
namespace SimuladorElevador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.andar1A = new System.Windows.Forms.Button();
            this.andar2A = new System.Windows.Forms.Button();
            this.andar3A = new System.Windows.Forms.Button();
            this.andar4A = new System.Windows.Forms.Button();
            this.andar5A = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.TextBox();
            this.emergencia = new System.Windows.Forms.Button();
            this.subir1 = new System.Windows.Forms.Button();
            this.descer2 = new System.Windows.Forms.Button();
            this.subir2 = new System.Windows.Forms.Button();
            this.subir3 = new System.Windows.Forms.Button();
            this.descer3 = new System.Windows.Forms.Button();
            this.subir4 = new System.Windows.Forms.Button();
            this.descer4 = new System.Windows.Forms.Button();
            this.decer5 = new System.Windows.Forms.Button();
            this.andar1 = new System.Windows.Forms.Label();
            this.andar2 = new System.Windows.Forms.Label();
            this.andar3 = new System.Windows.Forms.Label();
            this.andar4 = new System.Windows.Forms.Label();
            this.andar5 = new System.Windows.Forms.Label();
            this.operaçãoA = new System.Windows.Forms.Button();
            this.manual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // andar1A
            // 
            this.andar1A.Location = new System.Drawing.Point(489, 209);
            this.andar1A.Name = "andar1A";
            this.andar1A.Size = new System.Drawing.Size(110, 23);
            this.andar1A.TabIndex = 0;
            this.andar1A.Text = "1 ANDAR";
            this.andar1A.UseVisualStyleBackColor = true;
            this.andar1A.Click += new System.EventHandler(this.andar1A_Click);
            // 
            // andar2A
            // 
            this.andar2A.Location = new System.Drawing.Point(614, 209);
            this.andar2A.Name = "andar2A";
            this.andar2A.Size = new System.Drawing.Size(110, 23);
            this.andar2A.TabIndex = 0;
            this.andar2A.Text = "2 ANDAR";
            this.andar2A.UseVisualStyleBackColor = true;
            this.andar2A.Click += new System.EventHandler(this.andar2A_Click);
            // 
            // andar3A
            // 
            this.andar3A.Location = new System.Drawing.Point(489, 252);
            this.andar3A.Name = "andar3A";
            this.andar3A.Size = new System.Drawing.Size(110, 23);
            this.andar3A.TabIndex = 0;
            this.andar3A.Text = "3 ANDAR";
            this.andar3A.UseVisualStyleBackColor = true;
            this.andar3A.Click += new System.EventHandler(this.andar3A_Click);
            // 
            // andar4A
            // 
            this.andar4A.Location = new System.Drawing.Point(614, 252);
            this.andar4A.Name = "andar4A";
            this.andar4A.Size = new System.Drawing.Size(110, 23);
            this.andar4A.TabIndex = 0;
            this.andar4A.Text = "4 ANDAR";
            this.andar4A.UseVisualStyleBackColor = true;
            this.andar4A.Click += new System.EventHandler(this.andar4A_Click);
            // 
            // andar5A
            // 
            this.andar5A.Location = new System.Drawing.Point(550, 288);
            this.andar5A.Name = "andar5A";
            this.andar5A.Size = new System.Drawing.Size(110, 23);
            this.andar5A.TabIndex = 0;
            this.andar5A.Text = "5 ANDAR";
            this.andar5A.UseVisualStyleBackColor = true;
            this.andar5A.Click += new System.EventHandler(this.andar5A_Click);
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(13, 83);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(210, 20);
            this.status.TabIndex = 1;
            // 
            // emergencia
            // 
            this.emergencia.BackColor = System.Drawing.Color.Red;
            this.emergencia.Location = new System.Drawing.Point(571, 326);
            this.emergencia.Name = "emergencia";
            this.emergencia.Size = new System.Drawing.Size(75, 23);
            this.emergencia.TabIndex = 2;
            this.emergencia.Text = "Emergecia";
            this.emergencia.UseVisualStyleBackColor = false;
            this.emergencia.Click += new System.EventHandler(this.emergencia_Click);
            // 
            // subir1
            // 
            this.subir1.Location = new System.Drawing.Point(148, 167);
            this.subir1.Name = "subir1";
            this.subir1.Size = new System.Drawing.Size(75, 23);
            this.subir1.TabIndex = 6;
            this.subir1.Text = "Subir ";
            this.subir1.UseVisualStyleBackColor = true;
            this.subir1.Click += new System.EventHandler(this.subir1_Click);
            // 
            // descer2
            // 
            this.descer2.Location = new System.Drawing.Point(236, 214);
            this.descer2.Name = "descer2";
            this.descer2.Size = new System.Drawing.Size(75, 23);
            this.descer2.TabIndex = 7;
            this.descer2.Text = "Descer";
            this.descer2.UseVisualStyleBackColor = true;
            this.descer2.Click += new System.EventHandler(this.descer2_Click);
            // 
            // subir2
            // 
            this.subir2.Location = new System.Drawing.Point(148, 214);
            this.subir2.Name = "subir2";
            this.subir2.Size = new System.Drawing.Size(75, 23);
            this.subir2.TabIndex = 6;
            this.subir2.Text = "Subir ";
            this.subir2.UseVisualStyleBackColor = true;
            this.subir2.Click += new System.EventHandler(this.subir2_Click);
            // 
            // subir3
            // 
            this.subir3.Location = new System.Drawing.Point(148, 252);
            this.subir3.Name = "subir3";
            this.subir3.Size = new System.Drawing.Size(75, 23);
            this.subir3.TabIndex = 6;
            this.subir3.Text = "Subir ";
            this.subir3.UseVisualStyleBackColor = true;
            this.subir3.Click += new System.EventHandler(this.subir3_Click);
            // 
            // descer3
            // 
            this.descer3.Location = new System.Drawing.Point(236, 252);
            this.descer3.Name = "descer3";
            this.descer3.Size = new System.Drawing.Size(75, 23);
            this.descer3.TabIndex = 7;
            this.descer3.Text = "Descer";
            this.descer3.UseVisualStyleBackColor = true;
            this.descer3.Click += new System.EventHandler(this.descer3_Click);
            // 
            // subir4
            // 
            this.subir4.Location = new System.Drawing.Point(148, 293);
            this.subir4.Name = "subir4";
            this.subir4.Size = new System.Drawing.Size(75, 23);
            this.subir4.TabIndex = 6;
            this.subir4.Text = "Subir ";
            this.subir4.UseVisualStyleBackColor = true;
            this.subir4.Click += new System.EventHandler(this.subir4_Click);
            // 
            // descer4
            // 
            this.descer4.Location = new System.Drawing.Point(236, 293);
            this.descer4.Name = "descer4";
            this.descer4.Size = new System.Drawing.Size(75, 23);
            this.descer4.TabIndex = 7;
            this.descer4.Text = "Descer";
            this.descer4.UseVisualStyleBackColor = true;
            this.descer4.Click += new System.EventHandler(this.descer4_Click);
            // 
            // decer5
            // 
            this.decer5.Location = new System.Drawing.Point(148, 331);
            this.decer5.Name = "decer5";
            this.decer5.Size = new System.Drawing.Size(75, 23);
            this.decer5.TabIndex = 7;
            this.decer5.Text = "Descer";
            this.decer5.UseVisualStyleBackColor = true;
            this.decer5.Click += new System.EventHandler(this.decer5_Click);
            // 
            // andar1
            // 
            this.andar1.AutoSize = true;
            this.andar1.Location = new System.Drawing.Point(61, 172);
            this.andar1.Name = "andar1";
            this.andar1.Size = new System.Drawing.Size(54, 13);
            this.andar1.TabIndex = 11;
            this.andar1.Text = "1 ANDAR";
            // 
            // andar2
            // 
            this.andar2.AutoSize = true;
            this.andar2.Location = new System.Drawing.Point(61, 219);
            this.andar2.Name = "andar2";
            this.andar2.Size = new System.Drawing.Size(54, 13);
            this.andar2.TabIndex = 11;
            this.andar2.Text = "2 ANDAR";
            // 
            // andar3
            // 
            this.andar3.AutoSize = true;
            this.andar3.Location = new System.Drawing.Point(61, 257);
            this.andar3.Name = "andar3";
            this.andar3.Size = new System.Drawing.Size(54, 13);
            this.andar3.TabIndex = 11;
            this.andar3.Text = "3 ANDAR";
            // 
            // andar4
            // 
            this.andar4.AutoSize = true;
            this.andar4.Location = new System.Drawing.Point(61, 298);
            this.andar4.Name = "andar4";
            this.andar4.Size = new System.Drawing.Size(54, 13);
            this.andar4.TabIndex = 11;
            this.andar4.Text = "4 ANDAR";
            // 
            // andar5
            // 
            this.andar5.AutoSize = true;
            this.andar5.Location = new System.Drawing.Point(61, 336);
            this.andar5.Name = "andar5";
            this.andar5.Size = new System.Drawing.Size(54, 13);
            this.andar5.TabIndex = 11;
            this.andar5.Text = "5 ANDAR";
            // 
            // operaçãoA
            // 
            this.operaçãoA.Location = new System.Drawing.Point(614, 142);
            this.operaçãoA.Name = "operaçãoA";
            this.operaçãoA.Size = new System.Drawing.Size(75, 23);
            this.operaçãoA.TabIndex = 9;
            this.operaçãoA.Text = "Automatico";
            this.operaçãoA.UseVisualStyleBackColor = true;
            this.operaçãoA.Click += new System.EventHandler(this.operaçãoA_Click);
            // 
            // manual
            // 
            this.manual.Location = new System.Drawing.Point(524, 142);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(75, 23);
            this.manual.TabIndex = 12;
            this.manual.Text = "Manual";
            this.manual.UseVisualStyleBackColor = true;
            this.manual.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.andar5);
            this.Controls.Add(this.andar4);
            this.Controls.Add(this.andar3);
            this.Controls.Add(this.andar2);
            this.Controls.Add(this.andar1);
            this.Controls.Add(this.operaçãoA);
            this.Controls.Add(this.decer5);
            this.Controls.Add(this.descer4);
            this.Controls.Add(this.descer3);
            this.Controls.Add(this.descer2);
            this.Controls.Add(this.subir4);
            this.Controls.Add(this.subir3);
            this.Controls.Add(this.subir2);
            this.Controls.Add(this.subir1);
            this.Controls.Add(this.emergencia);
            this.Controls.Add(this.status);
            this.Controls.Add(this.andar5A);
            this.Controls.Add(this.andar4A);
            this.Controls.Add(this.andar3A);
            this.Controls.Add(this.andar2A);
            this.Controls.Add(this.andar1A);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button andar1A;
        private System.Windows.Forms.Button andar2A;
        private System.Windows.Forms.Button andar3A;
        private System.Windows.Forms.Button andar4A;
        private System.Windows.Forms.Button andar5A;
        public System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button emergencia;
        private System.Windows.Forms.Button subir1;
        private System.Windows.Forms.Button descer2;
        private System.Windows.Forms.Button subir2;
        private System.Windows.Forms.Button subir3;
        private System.Windows.Forms.Button descer3;
        private System.Windows.Forms.Button subir4;
        private System.Windows.Forms.Button descer4;
        private System.Windows.Forms.Button decer5;
        private System.Windows.Forms.Label andar1;
        private System.Windows.Forms.Label andar2;
        private System.Windows.Forms.Label andar3;
        private System.Windows.Forms.Label andar4;
        private System.Windows.Forms.Label andar5;
        private System.Windows.Forms.Button operaçãoA;
        private System.Windows.Forms.Button manual;
    }
  
}

