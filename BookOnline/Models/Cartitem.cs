using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookOnline.Models
{
    [Serializable]
    public class Cartitem
    {
       
        public Sach Sach { get; set; }
        public int SoLuong { get; set; }
       
    }
}