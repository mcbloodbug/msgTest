using LitJson;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerByJson : MonoBehaviour
{
    public List<Attributes> playerAttributesList; // ������Զ����б�

    void Start()
    {
        LoadPlayerAttributes(); // ���������������
    }

    void LoadPlayerAttributes()
    {
        // ��JSON�����м�������ֵ
        string json = File.ReadAllText(Application.dataPath + "/Json/CharDatajs.json");
        playerAttributesList = JsonMapper.ToObject<List<Attributes>>(json);

        // �������ֵʾ��
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
