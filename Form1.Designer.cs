namespace perimetro_de_un_cuadrado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbdatoscuadrados = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtblado1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllado1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblperimetroCuadrado = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnsalirprogram = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btncalcularperimetro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gblimpiar = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtperimetrocuadrad = new System.Windows.Forms.TextBox();
            this.gbdatoscuadrados.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gblimpiar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbdatoscuadrados
            // 
            this.gbdatoscuadrados.BackColor = System.Drawing.SystemColors.Control;
            this.gbdatoscuadrados.Controls.Add(this.gblimpiar);
            this.gbdatoscuadrados.Controls.Add(this.groupBox5);
            this.gbdatoscuadrados.Controls.Add(this.groupBox4);
            this.gbdatoscuadrados.Controls.Add(this.groupBox3);
            this.gbdatoscuadrados.Controls.Add(this.groupBox2);
            this.gbdatoscuadrados.Controls.Add(this.label2);
            this.gbdatoscuadrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatoscuadrados.Location = new System.Drawing.Point(31, 3);
            this.gbdatoscuadrados.Name = "gbdatoscuadrados";
            this.gbdatoscuadrados.Size = new System.Drawing.Size(711, 418);
            this.gbdatoscuadrados.TabIndex = 0;
            this.gbdatoscuadrados.TabStop = false;
            this.gbdatoscuadrados.Text = "Datos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtblado1);
            this.groupBox3.Controls.Add(this.lbllado1);
            this.groupBox3.Location = new System.Drawing.Point(24, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 189);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lados del cuadrado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btncalcularperimetro);
            this.groupBox2.Location = new System.Drawing.Point(423, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 195);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haz click para calcular el perimetro";
            // 
            // txtblado1
            // 
            this.txtblado1.Location = new System.Drawing.Point(91, 64);
            this.txtblado1.Multiline = true;
            this.txtblado1.Name = "txtblado1";
            this.txtblado1.Size = new System.Drawing.Size(144, 24);
            this.txtblado1.TabIndex = 4;
            this.txtblado1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 1;
            // 
            // lbllado1
            // 
            this.lbllado1.AutoSize = true;
            this.lbllado1.Location = new System.Drawing.Point(6, 64);
            this.lbllado1.Name = "lbllado1";
            this.lbllado1.Size = new System.Drawing.Size(79, 24);
            this.lbllado1.TabIndex = 0;
            this.lbllado1.Text = "Lado 1:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtperimetrocuadrad);
            this.groupBox4.Controls.Add(this.lblperimetroCuadrado);
            this.groupBox4.Location = new System.Drawing.Point(22, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 141);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado del calculo";
            // 
            // lblperimetroCuadrado
            // 
            this.lblperimetroCuadrado.AutoSize = true;
            this.lblperimetroCuadrado.Location = new System.Drawing.Point(6, 56);
            this.lblperimetroCuadrado.Name = "lblperimetroCuadrado";
            this.lblperimetroCuadrado.Size = new System.Drawing.Size(235, 24);
            this.lblperimetroCuadrado.TabIndex = 0;
            this.lblperimetroCuadrado.Text = "Perimetro del cuadrado:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnsalirprogram);
            this.groupBox5.Location = new System.Drawing.Point(423, 293);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(260, 119);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Salir del programa";
            // 
            // btnsalirprogram
            // 
            this.btnsalirprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirprogram.Image = global::perimetro_de_un_cuadrado.Properties.Resources.icons8_salida_48;
            this.btnsalirprogram.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalirprogram.Location = new System.Drawing.Point(27, 43);
            this.btnsalirprogram.Name = "btnsalirprogram";
            this.btnsalirprogram.Size = new System.Drawing.Size(153, 65);
            this.btnsalirprogram.TabIndex = 0;
            this.btnsalirprogram.Text = "Salir";
            this.btnsalirprogram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirprogram.UseVisualStyleBackColor = true;
            this.btnsalirprogram.Click += new System.EventHandler(this.btnsalirprogram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::perimetro_de_un_cuadrado.Properties.Resources.icons8_emoji_cuadrado_grande_negro_42;
            this.pictureBox1.Location = new System.Drawing.Point(269, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 37);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btncalcularperimetro
            // 
            this.btncalcularperimetro.Image = global::perimetro_de_un_cuadrado.Properties.Resources.square256_25198;
            this.btncalcularperimetro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncalcularperimetro.Location = new System.Drawing.Point(41, 60);
            this.btncalcularperimetro.Name = "btncalcularperimetro";
            this.btncalcularperimetro.Size = new System.Drawing.Size(177, 112);
            this.btncalcularperimetro.TabIndex = 0;
            this.btncalcularperimetro.Text = "Calcular Perimetro";
            this.btncalcularperimetro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncalcularperimetro.UseVisualStyleBackColor = true;
            this.btncalcularperimetro.Click += new System.EventHandler(this.btncalcularperimetro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // gblimpiar
            // 
            this.gblimpiar.Controls.Add(this.btnLimpiar);
            this.gblimpiar.Location = new System.Drawing.Point(426, 233);
            this.gblimpiar.Name = "gblimpiar";
            this.gblimpiar.Size = new System.Drawing.Size(256, 60);
            this.gblimpiar.TabIndex = 12;
            this.gblimpiar.TabStop = false;
            this.gblimpiar.Text = "Limpiar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(74, 28);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(122, 26);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtperimetrocuadrad
            // 
            this.txtperimetrocuadrad.Location = new System.Drawing.Point(247, 53);
            this.txtperimetrocuadrad.Multiline = true;
            this.txtperimetrocuadrad.Name = "txtperimetrocuadrad";
            this.txtperimetrocuadrad.Size = new System.Drawing.Size(83, 46);
            this.txtperimetrocuadrad.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbdatoscuadrados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Perimetro de un Cuadrado";
            this.gbdatoscuadrados.ResumeLayout(false);
            this.gbdatoscuadrados.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gblimpiar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbdatoscuadrados;
        private System.Windows.Forms.TextBox txtblado1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllado1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btncalcularperimetro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblperimetroCuadrado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsalirprogram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gblimpiar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtperimetrocuadrad;
    }
}

