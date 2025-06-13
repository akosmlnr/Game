using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004D4 RID: 1236
	public class ActivateDuringBuild : MonoBehaviour
	{
		// Token: 0x06006BBC RID: 27580 RVA: 0x00032B1A File Offset: 0x00030D1A
		// Note: this type is marked as 'beforefieldinit'.
		static ActivateDuringBuild()
		{
			Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "ActivateDuringBuild");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr);
			ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr, 100677066);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x001E3CC0 File Offset: 0x001E1EC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActivateDuringBuild() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActivateDuringBuild>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActivateDuringBuild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BBE RID: 27582 RVA: 0x00032B53 File Offset: 0x00030D53
		public ActivateDuringBuild(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040049CA RID: 18890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
