using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D  myRigidbody;
    private Vector3 change;
    private Animator animator;
    public GameObject SceneTrigger;
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void scenechangetrigger()
    {
       // GameObject.Find
    }

    
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
    }

    void UpdateAnimationAndMove()
    { 
              if (change != Vector3.zero)
        {
            MoveCharacter();
    animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
{
    animator.SetBool("moving", false);
}
    }
    void MoveCharacter()
    {
        myRigidbody.MovePosition(
            transform.position + change.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Note" && collision.gameObject.GetComponent <PopUpSystem> ().isbeinginteractedwith == false)
        {
            collision.gameObject.GetComponent<PopUpSystem>().activeinteract();


        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }


}
