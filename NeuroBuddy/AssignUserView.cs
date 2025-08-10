using NeuroBuddy.Core;

namespace NeuroBuddy
{
    public partial class AssignUserView : Form
    {
        IUserdatabase db = new JsonUserdatabase();
        IUserdatabaseProvider dbprovider = new JsonProvider();
        public AssignUserView()
        {
            InitializeComponent();
          
        }


        private void Registered_button_Click(object sender, EventArgs e)
        {
            db.Username = username_box.Text;

            if (!dbprovider.IsRegistered(db.Username))
            {
                MessageBox.Show("User is not registered");
                return;
            } 
            var main = new MainView(dbprovider, db.Username);
            main.Show();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            db.Username = username_box.Text;
            dbprovider.SaveUsers(db.Username);

            var Main = new MainView(dbprovider, db.Username);
            Main.Show();
        }

        private void username_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
