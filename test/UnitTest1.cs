using System;
using Xunit;
using api.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ValuesController controller = new ValuesController();
            var expected = "value1";
            var actual = controller.Get().FirstOrDefault();

            Assert.Equal(expected, actual);
        }
    }
}
