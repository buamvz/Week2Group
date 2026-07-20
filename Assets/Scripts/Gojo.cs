using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Gojo : Damagable
{

    [SerializeField] int hp;

    public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount);
    }

    public void Dead()
    {
        base.Dead();
        Debug.Log("Dead");
    }


    
}
