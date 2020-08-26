using System;

namespace ConsoleApp1
{
    class Program
    {
        private String Texto;
        private int periodo;
        private String temporal;
        int inicio, fin,repeticiones;
        public String tx="";
            public void validar() {
                Console.Write("Ingrese la cadena de texto: ");
                Texto = Console.ReadLine();
                 inicio = Texto.IndexOf(Texto);
                 fin = Texto.Length;
            periodo = 3;
            repeticiones = fin / periodo;
            fin = fin - repeticiones+1;
                temporal = Texto.Remove(inicio,fin);

        }

             public void imprimir() {
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
