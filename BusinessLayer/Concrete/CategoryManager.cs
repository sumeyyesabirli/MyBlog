﻿using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAllBl()
        {
            return repo.List();

        }

        public void CategoryAddBl(Category category)
        {
            if (category.CategoryName== ""|| category.CategoryName.Length== 0)
            {
                Console.WriteLine("Hata");
            }
            else
            {
                repo.Add(category);
            }
        }

    }
}
