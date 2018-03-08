using System;
using Xunit;
using Certifications.API.Controllers;
using System.Collections.Generic;
using System.Linq;

namespace Certifications.Test.API
{
    public class ControllerTests
    {
        [Fact]
        public void ValuesControllerTest()
        {
            ValuesController controller = new ValuesController();
            var expected = "value1";
            var actual = controller.Get().FirstOrDefault();

            Assert.Equal(expected, actual);
        }
    }
}
