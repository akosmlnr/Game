using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000505 RID: 1285
	public class ObstructionDetector : MonoBehaviour
	{
		// Token: 0x06007096 RID: 28822 RVA: 0x001F3DA8 File Offset: 0x001F1FA8
		// Note: this type is marked as 'beforefieldinit'.
		static ObstructionDetector()
		{
			Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ObstructionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr);
			ObstructionDetector.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicle");
			ObstructionDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicles");
			ObstructionDetector.NativeFieldInfoPtr_npcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "npcs");
			ObstructionDetector.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "players");
			ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicleObstacles");
			ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "closestObstructionDistance");
			ObstructionDetector.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "range");
			ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677637);
			ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677638);
			ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677639);
			ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100677640);
		}

		// Token: 0x06007097 RID: 28823 RVA: 0x001F3EB4 File Offset: 0x001F20B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224181, XrefRangeEnd = 224192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007098 RID: 28824 RVA: 0x001F3EF0 File Offset: 0x001F20F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224192, XrefRangeEnd = 224284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007099 RID: 28825 RVA: 0x001F3F2C File Offset: 0x001F212C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224284, XrefRangeEnd = 224345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600709A RID: 28826 RVA: 0x001F3F70 File Offset: 0x001F2170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224345, XrefRangeEnd = 224374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObstructionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600709B RID: 28827 RVA: 0x0003502F File Offset: 0x0003322F
		public ObstructionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021BD RID: 8637
		// (get) Token: 0x0600709C RID: 28828 RVA: 0x001F3FAC File Offset: 0x001F21AC
		// (set) Token: 0x0600709D RID: 28829 RVA: 0x00035038 File Offset: 0x00033238
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021BE RID: 8638
		// (get) Token: 0x0600709E RID: 28830 RVA: 0x001F3FDC File Offset: 0x001F21DC
		// (set) Token: 0x0600709F RID: 28831 RVA: 0x00035057 File Offset: 0x00033257
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021BF RID: 8639
		// (get) Token: 0x060070A0 RID: 28832 RVA: 0x001F400C File Offset: 0x001F220C
		// (set) Token: 0x060070A1 RID: 28833 RVA: 0x00035076 File Offset: 0x00033276
		public unsafe List<NPC> npcs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C0 RID: 8640
		// (get) Token: 0x060070A2 RID: 28834 RVA: 0x001F403C File Offset: 0x001F223C
		// (set) Token: 0x060070A3 RID: 28835 RVA: 0x00035095 File Offset: 0x00033295
		public unsafe List<PlayerMovement> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMovement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C1 RID: 8641
		// (get) Token: 0x060070A4 RID: 28836 RVA: 0x001F406C File Offset: 0x001F226C
		// (set) Token: 0x060070A5 RID: 28837 RVA: 0x000350B4 File Offset: 0x000332B4
		public unsafe List<VehicleObstacle> vehicleObstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C2 RID: 8642
		// (get) Token: 0x060070A6 RID: 28838 RVA: 0x001F409C File Offset: 0x001F229C
		// (set) Token: 0x060070A7 RID: 28839 RVA: 0x000350D3 File Offset: 0x000332D3
		public unsafe float closestObstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance)) = value;
			}
		}

		// Token: 0x170021C3 RID: 8643
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x001F40C4 File Offset: 0x001F22C4
		// (set) Token: 0x060070A9 RID: 28841 RVA: 0x000350EE File Offset: 0x000332EE
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x04004D0F RID: 19727
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D10 RID: 19728
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x04004D11 RID: 19729
		private static readonly IntPtr NativeFieldInfoPtr_npcs;

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeFieldInfoPtr_vehicleObstacles;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeFieldInfoPtr_closestObstructionDistance;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
