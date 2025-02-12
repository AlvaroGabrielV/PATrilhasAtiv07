using System;

namespace PATrilhasAtiv07
{
	class Program
	{
		public static void Main(string[] args)
		{		
		Random rand = new Random();	
    	int [,] matriz10 = new int[10, 10];
    	int soma = 0;
    	
    	for (int i = 0; i < 10; i++) 
    	{
    		for (int j = 0; j < 10; j++) 
    		{
    			matriz10[i, j] = rand.Next(0, 10);
    			Console.Write(matriz10[i, j] + " |");
    			
    			soma += matriz10 [i, j];
    		}
    		Console.WriteLine();
    	}
    	Console.WriteLine("\n\rA soma de todos os elementos da matriz é {0}.", soma);
		Console.Write("\n\rPress any key to continue . . . ");
		Console.ReadKey(true);
		}
    
	}
  
}
