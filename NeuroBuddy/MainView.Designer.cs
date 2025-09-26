using System.Windows.Forms;

namespace NeuroBuddy
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            Top_panel = new Panel();
            Username_Label = new Label();
            panel3 = new Panel();
            NeuroBuddy_button = new Button();
            Calender_panel = new Panel();
            Menu_panel = new Panel();
            Notes_button = new Button();
            LogOut_button = new Button();
            Calender_button = new Button();
            Reminders_button = new Button();
            Activities_button = new Button();
            Category_button = new Button();
            Home_button = new Button();
            Category_panel = new Panel();
            Category_treeView = new TreeView();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            Top_panel.SuspendLayout();
            panel3.SuspendLayout();
            Menu_panel.SuspendLayout();
            Category_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Top_panel
            // 
            Top_panel.BackColor = Color.PaleVioletRed;
            Top_panel.Controls.Add(Username_Label);
            Top_panel.Controls.Add(panel3);
            Top_panel.Location = new Point(0, 10);
            Top_panel.Name = "Top_panel";
            Top_panel.Size = new Size(948, 55);
            Top_panel.TabIndex = 2;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username_Label.Location = new Point(407, 10);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(65, 28);
            Username_Label.TabIndex = 1;
            Username_Label.Text = "label1";
            Username_Label.UseMnemonic = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(150, 80, 130);
            panel3.Controls.Add(NeuroBuddy_button);
            panel3.Location = new Point(0, -7);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 75);
            panel3.TabIndex = 0;
            // 
            // NeuroBuddy_button
            // 
            NeuroBuddy_button.FlatStyle = FlatStyle.Flat;
            NeuroBuddy_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NeuroBuddy_button.ForeColor = Color.BurlyWood;
            NeuroBuddy_button.ImageAlign = ContentAlignment.MiddleLeft;
            NeuroBuddy_button.Location = new Point(-1, -2);
            NeuroBuddy_button.Name = "NeuroBuddy_button";
            NeuroBuddy_button.Size = new Size(213, 72);
            NeuroBuddy_button.TabIndex = 0;
            NeuroBuddy_button.Text = "NeuroBuddy";
            NeuroBuddy_button.UseVisualStyleBackColor = true;
            // 
            // Calender_panel
            // 
            Calender_panel.Location = new Point(200, 71);
            Calender_panel.Name = "Calender_panel";
            Calender_panel.Size = new Size(751, 469);
            Calender_panel.TabIndex = 5;
            // 
            // Menu_panel
            // 
            Menu_panel.BackColor = Color.FromArgb(97, 54, 89);
            Menu_panel.Controls.Add(Notes_button);
            Menu_panel.Controls.Add(LogOut_button);
            Menu_panel.Controls.Add(Calender_button);
            Menu_panel.Controls.Add(Reminders_button);
            Menu_panel.Controls.Add(Activities_button);
            Menu_panel.Controls.Add(Category_button);
            Menu_panel.Controls.Add(Home_button);
            Menu_panel.Location = new Point(0, 66);
            Menu_panel.Name = "Menu_panel";
            Menu_panel.Size = new Size(194, 482);
            Menu_panel.TabIndex = 3;
            // 
            // Notes_button
            // 
            Notes_button.BackgroundImageLayout = ImageLayout.None;
            Notes_button.Dock = DockStyle.Top;
            Notes_button.FlatStyle = FlatStyle.Popup;
            Notes_button.Font = new Font("Microsoft Sans Serif", 9F);
            Notes_button.ForeColor = Color.BlanchedAlmond;
            Notes_button.Image = (Image)resources.GetObject("Notes_button.Image");
            Notes_button.ImageAlign = ContentAlignment.BottomLeft;
            Notes_button.Location = new Point(0, 285);
            Notes_button.Margin = new Padding(0);
            Notes_button.Name = "Notes_button";
            Notes_button.RightToLeft = RightToLeft.No;
            Notes_button.Size = new Size(194, 57);
            Notes_button.TabIndex = 6;
            Notes_button.Text = "Notes";
            Notes_button.UseVisualStyleBackColor = true;
            // 
            // LogOut_button
            // 
            LogOut_button.BackColor = Color.PeachPuff;
            LogOut_button.BackgroundImageLayout = ImageLayout.None;
            LogOut_button.Dock = DockStyle.Bottom;
            LogOut_button.FlatStyle = FlatStyle.Popup;
            LogOut_button.Font = new Font("Microsoft Sans Serif", 9F);
            LogOut_button.ForeColor = Color.Crimson;
            LogOut_button.Image = (Image)resources.GetObject("LogOut_button.Image");
            LogOut_button.ImageAlign = ContentAlignment.MiddleLeft;
            LogOut_button.Location = new Point(0, 442);
            LogOut_button.Margin = new Padding(0);
            LogOut_button.Name = "LogOut_button";
            LogOut_button.RightToLeft = RightToLeft.No;
            LogOut_button.Size = new Size(194, 40);
            LogOut_button.TabIndex = 5;
            LogOut_button.Text = "Log out";
            LogOut_button.UseCompatibleTextRendering = true;
            LogOut_button.UseVisualStyleBackColor = false;
            // 
            // Calender_button
            // 
            Calender_button.BackgroundImageLayout = ImageLayout.None;
            Calender_button.Dock = DockStyle.Top;
            Calender_button.FlatStyle = FlatStyle.Popup;
            Calender_button.Font = new Font("Microsoft Sans Serif", 9F);
            Calender_button.ForeColor = Color.BlanchedAlmond;
            Calender_button.Image = (Image)resources.GetObject("Calender_button.Image");
            Calender_button.ImageAlign = ContentAlignment.BottomLeft;
            Calender_button.Location = new Point(0, 228);
            Calender_button.Margin = new Padding(0);
            Calender_button.Name = "Calender_button";
            Calender_button.RightToLeft = RightToLeft.No;
            Calender_button.Size = new Size(194, 57);
            Calender_button.TabIndex = 4;
            Calender_button.Text = "Calender";
            Calender_button.UseVisualStyleBackColor = true;
            // 
            // Reminders_button
            // 
            Reminders_button.BackgroundImageLayout = ImageLayout.None;
            Reminders_button.Dock = DockStyle.Top;
            Reminders_button.FlatStyle = FlatStyle.Popup;
            Reminders_button.Font = new Font("Microsoft Sans Serif", 9F);
            Reminders_button.ForeColor = Color.BlanchedAlmond;
            Reminders_button.Image = (Image)resources.GetObject("Reminders_button.Image");
            Reminders_button.ImageAlign = ContentAlignment.BottomLeft;
            Reminders_button.Location = new Point(0, 171);
            Reminders_button.Margin = new Padding(0);
            Reminders_button.Name = "Reminders_button";
            Reminders_button.RightToLeft = RightToLeft.No;
            Reminders_button.Size = new Size(194, 57);
            Reminders_button.TabIndex = 3;
            Reminders_button.Text = "Reminders";
            Reminders_button.UseVisualStyleBackColor = true;
            // 
            // Activities_button
            // 
            Activities_button.BackgroundImageLayout = ImageLayout.None;
            Activities_button.Dock = DockStyle.Top;
            Activities_button.FlatStyle = FlatStyle.Popup;
            Activities_button.Font = new Font("Microsoft Sans Serif", 9F);
            Activities_button.ForeColor = Color.BlanchedAlmond;
            Activities_button.Image = (Image)resources.GetObject("Activities_button.Image");
            Activities_button.ImageAlign = ContentAlignment.BottomLeft;
            Activities_button.Location = new Point(0, 114);
            Activities_button.Margin = new Padding(0);
            Activities_button.Name = "Activities_button";
            Activities_button.RightToLeft = RightToLeft.No;
            Activities_button.Size = new Size(194, 57);
            Activities_button.TabIndex = 2;
            Activities_button.Text = "Activies";
            Activities_button.UseVisualStyleBackColor = true;
            // 
            // Category_button
            // 
            Category_button.BackgroundImageLayout = ImageLayout.None;
            Category_button.Dock = DockStyle.Top;
            Category_button.FlatStyle = FlatStyle.Popup;
            Category_button.Font = new Font("Microsoft Sans Serif", 9F);
            Category_button.ForeColor = Color.BlanchedAlmond;
            Category_button.Image = (Image)resources.GetObject("Category_button.Image");
            Category_button.ImageAlign = ContentAlignment.BottomLeft;
            Category_button.Location = new Point(0, 57);
            Category_button.Margin = new Padding(0);
            Category_button.Name = "Category_button";
            Category_button.RightToLeft = RightToLeft.No;
            Category_button.Size = new Size(194, 57);
            Category_button.TabIndex = 1;
            Category_button.Text = "Category";
            Category_button.UseVisualStyleBackColor = true;
            // 
            // Home_button
            // 
            Home_button.BackColor = Color.FromArgb(97, 54, 89);
            Home_button.BackgroundImageLayout = ImageLayout.None;
            Home_button.Dock = DockStyle.Top;
            Home_button.FlatStyle = FlatStyle.Popup;
            Home_button.Font = new Font("Microsoft Sans Serif", 9F);
            Home_button.ForeColor = Color.BlanchedAlmond;
            Home_button.Image = (Image)resources.GetObject("Home_button.Image");
            Home_button.ImageAlign = ContentAlignment.BottomLeft;
            Home_button.Location = new Point(0, 0);
            Home_button.Margin = new Padding(0);
            Home_button.Name = "Home_button";
            Home_button.RightToLeft = RightToLeft.No;
            Home_button.Size = new Size(194, 57);
            Home_button.TabIndex = 0;
            Home_button.Text = "Home";
            Home_button.UseVisualStyleBackColor = false;
            // 
            // Category_panel
            // 
            Category_panel.Controls.Add(Category_treeView);
            Category_panel.Location = new Point(227, 123);
            Category_panel.Name = "Category_panel";
            Category_panel.Size = new Size(751, 469);
            Category_panel.TabIndex = 4;
            // 
            // Category_treeView
            // 
            Category_treeView.Anchor = AnchorStyles.None;
            Category_treeView.BackColor = Color.FromArgb(33, 21, 34);
            Category_treeView.BorderStyle = BorderStyle.None;
            Category_treeView.Location = new Point(69, 35);
            Category_treeView.Name = "Category_treeView";
            Category_treeView.Size = new Size(473, 346);
            Category_treeView.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 100);
            tabPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(0, 0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(200, 100);
            tabPage2.TabIndex = 0;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 21, 34);
            ClientSize = new Size(960, 547);
            Controls.Add(Calender_panel);
            Controls.Add(Category_panel);
            Controls.Add(Menu_panel);
            Controls.Add(Top_panel);
            Name = "MainView";
            Text = "MainView";
            Top_panel.ResumeLayout(false);
            Top_panel.PerformLayout();
            panel3.ResumeLayout(false);
            Menu_panel.ResumeLayout(false);
            Category_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel Top_panel;
        private Panel Menu_panel;
        private Button Home_button;
        private Button Reminders_button;
        private Button Activities_button;
        private Button Category_button;
        private Button Calender_button;
        private Panel panel3;
        private Button LogOut_button;
        private Button Notes_button;
        private Button NeuroBuddy_button;
        private Label Username_Label;
        private Panel Category_panel;
        private TreeView Category_treeView;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel Calender_panel;
    }
}