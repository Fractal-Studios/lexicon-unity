/*
 * Controls the display of each card. Attatched to the Card prefab.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public CardScriptableObject cardScript;
    public TextMeshProUGUI descriptionText;
    public Image artworkImage;
    public TextMeshProUGUI manaText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI healthText;

    public int loadId;

    Card card;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Draw card: " + loadId.ToString());
        ChangeCard();
        HideCardUI();
    }

    public void ChangeCard()
    {
        card = GetComponent<Card>();
        //loadId = card.cardId;

        cardScript = Resources.Load<CardScriptableObject>("Cards/" + loadId.ToString("000"));
        descriptionText.text = cardScript.description;
        artworkImage.sprite = cardScript.image;
        manaText.text = cardScript.manaCost.ToString();
        attackText.text = cardScript.attack.ToString();
        healthText.text = cardScript.health.ToString();
    }
    
    // Hide health, attack, and mana text if the card is "spell" type
    public void HideCardUI()
    {
        switch (cardScript.cardType)
        {
            case CardType.SPELL:
                Debug.Log("Card is " + cardScript.cardType);
                healthText.gameObject.SetActive(false);
                attackText.gameObject.SetActive(false);
                manaText.gameObject.SetActive(false);
                break;
            case CardType.CHARACTER:
                Debug.Log("Card is " + cardScript.cardType);
                healthText.gameObject.SetActive(true);
                attackText.gameObject.SetActive(true);
                manaText.gameObject.SetActive(true);
                break;
            default:
                // Handle errors:
                Debug.Log("Error: Invalid card type.");
                break;
        }
    }

    public void LoadCardData(ScriptableObject CardData)
    {
        manaText.text = cardScript.manaCost.ToString();
        attackText.text = cardScript.attack.ToString();
        healthText.text = cardScript.health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeCard();
    }
}
