
namespace Тест_по_философии
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Results = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Registration = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbId = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.BTinsert = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Results.SuspendLayout();
            this.Registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.менюToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HelpToolStripMenuItem.Text = "Справка";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Выйти";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Results);
            this.tabControl1.Controls.Add(this.Registration);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 482);
            this.tabControl1.TabIndex = 1;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.listBox1);
            this.Results.Location = new System.Drawing.Point(4, 25);
            this.Results.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Results.Name = "Results";
            this.Results.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Results.Size = new System.Drawing.Size(809, 453);
            this.Results.TabIndex = 0;
            this.Results.Text = "Результаты";
            this.Results.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 4);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(803, 445);
            this.listBox1.TabIndex = 0;
            // 
            // Registration
            // 
            this.Registration.Controls.Add(this.dataGridView1);
            this.Registration.Controls.Add(this.tbId);
            this.Registration.Controls.Add(this.labelid);
            this.Registration.Controls.Add(this.BTinsert);
            this.Registration.Controls.Add(this.tbPassword);
            this.Registration.Controls.Add(this.tbLogin);
            this.Registration.Controls.Add(this.labelPassword);
            this.Registration.Controls.Add(this.labelLogin);
            this.Registration.Location = new System.Drawing.Point(4, 25);
            this.Registration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Registration.Name = "Registration";
            this.Registration.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Registration.Size = new System.Drawing.Size(809, 453);
            this.Registration.TabIndex = 1;
            this.Registration.Text = "Регистрация пользователей";
            this.Registration.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 145);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 299);
            this.dataGridView1.TabIndex = 15;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(13, 38);
            this.tbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(116, 21);
            this.tbId.TabIndex = 13;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(9, 18);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(21, 16);
            this.labelid.TabIndex = 11;
            this.labelid.Text = "id:";
            // 
            // BTinsert
            // 
            this.BTinsert.Location = new System.Drawing.Point(352, 86);
            this.BTinsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTinsert.Name = "BTinsert";
            this.BTinsert.Size = new System.Drawing.Size(87, 28);
            this.BTinsert.TabIndex = 10;
            this.BTinsert.Text = "добавить";
            this.BTinsert.UseVisualStyleBackColor = true;
            this.BTinsert.Click += new System.EventHandler(this.BTinsert_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(195, 86);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(116, 21);
            this.tbPassword.TabIndex = 9;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(195, 38);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(116, 21);
            this.tbLogin.TabIndex = 8;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(183, 66);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(52, 16);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "пароль:";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(191, 18);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(42, 16);
            this.labelLogin.TabIndex = 6;
            this.labelLogin.Text = "логин:";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 507);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим администратора ";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Results.ResumeLayout(false);
            this.Registration.ResumeLayout(false);
            this.Registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Results;
        private System.Windows.Forms.TabPage Registration;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Button BTinsert;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}