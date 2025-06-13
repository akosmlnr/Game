using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000425 RID: 1061
	public class Botanist : Employee
	{
		// Token: 0x0600581B RID: 22555 RVA: 0x0019D540 File Offset: 0x0019B740
		// Note: this type is marked as 'beforefieldinit'.
		static Botanist()
		{
			Il2CppClassPointerStore<Botanist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Botanist");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist>.NativeClassPtr);
			Botanist.NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "CRITICAL_WATERING_THRESHOLD");
			Botanist.NativeFieldInfoPtr_WATERING_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WATERING_THRESHOLD");
			Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "TARGET_WATER_LEVEL_MIN");
			Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "TARGET_WATER_LEVEL_MAX");
			Botanist.NativeFieldInfoPtr_SOIL_POUR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "SOIL_POUR_TIME");
			Botanist.NativeFieldInfoPtr_WATER_POUR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WATER_POUR_TIME");
			Botanist.NativeFieldInfoPtr_ADDITIVE_POUR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "ADDITIVE_POUR_TIME");
			Botanist.NativeFieldInfoPtr_SEED_SOW_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "SEED_SOW_TIME");
			Botanist.NativeFieldInfoPtr_HARVEST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "HARVEST_TIME");
			Botanist.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "typeIcon");
			Botanist.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "configReplicator");
			Botanist.NativeFieldInfoPtr_PotActionBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "PotActionBehaviour");
			Botanist.NativeFieldInfoPtr_StartDryingRackBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "StartDryingRackBehaviour");
			Botanist.NativeFieldInfoPtr_StopDryingRackBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "StopDryingRackBehaviour");
			Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WorldspaceUIPrefab");
			Botanist.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "uiPoint");
			Botanist.NativeFieldInfoPtr_MaxAssignedPots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MaxAssignedPots");
			Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NoAssignedStationsDialogue");
			Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "UnspecifiedPotsDialogue");
			Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NullDestinationPotsDialogue");
			Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MissingMaterialsDialogue");
			Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NoPotsRequireWorkDialogue");
			Botanist.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<configuration>k__BackingField");
			Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Botanist.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted");
			Botanist.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted");
			Botanist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674430);
			Botanist.NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674431);
			Botanist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674432);
			Botanist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674433);
			Botanist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674434);
			Botanist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674435);
			Botanist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674436);
			Botanist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674437);
			Botanist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674438);
			Botanist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674439);
			Botanist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674440);
			Botanist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674441);
			Botanist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674442);
			Botanist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674443);
			Botanist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674444);
			Botanist.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674445);
			Botanist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674446);
			Botanist.NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674447);
			Botanist.NativeMethodInfoPtr_StartAction_Private_Void_Pot_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674448);
			Botanist.NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674449);
			Botanist.NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674450);
			Botanist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674451);
			Botanist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674452);
			Botanist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674453);
			Botanist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674454);
			Botanist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674455);
			Botanist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674456);
			Botanist.NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674457);
			Botanist.NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674458);
			Botanist.NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674459);
			Botanist.NativeMethodInfoPtr_GetItemInSupplies_Public_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674460);
			Botanist.NativeMethodInfoPtr_GetSeedInSupplies_Public_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674461);
			Botanist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674462);
			Botanist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674463);
			Botanist.NativeMethodInfoPtr_AreThereUnspecifiedPots_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674464);
			Botanist.NativeMethodInfoPtr_AreThereNullDestinationPots_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674465);
			Botanist.NativeMethodInfoPtr_IsMissingRequiredMaterials_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674466);
			Botanist.NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674467);
			Botanist.NativeMethodInfoPtr_GetPotForSoilSour_Private_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674468);
			Botanist.NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674469);
			Botanist.NativeMethodInfoPtr_GetAccessableEntity_Private_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674470);
			Botanist.NativeMethodInfoPtr_GetAccessableEntities_Private_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674471);
			Botanist.NativeMethodInfoPtr_FilterPotsForSpecifiedSeed_Private_List_1_Pot_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674472);
			Botanist.NativeMethodInfoPtr_GetPotForAdditives_Private_Pot_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674473);
			Botanist.NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674474);
			Botanist.NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674475);
			Botanist.NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674476);
			Botanist.NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674477);
			Botanist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674478);
			Botanist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674479);
			Botanist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674480);
			Botanist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674481);
			Botanist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674482);
			Botanist.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674483);
			Botanist.NativeMethodInfoPtr__GetAccessableEntities_b__77_0_Private_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674484);
			Botanist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674485);
			Botanist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674486);
			Botanist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674487);
			Botanist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674488);
			Botanist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674489);
			Botanist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674490);
			Botanist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674491);
			Botanist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674492);
			Botanist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674493);
			Botanist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100674494);
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x0019DCB4 File Offset: 0x0019BEB4
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 187554, RefRangeEnd = 187566, XrefRangeStart = 187554, XrefRangeEnd = 187554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr2) : null;
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600581D RID: 22557 RVA: 0x0019DCF4 File Offset: 0x0019BEF4
		// (set) Token: 0x0600581E RID: 22558 RVA: 0x0019DD34 File Offset: 0x0019BF34
		public unsafe BotanistConfiguration configuration
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 187554, RefRangeEnd = 187566, XrefRangeStart = 187554, XrefRangeEnd = 187566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187566, XrefRangeEnd = 187567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600581F RID: 22559 RVA: 0x0019DD78 File Offset: 0x0019BF78
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x0019DDB8 File Offset: 0x0019BFB8
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 124691, RefRangeEnd = 124696, XrefRangeStart = 124691, XrefRangeEnd = 124696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06005821 RID: 22561 RVA: 0x0019DDF4 File Offset: 0x0019BFF4
		// (set) Token: 0x06005822 RID: 22562 RVA: 0x0019DE34 File Offset: 0x0019C034
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187567, XrefRangeEnd = 187568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06005823 RID: 22563 RVA: 0x0019DE78 File Offset: 0x0019C078
		// (set) Token: 0x06005824 RID: 22564 RVA: 0x0019DEB8 File Offset: 0x0019C0B8
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 187576, RefRangeEnd = 187578, XrefRangeStart = 187568, XrefRangeEnd = 187576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x0019DEFC File Offset: 0x0019C0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187578, XrefRangeEnd = 187600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0019DF40 File Offset: 0x0019C140
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 187600, RefRangeEnd = 187604, XrefRangeStart = 187600, XrefRangeEnd = 187600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x0019DF80 File Offset: 0x0019C180
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 51237, RefRangeEnd = 51239, XrefRangeStart = 51237, XrefRangeEnd = 51239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x0019DFC0 File Offset: 0x0019C1C0
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 187604, RefRangeEnd = 187629, XrefRangeStart = 187604, XrefRangeEnd = 187604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06005829 RID: 22569 RVA: 0x0019E000 File Offset: 0x0019C200
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x0600582A RID: 22570 RVA: 0x0019E03C File Offset: 0x0019C23C
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0019E07C File Offset: 0x0019C27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187629, XrefRangeEnd = 187630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0019E0B8 File Offset: 0x0019C2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187630, XrefRangeEnd = 187677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x0019E0F4 File Offset: 0x0019C2F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187685, RefRangeEnd = 187688, XrefRangeStart = 187677, XrefRangeEnd = 187685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEntityAccessible(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0019E144 File Offset: 0x0019C344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187690, RefRangeEnd = 187691, XrefRangeStart = 187688, XrefRangeEnd = 187690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction(Pot pot, PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref actionType;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StartAction_Private_Void_Pot_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x0019E194 File Offset: 0x0019C394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187691, XrefRangeEnd = 187694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDryingRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x0019E1D8 File Offset: 0x0019C3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187694, XrefRangeEnd = 187697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDryingRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0019E21C File Offset: 0x0019C41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187697, XrefRangeEnd = 187715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x0019E26C File Offset: 0x0019C46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187715, XrefRangeEnd = 187732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0019E2B0 File Offset: 0x0019C4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187732, XrefRangeEnd = 187741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref warp;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0019E30C File Offset: 0x0019C50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187741, XrefRangeEnd = 187744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x0019E348 File Offset: 0x0019C548
		[CallerCount(0)]
		public unsafe override void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0019E384 File Offset: 0x0019C584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187744, XrefRangeEnd = 187750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x0019E3C0 File Offset: 0x0019C5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187750, XrefRangeEnd = 187773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &moveQuantity;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			dryable = ((intPtr3 == 0) ? null : new QualityItemInstance(intPtr3));
			System.IntPtr intPtr4 = intPtr2;
			destinationRack = ((intPtr4 == 0) ? null : new DryingRack(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x0019E450 File Offset: 0x0019C650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187811, RefRangeEnd = 187812, XrefRangeStart = 187773, XrefRangeEnd = 187811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetDryableInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0019E490 File Offset: 0x0019C690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187828, RefRangeEnd = 187829, XrefRangeStart = 187812, XrefRangeEnd = 187828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dryable);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &rackInputCapacity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x0019E4F0 File Offset: 0x0019C6F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 187867, RefRangeEnd = 187872, XrefRangeStart = 187829, XrefRangeEnd = 187867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetItemInSupplies(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetItemInSupplies_Public_ItemInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x0019E540 File Offset: 0x0019C740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187910, RefRangeEnd = 187912, XrefRangeStart = 187872, XrefRangeEnd = 187910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetSeedInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetSeedInSupplies_Public_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0019E580 File Offset: 0x0019C780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187912, XrefRangeEnd = 187913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0019E5C8 File Offset: 0x0019C7C8
		[CallerCount(0)]
		public unsafe override EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x0019E614 File Offset: 0x0019C814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187913, XrefRangeEnd = 187925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreThereUnspecifiedPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_AreThereUnspecifiedPots_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x0019E650 File Offset: 0x0019C850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187925, XrefRangeEnd = 187943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreThereNullDestinationPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_AreThereNullDestinationPots_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x0019E68C File Offset: 0x0019C88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187943, XrefRangeEnd = 187956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMissingRequiredMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_IsMissingRequiredMaterials_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0019E6C8 File Offset: 0x0019C8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187976, RefRangeEnd = 187977, XrefRangeStart = 187956, XrefRangeEnd = 187976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForWatering(float threshold, bool excludeFullyGrowm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref threshold;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref excludeFullyGrowm;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x0019E724 File Offset: 0x0019C924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 187988, RefRangeEnd = 187989, XrefRangeStart = 187977, XrefRangeEnd = 187988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForSoilSour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForSoilSour_Private_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x0019E764 File Offset: 0x0019C964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188006, RefRangeEnd = 188007, XrefRangeStart = 187989, XrefRangeEnd = 188006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> GetPotsReadyForSeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x0019E7A4 File Offset: 0x0019C9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188007, XrefRangeEnd = 188025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetAccessableEntity<T>(T entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = entity;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref entity;
			}
			ptr2 = intPtr;
			System.IntPtr returnedException;
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(Botanist.MethodInfoStoreGeneric_GetAccessableEntity_Private_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.PointerToValueGeneric<T>(objectPointer, false, true);
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x0019E824 File Offset: 0x0019CA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188025, XrefRangeEnd = 188028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetAccessableEntities<T>(List<T> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.MethodInfoStoreGeneric_GetAccessableEntities_Private_List_1_T_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
		}

		// Token: 0x06005846 RID: 22598 RVA: 0x0019E874 File Offset: 0x0019CA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188028, XrefRangeEnd = 188058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> FilterPotsForSpecifiedSeed(List<Pot> pots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pots);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_FilterPotsForSpecifiedSeed_Private_List_1_Pot_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
		}

		// Token: 0x06005847 RID: 22599 RVA: 0x0019E8C4 File Offset: 0x0019CAC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188058, XrefRangeEnd = 188069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForAdditives(out int additiveNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &additiveNumber;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForAdditives_Private_Pot_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
		}

		// Token: 0x06005848 RID: 22600 RVA: 0x0019E910 File Offset: 0x0019CB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188069, XrefRangeEnd = 188086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> GetPotsForHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
		}

		// Token: 0x06005849 RID: 22601 RVA: 0x0019E950 File Offset: 0x0019CB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188086, XrefRangeEnd = 188103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr2) : null;
		}

		// Token: 0x0600584A RID: 22602 RVA: 0x0019E990 File Offset: 0x0019CB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188103, XrefRangeEnd = 188120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksToStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr2) : null;
		}

		// Token: 0x0600584B RID: 22603 RVA: 0x0019E9D0 File Offset: 0x0019CBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188120, XrefRangeEnd = 188143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr2) : null;
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x0019EA10 File Offset: 0x0019CC10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 188170, RefRangeEnd = 188171, XrefRangeStart = 188143, XrefRangeEnd = 188170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x0019EA50 File Offset: 0x0019CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188171, XrefRangeEnd = 188175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x0019EA84 File Offset: 0x0019CC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188175, XrefRangeEnd = 188184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr2) : null;
		}

		// Token: 0x0600584F RID: 22607 RVA: 0x0019EAD0 File Offset: 0x0019CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188184, XrefRangeEnd = 188188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr2) : null;
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x0019EB1C File Offset: 0x0019CD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188188, XrefRangeEnd = 188194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x0019EB78 File Offset: 0x0019CD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188194, XrefRangeEnd = 188195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Botanist() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x0019EBB4 File Offset: 0x0019CDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188195, XrefRangeEnd = 188207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetAccessableEntities_b__77_0<T>(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.MethodInfoStoreGeneric__GetAccessableEntities_b__77_0_Private_Boolean_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x0019EC38 File Offset: 0x0019CE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188207, XrefRangeEnd = 188231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x0019EC74 File Offset: 0x0019CE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188231, XrefRangeEnd = 188232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x0019ECB0 File Offset: 0x0019CEB0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x0019ECEC File Offset: 0x0019CEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188232, XrefRangeEnd = 188242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005857 RID: 22615 RVA: 0x0019ED30 File Offset: 0x0019CF30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187576, RefRangeEnd = 187578, XrefRangeStart = 187576, XrefRangeEnd = 187578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005858 RID: 22616 RVA: 0x0019ED74 File Offset: 0x0019CF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188242, XrefRangeEnd = 188246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06005859 RID: 22617 RVA: 0x0019EDD8 File Offset: 0x0019CFD8
		// (set) Token: 0x0600585A RID: 22618 RVA: 0x0019EE18 File Offset: 0x0019D018
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 188255, RefRangeEnd = 188256, XrefRangeStart = 188246, XrefRangeEnd = 188255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600585B RID: 22619 RVA: 0x0019EE68 File Offset: 0x0019D068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188256, XrefRangeEnd = 188260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_Employees_Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600585C RID: 22620 RVA: 0x0019EEDC File Offset: 0x0019D0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188260, XrefRangeEnd = 188261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600585D RID: 22621 RVA: 0x00029DB4 File Offset: 0x00027FB4
		public Botanist(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600585E RID: 22622 RVA: 0x0019EF18 File Offset: 0x0019D118
		// (set) Token: 0x0600585F RID: 22623 RVA: 0x00029DBD File Offset: 0x00027FBD
		public unsafe float CRITICAL_WATERING_THRESHOLD
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD)) = value;
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06005860 RID: 22624 RVA: 0x0019EF40 File Offset: 0x0019D140
		// (set) Token: 0x06005861 RID: 22625 RVA: 0x00029DD8 File Offset: 0x00027FD8
		public unsafe float WATERING_THRESHOLD
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATERING_THRESHOLD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATERING_THRESHOLD)) = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06005862 RID: 22626 RVA: 0x0019EF68 File Offset: 0x0019D168
		// (set) Token: 0x06005863 RID: 22627 RVA: 0x00029DF3 File Offset: 0x00027FF3
		public unsafe float TARGET_WATER_LEVEL_MIN
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN)) = value;
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06005864 RID: 22628 RVA: 0x0019EF90 File Offset: 0x0019D190
		// (set) Token: 0x06005865 RID: 22629 RVA: 0x00029E0E File Offset: 0x0002800E
		public unsafe float TARGET_WATER_LEVEL_MAX
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX)) = value;
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06005866 RID: 22630 RVA: 0x0019EFB8 File Offset: 0x0019D1B8
		// (set) Token: 0x06005867 RID: 22631 RVA: 0x00029E29 File Offset: 0x00028029
		public unsafe float SOIL_POUR_TIME
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SOIL_POUR_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SOIL_POUR_TIME)) = value;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06005868 RID: 22632 RVA: 0x0019EFE0 File Offset: 0x0019D1E0
		// (set) Token: 0x06005869 RID: 22633 RVA: 0x00029E44 File Offset: 0x00028044
		public unsafe float WATER_POUR_TIME
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATER_POUR_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WATER_POUR_TIME)) = value;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x0600586A RID: 22634 RVA: 0x0019F008 File Offset: 0x0019D208
		// (set) Token: 0x0600586B RID: 22635 RVA: 0x00029E5F File Offset: 0x0002805F
		public unsafe float ADDITIVE_POUR_TIME
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_ADDITIVE_POUR_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_ADDITIVE_POUR_TIME)) = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x0600586C RID: 22636 RVA: 0x0019F030 File Offset: 0x0019D230
		// (set) Token: 0x0600586D RID: 22637 RVA: 0x00029E7A File Offset: 0x0002807A
		public unsafe float SEED_SOW_TIME
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SEED_SOW_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_SEED_SOW_TIME)) = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x0600586E RID: 22638 RVA: 0x0019F058 File Offset: 0x0019D258
		// (set) Token: 0x0600586F RID: 22639 RVA: 0x00029E95 File Offset: 0x00028095
		public unsafe float HARVEST_TIME
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_HARVEST_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_HARVEST_TIME)) = value;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06005870 RID: 22640 RVA: 0x0019F080 File Offset: 0x0019D280
		// (set) Token: 0x06005871 RID: 22641 RVA: 0x00029EB0 File Offset: 0x000280B0
		public unsafe Sprite typeIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_typeIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06005872 RID: 22642 RVA: 0x0019F0B0 File Offset: 0x0019D2B0
		// (set) Token: 0x06005873 RID: 22643 RVA: 0x00029ECF File Offset: 0x000280CF
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_configReplicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06005874 RID: 22644 RVA: 0x0019F0E0 File Offset: 0x0019D2E0
		// (set) Token: 0x06005875 RID: 22645 RVA: 0x00029EEE File Offset: 0x000280EE
		public unsafe PotActionBehaviour PotActionBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_PotActionBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_PotActionBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005876 RID: 22646 RVA: 0x0019F110 File Offset: 0x0019D310
		// (set) Token: 0x06005877 RID: 22647 RVA: 0x00029F0D File Offset: 0x0002810D
		public unsafe StartDryingRackBehaviour StartDryingRackBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StartDryingRackBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartDryingRackBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StartDryingRackBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06005878 RID: 22648 RVA: 0x0019F140 File Offset: 0x0019D340
		// (set) Token: 0x06005879 RID: 22649 RVA: 0x00029F2C File Offset: 0x0002812C
		public unsafe StopDryingRackBehaviour StopDryingRackBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StopDryingRackBehaviour);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopDryingRackBehaviour>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_StopDryingRackBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x0600587A RID: 22650 RVA: 0x0019F170 File Offset: 0x0019D370
		// (set) Token: 0x0600587B RID: 22651 RVA: 0x00029F4B File Offset: 0x0002814B
		public unsafe BotanistUIElement WorldspaceUIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x0600587C RID: 22652 RVA: 0x0019F1A0 File Offset: 0x0019D3A0
		// (set) Token: 0x0600587D RID: 22653 RVA: 0x00029F6A File Offset: 0x0002816A
		public unsafe Transform uiPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_uiPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600587E RID: 22654 RVA: 0x0019F1D0 File Offset: 0x0019D3D0
		// (set) Token: 0x0600587F RID: 22655 RVA: 0x00029F89 File Offset: 0x00028189
		public unsafe int MaxAssignedPots
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MaxAssignedPots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MaxAssignedPots)) = value;
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06005880 RID: 22656 RVA: 0x0019F1F8 File Offset: 0x0019D3F8
		// (set) Token: 0x06005881 RID: 22657 RVA: 0x00029FA4 File Offset: 0x000281A4
		public unsafe DialogueContainer NoAssignedStationsDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06005882 RID: 22658 RVA: 0x0019F228 File Offset: 0x0019D428
		// (set) Token: 0x06005883 RID: 22659 RVA: 0x00029FC3 File Offset: 0x000281C3
		public unsafe DialogueContainer UnspecifiedPotsDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06005884 RID: 22660 RVA: 0x0019F258 File Offset: 0x0019D458
		// (set) Token: 0x06005885 RID: 22661 RVA: 0x00029FE2 File Offset: 0x000281E2
		public unsafe DialogueContainer NullDestinationPotsDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06005886 RID: 22662 RVA: 0x0019F288 File Offset: 0x0019D488
		// (set) Token: 0x06005887 RID: 22663 RVA: 0x0002A001 File Offset: 0x00028201
		public unsafe DialogueContainer MissingMaterialsDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06005888 RID: 22664 RVA: 0x0019F2B8 File Offset: 0x0019D4B8
		// (set) Token: 0x06005889 RID: 22665 RVA: 0x0002A020 File Offset: 0x00028220
		public unsafe DialogueContainer NoPotsRequireWorkDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x0600588A RID: 22666 RVA: 0x0019F2E8 File Offset: 0x0019D4E8
		// (set) Token: 0x0600588B RID: 22667 RVA: 0x0002A03F File Offset: 0x0002823F
		public unsafe BotanistConfiguration _configuration_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__configuration_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x0600588C RID: 22668 RVA: 0x0019F318 File Offset: 0x0019D518
		// (set) Token: 0x0600588D RID: 22669 RVA: 0x0002A05E File Offset: 0x0002825E
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x0600588E RID: 22670 RVA: 0x0019F348 File Offset: 0x0019D548
		// (set) Token: 0x0600588F RID: 22671 RVA: 0x0002A07D File Offset: 0x0002827D
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06005890 RID: 22672 RVA: 0x0019F378 File Offset: 0x0019D578
		// (set) Token: 0x06005891 RID: 22673 RVA: 0x0002A09C File Offset: 0x0002829C
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x0019F3A8 File Offset: 0x0019D5A8
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x0002A0BB File Offset: 0x000282BB
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x0019F3D0 File Offset: 0x0019D5D0
		// (set) Token: 0x06005895 RID: 22677 RVA: 0x0002A0D6 File Offset: 0x000282D6
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003BC7 RID: 15303
		private static readonly System.IntPtr NativeFieldInfoPtr_CRITICAL_WATERING_THRESHOLD;

		// Token: 0x04003BC8 RID: 15304
		private static readonly System.IntPtr NativeFieldInfoPtr_WATERING_THRESHOLD;

		// Token: 0x04003BC9 RID: 15305
		private static readonly System.IntPtr NativeFieldInfoPtr_TARGET_WATER_LEVEL_MIN;

		// Token: 0x04003BCA RID: 15306
		private static readonly System.IntPtr NativeFieldInfoPtr_TARGET_WATER_LEVEL_MAX;

		// Token: 0x04003BCB RID: 15307
		private static readonly System.IntPtr NativeFieldInfoPtr_SOIL_POUR_TIME;

		// Token: 0x04003BCC RID: 15308
		private static readonly System.IntPtr NativeFieldInfoPtr_WATER_POUR_TIME;

		// Token: 0x04003BCD RID: 15309
		private static readonly System.IntPtr NativeFieldInfoPtr_ADDITIVE_POUR_TIME;

		// Token: 0x04003BCE RID: 15310
		private static readonly System.IntPtr NativeFieldInfoPtr_SEED_SOW_TIME;

		// Token: 0x04003BCF RID: 15311
		private static readonly System.IntPtr NativeFieldInfoPtr_HARVEST_TIME;

		// Token: 0x04003BD0 RID: 15312
		private static readonly System.IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04003BD1 RID: 15313
		private static readonly System.IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003BD2 RID: 15314
		private static readonly System.IntPtr NativeFieldInfoPtr_PotActionBehaviour;

		// Token: 0x04003BD3 RID: 15315
		private static readonly System.IntPtr NativeFieldInfoPtr_StartDryingRackBehaviour;

		// Token: 0x04003BD4 RID: 15316
		private static readonly System.IntPtr NativeFieldInfoPtr_StopDryingRackBehaviour;

		// Token: 0x04003BD5 RID: 15317
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003BD6 RID: 15318
		private static readonly System.IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003BD7 RID: 15319
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxAssignedPots;

		// Token: 0x04003BD8 RID: 15320
		private static readonly System.IntPtr NativeFieldInfoPtr_NoAssignedStationsDialogue;

		// Token: 0x04003BD9 RID: 15321
		private static readonly System.IntPtr NativeFieldInfoPtr_UnspecifiedPotsDialogue;

		// Token: 0x04003BDA RID: 15322
		private static readonly System.IntPtr NativeFieldInfoPtr_NullDestinationPotsDialogue;

		// Token: 0x04003BDB RID: 15323
		private static readonly System.IntPtr NativeFieldInfoPtr_MissingMaterialsDialogue;

		// Token: 0x04003BDC RID: 15324
		private static readonly System.IntPtr NativeFieldInfoPtr_NoPotsRequireWorkDialogue;

		// Token: 0x04003BDD RID: 15325
		private static readonly System.IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003BDE RID: 15326
		private static readonly System.IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003BDF RID: 15327
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003BE0 RID: 15328
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x04003BE1 RID: 15329
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003BE2 RID: 15330
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003BE3 RID: 15331
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04003BE4 RID: 15332
		private static readonly System.IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0;

		// Token: 0x04003BE5 RID: 15333
		private static readonly System.IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0;

		// Token: 0x04003BE6 RID: 15334
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003BE7 RID: 15335
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003BE8 RID: 15336
		private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003BE9 RID: 15337
		private static readonly System.IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003BEA RID: 15338
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003BEB RID: 15339
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003BEC RID: 15340
		private static readonly System.IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003BED RID: 15341
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003BEE RID: 15342
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003BEF RID: 15343
		private static readonly System.IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003BF0 RID: 15344
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003BF1 RID: 15345
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003BF2 RID: 15346
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003BF3 RID: 15347
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0;

		// Token: 0x04003BF4 RID: 15348
		private static readonly System.IntPtr NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0;

		// Token: 0x04003BF5 RID: 15349
		private static readonly System.IntPtr NativeMethodInfoPtr_StartAction_Private_Void_Pot_EActionType_0;

		// Token: 0x04003BF6 RID: 15350
		private static readonly System.IntPtr NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0;

		// Token: 0x04003BF7 RID: 15351
		private static readonly System.IntPtr NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0;

		// Token: 0x04003BF8 RID: 15352
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003BF9 RID: 15353
		private static readonly System.IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003BFA RID: 15354
		private static readonly System.IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0;

		// Token: 0x04003BFB RID: 15355
		private static readonly System.IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0;

		// Token: 0x04003BFC RID: 15356
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0;

		// Token: 0x04003BFD RID: 15357
		private static readonly System.IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003BFE RID: 15358
		private static readonly System.IntPtr NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0;

		// Token: 0x04003BFF RID: 15359
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0;

		// Token: 0x04003C00 RID: 15360
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0;

		// Token: 0x04003C01 RID: 15361
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemInSupplies_Public_ItemInstance_String_0;

		// Token: 0x04003C02 RID: 15362
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSeedInSupplies_Public_ItemInstance_0;

		// Token: 0x04003C03 RID: 15363
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x04003C04 RID: 15364
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0;

		// Token: 0x04003C05 RID: 15365
		private static readonly System.IntPtr NativeMethodInfoPtr_AreThereUnspecifiedPots_Private_Boolean_0;

		// Token: 0x04003C06 RID: 15366
		private static readonly System.IntPtr NativeMethodInfoPtr_AreThereNullDestinationPots_Private_Boolean_0;

		// Token: 0x04003C07 RID: 15367
		private static readonly System.IntPtr NativeMethodInfoPtr_IsMissingRequiredMaterials_Private_Boolean_0;

		// Token: 0x04003C08 RID: 15368
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_Boolean_0;

		// Token: 0x04003C09 RID: 15369
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPotForSoilSour_Private_Pot_0;

		// Token: 0x04003C0A RID: 15370
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0;

		// Token: 0x04003C0B RID: 15371
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAccessableEntity_Private_T_T_0;

		// Token: 0x04003C0C RID: 15372
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAccessableEntities_Private_List_1_T_List_1_T_0;

		// Token: 0x04003C0D RID: 15373
		private static readonly System.IntPtr NativeMethodInfoPtr_FilterPotsForSpecifiedSeed_Private_List_1_Pot_List_1_Pot_0;

		// Token: 0x04003C0E RID: 15374
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPotForAdditives_Private_Pot_byref_Int32_0;

		// Token: 0x04003C0F RID: 15375
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0;

		// Token: 0x04003C10 RID: 15376
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0;

		// Token: 0x04003C11 RID: 15377
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0;

		// Token: 0x04003C12 RID: 15378
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0;

		// Token: 0x04003C13 RID: 15379
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003C14 RID: 15380
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003C15 RID: 15381
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04003C16 RID: 15382
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x04003C17 RID: 15383
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x04003C18 RID: 15384
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C19 RID: 15385
		private static readonly System.IntPtr NativeMethodInfoPtr__GetAccessableEntities_b__77_0_Private_Boolean_T_0;

		// Token: 0x04003C1A RID: 15386
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003C1B RID: 15387
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003C1C RID: 15388
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003C1D RID: 15389
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04003C1E RID: 15390
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003C1F RID: 15391
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003C20 RID: 15392
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003C21 RID: 15393
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003C22 RID: 15394
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003C23 RID: 15395
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A14 RID: 2580
		[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c__DisplayClass58_0")]
		public sealed class __c__DisplayClass58_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1A8 RID: 53672 RVA: 0x0032ADA0 File Offset: 0x00328FA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass58_0()
			{
				Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<>c__DisplayClass58_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr);
				Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, "<>4__this");
				Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, "conn");
				Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, 100674495);
				Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, 100674496);
				Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, 100674497);
			}

			// Token: 0x0600D1A9 RID: 53673 RVA: 0x0032AE30 File Offset: 0x00329030
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass58_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1AA RID: 53674 RVA: 0x0032AE6C File Offset: 0x0032906C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187549, XrefRangeEnd = 187554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D1AB RID: 53675 RVA: 0x0032AEAC File Offset: 0x003290AC
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D1AC RID: 53676 RVA: 0x00065A56 File Offset: 0x00063C56
			public __c__DisplayClass58_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004101 RID: 16641
			// (get) Token: 0x0600D1AD RID: 53677 RVA: 0x0032AEE8 File Offset: 0x003290E8
			// (set) Token: 0x0600D1AE RID: 53678 RVA: 0x00065A5F File Offset: 0x00063C5F
			public unsafe Botanist __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004102 RID: 16642
			// (get) Token: 0x0600D1AF RID: 53679 RVA: 0x0032AF18 File Offset: 0x00329118
			// (set) Token: 0x0600D1B0 RID: 53680 RVA: 0x00065A7E File Offset: 0x00063C7E
			public unsafe NetworkConnection conn
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr_conn);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DCE RID: 36302
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DCF RID: 36303
			private static readonly System.IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x04008DD0 RID: 36304
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DD1 RID: 36305
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008DD2 RID: 36306
			private static readonly System.IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000CA6 RID: 3238
			[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c__DisplayClass58_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E86F RID: 59503 RVA: 0x0036B1EC File Offset: 0x003693EC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674498);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674499);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674500);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674501);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674502);
					Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674503);
				}

				// Token: 0x0600E870 RID: 59504 RVA: 0x0036B2CC File Offset: 0x003694CC
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E871 RID: 59505 RVA: 0x0036B314 File Offset: 0x00369514
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E872 RID: 59506 RVA: 0x0036B348 File Offset: 0x00369548
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187533, XrefRangeEnd = 187544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047CC RID: 18380
				// (get) Token: 0x0600E873 RID: 59507 RVA: 0x0036B384 File Offset: 0x00369584
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E874 RID: 59508 RVA: 0x0036B3C4 File Offset: 0x003695C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187544, XrefRangeEnd = 187549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047CD RID: 18381
				// (get) Token: 0x0600E875 RID: 59509 RVA: 0x0036B3F8 File Offset: 0x003695F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E876 RID: 59510 RVA: 0x00071037 File Offset: 0x0006F237
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047C9 RID: 18377
				// (get) Token: 0x0600E877 RID: 59511 RVA: 0x0036B438 File Offset: 0x00369638
				// (set) Token: 0x0600E878 RID: 59512 RVA: 0x00071040 File Offset: 0x0006F240
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047CA RID: 18378
				// (get) Token: 0x0600E879 RID: 59513 RVA: 0x0036B460 File Offset: 0x00369660
				// (set) Token: 0x0600E87A RID: 59514 RVA: 0x0007105B File Offset: 0x0006F25B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047CB RID: 18379
				// (get) Token: 0x0600E87B RID: 59515 RVA: 0x0036B490 File Offset: 0x00369690
				// (set) Token: 0x0600E87C RID: 59516 RVA: 0x0007107A File Offset: 0x0006F27A
				public unsafe Botanist.__c__DisplayClass58_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist.__c__DisplayClass58_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass58_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009B9B RID: 39835
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B9C RID: 39836
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B9D RID: 39837
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B9E RID: 39838
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B9F RID: 39839
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BA0 RID: 39840
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BA1 RID: 39841
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BA2 RID: 39842
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BA3 RID: 39843
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A15 RID: 2581
		private sealed class MethodInfoStoreGeneric_GetAccessableEntity_Private_T_T_0<T>
		{
			// Token: 0x04008DD3 RID: 36307
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Botanist.NativeMethodInfoPtr_GetAccessableEntity_Private_T_T_0, Il2CppClassPointerStore<Botanist>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A16 RID: 2582
		private sealed class MethodInfoStoreGeneric_GetAccessableEntities_Private_List_1_T_List_1_T_0<T>
		{
			// Token: 0x04008DD4 RID: 36308
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Botanist.NativeMethodInfoPtr_GetAccessableEntities_Private_List_1_T_List_1_T_0, Il2CppClassPointerStore<Botanist>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A17 RID: 2583
		private sealed class MethodInfoStoreGeneric__GetAccessableEntities_b__77_0_Private_Boolean_T_0<T>
		{
			// Token: 0x04008DD5 RID: 36309
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Botanist.NativeMethodInfoPtr__GetAccessableEntities_b__77_0_Private_Boolean_T_0, Il2CppClassPointerStore<Botanist>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
