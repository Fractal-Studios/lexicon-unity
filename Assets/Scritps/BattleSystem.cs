using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum BattleState { PRE, DRAW, PLAY, ATTACK, END }
public enum GameState { START, PLAYERTURN, ENEMYTURN, WON, LOST }
public class BattleSystem : MonoBehaviour
{
    public GameObject cardPrefab;
    public CardScriptableObject cardData;
    public Transform[] playerCardSlots;
    public Transform[] opponentCardSlots;
    public Transform[] playerMatSlots;
    public Transform[] opponentMatSlots;

    public TextMeshProUGUI phaseText;
    public TextMeshProUGUI turnText;

    public BattleState battleState;
    public GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        battleState = BattleState.PRE;
        gameState = GameState.START;
        SetupBattle();
    }

    // Update is called once per frame
    void Update()
    {
        // Move this into a function called when phases change #TODO
        phaseText.text = battleState.ToString();
        turnText.text = gameState.ToString();
    }
    public void DrawCard()
    {
        // Draw card and change phase DRAW -> PLAY
        if (battleState != BattleState.DRAW)
            Debug.Log("Error: Should not be able to call DrawCard() outside of DRAW state.");
        return;
    }
    void SetupBattle()
    {

    }
}
