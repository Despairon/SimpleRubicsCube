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
            this.newToolStripMenuItem.Text = "New";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // bRotateCubeDown
            // 
            this.bRotateCubeDown.Image = global::SimpleRubicsCube.Properties.Resources.cube_rotate_arrow_down;
            this.bRotateCubeDown.Location = new System.Drawing.Point(386, 602);
            this.bRotateCubeDown.Name = "bRotateCubeDown";
            this.bRotateCubeDown.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeDown.TabIndex = 16;
            this.bRotateCubeDown.UseVisualStyleBackColor = true;
            // 
            // bRotateCubeLeft
            // 
            this.bRotateCubeLeft.Image = global::SimpleRubicsCube.Properties.Resources.cube_rotate_arrow_left;
            this.bRotateCubeLeft.Location = new System.Drawing.Point(12, 312);
            this.bRotateCubeLeft.Name = "bRotateCubeLeft";
            this.bRotateCubeLeft.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeLeft.TabIndex = 15;
            this.bRotateCubeLeft.UseVisualStyleBackColor = true;
            // 
            // bRotateCubeRight
            // 
            this.bRotateCubeRight.Image = global::SimpleRubicsCube.Properties.Resources.cube_rotate_arrow_right;
            this.bRotateCubeRight.Location = new System.Drawing.Point(756, 312);
            this.bRotateCubeRight.Name = "bRotateCubeRight";
            this.bRotateCubeRight.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeRight.TabIndex = 14;
            this.bRotateCubeRight.UseVisualStyleBackColor = true;
            // 
            // bRotateCubeUp
            // 
            this.bRotateCubeUp.Image = ((System.Drawing.Image)(resources.GetObject("bRotateCubeUp.Image")));
            this.bRotateCubeUp.Location = new System.Drawing.Point(386, 27);
            this.bRotateCubeUp.Name = "bRotateCubeUp";
            this.bRotateCubeUp.Size = new System.Drawing.Size(48, 48);
            this.bRotateCubeUp.TabIndex = 13;
            this.bRotateCubeUp.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 662);
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
    }
}

