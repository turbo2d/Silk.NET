// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAGS")]
    public enum ResourceBarrierFlags
    {
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_NONE")]
        ResourceBarrierFlagNone = 0x0,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_BEGIN_ONLY")]
        ResourceBarrierFlagBeginOnly = 0x1,
        [NativeName("Name", "D3D12_RESOURCE_BARRIER_FLAG_END_ONLY")]
        ResourceBarrierFlagEndOnly = 0x2,
    }
}
