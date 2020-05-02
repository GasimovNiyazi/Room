using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMplProject
{
    public class CalculateResult : ShareValues
    {
        public string shareValue(Data data)
        {
            int area = data.Width * data.Length;
            float total = data.EmployeeSalary + area*data.ColorPrice + area*data.FloorTypePrice;
            return "AREA: " + area + " " + "Total: " + total;
        }
    }
}