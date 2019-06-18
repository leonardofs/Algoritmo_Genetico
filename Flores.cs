using System;

namespace AlgoritmosGeneticos
{
	/// <summary>
	/// Descricao breve das Flores.
	/// </summary>
	public class Flores
	{
		// Variaveis da classe
		private int x; // Posicao na tela
		private double adaptacao; // Nivel de adaptacao da flor


        // Criamos os cromossomos da 
        // 0-Altura da flor
        // 1-Cor da flor
        // 2-Cor do talo
        // 3-espessura do talo
        // 4-Tamanho da flor
        // 5-Tamanho do centro da flor

        public int[] cromosomo=new int[6];

		// Creamos las propiedades
		public int CoordX 
		{
			set {x=value;}
			get {return x;}
		}

		public double Adaptacao
		{
			set {adaptacao=value;}
			get {return adaptacao;}
		}


		public Flores()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//

			
		}

	

	}
}
