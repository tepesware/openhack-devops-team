using System;
using Xunit;
using poi.Models;

namespace UnitTests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            Assert.Equal("Buenos dias amigos!", new Healthcheck().Message);
            Assert.Equal("Wszystko w porządku!", new Healthcheck().Status);
        }
    }
}
