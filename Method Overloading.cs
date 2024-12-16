using System;
class HelloWorld {
  static void Main() {
   Mishon m1 =new Mishon();
   m1.Display();
   m1.Display(10);
   m1.Display(30,20);
  }
  
  class Mishon{
      public void Display(){
          Console.WriteLine("No parameter called:");
      }
      public void Display(int a){
          Console.WriteLine($"Displaying Method in one parameter: {a}");
      }
      public void Display(int a,int b){
          Console.WriteLine($"Displaying Method in two parameter {a},{b}");
      }
  }
}
