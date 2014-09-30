//------------------------------------------------------------------------------
// SceneSettings.cs
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
	/// <summary>
	/// SceneSettings is always listed in .unity scene files, but is not
	/// exposed in the public API.  It appears to be entirely related to
	/// the Unity Pro only Occlusion Culling feature.
	/// See http://docs.unity3d.com/Manual/OcclusionCulling.html
	/// </summary>
	public class SceneSettings : Object
	{
		//m_PVSData:
		//m_PVSObjectsArray: []
		//m_PVSPortalsArray: []

		[YamlAlias("m_OcclusionBakeSettings")]
		public OcclusionBakeSettings occlusionBakeSettings;
	}
}