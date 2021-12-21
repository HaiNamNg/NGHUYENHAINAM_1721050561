using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LTQL_1721050561.Models
{
    public class LTQLDb :DbContext
    {
        public LTQLDb() : base("DbContext")
        {

        }
    }
    
}