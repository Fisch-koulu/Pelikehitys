using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Inheritance
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Mage mage;
        [SerializeField] Warrior warrior;

        /*void Start()
        {
            mage = GetComponent<Mage>();
            warrior = GetComponent<Warrior>();
        }*/

        void Update()
        {
            if (Keyboard.current.xKey.wasPressedThisFrame) //ei ole Gamepadia nyt tässä
            {
                warrior.Attack();
                mage.TakeDamage(warrior.vahinko); //ottaa warrior luokasta sen damagen
            }
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                mage.Attack();
                warrior.TakeDamage(mage.vahinko); //ottaa mage luokasta sen damagen
            }
        }
    }
}
