//------------------------------------------------------------------------------
// ParticleSystem.cs
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
	public sealed class ParticleSystem : Component
	{
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
		public void Play(bool withChildren = true)
		{
		}
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

}