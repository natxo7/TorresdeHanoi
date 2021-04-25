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


            /*

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
                        int solucion = sol.recursivo(discos, ini, fin, aux);
                        //-------------------------------------------------------------------------------------

                        Console.WriteLine("Los movimientos finales son" + solucion);
                        Console.WriteLine("la pila final:");
                        fin.impr();
                        Console.ReadKey();

            */


            Console.WriteLine("¿Qué algoritmo prefieres utilizar? Pulsa 1 para usar el iterativo o 2 para usar el recursivo?");
            int algoritmoUtilizado = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuántos discos quieres insertar?");
            int numDiscos =Int32.Parse(Console.ReadLine());
            List<Disco> discoFinales = new List<Disco>();
            if (numDiscos == 0)
            {
                Console.WriteLine("¿Realmente quisiste escribir 0? Con el numero 0 es imposible de realizar.");
                Console.ReadKey();
            }
            if (numDiscos < 0)
            {
                Console.WriteLine("¿Realmente quisiste escribir un número negativo? Si ya es imposible repartir algo inexistente, imagínate algo negativo, vuelva a intentarlo.");
                Console.ReadKey();
            }
            if (numDiscos > 0)
            {
                Pila ini = new Pila();
                Pila aux = new Pila();
                Pila fin = new Pila();

                for (int i = numDiscos; i > 0; i--)
                {
                   
                    //discoFinales.Add(new Disco(i));
                    ini.push(new Disco(i));

                   
                   
                }
           
                Hanoi torres_hanoi = new Hanoi();
                if (algoritmoUtilizado == 1) // si penemos un 1 en pantalla
                {
                    
                    int sol = torres_hanoi.iterativo(numDiscos, ini, fin, aux); // Llamamos  iterativo
                    Console.WriteLine(sol); // mostramos la sol 
                }
                if (algoritmoUtilizado == 2) // Si la respuesta del usuario al principio es dos
                {
                    
                    int sol = torres_hanoi.recursivo(numDiscos, ini, fin, aux); // Llamamos recursivo
                    Console.WriteLine(sol); //  mostramos la sol 
                }
                Console.ReadKey();
            }
        }
    }
}
