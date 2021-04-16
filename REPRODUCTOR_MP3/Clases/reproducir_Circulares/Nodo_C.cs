using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_MP3.Clases.reproducir_Circulares
{
    class Nodo_C
    {

        public string dato;
        public Nodo_C enlace;

        public Nodo_C(string entrada)
        {
            dato = entrada;
            enlace = this;
        }


    }
}
