namespace Spravce_pisem_uctu
{
    partial class Form3
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
            this.btnOdevzdat = new System.Windows.Forms.Button();
            this.btnRedukovany = new System.Windows.Forms.Button();
            this.btnSmazat = new System.Windows.Forms.Button();
            this.btnZpet = new System.Windows.Forms.Button();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOdevzdat
            // 
            this.btnOdevzdat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOdevzdat.Location = new System.Drawing.Point(10, 10);
            this.btnOdevzdat.Margin = new System.Windows.Forms.Padding(10);
            this.btnOdevzdat.Name = "btnOdevzdat";
            this.btnOdevzdat.Size = new System.Drawing.Size(482, 28);
            this.btnOdevzdat.TabIndex = 2;
            this.btnOdevzdat.Text = "Kopírovat práce";
            this.btnOdevzdat.UseVisualStyleBackColor = true;
            this.btnOdevzdat.Click += new System.EventHandler(this.btnOdevzdat_Click);
            // 
            // btnRedukovany
            // 
            this.btnRedukovany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedukovany.Location = new System.Drawing.Point(10, 121);
            this.btnRedukovany.Margin = new System.Windows.Forms.Padding(10);
            this.btnRedukovany.Name = "btnRedukovany";
            this.btnRedukovany.Size = new System.Drawing.Size(482, 28);
            this.btnRedukovany.TabIndex = 3;
            this.btnRedukovany.Text = "Vytvořit redukovaný";
            this.btnRedukovany.UseVisualStyleBackColor = true;
            this.btnRedukovany.Click += new System.EventHandler(this.btnRedukovany_Click);
            // 
            // btnSmazat
            // 
            this.btnSmazat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmazat.Location = new System.Drawing.Point(10, 169);
            this.btnSmazat.Margin = new System.Windows.Forms.Padding(10);
            this.btnSmazat.Name = "btnSmazat";
            this.btnSmazat.Size = new System.Drawing.Size(482, 28);
            this.btnSmazat.TabIndex = 4;
            this.btnSmazat.Text = "Smazat práce studentů";
            this.btnSmazat.UseVisualStyleBackColor = true;
            this.btnSmazat.Click += new System.EventHandler(this.btnSmazat_Click);
            // 
            // btnZpet
            // 
            this.btnZpet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZpet.Location = new System.Drawing.Point(10, 217);
            this.btnZpet.Margin = new System.Windows.Forms.Padding(10);
            this.btnZpet.Name = "btnZpet";
            this.btnZpet.Size = new System.Drawing.Size(482, 29);
            this.btnZpet.TabIndex = 5;
            this.btnZpet.Text = "Zpět";
            this.btnZpet.UseVisualStyleBackColor = true;
            this.btnZpet.Click += new System.EventHandler(this.btnZpet_Click);
            // 
            // txtRegex
            // 
            this.txtRegex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRegex.Location = new System.Drawing.Point(10, 81);
            this.txtRegex.Margin = new System.Windows.Forms.Padding(10);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(482, 20);
            this.txtRegex.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtr souborů (Regex):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnZpet, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnOdevzdat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRegex, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSmazat, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRedukovany, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 256);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 256);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOdevzdat;
        private System.Windows.Forms.Button btnRedukovany;
        private System.Windows.Forms.Button btnSmazat;
        private System.Windows.Forms.Button btnZpet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}