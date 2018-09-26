namespace WindowsForms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictBox = new System.Windows.Forms.PictureBox();
            this.chkStretch = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetBackground1 = new System.Windows.Forms.Button();
            this.btnSetBackground2 = new System.Windows.Forms.Button();
            this.btnSetBackground3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.chkStretch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictBox, 2);
            this.pictBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictBox.Location = new System.Drawing.Point(3, 3);
            this.pictBox.Name = "pictBox";
            this.pictBox.Size = new System.Drawing.Size(778, 408);
            this.pictBox.TabIndex = 0;
            this.pictBox.TabStop = false;
            // 
            // chkStretch
            // 
            this.chkStretch.AutoSize = true;
            this.chkStretch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkStretch.Location = new System.Drawing.Point(3, 417);
            this.chkStretch.Name = "chkStretch";
            this.chkStretch.Size = new System.Drawing.Size(111, 41);
            this.chkStretch.TabIndex = 0;
            this.chkStretch.Text = "Stretch";
            this.chkStretch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.btnSetBackground1);
            this.flowLayoutPanel1.Controls.Add(this.btnSetBackground2);
            this.flowLayoutPanel1.Controls.Add(this.btnSetBackground3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(120, 417);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(661, 41);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(3, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSetBackground1
            // 
            this.btnSetBackground1.Location = new System.Drawing.Point(119, 3);
            this.btnSetBackground1.Name = "btnSetBackground1";
            this.btnSetBackground1.Size = new System.Drawing.Size(175, 35);
            this.btnSetBackground1.TabIndex = 2;
            this.btnSetBackground1.Text = "Set Background";
            this.btnSetBackground1.UseVisualStyleBackColor = true;
            // 
            // btnSetBackground2
            // 
            this.btnSetBackground2.Location = new System.Drawing.Point(300, 3);
            this.btnSetBackground2.Name = "btnSetBackground2";
            this.btnSetBackground2.Size = new System.Drawing.Size(175, 35);
            this.btnSetBackground2.TabIndex = 3;
            this.btnSetBackground2.Text = "Set Background";
            this.btnSetBackground2.UseVisualStyleBackColor = true;
            // 
            // btnSetBackground3
            // 
            this.btnSetBackground3.Location = new System.Drawing.Point(481, 3);
            this.btnSetBackground3.Name = "btnSetBackground3";
            this.btnSetBackground3.Size = new System.Drawing.Size(175, 35);
            this.btnSetBackground3.TabIndex = 4;
            this.btnSetBackground3.Text = "Set Background";
            this.btnSetBackground3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictBox;
        private System.Windows.Forms.CheckBox chkStretch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSetBackground1;
        private System.Windows.Forms.Button btnSetBackground2;
        private System.Windows.Forms.Button btnSetBackground3;
    }
}

