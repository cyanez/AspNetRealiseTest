using System;


namespace WebNet.Models {
  public class Employe {
    private string name;
    public string Name {
      get => name;
      set => name = value;
    }

    public string SayHello() {
      return $"hello {name}";
    }
  }
}