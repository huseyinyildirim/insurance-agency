using InsuranceAgency.Business.Services;
using InsuranceAgency.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceAgency.WebUI.Controllers
{
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OfferQueryInput offerQueryInput)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = _offerService.GetAllByTCId(offerQueryInput.TCId);

            ViewData["Offers"] = result.Data;

            return View(offerQueryInput);
        }
    }
}
