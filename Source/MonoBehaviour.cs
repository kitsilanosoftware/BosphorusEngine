//------------------------------------------------------------------------------
// MonoBehaviour.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public class MonoBehaviour : Behaviour
	{
		// public MonoBehaviour ();
		
		// public static void print (object message);
		// public void CancelInvoke ();
		// public void CancelInvoke (string methodName);
		// public void Invoke (string methodName, float time);
		public void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}
		
		// public bool IsInvoking ();
		// public bool IsInvoking (string methodName);
		
		public Coroutine StartCoroutine(System.Collections.IEnumerator routine)
		{
			return null;
		}
		
		public Coroutine StartCoroutine(string methodName)
		{
			return null;
		}
		
		public Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}
		
		// public Coroutine StartCoroutine_Auto (System.Collections.IEnumerator routine);
		// public void StopAllCoroutines ();
		// public void StopCoroutine (System.Collections.IEnumerator routine);
		// public void StopCoroutine (string methodName);
		
		// public bool useGUILayout { get; set; }
	}
}