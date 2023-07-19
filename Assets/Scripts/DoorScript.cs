using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    public Button hulalaBtn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("들어옴");
            hulalaBtn.gameObject.SetActive(true); // 플레이어가 감지되면 HulalaBtn 활성화
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hulalaBtn.gameObject.SetActive(false); // 플레이어가 범위를 벗어나면 HulalaBtn 비활성화
        }
    }
}
