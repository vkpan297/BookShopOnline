using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookOnline.Areas.Admin.Common
{
    [Serializable]
    public class UserLogin
    {
        public long ID { get; set; }
        public string username { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }


        public long? sta { get; set; }

    }
}