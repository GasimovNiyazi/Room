using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMplProject
{
    public class Data
    {
        private int width;
        public int Width {
            get { return width; }
            set { width = value; }
        }
        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        private String floorType;
        public String FloorType
        {
            get { return floorType; }
            set { floorType = value; }
        }
        private float floorTypePrice;
        public float FloorTypePrice
        {
            get { return floorTypePrice; }
            set { floorTypePrice = value; }
        }
        private String color;
        public String Color
        {
            get { return color; }
            set { color = value; }
        }
        private float colorPrice;
        public float ColorPrice
        {
            get { return colorPrice; }
            set { colorPrice = value; }
        }
        private string employe;
        public string Employee
        {
            get { return employe; }
            set { employe = value; }
        }
        private float employeeSalary;
        public float EmployeeSalary
        {
            get { return employeeSalary; }
            set { employeeSalary = value; }
        }

    }
}