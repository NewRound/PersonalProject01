using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatsHandler : MonoBehaviour
{
    [SerializeField] public CharacterStats baseStats;
    public CharacterStats CurrentStats { get; private set; }
    public List<CharacterStats> statsModifier = new List<CharacterStats>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        AttackSO attackSO = null;
        if (baseStats.attackSO != null)
        {
            attackSO = Instantiate(baseStats.attackSO);
        }

        CurrentStats = new CharacterStats { attackSO = attackSO };
        // ToDo -> �߰� ���� ���
        CurrentStats.statsChangeType = baseStats.statsChangeType;
        CurrentStats.maxHealth = baseStats.maxHealth;
        CurrentStats.speed = baseStats.speed;

    }
}
