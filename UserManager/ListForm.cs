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
            UserRepository userRepository = new UserRepository();

            List<UserModel> users = userRepository.GetAll();
            dgViewUsers.DataSource = users;
        }

       
        }
    
}
