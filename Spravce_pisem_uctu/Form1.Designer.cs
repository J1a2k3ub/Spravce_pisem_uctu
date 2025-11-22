namespace Spravce_pisem_uctu
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNacistPisemky = new System.Windows.Forms.Button();
            this.btnNacistStudenty = new System.Windows.Forms.Button();
            this.btnVytvoritAdresare = new System.Windows.Forms.Button();
            this.btnKopirovatZadani = new System.Windows.Forms.Button();
            this.btnStartCasovac = new System.Windows.Forms.Button();
            this.btnPlus5 = new System.Windows.Forms.Button();
            this.listLog = new System.Windows.Forms.ListBox();
            this.lblCas = new System.Windows.Forms.Label();
            this.listPisemky = new System.Windows.Forms.ListBox();
            this.listStudenti = new System.Windows.Forms.ListBox();
            this.numMinuty = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numMinuty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNacistPisemky
            // 
            this.btnNacistPisemky.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNacistPisemky.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNacistPisemky.Location = new System.Drawing.Point(218, 59);
            this.btnNacistPisemky.Name = "btnNacistPisemky";
            this.btnNacistPisemky.Size = new System.Drawing.Size(177, 59);
            this.btnNacistPisemky.TabIndex = 0;
            this.btnNacistPisemky.Text = "Nacti pisemky";
            this.btnNacistPisemky.UseVisualStyleBackColor = false;
            this.btnNacistPisemky.Click += new System.EventHandler(this.btnNacistPisemky_Click);
            // 
            // btnNacistStudenty
            // 
            this.btnNacistStudenty.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNacistStudenty.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNacistStudenty.Location = new System.Drawing.Point(26, 59);
            this.btnNacistStudenty.Name = "btnNacistStudenty";
            this.btnNacistStudenty.Size = new System.Drawing.Size(177, 59);
            this.btnNacistStudenty.TabIndex = 1;
            this.btnNacistStudenty.Text = "Nacti studenty";
            this.btnNacistStudenty.UseVisualStyleBackColor = false;
            this.btnNacistStudenty.Click += new System.EventHandler(this.btnNacistStudenty_Click);
            // 
            // btnVytvoritAdresare
            // 
            this.btnVytvoritAdresare.BackColor = System.Drawing.Color.MediumPurple;
            this.btnVytvoritAdresare.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVytvoritAdresare.Location = new System.Drawing.Point(26, 122);
            this.btnVytvoritAdresare.Name = "btnVytvoritAdresare";
            this.btnVytvoritAdresare.Size = new System.Drawing.Size(177, 59);
            this.btnVytvoritAdresare.TabIndex = 2;
            this.btnVytvoritAdresare.Text = "Vytvořit adresáře";
            this.btnVytvoritAdresare.UseVisualStyleBackColor = false;
            this.btnVytvoritAdresare.Click += new System.EventHandler(this.btnVytvoritAdresare_Click);
            // 
            // btnKopirovatZadani
            // 
            this.btnKopirovatZadani.BackColor = System.Drawing.Color.MediumPurple;
            this.btnKopirovatZadani.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKopirovatZadani.Location = new System.Drawing.Point(218, 126);
            this.btnKopirovatZadani.Name = "btnKopirovatZadani";
            this.btnKopirovatZadani.Size = new System.Drawing.Size(177, 59);
            this.btnKopirovatZadani.TabIndex = 3;
            this.btnKopirovatZadani.Text = "Kopírovat zadání";
            this.btnKopirovatZadani.UseVisualStyleBackColor = false;
            this.btnKopirovatZadani.Click += new System.EventHandler(this.btnKopirovatZadani_Click);
            // 
            // btnStartCasovac
            // 
            this.btnStartCasovac.BackColor = System.Drawing.Color.MediumPurple;
            this.btnStartCasovac.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartCasovac.Location = new System.Drawing.Point(418, 59);
            this.btnStartCasovac.Name = "btnStartCasovac";
            this.btnStartCasovac.Size = new System.Drawing.Size(177, 59);
            this.btnStartCasovac.TabIndex = 4;
            this.btnStartCasovac.Text = "Start časovače";
            this.btnStartCasovac.UseVisualStyleBackColor = false;
            this.btnStartCasovac.Click += new System.EventHandler(this.btnStartCasovac_Click);
            // 
            // btnPlus5
            // 
            this.btnPlus5.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPlus5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlus5.Location = new System.Drawing.Point(418, 124);
            this.btnPlus5.Name = "btnPlus5";
            this.btnPlus5.Size = new System.Drawing.Size(177, 59);
            this.btnPlus5.TabIndex = 5;
            this.btnPlus5.Text = "+ 5 minut";
            this.btnPlus5.UseVisualStyleBackColor = false;
            this.btnPlus5.Click += new System.EventHandler(this.btnPlus5_Click);
            // 
            // listLog
            // 
            this.listLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.listLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listLog.ForeColor = System.Drawing.Color.LawnGreen;
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 15;
            this.listLog.Location = new System.Drawing.Point(12, 199);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(383, 244);
            this.listLog.TabIndex = 6;
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.BackColor = System.Drawing.Color.FloralWhite;
            this.lblCas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCas.ForeColor = System.Drawing.Color.Red;
            this.lblCas.Location = new System.Drawing.Point(698, 95);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(19, 14);
            this.lblCas.TabIndex = 7;
            this.lblCas.Text = "---";
            // 
            // listPisemky
            // 
            this.listPisemky.BackColor = System.Drawing.SystemColors.InfoText;
            this.listPisemky.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listPisemky.ForeColor = System.Drawing.Color.LawnGreen;
            this.listPisemky.FormattingEnabled = true;
            this.listPisemky.ItemHeight = 15;
            this.listPisemky.Location = new System.Drawing.Point(418, 199);
            this.listPisemky.Name = "listPisemky";
            this.listPisemky.Size = new System.Drawing.Size(197, 244);
            this.listPisemky.TabIndex = 8;
            // 
            // listStudenti
            // 
            this.listStudenti.BackColor = System.Drawing.SystemColors.InfoText;
            this.listStudenti.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listStudenti.ForeColor = System.Drawing.Color.LawnGreen;
            this.listStudenti.FormattingEnabled = true;
            this.listStudenti.ItemHeight = 15;
            this.listStudenti.Location = new System.Drawing.Point(639, 199);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(190, 244);
            this.listStudenti.TabIndex = 9;
            // 
            // numMinuty
            // 
            this.numMinuty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.numMinuty.Location = new System.Drawing.Point(448, 33);
            this.numMinuty.Name = "numMinuty";
            this.numMinuty.Size = new System.Drawing.Size(120, 20);
            this.numMinuty.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(850, 479);
            this.Controls.Add(this.numMinuty);
            this.Controls.Add(this.listStudenti);
            this.Controls.Add(this.listPisemky);
            this.Controls.Add(this.lblCas);
            this.Controls.Add(this.listLog);
            this.Controls.Add(this.btnPlus5);
            this.Controls.Add(this.btnStartCasovac);
            this.Controls.Add(this.btnKopirovatZadani);
            this.Controls.Add(this.btnVytvoritAdresare);
            this.Controls.Add(this.btnNacistStudenty);
            this.Controls.Add(this.btnNacistPisemky);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numMinuty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNacistPisemky;
        private System.Windows.Forms.Button btnNacistStudenty;
        private System.Windows.Forms.Button btnVytvoritAdresare;
        private System.Windows.Forms.Button btnKopirovatZadani;
        private System.Windows.Forms.Button btnStartCasovac;
        private System.Windows.Forms.Button btnPlus5;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.ListBox listPisemky;
        private System.Windows.Forms.ListBox listStudenti;
        private System.Windows.Forms.NumericUpDown numMinuty;
        private System.Windows.Forms.Timer timer;
    }
}

