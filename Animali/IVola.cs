using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal interface IVola
    {
        public void Vola() => Console.WriteLine("Sto volando!!");
    }
}
