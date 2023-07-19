using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    [SerializeField]
    private int damage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
	{
		// 운석에 부딪힌 오브젝트의 태그가 "Player"이면
		if ( collision.CompareTag("Player") )
		{
			// 운석 공격력만큼 플레이어 체력 감소
			collision.GetComponent<PlayerHP>().TakeDamage(damage);
            Destroy(gameObject);
		}
	}
}
