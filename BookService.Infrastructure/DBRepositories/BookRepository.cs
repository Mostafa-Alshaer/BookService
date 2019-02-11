using BookService.Infrastructure.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Infrastructure.DBRepositories
{
    class BookRepository
    {
        private DBBookServiceContext db = new DBBookServiceContext();
        public List<DBBook> Get()
        {
            try
            {
                return db.DBBooks.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DBBook Get(int id)
        {
            try
            {
                return db.DBBooks.SingleOrDefault(a => a.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(DBBook dBBook)
        {
            try
            {
                db.DBBooks.Add(dBBook);
                db.SaveChanges();
                return dBBook.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(string id, DBBook dBBook)
        {
            try
            {
                db.Entry(dBBook).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(DBBook dBBook)
        {
            try
            {
                db.DBBooks.Remove(dBBook);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exists(int id)
        {
            try
            {
                return db.DBBooks.Count(a => a.Id == id) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
