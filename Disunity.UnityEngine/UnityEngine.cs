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

		[YamlAlias("m_ObjectHideFlags")]
		public HideFlags hideFlags { get; set; }

		[YamlAlias("m_Name")]
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

		// public Color color { get; set; }
		// public Texture mainTexture { get; set; }
		// public Vector2 mainTextureOffset { get; set; }
		// public Vector2 mainTextureScale { get; set; }
		// public int passCount { get; private set; }
		// public int renderQueue { get; set; }
		// public Shader shader { get; set; }
		// public string [] shaderKeywords { get; set; }
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

		// YAML: Direct mapping.
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

		// TODO: fileID mapping.
		// [YamlAlias("m_SkyboxMaterial")]
		// public /* static */ Material skybox { get; set; }
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

	public sealed class GameObject: Object
	{
		// public GameObject (string name);
		// public GameObject ();
		// public GameObject (string name, params Type [] components);

		// public static GameObject CreatePrimitive (PrimitiveType type);
		// public static GameObject Find (string name);
		// public static GameObject[] FindGameObjectsWithTag (string tag);
		// public static GameObject FindGameObjectWithTag (string tag);
		// public static GameObject FindWithTag (string tag);
		// public T AddComponent<T> () where T : Component;
		// public Component AddComponent (string className);
		// public Component AddComponent (Type componentType);
		// public void BroadcastMessage (string methodName);
		// public void BroadcastMessage (string methodName, object parameter);
		// public void BroadcastMessage (string methodName, object parameter, SendMessageOptions options);
		// public void BroadcastMessage (string methodName, SendMessageOptions options);
		// public bool CompareTag (string tag);
		// public T GetComponent<T> () where T : Component;
		// public Component GetComponent (string type);
		// public Component GetComponent (Type type);
		// public T GetComponentInChildren<T> () where T : Component;
		// public Component GetComponentInChildren (Type type);
		// public T GetComponentInParent<T> () where T : Component;
		// public Component GetComponentInParent (Type type);
		// public T[] GetComponents<T> () where T : Component;
		// public Component[] GetComponents (Type type);
		// public T[] GetComponentsInChildren<T> () where T : Component;
		// public T[] GetComponentsInChildren<T> (bool includeInactive) where T : Component;
		// public Component[] GetComponentsInChildren (Type type);
		// public Component[] GetComponentsInChildren (Type type, bool includeInactive);
		// public T[] GetComponentsInParent<T> () where T : Component;
		// public T[] GetComponentsInParent<T> (bool includeInactive) where T : Component;
		// public Component[] GetComponentsInParent (Type type);
		// public Component[] GetComponentsInParent (Type type, bool includeInactive);
		// public void PlayAnimation (AnimationClip animation);
		// public void SampleAnimation (AnimationClip animation, float time);
		// public void SendMessage (string methodName);
		// public void SendMessage (string methodName, object value);
		// public void SendMessage (string methodName, object value, SendMessageOptions options);
		// public void SendMessage (string methodName, SendMessageOptions options);
		// public void SendMessageUpwards (string methodName);
		// public void SendMessageUpwards (string methodName, object value);
		// public void SendMessageUpwards (string methodName, object value, SendMessageOptions options);
		// public void SendMessageUpwards (string methodName, SendMessageOptions options);
		// public void SetActive (bool value);
		// public void SetActiveRecursively (bool state);
		// public void StopAnimation ();

		[YamlAlias("m_IsActive")]
		public bool active { get; set; }

		// public bool activeInHierarchy { get; }
		// public bool activeSelf { get; }
		// public Animation animation { get; }
		// public AudioSource audio { get; }
		// public Camera camera { get; }
		// public Collider collider { get; }
		// public Collider2D collider2D { get; }
		// public ConstantForce constantForce { get; }
		// public GameObject gameObject { get; }
		// public GUIElement guiElement { get; }
		// public GUIText guiText { get; }
		// public GUITexture guiTexture { get; }
		// public HingeJoint hingeJoint { get; }

		// Not a direct mapping.
		// [YamlAlias("m_StaticEditorFlags")]
		// public bool isStatic { get; set; }

		[YamlAlias("m_Layer")]
		public int layer { get; set; }

		// public Light light { get; }
		// public NetworkView networkView { get; }
		// public ParticleEmitter particleEmitter { get; }
		// public ParticleSystem particleSystem { get; }
		// public Renderer renderer { get; }
		// public Rigidbody rigidbody { get; }
		// public Rigidbody2D rigidbody2D { get; }

		[YamlAlias("m_TagString")]
		public string tag { get; set; }

		// public Transform transform { get; }
	}

	public class Component: Object
	{
		// public Component ();

		// public void BroadcastMessage (string methodName);
		// public void BroadcastMessage (string methodName, object parameter);
		// public void BroadcastMessage (string methodName, object parameter, SendMessageOptions options);
		// public void BroadcastMessage (string methodName, SendMessageOptions options);
		// public bool CompareTag (string tag);
		// public T GetComponent<T> () where T : Component;
		// public Component GetComponent (string type);
		// public Component GetComponent (Type type);
		// public T GetComponentInChildren<T> () where T : Component;
		// public Component GetComponentInChildren (Type t);
		// public T GetComponentInParent<T> () where T : Component;
		// public Component GetComponentInParent (Type t);
		// public T[] GetComponents<T> () where T : Component;
		// public Component[] GetComponents (Type type);
		// public T[] GetComponentsInChildren<T> () where T : Component;
		// public T[] GetComponentsInChildren<T> (bool includeInactive) where T : Component;
		// public Component[] GetComponentsInChildren (Type t);
		// public Component[] GetComponentsInChildren (Type t, bool includeInactive);
		// public T[] GetComponentsInParent<T> () where T : Component;
		// public T[] GetComponentsInParent<T> (bool includeInactive) where T : Component;
		// public Component[] GetComponentsInParent (Type t);
		// public Component[] GetComponentsInParent (Type t, bool includeInactive);
		// public void SendMessage (string methodName);
		// public void SendMessage (string methodName, object value);
		// public void SendMessage (string methodName, object value, SendMessageOptions options);
		// public void SendMessage (string methodName, SendMessageOptions options);
		// public void SendMessageUpwards (string methodName);
		// public void SendMessageUpwards (string methodName, object value);
		// public void SendMessageUpwards (string methodName, object value, SendMessageOptions options);
		// public void SendMessageUpwards (string methodName, SendMessageOptions options);

		// public bool active { get; set; }

		// public Animation animation { get; }
		// public AudioSource audio { get; }
		// public Camera camera { get; }
		// public Collider collider { get; }
		// public Collider2D collider2D { get; }
		// public ConstantForce constantForce { get; }
		// public GameObject gameObject { get; }
		// public GUIElement guiElement { get; }
		// public GUIText guiText { get; }
		// public GUITexture guiTexture { get; }
		// public HingeJoint hingeJoint { get; }
		// public Light light { get; }
		// public NetworkView networkView { get; }
		// public ParticleEmitter particleEmitter { get; }
		// public ParticleSystem particleSystem { get; }
		// public Renderer renderer { get; }
		// public Rigidbody rigidbody { get; }
		// public Rigidbody2D rigidbody2D { get; }

		// public string tag { get; set; }

		// public Transform transform { get; }
	}

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

		// public static Vector3 operator + (Vector3 a, Vector3 b);
		// public static Vector3 operator - (Vector3 a, Vector3 b);
		// public static Vector3 operator - (Vector3 a);
		// public static Vector3 operator * (Vector3 a, float d);
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
		// public static Vector3 up {
		//	get;
		// }
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
		// public Vector3 normalized {
		//	get;
		// }
		// public float sqrMagnitude {
		//	get;
		// }

		public const float kEpsilon = 1E-05f;

		// YAML: Direct mapping.
		public float x;
		public float y;
		public float z;
	}

	public struct Quaternion {

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
		// public static Quaternion Euler (float x, float y, float z);
		// public static Quaternion Euler (Vector3 euler);
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

	public sealed class Transform: Component
		// System.Collections.IEnumerable
	{
		// public void DetachChildren ();
		// public Transform Find (string name);
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

		// public Matrix4x4 localToWorldMatrix { get; }
		// public Vector3 lossyScale { get; }
		// public Transform parent { get; set; }
		// public Vector3 position { get; set; }
		// public Vector3 right { get; set; }
		// public Transform root { get; }
		// public Quaternion rotation { get; set; }
		// public Vector3 up { get; set; }
		// public Matrix4x4 worldToLocalMatrix { get; }
	}

	public struct Vector4
	{
		// public Vector4 (float x, float y, float z, float w);
		// public Vector4 (float x, float y, float z);
		// public Vector4 (float x, float y);

		// public static float Distance (Vector4 a, Vector4 b);
		// public static float Dot (Vector4 a, Vector4 b);
		// public static Vector4 Lerp (Vector4 from, Vector4 to, float t);
		// public static float Magnitude (Vector4 a);
		// public static Vector4 Max (Vector4 lhs, Vector4 rhs);
		// public static Vector4 Min (Vector4 lhs, Vector4 rhs);
		// public static Vector4 MoveTowards (Vector4 current, Vector4 target, float maxDistanceDelta);
		// public static Vector4 Normalize (Vector4 a);
		// public static Vector4 Project (Vector4 a, Vector4 b);
		// public static Vector4 Scale (Vector4 a, Vector4 b);
		// public static float SqrMagnitude (Vector4 a);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Normalize ();
		// public void Scale (Vector4 scale);
		// public void Set (float new_x, float new_y, float new_z, float new_w);
		// public float SqrMagnitude ();
		// public override string ToString ();
		// public string ToString (string format);

		// public static Vector4 operator + (Vector4 a, Vector4 b);
		// public static Vector4 operator - (Vector4 a, Vector4 b);
		// public static Vector4 operator - (Vector4 a);
		// public static Vector4 operator * (Vector4 a, float d);
		// public static Vector4 operator * (float d, Vector4 a);
		// public static Vector4 operator / (Vector4 a, float d);
		// public static bool operator == (Vector4 lhs, Vector4 rhs);
		// public static bool operator != (Vector4 lhs, Vector4 rhs);
		// public static implicit operator Vector4 (Vector3 v);
		// public static implicit operator Vector3 (Vector4 v);
		// public static implicit operator Vector4 (Vector2 v);
		// public static implicit operator Vector2 (Vector4 v);

		// public static Vector4 one {
		//	get;
		// }
		// public static Vector4 zero {
		//	get;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		// public float magnitude {
		//	get;
		// }
		// public Vector4 normalized {
		//	get;
		// }
		// public float sqrMagnitude {
		//	get;
		// }

		public const float kEpsilon = 1E-05f;

		// YAML: Direct mapping.
		public float x;
		public float y;
		public float z;
		public float w;
	}

	public class Renderer: Component {

		// public void GetPropertyBlock (MaterialPropertyBlock dest);
		// public void Render (int material);
		// public void SetPropertyBlock (MaterialPropertyBlock properties);

		// public Bounds bounds { get; }

		[YamlAlias("m_CastShadows")]
		public bool castShadows { get; set; }

		[YamlAlias("m_Enabled")]
		public bool enabled { get; set; }

		// public bool isPartOfStaticBatch { get; }
		// public bool isVisible { get; }

		[YamlAlias("m_LightmapIndex")]
		public int lightmapIndex { get; set; }

		[YamlAlias("m_LightmapTilingOffset")]
		public Vector4 lightmapTilingOffset { get; set; }

		// TODO: Exception, Key name fileID does not match Transform.
		// [YamlAlias("m_LightProbeAnchor")]
		// public Transform lightProbeAnchor { get; set; }

		// public Matrix4x4 localToWorldMatrix { get; }
		// public Material material { get; set; }

		// TODO: Exception, Key name fileID does not match Material.
		// [YamlAlias("m_Materials")]
		// public Material[] materials { get; set; }

		[YamlAlias("m_ReceiveShadows")]
		public bool receiveShadows { get; set; }

		// public Material sharedMaterial { get; set; }
		// public Material[] sharedMaterials { get; set; }

		[YamlAlias("m_SortingLayerID")]
		public int sortingLayerID { get; set; }

		// public string sortingLayerName { get; set; }

		[YamlAlias("m_SortingOrder")]
		public int sortingOrder { get; set; }

		[YamlAlias("m_UseLightProbes")]
		public bool useLightProbes { get; set; }

		// public Matrix4x4 worldToLocalMatrix { get; }
	}

	public sealed class MeshFilter: Component
	{
		// [YamlAlias("m_Mesh")]
		// public Mesh mesh { get; set; }

		// public Mesh sharedMesh { get; set; }
	}

	[Serializable]
	public enum ParticleSystemRenderMode {
		Billboard,
		Stretch,
		HorizontalBillboard,
		VerticalBillboard,
		Mesh
	}

	public sealed class ParticleSystemRenderer: Renderer {
		[YamlAlias("m_CameraVelocityScale")]
		public float cameraVelocityScale { get; set; }

		[YamlAlias("m_LengthScale")]
		public float lengthScale { get; set; }

		[YamlAlias("m_MaxParticleSize")]
		public float maxParticleSize { get; set; }

		// [YamlAlias("m_Mesh")]
		// public Mesh mesh { get; set; }

		[YamlAlias("m_RenderMode")]
		public ParticleSystemRenderMode renderMode { get; set; }

		[YamlAlias("m_VelocityScale")]
		public float velocityScale { get; set; }
	}

	public sealed class ParticleSystem: Component {

		// public ParticleSystem ();

		// public void Clear ();
		// public void Clear (bool withChildren);
		// public void Emit (int count);
		// public void Emit (Particle particle);
		// public void Emit (Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color);
		// public int GetCollisionEvents (GameObject go, CollisionEvent[] collisionEvents);
		// public int GetParticles (Particle[] particles);
		// public bool IsAlive ();
		// public bool IsAlive (bool withChildren);
		// public void Pause ();
		// public void Pause (bool withChildren);
		// public void Play ();
		// public void Play (bool withChildren);
		// public void SetParticles (Particle[] particles, int size);
		// public void Simulate (float t);
		// public void Simulate (float t, bool withChildren);
		// public void Simulate (float t, bool withChildren, bool restart);
		// public void Stop ();
		// public void Stop (bool withChildren);

		// public float duration { get; }
		// public float emissionRate { get; set; }
		// public bool enableEmission { get; set; }
		// public float gravityModifier { get; set; }
		// public bool isPaused { get; }
		// public bool isPlaying { get; }
		// public bool isStopped { get; }

		[YamlAlias("looping")]
		public bool loop { get; set; }

		// public int maxParticles { get; set; }
		// public int particleCount { get; }
		// public float playbackSpeed { get; set; }

		// YAML: Direct mapping.
		public bool playOnAwake { get; set; }
		public uint randomSeed { get; set; }

		// public int safeCollisionEventSize { get; }
		// public ParticleSystemSimulationSpace simulationSpace { get; set; }
		// public Color startColor { get; set; }

		// YAML: Direct mapping.
		public float startDelay { get; set; }

		// public float startLifetime { get; set; }
		// public float startRotation { get; set; }
		// public float startSize { get; set; }
		// public float startSpeed { get; set; }
		// public float time { get; set; }

		public struct CollisionEvent
		{
			// TODO
		}
		public struct Particle
		{
			// TODO
		}
	}

	public class Behaviour: Component {
		[YamlAlias("m_Enabled")]
		public bool enabled { get; set; }
	}

	public struct Vector2 {

		// public Vector2 (float x, float y);

		// public static float Angle (Vector2 from, Vector2 to);
		// public static Vector2 ClampMagnitude (Vector2 vector, float maxLength);
		// public static float Distance (Vector2 a, Vector2 b);
		// public static float Dot (Vector2 lhs, Vector2 rhs);
		// public static Vector2 Lerp (Vector2 from, Vector2 to, float t);
		// public static Vector2 Max (Vector2 lhs, Vector2 rhs);
		// public static Vector2 Min (Vector2 lhs, Vector2 rhs);
		// public static Vector2 MoveTowards (Vector2 current, Vector2 target, float maxDistanceDelta);
		// public static Vector2 Scale (Vector2 a, Vector2 b);
		// public static float SqrMagnitude (Vector2 a);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Normalize ();
		// public void Scale (Vector2 scale);
		// public void Set (float new_x, float new_y);
		// public float SqrMagnitude ();
		// public override string ToString ();
		// public string ToString (string format);

		// public static Vector2 operator + (Vector2 a, Vector2 b);
		// public static Vector2 operator - (Vector2 a, Vector2 b);
		// public static Vector2 operator - (Vector2 a);
		// public static Vector2 operator * (Vector2 a, float d);
		// public static Vector2 operator * (float d, Vector2 a);
		// public static Vector2 operator / (Vector2 a, float d);
		// public static bool operator == (Vector2 lhs, Vector2 rhs);
		// public static bool operator != (Vector2 lhs, Vector2 rhs);
		// public static implicit operator Vector2 (Vector3 v);
		// public static implicit operator Vector3 (Vector2 v);

		// public static Vector2 one {
		//	get;
		// }
		// public static Vector2 right {
		//	get;
		// }
		// public static Vector2 up {
		//	get;
		// }
		// public static Vector2 zero {
		//	get;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		// public float magnitude {
		//	get;
		// }
		// public Vector2 normalized {
		//	get;
		// }
		// public float sqrMagnitude {
		//	get;
		// }

		public const float kEpsilon = 1E-05f;

		// YAML: Direct mapping.
		public float x;
		public float y;
	}

	[Serializable]
	public enum LightRenderMode {
		Auto,
		ForcePixel,
		ForceVertex
	}

	[Serializable]
	public enum LightShadows {
		None,
		Hard,
		Soft
	}

	[Serializable]
	public enum LightType {
		Spot,
		Directional,
		Point,
		Area
	}

	public sealed class Light: Behaviour {

		// public Light ();

		// public static Light[] GetLights (LightType type, int layer);

		// public static int pixelLightCount { get; set; }

		[YamlAlias("m_ActuallyLightmapped")]
		public bool alreadyLightmapped { get; set; }

		[YamlAlias("m_AreaSize")]
		public Vector2 areaSize { get; set; }

		// public bool attenuate { get; set; }

		[YamlAlias("m_Color")]
		public Color color { get; set; }

		// TODO: type, fileID mapping.
		// [YamlAlias("m_Cookie")]
		// public Texture cookie { get; set; }

		[YamlAlias("m_CookieSize")]
		public float cookieSize { get; set; }

		// TODO: Indirect mapping.
		// [YamlAlias("m_CullingMask")]
		// public int cullingMask { get; set; }

		// TODO: type, fileID mapping.
		// [YamlAlias("m_Flare")]
		// public Flare flare { get; set; }

		[YamlAlias("m_Intensity")]
		public float intensity { get; set; }

		[YamlAlias("m_Range")]
		public float range { get; set; }

		[YamlAlias("m_RenderMode")]
		public LightRenderMode renderMode { get; set; }

		// public float shadowBias { get; set; }
		// public float shadowConstantBias { get; set; }
		// public float shadowObjectSizeBias { get; set; }

		[YamlAlias("m_Shadows")]
		public LightShadows shadows { get; set; }

		// public float shadowSoftness { get; set; }
		// public float shadowSoftnessFade { get; set; }
		// public float shadowStrength { get; set; }

		[YamlAlias("m_SpotAngle")]
		public float spotAngle { get; set; }

		[YamlAlias("m_Type")]
		public LightType type { get; set; }
	}

	[Serializable]
	public enum AnimationCullingType {
		AlwaysAnimate,
		BasedOnRenderers,
		BasedOnClipBounds,
		BasedOnUserBounds
	}

	[Serializable]
	public enum WrapMode {
		Once = 1,
		Loop = 2,
		PingPong = 4,
		Default = 0,
		ClampForever = 8,
		Clamp = 1
	}

	public sealed class Animation: Behaviour
	// , System.Collections.IEnumerable
	{

		// public Animation ();

		// public void AddClip (AnimationClip clip, string newName);
		// public void AddClip (AnimationClip clip, string newName, int firstFrame, int lastFrame);
		// public void AddClip (AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame);
		// public void Blend (string animation);
		// public void Blend (string animation, float targetWeight);
		// public void Blend (string animation, float targetWeight, float fadeLength);
		// public void CrossFade (string animation);
		// public void CrossFade (string animation, float fadeLength);
		// public void CrossFade (string animation, float fadeLength, PlayMode mode);
		// public AnimationState CrossFadeQueued (string animation);
		// public AnimationState CrossFadeQueued (string animation, float fadeLength);
		// public AnimationState CrossFadeQueued (string animation, float fadeLength, QueueMode queue);
		// public AnimationState CrossFadeQueued (string animation, float fadeLength, QueueMode queue, PlayMode mode);
		// public AnimationClip GetClip (string name);
		// public int GetClipCount ();
		// public System.Collections.IEnumerator GetEnumerator ();
		// public bool IsPlaying (string name);
		// public bool Play ();
		// public bool Play (AnimationPlayMode mode);
		// public bool Play (PlayMode mode);
		// public bool Play (string animation);
		// public bool Play (string animation, AnimationPlayMode mode);
		// public bool Play (string animation, PlayMode mode);
		// public AnimationState PlayQueued (string animation);
		// public AnimationState PlayQueued (string animation, QueueMode queue);
		// public AnimationState PlayQueued (string animation, QueueMode queue, PlayMode mode);
		// public void RemoveClip (AnimationClip clip);
		// public void RemoveClip (string clipName);
		// public void Rewind ();
		// public void Rewind (string name);
		// public void Sample ();
		// public void Stop ();
		// public void Stop (string name);
		// public void SyncLayer (int layer);

		// public bool animateOnlyIfVisible { get; set; }

		[YamlAlias("m_AnimatePhysics")]
		public bool animatePhysics { get; set; }

		// [YamlAlias("m_Animation")]
		// public AnimationClip clip { get; set; }

		[YamlAlias("m_CullingType")]
		public AnimationCullingType cullingType { get; set; }

		// public bool isPlaying { get; }
		// public AnimationState this [string name] { get; }
		// public Bounds localBounds { get; set; }

		[YamlAlias("m_PlayAutomatically")]
		public bool playAutomatically { get; set; }

		[YamlAlias("m_WrapMode")]
		public WrapMode wrapMode { get; set; }
	}

	public class MonoBehaviour: Behaviour
	{
		// public MonoBehaviour ();

		// public static void print (object message);
		// public void CancelInvoke ();
		// public void CancelInvoke (string methodName);
		// public void Invoke (string methodName, float time);
		// public void InvokeRepeating (string methodName, float time, float repeatRate);
		// public bool IsInvoking ();
		// public bool IsInvoking (string methodName);
		// public Coroutine StartCoroutine (System.Collections.IEnumerator routine);
		// public Coroutine StartCoroutine (string methodName);
		// public Coroutine StartCoroutine (string methodName, object value);
		// public Coroutine StartCoroutine_Auto (System.Collections.IEnumerator routine);
		// public void StopAllCoroutines ();
		// public void StopCoroutine (System.Collections.IEnumerator routine);
		// public void StopCoroutine (string methodName);

		// public bool useGUILayout { get; set; }
	}

	public sealed class LightProbeGroup: Component
	{
		// public LightProbeGroup ();

		[YamlAlias("m_SourcePositions")]
		public Vector3[] probePositions { get; set; }
	}

	[Serializable]
	public enum CameraClearFlags
	{
		Skybox = 1,
		Color = 2,
		SolidColor = 2,
		Depth = 3,
		Nothing = 4
	}

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

	[Serializable]
	public enum RenderingPath {
		UsePlayerSettings = -1,
		VertexLit = 0,
		Forward,
		DeferredLighting
	}

	public sealed class Camera: Behaviour
	{
		// public Camera ();

		// public static int GetAllCameras (Camera[] cameras);
		// public static void SetupCurrent (Camera cur);
		// public Matrix4x4 CalculateObliqueMatrix (Vector4 clipPlane);
		// public void CopyFrom (Camera other);
		// public void DoClear ();
		// public float GetScreenHeight ();
		// public float GetScreenWidth ();
		// public void Render ();
		// public void RenderDontRestore ();
		// public bool RenderToCubemap (Cubemap cubemap);
		// public bool RenderToCubemap (Cubemap cubemap, int faceMask);
		// public bool RenderToCubemap (RenderTexture cubemap);
		// public bool RenderToCubemap (RenderTexture cubemap, int faceMask);
		// public void RenderWithShader (Shader shader, string replacementTag);
		// public void ResetAspect ();
		// public void ResetProjectionMatrix ();
		// public void ResetReplacementShader ();
		// public void ResetWorldToCameraMatrix ();
		// public Ray ScreenPointToRay (Vector3 position);
		// public Vector3 ScreenToViewportPoint (Vector3 position);
		// public Vector3 ScreenToWorldPoint (Vector3 position);
		// public void SetReplacementShader (Shader shader, string replacementTag);
		// public void SetTargetBuffers (RenderBuffer colorBuffer, RenderBuffer depthBuffer);
		// public void SetTargetBuffers (RenderBuffer[] colorBuffer, RenderBuffer depthBuffer);
		// public Ray ViewportPointToRay (Vector3 position);
		// public Vector3 ViewportToScreenPoint (Vector3 position);
		// public Vector3 ViewportToWorldPoint (Vector3 position);
		// public Vector3 WorldToScreenPoint (Vector3 position);
		// public Vector3 WorldToViewportPoint (Vector3 position);

		// public static Camera[] allCameras { get; }
		// public static int allCamerasCount { get; }
		// public static Camera current { get; }
		// public static Camera main { get; }
		// public static Camera mainCamera { get; }
		// public RenderingPath actualRenderingPath { get; }
		// public float aspect { get; set; }

		[YamlAlias("m_BackGroundColor")]
		public Color backgroundColor { get; set; }

		// public Matrix4x4 cameraToWorldMatrix { get; }

		[YamlAlias("m_ClearFlags")]
		public CameraClearFlags clearFlags { get; set; }

		// public bool clearStencilAfterLightingPass { get; set; }

		// TODO: Indirect mapping.
		// [YamlAlias("m_CullingMask")]
		// public int cullingMask { get; set; }

		[YamlAlias("m_Depth")]
		public float depth { get; set; }

		// public DepthTextureMode depthTextureMode { get; set; }
		// public int eventMask { get; set; }
		// public float far { get; set; }

		[YamlAlias("far clip plane")]
		public float farClipPlane { get; set; }

		[YamlAlias("field of view")]
		public float fieldOfView { get; set; }

		// public float fov { get; set; }

		[YamlAlias("m_HDR")]
		public bool hdr { get; set; }

		// public bool isOrthoGraphic { get; set; }
		// public float [] layerCullDistances { get; set; }
		// public bool layerCullSpherical { get; set; }
		// public float near { get; set; }

		[YamlAlias("near clip plane")]
		public float nearClipPlane { get; set; }

		// YAML: Direct mapping.
		public bool orthographic { get; set; }

		[YamlAlias("orthographic size")]
		public float orthographicSize { get; set; }

		// public float pixelHeight { get; }
		// public Rect pixelRect { get; set; }
		// public float pixelWidth { get; }
		// public Matrix4x4 projectionMatrix { get; set; }

		// TODO: Verify.
		[YamlAlias("m_NormalizedViewPortRect")]
		public Rect rect { get; set; }

		[YamlAlias("m_RenderingPath")]
		public RenderingPath renderingPath { get; set; }

		[YamlAlias("m_StereoConvergence")]
		public float stereoConvergence { get; set; }

		// public bool stereoEnabled { get; }

		[YamlAlias("m_StereoSeparation")]
		public float stereoSeparation { get; set; }

		// TODO: type, fileID mapping.
		// [YamlAlias("m_TargetTexture")]
		// public RenderTexture targetTexture { get; set; }

		// public TransparencySortMode transparencySortMode { get; set; }

		[YamlAlias("m_OcclusionCulling")]
		public bool useOcclusionCulling { get; set; }

		// public Vector3 velocity { get; }
		// public Matrix4x4 worldToCameraMatrix { get; set; }
	}

	public sealed class AudioListener: Behaviour
	{
		// public AudioListener ();

		// public static float [] GetOutputData (int numSamples, int channel);
		// public static void GetOutputData (float [] samples, int channel);
		// public static float [] GetSpectrumData (int numSamples, int channel, FFTWindow window);
		// public static void GetSpectrumData (float [] samples, int channel, FFTWindow window);

		// public static bool pause { get; set; }
		// public static float volume { get; set; }
		// public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	}

	public class Collider: Component
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

	public sealed class MeshCollider: Collider
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
