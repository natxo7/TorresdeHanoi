using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        //PARA EL TAMANYO
        public int Size { get; set; }

    
      

        /*ELEGIMOS TIPO LIST PORQUE NO HAY QUE DECIRLE EL TAMANYO*/
        public List<Disco> elementos { get; set; }
        //para que puedas ver el nombre de cada uno
        public string nombre { get; set; }
        /*CONSTRUCTOR*/
        public Pila()
        {
            elementos = new List<Disco>();//inicializamos elementos
            Size = 0;
        }
        /*METODOS A IMPLEMENTAR*/


        public void push(Disco d)//para añadir un disco a la pila
        {
            elementos.Add(d);
            Size++;
            
        }

        public Disco pop()//para quitar un disco
        {
            if (isEmpty() == true)
            {
                return null;
            }
            else
            {
                //variable tipo disco
                Disco variable = elementos[elementos.Count - 1];//donde guardamos en la variable el ultimo elemento de la lista
                elementos.RemoveAt(elementos.Count - 1);
                Size--;
               
                return variable;
            }
           
        }
        

        public bool isEmpty()//si esta vacio 
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }
        //metodo que he utilizado para imprimir para poder ver donde hay un error
        public void impr()
        {
            if (Size == 0)
            {
                Console.WriteLine("0");
                return;
            }
            foreach (Disco h in elementos)
            {
                Console.WriteLine(h.Valor);
            }
        }

    }
}
