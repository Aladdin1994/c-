using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace AccessModifiers_2
{
    internal class Course
    {


        public Group[] groups = new Group[0];
        public void AddGroups(Group group)
        {
            Array.Resize(ref groups, groups.Length + 1);
            groups[groups.Length - 1] = group;
        }

        //public string No
        //{
        //    get => No;
        //    set
        //    {
        //        if (GetGroupsNo(value))
        //            No = value;
        //    }
        //}

        //public bool GetGroupsNo(string no)
        //{
        //    if (!string.IsNullOrWhiteSpace(no) && no.Length == 4 && char.IsUpper(no[0]) && char.IsNumber(no[1]) && char.IsNumber(no[2]) && char.IsNumber(no[3]))
        //        return true;
        //    return false;
        //}
        //public Group[]  GetGroupsByPointRange(double minPoint, double maxPoint)
        //{
        //    Group[] wantedgroups = new Group[0];
        //    for(int i=0; i<groups.Length; i++)
        //    {
        //        if (groups[i].AvgPoint >= minPoint && groups[i].AvgPoint <= maxPoint)
        //        {
        //            Array.Resize(ref wantedgroups, wantedgroups.Length + 1);
        //            wantedgroups[wantedgroups.Length - 1] = groups[i];
        //        }
        //    }
        //    return wantedgroups;
        //}
        
    }

    
}
