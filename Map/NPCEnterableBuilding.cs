using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020007AB RID: 1963
	public class NPCEnterableBuilding : MonoBehaviour
	{
		// Token: 0x0600B9B1 RID: 47537 RVA: 0x002E4FF8 File Offset: 0x002E31F8
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEnterableBuilding()
		{
			Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCEnterableBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr);
			NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "DOOR_SOUND_DISTANCE_LIMIT");
			NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<GUID>k__BackingField");
			NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BuildingName");
			NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BakedGUID");
			NPCEnterableBuilding.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Doors");
			NPCEnterableBuilding.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Occupants");
			NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686269);
			NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686270);
			NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686271);
			NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686272);
			NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686273);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686274);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686275);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686276);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686277);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686278);
			NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100686279);
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600B9B2 RID: 47538 RVA: 0x002E517C File Offset: 0x002E337C
		// (set) Token: 0x0600B9B3 RID: 47539 RVA: 0x002E51B8 File Offset: 0x002E33B8
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600B9B4 RID: 47540 RVA: 0x002E51F8 File Offset: 0x002E33F8
		public unsafe int OccupantCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 316504, RefRangeEnd = 316505, XrefRangeStart = 316503, XrefRangeEnd = 316504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x002E5234 File Offset: 0x002E3434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316532, RefRangeEnd = 316533, XrefRangeStart = 316505, XrefRangeEnd = 316532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x002E5270 File Offset: 0x002E3470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316533, XrefRangeEnd = 316537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x002E52B0 File Offset: 0x002E34B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316581, RefRangeEnd = 316582, XrefRangeStart = 316537, XrefRangeEnd = 316581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCEnteredBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x002E5300 File Offset: 0x002E3500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316624, RefRangeEnd = 316625, XrefRangeStart = 316582, XrefRangeEnd = 316624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCExitedBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9B9 RID: 47545 RVA: 0x002E5350 File Offset: 0x002E3550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316625, XrefRangeEnd = 316629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDoors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9BA RID: 47546 RVA: 0x002E5384 File Offset: 0x002E3584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316629, XrefRangeEnd = 316650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetSummonableNPCs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x002E53C4 File Offset: 0x002E35C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316676, RefRangeEnd = 316679, XrefRangeStart = 316650, XrefRangeEnd = 316676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref useableOnly;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr2) : null;
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x002E5420 File Offset: 0x002E3620
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316690, RefRangeEnd = 316692, XrefRangeStart = 316679, XrefRangeEnd = 316690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEnterableBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B9BD RID: 47549 RVA: 0x0005AC65 File Offset: 0x00058E65
		public NPCEnterableBuilding(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600B9BE RID: 47550 RVA: 0x002E545C File Offset: 0x002E365C
		// (set) Token: 0x0600B9BF RID: 47551 RVA: 0x0005AC6E File Offset: 0x00058E6E
		public unsafe static float DOOR_SOUND_DISTANCE_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600B9C0 RID: 47552 RVA: 0x002E5478 File Offset: 0x002E3678
		// (set) Token: 0x0600B9C1 RID: 47553 RVA: 0x0005AC7C File Offset: 0x00058E7C
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600B9C2 RID: 47554 RVA: 0x002E54A0 File Offset: 0x002E36A0
		// (set) Token: 0x0600B9C3 RID: 47555 RVA: 0x0005AC97 File Offset: 0x00058E97
		public unsafe string BuildingName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600B9C4 RID: 47556 RVA: 0x002E54C8 File Offset: 0x002E36C8
		// (set) Token: 0x0600B9C5 RID: 47557 RVA: 0x0005ACB6 File Offset: 0x00058EB6
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600B9C6 RID: 47558 RVA: 0x002E54F0 File Offset: 0x002E36F0
		// (set) Token: 0x0600B9C7 RID: 47559 RVA: 0x0005ACD5 File Offset: 0x00058ED5
		public unsafe Il2CppReferenceArray<StaticDoor> Doors
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticDoor>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600B9C8 RID: 47560 RVA: 0x002E5520 File Offset: 0x002E3720
		// (set) Token: 0x0600B9C9 RID: 47561 RVA: 0x0005ACF4 File Offset: 0x00058EF4
		public unsafe List<NPC> Occupants
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007D42 RID: 32066
		private static readonly System.IntPtr NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT;

		// Token: 0x04007D43 RID: 32067
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04007D44 RID: 32068
		private static readonly System.IntPtr NativeFieldInfoPtr_BuildingName;

		// Token: 0x04007D45 RID: 32069
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04007D46 RID: 32070
		private static readonly System.IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x04007D47 RID: 32071
		private static readonly System.IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x04007D48 RID: 32072
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04007D49 RID: 32073
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04007D4A RID: 32074
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0;

		// Token: 0x04007D4B RID: 32075
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007D4C RID: 32076
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04007D4D RID: 32077
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04007D4E RID: 32078
		private static readonly System.IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04007D4F RID: 32079
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDoors_Public_Void_0;

		// Token: 0x04007D50 RID: 32080
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0;

		// Token: 0x04007D51 RID: 32081
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0;

		// Token: 0x04007D52 RID: 32082
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C59 RID: 3161
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E580 RID: 58752 RVA: 0x00362C88 File Offset: 0x00360E88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr);
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9");
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9__16_0");
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100686281);
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100686282);
			}

			// Token: 0x0600E581 RID: 58753 RVA: 0x00362D04 File Offset: 0x00360F04
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E582 RID: 58754 RVA: 0x00362D40 File Offset: 0x00360F40
			[CallerCount(0)]
			public unsafe bool _GetSummonableNPCs_b__16_0(NPC npc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E583 RID: 58755 RVA: 0x0006F990 File Offset: 0x0006DB90
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046CC RID: 18124
			// (get) Token: 0x0600E584 RID: 58756 RVA: 0x00362D90 File Offset: 0x00360F90
			// (set) Token: 0x0600E585 RID: 58757 RVA: 0x0006F999 File Offset: 0x0006DB99
			public unsafe static NPCEnterableBuilding.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046CD RID: 18125
			// (get) Token: 0x0600E586 RID: 58758 RVA: 0x00362DB8 File Offset: 0x00360FB8
			// (set) Token: 0x0600E587 RID: 58759 RVA: 0x0006F9AB File Offset: 0x0006DBAB
			public unsafe static Il2CppSystem.Func<NPC, bool> __9__16_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099BB RID: 39355
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099BC RID: 39356
			private static readonly System.IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040099BD RID: 39357
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099BE RID: 39358
			private static readonly System.IntPtr NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000C5A RID: 3162
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E588 RID: 58760 RVA: 0x00362DE0 File Offset: 0x00360FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "useableOnly");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "pos");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100686283);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100686284);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100686285);
			}

			// Token: 0x0600E589 RID: 58761 RVA: 0x00362E70 File Offset: 0x00361070
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E58A RID: 58762 RVA: 0x00362EAC File Offset: 0x003610AC
			[CallerCount(0)]
			public unsafe bool _GetClosestDoor_b__0(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E58B RID: 58763 RVA: 0x00362EFC File Offset: 0x003610FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316498, XrefRangeEnd = 316503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetClosestDoor_b__1(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E58C RID: 58764 RVA: 0x0006F9BD File Offset: 0x0006DBBD
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046CE RID: 18126
			// (get) Token: 0x0600E58D RID: 58765 RVA: 0x00362F4C File Offset: 0x0036114C
			// (set) Token: 0x0600E58E RID: 58766 RVA: 0x0006F9C6 File Offset: 0x0006DBC6
			public unsafe bool useableOnly
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly)) = value;
				}
			}

			// Token: 0x170046CF RID: 18127
			// (get) Token: 0x0600E58F RID: 58767 RVA: 0x00362F74 File Offset: 0x00361174
			// (set) Token: 0x0600E590 RID: 58768 RVA: 0x0006F9E1 File Offset: 0x0006DBE1
			public unsafe Vector3 pos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x040099BF RID: 39359
			private static readonly System.IntPtr NativeFieldInfoPtr_useableOnly;

			// Token: 0x040099C0 RID: 39360
			private static readonly System.IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040099C1 RID: 39361
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099C2 RID: 39362
			private static readonly System.IntPtr NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0;

			// Token: 0x040099C3 RID: 39363
			private static readonly System.IntPtr NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0;
		}
	}
}
