using Recon_api_datamodel;
using Recon_api_model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recon_api_service
{
   public  class Dashboard_Service
    {

       public static DataSet DashboardList(Dashboard_model ObjModel)
        {
            DataSet dt = new DataSet();
            try
            {
                Dashboard_datamodel objproduct = new Dashboard_datamodel();
                dt = objproduct.DashboardList(ObjModel);
            }
            catch (Exception e)
            {

            }
            return dt;

        }
    }
}
