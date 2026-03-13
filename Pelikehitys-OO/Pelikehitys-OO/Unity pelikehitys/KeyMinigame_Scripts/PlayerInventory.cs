using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //vois laittaa singletonin
    [SerializeField] int currentId = -1;
    public bool HasKey(int id) => currentId == id;

    public void AddKey(int id)
    {
        currentId = id;

        Debug.Log($"nyt avain {id}");
    }

    public void ClearKey()
    {
        currentId = -1;

        Debug.Log("avain poistettu");
    }
}
