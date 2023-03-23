using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    public class Delfino : Animale, INuota
    {
        static string verso = "IIIIIII IIIIIII";
        static string cosaMangia = "Pesce";
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
        public void Nuota() => Console.WriteLine("Sto nuotando!!");
    }
}
