using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<HealthSystem>(out HealthSystem HealthDamage))
        {
            HealthDamage.UnitDamage(1);
        }
        Destroy(gameObject);
    }
}
