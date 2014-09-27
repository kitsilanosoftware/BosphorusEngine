//------------------------------------------------------------------------------
// Rect.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public struct Rect
	{
		// public Rect (float left, float top, float width, float height);
		// public Rect (Rect source);
		
		// public static Rect MinMaxRect (float left, float top, float right, float bottom);
		// public static Vector2 NormalizedToPoint (Rect rectangle, Vector2 normalizedRectCoordinates);
		// public static Vector2 PointToNormalized (Rect rectangle, Vector2 point);
		// public bool Contains (Vector2 point);
		// public bool Contains (Vector3 point);
		// public bool Contains (Vector3 point, bool allowInverse);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public bool Overlaps (Rect other);
		// public bool Overlaps (Rect other, bool allowInverse);
		// public void Set (float left, float top, float width, float height);
		// public override string ToString ();
		// public string ToString (string format);
		
		// public static bool operator != (Rect lhs, Rect rhs);
		// public static bool operator == (Rect lhs, Rect rhs);
		
		// public float bottom { get; }
		// public Vector2 center { get; set; }
		
		// YAML: Direct mapping.
		public float height { get; set; }
		
		// public float left { get; }
		// public Vector2 max { get; set; }
		// public Vector2 min { get; set; }
		// public Vector2 position { get; set; }
		// public float right { get; }
		// public Vector2 size { get; set; }
		// public float top { get; }
		
		// YAML: Direct mapping.
		public float width { get; set; }
		public float x { get; set; }
		
		// public float xMax { get; set; }
		// public float xMin { get; set; }
		
		// YAML: Direct mapping.
		public float y { get; set; }
		
		// public float yMax { get; set; }
		// public float yMin { get; set; }
	}
}

