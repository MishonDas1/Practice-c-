using System;

namespace NewFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] BookNames={"Book1","Book2","Book3","Book4","Book5"};
            string[] BookGener={"Gener1","Gener2","Gener3","Gener4","Gener5"};
            string[] BookWriter={"Writer1","Writer2","Writer3","Writer4","Writer5"};
            double[] BookPrice={100,200,300,400,500};
            Book[] books=new Book[5];
            for(int i=0;i<5;i++){
                books[i]=new Book(BookNames[i],BookGener[i],BookWriter[i],BookPrice[i]);
                books[i].Method();
            }

        }
    }


    class Book{
        public string name;
        public string gener;
        public string writer;
        private double price;

        public Book(string name,string gener,string writer,double price){
            this.name=name;
            this.gener=gener;
            this.writer=writer;
            this.price=price;
        }

        public void Method(){
            Console.WriteLine($"Book name is :{this.name} Book Writer name is:{this.writer},Book price is :{this.price} and gener is :{this.gener}");
        }
    }
}


