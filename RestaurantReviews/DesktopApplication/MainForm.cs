using RestaurantReviews.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class MainForm : Form
    {
        User user;
        UserManager userManager = new UserManager();
        RestaurantManager restaurantManager = new RestaurantManager();
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(User u)
        {
            InitializeComponent();
            user = u;
            DisplayUsers();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabUsers)
            {
                DisplayUsers();
                errorMessageDelete.Text = "";
            }
            else if(tabControl1.SelectedTab == tabRestuarants)
            {
                DisplayRestaurants();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbxUsers.SelectedIndex != -1)
            {
                object selectedUser = lbxUsers.SelectedItem;
                User user = ((User)selectedUser);
                userManager.DeleteUser(user);
                DisplayUsers();
                errorMessageDelete.Text = "";
            }
            else
            {
                errorMessageDelete.Text = "Please, select a user";
            }
            

        }

        private void DisplayUsers()
        {
            lbxUsers.Items.Clear();
            foreach (User user in userManager.findAllUsers())
            {
                lbxUsers.Items.Add(user);
            }
        }

        private void DisplayRestaurants()
        {
            lbxRestaurants.Items.Clear();
            foreach (Restaurant restaurant in restaurantManager.GetAllRestaurants())
            {
                lbxRestaurants.Items.Add(restaurant);
            }
        }

        private void ClearTextBoxes()
        {
            txbName.Text = string.Empty;
            txbStreet.Text = string.Empty;
            txbStreetNumber.Text = string.Empty;
            txbPostCode.Text = string.Empty;
            txbPhone.Text = string.Empty;
            rbtDeliveryNo.Checked = false;
            rbtDeliveryYes.Checked = false;
            rbtParkingNo.Checked = false;
            rbtParkingYes.Checked = false;
            cbxCity.SelectedIndex = -1;
        }

        private void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            if(txbName.Text != string.Empty && cbxCity.SelectedIndex != -1 && txbStreet.Text != string.Empty && txbStreetNumber.Text != string.Empty && txbPostCode.Text != string.Empty && txbPhone.Text != string.Empty && (rbtDeliveryNo.Checked || rbtDeliveryYes.Checked) && (rbtParkingNo.Checked || rbtParkingYes.Checked))
            {
                string has_delivery = "Yes";
                string has_pakring = "Yes";

                if (rbtDeliveryNo.Checked)
                {
                    has_delivery = "No";
                }
                if (rbtParkingNo.Checked)
                {
                    has_pakring = "No";
                }
                restaurantManager.CreateNewRestaurant(txbName.Text, cbxCity.SelectedItem.ToString(), txbStreet.Text,txbPostCode.Text, Convert.ToInt32(txbStreetNumber.Text), txbPhone.Text, has_pakring,has_delivery);
                DisplayRestaurants();
                ClearTextBoxes();
                MessageBox.Show("Restaurant successfully added");
            }
            else
            {
                MessageBox.Show("All fileds must be filled!");
            }
        }

        private void btnUpdateRestaurant_Click(object sender, EventArgs e)
        {
            object selectedRestaurant = lbxRestaurants.SelectedItem;
            Restaurant restaurant = ((Restaurant)selectedRestaurant);

            if (txbName.Text != string.Empty && cbxCity.SelectedIndex != -1 && txbStreet.Text != string.Empty && txbStreetNumber.Text != string.Empty && txbPostCode.Text != string.Empty && txbPhone.Text != string.Empty && (rbtDeliveryNo.Checked || rbtDeliveryYes.Checked) && (rbtParkingNo.Checked || rbtParkingYes.Checked))
            {
                string has_delivery = "Yes";
                string has_pakring = "Yes";

                if (rbtDeliveryNo.Checked)
                {
                    has_delivery = "No";
                }
                if (rbtParkingNo.Checked)
                {
                    has_pakring = "No";
                }
                restaurantManager.UpdateRestaurantInfo(txbName.Text, cbxCity.SelectedItem.ToString(), txbStreet.Text, txbPostCode.Text, Convert.ToInt32(txbStreetNumber.Text), txbPhone.Text, has_pakring, has_delivery, restaurant);
                DisplayRestaurants();
                ClearTextBoxes();
                MessageBox.Show("Restaurant successfully updated");
            }
            else
            {
                MessageBox.Show("All fileds must be filled!");
            }

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            object selectedRestaurant = lbxRestaurants.SelectedItem;
            Restaurant restaurant = ((Restaurant)selectedRestaurant);
            ShowFieldsToBeEddited(restaurant);
        }


        private void ShowFieldsToBeEddited(Restaurant restaurant)
        {
            txbName.Text = restaurant.Name;
            txbStreet.Text = restaurant.Street;
            txbStreetNumber.Text = restaurant.StreetNumber.ToString();
            txbPostCode.Text = restaurant.PostCode;
            txbPhone.Text = restaurant.PhoneNumber;
            if(restaurant.HasParking == "Yes")
            {
                rbtParkingYes.Checked = true;
                rbtParkingNo.Checked = false;
            }
            else
            {
                rbtParkingYes.Checked = false;
                rbtParkingNo.Checked = true;
            }

            if (restaurant.HasDelivery == "Yes")
            {
                rbtDeliveryYes.Checked = true;
                rbtParkingNo.Checked = false;
            }
            else
            {
                rbtDeliveryYes.Checked = false;
                rbtDeliveryNo.Checked = true;
            }

            cbxCity.SelectedItem = restaurant.City;
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        {
            object selectedRestaurant = lbxRestaurants.SelectedItem;
            Restaurant restaurant = ((Restaurant)selectedRestaurant);
            restaurantManager.DeleteRestaurant(restaurant);
            DisplayRestaurants();
        }

       
    }
}
