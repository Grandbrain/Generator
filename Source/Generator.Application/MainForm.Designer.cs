namespace Generator.Application
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.editUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.editAccount = new System.Windows.Forms.TextBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.editPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.editCookies = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.layoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutTable
            // 
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutTable.Controls.Add(this.editUrl, 1, 0);
            this.layoutTable.Controls.Add(this.labelUrl, 0, 0);
            this.layoutTable.Controls.Add(this.editAccount, 1, 1);
            this.layoutTable.Controls.Add(this.labelAccount, 0, 1);
            this.layoutTable.Controls.Add(this.editPassword, 1, 2);
            this.layoutTable.Controls.Add(this.labelPassword, 0, 2);
            this.layoutTable.Controls.Add(this.buttonGenerate, 0, 3);
            this.layoutTable.Controls.Add(this.editCookies, 0, 4);
            this.layoutTable.Controls.Add(this.buttonCopy, 0, 5);
            this.layoutTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutTable.Location = new System.Drawing.Point(0, 0);
            this.layoutTable.Name = "layoutTable";
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutTable.Size = new System.Drawing.Size(683, 394);
            this.layoutTable.TabIndex = 0;
            // 
            // editUrl
            // 
            this.editUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUrl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editUrl.Location = new System.Drawing.Point(109, 3);
            this.editUrl.Name = "editUrl";
            this.editUrl.Size = new System.Drawing.Size(571, 23);
            this.editUrl.TabIndex = 0;
            this.editUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUrl
            // 
            this.labelUrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUrl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelUrl.Location = new System.Drawing.Point(3, 0);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(100, 29);
            this.labelUrl.TabIndex = 1;
            this.labelUrl.Text = "URL:";
            this.labelUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editAccount
            // 
            this.editAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editAccount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editAccount.Location = new System.Drawing.Point(109, 32);
            this.editAccount.Name = "editAccount";
            this.editAccount.Size = new System.Drawing.Size(571, 23);
            this.editAccount.TabIndex = 2;
            this.editAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelAccount
            // 
            this.labelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAccount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAccount.Location = new System.Drawing.Point(3, 29);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(100, 29);
            this.labelAccount.TabIndex = 3;
            this.labelAccount.Text = "Account:";
            this.labelAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editPassword
            // 
            this.editPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editPassword.Location = new System.Drawing.Point(109, 61);
            this.editPassword.Name = "editPassword";
            this.editPassword.Size = new System.Drawing.Size(571, 23);
            this.editPassword.TabIndex = 4;
            this.editPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPassword.Location = new System.Drawing.Point(3, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 29);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerate
            // 
            this.layoutTable.SetColumnSpan(this.buttonGenerate, 2);
            this.buttonGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonGenerate.Location = new System.Drawing.Point(3, 90);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(677, 23);
            this.buttonGenerate.TabIndex = 6;
            this.buttonGenerate.Text = "Generate Cookies";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerateClick);
            // 
            // editCookies
            // 
            this.layoutTable.SetColumnSpan(this.editCookies, 2);
            this.editCookies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editCookies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editCookies.Location = new System.Drawing.Point(3, 119);
            this.editCookies.Multiline = true;
            this.editCookies.Name = "editCookies";
            this.editCookies.ReadOnly = true;
            this.editCookies.Size = new System.Drawing.Size(677, 243);
            this.editCookies.TabIndex = 7;
            // 
            // buttonCopy
            // 
            this.layoutTable.SetColumnSpan(this.buttonCopy, 2);
            this.buttonCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonCopy.Location = new System.Drawing.Point(3, 368);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(677, 23);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Copy To Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.ButtonCopyClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.layoutTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
            this.Shown += new System.EventHandler(this.MainFormShown);
            this.layoutTable.ResumeLayout(false);
            this.layoutTable.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel layoutTable;
        private System.Windows.Forms.TextBox editAccount;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox editPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox editCookies;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox editUrl;
        private System.Windows.Forms.Label labelUrl;
    }
}

