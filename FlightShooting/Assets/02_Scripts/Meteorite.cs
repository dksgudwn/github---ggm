using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private int scorePoint = 100;
    [SerializeField]
    private GameObject explosionPrefab;

    private void Awake()
    {
        //   playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerHp>().TakeDamege(damage);
            OnDie();
        }
    }

    public void OnDie()
    {
        //playerController.Score += scorePoint;
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
