using UnityEngine;
using TMPro;
using TMPro.Examples;


public class Vorrangregeln : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VorrangZone"))
        {
            Text.text = "Vorrang geben !";
            Debug.Log("Vorrang geben !");
        }
        
        if (other.CompareTag("Vorrangstraße"))
        {
            Text.text = "Vorrangstraße !";
            Debug.Log("Vorrangstraße !");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("VorrangZone"))
        {
            Text.text = "";
        }
        if (other.CompareTag("Vorrangstraße"))
        {
            Text.text = "";
        }
    }
}
