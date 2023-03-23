using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    public class PulcinellaDiMare : Animale, INuota, IVola
    {  public override void Verso()
        { Console.WriteLine(GetVerso());
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
            return "PULCINELLA PULCINELLA";
        }
        public void Vola() => Console.WriteLine("Sto volando!!");
        public void Nuota() => Console.WriteLine("Sto nuotando!!");
    }
}
