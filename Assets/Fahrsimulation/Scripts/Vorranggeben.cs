using UnityEngine;
using TMPro;

public class Vorranggeben : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Street"))
        {
            Text.text = "VorrangZone";
        }
    }
}
