//------------------------------------------------------------------------------
// Material.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public class Material : Object
	{
		// public Material (string contents);
		// public Material (Shader shader);
		// public Material (Material source);
		
		// public static Material Create (string scriptContents);
		// public void CopyPropertiesFromMaterial (Material mat);
		// public void DisableKeyword (string keyword);
		// public void EnableKeyword (string keyword);
		// public Color GetColor (int nameID);
		// public Color GetColor (string propertyName);
		// public float GetFloat (int nameID);
		// public float GetFloat (string propertyName);
		// public int GetInt (int nameID);
		// public int GetInt (string propertyName);
		// public Matrix4x4 GetMatrix (int nameID);
		// public Matrix4x4 GetMatrix (string propertyName);
		// public string GetTag (string tag, bool searchFallbacks);
		// public string GetTag (string tag, bool searchFallbacks, string defaultValue);
		// public Texture GetTexture (int nameID);
		// public Texture GetTexture (string propertyName);
		// public Vector2 GetTextureOffset (string propertyName);
		// public Vector2 GetTextureScale (string propertyName);
		// public Vector4 GetVector (int nameID);
		// public Vector4 GetVector (string propertyName);
		// public bool HasProperty (int nameID);
		// public bool HasProperty (string propertyName);
		// public void Lerp (Material start, Material end, float t);
		// public void SetBuffer (string propertyName, ComputeBuffer buffer);
		// public void SetColor (int nameID, Color color);
		// public void SetColor (string propertyName, Color color);
		// public void SetFloat (int nameID, float value);
		// public void SetFloat (string propertyName, float value);
		// public void SetInt (int nameID, int value);
		// public void SetInt (string propertyName, int value);
		// public void SetMatrix (int nameID, Matrix4x4 matrix);
		// public void SetMatrix (string propertyName, Matrix4x4 matrix);
		// public bool SetPass (int pass);
		// public void SetTexture (int nameID, Texture texture);
		// public void SetTexture (string propertyName, Texture texture);
		// public void SetTextureOffset (string propertyName, Vector2 offset);
		// public void SetTextureScale (string propertyName, Vector2 scale);
		// public void SetVector (int nameID, Vector4 vector);
		// public void SetVector (string propertyName, Vector4 vector);
		
		public Color color { get; set; }
		// public Texture mainTexture { get; set; }
		// public Vector2 mainTextureOffset { get; set; }
		// public Vector2 mainTextureScale { get; set; }
		// public int passCount { get; private set; }
		// public int renderQueue { get; set; }
		// public Shader shader { get; set; }
		// public string [] shaderKeywords { get; set; }
	}
}