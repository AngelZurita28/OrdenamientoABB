using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenamientoABB
{
    internal class ABB
    {
        private Nodo raiz { get; set; }

        public ABB()
        { raiz = null; }

        public void Insertar(int nuevoDato, bool invertido)
        { 
            if (invertido)
            {
                raiz = InsertarInvertido(raiz, nuevoDato);
                return;
            }
            raiz = Insertar(raiz, nuevoDato);
        }

        private Nodo Insertar(Nodo raiz, int nuevoDato)
        {
            if (raiz == null)
            {
                raiz = new Nodo(nuevoDato);
                return raiz;
            }
            if (raiz.dato > nuevoDato)
            {
                raiz.izquierdo = Insertar(raiz.izquierdo, nuevoDato);
                return raiz;
            }
            if (raiz.dato < nuevoDato)
            {
                raiz.derecho = Insertar(raiz.derecho, nuevoDato);
                return raiz;
            }
            return raiz;
        }
        private Nodo InsertarInvertido(Nodo raiz, int nuevoDato)
        {
            if (raiz == null)
            {
                raiz = new Nodo(nuevoDato);
                return raiz;
            }
            if (raiz.dato < nuevoDato)
            {
                raiz.izquierdo = Insertar(raiz.derecho, nuevoDato);
                return raiz;
            }
            if (raiz.dato > nuevoDato)
            {
                raiz.derecho = Insertar(raiz.izquierdo, nuevoDato);
                return raiz;
            }
            return raiz;
        }

        //Ordenamiento en In-Orden
        public string Inorden()
        {
            string cadena = "";
            return Inorden(this.raiz, ref cadena);
        }

        private string Inorden(Nodo rama, ref string cadena)
        {
            if (rama != null)
            {
                Inorden(rama.izquierdo, ref cadena);
                cadena += ", " + rama.dato;
                Inorden(rama.derecho, ref cadena);
            }
            return cadena;
        }
    }
}
