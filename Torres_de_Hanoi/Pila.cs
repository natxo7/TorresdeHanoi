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
        
        public int Top { get; set; }
       
        /*ELEGIMOS TIPO LIST PORQUE NO HAY QUE DECIRLE EL TAMANYO*/
        public List<Disco> elementos { get; set; }
        /*CONSTRUCTOR*/
        public Pila()
        {

        }
        /*METODOS A IMPLEMENTAR*/


        public void push(Disco d)
        {
            elementos.Add(d);
        }

        public Disco pop()
        {
            Disco variable;//variable tipo disco
            variable = elementos[elementos.Count-1];//donde guardamos en la variable el ultimo elemento de la lista
            elementos.RemoveAt(elementos.Count - 1);
            return variable;
        }                

        public bool isEmpty()
        {
            if (elementos.Count == 0)
            {
                return true;
            }
            return false;
        }

    }
}
