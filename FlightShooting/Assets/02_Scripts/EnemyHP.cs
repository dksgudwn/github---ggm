using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 4;
    private float currentHP;
    private Enemy enemy;
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        currentHP = maxHP;
        enemy = GetComponent<Enemy>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    public void TakeDamege(float damege)
    {
        currentHP -= damege;
        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");
        
        if ( currentHP <=0)
        {
            enemy.OnDie();
        }
    }
    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.05f);
        spriteRenderer.color = Color.white;
    }
}
