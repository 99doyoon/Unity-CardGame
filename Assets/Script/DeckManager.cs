using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<CardData> deck = new List<CardData>();

    public void Shuffle()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            CardData temp = deck[i];
            int randomIndex = Random.Range(i, deck.Count);

            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

    public CardData Draw()
    {
        if (deck.Count == 0)
            return null;

        CardData card = deck[0];
        deck.RemoveAt(0);
        return card;
    }
}