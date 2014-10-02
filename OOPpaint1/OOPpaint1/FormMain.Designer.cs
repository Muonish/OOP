﻿namespace OOPpaint1
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHolst = new System.Windows.Forms.Panel();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonRect = new System.Windows.Forms.RadioButton();
            this.radioButtonEllipse = new System.Windows.Forms.RadioButton();
            this.radioButtonTriangle = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFigures = new System.Windows.Forms.GroupBox();
            this.radioButtonCircle = new System.Windows.Forms.RadioButton();
            this.radioButtonSquare = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBoxFigures.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHolst
            // 
            this.panelHolst.BackColor = System.Drawing.SystemColors.Window;
            this.panelHolst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHolst.Location = new System.Drawing.Point(231, 0);
            this.panelHolst.Name = "panelHolst";
            this.panelHolst.Size = new System.Drawing.Size(574, 450);
            this.panelHolst.TabIndex = 0;
            this.panelHolst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHolst_MouseDown);
            this.panelHolst.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHolst_MouseUp);
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLine.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLine.Location = new System.Drawing.Point(11, 30);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(40, 40);
            this.radioButtonLine.TabIndex = 1;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = " \\";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonRect
            // 
            this.radioButtonRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonRect.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonRect.Location = new System.Drawing.Point(153, 30);
            this.radioButtonRect.Name = "radioButtonRect";
            this.radioButtonRect.Size = new System.Drawing.Size(40, 40);
            this.radioButtonRect.TabIndex = 2;
            this.radioButtonRect.TabStop = true;
            this.radioButtonRect.Text = " ▭";
            this.radioButtonRect.UseVisualStyleBackColor = true;
            // 
            // radioButtonEllipse
            // 
            this.radioButtonEllipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonEllipse.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonEllipse.Location = new System.Drawing.Point(105, 30);
            this.radioButtonEllipse.Name = "radioButtonEllipse";
            this.radioButtonEllipse.Size = new System.Drawing.Size(40, 40);
            this.radioButtonEllipse.TabIndex = 3;
            this.radioButtonEllipse.TabStop = true;
            this.radioButtonEllipse.Text = " ⬭";
            this.radioButtonEllipse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTriangle
            // 
            this.radioButtonTriangle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTriangle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTriangle.Location = new System.Drawing.Point(58, 30);
            this.radioButtonTriangle.Name = "radioButtonTriangle";
            this.radioButtonTriangle.Size = new System.Drawing.Size(40, 40);
            this.radioButtonTriangle.TabIndex = 4;
            this.radioButtonTriangle.TabStop = true;
            this.radioButtonTriangle.Text = " △";
            this.radioButtonTriangle.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.figureToolStripMenuItem,
            this.holstToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.figureToolStripMenuItem.Text = "Figure";
            // 
            // holstToolStripMenuItem
            // 
            this.holstToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.holstToolStripMenuItem.Name = "holstToolStripMenuItem";
            this.holstToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.holstToolStripMenuItem.Text = "Holst";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // groupBoxFigures
            // 
            this.groupBoxFigures.Controls.Add(this.radioButtonCircle);
            this.groupBoxFigures.Controls.Add(this.radioButtonSquare);
            this.groupBoxFigures.Controls.Add(this.radioButtonLine);
            this.groupBoxFigures.Controls.Add(this.radioButtonRect);
            this.groupBoxFigures.Controls.Add(this.radioButtonEllipse);
            this.groupBoxFigures.Controls.Add(this.radioButtonTriangle);
            this.groupBoxFigures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFigures.Location = new System.Drawing.Point(12, 66);
            this.groupBoxFigures.Name = "groupBoxFigures";
            this.groupBoxFigures.Size = new System.Drawing.Size(204, 137);
            this.groupBoxFigures.TabIndex = 6;
            this.groupBoxFigures.TabStop = false;
            this.groupBoxFigures.Text = "Standard figures:";
            // 
            // radioButtonCircle
            // 
            this.radioButtonCircle.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonCircle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCircle.Location = new System.Drawing.Point(58, 79);
            this.radioButtonCircle.Name = "radioButtonCircle";
            this.radioButtonCircle.Size = new System.Drawing.Size(40, 40);
            this.radioButtonCircle.TabIndex = 6;
            this.radioButtonCircle.TabStop = true;
            this.radioButtonCircle.Text = " ◯";
            this.radioButtonCircle.UseVisualStyleBackColor = true;
            // 
            // radioButtonSquare
            // 
            this.radioButtonSquare.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSquare.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSquare.Location = new System.Drawing.Point(11, 79);
            this.radioButtonSquare.Name = "radioButtonSquare";
            this.radioButtonSquare.Size = new System.Drawing.Size(40, 40);
            this.radioButtonSquare.TabIndex = 5;
            this.radioButtonSquare.TabStop = true;
            this.radioButtonSquare.Text = " □";
            this.radioButtonSquare.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "FigureList";
            this.saveFileDialog.Filter = "Serial files|*.xml";
            this.saveFileDialog.RestoreDirectory = true;
            this.saveFileDialog.Title = "Save";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Serial files|*.xml";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.groupBoxFigures);
            this.Controls.Add(this.panelHolst);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "!(Paint)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxFigures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHolst;
        public System.Windows.Forms.RadioButton radioButtonLine;
        public System.Windows.Forms.RadioButton radioButtonEllipse;
        public System.Windows.Forms.RadioButton radioButtonTriangle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem figureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        public System.Windows.Forms.RadioButton radioButtonRect;
        private System.Windows.Forms.GroupBox groupBoxFigures;
        public System.Windows.Forms.RadioButton radioButtonSquare;
        public System.Windows.Forms.RadioButton radioButtonCircle;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

