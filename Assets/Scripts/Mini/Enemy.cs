using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    [SerializeField]
	private	int				 scorePoint = 100;		// 적 처치시 획득 점수
    private	MiniPlayerController playerController;		// 플레이어의 점수(Score) 정보에 접근하기 위해

    private void Awake()
	{
		playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<MiniPlayerController>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
	{
		// 적에게 부딪힌 오브젝트의 태그가 "Player"이면
		if ( collision.CompareTag("Player") )
		{
			// 적 공격력만큼 플레이어 체력 감소
			collision.GetComponent<PlayerHP>().TakeDamage(damage);
            OnDie();
		}
	}

    public void OnDie()
	{
		// 플레이어의 점수를 scorePoint만큼 증가시킨다
		playerController.Score += scorePoint;
		// 적 오브젝트 삭제
		Destroy(gameObject);
	}

}
