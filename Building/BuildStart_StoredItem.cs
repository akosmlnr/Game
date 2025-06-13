using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004DA RID: 1242
	public class BuildStart_StoredItem : BuildStart_Base
	{
		// Token: 0x06006BFC RID: 27644 RVA: 0x001E4CF4 File Offset: 0x001E2EF4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_StoredItem()
		{
			Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr);
			BuildStart_StoredItem.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr, 100677103);
			BuildStart_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GameObject_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr, 100677104);
			BuildStart_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr, 100677105);
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x001E4D60 File Offset: 0x001E2F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217831, XrefRangeEnd = 217862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_StoredItem.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x001E4DB0 File Offset: 0x001E2FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217862, XrefRangeEnd = 217891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateGhostModel(StorableItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GameObject_StorableItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x001E4E0C File Offset: 0x001E300C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x00032C9C File Offset: 0x00030E9C
		public BuildStart_StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040049F5 RID: 18933
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040049F6 RID: 18934
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GameObject_StorableItemInstance_0;

		// Token: 0x040049F7 RID: 18935
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
