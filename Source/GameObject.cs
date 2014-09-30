//------------------------------------------------------------------------------
// GameObject.cs
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
	public sealed class GameObject : Object
	{
		// public GameObject (string name);
		// public GameObject ();
		// public GameObject (string name, params Type [] components);
		
		// public static GameObject CreatePrimitive (PrimitiveType type);
		public static GameObject Find(string name)
		{
			return null;
		}
		// public static GameObject[] FindGameObjectsWithTag (string tag);
		public static GameObject FindGameObjectWithTag(string tag)
		{
			return null;
		}
		// public static GameObject FindWithTag (string tag);
		
		public T AddComponent<T>() where T : Component
		{
			return default(T);
		}
		
		// public Component AddComponent (string className);
		// public Component AddComponent (Type componentType);
		// public void BroadcastMessage (string methodName);
		// public void BroadcastMessage (string methodName, object parameter);
		// public void BroadcastMessage (string methodName, object parameter, SendMessageOptions options);
		// public void BroadcastMessage (string methodName, SendMessageOptions options);
		// public bool CompareTag (string tag);
		public T GetComponent<T>() where T : Component
		{
			return default(T);
		}
		
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
		public void SetActive(bool value)
		{
			activeSelf = value;
		}
		// public void SetActiveRecursively (bool state);
		// public void StopAnimation ();
		
		public static implicit operator bool(GameObject obj)
		{
			return false;
		}
		
		[YamlAlias("m_IsActive")]
		public bool active { get; set; }

		// public bool activeInHierarchy { get; }
		public bool activeSelf { get; set; }
		// public Animation animation { get; }
		// public AudioSource audio { get; }
		// public Camera camera { get; }
		// public Collider collider { get; }
		// public Collider2D collider2D { get; }
		// public ConstantForce constantForce { get; }
		// public GameObject gameObject { get; }
		// public GUIElement guiElement { get; }
		public GUIText guiText;
		public GUITexture guiTexture;
		// public HingeJoint hingeJoint { get; }
		
		// Not a direct mapping.
		// [YamlAlias("m_StaticEditorFlags")]
		// public bool isStatic { get; set; } // 0 or 0xFFFFFFFF
		
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
		
		public Transform transform;
	}
	

}