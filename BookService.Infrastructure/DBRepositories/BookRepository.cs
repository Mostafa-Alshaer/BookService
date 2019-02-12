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
        public List<DBBook> Get()
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                return db.DBBooks.Include(x => x.Author).ToList();
            }
        }

        public DBBook Get(int id)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                return db.DBBooks.Include(x => x.Author).SingleOrDefault(a => a.Id == id);
            }
        }

        public DBBook Insert(DBBook dBBook)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                db.DBBooks.Add(dBBook);
                db.SaveChanges();
                db.Entry(dBBook).Reference(x => x.Author).Load();
                return dBBook;
            }
        }

        public void Update(DBBook dBBook)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                db.Entry(dBBook).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Remove(DBBook dBBook)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                db.DBBooks.Remove(dBBook);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                return db.DBBooks.Count(a => a.Id == id) > 0;
            }
        }
    }
}
