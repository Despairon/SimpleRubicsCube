namespace SimpleRubicsCube
{
    partial class Main_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.openGLcanvas = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bRotateBotHRight = new System.Windows.Forms.Button();
            this.bRotateTopHRight = new System.Windows.Forms.Button();
            this.bRotateMidHRight = new System.Windows.Forms.Button();
            this.bRotateBotHLeft = new System.Windows.Forms.Button();
            this.bRotateTopHLeft = new System.Windows.Forms.Button();
            this.bRotateMidHLeft = new System.Windows.Forms.Button();
            this.bRotateRightVDown = new System.Windows.Forms.Button();
            this.bRotateMidVDown = new System.Windows.Forms.Button();
            this.bRotateLeftVDown = new System.Windows.Forms.Button();
            this.bRotateRightVUp = new System.Windows.Forms.Button();
            this.bRotateMidVUp = new System.Windows.Forms.Button();
            this.bRotateLeftVUp = new System.Windows.Forms.Button();
            this.bRotateCubeDown = new System.Windows.Forms.Button();
            this.bRotateCubeLeft = new System.Windows.Forms.Button();
            this.bRotateCubeRight = new System.Windows.Forms.Button();
            this.bRotateCubeUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLcanvas
            // 
            this.openGLcanvas.AccumBits = ((byte)(0));
            this.openGLcanvas.AutoCheckErrors = false;
            this.openGLcanvas.AutoFinish = false;
            this.openGLcanvas.AutoMakeCurrent = true;
            this.openGLcanvas.AutoSwapBuffers = true;
            this.openGLcanvas.BackColor = System.Drawing.Color.Black;
            this.openGLcanvas.ColorBits = ((byte)(32));
            this.openGLcanvas.DepthBits = ((byte)(16));
            this.openGLcanvas.Location = new System.Drawing.Point(164, 135);
            this.openGLcanvas.Name = "openGLcanvas";
            this.openGLcanvas.Size = new System.Drawing.Size(500, 400);
            this.openGLcanvas.StencilBits = ((byte)(0));
            this.openGLcanvas.TabIndex = 12;
            // 
            // renderTimer
            // 
            this.renderTimer.Enabled = true;
            this.renderTimer.Interval = 1;
            this.renderTimer.Tick += new System.EventHandler(this.renderTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "Reset";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // bRotateBotHRight
            // 
            this.bRotateBotHRight.Image = ((System.Drawing.Image)(resources.GetObject("bRotateBotHRight.Image")));
            this.bRotateBotHRight.Location = new System.Drawing.Point(670, 433);
            this.bRotateBotHRight.Name = "bRotateBotHRight";
            this.bRotateBotHRight.Size = new System.Drawing.Size(48, 32);
            this.bRotateBotHRight.TabIndex = 28;
            this.bRotateBotHRight.UseVisualStyleBackColor = true;
            // 
            // bRotateTopHRight
            // 
            this.bRotateTopHRight.Image = ((System.Drawing.Image)(resources.GetObject("bRotateTopHRight.Image")));
            this.bRotateTopHRight.Location = new System.Drawing.Point(670, 203);
            this.bRotateTopHRight.Name = "bRotateTopHRight";
            this.bRotateTopHRight.Size = new System.Drawing.Size(48, 32);
            this.bRotateTopHRight.TabIndex = 27;
            this.bRotateTopHRight.UseVisualStyleBackColor = true;
            // 
            // bRotateMidHRight
            // 
            this.bRotateMidHRight.Image = ((System.Drawing.Image)(resources.GetObject("bRotateMidHRight.Image")));
            this.bRotateMidHRight.Location = new System.Drawing.Point(670, 320);
            this.bRotateMidHRight.Name = "bRotateMidHRight";
            this.bRotateMidHRight.Size = new System.Drawing.Size(48, 32);
            this.bRotateMidHRight.TabIndex = 26;
            this.bRotateMidHRight.UseVisualStyleBackColor = true;
            // 
            // bRotateBotHLeft
            // 
            this.bRotateBotHLeft.Image = ((System.Drawing.Image)(resources.GetObject("bRotateBotHLeft.Image")));
            this.bRotateBotHLeft.Location = new System.Drawing.Point(110, 433);
            this.bRotateBotHLeft.Name = "bRotateBotHLeft";
            this.bRotateBotHLeft.Size = new System.Drawing.Size(48, 32);
            this.bRotateBotHLeft.TabIndex = 25;
            this.bRotateBotHLeft.UseVisualStyleBackColor = true;
            // 
            // bRotateTopHLeft
            // 
            this.bRotateTopHLeft.Image = ((System.Drawing.Image)(resources.GetObject("bRotateTopHLeft.Image")));
            this.bRotateTopHLeft.Location = new System.Drawing.Point(110, 203);
            this.bRotateTopHLeft.Name = "bRotateTopHLeft";
            this.bRotateTopHLeft.Size = new System.Drawing.Size(48, 32);
            this.bRotateTopHLeft.TabIndex = 24;
            this.bRotateTopHLeft.UseVisualStyleBackColor = true;
            // 
            // bRotateMidHLeft
            // 
            this.bRotateMidHLeft.Image = ((System.Drawing.Image)(resources.GetObject("bRotateMidHLeft.Image")));
            this.bRotateMidHLeft.Location = new System.Drawing.Point(110, 320);
            this.bRotateMidHLeft.Name = "bRotateMidHLeft";
            this.bRotateMidHLeft.Size = new System.Drawing.Size(48, 32);
            this.bRotateMidHLeft.TabIndex = 23;
            this.bRotateMidHLeft.UseVisualStyleBackColor = true;
            // 
            // bRotateRightVDown
            // 
            this.bRotateRightVDown.Image = ((System.Drawing.Image)(resources.GetObject("bRotateRightVDown.Image")));
            this.bRotateRightVDown.Location = new System.Drawing.Point(512, 541);
            this.bRotateRightVDown.Name = "bRotateRightVDown";
            this.bRotateRightVDown.Size = new System.Drawing.Size(32, 48);
            this.bRotateRightVDown.TabIndex = 22;
            this.bRotateRightVDown.UseVisualStyleBackColor = true;
            // 
            // bRotateMidVDown
            // 
            this.bRotateMidVDown.Image = ((System.Drawing.Image)(resources.GetObject("bRotateMidVDown.Image")));
            this.bRotateMidVDown.Location = new System.Drawing.Point(394, 541);
            this.bRotateMidVDown.Name = "bRotateMidVDown";
            this.bRotateMidVDown.Size = new System.Drawing.Size(32, 48);
            this.bRotateMidVDown.TabIndex = 21;
            this.bRotateMidVDown.UseVisualStyleBackColor = true;
            // 
            // bRotateLeftVDown
            // 
            this.bRotateLeftVDown.Image = ((System.Drawing.Image)(resources.GetObject("bRotateLeftVDown.Image")));
            this.bRotateLeftVDown.Location = new System.Drawing.Point(277, 541);
            this.bRotateLeftVDown.Name = "bRotateLeftVDown";
            this.bRotateLeftVDown.Size = new System.Drawing.Size(32, 48);
            this.bRotateLeftVDown.TabIndex = 20;
            this.bRotateLeftVDown.UseVisualStyleBackColor = true;
            // 
            // bRotateRightVUp
            // 
            this.bRotateRightVUp.Image = ((System.Drawing.Image)(resources.GetObject("bRotateRightVUp.Image")));
            this.bRotateRightVUp.Location = new System.Drawing.Point(512, 81);
            this.bRotateRightVUp.Name = "bRotateRightVUp";
            this.bRotateRightVUp.Size = new System.Drawing.Size(32, 48);
            this.bRotateRightVUp.TabIndex = 19;
            this.bRotateRightVUp.UseVisualStyleBackColor = true;
            // 
            // bRotateMidVUp
            // 
            this.bRotateMidVUp.Image = ((System.Drawing.Image)(resources.GetObject("bRotateMidVUp.Image")));
            this.bRotateMidVUp.Location = new System.Drawing.Point(394, 81);
            this.bRotateMidVUp.Name = "bRotateMidVUp";
            this.bRotateMidVUp.Size = new System.Drawing.Size(32, 48);
            this.bRotateMidVUp.TabIndex = 18;
            this.bRotateMidVUp.UseVisualStyleBackColor = true;
            // 
            // bRotateLeftVUp
            // 
            this.bRotateLeftVUp.Image = ((System.Drawing.Image)(resources.GetObject("bRotateLeftVUp.Image")));
            this.bRotateLeftVUp.Location = new System.Drawing.Point(277, 81);
            this.bRotateLeftVUp.Name = "bRotateLeftVUp";
            this.bRotateLeftVUp.Size = new System.Drawing.Size(32, 48);
            this.bRotateLeftVUp.TabIndex = 17;
            this.bRotateLeftVUp.UseVisualStyleBackColor = true;
            // 
            // bRotateCubeDown
            // 
            this.bRotateCubeDown.Image = global::SimpleRubicsCube.Properties.Resources.cube_rotate_arrow_down;
            this.bRotateCubeDown.Location = new System.Drawing.Point(386, 602);
            this.bRotateCubeDown.Name = "bRotateCubeDown";
            this.bRotateCubeDown.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeDown.TabIndex = 16;
            this.bRotateCubeDown.UseVisualStyleBackColor = true;
            this.bRotateCubeDown.Click += new System.EventHandler(this.bRotateCubeDown_Click);
            // 
            // bRotateCubeLeft
            // 
            this.bRotateCubeLeft.Image = global::SimpleRubicsCube.Properties.Resources.cube_rotate_arrow_left;
            this.bRotateCubeLeft.Location = new System.Drawing.Point(12, 312);
            this.bRotateCubeLeft.Name = "bRotateCubeLeft";
            this.bRotateCubeLeft.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeLeft.TabIndex = 15;
            this.bRotateCubeLeft.UseVisualStyleBackColor = true;
            this.bRotateCubeLeft.Click += new System.EventHandler(this.bRotateCubeLeft_Click);
            // 
            // bRotateCubeRight
            // 
            this.bRotateCubeRight.Image = global::SimpleRubicsCube.Properties.Resources.cube_rotate_arrow_right;
            this.bRotateCubeRight.Location = new System.Drawing.Point(756, 312);
            this.bRotateCubeRight.Name = "bRotateCubeRight";
            this.bRotateCubeRight.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeRight.TabIndex = 14;
            this.bRotateCubeRight.UseVisualStyleBackColor = true;
            this.bRotateCubeRight.Click += new System.EventHandler(this.bRotateCubeRight_Click);
            // 
            // bRotateCubeUp
            // 
            this.bRotateCubeUp.Image = ((System.Drawing.Image)(resources.GetObject("bRotateCubeUp.Image")));
            this.bRotateCubeUp.Location = new System.Drawing.Point(386, 27);
            this.bRotateCubeUp.Name = "bRotateCubeUp";
            this.bRotateCubeUp.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeUp.TabIndex = 13;
            this.bRotateCubeUp.UseVisualStyleBackColor = true;
            this.bRotateCubeUp.Click += new System.EventHandler(this.bRotateCubeUp_Click);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 662);
            this.Controls.Add(this.bRotateBotHRight);
            this.Controls.Add(this.bRotateTopHRight);
            this.Controls.Add(this.bRotateMidHRight);
            this.Controls.Add(this.bRotateBotHLeft);
            this.Controls.Add(this.bRotateTopHLeft);
            this.Controls.Add(this.bRotateMidHLeft);
            this.Controls.Add(this.bRotateRightVDown);
            this.Controls.Add(this.bRotateMidVDown);
            this.Controls.Add(this.bRotateLeftVDown);
            this.Controls.Add(this.bRotateRightVUp);
            this.Controls.Add(this.bRotateMidVUp);
            this.Controls.Add(this.bRotateLeftVUp);
            this.Controls.Add(this.bRotateCubeDown);
            this.Controls.Add(this.bRotateCubeLeft);
            this.Controls.Add(this.bRotateCubeRight);
            this.Controls.Add(this.bRotateCubeUp);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openGLcanvas);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_form";
            this.Text = "Simple Rubics Cube";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Tao.Platform.Windows.SimpleOpenGlControl openGLcanvas;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button bRotateCubeUp;
        private System.Windows.Forms.Button bRotateCubeRight;
        private System.Windows.Forms.Button bRotateCubeLeft;
        private System.Windows.Forms.Button bRotateCubeDown;
        private System.Windows.Forms.Button bRotateLeftVUp;
        private System.Windows.Forms.Button bRotateMidVUp;
        private System.Windows.Forms.Button bRotateRightVUp;
        private System.Windows.Forms.Button bRotateRightVDown;
        private System.Windows.Forms.Button bRotateMidVDown;
        private System.Windows.Forms.Button bRotateLeftVDown;
        private System.Windows.Forms.Button bRotateBotHLeft;
        private System.Windows.Forms.Button bRotateTopHLeft;
        private System.Windows.Forms.Button bRotateMidHLeft;
        private System.Windows.Forms.Button bRotateBotHRight;
        private System.Windows.Forms.Button bRotateTopHRight;
        private System.Windows.Forms.Button bRotateMidHRight;
    }
}

