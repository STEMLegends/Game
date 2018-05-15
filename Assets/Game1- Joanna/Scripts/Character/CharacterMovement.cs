using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

    protected bool toRight = true;
    [SerializeField] protected int speed = 2;
    protected float movement = 0.05f;
    protected int jumpHeight = 6;
    protected bool jumping = false;
    //protected bool djumping = false;
    protected string walkingAnimName = "run";
    protected string jumpingAnimName = "jump";
    protected string shootingAnimName = "gunShoot";
    protected string strikingAnimName = "meleeSwing1";
    protected int lives = 8;
    protected int enemies = 0;
    Animator cmpAnimator;
    Rigidbody2D cmpRigidBody;
    SpriteRenderer sprite;
    void Start()
    {
        cmpAnimator = GetComponent<Animator>();
        cmpRigidBody = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        //IDle animation
        cmpAnimator.SetFloat("Speed", Mathf.Abs(horizontalAxis));
        cmpRigidBody.MovePosition(this.transform.position + new Vector3(horizontalAxis * Time.deltaTime *speed, 0));

        // Move to left
        if (Input.GetAxis("Horizontal") >= 0.03f)
        {
            sprite.flipX = false;

        }

        // Move to right
        if (Input.GetAxis("Horizontal") <= -0.03f)
        {
            sprite.flipX = true;

        }

        // Shoot
        if (Input.GetMouseButtonDown(0))
        {

            Destroy(GameObject.Find("Enemy" + lives));

            enemies++;

            if (enemies == 14)
            {
                Application.LoadLevel("win_scene");
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
        }

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && !jumping)
        {
            Debug.Log("Saltando");
            jumping = true;
            cmpRigidBody.AddForce( new Vector3(0, jumpHeight * 1000, 0));
        }

        // Double jumping
        /*if (Input.GetKeyDown(KeyCode.Space) && jumping && !djumping)
        {
            djumping = true;
            GetComponentInChildren<Rigidbody2D>().velocity = new Vector3(0, jumpHeight, 0);
            GetComponentInChildren<SkeletonAnimation>().AnimationName = jumpingAnimName;
        }*/
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("TagPlatform"))
        {
            jumping = false;
            //djumping = false;

        }

       
    }
}
