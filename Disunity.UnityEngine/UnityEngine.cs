using System;
using YamlDotNet.Serialization;

namespace UnityEngine
{











	public class Renderer: Component {

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

	public sealed class MeshFilter: Component
	{
		// [YamlAlias("m_Mesh")]
		// public Mesh mesh { get; set; }

		// public Mesh sharedMesh { get; set; }
	}

	[Serializable]
	public enum ParticleSystemRenderMode {
		Billboard,
		Stretch,
		HorizontalBillboard,
		VerticalBillboard,
		Mesh
	}

	public sealed class ParticleSystemRenderer: Renderer {
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

	public sealed class ParticleSystem : Component
	{

		// public ParticleSystem ();

		// public void Clear ();
		// public void Clear (bool withChildren);
		// public void Emit (int count);
		// public void Emit (Particle particle);
		// public void Emit (Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color);
		// public int GetCollisionEvents (GameObject go, CollisionEvent[] collisionEvents);
		// public int GetParticles (Particle[] particles);
		// public bool IsAlive ();
		// public bool IsAlive (bool withChildren);
		// public void Pause ();
		// public void Pause (bool withChildren);
		public void Play(bool withChildren = true)
		{
		}
		// public void Play (bool withChildren);
		// public void SetParticles (Particle[] particles, int size);
		// public void Simulate (float t);
		// public void Simulate (float t, bool withChildren);
		// public void Simulate (float t, bool withChildren, bool restart);
		// public void Stop ();
		// public void Stop (bool withChildren);

		// public float duration { get; }
		// public float emissionRate { get; set; }
		// public bool enableEmission { get; set; }
		// public float gravityModifier { get; set; }
		// public bool isPaused { get; }
		// public bool isPlaying { get; }
		// public bool isStopped { get; }

		[YamlAlias("looping")]
		public bool loop { get; set; }

		// public int maxParticles { get; set; }
		// public int particleCount { get; }
		// public float playbackSpeed { get; set; }

		// YAML: Direct mapping.
		public bool playOnAwake { get; set; }
		public uint randomSeed { get; set; }

		// public int safeCollisionEventSize { get; }
		// public ParticleSystemSimulationSpace simulationSpace { get; set; }
		// public Color startColor { get; set; }

		// YAML: Direct mapping.
		public float startDelay { get; set; }

		// public float startLifetime { get; set; }
		// public float startRotation { get; set; }
		// public float startSize { get; set; }
		// public float startSpeed { get; set; }
		// public float time { get; set; }

		public struct CollisionEvent
		{
			// TODO
		}
		public struct Particle
		{
			// TODO
		}
	}

	public class Behaviour: Component
	{
		[YamlAlias("m_Enabled")]
		public bool enabled { get; set; }
	}

	public class Input
	{
		public static float GetAxis(string axisName)
		{
			return 0.0f;
		}
		
		public static bool GetButtonDown(string buttonName)
		{
			return false;
		}
		
		public static bool GetKeyUp(KeyCode key)
		{
			return false;
		}
	}

	public struct Vector2
	{
		public Vector2(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		// public static float Angle (Vector2 from, Vector2 to);
		// public static Vector2 ClampMagnitude (Vector2 vector, float maxLength);
		// public static float Distance (Vector2 a, Vector2 b);
		// public static float Dot (Vector2 lhs, Vector2 rhs);
		// public static Vector2 Lerp (Vector2 from, Vector2 to, float t);
		// public static Vector2 Max (Vector2 lhs, Vector2 rhs);
		// public static Vector2 Min (Vector2 lhs, Vector2 rhs);
		// public static Vector2 MoveTowards (Vector2 current, Vector2 target, float maxDistanceDelta);
		// public static Vector2 Scale (Vector2 a, Vector2 b);
		// public static float SqrMagnitude (Vector2 a);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public void Normalize ();
		// public void Scale (Vector2 scale);
		// public void Set (float new_x, float new_y);
		// public float SqrMagnitude ();
		// public override string ToString ();
		// public string ToString (string format);

		// public static Vector2 operator + (Vector2 a, Vector2 b);
		// public static Vector2 operator - (Vector2 a, Vector2 b);
		// public static Vector2 operator - (Vector2 a);

		public static Vector2 operator*(Vector2 a, float d)
		{
			return a;
		}

		// public static Vector2 operator * (float d, Vector2 a);
		// public static Vector2 operator / (Vector2 a, float d);
		// public static bool operator == (Vector2 lhs, Vector2 rhs);
		// public static bool operator != (Vector2 lhs, Vector2 rhs);
		// public static implicit operator Vector2 (Vector3 v);
		// public static implicit operator Vector3 (Vector2 v);

		// public static Vector2 one {
		//	get;
		// }
		public static Vector2 right;

		// public static Vector2 up {
		//	get;
		// }
		// public static Vector2 zero {
		//	get;
		// }
		// public float this [int index] {
		//	get;
		//	set;
		// }
		// public float magnitude {
		//	get;
		// }
		// public Vector2 normalized {
		//	get;
		// }
		// public float sqrMagnitude {
		//	get;
		// }

		public const float kEpsilon = 1E-05f;

		// YAML: Direct mapping.
		public float x;
		public float y;
	}

