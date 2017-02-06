namespace PasswordHelperWF
{
    partial class Form3
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
            this.LVSiteLogPass = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Site = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LVSiteLogPass
            // 
            this.LVSiteLogPass.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Site,
            this.Login,
            this.Pass});
            this.LVSiteLogPass.Location = new System.Drawing.Point(12, 35);
            this.LVSiteLogPass.Name = "LVSiteLogPass";
            this.LVSiteLogPass.Size = new System.Drawing.Size(333, 362);
            this.LVSiteLogPass.TabIndex = 0;
            this.LVSiteLogPass.UseCompatibleStateImageBehavior = false;
            this.LVSiteLogPass.View = System.Windows.Forms.View.Details;
            this.LVSiteLogPass.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Number
            // 
            this.Number.Text = "№";
            this.Number.Width = 24;
            // 
            // Site
            // 
            this.Site.Text = "Сервис";
            this.Site.Width = 101;
            // 
            // Login
            // 
            this.Login.Text = "Логин";
            this.Login.Width = 100;
            // 
            // Pass
            // 
            this.Pass.Text = "Пароль";
            this.Pass.Width = 104;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 409);
            this.Controls.Add(this.LVSiteLogPass);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LVSiteLogPass;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Site;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Pass;
    }
}