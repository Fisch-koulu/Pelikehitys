using UnityEngine;

/// <summary>
/// Abstractin luokan rooli on
///     - m‰‰ritell‰ yhteinen rakenne ja toiminta
///     - ei edustaa konkreettista hahmoa peliss‰
/// </summary>
public class Character : MonoBehaviour
{
    //jos ei ole "field:", jonkun takia toi protected string ei n‰y, vaikka oisi SerializeField
    [field: SerializeField] protected string Name { get; set; }
    [field: SerializeField] protected float Health { get; set; }

    public void TakeDamage(int damageAmount)
    {
        Health -= damageAmount;
        Debug.Log($"{Name} sai {damageAmount} vahinkoa! HP: {Health}");

        if (Health <= 0) Debug.Log($"{Name} h‰visi taistelun!");
    }

    public virtual void Attack()
    {
        Debug.Log($"{Name} hyˆkk‰‰!");
    }
}
