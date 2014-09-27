//------------------------------------------------------------------------------
// Camera.cs
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
	public sealed class Camera : Behaviour
	{
		// public Camera ();
		
		// public static int GetAllCameras (Camera[] cameras);
		// public static void SetupCurrent (Camera cur);
		// public Matrix4x4 CalculateObliqueMatrix (Vector4 clipPlane);
		// public void CopyFrom (Camera other);
		// public void DoClear ();
		// public float GetScreenHeight ();
		// public float GetScreenWidth ();
		// public void Render ();
		// public void RenderDontRestore ();
		// public bool RenderToCubemap (Cubemap cubemap);
		// public bool RenderToCubemap (Cubemap cubemap, int faceMask);
		// public bool RenderToCubemap (RenderTexture cubemap);
		// public bool RenderToCubemap (RenderTexture cubemap, int faceMask);
		// public void RenderWithShader (Shader shader, string replacementTag);
		// public void ResetAspect ();
		// public void ResetProjectionMatrix ();
		// public void ResetReplacementShader ();
		// public void ResetWorldToCameraMatrix ();
		// public Ray ScreenPointToRay (Vector3 position);
		// public Vector3 ScreenToViewportPoint (Vector3 position);
		// public Vector3 ScreenToWorldPoint (Vector3 position);
		// public void SetReplacementShader (Shader shader, string replacementTag);
		// public void SetTargetBuffers (RenderBuffer colorBuffer, RenderBuffer depthBuffer);
		// public void SetTargetBuffers (RenderBuffer[] colorBuffer, RenderBuffer depthBuffer);
		// public Ray ViewportPointToRay (Vector3 position);
		// public Vector3 ViewportToScreenPoint (Vector3 position);
		// public Vector3 ViewportToWorldPoint (Vector3 position);
		// public Vector3 WorldToScreenPoint (Vector3 position);
		// public Vector3 WorldToViewportPoint (Vector3 position);
		
		// public static Camera[] allCameras { get; }
		// public static int allCamerasCount { get; }
		// public static Camera current { get; }
		// public static Camera main { get; }
		// public static Camera mainCamera { get; }
		// public RenderingPath actualRenderingPath { get; }
		// public float aspect { get; set; }
		
		[YamlAlias("m_BackGroundColor")]
		public Color backgroundColor { get; set; }
		
		// public Matrix4x4 cameraToWorldMatrix { get; }
		
		[YamlAlias("m_ClearFlags")]
		public CameraClearFlags clearFlags { get; set; }
		
		// public bool clearStencilAfterLightingPass { get; set; }
		
		// TODO: Indirect mapping.
		// [YamlAlias("m_CullingMask")]
		// public int cullingMask { get; set; }
		
		[YamlAlias("m_Depth")]
		public float depth { get; set; }
		
		// public DepthTextureMode depthTextureMode { get; set; }
		// public int eventMask { get; set; }
		// public float far { get; set; }
		
		[YamlAlias("far clip plane")]
		public float farClipPlane { get; set; }
		
		[YamlAlias("field of view")]
		public float fieldOfView { get; set; }
		
		// public float fov { get; set; }
		
		[YamlAlias("m_HDR")]
		public bool hdr { get; set; }
		
		// public bool isOrthoGraphic { get; set; }
		// public float [] layerCullDistances { get; set; }
		// public bool layerCullSpherical { get; set; }
		// public float near { get; set; }
		
		[YamlAlias("near clip plane")]
		public float nearClipPlane { get; set; }
		
		// YAML: Direct mapping.
		public bool orthographic { get; set; }
		
		[YamlAlias("orthographic size")]
		public float orthographicSize { get; set; }
		
		// public float pixelHeight { get; }
		// public Rect pixelRect { get; set; }
		// public float pixelWidth { get; }
		// public Matrix4x4 projectionMatrix { get; set; }
		
		// TODO: Verify.
		[YamlAlias("m_NormalizedViewPortRect")]
		public Rect rect { get; set; }
		
		[YamlAlias("m_RenderingPath")]
		public RenderingPath renderingPath { get; set; }
		
		[YamlAlias("m_StereoConvergence")]
		public float stereoConvergence { get; set; }
		
		// public bool stereoEnabled { get; }
		
		[YamlAlias("m_StereoSeparation")]
		public float stereoSeparation { get; set; }
		
		// TODO: type, fileID mapping.
		// [YamlAlias("m_TargetTexture")]
		// public RenderTexture targetTexture { get; set; }
		
		// public TransparencySortMode transparencySortMode { get; set; }
		
		[YamlAlias("m_OcclusionCulling")]
		public bool useOcclusionCulling { get; set; }
		
		// public Vector3 velocity { get; }
		// public Matrix4x4 worldToCameraMatrix { get; set; }
		
		public static Camera main;
	}
}
