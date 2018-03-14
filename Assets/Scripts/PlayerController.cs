using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator anim;
    private bool playerMoving;
    private Vector2 lastMove;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        playerMoving = false;



        if (moveHorizontal > 0.5f || moveHorizontal < -0.5f)
        {
            playerMoving = true;
            lastMove = new Vector2(moveHorizontal * Time.deltaTime, 0f);
            rb.velocity = new Vector2(moveHorizontal * speed * Time.deltaTime, rb.velocity.y);
        }
        if (moveVertical > 0.5f || moveVertical < -0.5f)
        {
            playerMoving = true;
            lastMove = new Vector2(0f, moveVertical * Time.deltaTime);
            rb.velocity = new Vector2(rb.velocity.x, moveVertical * speed * Time.deltaTime);

        }

        if (moveHorizontal < 0.5f && moveHorizontal > -0.5f)
        {
            rb.velocity = new Vector2(0f, rb.velocity.y);

        }
        if (moveVertical < 0.5f && moveVertical > -0.5f)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);

        }



        anim.SetFloat("moveX", moveHorizontal * Time.deltaTime);
        anim.SetFloat("moveY", moveVertical * Time.deltaTime);
        anim.SetBool("playerMoving", playerMoving);
        anim.SetFloat("lastMoveX", lastMove.x * Time.deltaTime);
        anim.SetFloat("lastMoveY", lastMove.y * Time.deltaTime);

    }

}
