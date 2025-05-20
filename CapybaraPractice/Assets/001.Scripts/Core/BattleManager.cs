using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public void Hit(Character _attacker, Character _hiter)
    {
        _hiter.Hit(CalculateDamage(_attacker, _hiter), () => 
        {
            StageManager.Instance.CheckMoveToNextLevel();
        });
    }

    public float CalculateDamage(Character _attacker, Character _hiter)
    {
        float damage = _attacker.status.nowAttackForce * (1 / 1 + _hiter.status.nowDefenceForce * 0.01f);
        return damage;
    }
}
