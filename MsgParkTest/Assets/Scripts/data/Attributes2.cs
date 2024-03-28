using MessagePack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MessagePackObject]
public class Attributes2
{
    [Key(0)]
    public int ID; // ���
    [Key(1)]
    public string Name; // ����
    [Key(2)]
    public int Layer; // �㼶
    [Key(3)]
    public float MaxHP; // Ѫ��
    [Key(4)]
    public float MaxMP; // ħ��
    [Key(5)]
    public float STR; // ����
    [Key(6)]
    public float DEX; // ����
    [Key(7)]
    public float INT; // ����
}

