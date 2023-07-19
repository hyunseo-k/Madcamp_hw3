using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerScoreViewer : MonoBehaviour
{
    [SerializeField]
    private MiniPlayerController PlayerController;
    private TMP_Text  textScore;

    private void Awake()
    {
        textScore = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        // Text UI에 현재 점수 정보를 업데이트
        textScore.text = "Score "+PlayerController.Score;
    }
}
