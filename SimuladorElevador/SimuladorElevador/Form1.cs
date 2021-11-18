using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace SimuladorElevador
{
    public partial class Form1 : Form
    {
       
        int i;
        string stat;
        int andarAt=1;
        int andarN;
        
        public Form1()
        {
            InitializeComponent();
        }
       //método movimento Elevador 
        public void movimento()
        {
            if (andarAt < andarN)
            {
                Application.DoEvents();
                status.Text = "Subindo";
                status.Refresh();
                Thread.Sleep(10000);

              
                while (andarAt < andarN) { 
                
                    andarAt++;
                }
                Application.DoEvents();
                status.Text = "Parado" + andarAt;
                status.Refresh();
                andarAt = andarN;
            }else{
                if (andarAt > andarN)
                {
                    Application.DoEvents();
                    status.Text = "Descendo";
                    Thread.Sleep(10000);
                    status.Refresh();
                    while (andarAt > andarN)
                    {
                        andarAt--;
                    }
                    while (andarAt < andarN)
                    {
                        andarAt++;
                    }
                    Application.DoEvents();
                    status.Text = "Parado"+andarAt;
                    status.Refresh();
                    andarAt = andarN;
                }else{
                    if (andarAt == andarN)
                    {
                        status.Text = "Elevador Já está no andar";

                    }
                }
            }             
        }
        //Botôes Painel internos
        private void andar1A_Click(object sender, EventArgs e)
        {
            andarN = 1;
            movimento();
        }

        private void andar2A_Click(object sender, EventArgs e)
        {
            andarN = 2;
            movimento();
        }
        private void andar3A_Click(object sender, EventArgs e)
        {
            andarN = 3;
            movimento();
        }

        private void andar4A_Click(object sender, EventArgs e)
        {
            andarN = 4;
            movimento();
        }

        private void andar5A_Click(object sender, EventArgs e)
        {
            andarN = 5;
            movimento();
        }
        //Botões Painel Externo
        public void subir1_Click(object sender, EventArgs e)
        {
            stat = "Subindo";
            status.Text = "Parado " + andarAt;
            if (andarAt > 2)
            {
                Application.DoEvents();
                status.Text = "Descendo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt > 2)
                {
                    andarAt--;
                }

            }

        }
        private void subir2_Click(object sender, EventArgs e)
        {
            stat = "Subindo";
            status.Text = "Parado " + andarAt;
            if (andarAt > 2)
            {
                Application.DoEvents();
                status.Text = "Descendo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt > 2)
                {
                    andarAt--;
                }

            }


        }

        private void subir3_Click(object sender, EventArgs e)
        {
            stat = "Subindo";
            status.Text = "Parado " + andarAt;
            if (andarAt > 3)
            {
                Application.DoEvents();
                status.Text = "Descendo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt > 3)
                {
                    andarAt--;
                }

            }
            
        }

        private void subir4_Click(object sender, EventArgs e)
        {
            stat = "Subindo";
            status.Text = "Parado " + andarAt;
            if (andarAt > 4)
            {
                Application.DoEvents();
                status.Text = "Descendo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt > 4)
                {
                    andarAt--;
                }

            }
            
           
        }

        private void decer5_Click(object sender, EventArgs e)
        {
            stat = "Descendo";
            status.Text = "Parado " + andarAt;
            if (andarAt <5 )
            {
                Application.DoEvents();
                status.Text = "Subindo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt < 5)
                {
                    andarAt++;
                }

            }
            
           
        }
        private void descer4_Click(object sender, EventArgs e)
        {
            stat = "Descendo";
            status.Text = "Parado " + andarAt;
            if (andarAt < 1)
            {
                Application.DoEvents();
                status.Text = "Subindo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt < 4)
                {
                    andarAt++;
                }

            }
            
        
        }

        private void descer3_Click(object sender, EventArgs e)
        {
            stat = "Descendo";
            status.Text = "Parado " + andarAt;
            if (andarAt < 3)
            {
                Application.DoEvents();
                status.Text = "Subindo";
                Thread.Sleep(10000);
                status.Refresh();
                
                while (andarAt < 3)
                {
                    andarAt++;
                }

            }
            
        }

        private void descer2_Click(object sender, EventArgs e)
        {
            stat = "Descendo";
            status.Text = "Parado " + andarAt;
            if (andarAt < 2)
            {
                Application.DoEvents();
                status.Text = "Subindo";
                Thread.Sleep(10000);
                status.Refresh();

                while (andarAt < 2)
                {
                    andarAt++;
                }

            }
            
            
        }
        //método opção automatica
        private void operaçãoA_Click(object sender, EventArgs e)
        {
            //Desativando botões Extrenos
            subir1.Enabled = false;
            subir2.Enabled = false;
            subir3.Enabled = false;
            subir4.Enabled = false;
            descer2.Enabled = false;
            descer3.Enabled = false;
            descer4.Enabled = false;
            decer5.Enabled = false;

            andarAle();


        }
        public void andarAle( )
        {
            try
            {
                int andarAleat;
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    andarAleat = Convert.ToInt32(random.Next(1, 5).ToString());
                    andarN = andarAleat;
                    movimento();
                    andarAt = andarN;
                }
            }
            catch
            {
                status.Text = "Erro";
            }
          
               
   
        }
        //Botão de Parada
        private void emergencia_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            status.Text = "Parado";
            Thread.Sleep(10000);
            status.Refresh();

        }
        //opção manual
        private void button1_Click(object sender, EventArgs e)
        {
           //Ativando botões Internos
            subir1.Enabled = true;
            subir2.Enabled = true;
            subir3.Enabled = true;
            subir4.Enabled = true;
            descer2.Enabled = true;
            descer3.Enabled = true;
            descer4.Enabled = true;
            decer5.Enabled = true;
        }
    }
}
