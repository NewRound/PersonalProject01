using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("GameObject")]
    [SerializeField] GameObject player;

    [Header("UI")]
    [SerializeField] GameObject BackgroundUICanvas;
    [SerializeField] GameObject selectUICanvas;
    [SerializeField] GameObject playerInfoUICanvas;
    [SerializeField] GameObject InventoryUICanvas;
    [SerializeField] GameObject backButton;

    private void Awake()
    {
        instance = this;

        selectUICanvas.SetActive(true);
        playerInfoUICanvas.SetActive(false);
        InventoryUICanvas.SetActive(false);
        backButton.SetActive(false);
    }


}
