
// Copyright (C) 2015-2017 Luca Piccioni
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

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] Value of GL_FOG_FUNC_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_fog_function")]
		public const int FOG_FUNC_SGIS = 0x812A;

		/// <summary>
		/// [GL] Value of GL_FOG_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_fog_function")]
		public const int FOG_FUNC_POINTS_SGIS = 0x812B;

		/// <summary>
		/// [GL] Value of GL_MAX_FOG_FUNC_POINTS_SGIS symbol.
		/// </summary>
		[RequiredByFeature("GL_SGIS_fog_function")]
		public const int MAX_FOG_FUNC_POINTS_SGIS = 0x812C;

		/// <summary>
		/// [GL] Binding for glFogFuncSGIS.
		/// </summary>
		/// <param name="n">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_fog_function")]
		public static void FogFuncSGIS(Int32 n, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglFogFuncSGIS != null, "pglFogFuncSGIS not implemented");
					Delegates.pglFogFuncSGIS(n, p_points);
					LogCommand("glFogFuncSGIS", null, n, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] Binding for glGetFogFuncSGIS.
		/// </summary>
		/// <param name="points">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_SGIS_fog_function")]
		public static void GetFogFuncSGIS([Out] float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglGetFogFuncSGIS != null, "pglGetFogFuncSGIS not implemented");
					Delegates.pglGetFogFuncSGIS(p_points);
					LogCommand("glGetFogFuncSGIS", null, points					);
				}
			}
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glFogFuncSGIS(Int32 n, float* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFogFuncSGIS", ExactSpelling = true)]
			internal extern static unsafe void glGetFogFuncSGIS(float* points);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_SGIS_fog_function")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogFuncSGIS(Int32 n, float* points);

			[RequiredByFeature("GL_SGIS_fog_function")]
			[ThreadStatic]
			internal static glFogFuncSGIS pglFogFuncSGIS;

			[RequiredByFeature("GL_SGIS_fog_function")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFogFuncSGIS(float* points);

			[RequiredByFeature("GL_SGIS_fog_function")]
			[ThreadStatic]
			internal static glGetFogFuncSGIS pglGetFogFuncSGIS;

		}
	}

}
