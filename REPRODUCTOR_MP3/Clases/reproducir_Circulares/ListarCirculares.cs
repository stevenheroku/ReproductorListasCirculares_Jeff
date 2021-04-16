using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPRODUCTOR_MP3.Clases.reproducir_Circulares
{
    class ListarCirculares
    {

        public Nodo_C primero;
        public Nodo_C ultimo;
        public int tam;

        public ListarCirculares()
        {
            primero = null;
            ultimo = null;
            tam = 0;

        }

        public void InsertarNodoCircular(String name)
        {
            Nodo_C nuevo;
            nuevo = new Nodo_C(name);
            if (primero == null)
            {
                primero = nuevo;
                primero.enlace = primero;
                ultimo = primero;
            }
            else
            {
                ultimo.enlace = nuevo;
                nuevo.enlace = primero;
                ultimo = nuevo;

            }

            tam++;
        }


        public void eliminarCircularNodo(string entrada)
        {
            Nodo_C actual;
            actual = primero;
            while ((actual.enlace != primero) && !(actual.enlace.dato.Equals(entrada)))
            {
                if (!actual.enlace.dato.Equals(entrada))
                {
                    actual = actual.enlace;
                }
            }
        }

            public Nodo_C buscarPosicion(int posicion)
        {
            Nodo_C indice;
            int i;
            if (posicion < 0)
            {
                return null;
            }
            indice = primero;
            for (i = 1; (i < posicion) && (indice != null); i++)
            {
                indice = indice.enlace;
            }
            return indice;

        }

        public ListarCirculares insertarCircular(string entrada)
        {
            Nodo_C nuevo;
            nuevo = new Nodo_C(entrada);


            if (primero != null)//lista no vacia
            {
                nuevo.enlace = primero.enlace;
                primero.enlace = nuevo;

            }
            primero = nuevo;
            tam++;
            return this;
        }


        public void eliminarCircular(string entrada)
        {
            Nodo_C actual;
            actual = primero;
            while ((actual.enlace != primero) && !(actual.enlace.dato.Equals(entrada)))
            {
                if (!actual.enlace.dato.Equals(entrada))
                {
                    actual = actual.enlace;
                }
            }
            // Enlace de nodo anterior con el siguiente
            // si se ha encontrado el nodo.
            if (actual.enlace.dato.Equals(entrada))
            {
                Nodo_C p;
                p = actual.enlace; // Nodo a eliminar
                if (primero == primero.enlace) // Lista con un solo nodo
                {
                    primero = null;
                }
                else
                {
                    if (p == primero)
                    {
                        primero = actual; // Se borra el elemento referenciado por lc,   
                                          // el nuevo acceso a la lista es el anterior
                    }
                    actual.enlace = p.enlace;
                }
                tam--;
                p = null;
            }
        }

        public void eliminarNodoCircular(string entrada)
        {
            Nodo_C actual;
            actual = primero;
            while ((actual.enlace != primero) && !(actual.enlace.dato.Equals(entrada)))
            {
                if (!actual.enlace.dato.Equals(entrada))
                {
                    actual = actual.enlace;
                }
            }
            // Enlace de nodo anterior con el siguiente
            // si se ha encontrado el nodo.
            if (actual.enlace.dato.Equals(entrada))
            {
                Nodo_C p;
                p = actual.enlace; // Nodo a eliminar
                if (primero == primero.enlace) // Lista con un solo nodo
                {
                    primero = null;
                }
                else
                {
                    if (p == primero)
                    {
                        primero = actual; // Se borra el elemento referenciado por lc,   
                                          // el nuevo acceso a la lista es el anterior
                    }
                    actual.enlace = p.enlace;
                }
                tam--;
                p = null;
            }
        }

        public void transversa()
        {
            Nodo_C n = primero;
            string dt;


            while (n != null)
            {
                dt = n.dato;
                n = n.enlace;
                this.tam = this.tam + 1;//Obtenemos el tamaño de la Lista
            }
        }


        public String[] vizualizar()
        {
            transversa();
            string[] datos = new string[this.tam];
            Nodo_C n;
            n = primero;
            int cont = 0;

            while (n != null)
            {
                string dt;
                dt = n.dato;
                datos[cont] = dt;
                n = n.enlace;
                cont++;
            }
            return datos;
        }

        public void recorrer()
        {
            transversa();
            string[] datos = new string[this.tam];
            Nodo_C p;
            p = primero;
            int cont = 0;
            if (primero != null)
            {
                p = primero.enlace; // siguiente nodo al de acceso
                do
                {
                    MessageBox.Show("\t" + p.dato);
                    string dt;
                    dt = p.dato;
                    datos[cont] = dt;
                    p = p.enlace;
                    cont++;
                    p = p.enlace;
                } while (p != primero.enlace);
            }
            else
            {
                MessageBox.Show("\t Lista Circular vacía.");
            }
        }

    }
}
