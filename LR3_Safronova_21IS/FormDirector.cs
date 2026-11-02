using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LR3_Safronova_21IS.ADO.NET;

namespace LR3_Safronova_21IS
{
    public partial class FormDirector : Form
    {
        public FormDirector()
        {
            InitializeComponent();
        }

        private void FormDirector_Load(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Model1 model = new Model1();
            //Используя ранее заполненное статическое поле формы авторизации заполняем эту форму данными
            labelNames.Text = FormAuthorization.Enter_User.First_Name + " " + FormAuthorization.Enter_User.Second_Name;
            labelRole.Text = model.Roles.First(x => x.ID == FormAuthorization.Enter_User.RoleID).Name;
            pictureBox1.Image = Image.FromFile(@"Photo\" + FormAuthorization.Enter_User.Pictures);
        }
    }
}
