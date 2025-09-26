using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuroBuddy.Common.Entities;
using NeuroBuddy.Common.Interfaces;

namespace NeuroBuddy.View
{
    public partial class AssignUserWindow : Form, ILoginView
    {
        public event Action<UserInfo> SignInButtonClicked;
        public event Action<UserInfo> SignUpButtonClicked;
        UserInfo user = new();
        public AssignUserWindow()
        {
            InitializeComponent();
            user.Id = 2; 

        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            user.Username = username.Text;
            SignInButtonClicked.Invoke(user);
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            user.Username = username.Text;
           
            SignUpButtonClicked.Invoke(user);

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            user.Username = username.Text;
        }

        public void ShowMainWindow()
        {
            Form view = new MainView();
            view.Show();
        }
    }
}
