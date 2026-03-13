using UnityEngine;
/// <summary>
/// Taikuri, joka perii Character-luokan
/// </summary>
public class Mage : Character
{
    public int vahinko = 15;
    public override void Attack()
    {
        Debug.Log($"{Name} heit‰‰ tulipallon!");
    }
}
