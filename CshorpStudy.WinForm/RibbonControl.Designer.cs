namespace CshorpStudy.WinForm
{
    partial class RibbonControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ribbonStrip1 = new Heren.Common.Ribbon.RibbonStrip();
            this.ribbonTab1 = new Heren.Common.Ribbon.RibbonTab();
            this.ribbonTab2 = new Heren.Common.Ribbon.RibbonTab();
            this.ribbonPanel1 = new Heren.Common.Ribbon.RibbonPanel();
            this.ribbonPanel2 = new Heren.Common.Ribbon.RibbonPanel();
            this.ribbonPanel3 = new Heren.Common.Ribbon.RibbonPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ribbonStrip1
            // 
            this.ribbonStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ribbonStrip1.Location = new System.Drawing.Point(0, 0);
            this.ribbonStrip1.Minimized = false;
            this.ribbonStrip1.Name = "ribbonStrip1";
            // 
            // 
            // 
            this.ribbonStrip1.OrbDropDown.BorderRoundness = 8;
            this.ribbonStrip1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonStrip1.OrbDropDown.Name = "";
            this.ribbonStrip1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbonStrip1.OrbDropDown.TabIndex = 0;
            this.ribbonStrip1.OrbImage = null;
            this.ribbonStrip1.OrbStyle = Heren.Common.Ribbon.RibbonOrbStyle.Office_2013;
            this.ribbonStrip1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonStrip1.Size = new System.Drawing.Size(749, 157);
            this.ribbonStrip1.TabIndex = 0;
            this.ribbonStrip1.Tabs.Add(this.ribbonTab1);
            this.ribbonStrip1.Tabs.Add(this.ribbonTab2);
            this.ribbonStrip1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonStrip1.Text = "ribbonStrip1";
            this.ribbonStrip1.ThemeColor = Heren.Common.Ribbon.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Panels.Add(this.ribbonPanel1);
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Panels.Add(this.ribbonPanel3);
            this.ribbonTab2.Text = "ribbonTab2";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Text = "ribbonPanel3";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(671, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RibbonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ribbonStrip1);
            this.Name = "RibbonControl";
            this.Size = new System.Drawing.Size(749, 162);
            this.ResumeLayout(false);

        }

        #endregion

        private Heren.Common.Ribbon.RibbonStrip ribbonStrip1;
        private Heren.Common.Ribbon.RibbonTab ribbonTab1;
        private Heren.Common.Ribbon.RibbonTab ribbonTab2;
        private Heren.Common.Ribbon.RibbonPanel ribbonPanel1;
        private Heren.Common.Ribbon.RibbonPanel ribbonPanel2;
        private Heren.Common.Ribbon.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.Button button1;
    }
}
