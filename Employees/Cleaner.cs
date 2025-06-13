using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000427 RID: 1063
	public class Cleaner : Employee
	{
		// Token: 0x060058F0 RID: 22768 RVA: 0x001A0B68 File Offset: 0x0019ED68
		// Note: this type is marked as 'beforefieldinit'.
		static Cleaner()
		{
			Il2CppClassPointerStore<Cleaner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Cleaner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner>.NativeClassPtr);
			Cleaner.NativeFieldInfoPtr_MAX_ASSIGNED_BINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "MAX_ASSIGNED_BINS");
			Cleaner.NativeFieldInfoPtr_TrashGrabberDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "TrashGrabberDef");
			Cleaner.NativeFieldInfoPtr_PickUpTrashBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "PickUpTrashBehaviour");
			Cleaner.NativeFieldInfoPtr_EmptyTrashGrabberBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "EmptyTrashGrabberBehaviour");
			Cleaner.NativeFieldInfoPtr_BagTrashCanBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "BagTrashCanBehaviour");
			Cleaner.NativeFieldInfoPtr_DisposeTrashBagBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "DisposeTrashBagBehaviour");
			Cleaner.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "typeIcon");
			Cleaner.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "configReplicator");
			Cleaner.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "WorldspaceUIPrefab");
			Cleaner.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "uiPoint");
			Cleaner.NativeFieldInfoPtr__trashGrabberInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<trashGrabberInstance>k__BackingField");
			Cleaner.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<configuration>k__BackingField");
			Cleaner.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Cleaner.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Cleaner.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Cleaner.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted");
			Cleaner.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.CleanerAssembly-CSharp.dll_Excuted");
			Cleaner.NativeMethodInfoPtr_get_trashGrabberInstance_Public_get_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674569);
			Cleaner.NativeMethodInfoPtr_set_trashGrabberInstance_Private_set_Void_TrashGrabberInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674570);
			Cleaner.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674571);
			Cleaner.NativeMethodInfoPtr_get_configuration_Protected_get_CleanerConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674572);
			Cleaner.NativeMethodInfoPtr_set_configuration_Protected_set_Void_CleanerConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674573);
			Cleaner.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674574);
			Cleaner.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674575);
			Cleaner.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674576);
			Cleaner.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674577);
			Cleaner.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674578);
			Cleaner.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674579);
			Cleaner.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674580);
			Cleaner.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674581);
			Cleaner.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674582);
			Cleaner.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674583);
			Cleaner.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674584);
			Cleaner.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674585);
			Cleaner.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674586);
			Cleaner.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674587);
			Cleaner.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674588);
			Cleaner.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674589);
			Cleaner.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674590);
			Cleaner.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674591);
			Cleaner.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674592);
			Cleaner.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674593);
			Cleaner.NativeMethodInfoPtr_GetFirstNonFullBin_Private_TrashContainerItem_Il2CppReferenceArray_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674594);
			Cleaner.NativeMethodInfoPtr_SetIdle_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674595);
			Cleaner.NativeMethodInfoPtr_GetTrashContainersOrderedByDistance_Private_Il2CppReferenceArray_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674596);
			Cleaner.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674597);
			Cleaner.NativeMethodInfoPtr_EnsureTrashGrabberInInventory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674598);
			Cleaner.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674599);
			Cleaner.NativeMethodInfoPtr_GetTrashGrabberAmount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674600);
			Cleaner.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674601);
			Cleaner.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674602);
			Cleaner.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674603);
			Cleaner.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674604);
			Cleaner.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674605);
			Cleaner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674606);
			Cleaner.NativeMethodInfoPtr__GetTrashContainersOrderedByDistance_b__53_0_Private_Int32_TrashContainerItem_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674607);
			Cleaner.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674608);
			Cleaner.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674609);
			Cleaner.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674610);
			Cleaner.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674611);
			Cleaner.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674612);
			Cleaner.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674613);
			Cleaner.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674614);
			Cleaner.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674615);
			Cleaner.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Cleaner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674616);
			Cleaner.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, 100674617);
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x060058F1 RID: 22769 RVA: 0x001A10C0 File Offset: 0x0019F2C0
		// (set) Token: 0x060058F2 RID: 22770 RVA: 0x001A1100 File Offset: 0x0019F300
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 188282, RefRangeEnd = 188290, XrefRangeStart = 188282, XrefRangeEnd = 188290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_trashGrabberInstance_Public_get_TrashGrabberInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_trashGrabberInstance_Private_set_Void_TrashGrabberInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x060058F3 RID: 22771 RVA: 0x001A1144 File Offset: 0x0019F344
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 188302, RefRangeEnd = 188309, XrefRangeStart = 188302, XrefRangeEnd = 188309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x060058F4 RID: 22772 RVA: 0x001A1184 File Offset: 0x0019F384
		// (set) Token: 0x060058F5 RID: 22773 RVA: 0x001A11C4 File Offset: 0x0019F3C4
		public unsafe CleanerConfiguration configuration
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 188302, RefRangeEnd = 188309, XrefRangeStart = 188302, XrefRangeEnd = 188309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_configuration_Protected_get_CleanerConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfiguration>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_configuration_Protected_set_Void_CleanerConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x060058F6 RID: 22774 RVA: 0x001A1208 File Offset: 0x0019F408
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x060058F7 RID: 22775 RVA: 0x001A1248 File Offset: 0x0019F448
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 188877, RefRangeEnd = 188912, XrefRangeStart = 188877, XrefRangeEnd = 188877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x060058F8 RID: 22776 RVA: 0x001A1284 File Offset: 0x0019F484
		// (set) Token: 0x060058F9 RID: 22777 RVA: 0x001A12C4 File Offset: 0x0019F4C4
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 187604, RefRangeEnd = 187629, XrefRangeStart = 187604, XrefRangeEnd = 187629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188912, XrefRangeEnd = 188913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x001A1308 File Offset: 0x0019F508
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x001A1348 File Offset: 0x0019F548
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 188913, RefRangeEnd = 188924, XrefRangeStart = 188913, XrefRangeEnd = 188913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 188932, RefRangeEnd = 188934, XrefRangeStart = 188924, XrefRangeEnd = 188932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x001A138C File Offset: 0x0019F58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188934, XrefRangeEnd = 188956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x060058FD RID: 22781 RVA: 0x001A13D0 File Offset: 0x0019F5D0
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 187600, RefRangeEnd = 187604, XrefRangeStart = 187600, XrefRangeEnd = 187604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x060058FE RID: 22782 RVA: 0x001A1410 File Offset: 0x0019F610
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 51237, RefRangeEnd = 51239, XrefRangeStart = 51237, XrefRangeEnd = 51239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x060058FF RID: 22783 RVA: 0x001A1450 File Offset: 0x0019F650
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06005900 RID: 22784 RVA: 0x001A1490 File Offset: 0x0019F690
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06005901 RID: 22785 RVA: 0x001A14CC File Offset: 0x0019F6CC
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x001A150C File Offset: 0x0019F70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188956, XrefRangeEnd = 188965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref warp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x001A1568 File Offset: 0x0019F768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x001A15A4 File Offset: 0x0019F7A4
		[CallerCount(0)]
		public unsafe override void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x001A15E0 File Offset: 0x0019F7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188965, XrefRangeEnd = 188976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x001A161C File Offset: 0x0019F81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188976, XrefRangeEnd = 188994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x001A166C File Offset: 0x0019F86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188994, XrefRangeEnd = 189011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x001A16B0 File Offset: 0x0019F8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189011, XrefRangeEnd = 189024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x001A16EC File Offset: 0x0019F8EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189066, RefRangeEnd = 189067, XrefRangeStart = 189024, XrefRangeEnd = 189066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartNewTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x001A1720 File Offset: 0x0019F920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189067, XrefRangeEnd = 189085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerItem GetFirstNonFullBin(Il2CppReferenceArray<TrashContainerItem> bins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bins);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_GetFirstNonFullBin_Private_TrashContainerItem_Il2CppReferenceArray_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainerItem>(intPtr2) : null;
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x001A1770 File Offset: 0x0019F970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189085, XrefRangeEnd = 189093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIdle(bool idle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref idle;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_SetIdle_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x001A17BC File Offset: 0x0019F9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189093, XrefRangeEnd = 189105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashContainerItem> GetTrashContainersOrderedByDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_GetTrashContainersOrderedByDistance_Private_Il2CppReferenceArray_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashContainerItem>>(intPtr2) : null;
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x001A17FC File Offset: 0x0019F9FC
		[CallerCount(0)]
		public unsafe override EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
		}

		// Token: 0x0600590E RID: 22798 RVA: 0x001A1848 File Offset: 0x0019FA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189105, XrefRangeEnd = 189112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureTrashGrabberInInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_EnsureTrashGrabberInInventory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600590F RID: 22799 RVA: 0x001A187C File Offset: 0x0019FA7C
		[CallerCount(0)]
		public unsafe bool AnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005910 RID: 22800 RVA: 0x001A18B8 File Offset: 0x0019FAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189112, XrefRangeEnd = 189114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrashGrabberAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_GetTrashGrabberAmount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005911 RID: 22801 RVA: 0x001A18F4 File Offset: 0x0019FAF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 189141, RefRangeEnd = 189142, XrefRangeStart = 189114, XrefRangeEnd = 189141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
		}

		// Token: 0x06005912 RID: 22802 RVA: 0x001A1934 File Offset: 0x0019FB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189142, XrefRangeEnd = 189146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005913 RID: 22803 RVA: 0x001A1968 File Offset: 0x0019FB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189146, XrefRangeEnd = 189155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
		}

		// Token: 0x06005914 RID: 22804 RVA: 0x001A19B4 File Offset: 0x0019FBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189155, XrefRangeEnd = 189159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr2) : null;
		}

		// Token: 0x06005915 RID: 22805 RVA: 0x001A1A00 File Offset: 0x0019FC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189159, XrefRangeEnd = 189165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x06005916 RID: 22806 RVA: 0x001A1A5C File Offset: 0x0019FC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cleaner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005917 RID: 22807 RVA: 0x001A1A98 File Offset: 0x0019FC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189165, XrefRangeEnd = 189184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _GetTrashContainersOrderedByDistance_b__53_0(TrashContainerItem x, TrashContainerItem y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr__GetTrashContainersOrderedByDistance_b__53_0_Private_Int32_TrashContainerItem_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005918 RID: 22808 RVA: 0x001A1AF8 File Offset: 0x0019FCF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189184, XrefRangeEnd = 189208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005919 RID: 22809 RVA: 0x001A1B34 File Offset: 0x0019FD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189208, XrefRangeEnd = 189209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600591A RID: 22810 RVA: 0x001A1B70 File Offset: 0x0019FD70
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600591B RID: 22811 RVA: 0x001A1BAC File Offset: 0x0019FDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189209, XrefRangeEnd = 189219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x001A1BF0 File Offset: 0x0019FDF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188932, RefRangeEnd = 188934, XrefRangeStart = 188932, XrefRangeEnd = 188934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x001A1C34 File Offset: 0x0019FE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189219, XrefRangeEnd = 189223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x0600591E RID: 22814 RVA: 0x001A1C98 File Offset: 0x0019FE98
		// (set) Token: 0x0600591F RID: 22815 RVA: 0x001A1CD8 File Offset: 0x0019FED8
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 188913, RefRangeEnd = 188924, XrefRangeStart = 188913, XrefRangeEnd = 188924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 189232, RefRangeEnd = 189233, XrefRangeStart = 189223, XrefRangeEnd = 189232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x001A1D28 File Offset: 0x0019FF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189233, XrefRangeEnd = 189237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Employees_Cleaner(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Cleaner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005921 RID: 22817 RVA: 0x001A1D9C File Offset: 0x0019FF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cleaner.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005922 RID: 22818 RVA: 0x0002A2D1 File Offset: 0x000284D1
		public Cleaner(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x06005923 RID: 22819 RVA: 0x001A1DD8 File Offset: 0x0019FFD8
		// (set) Token: 0x06005924 RID: 22820 RVA: 0x0002A2DA File Offset: 0x000284DA
		public unsafe static int MAX_ASSIGNED_BINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Cleaner.NativeFieldInfoPtr_MAX_ASSIGNED_BINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cleaner.NativeFieldInfoPtr_MAX_ASSIGNED_BINS, (void*)(&value));
			}
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x06005925 RID: 22821 RVA: 0x001A1DF4 File Offset: 0x0019FFF4
		// (set) Token: 0x06005926 RID: 22822 RVA: 0x0002A2E8 File Offset: 0x000284E8
		public unsafe TrashGrabberDefinition TrashGrabberDef
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_TrashGrabberDef);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_TrashGrabberDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x06005927 RID: 22823 RVA: 0x001A1E24 File Offset: 0x001A0024
		// (set) Token: 0x06005928 RID: 22824 RVA: 0x0002A307 File Offset: 0x00028507
		public unsafe PickUpTrashBehaviour PickUpTrashBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_PickUpTrashBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PickUpTrashBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_PickUpTrashBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x06005929 RID: 22825 RVA: 0x001A1E54 File Offset: 0x001A0054
		// (set) Token: 0x0600592A RID: 22826 RVA: 0x0002A326 File Offset: 0x00028526
		public unsafe EmptyTrashGrabberBehaviour EmptyTrashGrabberBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_EmptyTrashGrabberBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmptyTrashGrabberBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_EmptyTrashGrabberBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600592B RID: 22827 RVA: 0x001A1E84 File Offset: 0x001A0084
		// (set) Token: 0x0600592C RID: 22828 RVA: 0x0002A345 File Offset: 0x00028545
		public unsafe BagTrashCanBehaviour BagTrashCanBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_BagTrashCanBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BagTrashCanBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_BagTrashCanBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600592D RID: 22829 RVA: 0x001A1EB4 File Offset: 0x001A00B4
		// (set) Token: 0x0600592E RID: 22830 RVA: 0x0002A364 File Offset: 0x00028564
		public unsafe DisposeTrashBagBehaviour DisposeTrashBagBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_DisposeTrashBagBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisposeTrashBagBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_DisposeTrashBagBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x0600592F RID: 22831 RVA: 0x001A1EE4 File Offset: 0x001A00E4
		// (set) Token: 0x06005930 RID: 22832 RVA: 0x0002A383 File Offset: 0x00028583
		public unsafe Sprite typeIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_typeIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x06005931 RID: 22833 RVA: 0x001A1F14 File Offset: 0x001A0114
		// (set) Token: 0x06005932 RID: 22834 RVA: 0x0002A3A2 File Offset: 0x000285A2
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_configReplicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x06005933 RID: 22835 RVA: 0x001A1F44 File Offset: 0x001A0144
		// (set) Token: 0x06005934 RID: 22836 RVA: 0x0002A3C1 File Offset: 0x000285C1
		public unsafe CleanerUIElement WorldspaceUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_WorldspaceUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB6 RID: 6838
		// (get) Token: 0x06005935 RID: 22837 RVA: 0x001A1F74 File Offset: 0x001A0174
		// (set) Token: 0x06005936 RID: 22838 RVA: 0x0002A3E0 File Offset: 0x000285E0
		public unsafe Transform uiPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_uiPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB7 RID: 6839
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x001A1FA4 File Offset: 0x001A01A4
		// (set) Token: 0x06005938 RID: 22840 RVA: 0x0002A3FF File Offset: 0x000285FF
		public unsafe TrashGrabberInstance _trashGrabberInstance_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__trashGrabberInstance_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__trashGrabberInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x06005939 RID: 22841 RVA: 0x001A1FD4 File Offset: 0x001A01D4
		// (set) Token: 0x0600593A RID: 22842 RVA: 0x0002A41E File Offset: 0x0002861E
		public unsafe CleanerConfiguration _configuration_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__configuration_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CleanerConfiguration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600593B RID: 22843 RVA: 0x001A2004 File Offset: 0x001A0204
		// (set) Token: 0x0600593C RID: 22844 RVA: 0x0002A43D File Offset: 0x0002863D
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600593D RID: 22845 RVA: 0x001A2034 File Offset: 0x001A0234
		// (set) Token: 0x0600593E RID: 22846 RVA: 0x0002A45C File Offset: 0x0002865C
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600593F RID: 22847 RVA: 0x001A2064 File Offset: 0x001A0264
		// (set) Token: 0x06005940 RID: 22848 RVA: 0x0002A47B File Offset: 0x0002867B
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06005941 RID: 22849 RVA: 0x001A2094 File Offset: 0x001A0294
		// (set) Token: 0x06005942 RID: 22850 RVA: 0x0002A49A File Offset: 0x0002869A
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06005943 RID: 22851 RVA: 0x001A20BC File Offset: 0x001A02BC
		// (set) Token: 0x06005944 RID: 22852 RVA: 0x0002A4B5 File Offset: 0x000286B5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003C6C RID: 15468
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ASSIGNED_BINS;

		// Token: 0x04003C6D RID: 15469
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashGrabberDef;

		// Token: 0x04003C6E RID: 15470
		private static readonly System.IntPtr NativeFieldInfoPtr_PickUpTrashBehaviour;

		// Token: 0x04003C6F RID: 15471
		private static readonly System.IntPtr NativeFieldInfoPtr_EmptyTrashGrabberBehaviour;

		// Token: 0x04003C70 RID: 15472
		private static readonly System.IntPtr NativeFieldInfoPtr_BagTrashCanBehaviour;

		// Token: 0x04003C71 RID: 15473
		private static readonly System.IntPtr NativeFieldInfoPtr_DisposeTrashBagBehaviour;

		// Token: 0x04003C72 RID: 15474
		private static readonly System.IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003C73 RID: 15475
		private static readonly System.IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003C74 RID: 15476
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003C75 RID: 15477
		private static readonly System.IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003C76 RID: 15478
		private static readonly System.IntPtr NativeFieldInfoPtr__trashGrabberInstance_k__BackingField;

		// Token: 0x04003C77 RID: 15479
		private static readonly System.IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003C78 RID: 15480
		private static readonly System.IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003C79 RID: 15481
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003C7A RID: 15482
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003C7B RID: 15483
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003C7C RID: 15484
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003C7D RID: 15485
		private static readonly System.IntPtr NativeMethodInfoPtr_get_trashGrabberInstance_Public_get_TrashGrabberInstance_0;

		// Token: 0x04003C7E RID: 15486
		private static readonly System.IntPtr NativeMethodInfoPtr_set_trashGrabberInstance_Private_set_Void_TrashGrabberInstance_0;

		// Token: 0x04003C7F RID: 15487
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003C80 RID: 15488
		private static readonly System.IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_CleanerConfiguration_0;

		// Token: 0x04003C81 RID: 15489
		private static readonly System.IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_CleanerConfiguration_0;

		// Token: 0x04003C82 RID: 15490
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003C83 RID: 15491
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003C84 RID: 15492
		private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003C85 RID: 15493
		private static readonly System.IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003C86 RID: 15494
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003C87 RID: 15495
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003C88 RID: 15496
		private static readonly System.IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003C89 RID: 15497
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003C8A RID: 15498
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003C8B RID: 15499
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003C8C RID: 15500
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003C8D RID: 15501
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003C8E RID: 15502
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0;

		// Token: 0x04003C8F RID: 15503
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0;

		// Token: 0x04003C90 RID: 15504
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0;

		// Token: 0x04003C91 RID: 15505
		private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003C92 RID: 15506
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003C93 RID: 15507
		private static readonly System.IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003C94 RID: 15508
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04003C95 RID: 15509
		private static readonly System.IntPtr NativeMethodInfoPtr_TryStartNewTask_Private_Void_0;

		// Token: 0x04003C96 RID: 15510
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstNonFullBin_Private_TrashContainerItem_Il2CppReferenceArray_1_TrashContainerItem_0;

		// Token: 0x04003C97 RID: 15511
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIdle_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003C98 RID: 15512
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTrashContainersOrderedByDistance_Private_Il2CppReferenceArray_1_TrashContainerItem_0;

		// Token: 0x04003C99 RID: 15513
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0;

		// Token: 0x04003C9A RID: 15514
		private static readonly System.IntPtr NativeMethodInfoPtr_EnsureTrashGrabberInInventory_Private_Void_0;

		// Token: 0x04003C9B RID: 15515
		private static readonly System.IntPtr NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0;

		// Token: 0x04003C9C RID: 15516
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTrashGrabberAmount_Private_Int32_0;

		// Token: 0x04003C9D RID: 15517
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003C9E RID: 15518
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003C9F RID: 15519
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04003CA0 RID: 15520
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x04003CA1 RID: 15521
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003CA2 RID: 15522
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003CA3 RID: 15523
		private static readonly System.IntPtr NativeMethodInfoPtr__GetTrashContainersOrderedByDistance_b__53_0_Private_Int32_TrashContainerItem_TrashContainerItem_0;

		// Token: 0x04003CA4 RID: 15524
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003CA5 RID: 15525
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003CA6 RID: 15526
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003CA7 RID: 15527
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003CA8 RID: 15528
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003CA9 RID: 15529
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003CAA RID: 15530
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003CAB RID: 15531
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003CAC RID: 15532
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Cleaner_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003CAD RID: 15533
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A19 RID: 2585
		[ObfuscatedName("ScheduleOne.Employees.Cleaner+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D1BD RID: 53693 RVA: 0x0032B1EC File Offset: 0x003293EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr);
				Cleaner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, "<>9");
				Cleaner.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, "<>9__51_0");
				Cleaner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, 100674619);
				Cleaner.__c.NativeMethodInfoPtr__GetFirstNonFullBin_b__51_0_Internal_Boolean_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr, 100674620);
			}

			// Token: 0x0600D1BE RID: 53694 RVA: 0x0032B268 File Offset: 0x00329468
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1BF RID: 53695 RVA: 0x0032B2A4 File Offset: 0x003294A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188855, XrefRangeEnd = 188856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFirstNonFullBin_b__51_0(TrashContainerItem bin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bin);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c.NativeMethodInfoPtr__GetFirstNonFullBin_b__51_0_Internal_Boolean_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D1C0 RID: 53696 RVA: 0x00065AE4 File Offset: 0x00063CE4
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004105 RID: 16645
			// (get) Token: 0x0600D1C1 RID: 53697 RVA: 0x0032B2F4 File Offset: 0x003294F4
			// (set) Token: 0x0600D1C2 RID: 53698 RVA: 0x00065AED File Offset: 0x00063CED
			public unsafe static Cleaner.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Cleaner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Cleaner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004106 RID: 16646
			// (get) Token: 0x0600D1C3 RID: 53699 RVA: 0x0032B31C File Offset: 0x0032951C
			// (set) Token: 0x0600D1C4 RID: 53700 RVA: 0x00065AFF File Offset: 0x00063CFF
			public unsafe static Il2CppSystem.Func<TrashContainerItem, bool> __9__51_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Cleaner.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<TrashContainerItem, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Cleaner.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DDB RID: 36315
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DDC RID: 36316
			private static readonly System.IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x04008DDD RID: 36317
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DDE RID: 36318
			private static readonly System.IntPtr NativeMethodInfoPtr__GetFirstNonFullBin_b__51_0_Internal_Boolean_TrashContainerItem_0;
		}

		// Token: 0x02000A1A RID: 2586
		[ObfuscatedName("ScheduleOne.Employees.Cleaner+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1C5 RID: 53701 RVA: 0x0032B344 File Offset: 0x00329544
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cleaner>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr);
				Cleaner.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
				Cleaner.__c__DisplayClass48_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr, "conn");
				Cleaner.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr, 100674621);
				Cleaner.__c__DisplayClass48_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr, 100674622);
				Cleaner.__c__DisplayClass48_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr, 100674623);
			}

			// Token: 0x0600D1C6 RID: 53702 RVA: 0x0032B3D4 File Offset: 0x003295D4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1C7 RID: 53703 RVA: 0x0032B410 File Offset: 0x00329610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188872, XrefRangeEnd = 188877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D1C8 RID: 53704 RVA: 0x0032B450 File Offset: 0x00329650
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D1C9 RID: 53705 RVA: 0x00065B11 File Offset: 0x00063D11
			public __c__DisplayClass48_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004107 RID: 16647
			// (get) Token: 0x0600D1CA RID: 53706 RVA: 0x0032B48C File Offset: 0x0032968C
			// (set) Token: 0x0600D1CB RID: 53707 RVA: 0x00065B1A File Offset: 0x00063D1A
			public unsafe Cleaner __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004108 RID: 16648
			// (get) Token: 0x0600D1CC RID: 53708 RVA: 0x0032B4BC File Offset: 0x003296BC
			// (set) Token: 0x0600D1CD RID: 53709 RVA: 0x00065B39 File Offset: 0x00063D39
			public unsafe NetworkConnection conn
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.NativeFieldInfoPtr_conn);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DDF RID: 36319
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DE0 RID: 36320
			private static readonly System.IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008DE1 RID: 36321
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DE2 RID: 36322
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008DE3 RID: 36323
			private static readonly System.IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000CA8 RID: 3240
			[ObfuscatedName("ScheduleOne.Employees.Cleaner+<>c__DisplayClass48_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E88B RID: 59531 RVA: 0x0036B794 File Offset: 0x00369994
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674624);
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674625);
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674626);
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674627);
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674628);
					Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674629);
				}

				// Token: 0x0600E88C RID: 59532 RVA: 0x0036B874 File Offset: 0x00369A74
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E88D RID: 59533 RVA: 0x0036B8BC File Offset: 0x00369ABC
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E88E RID: 59534 RVA: 0x0036B8F0 File Offset: 0x00369AF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188856, XrefRangeEnd = 188867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047D6 RID: 18390
				// (get) Token: 0x0600E88F RID: 59535 RVA: 0x0036B92C File Offset: 0x00369B2C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E890 RID: 59536 RVA: 0x0036B96C File Offset: 0x00369B6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188867, XrefRangeEnd = 188872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047D7 RID: 18391
				// (get) Token: 0x0600E891 RID: 59537 RVA: 0x0036B9A0 File Offset: 0x00369BA0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E892 RID: 59538 RVA: 0x000710FB File Offset: 0x0006F2FB
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047D3 RID: 18387
				// (get) Token: 0x0600E893 RID: 59539 RVA: 0x0036B9E0 File Offset: 0x00369BE0
				// (set) Token: 0x0600E894 RID: 59540 RVA: 0x00071104 File Offset: 0x0006F304
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047D4 RID: 18388
				// (get) Token: 0x0600E895 RID: 59541 RVA: 0x0036BA08 File Offset: 0x00369C08
				// (set) Token: 0x0600E896 RID: 59542 RVA: 0x0007111F File Offset: 0x0006F31F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D5 RID: 18389
				// (get) Token: 0x0600E897 RID: 59543 RVA: 0x0036BA38 File Offset: 0x00369C38
				// (set) Token: 0x0600E898 RID: 59544 RVA: 0x0007113E File Offset: 0x0006F33E
				public unsafe Cleaner.__c__DisplayClass48_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner.__c__DisplayClass48_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Cleaner.__c__DisplayClass48_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BAD RID: 39853
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BAE RID: 39854
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BAF RID: 39855
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BB0 RID: 39856
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BB1 RID: 39857
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BB2 RID: 39858
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BB3 RID: 39859
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BB4 RID: 39860
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BB5 RID: 39861
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
