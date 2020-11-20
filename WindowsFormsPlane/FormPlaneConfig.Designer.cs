namespace WindowsFormsPlane
{
	partial class FormPlaneConfig
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
            this.groupBoxBodyType = new System.Windows.Forms.GroupBox();
            this.labelBomberPlane = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.groupBoxParameter = new System.Windows.Forms.GroupBox();
            this.checkBoxTurboEngine = new System.Windows.Forms.CheckBox();
            this.checkBoxBombs = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeightPlane = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupColors = new System.Windows.Forms.GroupBox();
            this.panelDopColor4 = new System.Windows.Forms.Panel();
            this.panelDopColor3 = new System.Windows.Forms.Panel();
            this.panelDopColor2 = new System.Windows.Forms.Panel();
            this.panelDopColor = new System.Windows.Forms.Panel();
            this.panelMainColor4 = new System.Windows.Forms.Panel();
            this.panelMainColor3 = new System.Windows.Forms.Panel();
            this.panelMainColor2 = new System.Windows.Forms.Panel();
            this.panelMainColor = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxBodyType.SuspendLayout();
            this.panelPlane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.groupBoxParameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxBodyType
            // 
            this.groupBoxBodyType.Controls.Add(this.labelBomberPlane);
            this.groupBoxBodyType.Controls.Add(this.labelPlane);
            this.groupBoxBodyType.Location = new System.Drawing.Point(17, 29);
            this.groupBoxBodyType.Name = "groupBoxBodyType";
            this.groupBoxBodyType.Size = new System.Drawing.Size(158, 152);
            this.groupBoxBodyType.TabIndex = 0;
            this.groupBoxBodyType.TabStop = false;
            this.groupBoxBodyType.Text = "Тип кузова";
            // 
            // labelBomberPlane
            // 
            this.labelBomberPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBomberPlane.Location = new System.Drawing.Point(12, 84);
            this.labelBomberPlane.Name = "labelBomberPlane";
            this.labelBomberPlane.Size = new System.Drawing.Size(132, 47);
            this.labelBomberPlane.TabIndex = 1;
            this.labelBomberPlane.Text = "Бомбардировщик";
            this.labelBomberPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBomberPlane_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(12, 25);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(132, 42);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Обычный самолет";
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(181, 29);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(157, 147);
            this.panelPlane.TabIndex = 1;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPlane_DragEnter);
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(16, 16);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(119, 114);
            this.pictureBoxPlane.TabIndex = 0;
            this.pictureBoxPlane.TabStop = false;
            // 
            // groupBoxParameter
            // 
            this.groupBoxParameter.Controls.Add(this.checkBoxTurboEngine);
            this.groupBoxParameter.Controls.Add(this.checkBoxBombs);
            this.groupBoxParameter.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameter.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameter.Controls.Add(this.labelWeightPlane);
            this.groupBoxParameter.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameter.Location = new System.Drawing.Point(17, 187);
            this.groupBoxParameter.Name = "groupBoxParameter";
            this.groupBoxParameter.Size = new System.Drawing.Size(321, 149);
            this.groupBoxParameter.TabIndex = 2;
            this.groupBoxParameter.TabStop = false;
            this.groupBoxParameter.Text = "Параметры";
            // 
            // checkBoxTurboEngine
            // 
            this.checkBoxTurboEngine.AutoSize = true;
            this.checkBoxTurboEngine.Location = new System.Drawing.Point(149, 49);
            this.checkBoxTurboEngine.Name = "checkBoxTurboEngine";
            this.checkBoxTurboEngine.Size = new System.Drawing.Size(161, 17);
            this.checkBoxTurboEngine.TabIndex = 5;
            this.checkBoxTurboEngine.Text = "Наличие турбо двигателей";
            this.checkBoxTurboEngine.UseVisualStyleBackColor = true;
            // 
            // checkBoxBombs
            // 
            this.checkBoxBombs.AutoSize = true;
            this.checkBoxBombs.Location = new System.Drawing.Point(149, 26);
            this.checkBoxBombs.Name = "checkBoxBombs";
            this.checkBoxBombs.Size = new System.Drawing.Size(98, 17);
            this.checkBoxBombs.TabIndex = 4;
            this.checkBoxBombs.Text = "Наличие бомб";
            this.checkBoxBombs.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(18, 118);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(18, 44);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeightPlane
            // 
            this.labelWeightPlane.AutoSize = true;
            this.labelWeightPlane.Location = new System.Drawing.Point(11, 88);
            this.labelWeightPlane.Name = "labelWeightPlane";
            this.labelWeightPlane.Size = new System.Drawing.Size(78, 13);
            this.labelWeightPlane.TabIndex = 1;
            this.labelWeightPlane.Text = "Вес самолета";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(11, 24);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(87, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость";
            // 
            // groupColors
            // 
            this.groupColors.Controls.Add(this.panelDopColor4);
            this.groupColors.Controls.Add(this.panelDopColor3);
            this.groupColors.Controls.Add(this.panelDopColor2);
            this.groupColors.Controls.Add(this.panelDopColor);
            this.groupColors.Controls.Add(this.panelMainColor4);
            this.groupColors.Controls.Add(this.panelMainColor3);
            this.groupColors.Controls.Add(this.panelMainColor2);
            this.groupColors.Controls.Add(this.panelMainColor);
            this.groupColors.Controls.Add(this.labelDopColor);
            this.groupColors.Controls.Add(this.labelMainColor);
            this.groupColors.Location = new System.Drawing.Point(381, 29);
            this.groupColors.Name = "groupColors";
            this.groupColors.Size = new System.Drawing.Size(273, 193);
            this.groupColors.TabIndex = 3;
            this.groupColors.TabStop = false;
            this.groupColors.Text = "Цвета";
            // 
            // panelDopColor4
            // 
            this.panelDopColor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelDopColor4.Location = new System.Drawing.Point(213, 136);
            this.panelDopColor4.Name = "panelDopColor4";
            this.panelDopColor4.Size = new System.Drawing.Size(39, 29);
            this.panelDopColor4.TabIndex = 9;
            // 
            // panelDopColor3
            // 
            this.panelDopColor3.BackColor = System.Drawing.Color.Black;
            this.panelDopColor3.Location = new System.Drawing.Point(153, 132);
            this.panelDopColor3.Name = "panelDopColor3";
            this.panelDopColor3.Size = new System.Drawing.Size(39, 34);
            this.panelDopColor3.TabIndex = 8;
            // 
            // panelDopColor2
            // 
            this.panelDopColor2.BackColor = System.Drawing.Color.Silver;
            this.panelDopColor2.Location = new System.Drawing.Point(213, 79);
            this.panelDopColor2.Name = "panelDopColor2";
            this.panelDopColor2.Size = new System.Drawing.Size(40, 38);
            this.panelDopColor2.TabIndex = 7;
            // 
            // panelDopColor
            // 
            this.panelDopColor.BackColor = System.Drawing.Color.Lime;
            this.panelDopColor.Location = new System.Drawing.Point(153, 80);
            this.panelDopColor.Name = "panelDopColor";
            this.panelDopColor.Size = new System.Drawing.Size(40, 37);
            this.panelDopColor.TabIndex = 6;
            // 
            // panelMainColor4
            // 
            this.panelMainColor4.BackColor = System.Drawing.Color.Black;
            this.panelMainColor4.Location = new System.Drawing.Point(80, 130);
            this.panelMainColor4.Name = "panelMainColor4";
            this.panelMainColor4.Size = new System.Drawing.Size(41, 36);
            this.panelMainColor4.TabIndex = 5;
            // 
            // panelMainColor3
            // 
            this.panelMainColor3.BackColor = System.Drawing.Color.Yellow;
            this.panelMainColor3.Location = new System.Drawing.Point(16, 132);
            this.panelMainColor3.Name = "panelMainColor3";
            this.panelMainColor3.Size = new System.Drawing.Size(42, 35);
            this.panelMainColor3.TabIndex = 4;
            // 
            // panelMainColor2
            // 
            this.panelMainColor2.BackColor = System.Drawing.Color.Lime;
            this.panelMainColor2.Location = new System.Drawing.Point(81, 77);
            this.panelMainColor2.Name = "panelMainColor2";
            this.panelMainColor2.Size = new System.Drawing.Size(41, 40);
            this.panelMainColor2.TabIndex = 3;
            // 
            // panelMainColor
            // 
            this.panelMainColor.BackColor = System.Drawing.Color.Red;
            this.panelMainColor.Location = new System.Drawing.Point(16, 77);
            this.panelMainColor.Name = "panelMainColor";
            this.panelMainColor.Size = new System.Drawing.Size(43, 40);
            this.panelMainColor.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(150, 30);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(114, 34);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(14, 29);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(108, 35);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(381, 231);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 31);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(381, 275);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 31);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlaneConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 338);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupColors);
            this.Controls.Add(this.groupBoxParameter);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBoxBodyType);
            this.Name = "FormPlaneConfig";
            this.Text = "FormPlaneConfig";
            this.groupBoxBodyType.ResumeLayout(false);
            this.panelPlane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.groupBoxParameter.ResumeLayout(false);
            this.groupBoxParameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupColors.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxBodyType;
		private System.Windows.Forms.Label labelBomberPlane;
		private System.Windows.Forms.Label labelPlane;
		private System.Windows.Forms.Panel panelPlane;
		private System.Windows.Forms.PictureBox pictureBoxPlane;
		private System.Windows.Forms.GroupBox groupBoxParameter;
		private System.Windows.Forms.CheckBox checkBoxBombs;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
		private System.Windows.Forms.Label labelWeightPlane;
		private System.Windows.Forms.Label labelMaxSpeed;
		private System.Windows.Forms.CheckBox checkBoxTurboEngine;
		private System.Windows.Forms.GroupBox groupColors;
		private System.Windows.Forms.Panel panelDopColor4;
		private System.Windows.Forms.Panel panelDopColor3;
		private System.Windows.Forms.Panel panelDopColor2;
		private System.Windows.Forms.Panel panelDopColor;
		private System.Windows.Forms.Panel panelMainColor4;
		private System.Windows.Forms.Panel panelMainColor3;
		private System.Windows.Forms.Panel panelMainColor2;
		private System.Windows.Forms.Panel panelMainColor;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}