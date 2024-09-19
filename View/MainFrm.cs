using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmApp.View
{
    public partial class MainFrm : Form
    {
        private AnimalController controller;

        public MainFrm()
        {
            InitializeComponent();
            controller = new AnimalController();
            RefreshAnimalData();
        }

        private void btnAddCow_Click(object sender, EventArgs e)
        {
            controller.AddNewAnimal("Cow");
            RefreshAnimalData();
        }
        private void btnAddGoat_Click(object sender, EventArgs e)
        {
            controller.AddNewAnimal("Goat");
            RefreshAnimalData();
        }
        private void btnAddSheep_Click(object sender, EventArgs e)
        {
            controller.AddNewAnimal("Sheep");
            RefreshAnimalData();
        }
        private void btnShowSounds_Click(object sender, EventArgs e)
        {
            string sounds = controller.GetAnimalSounds();
            MessageBox.Show(sounds, "Animal sounds");
        }

        private void btnSimulateDay_Click(object sender, EventArgs e)
        {
            controller.SimulateNewDay();
            RefreshAnimalData();
        }
        private void btnShowTotalMilk_Click(object sender, EventArgs e)
        {
            decimal totalMilk = controller.GetTotalMilkProduced();
            lblTotalMilk.Text = $"Total Milk: {totalMilk} liters";
        }
        private void RefreshAnimalData()
        {
            lblCowCount.Text = controller.GetAnimalCount("Cow").ToString();
            lblSheepCount.Text = controller.GetAnimalCount("Sheep").ToString();
            lblGoatCount.Text = controller.GetAnimalCount("Goat").ToString();
        }
    }
}
