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
            panel1 = new Panel();
            Username_Label = new Label();
            panel2 = new Panel();
            treeView1 = new TreeView();
            listView1 = new ListView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 203, 212);
            panel1.Controls.Add(Username_Label);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 48);
            panel1.TabIndex = 0;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Location = new Point(8, 13);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(50, 20);
            Username_Label.TabIndex = 0;
            Username_Label.Text = "label1";
            Username_Label.Click += Username_Label_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Controls.Add(treeView1);
            panel2.Location = new Point(12, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 444);
            panel2.TabIndex = 1;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(180, 159, 173);
            treeView1.Location = new Point(-13, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(425, 438);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Location = new Point(418, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(320, 355);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 131, 146);
            ClientSize = new Size(765, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainView";
            Text = "MainView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Username_Label;
        private Panel panel2;
        private TreeView treeView1;
        private ListView listView1;
    }
}