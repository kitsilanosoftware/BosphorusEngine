//------------------------------------------------------------------------------
// Physics2D.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{	
	public class Physics2D
	{
		public const int DefaultRaycastLayers = 0;
		
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			return null;
		}
		
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			return null;
		}
		
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			return null;
		}
	}
}
