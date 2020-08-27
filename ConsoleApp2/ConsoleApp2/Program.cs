using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        //palabra a recibir
        private String S;
        //cantidad total
        private int h1,o1,l,a1;
        private String temporal,temp_1,l1,l2,l3,l4;
        int inicio, fin, letras, fin_temp;
        public String tx1,tx2,tx3,tx4 = "";
        public void validar()
        {
            Console.Write("Ingrese la cadena de texto: ");
            S = Console.ReadLine();
          
            inicio = S.IndexOf(S);
            fin = S.Length;
            int i;
            l1 = "h";
            l2 = "o";
            l3 = "l";
            l4 = "a";

            temporal = l1 + l2 + l3 + l4;

            for (i=0; i < fin; i++)
            {


                temp_1 = char.ToString(S[i]);
               // Console.WriteLine(temp_1);

                
               
                if (string.Compare(temp_1, l1)==0)
                {
                    h1 ++;                 
                    //Console.WriteLine("bien");
                }
                
                else if(string.Compare(temp_1,l2)==0)
                {
                    o1++;
                    //Console.WriteLine("bien");
                }
                else if (string.Compare(temp_1, l3) == 0)
                {
                    l++;
                    //Console.WriteLine("bien");
                }
                else if (string.Compare(temp_1, l4) == 0)
                {
                    a1++;
                   // Console.WriteLine("bien");
                }
                else
                {
                    Console.WriteLine("Verifique");
                }
                

            }
            Console.WriteLine(S);
            
            //Console.WriteLine("numero de veces H:" + h1);
           // Console.WriteLine("numero de veces o:" + o1);
           // Console.WriteLine("numero de veces o:" + l);
           // Console.WriteLine("numero de veces o:" + a1);
            tx1 = S.Remove(1, h1-1);
            Console.WriteLine("primer paso: " + tx1);
            tx2 = tx1.Remove(2, o1-1);
            Console.WriteLine("segundo paso: " + tx2);
            tx3 = tx2.Remove(3, l-1);
            Console.WriteLine("Tercer Paso: " + tx3);
            tx4 = tx3.Remove(4, a1 - 1);
            Console.WriteLine("final: " + tx4);

            if (Equals(tx4, temporal))
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("false");
            }

            
        }

       

            static void Main(string[] args)
        {
            Program program1 = new Program();

            program1.validar();
        }
    }
}
