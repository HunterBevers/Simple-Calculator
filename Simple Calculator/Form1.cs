namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        // A counter to track the number of successful calculations performed.
        private int calculationCount = 0;

        // A default error message for invalid inputs.
        private string errorMessage = "Error: Please enter valid numeric values.";

        public Form1()
        {
            InitializeComponent();
        }

        // When the form loads, initialize the calculation count display.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Using label4 as the display for calculation count.
            Calculation_Count_Label.Text = "Calculations performed: 0";
        }

        // Event handler for clicking on label1 (currently unused).
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Event handler for clicking on label2 (currently unused).
        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Event handler for clicking on label3 (currently unused).
        private void label3_Click(object sender, EventArgs e)
        {
        }

        // Event handler for clicking on label4 (used to display calculation count).
        private void label4_Click(object sender, EventArgs e)
        {
        }

        // Addition button event handler.
        private void Enter_Button_Click(object sender, EventArgs e)
        {
            // Validate inputs from the first two textboxes.
            if (!ValidateInputs(out double number1, out double number2))
            {
                MessageBox.Show(errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform addition.
            double result = number1 + number2;

            // Display the result in the third textbox.
            Third_Result.Text = result.ToString();

            // Update the calculation count.
            UpdateCalculationCount();
        }

        // Subtraction button event handler.
        private void Subtract_Button_Click(object sender, EventArgs e)
        {
            // Validate inputs.
            if (!ValidateInputs(out double number1, out double number2))
            {
                MessageBox.Show(errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform subtraction.
            double result = number1 - number2;

            // Display the result.
            Third_Result.Text = result.ToString();

            // Update the calculation count.
            UpdateCalculationCount();
        }

        // Multiplication button event handler.
        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            // Validate inputs.
            if (!ValidateInputs(out double number1, out double number2))
            {
                MessageBox.Show(errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform multiplication.
            double result = number1 * number2;

            // Display the result.
            Third_Result.Text = result.ToString();

            // Update the calculation count.
            UpdateCalculationCount();
        }

        // Division button event handler.
        private void Divide_Button_Click(object sender, EventArgs e)
        {
            // Validate inputs.
            if (!ValidateInputs(out double number1, out double number2))
            {
                MessageBox.Show(errorMessage, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Prevent division by zero.
            if (number2 == 0)
            {
                MessageBox.Show("Error: Division by zero is not allowed.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform division.
            double result = number1 / number2;

            // Display the result.
            Third_Result.Text = result.ToString();

            // Update the calculation count.
            UpdateCalculationCount();
        }

        // Exit button event handler.
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            // Ask the user to confirm exit.
            DialogResult dr = MessageBox.Show("Are you sure you want to quit?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Event handler for text changes in the first textbox (currently unused).
        private void First_Result_TextChanged(object sender, EventArgs e)
        {
        }

        // AC (clear) button event handler.
        private void AC_Button_Click(object sender, EventArgs e)
        {
            // Clear the input and result textboxes.
            First_Result.Text = string.Empty;
            Second_Result.Text = string.Empty;
            Third_Result.Text = string.Empty;
        }

        // An extra button event handler (currently unused).
        private void button1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Validates the input in the First_Result and Second_Result textboxes.
        /// Returns true if both inputs can be parsed as doubles; otherwise, false.
        /// </summary>
        private bool ValidateInputs(out double number1, out double number2)
        {
            // Attempt to parse the text from the first textbox.
            bool validNumber1 = double.TryParse(First_Result.Text, out number1);
            // Attempt to parse the text from the second textbox.
            bool validNumber2 = double.TryParse(Second_Result.Text, out number2);

            // Return false if either parse fails.
            if (!validNumber1 || !validNumber2)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Increments the calculation count and updates the display on label4.
        /// </summary>
        private void UpdateCalculationCount()
        {
            calculationCount++; // Increment the counter.
            // Update label4 to show the updated count.
            Calculation_Count_Label.Text = "Calculations performed: " + calculationCount.ToString();
        }
    }
}
