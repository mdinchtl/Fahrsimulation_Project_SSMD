using UnityEngine;
using TMPro;

public class DisplaySpeed : MonoBehaviour
{
    private Rigidbody rb;
    public TextMeshProUGUI speedText;
    public ScoreManager scoreSystem;
    private bool wasOverLimit = false;
    private float underLimitTimer = 0f;
    public float limit = 55f;
    public float resetDelay = 3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float speed = Mathf.Max(0f, rb.linearVelocity.magnitude * 7.2f - 5f);

        speedText.text = "Speed: " + speed.ToString("F0") + " km/h";

        if (speed > limit)
        {
            underLimitTimer = 0f;

            if (!wasOverLimit)
            {
                scoreSystem.score += 3;
                scoreSystem.typOfError.Add("Speeding");
                wasOverLimit = true;
            }
        }
        else
        {
            underLimitTimer += Time.deltaTime;

            if (underLimitTimer >= resetDelay)
            {
                wasOverLimit = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kinderzone"))
        {
            limit = 25f;
        }
    }
}