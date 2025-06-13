using System;
using Il2CppFishNet.Component.Transforming;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000591 RID: 1425
	public class Pallet : NetworkBehaviour
	{
		// Token: 0x06007C2F RID: 31791 RVA: 0x00218C94 File Offset: 0x00216E94
		// Note: this type is marked as 'beforefieldinit'.
		static Pallet()
		{
			Il2CppClassPointerStore<Pallet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "Pallet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pallet>.NativeClassPtr);
			Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "palletsOwnedByLocalPlayer");
			Pallet.NativeFieldInfoPtr_sizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "sizeX");
			Pallet.NativeFieldInfoPtr_sizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "sizeY");
			Pallet.NativeFieldInfoPtr__storedItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "_storedItemContainer");
			Pallet.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb");
			Pallet.NativeFieldInfoPtr_storageGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "storageGrid");
			Pallet.NativeFieldInfoPtr_networkTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "networkTransform");
			Pallet.NativeFieldInfoPtr_forkliftsInContact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "forkliftsInContact");
			Pallet.NativeFieldInfoPtr_currentSlotGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "currentSlotGUID");
			Pallet.NativeFieldInfoPtr_currentSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "currentSlot");
			Pallet.NativeFieldInfoPtr_timeSinceSlotCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "timeSinceSlotCheck");
			Pallet.NativeFieldInfoPtr_timeBoundToSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "timeBoundToSlot");
			Pallet.NativeFieldInfoPtr_rb_Mass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_Mass");
			Pallet.NativeFieldInfoPtr_rb_Drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_Drag");
			Pallet.NativeFieldInfoPtr_rb_AngularDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "rb_AngularDrag");
			Pallet.NativeFieldInfoPtr__reservedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "_reservedItems");
			Pallet.NativeFieldInfoPtr_completedJobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "completedJobs");
			Pallet.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted");
			Pallet.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pallet>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Storage.PalletAssembly-CSharp.dll_Excuted");
			Pallet.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678934);
			Pallet.NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678935);
			Pallet.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678936);
			Pallet.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678937);
			Pallet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678938);
			Pallet.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678939);
			Pallet.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678940);
			Pallet.NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678941);
			Pallet.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678942);
			Pallet.NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678943);
			Pallet.NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678944);
			Pallet.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678945);
			Pallet.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678946);
			Pallet.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678947);
			Pallet.NativeMethodInfoPtr_UpdateOwnership_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678948);
			Pallet.NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678949);
			Pallet.NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678950);
			Pallet.NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678951);
			Pallet.NativeMethodInfoPtr_ExitSlot_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678952);
			Pallet.NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678953);
			Pallet.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678954);
			Pallet.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678955);
			Pallet.NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678956);
			Pallet.NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678957);
			Pallet.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678958);
			Pallet.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678959);
			Pallet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678960);
			Pallet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678962);
			Pallet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678963);
			Pallet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678964);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678965);
			Pallet.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678966);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678967);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678968);
			Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678969);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678970);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678971);
			Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678972);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678973);
			Pallet.NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678974);
			Pallet.NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678975);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678976);
			Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678977);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678978);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678979);
			Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678980);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678981);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678982);
			Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678983);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678984);
			Pallet.NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678985);
			Pallet.NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678986);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678987);
			Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678988);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678989);
			Pallet.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678990);
			Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678991);
			Pallet.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678992);
			Pallet.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678993);
			Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678994);
			Pallet.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678995);
			Pallet.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pallet>.NativeClassPtr, 100678996);
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x06007C30 RID: 31792 RVA: 0x00219318 File Offset: 0x00217518
		public unsafe bool isEmpty
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237503, XrefRangeEnd = 237504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x06007C31 RID: 31793 RVA: 0x00219354 File Offset: 0x00217554
		public unsafe bool carriedByForklift
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237504, XrefRangeEnd = 237505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06007C32 RID: 31794 RVA: 0x00219390 File Offset: 0x00217590
		public unsafe virtual Transform storedItemContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06007C33 RID: 31795 RVA: 0x002193D0 File Offset: 0x002175D0
		public unsafe virtual Dictionary<StoredItem, Employee> reservedItems
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90006, RefRangeEnd = 90007, XrefRangeStart = 90006, XrefRangeEnd = 90007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x00219410 File Offset: 0x00217610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237505, XrefRangeEnd = 237509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x0021944C File Offset: 0x0021764C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237509, XrefRangeEnd = 237516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x00219488 File Offset: 0x00217688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237516, XrefRangeEnd = 237526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetOwner(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x002194D8 File Offset: 0x002176D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237526, XrefRangeEnd = 237550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnOwnershipClient(NetworkConnection prevOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevOwner);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C38 RID: 31800 RVA: 0x00219528 File Offset: 0x00217728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237550, XrefRangeEnd = 237557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x00219578 File Offset: 0x00217778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237575, RefRangeEnd = 237576, XrefRangeStart = 237557, XrefRangeEnd = 237575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendItemsToClient(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x002195BC File Offset: 0x002177BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237576, XrefRangeEnd = 237577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyPallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x002195F8 File Offset: 0x002177F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237577, XrefRangeEnd = 237583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x00219634 File Offset: 0x00217834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237583, XrefRangeEnd = 237677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x00219670 File Offset: 0x00217870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237677, XrefRangeEnd = 237679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x002196B0 File Offset: 0x002178B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237696, RefRangeEnd = 237697, XrefRangeStart = 237679, XrefRangeEnd = 237696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOwnership()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_UpdateOwnership_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x002196E4 File Offset: 0x002178E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237719, RefRangeEnd = 237721, XrefRangeStart = 237697, XrefRangeEnd = 237719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindToSlot_Server(Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x00219724 File Offset: 0x00217924
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237754, RefRangeEnd = 237758, XrefRangeStart = 237721, XrefRangeEnd = 237754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BindToSlot(NetworkConnection conn, Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C41 RID: 31809 RVA: 0x00219774 File Offset: 0x00217974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237758, XrefRangeEnd = 237779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlot_Server()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x002197A8 File Offset: 0x002179A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237788, RefRangeEnd = 237791, XrefRangeStart = 237779, XrefRangeEnd = 237788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_ExitSlot_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x002197DC File Offset: 0x002179DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237820, RefRangeEnd = 237821, XrefRangeStart = 237791, XrefRangeEnd = 237820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C44 RID: 31812 RVA: 0x00219820 File Offset: 0x00217A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237821, XrefRangeEnd = 237830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StoredItem> GetStoredItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr2) : null;
		}

		// Token: 0x06007C45 RID: 31813 RVA: 0x00219860 File Offset: 0x00217A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 237839, RefRangeEnd = 237841, XrefRangeStart = 237830, XrefRangeEnd = 237839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<StorageGrid> GetStorageGrids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageGrid>>(intPtr2) : null;
		}

		// Token: 0x06007C46 RID: 31814 RVA: 0x002198A0 File Offset: 0x00217AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237841, XrefRangeEnd = 237842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x00219940 File Offset: 0x00217B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237842, XrefRangeEnd = 237858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateStoredItem_Server(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x002199C0 File Offset: 0x00217BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237858, XrefRangeEnd = 237884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x00219A30 File Offset: 0x00217C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237884, XrefRangeEnd = 237897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem_Server(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C4A RID: 31818 RVA: 0x00219A94 File Offset: 0x00217C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237897, XrefRangeEnd = 237919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pallet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pallet>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C4B RID: 31819 RVA: 0x00219AD0 File Offset: 0x00217CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237919, XrefRangeEnd = 237987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C4C RID: 31820 RVA: 0x00219B0C File Offset: 0x00217D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237987, RefRangeEnd = 237988, XrefRangeStart = 237987, XrefRangeEnd = 237987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C4D RID: 31821 RVA: 0x00219B48 File Offset: 0x00217D48
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C4E RID: 31822 RVA: 0x00219B84 File Offset: 0x00217D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C4F RID: 31823 RVA: 0x00219BC8 File Offset: 0x00217DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238032, RefRangeEnd = 238033, XrefRangeStart = 237988, XrefRangeEnd = 238032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetOwner_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C50 RID: 31824 RVA: 0x00219C18 File Offset: 0x00217E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238033, XrefRangeEnd = 238036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetOwner_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C51 RID: 31825 RVA: 0x00219C7C File Offset: 0x00217E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238036, XrefRangeEnd = 238047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_BindToSlot_Server_1272046255(Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C52 RID: 31826 RVA: 0x00219CBC File Offset: 0x00217EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238047, XrefRangeEnd = 238048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BindToSlot_Server_1272046255(Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C53 RID: 31827 RVA: 0x00219CFC File Offset: 0x00217EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238048, XrefRangeEnd = 238052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_BindToSlot_Server_1272046255(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C54 RID: 31828 RVA: 0x00219D60 File Offset: 0x00217F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238052, XrefRangeEnd = 238063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_BindToSlot_454078614(NetworkConnection conn, Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C55 RID: 31829 RVA: 0x00219DB0 File Offset: 0x00217FB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238132, RefRangeEnd = 238134, XrefRangeStart = 238063, XrefRangeEnd = 238132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___BindToSlot_454078614(NetworkConnection conn, Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x00219E00 File Offset: 0x00218000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238134, XrefRangeEnd = 238137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x00219E50 File Offset: 0x00218050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238137, XrefRangeEnd = 238148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_BindToSlot_454078614(NetworkConnection conn, Il2CppSystem.Guid slotGuid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref slotGuid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x00219EA0 File Offset: 0x002180A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238148, XrefRangeEnd = 238152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_BindToSlot_454078614(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x00219EF0 File Offset: 0x002180F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238152, XrefRangeEnd = 238161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExitSlot_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x00219F24 File Offset: 0x00218124
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237788, RefRangeEnd = 237791, XrefRangeStart = 237788, XrefRangeEnd = 237791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitSlot_Server_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x00219F58 File Offset: 0x00218158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238161, XrefRangeEnd = 238164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExitSlot_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00219FBC File Offset: 0x002181BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237788, RefRangeEnd = 237791, XrefRangeStart = 237788, XrefRangeEnd = 237791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ExitSlot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x00219FF0 File Offset: 0x002181F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 238204, RefRangeEnd = 238205, XrefRangeStart = 238164, XrefRangeEnd = 238204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ExitSlot_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x0021A024 File Offset: 0x00218224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238205, XrefRangeEnd = 238207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ExitSlot_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C5F RID: 31839 RVA: 0x0021A074 File Offset: 0x00218274
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 238224, RefRangeEnd = 238227, XrefRangeStart = 238207, XrefRangeEnd = 238224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C60 RID: 31840 RVA: 0x0021A114 File Offset: 0x00218314
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 238266, RefRangeEnd = 238271, XrefRangeStart = 238227, XrefRangeEnd = 238266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C61 RID: 31841 RVA: 0x0021A1B4 File Offset: 0x002183B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238271, XrefRangeEnd = 238281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C62 RID: 31842 RVA: 0x0021A204 File Offset: 0x00218404
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238298, RefRangeEnd = 238300, XrefRangeStart = 238281, XrefRangeEnd = 238298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateStoredItem_913707843(NetworkConnection conn, StorableItemInstance item, int gridIndex, Vector2 originCoord, float rotation, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x0021A2A4 File Offset: 0x002184A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238300, XrefRangeEnd = 238310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateStoredItem_913707843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x0021A2F4 File Offset: 0x002184F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238310, XrefRangeEnd = 238326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x0021A374 File Offset: 0x00218574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238326, XrefRangeEnd = 238328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateStoredItem_Server_1890711751(StorableItemInstance data, int gridIndex, Vector2 originCoord, float rotation, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoord;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x0021A3F4 File Offset: 0x002185F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238328, XrefRangeEnd = 238338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateStoredItem_Server_1890711751(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x0021A458 File Offset: 0x00218658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238338, XrefRangeEnd = 238352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x0021A4C8 File Offset: 0x002186C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 238412, RefRangeEnd = 238416, XrefRangeStart = 238352, XrefRangeEnd = 238412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_3261517793(int gridIndex, Coordinate coord, string jobID = "", bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x0021A538 File Offset: 0x00218738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238416, XrefRangeEnd = 238423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyStoredItem_3261517793(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C6A RID: 31850 RVA: 0x0021A588 File Offset: 0x00218788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C6B RID: 31851 RVA: 0x0021A5EC File Offset: 0x002187EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238423, XrefRangeEnd = 238448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyStoredItem_Server_3952619116(int gridIndex, Coordinate coord, string jobID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coord);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(jobID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C6C RID: 31852 RVA: 0x0021A650 File Offset: 0x00218850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238448, XrefRangeEnd = 238478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DestroyStoredItem_Server_3952619116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pallet.NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C6D RID: 31853 RVA: 0x0021A6B4 File Offset: 0x002188B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238478, XrefRangeEnd = 238481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pallet.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007C6E RID: 31854 RVA: 0x0003ADC1 File Offset: 0x00038FC1
		public Pallet(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002564 RID: 9572
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x0021A6F0 File Offset: 0x002188F0
		// (set) Token: 0x06007C70 RID: 31856 RVA: 0x0003ADCA File Offset: 0x00038FCA
		public unsafe static List<Pallet> palletsOwnedByLocalPlayer
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pallet>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_palletsOwnedByLocalPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002565 RID: 9573
		// (get) Token: 0x06007C71 RID: 31857 RVA: 0x0021A718 File Offset: 0x00218918
		// (set) Token: 0x06007C72 RID: 31858 RVA: 0x0003ADDC File Offset: 0x00038FDC
		public unsafe static int sizeX
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_sizeX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_sizeX, (void*)(&value));
			}
		}

		// Token: 0x17002566 RID: 9574
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x0021A734 File Offset: 0x00218934
		// (set) Token: 0x06007C74 RID: 31860 RVA: 0x0003ADEA File Offset: 0x00038FEA
		public unsafe static int sizeY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Pallet.NativeFieldInfoPtr_sizeY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pallet.NativeFieldInfoPtr_sizeY, (void*)(&value));
			}
		}

		// Token: 0x17002567 RID: 9575
		// (get) Token: 0x06007C75 RID: 31861 RVA: 0x0021A750 File Offset: 0x00218950
		// (set) Token: 0x06007C76 RID: 31862 RVA: 0x0003ADF8 File Offset: 0x00038FF8
		public unsafe Transform _storedItemContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__storedItemContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__storedItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002568 RID: 9576
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x0021A780 File Offset: 0x00218980
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0003AE17 File Offset: 0x00039017
		public unsafe Rigidbody rb
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002569 RID: 9577
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x0021A7B0 File Offset: 0x002189B0
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x0003AE36 File Offset: 0x00039036
		public unsafe StorageGrid storageGrid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_storageGrid);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_storageGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256A RID: 9578
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x0021A7E0 File Offset: 0x002189E0
		// (set) Token: 0x06007C7C RID: 31868 RVA: 0x0003AE55 File Offset: 0x00039055
		public unsafe NetworkTransform networkTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_networkTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_networkTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256B RID: 9579
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x0021A810 File Offset: 0x00218A10
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x0003AE74 File Offset: 0x00039074
		public unsafe List<Forklift> forkliftsInContact
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_forkliftsInContact);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Forklift>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_forkliftsInContact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x0021A840 File Offset: 0x00218A40
		// (set) Token: 0x06007C80 RID: 31872 RVA: 0x0003AE93 File Offset: 0x00039093
		public unsafe Il2CppSystem.Guid currentSlotGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlotGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlotGUID)) = value;
			}
		}

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x06007C81 RID: 31873 RVA: 0x0021A868 File Offset: 0x00218A68
		// (set) Token: 0x06007C82 RID: 31874 RVA: 0x0003AEAE File Offset: 0x000390AE
		public unsafe PalletSlot currentSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PalletSlot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_currentSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700256E RID: 9582
		// (get) Token: 0x06007C83 RID: 31875 RVA: 0x0021A898 File Offset: 0x00218A98
		// (set) Token: 0x06007C84 RID: 31876 RVA: 0x0003AECD File Offset: 0x000390CD
		public unsafe float timeSinceSlotCheck
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeSinceSlotCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeSinceSlotCheck)) = value;
			}
		}

		// Token: 0x1700256F RID: 9583
		// (get) Token: 0x06007C85 RID: 31877 RVA: 0x0021A8C0 File Offset: 0x00218AC0
		// (set) Token: 0x06007C86 RID: 31878 RVA: 0x0003AEE8 File Offset: 0x000390E8
		public unsafe float timeBoundToSlot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeBoundToSlot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_timeBoundToSlot)) = value;
			}
		}

		// Token: 0x17002570 RID: 9584
		// (get) Token: 0x06007C87 RID: 31879 RVA: 0x0021A8E8 File Offset: 0x00218AE8
		// (set) Token: 0x06007C88 RID: 31880 RVA: 0x0003AF03 File Offset: 0x00039103
		public unsafe float rb_Mass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Mass);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Mass)) = value;
			}
		}

		// Token: 0x17002571 RID: 9585
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x0021A910 File Offset: 0x00218B10
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x0003AF1E File Offset: 0x0003911E
		public unsafe float rb_Drag
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Drag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_Drag)) = value;
			}
		}

		// Token: 0x17002572 RID: 9586
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x0021A938 File Offset: 0x00218B38
		// (set) Token: 0x06007C8C RID: 31884 RVA: 0x0003AF39 File Offset: 0x00039139
		public unsafe float rb_AngularDrag
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_AngularDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_rb_AngularDrag)) = value;
			}
		}

		// Token: 0x17002573 RID: 9587
		// (get) Token: 0x06007C8D RID: 31885 RVA: 0x0021A960 File Offset: 0x00218B60
		// (set) Token: 0x06007C8E RID: 31886 RVA: 0x0003AF54 File Offset: 0x00039154
		public unsafe Dictionary<StoredItem, Employee> _reservedItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__reservedItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StoredItem, Employee>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr__reservedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002574 RID: 9588
		// (get) Token: 0x06007C8F RID: 31887 RVA: 0x0021A990 File Offset: 0x00218B90
		// (set) Token: 0x06007C90 RID: 31888 RVA: 0x0003AF73 File Offset: 0x00039173
		public unsafe List<string> completedJobs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_completedJobs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_completedJobs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002575 RID: 9589
		// (get) Token: 0x06007C91 RID: 31889 RVA: 0x0021A9C0 File Offset: 0x00218BC0
		// (set) Token: 0x06007C92 RID: 31890 RVA: 0x0003AF92 File Offset: 0x00039192
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002576 RID: 9590
		// (get) Token: 0x06007C93 RID: 31891 RVA: 0x0021A9E8 File Offset: 0x00218BE8
		// (set) Token: 0x06007C94 RID: 31892 RVA: 0x0003AFAD File Offset: 0x000391AD
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Pallet.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400547F RID: 21631
		private static readonly System.IntPtr NativeFieldInfoPtr_palletsOwnedByLocalPlayer;

		// Token: 0x04005480 RID: 21632
		private static readonly System.IntPtr NativeFieldInfoPtr_sizeX;

		// Token: 0x04005481 RID: 21633
		private static readonly System.IntPtr NativeFieldInfoPtr_sizeY;

		// Token: 0x04005482 RID: 21634
		private static readonly System.IntPtr NativeFieldInfoPtr__storedItemContainer;

		// Token: 0x04005483 RID: 21635
		private static readonly System.IntPtr NativeFieldInfoPtr_rb;

		// Token: 0x04005484 RID: 21636
		private static readonly System.IntPtr NativeFieldInfoPtr_storageGrid;

		// Token: 0x04005485 RID: 21637
		private static readonly System.IntPtr NativeFieldInfoPtr_networkTransform;

		// Token: 0x04005486 RID: 21638
		private static readonly System.IntPtr NativeFieldInfoPtr_forkliftsInContact;

		// Token: 0x04005487 RID: 21639
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSlotGUID;

		// Token: 0x04005488 RID: 21640
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSlot;

		// Token: 0x04005489 RID: 21641
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceSlotCheck;

		// Token: 0x0400548A RID: 21642
		private static readonly System.IntPtr NativeFieldInfoPtr_timeBoundToSlot;

		// Token: 0x0400548B RID: 21643
		private static readonly System.IntPtr NativeFieldInfoPtr_rb_Mass;

		// Token: 0x0400548C RID: 21644
		private static readonly System.IntPtr NativeFieldInfoPtr_rb_Drag;

		// Token: 0x0400548D RID: 21645
		private static readonly System.IntPtr NativeFieldInfoPtr_rb_AngularDrag;

		// Token: 0x0400548E RID: 21646
		private static readonly System.IntPtr NativeFieldInfoPtr__reservedItems;

		// Token: 0x0400548F RID: 21647
		private static readonly System.IntPtr NativeFieldInfoPtr_completedJobs;

		// Token: 0x04005490 RID: 21648
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005491 RID: 21649
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005492 RID: 21650
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;

		// Token: 0x04005493 RID: 21651
		private static readonly System.IntPtr NativeMethodInfoPtr_get_carriedByForklift_Protected_get_Boolean_0;

		// Token: 0x04005494 RID: 21652
		private static readonly System.IntPtr NativeMethodInfoPtr_get_storedItemContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04005495 RID: 21653
		private static readonly System.IntPtr NativeMethodInfoPtr_get_reservedItems_Public_Virtual_Final_New_get_Dictionary_2_StoredItem_Employee_0;

		// Token: 0x04005496 RID: 21654
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005497 RID: 21655
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04005498 RID: 21656
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOwner_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x04005499 RID: 21657
		private static readonly System.IntPtr NativeMethodInfoPtr_OnOwnershipClient_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400549A RID: 21658
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400549B RID: 21659
		private static readonly System.IntPtr NativeMethodInfoPtr_SendItemsToClient_Private_Void_NetworkConnection_0;

		// Token: 0x0400549C RID: 21660
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyPallet_Public_Virtual_New_Void_0;

		// Token: 0x0400549D RID: 21661
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x0400549E RID: 21662
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x0400549F RID: 21663
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Vector3_0;

		// Token: 0x040054A0 RID: 21664
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOwnership_Private_Void_0;

		// Token: 0x040054A1 RID: 21665
		private static readonly System.IntPtr NativeMethodInfoPtr_BindToSlot_Server_Public_Void_Guid_0;

		// Token: 0x040054A2 RID: 21666
		private static readonly System.IntPtr NativeMethodInfoPtr_BindToSlot_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x040054A3 RID: 21667
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitSlot_Server_Public_Void_0;

		// Token: 0x040054A4 RID: 21668
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitSlot_Private_Void_0;

		// Token: 0x040054A5 RID: 21669
		private static readonly System.IntPtr NativeMethodInfoPtr_TriggerStay_Public_Void_Collider_0;

		// Token: 0x040054A6 RID: 21670
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStoredItems_Public_Virtual_Final_New_List_1_StoredItem_0;

		// Token: 0x040054A7 RID: 21671
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStorageGrids_Public_Virtual_Final_New_List_1_StorageGrid_0;

		// Token: 0x040054A8 RID: 21672
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateStoredItem_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x040054A9 RID: 21673
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateStoredItem_Server_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x040054AA RID: 21674
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x040054AB RID: 21675
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyStoredItem_Server_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x040054AC RID: 21676
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040054AD RID: 21677
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040054AE RID: 21678
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040054AF RID: 21679
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040054B0 RID: 21680
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetOwner_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040054B1 RID: 21681
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetOwner_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040054B2 RID: 21682
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetOwner_328543758_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040054B3 RID: 21683
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_BindToSlot_Server_1272046255_Private_Void_Guid_0;

		// Token: 0x040054B4 RID: 21684
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BindToSlot_Server_1272046255_Public_Void_Guid_0;

		// Token: 0x040054B5 RID: 21685
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_BindToSlot_Server_1272046255_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040054B6 RID: 21686
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x040054B7 RID: 21687
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x040054B8 RID: 21688
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_BindToSlot_454078614_Private_Void_PooledReader_Channel_0;

		// Token: 0x040054B9 RID: 21689
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_BindToSlot_454078614_Private_Void_NetworkConnection_Guid_0;

		// Token: 0x040054BA RID: 21690
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_BindToSlot_454078614_Private_Void_PooledReader_Channel_0;

		// Token: 0x040054BB RID: 21691
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExitSlot_Server_2166136261_Private_Void_0;

		// Token: 0x040054BC RID: 21692
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ExitSlot_Server_2166136261_Public_Void_0;

		// Token: 0x040054BD RID: 21693
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ExitSlot_Server_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040054BE RID: 21694
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ExitSlot_2166136261_Private_Void_0;

		// Token: 0x040054BF RID: 21695
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ExitSlot_2166136261_Private_Void_0;

		// Token: 0x040054C0 RID: 21696
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ExitSlot_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040054C1 RID: 21697
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x040054C2 RID: 21698
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___CreateStoredItem_913707843_Public_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x040054C3 RID: 21699
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0;

		// Token: 0x040054C4 RID: 21700
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateStoredItem_913707843_Private_Void_NetworkConnection_StorableItemInstance_Int32_Vector2_Single_String_Boolean_0;

		// Token: 0x040054C5 RID: 21701
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateStoredItem_913707843_Private_Void_PooledReader_Channel_0;

		// Token: 0x040054C6 RID: 21702
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x040054C7 RID: 21703
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___CreateStoredItem_Server_1890711751_Private_Void_StorableItemInstance_Int32_Vector2_Single_String_0;

		// Token: 0x040054C8 RID: 21704
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateStoredItem_Server_1890711751_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040054C9 RID: 21705
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyStoredItem_3261517793_Private_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x040054CA RID: 21706
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_3261517793_Public_Void_Int32_Coordinate_String_Boolean_0;

		// Token: 0x040054CB RID: 21707
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyStoredItem_3261517793_Private_Void_PooledReader_Channel_0;

		// Token: 0x040054CC RID: 21708
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x040054CD RID: 21709
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___DestroyStoredItem_Server_3952619116_Private_Void_Int32_Coordinate_String_0;

		// Token: 0x040054CE RID: 21710
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_DestroyStoredItem_Server_3952619116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040054CF RID: 21711
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
