using UnityEngine;
using UnityEngine.Animations;

/// <summary>
/// Avaa arkun
/// </summary>
public class ChestController : MonoBehaviour
{
    [SerializeField] private Animator chestAnimator;

    private void Awake()
    {
        chestAnimator = GetComponent<Animator>();
    }

    // TEHTÄVÄ:
    // 1. Tee julkinen metodi, jota toinen olio (esim. pelaaja, painike) voi kutsua
    public void Open()
    {
        // 2. Metodin tulee käynnistää arkun avautumisanimaatio
        chestAnimator.SetBool("Open", true);
        //ja debug logi että tiedän varmasti toimivan
        Debug.Log("Arkku aukeaa");
    }
    public void Close()
    {
        // Sulkee arkun
        // closing animaatiosta idleen on "Has Exit time" ja Exit time on 1
        chestAnimator.SetBool("Open", false);
        //ja debug logi että tiedän varmasti toimivan
        Debug.Log("Arkku menee kiinni");
    }
}
