using UnityEngine;
using TMPro;

public class OnTrack : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private void OnTriggerStay(Collider other)
    {
        if (
    !other.CompareTag("Vorrangstraße") &&
    !other.CompareTag("links") &&
    !other.CompareTag("rechts") &&
    !other.CompareTag("gerade") &&
    !other.CompareTag("Linie") &&
    !other.CompareTag("Strasse")
        )
        {
            Text.text = "Du befindest dich nicht mehr auf der Spur !";

        }
    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Ground"))
    //    {
    //        Text.text = "";
    //    }
    //}
}
