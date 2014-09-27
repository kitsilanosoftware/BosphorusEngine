//------------------------------------------------------------------------------
// CameraClearFlags.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

using System;

namespace UnityEngine
{
	[Serializable]
	public enum CameraClearFlags
	{
		Skybox = 1,
		Color = 2,
		SolidColor = 2,
		Depth = 3,
		Nothing = 4
	}
}

