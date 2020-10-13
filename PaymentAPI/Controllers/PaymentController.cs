using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentDomain.DomainObject;
using PaymentDomain.Interfaces;
using PaymentInfrastructure.Services;

namespace PaymentAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase {

        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService) {
            _paymentService = paymentService;
        }


        [HttpGet]
        [Route("producttypes")]
        public IActionResult ProductTypes() {
            var response =_paymentService.GetProductTypes();
            return Ok(response);
        }


        /// <summary>
        /// Create Payment for All products
        /// </summary>
        /// <param name="payment"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Payment([FromBody] PaymentDTO payment) {
            if (payment == null)
                return BadRequest("Input is null");

            // FIeld Validation --- 

            _paymentService.ProcessPayment(payment);

             return Ok("Payment processed");
        }
    }
}
