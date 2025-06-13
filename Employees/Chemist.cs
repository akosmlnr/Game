using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000426 RID: 1062
	public class Chemist : Employee
	{
		// Token: 0x06005896 RID: 22678 RVA: 0x0019F3F8 File Offset: 0x0019D5F8
		// Note: this type is marked as 'beforefieldinit'.
		static Chemist()
		{
			Il2CppClassPointerStore<Chemist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Chemist");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist>.NativeClassPtr);
			Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "MAX_ASSIGNED_STATIONS");
			Chemist.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "typeIcon");
			Chemist.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "configReplicator");
			Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartChemistryStationBehaviour");
			Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartLabOvenBehaviour");
			Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "FinishLabOvenBehaviour");
			Chemist.NativeFieldInfoPtr_StartCauldronBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartCauldronBehaviour");
			Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartMixingStationBehaviour");
			Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "WorldspaceUIPrefab");
			Chemist.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "uiPoint");
			Chemist.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<configuration>k__BackingField");
			Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Chemist.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted");
			Chemist.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted");
			Chemist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674504);
			Chemist.NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674505);
			Chemist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674506);
			Chemist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674507);
			Chemist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674508);
			Chemist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674509);
			Chemist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674510);
			Chemist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674511);
			Chemist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674512);
			Chemist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674513);
			Chemist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674514);
			Chemist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674515);
			Chemist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674516);
			Chemist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674517);
			Chemist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674518);
			Chemist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674519);
			Chemist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674520);
			Chemist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674521);
			Chemist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674522);
			Chemist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674523);
			Chemist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674524);
			Chemist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674525);
			Chemist.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674526);
			Chemist.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674527);
			Chemist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674528);
			Chemist.NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674529);
			Chemist.NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674530);
			Chemist.NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674531);
			Chemist.NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674532);
			Chemist.NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674533);
			Chemist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674534);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674535);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674536);
			Chemist.NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674537);
			Chemist.NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674538);
			Chemist.NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674539);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674540);
			Chemist.NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674541);
			Chemist.NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674542);
			Chemist.NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674543);
			Chemist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674544);
			Chemist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674545);
			Chemist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674546);
			Chemist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674547);
			Chemist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674548);
			Chemist.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674549);
			Chemist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674550);
			Chemist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674551);
			Chemist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674552);
			Chemist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674553);
			Chemist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674554);
			Chemist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674555);
			Chemist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674556);
			Chemist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674557);
			Chemist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674558);
			Chemist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100674559);
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06005897 RID: 22679 RVA: 0x0019F9C8 File Offset: 0x0019DBC8
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 188282, RefRangeEnd = 188290, XrefRangeStart = 188282, XrefRangeEnd = 188282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06005898 RID: 22680 RVA: 0x0019FA08 File Offset: 0x0019DC08
		// (set) Token: 0x06005899 RID: 22681 RVA: 0x0019FA48 File Offset: 0x0019DC48
		public unsafe ChemistConfiguration configuration
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 188282, RefRangeEnd = 188290, XrefRangeStart = 188282, XrefRangeEnd = 188290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfiguration>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188290, XrefRangeEnd = 188291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x0600589A RID: 22682 RVA: 0x0019FA8C File Offset: 0x0019DC8C
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 188291, RefRangeEnd = 188302, XrefRangeStart = 188291, XrefRangeEnd = 188291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x0600589B RID: 22683 RVA: 0x0019FACC File Offset: 0x0019DCCC
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x0019FB08 File Offset: 0x0019DD08
		// (set) Token: 0x0600589D RID: 22685 RVA: 0x0019FB48 File Offset: 0x0019DD48
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 188302, RefRangeEnd = 188309, XrefRangeStart = 188302, XrefRangeEnd = 188302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188309, XrefRangeEnd = 188310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x0019FB8C File Offset: 0x0019DD8C
		// (set) Token: 0x0600589F RID: 22687 RVA: 0x0019FBCC File Offset: 0x0019DDCC
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 187604, RefRangeEnd = 187629, XrefRangeStart = 187604, XrefRangeEnd = 187629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 188318, RefRangeEnd = 188320, XrefRangeStart = 188310, XrefRangeEnd = 188318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0019FC10 File Offset: 0x0019DE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188320, XrefRangeEnd = 188342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x0019FC54 File Offset: 0x0019DE54
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x0019FC94 File Offset: 0x0019DE94
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 51237, RefRangeEnd = 51239, XrefRangeStart = 51237, XrefRangeEnd = 51239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x060058A3 RID: 22691 RVA: 0x0019FCD4 File Offset: 0x0019DED4
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x060058A4 RID: 22692 RVA: 0x0019FD14 File Offset: 0x0019DF14
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x0019FD50 File Offset: 0x0019DF50
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x0019FD90 File Offset: 0x0019DF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188342, XrefRangeEnd = 188351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref warp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x0019FDEC File Offset: 0x0019DFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x0019FE28 File Offset: 0x0019E028
		[CallerCount(0)]
		public unsafe override void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0019FE64 File Offset: 0x0019E064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188351, XrefRangeEnd = 188362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x0019FEA0 File Offset: 0x0019E0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188362, XrefRangeEnd = 188380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x0019FEF0 File Offset: 0x0019E0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188380, XrefRangeEnd = 188397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x0019FF34 File Offset: 0x0019E134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188397, XrefRangeEnd = 188405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x0019FF70 File Offset: 0x0019E170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188460, RefRangeEnd = 188461, XrefRangeStart = 188405, XrefRangeEnd = 188460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartNewTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x0019FFA4 File Offset: 0x0019E1A4
		[CallerCount(0)]
		public unsafe bool AnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x0019FFE0 File Offset: 0x0019E1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188461, XrefRangeEnd = 188462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x001A0028 File Offset: 0x0019E228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188462, XrefRangeEnd = 188465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartChemistryStation(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x001A006C File Offset: 0x0019E26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188465, XrefRangeEnd = 188468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCauldron(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x001A00B0 File Offset: 0x0019E2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188468, XrefRangeEnd = 188471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLabOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x001A00F4 File Offset: 0x0019E2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188471, XrefRangeEnd = 188474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishLabOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x001A0138 File Offset: 0x0019E338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188474, XrefRangeEnd = 188477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixingStation(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x001A017C File Offset: 0x0019E37C
		[CallerCount(0)]
		public unsafe override EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x001A01C8 File Offset: 0x0019E3C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188506, RefRangeEnd = 188507, XrefRangeStart = 188477, XrefRangeEnd = 188506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr2) : null;
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x001A0208 File Offset: 0x0019E408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188535, RefRangeEnd = 188536, XrefRangeStart = 188507, XrefRangeEnd = 188535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr2) : null;
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x001A0248 File Offset: 0x0019E448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188571, RefRangeEnd = 188572, XrefRangeStart = 188536, XrefRangeEnd = 188571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr2) : null;
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x001A0288 File Offset: 0x0019E488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188600, RefRangeEnd = 188601, XrefRangeStart = 188572, XrefRangeEnd = 188600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Cauldron> GetCauldronsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr2) : null;
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x001A02C8 File Offset: 0x0019E4C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188633, RefRangeEnd = 188634, XrefRangeStart = 188601, XrefRangeEnd = 188633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MixingStation> GetMixingStationsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x001A0308 File Offset: 0x0019E508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188662, RefRangeEnd = 188663, XrefRangeStart = 188634, XrefRangeEnd = 188662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr2) : null;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x001A0348 File Offset: 0x0019E548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188691, RefRangeEnd = 188692, XrefRangeStart = 188663, XrefRangeEnd = 188691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ChemistryStation> GetChemStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr2) : null;
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x001A0388 File Offset: 0x0019E588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188720, RefRangeEnd = 188721, XrefRangeStart = 188692, XrefRangeEnd = 188720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Cauldron> GetCauldronsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr2) : null;
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x001A03C8 File Offset: 0x0019E5C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188749, RefRangeEnd = 188750, XrefRangeStart = 188721, XrefRangeEnd = 188749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MixingStation> GetMixStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x001A0408 File Offset: 0x0019E608
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188777, RefRangeEnd = 188778, XrefRangeStart = 188750, XrefRangeEnd = 188777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x001A0448 File Offset: 0x0019E648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188778, XrefRangeEnd = 188782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x001A047C File Offset: 0x0019E67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188782, XrefRangeEnd = 188791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x001A04C8 File Offset: 0x0019E6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188791, XrefRangeEnd = 188795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr2) : null;
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x001A0514 File Offset: 0x0019E714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188795, XrefRangeEnd = 188801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x001A0570 File Offset: 0x0019E770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188801, XrefRangeEnd = 188802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Chemist() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x001A05AC File Offset: 0x0019E7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188802, XrefRangeEnd = 188826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x001A05E8 File Offset: 0x0019E7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188826, XrefRangeEnd = 188827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x001A0624 File Offset: 0x0019E824
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x001A0660 File Offset: 0x0019E860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188827, XrefRangeEnd = 188837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x001A06A4 File Offset: 0x0019E8A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 188318, RefRangeEnd = 188320, XrefRangeStart = 188318, XrefRangeEnd = 188320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x001A06E8 File Offset: 0x0019E8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188837, XrefRangeEnd = 188841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060058CB RID: 22731 RVA: 0x001A074C File Offset: 0x0019E94C
		// (set) Token: 0x060058CC RID: 22732 RVA: 0x001A078C File Offset: 0x0019E98C
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 187604, RefRangeEnd = 187629, XrefRangeStart = 187604, XrefRangeEnd = 187629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 188850, RefRangeEnd = 188851, XrefRangeStart = 188841, XrefRangeEnd = 188850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x001A07DC File Offset: 0x0019E9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188851, XrefRangeEnd = 188855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Employees_Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x001A0850 File Offset: 0x0019EA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x0002A0F1 File Offset: 0x000282F1
		public Chemist(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060058D0 RID: 22736 RVA: 0x001A088C File Offset: 0x0019EA8C
		// (set) Token: 0x060058D1 RID: 22737 RVA: 0x0002A0FA File Offset: 0x000282FA
		public unsafe static int MAX_ASSIGNED_STATIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS, (void*)(&value));
			}
		}

		// Token: 0x17001A92 RID: 6802
		// (get) Token: 0x060058D2 RID: 22738 RVA: 0x001A08A8 File Offset: 0x0019EAA8
		// (set) Token: 0x060058D3 RID: 22739 RVA: 0x0002A108 File Offset: 0x00028308
		public unsafe Sprite typeIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_typeIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A93 RID: 6803
		// (get) Token: 0x060058D4 RID: 22740 RVA: 0x001A08D8 File Offset: 0x0019EAD8
		// (set) Token: 0x060058D5 RID: 22741 RVA: 0x0002A127 File Offset: 0x00028327
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_configReplicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x060058D6 RID: 22742 RVA: 0x001A0908 File Offset: 0x0019EB08
		// (set) Token: 0x060058D7 RID: 22743 RVA: 0x0002A146 File Offset: 0x00028346
		public unsafe StartChemistryStationBehaviour StartChemistryStationBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartChemistryStationBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x060058D8 RID: 22744 RVA: 0x001A0938 File Offset: 0x0019EB38
		// (set) Token: 0x060058D9 RID: 22745 RVA: 0x0002A165 File Offset: 0x00028365
		public unsafe StartLabOvenBehaviour StartLabOvenBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLabOvenBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x060058DA RID: 22746 RVA: 0x001A0968 File Offset: 0x0019EB68
		// (set) Token: 0x060058DB RID: 22747 RVA: 0x0002A184 File Offset: 0x00028384
		public unsafe FinishLabOvenBehaviour FinishLabOvenBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinishLabOvenBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A97 RID: 6807
		// (get) Token: 0x060058DC RID: 22748 RVA: 0x001A0998 File Offset: 0x0019EB98
		// (set) Token: 0x060058DD RID: 22749 RVA: 0x0002A1A3 File Offset: 0x000283A3
		public unsafe StartCauldronBehaviour StartCauldronBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartCauldronBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartCauldronBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartCauldronBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A98 RID: 6808
		// (get) Token: 0x060058DE RID: 22750 RVA: 0x001A09C8 File Offset: 0x0019EBC8
		// (set) Token: 0x060058DF RID: 22751 RVA: 0x0002A1C2 File Offset: 0x000283C2
		public unsafe StartMixingStationBehaviour StartMixingStationBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartMixingStationBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x060058E0 RID: 22752 RVA: 0x001A09F8 File Offset: 0x0019EBF8
		// (set) Token: 0x060058E1 RID: 22753 RVA: 0x0002A1E1 File Offset: 0x000283E1
		public unsafe ChemistUIElement WorldspaceUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x060058E2 RID: 22754 RVA: 0x001A0A28 File Offset: 0x0019EC28
		// (set) Token: 0x060058E3 RID: 22755 RVA: 0x0002A200 File Offset: 0x00028400
		public unsafe Transform uiPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_uiPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x060058E4 RID: 22756 RVA: 0x001A0A58 File Offset: 0x0019EC58
		// (set) Token: 0x060058E5 RID: 22757 RVA: 0x0002A21F File Offset: 0x0002841F
		public unsafe ChemistConfiguration _configuration_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__configuration_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfiguration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x060058E6 RID: 22758 RVA: 0x001A0A88 File Offset: 0x0019EC88
		// (set) Token: 0x060058E7 RID: 22759 RVA: 0x0002A23E File Offset: 0x0002843E
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x060058E8 RID: 22760 RVA: 0x001A0AB8 File Offset: 0x0019ECB8
		// (set) Token: 0x060058E9 RID: 22761 RVA: 0x0002A25D File Offset: 0x0002845D
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x060058EA RID: 22762 RVA: 0x001A0AE8 File Offset: 0x0019ECE8
		// (set) Token: 0x060058EB RID: 22763 RVA: 0x0002A27C File Offset: 0x0002847C
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x060058EC RID: 22764 RVA: 0x001A0B18 File Offset: 0x0019ED18
		// (set) Token: 0x060058ED RID: 22765 RVA: 0x0002A29B File Offset: 0x0002849B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x001A0B40 File Offset: 0x0019ED40
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x0002A2B6 File Offset: 0x000284B6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003C24 RID: 15396
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS;

		// Token: 0x04003C25 RID: 15397
		private static readonly System.IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003C26 RID: 15398
		private static readonly System.IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003C27 RID: 15399
		private static readonly System.IntPtr NativeFieldInfoPtr_StartChemistryStationBehaviour;

		// Token: 0x04003C28 RID: 15400
		private static readonly System.IntPtr NativeFieldInfoPtr_StartLabOvenBehaviour;

		// Token: 0x04003C29 RID: 15401
		private static readonly System.IntPtr NativeFieldInfoPtr_FinishLabOvenBehaviour;

		// Token: 0x04003C2A RID: 15402
		private static readonly System.IntPtr NativeFieldInfoPtr_StartCauldronBehaviour;

		// Token: 0x04003C2B RID: 15403
		private static readonly System.IntPtr NativeFieldInfoPtr_StartMixingStationBehaviour;

		// Token: 0x04003C2C RID: 15404
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003C2D RID: 15405
		private static readonly System.IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003C2E RID: 15406
		private static readonly System.IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003C2F RID: 15407
		private static readonly System.IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003C30 RID: 15408
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003C31 RID: 15409
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003C32 RID: 15410
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003C33 RID: 15411
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003C34 RID: 15412
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003C35 RID: 15413
		private static readonly System.IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0;

		// Token: 0x04003C36 RID: 15414
		private static readonly System.IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0;

		// Token: 0x04003C37 RID: 15415
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003C38 RID: 15416
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003C39 RID: 15417
		private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003C3A RID: 15418
		private static readonly System.IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003C3B RID: 15419
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003C3C RID: 15420
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003C3D RID: 15421
		private static readonly System.IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003C3E RID: 15422
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003C3F RID: 15423
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003C40 RID: 15424
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003C41 RID: 15425
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003C42 RID: 15426
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003C43 RID: 15427
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0;

		// Token: 0x04003C44 RID: 15428
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0;

		// Token: 0x04003C45 RID: 15429
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0;

		// Token: 0x04003C46 RID: 15430
		private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003C47 RID: 15431
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003C48 RID: 15432
		private static readonly System.IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003C49 RID: 15433
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0;

		// Token: 0x04003C4A RID: 15434
		private static readonly System.IntPtr NativeMethodInfoPtr_TryStartNewTask_Private_Void_0;

		// Token: 0x04003C4B RID: 15435
		private static readonly System.IntPtr NativeMethodInfoPtr_AnyWorkInProgress_Private_Boolean_0;

		// Token: 0x04003C4C RID: 15436
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x04003C4D RID: 15437
		private static readonly System.IntPtr NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0;

		// Token: 0x04003C4E RID: 15438
		private static readonly System.IntPtr NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0;

		// Token: 0x04003C4F RID: 15439
		private static readonly System.IntPtr NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0;

		// Token: 0x04003C50 RID: 15440
		private static readonly System.IntPtr NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0;

		// Token: 0x04003C51 RID: 15441
		private static readonly System.IntPtr NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0;

		// Token: 0x04003C52 RID: 15442
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0;

		// Token: 0x04003C53 RID: 15443
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0;

		// Token: 0x04003C54 RID: 15444
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0;

		// Token: 0x04003C55 RID: 15445
		private static readonly System.IntPtr NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0;

		// Token: 0x04003C56 RID: 15446
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0;

		// Token: 0x04003C57 RID: 15447
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0;

		// Token: 0x04003C58 RID: 15448
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0;

		// Token: 0x04003C59 RID: 15449
		private static readonly System.IntPtr NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0;

		// Token: 0x04003C5A RID: 15450
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0;

		// Token: 0x04003C5B RID: 15451
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0;

		// Token: 0x04003C5C RID: 15452
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003C5D RID: 15453
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003C5E RID: 15454
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04003C5F RID: 15455
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x04003C60 RID: 15456
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003C61 RID: 15457
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C62 RID: 15458
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003C63 RID: 15459
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003C64 RID: 15460
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003C65 RID: 15461
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003C66 RID: 15462
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003C67 RID: 15463
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003C68 RID: 15464
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003C69 RID: 15465
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003C6A RID: 15466
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003C6B RID: 15467
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A18 RID: 2584
		[ObfuscatedName("ScheduleOne.Employees.Chemist+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1B4 RID: 53684 RVA: 0x0032B044 File Offset: 0x00329244
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr);
				Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, "conn");
				Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, 100674560);
				Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, 100674561);
				Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, 100674562);
			}

			// Token: 0x0600D1B5 RID: 53685 RVA: 0x0032B0D4 File Offset: 0x003292D4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1B6 RID: 53686 RVA: 0x0032B110 File Offset: 0x00329310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188277, XrefRangeEnd = 188282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D1B7 RID: 53687 RVA: 0x0032B150 File Offset: 0x00329350
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D1B8 RID: 53688 RVA: 0x00065A9D File Offset: 0x00063C9D
			public __c__DisplayClass44_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004103 RID: 16643
			// (get) Token: 0x0600D1B9 RID: 53689 RVA: 0x0032B18C File Offset: 0x0032938C
			// (set) Token: 0x0600D1BA RID: 53690 RVA: 0x00065AA6 File Offset: 0x00063CA6
			public unsafe Chemist __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004104 RID: 16644
			// (get) Token: 0x0600D1BB RID: 53691 RVA: 0x0032B1BC File Offset: 0x003293BC
			// (set) Token: 0x0600D1BC RID: 53692 RVA: 0x00065AC5 File Offset: 0x00063CC5
			public unsafe NetworkConnection conn
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr_conn);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DD6 RID: 36310
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DD7 RID: 36311
			private static readonly System.IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008DD8 RID: 36312
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD9 RID: 36313
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008DDA RID: 36314
			private static readonly System.IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000CA7 RID: 3239
			[ObfuscatedName("ScheduleOne.Employees.Chemist+<>c__DisplayClass44_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E87D RID: 59517 RVA: 0x0036B4C0 File Offset: 0x003696C0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674563);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674564);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674565);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674566);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674567);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674568);
				}

				// Token: 0x0600E87E RID: 59518 RVA: 0x0036B5A0 File Offset: 0x003697A0
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E87F RID: 59519 RVA: 0x0036B5E8 File Offset: 0x003697E8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E880 RID: 59520 RVA: 0x0036B61C File Offset: 0x0036981C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188261, XrefRangeEnd = 188272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047D1 RID: 18385
				// (get) Token: 0x0600E881 RID: 59521 RVA: 0x0036B658 File Offset: 0x00369858
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E882 RID: 59522 RVA: 0x0036B698 File Offset: 0x00369898
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188272, XrefRangeEnd = 188277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047D2 RID: 18386
				// (get) Token: 0x0600E883 RID: 59523 RVA: 0x0036B6CC File Offset: 0x003698CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E884 RID: 59524 RVA: 0x00071099 File Offset: 0x0006F299
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047CE RID: 18382
				// (get) Token: 0x0600E885 RID: 59525 RVA: 0x0036B70C File Offset: 0x0036990C
				// (set) Token: 0x0600E886 RID: 59526 RVA: 0x000710A2 File Offset: 0x0006F2A2
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047CF RID: 18383
				// (get) Token: 0x0600E887 RID: 59527 RVA: 0x0036B734 File Offset: 0x00369934
				// (set) Token: 0x0600E888 RID: 59528 RVA: 0x000710BD File Offset: 0x0006F2BD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047D0 RID: 18384
				// (get) Token: 0x0600E889 RID: 59529 RVA: 0x0036B764 File Offset: 0x00369964
				// (set) Token: 0x0600E88A RID: 59530 RVA: 0x000710DC File Offset: 0x0006F2DC
				public unsafe Chemist.__c__DisplayClass44_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist.__c__DisplayClass44_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BA4 RID: 39844
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BA5 RID: 39845
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BA6 RID: 39846
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BA7 RID: 39847
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BA8 RID: 39848
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BA9 RID: 39849
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BAA RID: 39850
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BAB RID: 39851
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BAC RID: 39852
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
