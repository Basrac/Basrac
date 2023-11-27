using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject GameOverPopup;

    private Animator animator;
    public SpriteRenderer Img_Renderer;
    public Sprite SpriteLeft;
    public Sprite SpriteRight;
    public float movePower = 1f;
    public float jumpPower = 1f;
    public int maxHealth = 1;
 

    Rigidbody2D rigid;
  
    public delegate void JumpAction();
    public event JumpAction OnJumpEvent;

    Vector3 movement;
    bool isJumping = false;
    bool isDie = false;

    int health = 1;

    //---------------------------------------------------[Override Function]
    //Initialization
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponentInChildren<Animator>();

        health = maxHealth;
    }

    //Graphic & Input Updates	
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;

            if (OnJumpEvent != null)
            {
                OnJumpEvent();
            }
        }

        if(health == 0)
        {
            if (!isDie)
                Die();
            return;
        }
        if (transform.position.y < -13f)
        {
            gameObject.SetActive(false);

            Invoke("MoveToNextScene", 0.01f);
        }

    }

    //Physics engine Updates
    void FixedUpdate()
    {
        if (health == 0)
            return;
        Move();
        Jump();
    }

    //---------------------------------------------------[Movement Function]

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Img_Renderer.sprite = SpriteLeft;
            moveVelocity = Vector3.left;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            Img_Renderer.sprite = SpriteRight;
            moveVelocity = Vector3.right;
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    void Jump()
    {
        if (!isJumping)
            return;

        //Prevent Velocity amplification.
        rigid.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jumpPower);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJumping = false;
    }

    void Die()
    {
        isDie = true;

        rigid.velocity = Vector2.zero;
        animator.Play("Die");

        BoxCollider2D[] colls = gameObject.GetComponents<BoxCollider2D>();
        colls[0].enabled = false;
        colls[1].enabled = false;

        Vector2 dieVelocity = new Vector2(0, 10f);
        rigid.AddForce(dieVelocity, ForceMode2D.Impulse);

        Invoke("GameOver", 1f);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            TakeDamage(10);
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            gameObject.SetActive(false);

            Invoke("MoveToNextScene", 0.01f);
        }
        
    }

    public void MoveToNextScene()
    {
        GameOverPopup.SetActive(true);

    }
}
