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
	public class SceneSettings : Object
	{
		//m_PVSData: 
		//m_PVSObjectsArray: []
		//m_PVSPortalsArray: []

		[YamlAlias("m_OcclusionBakeSettings")]
		public OcclusionBakeSettings occlusionBakeSettings;
	}
}