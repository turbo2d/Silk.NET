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

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODE_PROFILES")]
    public unsafe partial struct FeatureDataVideoDecodeProfiles
    {
        public FeatureDataVideoDecodeProfiles
        (
            uint? nodeIndex = null,
            uint? profileCount = null,
            Guid* pProfiles = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (profileCount is not null)
            {
                ProfileCount = profileCount.Value;
            }

            if (pProfiles is not null)
            {
                PProfiles = pProfiles;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProfileCount")]
        public uint ProfileCount;

        [NativeName("Type", "GUID *")]
        [NativeName("Type.Name", "GUID *")]
        [NativeName("Name", "pProfiles")]
        public Guid* PProfiles;
    }
}
