using LitJson;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerByJson : MonoBehaviour
{
    public List<Attributes> playerAttributesList; // 玩家属性对象列表

    void Start()
    {
        LoadPlayerAttributes(); // 加载玩家属性数据
    }

    void LoadPlayerAttributes()
    {
        // 从JSON数据中加载属性值
        string json = File.ReadAllText(Application.dataPath + "/Json/CharDatajs.json");
        playerAttributesList = JsonMapper.ToObject<List<Attributes>>(json);

        // 输出属性值示例
        foreach (Attributes attributes in playerAttributesList)
        {
            Debug.Log("ID: " + attributes.ID);
            Debug.Log("Name: " + attributes.Name);
            Debug.Log("Layer: " + attributes.Layer);
            Debug.Log("MaxHP: " + attributes.MaxHP);
            Debug.Log("MaxMP: " + attributes.MaxMP);
            Debug.Log("STR: " + attributes.STR);
            Debug.Log("DEX: " + attributes.DEX);
            Debug.Log("INT: " + attributes.INT);
        }
    }
}
