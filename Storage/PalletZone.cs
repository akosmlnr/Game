using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000594 RID: 1428
	public class PalletZone : MonoBehaviour
	{
		// Token: 0x06007CAC RID: 31916 RVA: 0x0021AEBC File Offset: 0x002190BC
		// Note: this type is marked as 'beforefieldinit'.
		static PalletZone()
		{
			Il2CppClassPointerStore<PalletZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletZone>.NativeClassPtr);
			PalletZone.NativeFieldInfoPtr_pallets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "pallets");
			PalletZone.NativeFieldInfoPtr_palletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "palletPrefab");
			PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, "orderReceivedThisFrame");
			PalletZone.NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679006);
			PalletZone.NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679007);
			PalletZone.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679008);
			PalletZone.NativeMethodInfoPtr_LateUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679009);
			PalletZone.NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679010);
			PalletZone.NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679011);
			PalletZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletZone>.NativeClassPtr, 100679012);
		}

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06007CAD RID: 31917 RVA: 0x0021AFB4 File Offset: 0x002191B4
		public unsafe bool isClear
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238495, XrefRangeEnd = 238502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x0021AFF0 File Offset: 0x002191F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238502, XrefRangeEnd = 238515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0021B034 File Offset: 0x00219234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238515, XrefRangeEnd = 238517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_FixedUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x0021B068 File Offset: 0x00219268
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 165084, RefRangeEnd = 165097, XrefRangeStart = 165084, XrefRangeEnd = 165097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_LateUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x0021B09C File Offset: 0x0021929C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238517, XrefRangeEnd = 238534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pallet GeneratePallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x0021B0DC File Offset: 0x002192DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238534, XrefRangeEnd = 238540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPalletsClear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x0021B118 File Offset: 0x00219318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238540, XrefRangeEnd = 238548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x0003B071 File Offset: 0x00039271
		public PalletZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x0021B154 File Offset: 0x00219354
		// (set) Token: 0x06007CB6 RID: 31926 RVA: 0x0003B07A File Offset: 0x0003927A
		public unsafe List<Pallet> pallets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_pallets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pallet>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_pallets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06007CB7 RID: 31927 RVA: 0x0021B184 File Offset: 0x00219384
		// (set) Token: 0x06007CB8 RID: 31928 RVA: 0x0003B099 File Offset: 0x00039299
		public unsafe GameObject palletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_palletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_palletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06007CB9 RID: 31929 RVA: 0x0021B1B4 File Offset: 0x002193B4
		// (set) Token: 0x06007CBA RID: 31930 RVA: 0x0003B0B8 File Offset: 0x000392B8
		public unsafe bool orderReceivedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PalletZone.NativeFieldInfoPtr_orderReceivedThisFrame)) = value;
			}
		}

		// Token: 0x040054DE RID: 21726
		private static readonly IntPtr NativeFieldInfoPtr_pallets;

		// Token: 0x040054DF RID: 21727
		private static readonly IntPtr NativeFieldInfoPtr_palletPrefab;

		// Token: 0x040054E0 RID: 21728
		private static readonly IntPtr NativeFieldInfoPtr_orderReceivedThisFrame;

		// Token: 0x040054E1 RID: 21729
		private static readonly IntPtr NativeMethodInfoPtr_get_isClear_Public_get_Boolean_0;

		// Token: 0x040054E2 RID: 21730
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Protected_Void_Collider_0;

		// Token: 0x040054E3 RID: 21731
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Void_0;

		// Token: 0x040054E4 RID: 21732
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Void_0;

		// Token: 0x040054E5 RID: 21733
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePallet_Public_Pallet_0;

		// Token: 0x040054E6 RID: 21734
		private static readonly IntPtr NativeMethodInfoPtr_AreAllPalletsClear_Private_Boolean_0;

		// Token: 0x040054E7 RID: 21735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
