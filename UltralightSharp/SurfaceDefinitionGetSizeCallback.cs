using System;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Ultralight {

  [PublicAPI]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  [return: NativeTypeName("size_t")]
  public unsafe delegate UIntPtr SurfaceDefinitionGetSizeCallback([NativeTypeName("void *")] void* userData);

}