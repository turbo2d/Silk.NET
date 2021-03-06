// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_video_capture")]
    public unsafe partial class NVVideoCapture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_video_capture";
        [NativeApi(EntryPoint = "glBeginVideoCaptureNV")]
        public partial void BeginVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot);

        [NativeApi(EntryPoint = "glBindVideoCaptureStreamBufferNV")]
        public partial void BindVideoCaptureStreamBuffer([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] IntPtr offset);

        [NativeApi(EntryPoint = "glBindVideoCaptureStreamTextureNV")]
        public partial void BindVideoCaptureStreamTexture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glEndVideoCaptureNV")]
        public partial void EndVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot);

        [NativeApi(EntryPoint = "glGetVideoCaptureivNV")]
        public unsafe partial void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureivNV")]
        public partial void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV")]
        public unsafe partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV")]
        public partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV")]
        public unsafe partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV")]
        public partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV")]
        public unsafe partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV")]
        public partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        public unsafe partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        public unsafe partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] out ulong capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        public unsafe partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] out uint sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        public partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] out uint sequence_num, [Flow(FlowDirection.Out)] out ulong capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV")]
        public unsafe partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV")]
        public partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV")]
        public unsafe partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV")]
        public partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV")]
        public unsafe partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV")]
        public partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        public NVVideoCapture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

