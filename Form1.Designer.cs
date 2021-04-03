
namespace Actividad_Integradora_5_Problema_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblExtraccion = new System.Windows.Forms.Label();
            this.lblPuente = new System.Windows.Forms.Label();
            this.lblEndodoncia = new System.Windows.Forms.Label();
            this.lblLimpieza = new System.Windows.Forms.Label();
            this.lblRadiologia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Actividad_Integradora_5_Problema_2.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(278, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servicio:";
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(409, 397);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(188, 58);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(409, 318);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(250, 47);
            this.txtServicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 763);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Acumulado:  $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(503, 763);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 41);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Limpieza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 712);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Puente Dental:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 671);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 41);
            this.label5.TabIndex = 8;
            this.label5.Text = "Radiologia dental:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "Endodoncia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 41);
            this.label7.TabIndex = 10;
            this.label7.Text = "Extacciones:";
            // 
            // lblExtraccion
            // 
            this.lblExtraccion.AutoSize = true;
            this.lblExtraccion.Location = new System.Drawing.Point(448, 548);
            this.lblExtraccion.Name = "lblExtraccion";
            this.lblExtraccion.Size = new System.Drawing.Size(34, 41);
            this.lblExtraccion.TabIndex = 15;
            this.lblExtraccion.Text = "0";
            // 
            // lblPuente
            // 
            this.lblPuente.AutoSize = true;
            this.lblPuente.Location = new System.Drawing.Point(448, 712);
            this.lblPuente.Name = "lblPuente";
            this.lblPuente.Size = new System.Drawing.Size(34, 41);
            this.lblPuente.TabIndex = 14;
            this.lblPuente.Text = "0";
            // 
            // lblEndodoncia
            // 
            this.lblEndodoncia.AutoSize = true;
            this.lblEndodoncia.Location = new System.Drawing.Point(448, 630);
            this.lblEndodoncia.Name = "lblEndodoncia";
            this.lblEndodoncia.Size = new System.Drawing.Size(34, 41);
            this.lblEndodoncia.TabIndex = 13;
            this.lblEndodoncia.Text = "0";
            // 
            // lblLimpieza
            // 
            this.lblLimpieza.AutoSize = true;
            this.lblLimpieza.Location = new System.Drawing.Point(448, 589);
            this.lblLimpieza.Name = "lblLimpieza";
            this.lblLimpieza.Size = new System.Drawing.Size(34, 41);
            this.lblLimpieza.TabIndex = 12;
            this.lblLimpieza.Text = "0";
            // 
            // lblRadiologia
            // 
            this.lblRadiologia.AutoSize = true;
            this.lblRadiologia.Location = new System.Drawing.Point(448, 671);
            this.lblRadiologia.Name = "lblRadiologia";
            this.lblRadiologia.Size = new System.Drawing.Size(34, 41);
            this.lblRadiologia.TabIndex = 11;
            this.lblRadiologia.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 851);
            this.Controls.Add(this.lblExtraccion);
            this.Controls.Add(this.lblPuente);
            this.Controls.Add(this.lblEndodoncia);
            this.Controls.Add(this.lblLimpieza);
            this.Controls.Add(this.lblRadiologia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Actividad Integradora 5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblExtraccion;
        private System.Windows.Forms.Label lblPuente;
        private System.Windows.Forms.Label lblEndodoncia;
        private System.Windows.Forms.Label lblLimpieza;
        private System.Windows.Forms.Label lblRadiologia;
    }
}

