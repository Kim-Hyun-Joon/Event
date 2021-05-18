using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public void HealthBoost(Character target) {
        Debug.Log(target.playerName + " 의 체력을 강화했다");
        target.hp += 10;
    }

    public void ShieldBoost(Character target) {
        Debug.Log(target.playerName + " 의 실드를 강화했다");
        target.defense += 10;
    }
    public void DamageBoost(Character target) {
        Debug.Log(target.playerName + " 의 데미지를 강화했다");
        target.damage += 10;
    }

    private void Awake() {
        Character player = FindObjectOfType<Character>();

        player.playerBoost += HealthBoost;
        player.playerBoost += ShieldBoost;
        player.playerBoost += DamageBoost;
        //if
        //player.playerBoost = DamageBoost;
        //이렇게 돼면 데미지만 덮어씌워버리는 상황이 발생한다
        //이러한 상황을 방지하기 위해서
        //delegate에 event를 사용한다
        //event를 설정하면 덮어씌우는것을 막아주고 덧셈뺄셈만 가능하게 함
        //event는 코드 실수를 하지 않을 자신 있다면 안 써도 가능은 하다

        //또한
        //player.playerBoost(player);
        //event를 설정한다면 캐릭터 스크립트 밖에서 이벤트를 임의로 발생시키지 못하게 한다
    }
}
