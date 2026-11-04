namespace Cifrariodicesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TextBox txt_n4;
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.txt_n3 = new System.Windows.Forms.TextBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.lbl_n7 = new System.Windows.Forms.Label();
            this.lbl_n8 = new System.Windows.Forms.Label();
            txt_n4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_n1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_n1.Location = new System.Drawing.Point(253, 58);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(250, 33);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "CIFRARIO DI CESARE";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(127, 204);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(0);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_n1.Size = new System.Drawing.Size(47, 20);
            this.txt_n1.TabIndex = 1;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(81, 207);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(43, 13);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "Chiave:";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(81, 154);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(90, 13);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Testo da criptare:";
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(177, 150);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(137, 20);
            this.txt_n2.TabIndex = 4;
            // 
            // txt_n3
            // 
            this.txt_n3.Location = new System.Drawing.Point(507, 154);
            this.txt_n3.Name = "txt_n3";
            this.txt_n3.Size = new System.Drawing.Size(137, 20);
            this.txt_n3.TabIndex = 5;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(402, 157);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(102, 13);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "Testo da decriptare:";
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(84, 248);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(135, 58);
            this.btn_n1.TabIndex = 9;
            this.btn_n1.Text = "CRIPTA";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // btn_n2
            // 
            this.btn_n2.Location = new System.Drawing.Point(405, 248);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(135, 58);
            this.btn_n2.TabIndex = 10;
            this.btn_n2.Text = "DECRIPTA";
            this.btn_n2.UseVisualStyleBackColor = true;
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_n6.Location = new System.Drawing.Point(365, 101);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(14, 340);
            this.lbl_n6.TabIndex = 11;
            this.lbl_n6.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Location = new System.Drawing.Point(405, 207);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(43, 13);
            this.lbl_n5.TabIndex = 12;
            this.lbl_n5.Text = "Chiave:";
            // 
            // txt_n4
            // 
            txt_n4.Location = new System.Drawing.Point(454, 204);
            txt_n4.Name = "txt_n4";
            txt_n4.Size = new System.Drawing.Size(47, 20);
            txt_n4.TabIndex = 13;
            // 
            // lbl_n7
            // 
            this.lbl_n7.AutoSize = true;
            this.lbl_n7.Location = new System.Drawing.Point(81, 321);
            this.lbl_n7.Name = "lbl_n7";
            this.lbl_n7.Size = new System.Drawing.Size(71, 13);
            this.lbl_n7.TabIndex = 14;
            this.lbl_n7.Text = "RISULTATO:";
            // 
            // lbl_n8
            // 
            this.lbl_n8.AutoSize = true;
            this.lbl_n8.Location = new System.Drawing.Point(402, 321);
            this.lbl_n8.Name = "lbl_n8";
            this.lbl_n8.Size = new System.Drawing.Size(71, 13);
            this.lbl_n8.TabIndex = 15;
            this.lbl_n8.Text = "RISULTATO:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 476);
            this.Controls.Add(this.lbl_n8);
            this.Controls.Add(this.lbl_n7);
            this.Controls.Add(txt_n4);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.txt_n3);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.TextBox txt_n3;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.Label lbl_n7;
        private System.Windows.Forms.Label lbl_n8;
    }
}

