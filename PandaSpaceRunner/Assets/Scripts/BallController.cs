using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public GameObject particle;
    
    Animator animator;
    [SerializeField]
    private float speed;
    bool started;
    bool gameOver;
    bool running;
    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Use this for initialization
    void Start()
    {

        started = false;
        gameOver = false;
        running = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                animator.SetLayerWeight(animator.GetLayerIndex("RunForward"), 1f);
                

                GameManager.instance.StartGame();
            }
        }

        //Debug.DrawRay(transform.position, Vector3.down, Color.red);

        if (!Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -25f, 0);

            Camera.main.GetComponent<CameraFollow>().gameOver = true;

            GameManager.instance.GameOver();
        }

        if (Input.GetMouseButtonDown(0) && !gameOver)
        {
            SwitchDirection();
        }
    }

    void SwitchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
            transform.Rotate(0, 90, 0);
        }

        else if (rb.velocity.x > 0 && !running)
        {
            rb.velocity = new Vector3(0, 0, speed);
            running = true;
        }

        else if (rb.velocity.x > 0 && running)
        {
            rb.velocity = new Vector3(0, 0, speed);
            transform.Rotate(0, -90, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            GameObject part = Instantiate(particle, other.gameObject.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(part, 1f);
            ScoreManager.instance.diamondCount();

        }

        
    }
}
