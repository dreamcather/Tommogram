namespace Tomogram
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glControl1 = new OpenTK.GLControl();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.renderTypeWindow = new System.Windows.Forms.GroupBox();
            this.quadsBottom = new System.Windows.Forms.RadioButton();
            this.textureBotton = new System.Windows.Forms.RadioButton();
            this.trackBarStartPoint = new System.Windows.Forms.TrackBar();
            this.trackBarWidthOfTF = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.renderTypeWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStartPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthOfTF)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // glControl1
            // 
            this.glControl1.AutoSize = true;
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(13, 28);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(967, 432);
            this.glControl1.TabIndex = 1;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(13, 481);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 70;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(731, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // renderTypeWindow
            // 
            this.renderTypeWindow.Controls.Add(this.quadsBottom);
            this.renderTypeWindow.Controls.Add(this.textureBotton);
            this.renderTypeWindow.Location = new System.Drawing.Point(676, 515);
            this.renderTypeWindow.Margin = new System.Windows.Forms.Padding(2);
            this.renderTypeWindow.Name = "renderTypeWindow";
            this.renderTypeWindow.Padding = new System.Windows.Forms.Padding(2);
            this.renderTypeWindow.Size = new System.Drawing.Size(160, 60);
            this.renderTypeWindow.TabIndex = 3;
            this.renderTypeWindow.TabStop = false;
            this.renderTypeWindow.Text = "Тип отрисовки";
            // 
            // quadsBottom
            // 
            this.quadsBottom.AutoSize = true;
            this.quadsBottom.Location = new System.Drawing.Point(4, 17);
            this.quadsBottom.Margin = new System.Windows.Forms.Padding(2);
            this.quadsBottom.Name = "quadsBottom";
            this.quadsBottom.Size = new System.Drawing.Size(61, 17);
            this.quadsBottom.TabIndex = 1;
            this.quadsBottom.TabStop = true;
            this.quadsBottom.Text = "Texture";
            this.quadsBottom.UseVisualStyleBackColor = true;
            this.quadsBottom.Click += new System.EventHandler(this.quadsBottom_Click);
            // 
            // textureBotton
            // 
            this.textureBotton.AutoSize = true;
            this.textureBotton.Location = new System.Drawing.Point(4, 37);
            this.textureBotton.Margin = new System.Windows.Forms.Padding(2);
            this.textureBotton.Name = "textureBotton";
            this.textureBotton.Size = new System.Drawing.Size(56, 17);
            this.textureBotton.TabIndex = 0;
            this.textureBotton.TabStop = true;
            this.textureBotton.Text = "Quads";
            this.textureBotton.UseVisualStyleBackColor = true;
            this.textureBotton.Click += new System.EventHandler(this.textureBotton_Click);
            // 
            // trackBarStartPoint
            // 
            this.trackBarStartPoint.Location = new System.Drawing.Point(13, 530);
            this.trackBarStartPoint.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarStartPoint.Maximum = 11;
            this.trackBarStartPoint.Minimum = 1;
            this.trackBarStartPoint.Name = "trackBarStartPoint";
            this.trackBarStartPoint.Size = new System.Drawing.Size(133, 45);
            this.trackBarStartPoint.TabIndex = 4;
            this.trackBarStartPoint.Value = 1;
            this.trackBarStartPoint.Scroll += new System.EventHandler(this.trackBarStartPoint_Scroll);
            // 
            // trackBarWidthOfTF
            // 
            this.trackBarWidthOfTF.Location = new System.Drawing.Point(247, 530);
            this.trackBarWidthOfTF.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarWidthOfTF.Name = "trackBarWidthOfTF";
            this.trackBarWidthOfTF.Size = new System.Drawing.Size(261, 45);
            this.trackBarWidthOfTF.TabIndex = 5;
            this.trackBarWidthOfTF.Scroll += new System.EventHandler(this.trackBarWidthOfTF_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 530);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Минимумм TF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 530);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ширина TF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarWidthOfTF);
            this.Controls.Add(this.trackBarStartPoint);
            this.Controls.Add(this.renderTypeWindow);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.renderTypeWindow.ResumeLayout(false);
            this.renderTypeWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStartPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthOfTF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox renderTypeWindow;
        private System.Windows.Forms.RadioButton quadsBottom;
        private System.Windows.Forms.RadioButton textureBotton;
        private System.Windows.Forms.TrackBar trackBarStartPoint;
        private System.Windows.Forms.TrackBar trackBarWidthOfTF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

