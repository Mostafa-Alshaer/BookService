using BookService.Infrastructure.DBModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService.Infrastructure.DBRepositories
{
    class AuthorRepository
    {
        public List<DBAuthor> Get()
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                return db.DBAuthors.ToList();
            }               
        }

        public DBAuthor Get(int id)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                return db.DBAuthors.SingleOrDefault(a => a.Id == id);
            }
        }

        public int Insert(DBAuthor dBAuthor)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                db.DBAuthors.Add(dBAuthor);
                db.SaveChanges();
                return dBAuthor.Id;
            }
        }

        public void Update(DBAuthor dBAuthor)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                db.Entry(dBAuthor).State = EntityState.Modified;
                db.SaveChanges();
            }            
        }

        public void Remove(DBAuthor dBAuthor)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                db.DBAuthors.Remove(dBAuthor);
                db.SaveChanges();
            }
        }

        public bool Exists(int id)
        {
            using (DBBookServiceContext db = new DBBookServiceContext())
            {
                return db.DBAuthors.Count(a => a.Id == id) > 0;
            }            
        }
    }
}
