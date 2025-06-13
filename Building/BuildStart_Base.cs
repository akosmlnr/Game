using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004D6 RID: 1238
	public class BuildStart_Base : MonoBehaviour
	{
		// Token: 0x06006BEA RID: 27626 RVA: 0x001E4884 File Offset: 0x001E2A84
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Base()
		{
			Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr);
			BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100677093);
			BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr, 100677094);
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x001E48DC File Offset: 0x001E2ADC
		[CallerCount(0)]
		public unsafe virtual void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Base.NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BEC RID: 27628 RVA: 0x001E492C File Offset: 0x001E2B2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BED RID: 27629 RVA: 0x00032C78 File Offset: 0x00030E78
		public BuildStart_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040049EB RID: 18923
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Abstract_Virtual_New_Void_ItemInstance_0;

		// Token: 0x040049EC RID: 18924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
