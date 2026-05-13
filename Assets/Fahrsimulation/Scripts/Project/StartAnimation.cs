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

    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ColliderCar1_3"))
        {
            car1Animator.SetTrigger("On");
            car3Animator.SetTrigger("On");
            Debug.Log("ColliderCar1_3 triggered");
        }
        if (collision.gameObject.CompareTag("ColliderCar2_4"))
        {
            car2Animator.SetTrigger("On");
            car4Animator.SetTrigger("On");
        }
        if (collision.gameObject.CompareTag("ColliderCar5"))
        {
            car5Animator.SetTrigger("On");
        }
        if (collision.gameObject.CompareTag("ColliderCar6"))
        {
            car6Animator.SetTrigger("On");
        }
        if (collision.gameObject.CompareTag("ColliderCar7"))
        {
            car7Animator.SetTrigger("On");
        }
        if (collision.gameObject.CompareTag("ColliderCar8_9"))
        {
            car8Animator.SetTrigger("On");
            car9Animator.SetTrigger("On");
        }
        if (collision.gameObject.CompareTag("ColliderCar9"))
        {
            car9Animator.SetTrigger("On");
        }
    }
    


}
