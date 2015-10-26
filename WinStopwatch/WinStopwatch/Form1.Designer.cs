namespace WinStopwatch
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddControl = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.nuNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbTextBox = new System.Windows.Forms.RadioButton();
            this.rbCheckBox = new System.Windows.Forms.RadioButton();
            this.rbRadioButton = new System.Windows.Forms.RadioButton();
            this.rbButton = new System.Windows.Forms.RadioButton();
            this.btnLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddControl
            // 
            this.btnAddControl.Location = new System.Drawing.Point(22, 240);
            this.btnAddControl.Name = "btnAddControl";
            this.btnAddControl.Size = new System.Drawing.Size(203, 33);
            this.btnAddControl.TabIndex = 0;
            this.btnAddControl.Text = "加载控件-通过Stopwatch记录日志";
            this.btnAddControl.UseVisualStyleBackColor = true;
            this.btnAddControl.Click += new System.EventHandler(this.btnAddControl_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContent.Location = new System.Drawing.Point(22, 12);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(394, 222);
            this.pnlContent.TabIndex = 1;
            // 
            // nuNum
            // 
            this.nuNum.Location = new System.Drawing.Point(440, 213);
            this.nuNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuNum.Name = "nuNum";
            this.nuNum.Size = new System.Drawing.Size(76, 21);
            this.nuNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(522, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "个";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(258, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "耗时：";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.Location = new System.Drawing.Point(310, 266);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 16);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "0ms";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbTextBox);
            this.panel2.Controls.Add(this.rbCheckBox);
            this.panel2.Controls.Add(this.rbRadioButton);
            this.panel2.Controls.Add(this.rbButton);
            this.panel2.Location = new System.Drawing.Point(422, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 177);
            this.panel2.TabIndex = 6;
            // 
            // rbTextBox
            // 
            this.rbTextBox.AutoSize = true;
            this.rbTextBox.Location = new System.Drawing.Point(18, 126);
            this.rbTextBox.Name = "rbTextBox";
            this.rbTextBox.Size = new System.Drawing.Size(65, 16);
            this.rbTextBox.TabIndex = 3;
            this.rbTextBox.Text = "TextBox";
            this.rbTextBox.UseVisualStyleBackColor = true;
            // 
            // rbCheckBox
            // 
            this.rbCheckBox.AutoSize = true;
            this.rbCheckBox.Location = new System.Drawing.Point(18, 92);
            this.rbCheckBox.Name = "rbCheckBox";
            this.rbCheckBox.Size = new System.Drawing.Size(71, 16);
            this.rbCheckBox.TabIndex = 2;
            this.rbCheckBox.Text = "CheckBox";
            this.rbCheckBox.UseVisualStyleBackColor = true;
            // 
            // rbRadioButton
            // 
            this.rbRadioButton.AutoSize = true;
            this.rbRadioButton.Location = new System.Drawing.Point(16, 56);
            this.rbRadioButton.Name = "rbRadioButton";
            this.rbRadioButton.Size = new System.Drawing.Size(89, 16);
            this.rbRadioButton.TabIndex = 1;
            this.rbRadioButton.Text = "RadioButton";
            this.rbRadioButton.UseVisualStyleBackColor = true;
            // 
            // rbButton
            // 
            this.rbButton.AutoSize = true;
            this.rbButton.Checked = true;
            this.rbButton.Location = new System.Drawing.Point(16, 20);
            this.rbButton.Name = "rbButton";
            this.rbButton.Size = new System.Drawing.Size(59, 16);
            this.rbButton.TabIndex = 0;
            this.rbButton.TabStop = true;
            this.rbButton.Text = "Button";
            this.rbButton.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(22, 283);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(203, 32);
            this.btnLog.TabIndex = 7;
            this.btnLog.Text = "加载控件-通过Log4emr记录日志";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 327);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuNum);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnAddControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加载控件测试";
            ((System.ComponentModel.ISupportInitialize)(this.nuNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddControl;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.NumericUpDown nuNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbCheckBox;
        private System.Windows.Forms.RadioButton rbRadioButton;
        private System.Windows.Forms.RadioButton rbButton;
        private System.Windows.Forms.RadioButton rbTextBox;
        private System.Windows.Forms.Button btnLog;
    }
}

