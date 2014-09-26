//------------------------------------------------------------------------------
// AudioSource.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{
	public class AudioSource : Behaviour
	{
		public AudioClip clip;
		public bool isPlaying;
		
		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume = 1.0f)
		{
		}
		
		public void Play(ulong delay = 0)
		{
		}
	}
}