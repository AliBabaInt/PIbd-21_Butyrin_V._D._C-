namespace ProgrammingTech
{
	partial class FormTank
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTank));
            this.pictureTank = new System.Windows.Forms.PictureBox();
            this.buttonCreateTank = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonCreateArmoredVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTank)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureTank
            // 
            this.pictureTank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureTank.Location = new System.Drawing.Point(0, 0);
            this.pictureTank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureTank.Name = "pictureTank";
            this.pictureTank.Size = new System.Drawing.Size(933, 519);
            this.pictureTank.TabIndex = 0;
            this.pictureTank.TabStop = false;
            // 
            // buttonCreateTank
            // 
            this.buttonCreateTank.Location = new System.Drawing.Point(15, 15);
            this.buttonCreateTank.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateTank.Name = "buttonCreateTank";
            this.buttonCreateTank.Size = new System.Drawing.Size(88, 27);
            this.buttonCreateTank.TabIndex = 1;
            this.buttonCreateTank.Text = "Создать танк";
            this.buttonCreateTank.UseVisualStyleBackColor = true;
            this.buttonCreateTank.Click += new System.EventHandler(this.buttonCreateTank_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(884, 471);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(35, 35);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(842, 471);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(35, 35);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(800, 471);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(35, 35);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(842, 429);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(35, 35);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateArmoredVehicle
            // 
            this.buttonCreateArmoredVehicle.Location = new System.Drawing.Point(111, 15);
            this.buttonCreateArmoredVehicle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCreateArmoredVehicle.Name = "buttonCreateArmoredVehicle";
            this.buttonCreateArmoredVehicle.Size = new System.Drawing.Size(88, 27);
            this.buttonCreateArmoredVehicle.TabIndex = 6;
            this.buttonCreateArmoredVehicle.Text = "Создать БТР";
            this.buttonCreateArmoredVehicle.UseVisualStyleBackColor = true;
            this.buttonCreateArmoredVehicle.Click += new System.EventHandler(this.buttonCreateArmoredVehicle_Click);
            // 
            // FormTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.buttonCreateArmoredVehicle);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCreateTank);
            this.Controls.Add(this.pictureTank);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormTank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Танк";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTank)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureTank;
		private System.Windows.Forms.Button buttonCreateTank;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonCreateArmoredVehicle;
    }
}

