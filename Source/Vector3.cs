//------------------------------------------------------------------------------
// Vector3.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public struct Vector3
	{
		public Vector3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		
		public Vector3(float x, float y)
		{
			this.x = x;
			this.y = y;
			this.z = 0;
		}
		
		public static Vector3 Lerp(Vector3 from, Vector3 to, float t)
		{
			return from;
		}
		
		// public static float Angle (Vector3 from, Vector3 to);
		// public static float AngleBetween (Vector3 from, Vector3 to);
		// public static Vector3 ClampMagnitude (Vector3 vector, float maxLength);
		// public static Vector3 Cross (Vector3 lhs, Vector3 rhs);
		// public static float Distance (Vector3 a, Vector3 b);
		// public static float Dot (Vector3 lhs, Vector3 rhs);
		// public static Vector3 Exclude (Vector3 excludeThis, Vector3 fromThat);
		// public static Vector3 Lerp (Vector3 from, Vector3 to, float t);
		// public static float Magnitude (Vector3 a);
		// public static Vector3 Max (Vector3 lhs, Vector3 rhs);
		// public static Vector3 Min (Vector3 lhs, Vector3 rhs);
		// public static Vector3 MoveTowards (Vector3 current, Vector3 target, float maxDistanceDelta);
		// public static Vector3 Normalize (Vector3 value);
		// public static void OrthoNormalize (ref Vector3 normal, ref Vector3 tangent);
		// public static void OrthoNormalize (ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal);
		// public static Vector3 Project (Vector3 vector, Vector3 onNormal);
		// public static Vector3 Reflect (Vector3 inDirection, Vector3 inNormal);
		// public static Vector3 RotateTowards (Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta);
		// public static Vector3 Scale (Vector3 a, Vector3 b);
		// public static Vector3 Slerp (Vector3 from, Vector3 to, float t);
		// public static Vector3 SmoothDamp (Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime);
		// public static Vector3 SmoothDamp (Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed);
		// public static Vector3 SmoothDamp (Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
		// public static float SqrMagnitude (Vector3 a);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Normalize ();
		// public void Scale (Vector3 scale);
		// public void Set (float new_x, float new_y, float new_z);
		// public override string ToString ();
		// public string ToString (string format);
		
		public static implicit operator Vector2(Vector3 vector)
		{
			return default(Vector2);
		}
		
		public static Vector3 operator+(Vector3 a, Vector3 b)
		{
			return a;
		}
		
		public static Vector3 operator-(Vector3 a, Vector3 b)
		{
			return a;
		}
		
		// public static Vector3 operator - (Vector3 a);
		public static Vector3 operator*(Vector3 a, float d)
		{
			return a;
		}
		
		// public static Vector3 operator * (float d, Vector3 a);
		// public static Vector3 operator / (Vector3 a, float d);
		// public static bool operator == (Vector3 lhs, Vector3 rhs);
		// public static bool operator != (Vector3 lhs, Vector3 rhs);
		
		// public static Vector3 back {
		//	get;
		// }
		// public static Vector3 down {
		//	get;
		// }
		// public static Vector3 forward {
		//	get;
		// }
		// public static Vector3 fwd {
		//	get;
		// }
		// public static Vector3 left {
		//	get;
		// }
		// public static Vector3 one {
		//	get;
		// }
		// public static Vector3 right {
		//	get;
		// }
		public static Vector3 up;
		
		// public static Vector3 zero {
		//	get;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		// public float magnitude {
		//	get;
		// }
		public Vector3 normalized { get { return this; } }
		// public float sqrMagnitude {
		//	get;
		// }
		
		public const float kEpsilon = 1E-05f;
		
		// YAML: Direct mapping.
		public float x;
		public float y;
		public float z;
	}
}