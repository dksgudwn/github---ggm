using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    float timer;
    float waitingTime;
    [SerializeField]
    private GameObject Playerprojecttile;
    [SerializeField]
    private float attackRate = 5f;
    private void Start()
    {
        timer = 0.0f;
        waitingTime = attackRate;
    }
    void Update()
    {
        timer += Time.deltaTime;
    }
    public void StartFiring()
    {
        StartCoroutine("WaitForSeconds");
    }

    private IEnumerator WaitForSeconds(){
        while (true)
        {
            if(Input.GetKey(KeyCode.Space) && timer > waitingTime ){
                StartCoroutine("TryAttack");
                timer = 0;
            }
            yield return new WaitForSeconds(attackRate);
        }
    }

    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }
    private IEnumerator TryAttack()
    {
        while (true)
        {
            Instantiate(Playerprojecttile, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(attackRate);
        }
    }
}
