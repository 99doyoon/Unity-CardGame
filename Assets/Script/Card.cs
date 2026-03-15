using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Card : MonoBehaviour
{
    public CardData data;

    public TMP_Text nameText;
    public TMP_Text costText;
    public Image artwork;

    Enemy enemy;

    public void Init(CardData newData)
    {
        data = newData;

        nameText.text = data.cardName;
        costText.text = data.cost.ToString();

        enemy = FindObjectOfType<Enemy>();
    }

    public void OnClick()
    {
        Debug.Log("Card Clicked!");

        if (enemy != null)
        {
            enemy.TakeDamage(data.damage);
        }

        Destroy(gameObject);
    }
}