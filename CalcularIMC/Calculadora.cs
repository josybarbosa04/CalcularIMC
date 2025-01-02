using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    public class Calculadora
    {
        private double peso;
        private double altura;
        private double imc;
        public String classificacao;

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Imc
        {
            get { return imc; }
            set { imc = value; }
        }

        public String Classificacao
        {
            get { return classificacao; }
            set { classificacao = value; }
        }

        private void CalculoIMC()
        {
            double altQuadrado = (Altura * Altura);
            Imc = Peso / altQuadrado;
        }

        private void ClassificaObesidade()
        {
            if (Imc <= 18.5)
            {
                Classificacao = "Você está abaixo do peso!";
            } else if (Imc > 18.5 && Imc < 24.99)
            {
                Classificacao = "Você está no peso ideal!";
            } else if (Imc > 24.99 && Imc < 29.99)
            {
                Classificacao = "Você está acima do peso!";
            } else if (Imc > 29.99)
            {
                Classificacao = "Você está obeso!!!\nA obesidade é uma doença. Procure um profissional!";
            }
        }

    }
}
