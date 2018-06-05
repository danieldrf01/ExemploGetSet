using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dogao = new Cachorro();
            //set tem como objetivo guardar determinada informação

            dogao.SetNome("aaaaaaaaaaaaaaaaa");
            dogao.SetAltura(2);
            dogao.SetPeso (80);
            dogao.SetRaca ("Pinscher");

            Console.WriteLine(dogao.GetNome());
            Console.WriteLine(dogao.GetAltura());
            Console.WriteLine(dogao.GetPeso());
            Console.WriteLine(dogao.GetRaca());
        }
    }
}
