using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal class Cane : Animale
    {
        static string verso = "BAU BAU";
        static string cosaMangia = "Carne";
        public Cane() : base(verso, cosaMangia) { }
    }
}
