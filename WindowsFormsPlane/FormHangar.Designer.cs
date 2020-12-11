namespace WindowsFormsPlane
{
    partial class FormHangar
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
            this.pictureBoxHangar = new System.Windows.Forms.PictureBox();
            this.buttonSetPlane = new System.Windows.Forms.Button();
            this.groupBoxParking = new System.Windows.Forms.GroupBox();
            this.buttonPickUpPlane = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelParking = new System.Windows.Forms.Label();
            this.listBoxHangars = new System.Windows.Forms.ListBox();
            this.buttonAddHangar = new System.Windows.Forms.Button();
            this.buttonDelHangar = new System.Windows.Forms.Button();
            this.labelHangars = new System.Windows.Forms.Label();
            this.textBoxHangars = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).BeginInit();
            this.groupBoxParking.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxHangar
            // 
            this.pictureBoxHangar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxHangar.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxHangar.Name = "pictureBoxHangar";
            this.pictureBoxHangar.Size = new System.Drawing.Size(884, 462);
            this.pictureBoxHangar.TabIndex = 0;
            this.pictureBoxHangar.TabStop = false;
            // 
            // buttonSetPlane
            // 
            this.buttonSetPlane.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetPlane.Location = new System.Drawing.Point(897, 27);
            this.buttonSetPlane.Name = "buttonSetPlane";
            this.buttonSetPlane.Size = new System.Drawing.Size(104, 25);
            this.buttonSetPlane.TabIndex = 2;
            this.buttonSetPlane.Text = "Припарковать самолет";
            this.buttonSetPlane.UseVisualStyleBackColor = true;
            this.buttonSetPlane.Click += new System.EventHandler(this.buttonSetPlane_Click);
            // 
            // groupBoxParking
            // 
            this.groupBoxParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParking.Controls.Add(this.buttonPickUpPlane);
            this.groupBoxParking.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxParking.Controls.Add(this.labelParking);
            this.groupBoxParking.Location = new System.Drawing.Point(897, 58);
            this.groupBoxParking.Name = "groupBoxParking";
            this.groupBoxParking.Size = new System.Drawing.Size(103, 124);
            this.groupBoxParking.TabIndex = 3;
            this.groupBoxParking.TabStop = false;
            this.groupBoxParking.Text = "Забрать самолет";
            // 
            // buttonPickUpPlane
            // 
            this.buttonPickUpPlane.Location = new System.Drawing.Point(12, 63);
            this.buttonPickUpPlane.Name = "buttonPickUpPlane";
            this.buttonPickUpPlane.Size = new System.Drawing.Size(75, 28);
            this.buttonPickUpPlane.TabIndex = 2;
            this.buttonPickUpPlane.Text = "Забрать";
            this.buttonPickUpPlane.UseVisualStyleBackColor = true;
            this.buttonPickUpPlane.Click += new System.EventHandler(this.buttonPickUpPlane_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(55, 32);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(33, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelParking
            // 
            this.labelParking.AutoSize = true;
            this.labelParking.Location = new System.Drawing.Point(6, 35);
            this.labelParking.Name = "labelParking";
            this.labelParking.Size = new System.Drawing.Size(42, 13);
            this.labelParking.TabIndex = 0;
            this.labelParking.Text = "Место:";
            // 
            // listBoxHangars
            // 
            this.listBoxHangars.FormattingEnabled = true;
            this.listBoxHangars.Location = new System.Drawing.Point(897, 357);
            this.listBoxHangars.Name = "listBoxHangars";
            this.listBoxHangars.Size = new System.Drawing.Size(103, 69);
            this.listBoxHangars.TabIndex = 4;
            this.listBoxHangars.SelectedIndexChanged += new System.EventHandler(this.listBoxHangars_SelectedIndexChanged_1);
            // 
            // buttonAddHangar
            // 
            this.buttonAddHangar.Location = new System.Drawing.Point(899, 307);
            this.buttonAddHangar.Name = "buttonAddHangar";
            this.buttonAddHangar.Size = new System.Drawing.Size(101, 34);
            this.buttonAddHangar.TabIndex = 5;
            this.buttonAddHangar.Text = "Добавить ангары";
            this.buttonAddHangar.UseVisualStyleBackColor = true;
            this.buttonAddHangar.Click += new System.EventHandler(this.buttonAddHangar_Click);
            // 
            // buttonDelHangar
            // 
            this.buttonDelHangar.Location = new System.Drawing.Point(900, 429);
            this.buttonDelHangar.Name = "buttonDelHangar";
            this.buttonDelHangar.Size = new System.Drawing.Size(98, 31);
            this.buttonDelHangar.TabIndex = 6;
            this.buttonDelHangar.Text = "Удалить ангары";
            this.buttonDelHangar.UseVisualStyleBackColor = true;
            this.buttonDelHangar.Click += new System.EventHandler(this.buttonDelHangar_Click);
            // 
            // labelHangars
            // 
            this.labelHangars.AutoSize = true;
            this.labelHangars.Location = new System.Drawing.Point(919, 265);
            this.labelHangars.Name = "labelHangars";
            this.labelHangars.Size = new System.Drawing.Size(48, 13);
            this.labelHangars.TabIndex = 7;
            this.labelHangars.Text = "Ангары:";
            // 
            // textBoxHangars
            // 
            this.textBoxHangars.Location = new System.Drawing.Point(902, 281);
            this.textBoxHangars.Name = "textBoxHangars";
            this.textBoxHangars.Size = new System.Drawing.Size(81, 20);
            this.textBoxHangars.TabIndex = 8;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(897, 205);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(102, 27);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormHangar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 486);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxHangars);
            this.Controls.Add(this.labelHangars);
            this.Controls.Add(this.buttonDelHangar);
            this.Controls.Add(this.buttonAddHangar);
            this.Controls.Add(this.listBoxHangars);
            this.Controls.Add(this.groupBoxParking);
            this.Controls.Add(this.buttonSetPlane);
            this.Controls.Add(this.pictureBoxHangar);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormHangar";
            this.Text = "FormHangar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHangar)).EndInit();
            this.groupBoxParking.ResumeLayout(false);
            this.groupBoxParking.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHangar;
        private System.Windows.Forms.Button buttonSetPlane;
        private System.Windows.Forms.GroupBox groupBoxParking;
        private System.Windows.Forms.Button buttonPickUpPlane;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelParking;
        private System.Windows.Forms.ListBox listBoxHangars;
        private System.Windows.Forms.Button buttonAddHangar;
        private System.Windows.Forms.Button buttonDelHangar;
        private System.Windows.Forms.Label labelHangars;
        private System.Windows.Forms.TextBox textBoxHangars;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}