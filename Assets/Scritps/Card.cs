using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool isPlayed;
    public int handIndex;
    public int matIndex;
    GameManager gm;

    public int cardId;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveToDiscardPile()
    {
        gm.playerDiscardPile.Add(this);
        gameObject.SetActive(false);
    }
}
