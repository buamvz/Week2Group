using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Gojo : Damagable
{


    public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount);
    }

    public override void Dead()
    {
        base.Dead();
        Debug.Log("Dead");
    }


    
}
