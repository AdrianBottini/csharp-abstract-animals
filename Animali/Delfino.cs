using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal class Delfino : Animale
    {
        static string verso = "IIIIIII IIIIIII";
        static string cosaMangia = "Pesce";
        public Delfino() : base(verso, cosaMangia) { }
    }
}
