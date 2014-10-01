//------------------------------------------------------------------------------
// LightmapSettings.cs
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
	public class LightmapSettings : Object
	{
		[YamlAlias("m_BakedColorSpace")]
		public /* static */ ColorSpace bakedColorSpace { get; set; }
		
		[YamlAlias("m_Lightmaps")]
		public /* static */ LightmapData[] lightmaps { get; set; }
		
		[YamlAlias("m_LightmapsMode")]
		public /* static */ LightmapsMode lightmapsMode { get; set; }

		[YamlAlias("m_UseDualLightmapsInForward")]
		public /* static */ bool useDualLightmapsInForward { get; set; }

		[YamlAlias("m_LightProbes")]
		public ComponentReference lightProbes { get; set; }
	}
}