using UnityEngine;

public class FollowStreet : MonoBehaviour
{
    public GameObject Auto;
    void Start()
    {
        Collider autoCollider = Auto.GetComponent<Collider>();
    }

    void Update()
    {
        
    }
}
