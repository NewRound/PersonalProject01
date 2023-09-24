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
    [SerializeField] public ScrollRect scrollRect; // ��ũ�� ��
    [SerializeField] public RectTransform content; // Content ���

    private PlayerModel playerModel;

    // �߰��� ������ ������ ������ �Ǵ� UI ���
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

        // Content�� �ڽ����� ����
        newItem.transform.SetParent(content, false);

        // ������ �ʱ�ȭ �� ��ġ ����
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
