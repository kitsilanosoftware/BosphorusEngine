//------------------------------------------------------------------------------
// Vector2.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public struct Vector2
	{
		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
		
		// public static float Angle (Vector2 from, Vector2 to);
		// public static Vector2 ClampMagnitude (Vector2 vector, float maxLength);
		// public static float Distance (Vector2 a, Vector2 b);
		// public static float Dot (Vector2 lhs, Vector2 rhs);
		// public static Vector2 Lerp (Vector2 from, Vector2 to, float t);
		// public static Vector2 Max (Vector2 lhs, Vector2 rhs);
		// public static Vector2 Min (Vector2 lhs, Vector2 rhs);
		// public static Vector2 MoveTowards (Vector2 current, Vector2 target, float maxDistanceDelta);
		// public static Vector2 Scale (Vector2 a, Vector2 b);
		// public static float SqrMagnitude (Vector2 a);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Normalize ();
		// public void Scale (Vector2 scale);
		// public void Set (float new_x, float new_y);
		// public float SqrMagnitude ();
		// public override string ToString ();
		// public string ToString (string format);
		
		// public static Vector2 operator + (Vector2 a, Vector2 b);
		// public static Vector2 operator - (Vector2 a, Vector2 b);
		// public static Vector2 operator - (Vector2 a);
		
		public static Vector2 operator*(Vector2 a, float d)
		{
			return a;
		}
		
		// public static Vector2 operator * (float d, Vector2 a);
		// public static Vector2 operator / (Vector2 a, float d);
		// public static bool operator == (Vector2 lhs, Vector2 rhs);
		// public static bool operator != (Vector2 lhs, Vector2 rhs);
		// public static implicit operator Vector2 (Vector3 v);
		// public static implicit operator Vector3 (Vector2 v);
		
		// public static Vector2 one {
		//	get;
		// }
		public static Vector2 right;
		
		// public static Vector2 up {
		//	get;
		// }
		// public static Vector2 zero {
		//	get;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		// public float magnitude {
		//	get;
		// }
		// public Vector2 normalized {
		//	get;
		// }
		// public float sqrMagnitude {
		//	get;
		// }
		
		public const float kEpsilon = 1E-05f;
		
		// YAML: Direct mapping.
		public float x;
		public float y;
	}

}