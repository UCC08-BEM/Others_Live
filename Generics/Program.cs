using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //Bazen tasarlanılan metot class parametreler(değişgenler) belirli bir tip olarak değilde bir şablon yapısı dahilinde çalışmayı sağlayan bir yapı. 


    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic yöntemini kullanarak...

            // Generic olarak tanımladığım classı int olarak nesnelendiriyorum.
            Example<int> examp_1 = new Example<int>(); // Generic yapıda tanımlanmış bir classın int olarak kullanılabilmesi...
                                                       // 
            examp_1.example_1 = 20;
            examp_1.example_2(200);

            // string olarak tanımlıyorum
            Example<string> examp_2 = new Example<string>();

            examp_2.example_1 = "Ümit KARAÇİVİ";

            examp_2.example_2("C#");

            // burada da double olarak ayarlıyorum
            Example<double> examp_3 = new Example<double>();

            examp_3.example_1 = 100.5;
            examp_3.example_2(151.25);

            Console.ReadKey();
        }

        // Normal olarak...
        public class Example
        {
            public int example_1;

            public void example_2(int parameter)
            { 
            
            }

        }

        // Generic denilen yapıyı kullandığımızda değişgenler,parametreler ve metotların geri dönüş tipleri gibi durumları o sınıftan bir nesne  oluştururken belirlenebilmesi

        public class Example<T> // T -- > Type
        {
            public T example_1; // sadece bir değişgen

            public void example_2(T parameter) // birşeyler yapan bir metot
            {
                Console.WriteLine("Parametre değeri :" + parameter + "\n");
            }
        }
    }
}
