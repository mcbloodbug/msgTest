using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerByExc : MonoBehaviour
{ 
    public int ID; // ���
    public string Name; // ����
    public int Layer; // �㼶
    public float MaxHP; // Ѫ��
    public float MaxMP; // ħ��
    public float STR; // ����
    public float DEX; // ����
    public float INT; // ����
    void Start()
    {
        LoadPlayersFromExcel();
    }

    private void LoadPlayersFromExcel()
    {
        string filePath = Path.Combine(Application.dataPath, "Excel/CharData.xlsx");
        FileInfo fileInfo = new FileInfo(filePath);

        if (!fileInfo.Exists)
        {
            Debug.LogError("Excel�ļ������ڣ�" + filePath);
            return;
        } 
        using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[1];
            //worksheet.Dimension.End.Row��Excel�����������һ���ǿ��е��к�
            for (int i = 4; i <= worksheet.Dimension.End.Row; i++)
            { 
                ID = int.Parse(worksheet.Cells[i, 1].Value.ToString());
                Name = worksheet.Cells[i, 2].Value.ToString();
                Layer = int.Parse(worksheet.Cells[i, 3].Value.ToString());
                MaxHP = float.Parse(worksheet.Cells[i, 4].Value.ToString());
                MaxMP = float.Parse(worksheet.Cells[i, 5].Value.ToString());
                STR = float.Parse(worksheet.Cells[i, 6].Value.ToString());
                DEX = float.Parse(worksheet.Cells[i, 7].Value.ToString());
                INT = float.Parse(worksheet.Cells[i, 8].Value.ToString()); 
            }
        }
    } 
}