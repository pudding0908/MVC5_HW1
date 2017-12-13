using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_HW1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public 客戶資料 Find(int? id)
        {
            return All().FirstOrDefault(a => a.Id == id);
        }

    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}