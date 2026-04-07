using UnityEngine;
using TMPro;

public class DisplaySpeed : MonoBehaviour
{
    private Rigidbody rb;
    public TextMeshProUGUI speedText;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float speed = rb.linearVelocity.magnitude * 3.6f; // km/h
        speedText.text = "Speed:" + speed.ToString("F1") + "km/h";
    }
}