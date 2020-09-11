using RefInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAW_WebForm
{
    public partial class SPRForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AboutData data = new AboutData();
            AboutTitle.Text = data.TitleAbout;
            AboutApp.Text = data.DataAboutApplication;

            AboutCalcTitle.Text = data.AboutCalcTitle;
            AboutCalcText.Text = data.AboutCalc;

            AboutCalcAreaTitle.Text = data.AboutCalcTitle + " площади.";
            AboutCalcAreaText.Text = data.DataAboutCalcArea;

            AboutCalcVolumeTitle.Text = data.AboutCalcTitle + " объема.";
            AboutCalcVolumeText.Text = data.DataAboutCalcVolume;
        }
    }
}