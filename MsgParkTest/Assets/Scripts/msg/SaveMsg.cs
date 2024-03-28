using LitJson;
using MessagePack;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveMsg : MonoBehaviour
{
    void Start()
    {
        // 创建一个字典用于存储所有配置表
        Dictionary<string, List<Attributes2>> tableDictionary = new Dictionary<string, List<Attributes2>>();

        // 获取所有配置表的路径并逐个转换为 MessagePack 格式

        // 读取 JSON 文件内容
            string filePath = Application.dataPath + "/Json/CharDatajs.json";
            string jsonContent = File.ReadAllText(filePath);
            // 将 JSON 字符串转换为对象列表
            List<Attributes2> Attributes2List = JsonMapper.ToObject<List<Attributes2>>(jsonContent);
            // 获取表名（去除文件扩展名）
            string tableName = Path.GetFileNameWithoutExtension(filePath);
            // 将表名和对象列表存入字典
            tableDictionary.Add(tableName, Attributes2List);
       

        // 序列化字典为 MessagePack 格式
        byte[] messagePackData = MessagePackSerializer.Serialize(tableDictionary);

        // 保存 MessagePack 数据到文件
        string messagePackFilePath = Application.dataPath + "/MessagePark/multipleTables";
        File.WriteAllBytes(messagePackFilePath, messagePackData);

        Debug.Log("JSON 转换为 MessagePack 完成");
    }
     
}
