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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_chiave = new System.Windows.Forms.TextBox();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.txt_criptaggio = new System.Windows.Forms.TextBox();
            this.txt_decriptaggio = new System.Windows.Forms.TextBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.btn_criptaggio = new System.Windows.Forms.Button();
            this.btn_decriptaggio = new System.Windows.Forms.Button();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.lbl_risultato1 = new System.Windows.Forms.Label();
            this.lbl_risultato2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_criptaggio_chiave_stringa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_chiave_stringa = new System.Windows.Forms.Label();
            this.txt_chiave_stringa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_n1.Location = new System.Drawing.Point(457, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(395, 41);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "CIFRARIO DI CESARE";
            // 
            // txt_chiave
            // 
            this.txt_chiave.Location = new System.Drawing.Point(329, 77);
            this.txt_chiave.Margin = new System.Windows.Forms.Padding(0);
            this.txt_chiave.Name = "txt_chiave";
            this.txt_chiave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_chiave.Size = new System.Drawing.Size(76, 20);
            this.txt_chiave.TabIndex = 1;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_n3.Location = new System.Drawing.Point(241, 77);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(67, 20);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "CHIAVE:";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.Black;
            this.lbl_n2.Location = new System.Drawing.Point(12, 120);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(128, 20);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Testo da Criptare:";
            // 
            // txt_criptaggio
            // 
            this.txt_criptaggio.Location = new System.Drawing.Point(146, 120);
            this.txt_criptaggio.Name = "txt_criptaggio";
            this.txt_criptaggio.Size = new System.Drawing.Size(137, 20);
            this.txt_criptaggio.TabIndex = 4;
            // 
            // txt_decriptaggio
            // 
            this.txt_decriptaggio.Location = new System.Drawing.Point(496, 122);
            this.txt_decriptaggio.Name = "txt_decriptaggio";
            this.txt_decriptaggio.Size = new System.Drawing.Size(137, 20);
            this.txt_decriptaggio.TabIndex = 5;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.ForeColor = System.Drawing.Color.Black;
            this.lbl_n4.Location = new System.Drawing.Point(346, 121);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(144, 20);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "Testo da Decriptare:";
            // 
            // btn_criptaggio
            // 
            this.btn_criptaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptaggio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_criptaggio.Location = new System.Drawing.Point(146, 162);
            this.btn_criptaggio.Name = "btn_criptaggio";
            this.btn_criptaggio.Size = new System.Drawing.Size(137, 58);
            this.btn_criptaggio.TabIndex = 9;
            this.btn_criptaggio.Text = "CRIPTA";
            this.btn_criptaggio.UseVisualStyleBackColor = true;
            this.btn_criptaggio.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // btn_decriptaggio
            // 
            this.btn_decriptaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decriptaggio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decriptaggio.Location = new System.Drawing.Point(496, 162);
            this.btn_decriptaggio.Name = "btn_decriptaggio";
            this.btn_decriptaggio.Size = new System.Drawing.Size(137, 58);
            this.btn_decriptaggio.TabIndex = 10;
            this.btn_decriptaggio.Text = "DECRIPTA";
            this.btn_decriptaggio.UseVisualStyleBackColor = true;
            this.btn_decriptaggio.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_n6.Location = new System.Drawing.Point(315, 120);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(14, 200);
            this.lbl_n6.TabIndex = 11;
            this.lbl_n6.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Location = new System.Drawing.Point(405, 207);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(0, 13);
            this.lbl_n5.TabIndex = 12;
            // 
            // lbl_risultato1
            // 
            this.lbl_risultato1.AutoSize = true;
            this.lbl_risultato1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_risultato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_risultato1.Location = new System.Drawing.Point(12, 242);
            this.lbl_risultato1.Name = "lbl_risultato1";
            this.lbl_risultato1.Size = new System.Drawing.Size(105, 22);
            this.lbl_risultato1.TabIndex = 14;
            this.lbl_risultato1.Text = "RISULTATO:";
            // 
            // lbl_risultato2
            // 
            this.lbl_risultato2.AutoSize = true;
            this.lbl_risultato2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_risultato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_risultato2.Location = new System.Drawing.Point(346, 242);
            this.lbl_risultato2.Name = "lbl_risultato2";
            this.lbl_risultato2.Size = new System.Drawing.Size(105, 22);
            this.lbl_risultato2.TabIndex = 15;
            this.lbl_risultato2.Text = "RISULTATO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(649, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 240);
            this.label1.TabIndex = 18;
            this.label1.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_6.Location = new System.Drawing.Point(696, 122);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(137, 22);
            this.lbl_6.TabIndex = 19;
            this.lbl_6.Text = "Testo da Criptare:";
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_7.Location = new System.Drawing.Point(696, 242);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(105, 22);
            this.lbl_7.TabIndex = 20;
            this.lbl_7.Text = "RISULTATO:";
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_8.Location = new System.Drawing.Point(991, 115);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(14, 200);
            this.lbl_8.TabIndex = 21;
            this.lbl_8.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(798, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            // 
            // btn_criptaggio_chiave_stringa
            // 
            this.btn_criptaggio_chiave_stringa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptaggio_chiave_stringa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_criptaggio_chiave_stringa.Location = new System.Drawing.Point(839, 163);
            this.btn_criptaggio_chiave_stringa.Name = "btn_criptaggio_chiave_stringa";
            this.btn_criptaggio_chiave_stringa.Size = new System.Drawing.Size(137, 58);
            this.btn_criptaggio_chiave_stringa.TabIndex = 23;
            this.btn_criptaggio_chiave_stringa.Text = "CRIPTA";
            this.btn_criptaggio_chiave_stringa.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(1087, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(839, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 25;
            // 
            // lbl_chiave_stringa
            // 
            this.lbl_chiave_stringa.AutoSize = true;
            this.lbl_chiave_stringa.Location = new System.Drawing.Point(853, 361);
            this.lbl_chiave_stringa.Name = "lbl_chiave_stringa";
            this.lbl_chiave_stringa.Size = new System.Drawing.Size(35, 13);
            this.lbl_chiave_stringa.TabIndex = 26;
            this.lbl_chiave_stringa.Text = "label2";
            // 
            // txt_chiave_stringa
            // 
            this.txt_chiave_stringa.Location = new System.Drawing.Point(1006, 78);
            this.txt_chiave_stringa.Name = "txt_chiave_stringa";
            this.txt_chiave_stringa.Size = new System.Drawing.Size(76, 20);
            this.txt_chiave_stringa.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1311, 633);
            this.Controls.Add(this.txt_chiave_stringa);
            this.Controls.Add(this.lbl_chiave_stringa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_criptaggio_chiave_stringa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_risultato2);
            this.Controls.Add(this.lbl_risultato1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.btn_decriptaggio);
            this.Controls.Add(this.btn_criptaggio);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.txt_decriptaggio);
            this.Controls.Add(this.txt_criptaggio);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.txt_chiave);
            this.Controls.Add(this.lbl_n1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_chiave;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.TextBox txt_criptaggio;
        private System.Windows.Forms.TextBox txt_decriptaggio;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.Button btn_criptaggio;
        private System.Windows.Forms.Button btn_decriptaggio;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.Label lbl_risultato1;
        private System.Windows.Forms.Label lbl_risultato2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_criptaggio_chiave_stringa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_chiave_stringa;
        private System.Windows.Forms.TextBox txt_chiave_stringa;
    }
}

