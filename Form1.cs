namespace CS311_Project3_LTC
{
    public partial class formOrderForm : Form
    {
        // class members
        private double subTotal = 0;
        private double tax = .06;
        private string crustType = "";
        private string pizzaSize = "";

        // empty-argument constructor
        public formOrderForm()
        {
            InitializeComponent();
        }

        // Calculate button that calls the Summarize method.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        // Summarize method that calculates the subtotal, tax, and total, and displays the order summary.
        private void Summarize()
        {
            chooseCrustType();

            string orderStatement = $"You ordered a {pizzaSize} pizza with {crustType} crust and the following toppings:";

            richTextBoxOrderSummary.SelectedText = orderStatement + "\n";

            richTextBoxOrderSummary.SelectionBullet = true;
            chooseIngredient();
            richTextBoxOrderSummary.SelectionBullet = false;

            double subtotal = subTotal;
            double taxTotal = tax * subtotal;
            double total = subtotal + taxTotal;

            txtBoxSubTotal.Text = subtotal.ToString("c");
            txtBoxTax.Text = taxTotal.ToString("c");
            txtBoxTotal.Text = total.ToString("c");
        }


        // Event handler that allows user to select a pizza size.
        private void cboBoxSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            String data = cboBoxSizes.GetItemText(cboBoxSizes.SelectedItem);

            pizzaSize = data;

            switch (data)
            {
                case "Small":
                    subTotal += 2.00;
                    break;
                case "Medium":
                    subTotal += 5.00;
                    break;
                case "Large":
                    subTotal += 10.00;
                    break;
                case "X-Large":
                    subTotal += 15.00;
                    break;
                case "Ginormous":
                    subTotal += 20.00;
                    break;
                default:
                    break;
            }
        }

        // Event handler that allows user to select a crust type with radio buttons.
        private void chooseCrustType()
        {
            crustType = "";

            if (rdoBtnThin.Checked)
            {
                crustType = "Thin";
            }
            else if (rdoBtnRegular.Checked)
            {
                crustType = "Regular";
            }
            else if (rdoBtnThick.Checked)
            {
                crustType = "Thick";
            }
        }

        // chooseIngredient method that allows user to select ingredients with check boxes.
        private void chooseIngredient()
        {
            Dictionary<CheckBox, double> ingredientPrices = new Dictionary<CheckBox, double>
            {
                { chkBoxPepperoni, 2.00 },
                { chkBoxSausage, 2.00 },
                { chkBoxCanadianBacon, 2.00 },
                { chkBoxSpicyItalian, 2.00 },
                { chkBoxOnion, 1.00 },
                { chkBoxGreenPepper, 1.00 },
                { chkBoxBlackOlives, 1.00 },
                { chkBoxGreenOlives, 1.00 },
                { chkBoxBananaPeppers, 1.00 },
                { chkBoxJalepeno, 1.00 },
                { chkBoxExtraCheese, 1.00 },
                { chkBoxMushroom, 1.00 },
            };

            foreach (var pair in ingredientPrices)
            {
                if (pair.Key.Checked)
                {
                    richTextBoxOrderSummary.SelectedText = pair.Key.Text + "\n";
                    subTotal += pair.Value;
                }
            }
        }

        // btnClear_Click event handler that clears all fields.
        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("Clear all fields", "Clear Fields", buttons);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                pizzaSize = "";
                subTotal = 0;
                crustType = "";
                chkBoxPepperoni.Checked = false;
                chkBoxSausage.Checked = false;
                chkBoxCanadianBacon.Checked = false;
                chkBoxSpicyItalian.Checked = false;
                chkBoxOnion.Checked = false;
                chkBoxGreenPepper.Checked = false;
                chkBoxBlackOlives.Checked = false;
                chkBoxGreenOlives.Checked = false;
                chkBoxBananaPeppers.Checked = false;
                chkBoxJalepeno.Checked = false;
                chkBoxExtraCheese.Checked = false;
                chkBoxMushroom.Checked = false;
                rdoBtnThin.Checked = false;
                rdoBtnRegular.Checked = false;
                rdoBtnThick.Checked = false;
                cboBoxSizes.SelectedIndex = -1;

                richTextBoxOrderSummary.Clear();
                txtBoxSubTotal.Clear();
                txtBoxTax.Clear();
                txtBoxTotal.Clear();
            }
        }
    }
}