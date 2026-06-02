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
            Text.text = "";
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
