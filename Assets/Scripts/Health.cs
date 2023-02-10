using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 5;
    [SerializeField] int score = 1;


    ScoreManager scoreManager;
    Enermy enermy;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        enermy = FindObjectOfType<Enermy>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damageDealer = collision.GetComponent<DamageDealer>();
        if(damageDealer!=null)
        {
            if(enermy.CanDestroy()==true)
            {
                TakeDame(damageDealer.GetDame());
                damageDealer.Hit();
            }    
            
        }
    }
    void TakeDame(int dame)
    {
        health -= dame;
        if(health<=0)
        {
            Die();
        }    
    }
    void Die()
    {
            scoreManager.ModifyScore(score);
            Destroy(gameObject);
    }
}
