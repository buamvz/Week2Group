using UnityEngine;

public class PrisonGojo : Damagable
{

    public override void TakeDamage(int damageAmount)
    {
        base.TakeDamage(damageAmount);
    }

    public override void Dead()
    {
        base.Dead();
        Debug.Log("Gojo prison realm is freed!");
    }

  

}
