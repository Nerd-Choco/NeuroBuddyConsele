namespace NeuroBuddy
{
    partial class AssignUserView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            Registered_button = new Button();
            username_label = new Label();
            username_box = new TextBox();
            register_button = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(265, 27);
            textBox2.TabIndex = 1;
            // 
            // Registered_button
            // 
            Registered_button.BackColor = Color.FromArgb(114, 67, 92);
            Registered_button.FlatStyle = FlatStyle.Flat;
            Registered_button.Location = new Point(226, 116);
            Registered_button.Name = "Registered_button";
            Registered_button.Size = new Size(116, 36);
            Registered_button.TabIndex = 4;
            Registered_button.Text = "Registered";
            Registered_button.UseVisualStyleBackColor = false;
            Registered_button.Click += Registered_button_Click;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(77, 42);
            username_label.Name = "username_label";
            username_label.Size = new Size(75, 20);
            username_label.TabIndex = 5;
            username_label.Text = "Username";
            // 
            // username_box
            // 
            username_box.Location = new Point(77, 65);
            username_box.Name = "username_box";
            username_box.Size = new Size(265, 27);
            username_box.TabIndex = 6;
            username_box.TextChanged += username_box_TextChanged;
            // 
            // register_button
            // 
            register_button.BackColor = Color.FromArgb(232, 180, 184);
            register_button.FlatStyle = FlatStyle.Popup;
            register_button.Location = new Point(77, 116);
            register_button.Name = "register_button";
            register_button.Size = new Size(116, 36);
            register_button.TabIndex = 7;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // AssignUserView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 147, 147);
            ClientSize = new Size(417, 201);
            Controls.Add(register_button);
            Controls.Add(username_box);
            Controls.Add(username_label);
            Controls.Add(Registered_button);
            Name = "AssignUserView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Button SignUp_button;
        private TextBox textBox1;
        private Button Registered_button;
        private Label username_label;
        private Label password_label;
        private TextBox username_box;
        private Button register_button;
    }
}
