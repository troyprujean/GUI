namespace Bunifu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cpbRAM = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.cpbCPU = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.NetworkSent = new System.Diagnostics.PerformanceCounter();
            this.label5 = new System.Windows.Forms.Label();
            this.NetworkReceived = new System.Diagnostics.PerformanceCounter();
            this.lblSent = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkSent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkReceived)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuGradientPanel3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(27, 74);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1013, 74);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackColor = System.Drawing.Color.Red;
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 10;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(267, 72);
            this.bunifuGradientPanel3.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel2.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel2.Controls.Add(this.bunifuFlatButton2);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(27, 148);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(267, 381);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Quit";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 331);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(265, 48);
            this.bunifuFlatButton1.TabIndex = 2;
            this.bunifuFlatButton1.Text = "Quit";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "bunifuFlatButton2";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(265, 48);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "bunifuFlatButton2";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblReceived);
            this.panel1.Controls.Add(this.lblSent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cpbRAM);
            this.panel1.Controls.Add(this.cpbCPU);
            this.panel1.Location = new System.Drawing.Point(293, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 381);
            this.panel1.TabIndex = 2;
            // 
            // cpbRAM
            // 
            this.cpbRAM.animated = false;
            this.cpbRAM.animationIterval = 5;
            this.cpbRAM.animationSpeed = 300;
            this.cpbRAM.BackColor = System.Drawing.Color.White;
            this.cpbRAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbRAM.BackgroundImage")));
            this.cpbRAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbRAM.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpbRAM.LabelVisible = true;
            this.cpbRAM.LineProgressThickness = 8;
            this.cpbRAM.LineThickness = 5;
            this.cpbRAM.Location = new System.Drawing.Point(260, 114);
            this.cpbRAM.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbRAM.MaxValue = 100;
            this.cpbRAM.Name = "cpbRAM";
            this.cpbRAM.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbRAM.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cpbRAM.Size = new System.Drawing.Size(201, 201);
            this.cpbRAM.TabIndex = 1;
            this.cpbRAM.Value = 0;
            // 
            // cpbCPU
            // 
            this.cpbCPU.animated = false;
            this.cpbCPU.animationIterval = 5;
            this.cpbCPU.animationSpeed = 300;
            this.cpbCPU.BackColor = System.Drawing.Color.White;
            this.cpbCPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpbCPU.BackgroundImage")));
            this.cpbCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpbCPU.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpbCPU.LabelVisible = true;
            this.cpbCPU.LineProgressThickness = 8;
            this.cpbCPU.LineThickness = 5;
            this.cpbCPU.Location = new System.Drawing.Point(15, 114);
            this.cpbCPU.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpbCPU.MaxValue = 100;
            this.cpbCPU.Name = "cpbCPU";
            this.cpbCPU.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpbCPU.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cpbCPU.Size = new System.Drawing.Size(201, 201);
            this.cpbCPU.TabIndex = 0;
            this.cpbCPU.Value = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "RAM";
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Network Sent";
            // 
            // NetworkSent
            // 
            this.NetworkSent.CategoryName = "Network Interface";
            this.NetworkSent.CounterName = "Bytes Received/sec";
            this.NetworkSent.InstanceName = "Intel(R) 82579LM Gigabit Network Connection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Network Received";
            // 
            // NetworkReceived
            // 
            this.NetworkReceived.CategoryName = "Network Interface";
            this.NetworkReceived.CounterName = "Bytes Sent/sec";
            this.NetworkReceived.InstanceName = "Intel(R) 82579LM Gigabit Network Connection";
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSent.Location = new System.Drawing.Point(594, 75);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(80, 31);
            this.lblSent.TabIndex = 7;
            this.lblSent.Text = "bytes";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceived.Location = new System.Drawing.Point(594, 252);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(80, 31);
            this.lblReceived.TabIndex = 8;
            this.lblReceived.Text = "bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkSent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetworkReceived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Framework.UI.BunifuCircleProgressbar cpbRAM;
        private Framework.UI.BunifuCircleProgressbar cpbCPU;
        private Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Diagnostics.PerformanceCounter NetworkSent;
        private System.Diagnostics.PerformanceCounter NetworkReceived;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Label lblSent;
    }
}

