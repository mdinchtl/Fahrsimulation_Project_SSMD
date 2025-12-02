using TMPro;
using UnityEngine;

public class FollowStreet : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Street"))
        {
           Text.text = "Auto ist nicht auf der spur !";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Street"))
        {
           Text.text = "Auto ist auf der spur !";
        }
    }
}
