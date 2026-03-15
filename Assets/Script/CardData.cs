using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "Card Game/Card")]
public class CardData : ScriptableObject
{
    public string cardName;
    public int cost;
    public int damage;
    public Sprite artwork;
}