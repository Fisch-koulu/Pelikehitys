using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.KeyMinigame_Scripts
{
    public class ChestController : MonoBehaviour
    {
        [SerializeField] bool isOpen = false;
        [SerializeField] int requiredKeyId = 1;
        [SerializeField] private Animator chestAnimator;

        public void Open()
        {
            //arkku on avattu
            isOpen = true;
            Debug.Log("myöhemmin animator");
        }

        void TryOpen(PlayerInventory inventory)
        {
            //tarkista onko arkku jo auki --> return
            if (isOpen) { return; }

            //tarkista onko oikea avain inventorissa
            if (inventory != null && inventory.HasKey(requiredKeyId))
            {
                Open();
                inventory.ClearKey();
            } 
            else
            {
                Debug.Log("EI");
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                TryOpen(other.GetComponent<PlayerInventory>());
            }
        }
    }
}
