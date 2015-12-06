namespace CshorpStudy.WinForm
{
    partial class RibbonUse
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
            this.ribbonHost1 = new Heren.Common.Ribbon.RibbonHost();
            this.ribbonControl1 = new CshorpStudy.WinForm.RibbonControl();
            this.SuspendLayout();
            // 
            // ribbonHost1
            // 
            this.ribbonHost1.HostedControl = null;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Size = new System.Drawing.Size(873, 135);
            this.ribbonControl1.TabIndex = 0;
            // 
            // RibbonUse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 427);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "RibbonUse";
            this.Text = "RibbonUse";
            this.ResumeLayout(false);

        }

        #endregion

        private Heren.Common.Ribbon.RibbonHost ribbonHost1;
        private RibbonControl ribbonControl1;
    }
}