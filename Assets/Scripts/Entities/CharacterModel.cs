using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    [SerializeField] public string Name;
    [SerializeField] public string description;

    [SerializeField] public CharacterStats characterStats;

    private void Awake()
    {
        
    }

    private void Start()
    {
        characterStats = GetComponent<CharacterStatsHandler>().baseStats;
    }
}
