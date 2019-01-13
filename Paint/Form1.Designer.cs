namespace Paint
{
    partial class MsPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsPaint));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelPaint = new System.Windows.Forms.Panel();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pencil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openToolStripMenuItem.Text = "Open Command";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.saveToolStripMenuItem.Text = "Save Command";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelPaint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.txtCommand);
            this.splitContainer1.Size = new System.Drawing.Size(902, 452);
            this.splitContainer1.SplitterDistance = 538;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelPaint
            // 
            this.panelPaint.BackColor = System.Drawing.Color.White;
            this.panelPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaint.Location = new System.Drawing.Point(0, 0);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(534, 448);
            this.panelPaint.TabIndex = 0;
            this.panelPaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseClick);
            this.panelPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseDown);
            this.panelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseMove);
            this.panelPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseUp);
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.BackColor = System.Drawing.SystemColors.Info;
            this.txtCommand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCommand.Location = new System.Drawing.Point(0, 0);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommand.Size = new System.Drawing.Size(358, 448);
            this.txtCommand.TabIndex = 0;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Location = new System.Drawing.Point(800, 28);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 25);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "ClearCode";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(557, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 27);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(719, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(638, 27);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 27);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 24);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer3.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer3.Panel1.Controls.Add(this.btnClearAll);
            this.splitContainer3.Panel1.Controls.Add(this.btnOpen);
            this.splitContainer3.Panel1.Controls.Add(this.btnSave);
            this.splitContainer3.Panel1.Controls.Add(this.btnRun);
            this.splitContainer3.Panel1.Controls.Add(this.btnClear);
            this.splitContainer3.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer3_Panel1_Paint);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(902, 537);
            this.splitContainer3.SplitterDistance = 81;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChooseColor);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(414, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(98, 55);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colors";
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.Black;
            this.btnChooseColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChooseColor.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseColor.Location = new System.Drawing.Point(6, 21);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(86, 26);
            this.btnChooseColor.TabIndex = 1;
            this.btnChooseColor.UseVisualStyleBackColor = false;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboSize);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(269, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(6, 28);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(87, 26);
            this.cboSize.TabIndex = 2;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTriangle);
            this.groupBox2.Controls.Add(this.btnRectangle);
            this.groupBox2.Controls.Add(this.btnPolygon);
            this.groupBox2.Controls.Add(this.btnCircle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(142, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 64);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shapes";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTriangle.BackgroundImage")));
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTriangle.FlatAppearance.BorderSize = 0;
            this.btnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangle.Location = new System.Drawing.Point(6, 15);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(27, 23);
            this.btnTriangle.TabIndex = 0;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRectangle.BackgroundImage")));
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(49, 16);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(27, 23);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPolygon.BackgroundImage")));
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPolygon.FlatAppearance.BorderSize = 0;
            this.btnPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPolygon.Location = new System.Drawing.Point(6, 35);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(27, 23);
            this.btnPolygon.TabIndex = 0;
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.Location = new System.Drawing.Point(49, 35);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(27, 23);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pencil);
            this.groupBox1.Controls.Add(this.btnEraser);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 5;
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.Gray;
            this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pencil.FlatAppearance.BorderSize = 0;
            this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil.Location = new System.Drawing.Point(8, 31);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(27, 23);
            this.pencil.TabIndex = 0;
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEraser.BackgroundImage")));
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.FlatAppearance.BorderSize = 0;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEraser.Location = new System.Drawing.Point(53, 31);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(27, 23);
            this.btnEraser.TabIndex = 0;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1177, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MsPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 561);
            this.Controls.Add(this.splitContainer3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MsPaint";
            this.Text = "MS PAINT";
            this.Load += new System.EventHandler(this.MsPaint_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

