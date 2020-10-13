using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase {

        public PaymentController() {

        }


        [HttpGet("{id}")]
        public IActionResult Payment(int id) {
            return Ok(id);
        }

    }
}
