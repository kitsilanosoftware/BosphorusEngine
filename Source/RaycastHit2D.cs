//------------------------------------------------------------------------------
// RaycastHit2D.cs
//
// This file is part of the Bosphorus project.
//
// See http://bosphorusengine.com for more details on Bosphorus.
//
// Copyright (c) 2014 Kitsilano Software Inc (http://kitsilanosoftware.com)
//------------------------------------------------------------------------------

namespace UnityEngine
{	
	public class RaycastHit2D
	{
		public static implicit operator bool(RaycastHit2D raycast)
		{
			return false;
		}
	}
}
