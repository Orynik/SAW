using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateonAreaOfConeAndCylinder
{
    class SideAreaDependency
    {
        public double l(int R,int h)
        {
            return Math.Sqrt(Math.Pow(R,2) + Math.Pow(h,2));
        }

        public double Pi_R_Pow_2(int R)
        {
            return Math.PI * Math.Pow(R,2);
        }
        public double Pi_R(int R)
        {
            return Math.PI * R;
        }
    }
}
