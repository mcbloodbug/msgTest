using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerByExc : MonoBehaviour
{ 
    public int ID; // 编号
    public string Name; // 名字
    public int Layer; // 层级
    public float MaxHP; // 血量
    public float MaxMP; // 魔法
    public float STR; // 力量
    public float DEX; // 敏捷
    public float INT; // 智力
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
            Debug.LogError("Excel文件不存在：" + filePath);
            return;
        } 
        using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets[1];
            //worksheet.Dimension.End.Row是Excel工作表中最后一个非空行的行号
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