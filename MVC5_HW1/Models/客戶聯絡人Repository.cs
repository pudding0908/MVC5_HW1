using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_HW1.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public override IQueryable<客戶聯絡人> All()
        {
            return Where(a => true != a.IsDelete.Value).OrderBy(a => a.Id);
        }

        public 客戶聯絡人 Find(int? id)
        {
            return this.All().FirstOrDefault(a => a.Id == id);
        }

        public IQueryable<客戶聯絡人> Keyword(string keyword)
        {
            var query = All().OrderBy(m => m.姓名);

            if (!string.IsNullOrEmpty(keyword))
            {
                return All().Where(m => m.姓名.Contains(keyword) || m.職稱.Contains(keyword));
            }

            return query;
        }
}

        //public override void Delete(客戶聯絡人 entity)
        //{
        //    entity.IsDelete = true;
        //}
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}