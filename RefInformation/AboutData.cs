using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefInformation
{
    public class AboutData
    {
        public string TitleAbout;
        public string DataAboutApplication;
        public string DataAboutCalcArea;
        public string DataAboutCalcVolume;
        public string AboutCalcTitle;
        public string AboutCalc;

        public AboutData()
        {
            TitleAbout = "О приложении";
            DataAboutApplication = "Данная автоматизация рабочего места для сотрудников компании ООО &quot;Жожоба&quot; было написано выпускником Ангарского Политехнического Техникума.";
            AboutCalc = "Калькулятор сделан с целью сокращения времени вычислений на каждого работника" +
                "и экономии ресурсов рабочих станций";
            DataAboutCalcArea = "Калькулятор площади сделан с целью сокращения времени вычислений на каждого работника" +
                "и экономии ресурсов рабочих станций";
            DataAboutCalcVolume = "Калькулятор объема сделан  с целью сокращения времени вычислений на каждого работника" +
                "и экономии ресурсов рабочих станций";
            AboutCalcTitle = "О калькуляторе";

        }
    }
}
