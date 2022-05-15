using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionScroller : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float scrollRange = 9.9f;
    [SerializeField]
    private float movespeed = 3.0f;
    [SerializeField]
    private Vector3 moveDirection = Vector3.down;


    void Update()
    {
        //����� moveDirection �������� move Speed�� �ӵ��� �̵�
        transform.position += moveDirection * movespeed  * Time.deltaTime;

        if (transform.position.y <= -scrollRange)
        {
            transform.position = target.position + Vector3.up * scrollRange;
        }
    }
}
