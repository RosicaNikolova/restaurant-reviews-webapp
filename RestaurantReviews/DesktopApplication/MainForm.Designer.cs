
namespace DesktopApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.errorMessageDelete = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.tabRestuarants = new System.Windows.Forms.TabPage();
            this.lbxRestaurants = new System.Windows.Forms.ListBox();
            this.groupBoxAddRestaurant = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtParkingNo = new System.Windows.Forms.RadioButton();
            this.rbtParkingYes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtDeliveryNo = new System.Windows.Forms.RadioButton();
            this.rbtDeliveryYes = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteRestaurant = new System.Windows.Forms.Button();
            this.btnUpdateRestaurant = new System.Windows.Forms.Button();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.txbStreetNumber = new System.Windows.Forms.TextBox();
            this.txbPostCode = new System.Windows.Forms.TextBox();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.tabManageReviews = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnDeleteReview = new System.Windows.Forms.Button();
            this.lbxReviews = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddDiscountRestaurant = new System.Windows.Forms.Button();
            this.cmbxDiscountType = new System.Windows.Forms.ComboBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbxNames = new System.Windows.Forms.ComboBox();
            this.lbxDiscounts = new System.Windows.Forms.ListBox();
            this.lblRestDisc = new System.Windows.Forms.Label();
            this.grbxDiscountsOverview = new System.Windows.Forms.GroupBox();
            this.rbtActive = new System.Windows.Forms.RadioButton();
            this.rbtInactive = new System.Windows.Forms.RadioButton();
            this.grbxDiscountDetails = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rbtRestaurants = new System.Windows.Forms.RadioButton();
            this.rbtCustomers = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabRestuarants.SuspendLayout();
            this.groupBoxAddRestaurant.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabManageReviews.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbxDiscountsOverview.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabUsers);
            this.TabControl.Controls.Add(this.tabRestuarants);
            this.TabControl.Controls.Add(this.tabManageReviews);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1255, 869);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.LavenderBlush;
            this.tabUsers.Controls.Add(this.errorMessageDelete);
            this.tabUsers.Controls.Add(this.richTextBox1);
            this.tabUsers.Controls.Add(this.button1);
            this.tabUsers.Controls.Add(this.lbxUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1247, 836);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Manage Users";
            // 
            // errorMessageDelete
            // 
            this.errorMessageDelete.AutoSize = true;
            this.errorMessageDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorMessageDelete.Location = new System.Drawing.Point(257, 355);
            this.errorMessageDelete.Name = "errorMessageDelete";
            this.errorMessageDelete.Size = new System.Drawing.Size(0, 25);
            this.errorMessageDelete.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightPink;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(725, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 232);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Be carefull when deleteing users!\nA user can be delete only when:\n\nThey have susp" +
    "icious behavior\nThey write fake reviews\nThey use vulgar and offending language\n\n" +
    "\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(30, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete User";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 20;
            this.lbxUsers.Location = new System.Drawing.Point(26, 22);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(646, 304);
            this.lbxUsers.TabIndex = 0;
            // 
            // tabRestuarants
            // 
            this.tabRestuarants.BackColor = System.Drawing.Color.LightCyan;
            this.tabRestuarants.Controls.Add(this.lbxRestaurants);
            this.tabRestuarants.Controls.Add(this.groupBoxAddRestaurant);
            this.tabRestuarants.Location = new System.Drawing.Point(4, 29);
            this.tabRestuarants.Name = "tabRestuarants";
            this.tabRestuarants.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestuarants.Size = new System.Drawing.Size(1247, 836);
            this.tabRestuarants.TabIndex = 1;
            this.tabRestuarants.Text = "Manage Restaurants";
            // 
            // lbxRestaurants
            // 
            this.lbxRestaurants.FormattingEnabled = true;
            this.lbxRestaurants.ItemHeight = 20;
            this.lbxRestaurants.Location = new System.Drawing.Point(501, 19);
            this.lbxRestaurants.Name = "lbxRestaurants";
            this.lbxRestaurants.Size = new System.Drawing.Size(675, 764);
            this.lbxRestaurants.TabIndex = 1;
            // 
            // groupBoxAddRestaurant
            // 
            this.groupBoxAddRestaurant.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxAddRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxAddRestaurant.Controls.Add(this.btnSelect);
            this.groupBoxAddRestaurant.Controls.Add(this.groupBox2);
            this.groupBoxAddRestaurant.Controls.Add(this.groupBox1);
            this.groupBoxAddRestaurant.Controls.Add(this.label11);
            this.groupBoxAddRestaurant.Controls.Add(this.label10);
            this.groupBoxAddRestaurant.Controls.Add(this.label9);
            this.groupBoxAddRestaurant.Controls.Add(this.btnDeleteRestaurant);
            this.groupBoxAddRestaurant.Controls.Add(this.btnUpdateRestaurant);
            this.groupBoxAddRestaurant.Controls.Add(this.btnAddRestaurant);
            this.groupBoxAddRestaurant.Controls.Add(this.label6);
            this.groupBoxAddRestaurant.Controls.Add(this.label5);
            this.groupBoxAddRestaurant.Controls.Add(this.label4);
            this.groupBoxAddRestaurant.Controls.Add(this.label3);
            this.groupBoxAddRestaurant.Controls.Add(this.label2);
            this.groupBoxAddRestaurant.Controls.Add(this.label1);
            this.groupBoxAddRestaurant.Controls.Add(this.txbPhone);
            this.groupBoxAddRestaurant.Controls.Add(this.txbStreetNumber);
            this.groupBoxAddRestaurant.Controls.Add(this.txbPostCode);
            this.groupBoxAddRestaurant.Controls.Add(this.txbStreet);
            this.groupBoxAddRestaurant.Controls.Add(this.cbxCity);
            this.groupBoxAddRestaurant.Controls.Add(this.txbName);
            this.groupBoxAddRestaurant.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAddRestaurant.Location = new System.Drawing.Point(33, 16);
            this.groupBoxAddRestaurant.Name = "groupBoxAddRestaurant";
            this.groupBoxAddRestaurant.Size = new System.Drawing.Size(447, 766);
            this.groupBoxAddRestaurant.TabIndex = 0;
            this.groupBoxAddRestaurant.TabStop = false;
            this.groupBoxAddRestaurant.Text = "Add Restaurant";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightCyan;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSelect.Location = new System.Drawing.Point(275, 629);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(79, 44);
            this.btnSelect.TabIndex = 24;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rbtParkingNo);
            this.groupBox2.Controls.Add(this.rbtParkingYes);
            this.groupBox2.Location = new System.Drawing.Point(13, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 50);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parking";
            // 
            // rbtParkingNo
            // 
            this.rbtParkingNo.AutoSize = true;
            this.rbtParkingNo.Location = new System.Drawing.Point(284, 13);
            this.rbtParkingNo.Name = "rbtParkingNo";
            this.rbtParkingNo.Size = new System.Drawing.Size(57, 29);
            this.rbtParkingNo.TabIndex = 7;
            this.rbtParkingNo.TabStop = true;
            this.rbtParkingNo.Text = "No";
            this.rbtParkingNo.UseVisualStyleBackColor = true;
            // 
            // rbtParkingYes
            // 
            this.rbtParkingYes.AutoSize = true;
            this.rbtParkingYes.Location = new System.Drawing.Point(164, 13);
            this.rbtParkingYes.Name = "rbtParkingYes";
            this.rbtParkingYes.Size = new System.Drawing.Size(58, 29);
            this.rbtParkingYes.TabIndex = 6;
            this.rbtParkingYes.TabStop = true;
            this.rbtParkingYes.Text = "Yes";
            this.rbtParkingYes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rbtDeliveryNo);
            this.groupBox1.Controls.Add(this.rbtDeliveryYes);
            this.groupBox1.Location = new System.Drawing.Point(13, 480);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 49);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Delivery";
            // 
            // rbtDeliveryNo
            // 
            this.rbtDeliveryNo.AutoSize = true;
            this.rbtDeliveryNo.Location = new System.Drawing.Point(284, 14);
            this.rbtDeliveryNo.Name = "rbtDeliveryNo";
            this.rbtDeliveryNo.Size = new System.Drawing.Size(57, 29);
            this.rbtDeliveryNo.TabIndex = 9;
            this.rbtDeliveryNo.TabStop = true;
            this.rbtDeliveryNo.Text = "No";
            this.rbtDeliveryNo.UseVisualStyleBackColor = true;
            // 
            // rbtDeliveryYes
            // 
            this.rbtDeliveryYes.AutoSize = true;
            this.rbtDeliveryYes.Location = new System.Drawing.Point(164, 14);
            this.rbtDeliveryYes.Name = "rbtDeliveryYes";
            this.rbtDeliveryYes.Size = new System.Drawing.Size(58, 29);
            this.rbtDeliveryYes.TabIndex = 8;
            this.rbtDeliveryYes.TabStop = true;
            this.rbtDeliveryYes.Text = "Yes";
            this.rbtDeliveryYes.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 712);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Select a restuarant from the box";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 23);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select a restuarant from the box";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 565);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "All fields must be filled";
            // 
            // btnDeleteRestaurant
            // 
            this.btnDeleteRestaurant.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteRestaurant.Location = new System.Drawing.Point(275, 702);
            this.btnDeleteRestaurant.Name = "btnDeleteRestaurant";
            this.btnDeleteRestaurant.Size = new System.Drawing.Size(166, 44);
            this.btnDeleteRestaurant.TabIndex = 18;
            this.btnDeleteRestaurant.Text = "Delete";
            this.btnDeleteRestaurant.UseVisualStyleBackColor = false;
            this.btnDeleteRestaurant.Click += new System.EventHandler(this.btnDeleteRestaurant_Click);
            // 
            // btnUpdateRestaurant
            // 
            this.btnUpdateRestaurant.BackColor = System.Drawing.Color.LightCyan;
            this.btnUpdateRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateRestaurant.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateRestaurant.Location = new System.Drawing.Point(362, 629);
            this.btnUpdateRestaurant.Name = "btnUpdateRestaurant";
            this.btnUpdateRestaurant.Size = new System.Drawing.Size(79, 44);
            this.btnUpdateRestaurant.TabIndex = 17;
            this.btnUpdateRestaurant.Text = "Update";
            this.btnUpdateRestaurant.UseVisualStyleBackColor = false;
            this.btnUpdateRestaurant.Click += new System.EventHandler(this.btnUpdateRestaurant_Click);
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRestaurant.Location = new System.Drawing.Point(275, 546);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(166, 44);
            this.btnAddRestaurant.TabIndex = 1;
            this.btnAddRestaurant.Text = "Add";
            this.btnAddRestaurant.UseVisualStyleBackColor = false;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Street Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Postcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Street";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(177, 369);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(177, 31);
            this.txbPhone.TabIndex = 5;
            // 
            // txbStreetNumber
            // 
            this.txbStreetNumber.Location = new System.Drawing.Point(177, 303);
            this.txbStreetNumber.Name = "txbStreetNumber";
            this.txbStreetNumber.Size = new System.Drawing.Size(177, 31);
            this.txbStreetNumber.TabIndex = 4;
            // 
            // txbPostCode
            // 
            this.txbPostCode.Location = new System.Drawing.Point(177, 247);
            this.txbPostCode.Name = "txbPostCode";
            this.txbPostCode.Size = new System.Drawing.Size(177, 31);
            this.txbPostCode.TabIndex = 3;
            // 
            // txbStreet
            // 
            this.txbStreet.Location = new System.Drawing.Point(177, 182);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(177, 31);
            this.txbStreet.TabIndex = 2;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "Eindhoven",
            "Amsterdam",
            "Rotterdam",
            "The Hague"});
            this.cbxCity.Location = new System.Drawing.Point(177, 114);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(177, 33);
            this.cbxCity.TabIndex = 1;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(177, 53);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(177, 31);
            this.txbName.TabIndex = 0;
            // 
            // tabManageReviews
            // 
            this.tabManageReviews.BackColor = System.Drawing.Color.MistyRose;
            this.tabManageReviews.Controls.Add(this.richTextBox2);
            this.tabManageReviews.Controls.Add(this.btnDeleteReview);
            this.tabManageReviews.Controls.Add(this.lbxReviews);
            this.tabManageReviews.Location = new System.Drawing.Point(4, 29);
            this.tabManageReviews.Name = "tabManageReviews";
            this.tabManageReviews.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageReviews.Size = new System.Drawing.Size(1247, 836);
            this.tabManageReviews.TabIndex = 2;
            this.tabManageReviews.Text = "Manage Reviews";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.LightPink;
            this.richTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(867, 38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(370, 232);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "Be carefull when deleteing reviews!\nA review can be delete only when:\n\nIt is fake" +
    "\nVulgar and offending lanuage is used.\n\n\n";
            // 
            // btnDeleteReview
            // 
            this.btnDeleteReview.BackColor = System.Drawing.Color.Pink;
            this.btnDeleteReview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteReview.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteReview.Location = new System.Drawing.Point(867, 379);
            this.btnDeleteReview.Name = "btnDeleteReview";
            this.btnDeleteReview.Size = new System.Drawing.Size(143, 67);
            this.btnDeleteReview.TabIndex = 2;
            this.btnDeleteReview.Text = "Delete Review";
            this.btnDeleteReview.UseVisualStyleBackColor = false;
            this.btnDeleteReview.Click += new System.EventHandler(this.btnDeleteReview_Click);
            // 
            // lbxReviews
            // 
            this.lbxReviews.AllowDrop = true;
            this.lbxReviews.FormattingEnabled = true;
            this.lbxReviews.ItemHeight = 20;
            this.lbxReviews.Location = new System.Drawing.Point(28, 38);
            this.lbxReviews.Name = "lbxReviews";
            this.lbxReviews.Size = new System.Drawing.Size(818, 744);
            this.lbxReviews.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbxDiscountDetails);
            this.tabPage1.Controls.Add(this.grbxDiscountsOverview);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.lblRestDisc);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1247, 836);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Discounts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MintCream;
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnAddDiscountRestaurant);
            this.groupBox3.Controls.Add(this.cmbxDiscountType);
            this.groupBox3.Controls.Add(this.dtpStartDate);
            this.groupBox3.Controls.Add(this.cmbxNames);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox3.Location = new System.Drawing.Point(35, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 398);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create Discount";
            // 
            // btnAddDiscountRestaurant
            // 
            this.btnAddDiscountRestaurant.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddDiscountRestaurant.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiscountRestaurant.ForeColor = System.Drawing.Color.Honeydew;
            this.btnAddDiscountRestaurant.Location = new System.Drawing.Point(216, 318);
            this.btnAddDiscountRestaurant.Name = "btnAddDiscountRestaurant";
            this.btnAddDiscountRestaurant.Size = new System.Drawing.Size(239, 40);
            this.btnAddDiscountRestaurant.TabIndex = 4;
            this.btnAddDiscountRestaurant.Text = "Create";
            this.btnAddDiscountRestaurant.UseVisualStyleBackColor = false;
            // 
            // cmbxDiscountType
            // 
            this.cmbxDiscountType.FormattingEnabled = true;
            this.cmbxDiscountType.Items.AddRange(new object[] {
            "Customer",
            "Restaurant"});
            this.cmbxDiscountType.Location = new System.Drawing.Point(216, 48);
            this.cmbxDiscountType.Name = "cmbxDiscountType";
            this.cmbxDiscountType.Size = new System.Drawing.Size(108, 28);
            this.cmbxDiscountType.TabIndex = 3;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(216, 215);
            this.dtpStartDate.MinDate = new System.DateTime(2022, 4, 6, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(239, 28);
            this.dtpStartDate.TabIndex = 2;
            // 
            // cmbxNames
            // 
            this.cmbxNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxNames.FormattingEnabled = true;
            this.cmbxNames.Location = new System.Drawing.Point(216, 122);
            this.cmbxNames.Name = "cmbxNames";
            this.cmbxNames.Size = new System.Drawing.Size(239, 28);
            this.cmbxNames.TabIndex = 1;
            // 
            // lbxDiscounts
            // 
            this.lbxDiscounts.FormattingEnabled = true;
            this.lbxDiscounts.ItemHeight = 20;
            this.lbxDiscounts.Location = new System.Drawing.Point(23, 116);
            this.lbxDiscounts.Name = "lbxDiscounts";
            this.lbxDiscounts.Size = new System.Drawing.Size(521, 264);
            this.lbxDiscounts.TabIndex = 5;
            // 
            // lblRestDisc
            // 
            this.lblRestDisc.AutoSize = true;
            this.lblRestDisc.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRestDisc.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lblRestDisc.Location = new System.Drawing.Point(467, 28);
            this.lblRestDisc.Name = "lblRestDisc";
            this.lblRestDisc.Size = new System.Drawing.Size(170, 34);
            this.lblRestDisc.TabIndex = 0;
            this.lblRestDisc.Text = "Discounts";
            // 
            // grbxDiscountsOverview
            // 
            this.grbxDiscountsOverview.BackColor = System.Drawing.Color.DarkGreen;
            this.grbxDiscountsOverview.Controls.Add(this.groupBox5);
            this.grbxDiscountsOverview.Controls.Add(this.groupBox4);
            this.grbxDiscountsOverview.Controls.Add(this.lbxDiscounts);
            this.grbxDiscountsOverview.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grbxDiscountsOverview.ForeColor = System.Drawing.Color.White;
            this.grbxDiscountsOverview.Location = new System.Drawing.Point(531, 88);
            this.grbxDiscountsOverview.Name = "grbxDiscountsOverview";
            this.grbxDiscountsOverview.Size = new System.Drawing.Size(565, 398);
            this.grbxDiscountsOverview.TabIndex = 7;
            this.grbxDiscountsOverview.TabStop = false;
            this.grbxDiscountsOverview.Text = "Discounts Overview";
            // 
            // rbtActive
            // 
            this.rbtActive.AutoSize = true;
            this.rbtActive.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtActive.ForeColor = System.Drawing.Color.Transparent;
            this.rbtActive.Location = new System.Drawing.Point(16, 18);
            this.rbtActive.Name = "rbtActive";
            this.rbtActive.Size = new System.Drawing.Size(89, 24);
            this.rbtActive.TabIndex = 6;
            this.rbtActive.TabStop = true;
            this.rbtActive.Text = "Active";
            this.rbtActive.UseVisualStyleBackColor = true;
            // 
            // rbtInactive
            // 
            this.rbtInactive.AutoSize = true;
            this.rbtInactive.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtInactive.ForeColor = System.Drawing.Color.Transparent;
            this.rbtInactive.Location = new System.Drawing.Point(16, 53);
            this.rbtInactive.Name = "rbtInactive";
            this.rbtInactive.Size = new System.Drawing.Size(108, 24);
            this.rbtInactive.TabIndex = 7;
            this.rbtInactive.TabStop = true;
            this.rbtInactive.Text = "Inactive";
            this.rbtInactive.UseVisualStyleBackColor = true;
            // 
            // grbxDiscountDetails
            // 
            this.grbxDiscountDetails.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grbxDiscountDetails.Location = new System.Drawing.Point(419, 522);
            this.grbxDiscountDetails.Name = "grbxDiscountDetails";
            this.grbxDiscountDetails.Size = new System.Drawing.Size(677, 282);
            this.grbxDiscountDetails.TabIndex = 8;
            this.grbxDiscountDetails.TabStop = false;
            this.grbxDiscountDetails.Text = "DiscountDetails";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Customer/Restaurant:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Select name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Select start date:";
            // 
            // rbtRestaurants
            // 
            this.rbtRestaurants.AutoSize = true;
            this.rbtRestaurants.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtRestaurants.ForeColor = System.Drawing.Color.Transparent;
            this.rbtRestaurants.Location = new System.Drawing.Point(18, 18);
            this.rbtRestaurants.Name = "rbtRestaurants";
            this.rbtRestaurants.Size = new System.Drawing.Size(144, 24);
            this.rbtRestaurants.TabIndex = 8;
            this.rbtRestaurants.TabStop = true;
            this.rbtRestaurants.Text = "Restaurants";
            this.rbtRestaurants.UseVisualStyleBackColor = true;
            // 
            // rbtCustomers
            // 
            this.rbtCustomers.AutoSize = true;
            this.rbtCustomers.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtCustomers.ForeColor = System.Drawing.Color.Transparent;
            this.rbtCustomers.Location = new System.Drawing.Point(18, 50);
            this.rbtCustomers.Name = "rbtCustomers";
            this.rbtCustomers.Size = new System.Drawing.Size(131, 24);
            this.rbtCustomers.TabIndex = 9;
            this.rbtCustomers.TabStop = true;
            this.rbtCustomers.Text = "Customers";
            this.rbtCustomers.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox4.Controls.Add(this.rbtCustomers);
            this.groupBox4.Controls.Add(this.rbtRestaurants);
            this.groupBox4.Location = new System.Drawing.Point(190, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 84);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox5.Controls.Add(this.rbtInactive);
            this.groupBox5.Controls.Add(this.rbtActive);
            this.groupBox5.Location = new System.Drawing.Point(382, 26);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 83);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 857);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.TabControl.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabRestuarants.ResumeLayout(false);
            this.groupBoxAddRestaurant.ResumeLayout(false);
            this.groupBoxAddRestaurant.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabManageReviews.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbxDiscountsOverview.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.TabPage tabRestuarants;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label errorMessageDelete;
        private System.Windows.Forms.ListBox lbxRestaurants;
        private System.Windows.Forms.GroupBox groupBoxAddRestaurant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteRestaurant;
        private System.Windows.Forms.Button btnUpdateRestaurant;
        private System.Windows.Forms.Button btnAddRestaurant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtDeliveryNo;
        private System.Windows.Forms.RadioButton rbtDeliveryYes;
        private System.Windows.Forms.RadioButton rbtParkingNo;
        private System.Windows.Forms.RadioButton rbtParkingYes;
        private System.Windows.Forms.TextBox txbPhone;
        private System.Windows.Forms.TextBox txbStreetNumber;
        private System.Windows.Forms.TextBox txbPostCode;
        private System.Windows.Forms.TextBox txbStreet;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TabPage tabManageReviews;
        private System.Windows.Forms.ListBox lbxReviews;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnDeleteReview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbxDiscountType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ComboBox cmbxNames;
        private System.Windows.Forms.Label lblRestDisc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddDiscountRestaurant;
        private System.Windows.Forms.ListBox lbxDiscounts;
        private System.Windows.Forms.GroupBox grbxDiscountDetails;
        private System.Windows.Forms.GroupBox grbxDiscountsOverview;
        private System.Windows.Forms.RadioButton rbtInactive;
        private System.Windows.Forms.RadioButton rbtActive;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtCustomers;
        private System.Windows.Forms.RadioButton rbtRestaurants;
    }
}