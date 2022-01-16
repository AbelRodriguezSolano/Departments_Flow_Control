using DataLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicBusinessLayer
{
    public class Reports
    {
        DocumentsControlEntities controlEntities = new DocumentsControlEntities();
        public List<Rep_Doc_DateRange_Result> ReportByDateRange(DateTime datesatart, DateTime dateend)
        {
            return controlEntities.Rep_Doc_DateRange(datesatart,dateend).ToList();
        }

        public List<Rep_Doc_DepDest_Result> ReportByDepDest(int? DepDest)
        {
            return controlEntities.Rep_Doc_DepDest(DepDest).ToList();
        }
        public List<Rep_Doc_DepOrig_Result> ReportByDepOrig(int? DepOrig)
        {
            return controlEntities.Rep_Doc_DepOrig(DepOrig).ToList();
        }
        public List<Rep_Doc_User_Result> ReportByUser(string user)
        {
            return controlEntities.Rep_Doc_User(user).ToList();
        }
    }
}
