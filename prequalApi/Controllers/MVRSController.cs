using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using prequalApi.Models;
using System.Data;
//using System.Data.Common;
//using System.Data.SqlClient;

namespace prequalApi.Controllers
{
    
    public class MVRSController : ApiController
    {
        MvrsEntities DB = new MvrsEntities();
        //public IEnumerable<MVRS> GetAllMeterAccount() {
        //    MVRS[] dblist = (from it in DB.MVRS
        //                     orderby it.accountNumber
        //                     select it).Take(15)
        //                     .GroupBy(it=>it.accountNumber)
        //                     .ToArray() as MVRS[];
        //    return dblist;
        //}
        public IEnumerable<MVR> GetAllMeterAccount()
        {
               var dblist = (from it in DB.MVRS
                             orderby it.accountNumber
                             select it).Take(15)
                             .AsEnumerable();
            return dblist;//.GroupBy(it => it.accountNumber)
        }

        public IHttpActionResult GetMeterAccount(string acc)
        {
            var res = (from it in DB.MVRS
                       where it.accountNumber == acc
                       select it).ToArray();
            if (res == null)
                return NotFound();
            return Ok(res);
        }

    }
}
