using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal interface INuota
    {
        public void Nuota() => Console.WriteLine("Sto nuotando!!");
    }
}
