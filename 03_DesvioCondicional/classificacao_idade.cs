using System;
class idade
{
  static void Main()
  {	
  int idade;
	
	Console.WriteLine("digite sua idade");
	idade= int.Parse(Console.ReadLine());

	if(idade <=12)
		Console.WriteLine("vc é criança");
	
	else if(idade <=17)
		Console.WriteLine("vc é adolescente");
	
	else if(idade >=60)
		Console.WriteLine("vc é idoso");
		
    else
	{
		Console.WriteLine("vc é adulto");
  }
  }
}
  

	