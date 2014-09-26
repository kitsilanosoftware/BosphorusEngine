//------------------------------------------------------------------------------
// Quaternion.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public struct Quaternion
	{
		public Quaternion(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}
		
		// public static float Angle (Quaternion a, Quaternion b);
		// public static Quaternion AngleAxis (float angle, Vector3 axis);
		// public static Quaternion AxisAngle (Vector3 axis, float angle);
		// public static float Dot (Quaternion a, Quaternion b);
		
		public static Quaternion Euler(float x, float y, float z)
		{
			return identity;
		}
		
		public static Quaternion Euler(Vector3 euler)
		{
			return identity;
		}
		
		// public static Quaternion EulerAngles (float x, float y, float z);
		// public static Quaternion EulerAngles (Vector3 euler);
		// public static Quaternion EulerRotation (float x, float y, float z);
		// public static Quaternion EulerRotation (Vector3 euler);
		// public static Quaternion FromToRotation (Vector3 fromDirection, Vector3 toDirection);
		// public static Quaternion Inverse (Quaternion rotation);
		// public static Quaternion Lerp (Quaternion from, Quaternion to, float t);
		// public static Quaternion LookRotation (Vector3 forward);
		// public static Quaternion LookRotation (Vector3 forward, Vector3 upwards);
		// public static Quaternion RotateTowards (Quaternion from, Quaternion to, float maxDegreesDelta);
		// public static Quaternion Slerp (Quaternion from, Quaternion to, float t);
		// public static Vector3 ToEulerAngles (Quaternion rotation);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Set (float new_x, float new_y, float new_z, float new_w);
		// public void SetAxisAngle (Vector3 axis, float angle);
		// public void SetEulerAngles (float x, float y, float z);
		// public void SetEulerAngles (Vector3 euler);
		// public void SetEulerRotation (float x, float y, float z);
		// public void SetEulerRotation (Vector3 euler);
		// public void SetFromToRotation (Vector3 fromDirection, Vector3 toDirection);
		// public void SetLookRotation (Vector3 view);
		// public void SetLookRotation (Vector3 view, Vector3 up);
		// public void ToAngleAxis (out float angle, out Vector3 axis);
		// public void ToAxisAngle (out Vector3 axis, out float angle);
		// public Vector3 ToEuler ();
		// public Vector3 ToEulerAngles ();
		// public override string ToString ();
		// public string ToString (string format);
		
		// public static Quaternion operator * (Quaternion lhs, Quaternion rhs);
		// public static Vector3 operator * (Quaternion rotation, Vector3 point);
		// public static bool operator == (Quaternion lhs, Quaternion rhs);
		// public static bool operator != (Quaternion lhs, Quaternion rhs);
		
		public static Quaternion identity = new Quaternion();
		
		// public static Quaternion identity {
		//	get;
		// }
		// public Vector3 eulerAngles {
		//	get;
		//	set;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		
		public const float kEpsilon = 1E-06f;
		
		// YAML: Direct mapping.
		public float x;
		public float y;
		public float z;
		public float w;
	}

}