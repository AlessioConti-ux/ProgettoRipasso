namespace ProgettoRipasso
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
            lbltitolo = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtArticolo = new TextBox();
            txtPrezzo = new TextBox();
            txtQuantita = new TextBox();
            btnAggiungi = new Button();
            button4 = new Button();
            label4 = new Label();
            listBox = new ListBox();
            panel2 = new Panel();
            button5 = new Button();
            lblPrezzo = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbltitolo
            // 
            lbltitolo.AutoSize = true;
            lbltitolo.BackColor = Color.FromArgb(30, 37, 50);
            lbltitolo.Font = new Font("Segoe UI", 18F);
            lbltitolo.ForeColor = Color.Snow;
            lbltitolo.Location = new Point(3, 1);
            lbltitolo.Name = "lbltitolo";
            lbltitolo.Size = new Size(382, 32);
            lbltitolo.TabIndex = 0;
            lbltitolo.Text = "POS Cassa & Ordini v1.0 - [Running]";
            lbltitolo.Click += lbltitolo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 37, 50);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lbltitolo);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 43);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.ForeColor = SystemColors.ActiveCaption;
            button2.Location = new Point(727, 10);
            button2.Name = "button2";
            button2.Size = new Size(27, 23);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(760, 10);
            button1.Name = "button1";
            button1.Size = new Size(27, 23);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(23, 86);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "Descrizione articolo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(23, 155);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 3;
            label2.Text = "Prezzo: ($):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = SystemColors.AppWorkspace;
            label3.Location = new Point(191, 155);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 4;
            label3.Text = "Quantita':";
            // 
            // txtArticolo
            // 
            txtArticolo.BackColor = Color.FromArgb(30, 37, 50);
            txtArticolo.BorderStyle = BorderStyle.None;
            txtArticolo.Font = new Font("Segoe UI", 13F);
            txtArticolo.ForeColor = SystemColors.Window;
            txtArticolo.Location = new Point(23, 109);
            txtArticolo.Name = "txtArticolo";
            txtArticolo.Size = new Size(315, 24);
            txtArticolo.TabIndex = 5;
            // 
            // txtPrezzo
            // 
            txtPrezzo.BackColor = Color.FromArgb(30, 37, 50);
            txtPrezzo.BorderStyle = BorderStyle.None;
            txtPrezzo.Font = new Font("Segoe UI", 13F);
            txtPrezzo.ForeColor = SystemColors.Window;
            txtPrezzo.Location = new Point(23, 178);
            txtPrezzo.Name = "txtPrezzo";
            txtPrezzo.Size = new Size(144, 24);
            txtPrezzo.TabIndex = 6;
            txtPrezzo.TextChanged += textBox2_TextChanged;
            // 
            // txtQuantita
            // 
            txtQuantita.BackColor = Color.FromArgb(30, 37, 50);
            txtQuantita.BorderStyle = BorderStyle.None;
            txtQuantita.Font = new Font("Segoe UI", 13F);
            txtQuantita.ForeColor = SystemColors.Window;
            txtQuantita.Location = new Point(191, 178);
            txtQuantita.Name = "txtQuantita";
            txtQuantita.Size = new Size(147, 24);
            txtQuantita.TabIndex = 7;
            // 
            // btnAggiungi
            // 
            btnAggiungi.BackColor = Color.Cyan;
            btnAggiungi.FlatAppearance.BorderSize = 0;
            btnAggiungi.FlatStyle = FlatStyle.Flat;
            btnAggiungi.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAggiungi.Location = new Point(23, 225);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(315, 50);
            btnAggiungi.TabIndex = 8;
            btnAggiungi.Text = "+ Aggiungi Voce";
            btnAggiungi.UseVisualStyleBackColor = false;
            btnAggiungi.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(23, 289);
            button4.Name = "button4";
            button4.Size = new Size(315, 50);
            button4.TabIndex = 9;
            button4.Text = "Rimuovi Selezionato";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(388, 77);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 10;
            label4.Text = "Riepilogo Carrello (List Box):";
            // 
            // listBox
            // 
            listBox.BackColor = Color.FromArgb(30, 37, 50);
            listBox.BorderStyle = BorderStyle.None;
            listBox.Font = new Font("Segoe UI", 13F);
            listBox.ForeColor = SystemColors.ScrollBar;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 23;
            listBox.Location = new Point(388, 109);
            listBox.Name = "listBox";
            listBox.Size = new Size(390, 230);
            listBox.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 37, 50);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(lblPrezzo);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(23, 350);
            panel2.Name = "panel2";
            panel2.Size = new Size(755, 88);
            panel2.TabIndex = 12;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(478, 14);
            button5.Name = "button5";
            button5.Size = new Size(255, 65);
            button5.TabIndex = 2;
            button5.Text = "💾Emetti Scontrino";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Font = new Font("Segoe UI", 24F);
            lblPrezzo.ForeColor = Color.Lime;
            lblPrezzo.Location = new Point(29, 34);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new Size(0, 45);
            lblPrezzo.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.ForeColor = SystemColors.AppWorkspace;
            label5.Location = new Point(29, 14);
            label5.Name = "label5";
            label5.Size = new Size(211, 20);
            label5.TabIndex = 0;
            label5.Text = "TOTALE DOVUTO ALLA CASSA:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 64, 84);
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(listBox);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(btnAggiungi);
            Controls.Add(txtQuantita);
            Controls.Add(txtPrezzo);
            Controls.Add(txtArticolo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitolo;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtArticolo;
        private TextBox txtPrezzo;
        private TextBox txtQuantita;
        private Button btnAggiungi;
        private Button button4;
        private Label label4;
        private ListBox listBox;
        private Panel panel2;
        private Label lblPrezzo;
        private Label label5;
        private Button button5;
    }
}
