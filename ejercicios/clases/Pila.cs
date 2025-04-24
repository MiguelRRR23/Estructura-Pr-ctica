using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios.clases
{
    class Pila
    {
        private Nodo cima = null;
        private int cantidad = 0;

        public void push(string nom)//Se usa Push para apilar
        {
            Nodo nuevo = new Nodo();
            nuevo.Nombre = nom;

            nuevo.Siguiente = cima;
            cima = nuevo;
            cantidad++;
        }

        public void mostrar(ListBox list)
        {
            Nodo actual = cima;

            while(actual!=null)
            {
                list.Items.Add(actual.Nombre);
                actual = actual.Siguiente;
            }
        }

        public String Pop()//Para desapilar se usa Pop
        {
            if(cima != null)
            {
                string nom = cima.Nombre;
                cima = cima.Siguiente;
                cantidad--;
                return nom;
            }
            return null;
        }

        public string Peek()
        {
            if (cima != null)
            {
                return cima.Nombre;
            }
            return null;
        }

        public int Count()
        {
            return cantidad;
        }

        public void Clear()
        {
            cima = null;
            cantidad = 0;
           
        }
    }

}
