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
        
        if (other.CompareTag("Vorrangstra�e"))
        {
            Text.text = "Vorrangstra�e !";
            Debug.Log("Vorrangstra�e !");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("VorrangZone"))
        {
            Text.text = "";
        }
        if (other.CompareTag("Vorrangstra�e"))
        {
            Text.text = "";
        }

    }

}
