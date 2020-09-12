﻿using CalculationCapacityConeAndСylinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAW_WebForm.Pages
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Result_Сone_Btn_Click(object sender, EventArgs e)
        {
            ConeVolume cone = new ConeVolume(Convert.ToInt32(R.Text), Convert.ToInt32(h.Text));
            result.Text = Convert.ToString(cone.CalcCapacity());
        }

        protected void Result_Cyl_Btn_Click(object sender, EventArgs e)
        {
            CylinderVolume cyl = new CylinderVolume(Convert.ToInt32(R.Text), Convert.ToInt32(h.Text));
            result.Text = Convert.ToString(cyl.CalcCapacity());
        }
    }
}