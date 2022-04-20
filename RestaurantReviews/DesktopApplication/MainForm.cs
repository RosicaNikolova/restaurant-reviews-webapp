using ClassLibrary.Business;
using ClassLibrary.Exceptions;
using ClassLibrary.Persistence;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class MainForm : Form
    {
        User user;

        UserManager userManager = new UserManager(new UserRepository());
        RestaurantManager restaurantManager = new RestaurantManager(new RestaurantRepository());
        ReviewManager reviewManager = new ReviewManager(new ReviewRepository());
        DiscountManager discountManager = new DiscountManager(new DiscountRepository());
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
            if (TabControl.SelectedTab == tabUsers)
            {
                DisplayUsers();
                errorMessageDelete.Text = "";
            }
            else if (TabControl.SelectedTab == tabRestuarants)
            {
                DisplayRestaurants();
                ClearTextBoxes();
            }
            else if (TabControl.SelectedTab == tabManageReviews)
            {
                DisplayReviews();
            }
            else if (TabControl.SelectedTab == tabDiscounts)
            {
                UpdateDiscountList();
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
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while deleting the user. Please, contact the support");
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
                foreach (User user in userManager.FindAllUsers())
                {
                    lbxUsers.Items.Add(user);
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while loading the users. Please, contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while loading the users. Please, contact the support");

            }
        }

        private void DisplayRestaurants()
        {
            lbxRestaurants.Items.Clear();
            try
            {
                List<Restaurant> restaurants = new List<Restaurant>();

                foreach (Restaurant restaurant in restaurants)
                {
                    lbxRestaurants.Items.Add(restaurant);
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while loading the restaurants. Please contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while loading the restaurants. Please contact the support");
            }
        }

        private void DisplayReviews()
        {
            lbxReviews.Items.Clear();
            try
            {
                List<Review> reviews = reviewManager.GetAllReviews();
                foreach (Review review in reviews)
                {
                    lbxReviews.Items.Add(review);
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while loading the reviews. Please contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while loading the restaurants. Please contact the support");
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
            try
            {
                restaurantManager.CreateNewRestaurant(txbName.Text, cbxCity.SelectedItem.ToString(), txbStreet.Text, txbPostCode.Text, Convert.ToInt32(txbStreetNumber.Text), txbPhone.Text, has_pakring, has_delivery);
                DisplayRestaurants();
                ClearTextBoxes();
                MessageBox.Show("Restaurant successfully added");
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while creating the restaurant. Please, contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("Entered data is invalid (Street number must be a digit!).");
            }
        }



        private void btnUpdateRestaurant_Click(object sender, EventArgs e)
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

            try
            {
                object selectedRestaurant = lbxRestaurants.SelectedItem;
                Restaurant restaurant = ((Restaurant)selectedRestaurant);
                restaurantManager.UpdateRestaurantInfo(txbName.Text, cbxCity.SelectedItem.ToString(), txbStreet.Text, txbPostCode.Text, Convert.ToInt32(txbStreetNumber.Text), txbPhone.Text, has_pakring, has_delivery, restaurant);
                DisplayRestaurants();
                ClearTextBoxes();
                MessageBox.Show("Restaurant successfully updated");
            }
            catch (RestaurantException)
            {
                MessageBox.Show("Unable to update restaurant. Check the entered information again.");
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while updating the information. Please, contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("All fileds must be filled! (Street Number must be a digit.)");
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
            catch (Exception)
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
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while deleting the restaurant. Please, contact the support.");
            }
            catch (Exception)
            {
                MessageBox.Show("Please, select a restaurant to be deleted!");
            }
        }

        private void btnDeleteReview_Click(object sender, EventArgs e)
        {
            try
            {
                object selectedReview = lbxReviews.SelectedItem;
                Review review = ((Review)selectedReview);
                reviewManager.DeleteReview(review);
                DisplayReviews();
                MessageBox.Show("Restaurant deleted successfully");
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while deleting the review. Please contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("Please, select a review to be deleted!");
            }
        }

        private void cmbxDiscountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxNames.Items.Clear();
            if (cmbxDiscountType.SelectedIndex == 0)
            {
                try
                {
                    List<User> users = new List<User>();
                    users = userManager.FindAllUsersEligibleForDiscount();
                    foreach (User user in users)
                    {
                        cmbxNames.Items.Add(user);
                    }
                }
                catch (DataBaseException)
                {
                    MessageBox.Show("An error occured while loading the customers. Please, contact the support");

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while loading the customers. Please, contact the support");

                }

            }
            else if (cmbxDiscountType.SelectedIndex == 1)
            {
                try
                {
                    List<Restaurant> restaurants = new List<Restaurant>();
                    restaurants = restaurantManager.FindAllRestaurantsEligibleForDiscount();
                    foreach (Restaurant restaurant in restaurants)
                    {
                        cmbxNames.Items.Add(restaurant);
                    }
                }
                catch (DataBaseException)
                {
                    MessageBox.Show("An error occured while loading the restaurants. Please, contact the support");

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while loading the restaurants. Please, contact the support");

                }

            }
        }

        private void btnAddDiscountRestaurant_Click(object sender, EventArgs e)
        {
            if (cmbxDiscountType.SelectedIndex != -1 && cmbxNames.SelectedIndex != -1)
            {
                if (cmbxDiscountType.SelectedIndex == 0)
                {
                    try
                    {
                        object selectedUser = cmbxNames.SelectedItem;
                        User user = ((User)selectedUser);
                        discountManager.CreateUserDiscount(user);
                    }
                    catch (DataBaseException)
                    {

                        MessageBox.Show("An error occured while adding the discount. Please contact the support");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occured while adding the discount. Please contact the support");

                    }

                }
                else if (cmbxDiscountType.SelectedIndex == 1)
                {
                    try
                    {
                        object selectedRestaurant = cmbxNames.SelectedItem;
                        Restaurant restaurant = ((Restaurant)selectedRestaurant);
                        discountManager.CreateRestaurantDiscount(restaurant);
                    }
                    catch (DataBaseException)
                    {

                        MessageBox.Show("An error occured while adding the discount. Please contact the support");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("An error occured while adding the discount. Please contact the support");

                    }
                }
            }
            else
            {
                MessageBox.Show("Please, select a customer or a restaurant");
            }

            UpdateDiscountList();
        }

        private void UpdateDiscountList()
        {
            try
            {
                lbxDiscounts.Items.Clear();
                List<Discount> discounts = new List<Discount>();
                discounts = discountManager.GetAllDiscounts();
                foreach (Discount discount in discounts)
                {
                    lbxDiscounts.Items.Add(discount);
                }
            }
            catch (DataBaseException)
            {
                MessageBox.Show("An error occured while updating the discounts. Please contact the support");
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while updating the discounts. Please contact the support");
            }
        }

        private void lbxDiscounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            object obj = lbxDiscounts.SelectedItem;
            Discount discount = ((Discount)obj);
            if (discount is RestaurantDiscount)
            {
                try
                {
                    RestaurantDiscount restaurantDiscount = ((RestaurantDiscount)discount);
                    SpeacialDish speacialDiscountedDish = new SpeacialDish();
                    speacialDiscountedDish = discountManager.GetSpeshialDish(restaurantDiscount.RestaurantId);
                    ShowFieldsForRestaurant();
                    txbDiscountName.Text = restaurantDiscount.Name;
                    txbDiscountAmount.Text = restaurantDiscount.CalculatedDiscount.ToString() + "%";
                    txbSpeacialDish.Text = speacialDiscountedDish.DishName;
                    txbReguralPrice.Text = Math.Round(speacialDiscountedDish.Price, 2).ToString() + "€";
                    txbRestaurantNameDiscount.Text = restaurantManager.GetRestaurantName(speacialDiscountedDish.RestaurantId);
                    txbPriceWithDiscount.Text = restaurantDiscount.ApplyDiscount(speacialDiscountedDish.Price).ToString() + "€";
                }
                catch (DataBaseException)
                {
                    MessageBox.Show("An error occured while loading the discount. Please, contact the support.");

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while loading the discount. Please, contact the support.");

                }
            }
            else if (discount is UserDiscount)
            {
                try
                {
                    UserDiscount userDiscount = ((UserDiscount)discount);
                    HideFieldsForRestaurant();
                    txbDiscountName.Text = userDiscount.Name;
                    txbDiscountAmount.Text = userDiscount.CalculatedDiscount.ToString() + "%";
                    txbRestaurantNameDiscount.Text = userManager.GetNameOfUser(userDiscount.UserId);
                }
                catch (DataBaseException)
                {
                    MessageBox.Show("An error occured while loading the discount. Please, contact the support.");

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured while loading the discount. Please, contact the support.");
                }
            }
        }

        private void HideFieldsForRestaurant()
        {
            txbSpeacialDish.Hide();
            lblSpeacialdish.Hide();
            lblForName.Text = "Customer";
            txbPriceWithDiscount.Hide();
            lblPriceWithDiscount.Hide();
            lblReguralPrice.Hide();
            txbReguralPrice.Hide();
        }

        private void ShowFieldsForRestaurant()
        {
            txbSpeacialDish.Show();
            lblSpeacialdish.Show();
            lblReguralPrice.Show();
            txbPriceWithDiscount.Show();
            lblPriceWithDiscount.Show();
            txbReguralPrice.Show();

            lblForName.Text = "Restaurant";

        }
    }
}
