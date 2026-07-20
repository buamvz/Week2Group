using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damageAmount;
    public GameObject hitObject;

    public void Attack()
    {
        hitObject.GetComponent<Damagable>().TakeDamage(damageAmount);
    }


}
