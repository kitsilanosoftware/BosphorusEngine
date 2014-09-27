//------------------------------------------------------------------------------
// ParticleSystemRenderer.cs
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
	public sealed class ParticleSystemRenderer : Renderer
	{
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
}