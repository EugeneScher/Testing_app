
namespace Тест_по_философии
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BTexit = new System.Windows.Forms.Button();
            this.BTstart = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelResult = new System.Windows.Forms.Label();
            this.RBanswer2 = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.RBanswer3 = new System.Windows.Forms.RadioButton();
            this.RBanswer1 = new System.Windows.Forms.RadioButton();
            this.BTnext = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BTexit);
            this.splitContainer1.Panel1.Controls.Add(this.BTstart);
            this.splitContainer1.Panel1.Controls.Add(this.tbName);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(679, 375);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 0;
            // 
            // BTexit
            // 
            this.BTexit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTexit.Location = new System.Drawing.Point(253, 80);
            this.BTexit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTexit.Name = "BTexit";
            this.BTexit.Size = new System.Drawing.Size(178, 22);
            this.BTexit.TabIndex = 6;
            this.BTexit.Text = "выйти";
            this.BTexit.UseVisualStyleBackColor = true;
            this.BTexit.Visible = false;
            this.BTexit.Click += new System.EventHandler(this.BTexit_Click);
            // 
            // BTstart
            // 
            this.BTstart.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTstart.Location = new System.Drawing.Point(253, 61);
            this.BTstart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTstart.Name = "BTstart";
            this.BTstart.Size = new System.Drawing.Size(178, 22);
            this.BTstart.TabIndex = 5;
            this.BTstart.Text = "начать тестирование";
            this.BTstart.UseVisualStyleBackColor = true;
            this.BTstart.Click += new System.EventHandler(this.BTstart_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(183, 35);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(316, 20);
            this.tbName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(180, 19);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(85, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Введите ФИО:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelResult, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.RBanswer2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelQuestion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RBanswer3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.RBanswer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTnext, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(679, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Location = new System.Drawing.Point(3, 220);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(673, 46);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "label2";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Visible = false;
            // 
            // RBanswer2
            // 
            this.RBanswer2.AutoSize = true;
            this.RBanswer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBanswer2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBanswer2.Location = new System.Drawing.Point(3, 91);
            this.RBanswer2.Name = "RBanswer2";
            this.RBanswer2.Size = new System.Drawing.Size(673, 38);
            this.RBanswer2.TabIndex = 3;
            this.RBanswer2.Text = "radioButton2";
            this.RBanswer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBanswer2.UseVisualStyleBackColor = true;
            this.RBanswer2.Visible = false;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuestion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(3, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(673, 44);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "label1";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.Visible = false;
            // 
            // RBanswer3
            // 
            this.RBanswer3.AutoSize = true;
            this.RBanswer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBanswer3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBanswer3.Location = new System.Drawing.Point(3, 136);
            this.RBanswer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RBanswer3.Name = "RBanswer3";
            this.RBanswer3.Size = new System.Drawing.Size(673, 36);
            this.RBanswer3.TabIndex = 4;
            this.RBanswer3.Text = "radioButton3";
            this.RBanswer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBanswer3.UseVisualStyleBackColor = true;
            this.RBanswer3.Visible = false;
            // 
            // RBanswer1
            // 
            this.RBanswer1.AutoSize = true;
            this.RBanswer1.Checked = true;
            this.RBanswer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RBanswer1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RBanswer1.Location = new System.Drawing.Point(3, 48);
            this.RBanswer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RBanswer1.Name = "RBanswer1";
            this.RBanswer1.Size = new System.Drawing.Size(673, 36);
            this.RBanswer1.TabIndex = 2;
            this.RBanswer1.TabStop = true;
            this.RBanswer1.Text = "radioButton1";
            this.RBanswer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBanswer1.UseVisualStyleBackColor = true;
            this.RBanswer1.Visible = false;
            // 
            // BTnext
            // 
            this.BTnext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTnext.Location = new System.Drawing.Point(3, 180);
            this.BTnext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTnext.Name = "BTnext";
            this.BTnext.Size = new System.Drawing.Size(673, 36);
            this.BTnext.TabIndex = 5;
            this.BTnext.Text = "далее";
            this.BTnext.UseVisualStyleBackColor = true;
            this.BTnext.Visible = false;
            this.BTnext.Click += new System.EventHandler(this.BTnext_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(679, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.HelpToolStripMenuItem.Text = "Инструкция";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click_1);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 375);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "тест по философии";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BTstart;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RadioButton RBanswer1;
        private System.Windows.Forms.RadioButton RBanswer2;
        private System.Windows.Forms.RadioButton RBanswer3;
        private System.Windows.Forms.Button BTnext;
        private System.Windows.Forms.Button BTexit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}