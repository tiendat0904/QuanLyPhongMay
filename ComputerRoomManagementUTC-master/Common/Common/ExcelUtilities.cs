
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common.Common
{
    public static class ExcelUtilities
    {
        public static byte[] CreateExcelFile<T>(string fileName, List<T> listData) where T :new()
        {
            ExcelPackage excelPackage = new ExcelPackage();
            var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
            workSheet.TabColor = System.Drawing.Color.Black;
            T genericObj = new T();
            List<PropertyInfo> propertyList = new List<PropertyInfo>();
            foreach (var property in genericObj.GetType().GetProperties())
            {
                propertyList.Add(property);
            }

            // Set header of excel table
            workSheet.Row(1).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;
            for(int i=1; i<= genericObj.GetType().GetProperties().Length; i++)
            {
                workSheet.Column(i).Width = 20;
                workSheet.Column(i).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                workSheet.Cells[1, i].Value = propertyList.ElementAt(i-1).Name;
            }

            int recordIndex = 2;
            foreach(var item in listData)
            {
                for (int i = 0; i < item.GetType().GetProperties().Length; i++)
                {
                    string propertiesName = propertyList.ElementAt<PropertyInfo>(i).Name.ToString();
                    workSheet.Cells[recordIndex, i + 1].Value = item.GetType().GetProperty(propertiesName).GetValue(item, null);
                }
                recordIndex++;
            }

            var result = excelPackage.GetAsByteArray();
            return result;
        }
    }
}
