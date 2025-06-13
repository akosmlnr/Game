using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E0 RID: 1504
	public class Equippable : MonoBehaviour
	{
		// Token: 0x06008303 RID: 33539 RVA: 0x00231DD0 File Offset: 0x0022FFD0
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable()
		{
			Il2CppClassPointerStore<Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable>.NativeClassPtr);
			Equippable.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "itemInstance");
			Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanInteractWhenEquipped");
			Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable>.NativeClassPtr, "CanPickUpWhenEquipped");
			Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679821);
			Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679822);
			Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable>.NativeClassPtr, 100679823);
		}

		// Token: 0x06008304 RID: 33540 RVA: 0x00231E78 File Offset: 0x00230078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248482, XrefRangeEnd = 248489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008305 RID: 33541 RVA: 0x00231EC8 File Offset: 0x002300C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248489, XrefRangeEnd = 248500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x00231F04 File Offset: 0x00230104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248500, XrefRangeEnd = 248501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008307 RID: 33543 RVA: 0x0003DEC3 File Offset: 0x0003C0C3
		public Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x06008308 RID: 33544 RVA: 0x00231F40 File Offset: 0x00230140
		// (set) Token: 0x06008309 RID: 33545 RVA: 0x0003DECC File Offset: 0x0003C0CC
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x0600830A RID: 33546 RVA: 0x00231F70 File Offset: 0x00230170
		// (set) Token: 0x0600830B RID: 33547 RVA: 0x0003DEEB File Offset: 0x0003C0EB
		public unsafe bool CanInteractWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanInteractWhenEquipped)) = value;
			}
		}

		// Token: 0x17002764 RID: 10084
		// (get) Token: 0x0600830C RID: 33548 RVA: 0x00231F98 File Offset: 0x00230198
		// (set) Token: 0x0600830D RID: 33549 RVA: 0x0003DF06 File Offset: 0x0003C106
		public unsafe bool CanPickUpWhenEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable.NativeFieldInfoPtr_CanPickUpWhenEquipped)) = value;
			}
		}

		// Token: 0x0400593C RID: 22844
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x0400593D RID: 22845
		private static readonly IntPtr NativeFieldInfoPtr_CanInteractWhenEquipped;

		// Token: 0x0400593E RID: 22846
		private static readonly IntPtr NativeFieldInfoPtr_CanPickUpWhenEquipped;

		// Token: 0x0400593F RID: 22847
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04005940 RID: 22848
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_New_Void_0;

		// Token: 0x04005941 RID: 22849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
