//------------------------------------------------------------------------------
// Rigidbody2D.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public class Rigidbody2D : Component
	{
		public bool fixedAngle;
		public Vector2 velocity;
		
		public void AddForce(Vector2 force, ForceMode2D mode = ForceMode2D.Force)
		{
		}
		
		public void AddTorque(float torque)
		{
		}
	}
}