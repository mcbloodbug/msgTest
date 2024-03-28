using MessagePack;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadMsg : MonoBehaviour
{
    void Start()
    {
        string messagePackFilePath = Application.dataPath + "/MessagePark/multipleTables";
        byte[] messagePackData = File.ReadAllBytes(messagePackFilePath);

        // 从 MessagePack 文件中反序列化字典
        Dictionary<string, List<Attributes2>> tableDictionary = MessagePackSerializer.Deserialize<Dictionary<string, List<Attributes2>>>(messagePackData);

        // 示例：根据键名读取特定配置表
        string tableName = "CharDatajs";
        if (tableDictionary.ContainsKey(tableName))
        {
            List<Attributes2> Attributes2List = tableDictionary[tableName];
            foreach (Attributes2 data in Attributes2List)
            {
                Debug.Log("ID: " + data.ID);
                Debug.Log("Layer: " + data.Layer);
                Debug.Log("MaxHP: " + data.MaxHP);
                Debug.Log("MaxMP: " + data.MaxMP);
                Debug.Log("STR: " + data.STR);
                Debug.Log("DEX: " + data.DEX);
                Debug.Log("INT: " + data.INT);
            }
        }

        Debug.Log("从 MessagePack 加载配置表完成");
    }
}
