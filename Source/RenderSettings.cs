//------------------------------------------------------------------------------
// RenderSettings.cs
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
	public class RenderSettings : Object
	{
		[YamlAlias("m_AmbientLight")]
		public /* static */ Color ambientLight { get; set; }
		
		[YamlAlias("m_FlareFadeSpeed")]
		public /* static */ float flareFadeSpeed { get; set; }
		
		[YamlAlias("m_FlareStrength")]
		public /* static */ float flareStrength { get; set; }
		
		[YamlAlias("m_Fog")]
		public /* static */ bool fog { get; set; }
		
		[YamlAlias("m_FogColor")]
		public /* static */ Color fogColor { get; set; }
		
		[YamlAlias("m_FogDensity")]
		public /* static */ float fogDensity { get; set; }
		
		[YamlAlias("m_LinearFogEnd")]
		public /* static */ float fogEndDistance { get; set; }
		
		[YamlAlias("m_FogMode")]
		public /* static */ FogMode fogMode { get; set; }
		
		[YamlAlias("m_LinearFogStart")]
		public /* static */ float fogStartDistance { get; set; }
		
		[YamlAlias("m_HaloStrength")]
		public /* static */ float haloStrength { get; set; }
		
		[YamlAlias("m_SkyboxMaterial")]
		public ComponentReference skybox { get; set; }

		[YamlAlias("m_HaloTexture")]
		public ComponentReference haloTexture { get; set; }

		[YamlAlias("m_SpotCookie")]
		public ComponentReference spotCookie { get; set; }
	}
}