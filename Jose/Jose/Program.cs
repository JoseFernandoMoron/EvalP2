﻿using System;
namespace Jose
{
    //class Program
    //{
    // static void Main(string[] args)
    //{
    //    Console.WriteLine("Hello World!");
    //}
    //}
    //}



    public class Company
    {

        private string _name;
        private double _saveproject;
        //private Company()
        //{

        //}
        static void Main() { }
        public string Name { get { return _name; } }
        public double SaveProject { get { return _saveproject; } }

        public Company(string name, double saveproject)
        {
            _name = name;
            _saveproject = saveproject;
        }

        public void Spend(object cantidadRetirada)
        {
            throw new NotImplementedException();
        }

        public void Save(double save)
        {
            _saveproject += save;
        }

        public void Spend(double save)
        {
            _saveproject += save;
        }

        public void ChangeName(string name)
        {
            _name = name;
        }

    }
}
