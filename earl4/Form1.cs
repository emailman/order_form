using System;
using System.Windows.Forms;

namespace earl4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Counter_ValueChanged(object sender, EventArgs e)
        {
            // Remove the $ from the unit price label
            double unitPrice1 = double.Parse(lblUnit1.Text.Remove(0, 1));
            double unitPrice2 = double.Parse(lblUnit2.Text.Remove(0, 1));
            double unitPrice3 = double.Parse(lblUnit3.Text.Remove(0, 1));

            // Calculate and show the extended price
            lblSub1.Text = ((double)ctr1.Value * unitPrice1).ToString("c");
            lblSub2.Text = ((double)ctr2.Value * unitPrice2).ToString("c");
            lblSub3.Text = ((double)ctr3.Value * unitPrice3).ToString("c");

            // Calculate and show the subtotal,
            // removing the $ from the field
            double subtotal =
                double.Parse(lblSub1.Text.Remove(0, 1)) +
                double.Parse(lblSub2.Text.Remove(0, 1)) +
                double.Parse(lblSub3.Text.Remove(0, 1));
            lblSub.Text = subtotal.ToString("c");

            // Calculate and show the tax
            double taxRate = .0625;
            double tax = taxRate * subtotal;
            lblTax.Text = tax.ToString("c");

            // Calculate and show the total
            double total = subtotal + tax;
            lblTotal.Text = total.ToString("c");
        }
    }
}
