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
            this.txt_chiave_variabile_criptaggio = new System.Windows.Forms.TextBox();
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
            this.btn_chiave_stringa_decriptaggio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_chiave_stringa = new System.Windows.Forms.Label();
            this.txt_chiave_variabile_decriptaggio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_chiave_fissa_criptaggio = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_n1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_n1.Font = new System.Drawing.Font("Old English Text MT", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_n1.Location = new System.Drawing.Point(522, 20);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(649, 58);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "CIFRARIO DI CESARE";
            // 
            // txt_chiave_variabile_criptaggio
            // 
            this.txt_chiave_variabile_criptaggio.Location = new System.Drawing.Point(186, 267);
            this.txt_chiave_variabile_criptaggio.Margin = new System.Windows.Forms.Padding(0);
            this.txt_chiave_variabile_criptaggio.Name = "txt_chiave_variabile_criptaggio";
            this.txt_chiave_variabile_criptaggio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_chiave_variabile_criptaggio.Size = new System.Drawing.Size(100, 22);
            this.txt_chiave_variabile_criptaggio.TabIndex = 1;
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_n3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_n3.Location = new System.Drawing.Point(248, 146);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(297, 34);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "CHIAVE VARIABILE:";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.Black;
            this.lbl_n2.Location = new System.Drawing.Point(13, 222);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(158, 24);
            this.lbl_n2.TabIndex = 3;
            this.lbl_n2.Text = "Testo da Criptare:";
            // 
            // txt_criptaggio
            // 
            this.txt_criptaggio.Location = new System.Drawing.Point(186, 225);
            this.txt_criptaggio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_criptaggio.Name = "txt_criptaggio";
            this.txt_criptaggio.Size = new System.Drawing.Size(183, 22);
            this.txt_criptaggio.TabIndex = 4;
            // 
            // txt_decriptaggio
            // 
            this.txt_decriptaggio.Location = new System.Drawing.Point(585, 228);
            this.txt_decriptaggio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_decriptaggio.Name = "txt_decriptaggio";
            this.txt_decriptaggio.Size = new System.Drawing.Size(181, 22);
            this.txt_decriptaggio.TabIndex = 5;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.ForeColor = System.Drawing.Color.Black;
            this.lbl_n4.Location = new System.Drawing.Point(398, 225);
            this.lbl_n4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(179, 24);
            this.lbl_n4.TabIndex = 7;
            this.lbl_n4.Text = "Testo da Decriptare:";
            // 
            // btn_criptaggio
            // 
            this.btn_criptaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptaggio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_criptaggio.Location = new System.Drawing.Point(186, 319);
            this.btn_criptaggio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_criptaggio.Name = "btn_criptaggio";
            this.btn_criptaggio.Size = new System.Drawing.Size(183, 71);
            this.btn_criptaggio.TabIndex = 9;
            this.btn_criptaggio.Text = "CRIPTA";
            this.btn_criptaggio.UseVisualStyleBackColor = true;
            this.btn_criptaggio.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // btn_decriptaggio
            // 
            this.btn_decriptaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decriptaggio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_decriptaggio.Location = new System.Drawing.Point(585, 319);
            this.btn_decriptaggio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_decriptaggio.Name = "btn_decriptaggio";
            this.btn_decriptaggio.Size = new System.Drawing.Size(181, 71);
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
            this.lbl_n6.Location = new System.Drawing.Point(372, 221);
            this.lbl_n6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(17, 250);
            this.lbl_n6.TabIndex = 11;
            this.lbl_n6.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n";
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.Location = new System.Drawing.Point(540, 255);
            this.lbl_n5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(0, 16);
            this.lbl_n5.TabIndex = 12;
            // 
            // lbl_risultato1
            // 
            this.lbl_risultato1.AutoSize = true;
            this.lbl_risultato1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_risultato1.Location = new System.Drawing.Point(13, 410);
            this.lbl_risultato1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_risultato1.Name = "lbl_risultato1";
            this.lbl_risultato1.Size = new System.Drawing.Size(131, 25);
            this.lbl_risultato1.TabIndex = 14;
            this.lbl_risultato1.Text = "RISULTATO:";
            // 
            // lbl_risultato2
            // 
            this.lbl_risultato2.AutoSize = true;
            this.lbl_risultato2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_risultato2.Location = new System.Drawing.Point(397, 410);
            this.lbl_risultato2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_risultato2.Name = "lbl_risultato2";
            this.lbl_risultato2.Size = new System.Drawing.Size(131, 25);
            this.lbl_risultato2.TabIndex = 15;
            this.lbl_risultato2.Text = "RISULTATO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(774, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 302);
            this.label1.TabIndex = 18;
            this.label1.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.";
            // 
            // lbl_6
            // 
            this.lbl_6.AutoSize = true;
            this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_6.Location = new System.Drawing.Point(397, 267);
            this.lbl_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(171, 25);
            this.lbl_6.TabIndex = 19;
            this.lbl_6.Text = "Inserisci la chiave:";
            // 
            // lbl_7
            // 
            this.lbl_7.AutoSize = true;
            this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_7.Location = new System.Drawing.Point(801, 410);
            this.lbl_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(131, 25);
            this.lbl_7.TabIndex = 20;
            this.lbl_7.Text = "RISULTATO:";
            // 
            // lbl_8
            // 
            this.lbl_8.AutoSize = true;
            this.lbl_8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_8.Location = new System.Drawing.Point(1221, 169);
            this.lbl_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(19, 302);
            this.lbl_8.TabIndex = 21;
            this.lbl_8.Text = "|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.\r\n|\r\n.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(1064, 469);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 22;
            // 
            // btn_criptaggio_chiave_stringa
            // 
            this.btn_criptaggio_chiave_stringa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criptaggio_chiave_stringa.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_criptaggio_chiave_stringa.Location = new System.Drawing.Point(802, 317);
            this.btn_criptaggio_chiave_stringa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_criptaggio_chiave_stringa.Name = "btn_criptaggio_chiave_stringa";
            this.btn_criptaggio_chiave_stringa.Size = new System.Drawing.Size(181, 71);
            this.btn_criptaggio_chiave_stringa.TabIndex = 23;
            this.btn_criptaggio_chiave_stringa.Text = "CRIPTA";
            this.btn_criptaggio_chiave_stringa.UseVisualStyleBackColor = true;
            // 
            // btn_chiave_stringa_decriptaggio
            // 
            this.btn_chiave_stringa_decriptaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chiave_stringa_decriptaggio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_chiave_stringa_decriptaggio.Location = new System.Drawing.Point(1032, 317);
            this.btn_chiave_stringa_decriptaggio.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chiave_stringa_decriptaggio.Name = "btn_chiave_stringa_decriptaggio";
            this.btn_chiave_stringa_decriptaggio.Size = new System.Drawing.Size(181, 73);
            this.btn_chiave_stringa_decriptaggio.TabIndex = 24;
            this.btn_chiave_stringa_decriptaggio.Text = "DECRIPTA";
            this.btn_chiave_stringa_decriptaggio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(990, 266);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 22);
            this.textBox1.TabIndex = 25;
            // 
            // lbl_chiave_stringa
            // 
            this.lbl_chiave_stringa.AutoSize = true;
            this.lbl_chiave_stringa.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_chiave_stringa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_chiave_stringa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chiave_stringa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_chiave_stringa.Location = new System.Drawing.Point(873, 146);
            this.lbl_chiave_stringa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chiave_stringa.Name = "lbl_chiave_stringa";
            this.lbl_chiave_stringa.Size = new System.Drawing.Size(274, 34);
            this.lbl_chiave_stringa.TabIndex = 26;
            this.lbl_chiave_stringa.Text = "CHIAVE STRINGA:";
            // 
            // txt_chiave_variabile_decriptaggio
            // 
            this.txt_chiave_variabile_decriptaggio.Location = new System.Drawing.Point(585, 268);
            this.txt_chiave_variabile_decriptaggio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chiave_variabile_decriptaggio.Name = "txt_chiave_variabile_decriptaggio";
            this.txt_chiave_variabile_decriptaggio.Size = new System.Drawing.Size(100, 22);
            this.txt_chiave_variabile_decriptaggio.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Inserisci la chiave:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(801, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Inserisci la chiave:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(990, 228);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(801, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Testo da Decriptare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1247, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Testo da Decriptare:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(1247, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 33;
            this.label7.Text = "inserisci la chiave:";
            // 
            // btn_chiave_fissa_criptaggio
            // 
            this.btn_chiave_fissa_criptaggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chiave_fissa_criptaggio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_chiave_fissa_criptaggio.Location = new System.Drawing.Point(1247, 318);
            this.btn_chiave_fissa_criptaggio.Name = "btn_chiave_fissa_criptaggio";
            this.btn_chiave_fissa_criptaggio.Size = new System.Drawing.Size(181, 72);
            this.btn_chiave_fissa_criptaggio.TabIndex = 34;
            this.btn_chiave_fissa_criptaggio.Text = "CRIPTA";
            this.btn_chiave_fissa_criptaggio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(1461, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 72);
            this.button2.TabIndex = 35;
            this.button2.Text = "DECRIPTA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(1247, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "RISULTATO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1332, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 34);
            this.label9.TabIndex = 37;
            this.label9.Text = "CHIAVE FISSA:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1441, 232);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 22);
            this.textBox3.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(1441, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 27);
            this.label10.TabIndex = 39;
            this.label10.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1658, 558);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_chiave_fissa_criptaggio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_chiave_variabile_decriptaggio);
            this.Controls.Add(this.lbl_chiave_stringa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_chiave_stringa_decriptaggio);
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
            this.Controls.Add(this.txt_chiave_variabile_criptaggio);
            this.Controls.Add(this.lbl_n1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_chiave_variabile_criptaggio;
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
        private System.Windows.Forms.Button btn_chiave_stringa_decriptaggio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_chiave_stringa;
        private System.Windows.Forms.TextBox txt_chiave_variabile_decriptaggio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_chiave_fissa_criptaggio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
    }
}

