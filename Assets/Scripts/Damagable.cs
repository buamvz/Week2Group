using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Damagable : MonoBehaviour
{

    [SerializeField] int hp;

    public virtual void TakeDamage(int damageAmount)
    {
        hp -= damageAmount;
        if (hp <= 0)
        {
            Dead();
        }
    }

    public virtual void Dead()
    {
        Debug.Log("Dead NOOOOO");
    }



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
