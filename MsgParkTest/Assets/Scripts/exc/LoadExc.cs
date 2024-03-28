using System.IO;
using UnityEngine;
using OfficeOpenXml; 

public class LoadExc : MonoBehaviour
{ 
    void Start()
    {
        string filePath = Path.Combine(Application.dataPath, "Excel/CharData.xlsx");  
        //获取Excel文件的信息
        FileInfo fileInfo = new FileInfo(filePath);

        //检查文件是否存在
        if (!fileInfo.Exists)
        {
            Debug.LogError("Excel文件不存在：" + filePath);
            return;
        }

        //通过Excel表格的文件信息，打开Excel表格
        using (ExcelPackage excelPackage = new ExcelPackage(fileInfo)) 
        {
            //取得Exce1文件中的第一张表
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[1];
            
            //取得表中数据
            Debug.Log(worksheet.Cells[1, 1].Value.ToString()); 
           
        }
    }
    
}
