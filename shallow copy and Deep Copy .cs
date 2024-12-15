using System;

class  Helloworld{
    
     static void Main(){
        /*int[] Array ={10,20,30,40,50,60,70};
        int[]  shallowCopy = Array;
        Console.WriteLine("Orginal Array is:");
        DisplayInfo(Array);
        Console.WriteLine("shallowCopy before modification:");
        DisplayInfo(shallowCopy);
        
        shallowCopy[0]=100;
        Console.WriteLine("Orginal Array after is:");
        DisplayInfo(Array);
        Console.WriteLine("shallowCopy after modification:");
        DisplayInfo(shallowCopy);*/
        
        
        int[] Array2 = {50, 60, 80, 99, 94, 96, 98, 78};
        int[] DeepCopy = new int[Array2.Length];
        Array.Copy(Array2, DeepCopy, Array2.Length);
        
        Console.WriteLine("Original Array2 is:");
        DisplayInfo(Array2);
        Console.WriteLine("DeepCopy before modification:");
        DisplayInfo(DeepCopy);
        
        DeepCopy[0] = 200;
        Console.WriteLine("Original Array2 after modification is:");
        DisplayInfo(Array2);
        Console.WriteLine("DeepCopy after modification:");
        DisplayInfo(DeepCopy);
        
        
    }
    
    public static void DisplayInfo(int[] numbers){
        for(int i =0;i<numbers.Length;i++){
            Console.Write($"{numbers[i]} ");
        }
        Console.WriteLine();
    }
}
