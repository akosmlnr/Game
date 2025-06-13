using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000592 RID: 1426
	public class PalletSlot : MonoBehaviour
	{
		// Token: 0x06007C95 RID: 31893 RVA: 0x0021AA10 File Offset: 0x00218C10
		// Note: this type is marked as 'beforefieldinit'.
		static PalletSlot()
		{
			Il2CppClassPointerStore<PalletSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "PalletSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr);
			PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "<GUID>k__BackingField");
			PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "<occupant>k__BackingField");
			PalletSlot.NativeFieldInfoPtr_onPalletAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "onPalletAdded");
			PalletSlot.NativeFieldInfoPtr_onPalletRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, "onPalletRemoved");
			PalletSlot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678997);
			PalletSlot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678998);
			PalletSlot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100678999);
			PalletSlot.NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100679000);
			PalletSlot.NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100679001);
			PalletSlot.NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100679002);
			PalletSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr, 100679003);
		}

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x06007C96 RID: 31894 RVA: 0x0021AB1C File Offset: 0x00218D1C
		// (set) Token: 0x06007C97 RID: 31895 RVA: 0x0021AB58 File Offset: 0x00218D58
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x0021AB98 File Offset: 0x00218D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238481, XrefRangeEnd = 238485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x06007C99 RID: 31897 RVA: 0x0021ABD8 File Offset: 0x00218DD8
		// (set) Token: 0x06007C9A RID: 31898 RVA: 0x0021AC18 File Offset: 0x00218E18
		public unsafe Pallet occupant
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007C9B RID: 31899 RVA: 0x0021AC5C File Offset: 0x00218E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238491, RefRangeEnd = 238493, XrefRangeStart = 238485, XrefRangeEnd = 238491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(Pallet _occupant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_occupant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x0021ACA0 File Offset: 0x00218EA0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PalletSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PalletSlot>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PalletSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x0003AFC8 File Offset: 0x000391C8
		public PalletSlot(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06007C9E RID: 31902 RVA: 0x0021ACDC File Offset: 0x00218EDC
		// (set) Token: 0x06007C9F RID: 31903 RVA: 0x0003AFD1 File Offset: 0x000391D1
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06007CA0 RID: 31904 RVA: 0x0021AD04 File Offset: 0x00218F04
		// (set) Token: 0x06007CA1 RID: 31905 RVA: 0x0003AFEC File Offset: 0x000391EC
		public unsafe Pallet _occupant_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr__occupant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x06007CA2 RID: 31906 RVA: 0x0021AD34 File Offset: 0x00218F34
		// (set) Token: 0x06007CA3 RID: 31907 RVA: 0x0003B00B File Offset: 0x0003920B
		public unsafe Il2CppSystem.Action onPalletAdded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletAdded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletAdded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x06007CA4 RID: 31908 RVA: 0x0021AD64 File Offset: 0x00218F64
		// (set) Token: 0x06007CA5 RID: 31909 RVA: 0x0003B02A File Offset: 0x0003922A
		public unsafe Il2CppSystem.Action onPalletRemoved
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletRemoved);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PalletSlot.NativeFieldInfoPtr_onPalletRemoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054D0 RID: 21712
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x040054D1 RID: 21713
		private static readonly System.IntPtr NativeFieldInfoPtr__occupant_k__BackingField;

		// Token: 0x040054D2 RID: 21714
		private static readonly System.IntPtr NativeFieldInfoPtr_onPalletAdded;

		// Token: 0x040054D3 RID: 21715
		private static readonly System.IntPtr NativeFieldInfoPtr_onPalletRemoved;

		// Token: 0x040054D4 RID: 21716
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040054D5 RID: 21717
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040054D6 RID: 21718
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040054D7 RID: 21719
		private static readonly System.IntPtr NativeMethodInfoPtr_get_occupant_Public_get_Pallet_0;

		// Token: 0x040054D8 RID: 21720
		private static readonly System.IntPtr NativeMethodInfoPtr_set_occupant_Protected_set_Void_Pallet_0;

		// Token: 0x040054D9 RID: 21721
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_Pallet_0;

		// Token: 0x040054DA RID: 21722
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
