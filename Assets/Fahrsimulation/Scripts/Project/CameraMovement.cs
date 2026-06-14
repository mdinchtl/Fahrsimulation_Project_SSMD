using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        float horizontal = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
            horizontal = -1f;

        if (Input.GetKey(KeyCode.RightArrow))
            horizontal = 1f;

        transform.Rotate(0f, horizontal * rotationSpeed * Time.deltaTime, 0f);
    }
}