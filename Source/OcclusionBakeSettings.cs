//------------------------------------------------------------------------------
// OcclusionBakeSettings.cs
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
	public struct OcclusionBakeSettings
	{
		public int smallestOccluder;
		public float smallestHole;
		public int backfaceThreshold;
	}
}