using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000531 RID: 1329
	public class Property : NetworkBehaviour
	{
		// Token: 0x06007495 RID: 29845 RVA: 0x001FF8C4 File Offset: 0x001FDAC4
		// Note: this type is marked as 'beforefieldinit'.
		static Property()
		{
			Il2CppClassPointerStore<Property>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Property");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property>.NativeClassPtr);
			Property.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Properties");
			Property.NativeFieldInfoPtr_UnownedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "UnownedProperties");
			Property.NativeFieldInfoPtr_OwnedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "OwnedProperties");
			Property.NativeFieldInfoPtr_onPropertyAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "onPropertyAcquired");
			Property.NativeFieldInfoPtr_onThisPropertyAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "onThisPropertyAcquired");
			Property.NativeFieldInfoPtr__IsOwned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<IsOwned>k__BackingField");
			Property.NativeFieldInfoPtr__Employees_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<Employees>k__BackingField");
			Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<WorldspaceUIContainer>k__BackingField");
			Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<IsContentCulled>k__BackingField");
			Property.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyName");
			Property.NativeFieldInfoPtr_AvailableInDemo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "AvailableInDemo");
			Property.NativeFieldInfoPtr_propertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyCode");
			Property.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Price");
			Property.NativeFieldInfoPtr_DefaultRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DefaultRotation");
			Property.NativeFieldInfoPtr_EmployeeCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeCapacity");
			Property.NativeFieldInfoPtr_OwnedByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "OwnedByDefault");
			Property.NativeFieldInfoPtr_DEBUG_SET_OWNED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DEBUG_SET_OWNED");
			Property.NativeFieldInfoPtr_IsOwnedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "IsOwnedVariable");
			Property.NativeFieldInfoPtr_ContentCullingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ContentCullingEnabled");
			Property.NativeFieldInfoPtr_MinimumCullingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MinimumCullingDistance");
			Property.NativeFieldInfoPtr_ObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ObjectsToCull");
			Property.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Container");
			Property.NativeFieldInfoPtr_EmployeeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeContainer");
			Property.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "SpawnPoint");
			Property.NativeFieldInfoPtr_InteriorSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "InteriorSpawnPoint");
			Property.NativeFieldInfoPtr_ForSaleSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ForSaleSign");
			Property.NativeFieldInfoPtr_BoundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "BoundingBox");
			Property.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "PoI");
			Property.NativeFieldInfoPtr_ListingPoster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ListingPoster");
			Property.NativeFieldInfoPtr_NPCSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NPCSpawnPoint");
			Property.NativeFieldInfoPtr_EmployeeIdlePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "EmployeeIdlePoints");
			Property.NativeFieldInfoPtr_Switches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Switches");
			Property.NativeFieldInfoPtr_Toggleables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Toggleables");
			Property.NativeFieldInfoPtr_DisposalArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "DisposalArea");
			Property.NativeFieldInfoPtr_LoadingDocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "LoadingDocks");
			Property.NativeFieldInfoPtr_BuildableItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "BuildableItems");
			Property.NativeFieldInfoPtr_Configurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Configurables");
			Property.NativeFieldInfoPtr_propertyBoundsColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "propertyBoundsColliders");
			Property.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "loader");
			Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Property.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "<HasChanged>k__BackingField");
			Property.NativeFieldInfoPtr_savedObjectPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "savedObjectPaths");
			Property.NativeFieldInfoPtr_savedEmployeePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "savedEmployeePaths");
			Property.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted");
			Property.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted");
			Property.NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678021);
			Property.NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678022);
			Property.NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678023);
			Property.NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678024);
			Property.NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678025);
			Property.NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678026);
			Property.NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678027);
			Property.NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678028);
			Property.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678029);
			Property.NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678030);
			Property.NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678031);
			Property.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678032);
			Property.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678033);
			Property.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678034);
			Property.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678035);
			Property.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678036);
			Property.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678037);
			Property.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678038);
			Property.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678039);
			Property.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678040);
			Property.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678041);
			Property.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678042);
			Property.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678043);
			Property.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678044);
			Property.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678045);
			Property.NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678046);
			Property.NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678047);
			Property.NativeMethodInfoPtr_UpdateCulling_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678048);
			Property.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678049);
			Property.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678050);
			Property.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678051);
			Property.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678052);
			Property.NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678053);
			Property.NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678054);
			Property.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678055);
			Property.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678056);
			Property.NativeMethodInfoPtr_SetOwned_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678057);
			Property.NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678058);
			Property.NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678059);
			Property.NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678060);
			Property.NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678061);
			Property.NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678062);
			Property.NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678063);
			Property.NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678064);
			Property.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678065);
			Property.NativeMethodInfoPtr_GetEmployeeSaveDatas_Protected_List_1_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678066);
			Property.NativeMethodInfoPtr_GetObjectSaveDatas_Protected_List_1_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678067);
			Property.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678068);
			Property.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678069);
			Property.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678070);
			Property.NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678071);
			Property.NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678072);
			Property.NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678073);
			Property.NativeMethodInfoPtr_GetBuildablesOfType_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678074);
			Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678075);
			Property.NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678077);
			Property.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678078);
			Property.NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678079);
			Property.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678080);
			Property.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678081);
			Property.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678082);
			Property.NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678083);
			Property.NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678084);
			Property.NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678085);
			Property.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678086);
			Property.NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678087);
			Property.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678088);
			Property.NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678089);
			Property.NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678090);
			Property.NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678091);
			Property.NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678092);
			Property.NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678093);
			Property.NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678094);
			Property.NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678095);
			Property.NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678096);
			Property.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100678097);
		}

		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x06007496 RID: 29846 RVA: 0x0020027C File Offset: 0x001FE47C
		// (set) Token: 0x06007497 RID: 29847 RVA: 0x002002B8 File Offset: 0x001FE4B8
		public unsafe bool IsOwned
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x06007498 RID: 29848 RVA: 0x002002F8 File Offset: 0x001FE4F8
		// (set) Token: 0x06007499 RID: 29849 RVA: 0x00200338 File Offset: 0x001FE538
		public unsafe List<Employee> Employees
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0600749A RID: 29850 RVA: 0x0020037C File Offset: 0x001FE57C
		// (set) Token: 0x0600749B RID: 29851 RVA: 0x002003BC File Offset: 0x001FE5BC
		public unsafe RectTransform WorldspaceUIContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0600749C RID: 29852 RVA: 0x00200400 File Offset: 0x001FE600
		// (set) Token: 0x0600749D RID: 29853 RVA: 0x0020043C File Offset: 0x001FE63C
		public unsafe bool IsContentCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x0600749E RID: 29854 RVA: 0x0020047C File Offset: 0x001FE67C
		public unsafe string PropertyName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_PropertyName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x0600749F RID: 29855 RVA: 0x002004B4 File Offset: 0x001FE6B4
		public unsafe string PropertyCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x060074A0 RID: 29856 RVA: 0x002004EC File Offset: 0x001FE6EC
		public unsafe int LoadingDockCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 228525, RefRangeEnd = 228528, XrefRangeStart = 228525, XrefRangeEnd = 228525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x060074A1 RID: 29857 RVA: 0x00200528 File Offset: 0x001FE728
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x060074A2 RID: 29858 RVA: 0x00200560 File Offset: 0x001FE760
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228528, XrefRangeEnd = 228529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x060074A3 RID: 29859 RVA: 0x00200598 File Offset: 0x001FE798
		public unsafe virtual Loader Loader
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 171090, RefRangeEnd = 171104, XrefRangeStart = 171090, XrefRangeEnd = 171104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x060074A4 RID: 29860 RVA: 0x002005D8 File Offset: 0x001FE7D8
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x060074A5 RID: 29861 RVA: 0x00200614 File Offset: 0x001FE814
		// (set) Token: 0x060074A6 RID: 29862 RVA: 0x00200654 File Offset: 0x001FE854
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x060074A7 RID: 29863 RVA: 0x00200698 File Offset: 0x001FE898
		// (set) Token: 0x060074A8 RID: 29864 RVA: 0x002006D8 File Offset: 0x001FE8D8
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228529, XrefRangeEnd = 228530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x060074A9 RID: 29865 RVA: 0x0020071C File Offset: 0x001FE91C
		// (set) Token: 0x060074AA RID: 29866 RVA: 0x00200758 File Offset: 0x001FE958
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060074AB RID: 29867 RVA: 0x00200798 File Offset: 0x001FE998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228530, XrefRangeEnd = 228531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x002007D4 File Offset: 0x001FE9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228531, XrefRangeEnd = 228537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x00200810 File Offset: 0x001FEA10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 228555, RefRangeEnd = 228560, XrefRangeStart = 228537, XrefRangeEnd = 228555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074AE RID: 29870 RVA: 0x0020084C File Offset: 0x001FEA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228560, XrefRangeEnd = 228561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x00200888 File Offset: 0x001FEA88
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 228567, RefRangeEnd = 228579, XrefRangeStart = 228561, XrefRangeEnd = 228567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConfigurable(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x002008CC File Offset: 0x001FEACC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 228585, RefRangeEnd = 228600, XrefRangeStart = 228579, XrefRangeEnd = 228585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveConfigurable(IConfigurable configurable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00200910 File Offset: 0x001FEB10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228622, RefRangeEnd = 228623, XrefRangeStart = 228600, XrefRangeEnd = 228622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCulling()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_UpdateCulling_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x00200944 File Offset: 0x001FEB44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228632, RefRangeEnd = 228634, XrefRangeStart = 228623, XrefRangeEnd = 228632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x00200994 File Offset: 0x001FEB94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228668, RefRangeEnd = 228669, XrefRangeStart = 228634, XrefRangeEnd = 228668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x002009D0 File Offset: 0x001FEBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228669, XrefRangeEnd = 228670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x00200A20 File Offset: 0x001FEC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228670, XrefRangeEnd = 228689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x00200A5C File Offset: 0x001FEC5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228710, RefRangeEnd = 228714, XrefRangeStart = 228689, XrefRangeEnd = 228710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwned_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x00200A90 File Offset: 0x001FEC90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228734, RefRangeEnd = 228736, XrefRangeStart = 228714, XrefRangeEnd = 228734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveOwned_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x00200AC4 File Offset: 0x001FECC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228792, RefRangeEnd = 228793, XrefRangeStart = 228736, XrefRangeEnd = 228792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x00200B00 File Offset: 0x001FED00
		[CallerCount(0)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x00200B48 File Offset: 0x001FED48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228794, RefRangeEnd = 228797, XrefRangeStart = 228793, XrefRangeEnd = 228794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetOwned_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x00200B7C File Offset: 0x001FED7C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBoundsVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x00200BBC File Offset: 0x001FEDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228797, XrefRangeEnd = 228820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref culled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074BD RID: 29885 RVA: 0x00200C08 File Offset: 0x001FEE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228830, RefRangeEnd = 228831, XrefRangeStart = 228820, XrefRangeEnd = 228830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RegisterEmployee(Employee emp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emp);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x00200C58 File Offset: 0x001FEE58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228835, RefRangeEnd = 228836, XrefRangeStart = 228831, XrefRangeEnd = 228835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterEmployee(Employee emp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emp);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074BF RID: 29887 RVA: 0x00200C9C File Offset: 0x001FEE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228836, XrefRangeEnd = 228851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleableActioned(InteractableToggleable toggleable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toggleable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x00200CE0 File Offset: 0x001FEEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228851, XrefRangeEnd = 228863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendToggleableState(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x00200D2C File Offset: 0x001FEF2C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228898, RefRangeEnd = 228901, XrefRangeStart = 228863, XrefRangeEnd = 228898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToggleableState(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x00200D8C File Offset: 0x001FEF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228901, XrefRangeEnd = 228940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x00200DD0 File Offset: 0x001FEFD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228960, RefRangeEnd = 228962, XrefRangeStart = 228940, XrefRangeEnd = 228960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DynamicSaveData> GetEmployeeSaveDatas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_GetEmployeeSaveDatas_Protected_List_1_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DynamicSaveData>>(intPtr2) : null;
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x00200E10 File Offset: 0x001FF010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228982, RefRangeEnd = 228984, XrefRangeStart = 228962, XrefRangeEnd = 228982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DynamicSaveData> GetObjectSaveDatas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_GetObjectSaveDatas_Protected_List_1_DynamicSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DynamicSaveData>>(intPtr2) : null;
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x00200E50 File Offset: 0x001FF050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228984, XrefRangeEnd = 228993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x00200EAC File Offset: 0x001FF0AC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x00200EFC File Offset: 0x001FF0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228993, XrefRangeEnd = 229006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PropertyData propertyData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x00200F4C File Offset: 0x001FF14C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 229012, RefRangeEnd = 229018, XrefRangeStart = 229006, XrefRangeEnd = 229012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x00200F98 File Offset: 0x001FF198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229028, RefRangeEnd = 229029, XrefRangeStart = 229018, XrefRangeEnd = 229028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldPoint;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(box);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x00200FF4 File Offset: 0x001FF1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 229054, RefRangeEnd = 229055, XrefRangeStart = 229029, XrefRangeEnd = 229054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Bed> GetUnassignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bed>>(intPtr2) : null;
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x00201034 File Offset: 0x001FF234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229083, RefRangeEnd = 229085, XrefRangeStart = 229055, XrefRangeEnd = 229083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetBuildablesOfType<T>() where T : BuildableItem
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.MethodInfoStoreGeneric_GetBuildablesOfType_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x00201074 File Offset: 0x001FF274
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 229145, RefRangeEnd = 229150, XrefRangeStart = 229085, XrefRangeEnd = 229145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x002010B0 File Offset: 0x001FF2B0
		[CallerCount(0)]
		public unsafe void _Awake_b__80_0(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref <p0>;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074CE RID: 29902 RVA: 0x002010F0 File Offset: 0x001FF2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229150, XrefRangeEnd = 229155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060074CF RID: 29903 RVA: 0x00201130 File Offset: 0x001FF330
		[CallerCount(0)]
		public unsafe bool _RecieveOwned_b__93_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060074D0 RID: 29904 RVA: 0x0020116C File Offset: 0x001FF36C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 229187, RefRangeEnd = 229192, XrefRangeStart = 229155, XrefRangeEnd = 229187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D1 RID: 29905 RVA: 0x002011A8 File Offset: 0x001FF3A8
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D2 RID: 29906 RVA: 0x002011E4 File Offset: 0x001FF3E4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D3 RID: 29907 RVA: 0x00201220 File Offset: 0x001FF420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229192, XrefRangeEnd = 229201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwned_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D4 RID: 29908 RVA: 0x00201254 File Offset: 0x001FF454
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228734, RefRangeEnd = 228736, XrefRangeStart = 228734, XrefRangeEnd = 228736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOwned_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D5 RID: 29909 RVA: 0x00201288 File Offset: 0x001FF488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229201, XrefRangeEnd = 229204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D6 RID: 29910 RVA: 0x002012EC File Offset: 0x001FF4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229204, XrefRangeEnd = 229213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D7 RID: 29911 RVA: 0x00201320 File Offset: 0x001FF520
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D8 RID: 29912 RVA: 0x00201354 File Offset: 0x001FF554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229213, XrefRangeEnd = 229215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x002013A4 File Offset: 0x001FF5A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x002013F0 File Offset: 0x001FF5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229215, XrefRangeEnd = 229216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x0020143C File Offset: 0x001FF63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229216, XrefRangeEnd = 229220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074DC RID: 29916 RVA: 0x002014A0 File Offset: 0x001FF6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229220, XrefRangeEnd = 229232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074DD RID: 29917 RVA: 0x00201500 File Offset: 0x001FF700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229237, RefRangeEnd = 229239, XrefRangeStart = 229232, XrefRangeEnd = 229237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074DE RID: 29918 RVA: 0x00201560 File Offset: 0x001FF760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229239, XrefRangeEnd = 229243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074DF RID: 29919 RVA: 0x002015B0 File Offset: 0x001FF7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229243, XrefRangeEnd = 229255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074E0 RID: 29920 RVA: 0x00201610 File Offset: 0x001FF810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229255, XrefRangeEnd = 229260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074E1 RID: 29921 RVA: 0x00201660 File Offset: 0x001FF860
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 229436, RefRangeEnd = 229442, XrefRangeStart = 229260, XrefRangeEnd = 229436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x00037320 File Offset: 0x00035520
		public Property(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x060074E3 RID: 29923 RVA: 0x0020169C File Offset: 0x001FF89C
		// (set) Token: 0x060074E4 RID: 29924 RVA: 0x00037329 File Offset: 0x00035529
		public unsafe static List<Property> Properties
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_Properties, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_Properties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x002016C4 File Offset: 0x001FF8C4
		// (set) Token: 0x060074E6 RID: 29926 RVA: 0x0003733B File Offset: 0x0003553B
		public unsafe static List<Property> UnownedProperties
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_UnownedProperties, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_UnownedProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002323 RID: 8995
		// (get) Token: 0x060074E7 RID: 29927 RVA: 0x002016EC File Offset: 0x001FF8EC
		// (set) Token: 0x060074E8 RID: 29928 RVA: 0x0003734D File Offset: 0x0003554D
		public unsafe static List<Property> OwnedProperties
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_OwnedProperties, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_OwnedProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002324 RID: 8996
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x00201714 File Offset: 0x001FF914
		// (set) Token: 0x060074EA RID: 29930 RVA: 0x0003735F File Offset: 0x0003555F
		public unsafe static Property.PropertyChange onPropertyAcquired
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Property.NativeFieldInfoPtr_onPropertyAcquired, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property.PropertyChange>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Property.NativeFieldInfoPtr_onPropertyAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002325 RID: 8997
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0020173C File Offset: 0x001FF93C
		// (set) Token: 0x060074EC RID: 29932 RVA: 0x00037371 File Offset: 0x00035571
		public unsafe UnityEvent onThisPropertyAcquired
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_onThisPropertyAcquired);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_onThisPropertyAcquired), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x060074ED RID: 29933 RVA: 0x0020176C File Offset: 0x001FF96C
		// (set) Token: 0x060074EE RID: 29934 RVA: 0x00037390 File Offset: 0x00035590
		public unsafe bool _IsOwned_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsOwned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsOwned_k__BackingField)) = value;
			}
		}

		// Token: 0x17002327 RID: 8999
		// (get) Token: 0x060074EF RID: 29935 RVA: 0x00201794 File Offset: 0x001FF994
		// (set) Token: 0x060074F0 RID: 29936 RVA: 0x000373AB File Offset: 0x000355AB
		public unsafe List<Employee> _Employees_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__Employees_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__Employees_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002328 RID: 9000
		// (get) Token: 0x060074F1 RID: 29937 RVA: 0x002017C4 File Offset: 0x001FF9C4
		// (set) Token: 0x060074F2 RID: 29938 RVA: 0x000373CA File Offset: 0x000355CA
		public unsafe RectTransform _WorldspaceUIContainer_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002329 RID: 9001
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x002017F4 File Offset: 0x001FF9F4
		// (set) Token: 0x060074F4 RID: 29940 RVA: 0x000373E9 File Offset: 0x000355E9
		public unsafe bool _IsContentCulled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__IsContentCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700232A RID: 9002
		// (get) Token: 0x060074F5 RID: 29941 RVA: 0x0020181C File Offset: 0x001FFA1C
		// (set) Token: 0x060074F6 RID: 29942 RVA: 0x00037404 File Offset: 0x00035604
		public unsafe string propertyName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x060074F7 RID: 29943 RVA: 0x00201844 File Offset: 0x001FFA44
		// (set) Token: 0x060074F8 RID: 29944 RVA: 0x00037423 File Offset: 0x00035623
		public unsafe bool AvailableInDemo
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AvailableInDemo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AvailableInDemo)) = value;
			}
		}

		// Token: 0x1700232C RID: 9004
		// (get) Token: 0x060074F9 RID: 29945 RVA: 0x0020186C File Offset: 0x001FFA6C
		// (set) Token: 0x060074FA RID: 29946 RVA: 0x0003743E File Offset: 0x0003563E
		public unsafe string propertyCode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x060074FB RID: 29947 RVA: 0x00201894 File Offset: 0x001FFA94
		// (set) Token: 0x060074FC RID: 29948 RVA: 0x0003745D File Offset: 0x0003565D
		public unsafe float Price
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x060074FD RID: 29949 RVA: 0x002018BC File Offset: 0x001FFABC
		// (set) Token: 0x060074FE RID: 29950 RVA: 0x00037478 File Offset: 0x00035678
		public unsafe float DefaultRotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DefaultRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DefaultRotation)) = value;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x002018E4 File Offset: 0x001FFAE4
		// (set) Token: 0x06007500 RID: 29952 RVA: 0x00037493 File Offset: 0x00035693
		public unsafe int EmployeeCapacity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeCapacity)) = value;
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x06007501 RID: 29953 RVA: 0x0020190C File Offset: 0x001FFB0C
		// (set) Token: 0x06007502 RID: 29954 RVA: 0x000374AE File Offset: 0x000356AE
		public unsafe bool OwnedByDefault
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_OwnedByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_OwnedByDefault)) = value;
			}
		}

		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x06007503 RID: 29955 RVA: 0x00201934 File Offset: 0x001FFB34
		// (set) Token: 0x06007504 RID: 29956 RVA: 0x000374C9 File Offset: 0x000356C9
		public unsafe bool DEBUG_SET_OWNED
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DEBUG_SET_OWNED);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DEBUG_SET_OWNED)) = value;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x0020195C File Offset: 0x001FFB5C
		// (set) Token: 0x06007506 RID: 29958 RVA: 0x000374E4 File Offset: 0x000356E4
		public unsafe string IsOwnedVariable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_IsOwnedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_IsOwnedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002333 RID: 9011
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x00201984 File Offset: 0x001FFB84
		// (set) Token: 0x06007508 RID: 29960 RVA: 0x00037503 File Offset: 0x00035703
		public unsafe bool ContentCullingEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ContentCullingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ContentCullingEnabled)) = value;
			}
		}

		// Token: 0x17002334 RID: 9012
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x002019AC File Offset: 0x001FFBAC
		// (set) Token: 0x0600750A RID: 29962 RVA: 0x0003751E File Offset: 0x0003571E
		public unsafe float MinimumCullingDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MinimumCullingDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MinimumCullingDistance)) = value;
			}
		}

		// Token: 0x17002335 RID: 9013
		// (get) Token: 0x0600750B RID: 29963 RVA: 0x002019D4 File Offset: 0x001FFBD4
		// (set) Token: 0x0600750C RID: 29964 RVA: 0x00037539 File Offset: 0x00035739
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToCull
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ObjectsToCull);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002336 RID: 9014
		// (get) Token: 0x0600750D RID: 29965 RVA: 0x00201A04 File Offset: 0x001FFC04
		// (set) Token: 0x0600750E RID: 29966 RVA: 0x00037558 File Offset: 0x00035758
		public unsafe PropertyContentsContainer Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyContentsContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002337 RID: 9015
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x00201A34 File Offset: 0x001FFC34
		// (set) Token: 0x06007510 RID: 29968 RVA: 0x00037577 File Offset: 0x00035777
		public unsafe Transform EmployeeContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002338 RID: 9016
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x00201A64 File Offset: 0x001FFC64
		// (set) Token: 0x06007512 RID: 29970 RVA: 0x00037596 File Offset: 0x00035796
		public unsafe Transform SpawnPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_SpawnPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x06007513 RID: 29971 RVA: 0x00201A94 File Offset: 0x001FFC94
		// (set) Token: 0x06007514 RID: 29972 RVA: 0x000375B5 File Offset: 0x000357B5
		public unsafe Transform InteriorSpawnPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_InteriorSpawnPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_InteriorSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x06007515 RID: 29973 RVA: 0x00201AC4 File Offset: 0x001FFCC4
		// (set) Token: 0x06007516 RID: 29974 RVA: 0x000375D4 File Offset: 0x000357D4
		public unsafe GameObject ForSaleSign
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ForSaleSign);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ForSaleSign), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x06007517 RID: 29975 RVA: 0x00201AF4 File Offset: 0x001FFCF4
		// (set) Token: 0x06007518 RID: 29976 RVA: 0x000375F3 File Offset: 0x000357F3
		public unsafe GameObject BoundingBox
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BoundingBox);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BoundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x00201B24 File Offset: 0x001FFD24
		// (set) Token: 0x0600751A RID: 29978 RVA: 0x00037612 File Offset: 0x00035812
		public unsafe POI PoI
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_PoI);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600751B RID: 29979 RVA: 0x00201B54 File Offset: 0x001FFD54
		// (set) Token: 0x0600751C RID: 29980 RVA: 0x00037631 File Offset: 0x00035831
		public unsafe Transform ListingPoster
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ListingPoster);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ListingPoster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233E RID: 9022
		// (get) Token: 0x0600751D RID: 29981 RVA: 0x00201B84 File Offset: 0x001FFD84
		// (set) Token: 0x0600751E RID: 29982 RVA: 0x00037650 File Offset: 0x00035850
		public unsafe Transform NPCSpawnPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_NPCSpawnPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_NPCSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700233F RID: 9023
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x00201BB4 File Offset: 0x001FFDB4
		// (set) Token: 0x06007520 RID: 29984 RVA: 0x0003766F File Offset: 0x0003586F
		public unsafe Il2CppReferenceArray<Transform> EmployeeIdlePoints
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeIdlePoints);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_EmployeeIdlePoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002340 RID: 9024
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x00201BE4 File Offset: 0x001FFDE4
		// (set) Token: 0x06007522 RID: 29986 RVA: 0x0003768E File Offset: 0x0003588E
		public unsafe List<ModularSwitch> Switches
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Switches);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModularSwitch>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Switches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002341 RID: 9025
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x00201C14 File Offset: 0x001FFE14
		// (set) Token: 0x06007524 RID: 29988 RVA: 0x000376AD File Offset: 0x000358AD
		public unsafe List<InteractableToggleable> Toggleables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Toggleables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InteractableToggleable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Toggleables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002342 RID: 9026
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x00201C44 File Offset: 0x001FFE44
		// (set) Token: 0x06007526 RID: 29990 RVA: 0x000376CC File Offset: 0x000358CC
		public unsafe PropertyDisposalArea DisposalArea
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DisposalArea);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyDisposalArea>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_DisposalArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002343 RID: 9027
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x00201C74 File Offset: 0x001FFE74
		// (set) Token: 0x06007528 RID: 29992 RVA: 0x000376EB File Offset: 0x000358EB
		public unsafe Il2CppReferenceArray<LoadingDock> LoadingDocks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LoadingDocks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LoadingDock>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LoadingDocks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002344 RID: 9028
		// (get) Token: 0x06007529 RID: 29993 RVA: 0x00201CA4 File Offset: 0x001FFEA4
		// (set) Token: 0x0600752A RID: 29994 RVA: 0x0003770A File Offset: 0x0003590A
		public unsafe List<BuildableItem> BuildableItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BuildableItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_BuildableItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002345 RID: 9029
		// (get) Token: 0x0600752B RID: 29995 RVA: 0x00201CD4 File Offset: 0x001FFED4
		// (set) Token: 0x0600752C RID: 29996 RVA: 0x00037729 File Offset: 0x00035929
		public unsafe List<IConfigurable> Configurables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Configurables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Configurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x0600752D RID: 29997 RVA: 0x00201D04 File Offset: 0x001FFF04
		// (set) Token: 0x0600752E RID: 29998 RVA: 0x00037748 File Offset: 0x00035948
		public unsafe Il2CppReferenceArray<BoxCollider> propertyBoundsColliders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyBoundsColliders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_propertyBoundsColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002347 RID: 9031
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x00201D34 File Offset: 0x001FFF34
		// (set) Token: 0x06007530 RID: 30000 RVA: 0x00037767 File Offset: 0x00035967
		public unsafe PropertyLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002348 RID: 9032
		// (get) Token: 0x06007531 RID: 30001 RVA: 0x00201D64 File Offset: 0x001FFF64
		// (set) Token: 0x06007532 RID: 30002 RVA: 0x00037786 File Offset: 0x00035986
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002349 RID: 9033
		// (get) Token: 0x06007533 RID: 30003 RVA: 0x00201D94 File Offset: 0x001FFF94
		// (set) Token: 0x06007534 RID: 30004 RVA: 0x000377A5 File Offset: 0x000359A5
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234A RID: 9034
		// (get) Token: 0x06007535 RID: 30005 RVA: 0x00201DC4 File Offset: 0x001FFFC4
		// (set) Token: 0x06007536 RID: 30006 RVA: 0x000377C4 File Offset: 0x000359C4
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700234B RID: 9035
		// (get) Token: 0x06007537 RID: 30007 RVA: 0x00201DEC File Offset: 0x001FFFEC
		// (set) Token: 0x06007538 RID: 30008 RVA: 0x000377DF File Offset: 0x000359DF
		public unsafe List<string> savedObjectPaths
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedObjectPaths);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedObjectPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234C RID: 9036
		// (get) Token: 0x06007539 RID: 30009 RVA: 0x00201E1C File Offset: 0x0020001C
		// (set) Token: 0x0600753A RID: 30010 RVA: 0x000377FE File Offset: 0x000359FE
		public unsafe List<string> savedEmployeePaths
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedEmployeePaths);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_savedEmployeePaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x0600753B RID: 30011 RVA: 0x00201E4C File Offset: 0x0020004C
		// (set) Token: 0x0600753C RID: 30012 RVA: 0x0003781D File Offset: 0x00035A1D
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x00201E74 File Offset: 0x00200074
		// (set) Token: 0x0600753E RID: 30014 RVA: 0x00037838 File Offset: 0x00035A38
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004F92 RID: 20370
		private static readonly System.IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x04004F93 RID: 20371
		private static readonly System.IntPtr NativeFieldInfoPtr_UnownedProperties;

		// Token: 0x04004F94 RID: 20372
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnedProperties;

		// Token: 0x04004F95 RID: 20373
		private static readonly System.IntPtr NativeFieldInfoPtr_onPropertyAcquired;

		// Token: 0x04004F96 RID: 20374
		private static readonly System.IntPtr NativeFieldInfoPtr_onThisPropertyAcquired;

		// Token: 0x04004F97 RID: 20375
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOwned_k__BackingField;

		// Token: 0x04004F98 RID: 20376
		private static readonly System.IntPtr NativeFieldInfoPtr__Employees_k__BackingField;

		// Token: 0x04004F99 RID: 20377
		private static readonly System.IntPtr NativeFieldInfoPtr__WorldspaceUIContainer_k__BackingField;

		// Token: 0x04004F9A RID: 20378
		private static readonly System.IntPtr NativeFieldInfoPtr__IsContentCulled_k__BackingField;

		// Token: 0x04004F9B RID: 20379
		private static readonly System.IntPtr NativeFieldInfoPtr_propertyName;

		// Token: 0x04004F9C RID: 20380
		private static readonly System.IntPtr NativeFieldInfoPtr_AvailableInDemo;

		// Token: 0x04004F9D RID: 20381
		private static readonly System.IntPtr NativeFieldInfoPtr_propertyCode;

		// Token: 0x04004F9E RID: 20382
		private static readonly System.IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04004F9F RID: 20383
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultRotation;

		// Token: 0x04004FA0 RID: 20384
		private static readonly System.IntPtr NativeFieldInfoPtr_EmployeeCapacity;

		// Token: 0x04004FA1 RID: 20385
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnedByDefault;

		// Token: 0x04004FA2 RID: 20386
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_SET_OWNED;

		// Token: 0x04004FA3 RID: 20387
		private static readonly System.IntPtr NativeFieldInfoPtr_IsOwnedVariable;

		// Token: 0x04004FA4 RID: 20388
		private static readonly System.IntPtr NativeFieldInfoPtr_ContentCullingEnabled;

		// Token: 0x04004FA5 RID: 20389
		private static readonly System.IntPtr NativeFieldInfoPtr_MinimumCullingDistance;

		// Token: 0x04004FA6 RID: 20390
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectsToCull;

		// Token: 0x04004FA7 RID: 20391
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04004FA8 RID: 20392
		private static readonly System.IntPtr NativeFieldInfoPtr_EmployeeContainer;

		// Token: 0x04004FA9 RID: 20393
		private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04004FAA RID: 20394
		private static readonly System.IntPtr NativeFieldInfoPtr_InteriorSpawnPoint;

		// Token: 0x04004FAB RID: 20395
		private static readonly System.IntPtr NativeFieldInfoPtr_ForSaleSign;

		// Token: 0x04004FAC RID: 20396
		private static readonly System.IntPtr NativeFieldInfoPtr_BoundingBox;

		// Token: 0x04004FAD RID: 20397
		private static readonly System.IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04004FAE RID: 20398
		private static readonly System.IntPtr NativeFieldInfoPtr_ListingPoster;

		// Token: 0x04004FAF RID: 20399
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCSpawnPoint;

		// Token: 0x04004FB0 RID: 20400
		private static readonly System.IntPtr NativeFieldInfoPtr_EmployeeIdlePoints;

		// Token: 0x04004FB1 RID: 20401
		private static readonly System.IntPtr NativeFieldInfoPtr_Switches;

		// Token: 0x04004FB2 RID: 20402
		private static readonly System.IntPtr NativeFieldInfoPtr_Toggleables;

		// Token: 0x04004FB3 RID: 20403
		private static readonly System.IntPtr NativeFieldInfoPtr_DisposalArea;

		// Token: 0x04004FB4 RID: 20404
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadingDocks;

		// Token: 0x04004FB5 RID: 20405
		private static readonly System.IntPtr NativeFieldInfoPtr_BuildableItems;

		// Token: 0x04004FB6 RID: 20406
		private static readonly System.IntPtr NativeFieldInfoPtr_Configurables;

		// Token: 0x04004FB7 RID: 20407
		private static readonly System.IntPtr NativeFieldInfoPtr_propertyBoundsColliders;

		// Token: 0x04004FB8 RID: 20408
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004FB9 RID: 20409
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004FBA RID: 20410
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004FBB RID: 20411
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004FBC RID: 20412
		private static readonly System.IntPtr NativeFieldInfoPtr_savedObjectPaths;

		// Token: 0x04004FBD RID: 20413
		private static readonly System.IntPtr NativeFieldInfoPtr_savedEmployeePaths;

		// Token: 0x04004FBE RID: 20414
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004FBF RID: 20415
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004FC0 RID: 20416
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOwned_Public_get_Boolean_0;

		// Token: 0x04004FC1 RID: 20417
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOwned_Protected_set_Void_Boolean_0;

		// Token: 0x04004FC2 RID: 20418
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Employees_Public_get_List_1_Employee_0;

		// Token: 0x04004FC3 RID: 20419
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Employees_Protected_set_Void_List_1_Employee_0;

		// Token: 0x04004FC4 RID: 20420
		private static readonly System.IntPtr NativeMethodInfoPtr_get_WorldspaceUIContainer_Public_get_RectTransform_0;

		// Token: 0x04004FC5 RID: 20421
		private static readonly System.IntPtr NativeMethodInfoPtr_set_WorldspaceUIContainer_Protected_set_Void_RectTransform_0;

		// Token: 0x04004FC6 RID: 20422
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsContentCulled_Public_get_Boolean_0;

		// Token: 0x04004FC7 RID: 20423
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsContentCulled_Public_set_Void_Boolean_0;

		// Token: 0x04004FC8 RID: 20424
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyName_Public_get_String_0;

		// Token: 0x04004FC9 RID: 20425
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyCode_Public_get_String_0;

		// Token: 0x04004FCA RID: 20426
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadingDockCount_Public_get_Int32_0;

		// Token: 0x04004FCB RID: 20427
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004FCC RID: 20428
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004FCD RID: 20429
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004FCE RID: 20430
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004FCF RID: 20431
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004FD0 RID: 20432
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004FD1 RID: 20433
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004FD2 RID: 20434
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004FD3 RID: 20435
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004FD4 RID: 20436
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004FD5 RID: 20437
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004FD6 RID: 20438
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004FD7 RID: 20439
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04004FD8 RID: 20440
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04004FD9 RID: 20441
		private static readonly System.IntPtr NativeMethodInfoPtr_AddConfigurable_Public_Void_IConfigurable_0;

		// Token: 0x04004FDA RID: 20442
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveConfigurable_Public_Void_IConfigurable_0;

		// Token: 0x04004FDB RID: 20443
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCulling_Private_Void_0;

		// Token: 0x04004FDC RID: 20444
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004FDD RID: 20445
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_1;

		// Token: 0x04004FDE RID: 20446
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_New_Void_FloatContainer_0;

		// Token: 0x04004FDF RID: 20447
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04004FE0 RID: 20448
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOwned_Server_Protected_Void_0;

		// Token: 0x04004FE1 RID: 20449
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveOwned_Networked_Private_Void_0;

		// Token: 0x04004FE2 RID: 20450
		private static readonly System.IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_New_Void_1;

		// Token: 0x04004FE3 RID: 20451
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04004FE4 RID: 20452
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOwned_Public_Void_0;

		// Token: 0x04004FE5 RID: 20453
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBoundsVisible_Public_Void_Boolean_0;

		// Token: 0x04004FE6 RID: 20454
		private static readonly System.IntPtr NativeMethodInfoPtr_SetContentCulled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004FE7 RID: 20455
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterEmployee_Public_Int32_Employee_0;

		// Token: 0x04004FE8 RID: 20456
		private static readonly System.IntPtr NativeMethodInfoPtr_DeregisterEmployee_Public_Void_Employee_0;

		// Token: 0x04004FE9 RID: 20457
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleableActioned_Private_Void_InteractableToggleable_0;

		// Token: 0x04004FEA RID: 20458
		private static readonly System.IntPtr NativeMethodInfoPtr_SendToggleableState_Public_Void_Int32_Boolean_0;

		// Token: 0x04004FEB RID: 20459
		private static readonly System.IntPtr NativeMethodInfoPtr_SetToggleableState_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04004FEC RID: 20460
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004FED RID: 20461
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEmployeeSaveDatas_Protected_List_1_DynamicSaveData_0;

		// Token: 0x04004FEE RID: 20462
		private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectSaveDatas_Protected_List_1_DynamicSaveData_0;

		// Token: 0x04004FEF RID: 20463
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004FF0 RID: 20464
		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04004FF1 RID: 20465
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PropertyData_0;

		// Token: 0x04004FF2 RID: 20466
		private static readonly System.IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Public_Boolean_Vector3_0;

		// Token: 0x04004FF3 RID: 20467
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPointInsideBox_Private_Boolean_Vector3_BoxCollider_0;

		// Token: 0x04004FF4 RID: 20468
		private static readonly System.IntPtr NativeMethodInfoPtr_GetUnassignedBeds_Public_List_1_Bed_0;

		// Token: 0x04004FF5 RID: 20469
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBuildablesOfType_Public_List_1_T_0;

		// Token: 0x04004FF6 RID: 20470
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004FF7 RID: 20471
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__80_0_Private_Void_Boolean_0;

		// Token: 0x04004FF8 RID: 20472
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04004FF9 RID: 20473
		private static readonly System.IntPtr NativeMethodInfoPtr__RecieveOwned_b__93_1_Private_Boolean_0;

		// Token: 0x04004FFA RID: 20474
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004FFB RID: 20475
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004FFC RID: 20476
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004FFD RID: 20477
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwned_Server_2166136261_Private_Void_0;

		// Token: 0x04004FFE RID: 20478
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetOwned_Server_2166136261_Protected_Void_0;

		// Token: 0x04004FFF RID: 20479
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwned_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005000 RID: 20480
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveOwned_Networked_2166136261_Private_Void_0;

		// Token: 0x04005001 RID: 20481
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveOwned_Networked_2166136261_Private_Void_0;

		// Token: 0x04005002 RID: 20482
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveOwned_Networked_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005003 RID: 20483
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendToggleableState_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x04005004 RID: 20484
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendToggleableState_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x04005005 RID: 20485
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendToggleableState_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005006 RID: 20486
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04005007 RID: 20487
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetToggleableState_338960014_Public_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x04005008 RID: 20488
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005009 RID: 20489
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetToggleableState_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400500A RID: 20490
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetToggleableState_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400500B RID: 20491
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000AD2 RID: 2770
		public sealed class PropertyChange : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600D740 RID: 55104 RVA: 0x0033A344 File Offset: 0x00338544
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyChange()
			{
				Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "PropertyChange");
				Property.PropertyChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100678098);
				Property.PropertyChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100678099);
				Property.PropertyChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100678100);
				Property.PropertyChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr, 100678101);
			}

			// Token: 0x0600D741 RID: 55105 RVA: 0x0033A3B8 File Offset: 0x003385B8
			[CallerCount(500)]
			[CachedScanResults(RefRangeStart = 85002, RefRangeEnd = 85502, XrefRangeStart = 85002, XrefRangeEnd = 85502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyChange(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.PropertyChange>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D742 RID: 55106 RVA: 0x0033A414 File Offset: 0x00338614
			[CallerCount(0)]
			public unsafe void Invoke(Property property)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D743 RID: 55107 RVA: 0x0033A458 File Offset: 0x00338658
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Property property, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600D744 RID: 55108 RVA: 0x0033A4CC File Offset: 0x003386CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.PropertyChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D745 RID: 55109 RVA: 0x000687F9 File Offset: 0x000669F9
			public PropertyChange(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D746 RID: 55110 RVA: 0x00068802 File Offset: 0x00066A02
			public static implicit operator Property.PropertyChange(System.Action<Property> A_0)
			{
				return DelegateSupport.ConvertDelegate<Property.PropertyChange>(A_0);
			}

			// Token: 0x0600D747 RID: 55111 RVA: 0x0006880A File Offset: 0x00066A0A
			public static Property.PropertyChange operator +(Property.PropertyChange A_0, Property.PropertyChange A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Property.PropertyChange>();
			}

			// Token: 0x0600D748 RID: 55112 RVA: 0x00068818 File Offset: 0x00066A18
			public static Property.PropertyChange operator -(Property.PropertyChange A_0, Property.PropertyChange A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Property.PropertyChange>();
				}
				return result;
			}

			// Token: 0x0400913D RID: 37181
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400913E RID: 37182
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0;

			// Token: 0x0400913F RID: 37183
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0;

			// Token: 0x04009140 RID: 37184
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000AD3 RID: 2771
		[ObfuscatedName("ScheduleOne.Property.Property+<<RecieveOwned>g__Wait|93_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D749 RID: 55113 RVA: 0x0033A510 File Offset: 0x00338710
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<<RecieveOwned>g__Wait|93_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100678102);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100678103);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100678104);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100678105);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100678106);
				Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100678107);
			}

			// Token: 0x0600D74A RID: 55114 RVA: 0x0033A5F0 File Offset: 0x003387F0
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D74B RID: 55115 RVA: 0x0033A638 File Offset: 0x00338838
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D74C RID: 55116 RVA: 0x0033A66C File Offset: 0x0033886C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228486, XrefRangeEnd = 228499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004284 RID: 17028
			// (get) Token: 0x0600D74D RID: 55117 RVA: 0x0033A6A8 File Offset: 0x003388A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D74E RID: 55118 RVA: 0x0033A6E8 File Offset: 0x003388E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228499, XrefRangeEnd = 228504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004285 RID: 17029
			// (get) Token: 0x0600D74F RID: 55119 RVA: 0x0033A71C File Offset: 0x0033891C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D750 RID: 55120 RVA: 0x00068829 File Offset: 0x00066A29
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004281 RID: 17025
			// (get) Token: 0x0600D751 RID: 55121 RVA: 0x0033A75C File Offset: 0x0033895C
			// (set) Token: 0x0600D752 RID: 55122 RVA: 0x00068832 File Offset: 0x00066A32
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004282 RID: 17026
			// (get) Token: 0x0600D753 RID: 55123 RVA: 0x0033A784 File Offset: 0x00338984
			// (set) Token: 0x0600D754 RID: 55124 RVA: 0x0006884D File Offset: 0x00066A4D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004283 RID: 17027
			// (get) Token: 0x0600D755 RID: 55125 RVA: 0x0033A7B4 File Offset: 0x003389B4
			// (set) Token: 0x0600D756 RID: 55126 RVA: 0x0006886C File Offset: 0x00066A6C
			public unsafe Property __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009141 RID: 37185
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009142 RID: 37186
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009143 RID: 37187
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009144 RID: 37188
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009145 RID: 37189
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009146 RID: 37190
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009147 RID: 37191
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009148 RID: 37192
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009149 RID: 37193
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD4 RID: 2772
		[ObfuscatedName("ScheduleOne.Property.Property+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D757 RID: 55127 RVA: 0x0033A7E4 File Offset: 0x003389E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Property.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.__c>.NativeClassPtr);
				Property.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, "<>9");
				Property.__c.NativeFieldInfoPtr___9__111_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, "<>9__111_0");
				Property.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, 100678109);
				Property.__c.NativeMethodInfoPtr__GetUnassignedBeds_b__111_0_Internal_Boolean_Bed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c>.NativeClassPtr, 100678110);
			}

			// Token: 0x0600D758 RID: 55128 RVA: 0x0033A860 File Offset: 0x00338A60
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D759 RID: 55129 RVA: 0x0033A89C File Offset: 0x00338A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228504, XrefRangeEnd = 228510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnassignedBeds_b__111_0(Bed x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Property.__c.NativeMethodInfoPtr__GetUnassignedBeds_b__111_0_Internal_Boolean_Bed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D75A RID: 55130 RVA: 0x0006888B File Offset: 0x00066A8B
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004286 RID: 17030
			// (get) Token: 0x0600D75B RID: 55131 RVA: 0x0033A8EC File Offset: 0x00338AEC
			// (set) Token: 0x0600D75C RID: 55132 RVA: 0x00068894 File Offset: 0x00066A94
			public unsafe static Property.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Property.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Property.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004287 RID: 17031
			// (get) Token: 0x0600D75D RID: 55133 RVA: 0x0033A914 File Offset: 0x00338B14
			// (set) Token: 0x0600D75E RID: 55134 RVA: 0x000688A6 File Offset: 0x00066AA6
			public unsafe static Il2CppSystem.Func<Bed, bool> __9__111_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Property.__c.NativeFieldInfoPtr___9__111_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Bed, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Property.__c.NativeFieldInfoPtr___9__111_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400914A RID: 37194
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400914B RID: 37195
			private static readonly System.IntPtr NativeFieldInfoPtr___9__111_0;

			// Token: 0x0400914C RID: 37196
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400914D RID: 37197
			private static readonly System.IntPtr NativeMethodInfoPtr__GetUnassignedBeds_b__111_0_Internal_Boolean_Bed_0;
		}

		// Token: 0x02000AD5 RID: 2773
		[ObfuscatedName("ScheduleOne.Property.Property+<>c__DisplayClass80_0")]
		public sealed class __c__DisplayClass80_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D75F RID: 55135 RVA: 0x0033A93C File Offset: 0x00338B3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass80_0()
			{
				Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Property>.NativeClassPtr, "<>c__DisplayClass80_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr);
				Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, "toggleable1");
				Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, "<>4__this");
				Property.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, 100678111);
				Property.__c__DisplayClass80_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr, 100678112);
			}

			// Token: 0x0600D760 RID: 55136 RVA: 0x0033A9B8 File Offset: 0x00338BB8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass80_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property.__c__DisplayClass80_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c__DisplayClass80_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D761 RID: 55137 RVA: 0x0033A9F4 File Offset: 0x00338BF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228510, XrefRangeEnd = 228525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.__c__DisplayClass80_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D762 RID: 55138 RVA: 0x000688B8 File Offset: 0x00066AB8
			public __c__DisplayClass80_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004288 RID: 17032
			// (get) Token: 0x0600D763 RID: 55139 RVA: 0x0033AA28 File Offset: 0x00338C28
			// (set) Token: 0x0600D764 RID: 55140 RVA: 0x000688C1 File Offset: 0x00066AC1
			public unsafe InteractableToggleable toggleable1
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableToggleable>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr_toggleable1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004289 RID: 17033
			// (get) Token: 0x0600D765 RID: 55141 RVA: 0x0033AA58 File Offset: 0x00338C58
			// (set) Token: 0x0600D766 RID: 55142 RVA: 0x000688E0 File Offset: 0x00066AE0
			public unsafe Property __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Property.__c__DisplayClass80_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400914E RID: 37198
			private static readonly System.IntPtr NativeFieldInfoPtr_toggleable1;

			// Token: 0x0400914F RID: 37199
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009150 RID: 37200
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009151 RID: 37201
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;
		}

		// Token: 0x02000AD6 RID: 2774
		private sealed class MethodInfoStoreGeneric_GetBuildablesOfType_Public_List_1_T_0<T>
		{
			// Token: 0x04009152 RID: 37202
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Property.NativeMethodInfoPtr_GetBuildablesOfType_Public_List_1_T_0, Il2CppClassPointerStore<Property>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
