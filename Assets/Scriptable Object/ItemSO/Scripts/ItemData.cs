using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable
}

public enum IncreaseType
{
    AttackDamage,
    Defense,
    Health,
    CriticalChance,
    HPRecovery,
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public bool equipable;
    public bool isEquiped;
    // public GameObject dropPrefab;

    [Header("ValueInfo")]
    public IncreaseType incrementType;
    public int value;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

}
