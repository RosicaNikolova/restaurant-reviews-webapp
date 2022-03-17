
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.errorMessageDelete = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.tabRestuarants = new System.Windows.Forms.TabPage();
            this.groupBoxAddRestaurant = new System.Windows.Forms.GroupBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.txbStreet = new System.Windows.Forms.TextBox();
            this.txbPostCode = new System.Windows.Forms.TextBox();
            this.txbStreetNumber = new System.Windows.Forms.TextBox();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.rbtParkingYes = new System.Windows.Forms.RadioButton();
            this.rbtParkingNo = new System.Windows.Forms.RadioButton();
            this.rbtDeliveryYes = new System.Windows.Forms.RadioButton();
            this.rbtDeliveryNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.lbxRestaurants = new System.Windows.Forms.ListBox();
            this.btnUpdateRestaurant = new System.Windows.Forms.Button();
            this.btnDeleteRestaurant = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabRestuarants.SuspendLayout();
            this.groupBoxAddRestaurant.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabRestuarants);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1255, 869);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            this.richTextBox1.Location = new System.Drawing.Point(601, 60);
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
            this.lbxUsers.Size = new System.Drawing.Size(481, 304);
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
            // groupBoxAddRestaurant
            // 
            this.groupBoxAddRestaurant.BackColor = System.Drawing.Color.LightBlue;
            this.groupBoxAddRestaurant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBoxAddRestaurant.Controls.Add(this.label11);
            this.groupBoxAddRestaurant.Controls.Add(this.label10);
            this.groupBoxAddRestaurant.Controls.Add(this.label9);
            this.groupBoxAddRestaurant.Controls.Add(this.btnDeleteRestaurant);
            this.groupBoxAddRestaurant.Controls.Add(this.btnUpdateRestaurant);
            this.groupBoxAddRestaurant.Controls.Add(this.btnAddRestaurant);
            this.groupBoxAddRestaurant.Controls.Add(this.label8);
            this.groupBoxAddRestaurant.Controls.Add(this.label7);
            this.groupBoxAddRestaurant.Controls.Add(this.label6);
            this.groupBoxAddRestaurant.Controls.Add(this.label5);
            this.groupBoxAddRestaurant.Controls.Add(this.label4);
            this.groupBoxAddRestaurant.Controls.Add(this.label3);
            this.groupBoxAddRestaurant.Controls.Add(this.label2);
            this.groupBoxAddRestaurant.Controls.Add(this.label1);
            this.groupBoxAddRestaurant.Controls.Add(this.rbtDeliveryNo);
            this.groupBoxAddRestaurant.Controls.Add(this.rbtDeliveryYes);
            this.groupBoxAddRestaurant.Controls.Add(this.rbtParkingNo);
            this.groupBoxAddRestaurant.Controls.Add(this.rbtParkingYes);
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
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(177, 53);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(177, 31);
            this.txbName.TabIndex = 0;
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Location = new System.Drawing.Point(177, 114);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(177, 33);
            this.cbxCity.TabIndex = 1;
            // 
            // txbStreet
            // 
            this.txbStreet.Location = new System.Drawing.Point(177, 182);
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.Size = new System.Drawing.Size(177, 31);
            this.txbStreet.TabIndex = 2;
            // 
            // txbPostCode
            // 
            this.txbPostCode.Location = new System.Drawing.Point(177, 247);
            this.txbPostCode.Name = "txbPostCode";
            this.txbPostCode.Size = new System.Drawing.Size(177, 31);
            this.txbPostCode.TabIndex = 3;
            // 
            // txbStreetNumber
            // 
            this.txbStreetNumber.Location = new System.Drawing.Point(177, 303);
            this.txbStreetNumber.Name = "txbStreetNumber";
            this.txbStreetNumber.Size = new System.Drawing.Size(177, 31);
            this.txbStreetNumber.TabIndex = 4;
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(177, 369);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(177, 31);
            this.txbPhone.TabIndex = 5;
            // 
            // rbtParkingYes
            // 
            this.rbtParkingYes.AutoSize = true;
            this.rbtParkingYes.Location = new System.Drawing.Point(177, 434);
            this.rbtParkingYes.Name = "rbtParkingYes";
            this.rbtParkingYes.Size = new System.Drawing.Size(58, 29);
            this.rbtParkingYes.TabIndex = 6;
            this.rbtParkingYes.TabStop = true;
            this.rbtParkingYes.Text = "Yes";
            this.rbtParkingYes.UseVisualStyleBackColor = true;
            // 
            // rbtParkingNo
            // 
            this.rbtParkingNo.AutoSize = true;
            this.rbtParkingNo.Location = new System.Drawing.Point(297, 434);
            this.rbtParkingNo.Name = "rbtParkingNo";
            this.rbtParkingNo.Size = new System.Drawing.Size(57, 29);
            this.rbtParkingNo.TabIndex = 7;
            this.rbtParkingNo.TabStop = true;
            this.rbtParkingNo.Text = "No";
            this.rbtParkingNo.UseVisualStyleBackColor = true;
            // 
            // rbtDeliveryYes
            // 
            this.rbtDeliveryYes.AutoSize = true;
            this.rbtDeliveryYes.Location = new System.Drawing.Point(177, 488);
            this.rbtDeliveryYes.Name = "rbtDeliveryYes";
            this.rbtDeliveryYes.Size = new System.Drawing.Size(58, 29);
            this.rbtDeliveryYes.TabIndex = 8;
            this.rbtDeliveryYes.TabStop = true;
            this.rbtDeliveryYes.Text = "Yes";
            this.rbtDeliveryYes.UseVisualStyleBackColor = true;
            // 
            // rbtDeliveryNo
            // 
            this.rbtDeliveryNo.AutoSize = true;
            this.rbtDeliveryNo.Location = new System.Drawing.Point(296, 488);
            this.rbtDeliveryNo.Name = "rbtDeliveryNo";
            this.rbtDeliveryNo.Size = new System.Drawing.Size(57, 29);
            this.rbtDeliveryNo.TabIndex = 9;
            this.rbtDeliveryNo.TabStop = true;
            this.rbtDeliveryNo.Text = "No";
            this.rbtDeliveryNo.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "City";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Postcode";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parking";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Delivery";
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddRestaurant.Location = new System.Drawing.Point(297, 549);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(116, 44);
            this.btnAddRestaurant.TabIndex = 1;
            this.btnAddRestaurant.Text = "Add";
            this.btnAddRestaurant.UseVisualStyleBackColor = false;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click);
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
            // btnUpdateRestaurant
            // 
            this.btnUpdateRestaurant.BackColor = System.Drawing.Color.LightCyan;
            this.btnUpdateRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateRestaurant.Location = new System.Drawing.Point(297, 627);
            this.btnUpdateRestaurant.Name = "btnUpdateRestaurant";
            this.btnUpdateRestaurant.Size = new System.Drawing.Size(116, 44);
            this.btnUpdateRestaurant.TabIndex = 17;
            this.btnUpdateRestaurant.Text = "Update";
            this.btnUpdateRestaurant.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRestaurant
            // 
            this.btnDeleteRestaurant.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteRestaurant.Location = new System.Drawing.Point(297, 702);
            this.btnDeleteRestaurant.Name = "btnDeleteRestaurant";
            this.btnDeleteRestaurant.Size = new System.Drawing.Size(116, 44);
            this.btnDeleteRestaurant.TabIndex = 18;
            this.btnDeleteRestaurant.Text = "Delete";
            this.btnDeleteRestaurant.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "All fields must be filled";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(265, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Select a restuarant from the box";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 712);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(265, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Select a restuarant from the box";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 857);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabRestuarants.ResumeLayout(false);
            this.groupBoxAddRestaurant.ResumeLayout(false);
            this.groupBoxAddRestaurant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}