// Compatibility shim for 'record' on netstandard2.0 builds.
#if !NET5_0_OR_GREATER
namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit {}
}
#endif