	[Serializable]
	public enum LightRenderMode
	{
		Auto,
		ForcePixel,
		ForceVertex
	}

	[Serializable]
	public enum LightShadows
	{
		None,
		Hard,
		Soft
	}

	[Serializable]
	public enum LightType
	{
		Spot,
		Directional,
		Point,
		Area
	}

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

	[Serializable]
	public enum AnimationCullingType
	{
		AlwaysAnimate,
		BasedOnRenderers,
		BasedOnClipBounds,
		BasedOnUserBounds
	}

	[Serializable]
	public enum WrapMode
	{
		Once = 1,
		Loop = 2,
		PingPong = 4,
		Default = 0,
		ClampForever = 8,
		Clamp = 1
	}

	public sealed class Animation : Behaviour
	// , System.Collections.IEnumerable
	{

		// public Animation ();

		// public void AddClip (AnimationClip clip, string newName);
		// public void AddClip (AnimationClip clip, string newName, int firstFrame, int lastFrame);
		// public void AddClip (AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame);
		// public void Blend (string animation);
		// public void Blend (string animation, float targetWeight);
		// public void Blend (string animation, float targetWeight, float fadeLength);
		// public void CrossFade (string animation);
		// public void CrossFade (string animation, float fadeLength);
		// public void CrossFade (string animation, float fadeLength, PlayMode mode);
		// public AnimationState CrossFadeQueued (string animation);
		// public AnimationState CrossFadeQueued (string animation, float fadeLength);
		// public AnimationState CrossFadeQueued (string animation, float fadeLength, QueueMode queue);
		// public AnimationState CrossFadeQueued (string animation, float fadeLength, QueueMode queue, PlayMode mode);
		// public AnimationClip GetClip (string name);
		// public int GetClipCount ();
		// public System.Collections.IEnumerator GetEnumerator ();
		// public bool IsPlaying (string name);
		// public bool Play ();
		// public bool Play (AnimationPlayMode mode);
		// public bool Play (PlayMode mode);
		// public bool Play (string animation);
		// public bool Play (string animation, AnimationPlayMode mode);
		// public bool Play (string animation, PlayMode mode);
		// public AnimationState PlayQueued (string animation);
		// public AnimationState PlayQueued (string animation, QueueMode queue);
		// public AnimationState PlayQueued (string animation, QueueMode queue, PlayMode mode);
		// public void RemoveClip (AnimationClip clip);
		// public void RemoveClip (string clipName);
		// public void Rewind ();
		// public void Rewind (string name);
		// public void Sample ();
		// public void Stop ();
		// public void Stop (string name);
		// public void SyncLayer (int layer);

		// public bool animateOnlyIfVisible { get; set; }

		[YamlAlias("m_AnimatePhysics")]
		public bool animatePhysics { get; set; }

		// [YamlAlias("m_Animation")]
		// public AnimationClip clip { get; set; }

		[YamlAlias("m_CullingType")]
		public AnimationCullingType cullingType { get; set; }

		// public bool isPlaying { get; }
		// public AnimationState this [string name] { get; }
		// public Bounds localBounds { get; set; }

		[YamlAlias("m_PlayAutomatically")]
		public bool playAutomatically { get; set; }

		[YamlAlias("m_WrapMode")]
		public WrapMode wrapMode { get; set; }
	}

	public class Coroutine
	{
	}

	public class WaitForSeconds
	{
		public WaitForSeconds(float seconds)
		{
		}
	}

	public class RaycastHit2D
	{
		public static implicit operator bool(RaycastHit2D raycast)
		{
			return false;
		}
	}

	public class Physics2D
	{
		public const int DefaultRaycastLayers = 0;
		
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			return null;
		}
		
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			return null;
		}
		
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask = DefaultRaycastLayers, float minDepth = -Mathf.Infinity, float maxDepth = Mathf.Infinity)
		{
			return null;
		}
	}

	public class MonoBehaviour : Behaviour
	{
		// public MonoBehaviour ();

		// public static void print (object message);
		// public void CancelInvoke ();
		// public void CancelInvoke (string methodName);
		// public void Invoke (string methodName, float time);
		public void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}

		// public bool IsInvoking ();
		// public bool IsInvoking (string methodName);

