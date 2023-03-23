using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal class Passerotto : Animale, IVola
    {
        static string verso = "CIIIP CIIIIP";
        static string cosaMangia = "Insetti";
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
    }
}
