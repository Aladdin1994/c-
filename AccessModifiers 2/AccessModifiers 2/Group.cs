using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers_2
{
    internal class Group
    {
         string No;
        public double AvgPoint;


        public string NO
        {
            get => No;
            set
            {
                if (GetGroupsNo(value))
                {
                    No = value;
                }
             
            }
        }

        public bool GetGroupsNo(string no)
        {
            if (!string.IsNullOrWhiteSpace(no) && no.Length == 4 && char.IsUpper(no[0]) && char.IsNumber(no[1]) && char.IsNumber(no[2]) && char.IsNumber(no[3]))
                return true;
            return false;
        }
        //public string NO
        //{
        //    get
        //    {
        //        return No;
        //    }
        //    set
        //    {
        //        if (value.Length==4 && char.IsUpper(value[0]) && char.IsNumber(value[1]) && char.IsNumber(value[2]) && char.IsNumber(value[3]))
        //        {
        //            No = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("yeniden daxil edin:");
        //        }
        //    }
        //}

        public double Averagepoint
        {
            get
            {
                return AvgPoint;

            }
            set
            {
                if(value>0 && value<100)
                {
                    AvgPoint = value;
                }
                else
                {
                    Console.WriteLine("yanlis daxil edilib:");
                }
            }
        }
    }
}
