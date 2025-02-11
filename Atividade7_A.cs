using System;

namespace att01
{
	class Program
	{
		public static void Main()
		{
			int[,] tabela = new int[3,3];
			
			for (int lin = 0; lin < 3; lin++) {

				for (int col = 0; col < 3; col++) {
					
					Console.WriteLine("Digite o numero do elemento[{0}, {1}]", lin, col);
					int	numero = int.Parse(Console.ReadLine());
					tabela[lin, col] = numero;
				}
			}
			
			Console.WriteLine("\n\rMATRIZ 3x3");
			
			for (int lin = 0; lin < 3; lin++) {
				
				Console.Write("\n\r ");
				
				for (int col = 0; col < 3; col++) {
														
					Console.Write(tabela[lin, col] + " ");
					
				}
			}
			
			Console.WriteLine("\r\nAperte qualquer tecla para continuar...");
			Console.ReadKey(true);
		}
	}
}
