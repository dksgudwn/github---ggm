using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField]
    private PlayerController PlayerController;
    private TextMeshProUGUI textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        textScore.text = "Score "+PlayerController.Score;
        if(PlayerController.Score>=1000)
        {
            SceneManager.LoadScene("GameClear");
        }
    }
}
