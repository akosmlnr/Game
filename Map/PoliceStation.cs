using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007B4 RID: 1972
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x0600BA79 RID: 47737 RVA: 0x002E75B4 File Offset: 0x002E57B4
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceStation()
		{
			Il2CppClassPointerStore<PoliceStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "PoliceStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr);
			PoliceStation.NativeFieldInfoPtr_PoliceStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceStations");
			PoliceStation.NativeFieldInfoPtr_VehicleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleLimit");
			PoliceStation.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "SpawnPoint");
			PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PossessedVehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceVehiclePrefabs");
			PoliceStation.NativeFieldInfoPtr_OfficerPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "OfficerPool");
			PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<TimeSinceLastDispatch>k__BackingField");
			PoliceStation.NativeFieldInfoPtr_deployedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "deployedVehicles");
			PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686367);
			PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686368);
			PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686369);
			PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686370);
			PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686371);
			PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686372);
			PoliceStation.NativeMethodInfoPtr_CleanVehicleList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686373);
			PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686374);
			PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686375);
			PoliceStation.NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686376);
			PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686377);
			PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686378);
			PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686379);
			PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686380);
			PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100686382);
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x002E77C4 File Offset: 0x002E59C4
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x002E7800 File Offset: 0x002E5A00
		public unsafe float TimeSinceLastDispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x002E7840 File Offset: 0x002E5A40
		public unsafe int deployedVehicleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317365, XrefRangeEnd = 317386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600BA7D RID: 47741 RVA: 0x002E787C File Offset: 0x002E5A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317386, XrefRangeEnd = 317405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA7E RID: 47742 RVA: 0x002E78B8 File Offset: 0x002E5AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317405, XrefRangeEnd = 317418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA7F RID: 47743 RVA: 0x002E78EC File Offset: 0x002E5AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317418, XrefRangeEnd = 317419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x002E7920 File Offset: 0x002E5B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317419, XrefRangeEnd = 317431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanVehicleList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_CleanVehicleList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x002E7954 File Offset: 0x002E5B54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317497, RefRangeEnd = 317499, XrefRangeStart = 317431, XrefRangeEnd = 317497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref requestedOfficerCount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref beginAsSighted;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x002E79C0 File Offset: 0x002E5BC0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317508, RefRangeEnd = 317512, XrefRangeStart = 317499, XrefRangeEnd = 317508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer PullOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x002E7A00 File Offset: 0x002E5C00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317544, RefRangeEnd = 317546, XrefRangeStart = 317512, XrefRangeEnd = 317544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle CreateVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x002E7A40 File Offset: 0x002E5C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317546, XrefRangeEnd = 317556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCEnteredBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x002E7A90 File Offset: 0x002E5C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317556, XrefRangeEnd = 317562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCExitedBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x002E7AE0 File Offset: 0x002E5CE0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 317570, RefRangeEnd = 317580, XrefRangeStart = 317562, XrefRangeEnd = 317570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr2) : null;
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x002E7B20 File Offset: 0x002E5D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317580, XrefRangeEnd = 317595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x002E7B5C File Offset: 0x002E5D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317595, XrefRangeEnd = 317611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Transform_PDM_0(Transform spawnPoint)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spawnPoint);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x0005B31B File Offset: 0x0005951B
		public PoliceStation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x002E7BA0 File Offset: 0x002E5DA0
		// (set) Token: 0x0600BA8B RID: 47755 RVA: 0x0005B324 File Offset: 0x00059524
		public unsafe static List<PoliceStation> PoliceStations
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceStation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x0600BA8C RID: 47756 RVA: 0x002E7BC8 File Offset: 0x002E5DC8
		// (set) Token: 0x0600BA8D RID: 47757 RVA: 0x0005B336 File Offset: 0x00059536
		public unsafe int VehicleLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleLimit)) = value;
			}
		}

		// Token: 0x1700398A RID: 14730
		// (get) Token: 0x0600BA8E RID: 47758 RVA: 0x002E7BF0 File Offset: 0x002E5DF0
		// (set) Token: 0x0600BA8F RID: 47759 RVA: 0x0005B351 File Offset: 0x00059551
		public unsafe Transform SpawnPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398B RID: 14731
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x002E7C20 File Offset: 0x002E5E20
		// (set) Token: 0x0600BA91 RID: 47761 RVA: 0x0005B370 File Offset: 0x00059570
		public unsafe Il2CppReferenceArray<Transform> VehicleSpawnPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398C RID: 14732
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x002E7C50 File Offset: 0x002E5E50
		// (set) Token: 0x0600BA93 RID: 47763 RVA: 0x0005B38F File Offset: 0x0005958F
		public unsafe Il2CppReferenceArray<Transform> PossessedVehicleSpawnPoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398D RID: 14733
		// (get) Token: 0x0600BA94 RID: 47764 RVA: 0x002E7C80 File Offset: 0x002E5E80
		// (set) Token: 0x0600BA95 RID: 47765 RVA: 0x0005B3AE File Offset: 0x000595AE
		public unsafe Il2CppReferenceArray<LandVehicle> PoliceVehiclePrefabs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x002E7CB0 File Offset: 0x002E5EB0
		// (set) Token: 0x0600BA97 RID: 47767 RVA: 0x0005B3CD File Offset: 0x000595CD
		public unsafe List<PoliceOfficer> OfficerPool
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_OfficerPool);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_OfficerPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x002E7CE0 File Offset: 0x002E5EE0
		// (set) Token: 0x0600BA99 RID: 47769 RVA: 0x0005B3EC File Offset: 0x000595EC
		public unsafe float _TimeSinceLastDispatch_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField)) = value;
			}
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0600BA9A RID: 47770 RVA: 0x002E7D08 File Offset: 0x002E5F08
		// (set) Token: 0x0600BA9B RID: 47771 RVA: 0x0005B407 File Offset: 0x00059607
		public unsafe List<LandVehicle> deployedVehicles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007DBF RID: 32191
		private static readonly System.IntPtr NativeFieldInfoPtr_PoliceStations;

		// Token: 0x04007DC0 RID: 32192
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleLimit;

		// Token: 0x04007DC1 RID: 32193
		private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04007DC2 RID: 32194
		private static readonly System.IntPtr NativeFieldInfoPtr_VehicleSpawnPoints;

		// Token: 0x04007DC3 RID: 32195
		private static readonly System.IntPtr NativeFieldInfoPtr_PossessedVehicleSpawnPoints;

		// Token: 0x04007DC4 RID: 32196
		private static readonly System.IntPtr NativeFieldInfoPtr_PoliceVehiclePrefabs;

		// Token: 0x04007DC5 RID: 32197
		private static readonly System.IntPtr NativeFieldInfoPtr_OfficerPool;

		// Token: 0x04007DC6 RID: 32198
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField;

		// Token: 0x04007DC7 RID: 32199
		private static readonly System.IntPtr NativeFieldInfoPtr_deployedVehicles;

		// Token: 0x04007DC8 RID: 32200
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0;

		// Token: 0x04007DC9 RID: 32201
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0;

		// Token: 0x04007DCA RID: 32202
		private static readonly System.IntPtr NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0;

		// Token: 0x04007DCB RID: 32203
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007DCC RID: 32204
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007DCD RID: 32205
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007DCE RID: 32206
		private static readonly System.IntPtr NativeMethodInfoPtr_CleanVehicleList_Private_Void_0;

		// Token: 0x04007DCF RID: 32207
		private static readonly System.IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0;

		// Token: 0x04007DD0 RID: 32208
		private static readonly System.IntPtr NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0;

		// Token: 0x04007DD1 RID: 32209
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0;

		// Token: 0x04007DD2 RID: 32210
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0;

		// Token: 0x04007DD3 RID: 32211
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0;

		// Token: 0x04007DD4 RID: 32212
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0;

		// Token: 0x04007DD5 RID: 32213
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007DD6 RID: 32214
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0;

		// Token: 0x02000C62 RID: 3170
		[OriginalName("Assembly-CSharp.dll", "", "EDispatchType")]
		public enum EDispatchType
		{
			// Token: 0x040099F2 RID: 39410
			Auto,
			// Token: 0x040099F3 RID: 39411
			UseVehicle,
			// Token: 0x040099F4 RID: 39412
			OnFoot
		}

		// Token: 0x02000C63 RID: 3171
		[ObfuscatedName("ScheduleOne.Map.PoliceStation+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E5CF RID: 58831 RVA: 0x00363B34 File Offset: 0x00361D34
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr);
				PoliceStation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9");
				PoliceStation.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9__14_0");
				PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100686384);
				PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100686385);
			}

			// Token: 0x0600E5D0 RID: 58832 RVA: 0x00363BB0 File Offset: 0x00361DB0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E5D1 RID: 58833 RVA: 0x00363BEC File Offset: 0x00361DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317361, XrefRangeEnd = 317365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_deployedVehicleCount_b__14_0(LandVehicle v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E5D2 RID: 58834 RVA: 0x0006FBB6 File Offset: 0x0006DDB6
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046E5 RID: 18149
			// (get) Token: 0x0600E5D3 RID: 58835 RVA: 0x00363C3C File Offset: 0x00361E3C
			// (set) Token: 0x0600E5D4 RID: 58836 RVA: 0x0006FBBF File Offset: 0x0006DDBF
			public unsafe static PoliceStation.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046E6 RID: 18150
			// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x00363C64 File Offset: 0x00361E64
			// (set) Token: 0x0600E5D6 RID: 58838 RVA: 0x0006FBD1 File Offset: 0x0006DDD1
			public unsafe static Il2CppSystem.Func<LandVehicle, bool> __9__14_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<LandVehicle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099F5 RID: 39413
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099F6 RID: 39414
			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x040099F7 RID: 39415
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099F8 RID: 39416
			private static readonly System.IntPtr NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0;
		}
	}
}
