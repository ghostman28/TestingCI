using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingCI.Models
{
    public class clsSendListPromoById
    {
        public string tag { get; set; }
        public string success { get; set; }
        public string error { get; set; }
        public ArrayList data { get; set; }
    }


    public class clsDataPromoById
    {
        public string nama_promo { get; set; }
        public string gambar_promo { get; set; }
        public string deskripsi_panjang { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }
}