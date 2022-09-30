using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularPOOBootcampDIO.Net.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo {nome} pro Iphone");
        }
    }
}