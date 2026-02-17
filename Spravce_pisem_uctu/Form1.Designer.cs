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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblCas = new System.Windows.Forms.Label();
            this.numMinuty = new System.Windows.Forms.NumericUpDown();
            this.btnStartCasovac = new System.Windows.Forms.Button();
            this.btnNacistPisemky = new System.Windows.Forms.Button();
            this.btnNacistStudenty = new System.Windows.Forms.Button();
            this.btnVytvoritAdresare = new System.Windows.Forms.Button();
            this.btnKopirovatZadani = new System.Windows.Forms.Button();
            this.btnPlus5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listStudenti = new System.Windows.Forms.ListBox();
            this.listPisemky = new System.Windows.Forms.ListBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuty)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.78862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.21138F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 492);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdmin, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblCas, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.numMinuty, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnStartCasovac, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNacistPisemky, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNacistStudenty, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVytvoritAdresare, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnKopirovatZadani, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPlus5, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(919, 171);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.MediumPurple;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmin.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmin.Location = new System.Drawing.Point(569, 90);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(151, 76);
            this.btnAdmin.TabIndex = 35;
            this.btnAdmin.Text = "Odevzdání";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblCas
            // 
            this.lblCas.AutoSize = true;
            this.lblCas.BackColor = System.Drawing.Color.FloralWhite;
            this.lblCas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCas.ForeColor = System.Drawing.Color.Red;
            this.lblCas.Location = new System.Drawing.Point(728, 0);
            this.lblCas.Name = "lblCas";
            this.lblCas.Size = new System.Drawing.Size(188, 85);
            this.lblCas.TabIndex = 34;
            this.lblCas.Text = "---";
            // 
            // numMinuty
            // 
            this.numMinuty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.numMinuty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMinuty.Location = new System.Drawing.Point(567, 3);
            this.numMinuty.Name = "numMinuty";
            this.numMinuty.Size = new System.Drawing.Size(155, 20);
            this.numMinuty.TabIndex = 33;
            // 
            // btnStartCasovac
            // 
            this.btnStartCasovac.BackColor = System.Drawing.Color.MediumPurple;
            this.btnStartCasovac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartCasovac.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStartCasovac.Location = new System.Drawing.Point(355, 5);
            this.btnStartCasovac.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartCasovac.Name = "btnStartCasovac";
            this.btnStartCasovac.Size = new System.Drawing.Size(204, 75);
            this.btnStartCasovac.TabIndex = 26;
            this.btnStartCasovac.Text = "Start časovače";
            this.btnStartCasovac.UseVisualStyleBackColor = false;
            this.btnStartCasovac.Click += new System.EventHandler(this.btnStartCasovac_Click_1);
            // 
            // btnNacistPisemky
            // 
            this.btnNacistPisemky.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNacistPisemky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNacistPisemky.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNacistPisemky.Location = new System.Drawing.Point(180, 5);
            this.btnNacistPisemky.Margin = new System.Windows.Forms.Padding(5);
            this.btnNacistPisemky.Name = "btnNacistPisemky";
            this.btnNacistPisemky.Size = new System.Drawing.Size(165, 75);
            this.btnNacistPisemky.TabIndex = 24;
            this.btnNacistPisemky.Text = "Nacti pisemky";
            this.btnNacistPisemky.UseVisualStyleBackColor = false;
            this.btnNacistPisemky.Click += new System.EventHandler(this.btnNacistPisemky_Click_1);
            // 
            // btnNacistStudenty
            // 
            this.btnNacistStudenty.BackColor = System.Drawing.Color.MediumPurple;
            this.btnNacistStudenty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNacistStudenty.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNacistStudenty.Location = new System.Drawing.Point(5, 5);
            this.btnNacistStudenty.Margin = new System.Windows.Forms.Padding(5);
            this.btnNacistStudenty.Name = "btnNacistStudenty";
            this.btnNacistStudenty.Size = new System.Drawing.Size(165, 75);
            this.btnNacistStudenty.TabIndex = 23;
            this.btnNacistStudenty.Text = "Nacti studenty";
            this.btnNacistStudenty.UseVisualStyleBackColor = false;
            this.btnNacistStudenty.Click += new System.EventHandler(this.btnNacistStudenty_Click_1);
            // 
            // btnVytvoritAdresare
            // 
            this.btnVytvoritAdresare.BackColor = System.Drawing.Color.MediumPurple;
            this.btnVytvoritAdresare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVytvoritAdresare.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVytvoritAdresare.Location = new System.Drawing.Point(5, 90);
            this.btnVytvoritAdresare.Margin = new System.Windows.Forms.Padding(5);
            this.btnVytvoritAdresare.Name = "btnVytvoritAdresare";
            this.btnVytvoritAdresare.Size = new System.Drawing.Size(165, 76);
            this.btnVytvoritAdresare.TabIndex = 27;
            this.btnVytvoritAdresare.Text = "Vytvořit adresáře";
            this.btnVytvoritAdresare.UseVisualStyleBackColor = false;
            this.btnVytvoritAdresare.Click += new System.EventHandler(this.btnVytvoritAdresare_Click_1);
            // 
            // btnKopirovatZadani
            // 
            this.btnKopirovatZadani.BackColor = System.Drawing.Color.MediumPurple;
            this.btnKopirovatZadani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKopirovatZadani.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKopirovatZadani.Location = new System.Drawing.Point(180, 90);
            this.btnKopirovatZadani.Margin = new System.Windows.Forms.Padding(5);
            this.btnKopirovatZadani.Name = "btnKopirovatZadani";
            this.btnKopirovatZadani.Size = new System.Drawing.Size(165, 76);
            this.btnKopirovatZadani.TabIndex = 28;
            this.btnKopirovatZadani.Text = "Kopírovat zadání";
            this.btnKopirovatZadani.UseVisualStyleBackColor = false;
            this.btnKopirovatZadani.Click += new System.EventHandler(this.btnKopirovatZadani_Click_1);
            // 
            // btnPlus5
            // 
            this.btnPlus5.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPlus5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlus5.Location = new System.Drawing.Point(355, 90);
            this.btnPlus5.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlus5.Name = "btnPlus5";
            this.btnPlus5.Size = new System.Drawing.Size(204, 76);
            this.btnPlus5.TabIndex = 29;
            this.btnPlus5.Text = "+ 5 minut";
            this.btnPlus5.UseVisualStyleBackColor = false;
            this.btnPlus5.Click += new System.EventHandler(this.btnPlus5_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.30769F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.69231F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel3.Controls.Add(this.listStudenti, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.listPisemky, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.listLog, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(923, 305);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // listStudenti
            // 
            this.listStudenti.BackColor = System.Drawing.SystemColors.InfoText;
            this.listStudenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listStudenti.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listStudenti.ForeColor = System.Drawing.Color.LawnGreen;
            this.listStudenti.FormattingEnabled = true;
            this.listStudenti.ItemHeight = 15;
            this.listStudenti.Location = new System.Drawing.Point(701, 3);
            this.listStudenti.Name = "listStudenti";
            this.listStudenti.Size = new System.Drawing.Size(219, 299);
            this.listStudenti.TabIndex = 10;
            // 
            // listPisemky
            // 
            this.listPisemky.BackColor = System.Drawing.SystemColors.InfoText;
            this.listPisemky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPisemky.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listPisemky.ForeColor = System.Drawing.Color.LawnGreen;
            this.listPisemky.FormattingEnabled = true;
            this.listPisemky.ItemHeight = 15;
            this.listPisemky.Location = new System.Drawing.Point(452, 3);
            this.listPisemky.Name = "listPisemky";
            this.listPisemky.Size = new System.Drawing.Size(243, 299);
            this.listPisemky.TabIndex = 9;
            // 
            // listLog
            // 
            this.listLog.BackColor = System.Drawing.SystemColors.InfoText;
            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listLog.ForeColor = System.Drawing.Color.LawnGreen;
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 15;
            this.listLog.Location = new System.Drawing.Point(3, 3);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(443, 299);
            this.listLog.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(929, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Snow;
            this.MinimumSize = new System.Drawing.Size(921, 531);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinuty)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNacistStudenty;
        private System.Windows.Forms.Button btnNacistPisemky;
        private System.Windows.Forms.Button btnStartCasovac;
        private System.Windows.Forms.Button btnVytvoritAdresare;
        private System.Windows.Forms.Button btnKopirovatZadani;
        private System.Windows.Forms.Button btnPlus5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.ListBox listPisemky;
        private System.Windows.Forms.ListBox listStudenti;
        private System.Windows.Forms.Label lblCas;
        private System.Windows.Forms.NumericUpDown numMinuty;
        private System.Windows.Forms.Button btnAdmin;
    }
}

