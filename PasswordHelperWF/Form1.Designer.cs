namespace PasswordHelperWF
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cblPass = new System.Windows.Forms.CheckedListBox();
            this.lblLengthPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passLength = new System.Windows.Forms.NumericUpDown();
            this.GenPass = new System.Windows.Forms.Button();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.btnCopyPass = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.войтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cblPass
            // 
            this.cblPass.CheckOnClick = true;
            this.cblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cblPass.FormattingEnabled = true;
            this.cblPass.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы"});
            this.cblPass.Location = new System.Drawing.Point(14, 76);
            this.cblPass.Name = "cblPass";
            this.cblPass.Size = new System.Drawing.Size(171, 67);
            this.cblPass.TabIndex = 0;
            // 
            // lblLengthPass
            // 
            this.lblLengthPass.AutoSize = true;
            this.lblLengthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLengthPass.Location = new System.Drawing.Point(224, 53);
            this.lblLengthPass.Name = "lblLengthPass";
            this.lblLengthPass.Size = new System.Drawing.Size(121, 20);
            this.lblLengthPass.TabIndex = 1;
            this.lblLengthPass.Text = "Длина пароля:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Условия пароля:";
            // 
            // passLength
            // 
            this.passLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passLength.Location = new System.Drawing.Point(228, 97);
            this.passLength.Name = "passLength";
            this.passLength.Size = new System.Drawing.Size(117, 26);
            this.passLength.TabIndex = 3;
            this.passLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // GenPass
            // 
            this.GenPass.Location = new System.Drawing.Point(91, 176);
            this.GenPass.Name = "GenPass";
            this.GenPass.Size = new System.Drawing.Size(173, 48);
            this.GenPass.TabIndex = 4;
            this.GenPass.Text = "Генерировать";
            this.GenPass.UseVisualStyleBackColor = true;
            this.GenPass.Click += new System.EventHandler(this.GenPass_Click);
            // 
            // NewPass
            // 
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPass.Location = new System.Drawing.Point(14, 240);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(333, 26);
            this.NewPass.TabIndex = 5;
            this.NewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSavePass
            // 
            this.btnSavePass.Location = new System.Drawing.Point(25, 267);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(121, 53);
            this.btnSavePass.TabIndex = 6;
            this.btnSavePass.Text = "Сохранить";
            this.btnSavePass.UseVisualStyleBackColor = true;
            // 
            // btnCopyPass
            // 
            this.btnCopyPass.Location = new System.Drawing.Point(215, 267);
            this.btnCopyPass.Name = "btnCopyPass";
            this.btnCopyPass.Size = new System.Drawing.Size(121, 53);
            this.btnCopyPass.TabIndex = 7;
            this.btnCopyPass.Text = "Копировать";
            this.btnCopyPass.UseVisualStyleBackColor = true;
            this.btnCopyPass.Click += new System.EventHandler(this.btnCopyPass_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.войтиToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // войтиToolStripMenuItem
            // 
            this.войтиToolStripMenuItem.Name = "войтиToolStripMenuItem";
            this.войтиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.войтиToolStripMenuItem.Text = "Войти";
            this.войтиToolStripMenuItem.Click += new System.EventHandler(this.войтиToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 409);
            this.Controls.Add(this.btnCopyPass);
            this.Controls.Add(this.btnSavePass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.GenPass);
            this.Controls.Add(this.passLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLengthPass);
            this.Controls.Add(this.cblPass);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Паролька";
            ((System.ComponentModel.ISupportInitialize)(this.passLength)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cblPass;
        private System.Windows.Forms.Label lblLengthPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown passLength;
        private System.Windows.Forms.Button GenPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.Button btnCopyPass;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem войтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    }
}

