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
        public Passerotto() : base(verso, cosaMangia) { }
        public void Vola() => Console.WriteLine("Sto volando!!");
    }
}
