using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class Gojo : MonoBehaviour
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
        Debug.Log("Dead");
    }



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
