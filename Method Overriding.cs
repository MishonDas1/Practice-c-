using System;
class HelloWorld {
  static void Main() {
      Mishon m1=new Mishon();
      m1.show();
      
      Arnab m2 = new Arnab();
      m2.show();
      
      Mishon m3 = new Arnab();
      m3.show();
   
  }
  
  class Mishon{
      public virtual void  show(){
          Console.WriteLine("Hi how are you___ Its base class");
      }
  }
  class Arnab:Mishon{
      public override void show(){
          Console.WriteLine("I am fine________its derived class");
      }
  }
}
