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
        // ����һ���ֵ����ڴ洢�������ñ�
        Dictionary<string, List<Attributes2>> tableDictionary = new Dictionary<string, List<Attributes2>>();

        // ��ȡ�������ñ��·�������ת��Ϊ MessagePack ��ʽ

        // ��ȡ JSON �ļ�����
            string filePath = Application.dataPath + "/Json/CharDatajs.json";
            string jsonContent = File.ReadAllText(filePath);
            // �� JSON �ַ���ת��Ϊ�����б�
            List<Attributes2> Attributes2List = JsonMapper.ToObject<List<Attributes2>>(jsonContent);
            // ��ȡ������ȥ���ļ���չ����
            string tableName = Path.GetFileNameWithoutExtension(filePath);
            // �������Ͷ����б�����ֵ�
            tableDictionary.Add(tableName, Attributes2List);
       

        // ���л��ֵ�Ϊ MessagePack ��ʽ
        byte[] messagePackData = MessagePackSerializer.Serialize(tableDictionary);

        // ���� MessagePack ���ݵ��ļ�
        string messagePackFilePath = Application.dataPath + "/MessagePark/multipleTables";
        File.WriteAllBytes(messagePackFilePath, messagePackData);

        Debug.Log("JSON ת��Ϊ MessagePack ���");
    }
     
}
