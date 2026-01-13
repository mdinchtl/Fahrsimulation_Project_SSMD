using TMPro;
using UnityEngine;

public class FollowStreet : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ground"))
        {
            Text.text = "Du befindest dich nicht mehr auf der Spur !";
            Benotung.punkte -= 2;

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
