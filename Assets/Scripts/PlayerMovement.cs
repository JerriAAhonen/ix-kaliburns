using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement
{
	private readonly PlayerController controller;
	private Vector2 movementDir;

	public PlayerMovement(PlayerController controller)
	{
		this.controller = controller; 
	}

	public void Update()
	{
		var x = Input.GetAxis("Horizontal");
		var y = Input.GetAxis("Vertical");

		movementDir = new Vector2(x, y);
		movementDir.Normalize();
	}

	public void FixedUpdate()
	{
		controller.Move(movementDir);
	}
}
