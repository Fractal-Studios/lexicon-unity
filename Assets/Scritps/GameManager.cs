using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class GameManager : MonoBehaviour
{
    public List<Card> playerDeck;
    public List<Card> opponentDeck;
    public TextMeshProUGUI deckSizeText;

    public Transform[] playerCardSlots;
    public Transform[] opponentCardSlots;
    public bool[] playerAvailableCardSlots;
    public bool[] opponentAvailableCardSlots;

    public List<Card> playerDiscardPile;
    public List<Card> opponentDiscardPile;

    public CardScriptableObject cardScript;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(playerDeck + " total cards in deck...");
    }

    public void DrawCard()
    {

    }

    // Editor-only cheat to always be allowed to draw
#if UNITY_EDITOR
    public void EditorDrawCard()
    {

    }
#endif

    // Update is called once per frame
    void Update()
    {
        
    }
}
