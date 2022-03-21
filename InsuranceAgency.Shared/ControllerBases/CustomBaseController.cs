using InsuranceAgency.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceAgency.Shared.ControllerBases
{
    public class CustomBaseController : ControllerBase
    {
        public static IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
