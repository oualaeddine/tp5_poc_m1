using PileClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Windows.Forms;

namespace Clients
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


     

        private void creer_pile_Click(object sender, EventArgs e)
        {
            int size = decimal.ToInt32(taille.Value)
;
             p = usine.creerUnePile(size);
            creer_pile.Enabled = false;
            taille.Enabled = false;
         
            MessageBox.Show("pile créé avec succes");
        }

        private void add_stud_Click(object sender, EventArgs e)
        {

            Etudiant etud = new Etudiant(decimal.ToInt32(id.Value), nom.Text, prenom.Text);
            bool isEmp = p.empiler(etud);
            if (isEmp) {
                add_result.ForeColor = Color.Green;
                MessageBox.Show("Ajouté avec Succes");
            }
            else
            {
                add_result.ForeColor = Color.Red;
                MessageBox.Show("erreur , etudiant non ajouté");
            }
        }

        private UsinePile usine;
        private Pile p;

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void show_size_Click(object sender, EventArgs e)
        {
            MessageBox.Show("taille courante = " +p.lireTailleCourante());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");

                usine = (UsinePile)Activator.GetObject(typeof(UsinePile), "tcp://"+ip.Text+":1234/usinePile");
                MessageBox.Show("connection effectué avec succes a l'usine");
                ip.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR :" + ex.Message);

                Console.WriteLine("ERREUR :" + ex.Message);
            }
        }
    }
}
