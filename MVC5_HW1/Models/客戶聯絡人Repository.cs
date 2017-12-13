using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_HW1.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public 客戶聯絡人 Find(int? id)
        {
            return All().FirstOrDefault(a => a.Id == id);
        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}