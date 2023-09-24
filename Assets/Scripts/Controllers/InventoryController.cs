using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController instance;
    [SerializeField] public GameObject player;

    [SerializeField] public GameObject inventoryAmount;
    [SerializeField] public GameObject inventoryMaxAmount;
    [SerializeField] public ScrollRect scrollRect; // ��ũ�� ��
    [SerializeField] public RectTransform content; // Content ���

    // �߰��� ������ ������ ������ �Ǵ� UI ���
    [SerializeField] public GameObject itemPrefab;


    private void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        PlayerModel playerModel = player.GetComponent<PlayerModel>();
        List<ItemData> itemList = playerModel.inventory;

        GameObject item;
    }

    public void ReLoad()
    {
        GameObject newItem = Instantiate(itemPrefab);

        // Content�� �ڽ����� ����
        newItem.transform.SetParent(content, false);

        // ������ �ʱ�ȭ �� ��ġ ����
        // ���� ���, �ؽ�Ʈ�� �����ϴ� �ڵ�
        Text itemText = newItem.GetComponentInChildren<Text>();
        itemText.text = "Item ";
    }
}
