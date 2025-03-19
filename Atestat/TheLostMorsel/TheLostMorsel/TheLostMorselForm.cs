using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheLostMorsel.Properties;

namespace TheLostMorsel
{
    public partial class TheLostMorselForm : Form
    {
        string connStr = @"Server=DESKTOP-V1355IC\SQLEXPRESS;Database=TheLostMorsel;User ID=sa;Password=1234";
        bool isSweet = false;
        bool isVegan = false;
        bool AllRecipesVegan = true;
        bool AllRecipesSweet = true;


        public TheLostMorselForm()
        {
            InitializeComponent();
            SelectAllIngredients();
            SelectAllRecipes();
        }

        private void SelectAllIngredients()
        {
            using(SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                string query = "SELECT * FROM Fridge";

                using(SqlCommand cmd = new SqlCommand(query, con))
                {
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rdr);
                        dgvFridge.DataSource = dt;
                    }
                }
            }
        }

        private void SelectAllRecipes()
        {
            using(var con = new SqlConnection(connStr))
            {
                con.Open ();

                string query = "SELECT RecipeID, [Recipe Name], [Prep. Time]  FROM CookBook";

                using(var cmd = new SqlCommand(query,con))
                {
                    using( SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rdr);
                        dgvRecipes.DataSource = dt;
                    }
                }
            }
        }

        private void WelcomePage_Click(object sender, EventArgs e)
        {

        }

        private void IngredientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchIngredientTextBox_TextChanged(object sender, EventArgs e)
        {
            string ingr = SearchIngredientTextBox.Text;
            SelectIngredientsByName(ingr);

        }

        private void SelectIngredientsByName(string ingr)
        {
            using(var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT * FROM Fridge WHERE [Ingredient Name] LIKE @ingr + '%'";
                using(var cmd =  new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ingr", ingr);
                    using(var rd = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rd);
                        dgvFridge.DataSource= dt;
                    }

                }
            }
        }

        private void InsertIngredient(string ingr, DateTime exprDate)
        {
            using(SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "INSERT INTO Fridge VALUES (@ingr, @exprDate)";

                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@ingr", ingr);
                    cmd.Parameters.AddWithValue("@exprDate", exprDate);
                    int rows = cmd.ExecuteNonQuery();
                    
                }
            }
        }

        private void AddIngredientButton_Click(object sender, EventArgs e)
        {
            string ingr = IngredientNameTextBox.Text;
            DateTime exprDate = ExpriationDatePicker.Value;
            InsertIngredient(ingr, exprDate);
            SelectAllIngredients();
            IngredientNameTextBox.Text = " ";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            string ingr = txtUpdateIngredient.Text;
            int id = int.Parse(txtUpdateId.Text);
            DateTime exprDate = dtpUpdateIngredient.Value;
            UpdateIngredients(id, ingr, exprDate);
            SelectAllIngredients();
        }

        private void UpdateIngredients(int id, string ingr, DateTime exprDate)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "UPDATE Fridge Set [Ingredient Name] = @ingr, [Expiring Date] = @exprDate WHERE IngredientID = @id";
                using( SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ingr", ingr);
                    cmd.Parameters.AddWithValue("@exprDate", exprDate);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDelete.Text);
            DeleteIngredients(id);
            SelectAllIngredients();
            txtDelete.Text = " ";
        }

        private void DeleteIngredients(int id)
        {
            using(var con = new SqlConnection(connStr))
            {  
                con.Open();
                string query = "DELETE FROM Fridge WHERE IngredientID = @id";
                using(SqlCommand cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                }
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string rcp = textBox1.Text; 
            SelectRecipesByName(rcp);

        }

        private void SelectSweetOrVeganRecipes()
        {
            using(var con =new SqlConnection(connStr))
            {
                con.Open();
                string query;
                if (AllRecipesSweet)
                    if (AllRecipesVegan)
                        query = "SELECT RecipeID, [Recipe Name], [Prep. Time] FROM CookBook";
                    else
                        query = "SELECT RecipeID, [Recipe Name], [Prep. Time] FROM CookBook WHERE isVegan = @isVegan";
                else
                    if (AllRecipesVegan)
                        query = "SELECT RecipeID, [Recipe Name], [Prep. Time] FROM CookBook WHERE isSweet = @isSweet";
                    else
                        query = "SELECT RecipeID, [Recipe Name], [Prep. Time] FROM CookBook WHERE isVegan = @isVegan AND isSweet = @isSweet"; 
                using (var cmd = new SqlCommand(query,con))
                {       
                    if(!AllRecipesSweet)
                        cmd.Parameters.AddWithValue("@isSweet", isSweet);
                    if(!AllRecipesVegan)
                        cmd.Parameters.AddWithValue("@isVegan", isVegan);

                    using(var rdr = cmd.ExecuteReader())
                    {
                        
                        DataTable dt = new DataTable();
                        dt.Load(rdr);
                        dgvRecipes.DataSource = dt;

                    }
                }
            }
        }

        private void SelectRecipesByName(string rcp)
        {
            using(var con =new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT RecipeID, [Recipe Name], [Prep. Time] FROM CookBook WHERE [Recipe Name] LIKE @rcp + '%'";
                using(var cmd = new SqlCommand(query,con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);
                    using(var rdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(rdr);
                        dgvRecipes.DataSource = dt;
                    }
                }
            }
        }

        private void SelectRecipes1(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step1 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);
              
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if(rdr.Read())
                        {
                            label7.Text = rdr["Step1"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes2(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step2 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label8.Text = rdr["Step2"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes3(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step3 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label9.Text = rdr["Step3"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes4(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step4 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label10.Text = rdr["Step4"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes5(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step5 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label11.Text = rdr["Step5"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes6(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step6 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label12.Text = rdr["Step6"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes7(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step7 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label13.Text = rdr["Step7"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes8(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step8 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label14.Text = rdr["Step8"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes9(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step9 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label15.Text = rdr["Step9"].ToString();
                        }
                    }
                }
            }
        }

        private void SelectRecipes10(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT Step10 FROM RecipeSteps WHERE RecipeNameStep = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            label16.Text = rdr["Step10"].ToString();
                        }
                    }
                }
            }
        }



        private void SelectRecipesIngredients(string rcp)
        {
            using (var con = new SqlConnection(connStr))
            {
                con.Open();
                string query = "SELECT * FROM RecipeIngredients WHERE RecipeName = @rcp";
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@rcp", rcp);

                    using(SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        checkedListBox1.DataSource = dt;
                        checkedListBox1.DisplayMember = "IngredientName";
                    }
                }
            }
        }





        private void rdbSweet_CheckedChanged(object sender, EventArgs e)
        {
            isSweet = true;
            AllRecipesSweet = false;
            SelectSweetOrVeganRecipes();   
             
            
        }

        private void rdbSavory_CheckedChanged(object sender, EventArgs e)
        {
            isSweet = false;
            AllRecipesSweet = false;
            SelectSweetOrVeganRecipes();
            
        }

        private void rdbVegan_CheckedChanged(object sender, EventArgs e)
        {
            isVegan = true;
            AllRecipesVegan = false;
            SelectSweetOrVeganRecipes();
        }

        private void rdbNoVegan_CheckedChanged(object sender, EventArgs e)
        {
            isVegan = false;
            AllRecipesVegan = false;
            SelectSweetOrVeganRecipes();    
        }

        private void rdbAllRecipesS_CheckedChanged(object sender, EventArgs e)
        {
            AllRecipesSweet = true;
            SelectSweetOrVeganRecipes();
        }


        private void rdbAllRecipesV_CheckedChanged(object sender, EventArgs e)
        {
            AllRecipesVegan = true;
            SelectSweetOrVeganRecipes();
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string rcp = comboBox1.Text;
            SelectRecipesIngredients(rcp);
            SelectRecipes1(rcp);
            SelectRecipes2(rcp);
            SelectRecipes3(rcp); 
            SelectRecipes4(rcp);
            SelectRecipes5(rcp);
            SelectRecipes6(rcp);
            SelectRecipes7(rcp);
            SelectRecipes8(rcp);
            SelectRecipes9(rcp);
            SelectRecipes10(rcp);

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Select a recipe!");
                return;
            }

            if (FoodMap.ContainsKey(comboBox1.SelectedItem.ToString()))
            {   
                pictureBox1.Image = FoodMap[comboBox1.SelectedItem.ToString()];
                
            }


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
           

        }

        private Dictionary<string, Bitmap> FoodMap = new Dictionary<string, Bitmap>
        {
            {"Tiramisu", Resources.Tiramisu },
            {"Cinnamon Roll", Resources.CinnamonRolls },
            {"Raspberry Muffins", Resources.RaspberryMuffins },
            {"Pasta Carbonara", Resources.PastaCarbonara  },
            {"Guacamole", Resources.Guacamole },
            {"Banana Bread", Resources.BananaBread },
            {"Pancakes", Resources.Pancake },
            {"Apple Pie", Resources.ApplePie },
            {"Pasta Bolognese", Resources.PastaBolognese },
            {"Vegetable Soup", Resources.VeggieSoup },
            {"Butter Cookies", Resources.ButterCookies },
            {"Croissants", Resources.Croissants },
            {"English Breakfast", Resources.EnglishBreakfast },
            {"Drumsticks", Resources.Drumsticks },
            {"Dumplings", Resources.Dumplings },
            {"Tacos", Resources.Tacos},
            {"Bread", Resources.Bread },
            {"Donuts", Resources.Donuts },
            {"Pizza", Resources.Pizza },
            {"Fried Shrimp", Resources.FriedShrimp },
            {"Omelette", Resources.Omelette },
            {"Burger", Resources.Burgir },
            {"Sushi", Resources.Sushi },
            {"Onigiri", Resources.Onigiri },
            {"Lasagna", Resources.Lasagna },
            {"Noodles", Resources.nudels}

        };

        private void CookBookPage_Click(object sender, EventArgs e)
        {

        }

        private void btnHelpCB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello everynyan! In this tab you can view all the recipes and sort them by different criterias!");
        }

        private void btnHelpFridge_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can add all the ingredients you have in your kitchen along with their expiration dates. You can also update an exiting ingredient, add a new one or delete one!");
        }

        private void btnHelpRcp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In this section you can select a recipe and get cooking right away! (All the recipes available here are the same ones that we can find in the Cook Book tab)");
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
