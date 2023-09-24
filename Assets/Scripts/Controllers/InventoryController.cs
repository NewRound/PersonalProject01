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
    [SerializeField] public ScrollRect scrollRect; // 스크롤 뷰
    [SerializeField] public RectTransform content; // Content 요소

    // 추가할 내용을 저장할 프리팹 또는 UI 요소
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

        // Content의 자식으로 설정
        newItem.transform.SetParent(content, false);

        // 아이템 초기화 및 위치 설정
        // 예를 들어, 텍스트를 설정하는 코드
        Text itemText = newItem.GetComponentInChildren<Text>();
        itemText.text = "Item ";
    }
}
