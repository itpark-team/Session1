using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppSmyslov13
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            DrugsStoreEntities db = new DrugsStoreEntities();

            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            User user = db.Users.FirstOrDefault(item => item.Login == login && item.Passowrd == password);

            if (user == null)
            {
                MessageBox.Show("Ошибка. Пользователь с такой парой логин-пароль не найдет!");
            }
            else
            {
                new FormWork().Show();
            }

        }
    }
}
