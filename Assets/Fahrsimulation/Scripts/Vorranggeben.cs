using UnityEngine;
using TMPro;
using TMPro.Examples;


public class Vorranggeben : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VorrangZone"))
        {
            Text.text = "Vorrang geben !";
            Debug.Log("Vorrang geben !");
        }
    }

}
