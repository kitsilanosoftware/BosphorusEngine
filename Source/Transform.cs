//------------------------------------------------------------------------------
// Transform.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

using YamlDotNet.Serialization;


namespace UnityEngine
{
	public sealed class Transform : Component
	{
		// public void DetachChildren ();
		
		public Transform Find(string name)
		{
			return this;
		}
		
		// public Transform FindChild (string name);
		// public Transform GetChild (int index);
		// public int GetChildCount ();
		// public System.Collections.IEnumerator GetEnumerator ();
		// public int GetSiblingIndex ();
		// public Vector3 InverseTransformDirection (float x, float y, float z);
		// public Vector3 InverseTransformDirection (Vector3 direction);
		// public Vector3 InverseTransformPoint (float x, float y, float z);
		// public Vector3 InverseTransformPoint (Vector3 position);
		// public bool IsChildOf (Transform parent);
		// public void LookAt (Transform target);
		// public void LookAt (Transform target, Vector3 worldUp);
		// public void LookAt (Vector3 worldPosition);
		// public void LookAt (Vector3 worldPosition, Vector3 worldUp);
		// public void Rotate (float xAngle, float yAngle, float zAngle);
		// public void Rotate (float xAngle, float yAngle, float zAngle, Space relativeTo);
		// public void Rotate (Vector3 eulerAngles);
		// public void Rotate (Vector3 axis, float angle);
		// public void Rotate (Vector3 axis, float angle, Space relativeTo);
		// public void Rotate (Vector3 eulerAngles, Space relativeTo);
		// public void RotateAround (Vector3 axis, float angle);
		// public void RotateAround (Vector3 point, Vector3 axis, float angle);
		// public void RotateAroundLocal (Vector3 axis, float angle);
		// public void SetAsFirstSibling ();
		// public void SetAsLastSibling ();
		// public void SetSiblingIndex (int index);
		// public Vector3 TransformDirection (float x, float y, float z);
		// public Vector3 TransformDirection (Vector3 direction);
		// public Vector3 TransformPoint (float x, float y, float z);
		// public Vector3 TransformPoint (Vector3 position);
		// public void Translate (float x, float y, float z);
		// public void Translate (float x, float y, float z, Space relativeTo);
		// public void Translate (float x, float y, float z, Transform relativeTo);
		// public void Translate (Vector3 translation);
		// public void Translate (Vector3 translation, Space relativeTo);
		// public void Translate (Vector3 translation, Transform relativeTo);
		
		// public int childCount { get; }
		// public Vector3 eulerAngles { get; set; }
		// public Vector3 forward { get; set; }
		// public bool hasChanged { get; set; }
		// public Vector3 localEulerAngles { get; set; }

		[YamlAlias("m_LocalPosition")]
		public Vector3 localPosition { get; set; }
		
		[YamlAlias("m_LocalRotation")]
		public Quaternion localRotation { get; set; }
		
		[YamlAlias("m_LocalScale")]
		public Vector3 localScale { get; set; }

		[YamlAlias("m_Children")]
		public ComponentReference[] children { get; set; }

		// public Matrix4x4 localToWorldMatrix { get; }
		// public Vector3 lossyScale { get; }
		public Transform parent { get; set; }
		public Vector3 position { get; set; }
		// public Vector3 right { get; set; }
		public Transform root;
		public Quaternion rotation { get; set; }
		// public Vector3 up { get; set; }
		// public Matrix4x4 worldToLocalMatrix { get; }
	}
}