
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
		/// Binding for glGetGraphicsResetStatusARB.
		/// </summary>
		[RequiredByFeature("GL_ARB_robustness")]
		public static int GetGraphicsResetStatusARB()
		{
			int retValue;

			Debug.Assert(Delegates.pglGetGraphicsResetStatusARB != null, "pglGetGraphicsResetStatusARB not implemented");
			retValue = Delegates.pglGetGraphicsResetStatusARB();
			CallLog("glGetGraphicsResetStatusARB() = {0}", retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Binding for glGetnTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnTexImageARB(int target, Int32 level, int format, int type, Int32 bufSize, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetnTexImageARB != null, "pglGetnTexImageARB not implemented");
			Delegates.pglGetnTexImageARB(target, level, format, type, bufSize, img);
			CallLog("glGetnTexImageARB({0}, {1}, {2}, {3}, {4}, {5})", target, level, format, type, bufSize, img);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="level">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnTexImageARB(int target, Int32 level, int format, int type, Int32 bufSize, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetnTexImageARB(target, level, format, type, bufSize, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnCompressedTexImageARB(int target, Int32 lod, Int32 bufSize, IntPtr img)
		{
			Debug.Assert(Delegates.pglGetnCompressedTexImageARB != null, "pglGetnCompressedTexImageARB not implemented");
			Delegates.pglGetnCompressedTexImageARB(target, lod, bufSize, img);
			CallLog("glGetnCompressedTexImageARB({0}, {1}, {2}, {3})", target, lod, bufSize, img);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnCompressedTexImageARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="lod">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="img">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnCompressedTexImageARB(int target, Int32 lod, Int32 bufSize, Object img)
		{
			GCHandle pin_img = GCHandle.Alloc(img, GCHandleType.Pinned);
			try {
				GetnCompressedTexImageARB(target, lod, bufSize, pin_img.AddrOfPinnedObject());
			} finally {
				pin_img.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnUniformfvARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, params float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformfvARB != null, "pglGetnUniformfvARB not implemented");
					Delegates.pglGetnUniformfvARB(program, location, (Int32)@params.Length, p_params);
					CallLog("glGetnUniformfvARB({0}, {1}, {2}, {3})", program, location, @params.Length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformivARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, params Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformivARB != null, "pglGetnUniformivARB not implemented");
					Delegates.pglGetnUniformivARB(program, location, (Int32)@params.Length, p_params);
					CallLog("glGetnUniformivARB({0}, {1}, {2}, {3})", program, location, @params.Length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformuivARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, params UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformuivARB != null, "pglGetnUniformuivARB not implemented");
					Delegates.pglGetnUniformuivARB(program, location, (Int32)@params.Length, p_params);
					CallLog("glGetnUniformuivARB({0}, {1}, {2}, {3})", program, location, @params.Length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnUniformdvARB.
		/// </summary>
		/// <param name="program">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="location">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnUniformARB(UInt32 program, Int32 location, params double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetnUniformdvARB != null, "pglGetnUniformdvARB not implemented");
					Delegates.pglGetnUniformdvARB(program, location, (Int32)@params.Length, p_params);
					CallLog("glGetnUniformdvARB({0}, {1}, {2}, {3})", program, location, @params.Length, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapdvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMapARB(int target, int query, params double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapdvARB != null, "pglGetnMapdvARB not implemented");
					Delegates.pglGetnMapdvARB(target, query, (Int32)v.Length, p_v);
					CallLog("glGetnMapdvARB({0}, {1}, {2}, {3})", target, query, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapfvARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMapARB(int target, int query, params float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapfvARB != null, "pglGetnMapfvARB not implemented");
					Delegates.pglGetnMapfvARB(target, query, (Int32)v.Length, p_v);
					CallLog("glGetnMapfvARB({0}, {1}, {2}, {3})", target, query, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMapivARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="query">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMapARB(int target, int query, params Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetnMapivARB != null, "pglGetnMapivARB not implemented");
					Delegates.pglGetnMapivARB(target, query, (Int32)v.Length, p_v);
					CallLog("glGetnMapivARB({0}, {1}, {2}, {3})", target, query, v.Length, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapfvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPixelMapARB(int map, params float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapfvARB != null, "pglGetnPixelMapfvARB not implemented");
					Delegates.pglGetnPixelMapfvARB(map, (Int32)values.Length, p_values);
					CallLog("glGetnPixelMapfvARB({0}, {1}, {2})", map, values.Length, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapuivARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPixelMapARB(int map, params UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapuivARB != null, "pglGetnPixelMapuivARB not implemented");
					Delegates.pglGetnPixelMapuivARB(map, (Int32)values.Length, p_values);
					CallLog("glGetnPixelMapuivARB({0}, {1}, {2})", map, values.Length, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPixelMapusvARB.
		/// </summary>
		/// <param name="map">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPixelMapARB(int map, params UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetnPixelMapusvARB != null, "pglGetnPixelMapusvARB not implemented");
					Delegates.pglGetnPixelMapusvARB(map, (Int32)values.Length, p_values);
					CallLog("glGetnPixelMapusvARB({0}, {1}, {2})", map, values.Length, values);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnPolygonStippleARB.
		/// </summary>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="pattern">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnPolygonStippleARB(params byte[] pattern)
		{
			unsafe {
				fixed (byte* p_pattern = pattern)
				{
					Debug.Assert(Delegates.pglGetnPolygonStippleARB != null, "pglGetnPolygonStippleARB not implemented");
					Delegates.pglGetnPolygonStippleARB((Int32)pattern.Length, p_pattern);
					CallLog("glGetnPolygonStippleARB({0}, {1})", pattern.Length, pattern);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnColorTableARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnColorTableARB(int target, int format, int type, Int32 bufSize, IntPtr table)
		{
			Debug.Assert(Delegates.pglGetnColorTableARB != null, "pglGetnColorTableARB not implemented");
			Delegates.pglGetnColorTableARB(target, format, type, bufSize, table);
			CallLog("glGetnColorTableARB({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, table);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnColorTableARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="table">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnColorTableARB(int target, int format, int type, Int32 bufSize, Object table)
		{
			GCHandle pin_table = GCHandle.Alloc(table, GCHandleType.Pinned);
			try {
				GetnColorTableARB(target, format, type, bufSize, pin_table.AddrOfPinnedObject());
			} finally {
				pin_table.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnConvolutionFilterARB(int target, int format, int type, Int32 bufSize, IntPtr image)
		{
			Debug.Assert(Delegates.pglGetnConvolutionFilterARB != null, "pglGetnConvolutionFilterARB not implemented");
			Delegates.pglGetnConvolutionFilterARB(target, format, type, bufSize, image);
			CallLog("glGetnConvolutionFilterARB({0}, {1}, {2}, {3}, {4})", target, format, type, bufSize, image);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnConvolutionFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="image">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnConvolutionFilterARB(int target, int format, int type, Int32 bufSize, Object image)
		{
			GCHandle pin_image = GCHandle.Alloc(image, GCHandleType.Pinned);
			try {
				GetnConvolutionFilterARB(target, format, type, bufSize, pin_image.AddrOfPinnedObject());
			} finally {
				pin_image.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnSeparableFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnSeparableFilterARB(int target, int format, int type, Int32 rowBufSize, IntPtr row, Int32 columnBufSize, IntPtr column, IntPtr span)
		{
			Debug.Assert(Delegates.pglGetnSeparableFilterARB != null, "pglGetnSeparableFilterARB not implemented");
			Delegates.pglGetnSeparableFilterARB(target, format, type, rowBufSize, row, columnBufSize, column, span);
			CallLog("glGetnSeparableFilterARB({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", target, format, type, rowBufSize, row, columnBufSize, column, span);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnSeparableFilterARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="rowBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="row">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="columnBufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="column">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <param name="span">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnSeparableFilterARB(int target, int format, int type, Int32 rowBufSize, Object row, Int32 columnBufSize, Object column, Object span)
		{
			GCHandle pin_row = GCHandle.Alloc(row, GCHandleType.Pinned);
			GCHandle pin_column = GCHandle.Alloc(column, GCHandleType.Pinned);
			GCHandle pin_span = GCHandle.Alloc(span, GCHandleType.Pinned);
			try {
				GetnSeparableFilterARB(target, format, type, rowBufSize, pin_row.AddrOfPinnedObject(), columnBufSize, pin_column.AddrOfPinnedObject(), pin_span.AddrOfPinnedObject());
			} finally {
				pin_row.Free();
				pin_column.Free();
				pin_span.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnHistogramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnHistogramARB(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnHistogramARB != null, "pglGetnHistogramARB not implemented");
			Delegates.pglGetnHistogramARB(target, reset, format, type, bufSize, values);
			CallLog("glGetnHistogramARB({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnHistogramARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnHistogramARB(int target, bool reset, int format, int type, Int32 bufSize, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetnHistogramARB(target, reset, format, type, bufSize, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

		/// <summary>
		/// Binding for glGetnMinmaxARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMinmaxARB(int target, bool reset, int format, int type, Int32 bufSize, IntPtr values)
		{
			Debug.Assert(Delegates.pglGetnMinmaxARB != null, "pglGetnMinmaxARB not implemented");
			Delegates.pglGetnMinmaxARB(target, reset, format, type, bufSize, values);
			CallLog("glGetnMinmaxARB({0}, {1}, {2}, {3}, {4}, {5})", target, reset, format, type, bufSize, values);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glGetnMinmaxARB.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="reset">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="format">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="bufSize">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:Object"/>.
		/// </param>
		[RequiredByFeature("GL_ARB_robustness")]
		public static void GetnMinmaxARB(int target, bool reset, int format, int type, Int32 bufSize, Object values)
		{
			GCHandle pin_values = GCHandle.Alloc(values, GCHandleType.Pinned);
			try {
				GetnMinmaxARB(target, reset, format, type, bufSize, pin_values.AddrOfPinnedObject());
			} finally {
				pin_values.Free();
			}
		}

	}

}
