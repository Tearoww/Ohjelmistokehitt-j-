using Autokauppa.controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Autokauppa.model;

namespace Autokauppa.view
{
    public partial class MainMenu : Form
    {
        KaupanLogiikka registerHandler;
        List<AutoMerkki> merkit;
        List<AutoMalli> mallit;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            registerHandler = new KaupanLogiikka();
            merkit = new List<AutoMerkki>(registerHandler.getAllAutoMakers());

            for (int i = 0; i < merkit.Count; i++)
            {
                merkkicomboBox.Items.Add(merkit[i].MerkkiNimi);
            }

            //mallit = new List<AutoMalli>(registerHandler.getAutoModels(10));

            //for (int i = 0; i < mallit.Count; i++)
            //{
            //    mallicomboBox.Items.Add(mallit[i].MalliNimi);
            //}

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testaaTietokantayhteyttäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string viesti = "Yhteys tietokantaan ";
            registerHandler = new KaupanLogiikka();
            if (registerHandler.TestDatabaseConnection())
            {
                viesti += "toimii.";
            }
            else
            {
                viesti += "ei toimi.";
            }
            MessageBox.Show(viesti, "Yhteystesti", MessageBoxButtons.OK);
        }
    }
}
