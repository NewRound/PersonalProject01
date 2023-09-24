using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public static InventoryController instance;
    [SerializeField] public GameObject player;

    [SerializeField] public GameObject inventoryAmount;
    [SerializeField] public GameObject inventoryMaxAmount;
    [SerializeField] public GameObject inventory;


    private void Awake()
    {
        instance = this;
    }

    
}
