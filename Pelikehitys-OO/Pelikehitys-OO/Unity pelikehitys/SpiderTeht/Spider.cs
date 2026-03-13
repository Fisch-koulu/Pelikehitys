using Unity.VisualScripting;
using UnityEngine;

public class Spider : MonoBehaviour, IDamageable
{
    int spiderHealth = 100;
    
    public void TakeDamage(int amount)
    {
        spiderHealth -= amount;
        print($"Damage taken {spiderHealth}/100");

        if (spiderHealth <= 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
