namespace TheLostMorsel
{
    partial class TheLostMorselForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLostMorselForm));
            this.Tabs = new System.Windows.Forms.TabControl();
            this.WelcomePage = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnHelpFridge = new System.Windows.Forms.Button();
            this.btnHelpCB = new System.Windows.Forms.Button();
            this.btnHelpRcp = new System.Windows.Forms.Button();
            this.CookBookPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbAllRecipesV = new System.Windows.Forms.RadioButton();
            this.rdbNoVegan = new System.Windows.Forms.RadioButton();
            this.rdbVegan = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbAllRecipesS = new System.Windows.Forms.RadioButton();
            this.rdbSweet = new System.Windows.Forms.RadioButton();
            this.rdbSavory = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.FridgePage = new System.Windows.Forms.TabPage();
            this.UpdateIngredientGP = new System.Windows.Forms.GroupBox();
            this.btnUpdateIngredient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpUpdateIngredient = new System.Windows.Forms.DateTimePicker();
            this.txtUpdateIngredient = new System.Windows.Forms.TextBox();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.dgvFridge = new System.Windows.Forms.DataGridView();
            this.AddIngredientGP = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.ExpriationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.IngredientNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SearchIngredientGP = new System.Windows.Forms.GroupBox();
            this.SearchIngredientTextBox = new System.Windows.Forms.TextBox();
            this.DeleteIngredientGP = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.RecipePage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Tabs.SuspendLayout();
            this.WelcomePage.SuspendLayout();
            this.CookBookPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            this.FridgePage.SuspendLayout();
            this.UpdateIngredientGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).BeginInit();
            this.AddIngredientGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SearchIngredientGP.SuspendLayout();
            this.DeleteIngredientGP.SuspendLayout();
            this.RecipePage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.Tabs.Controls.Add(this.WelcomePage);
            this.Tabs.Controls.Add(this.CookBookPage);
            this.Tabs.Controls.Add(this.FridgePage);
            this.Tabs.Controls.Add(this.RecipePage);
            this.Tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.ItemSize = new System.Drawing.Size(100, 50);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(123, 3);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(2564, 1113);
            this.Tabs.TabIndex = 0;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.Tabs_SelectedIndexChanged);
            // 
            // WelcomePage
            // 
            this.WelcomePage.BackColor = System.Drawing.Color.Transparent;
            this.WelcomePage.BackgroundImage = global::TheLostMorsel.Properties.Resources.welcomies;
            this.WelcomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WelcomePage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WelcomePage.Controls.Add(this.label17);
            this.WelcomePage.Controls.Add(this.label20);
            this.WelcomePage.Controls.Add(this.label19);
            this.WelcomePage.Controls.Add(this.label18);
            this.WelcomePage.Controls.Add(this.btnHelpFridge);
            this.WelcomePage.Controls.Add(this.btnHelpCB);
            this.WelcomePage.Controls.Add(this.btnHelpRcp);
            this.WelcomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WelcomePage.Location = new System.Drawing.Point(4, 54);
            this.WelcomePage.Name = "WelcomePage";
            this.WelcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.WelcomePage.Size = new System.Drawing.Size(2556, 1055);
            this.WelcomePage.TabIndex = 0;
            this.WelcomePage.Text = "Welcome!";
            this.WelcomePage.Click += new System.EventHandler(this.WelcomePage_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(11, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(813, 548);
            this.label17.TabIndex = 3;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(2274, 367);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 33);
            this.label20.TabIndex = 6;
            this.label20.Text = "Recipe";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(2282, 239);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 33);
            this.label19.TabIndex = 5;
            this.label19.Text = "Fridge";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(2251, 120);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 33);
            this.label18.TabIndex = 4;
            this.label18.Text = "Cook Book";
            // 
            // btnHelpFridge
            // 
            this.btnHelpFridge.Location = new System.Drawing.Point(2251, 279);
            this.btnHelpFridge.Margin = new System.Windows.Forms.Padding(5);
            this.btnHelpFridge.Name = "btnHelpFridge";
            this.btnHelpFridge.Size = new System.Drawing.Size(157, 56);
            this.btnHelpFridge.TabIndex = 2;
            this.btnHelpFridge.Text = "Help";
            this.btnHelpFridge.UseVisualStyleBackColor = true;
            this.btnHelpFridge.Click += new System.EventHandler(this.btnHelpFridge_Click);
            // 
            // btnHelpCB
            // 
            this.btnHelpCB.Location = new System.Drawing.Point(2251, 160);
            this.btnHelpCB.Margin = new System.Windows.Forms.Padding(5);
            this.btnHelpCB.Name = "btnHelpCB";
            this.btnHelpCB.Size = new System.Drawing.Size(157, 56);
            this.btnHelpCB.TabIndex = 1;
            this.btnHelpCB.Text = "Help";
            this.btnHelpCB.UseVisualStyleBackColor = true;
            this.btnHelpCB.Click += new System.EventHandler(this.btnHelpCB_Click);
            // 
            // btnHelpRcp
            // 
            this.btnHelpRcp.Location = new System.Drawing.Point(2251, 407);
            this.btnHelpRcp.Margin = new System.Windows.Forms.Padding(5);
            this.btnHelpRcp.Name = "btnHelpRcp";
            this.btnHelpRcp.Size = new System.Drawing.Size(157, 56);
            this.btnHelpRcp.TabIndex = 0;
            this.btnHelpRcp.Text = "Help";
            this.btnHelpRcp.UseVisualStyleBackColor = true;
            this.btnHelpRcp.Click += new System.EventHandler(this.btnHelpRcp_Click);
            // 
            // CookBookPage
            // 
            this.CookBookPage.BackgroundImage = global::TheLostMorsel.Properties.Resources.vendingmachine;
            this.CookBookPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CookBookPage.Controls.Add(this.groupBox3);
            this.CookBookPage.Controls.Add(this.groupBox2);
            this.CookBookPage.Controls.Add(this.groupBox1);
            this.CookBookPage.Controls.Add(this.dgvRecipes);
            this.CookBookPage.Location = new System.Drawing.Point(4, 54);
            this.CookBookPage.Name = "CookBookPage";
            this.CookBookPage.Padding = new System.Windows.Forms.Padding(3);
            this.CookBookPage.Size = new System.Drawing.Size(2353, 1055);
            this.CookBookPage.TabIndex = 1;
            this.CookBookPage.Text = "Cook Book";
            this.CookBookPage.UseVisualStyleBackColor = true;
            this.CookBookPage.Click += new System.EventHandler(this.CookBookPage_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbAllRecipesV);
            this.groupBox3.Controls.Add(this.rdbNoVegan);
            this.groupBox3.Controls.Add(this.rdbVegan);
            this.groupBox3.Location = new System.Drawing.Point(1650, 260);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(370, 288);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vegan/Not Vegan";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rdbAllRecipesV
            // 
            this.rdbAllRecipesV.AutoSize = true;
            this.rdbAllRecipesV.Checked = true;
            this.rdbAllRecipesV.Location = new System.Drawing.Point(34, 222);
            this.rdbAllRecipesV.Margin = new System.Windows.Forms.Padding(5);
            this.rdbAllRecipesV.Name = "rdbAllRecipesV";
            this.rdbAllRecipesV.Size = new System.Drawing.Size(219, 43);
            this.rdbAllRecipesV.TabIndex = 2;
            this.rdbAllRecipesV.TabStop = true;
            this.rdbAllRecipesV.Text = "All Recipes";
            this.rdbAllRecipesV.UseVisualStyleBackColor = true;
            this.rdbAllRecipesV.CheckedChanged += new System.EventHandler(this.rdbAllRecipesV_CheckedChanged);
            // 
            // rdbNoVegan
            // 
            this.rdbNoVegan.AutoSize = true;
            this.rdbNoVegan.Location = new System.Drawing.Point(34, 146);
            this.rdbNoVegan.Margin = new System.Windows.Forms.Padding(5);
            this.rdbNoVegan.Name = "rdbNoVegan";
            this.rdbNoVegan.Size = new System.Drawing.Size(207, 43);
            this.rdbNoVegan.TabIndex = 1;
            this.rdbNoVegan.Text = "Not Vegan";
            this.rdbNoVegan.UseVisualStyleBackColor = true;
            this.rdbNoVegan.CheckedChanged += new System.EventHandler(this.rdbNoVegan_CheckedChanged);
            // 
            // rdbVegan
            // 
            this.rdbVegan.AutoSize = true;
            this.rdbVegan.Location = new System.Drawing.Point(34, 70);
            this.rdbVegan.Margin = new System.Windows.Forms.Padding(5);
            this.rdbVegan.Name = "rdbVegan";
            this.rdbVegan.Size = new System.Drawing.Size(143, 43);
            this.rdbVegan.TabIndex = 0;
            this.rdbVegan.Text = "Vegan";
            this.rdbVegan.UseVisualStyleBackColor = true;
            this.rdbVegan.CheckedChanged += new System.EventHandler(this.rdbVegan_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbAllRecipesS);
            this.groupBox2.Controls.Add(this.rdbSweet);
            this.groupBox2.Controls.Add(this.rdbSavory);
            this.groupBox2.Location = new System.Drawing.Point(2029, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(368, 288);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Savory/Sweet";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbAllRecipesS
            // 
            this.rdbAllRecipesS.AutoSize = true;
            this.rdbAllRecipesS.Checked = true;
            this.rdbAllRecipesS.Location = new System.Drawing.Point(34, 222);
            this.rdbAllRecipesS.Margin = new System.Windows.Forms.Padding(5);
            this.rdbAllRecipesS.Name = "rdbAllRecipesS";
            this.rdbAllRecipesS.Size = new System.Drawing.Size(219, 43);
            this.rdbAllRecipesS.TabIndex = 2;
            this.rdbAllRecipesS.TabStop = true;
            this.rdbAllRecipesS.Text = "All Recipes";
            this.rdbAllRecipesS.UseVisualStyleBackColor = true;
            this.rdbAllRecipesS.CheckedChanged += new System.EventHandler(this.rdbAllRecipesS_CheckedChanged);
            // 
            // rdbSweet
            // 
            this.rdbSweet.AutoSize = true;
            this.rdbSweet.Location = new System.Drawing.Point(34, 146);
            this.rdbSweet.Margin = new System.Windows.Forms.Padding(5);
            this.rdbSweet.Name = "rdbSweet";
            this.rdbSweet.Size = new System.Drawing.Size(138, 43);
            this.rdbSweet.TabIndex = 1;
            this.rdbSweet.Text = "Sweet";
            this.rdbSweet.UseVisualStyleBackColor = true;
            this.rdbSweet.CheckedChanged += new System.EventHandler(this.rdbSweet_CheckedChanged);
            // 
            // rdbSavory
            // 
            this.rdbSavory.AutoSize = true;
            this.rdbSavory.Location = new System.Drawing.Point(34, 70);
            this.rdbSavory.Margin = new System.Windows.Forms.Padding(5);
            this.rdbSavory.Name = "rdbSavory";
            this.rdbSavory.Size = new System.Drawing.Size(153, 43);
            this.rdbSavory.TabIndex = 0;
            this.rdbSavory.Text = "Savory";
            this.rdbSavory.UseVisualStyleBackColor = true;
            this.rdbSavory.CheckedChanged += new System.EventHandler(this.rdbSavory_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1650, 122);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(747, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Recipe";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(684, 45);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvRecipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRecipes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(51, 112);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.RowTemplate.Height = 24;
            this.dgvRecipes.Size = new System.Drawing.Size(869, 651);
            this.dgvRecipes.TabIndex = 0;
            // 
            // FridgePage
            // 
            this.FridgePage.BackgroundImage = global::TheLostMorsel.Properties.Resources.flowey;
            this.FridgePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FridgePage.Controls.Add(this.UpdateIngredientGP);
            this.FridgePage.Controls.Add(this.dgvFridge);
            this.FridgePage.Controls.Add(this.AddIngredientGP);
            this.FridgePage.Controls.Add(this.pictureBox2);
            this.FridgePage.Controls.Add(this.SearchIngredientGP);
            this.FridgePage.Controls.Add(this.DeleteIngredientGP);
            this.FridgePage.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridgePage.Location = new System.Drawing.Point(4, 54);
            this.FridgePage.Name = "FridgePage";
            this.FridgePage.Padding = new System.Windows.Forms.Padding(3);
            this.FridgePage.Size = new System.Drawing.Size(2353, 1055);
            this.FridgePage.TabIndex = 2;
            this.FridgePage.Text = "Fridge";
            this.FridgePage.UseVisualStyleBackColor = true;
            // 
            // UpdateIngredientGP
            // 
            this.UpdateIngredientGP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateIngredientGP.BackColor = System.Drawing.Color.Transparent;
            this.UpdateIngredientGP.Controls.Add(this.btnUpdateIngredient);
            this.UpdateIngredientGP.Controls.Add(this.label5);
            this.UpdateIngredientGP.Controls.Add(this.label4);
            this.UpdateIngredientGP.Controls.Add(this.label3);
            this.UpdateIngredientGP.Controls.Add(this.dtpUpdateIngredient);
            this.UpdateIngredientGP.Controls.Add(this.txtUpdateIngredient);
            this.UpdateIngredientGP.Controls.Add(this.txtUpdateId);
            this.UpdateIngredientGP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateIngredientGP.Location = new System.Drawing.Point(1514, 613);
            this.UpdateIngredientGP.Name = "UpdateIngredientGP";
            this.UpdateIngredientGP.Size = new System.Drawing.Size(806, 376);
            this.UpdateIngredientGP.TabIndex = 6;
            this.UpdateIngredientGP.TabStop = false;
            this.UpdateIngredientGP.Text = "Update Ingredient";
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.Location = new System.Drawing.Point(433, 289);
            this.btnUpdateIngredient.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(155, 61);
            this.btnUpdateIngredient.TabIndex = 5;
            this.btnUpdateIngredient.Text = "Update";
            this.btnUpdateIngredient.UseVisualStyleBackColor = true;
            this.btnUpdateIngredient.Click += new System.EventHandler(this.btnUpdateIngredient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expiring Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingredient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // dtpUpdateIngredient
            // 
            this.dtpUpdateIngredient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdateIngredient.Location = new System.Drawing.Point(330, 234);
            this.dtpUpdateIngredient.Margin = new System.Windows.Forms.Padding(5);
            this.dtpUpdateIngredient.Name = "dtpUpdateIngredient";
            this.dtpUpdateIngredient.Size = new System.Drawing.Size(351, 45);
            this.dtpUpdateIngredient.TabIndex = 5;
            // 
            // txtUpdateIngredient
            // 
            this.txtUpdateIngredient.Location = new System.Drawing.Point(330, 137);
            this.txtUpdateIngredient.Margin = new System.Windows.Forms.Padding(5);
            this.txtUpdateIngredient.Name = "txtUpdateIngredient";
            this.txtUpdateIngredient.Size = new System.Drawing.Size(351, 45);
            this.txtUpdateIngredient.TabIndex = 1;
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(330, 59);
            this.txtUpdateId.Margin = new System.Windows.Forms.Padding(5);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.Size = new System.Drawing.Size(103, 45);
            this.txtUpdateId.TabIndex = 0;
            this.txtUpdateId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dgvFridge
            // 
            this.dgvFridge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvFridge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFridge.Location = new System.Drawing.Point(102, 262);
            this.dgvFridge.Name = "dgvFridge";
            this.dgvFridge.RowHeadersWidth = 82;
            this.dgvFridge.RowTemplate.Height = 33;
            this.dgvFridge.Size = new System.Drawing.Size(819, 734);
            this.dgvFridge.TabIndex = 4;
            // 
            // AddIngredientGP
            // 
            this.AddIngredientGP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddIngredientGP.BackColor = System.Drawing.Color.Transparent;
            this.AddIngredientGP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddIngredientGP.Controls.Add(this.label2);
            this.AddIngredientGP.Controls.Add(this.label1);
            this.AddIngredientGP.Controls.Add(this.AddIngredientButton);
            this.AddIngredientGP.Controls.Add(this.ExpriationDatePicker);
            this.AddIngredientGP.Controls.Add(this.IngredientNameTextBox);
            this.AddIngredientGP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddIngredientGP.Location = new System.Drawing.Point(1501, 262);
            this.AddIngredientGP.Name = "AddIngredientGP";
            this.AddIngredientGP.Size = new System.Drawing.Size(806, 338);
            this.AddIngredientGP.TabIndex = 5;
            this.AddIngredientGP.TabStop = false;
            this.AddIngredientGP.Text = "Add Ingredient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expiring Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingredient Name";
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(426, 238);
            this.AddIngredientButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(155, 61);
            this.AddIngredientButton.TabIndex = 2;
            this.AddIngredientButton.Text = "Add";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // ExpriationDatePicker
            // 
            this.ExpriationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpriationDatePicker.Location = new System.Drawing.Point(405, 166);
            this.ExpriationDatePicker.Margin = new System.Windows.Forms.Padding(5);
            this.ExpriationDatePicker.Name = "ExpriationDatePicker";
            this.ExpriationDatePicker.Size = new System.Drawing.Size(351, 45);
            this.ExpriationDatePicker.TabIndex = 1;
            // 
            // IngredientNameTextBox
            // 
            this.IngredientNameTextBox.Location = new System.Drawing.Point(405, 76);
            this.IngredientNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.IngredientNameTextBox.Name = "IngredientNameTextBox";
            this.IngredientNameTextBox.Size = new System.Drawing.Size(351, 45);
            this.IngredientNameTextBox.TabIndex = 0;
            this.IngredientNameTextBox.TextChanged += new System.EventHandler(this.IngredientNameTextBox_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TheLostMorsel.Properties.Resources.fridge;
            this.pictureBox2.Location = new System.Drawing.Point(992, 217);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(683, 1006);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // SearchIngredientGP
            // 
            this.SearchIngredientGP.BackColor = System.Drawing.Color.Transparent;
            this.SearchIngredientGP.Controls.Add(this.SearchIngredientTextBox);
            this.SearchIngredientGP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchIngredientGP.Location = new System.Drawing.Point(165, 93);
            this.SearchIngredientGP.Name = "SearchIngredientGP";
            this.SearchIngredientGP.Size = new System.Drawing.Size(563, 126);
            this.SearchIngredientGP.TabIndex = 7;
            this.SearchIngredientGP.TabStop = false;
            this.SearchIngredientGP.Text = "Search Ingredient";
            // 
            // SearchIngredientTextBox
            // 
            this.SearchIngredientTextBox.Location = new System.Drawing.Point(29, 46);
            this.SearchIngredientTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.SearchIngredientTextBox.Name = "SearchIngredientTextBox";
            this.SearchIngredientTextBox.Size = new System.Drawing.Size(481, 45);
            this.SearchIngredientTextBox.TabIndex = 0;
            this.SearchIngredientTextBox.TextChanged += new System.EventHandler(this.SearchIngredientTextBox_TextChanged);
            // 
            // DeleteIngredientGP
            // 
            this.DeleteIngredientGP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteIngredientGP.BackColor = System.Drawing.Color.Transparent;
            this.DeleteIngredientGP.Controls.Add(this.label6);
            this.DeleteIngredientGP.Controls.Add(this.btnDelete);
            this.DeleteIngredientGP.Controls.Add(this.txtDelete);
            this.DeleteIngredientGP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteIngredientGP.Location = new System.Drawing.Point(1501, 1114);
            this.DeleteIngredientGP.Name = "DeleteIngredientGP";
            this.DeleteIngredientGP.Size = new System.Drawing.Size(392, 149);
            this.DeleteIngredientGP.TabIndex = 8;
            this.DeleteIngredientGP.TabStop = false;
            this.DeleteIngredientGP.Text = "Delete Ingredient";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 39);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 56);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 61);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(106, 64);
            this.txtDelete.Margin = new System.Windows.Forms.Padding(5);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(97, 45);
            this.txtDelete.TabIndex = 0;
            // 
            // RecipePage
            // 
            this.RecipePage.BackgroundImage = global::TheLostMorsel.Properties.Resources.cukin;
            this.RecipePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecipePage.Controls.Add(this.groupBox4);
            this.RecipePage.Controls.Add(this.label16);
            this.RecipePage.Controls.Add(this.label15);
            this.RecipePage.Controls.Add(this.label14);
            this.RecipePage.Controls.Add(this.label13);
            this.RecipePage.Controls.Add(this.label12);
            this.RecipePage.Controls.Add(this.label11);
            this.RecipePage.Controls.Add(this.label10);
            this.RecipePage.Controls.Add(this.label9);
            this.RecipePage.Controls.Add(this.label8);
            this.RecipePage.Controls.Add(this.label7);
            this.RecipePage.Controls.Add(this.pictureBox1);
            this.RecipePage.Controls.Add(this.checkedListBox1);
            this.RecipePage.Location = new System.Drawing.Point(4, 54);
            this.RecipePage.Name = "RecipePage";
            this.RecipePage.Padding = new System.Windows.Forms.Padding(3);
            this.RecipePage.Size = new System.Drawing.Size(2556, 1055);
            this.RecipePage.TabIndex = 3;
            this.RecipePage.Text = " Recipe";
            this.RecipePage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(59, 40);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(882, 146);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Recipe";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tiramisu",
            "Cinnamon Roll",
            "Raspberry Muffins",
            "Pasta Carbonara",
            "Guacamole",
            "Banana Bread",
            "Pancakes",
            "Apple Pie",
            "Pasta Bolognese",
            "Vegetable Soup",
            "Butter Cookies",
            "Croissants",
            "English Breakfast",
            "Drumsticks",
            "Dumplings",
            "Tacos",
            "Bread",
            "Donuts",
            "Pizza",
            "Fried Shrimp",
            "Omelette",
            "Burger",
            "Sushi",
            "Onigiri",
            "Lasagna",
            "Noodles"});
            this.comboBox1.Location = new System.Drawing.Point(70, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(540, 47);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(123, 734);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 39);
            this.label16.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(123, 677);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 39);
            this.label15.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(123, 613);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 39);
            this.label14.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(123, 558);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 39);
            this.label13.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(123, 506);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 39);
            this.label12.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(123, 454);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 39);
            this.label11.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 403);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 39);
            this.label10.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 354);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 39);
            this.label9.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 302);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 39);
            this.label8.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 39);
            this.label7.TabIndex = 7;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheLostMorsel.Properties.Resources.COOK;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::TheLostMorsel.Properties.Resources.COOK;
            this.pictureBox1.Location = new System.Drawing.Point(1881, 593);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(603, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1881, 40);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(601, 508);
            this.checkedListBox1.TabIndex = 6;
            // 
            // TheLostMorselForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(2564, 1113);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheLostMorselForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Lost Morsel";
            this.Tabs.ResumeLayout(false);
            this.WelcomePage.ResumeLayout(false);
            this.WelcomePage.PerformLayout();
            this.CookBookPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            this.FridgePage.ResumeLayout(false);
            this.UpdateIngredientGP.ResumeLayout(false);
            this.UpdateIngredientGP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFridge)).EndInit();
            this.AddIngredientGP.ResumeLayout(false);
            this.AddIngredientGP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SearchIngredientGP.ResumeLayout(false);
            this.SearchIngredientGP.PerformLayout();
            this.DeleteIngredientGP.ResumeLayout(false);
            this.DeleteIngredientGP.PerformLayout();
            this.RecipePage.ResumeLayout(false);
            this.RecipePage.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage CookBookPage;
        private System.Windows.Forms.TabPage FridgePage;
        private System.Windows.Forms.TabPage RecipePage;
        private System.Windows.Forms.TabPage WelcomePage;
        private System.Windows.Forms.GroupBox SearchIngredientGP;
        private System.Windows.Forms.GroupBox DeleteIngredientGP;
        private System.Windows.Forms.GroupBox UpdateIngredientGP;
        private System.Windows.Forms.GroupBox AddIngredientGP;
        private System.Windows.Forms.DataGridView dgvFridge;
        private System.Windows.Forms.TextBox SearchIngredientTextBox;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.TextBox IngredientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.DateTimePicker ExpriationDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpUpdateIngredient;
        private System.Windows.Forms.TextBox txtUpdateIngredient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdateIngredient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNoVegan;
        private System.Windows.Forms.RadioButton rdbVegan;
        private System.Windows.Forms.RadioButton rdbSweet;
        private System.Windows.Forms.RadioButton rdbSavory;
        private System.Windows.Forms.RadioButton rdbAllRecipesV;
        private System.Windows.Forms.RadioButton rdbAllRecipesS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnHelpFridge;
        private System.Windows.Forms.Button btnHelpCB;
        private System.Windows.Forms.Button btnHelpRcp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}

