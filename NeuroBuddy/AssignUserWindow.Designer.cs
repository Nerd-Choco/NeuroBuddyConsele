namespace NeuroBuddy.View
{
    partial class AssignUserWindow
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
            contentPanel = new Panel();
            textBox2 = new TextBox();
            username = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            signinButton = new Button();
            signupButton = new Button();
            headerPanel = new Panel();
            loginLabel = new Label();
            controlsPanel = new Panel();
            contentPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            controlsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(textBox2);
            contentPanel.Controls.Add(username);
            contentPanel.Controls.Add(passwordLabel);
            contentPanel.Controls.Add(usernameLabel);
            contentPanel.Location = new Point(-5, 69);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(600, 194);
            contentPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 3;
            // 
            // username
            // 
            username.Location = new Point(206, 47);
            username.Name = "username";
            username.Size = new Size(220, 27);
            username.TabIndex = 2;
            username.TextChanged += username_TextChanged;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(119, 101);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(81, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password : ";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(118, 47);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(82, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username :";
            // 
            // signinButton
            // 
            signinButton.Location = new Point(416, 3);
            signinButton.Name = "signinButton";
            signinButton.Size = new Size(139, 55);
            signinButton.TabIndex = 5;
            signinButton.Text = "Sign In";
            signinButton.UseVisualStyleBackColor = true;
            signinButton.Click += signinButton_Click;
            // 
            // signupButton
            // 
            signupButton.Location = new Point(37, 3);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(139, 55);
            signupButton.TabIndex = 6;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = true;
            signupButton.Click += signupButton_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = SystemColors.ControlLightLight;
            headerPanel.Controls.Add(loginLabel);
            headerPanel.Location = new Point(-25, 1);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(651, 76);
            headerPanel.TabIndex = 7;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI", 15F);
            loginLabel.Location = new Point(259, 21);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(104, 35);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Register";
            // 
            // controlsPanel
            // 
            controlsPanel.BackColor = SystemColors.ControlDarkDark;
            controlsPanel.Controls.Add(signinButton);
            controlsPanel.Controls.Add(signupButton);
            controlsPanel.Location = new Point(0, 269);
            controlsPanel.Name = "controlsPanel";
            controlsPanel.Size = new Size(595, 77);
            controlsPanel.TabIndex = 8;
            // 
            // AssignUserWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 334);
            Controls.Add(controlsPanel);
            Controls.Add(headerPanel);
            Controls.Add(contentPanel);
            Name = "AssignUserWindow";
            Text = "NeuroBuddy Login";
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            controlsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel contentPanel;
        private Label passwordLabel;
        private Label usernameLabel;
        private Button signinButton;
        private TextBox textBox2;
        private TextBox username;
        private Button signupButton;
        private Panel headerPanel;
        private Label loginLabel;
        private Panel controlsPanel;
    }
}