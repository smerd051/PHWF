namespace PasswordHelperWF
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tBLogin = new System.Windows.Forms.TextBox();
            this.tBPass = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBLogin
            // 
            this.tBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBLogin.Location = new System.Drawing.Point(95, 18);
            this.tBLogin.Name = "tBLogin";
            this.tBLogin.Size = new System.Drawing.Size(116, 26);
            this.tBLogin.TabIndex = 0;
            // 
            // tBPass
            // 
            this.tBPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBPass.Location = new System.Drawing.Point(95, 61);
            this.tBPass.Name = "tBPass";
            this.tBPass.Size = new System.Drawing.Size(116, 26);
            this.tBPass.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLogin.Location = new System.Drawing.Point(18, 18);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(59, 20);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPass.Location = new System.Drawing.Point(18, 61);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(71, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Пароль:";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEnter.Location = new System.Drawing.Point(57, 108);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 55);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(224, 175);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tBPass);
            this.Controls.Add(this.tBLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBLogin;
        private System.Windows.Forms.TextBox tBPass;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnEnter;
    }
}