using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] int health, maxhealth;

    public void Start()
    {
        health = maxhealth;
    }

    public void UnitDamage(int damageammount)
    {
        health -= damageammount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Unitheal(int healammount)
    {
        int healmax = maxhealth;
        if (healammount < 0)
        {
            if (healmax <= healammount)
            {
                healammount -= healmax;
                if (healammount < 0)
                {
                    health += healammount;
                }
            }
            else
            {
                health += healammount;
            }
        }
    }
}
