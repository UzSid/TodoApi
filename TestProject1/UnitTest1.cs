using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApi;

namespace TestTodoApi
{
    [TestClass]
    public class TestWeatherForecast
    {
        [TestMethod]
        public void TestDate()
        {
            var tempc = new WeatherForecast();
            Assert.IsNotNull(tempc.Date);
        }

        [TestMethod]
        public void TestTemperatureC()
        {
            var tempc = new WeatherForecast();
            Assert.IsNotNull(tempc.TemperatureC);
        }

        [TestMethod]
        public void TestTemperatureF()
        {
            var tempc = new WeatherForecast();
            Assert.IsNotNull(tempc.TemperatureF);
        }

        [TestMethod]
        public void TestSummary()
        {
            var tempc = new WeatherForecast();
            Assert.IsNotNull(tempc.Summary);
        }
    }
}