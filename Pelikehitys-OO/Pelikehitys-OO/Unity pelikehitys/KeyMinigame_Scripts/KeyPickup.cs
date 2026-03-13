using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    [Tooltip("")]
    [SerializeField] int keyId = 0;

    private void OnTriggerEnter(Collider other)
    {

        var playerInventory = other.GetComponent<PlayerInventory>();

        //tarkista onko inventory olemassa
        if (playerInventory != null )
        {
            //lis‰t‰‰n ker‰tty avain inventoriin
            playerInventory.AddKey(keyId);

            //poistetaan avain scenesta
            Destroy(gameObject);
        }
    }
}
