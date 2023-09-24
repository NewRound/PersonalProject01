using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : CharacterModel
{
    [SerializeField] public int level;
    [SerializeField] public int maxExp;
    [SerializeField] public int exp;

    [SerializeField] public int inventoryMaxAmount;
    [SerializeField] List<ItemData> inventory;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("playerName"))
        {
            Name = PlayerPrefs.GetString("playerName");
            explanation = PlayerPrefs.GetString ("explanation");
            level = PlayerPrefs.GetInt("level");
            exp = PlayerPrefs.GetInt("exp");
        }
        else
        {
            Name = "test";
            explanation = "test";
            level = 1;
            maxExp = 10;
            exp = 0;
        }
        
    }
}
