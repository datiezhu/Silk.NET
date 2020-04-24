// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_polygon_mode")]
    public abstract unsafe partial class NVPolygonMode : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonModeNV")]
        public abstract void PolygonMode([Flow(FlowDirection.In)] NV face, [Flow(FlowDirection.In)] NV mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonModeNV")]
        public abstract void PolygonMode([Flow(FlowDirection.In)] NV face, [Flow(FlowDirection.In)] PolygonMode mode);

        public NVPolygonMode(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}
