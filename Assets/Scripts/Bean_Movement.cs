using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Bean_Movement : MonoBehaviour
{
	[SerializeField] private float move_speed;
	
	private Rigidbody2D rb2d;
	private Animator anim;
	private Player_Controls pc;

	private void Awake()
	{
		pc = new Player_Controls();
	}

	private void OnEnable()
	{
		pc.Enable();
	}

	private void OnDisable()
	{
		pc.Disable();
	}

	void Start()
    {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
    }

    void Update()
    {
		Move();
		
    }

	private void Move()
	{
		// get value from input (horizontal and vertical)
		float h_dir = pc.Player.Move_Horizontal.ReadValue<float>();
		float v_dir = pc.Player.Move_Vertical.ReadValue<float>();

		// process it into a new vector
		Vector2 n_velocity = new Vector2(h_dir * move_speed, v_dir * move_speed);
		// add new vector to velocity of rb2d
		rb2d.velocity = n_velocity;

		// update animation fsm
		bool has_hspeed = Mathf.Abs(rb2d.velocity.x) > Mathf.Epsilon;
		bool has_vspeed = Mathf.Abs(rb2d.velocity.y) > Mathf.Epsilon;
		anim.SetBool("isWalking", has_hspeed || has_vspeed);

		// check for necessary flipping
		FlipSprite(has_hspeed);
	}

	private void FlipSprite(bool has_hspeed)
	{
		// if moving, ensure it's facing in the direction of the velocity
		if (has_hspeed)
		{
			transform.localScale = new Vector2(Mathf.Sign(rb2d.velocity.x), 1f);
		}
	}
}
