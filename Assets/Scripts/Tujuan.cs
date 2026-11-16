using UnityEngine;
using UnityEngine.UI;

public class Tujuan : MonoBehaviour
{
    public Text teskPesan;

    void Start()
    {
        teskPesan.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            teskPesan.text = "MENANG!!";
            Debug.Log("Player Sampai Di Tujuan");
        }
    }
}
