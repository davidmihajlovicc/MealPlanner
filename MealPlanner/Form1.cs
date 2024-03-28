namespace MealPlan
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Random generator = new Random();
                Meal meal;
                decimal maxPrice = decimal.Parse(textBox1.Text);
                Food.Quantity = decimal.Parse(textBox2.Text);


                if (maxPrice < 2 * Food.Quantity)
                {
                    throw new NumberTooSmallException("Your balance is too low! Please enter 2 dollars * Number of people.");
                }


                List<Food> meat = new List<Food>() {
                new Food("Pork", 1.12m, 240),
                new Food("Lamb", 1.63m, 300),
                new Food("Beef", 1.55m, 290),
                new Food("Fish", 1.3m, 200),
                new Food("Chicken", 1.0m, 239)
                };

                List<Food> cereals = new List<Food>() {
                new Food("Bread", 0.30m, 264),
                new Food("Pasta", 0.65m, 131),
                new Food("Rice", 0.88m, 130),
                new Food("Breakfast cereal", 1.05m, 350)
                };

                List<Food> vegetables = new List<Food>() {
                new Food("Tomato", 0.75m, 50),
                new Food("Potato", 1m, 77),
                new Food("Beans", 0.95m, 347),
                new Food("Peas", 0.4m, 81)
                };


                List<Food> milkProducts = new List<Food>() {
                new Food("Yoghurt", 0.78m, 264),
                new Food("Cheese", 0.8m, 131),
                new Food("Milk", 0.3m, 130)
                };


                while (true)
                {
                    meal = new Meal(meat[generator.Next(0, meat.Count)], cereals[generator.Next(0, cereals.Count)],
                    vegetables[generator.Next(0, vegetables.Count)], milkProducts[generator.Next(0, milkProducts.Count)]);
                    if (meal.CalculatePrice() <= maxPrice) { break; }

                }

                dataGridView1.Rows.Add(meal.Meat.ToString(), meal.Cereal.ToString(), meal.Vegetable.ToString(), meal.Dairy.ToString());

                maskedTextBox2.Text = meal.CalculateCalories().ToString();
                maskedTextBox1.Text = meal.CalculatePrice().ToString();

            }
            catch (NumberTooSmallException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
