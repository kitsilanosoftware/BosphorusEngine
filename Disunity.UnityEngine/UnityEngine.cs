using System;
using YamlDotNet.Serialization;

namespace Disunity.UnityEngine
{
	[Serializable]
	[Flags]
	public enum HideFlags
	{
		None,
		HideInHierarchy,
		HideInInspector,
		DontSave,
		NotEditable,
		HideAndDontSave
	}

	public class Object
	{
		// public static void Destroy (Object obj);
		// public static void Destroy (Object obj, float t);
		// public static void DestroyImmediate (Object obj);
		// public static void DestroyImmediate (Object obj, bool allowDestroyingAssets);
		// public static void DestroyObject (Object obj);
		// public static void DestroyObject (Object obj, float t);
		// public static void DontDestroyOnLoad (Object target);
		// public static T FindObjectOfType<T> () where T : Object;
		// public static Object FindObjectOfType (Type type);
		// public static T[] FindObjectsOfType<T> () where T : Object;
		// public static Object[] FindObjectsOfType (Type type);
		// public static Object[] FindObjectsOfTypeAll (Type type);
		// public static Object[] FindObjectsOfTypeIncludingAssets (Type type);
		// public static Object[] FindSceneObjectsOfType (Type type);
		// public static Object Instantiate (Object original);
		// public static Object Instantiate (Object original, Vector3 position, Quaternion rotation);
		// public override bool Equals (object o);
		// public override int GetHashCode ();
		// public int GetInstanceID ();
		// public override string ToString ();

		// public static implicit operator bool (Object exists);
		// public static bool operator == (Object x, Object y);
		// public static bool operator != (Object x, Object y);

		public HideFlags hideFlags { get; set; }
		public string name { get; set; }
	}

	public class Material: Object
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
		public int passCount { get; private set; }
		public int renderQueue { get; set; }
		// public Shader shader { get; set; }
		public string [] shaderKeywords { get; set; }
	}

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

		// public static Color Lerp (Color a, Color b, float t);
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
		// public static Color green { get; }
		// public static Color grey { get; }
		// public static Color magenta { get; }
		// public static Color red { get; }
		// public static Color white { get; }
		// public static Color yellow { get; }
		// public Color gamma { get; }
		// public float grayscale { get; }
		// public float this [int index] { get; set; }
		// public Color linear { get; }

		public float r;
		public float g;
		public float b;
		public float a;
	}

	public enum FogMode
	{
		Linear = 1,
		Exponential,
		ExponentialSquared
	}

	public class RenderSettings: Object
	{
		[YamlAlias("m_AmbientLight")]
		public /* static */ Color ambientLight { get; set; }

		[YamlAlias("m_FlareFadeSpeed")]
		public /* static */ float flareFadeSpeed { get; set; }

		[YamlAlias("m_FlareStrength")]
		public /* static */ float flareStrength { get; set; }

		[YamlAlias("m_Fog")]
		public /* static */ bool fog { get; set; }

		[YamlAlias("m_FogColor")]
		public /* static */ Color fogColor { get; set; }

		[YamlAlias("m_FogDensity")]
		public /* static */ float fogDensity { get; set; }

		[YamlAlias("m_LinearFogEnd")]
		public /* static */ float fogEndDistance { get; set; }

		[YamlAlias("m_FogMode")]
		public /* static */ FogMode fogMode { get; set; }

		[YamlAlias("m_LinearFogStart")]
		public /* static */ float fogStartDistance { get; set; }

		[YamlAlias("m_HaloStrength")]
		public /* static */ float haloStrength { get; set; }

		// [YamlAlias("m_SkyboxMaterial")]
		public /* static */ Material skybox { get; set; }
	}

	[Serializable]
	public enum ColorSpace
	{
		Uninitialized,
		Gamma,
		Linear
	}

	public class LightmapData {
		// public LightmapData ();

		// public Texture2D lightmap { get; set; }
		// public Texture2D lightmapFar { get; set; }
		// public Texture2D lightmapNear { get; set; }
	}

	[Serializable]
	public enum LightmapsMode {
		Single,
		Dual,
		Directional
	}

	public class LightmapSettings: Object
	{
		[YamlAlias("m_BakedColorSpace")]
		public /* static */ ColorSpace bakedColorSpace { get; set; }

		[YamlAlias("m_Lightmaps")]
		public /* static */ LightmapData[] lightmaps { get; set; }

		[YamlAlias("m_LightmapsMode")]
		public /* static */ LightmapsMode lightmapsMode { get; set; }

		// public static LightProbes lightProbes { get; set; }
	}
}
