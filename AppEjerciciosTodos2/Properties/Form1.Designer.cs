namespace AppEjerciciosTodos2.Properties
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtMetrosEnPulgadas = new System.Windows.Forms.TextBox();
            this.txtMetrosEnPies = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "2.14 Convertidos de metros a pies y a pulgas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(177, 65);
            this.txtMetros.MaxLength = 10;
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(193, 20);
            this.txtMetros.TabIndex = 1;
            this.txtMetros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMetrosEnPulgadas
            // 
            this.txtMetrosEnPulgadas.Location = new System.Drawing.Point(177, 138);
            this.txtMetrosEnPulgadas.MaxLength = 10;
            this.txtMetrosEnPulgadas.Name = "txtMetrosEnPulgadas";
            this.txtMetrosEnPulgadas.Size = new System.Drawing.Size(193, 20);
            this.txtMetrosEnPulgadas.TabIndex = 2;
            // 
            // txtMetrosEnPies
            // 
            this.txtMetrosEnPies.Location = new System.Drawing.Point(177, 103);
            this.txtMetrosEnPies.MaxLength = 3000;
            this.txtMetrosEnPies.Name = "txtMetrosEnPies";
            this.txtMetrosEnPies.ReadOnly = true;
            this.txtMetrosEnPies.Size = new System.Drawing.Size(193, 20);
            this.txtMetrosEnPies.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(73, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(226, 217);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 20);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese los metros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Metros en pies es igual a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMetrosEnPies);
            this.Controls.Add(this.txtMetrosEnPulgadas);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtMetrosEnPulgadas;
        private System.Windows.Forms.TextBox txtMetrosEnPies;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}