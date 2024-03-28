using LitJson;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LoadJson : MonoBehaviour
{  
    void Start()
    {
        InitData( );
    } 
    void InitData( )
    {
        JsonData dataConfig = JsonMapper.ToObject(File.ReadAllText(Application.dataPath + "/Json/CharDatajs.json"));

        for (int i = 0; i < dataConfig.Count; i++)
        {
            JsonData data = dataConfig[i]; 
            Debug.Log("ID: " + data["ID"]);
            Debug.Log("Layer: " + data["Layer"]);
            Debug.Log("MaxHP: " + data["MaxHP"]);
            Debug.Log("MaxMP: " + data["MaxMP"]);
            Debug.Log("STR: " + data["STR"]);
            Debug.Log("DEX: " + data["DEX"]);
            Debug.Log("INT: " + data["INT"]);
        } 
    }
}
