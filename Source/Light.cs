//------------------------------------------------------------------------------
// Light.cs
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
	public sealed class Light : Behaviour
	{
		
		// public Light ();
		
		// public static Light[] GetLights (LightType type, int layer);
		
		// public static int pixelLightCount { get; set; }
		
		[YamlAlias("m_ActuallyLightmapped")]
		public bool alreadyLightmapped { get; set; }
		
		[YamlAlias("m_AreaSize")]
		public Vector2 areaSize { get; set; }
		
		// public bool attenuate { get; set; }
		
		[YamlAlias("m_Color")]
		public Color color { get; set; }
		
		// TODO: type, fileID mapping.
		// [YamlAlias("m_Cookie")]
		// public Texture cookie { get; set; }
		
		[YamlAlias("m_CookieSize")]
		public float cookieSize { get; set; }
		
		// TODO: Indirect mapping.
		// [YamlAlias("m_CullingMask")]
		// public int cullingMask { get; set; }
		
		// TODO: type, fileID mapping.
		// [YamlAlias("m_Flare")]
		// public Flare flare { get; set; }
		
		[YamlAlias("m_Intensity")]
		public float intensity { get; set; }
		
		[YamlAlias("m_Range")]
		public float range { get; set; }
		
		[YamlAlias("m_RenderMode")]
		public LightRenderMode renderMode { get; set; }
		
		// public float shadowBias { get; set; }
		// public float shadowConstantBias { get; set; }
		// public float shadowObjectSizeBias { get; set; }
		
		[YamlAlias("m_Shadows")]
		public LightShadows shadows { get; set; }
		
		// public float shadowSoftness { get; set; }
		// public float shadowSoftnessFade { get; set; }
		// public float shadowStrength { get; set; }
		
		[YamlAlias("m_SpotAngle")]
		public float spotAngle { get; set; }
		
		[YamlAlias("m_Type")]
		public LightType type { get; set; }
	}
}