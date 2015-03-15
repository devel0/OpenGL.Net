
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
		/// Binding for glBindBufferOffsetEXT.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="buffer">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="offset">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_EXT_transform_feedback")]
		public static void BindBufferOffsetEXT(int target, UInt32 index, UInt32 buffer, IntPtr offset)
		{
			if        (Delegates.pglBindBufferOffsetEXT != null) {
				Delegates.pglBindBufferOffsetEXT(target, index, buffer, offset);
				CallLog("glBindBufferOffsetEXT({0}, {1}, {2}, {3})", target, index, buffer, offset);
			} else if (Delegates.pglBindBufferOffsetNV != null) {
				Delegates.pglBindBufferOffsetNV(target, index, buffer, offset);
				CallLog("glBindBufferOffsetNV({0}, {1}, {2}, {3})", target, index, buffer, offset);
			} else
				throw new NotImplementedException("glBindBufferOffsetEXT (and other aliases) are not implemented");
			DebugCheckErrors();
		}

	}

}
