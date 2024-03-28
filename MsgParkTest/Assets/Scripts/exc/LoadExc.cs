using System.IO;
using UnityEngine;
using OfficeOpenXml; 

public class LoadExc : MonoBehaviour
{ 
    void Start()
    {
        string filePath = Path.Combine(Application.dataPath, "Excel/CharData.xlsx");  
        //��ȡExcel�ļ�����Ϣ
        FileInfo fileInfo = new FileInfo(filePath);

        //����ļ��Ƿ����
        if (!fileInfo.Exists)
        {
            Debug.LogError("Excel�ļ������ڣ�" + filePath);
            return;
        }

        //ͨ��Excel�����ļ���Ϣ����Excel���
        using (ExcelPackage excelPackage = new ExcelPackage(fileInfo)) 
        {
            //ȡ��Exce1�ļ��еĵ�һ�ű�
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[1];
            
            //ȡ�ñ�������
            Debug.Log(worksheet.Cells[1, 1].Value.ToString()); 
           
        }
    }
    
}
