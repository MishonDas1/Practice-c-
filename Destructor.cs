using System;
class HelloWorld {
  static void Main() {
      Mishon b1=new Mishon();
    
  }
  
  class Mishon{
      public Mishon(){
          Console.WriteLine("Constructor is called,");
      }
      ~Mishon(){
          Console.WriteLine("Destructor is called.");
      }
  }
}
