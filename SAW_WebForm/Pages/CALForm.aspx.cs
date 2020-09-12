using OnlineCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAW_WebForm
{
    public partial class CALForm : System.Web.UI.Page
    {
        private int aText;
        private int bText;
        private Calc calc = new Calc();

        protected void Page_Load(object sender, EventArgs e)
        {
            DoInvisible();
        }
        protected void Sum_Btn_Click(object sender, EventArgs e)
        {

            aText = Convert.ToInt32(A.Text);
            bText = Convert.ToInt32(B.Text);

            result.Text = Convert.ToString(calc.Sum(aText, bText));

            DoVisible();
        }

        protected void Mul_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);
            bText = Convert.ToInt32(B.Text);

            result.Text = Convert.ToString(calc.Mul(aText, bText));

            DoVisible();
        }

        protected void Sub_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);
            bText = Convert.ToInt32(B.Text);

            result.Text = Convert.ToString(calc.Sub(aText, bText));

            DoVisible();
        }

        protected void Div_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);
            bText = Convert.ToInt32(B.Text);

            result.Text = Convert.ToString(calc.Div(aText, bText));

            DoVisible();
        }

        protected void Sqrt_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);

            result.Text = Convert.ToString(calc.Squere(aText));

            DoVisible();
        }

        protected void Pow2_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);

            result.Text = Convert.ToString(calc.Pow2(aText));

            DoVisible();
        }

        protected void Pow_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);
            bText = Convert.ToInt32(B.Text);

            result.Text = Convert.ToString(calc.Pow(aText,bText));

            DoVisible();
        }

        protected void Mod_Btn_Click(object sender, EventArgs e)
        {
            aText = Convert.ToInt32(A.Text);
            bText = Convert.ToInt32(B.Text);

            result.Text = Convert.ToString(calc.Mod(aText, bText));

            DoVisible();
        }

        protected void DoVisible()
        {
            result.Visible = true;
            Labelresult.Visible = true;
        }

        protected void DoInvisible()
        {
            result.Visible = false;
            Labelresult.Visible = false;
        }
    }
}