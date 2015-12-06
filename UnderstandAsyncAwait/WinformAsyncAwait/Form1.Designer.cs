namespace WinformAsyncAwait
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
            this.btnTaskResult = new System.Windows.Forms.Button();
            this.btnAsyncAwait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaskResult
            // 
            this.btnTaskResult.Location = new System.Drawing.Point(43, 35);
            this.btnTaskResult.Name = "btnTaskResult";
            this.btnTaskResult.Size = new System.Drawing.Size(75, 23);
            this.btnTaskResult.TabIndex = 0;
            this.btnTaskResult.Text = "Task.Result";
            this.btnTaskResult.UseVisualStyleBackColor = true;
            this.btnTaskResult.Click += new System.EventHandler(this.btnTaskResult_Click);
            // 
            // btnAsyncAwait
            // 
            this.btnAsyncAwait.Location = new System.Drawing.Point(174, 34);
            this.btnAsyncAwait.Name = "btnAsyncAwait";
            this.btnAsyncAwait.Size = new System.Drawing.Size(75, 23);
            this.btnAsyncAwait.TabIndex = 1;
            this.btnAsyncAwait.Text = "Async/Await";
            this.btnAsyncAwait.UseVisualStyleBackColor = true;
            this.btnAsyncAwait.Click += new System.EventHandler(this.btnAsyncAwait_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 220);
            this.Controls.Add(this.btnAsyncAwait);
            this.Controls.Add(this.btnTaskResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaskResult;
        private System.Windows.Forms.Button btnAsyncAwait;
    }
}

