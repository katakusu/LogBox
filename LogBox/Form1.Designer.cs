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
            this.textBox = new System.Windows.Forms.TextBox();
            this.addMessageButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.showLogsButton = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(259, 108);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addMessageButton
            // 
            this.addMessageButton.Enabled = false;
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
            // showLogsButton
            // 
            this.showLogsButton.Location = new System.Drawing.Point(116, 126);
            this.showLogsButton.Name = "showLogsButton";
            this.showLogsButton.Size = new System.Drawing.Size(75, 23);
            this.showLogsButton.TabIndex = 2;
            this.showLogsButton.Text = "表示";
            this.showLogsButton.UseVisualStyleBackColor = true;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(12, 132);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 12);
            this.stateLabel.TabIndex = 3;
            // 
            // labelTimer
            // 
            this.labelTimer.Interval = 1000;
            this.labelTimer.Tick += new System.EventHandler(this.labelTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.showLogsButton);
            this.Controls.Add(this.addMessageButton);
            this.Controls.Add(this.textBox);
            this.Name = "mainForm";
            this.Text = "LogBox";
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button addMessageButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button showLogsButton;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer labelTimer;
    }
}

