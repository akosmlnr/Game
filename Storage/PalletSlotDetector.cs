using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000593 RID: 1427
	public class PalletSlotDetector : MonoBehaviour
	{
		// Token: 0x06007CA6 RID: 31910 RVA: 0x0021AD94 File Offset: 0x00218F94
		// Note: this type is marked as 'beforefieldinit'.
		static PalletSlotDetector()
		{
			Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletSlotDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr);
			PalletSlotDetector.NativeFieldInfoPtr_pallet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, "pallet");
			PalletSlotDetector.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, 100679004);
			PalletSlotDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr, 100679005);
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0021AE00 File Offset: 0x00219000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238493, XrefRangeEnd = 238495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PalletSlotDetector.NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x0021AE50 File Offset: 0x00219050
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletSlotDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletSlotDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlotDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x0003B049 File Offset: 0x00039249
		public PalletSlotDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x06007CAA RID: 31914 RVA: 0x0021AE8C File Offset: 0x0021908C
		// (set) Token: 0x06007CAB RID: 31915 RVA: 0x0003B052 File Offset: 0x00039252
		public unsafe Pallet pallet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlotDetector.NativeFieldInfoPtr_pallet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlotDetector.NativeFieldInfoPtr_pallet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054DB RID: 21723
		private static readonly IntPtr NativeFieldInfoPtr_pallet;

		// Token: 0x040054DC RID: 21724
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Virtual_New_Void_Collider_0;

		// Token: 0x040054DD RID: 21725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
