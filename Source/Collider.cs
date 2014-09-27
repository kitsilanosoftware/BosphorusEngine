//------------------------------------------------------------------------------
// Collider.cs
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
	public class Collider : Component
	{
		// public Collider ();
		
		// public Vector3 ClosestPointOnBounds (Vector3 position);
		// public bool Raycast (Ray ray, out RaycastHit hitInfo, float distance);
		
		// public Rigidbody attachedRigidbody { get; }
		// public Bounds bounds { get; }
		
		[YamlAlias("m_Enabled")]
		public bool enabled { get; set; }
		
		[YamlAlias("m_IsTrigger")]
		public bool isTrigger { get; set; }
		
		// TODO: via fileID.
		// [YamlAlias("m_Material")]
		// public PhysicMaterial material { get; set; }
		// public PhysicMaterial sharedMaterial { get; set; }
	}
}