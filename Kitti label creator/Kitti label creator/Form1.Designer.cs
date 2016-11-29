namespace Kitti_label_creator
{
    partial class Form1
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
            this.CtrlPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rstBtn = new System.Windows.Forms.Button();
            this.discBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.dirBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startLbl = new System.Windows.Forms.Label();
            this.startTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yLbl = new System.Windows.Forms.Label();
            this.xLbl = new System.Windows.Forms.Label();
            this.yTxt = new System.Windows.Forms.TextBox();
            this.xTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPnl = new System.Windows.Forms.Panel();
            this.CtrlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.picPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CtrlPanel
            // 
            this.CtrlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtrlPanel.Controls.Add(this.label1);
            this.CtrlPanel.Controls.Add(this.progressBar);
            this.CtrlPanel.Controls.Add(this.panel1);
            this.CtrlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CtrlPanel.Location = new System.Drawing.Point(0, 371);
            this.CtrlPanel.Name = "CtrlPanel";
            this.CtrlPanel.Size = new System.Drawing.Size(848, 57);
            this.CtrlPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(6, 20);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(439, 23);
            this.progressBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.rstBtn);
            this.panel1.Controls.Add(this.discBtn);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.dirBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(448, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 57);
            this.panel1.TabIndex = 0;
            // 
            // rstBtn
            // 
            this.rstBtn.Location = new System.Drawing.Point(26, 22);
            this.rstBtn.Name = "rstBtn";
            this.rstBtn.Size = new System.Drawing.Size(75, 23);
            this.rstBtn.TabIndex = 3;
            this.rstBtn.Text = "&Reset";
            this.rstBtn.UseVisualStyleBackColor = true;
            this.rstBtn.Click += new System.EventHandler(this.rstBtn_Click);
            // 
            // discBtn
            // 
            this.discBtn.Location = new System.Drawing.Point(107, 22);
            this.discBtn.Name = "discBtn";
            this.discBtn.Size = new System.Drawing.Size(75, 23);
            this.discBtn.TabIndex = 2;
            this.discBtn.Text = "&Discart";
            this.discBtn.UseVisualStyleBackColor = true;
            this.discBtn.Click += new System.EventHandler(this.discBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(188, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // dirBtn
            // 
            this.dirBtn.Location = new System.Drawing.Point(269, 22);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(119, 23);
            this.dirBtn.TabIndex = 0;
            this.dirBtn.Text = "&Open Directory";
            this.dirBtn.UseVisualStyleBackColor = true;
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.startLbl);
            this.panel2.Controls.Add(this.startTxt);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.yLbl);
            this.panel2.Controls.Add(this.xLbl);
            this.panel2.Controls.Add(this.yTxt);
            this.panel2.Controls.Add(this.xTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(669, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 371);
            this.panel2.TabIndex = 1;
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(20, 149);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(44, 13);
            this.startLbl.TabIndex = 6;
            this.startLbl.Text = "Start at:";
            // 
            // startTxt
            // 
            this.startTxt.Location = new System.Drawing.Point(67, 146);
            this.startTxt.Name = "startTxt";
            this.startTxt.Size = new System.Drawing.Size(100, 20);
            this.startTxt.TabIndex = 5;
            this.startTxt.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target resolution";
            // 
            // yLbl
            // 
            this.yLbl.AutoSize = true;
            this.yLbl.Location = new System.Drawing.Point(26, 67);
            this.yLbl.Name = "yLbl";
            this.yLbl.Size = new System.Drawing.Size(38, 13);
            this.yLbl.TabIndex = 3;
            this.yLbl.Text = "Height";
            // 
            // xLbl
            // 
            this.xLbl.AutoSize = true;
            this.xLbl.Location = new System.Drawing.Point(29, 40);
            this.xLbl.Name = "xLbl";
            this.xLbl.Size = new System.Drawing.Size(35, 13);
            this.xLbl.TabIndex = 2;
            this.xLbl.Text = "Width";
            // 
            // yTxt
            // 
            this.yTxt.Location = new System.Drawing.Point(67, 64);
            this.yTxt.Name = "yTxt";
            this.yTxt.Size = new System.Drawing.Size(100, 20);
            this.yTxt.TabIndex = 1;
            this.yTxt.Text = "370";
            // 
            // xTxt
            // 
            this.xTxt.Location = new System.Drawing.Point(67, 37);
            this.xTxt.Name = "xTxt";
            this.xTxt.Size = new System.Drawing.Size(100, 20);
            this.xTxt.TabIndex = 0;
            this.xTxt.Text = "1224";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(657, 324);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // picPnl
            // 
            this.picPnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picPnl.Controls.Add(this.pictureBox1);
            this.picPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPnl.Location = new System.Drawing.Point(0, 0);
            this.picPnl.Name = "picPnl";
            this.picPnl.Size = new System.Drawing.Size(669, 371);
            this.picPnl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 428);
            this.Controls.Add(this.picPnl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CtrlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_ResizeBegin);
            this.CtrlPanel.ResumeLayout(false);
            this.CtrlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.picPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CtrlPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rstBtn;
        private System.Windows.Forms.Button discBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button dirBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel picPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yLbl;
        private System.Windows.Forms.Label xLbl;
        private System.Windows.Forms.TextBox yTxt;
        private System.Windows.Forms.TextBox xTxt;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.TextBox startTxt;

    }
}

