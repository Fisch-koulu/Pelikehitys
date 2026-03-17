using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{
    public static event Action onPlayerDied;
    public static event Action<int> OnHealthChanged;

    #region HP
    [SerializeField] private int maxHealth = 100;

    private int currentHealth;

    public int CurrentHealth { get => currentHealth; set => currentHealth = value; }
    #endregion

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if ( Keyboard.current.spaceKey.wasPressedThisFrame )
        {
            TakeDamage(20);
        }
        if (Keyboard.current.hKey.wasPressedThisFrame)
        {
            HealDamage(20);
        }
    }

    void TakeDamage(int amount)
    {
        Modify(-amount);

        if (currentHealth <= 0)
        {
            Debug.Log("pelaaja kuoli");

            //kuolintapahtuma k‰ynistyy
            onPlayerDied?.Invoke();
        }
    }

    void HealDamage(int amount)
    {
        Modify(amount);

        if (currentHealth >= maxHealth)
        {
            Debug.Log("Pelaajalla on jo maksimi m‰‰r‰ terveytt‰");

            //vaihtaa takaisin max healthin
            currentHealth = maxHealth;
        }
    }

    void Modify(int amount)
    {
        currentHealth += amount;

        currentHealth = Math.Clamp(currentHealth, 0, maxHealth);

        //terveydenp‰ivitys tapahtuma k‰ynistyy
        OnHealthChanged?.Invoke(currentHealth);
    }
}
