namespace EjersClase.Forms
{
    partial class CalculatorForm
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
            this.txba = new System.Windows.Forms.TextBox();
            this.txbb = new System.Windows.Forms.TextBox();
            this.sumar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txba
            // 
            this.txba.Location = new System.Drawing.Point(83, 49);
            this.txba.Name = "txba";
            this.txba.Size = new System.Drawing.Size(100, 20);
            this.txba.TabIndex = 0;
            // 
            // txbb
            // 
            this.txbb.Location = new System.Drawing.Point(247, 48);
            this.txbb.Name = "txbb";
            this.txbb.Size = new System.Drawing.Size(100, 20);
            this.txbb.TabIndex = 1;
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(83, 153);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(75, 23);
            this.sumar.TabIndex = 2;
            this.sumar.Text = "sumar";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(175, 153);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(75, 23);
            this.restar.TabIndex = 3;
            this.restar.Text = "restar";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(83, 193);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 23);
            this.multiplicar.TabIndex = 4;
            this.multiplicar.Text = "multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(175, 192);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 23);
            this.dividir.TabIndex = 5;
            this.dividir.Text = "dividir";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(83, 101);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(32, 13);
            this.result.TabIndex = 6;
            this.result.Text = "result";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.txbb);
            this.Controls.Add(this.txba);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txba;
        private System.Windows.Forms.TextBox txbb;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Label result;
    }
}