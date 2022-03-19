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
        ReviewManager reviewManager = new ReviewManager();
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
            if(TabControl.SelectedTab == tabUsers)
            {
                DisplayUsers();
                errorMessageDelete.Text = "";
            }
            else if(TabControl.SelectedTab == tabRestuarants)
            {
                DisplayRestaurants();
                ClearTextBoxes();
            }
            else if(TabControl.SelectedTab == tabManageReviews)
            {
                DisplayReviews();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedUser = lbxUsers.SelectedItem;
                User user = ((User)selectedUser);
                userManager.DeleteUser(user);
                errorMessageDelete.Text = "";
                DisplayUsers();

            }
            catch (DelteUserException)
            {
                MessageBox.Show("Unable to delete user");
            }
            catch (Exception)
            {
                errorMessageDelete.Text = "Please, select a user";
            }

        }

        private void DisplayUsers()
        {
            lbxUsers.Items.Clear();
            try 
            {
                foreach (User user in userManager.findAllUsers())
                {
                    lbxUsers.Items.Add(user);
                }
            }
            catch (FindUsersException)
            {
                MessageBox.Show("Unable to find users");
            }
        }

        private void DisplayRestaurants()
        {
            lbxRestaurants.Items.Clear();
            try
            {
                foreach (Restaurant restaurant in restaurantManager.GetAllRestaurants())
                {
                    lbxRestaurants.Items.Add(restaurant);
                }
            }
            catch (RestaurantException)
            {
                MessageBox.Show("Unable to get all restaurants");
            }
        }

        private void DisplayReviews()
        {
            lbxReviews.Items.Clear();
            try
            {
                foreach (Review review in reviewManager.GetAllReviews())
                {
                    lbxReviews.Items.Add(review);
                    lbxReviews.Items.Add(Environment.NewLine);
                }
            }
            catch (RestaurantException)
            {
                MessageBox.Show("Unable to display reviews.");
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
                int number;
                if (int.TryParse(txbStreetNumber.Text, out number))
                {
                    try
                    {
                        restaurantManager.CreateNewRestaurant(txbName.Text, cbxCity.SelectedItem.ToString(), txbStreet.Text, txbPostCode.Text, Convert.ToInt32(txbStreetNumber.Text), txbPhone.Text, has_pakring, has_delivery);
                        DisplayRestaurants();
                        ClearTextBoxes();
                        MessageBox.Show("Restaurant successfully added");
                    }
                    catch (RestaurantException)
                    {
                        MessageBox.Show("Unable to add restaurant");
                    }
                }
                else
                {
                    MessageBox.Show("Street Number must be a digit!");
                }
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

                int number;

                if (int.TryParse(txbStreetNumber.Text, out number))
                {
                    try
                    {
                        restaurantManager.UpdateRestaurantInfo(txbName.Text, cbxCity.SelectedItem.ToString(), txbStreet.Text, txbPostCode.Text, Convert.ToInt32(txbStreetNumber.Text), txbPhone.Text, has_pakring, has_delivery, restaurant);
                        DisplayRestaurants();
                        ClearTextBoxes();
                        MessageBox.Show("Restaurant successfully updated");
                    }
                    catch (RestaurantException)
                    {
                        MessageBox.Show("Unable to update restaurant");
                    }
                }
                else
                {
                    MessageBox.Show("Street Number must be a digit!");
                }
            }
            else
            {
                MessageBox.Show("All fileds must be filled!");
            }

        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedRestaurant = lbxRestaurants.SelectedItem;
                Restaurant restaurant = ((Restaurant)selectedRestaurant);
                ShowFieldsToBeEddited(restaurant);
            }
            catch(Exception)
            {
               MessageBox.Show("Unable to select restaurant");
            }
        }


        private void ShowFieldsToBeEddited(Restaurant restaurant)
        {
            try
            {
                txbName.Text = restaurant.Name;
                txbStreet.Text = restaurant.Street;
                txbStreetNumber.Text = restaurant.StreetNumber.ToString();
                txbPostCode.Text = restaurant.PostCode;
                txbPhone.Text = restaurant.PhoneNumber;

                if (restaurant.HasParking == "Yes")
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
            catch (Exception)
            {
                MessageBox.Show("Unable to display restaurant");
            }
           
        }

        private void btnDeleteRestaurant_Click(object sender, EventArgs e)
        { 
                try
                {
                    object selectedRestaurant = lbxRestaurants.SelectedItem;
                    Restaurant restaurant = ((Restaurant)selectedRestaurant);
                    restaurantManager.DeleteRestaurant(restaurant);
                    DisplayRestaurants();
                }
                catch (RestaurantException)
                {
                    MessageBox.Show("Unable to delete restaurant");
                }
                catch (Exception)
                {
                    MessageBox.Show("Please, select a restaurant to be deleted!");
                }
            
           
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
           
                object selectedReview = lbxReviews.SelectedItem;
                Review review = ((Review)selectedReview);
                try
                {
                    reviewManager.DeleteReview(review);
                    DisplayReviews();
                    MessageBox.Show("Restaurant deleted successfully");
                }
                catch (ReviewException)
                {
                    MessageBox.Show("Unable to delete review");
                }
                catch (Exception)
                {
                    MessageBox.Show("Please, select a review to be deleted!");
                }
                
            
        }
    }
}
