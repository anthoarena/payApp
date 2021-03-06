﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using PaymentAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentAPITestProject {
    public class AppTestFixture : WebApplicationFactory<Startup> {

        protected override IHostBuilder CreateHostBuilder() {
            var builder = Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>().UseTestServer();

                })
                .ConfigureAppConfiguration((hostingContext, config) => {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
                });


            return builder;

        }
    }
}

