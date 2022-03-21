using System;
using InsuranceAgency.ProviderAPI.Models;
using InsuranceAgency.Shared;
using InsuranceAgency.Shared.ControllerBases;
using InsuranceAgency.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceAgency.ProviderAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MapfreSigortaController : CustomBaseController
    {
        public MapfreSigortaController()
        {
        }

        [HttpPost]
        public IActionResult GetIndex(Quotation quotation)
        {
            Offer offer = new()
            {
                CompanyName = "Mapfre Sigorta",
                Logo = "https://cdnsnet.mncdn.com/facelift/assets/img/elements/companies-icon/mapfre-sigorta.png",
                Description = quotation.Plate + " için verdiğimiz tekliftir.",
                Amount = new Random().Next(5000, 7000),
                Plate = quotation.Plate
            };

            return CreateActionResultInstance(Response<Offer>.Success(offer, HttpStatusCode.OK));
        }
    }
}
