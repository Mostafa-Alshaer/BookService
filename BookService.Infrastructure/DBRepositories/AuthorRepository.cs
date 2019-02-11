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
        private DBBookServiceContext db = new DBBookServiceContext();
        public List<DBAuthor> Get()
        {
            try
            {
                return db.DBAuthors.ToList();
            }
            catch (Exception ex)
            {       
                throw ex;
            }
        }

        public DBAuthor Get(int id)
        {
            try
            {
                return db.DBAuthors.SingleOrDefault(a => a.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(DBAuthor dBAuthor)
        {
            try
            {
                db.DBAuthors.Add(dBAuthor);
                db.SaveChanges();
                return dBAuthor.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(string id, DBAuthor dBAuthor)
        {
            try
            {
                db.Entry(dBAuthor).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(DBAuthor dBAuthor)
        {
            try
            {
                db.DBAuthors.Remove(dBAuthor);
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
                return db.DBAuthors.Count(a => a.Id == id) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
