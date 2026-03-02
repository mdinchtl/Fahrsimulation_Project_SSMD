using UnityEngine;

public class DispaySpeed : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float speed = rb.linearVelocity.magnitude * 3.6f;
        Debug.Log("Geschwindigkeit: " + speed + " m/s");
    }
}
