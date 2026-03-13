using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Luokka on vuorovaikutuksessa painikkeen kanssa.
/// </summary>
public class ButtonController : MonoBehaviour
{
    // Referenssi avattavaan arkkuun
    [SerializeField] private ChestController chest;

    private void Update()
    {
        //katsoo että se on olemassa
        if (Keyboard.current == null)
        {
            return;
        }

        // TEHTÄVÄ:
        // 1. Tee metodi, jota voidaan kutsua E-painikkeet painalluksesta
        if (Keyboard.current.eKey.wasPressedThisFrame) 
        // 2. Metodin tulee pyytää arkkua avautumaan
        { OpenChest(); }
        //Chest voi myös sulkeutua
        if (Keyboard.current.qKey.wasPressedThisFrame) { CloseChest(); }
    }

    //hyvä olla omat metodit, jos haluaa vaihtaa tai lisää
    void OpenChest() => chest.Open();
    void CloseChest() => chest.Close();
}
