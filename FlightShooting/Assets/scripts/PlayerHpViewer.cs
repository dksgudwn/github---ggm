using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHpViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerHp playerHp;
    private Slider sliderHp;

    private void Awake()
    {
        sliderHp = GetComponent<Slider>();
    }

    /// <summary>
    /// Tip. �� ��Ȯ�� ������δ� �̺�Ʈ�� �̿��� ü�� ������ �ٲ𶧸� UI ���� ����
    /// </summary>
    private void Update()
    {
        sliderHp.value = playerHp.CurrentHp / playerHp.MaxHp;
    }
}
