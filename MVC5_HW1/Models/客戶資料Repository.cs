using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5_HW1.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public override IQueryable<客戶資料> All()
        {
            return Where(a => true !=  a.IsDelete.Value).OrderBy(a => a.Id);
        }

        public 客戶資料 Find(int? id)
        {
            return this.All().FirstOrDefault(a => a.Id == id);
        }

        //public override void Delete(客戶資料 entity)
        //{
        //    entity.IsDelete = true;
        //}

        public IQueryable<客戶資料> Keyword(string keyword, string type)
        {
            var query = All().OrderBy(m => m.客戶名稱);

            if (!string.IsNullOrEmpty(keyword))
            {
                return All().Where(m => m.客戶名稱.Contains(keyword) || m.客戶分類 == type);
            }

            return query;
        }
    }

    public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}