//------------------------------------------------------------------------------
// Color.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

using System;

namespace UnityEngine
{
	public struct Color
	{
		public Color (float r, float g, float b, float a)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = a;
		}
		
		public Color (float r, float g, float b)
		{
			this.r = r;
			this.g = g;
			this.b = b;
			this.a = 1.0f;
		}
		
		public static Color Lerp(Color a, Color b, float t)
		{
			return red;
		}
		
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		
		public override string ToString ()
		{
			return String.Format ("RGBA({0}, {1}, {2}, {3})", r, g, b, a);
		}
		
		// public string ToString (string format);
		
		// public static Color operator + (Color a, Color b);
		// public static Color operator - (Color a, Color b);
		// public static Color operator * (Color a, Color b);
		// public static Color operator * (Color a, float b);
		// public static Color operator * (float b, Color a);
		// public static Color operator / (Color a, float b);
		// public static bool operator == (Color lhs, Color rhs);
		// public static bool operator != (Color lhs, Color rhs);
		// public static implicit operator Vector4 (Color c);
		// public static implicit operator Color (Vector4 v);
		
		// public static Color black { get; }
		// public static Color blue { get; }
		// public static Color clear { get; }
		// public static Color cyan { get; }
		// public static Color gray { get; }
		public static Color green { get; set; }
		// public static Color grey { get; }
		// public static Color magenta { get; }
		public static Color red { get; set; }
		// public static Color white { get; }
		// public static Color yellow { get; }
		// public Color gamma { get; }
		// public float grayscale { get; }
		// public float this [int index] { get; set; }
		// public Color linear { get; }
		
		// YAML: Direct mapping.
		public float r;
		public float g;
		public float b;
		public float a;
	}
}