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
     
      var returnValue = employee.SayHello("Christian");

      Assert.Equal("hello Christian", returnValue);
    }
  }
}
