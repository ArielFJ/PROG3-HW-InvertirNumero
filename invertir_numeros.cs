using System;


namespace InvertirNumeros{

	class Inversion{
	
		static void Main(string[] args){
            Console.Clear();
            Console.Write("Introduzca un número para invertir: ");
            int t = ObtenerNumerosDeDosCifras();
            Console.WriteLine("El número invertido es " + InvertirNumero(t));
		}

        static int ObtenerNumerosDeDosCifras(){
            // Este método sólo acepta números y sólo un número de 2 cifras
            string n = "";
            while(n.Length < 2)
                if(Console.KeyAvailable){
                    char read = Console.ReadKey(true).KeyChar;
                    if(Char.IsDigit(read)){
                        n += read.ToString();
                        Console.Write(n[n.Length - 1]);
                    }
                }
            Console.WriteLine();
            return Convert.ToInt32(n);
        }

		static string InvertirNumero(int n){
            // Invierte el orden de los dígitos
            string nuevoN = "";
            if(n > 10){
                nuevoN += n.ToString()[1];
                nuevoN += n.ToString()[0];
            }else
                nuevoN += n.ToString()[0] + "0";
            
            return nuevoN;
		}

	}

}
