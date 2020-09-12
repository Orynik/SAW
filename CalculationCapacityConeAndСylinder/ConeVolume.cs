using CalculationCapacityConeAndСylinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationCapacityConeAndСylinder

{
    public class ConeVolume
    {
        private int R;
        private int h;

        private VolumeDependency Dependency = new VolumeDependency();

        public ConeVolume(int R,int h)
        {
            this.R = R;
            this.h = h;
        }   
        public int CalcCapacity()
        {
            return (int)(0.33 * (Dependency.Pi_R_Pow_2(R) * h));
        }


    }
}
