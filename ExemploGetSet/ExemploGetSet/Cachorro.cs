using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Cachorro
    {
        private string Nome;
        public string Raca;
        public double Peso;
        private double Altura;

        // set tem como objetivo guardar determinada informação

        public void SetNome(string nome)
        {
            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letrras");
            }

            if (nome.Count() > 40)
            {
                throw new Exception("Nome deve conter no máximo 40 caracteres");
            }
            Nome = nome;
        }

        public void SetAltura(double altura)
        {
            if (Altura <= 0)
            {
                throw new Exception("Altura deve ser maior que 0");
            }

            if (Altura > 2)
            {
                throw new Exception("Altura deve ser menor que 2 metros");
            }
                Altura = altura;
        }


        public void SetPeso(double peso)
        {
            if (Peso <= 0)
            {
                throw new Exception("Peso deve ser maior que 0");
            }

            if (Peso > 150)
            {
                throw new Exception("Peso deve ser menor que 151");
            }

            Peso = peso;
        }

        public void SetRaca(string raca)
        {
            if (Raca.Length < 3)
            {
                throw new Exception("Raça deve conter mais de 2 caracteres");
            }

            if (Raca.Length > 40)
            {
                throw new Exception("Raça deve conter 40 caracteres ou menos");
            }

            Raca = raca;
        }

         //peso min: 0.1  max: 150
        // raca min: 3    max: 40

    }
}
