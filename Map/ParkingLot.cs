using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007AF RID: 1967
	public class ParkingLot : MonoBehaviour
	{
		// Token: 0x0600B9ED RID: 47597 RVA: 0x002E5C20 File Offset: 0x002E3E20
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingLot()
		{
			Il2CppClassPointerStore<ParkingLot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingLot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr);
			ParkingLot.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "BakedGUID");
			ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<GUID>k__BackingField");
			ParkingLot.NativeFieldInfoPtr_ParkingSpots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ParkingSpots");
			ParkingLot.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "EntryPoint");
			ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "HiddenVehicleAccessPoint");
			ParkingLot.NativeFieldInfoPtr_UseExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "UseExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitAlignment");
			ParkingLot.NativeFieldInfoPtr_ExitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPoint");
			ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "ExitPointVehicleDetector");
			ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686311);
			ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686312);
			ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686313);
			ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686314);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686315);
			ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686316);
			ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686317);
			ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, 100686318);
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600B9EE RID: 47598 RVA: 0x002E5DA4 File Offset: 0x002E3FA4
		// (set) Token: 0x0600B9EF RID: 47599 RVA: 0x002E5DE0 File Offset: 0x002E3FE0
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 56602, RefRangeEnd = 56606, XrefRangeStart = 56602, XrefRangeEnd = 56606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x002E5E20 File Offset: 0x002E4020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316908, XrefRangeEnd = 316937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x002E5E54 File Offset: 0x002E4054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316937, XrefRangeEnd = 316941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x002E5E94 File Offset: 0x002E4094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316958, RefRangeEnd = 316959, XrefRangeStart = 316941, XrefRangeEnd = 316958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot GetRandomFreeSpot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingSpot>(intPtr2) : null;
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x002E5ED4 File Offset: 0x002E40D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316968, RefRangeEnd = 316970, XrefRangeStart = 316959, XrefRangeEnd = 316968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandomFreeSpotIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x002E5F10 File Offset: 0x002E4110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316998, RefRangeEnd = 317000, XrefRangeStart = 316970, XrefRangeEnd = 316998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ParkingSpot> GetFreeParkingSpots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr2) : null;
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x002E5F50 File Offset: 0x002E4150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317000, XrefRangeEnd = 317011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingLot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x0005AE0D File Offset: 0x0005900D
		public ParkingLot(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600B9F7 RID: 47607 RVA: 0x002E5F8C File Offset: 0x002E418C
		// (set) Token: 0x0600B9F8 RID: 47608 RVA: 0x0005AE16 File Offset: 0x00059016
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x002E5FB4 File Offset: 0x002E41B4
		// (set) Token: 0x0600B9FA RID: 47610 RVA: 0x0005AE35 File Offset: 0x00059035
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600B9FB RID: 47611 RVA: 0x002E5FDC File Offset: 0x002E41DC
		// (set) Token: 0x0600B9FC RID: 47612 RVA: 0x0005AE50 File Offset: 0x00059050
		public unsafe List<ParkingSpot> ParkingSpots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ParkingSpot>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ParkingSpots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600B9FD RID: 47613 RVA: 0x002E600C File Offset: 0x002E420C
		// (set) Token: 0x0600B9FE RID: 47614 RVA: 0x0005AE6F File Offset: 0x0005906F
		public unsafe Transform EntryPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_EntryPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600B9FF RID: 47615 RVA: 0x002E603C File Offset: 0x002E423C
		// (set) Token: 0x0600BA00 RID: 47616 RVA: 0x0005AE8E File Offset: 0x0005908E
		public unsafe Transform HiddenVehicleAccessPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_HiddenVehicleAccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600BA01 RID: 47617 RVA: 0x002E606C File Offset: 0x002E426C
		// (set) Token: 0x0600BA02 RID: 47618 RVA: 0x0005AEAD File Offset: 0x000590AD
		public unsafe bool UseExitPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_UseExitPoint)) = value;
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600BA03 RID: 47619 RVA: 0x002E6094 File Offset: 0x002E4294
		// (set) Token: 0x0600BA04 RID: 47620 RVA: 0x0005AEC8 File Offset: 0x000590C8
		public unsafe EParkingAlignment ExitAlignment
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitAlignment)) = value;
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600BA05 RID: 47621 RVA: 0x002E60BC File Offset: 0x002E42BC
		// (set) Token: 0x0600BA06 RID: 47622 RVA: 0x0005AEE3 File Offset: 0x000590E3
		public unsafe Transform ExitPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600BA07 RID: 47623 RVA: 0x002E60EC File Offset: 0x002E42EC
		// (set) Token: 0x0600BA08 RID: 47624 RVA: 0x0005AF02 File Offset: 0x00059102
		public unsafe VehicleDetector ExitPointVehicleDetector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingLot.NativeFieldInfoPtr_ExitPointVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D68 RID: 32104
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04007D69 RID: 32105
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04007D6A RID: 32106
		private static readonly System.IntPtr NativeFieldInfoPtr_ParkingSpots;

		// Token: 0x04007D6B RID: 32107
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryPoint;

		// Token: 0x04007D6C RID: 32108
		private static readonly System.IntPtr NativeFieldInfoPtr_HiddenVehicleAccessPoint;

		// Token: 0x04007D6D RID: 32109
		private static readonly System.IntPtr NativeFieldInfoPtr_UseExitPoint;

		// Token: 0x04007D6E RID: 32110
		private static readonly System.IntPtr NativeFieldInfoPtr_ExitAlignment;

		// Token: 0x04007D6F RID: 32111
		private static readonly System.IntPtr NativeFieldInfoPtr_ExitPoint;

		// Token: 0x04007D70 RID: 32112
		private static readonly System.IntPtr NativeFieldInfoPtr_ExitPointVehicleDetector;

		// Token: 0x04007D71 RID: 32113
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04007D72 RID: 32114
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04007D73 RID: 32115
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007D74 RID: 32116
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04007D75 RID: 32117
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomFreeSpot_Public_ParkingSpot_0;

		// Token: 0x04007D76 RID: 32118
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomFreeSpotIndex_Public_Int32_0;

		// Token: 0x04007D77 RID: 32119
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeParkingSpots_Public_List_1_ParkingSpot_0;

		// Token: 0x04007D78 RID: 32120
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C5D RID: 3165
		[ObfuscatedName("ScheduleOne.Map.ParkingLot+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E5B1 RID: 58801 RVA: 0x003635C4 File Offset: 0x003617C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParkingLot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr);
				ParkingLot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9");
				ParkingLot.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, "<>9__16_0");
				ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100686320);
				ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr, 100686321);
			}

			// Token: 0x0600E5B2 RID: 58802 RVA: 0x00363640 File Offset: 0x00361840
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingLot.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5B3 RID: 58803 RVA: 0x0036367C File Offset: 0x0036187C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316904, XrefRangeEnd = 316908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeParkingSpots_b__16_0(ParkingSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ParkingLot.__c.NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E5B4 RID: 58804 RVA: 0x0006FAFA File Offset: 0x0006DCFA
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046DC RID: 18140
			// (get) Token: 0x0600E5B5 RID: 58805 RVA: 0x003636CC File Offset: 0x003618CC
			// (set) Token: 0x0600E5B6 RID: 58806 RVA: 0x0006FB03 File Offset: 0x0006DD03
			public unsafe static ParkingLot.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046DD RID: 18141
			// (get) Token: 0x0600E5B7 RID: 58807 RVA: 0x003636F4 File Offset: 0x003618F4
			// (set) Token: 0x0600E5B8 RID: 58808 RVA: 0x0006FB15 File Offset: 0x0006DD15
			public unsafe static Il2CppSystem.Func<ParkingSpot, bool> __9__16_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<ParkingSpot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ParkingLot.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099D8 RID: 39384
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099D9 RID: 39385
			private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040099DA RID: 39386
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099DB RID: 39387
			private static readonly System.IntPtr NativeMethodInfoPtr__GetFreeParkingSpots_b__16_0_Internal_Boolean_ParkingSpot_0;
		}
	}
}
