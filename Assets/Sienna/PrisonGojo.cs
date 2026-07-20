using UnityEngine;

public class PrisonGojo : MonoBehaviour
{
    [SerializeField] int hp;

    public void TakeDamage(int damageAmount)
    {
        hp -= damageAmount;
        if (hp <= 0)
        {
            Dead();
        }
    }

    public void Dead()
    {
        Debug.Log("Gojo prison realm is freed!");
    }

  

}
