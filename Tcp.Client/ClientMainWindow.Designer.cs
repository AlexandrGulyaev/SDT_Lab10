namespace SomeProject.TcpClient
{
    partial class ClientMainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SendFileBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(263, 216);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(147, 23);
            this.sendMsgBtn.TabIndex = 0;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            this.sendMsgBtn.Click += new System.EventHandler(this.OnMsgBtnClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(37, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(373, 193);
            this.textBox.TabIndex = 1;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Location = new System.Drawing.Point(37, 212);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 17);
            this.labelRes.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // SendFileBtn
            // 
            this.SendFileBtn.Location = new System.Drawing.Point(110, 216);
            this.SendFileBtn.Name = "SendFileBtn";
            this.SendFileBtn.Size = new System.Drawing.Size(147, 23);
            this.SendFileBtn.TabIndex = 0;
            this.SendFileBtn.Text = "Send File";
            this.SendFileBtn.UseVisualStyleBackColor = true;
            this.SendFileBtn.Click += new System.EventHandler(this.OnFileBtnClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ClientMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 260);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.SendFileBtn);
            this.Controls.Add(this.sendMsgBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientMainWindow";
            this.Text = "Client application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button SendFileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

