using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MiniPlayerController : MonoBehaviour
{
    [SerializeField]
    private StageData stageData;
    private Movement2D movement2D;
    [SerializeField]
	private	KeyCode		keyCodeAttack = KeyCode.Space;
    private	Weapon		weapon;
    private	bool		isDie = false;

    private	int			score;
	public	int			Score
	{
		// score 값이 음수가 되지 않도록
		set => score = Mathf.Max(0, value);
		get => score;
	}

    private void Awake() {
        movement2D = GetComponent<Movement2D>();
        weapon		= GetComponent<Weapon>();
    }

    private void Update(){
        if ( isDie == true ) return;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        movement2D.MoveTo(new Vector3(x, y, 0));

        if ( Input.GetKeyDown(keyCodeAttack) )
		{
			weapon.StartFiring();
		}
		else if ( Input.GetKeyUp(keyCodeAttack) )
		{
			weapon.StopFiring();
		}

    }

    private void LateUpdate() {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, stageData.LimitMin.x, stageData.LimitMax.x), Mathf.Clamp(transform.position.y, stageData.LimitMin.y, stageData.LimitMax.y)
        );
    }


public void OnDie()
	{
		// 공격 중지
		weapon.StopFiring();
		// 이동 방향 초기화
		movement2D.MoveTo(Vector3.zero);
		// 사망 애니메이션 재생
		// 적들과 충돌하지 않도록 충돌 박스 삭제
		Destroy(GetComponent<CircleCollider2D>());
		// 사망 시 키 플레이어 조작 등을 하지 못하게 하는 변수
		isDie = true;
}
public void OnDieEvent()
	{
		// 디바이스에 획득한 점수 score 저장
		PlayerPrefs.SetInt("Score", score);
		// 플레이어 사망 시 nextSceneName 씬으로 이동
	}
    
}