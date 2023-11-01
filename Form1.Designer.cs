namespace CS311_Project3_LTC
{
    partial class formOrderForm
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrderForm));
            picBoxLogo = new PictureBox();
            lblName = new Label();
            grpBoxOrderOptions = new GroupBox();
            chkBoxMushroom = new CheckBox();
            chkBoxExtraCheese = new CheckBox();
            chkBoxJalepeno = new CheckBox();
            chkBoxBananaPeppers = new CheckBox();
            chkBoxGreenOlives = new CheckBox();
            chkBoxBlackOlives = new CheckBox();
            chkBoxGreenPepper = new CheckBox();
            chkBoxOnion = new CheckBox();
            chkBoxSpicyItalian = new CheckBox();
            chkBoxCanadianBacon = new CheckBox();
            chkBoxSausage = new CheckBox();
            chkBoxPepperoni = new CheckBox();
            lblToppings = new Label();
            grpBoxCrustType = new GroupBox();
            rdoBtnThick = new RadioButton();
            rdoBtnRegular = new RadioButton();
            rdoBtnThin = new RadioButton();
            lblSizeOptions = new Label();
            cboBoxSizes = new ComboBox();
            lblOrderSummary = new Label();
            richTextBoxOrderSummary = new RichTextBox();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtBoxSubTotal = new TextBox();
            txtBoxTax = new TextBox();
            txtBoxTotal = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            grpBoxOrderOptions.SuspendLayout();
            grpBoxCrustType.SuspendLayout();
            SuspendLayout();
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = (Image)resources.GetObject("picBoxLogo.Image");
            picBoxLogo.Location = new Point(26, 12);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new Size(117, 116);
            picBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLogo.TabIndex = 0;
            picBoxLogo.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(226, 44);
            lblName.Name = "lblName";
            lblName.Size = new Size(320, 48);
            lblName.TabIndex = 1;
            lblName.Text = "Larry's Pizza Joint";
            // 
            // grpBoxOrderOptions
            // 
            grpBoxOrderOptions.Controls.Add(chkBoxMushroom);
            grpBoxOrderOptions.Controls.Add(chkBoxExtraCheese);
            grpBoxOrderOptions.Controls.Add(chkBoxJalepeno);
            grpBoxOrderOptions.Controls.Add(chkBoxBananaPeppers);
            grpBoxOrderOptions.Controls.Add(chkBoxGreenOlives);
            grpBoxOrderOptions.Controls.Add(chkBoxBlackOlives);
            grpBoxOrderOptions.Controls.Add(chkBoxGreenPepper);
            grpBoxOrderOptions.Controls.Add(chkBoxOnion);
            grpBoxOrderOptions.Controls.Add(chkBoxSpicyItalian);
            grpBoxOrderOptions.Controls.Add(chkBoxCanadianBacon);
            grpBoxOrderOptions.Controls.Add(chkBoxSausage);
            grpBoxOrderOptions.Controls.Add(chkBoxPepperoni);
            grpBoxOrderOptions.Controls.Add(lblToppings);
            grpBoxOrderOptions.Controls.Add(grpBoxCrustType);
            grpBoxOrderOptions.Controls.Add(lblSizeOptions);
            grpBoxOrderOptions.Controls.Add(cboBoxSizes);
            grpBoxOrderOptions.Location = new Point(26, 158);
            grpBoxOrderOptions.Name = "grpBoxOrderOptions";
            grpBoxOrderOptions.Size = new Size(884, 301);
            grpBoxOrderOptions.TabIndex = 2;
            grpBoxOrderOptions.TabStop = false;
            grpBoxOrderOptions.Text = "Order Options";
            // 
            // chkBoxMushroom
            // 
            chkBoxMushroom.AutoSize = true;
            chkBoxMushroom.Location = new Point(659, 253);
            chkBoxMushroom.Name = "chkBoxMushroom";
            chkBoxMushroom.Size = new Size(126, 29);
            chkBoxMushroom.TabIndex = 15;
            chkBoxMushroom.Text = "Mushroom";
            chkBoxMushroom.UseVisualStyleBackColor = true;
            // 
            // chkBoxExtraCheese
            // 
            chkBoxExtraCheese.AutoSize = true;
            chkBoxExtraCheese.Location = new Point(659, 214);
            chkBoxExtraCheese.Name = "chkBoxExtraCheese";
            chkBoxExtraCheese.Size = new Size(137, 29);
            chkBoxExtraCheese.TabIndex = 14;
            chkBoxExtraCheese.Text = "Extra Cheese";
            chkBoxExtraCheese.UseVisualStyleBackColor = true;
            // 
            // chkBoxJalepeno
            // 
            chkBoxJalepeno.AutoSize = true;
            chkBoxJalepeno.Location = new Point(659, 177);
            chkBoxJalepeno.Name = "chkBoxJalepeno";
            chkBoxJalepeno.Size = new Size(107, 29);
            chkBoxJalepeno.TabIndex = 13;
            chkBoxJalepeno.Text = "Jalepeno";
            chkBoxJalepeno.UseVisualStyleBackColor = true;
            // 
            // chkBoxBananaPeppers
            // 
            chkBoxBananaPeppers.AutoSize = true;
            chkBoxBananaPeppers.Location = new Point(659, 138);
            chkBoxBananaPeppers.Name = "chkBoxBananaPeppers";
            chkBoxBananaPeppers.Size = new Size(163, 29);
            chkBoxBananaPeppers.TabIndex = 12;
            chkBoxBananaPeppers.Text = "Banana Peppers";
            chkBoxBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // chkBoxGreenOlives
            // 
            chkBoxGreenOlives.AutoSize = true;
            chkBoxGreenOlives.Location = new Point(410, 253);
            chkBoxGreenOlives.Name = "chkBoxGreenOlives";
            chkBoxGreenOlives.Size = new Size(137, 29);
            chkBoxGreenOlives.TabIndex = 11;
            chkBoxGreenOlives.Text = "Green Olives";
            chkBoxGreenOlives.UseVisualStyleBackColor = true;
            // 
            // chkBoxBlackOlives
            // 
            chkBoxBlackOlives.AutoSize = true;
            chkBoxBlackOlives.Location = new Point(410, 214);
            chkBoxBlackOlives.Name = "chkBoxBlackOlives";
            chkBoxBlackOlives.Size = new Size(131, 29);
            chkBoxBlackOlives.TabIndex = 10;
            chkBoxBlackOlives.Text = "Black Olives";
            chkBoxBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkBoxGreenPepper
            // 
            chkBoxGreenPepper.AutoSize = true;
            chkBoxGreenPepper.Location = new Point(410, 177);
            chkBoxGreenPepper.Name = "chkBoxGreenPepper";
            chkBoxGreenPepper.Size = new Size(144, 29);
            chkBoxGreenPepper.TabIndex = 9;
            chkBoxGreenPepper.Text = "Green Pepper";
            chkBoxGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkBoxOnion
            // 
            chkBoxOnion.AutoSize = true;
            chkBoxOnion.Location = new Point(410, 138);
            chkBoxOnion.Name = "chkBoxOnion";
            chkBoxOnion.Size = new Size(87, 29);
            chkBoxOnion.TabIndex = 8;
            chkBoxOnion.Text = "Onion";
            chkBoxOnion.UseVisualStyleBackColor = true;
            // 
            // chkBoxSpicyItalian
            // 
            chkBoxSpicyItalian.AutoSize = true;
            chkBoxSpicyItalian.Location = new Point(186, 253);
            chkBoxSpicyItalian.Name = "chkBoxSpicyItalian";
            chkBoxSpicyItalian.Size = new Size(203, 29);
            chkBoxSpicyItalian.TabIndex = 7;
            chkBoxSpicyItalian.Text = "Spicy Italian Sausage";
            chkBoxSpicyItalian.UseVisualStyleBackColor = true;
            // 
            // chkBoxCanadianBacon
            // 
            chkBoxCanadianBacon.AutoSize = true;
            chkBoxCanadianBacon.Location = new Point(186, 214);
            chkBoxCanadianBacon.Name = "chkBoxCanadianBacon";
            chkBoxCanadianBacon.Size = new Size(164, 29);
            chkBoxCanadianBacon.TabIndex = 6;
            chkBoxCanadianBacon.Text = "Canadian Bacon";
            chkBoxCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // chkBoxSausage
            // 
            chkBoxSausage.AutoSize = true;
            chkBoxSausage.Location = new Point(186, 177);
            chkBoxSausage.Name = "chkBoxSausage";
            chkBoxSausage.Size = new Size(104, 29);
            chkBoxSausage.TabIndex = 5;
            chkBoxSausage.Text = "Sausage";
            chkBoxSausage.UseVisualStyleBackColor = true;
            // 
            // chkBoxPepperoni
            // 
            chkBoxPepperoni.AutoSize = true;
            chkBoxPepperoni.Location = new Point(186, 138);
            chkBoxPepperoni.Name = "chkBoxPepperoni";
            chkBoxPepperoni.Size = new Size(118, 29);
            chkBoxPepperoni.TabIndex = 4;
            chkBoxPepperoni.Text = "Pepperoni";
            chkBoxPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Location = new Point(67, 110);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(89, 25);
            lblToppings.TabIndex = 3;
            lblToppings.Text = "Toppings:";
            // 
            // grpBoxCrustType
            // 
            grpBoxCrustType.Controls.Add(rdoBtnThick);
            grpBoxCrustType.Controls.Add(rdoBtnRegular);
            grpBoxCrustType.Controls.Add(rdoBtnThin);
            grpBoxCrustType.Location = new Point(333, 31);
            grpBoxCrustType.Name = "grpBoxCrustType";
            grpBoxCrustType.Size = new Size(526, 38);
            grpBoxCrustType.TabIndex = 2;
            grpBoxCrustType.TabStop = false;
            grpBoxCrustType.Text = "Crust Type:";
            // 
            // rdoBtnThick
            // 
            rdoBtnThick.AutoSize = true;
            rdoBtnThick.Location = new Point(341, 0);
            rdoBtnThick.Name = "rdoBtnThick";
            rdoBtnThick.Size = new Size(77, 29);
            rdoBtnThick.TabIndex = 2;
            rdoBtnThick.TabStop = true;
            rdoBtnThick.Text = "Thick";
            rdoBtnThick.UseVisualStyleBackColor = true;
            // 
            // rdoBtnRegular
            // 
            rdoBtnRegular.AutoSize = true;
            rdoBtnRegular.Location = new Point(218, 0);
            rdoBtnRegular.Name = "rdoBtnRegular";
            rdoBtnRegular.Size = new Size(96, 29);
            rdoBtnRegular.TabIndex = 1;
            rdoBtnRegular.TabStop = true;
            rdoBtnRegular.Text = "Regular";
            rdoBtnRegular.UseVisualStyleBackColor = true;
            // 
            // rdoBtnThin
            // 
            rdoBtnThin.AutoSize = true;
            rdoBtnThin.Location = new Point(128, 0);
            rdoBtnThin.Name = "rdoBtnThin";
            rdoBtnThin.Size = new Size(70, 29);
            rdoBtnThin.TabIndex = 0;
            rdoBtnThin.TabStop = true;
            rdoBtnThin.Text = "Thin";
            rdoBtnThin.UseVisualStyleBackColor = true;
            // 
            // lblSizeOptions
            // 
            lblSizeOptions.AutoSize = true;
            lblSizeOptions.Location = new Point(6, 39);
            lblSizeOptions.Name = "lblSizeOptions";
            lblSizeOptions.Size = new Size(55, 25);
            lblSizeOptions.TabIndex = 1;
            lblSizeOptions.Text = "Sizes:";
            // 
            // cboBoxSizes
            // 
            cboBoxSizes.FormattingEnabled = true;
            cboBoxSizes.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboBoxSizes.Location = new Point(67, 36);
            cboBoxSizes.Name = "cboBoxSizes";
            cboBoxSizes.Size = new Size(212, 33);
            cboBoxSizes.TabIndex = 0;
            cboBoxSizes.SelectedIndexChanged += cboBoxSizes_SelectedIndexChanged;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.Location = new Point(26, 490);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(143, 25);
            lblOrderSummary.TabIndex = 3;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // richTextBoxOrderSummary
            // 
            richTextBoxOrderSummary.Location = new Point(167, 490);
            richTextBoxOrderSummary.Name = "richTextBoxOrderSummary";
            richTextBoxOrderSummary.Size = new Size(425, 194);
            richTextBoxOrderSummary.TabIndex = 4;
            richTextBoxOrderSummary.Text = "";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(598, 493);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(84, 25);
            lblSubTotal.TabIndex = 5;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(642, 548);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(40, 25);
            lblTax.TabIndex = 6;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(629, 602);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(53, 25);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total:";
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.Location = new Point(685, 493);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(200, 31);
            txtBoxSubTotal.TabIndex = 8;
            // 
            // txtBoxTax
            // 
            txtBoxTax.Location = new Point(685, 548);
            txtBoxTax.Name = "txtBoxTax";
            txtBoxTax.Size = new Size(200, 31);
            txtBoxTax.TabIndex = 9;
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Location = new Point(685, 602);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(197, 31);
            txtBoxTotal.TabIndex = 10;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(598, 654);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(287, 118);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // formOrderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 815);
            Controls.Add(btnCalculate);
            Controls.Add(txtBoxTotal);
            Controls.Add(txtBoxTax);
            Controls.Add(txtBoxSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(richTextBoxOrderSummary);
            Controls.Add(lblOrderSummary);
            Controls.Add(grpBoxOrderOptions);
            Controls.Add(lblName);
            Controls.Add(picBoxLogo);
            Name = "formOrderForm";
            Text = "Larry's Pizza Joint";
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            grpBoxOrderOptions.ResumeLayout(false);
            grpBoxOrderOptions.PerformLayout();
            grpBoxCrustType.ResumeLayout(false);
            grpBoxCrustType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBoxLogo;
        private Label lblName;
        private GroupBox grpBoxOrderOptions;
        private Label lblSizeOptions;
        private ComboBox cboBoxSizes;
        private GroupBox grpBoxCrustType;
        private Label lblToppings;
        private RadioButton rdoBtnThick;
        private RadioButton rdoBtnRegular;
        private RadioButton rdoBtnThin;
        private CheckBox chkBoxMushroom;
        private CheckBox chkBoxExtraCheese;
        private CheckBox chkBoxJalepeno;
        private CheckBox chkBoxBananaPeppers;
        private CheckBox chkBoxGreenOlives;
        private CheckBox chkBoxBlackOlives;
        private CheckBox chkBoxGreenPepper;
        private CheckBox chkBoxOnion;
        private CheckBox chkBoxSpicyItalian;
        private CheckBox chkBoxCanadianBacon;
        private CheckBox chkBoxSausage;
        private CheckBox chkBoxPepperoni;
        private Label lblOrderSummary;
        private RichTextBox richTextBoxOrderSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtBoxSubTotal;
        private TextBox txtBoxTax;
        private TextBox txtBoxTotal;
        private Button btnCalculate;
    }
}