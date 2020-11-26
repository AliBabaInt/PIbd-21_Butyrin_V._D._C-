namespace ProgrammingTech
{
	partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonArmoredVehicle = new System.Windows.Forms.Button();
            this.buttonTank = new System.Windows.Forms.Button();
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxTake.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(14, 14);
            this.pictureBoxParking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(758, 492);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonArmoredVehicle
            // 
            this.buttonArmoredVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonArmoredVehicle.Location = new System.Drawing.Point(797, 14);
            this.buttonArmoredVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonArmoredVehicle.Name = "buttonArmoredVehicle";
            this.buttonArmoredVehicle.Size = new System.Drawing.Size(139, 55);
            this.buttonArmoredVehicle.TabIndex = 1;
            this.buttonArmoredVehicle.Text = "Припарковать БТР";
            this.buttonArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonArmoredVehicle.Click += new System.EventHandler(this.buttonArmoredVehicle_Click);
            // 
            // buttonTank
            // 
            this.buttonTank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTank.Location = new System.Drawing.Point(797, 76);
            this.buttonTank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTank.Name = "buttonTank";
            this.buttonTank.Size = new System.Drawing.Size(139, 55);
            this.buttonTank.TabIndex = 2;
            this.buttonTank.Text = "Припарковать танк";
            this.buttonTank.UseVisualStyleBackColor = true;
            this.buttonTank.Click += new System.EventHandler(this.buttonTank_Click);
            // 
            // groupBoxTake
            // 
            this.groupBoxTake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTake.Controls.Add(this.buttonTake);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Location = new System.Drawing.Point(798, 154);
            this.groupBoxTake.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTake.Name = "groupBoxTake";
            this.groupBoxTake.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxTake.Size = new System.Drawing.Size(139, 137);
            this.groupBoxTake.TabIndex = 3;
            this.groupBoxTake.TabStop = false;
            this.groupBoxTake.Text = "Забрать технику";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(28, 92);
            this.buttonTake.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(88, 27);
            this.buttonTake.TabIndex = 2;
            this.buttonTake.Text = "Забрать";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(68, 33);
            this.maskedTextBoxPlace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(47, 23);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(8, 37);
            this.labelPlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(48, 15);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место: ";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 519);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.buttonTank);
            this.Controls.Add(this.buttonArmoredVehicle);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button buttonArmoredVehicle;
		private System.Windows.Forms.Button buttonTank;
		private System.Windows.Forms.GroupBox groupBoxTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.Button buttonTake;
	}
}