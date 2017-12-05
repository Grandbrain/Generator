using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint.Client;

namespace Generator.Application
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void ButtonGenerateClick(object sender, EventArgs e)
        {
            editCookies.Text = string.Empty;
            var cookies = await Task.Run(() => GetCookies(editUrl.Text.Trim(), editAccount.Text.Trim(), editPassword.Text.Trim()));
            if (!string.IsNullOrWhiteSpace(cookies))
            {
                editCookies.Text = cookies;
            }
            else
            {
                MessageBox.Show(this, Properties.Resources.GetCookiesErrorMessage, Properties.Resources.GetCookiesErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCopyClick(object sender, EventArgs e)
        {
            var cookies = editCookies.Text;
            if (!string.IsNullOrWhiteSpace(cookies))
            {
                Clipboard.SetText(cookies);
            }
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Url = editUrl.Text;
            Properties.Settings.Default.Account = editAccount.Text;
            Properties.Settings.Default.Password = editPassword.Text;
            Properties.Settings.Default.Save();
        }

        private void MainFormShown(object sender, EventArgs e)
        {
            editUrl.Text = Properties.Settings.Default.Url;
            editAccount.Text = Properties.Settings.Default.Account;
            editPassword.Text = Properties.Settings.Default.Password;
        }

        private static string GetCookies(string url, string account, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url) || 
                    string.IsNullOrWhiteSpace(account) || 
                    string.IsNullOrWhiteSpace(password)) return null;

                var securePassword = new SecureString();

                foreach (var ch in password)
                    securePassword.AppendChar(ch);

                var credentials = new SharePointOnlineCredentials(account, securePassword);

                return credentials.GetAuthenticationCookie(new Uri(url));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
