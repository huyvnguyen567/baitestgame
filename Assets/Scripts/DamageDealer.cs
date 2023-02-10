using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int dame = 1;
    public int GetDame()
    {
        return dame;
    }
    public void Hit()
    {
        Destroy(gameObject);
    }
    
}
