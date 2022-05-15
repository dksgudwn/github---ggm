using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //collision.GetComponent<Enemy>().OnDie();
            collision.GetComponent<EnemyHP>().TakeDamege(damage);
            Destroy(gameObject);
        }
    }
}
 