namespace EjersClase.Forms
{
    partial class TemperatureConverterForm
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
            this.btnconvert1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnconvert2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconvert1
            // 
            this.btnconvert1.Location = new System.Drawing.Point(218, 121);
            this.btnconvert1.Name = "btnconvert1";
            this.btnconvert1.Size = new System.Drawing.Size(75, 23);
            this.btnconvert1.TabIndex = 0;
            this.btnconvert1.Text = "F to C";
            this.btnconvert1.UseVisualStyleBackColor = true;
            this.btnconvert1.Click += new System.EventHandler(this.btnconvert1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(62, 84);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "label1";
            // 
            // btnconvert2
            // 
            this.btnconvert2.Location = new System.Drawing.Point(98, 121);
            this.btnconvert2.Name = "btnconvert2";
            this.btnconvert2.Size = new System.Drawing.Size(75, 23);
            this.btnconvert2.TabIndex = 4;
            this.btnconvert2.Text = "C to F";
            this.btnconvert2.UseVisualStyleBackColor = true;
            this.btnconvert2.Click += new System.EventHandler(this.btnconvert2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Farenheit";
            // 
            // TemperatureConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnconvert2);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnconvert1);
            this.Name = "TemperatureConverterForm";
            this.Text = "TemperatureConverterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvert1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnconvert2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}