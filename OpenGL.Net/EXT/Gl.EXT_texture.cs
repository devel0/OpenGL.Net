
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_RGB2_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int RGB2_EXT = 0x804E;

		/// <summary>
		/// Value of GL_REPLACE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int REPLACE_EXT = 0x8062;

		/// <summary>
		/// Value of GL_TEXTURE_TOO_LARGE_EXT symbol.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		public const int TEXTURE_TOO_LARGE_EXT = 0x8065;

	}

}