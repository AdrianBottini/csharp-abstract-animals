using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal class PulcinellaDiMare : Animale, INuota, IVola
    {
        static string verso = "PULCINELLA PULCINELLA";
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
        public void Vola() => Console.WriteLine("Sto volando!!" + verso);
        public void Nuota() => Console.WriteLine("Sto nuotando!!" + verso);
    }
}
