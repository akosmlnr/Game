using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004DD RID: 1245
	public class BuildUpdate_Base : MonoBehaviour
	{
		// Token: 0x06006C0A RID: 27658 RVA: 0x001E506C File Offset: 0x001E326C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Base()
		{
			Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr);
			BuildUpdate_Base.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr, 100677111);
			BuildUpdate_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr, 100677112);
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x001E50C4 File Offset: 0x001E32C4
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Base.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x001E5100 File Offset: 0x001E3300
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x00032CB7 File Offset: 0x00030EB7
		public BuildUpdate_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040049FD RID: 18941
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x040049FE RID: 18942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
