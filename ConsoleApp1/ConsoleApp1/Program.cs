using System;

namespace ConsoleApp1
{
    class Program
    {
        private String Texto;
        private int canti_palabras;
        private String temporal;
        int inicio, fin,letras,fin_temp;
        public String tx="";
            public void validar() {
                Console.Write("Ingrese la cadena de texto: ");
                Texto = Console.ReadLine();
            canti_palabras = 3;
                 inicio = Texto.IndexOf(Texto);
           
                 fin = Texto.Length;
            letras = fin / canti_palabras;
            fin_temp = fin- letras;
            temporal = Texto.Remove(inicio, fin_temp);





        }

             public void imprimir() {
            Console.WriteLine(" la plabra completa es :" + Texto);
           

             Console.WriteLine("Salida: " + temporal.Length);
                
             }

        static void Main(string[] args)
        {

            Program programa1 = new Program();

            programa1.validar();
            programa1.imprimir();
            Console.ReadKey();
        }
    }
}
