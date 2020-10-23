using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xunit;

using WebNet.Models;

namespace Test {
  public class UnitTest {
    [Fact]
    public void TestSayHello() {
     Employe employee = new Employe();

      employee.Name = "Christian";
      var returnValue = employee.SayHello();

      Assert.Equal("hello Christian", returnValue);
    }
  }
}
