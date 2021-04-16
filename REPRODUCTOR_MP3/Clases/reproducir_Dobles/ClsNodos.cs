using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPRODUCTOR_MP3.Clases.reproducir_Dobles
{
    class ClsNodos
    {
        public string dato;
        public ClsNodos adelante;
        public ClsNodos atras;

        public string getDato()
        {
            return dato;
        }

        public ClsNodos(string entrada)
        {

            this.dato = entrada;
            this.adelante = atras = null;
        }

    }
}
