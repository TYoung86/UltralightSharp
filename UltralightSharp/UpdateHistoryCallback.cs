using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace ImpromptuNinjas.UltralightSharp {

  [PublicAPI]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  public unsafe delegate void UpdateHistoryCallback([NativeTypeName("void *")] void* userData, [NativeTypeName("ULView")] View* caller);

}