using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController instance;
    [SerializeField] public GameObject player;

    [SerializeField] public GameObject inventoryAmount;
    [SerializeField] public GameObject inventoryMaxAmount;
    [SerializeField] public ScrollRect scrollRect; // 스크롤 뷰
    [SerializeField] public RectTransform content; // Content 요소

    private PlayerModel playerModel;

    // 추가할 내용을 저장할 프리팹 또는 UI 요소
    [SerializeField] public GameObject itemPrefab;


    private void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        playerModel = player.GetComponent<PlayerModel>();
        List<ItemData> itemList = playerModel.inventory;

        for(int i = 0; i < itemList.Count; i++)
        {
            AddItem(itemList[i]);
        }

    }

    public void AddItem(ItemData item)
    {
        GameObject newItem = Instantiate(itemPrefab);

        // Content의 자식으로 설정
        newItem.transform.SetParent(content, false);

        // 아이템 초기화 및 위치 설정
        Image itemImage = newItem.transform.Find("ItemImage").GetComponent<Image>();
        GameObject equiped = newItem.transform.Find("Equiped").gameObject;
        if(item.isEquiped)
        {
            equiped.SetActive(true);
        }
        else
        {
            equiped.SetActive(false);
        }

        itemImage.sprite = item.icon;

    }

    public void EquipItem()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        GameObject Equiped = clickObject.transform.Find("Equiped").gameObject;

    }
}
