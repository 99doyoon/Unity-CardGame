using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DeckManager deck;
    public HandManager hand;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            DrawCard();
        }
    }

    public void DrawCard()
    {
        CardData card = deck.Draw();

        if (card != null)
        {
            hand.AddCard(card);
        }
    }
}