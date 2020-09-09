using System;

class Pessoas{
	
  string Nome;
	int Idade;
	int Peso;
	double Altura;

	public void Envelhecimento (int IdadeAtual)
	{
		if (IdadeAtual > Idade) {
			Idade = IdadeAtual;
		}
		else {
			Console.WriteLine("Continua com a mesma idade!");
		}
		if (IdadeAtual < 21){
			Altura = ((IdadeAtual - Idade) * 0.5) + Altura;
		}
	}
	public void AumentouPeso(int PesoAtual){
		if (Peso < PesoAtual){
			Peso = PesoAtual;
		}
	}
	public void DiminuirPeso(int PesoAtual){
		if (Peso >= PesoAtual){
			Peso = PesoAtual;
		}
	}
	public void AumentarTamanho(double Tamanho)
	{
		if (Altura < Tamanho){
			Altura = Tamanho;
		}
	}
}