using System;
class HelloWorld {
  static void Main() {
    int[] num = {1,2,3,4,5};
    int [] tum =num;
    Console.WriteLine("Orginal Array is:");
    
    foreach(var item in num){
        Console.Write($"{item} ");
    }
    Console.WriteLine();
    Console.WriteLine("Shallocopy is:");
    DisplayInfo(tum);
  }
  
  public static void DisplayInfo(int[] numbers){
      for(int i =0;i<numbers.Length;i++){
        Console.Write($"{i } ");
    }
      
  }
}
