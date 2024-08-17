using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[SerializeField] private float movementSpeed;

	private PlayerMovement movement;
	private Rigidbody2D rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
		movement = new PlayerMovement(this);
	}

	private void Update()
	{
		movement?.Update();
	}

	private void FixedUpdate()
	{
		movement?.FixedUpdate();
	}

	public void Move(Vector2 vel)
	{
		rb.velocity = movementSpeed * Time.fixedDeltaTime * vel;
	}
}
