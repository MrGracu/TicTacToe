namespace Zad1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1vs1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1vsPC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.l00 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l01 = new System.Windows.Forms.Label();
            this.l02 = new System.Windows.Forms.Label();
            this.l10 = new System.Windows.Forms.Label();
            this.l11 = new System.Windows.Forms.Label();
            this.l12 = new System.Windows.Forms.Label();
            this.l20 = new System.Windows.Forms.Label();
            this.l21 = new System.Windows.Forms.Label();
            this.l22 = new System.Windows.Forms.Label();
            this.trybText = new System.Windows.Forms.Label();
            this.ktoTerazText = new System.Windows.Forms.Label();
            this.plansza = new System.Windows.Forms.GroupBox();
            this.plansza.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1vs1
            // 
            this.button1vs1.Location = new System.Drawing.Point(44, 148);
            this.button1vs1.Name = "button1vs1";
            this.button1vs1.Size = new System.Drawing.Size(258, 48);
            this.button1vs1.TabIndex = 26;
            this.button1vs1.Text = "Graj z innym graczem";
            this.button1vs1.UseVisualStyleBackColor = true;
            this.button1vs1.Click += new System.EventHandler(this.button1vs1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(93, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Kółko Krzyżyk";
            // 
            // button1vsPC
            // 
            this.button1vsPC.Location = new System.Drawing.Point(44, 241);
            this.button1vsPC.Name = "button1vsPC";
            this.button1vsPC.Size = new System.Drawing.Size(258, 48);
            this.button1vsPC.TabIndex = 28;
            this.button1vsPC.Text = "Graj z komputerem";
            this.button1vsPC.UseVisualStyleBackColor = true;
            this.button1vsPC.Click += new System.EventHandler(this.button1vsPC_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(108, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "by Gracjan Mika";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 295);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Gracz zaczyna pierwszy";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(125, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "https://gmika.pl";
            // 
            // l00
            // 
            this.l00.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l00.Location = new System.Drawing.Point(79, 41);
            this.l00.Name = "l00";
            this.l00.Size = new System.Drawing.Size(50, 50);
            this.l00.TabIndex = 13;
            this.l00.Text = "X";
            this.l00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l00.Click += new System.EventHandler(this.l00_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(130, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(2, 154);
            this.label6.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(183, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 154);
            this.label2.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(79, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 2);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(79, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 2);
            this.label4.TabIndex = 17;
            // 
            // l01
            // 
            this.l01.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l01.Location = new System.Drawing.Point(132, 41);
            this.l01.Name = "l01";
            this.l01.Size = new System.Drawing.Size(50, 50);
            this.l01.TabIndex = 18;
            this.l01.Text = "X";
            this.l01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l01.Click += new System.EventHandler(this.l01_Click);
            // 
            // l02
            // 
            this.l02.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l02.Location = new System.Drawing.Point(185, 41);
            this.l02.Name = "l02";
            this.l02.Size = new System.Drawing.Size(50, 50);
            this.l02.TabIndex = 19;
            this.l02.Text = "X";
            this.l02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l02.Click += new System.EventHandler(this.l02_Click);
            // 
            // l10
            // 
            this.l10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l10.Location = new System.Drawing.Point(79, 94);
            this.l10.Name = "l10";
            this.l10.Size = new System.Drawing.Size(50, 50);
            this.l10.TabIndex = 20;
            this.l10.Text = "X";
            this.l10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l10.Click += new System.EventHandler(this.l10_Click);
            // 
            // l11
            // 
            this.l11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l11.Location = new System.Drawing.Point(132, 94);
            this.l11.Name = "l11";
            this.l11.Size = new System.Drawing.Size(50, 50);
            this.l11.TabIndex = 21;
            this.l11.Text = "X";
            this.l11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l11.Click += new System.EventHandler(this.l11_Click);
            // 
            // l12
            // 
            this.l12.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l12.Location = new System.Drawing.Point(185, 94);
            this.l12.Name = "l12";
            this.l12.Size = new System.Drawing.Size(50, 50);
            this.l12.TabIndex = 22;
            this.l12.Text = "X";
            this.l12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l12.Click += new System.EventHandler(this.l12_Click);
            // 
            // l20
            // 
            this.l20.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l20.Location = new System.Drawing.Point(79, 147);
            this.l20.Name = "l20";
            this.l20.Size = new System.Drawing.Size(50, 50);
            this.l20.TabIndex = 23;
            this.l20.Text = "X";
            this.l20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l20.Click += new System.EventHandler(this.l20_Click);
            // 
            // l21
            // 
            this.l21.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l21.Location = new System.Drawing.Point(132, 147);
            this.l21.Name = "l21";
            this.l21.Size = new System.Drawing.Size(50, 50);
            this.l21.TabIndex = 24;
            this.l21.Text = "X";
            this.l21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l21.Click += new System.EventHandler(this.l21_Click);
            // 
            // l22
            // 
            this.l22.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l22.Location = new System.Drawing.Point(185, 147);
            this.l22.Name = "l22";
            this.l22.Size = new System.Drawing.Size(50, 50);
            this.l22.TabIndex = 25;
            this.l22.Text = "X";
            this.l22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l22.Click += new System.EventHandler(this.l22_Click);
            // 
            // trybText
            // 
            this.trybText.Location = new System.Drawing.Point(6, 12);
            this.trybText.Name = "trybText";
            this.trybText.Size = new System.Drawing.Size(304, 23);
            this.trybText.TabIndex = 26;
            this.trybText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ktoTerazText
            // 
            this.ktoTerazText.Location = new System.Drawing.Point(6, 211);
            this.ktoTerazText.Name = "ktoTerazText";
            this.ktoTerazText.Size = new System.Drawing.Size(304, 23);
            this.ktoTerazText.TabIndex = 27;
            this.ktoTerazText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plansza
            // 
            this.plansza.BackColor = System.Drawing.SystemColors.Control;
            this.plansza.Controls.Add(this.ktoTerazText);
            this.plansza.Controls.Add(this.trybText);
            this.plansza.Controls.Add(this.l22);
            this.plansza.Controls.Add(this.l21);
            this.plansza.Controls.Add(this.l20);
            this.plansza.Controls.Add(this.l12);
            this.plansza.Controls.Add(this.l11);
            this.plansza.Controls.Add(this.l10);
            this.plansza.Controls.Add(this.l02);
            this.plansza.Controls.Add(this.l01);
            this.plansza.Controls.Add(this.label4);
            this.plansza.Controls.Add(this.label3);
            this.plansza.Controls.Add(this.label2);
            this.plansza.Controls.Add(this.label6);
            this.plansza.Controls.Add(this.l00);
            this.plansza.Location = new System.Drawing.Point(12, 4);
            this.plansza.Name = "plansza";
            this.plansza.Size = new System.Drawing.Size(316, 336);
            this.plansza.TabIndex = 29;
            this.plansza.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 352);
            this.Controls.Add(this.plansza);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1vs1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1vsPC);
            this.Controls.Add(this.label7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kółko Krzyżyk GM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plansza.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1vs1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1vsPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l00;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l01;
        private System.Windows.Forms.Label l02;
        private System.Windows.Forms.Label l10;
        private System.Windows.Forms.Label l11;
        private System.Windows.Forms.Label l12;
        private System.Windows.Forms.Label l20;
        private System.Windows.Forms.Label l21;
        private System.Windows.Forms.Label l22;
        private System.Windows.Forms.Label trybText;
        private System.Windows.Forms.Label ktoTerazText;
        private System.Windows.Forms.GroupBox plansza;
    }
}

