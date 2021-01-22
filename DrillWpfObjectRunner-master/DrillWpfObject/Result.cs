using System;
using System.Collections.Generic;
using System.Text;

namespace DrillWpfObject
{
    class Result
    {
        private int meter;
        private double tid;
        private string namn;



       public Result(int distans, double period, string kallelse)
        {

            meter = distans;
            tid = period;
            namn = kallelse;
        }

        public override String ToString()
        {

            return "distants" + meter + Environment.NewLine + "tid" + tid + Environment.NewLine + "namn" + namn;
        }



        // write code here
    }
}
