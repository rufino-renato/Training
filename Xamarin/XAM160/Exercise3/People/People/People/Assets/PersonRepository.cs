﻿using System;
using System.Collections.Generic;
using System.Linq;
using People.Models;
using SQLite;

namespace People
{
    public class PersonRepository
    {
        public string StatusMessage { get; set; }

        private readonly SQLiteConnection conn;

        public PersonRepository(string dbPath)
        {
            conn = new SQLiteConnection(dbPath);

            conn.CreateTable<Person>();
        }

        public void AddNewPerson(string name)
        {
            int result = 0;
            try
            {
                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                result = conn.Insert(new Person { Name = name });

                StatusMessage = string.Format("{0} record(s) added [Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public IEnumerable<Person> GetAllPeople()
        {
            try
            {
                return conn.Table<Person>();
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return Enumerable.Empty<Person>();
        }
    }
}