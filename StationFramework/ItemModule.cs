using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005AD RID: 1453
	public class ItemModule : MonoBehaviour
	{
		// Token: 0x06007EFA RID: 32506 RVA: 0x0022339C File Offset: 0x0022159C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemModule()
		{
			Il2CppClassPointerStore<ItemModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "ItemModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemModule>.NativeClassPtr);
			ItemModule.NativeFieldInfoPtr__Item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<Item>k__BackingField");
			ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, "<IsModuleActive>k__BackingField");
			ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100679303);
			ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100679304);
			ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100679305);
			ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100679306);
			ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100679307);
			ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemModule>.NativeClassPtr, 100679308);
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x06007EFB RID: 32507 RVA: 0x0022346C File Offset: 0x0022166C
		// (set) Token: 0x06007EFC RID: 32508 RVA: 0x002234AC File Offset: 0x002216AC
		public unsafe StationItem Item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_Item_Public_get_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06007EFD RID: 32509 RVA: 0x002234F0 File Offset: 0x002216F0
		// (set) Token: 0x06007EFE RID: 32510 RVA: 0x0022352C File Offset: 0x0022172C
		public unsafe bool IsModuleActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007EFF RID: 32511 RVA: 0x0022356C File Offset: 0x0022176C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241417, XrefRangeEnd = 241418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActivateModule(StationItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemModule.NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F00 RID: 32512 RVA: 0x002235BC File Offset: 0x002217BC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemModule>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemModule.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F01 RID: 32513 RVA: 0x0003C07F File Offset: 0x0003A27F
		public ItemModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002632 RID: 9778
		// (get) Token: 0x06007F02 RID: 32514 RVA: 0x002235F8 File Offset: 0x002217F8
		// (set) Token: 0x06007F03 RID: 32515 RVA: 0x0003C088 File Offset: 0x0003A288
		public unsafe StationItem _Item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__Item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x06007F04 RID: 32516 RVA: 0x00223628 File Offset: 0x00221828
		// (set) Token: 0x06007F05 RID: 32517 RVA: 0x0003C0A7 File Offset: 0x0003A2A7
		public unsafe bool _IsModuleActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemModule.NativeFieldInfoPtr__IsModuleActive_k__BackingField)) = value;
			}
		}

		// Token: 0x04005673 RID: 22131
		private static readonly IntPtr NativeFieldInfoPtr__Item_k__BackingField;

		// Token: 0x04005674 RID: 22132
		private static readonly IntPtr NativeFieldInfoPtr__IsModuleActive_k__BackingField;

		// Token: 0x04005675 RID: 22133
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_StationItem_0;

		// Token: 0x04005676 RID: 22134
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Protected_set_Void_StationItem_0;

		// Token: 0x04005677 RID: 22135
		private static readonly IntPtr NativeMethodInfoPtr_get_IsModuleActive_Public_get_Boolean_0;

		// Token: 0x04005678 RID: 22136
		private static readonly IntPtr NativeMethodInfoPtr_set_IsModuleActive_Protected_set_Void_Boolean_0;

		// Token: 0x04005679 RID: 22137
		private static readonly IntPtr NativeMethodInfoPtr_ActivateModule_Public_Virtual_New_Void_StationItem_0;

		// Token: 0x0400567A RID: 22138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
