using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003BC RID: 956
	public class ITransitEntity : Il2CppObjectBase
	{
		// Token: 0x060049EB RID: 18923 RVA: 0x0016AAC4 File Offset: 0x00168CC4
		// Note: this type is marked as 'beforefieldinit'.
		static ITransitEntity()
		{
			Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ITransitEntity");
			ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672523);
			ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672524);
			ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672525);
			ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672526);
			ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672527);
			ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672528);
			ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672529);
			ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672530);
			ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672531);
			ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672532);
			ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672533);
			ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672534);
			ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672535);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672536);
			ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672537);
			ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672538);
			ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672539);
			ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672540);
			ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672541);
			ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672542);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672543);
			ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, 100672544);
		}

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x060049EC RID: 18924 RVA: 0x0016ACA4 File Offset: 0x00168EA4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x060049ED RID: 18925 RVA: 0x0016ACE8 File Offset: 0x00168EE8
		// (set) Token: 0x060049EE RID: 18926 RVA: 0x0016AD34 File Offset: 0x00168F34
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x060049EF RID: 18927 RVA: 0x0016AD84 File Offset: 0x00168F84
		// (set) Token: 0x060049F0 RID: 18928 RVA: 0x0016ADD0 File Offset: 0x00168FD0
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x060049F1 RID: 18929 RVA: 0x0016AE20 File Offset: 0x00169020
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x060049F2 RID: 18930 RVA: 0x0016AE6C File Offset: 0x0016906C
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x060049F3 RID: 18931 RVA: 0x0016AEB8 File Offset: 0x001690B8
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x060049F4 RID: 18932 RVA: 0x0016AF00 File Offset: 0x00169100
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x0016AF48 File Offset: 0x00169148
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x0016AF90 File Offset: 0x00169190
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x0016AFD8 File Offset: 0x001691D8
		[CallerCount(0)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x0016B024 File Offset: 0x00169224
		[CallerCount(0)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x0016B060 File Offset: 0x00169260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166720, XrefRangeEnd = 166763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoInput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049FA RID: 18938 RVA: 0x0016B0C0 File Offset: 0x001692C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166763, XrefRangeEnd = 166806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InsertItemIntoOutput(ItemInstance item, NPC inserter = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inserter);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x0016B120 File Offset: 0x00169320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166806, XrefRangeEnd = 166846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetInputCapacityForItem(ItemInstance item, NPC asker = null, bool checkPlayerFilters = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref checkPlayerFilters;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x0016B198 File Offset: 0x00169398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166846, XrefRangeEnd = 166886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetOutputCapacityForItem(ItemInstance item, NPC asker = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asker);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060049FD RID: 18941 RVA: 0x0016B204 File Offset: 0x00169404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166886, XrefRangeEnd = 166904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetOutputItemContainer(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
		}

		// Token: 0x060049FE RID: 18942 RVA: 0x0016B260 File Offset: 0x00169460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166904, XrefRangeEnd = 166936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<ItemSlot> ReserveInputSlotsForItem(ItemInstance item, NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locker);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
		}

		// Token: 0x060049FF RID: 18943 RVA: 0x0016B2D0 File Offset: 0x001694D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166936, XrefRangeEnd = 166961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveSlotLocks(NetworkObject locker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locker);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A00 RID: 18944 RVA: 0x0016B320 File Offset: 0x00169520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166961, XrefRangeEnd = 166982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingItem(string id, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref searchType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
		}

		// Token: 0x06004A01 RID: 18945 RVA: 0x0016B38C File Offset: 0x0016958C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166982, XrefRangeEnd = 167002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContainingTemplateItem(ItemInstance templateItem, ITransitEntity.ESlotType searchType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(templateItem);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref searchType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITransitEntity.NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
		}

		// Token: 0x06004A02 RID: 18946 RVA: 0x00023815 File Offset: 0x00021A15
		public ITransitEntity(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040031D0 RID: 12752
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040031D1 RID: 12753
		private static readonly System.IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040031D2 RID: 12754
		private static readonly System.IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040031D3 RID: 12755
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040031D4 RID: 12756
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040031D5 RID: 12757
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Abstract_Virtual_New_get_Transform_0;

		// Token: 0x040031D6 RID: 12758
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x040031D7 RID: 12759
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Selectable_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040031D8 RID: 12760
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040031D9 RID: 12761
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040031DA RID: 12762
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x040031DB RID: 12763
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOutline_Public_Abstract_Virtual_New_Void_Color_0;

		// Token: 0x040031DC RID: 12764
		private static readonly System.IntPtr NativeMethodInfoPtr_HideOutline_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040031DD RID: 12765
		private static readonly System.IntPtr NativeMethodInfoPtr_InsertItemIntoInput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x040031DE RID: 12766
		private static readonly System.IntPtr NativeMethodInfoPtr_InsertItemIntoOutput_Public_Virtual_New_Void_ItemInstance_NPC_0;

		// Token: 0x040031DF RID: 12767
		private static readonly System.IntPtr NativeMethodInfoPtr_GetInputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_Boolean_0;

		// Token: 0x040031E0 RID: 12768
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputCapacityForItem_Public_Virtual_New_Int32_ItemInstance_NPC_0;

		// Token: 0x040031E1 RID: 12769
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputItemContainer_Public_Virtual_New_ItemSlot_ItemInstance_0;

		// Token: 0x040031E2 RID: 12770
		private static readonly System.IntPtr NativeMethodInfoPtr_ReserveInputSlotsForItem_Public_Virtual_New_List_1_ItemSlot_ItemInstance_NetworkObject_0;

		// Token: 0x040031E3 RID: 12771
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveSlotLocks_Public_Virtual_New_Void_NetworkObject_0;

		// Token: 0x040031E4 RID: 12772
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstSlotContainingItem_Public_Virtual_New_ItemSlot_String_ESlotType_0;

		// Token: 0x040031E5 RID: 12773
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstSlotContainingTemplateItem_Public_Virtual_New_ItemSlot_ItemInstance_ESlotType_0;

		// Token: 0x020009C3 RID: 2499
		[OriginalName("Assembly-CSharp.dll", "", "ESlotType")]
		public enum ESlotType
		{
			// Token: 0x04008C02 RID: 35842
			Input,
			// Token: 0x04008C03 RID: 35843
			Output,
			// Token: 0x04008C04 RID: 35844
			Both
		}

		// Token: 0x020009C4 RID: 2500
		[ObfuscatedName("ScheduleOne.Management.ITransitEntity+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEDA RID: 52954 RVA: 0x00322D80 File Offset: 0x00320F80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ITransitEntity>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr);
				ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, "item");
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100672545);
				ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr, 100672546);
			}

			// Token: 0x0600CEDB RID: 52955 RVA: 0x00322DE8 File Offset: 0x00320FE8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ITransitEntity.__c__DisplayClass27_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEDC RID: 52956 RVA: 0x00322E24 File Offset: 0x00321024
			[CallerCount(0)]
			public unsafe bool _GetOutputItemContainer_b__0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ITransitEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CEDD RID: 52957 RVA: 0x0006444D File Offset: 0x0006264D
			public __c__DisplayClass27_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402B RID: 16427
			// (get) Token: 0x0600CEDE RID: 52958 RVA: 0x00322E74 File Offset: 0x00321074
			// (set) Token: 0x0600CEDF RID: 52959 RVA: 0x00064456 File Offset: 0x00062656
			public unsafe ItemInstance item
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ITransitEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C05 RID: 35845
			private static readonly System.IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008C06 RID: 35846
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C07 RID: 35847
			private static readonly System.IntPtr NativeMethodInfoPtr__GetOutputItemContainer_b__0_Internal_Boolean_ItemSlot_0;
		}
	}
}
