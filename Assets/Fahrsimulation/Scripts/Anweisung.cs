using UnityEngine;
using UnityEngine.UI;

public class Anweisung : MonoBehaviour
{
    public Image anweisungBild;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("VorrangZone"))
        {    
            anweisungBild.enabled = true;
        }
    }
}
