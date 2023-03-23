using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Animale
    {
        string verso;
        string cosaMangia;

        protected Animale(string verso, string cosaMangia)
        {
            this.verso = verso;
            this.cosaMangia = cosaMangia;
        }

        public void Dormi() => Console.WriteLine("zzzzzzzzz");
        public void Verso() => Console.WriteLine(verso);
        public void Mangia() => Console.WriteLine(cosaMangia);
    }
}
