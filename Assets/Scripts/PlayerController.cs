using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 2f;
    public float speedGravity = 15f;
    public bool isRising = false;
    public bool isGoingDown = false;
    public float maxJumpY = 2.30f;
    public float minJumpY = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isRising = true;
        }

        MovementPlayer();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obs")
        {
            Debug.Log("Colidiu!");
        }
    }

    private void MovementPlayer()
    {
        if (isRising && !isGoingDown)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (transform.position.y >= maxJumpY)
            {
                isRising = false;
                isGoingDown = true;
            }
        }

        if (isGoingDown)
        {
            transform.Translate(Vector3.down * speedGravity * Time.deltaTime);
            if (transform.position.y <= minJumpY)
            {
                isGoingDown = false;
            }
        }
    }
}
