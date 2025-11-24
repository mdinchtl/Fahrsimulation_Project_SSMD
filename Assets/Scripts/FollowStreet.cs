using UnityEngine;

public class FollowStreet : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Street"))
        {
            Debug.Log("Auto hat die Straﬂe verlassen!");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Street"))
        {
            Debug.Log("Auto ist wieder auf der spur !");
        }
    }
}
