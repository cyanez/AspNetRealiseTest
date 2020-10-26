using System;
using EmployeeFrameWork;

namespace WebNet.Models {
  public class Employe {
    EmployeeFrameWork.Employee employee = new EmployeeFrameWork.Employee();
        
    public string SayHello(string name) {

      employee.Name = name;
      return employee.SayHello();
      
    }
  }
}