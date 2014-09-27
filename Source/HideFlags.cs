//------------------------------------------------------------------------------
// HideFlags.cs
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
	[Flags] // TODO - These will need explicit values assigned to be correct, probably 1, 2, 4, 8, etc.
	// See http://stackoverflow.com/questions/8447/what-does-the-flags-enum-attribute-mean-in-c.
	public enum HideFlags
	{
		None,
		HideInHierarchy,
		HideInInspector,
		DontSave,
		NotEditable,
		HideAndDontSave
	}
}

