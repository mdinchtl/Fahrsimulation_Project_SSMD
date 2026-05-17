using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    public Animator car1Animator;
    public Animator car2Animator;
    public Animator car3Animator;
    public Animator car4Animator;
    public Animator car5Animator;
    public Animator car6Animator;
    public Animator car7Animator;
    public Animator car8Animator;
    public Animator car9Animator;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ColliderCar1_3"))
        {
            Debug.Log("ColliderCar1_3 triggered");
            car1Animator.SetTrigger("On");
            car3Animator.SetTrigger("On");
        }
        if (other.CompareTag("ColliderCar2_4"))
        {
            car2Animator.SetTrigger("On");
            car4Animator.SetTrigger("On");
        }
        if (other.CompareTag("ColliderCar5"))
        {
            car5Animator.SetTrigger("On");
        }
        if (other.CompareTag("ColliderCar6"))
        {
            car6Animator.SetTrigger("On");
        }
        if (other.CompareTag("ColliderCar7_9"))
        {
            car9Animator.SetTrigger("On");
            car7Animator.SetTrigger("On");
        }
        if (other.CompareTag("ColliderCar8"))
        {
            car8Animator.SetTrigger("On");
        }
        if (other.CompareTag("ColliderCar9"))
        {
            car9Animator.SetTrigger("On");
        }
    }



}
