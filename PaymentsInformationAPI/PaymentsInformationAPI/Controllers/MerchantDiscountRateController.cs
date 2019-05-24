using Microsoft.AspNetCore.Mvc;
using PaymentsInformationAPI.Services.Interfaces;
using System;

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
            try
            {
                if (ModelState.IsValid)
                {
                    var mdr = MerchantDiscountRateService.Get();
                    if (mdr == null) return NotFound();
                    return Ok(mdr);
                }

                return BadRequest("Parâmetro inválido. Tente novamente.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}