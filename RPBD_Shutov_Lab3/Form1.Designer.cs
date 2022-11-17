namespace RPBD_Shutov_Lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            shop.Dispose();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.basketsListBox = new System.Windows.Forms.ListBox();
            this.productsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.ComboBox();
            this.productId = new System.Windows.Forms.ComboBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.productDescription = new System.Windows.Forms.RichTextBox();
            this.productPrice = new System.Windows.Forms.TextBox();
            this.customerId = new System.Windows.Forms.ComboBox();
            this.productStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.editUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.filterUser = new System.Windows.Forms.Button();
            this.filterByProduct = new System.Windows.Forms.Button();
            this.deleteBasket = new System.Windows.Forms.Button();
            this.addBasket = new System.Windows.Forms.Button();
            this.editBasket = new System.Windows.Forms.Button();
            this.filterProduct = new System.Windows.Forms.Button();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.editProduct = new System.Windows.Forms.Button();
            this.BasketIdTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.filterByUser = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.filterByStatus = new System.Windows.Forms.Button();
            this.filterByCustomer = new System.Windows.Forms.Button();
            this.exampleDataButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 15;
            this.usersListBox.Location = new System.Drawing.Point(135, 36);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(178, 379);
            this.usersListBox.TabIndex = 3;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // basketsListBox
            // 
            this.basketsListBox.FormattingEnabled = true;
            this.basketsListBox.ItemHeight = 15;
            this.basketsListBox.Location = new System.Drawing.Point(481, 36);
            this.basketsListBox.Name = "basketsListBox";
            this.basketsListBox.Size = new System.Drawing.Size(178, 379);
            this.basketsListBox.TabIndex = 4;
            this.basketsListBox.SelectedIndexChanged += new System.EventHandler(this.basketsListBox_SelectedIndexChanged);
            // 
            // productsListBox
            // 
            this.productsListBox.FormattingEnabled = true;
            this.productsListBox.ItemHeight = 15;
            this.productsListBox.Location = new System.Drawing.Point(833, 36);
            this.productsListBox.Name = "productsListBox";
            this.productsListBox.Size = new System.Drawing.Size(178, 379);
            this.productsListBox.TabIndex = 5;
            this.productsListBox.SelectedIndexChanged += new System.EventHandler(this.productsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Users";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(491, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baskets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(833, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Products";
            // 
            // userId
            // 
            this.userId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userId.FormattingEnabled = true;
            this.userId.Location = new System.Drawing.Point(665, 110);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(156, 23);
            this.userId.TabIndex = 9;
            // 
            // productId
            // 
            this.productId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productId.FormattingEnabled = true;
            this.productId.Location = new System.Drawing.Point(665, 191);
            this.productId.Name = "productId";
            this.productId.Size = new System.Drawing.Size(156, 23);
            this.productId.TabIndex = 10;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userIdTextBox.Location = new System.Drawing.Point(319, 67);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.ReadOnly = true;
            this.userIdTextBox.Size = new System.Drawing.Size(156, 22);
            this.userIdTextBox.TabIndex = 11;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(319, 110);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(156, 23);
            this.userName.TabIndex = 12;
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productIdTextBox.Location = new System.Drawing.Point(1017, 67);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.ReadOnly = true;
            this.productIdTextBox.Size = new System.Drawing.Size(156, 22);
            this.productIdTextBox.TabIndex = 13;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(1017, 110);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(156, 23);
            this.productName.TabIndex = 14;
            // 
            // productDescription
            // 
            this.productDescription.Location = new System.Drawing.Point(1017, 155);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(156, 130);
            this.productDescription.TabIndex = 15;
            this.productDescription.Text = "";
            // 
            // productPrice
            // 
            this.productPrice.Location = new System.Drawing.Point(1017, 303);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(156, 23);
            this.productPrice.TabIndex = 16;
            // 
            // customerId
            // 
            this.customerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerId.FormattingEnabled = true;
            this.customerId.Location = new System.Drawing.Point(1017, 394);
            this.customerId.Name = "customerId";
            this.customerId.Size = new System.Drawing.Size(126, 23);
            this.customerId.TabIndex = 18;
            // 
            // productStatus
            // 
            this.productStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productStatus.FormattingEnabled = true;
            this.productStatus.Location = new System.Drawing.Point(1017, 347);
            this.productStatus.Name = "productStatus";
            this.productStatus.Size = new System.Drawing.Size(126, 23);
            this.productStatus.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "User";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1017, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1017, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Description";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1017, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Price";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1017, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1017, 373);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Customer";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1017, 479);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(156, 52);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editUser
            // 
            this.editUser.Location = new System.Drawing.Point(135, 421);
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(178, 23);
            this.editUser.TabIndex = 31;
            this.editUser.Text = "Edit";
            this.editUser.UseVisualStyleBackColor = true;
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(135, 450);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(178, 23);
            this.addUser.TabIndex = 32;
            this.addUser.Text = "Add";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(135, 479);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(178, 23);
            this.deleteUser.TabIndex = 33;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // filterUser
            // 
            this.filterUser.Location = new System.Drawing.Point(135, 508);
            this.filterUser.Name = "filterUser";
            this.filterUser.Size = new System.Drawing.Size(178, 23);
            this.filterUser.TabIndex = 34;
            this.filterUser.Text = "Filter";
            this.filterUser.UseVisualStyleBackColor = true;
            this.filterUser.Click += new System.EventHandler(this.filterUser_Click);
            // 
            // filterByProduct
            // 
            this.filterByProduct.Location = new System.Drawing.Point(665, 220);
            this.filterByProduct.Name = "filterByProduct";
            this.filterByProduct.Size = new System.Drawing.Size(156, 23);
            this.filterByProduct.TabIndex = 38;
            this.filterByProduct.Text = "Filter by product";
            this.filterByProduct.UseVisualStyleBackColor = true;
            this.filterByProduct.Click += new System.EventHandler(this.filterByProduct_Click);
            // 
            // deleteBasket
            // 
            this.deleteBasket.Location = new System.Drawing.Point(481, 479);
            this.deleteBasket.Name = "deleteBasket";
            this.deleteBasket.Size = new System.Drawing.Size(178, 23);
            this.deleteBasket.TabIndex = 37;
            this.deleteBasket.Text = "Delete";
            this.deleteBasket.UseVisualStyleBackColor = true;
            this.deleteBasket.Click += new System.EventHandler(this.deleteBasket_Click);
            // 
            // addBasket
            // 
            this.addBasket.Location = new System.Drawing.Point(481, 450);
            this.addBasket.Name = "addBasket";
            this.addBasket.Size = new System.Drawing.Size(178, 23);
            this.addBasket.TabIndex = 36;
            this.addBasket.Text = "Add";
            this.addBasket.UseVisualStyleBackColor = true;
            this.addBasket.Click += new System.EventHandler(this.addBasket_Click);
            // 
            // editBasket
            // 
            this.editBasket.Location = new System.Drawing.Point(481, 421);
            this.editBasket.Name = "editBasket";
            this.editBasket.Size = new System.Drawing.Size(178, 23);
            this.editBasket.TabIndex = 35;
            this.editBasket.Text = "Edit";
            this.editBasket.UseVisualStyleBackColor = true;
            this.editBasket.Click += new System.EventHandler(this.editBasket_Click);
            // 
            // filterProduct
            // 
            this.filterProduct.Location = new System.Drawing.Point(833, 508);
            this.filterProduct.Name = "filterProduct";
            this.filterProduct.Size = new System.Drawing.Size(178, 23);
            this.filterProduct.TabIndex = 42;
            this.filterProduct.Text = "Filter";
            this.filterProduct.UseVisualStyleBackColor = true;
            this.filterProduct.Click += new System.EventHandler(this.filterProduct_Click);
            // 
            // deleteProduct
            // 
            this.deleteProduct.Location = new System.Drawing.Point(833, 479);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(178, 23);
            this.deleteProduct.TabIndex = 41;
            this.deleteProduct.Text = "Delete";
            this.deleteProduct.UseVisualStyleBackColor = true;
            this.deleteProduct.Click += new System.EventHandler(this.deleteProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(833, 450);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(178, 23);
            this.addProduct.TabIndex = 40;
            this.addProduct.Text = "Add";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // editProduct
            // 
            this.editProduct.Location = new System.Drawing.Point(833, 421);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(178, 23);
            this.editProduct.TabIndex = 39;
            this.editProduct.Text = "Edit";
            this.editProduct.UseVisualStyleBackColor = true;
            this.editProduct.Click += new System.EventHandler(this.editProduct_Click);
            // 
            // BasketIdTextBox
            // 
            this.BasketIdTextBox.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BasketIdTextBox.Location = new System.Drawing.Point(665, 62);
            this.BasketIdTextBox.Name = "BasketIdTextBox";
            this.BasketIdTextBox.ReadOnly = true;
            this.BasketIdTextBox.Size = new System.Drawing.Size(156, 22);
            this.BasketIdTextBox.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(665, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 15);
            this.label14.TabIndex = 44;
            this.label14.Text = "ID";
            // 
            // filterByUser
            // 
            this.filterByUser.Location = new System.Drawing.Point(665, 139);
            this.filterByUser.Name = "filterByUser";
            this.filterByUser.Size = new System.Drawing.Size(156, 23);
            this.filterByUser.TabIndex = 45;
            this.filterByUser.Text = "Filter by user";
            this.filterByUser.UseVisualStyleBackColor = true;
            this.filterByUser.Click += new System.EventHandler(this.filterByUser_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.Location = new System.Drawing.Point(1016, 421);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(157, 52);
            this.eraseButton.TabIndex = 46;
            this.eraseButton.Text = "Erase database";
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // filterByStatus
            // 
            this.filterByStatus.Location = new System.Drawing.Point(1150, 346);
            this.filterByStatus.Name = "filterByStatus";
            this.filterByStatus.Size = new System.Drawing.Size(23, 23);
            this.filterByStatus.TabIndex = 47;
            this.filterByStatus.Text = "F";
            this.filterByStatus.UseVisualStyleBackColor = true;
            this.filterByStatus.Click += new System.EventHandler(this.filterByStatus_Click);
            // 
            // filterByCustomer
            // 
            this.filterByCustomer.Location = new System.Drawing.Point(1150, 394);
            this.filterByCustomer.Name = "filterByCustomer";
            this.filterByCustomer.Size = new System.Drawing.Size(23, 23);
            this.filterByCustomer.TabIndex = 48;
            this.filterByCustomer.Text = "F";
            this.filterByCustomer.UseVisualStyleBackColor = true;
            this.filterByCustomer.Click += new System.EventHandler(this.filterByCustomer_Click);
            // 
            // exampleDataButton
            // 
            this.exampleDataButton.Location = new System.Drawing.Point(8, 508);
            this.exampleDataButton.Name = "exampleDataButton";
            this.exampleDataButton.Size = new System.Drawing.Size(108, 23);
            this.exampleDataButton.TabIndex = 49;
            this.exampleDataButton.Text = "Load example";
            this.exampleDataButton.UseVisualStyleBackColor = true;
            this.exampleDataButton.Click += new System.EventHandler(this.exampleDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 544);
            this.Controls.Add(this.exampleDataButton);
            this.Controls.Add(this.filterByCustomer);
            this.Controls.Add(this.filterByStatus);
            this.Controls.Add(this.eraseButton);
            this.Controls.Add(this.filterByUser);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BasketIdTextBox);
            this.Controls.Add(this.filterProduct);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.editProduct);
            this.Controls.Add(this.filterByProduct);
            this.Controls.Add(this.deleteBasket);
            this.Controls.Add(this.addBasket);
            this.Controls.Add(this.editBasket);
            this.Controls.Add(this.filterUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.editUser);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.productStatus);
            this.Controls.Add(this.customerId);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productsListBox);
            this.Controls.Add(this.basketsListBox);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox comboBox1;
        private ListBox usersListBox;
        private ListBox basketsListBox;
        private ListBox productsListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox userId;
        private ComboBox productId;
        private TextBox userIdTextBox;
        private TextBox userName;
        private TextBox productIdTextBox;
        private TextBox productName;
        private RichTextBox productDescription;
        private TextBox productPrice;
        private ComboBox customerId;
        private ComboBox productStatus;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button saveButton;
        private Button editUser;
        private Button addUser;
        private Button deleteUser;
        private Button filterUser;
        private Button filterByProduct;
        private Button deleteBasket;
        private Button addBasket;
        private Button editBasket;
        private Button filterProduct;
        private Button deleteProduct;
        private Button addProduct;
        private Button editProduct;
        private TextBox BasketIdTextBox;
        private Label label14;
        private Button filterByUser;
        private Button eraseButton;
        private Button filterByStatus;
        private Button filterByCustomer;
        private Button exampleDataButton;
    }
}