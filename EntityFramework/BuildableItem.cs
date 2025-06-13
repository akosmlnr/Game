using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x0200041D RID: 1053
	public class BuildableItem : NetworkBehaviour
	{
		// Token: 0x06005683 RID: 22147 RVA: 0x00196358 File Offset: 0x00194558
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItem()
		{
			Il2CppClassPointerStore<BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr);
			BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<ItemInstance>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<ParentProperty>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<IsDestroyed>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<Initialized>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<GUID>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<IsCulled>k__BackingField");
			BuildableItem.NativeFieldInfoPtr_isGhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "isGhost");
			BuildableItem.NativeFieldInfoPtr_buildHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "buildHandler");
			BuildableItem.NativeFieldInfoPtr_HoldDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "HoldDistance");
			BuildableItem.NativeFieldInfoPtr_BuildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "BuildPoint");
			BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "MidAirCenterPoint");
			BuildableItem.NativeFieldInfoPtr_BoundingCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "BoundingCollider");
			BuildableItem.NativeFieldInfoPtr_OutlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "OutlineRenderers");
			BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "IncludeOutlineRendererChildren");
			BuildableItem.NativeFieldInfoPtr_OutlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "OutlineEffect");
			BuildableItem.NativeFieldInfoPtr_GameObjectsToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "GameObjectsToCull");
			BuildableItem.NativeFieldInfoPtr_MeshesToCull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "MeshesToCull");
			BuildableItem.NativeFieldInfoPtr_onGhostModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onGhostModel");
			BuildableItem.NativeFieldInfoPtr_onInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onInitialized");
			BuildableItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onDestroyed");
			BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "onDestroyedWithParameter");
			BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocallyBuilt>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted");
			BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.BuildableItemAssembly-CSharp.dll_Excuted");
			BuildableItem.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674130);
			BuildableItem.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674131);
			BuildableItem.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674132);
			BuildableItem.NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674133);
			BuildableItem.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674134);
			BuildableItem.NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674135);
			BuildableItem.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674136);
			BuildableItem.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674137);
			BuildableItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674138);
			BuildableItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674139);
			BuildableItem.NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674140);
			BuildableItem.NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674141);
			BuildableItem.NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674142);
			BuildableItem.NativeMethodInfoPtr_AddChildMeshes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674143);
			BuildableItem.NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674144);
			BuildableItem.NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674145);
			BuildableItem.NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674146);
			BuildableItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674147);
			BuildableItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674148);
			BuildableItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674149);
			BuildableItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674150);
			BuildableItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674151);
			BuildableItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674152);
			BuildableItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674153);
			BuildableItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674154);
			BuildableItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674155);
			BuildableItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674156);
			BuildableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674157);
			BuildableItem.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674158);
			BuildableItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674159);
			BuildableItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674160);
			BuildableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674161);
			BuildableItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674162);
			BuildableItem.NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674163);
			BuildableItem.NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674164);
			BuildableItem.NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674165);
			BuildableItem.NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674166);
			BuildableItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674167);
			BuildableItem.NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674168);
			BuildableItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674169);
			BuildableItem.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674170);
			BuildableItem.NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674171);
			BuildableItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674172);
			BuildableItem.NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674173);
			BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674174);
			BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674175);
			BuildableItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674176);
			BuildableItem.NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674177);
			BuildableItem.NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674178);
			BuildableItem.NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674179);
			BuildableItem.NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674180);
			BuildableItem.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674181);
			BuildableItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_New_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674182);
			BuildableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674183);
			BuildableItem.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674184);
			BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674185);
			BuildableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674186);
			BuildableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674187);
			BuildableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674188);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674189);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674190);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674191);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674192);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674193);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674194);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674195);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674196);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674197);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674198);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674199);
			BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674200);
			BuildableItem.NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674201);
			BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674202);
			BuildableItem.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, 100674203);
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x00196B6C File Offset: 0x00194D6C
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x00196BAC File Offset: 0x00194DAC
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184639, XrefRangeEnd = 184640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06005686 RID: 22150 RVA: 0x00196BF0 File Offset: 0x00194DF0
		// (set) Token: 0x06005687 RID: 22151 RVA: 0x00196C30 File Offset: 0x00194E30
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x00196C74 File Offset: 0x00194E74
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x00196CB0 File Offset: 0x00194EB0
		public unsafe virtual bool IsDestroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x00196CF0 File Offset: 0x00194EF0
		// (set) Token: 0x0600568B RID: 22155 RVA: 0x00196D2C File Offset: 0x00194F2C
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x00196D6C File Offset: 0x00194F6C
		// (set) Token: 0x0600568D RID: 22157 RVA: 0x00196DA8 File Offset: 0x00194FA8
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x0600568E RID: 22158 RVA: 0x00196DE8 File Offset: 0x00194FE8
		// (set) Token: 0x0600568F RID: 22159 RVA: 0x00196E24 File Offset: 0x00195024
		public unsafe bool IsCulled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06005690 RID: 22160 RVA: 0x00196E64 File Offset: 0x00195064
		public unsafe GameObject BuildHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x00196EA4 File Offset: 0x001950A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184640, XrefRangeEnd = 184669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChildMeshes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_AddChildMeshes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06005692 RID: 22162 RVA: 0x00196ED8 File Offset: 0x001950D8
		// (set) Token: 0x06005693 RID: 22163 RVA: 0x00196F14 File Offset: 0x00195114
		public unsafe bool LocallyBuilt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x00196F54 File Offset: 0x00195154
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184669, RefRangeEnd = 184672, XrefRangeStart = 184669, XrefRangeEnd = 184669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocallyBuilt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06005695 RID: 22165 RVA: 0x00196F88 File Offset: 0x00195188
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184672, XrefRangeEnd = 184677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x00196FC0 File Offset: 0x001951C0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184677, XrefRangeEnd = 184679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06005697 RID: 22167 RVA: 0x00196FF8 File Offset: 0x001951F8
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x00197038 File Offset: 0x00195238
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x00197074 File Offset: 0x00195274
		// (set) Token: 0x0600569A RID: 22170 RVA: 0x001970B4 File Offset: 0x001952B4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184679, XrefRangeEnd = 184680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x0600569B RID: 22171 RVA: 0x001970F8 File Offset: 0x001952F8
		// (set) Token: 0x0600569C RID: 22172 RVA: 0x00197138 File Offset: 0x00195338
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x0600569D RID: 22173 RVA: 0x0019717C File Offset: 0x0019537C
		// (set) Token: 0x0600569E RID: 22174 RVA: 0x001971B8 File Offset: 0x001953B8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x001971F8 File Offset: 0x001953F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00197234 File Offset: 0x00195434
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 184701, RefRangeEnd = 184708, XrefRangeStart = 184686, XrefRangeEnd = 184701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00197270 File Offset: 0x00195470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184722, RefRangeEnd = 184723, XrefRangeStart = 184708, XrefRangeEnd = 184722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x001972CC File Offset: 0x001954CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184723, XrefRangeEnd = 184729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00197308 File Offset: 0x00195508
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 184731, RefRangeEnd = 184744, XrefRangeStart = 184729, XrefRangeEnd = 184731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00197358 File Offset: 0x00195558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184744, XrefRangeEnd = 184752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x001973A8 File Offset: 0x001955A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184752, XrefRangeEnd = 184764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBuildableItemData(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00197410 File Offset: 0x00195610
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184799, RefRangeEnd = 184802, XrefRangeStart = 184764, XrefRangeEnd = 184799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveBuildableItemData(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x0019748C File Offset: 0x0019568C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184883, RefRangeEnd = 184886, XrefRangeStart = 184802, XrefRangeEnd = 184883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeBuildableItem(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x00197500 File Offset: 0x00195700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184895, RefRangeEnd = 184897, XrefRangeStart = 184886, XrefRangeEnd = 184895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBePickedUp(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00197558 File Offset: 0x00195758
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 184900, RefRangeEnd = 184913, XrefRangeStart = 184897, XrefRangeEnd = 184900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x001975BC File Offset: 0x001957BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184913, XrefRangeEnd = 184923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PickupItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x001975F8 File Offset: 0x001957F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184952, RefRangeEnd = 184954, XrefRangeStart = 184923, XrefRangeEnd = 184952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref callOnServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00197644 File Offset: 0x00195844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184954, XrefRangeEnd = 184963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00197678 File Offset: 0x00195878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184963, XrefRangeEnd = 184972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyItemWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x001976AC File Offset: 0x001958AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184972, XrefRangeEnd = 184976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x001976EC File Offset: 0x001958EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 184976, RefRangeEnd = 184981, XrefRangeStart = 184976, XrefRangeEnd = 184976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color32 GetColorFromOutlineColorEnum(BuildableItem.EOutlineColor col)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x0019772C File Offset: 0x0019592C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185038, RefRangeEnd = 185039, XrefRangeStart = 184981, XrefRangeEnd = 185038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowOutline(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00197778 File Offset: 0x00195978
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185042, RefRangeEnd = 185046, XrefRangeStart = 185039, XrefRangeEnd = 185042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x001977B8 File Offset: 0x001959B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185055, RefRangeEnd = 185056, XrefRangeStart = 185046, XrefRangeEnd = 185055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x001977F4 File Offset: 0x001959F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185056, XrefRangeEnd = 185135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFurthestPointFromBoundingCollider(Vector3 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00197840 File Offset: 0x00195A40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 185327, RefRangeEnd = 185333, XrefRangeStart = 185135, XrefRangeEnd = 185327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetPenetration(out float x, out float z, out float y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &z;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &y;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x001978A8 File Offset: 0x00195AA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 185362, RefRangeEnd = 185368, XrefRangeStart = 185333, XrefRangeEnd = 185362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasLoS_IgnoreBuildables(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref point;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x001978F4 File Offset: 0x00195AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185368, XrefRangeEnd = 185392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCulled(bool culled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref culled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00197940 File Offset: 0x00195B40
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 185396, RefRangeEnd = 185404, XrefRangeStart = 185392, XrefRangeEnd = 185396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr2) : null;
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x0019798C File Offset: 0x00195B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185404, XrefRangeEnd = 185408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_New_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x001979D8 File Offset: 0x00195BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185408, XrefRangeEnd = 185409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x00197A10 File Offset: 0x00195C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185409, XrefRangeEnd = 185415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x00197A6C File Offset: 0x00195C6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185435, RefRangeEnd = 185438, XrefRangeStart = 185415, XrefRangeEnd = 185435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00197AA8 File Offset: 0x00195CA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185470, RefRangeEnd = 185473, XrefRangeStart = 185438, XrefRangeEnd = 185470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00197AE4 File Offset: 0x00195CE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185473, RefRangeEnd = 185476, XrefRangeStart = 185473, XrefRangeEnd = 185473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00197B20 File Offset: 0x00195D20
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00197B5C File Offset: 0x00195D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00197BC4 File Offset: 0x00195DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185476, XrefRangeEnd = 185477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBuildableItemData_3537728543(ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x00197C2C File Offset: 0x00195E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185477, XrefRangeEnd = 185482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBuildableItemData_3537728543(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x00197C90 File Offset: 0x00195E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185482, XrefRangeEnd = 185494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x00197D0C File Offset: 0x00195F0C
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x00197D88 File Offset: 0x00195F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185494, XrefRangeEnd = 185498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00197DD8 File Offset: 0x00195FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185498, XrefRangeEnd = 185510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveBuildableItemData_3859851844(NetworkConnection conn, ItemInstance instance, string GUID, string parentPropertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(parentPropertyCode);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00197E54 File Offset: 0x00196054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185510, XrefRangeEnd = 185515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveBuildableItemData_3859851844(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00197EA4 File Offset: 0x001960A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00197ED8 File Offset: 0x001960D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185515, XrefRangeEnd = 185538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00197F0C File Offset: 0x0019610C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185538, XrefRangeEnd = 185562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00197F70 File Offset: 0x00196170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyItemWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00197FA4 File Offset: 0x001961A4
		[CallerCount(0)]
		public unsafe void RpcLogic___DestroyItemWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00197FD8 File Offset: 0x001961D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185562, XrefRangeEnd = 185563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyItemWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00198028 File Offset: 0x00196228
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildableItem.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x0002953C File Offset: 0x0002773C
		public BuildableItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x060056CF RID: 22223 RVA: 0x00198064 File Offset: 0x00196264
		// (set) Token: 0x060056D0 RID: 22224 RVA: 0x00029545 File Offset: 0x00027745
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x060056D1 RID: 22225 RVA: 0x00198094 File Offset: 0x00196294
		// (set) Token: 0x060056D2 RID: 22226 RVA: 0x00029564 File Offset: 0x00027764
		public unsafe Property _ParentProperty_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__ParentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x060056D3 RID: 22227 RVA: 0x001980C4 File Offset: 0x001962C4
		// (set) Token: 0x060056D4 RID: 22228 RVA: 0x00029583 File Offset: 0x00027783
		public unsafe bool _IsDestroyed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsDestroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x001980EC File Offset: 0x001962EC
		// (set) Token: 0x060056D6 RID: 22230 RVA: 0x0002959E File Offset: 0x0002779E
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x060056D7 RID: 22231 RVA: 0x00198114 File Offset: 0x00196314
		// (set) Token: 0x060056D8 RID: 22232 RVA: 0x000295B9 File Offset: 0x000277B9
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x060056D9 RID: 22233 RVA: 0x0019813C File Offset: 0x0019633C
		// (set) Token: 0x060056DA RID: 22234 RVA: 0x000295D4 File Offset: 0x000277D4
		public unsafe bool _IsCulled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__IsCulled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x060056DB RID: 22235 RVA: 0x00198164 File Offset: 0x00196364
		// (set) Token: 0x060056DC RID: 22236 RVA: 0x000295EF File Offset: 0x000277EF
		public unsafe bool isGhost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_isGhost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_isGhost)) = value;
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x060056DD RID: 22237 RVA: 0x0019818C File Offset: 0x0019638C
		// (set) Token: 0x060056DE RID: 22238 RVA: 0x0002960A File Offset: 0x0002780A
		public unsafe GameObject buildHandler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_buildHandler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_buildHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x060056DF RID: 22239 RVA: 0x001981BC File Offset: 0x001963BC
		// (set) Token: 0x060056E0 RID: 22240 RVA: 0x00029629 File Offset: 0x00027829
		public unsafe float HoldDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_HoldDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_HoldDistance)) = value;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x060056E1 RID: 22241 RVA: 0x001981E4 File Offset: 0x001963E4
		// (set) Token: 0x060056E2 RID: 22242 RVA: 0x00029644 File Offset: 0x00027844
		public unsafe Transform BuildPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BuildPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BuildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x060056E3 RID: 22243 RVA: 0x00198214 File Offset: 0x00196414
		// (set) Token: 0x060056E4 RID: 22244 RVA: 0x00029663 File Offset: 0x00027863
		public unsafe Transform MidAirCenterPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MidAirCenterPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060056E5 RID: 22245 RVA: 0x00198244 File Offset: 0x00196444
		// (set) Token: 0x060056E6 RID: 22246 RVA: 0x00029682 File Offset: 0x00027882
		public unsafe BoxCollider BoundingCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BoundingCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_BoundingCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060056E7 RID: 22247 RVA: 0x00198274 File Offset: 0x00196474
		// (set) Token: 0x060056E8 RID: 22248 RVA: 0x000296A1 File Offset: 0x000278A1
		public unsafe List<GameObject> OutlineRenderers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineRenderers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060056E9 RID: 22249 RVA: 0x001982A4 File Offset: 0x001964A4
		// (set) Token: 0x060056EA RID: 22250 RVA: 0x000296C0 File Offset: 0x000278C0
		public unsafe bool IncludeOutlineRendererChildren
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_IncludeOutlineRendererChildren)) = value;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x001982CC File Offset: 0x001964CC
		// (set) Token: 0x060056EC RID: 22252 RVA: 0x000296DB File Offset: 0x000278DB
		public unsafe Outlinable OutlineEffect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineEffect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_OutlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060056ED RID: 22253 RVA: 0x001982FC File Offset: 0x001964FC
		// (set) Token: 0x060056EE RID: 22254 RVA: 0x000296FA File Offset: 0x000278FA
		public unsafe Il2CppReferenceArray<GameObject> GameObjectsToCull
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_GameObjectsToCull);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_GameObjectsToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060056EF RID: 22255 RVA: 0x0019832C File Offset: 0x0019652C
		// (set) Token: 0x060056F0 RID: 22256 RVA: 0x00029719 File Offset: 0x00027919
		public unsafe List<MeshRenderer> MeshesToCull
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MeshesToCull);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_MeshesToCull), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060056F1 RID: 22257 RVA: 0x0019835C File Offset: 0x0019655C
		// (set) Token: 0x060056F2 RID: 22258 RVA: 0x00029738 File Offset: 0x00027938
		public unsafe UnityEvent onGhostModel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onGhostModel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onGhostModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060056F3 RID: 22259 RVA: 0x0019838C File Offset: 0x0019658C
		// (set) Token: 0x060056F4 RID: 22260 RVA: 0x00029757 File Offset: 0x00027957
		public unsafe UnityEvent onInitialized
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onInitialized);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060056F5 RID: 22261 RVA: 0x001983BC File Offset: 0x001965BC
		// (set) Token: 0x060056F6 RID: 22262 RVA: 0x00029776 File Offset: 0x00027976
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060056F7 RID: 22263 RVA: 0x001983EC File Offset: 0x001965EC
		// (set) Token: 0x060056F8 RID: 22264 RVA: 0x00029795 File Offset: 0x00027995
		public unsafe Il2CppSystem.Action<BuildableItem> onDestroyedWithParameter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_onDestroyedWithParameter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060056F9 RID: 22265 RVA: 0x0019841C File Offset: 0x0019661C
		// (set) Token: 0x060056FA RID: 22266 RVA: 0x000297B4 File Offset: 0x000279B4
		public unsafe bool _LocallyBuilt_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocallyBuilt_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x00198444 File Offset: 0x00196644
		// (set) Token: 0x060056FC RID: 22268 RVA: 0x000297CF File Offset: 0x000279CF
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060056FD RID: 22269 RVA: 0x00198474 File Offset: 0x00196674
		// (set) Token: 0x060056FE RID: 22270 RVA: 0x000297EE File Offset: 0x000279EE
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060056FF RID: 22271 RVA: 0x001984A4 File Offset: 0x001966A4
		// (set) Token: 0x06005700 RID: 22272 RVA: 0x0002980D File Offset: 0x00027A0D
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06005701 RID: 22273 RVA: 0x001984CC File Offset: 0x001966CC
		// (set) Token: 0x06005702 RID: 22274 RVA: 0x00029828 File Offset: 0x00027A28
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x001984F4 File Offset: 0x001966F4
		// (set) Token: 0x06005704 RID: 22276 RVA: 0x00029843 File Offset: 0x00027A43
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A86 RID: 14982
		private static readonly System.IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x04003A87 RID: 14983
		private static readonly System.IntPtr NativeFieldInfoPtr__ParentProperty_k__BackingField;

		// Token: 0x04003A88 RID: 14984
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDestroyed_k__BackingField;

		// Token: 0x04003A89 RID: 14985
		private static readonly System.IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04003A8A RID: 14986
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003A8B RID: 14987
		private static readonly System.IntPtr NativeFieldInfoPtr__IsCulled_k__BackingField;

		// Token: 0x04003A8C RID: 14988
		private static readonly System.IntPtr NativeFieldInfoPtr_isGhost;

		// Token: 0x04003A8D RID: 14989
		private static readonly System.IntPtr NativeFieldInfoPtr_buildHandler;

		// Token: 0x04003A8E RID: 14990
		private static readonly System.IntPtr NativeFieldInfoPtr_HoldDistance;

		// Token: 0x04003A8F RID: 14991
		private static readonly System.IntPtr NativeFieldInfoPtr_BuildPoint;

		// Token: 0x04003A90 RID: 14992
		private static readonly System.IntPtr NativeFieldInfoPtr_MidAirCenterPoint;

		// Token: 0x04003A91 RID: 14993
		private static readonly System.IntPtr NativeFieldInfoPtr_BoundingCollider;

		// Token: 0x04003A92 RID: 14994
		private static readonly System.IntPtr NativeFieldInfoPtr_OutlineRenderers;

		// Token: 0x04003A93 RID: 14995
		private static readonly System.IntPtr NativeFieldInfoPtr_IncludeOutlineRendererChildren;

		// Token: 0x04003A94 RID: 14996
		private static readonly System.IntPtr NativeFieldInfoPtr_OutlineEffect;

		// Token: 0x04003A95 RID: 14997
		private static readonly System.IntPtr NativeFieldInfoPtr_GameObjectsToCull;

		// Token: 0x04003A96 RID: 14998
		private static readonly System.IntPtr NativeFieldInfoPtr_MeshesToCull;

		// Token: 0x04003A97 RID: 14999
		private static readonly System.IntPtr NativeFieldInfoPtr_onGhostModel;

		// Token: 0x04003A98 RID: 15000
		private static readonly System.IntPtr NativeFieldInfoPtr_onInitialized;

		// Token: 0x04003A99 RID: 15001
		private static readonly System.IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x04003A9A RID: 15002
		private static readonly System.IntPtr NativeFieldInfoPtr_onDestroyedWithParameter;

		// Token: 0x04003A9B RID: 15003
		private static readonly System.IntPtr NativeFieldInfoPtr__LocallyBuilt_k__BackingField;

		// Token: 0x04003A9C RID: 15004
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003A9D RID: 15005
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003A9E RID: 15006
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003A9F RID: 15007
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003AA0 RID: 15008
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003AA1 RID: 15009
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x04003AA2 RID: 15010
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x04003AA3 RID: 15011
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x04003AA4 RID: 15012
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentProperty_Protected_set_Void_Property_0;

		// Token: 0x04003AA5 RID: 15013
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003AA6 RID: 15014
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDestroyed_Protected_set_Void_Boolean_0;

		// Token: 0x04003AA7 RID: 15015
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04003AA8 RID: 15016
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x04003AA9 RID: 15017
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003AAA RID: 15018
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003AAB RID: 15019
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCulled_Public_get_Boolean_0;

		// Token: 0x04003AAC RID: 15020
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCulled_Protected_set_Void_Boolean_0;

		// Token: 0x04003AAD RID: 15021
		private static readonly System.IntPtr NativeMethodInfoPtr_get_BuildHandler_Public_get_GameObject_0;

		// Token: 0x04003AAE RID: 15022
		private static readonly System.IntPtr NativeMethodInfoPtr_AddChildMeshes_Public_Void_0;

		// Token: 0x04003AAF RID: 15023
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocallyBuilt_Public_get_Boolean_0;

		// Token: 0x04003AB0 RID: 15024
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocallyBuilt_Protected_set_Void_Boolean_0;

		// Token: 0x04003AB1 RID: 15025
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLocallyBuilt_Public_Void_0;

		// Token: 0x04003AB2 RID: 15026
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003AB3 RID: 15027
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003AB4 RID: 15028
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003AB5 RID: 15029
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003AB6 RID: 15030
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003AB7 RID: 15031
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003AB8 RID: 15032
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003AB9 RID: 15033
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003ABA RID: 15034
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003ABB RID: 15035
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003ABC RID: 15036
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003ABD RID: 15037
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04003ABE RID: 15038
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_New_Property_Transform_0;

		// Token: 0x04003ABF RID: 15039
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003AC0 RID: 15040
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003AC1 RID: 15041
		private static readonly System.IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04003AC2 RID: 15042
		private static readonly System.IntPtr NativeMethodInfoPtr_SendBuildableItemData_Public_Void_ItemInstance_String_String_0;

		// Token: 0x04003AC3 RID: 15043
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveBuildableItemData_Public_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x04003AC4 RID: 15044
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeBuildableItem_Public_Virtual_New_Void_ItemInstance_String_String_0;

		// Token: 0x04003AC5 RID: 15045
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBePickedUp_Public_Boolean_byref_String_0;

		// Token: 0x04003AC6 RID: 15046
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003AC7 RID: 15047
		private static readonly System.IntPtr NativeMethodInfoPtr_PickupItem_Public_Virtual_New_Void_0;

		// Token: 0x04003AC8 RID: 15048
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003AC9 RID: 15049
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Networked_Private_Void_0;

		// Token: 0x04003ACA RID: 15050
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyItemWrapper_Private_Void_0;

		// Token: 0x04003ACB RID: 15051
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003ACC RID: 15052
		private static readonly System.IntPtr NativeMethodInfoPtr_GetColorFromOutlineColorEnum_Public_Static_Color32_EOutlineColor_0;

		// Token: 0x04003ACD RID: 15053
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOutline_Public_Virtual_New_Void_Color_0;

		// Token: 0x04003ACE RID: 15054
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x04003ACF RID: 15055
		private static readonly System.IntPtr NativeMethodInfoPtr_HideOutline_Public_Virtual_New_Void_0;

		// Token: 0x04003AD0 RID: 15056
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFurthestPointFromBoundingCollider_Public_Vector3_Vector3_0;

		// Token: 0x04003AD1 RID: 15057
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPenetration_Public_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x04003AD2 RID: 15058
		private static readonly System.IntPtr NativeMethodInfoPtr_HasLoS_IgnoreBuildables_Private_Boolean_Vector3_0;

		// Token: 0x04003AD3 RID: 15059
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCulled_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003AD4 RID: 15060
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_DynamicSaveData_0;

		// Token: 0x04003AD5 RID: 15061
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_New_BuildableItemData_0;

		// Token: 0x04003AD6 RID: 15062
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04003AD7 RID: 15063
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04003AD8 RID: 15064
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003AD9 RID: 15065
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003ADA RID: 15066
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003ADB RID: 15067
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003ADC RID: 15068
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBuildableItemData_3537728543_Private_Void_ItemInstance_String_String_0;

		// Token: 0x04003ADD RID: 15069
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendBuildableItemData_3537728543_Public_Void_ItemInstance_String_String_0;

		// Token: 0x04003ADE RID: 15070
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBuildableItemData_3537728543_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003ADF RID: 15071
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x04003AE0 RID: 15072
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveBuildableItemData_3859851844_Public_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x04003AE1 RID: 15073
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AE2 RID: 15074
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveBuildableItemData_3859851844_Private_Void_NetworkConnection_ItemInstance_String_String_0;

		// Token: 0x04003AE3 RID: 15075
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveBuildableItemData_3859851844_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AE4 RID: 15076
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x04003AE5 RID: 15077
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x04003AE6 RID: 15078
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003AE7 RID: 15079
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyItemWrapper_2166136261_Private_Void_0;

		// Token: 0x04003AE8 RID: 15080
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___DestroyItemWrapper_2166136261_Private_Void_0;

		// Token: 0x04003AE9 RID: 15081
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyItemWrapper_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AEA RID: 15082
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A05 RID: 2565
		[OriginalName("Assembly-CSharp.dll", "", "EOutlineColor")]
		public enum EOutlineColor
		{
			// Token: 0x04008D71 RID: 36209
			White,
			// Token: 0x04008D72 RID: 36210
			Blue,
			// Token: 0x04008D73 RID: 36211
			LightBlue
		}

		// Token: 0x02000A06 RID: 2566
		[ObfuscatedName("ScheduleOne.EntityFramework.BuildableItem+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D12A RID: 53546 RVA: 0x00329500 File Offset: 0x00327700
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildableItem>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr);
				BuildableItem.__c__DisplayClass76_0.NativeFieldInfoPtr_parentPropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr, "parentPropertyCode");
				BuildableItem.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr, 100674204);
				BuildableItem.__c__DisplayClass76_0.NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr, 100674205);
				BuildableItem.__c__DisplayClass76_0.NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr, 100674206);
			}

			// Token: 0x0600D12B RID: 53547 RVA: 0x0032957C File Offset: 0x0032777C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItem.__c__DisplayClass76_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D12C RID: 53548 RVA: 0x003295B8 File Offset: 0x003277B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184637, XrefRangeEnd = 184639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeBuildableItem_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass76_0.NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D12D RID: 53549 RVA: 0x00329608 File Offset: 0x00327808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeBuildableItem_b__1(Business b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BuildableItem.__c__DisplayClass76_0.NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D12E RID: 53550 RVA: 0x000656F5 File Offset: 0x000638F5
			public __c__DisplayClass76_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040D9 RID: 16601
			// (get) Token: 0x0600D12F RID: 53551 RVA: 0x00329658 File Offset: 0x00327858
			// (set) Token: 0x0600D130 RID: 53552 RVA: 0x000656FE File Offset: 0x000638FE
			public unsafe string parentPropertyCode
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.__c__DisplayClass76_0.NativeFieldInfoPtr_parentPropertyCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItem.__c__DisplayClass76_0.NativeFieldInfoPtr_parentPropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008D74 RID: 36212
			private static readonly System.IntPtr NativeFieldInfoPtr_parentPropertyCode;

			// Token: 0x04008D75 RID: 36213
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D76 RID: 36214
			private static readonly System.IntPtr NativeMethodInfoPtr__InitializeBuildableItem_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008D77 RID: 36215
			private static readonly System.IntPtr NativeMethodInfoPtr__InitializeBuildableItem_b__1_Internal_Boolean_Business_0;
		}
	}
}
