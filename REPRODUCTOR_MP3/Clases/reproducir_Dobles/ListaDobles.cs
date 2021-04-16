using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPRODUCTOR_MP3.Clases.reproducir_Dobles
{
    class ListaDobles
    {

        public ClsNodos primero;
        public ClsNodos ultimo;
        public int tam;

        public ListaDobles()
        {
            primero = null;
            ultimo = null;
            tam = 0;
        }

        public bool IsEmpty()
        {
            if (primero == null && ultimo == null)
            {
                MessageBox.Show("NO SE A INSERTADO NI UNA CANCIÓN");
                return true;
            }
            else
            {
                MessageBox.Show("SI HAY CANCIONES PARA PODER ELIMINAR");
                return false;
            }
        }

        public ClsNodos buscarPosicion(int posicion)
        {
            ClsNodos indice;
            int i;
            if (posicion < 0)
            {
                return null;
            }
            indice = primero;
            for (i = 1; (i < posicion) && (indice != null); i++)
            {
                indice = indice.adelante;
            }
            return indice;

        }

        //inserta dobles
        public void InsertarNodo(String name)
        {
            ClsNodos nuevo;
            nuevo = new ClsNodos(name);
            if (primero == null)
            {
                primero = nuevo;
                primero.adelante = null;
                primero.atras = null;
                ultimo = primero;
            }
            else
            {
                ultimo.adelante = nuevo;
                nuevo.adelante = null;
                nuevo.atras = ultimo;
                ultimo = nuevo;

            }
            tam++;
        }


        public ListaDobles eliminarNodos(string entrada)
        {
            ClsNodos actual = new ClsNodos(entrada);
            actual = primero;
            ClsNodos anterior = new ClsNodos(entrada);
            anterior = null;
            bool encontrado = false;
            while(actual!=null && encontrado == false)
            {
                if(actual.dato == entrada)
                {
                    if (actual == primero)//elimino la primer cancion
                    {
                        primero = primero.adelante;
                        primero.atras = null;

                    }else if(actual==ultimo)//elimino la ultima cancion
                    {
                        anterior.adelante = null;
                        ultimo = anterior;
                    }
                    else//elimino cualquier cancion
                    {
                        anterior.adelante = actual.adelante;
                        actual.adelante.atras = anterior;
                    }
                    MessageBox.Show("CANCION ELIMINADA");
                    tam--;
                    encontrado = true;
                }
                anterior = actual;
                actual = actual.adelante;
            }
            if(!encontrado)
            {
                MessageBox.Show("CANCION NO ENCONTRADA");
            }

            return this;
        }

        public ListaDobles insertarcabezaLista(string entrada)
        {
            ClsNodos nuevo;
            nuevo = new ClsNodos(entrada);
            nuevo.adelante = primero;

            if (primero != null)
            {
                primero.atras = nuevo;
            }
            primero = nuevo;
            tam++;
            return this;
        }


        public void eliminarDoble(string entrada)
        {
            ClsNodos actual = new ClsNodos(entrada);
            actual = primero;
            //Nodos open = buscarPosicion(entrada);
            bool encontrado = false;
            //bucle de busqueda

            while ((actual != null) && (!encontrado))
            {
                encontrado = actual.dato == entrada;
                if (!encontrado)
                {
                    actual = actual.adelante;

                }
            }
            //enlace del nodo anterior con el siguiente

            if (actual != null)
            {
                //distinguir entre nodo cabeza del resto de la lista
                if (actual == primero)
                {
                    primero = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)///no es el ultimo nodo
                {
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else//ultimo nodo
                {
                    actual.atras.adelante = null;

                }
                tam--;
                actual = null;
            }
        }




        public ClsNodos get_cancion(int index)
        {
            if (index < 0 || index >= tam)
            {
                return null;
            }

            int n = 0;
            ClsNodos aux = primero;
            while (n != index)
            {
                aux = aux.adelante;
                n++;
            }

            return aux;
        }




        public void eliminarDoble(int entrada)
        {
            ClsNodos actual;
            actual = primero;
            ClsNodos open = buscarPosicion(entrada);
            bool encontrado = false;
            //bucle de busqueda

            while ((actual != null) && (!encontrado))
            {
                encontrado = actual.dato == open.dato;
                if (!encontrado)
                {
                    actual = actual.adelante;

                }
            }
            //enlace del nodo anterior con el siguiente

            if (actual != null)
            {
                //distinguir entre nodo cabeza del resto de la lista
                if (actual == primero)
                {
                    primero = actual.adelante;
                    if (actual.adelante != null)
                    {
                        actual.adelante.atras = null;
                    }
                }
                else if (actual.adelante != null)///no es el ultimo nodo
                {
                    actual.atras.adelante = actual.adelante;
                    actual.adelante.atras = actual.atras;
                }
                else//ultimo nodo
                {
                    actual.atras.adelante = null;

                }
                tam--;
                actual = null;
            }
        }






        public bool buscar(String ruta)
        {
            ClsNodos aux = primero;

            while (aux != null)
            {
                if (aux.dato.Equals(ruta))
                {
                    return true;
                }
                aux = aux.adelante;
            }
            return false;
        }
        public void transversa()
        {
            ClsNodos n = primero;
            string dt;


            while (n != null)
            {
                dt = n.dato;
                n = n.adelante;
                this.tam = this.tam + 1;//Obtenemos el tamaño de la Lista
            }
        }


        public String[] vizualizar()
        {
            transversa();
            string[] datos = new string[this.tam];
            ClsNodos n;
            n = primero;
            int cont = 0;

            while (n != null)
            {
                string dt;
                dt = n.dato;
                datos[cont] = dt;
                n = n.adelante;
                cont++;
            }
            return datos;
        }

    }
}
