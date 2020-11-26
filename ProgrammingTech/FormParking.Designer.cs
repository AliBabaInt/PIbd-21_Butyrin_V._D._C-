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
            this.groupBoxTake = new System.Windows.Forms.GroupBox();
            this.buttonTake = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.listBoxParking = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
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
            // groupBoxTake
            // 
            this.groupBoxTake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTake.Controls.Add(this.buttonTake);
            this.groupBoxTake.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxTake.Controls.Add(this.labelPlace);
            this.groupBoxTake.Location = new System.Drawing.Point(780, 380);
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
            // listBoxParking
            // 
            this.listBoxParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxParking.FormattingEnabled = true;
            this.listBoxParking.ItemHeight = 15;
            this.listBoxParking.Location = new System.Drawing.Point(780, 102);
            this.listBoxParking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxParking.Name = "listBoxParking";
            this.listBoxParking.Size = new System.Drawing.Size(137, 109);
            this.listBoxParking.TabIndex = 4;
            this.listBoxParking.SelectedIndexChanged += new System.EventHandler(this.listBoxParking_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Парковки";
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddParking.Location = new System.Drawing.Point(779, 62);
            this.buttonAddParking.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(139, 27);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(779, 218);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 27);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить парковку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLevel.Location = new System.Drawing.Point(780, 32);
            this.textBoxLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(137, 23);
            this.textBoxLevel.TabIndex = 8;
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Location = new System.Drawing.Point(779, 307);
            this.buttonAddVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(138, 67);
            this.buttonAddVehicle.TabIndex = 10;
            this.buttonAddVehicle.Text = "Добавить технику";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxParking);
            this.Controls.Add(this.groupBoxTake);
            this.Controls.Add(this.pictureBoxParking);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxTake.ResumeLayout(false);
            this.groupBoxTake.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.GroupBox groupBoxTake;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.ListBox listBoxParking;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAddParking;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxLevel;
		private System.Windows.Forms.Button buttonAddVehicle;
	}
}