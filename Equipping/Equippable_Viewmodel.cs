using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005EA RID: 1514
	public class Equippable_Viewmodel : Equippable_StorableItem
	{
		// Token: 0x0600841F RID: 33823 RVA: 0x00235100 File Offset: 0x00233300
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Viewmodel()
		{
			Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Viewmodel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr);
			Equippable_Viewmodel.NativeFieldInfoPtr_localPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localPosition");
			Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localEulerAngles");
			Equippable_Viewmodel.NativeFieldInfoPtr_localScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "localScale");
			Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, "AvatarEquippable");
			Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679928);
			Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679929);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679930);
			Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679931);
			Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr, 100679932);
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x002351E4 File Offset: 0x002333E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 249522, RefRangeEnd = 249534, XrefRangeStart = 249494, XrefRangeEnd = 249522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x00235234 File Offset: 0x00233434
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249535, RefRangeEnd = 249539, XrefRangeStart = 249534, XrefRangeEnd = 249535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x00235270 File Offset: 0x00233470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249539, XrefRangeEnd = 249548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayEquipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x002352AC File Offset: 0x002334AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249548, XrefRangeEnd = 249559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayUnequipAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Viewmodel.NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x002352E8 File Offset: 0x002334E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 248176, RefRangeEnd = 248183, XrefRangeStart = 248176, XrefRangeEnd = 248183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Viewmodel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Viewmodel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Viewmodel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x0003E8FA File Offset: 0x0003CAFA
		public Equippable_Viewmodel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x06008426 RID: 33830 RVA: 0x00235324 File Offset: 0x00233524
		// (set) Token: 0x06008427 RID: 33831 RVA: 0x0003E903 File Offset: 0x0003CB03
		public unsafe Vector3 localPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localPosition)) = value;
			}
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x06008428 RID: 33832 RVA: 0x0023534C File Offset: 0x0023354C
		// (set) Token: 0x06008429 RID: 33833 RVA: 0x0003E91E File Offset: 0x0003CB1E
		public unsafe Vector3 localEulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localEulerAngles)) = value;
			}
		}

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600842A RID: 33834 RVA: 0x00235374 File Offset: 0x00233574
		// (set) Token: 0x0600842B RID: 33835 RVA: 0x0003E939 File Offset: 0x0003CB39
		public unsafe Vector3 localScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_localScale)) = value;
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x0600842C RID: 33836 RVA: 0x0023539C File Offset: 0x0023359C
		// (set) Token: 0x0600842D RID: 33837 RVA: 0x0003E954 File Offset: 0x0003CB54
		public unsafe AvatarEquippable AvatarEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Viewmodel.NativeFieldInfoPtr_AvatarEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040059EA RID: 23018
		private static readonly IntPtr NativeFieldInfoPtr_localPosition;

		// Token: 0x040059EB RID: 23019
		private static readonly IntPtr NativeFieldInfoPtr_localEulerAngles;

		// Token: 0x040059EC RID: 23020
		private static readonly IntPtr NativeFieldInfoPtr_localScale;

		// Token: 0x040059ED RID: 23021
		private static readonly IntPtr NativeFieldInfoPtr_AvatarEquippable;

		// Token: 0x040059EE RID: 23022
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040059EF RID: 23023
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040059F0 RID: 23024
		private static readonly IntPtr NativeMethodInfoPtr_PlayEquipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x040059F1 RID: 23025
		private static readonly IntPtr NativeMethodInfoPtr_PlayUnequipAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x040059F2 RID: 23026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
