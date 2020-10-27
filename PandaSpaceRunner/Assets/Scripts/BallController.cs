using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallController : MonoBehaviour
{

	private Vector2 fingerDownPos;
	private Vector2 fingerUpPos;
	public GameObject particle;
	Animator animator;
	[SerializeField]
	private float speed;
	bool started;
	bool gameOver;
	
	

	Rigidbody rb;

	public bool detectSwipeAfterRelease = false;

	public float SWIPE_THRESHOLD = 20f;


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
		speed = 8f;
		
	}

	// Update is called once per frame
	void Update()
	{
		if (!started)
		{
			if (Input.GetMouseButtonDown(0))
			{
				rb.velocity = new Vector3(0, 0, speed);
				started = true;
				animator.SetLayerWeight(animator.GetLayerIndex("RunForward"), 1f);

				GameManager.instance.StartGame();
			}
		}

		if (!Physics.Raycast(transform.position, Vector3.down, 1f))
		{
			gameOver = true;
			rb.velocity = new Vector3(0, -25f, 0);

			Camera.main.GetComponent<CameraFollow>().gameOver = true;

			GameManager.instance.GameOver();
		}

		foreach (Touch touch in Input.touches)
		{
			if (touch.phase == TouchPhase.Began)
			{
				fingerUpPos = touch.position;
				fingerDownPos = touch.position;
			}

			//Detects Swipe while finger is still moving on screen
			if (touch.phase == TouchPhase.Moved)
			{
				if (!detectSwipeAfterRelease)
				{
					fingerDownPos = touch.position;
					DetectSwipe();
					
				}
			}

			//Detects swipe after finger is released from screen
			if (touch.phase == TouchPhase.Ended)
			{
				fingerDownPos = touch.position;
				DetectSwipe();
				
			}
		}

		
	}

	

	void DetectSwipe()
	{

		if (VerticalMoveValue() > SWIPE_THRESHOLD && VerticalMoveValue() > HorizontalMoveValue())
		{
			Debug.Log("Vertical Swipe Detected!");
			if (fingerDownPos.y - fingerUpPos.y > 0)
			{
				OnSwipeUp();
			}
			else if (fingerDownPos.y - fingerUpPos.y < 0)
			{
				OnSwipeDown();
			}
			fingerUpPos = fingerDownPos;

		}
		else if (HorizontalMoveValue() > SWIPE_THRESHOLD && HorizontalMoveValue() > VerticalMoveValue())
		{
			Debug.Log("Horizontal Swipe Detected!");
			if (fingerDownPos.x - fingerUpPos.x > 0)
			{
				OnSwipeRight();
			}
			else if (fingerDownPos.x - fingerUpPos.x < 0)
			{
				OnSwipeLeft();
			}
			fingerUpPos = fingerDownPos;

		}
		else
		{
			Debug.Log("No Swipe Detected!");
		}
	}

	float VerticalMoveValue()
	{
		return Mathf.Abs(fingerDownPos.y - fingerUpPos.y);
	}

	float HorizontalMoveValue()
	{
		return Mathf.Abs(fingerDownPos.x - fingerUpPos.x);
	}

	void OnSwipeUp()
	{
		
	}

	void OnSwipeDown()
	{
		//Do something when swiped down
	}

	void OnSwipeLeft()
	{
		rb.velocity = new Vector3(0, 0, speed);
		animator.SetLayerWeight(animator.GetLayerIndex("RunRight"), 0f);
	}

	void OnSwipeRight()
	{
		rb.velocity = new Vector3(speed, 0, 0);
		animator.SetLayerWeight(animator.GetLayerIndex("RunRight"), 1f);
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
