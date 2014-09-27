//------------------------------------------------------------------------------
// LightProbeGroup.cs
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
	public sealed class LightProbeGroup : Component
	{
		// public LightProbeGroup ();
		
		[YamlAlias("m_SourcePositions")]
		public Vector3[] probePositions { get; set; }
	}
}
