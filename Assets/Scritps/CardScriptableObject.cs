using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType { SPELL, CHARACTER }

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardScriptableObject : ScriptableObject
{
    public int id;
    public new string name;
    public string description;

    public Sprite image;
    public CardType cardType;

    public int manaCost;
    public int attack;
    public int health;

    public void Print()
    {
        Debug.Log(name + ": " + description + " The card costs" + manaCost);
    }
}
