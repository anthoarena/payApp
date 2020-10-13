using Newtonsoft.Json;
using PaymentDomain.DomainObject;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PaymentAPITestProject {
    public class TestPaymentAPI : IClassFixture<AppTestFixture> {

        private readonly AppTestFixture _fixture;
        private readonly HttpClient _client;


        public TestPaymentAPI(AppTestFixture fixture) {
            _fixture = fixture;
            _client = fixture.CreateClient();
        }

        [Fact]
        public async Task Get_ProductTypes_ValidInputSuccess() {
          
            //Act
            var response = await _client.GetAsync($"api/payment/producttypes");

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);         
     
        }


        [Fact]
        public async Task POST_ProcessPayment_ValidInputSuccess() {
            // Arrange
            var payment = new PaymentDTO() { };

            var httpContent = new StringContent(JsonConvert.SerializeObject(payment), Encoding.UTF8, "application/json");

            //Act
            var response = await _client.PostAsync("api/payment", httpContent);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
    }
}
