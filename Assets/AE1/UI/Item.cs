using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName = "New Item";
    public enum Type { Ouja, Bell, Dynamite, CrystalBall }
    public Type type = Type.Ouja;
}
