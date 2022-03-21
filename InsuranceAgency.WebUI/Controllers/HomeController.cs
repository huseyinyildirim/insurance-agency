using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using AutoMapper;
using InsuranceAgency.Business.Dtos;
using InsuranceAgency.Business.Services;
using InsuranceAgency.Provider.Providers;
using InsuranceAgency.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InsuranceAgency.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuotationService _quotationService;
        private readonly IMapper _mapper;
        private readonly IInsuranceProviderService _insuranceProviderService;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IOfferService _offerService;

        public HomeController(ILogger<HomeController> logger, IQuotationService quotationService, IMapper mapper, IInsuranceProviderService insuranceProviderService, IHttpClientFactory httpClientFactory, IOfferService offerService)
        {
            _logger = logger;
            _quotationService = quotationService;
            _mapper = mapper;
            _insuranceProviderService = insuranceProviderService;
            _httpClientFactory = httpClientFactory;
            _offerService = offerService;
        }

        public IActionResult Index()
        {
            var result = _insuranceProviderService.GetAll();

            ViewData["InsuranceProviders"] = result.Data;

            //ViewData["Offers"] = offers.Result.Data;

            return View();
        }

        [HttpPost]
        public IActionResult Index(QuotationCreateInput quotationCreateInput)
        {
            var result = _insuranceProviderService.GetAll();

            ViewData["InsuranceProviders"] = result.Data;

            if (!ModelState.IsValid)
            {
                return View();
            }

            var newData = _mapper.Map<QuotationCreateDto>(quotationCreateInput);
            newData.CreatedAt = DateTime.Now;
            _quotationService.Create(newData);

            List<OfferResult> offerResults = new List<OfferResult>();

            var providerQueryMap = _mapper.Map<ProviderQueryDto>(quotationCreateInput);

            ProviderService providerServiceAcibademSigorta = new(new AcibademSigortaProvider(_httpClientFactory));
            var resultAcibademSigorta = providerServiceAcibademSigorta.GetOffer(providerQueryMap);
            offerResults.Add(_mapper.Map<OfferResult>(resultAcibademSigorta.Data.data));
            _offerService.Create(_mapper.Map<OfferCreateDto>(resultAcibademSigorta.Data.data));

            ProviderService providerServiceAkSigorta = new(new AkSigortaProvider(_httpClientFactory));
            var resultAkSigorta = providerServiceAkSigorta.GetOffer(providerQueryMap);
            offerResults.Add(_mapper.Map<OfferResult>(resultAkSigorta.Data.data));
            _offerService.Create(_mapper.Map<OfferCreateDto>(resultAkSigorta.Data.data));

            ProviderService providerServiceAllianz = new(new AllianzProvider(_httpClientFactory));
            var resultAllianz = providerServiceAllianz.GetOffer(providerQueryMap);
            offerResults.Add(_mapper.Map<OfferResult>(resultAllianz.Data.data));
            _offerService.Create(_mapper.Map<OfferCreateDto>(resultAllianz.Data.data));

            ProviderService providerServiceAnadoluSigorta = new(new AnadoluSigortaProvider(_httpClientFactory));
            var resultAnadoluSigorta = providerServiceAnadoluSigorta.GetOffer(providerQueryMap);
            offerResults.Add(_mapper.Map<OfferResult>(resultAnadoluSigorta.Data.data));
            _offerService.Create(_mapper.Map<OfferCreateDto>(resultAnadoluSigorta.Data.data));

            ViewData["Offers"] = offerResults;

            /*var resultsss = providerService.GetOffer(new ProviderQueryDto()
            {
                Plate = "45ZN447",
                TCId = "62809043732",
                LicenseSerialCode = "AZ",
                LicenseSerialNo = "123456"
            });*/

            return View();
        }

        [HttpPost]
        public JsonResult License(LicenseQueryInput licenseQueryInput)
        {
            var quotationResult = _quotationService.GetByPlateTCId(licenseQueryInput.Plate, licenseQueryInput.TCId);

            return Json(quotationResult);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
