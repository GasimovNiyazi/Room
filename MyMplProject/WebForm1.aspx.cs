using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MyMplProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        DbHelper dbHelper = new DbHelper();


        protected void Page_Load(object sender, EventArgs e)
        {
      
            DataTable dataTable = new DataTable();
            dataTable = dbHelper.dbExecute("select name from Material");
            addFloorType(dataTable);
            dataTable = dbHelper.dbExecute("select color_name from Color");
            addColor(dataTable);
            dataTable = dbHelper.dbExecute("select name from Ustalar");
            addEmployee(dataTable);
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            ShareValues shareValues = new CalculateResult();
            Data data = new Data();
            data.Width = int.Parse(width.Value);
            data.Length = int.Parse(length.Value);
            data.FloorType = floorType.Value;
            data.Color = color.Value;
     
            data.ColorPrice = dbHelper.dbGetSingleValue("select price from Color where color_name = '"+color.Value+"'");
        
            data.FloorTypePrice = dbHelper.dbGetSingleValue("select price from Material where name = '" + floorType.Value + "'");
            
            data.EmployeeSalary = dbHelper.dbGetSingleValue("select salary from Ustalar where name = '" + employee.Value + "'");
            
            data.Employee = employee.Value;
            result.InnerText = shareValues.shareValue(data);
            colorPrice.InnerText = data.ColorPrice.ToString();
            floorPrice.InnerText = data.FloorTypePrice.ToString();
            salary.InnerText = data.EmployeeSalary.ToString();
        }

        private void addFloorType(DataTable dataTable) {
              List<String> floorTypes = new List<String>();
            foreach (DataRow row in dataTable.Rows) {
                floorTypes.Add(row["name"].ToString());
            }
            floorType.DataSource = floorTypes;
            floorType.DataBind();
        }

        private void addColor(DataTable dataTable) {
            List<String> colorList = new List<String>();
            foreach (DataRow row in dataTable.Rows)
            {
                colorList.Add(row["color_name"].ToString());
            }
            color.DataSource = colorList;
            color.DataBind();
        }
        private void addEmployee(DataTable dataTable)
        {
            List<String> employeeList = new List<String>();
            foreach (DataRow row in dataTable.Rows)
            {
                employeeList.Add(row["name"].ToString());
            }
            employee.DataSource = employeeList;
            employee.DataBind();
        }
    }
}