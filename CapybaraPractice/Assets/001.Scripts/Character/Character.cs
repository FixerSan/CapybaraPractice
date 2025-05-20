using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterStatus status;

    public void Hit(float _damage, System.Action _hitCallback)
    {
        status.nowHP -= _damage;
        _hitCallback.Invoke();

        bool isDeath = status.nowHP <= 0;
        if(isDeath)
            Death();
    }

    public void Death()
    {

    }
}

public class CharacterStatus
{
    public float hp;
    public float nowHP;
    public float attackForce;
    public float nowAttackForce;
    public float defenceForce;
    public float nowDefenceForce;

}
