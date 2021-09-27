
namespace MinaProjekt
{
	partial class Form1
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
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblPersonNr = new System.Windows.Forms.Label();
            this.lblDistrikt = new System.Windows.Forms.Label();
            this.lblAntalArtiklar = new System.Windows.Forms.Label();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.tbxDistrikt = new System.Windows.Forms.TextBox();
            this.tbxAntalArtiklar = new System.Windows.Forms.TextBox();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.btnResultat = new System.Windows.Forms.Button();
            this.tbxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Location = new System.Drawing.Point(181, 105);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(74, 25);
            this.lblNamn.TabIndex = 0;
            this.lblNamn.Text = "Namn:";
            // 
            // lblPersonNr
            // 
            this.lblPersonNr.AutoSize = true;
            this.lblPersonNr.Location = new System.Drawing.Point(181, 186);
            this.lblPersonNr.Name = "lblPersonNr";
            this.lblPersonNr.Size = new System.Drawing.Size(163, 25);
            this.lblPersonNr.TabIndex = 1;
            this.lblPersonNr.Text = "Personnummer:";
            // 
            // lblDistrikt
            // 
            this.lblDistrikt.AutoSize = true;
            this.lblDistrikt.Location = new System.Drawing.Point(181, 272);
            this.lblDistrikt.Name = "lblDistrikt";
            this.lblDistrikt.Size = new System.Drawing.Size(84, 25);
            this.lblDistrikt.TabIndex = 2;
            this.lblDistrikt.Text = "Distrikt:";
            // 
            // lblAntalArtiklar
            // 
            this.lblAntalArtiklar.AutoSize = true;
            this.lblAntalArtiklar.Location = new System.Drawing.Point(181, 350);
            this.lblAntalArtiklar.Name = "lblAntalArtiklar";
            this.lblAntalArtiklar.Size = new System.Drawing.Size(138, 25);
            this.lblAntalArtiklar.TabIndex = 3;
            this.lblAntalArtiklar.Text = "Antal artiklar:";
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(408, 105);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(224, 31);
            this.tbxNamn.TabIndex = 4;
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(408, 186);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(224, 31);
            this.tbxPersonNr.TabIndex = 5;
            // 
            // tbxDistrikt
            // 
            this.tbxDistrikt.Location = new System.Drawing.Point(408, 272);
            this.tbxDistrikt.Name = "tbxDistrikt";
            this.tbxDistrikt.Size = new System.Drawing.Size(224, 31);
            this.tbxDistrikt.TabIndex = 6;
            // 
            // tbxAntalArtiklar
            // 
            this.tbxAntalArtiklar.Location = new System.Drawing.Point(408, 350);
            this.tbxAntalArtiklar.Name = "tbxAntalArtiklar";
            this.tbxAntalArtiklar.Size = new System.Drawing.Size(224, 31);
            this.tbxAntalArtiklar.TabIndex = 7;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(175, 500);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(183, 53);
            this.btnLäggTill.TabIndex = 8;
            this.btnLäggTill.Text = "Lägg till säljare";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // btnResultat
            // 
            this.btnResultat.Location = new System.Drawing.Point(472, 500);
            this.btnResultat.Name = "btnResultat";
            this.btnResultat.Size = new System.Drawing.Size(160, 53);
            this.btnResultat.TabIndex = 9;
            this.btnResultat.Text = "Se resultat";
            this.btnResultat.UseVisualStyleBackColor = true;
            this.btnResultat.Click += new System.EventHandler(this.btnResultat_Click);
            // 
            // tbxResultat
            // 
            this.tbxResultat.Location = new System.Drawing.Point(966, 89);
            this.tbxResultat.Multiline = true;
            this.tbxResultat.Name = "tbxResultat";
            this.tbxResultat.Size = new System.Drawing.Size(778, 488);
            this.tbxResultat.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2740, 1783);
            this.Controls.Add(this.tbxResultat);
            this.Controls.Add(this.btnResultat);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.tbxAntalArtiklar);
            this.Controls.Add(this.tbxDistrikt);
            this.Controls.Add(this.tbxPersonNr);
            this.Controls.Add(this.tbxNamn);
            this.Controls.Add(this.lblAntalArtiklar);
            this.Controls.Add(this.lblDistrikt);
            this.Controls.Add(this.lblPersonNr);
            this.Controls.Add(this.lblNamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNamn;
		private System.Windows.Forms.Label lblPersonNr;
		private System.Windows.Forms.Label lblDistrikt;
		private System.Windows.Forms.Label lblAntalArtiklar;
		private System.Windows.Forms.TextBox tbxNamn;
		private System.Windows.Forms.TextBox tbxPersonNr;
		private System.Windows.Forms.TextBox tbxDistrikt;
		private System.Windows.Forms.TextBox tbxAntalArtiklar;
		private System.Windows.Forms.Button btnLäggTill;
		private System.Windows.Forms.Button btnResultat;
		private System.Windows.Forms.TextBox tbxResultat;
	}
}

