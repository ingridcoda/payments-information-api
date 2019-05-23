using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentsInformationAPI.Services.Interfaces;

namespace PaymentsInformationAPI.Controllers
{
    [Route("mdr")]
    [ApiController]
    public class MerchantDiscountRateController : ControllerBase
    {
        private readonly IMerchantDiscountRateService MerchantDiscountRateService;

        public MerchantDiscountRateController(IMerchantDiscountRateService merchantDiscountRateService)
        {
            MerchantDiscountRateService = merchantDiscountRateService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            if (ModelState.IsValid)
            {
                var mdr = MerchantDiscountRateService.Get();
                if (mdr == null) return NotFound();
                return Ok(mdr);
            }

            return BadRequest("Parâmetro inválido. Tente novamente.");
        }
    }
}