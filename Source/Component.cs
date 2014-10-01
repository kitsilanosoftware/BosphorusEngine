//------------------------------------------------------------------------------
// Component.cs
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
	public class Component : Object
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
		
		public T GetComponent<T>()
		{
			return default(T);
		}
		
		public T[] GetComponentsInChildren<T>() where T : Component
		{
			return default(T[]);
		}
		
		// public Component GetComponentInChildren (Type t);
		public T GetComponentInChildren<T>() where T : Component
		{
			return default(T);
		}
		
		// public Component GetComponentInParent (Type t);
		public T[] GetComponents<T>() where T : Component
		{
			return default(T[]);
		}
		
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
		public AudioSource audio { get; set; }
		// public Camera camera { get; }
		// public Collider collider { get; }
		// public Collider2D collider2D { get; }
		// public ConstantForce constantForce { get; }

		[YamlAlias("m_PrefabParentObject")]
		public ComponentReference prefabParentObject { get; set; }

		[YamlAlias("m_PrefabInternal")]
		public ComponentReference prefabInternal { get; set; }

		[YamlAlias("m_GameObject")]
		public ComponentReference gameObject { get; set; }

		// public GUIElement guiElement { get; }
		public GUIText guiText { get; set; }
		// public GUITexture guiTexture { get; }
		// public HingeJoint hingeJoint { get; }
		// public Light light { get; }
		// public NetworkView networkView { get; }
		// public ParticleEmitter particleEmitter { get; }
		public ParticleSystem particleSystem { get; set; }
		public Renderer renderer { get; set; }
		// public Rigidbody rigidbody { get; }
		public Rigidbody2D rigidbody2D { get; set; }
		
		public string tag { get; set; }
		
		public Transform transform { get; set; }
	}
}