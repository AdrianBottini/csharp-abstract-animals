using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
   public class Passerotto : Animale, IVola
    {         public override void Verso()
        {
            Console.WriteLine(GetVerso());
        }
        public override void Mangia()
        {
            Console.WriteLine(GetCosaMangia());
        }
        public override string GetCosaMangia()
        {
            return "Insetti";
        }
        public override string GetVerso()
        {
            return "CIP CIP";
        }
        public void Vola() => Console.WriteLine("Sto volando!!");
    }
}
