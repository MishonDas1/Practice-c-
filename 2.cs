
using System;

namespace NewFinal
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] namey ={"Ami Manush","Tumi Manush","Seo Manush"};
           string [] writery ={"Mishon das","Mishon Kumar","Arnab","Sobita"};
           double [] pricey ={100,200,300,4000};

           Book[] b1 =new Book[10];
           for(int i =0;i<b1.Length;i++){
            b1[i]=new Book(namey[i],writery[i],pricey[i]);
            b1[i].Methood();
           }

        }
    }

    class Book{
        public string name;
        public string writer;
        private double price;

        /*Constructor  */

        public Book(string name,string writer,double price){
            this.name=name;
            this.writer =writer;
            this.price =price;

        }

        /*Methood */

        public void Methood(){
            Console.WriteLine($"Book Name is {this.name} and writer name is {this.writer} and its price is {this.price}");
        }
    }
}
