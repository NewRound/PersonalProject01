using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : CharacterModel
{
    [SerializeField] public int level;
    [SerializeField] public int exp;


    private void Awake()
    {
        if(PlayerPrefs.HasKey("playerName"))
        {
            Name = PlayerPrefs.GetString("playerName");
            description = PlayerPrefs.GetString ("Description");
            level = PlayerPrefs.GetInt("level");
            exp = PlayerPrefs.GetInt("exp");
        }
    }
}
