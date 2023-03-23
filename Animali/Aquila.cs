using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    public class Aquila : Animale, IVola 
    { public override void Verso()
        {  Console.WriteLine(GetVerso());
        }
        public override void Mangia()
        {
            Console.WriteLine(GetCosaMangia());
        }
        public override string GetCosaMangia()
        {
            return "Carne";
        }
        public override string GetVerso()
        {
            return "UII UII";
        }
        public void Vola() => Console.WriteLine("Sto volando!!");
    }
}
