using System;

class HelloWorld {
  static void Main() {
    int[] OrginalArray = {1, 2, 3, 4, 5};
    int[] DeepCopy = new int[OrginalArray.Length];
    
    Array.Copy(OrginalArray, DeepCopy, OrginalArray.Length);
   
    Console.WriteLine("Original Array is:");
    DisplayInfo(OrginalArray);
    
    Console.WriteLine("Deep Copy Array is:");
    DisplayInfo(DeepCopy);
    
    DeepCopy[0] = 65;
    Console.WriteLine("Original Array is:");
    DisplayInfo(OrginalArray);
    
    Console.WriteLine("Deep Copy Array is:");
    DisplayInfo(DeepCopy);
  }
  
  public static void DisplayInfo(int[] numbers) {
    for(int i = 0; i < numbers.Length; i++) {
      Console.Write($"{numbers[i]} ");
    }
    Console.WriteLine();
  }
}
