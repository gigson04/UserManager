using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManager
{

    public partial class ListForm : Form
    {
        UserRepository userRepository = new UserRepository();

        public ListForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateForms form = new CreateForms();
            form.ShowDialog();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to User Manager!");
            NewMethod();
        }

        private void NewMethod()
        {
            List<UserModel> users = userRepository.GetAll();
            dgViewUsers.DataSource = users;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }

}
