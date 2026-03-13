using UnityEngine;
/// <summary>
/// Soturi, joka perii Character-luokan
/// </summary>
public class Warrior : Character
{
    public int vahinko = 20;
    public override void Attack()
    {
        Debug.Log($"{Name} lyö miekalla!");
    }
}
