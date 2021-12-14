using System;
using CarDealership.model;
using System.Windows.Forms;
using CarDealership.controller;
using System.Collections.Generic;

namespace CarDealership.view
{
    public partial class MainForm : Form
    {
        int id;

        DealershipLogic connectionHandler;
        List<Make> makes;
        List<Model> models;
        List<Color> colors;
        List<Fuel> fuels;
        Car car;

        public MainForm()
        {
            InitializeComponent();
        }

        private bool SetCar(int id)
        {
            bool foundCar = false;

            (car, foundCar) = connectionHandler.GetCar(id);

            if (foundCar)
            {
                models = new(connectionHandler.GetModels(car.MakeId));

                for (int i = 0; i < models.Count; i++)
                {
                    modelComboBox.Items.Add(models[i].ModelName);
                }

                priceTextBox.Text = car.Price.ToString();
                dateOfRegistrationDateTimePicker.Value = car.DateOfRegistration;
                engineDisplacementTextBox.Text = car.EngineDisplacement.ToString();
                mileageTextBox.Text = car.Mileage.ToString();
                makeComboBox.SelectedItem = makes[car.MakeId - 1].Name;
                modelComboBox.SelectedItem = models.Find(model => model.Id == car.ModelId).ModelName;
                colorComboBox.SelectedItem = colors[car.ColorId - 1].ColorName;
                fuelComboBox.SelectedItem = fuels[car.FuelId - 1].FuelName;

                return true;
            }
            else
            {
                return false;
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            connectionHandler = new();
            makes = new(connectionHandler.GetMakes());
            colors = new(connectionHandler.GetColors());
            fuels = new(connectionHandler.GetFuels());
            id = connectionHandler.GetIdentity("ASC");

            for (int i = 0; i < makes.Count; i++)
            {
                makeComboBox.Items.Add(makes[i].Name);
            }

            for (int i = 0; i < colors.Count; i++)
            {
                colorComboBox.Items.Add(colors[i].ColorName);
            }

            for (int i = 0; i < fuels.Count; i++)
            {
                fuelComboBox.Items.Add(fuels[i].FuelName);
            }

            SetCar(id);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionHandler = new();
            string message = "The database connection ";

            if (connectionHandler.TestDatabaseConnection())
            {
                message += "is working!";
            }
            else
            {
                message += "is not working.";
            }

            MessageBox.Show(message, "Connection test", MessageBoxButtons.OK);
        }

        private void makeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = -1;

            modelComboBox.Items.Clear();

            for (int i = 0; i < makeComboBox.Items.Count; i++)
            {
                if (makeComboBox.SelectedItem.ToString() == makes[i].Name)
                {
                    models = connectionHandler.GetModels(makes[i].Id);
                }
            }

            for (int i = 0; i < models.Count; i++)
            {
                modelComboBox.Items.Add(models[i].ModelName);
            }
        }

        private void AnyOtherComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            id = -1;
        }

        private void AnyControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            id = -1;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();

            if (id == -1)
            {
                errorLabel.Text = "You've edited one or more of the fields. Please go through the cars using the arrow buttons above to delete.";
            }
            else
            {
                if (connectionHandler.DeleteCar(id))
                {
                    errorLabel.Text = "Car deleted successfully!";
                }
                else
                {
                    errorLabel.Text = "Car couldn't be deleted. Please try again.";
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();
            priceTextBox.ResetText();
            dateOfRegistrationDateTimePicker.ResetText();
            engineDisplacementTextBox.ResetText();
            mileageTextBox.ResetText();
            makeComboBox.SelectedItem = null;
            modelComboBox.SelectedItem = null;
            colorComboBox.SelectedItem = null;
            fuelComboBox.SelectedItem = null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Car car = new();
            bool priceIsCorrect = false, engineDisplacementIsCorrect = false, mileageIsCorrect = false;

            errorLabel.ResetText();

            if (decimal.TryParse(priceTextBox.Text, out decimal price))
            {
                car.Price = price;
                priceIsCorrect = true;

                if (decimal.TryParse(engineDisplacementTextBox.Text, out decimal engineDisplacement))
                {
                    if (engineDisplacement < 10)
                    {
                        car.EngineDisplacement = engineDisplacement;
                        engineDisplacementIsCorrect = true;

                        if (int.TryParse(mileageTextBox.Text, out int mileage))
                        {
                            car.Mileage = mileage;
                            mileageIsCorrect = true;
                        }
                        else
                        {
                            errorLabel.Text = "Mileage can only contain numbers!";
                        }
                    }
                    else
                    {
                        errorLabel.Text = "Engine displacement may not be greater than 10!";
                    }
                }
                else
                {
                    errorLabel.Text = "Engine displacement can only contain numbers and commas!";
                }
            }
            else
            {
                errorLabel.Text = "Price can only contain numbers and commas!";
            }

            car.DateOfRegistration = dateOfRegistrationDateTimePicker.Value;

            if (priceIsCorrect && engineDisplacementIsCorrect && mileageIsCorrect)
            {
                try
                {
                    car.MakeId = makes.Find(make => make.Name == makeComboBox.SelectedItem.ToString()).Id;
                    car.ModelId = models.Find(model => model.ModelName == modelComboBox.SelectedItem.ToString()).Id;
                    car.ColorId = colors.Find(color => color.ColorName == colorComboBox.SelectedItem.ToString()).Id;
                    car.FuelId = fuels.Find(fuel => fuel.FuelName == fuelComboBox.SelectedItem.ToString()).Id;

                    if (connectionHandler.SaveCar(car))
                    {
                        errorLabel.Text = "Car saved successfully!";
                    }
                    else
                    {
                        errorLabel.Text = "Car couldn't be saved. Please try again.";
                    }
                }
                catch (NullReferenceException)
                {
                    errorLabel.Text = "The drop-downs cannot be empty!";
                }
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();

            if (id == -1)
            {
                id = connectionHandler.GetIdentity("DESC");

                SetCar(id);
            }
            else if (id <= connectionHandler.GetIdentity("ASC"))
            {
                errorLabel.Text = "No cars before this one!";
            }
            else
            {
                id--;

                while (!SetCar(id))
                {
                    id--;
                }
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            errorLabel.ResetText();

            if (id == -1)
            {
                id = connectionHandler.GetIdentity("ASC");

                SetCar(id);
            }
            else if (id >= connectionHandler.GetIdentity("DESC"))
            {
                errorLabel.Text = "No cars after this one!";
            }
            else
            {
                id++;

                while (!SetCar(id))
                {
                    id++;
                }
            }
        }
    }
}
