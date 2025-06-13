using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200060F RID: 1551
	public class ItemSlotSiblingSet : MonoBehaviour
	{
		// Token: 0x060086B4 RID: 34484 RVA: 0x0023E6C8 File Offset: 0x0023C8C8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotSiblingSet()
		{
			Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlotSiblingSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr);
			ItemSlotSiblingSet.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, "Slots");
			ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, 100680260);
			ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, 100680261);
			ItemSlotSiblingSet.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, 100680262);
		}

		// Token: 0x060086B5 RID: 34485 RVA: 0x0023E748 File Offset: 0x0023C948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252780, RefRangeEnd = 252781, XrefRangeStart = 252770, XrefRangeEnd = 252780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotSiblingSet([Optional] Il2CppReferenceArray<ItemSlot> slots)
		{
			if (slots == null)
			{
				slots = new Il2CppReferenceArray<ItemSlot>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr));
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x0023E7A0 File Offset: 0x0023C9A0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 252804, RefRangeEnd = 252812, XrefRangeStart = 252781, XrefRangeEnd = 252804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotSiblingSet(List<ItemSlot> slots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086B7 RID: 34487 RVA: 0x0023E7EC File Offset: 0x0023C9EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 252836, RefRangeEnd = 252838, XrefRangeStart = 252812, XrefRangeEnd = 252836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSlot(ItemSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotSiblingSet.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x0003F984 File Offset: 0x0003DB84
		public ItemSlotSiblingSet(params ItemSlot[] slots) : this(new Il2CppReferenceArray<ItemSlot>(slots))
		{
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x0003F992 File Offset: 0x0003DB92
		public ItemSlotSiblingSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x060086BA RID: 34490 RVA: 0x0023E830 File Offset: 0x0023CA30
		// (set) Token: 0x060086BB RID: 34491 RVA: 0x0003F99B File Offset: 0x0003DB9B
		public unsafe List<ItemSlot> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotSiblingSet.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotSiblingSet.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BC9 RID: 23497
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04005BCA RID: 23498
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04005BCB RID: 23499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04005BCC RID: 23500
		private static readonly IntPtr NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_0;
	}
}
