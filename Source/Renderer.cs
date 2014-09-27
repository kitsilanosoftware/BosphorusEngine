//------------------------------------------------------------------------------
// Renderer.cs
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
	public class Renderer : Component {
		
		// public void GetPropertyBlock (MaterialPropertyBlock dest);
		// public void Render (int material);
		// public void SetPropertyBlock (MaterialPropertyBlock properties);
		
		// public Bounds bounds { get; }
		
		[YamlAlias("m_CastShadows")]
		public bool castShadows { get; set; }
		
		[YamlAlias("m_Enabled")]
		public bool enabled { get; set; }
		
		// public bool isPartOfStaticBatch { get; }
		// public bool isVisible { get; }
		
		[YamlAlias("m_LightmapIndex")]
		public int lightmapIndex { get; set; }
		
		[YamlAlias("m_LightmapTilingOffset")]
		public Vector4 lightmapTilingOffset { get; set; }
		
		// TODO: Exception, Key name fileID does not match Transform.
		// [YamlAlias("m_LightProbeAnchor")]
		// public Transform lightProbeAnchor { get; set; }
		
		// public Matrix4x4 localToWorldMatrix { get; }
		public Material material { get; set; }
		
		// TODO: Exception, Key name fileID does not match Material.
		// [YamlAlias("m_Materials")]
		// public Material[] materials { get; set; }
		
		[YamlAlias("m_ReceiveShadows")]
		public bool receiveShadows { get; set; }
		
		// public Material sharedMaterial { get; set; }
		// public Material[] sharedMaterials { get; set; }
		
		[YamlAlias("m_SortingLayerID")]
		public int sortingLayerID { get; set; }
		
		public string sortingLayerName { get; set; }
		
		[YamlAlias("m_SortingOrder")]
		public int sortingOrder { get; set; }
		
		[YamlAlias("m_UseLightProbes")]
		public bool useLightProbes { get; set; }
		
		// public Matrix4x4 worldToLocalMatrix { get; }
	}
}