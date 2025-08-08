using System;
class ParouImpar
{
  static void Main()
  {	
	int numero;
	
	Console.WriteLine("digite um numero");
	numero = int.Parse(Console.ReadLine());
	
	if(numero%2 == 0)
		Console.WriteLine("o numero e´ par");
	
	else 
		Console.WriteLine("o numero e impar");
		
  }
  
} 