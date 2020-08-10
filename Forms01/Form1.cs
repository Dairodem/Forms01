using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms01
{
    public partial class Form1 : Form
    {
        List<string> listNamen = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFullList.Items.Add("Appel");
            cbFullList.Items.Add("Peer");
            cbFullList.Items.Add("Banaan");
            cbFullList.Items.Add("Druif");
            cbFullList.Items.Add("Kiwi");
            cbFullList.Items.Add("Citroen");

            listNamen.Add("Ann");
            listNamen.Add("Bart");
            listNamen.Add("Carine");
            listNamen.Add("Davy");
            listNamen.Add("Frederic");
            listNamen.Add("Hans");
            listNamen.Add("Karel");
            listNamen.Add("Sofie");
            listNamen.Add("Walter");
            listNamen.Add("Tuur");

            foreach (string item in listNamen)
            {
                lbNamenLijst.Items.Add(item);
            }

            BindingList<User> gebruikers = new BindingList<User>();
            cbVoornamen.DisplayMember = "voornaam";
            cbVoornamen.ValueMember = "familienaam";

            gebruikers.Add(new User("Dairo", "Demeulemeester"));
            gebruikers.Add(new User("Niels", "Verdru"));
            gebruikers.Add(new User("Kees", "Jacobs"));
            gebruikers.Add(new User("Marc", "Zuiker"));

            cbVoornamen.DataSource = gebruikers;


        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            lbMijnLijst.Items.Add(txtInput1.Text);
            txtInput1.Text = "";
            txtInput1.Focus();
        }

        private void txtInput1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVoegToe_Click(sender, e);
            }

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbFullList.Text + " werd verwijdert");
            cbFullList.Items.Remove(cbFullList.Text);
        }

        private void lbNamenLijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<string> listFiltered = new List<string>();

            foreach (string item in listNamen)
            {
                if (item.Contains(txtFilter.Text))
                {
                    listFiltered.Add(item);

                }

            }
            lbNamenLijst.Items.Clear();

            foreach (string name in listFiltered)
            {
                lbNamenLijst.Items.Add(name);
                
            }
            txtFilter.Text = "";
            txtFilter.Focus();

        }

        private void cbVoornamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShowName_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbVoornamen.SelectedValue.ToString());
        }

        private void txtInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

    }
}
