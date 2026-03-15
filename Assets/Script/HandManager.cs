using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{
    public List<Card> hand = new List<Card>();

    public GameObject cardPrefab;
    public Transform handArea;
    /*
    public void AddCard(CardData data)
    {
        GameObject cardObj = Instantiate(cardPrefab, handArea);
        Card card = cardObj.GetComponent<Card>();

        card.data = data;
        hand.Add(card);
    }
    */
    public void AddCard(CardData data)
    {
        GameObject cardObj = Instantiate(cardPrefab, handArea);
        Card card = cardObj.GetComponent<Card>();

        card.Init(data);
    }
}