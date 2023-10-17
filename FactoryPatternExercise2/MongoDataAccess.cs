﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAcces
    {
        public List<Products> LoadData()
        {
            Console.WriteLine("I am reading data from Mongo Database.");
            var productList = new List<Products>();
            return productList;
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to the Mongo Database.");
        }

    }
}