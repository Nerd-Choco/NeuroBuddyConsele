using NeuroBuddy.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroBuddy
{
    public partial class MainView : Form
    {
        IUserdatabase userData;
        public MainView(IUserdatabaseProvider provider, string username)
        {
            userData = provider.Load(username);
            InitializeComponent();
            Username_Label.Text = username;
            UpdateCategoryList();
        }
        TreeNode MakeCategoryNode(NeuroCategory category)
        {
            var categoryNode = new TreeNode(category.Name);

            var activities = userData.GetAllActivitesOfCateogry(category.ID);
            foreach (var activity in activities)
            {
                categoryNode.Nodes.Add(new TreeNode(activity.Title));

            }
                return categoryNode;
        }
            void UpdateCategoryList()
            {
                treeView1.Nodes.Clear();


                var rootCategories = userData.GetAllCategories();

                foreach (var rootCat in rootCategories)
                {
                    treeView1.Nodes.Add(MakeCategoryNode(rootCat));
                }
            }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