		public Coroutine StartCoroutine(System.Collections.IEnumerator routine)
		{
			return null;
		}

		public Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		public Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}
		
		// public Coroutine StartCoroutine_Auto (System.Collections.IEnumerator routine);
		// public void StopAllCoroutines ();
		// public void StopCoroutine (System.Collections.IEnumerator routine);
		// public void StopCoroutine (string methodName);

		// public bool useGUILayout { get; set; }
	}

	public sealed class LightProbeGroup : Component
	{
		// public LightProbeGroup ();

		[YamlAlias("m_SourcePositions")]
		public Vector3[] probePositions { get; set; }
	}

	[Serializable]
	public enum CameraClearFlags
	{
		Skybox = 1,
		Color = 2,
		SolidColor = 2,
		Depth = 3,
		Nothing = 4
	}

	public class LayerMask
	{
		public static int NameToLayer(string layerName)
		{
			return 0;
		}
	}

	public class Mathf
	{
		public const float Infinity = 0.0f;
		
		public static float Abs(float f)
		{
			return f;
		}
		
		public static float Clamp(float value, float min, float max)
		{
			return value;
		}
		
		public static float Lerp(float from, float to, float t)
		{
			return from;
		}
		
		public static float Sign(float f)
		{
			return f;
		}
	}

	public struct Rect
	{
		// public Rect (float left, float top, float width, float height);
		// public Rect (Rect source);

		// public static Rect MinMaxRect (float left, float top, float right, float bottom);
		// public static Vector2 NormalizedToPoint (Rect rectangle, Vector2 normalizedRectCoordinates);
		// public static Vector2 PointToNormalized (Rect rectangle, Vector2 point);
		// public bool Contains (Vector2 point);
		// public bool Contains (Vector3 point);
		// public bool Contains (Vector3 point, bool allowInverse);
		// public override bool Equals (object other);
		// public override int GetHashCode ();
		// public bool Overlaps (Rect other);
		// public bool Overlaps (Rect other, bool allowInverse);
		// public void Set (float left, float top, float width, float height);
		// public override string ToString ();
		// public string ToString (string format);

		// public static bool operator != (Rect lhs, Rect rhs);
		// public static bool operator == (Rect lhs, Rect rhs);

		// public float bottom { get; }
		// public Vector2 center { get; set; }

		// YAML: Direct mapping.
		public float height { get; set; }

		// public float left { get; }
		// public Vector2 max { get; set; }
		// public Vector2 min { get; set; }
		// public Vector2 position { get; set; }
		// public float right { get; }
		// public Vector2 size { get; set; }
		// public float top { get; }

		// YAML: Direct mapping.
		public float width { get; set; }
		public float x { get; set; }

		// public float xMax { get; set; }
		// public float xMin { get; set; }

		// YAML: Direct mapping.
		public float y { get; set; }

		// public float yMax { get; set; }
		// public float yMin { get; set; }
	}

	[Serializable]
	public enum RenderingPath
	{
		UsePlayerSettings = -1,
		VertexLit = 0,
		Forward,
		DeferredLighting
	}

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

	public sealed class AudioListener : Behaviour
	{
		// public AudioListener ();

		// public static float [] GetOutputData (int numSamples, int channel);
		// public static void GetOutputData (float [] samples, int channel);
		// public static float [] GetSpectrumData (int numSamples, int channel, FFTWindow window);
		// public static void GetSpectrumData (float [] samples, int channel, FFTWindow window);

		// public static bool pause { get; set; }
		// public static float volume { get; set; }
		// public AudioVelocityUpdateMode velocityUpdateMode { get; set; }
	}

	public class Collider : Component
	{
		// public Collider ();

		// public Vector3 ClosestPointOnBounds (Vector3 position);
		// public bool Raycast (Ray ray, out RaycastHit hitInfo, float distance);

		// public Rigidbody attachedRigidbody { get; }
		// public Bounds bounds { get; }

		[YamlAlias("m_Enabled")]
		public bool enabled { get; set; }

		[YamlAlias("m_IsTrigger")]
		public bool isTrigger { get; set; }

		// TODO: via fileID.
		// [YamlAlias("m_Material")]
		// public PhysicMaterial material { get; set; }
		// public PhysicMaterial sharedMaterial { get; set; }
	}

	public sealed class MeshCollider : Collider
	{
		// public MeshCollider ();

		[YamlAlias("m_Convex")]
		public bool convex { get; set; }

		// [YamlAlias("m_Mesh")]
		// public Mesh mesh { get; set; }
		// public Mesh sharedMesh { get; set; }

		[YamlAlias("m_SmoothSphereCollisions")]
		public bool smoothSphereCollisions { get; set; }
	}
}
