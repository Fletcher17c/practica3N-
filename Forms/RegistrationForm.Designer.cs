namespace EjersClase.Forms
{
    partial class RegistrationForm
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txbuser = new System.Windows.Forms.TextBox();
            this.txbapellido = new System.Windows.Forms.TextBox();
            this.txbcorreo = new System.Windows.Forms.TextBox();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbconfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(215, 205);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txbuser
            // 
            this.txbuser.Location = new System.Drawing.Point(190, 62);
            this.txbuser.Name = "txbuser";
            this.txbuser.Size = new System.Drawing.Size(100, 20);
            this.txbuser.TabIndex = 1;
            // 
            // txbapellido
            // 
            this.txbapellido.Location = new System.Drawing.Point(190, 89);
            this.txbapellido.Name = "txbapellido";
            this.txbapellido.Size = new System.Drawing.Size(100, 20);
            this.txbapellido.TabIndex = 2;
            // 
            // txbcorreo
            // 
            this.txbcorreo.Location = new System.Drawing.Point(190, 115);
            this.txbcorreo.Name = "txbcorreo";
            this.txbcorreo.Size = new System.Drawing.Size(100, 20);
            this.txbcorreo.TabIndex = 3;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(190, 141);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(100, 20);
            this.txbpassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo Electronico";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Confrima Contraseña";
            // 
            // txbconfirm
            // 
            this.txbconfirm.Location = new System.Drawing.Point(190, 167);
            this.txbconfirm.Name = "txbconfirm";
            this.txbconfirm.Size = new System.Drawing.Size(100, 20);
            this.txbconfirm.TabIndex = 10;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 280);
            this.Controls.Add(this.txbconfirm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbcorreo);
            this.Controls.Add(this.txbapellido);
            this.Controls.Add(this.txbuser);
            this.Controls.Add(this.btnRegister);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txbuser;
        private System.Windows.Forms.TextBox txbapellido;
        private System.Windows.Forms.TextBox txbcorreo;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbconfirm;
    }
}