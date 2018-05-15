using UnityEngine;
using System.Collections;

public class EnemyBase : MonoBehaviour
{

    public float speed = 0.3f;
    public float movementX = 0.05f;
    public float movementY = 0.1f;
    [SerializeField] int damageAmount = 1;
    protected int limitY = 0;
    protected bool movingUp = true;
    Vector3 movement;

    void Update()
    {
        Movement();

    }

    protected virtual void Movement()
    {
        float horizontalMove = Time.deltaTime * -speed;
        float verticalMove = Mathf.Sin(Time.time * movementY);

        movement.Set(this.transform.position.x + horizontalMove, verticalMove, 0f);

        transform.position = movement;
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.tag=="Character")
        {
            Debug.Log("DAÑO");

            FindObjectOfType<JoannaHeath>().AddDamage(damageAmount);
        }
	}

}
