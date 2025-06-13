using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E7 RID: 1511
	public class Equippable_Revolver : Equippable_RangedWeapon
	{
		// Token: 0x06008400 RID: 33792 RVA: 0x00234A7C File Offset: 0x00232C7C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Revolver()
		{
			Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Revolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr);
			Equippable_Revolver.NativeFieldInfoPtr_Bullets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, "Bullets");
			Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679913);
			Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679914);
			Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679915);
			Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679916);
			Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679917);
			Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr, 100679918);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x00234B38 File Offset: 0x00232D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249390, XrefRangeEnd = 249393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x00234B88 File Offset: 0x00232D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249393, XrefRangeEnd = 249396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Fire_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008403 RID: 33795 RVA: 0x00234BC4 File Offset: 0x00232DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249396, XrefRangeEnd = 249411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_Reload_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x00234C00 File Offset: 0x00232E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249411, XrefRangeEnd = 249413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyIncrementalReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Revolver.NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008405 RID: 33797 RVA: 0x00234C3C File Offset: 0x00232E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249416, RefRangeEnd = 249420, XrefRangeStart = 249413, XrefRangeEnd = 249416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBullets(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x00234C7C File Offset: 0x00232E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Revolver() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Revolver>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Revolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x0003E854 File Offset: 0x0003CA54
		public Equippable_Revolver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C3 RID: 10179
		// (get) Token: 0x06008408 RID: 33800 RVA: 0x00234CB8 File Offset: 0x00232EB8
		// (set) Token: 0x06008409 RID: 33801 RVA: 0x0003E85D File Offset: 0x0003CA5D
		public unsafe Il2CppReferenceArray<Transform> Bullets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Revolver.NativeFieldInfoPtr_Bullets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040059D6 RID: 22998
		private static readonly IntPtr NativeFieldInfoPtr_Bullets;

		// Token: 0x040059D7 RID: 22999
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x040059D8 RID: 23000
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Public_Virtual_Void_0;

		// Token: 0x040059D9 RID: 23001
		private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_Void_0;

		// Token: 0x040059DA RID: 23002
		private static readonly IntPtr NativeMethodInfoPtr_NotifyIncrementalReload_Protected_Virtual_Void_0;

		// Token: 0x040059DB RID: 23003
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBullets_Private_Void_Int32_0;

		// Token: 0x040059DC RID: 23004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
