using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_HW1.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public override IQueryable<客戶銀行資訊> All()
        {
            return Where(a => true != a.IsDelete.Value).OrderBy(a => a.Id);
        }

        public 客戶銀行資訊 Find(int? id)
         {
             return All().FirstOrDefault(a => a.Id == id);
         }
}

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}