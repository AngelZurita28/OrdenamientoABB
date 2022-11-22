namespace OrdenamientoABB
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSinOrdenar = new System.Windows.Forms.TextBox();
            this.txtInorden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvertidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(25, 51);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(161, 23);
            this.txtCantidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la cantidad de digitos";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(25, 88);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 52);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sin ordenar";
            // 
            // txtSinOrdenar
            // 
            this.txtSinOrdenar.Location = new System.Drawing.Point(236, 51);
            this.txtSinOrdenar.Name = "txtSinOrdenar";
            this.txtSinOrdenar.Size = new System.Drawing.Size(272, 23);
            this.txtSinOrdenar.TabIndex = 4;
            // 
            // txtInorden
            // 
            this.txtInorden.Location = new System.Drawing.Point(236, 117);
            this.txtInorden.Name = "txtInorden";
            this.txtInorden.Size = new System.Drawing.Size(272, 23);
            this.txtInorden.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ordenados";
            // 
            // btnInvertidos
            // 
            this.btnInvertidos.Location = new System.Drawing.Point(111, 88);
            this.btnInvertidos.Name = "btnInvertidos";
            this.btnInvertidos.Size = new System.Drawing.Size(75, 52);
            this.btnInvertidos.TabIndex = 7;
            this.btnInvertidos.Text = "invertidos";
            this.btnInvertidos.UseVisualStyleBackColor = true;
            this.btnInvertidos.Click += new System.EventHandler(this.btnInvertidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 157);
            this.Controls.Add(this.btnInvertidos);
            this.Controls.Add(this.txtInorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSinOrdenar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCantidad;
        private Label label1;
        private Button btnIngresar;
        private Label label2;
        private TextBox txtSinOrdenar;
        private TextBox txtInorden;
        private Label label3;
        private Button btnInvertidos;
    }
}