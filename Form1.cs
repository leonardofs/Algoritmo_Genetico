using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgoritmosGeneticos
{
    /// <summary>
    /// Descricao breve do Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuSair;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbAlto;
		private System.Windows.Forms.RadioButton rbMedio;
		private System.Windows.Forms.RadioButton rbbaixo;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbVermelho;
		private System.Windows.Forms.RadioButton rbAzul;
		private System.Windows.Forms.RadioButton rbAmarelo;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton rbPequeno;
		private System.Windows.Forms.RadioButton rbNormal;
		private System.Windows.Forms.RadioButton rbGrande;
		private System.ComponentModel.IContainer components;

		// Array de flores
		public Flores[] populacao= new Flores[10];
		private System.Windows.Forms.Label lblGeracao;
		private int geracao=0;
		private int iPaiA,iPaiB;

		public Form1()
		{
			//
			// Nescessario para o iniciador de janelas do windows
			//
			InitializeComponent();

			

			Random random=new Random(unchecked((int)DateTime.Now.Ticks));
			for(int n=0;n<10;n++)
			{
				Flores temp=new Flores();
				populacao[n]=temp;

                //posicionando uma flor apos a outra
				populacao[n].CoordX=n*80+40;
				
				// Inicializamos o cromosomo com valores sortidos
				
				// A altura vai de 10 a 300
				populacao[n].cromosomo[0]=random.Next(10,300);

				// A cor da flor. 0-rojo, 1-azul, 2-amarillo
				populacao[n].cromosomo[1]=random.Next(0,3);

				// A cor do talo. Diferentes tons de verde
				populacao[n].cromosomo[2]=random.Next(0,3);

				// A espessura do talo. De 5 a 15
				populacao[n].cromosomo[3]=random.Next(5,15);

				// O tamanho da flor. De 20 a 80
				populacao[n].cromosomo[4]=random.Next(20,80);

				// O tamanho do centro da flor. De 5 a 15
				populacao[n].cromosomo[5]=random.Next(5,15);
			}

		}

		/// <summary>
		/// Limapar os recursos que estavamos utilizando.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Código gerado pelo Windows Forms
		/// <summary>
		/// Método necesario para usar o desenhador. Não se deve modificar
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuSair = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbbaixo = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbAlto = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAmarelo = new System.Windows.Forms.RadioButton();
            this.rbAzul = new System.Windows.Forms.RadioButton();
            this.rbVermelho = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbPequeno = new System.Windows.Forms.RadioButton();
            this.lblGeracao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuSair});
            this.menuItem1.Text = "Arquivo";
            // 
            // mnuSair
            // 
            this.mnuSair.Index = 0;
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4});
            this.menuItem2.Text = "Aplicacao";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Iniciar";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Parar";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbbaixo);
            this.groupBox1.Controls.Add(this.rbMedio);
            this.groupBox1.Controls.Add(this.rbAlto);
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altura";
            // 
            // rbbaixo
            // 
            this.rbbaixo.Location = new System.Drawing.Point(16, 64);
            this.rbbaixo.Name = "rbbaixo";
            this.rbbaixo.Size = new System.Drawing.Size(104, 24);
            this.rbbaixo.TabIndex = 2;
            this.rbbaixo.Text = "Baixo";
            // 
            // rbMedio
            // 
            this.rbMedio.Checked = true;
            this.rbMedio.Location = new System.Drawing.Point(16, 40);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(104, 24);
            this.rbMedio.TabIndex = 1;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Medio";
            // 
            // rbAlto
            // 
            this.rbAlto.Location = new System.Drawing.Point(16, 16);
            this.rbAlto.Name = "rbAlto";
            this.rbAlto.Size = new System.Drawing.Size(104, 24);
            this.rbAlto.TabIndex = 0;
            this.rbAlto.Text = "Alto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAmarelo);
            this.groupBox2.Controls.Add(this.rbAzul);
            this.groupBox2.Controls.Add(this.rbVermelho);
            this.groupBox2.Location = new System.Drawing.Point(160, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cor da flor";
            // 
            // rbAmarelo
            // 
            this.rbAmarelo.Location = new System.Drawing.Point(16, 64);
            this.rbAmarelo.Name = "rbAmarelo";
            this.rbAmarelo.Size = new System.Drawing.Size(104, 24);
            this.rbAmarelo.TabIndex = 2;
            this.rbAmarelo.Text = "Amarelo";
            // 
            // rbAzul
            // 
            this.rbAzul.Location = new System.Drawing.Point(16, 40);
            this.rbAzul.Name = "rbAzul";
            this.rbAzul.Size = new System.Drawing.Size(104, 24);
            this.rbAzul.TabIndex = 1;
            this.rbAzul.Text = "Azul";
            // 
            // rbVermelho
            // 
            this.rbVermelho.Checked = true;
            this.rbVermelho.Location = new System.Drawing.Point(16, 16);
            this.rbVermelho.Name = "rbVermelho";
            this.rbVermelho.Size = new System.Drawing.Size(104, 24);
            this.rbVermelho.TabIndex = 0;
            this.rbVermelho.TabStop = true;
            this.rbVermelho.Text = "Vermelho";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbGrande);
            this.groupBox3.Controls.Add(this.rbNormal);
            this.groupBox3.Controls.Add(this.rbPequeno);
            this.groupBox3.Location = new System.Drawing.Point(296, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tamanho da Flor";
            // 
            // rbGrande
            // 
            this.rbGrande.Location = new System.Drawing.Point(16, 64);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(104, 24);
            this.rbGrande.TabIndex = 2;
            this.rbGrande.Text = "Grande";
            // 
            // rbNormal
            // 
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(16, 40);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(104, 24);
            this.rbNormal.TabIndex = 1;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            // 
            // rbPequeno
            // 
            this.rbPequeno.Location = new System.Drawing.Point(16, 16);
            this.rbPequeno.Name = "rbPequeno";
            this.rbPequeno.Size = new System.Drawing.Size(104, 24);
            this.rbPequeno.TabIndex = 0;
            this.rbPequeno.Text = "Pequeno";
            // 
            // lblGeracao
            // 
            this.lblGeracao.Location = new System.Drawing.Point(16, 112);
            this.lblGeracao.Name = "lblGeracao";
            this.lblGeracao.Size = new System.Drawing.Size(100, 23);
            this.lblGeracao.TabIndex = 3;
            this.lblGeracao.Text = "Geracao:";
            this.lblGeracao.Click += new System.EventHandler(this.LblGeneracion_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 571);
            this.Controls.Add(this.lblGeracao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Trabalho 2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos Geneticos (Disciplina Sistemas Inteligentes)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ponto de inicio da aplicação
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void mnuSair_Click(object sender, System.EventArgs e)
		{
			this.Close();
		
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			timer1.Enabled=true;
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			timer1.Enabled=false;
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// Calculamos a adaptacao
			CalculaAdaptacao();

			// selecionamos os pais
			SelecionaPais();

			// fazemos o Crossover e a mutação
			Crossover();

			// Atualizamos a geracao
			geracao++;

            // Redesenhamos a janela
            this.Invalidate();
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// desenhamos o solo
			e.Graphics.FillRectangle(Brushes.DarkGreen,0,550,800,50);

			// Desenhamos as flores
			for(int n=0;n<10;n++)
			{
				// 0-Altura
				// 1-Cor da flor
				// 2-Cor do talo
				// 3-Espessura do talo
				// 4-Tamanho da flor
				// 5-Tamanho do centro da flor

				// Desenhamos o talo
						
				// criamos a cor do talo
				if(populacao[n].cromosomo[2]==0)
					e.Graphics.FillRectangle(Brushes.DarkGreen,
						populacao[n].CoordX,550-populacao[n].cromosomo[0],
						populacao[n].cromosomo[3],populacao[n].cromosomo[0]);
				else if(populacao[n].cromosomo[2]==1)
					e.Graphics.FillRectangle(Brushes.Green,
						populacao[n].CoordX,550-populacao[n].cromosomo[0],
						populacao[n].cromosomo[3],populacao[n].cromosomo[0]);
				else if(populacao[n].cromosomo[2]==2)
					e.Graphics.FillRectangle(Brushes.LightGreen,
						populacao[n].CoordX,550-populacao[n].cromosomo[0],
						populacao[n].cromosomo[3],populacao[n].cromosomo[0]);

				// Desenhamos a flor
				//Cor cflor=new Color();
				Color cflor=new Color(); 
				
				if(populacao[n].cromosomo[1]==0)
					cflor=Color.Red;
				else if(populacao[n].cromosomo[1]==1)
					cflor=Color.Blue;
				else if(populacao[n].cromosomo[1]==2)
					cflor=Color.Yellow;


				e.Graphics.FillEllipse(new SolidBrush(cflor),
					populacao[n].CoordX+populacao[n].cromosomo[3]/2-populacao[n].cromosomo[4]/2,
					550-populacao[n].cromosomo[0]-populacao[n].cromosomo[4]/2,
					populacao[n].cromosomo[4],populacao[n].cromosomo[4]);

				//Desenhamos o centro da flor
				e.Graphics.FillEllipse(Brushes.DarkOrange,
					populacao[n].CoordX+populacao[n].cromosomo[3]/2-populacao[n].cromosomo[5]/2,
					550-populacao[n].cromosomo[0]-populacao[n].cromosomo[5]/2,
					populacao[n].cromosomo[5],populacao[n].cromosomo[5]);
			}

			lblGeracao.Text="Geração: "+ geracao.ToString();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{

			
		}

		private void CalculaAdaptacao()
		{
			// Variaveis de opcoes do usuario
			int altura,color,tamano;
			altura=color=tamano=0;

			// Variaveis nescesssarias para o calculo
			double Aaltura,Acolor,Atamano;
			Aaltura=Acolor=Atamano=0.0;

			// Obtnemos a altura escolhida pelo usuario
			if(rbbaixo.Checked==true)
				altura=0;
			else if(rbMedio.Checked==true)
				altura=1;
			else if(rbAlto.Checked==true)
				altura=2;

            // Obtnemos a cor escolhida pelo usuario
            if (rbVermelho.Checked==true)
				color=0;
			else if(rbAzul.Checked==true)
				color=1;
			else if(rbAmarelo.Checked==true)
				color=2;

            // Obtnemos o tamanho da flor  escolhida pelo usuario
            if (rbPequeno.Checked==true)
				tamano=0;
			else if(rbNormal.Checked==true)
				tamano=1;
			else if(rbGrande.Checked==true)
				tamano=2;


			// Passamos por toda a populacao para gerar sua adaptacao 
			for(int n=0;n<10;n++)
			{
				// Checamos de adaptacao para a altura 
				if(altura==0) // range 10 a 100
					Aaltura=populacao[n].cromosomo[0]/100;
				else if(altura==1) // range 100 a 200
					Aaltura=populacao[n].cromosomo[0]/200;
				else if(altura==2) // range 200 a 300
					Aaltura=populacao[n].cromosomo[0]/300;

				if(Aaltura>1.0)
					Aaltura=1/Aaltura;

				// Checamos o nivel de adaptacao da cor
				if(color==populacao[n].cromosomo[1])
					Acolor=1.0;
				else
					Acolor=0.0;

				// Checamos o nivel de adaptacao do tamanho da flor
				if(tamano==0) // range 20 a 40
					Atamano=populacao[n].cromosomo[4]/40;
				else if(tamano==1) // range 40 a 60
					Atamano=populacao[n].cromosomo[4]/60;
				else if(tamano==2) // range 60 a 80
					Atamano=populacao[n].cromosomo[4]/80;

				if(Atamano>1.0)
					Atamano=1/Atamano;

				// Calculamos o valor final da adaptacao
				populacao[n].Adaptacao=(Aaltura+Acolor+Atamano)/3.0;

			}

		}

		
private void SelecionaPais()
		{
			// Seleccionamos os dois melhores
			// Modelo elitista
			
			iPaiA=iPaiB=0;

			// Encontramos o Pai A 
			for(int n=0;n<10;n++)
			{
				if(populacao[n].Adaptacao>populacao[iPaiA].Adaptacao)
					iPaiA=n;
			}

            // Encontramos o Pai B 
            for (int n=0;n<10;n++)
			{
				if(populacao[n].Adaptacao>populacao[iPaiB].Adaptacao && iPaiA!=n)
					iPaiB=n;
			}

		}

        private void LblGeneracion_Click(object sender, EventArgs e)
        {

        }

        private void Crossover()
		{
         

            //Nós copiamos os pais, pois todo o array será preenchido novamente com os filhos

            Flores PaiA =new Flores();
			Flores PaiB=new Flores();

			// Copiamos os pais
			for(int n=0;n<6;n++)
			{
				PaiA.cromosomo[n]=populacao[iPaiA].cromosomo[n];
				PaiB.cromosomo[n]=populacao[iPaiB].cromosomo[n];

			}

			// Criamos a proxima geração
			
			Random random=new Random(unchecked((int)DateTime.Now.Ticks));
			

			for(int n=0;n<10;n++)
			{
			
				int desde=random.Next(0,5);
				int ate=random.Next(desde,6);

				for(int c=desde;c<ate;c++)
				{
                    // Se o random é 0,  copiamos o gen de Pai A
                    // Se o random é 1,  copiamos o gen de Pai B
                    if (random.Next(0,2)==0)
						populacao[n].cromosomo[c]=PaiA.cromosomo[c];
					else
						populacao[n].cromosomo[c]=PaiB.cromosomo[c];

					// incluimos a multacao
					if(random.Next(0,100)<=5)
					{

						if(c==0)
							populacao[n].cromosomo[0]=random.Next(10,300);

						if(c==1)
							populacao[n].cromosomo[1]=random.Next(0,3);

						if(c==2)
							populacao[n].cromosomo[2]=random.Next(0,3);

						if(c==3)
							populacao[n].cromosomo[3]=random.Next(5,15);

						if(c==4)
							populacao[n].cromosomo[4]=random.Next(20,80);

						if(c==5)
							populacao[n].cromosomo[5]=random.Next(5,15);

					}

				}

			}


		}
	}
}
