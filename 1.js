using System;
class Mishon{
    public static void Main(string[] args){
       Sobi m1 = new Sobi("Mishon Das",32,"Hatita","Noakhali");
       m1.Method();
    }
}

public class Arnab{
    public string name ;
    public int age;
    
}

public class Sobi:Arnab{

    public Sobi (string n,int a,string p,string ad){
        name =n;
        age = a;
        place =p;
        adress =ad;
    }
   public string place ;
    public string adress;
    public void Method (){
        Console.WriteLine($"Person Name is {name} and age is {age} {place} {adress}");
    }

}
