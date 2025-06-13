using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007B0 RID: 1968
	public class ParkingSpot : MonoBehaviour
	{
		// Token: 0x0600BA09 RID: 47625 RVA: 0x002E611C File Offset: 0x002E431C
		// Note: this type is marked as 'beforefieldinit'.
		static ParkingSpot()
		{
			Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ParkingSpot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr);
			ParkingSpot.NativeFieldInfoPtr_ParentLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "ParentLot");
			ParkingSpot.NativeFieldInfoPtr_AlignmentPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "AlignmentPoint");
			ParkingSpot.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "Alignment");
			ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "OccupantVehicle_Readonly");
			ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, "<OccupantVehicle>k__BackingField");
			ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100686322);
			ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100686323);
			ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100686324);
			ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100686325);
			ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100686326);
			ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr, 100686327);
		}

		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600BA0A RID: 47626 RVA: 0x002E6228 File Offset: 0x002E4428
		// (set) Token: 0x0600BA0B RID: 47627 RVA: 0x002E6268 File Offset: 0x002E4468
		public unsafe LandVehicle OccupantVehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x002E62AC File Offset: 0x002E44AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317011, XrefRangeEnd = 317043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x002E62E0 File Offset: 0x002E44E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317043, XrefRangeEnd = 317066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x002E6314 File Offset: 0x002E4514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317068, RefRangeEnd = 317070, XrefRangeStart = 317066, XrefRangeEnd = 317068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOccupant(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x002E6358 File Offset: 0x002E4558
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParkingSpot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParkingSpot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParkingSpot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x0005AF21 File Offset: 0x00059121
		public ParkingSpot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600BA11 RID: 47633 RVA: 0x002E6394 File Offset: 0x002E4594
		// (set) Token: 0x0600BA12 RID: 47634 RVA: 0x0005AF2A File Offset: 0x0005912A
		public unsafe ParkingLot ParentLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_ParentLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600BA13 RID: 47635 RVA: 0x002E63C4 File Offset: 0x002E45C4
		// (set) Token: 0x0600BA14 RID: 47636 RVA: 0x0005AF49 File Offset: 0x00059149
		public unsafe Transform AlignmentPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_AlignmentPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600BA15 RID: 47637 RVA: 0x002E63F4 File Offset: 0x002E45F4
		// (set) Token: 0x0600BA16 RID: 47638 RVA: 0x0005AF68 File Offset: 0x00059168
		public unsafe EParkingAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600BA17 RID: 47639 RVA: 0x002E641C File Offset: 0x002E461C
		// (set) Token: 0x0600BA18 RID: 47640 RVA: 0x0005AF83 File Offset: 0x00059183
		public unsafe LandVehicle OccupantVehicle_Readonly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr_OccupantVehicle_Readonly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600BA19 RID: 47641 RVA: 0x002E644C File Offset: 0x002E464C
		// (set) Token: 0x0600BA1A RID: 47642 RVA: 0x0005AFA2 File Offset: 0x000591A2
		public unsafe LandVehicle _OccupantVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParkingSpot.NativeFieldInfoPtr__OccupantVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D79 RID: 32121
		private static readonly IntPtr NativeFieldInfoPtr_ParentLot;

		// Token: 0x04007D7A RID: 32122
		private static readonly IntPtr NativeFieldInfoPtr_AlignmentPoint;

		// Token: 0x04007D7B RID: 32123
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x04007D7C RID: 32124
		private static readonly IntPtr NativeFieldInfoPtr_OccupantVehicle_Readonly;

		// Token: 0x04007D7D RID: 32125
		private static readonly IntPtr NativeFieldInfoPtr__OccupantVehicle_k__BackingField;

		// Token: 0x04007D7E RID: 32126
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantVehicle_Public_get_LandVehicle_0;

		// Token: 0x04007D7F RID: 32127
		private static readonly IntPtr NativeMethodInfoPtr_set_OccupantVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04007D80 RID: 32128
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007D81 RID: 32129
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04007D82 RID: 32130
		private static readonly IntPtr NativeMethodInfoPtr_SetOccupant_Public_Void_LandVehicle_0;

		// Token: 0x04007D83 RID: 32131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
