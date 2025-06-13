using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004AD RID: 1197
	public class ConstructStop_Base : MonoBehaviour
	{
		// Token: 0x060066A8 RID: 26280 RVA: 0x001D1D74 File Offset: 0x001CFF74
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStop_Base()
		{
			Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr);
			ConstructStop_Base.NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr, 100676395);
			ConstructStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr, 100676396);
		}

		// Token: 0x060066A9 RID: 26281 RVA: 0x001D1DCC File Offset: 0x001CFFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209072, XrefRangeEnd = 209081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopConstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStop_Base.NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x001D1E08 File Offset: 0x001D0008
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStop_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x000304FB File Offset: 0x0002E6FB
		public ConstructStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400460D RID: 17933
		private static readonly IntPtr NativeMethodInfoPtr_StopConstruction_Public_Virtual_New_Void_0;

		// Token: 0x0400460E RID: 17934
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
