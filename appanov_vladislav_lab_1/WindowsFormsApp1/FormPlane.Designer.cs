namespace WindowsFormsApp1
{
	partial class FormPlane
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
			this.create = new System.Windows.Forms.Button();
			this.buttonRight = new System.Windows.Forms.Button();
			this.buttonDown = new System.Windows.Forms.Button();
			this.buttonLeft = new System.Windows.Forms.Button();
			this.buttonUp = new System.Windows.Forms.Button();
			this.pictureBoxPlans = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlans)).BeginInit();
			this.SuspendLayout();
			// 
			// create
			// 
			this.create.Location = new System.Drawing.Point(21, 12);
			this.create.Name = "create";
			this.create.Size = new System.Drawing.Size(93, 27);
			this.create.TabIndex = 1;
			this.create.Text = "Create";
			this.create.UseVisualStyleBackColor = true;
			this.create.Click += new System.EventHandler(this.create_Click);
			// 
			// buttonRight
			// 
			this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRight.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.buttonRight.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.rightarrows_878801;
			this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonRight.Location = new System.Drawing.Point(837, 398);
			this.buttonRight.Name = "buttonRight";
			this.buttonRight.Size = new System.Drawing.Size(35, 38);
			this.buttonRight.TabIndex = 5;
			this.buttonRight.UseVisualStyleBackColor = false;
			this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonDown
			// 
			this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDown.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.down;
			this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonDown.Location = new System.Drawing.Point(801, 431);
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.Size = new System.Drawing.Size(39, 30);
			this.buttonDown.TabIndex = 4;
			this.buttonDown.UseVisualStyleBackColor = true;
			this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonLeft
			// 
			this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLeft.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.left;
			this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonLeft.Location = new System.Drawing.Point(765, 398);
			this.buttonLeft.Name = "buttonLeft";
			this.buttonLeft.Size = new System.Drawing.Size(37, 38);
			this.buttonLeft.TabIndex = 3;
			this.buttonLeft.UseVisualStyleBackColor = true;
			this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// buttonUp
			// 
			this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonUp.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.right;
			this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.buttonUp.Location = new System.Drawing.Point(801, 369);
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.Size = new System.Drawing.Size(39, 33);
			this.buttonUp.TabIndex = 2;
			this.buttonUp.UseVisualStyleBackColor = true;
			this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
			// 
			// pictureBoxPlans
			// 
			this.pictureBoxPlans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxPlans.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBoxPlans.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxPlans.Name = "pictureBoxPlans";
			this.pictureBoxPlans.Size = new System.Drawing.Size(884, 461);
			this.pictureBoxPlans.TabIndex = 0;
			this.pictureBoxPlans.TabStop = false;
			// 
			// FormPlane
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.buttonRight);
			this.Controls.Add(this.buttonDown);
			this.Controls.Add(this.buttonLeft);
			this.Controls.Add(this.buttonUp);
			this.Controls.Add(this.create);
			this.Controls.Add(this.pictureBoxPlans);
			this.Name = "FormPlane";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlans)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPlans;
		private System.Windows.Forms.Button create;
		private System.Windows.Forms.Button buttonUp;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
	}
}

