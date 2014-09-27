//------------------------------------------------------------------------------
// MeshCollider.cs
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
	public sealed class MeshCollider : Collider
	{
		// public MeshCollider ();
		
		[YamlAlias("m_Convex")]
		public bool convex { get; set; }
		
		// [YamlAlias("m_Mesh")]
		// public Mesh mesh { get; set; }
		// public Mesh sharedMesh { get; set; }
		
		[YamlAlias("m_SmoothSphereCollisions")]
		public bool smoothSphereCollisions { get; set; }
	}
}