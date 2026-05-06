using UnityEngine;

public class StartAnimation : MonoBehaviour
{
   public Animator car1Animator;
   
    void Start()
    {
       
        car1Animator.SetTrigger("On");
    }
}
