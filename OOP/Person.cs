﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Entities
{
    public  class Person
    {
        //Fields
        private int _id;
        private string _name;
        private DateTime _dob;
        //Properties
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        public DateTime Dob
        {
            get => _dob;
            set => _dob = value;
        }

        public string Address { get; set; }
        //public abstract double GetSalary();
        public virtual string Display() => $"Id: {Id}, Name:{Name}, Dob:{Dob}";
        public override string? ToString() => $"Id: {Id}, Name: {Name}, Address:{Address}";
        public void Print() => Console.WriteLine("Print a Person");

    }
}
