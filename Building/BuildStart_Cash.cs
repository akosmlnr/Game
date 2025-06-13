using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004D7 RID: 1239
	public class BuildStart_Cash : BuildStart_StoredItem
	{
		// Token: 0x06006BEE RID: 27630 RVA: 0x001E4968 File Offset: 0x001E2B68
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_Cash()
		{
			Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr);
			BuildStart_Cash.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr, 100677095);
			BuildStart_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr, 100677096);
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x001E49C0 File Offset: 0x001E2BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217628, XrefRangeEnd = 217659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_Cash.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x001E4A10 File Offset: 0x001E2C10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_Cash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00032C81 File Offset: 0x00030E81
		public BuildStart_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040049ED RID: 18925
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040049EE RID: 18926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
