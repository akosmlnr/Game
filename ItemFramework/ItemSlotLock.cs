using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200060E RID: 1550
	public class ItemSlotLock : Il2CppSystem.Object
	{
		// Token: 0x060086A5 RID: 34469 RVA: 0x0023E354 File Offset: 0x0023C554
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotLock()
		{
			Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlotLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr);
			ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<Slot>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockOwner>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockReason>k__BackingField");
			ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680253);
			ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680254);
			ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680255);
			ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680256);
			ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680257);
			ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680258);
			ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100680259);
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x060086A6 RID: 34470 RVA: 0x0023E44C File Offset: 0x0023C64C
		// (set) Token: 0x060086A7 RID: 34471 RVA: 0x0023E48C File Offset: 0x0023C68C
		public unsafe ItemSlot Slot
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x060086A8 RID: 34472 RVA: 0x0023E4D0 File Offset: 0x0023C6D0
		// (set) Token: 0x060086A9 RID: 34473 RVA: 0x0023E510 File Offset: 0x0023C710
		public unsafe NetworkObject LockOwner
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x060086AA RID: 34474 RVA: 0x0023E554 File Offset: 0x0023C754
		// (set) Token: 0x060086AB RID: 34475 RVA: 0x0023E58C File Offset: 0x0023C78C
		public unsafe string LockReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x0023E5D0 File Offset: 0x0023C7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 252762, XrefRangeEnd = 252770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060086AD RID: 34477 RVA: 0x0003F91E File Offset: 0x0003DB1E
		public ItemSlotLock(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700287D RID: 10365
		// (get) Token: 0x060086AE RID: 34478 RVA: 0x0023E640 File Offset: 0x0023C840
		// (set) Token: 0x060086AF RID: 34479 RVA: 0x0003F927 File Offset: 0x0003DB27
		public unsafe ItemSlot _Slot_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700287E RID: 10366
		// (get) Token: 0x060086B0 RID: 34480 RVA: 0x0023E670 File Offset: 0x0023C870
		// (set) Token: 0x060086B1 RID: 34481 RVA: 0x0003F946 File Offset: 0x0003DB46
		public unsafe NetworkObject _LockOwner_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x060086B2 RID: 34482 RVA: 0x0023E6A0 File Offset: 0x0023C8A0
		// (set) Token: 0x060086B3 RID: 34483 RVA: 0x0003F965 File Offset: 0x0003DB65
		public unsafe string _LockReason_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005BBF RID: 23487
		private static readonly System.IntPtr NativeFieldInfoPtr__Slot_k__BackingField;

		// Token: 0x04005BC0 RID: 23488
		private static readonly System.IntPtr NativeFieldInfoPtr__LockOwner_k__BackingField;

		// Token: 0x04005BC1 RID: 23489
		private static readonly System.IntPtr NativeFieldInfoPtr__LockReason_k__BackingField;

		// Token: 0x04005BC2 RID: 23490
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0;

		// Token: 0x04005BC3 RID: 23491
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0;

		// Token: 0x04005BC4 RID: 23492
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0;

		// Token: 0x04005BC5 RID: 23493
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0;

		// Token: 0x04005BC6 RID: 23494
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LockReason_Public_get_String_0;

		// Token: 0x04005BC7 RID: 23495
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0;

		// Token: 0x04005BC8 RID: 23496
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0;
	}
}
