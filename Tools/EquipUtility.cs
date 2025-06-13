using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200055A RID: 1370
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x060078D4 RID: 30932 RVA: 0x0020EE4C File Offset: 0x0020D04C
		// Note: this type is marked as 'beforefieldinit'.
		static EquipUtility()
		{
			Il2CppClassPointerStore<EquipUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "EquipUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr);
			EquipUtility.NativeFieldInfoPtr_Equippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, "Equippable");
			EquipUtility.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678605);
			EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678606);
			EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678607);
			EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr, 100678608);
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x0020EEE0 File Offset: 0x0020D0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234819, XrefRangeEnd = 234823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x0020EF14 File Offset: 0x0020D114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234823, XrefRangeEnd = 234827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Equip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x0020EF48 File Offset: 0x0020D148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234827, XrefRangeEnd = 234833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr_Unequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x0020EF7C File Offset: 0x0020D17C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EquipUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EquipUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00039040 File Offset: 0x00037240
		public EquipUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x060078DA RID: 30938 RVA: 0x0020EFB8 File Offset: 0x0020D1B8
		// (set) Token: 0x060078DB RID: 30939 RVA: 0x00039049 File Offset: 0x00037249
		public unsafe AvatarEquippable Equippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EquipUtility.NativeFieldInfoPtr_Equippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005283 RID: 21123
		private static readonly IntPtr NativeFieldInfoPtr_Equippable;

		// Token: 0x04005284 RID: 21124
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04005285 RID: 21125
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_0;

		// Token: 0x04005286 RID: 21126
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Void_0;

		// Token: 0x04005287 RID: 21127
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
