﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using arendev.net.Models.Entity;

namespace arendev.net.Repositories
{
    public class GenericRepository<T> where T: class, new()
    {
        PortfolioEntities2 db = new PortfolioEntities2();

        public List<T> list()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges(); 
        }

        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges(); 
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
            
  
    }
}