//------------------------------------------------------------------------------
// Object.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace UnityEngine
{
	public class Object
	{
		public static void Destroy(Object obj)
		{
		}
		
		public static void Destroy(Object obj, float t)
		{
		}

		public void SetSerializationAnchor(int anchor)
		{
			yamlSerializationAnchor = anchor;
			dictionaryOfObjects[yamlSerializationAnchor] = this;
		}

		public Object FindObjectBySerializationAnchor(int anchor)
		{
			return dictionaryOfObjects[anchor];
		}

		public virtual void ResolveSerializationReferences()
		{
		}
		
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
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			return null;
		}
		// public override bool Equals (object o);
		// public override int GetHashCode ();
		// public int GetInstanceID ();
		// public override string ToString ();
		
		// public static implicit operator bool (Object exists);
		// public static bool operator == (Object x, Object y);
		// public static bool operator != (Object x, Object y);

		/// <summary>
		/// A dictionary mapping unique IDs to Object instances;
		/// </summary>
		static Dictionary<int, Object> dictionaryOfObjects = new Dictionary<int, Object>();

		[YamlAlias("m_ObjectHideFlags")]
		public HideFlags hideFlags { get; set; }
		
		[YamlAlias("m_Name")]
		public string name { get; set; }

		/// <summary>
		/// Serialization anchor (AKA unique ID) for this object within the
		/// YAML scene.   Just going to stuff this directly into the object
		/// itself for the time being.  We can do a second pass in the deserialization
		/// to resolve these into object references.
		/// </summary>
		public int yamlSerializationAnchor { get; set; }
	}
}