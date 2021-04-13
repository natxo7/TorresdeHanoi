using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero =4;


            Disco disco5 = new Disco(5);//inicializamos disco con valor 3
            Disco disco4 = new Disco(4);//inicializamos disco con valor 3
            Disco disco3 = new Disco(3);//inicializamos disco con valor 3
            Disco disco2 = new Disco(2);//inicializamos disco con valor 2
            Disco disco1 = new Disco(1);//inicializamos disco con valor 1
            
            //------------------------------------------------------------------------------------
            Pila ini = new Pila();//inicilizamos pila ini 
            ini.nombre = "INI";//le ponemos un nombre a la pila

            Pila aux = new Pila();//inicializamos la pila aux
            aux.nombre = "AUX";//le ponemos un nombre a la pila

            Pila fin = new Pila();//inicializamos la pila fin
            fin.nombre = "FIN";//le ponemos un nombre a la pila
                               //-------------------------------------------------------------------------------------
            ini.push(disco5);
            ini.push(disco4);
            ini.push(disco3);
            ini.push(disco2);
            ini.push(disco1);
            //-------------------------------------------------------------------------------------
            //NUMERO DE DISCOS
            int discos = 5;


            //Hanaoi()
            Hanoi sol = new Hanoi();
            //-------------------------------------------------------------------------------------
            //PRUEVA ITERATIVO
            //-------------------------------------------------------------------------------------
            int solucion = sol.iterativo(discos, ini, fin, aux);
            //-------------------------------------------------------------------------------------

            Console.WriteLine("Los movimientos finales son" + solucion);
            Console.WriteLine("la pila final:");
            fin.impr();
            Console.ReadKey();
        }
    }
}
