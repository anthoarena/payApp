using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult ProductTypes() {
            var response =_paymentService.GetProductTypes();
            return Ok(response);
        }

    }
}
