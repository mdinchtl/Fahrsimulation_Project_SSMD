using TMPro;
using UnityEngine;

public class FollowStreet : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public Benotung Benotung;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Text.text = "Du befindest dich nicht mehr auf der Spur !";
            Benotung.punkte -= 1;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Text.text = "";
        }
    }
}
