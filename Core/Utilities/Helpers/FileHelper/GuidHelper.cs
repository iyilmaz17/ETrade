using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class GuidHelper
    {
        public static string CreateGuid()
        {
            return Guid.NewGuid().ToString();
            //return "ProductImage" + DateTime.Now.Date.ToString("dd-MM-yyyy") + "at" +
                   //(DateTime.Now.TimeOfDay.ToString());
        }
    }
}
