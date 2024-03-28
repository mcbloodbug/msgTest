using MessagePack;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[MessagePackObject]
public class Attributes2
{
    [Key(0)]
    public int ID; // 编号
    [Key(1)]
    public string Name; // 名字
    [Key(2)]
    public int Layer; // 层级
    [Key(3)]
    public float MaxHP; // 血量
    [Key(4)]
    public float MaxMP; // 魔法
    [Key(5)]
    public float STR; // 力量
    [Key(6)]
    public float DEX; // 敏捷
    [Key(7)]
    public float INT; // 智力
}

