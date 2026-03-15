using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 30;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Enemy HP : " + health);

        if (health <= 0)
        {
            Debug.Log("Enemy Dead");
        }
    }
}