using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5_HW1.Models.ViewModel
{
    public class NewCustomerData
    {
        public int Id { get; set; }

        public int 客戶Id { get; set; }

        [Required(ErrorMessage = "請輸入客戶名稱")]
        public string 客戶名稱 { get; set; }

        public string 聯絡人 { get; set; }

        public int 聯絡人數量
        {
            get { return 聯絡人.Count(); }
        }

        public string 銀行帳戶 { get; set; }

        public int 銀行帳戶數量
        {
            get { return 銀行帳戶.Count(); }
        }
    }
}