using System;
using EmployeeFrameWork;

namespace WebNet.Models {
  public class Employe {
   Employee employee = new Employee();
        
    public string SayHello(string name) {

      employee.Name = name;
      return employee.SayHello();
      
    }
  }
}