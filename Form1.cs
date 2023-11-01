namespace CS311_Project3_LTC
{
    public partial class formOrderForm : Form
    {
        // class members
        private double subTotal = 0;
        private double tax = .06;
        private string crustType = "";
        private string pizzaSize = "";

        public formOrderForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            richTextBoxOrderSummary.Text = "Hello world";
            richTextBoxOrderSummary.SelectionBullet = true;
            chooseIngredient();
            richTextBoxOrderSummary.SelectionBullet = false;
        }

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

        private void chooseCrustType()
        {
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

        private double calculateTax()
        {
            double totalTax = subTotal * tax;
            return totalTax;
        }

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
    }
}