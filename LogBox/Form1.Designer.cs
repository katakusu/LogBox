﻿namespace LogBox
{
    partial class mainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addMessageButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 108);
            this.textBox1.TabIndex = 0;
            // 
            // addMessageButton
            // 
            this.addMessageButton.Location = new System.Drawing.Point(197, 127);
            this.addMessageButton.Name = "addMessageButton";
            this.addMessageButton.Size = new System.Drawing.Size(75, 23);
            this.addMessageButton.TabIndex = 1;
            this.addMessageButton.Text = "書き込み";
            this.addMessageButton.UseVisualStyleBackColor = true;
            this.addMessageButton.Click += new System.EventHandler(this.addMessageButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "LogBox";
            this.notifyIcon.Visible = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.addMessageButton);
            this.Controls.Add(this.textBox1);
            this.Name = "mainForm";
            this.Text = "LogBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addMessageButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

