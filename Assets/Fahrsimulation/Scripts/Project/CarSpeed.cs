//using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]
//public class CarSpeed : MonoBehaviour
//{
//    public float difference = 10f;
//    private Rigidbody rb;
//    private float currentSpeed = 0f;

//    void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//    }

//    void FixedUpdate()
//    {
//        if (Input.GetKey(KeyCode.UpArrow))
//        {
//            currentSpeed += difference * Time.fixedDeltaTime;
//        }

//        if (Input.GetKey(KeyCode.DownArrow))
//        {
//            currentSpeed -= difference * Time.fixedDeltaTime;
//        }
//    }

//}
