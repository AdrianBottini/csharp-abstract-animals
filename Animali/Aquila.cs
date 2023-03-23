using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals.Animali
{
    internal class Aquila : Animale 
    {
        static string verso = "QUII QUII";
        static string cosaMangia = "Carne";
        public Aquila() : base(verso, cosaMangia) { }
    }
}
