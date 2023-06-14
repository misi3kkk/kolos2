using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class bmi
    {
        public double bmiwynik;
        public double masabmi;
        public double wzrostbmi;
       

        
        public double Masabmi
        {
            get { return masabmi; }
            set { masabmi = value; }
        }
        public double Wzrostbmi
        {
            get { return wzrostbmi; }
            set { wzrostbmi = value; }
        }
        public bmi()
        {
            masabmi = 0;
            wzrostbmi = 0;

        }
       
       

    }
}
