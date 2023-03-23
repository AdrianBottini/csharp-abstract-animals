using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{    public class Cane : Animale
    {
        static string verso = "BAU BAU";
        static string cosaMangia = "Carne";
        public override void Verso()
        {
            Console.WriteLine(GetVerso());
        }
        public override void Mangia()
        {
            Console.WriteLine(GetCosaMangia());
        }
        public override string GetCosaMangia()
        {
            return cosaMangia;
        }
        public override string GetVerso()
        {
            return verso;
        }
    }
}
