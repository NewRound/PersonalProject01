using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("GameObject")]
    [SerializeField] GameObject player;

    [Header("UI")]
    [SerializeField] GameObject selectUICanvas;
    [SerializeField] GameObject playerInfoUICanvas;
    [SerializeField] GameObject InventoryUICanvas;
    [SerializeField] GameObject backButton;
    [SerializeField] TMP_Text playerName;
    [SerializeField] TMP_Text playerText;
    [SerializeField] TMP_Text Level;
    [SerializeField] Slider EXP;
    [SerializeField] TMP_Text EXPText;

    private void Awake()
    {
        instance = this;

        selectUICanvas.SetActive(true);
        playerInfoUICanvas.SetActive(false);
        InventoryUICanvas.SetActive(false);
        backButton.SetActive(false);
    }

    private void Start()
    {
        PlayerModel playerModel = player.GetComponent<PlayerModel>();
        playerName.text = playerModel.Name;
        playerText.text = playerModel.explanation;
        Level.text = playerModel.level.ToString();
        EXP.value = playerModel.exp / playerModel.maxExp;
        EXPText.text = (playerModel.exp.ToString() + " / " + playerModel.maxExp.ToString());
    }


}
