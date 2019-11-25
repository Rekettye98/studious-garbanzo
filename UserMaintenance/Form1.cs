using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName;            
            btnAdd.Text = Resource1.Add;

            listUsers.DataSource = users;
            listUsers.DisplayMember = "FullName";
            listUsers.ValueMember = "ID";            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text                
            };
            users.Add(u);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);               
                
                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.Write(";");
                    sw.Write(u.FullName);
                    sw.WriteLine();
                }
                sw.Close();
            }            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var ID = listUsers.SelectedValue;
            var delete = from x in users
                     where x.ID.ToString() == ID.ToString()
                     select x;
            users.Remove(delete.FirstOrDefault());
        }
    }
}
