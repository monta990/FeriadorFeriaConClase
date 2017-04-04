namespace DemoObjetosVisual
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
            this.tBCantidad = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.lbB50 = new System.Windows.Forms.Label();
            this.lbM5 = new System.Windows.Forms.Label();
            this.lbM1 = new System.Windows.Forms.Label();
            this.btSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBCantidad
            // 
            this.tBCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tBCantidad.Location = new System.Drawing.Point(176, 21);
            this.tBCantidad.Name = "tBCantidad";
            this.tBCantidad.Size = new System.Drawing.Size(99, 21);
            this.tBCantidad.TabIndex = 0;
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(19, 24);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(152, 16);
            this.lbCantidad.TabIndex = 1;
            this.lbCantidad.Text = "Cantidad a ferear   $ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Billetes de $50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Monedas de $5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Monedas de $1";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(176, 51);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(99, 26);
            this.btCalcular.TabIndex = 11;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // lbB50
            // 
            this.lbB50.AutoSize = true;
            this.lbB50.BackColor = System.Drawing.SystemColors.Control;
            this.lbB50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB50.Location = new System.Drawing.Point(178, 96);
            this.lbB50.Name = "lbB50";
            this.lbB50.Size = new System.Drawing.Size(160, 16);
            this.lbB50.TabIndex = 12;
            this.lbB50.Text = "Esperando cantidad...";
            // 
            // lbM5
            // 
            this.lbM5.AutoSize = true;
            this.lbM5.BackColor = System.Drawing.SystemColors.Control;
            this.lbM5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM5.Location = new System.Drawing.Point(178, 151);
            this.lbM5.Name = "lbM5";
            this.lbM5.Size = new System.Drawing.Size(160, 16);
            this.lbM5.TabIndex = 13;
            this.lbM5.Text = "Esperando cantidad...";
            // 
            // lbM1
            // 
            this.lbM1.AutoSize = true;
            this.lbM1.BackColor = System.Drawing.SystemColors.Control;
            this.lbM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbM1.Location = new System.Drawing.Point(178, 206);
            this.lbM1.Name = "lbM1";
            this.lbM1.Size = new System.Drawing.Size(160, 16);
            this.lbM1.TabIndex = 14;
            this.lbM1.Text = "Esperando cantidad...";
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(239, 339);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(99, 26);
            this.btSalir.TabIndex = 15;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dando feria correcta desde que me crearon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 48);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nota: Si tu feria no es correcta,  no es error,\r\nes la comisión por mi trabajo.\r\n" +
    "Si fue de mas contacta al admistrador.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 377);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.lbM1);
            this.Controls.Add(this.lbM5);
            this.Controls.Add(this.lbB50);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.tBCantidad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feriador de Feria  versión algo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBCantidad;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Label lbB50;
        private System.Windows.Forms.Label lbM5;
        private System.Windows.Forms.Label lbM1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

