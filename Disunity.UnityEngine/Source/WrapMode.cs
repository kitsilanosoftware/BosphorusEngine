//------------------------------------------------------------------------------
// WrapMode.cs
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
	public enum WrapMode
	{
		Once = 1,
		Loop = 2,
		PingPong = 4,
		Default = 0,
		ClampForever = 8,
		Clamp = 1
	}
}