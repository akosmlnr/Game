using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E5 RID: 1253
	public class OverrideGhostMaterial : MonoBehaviour
	{
		// Token: 0x06006CBC RID: 27836 RVA: 0x000332C4 File Offset: 0x000314C4
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideGhostMaterial()
		{
			Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "OverrideGhostMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr);
			OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr, 100677173);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x001E71D4 File Offset: 0x001E53D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideGhostMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x000332FD File Offset: 0x000314FD
		public OverrideGhostMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004A6C RID: 19052
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
