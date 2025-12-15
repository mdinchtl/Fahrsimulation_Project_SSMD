using TMPro;
using UnityEngine;

public class FollowStreet : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Street"))
        {
           Text.text = "Du befindest dich nicht mehr auf der Spur !";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Street"))
        {
            Text.text = " ";

        }
    }
}
