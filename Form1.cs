using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Make_Your_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rblSmall.Checked)
            {
                lblSize.Text = "Small.";
                return;
            }

            if (rblMeduim.Checked)
            {
                lblSize.Text = "Meduim.";
                return;
            }

            if (rblLarg.Checked)
            {
                lblSize.Text = "Larg.";
                return;
            }


        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppingsType = "";

            if (chkExtraCheese.Checked)
            {
                sToppingsType += "Extra Cheese";
            }

            if (chkOnion.Checked)
            {
                sToppingsType += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppingsType += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppingsType += ", Olives";
            }


            if (chkTomatoes.Checked)
            {
                sToppingsType += ", Tomatoes";
            }

            if (chkGreenPreppers.Checked)
            {
                sToppingsType += ", Green Preppers";
            }

            if (sToppingsType.StartsWith(","))
            {
                sToppingsType = sToppingsType.Substring(1, sToppingsType.Length - 1).Trim(); ;
            }

            if(sToppingsType=="")
            {
                sToppingsType = "No Toppings";
            }

            lblToppings.Text = sToppingsType;
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (rblThin.Checked)
            {
                lblCrustType.Text = "Thin Crust.";
                return;
            }

            if (rblThink.Checked)
            {
                lblCrustType.Text = "Think Crust.";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            if (rblEatin.Checked)
            {
                lblWhereToEat.Text = "Eat in";
                return;
            }

            if (rblTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take out";
                return;
            }

        }

        float GetSelectedSizePrice()
        {
            if (rblSmall.Checked)
            {
                return Convert.ToSingle(rblSmall.Tag);
            }
            else if(rblMeduim.Checked)
            {
                return Convert.ToSingle(rblMeduim.Tag);
            }
            else
            {
                return Convert.ToSingle(rblLarg.Tag);
            }
        }

        float GetSelectedCrustPrice()
        {
            if(rblThin.Checked)
            {
                return Convert.ToSingle(rblThin.Tag);
            }
            else 
            {
                return Convert.ToSingle(rblThink.Tag);
            }
        }

        float GetSelectedToppingsPrice()
        {
            float TotalPrice = 0;

            if(chkExtraCheese.Checked)
            {
                TotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkOnion.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPreppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chkGreenPreppers.Tag);
            }

            return TotalPrice;
            
        }

        float CalculatePrice()
        {
            return GetSelectedSizePrice() + GetSelectedToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculatePrice().ToString();
        }

        void OrderSummary()
        {
            UpdateSize();
            UpdateCrustType();
            UpdateToppings();
            UpdateWhereToEat();
        }
       

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThink_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }


        private void chExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chGreenPreppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        void ResetForm()
        {
            //Groups
            btnOrder.Enabled = true;
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            //Size
            rblMeduim.Checked = true;

            //Crust
            rblThin.Checked = true;

            //Toppings
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPreppers.Checked = false;

            //Where Eat
            rblEatin.Checked= true;
        }


        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnOrder.Enabled = false;
                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;


            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrderSummary();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
