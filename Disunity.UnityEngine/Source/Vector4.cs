//------------------------------------------------------------------------------
// Vector4.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public struct Vector4
	{
		// public Vector4 (float x, float y, float z, float w);
		// public Vector4 (float x, float y, float z);
		// public Vector4 (float x, float y);
		
		// public static float Distance (Vector4 a, Vector4 b);
		// public static float Dot (Vector4 a, Vector4 b);
		// public static Vector4 Lerp (Vector4 from, Vector4 to, float t);
		// public static float Magnitude (Vector4 a);
		// public static Vector4 Max (Vector4 lhs, Vector4 rhs);
		// public static Vector4 Min (Vector4 lhs, Vector4 rhs);
		// public static Vector4 MoveTowards (Vector4 current, Vector4 target, float maxDistanceDelta);
		// public static Vector4 Normalize (Vector4 a);
		// public static Vector4 Project (Vector4 a, Vector4 b);
		// public static Vector4 Scale (Vector4 a, Vector4 b);
		// public static float SqrMagnitude (Vector4 a);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Normalize ();
		// public void Scale (Vector4 scale);
		// public void Set (float new_x, float new_y, float new_z, float new_w);
		// public float SqrMagnitude ();
		// public override string ToString ();
		// public string ToString (string format);
		
		// public static Vector4 operator + (Vector4 a, Vector4 b);
		// public static Vector4 operator - (Vector4 a, Vector4 b);
		// public static Vector4 operator - (Vector4 a);
		// public static Vector4 operator * (Vector4 a, float d);
		// public static Vector4 operator * (float d, Vector4 a);
		// public static Vector4 operator / (Vector4 a, float d);
		// public static bool operator == (Vector4 lhs, Vector4 rhs);
		// public static bool operator != (Vector4 lhs, Vector4 rhs);
		// public static implicit operator Vector4 (Vector3 v);
		// public static implicit operator Vector3 (Vector4 v);
		// public static implicit operator Vector4 (Vector2 v);
		// public static implicit operator Vector2 (Vector4 v);
		
		// public static Vector4 one {
		//	get;
		// }
		// public static Vector4 zero {
		//	get;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		// public float magnitude {
		//	get;
		// }
		// public Vector4 normalized {
		//	get;
		// }
		// public float sqrMagnitude {
		//	get;
		// }
		
		public const float kEpsilon = 1E-05f;
		
		// YAML: Direct mapping.
		public float x;
		public float y;
		public float z;
		public float w;
	}
}