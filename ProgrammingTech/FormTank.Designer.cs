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
			this.pictureTank = new System.Windows.Forms.PictureBox();
			this.buttonCreate = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureTank)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureTank
			// 
			this.pictureTank.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureTank.Location = new System.Drawing.Point(0, 0);
			this.pictureTank.Name = "pictureTank";
			this.pictureTank.Size = new System.Drawing.Size(800, 450);
			this.pictureTank.TabIndex = 0;
			this.pictureTank.TabStop = false;
			// 
			// buttonCreate
			// 
			this.buttonCreate.Location = new System.Drawing.Point(13, 13);
			this.buttonCreate.Name = "buttonCreate";
			this.buttonCreate.Size = new System.Drawing.Size(75, 23);
			this.buttonCreate.TabIndex = 1;
			this.buttonCreate.Text = "Create";
			this.buttonCreate.UseVisualStyleBackColor = true;
			this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackgroundImage = global::ProgrammingTech.Properties.Resources.Right;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(758, 408);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(30, 30);
			this.buttonRight.TabIndex = 2;
			this.buttonRight.UseVisualStyleBackColor = true;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::ProgrammingTech.Properties.Resources.Down;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(722, 408);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(30, 30);
			this.buttonDown.TabIndex = 3;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::ProgrammingTech.Properties.Resources.Left;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(686, 408);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(30, 30);
			this.buttonLeft.TabIndex = 4;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::ProgrammingTech.Properties.Resources.Up;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(722, 372);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(30, 30);
			this.buttonUp.TabIndex = 5;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// FormTank
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonCreate);
			this.Controls.Add(this.pictureTank);
			this.Name = "FormTank";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Танк";
			((System.ComponentModel.ISupportInitialize)(this.pictureTank)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureTank;
		private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonUp;
	}
}

