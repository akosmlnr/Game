using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000421 RID: 1057
	public class ProceduralGridItem : BuildableItem
	{
		// Token: 0x06005765 RID: 22373 RVA: 0x0019A0D8 File Offset: 0x001982D8
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItem()
		{
			Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "ProceduralGridItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr);
			ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "ProceduralTileType");
			ProceduralGridItem.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "Rotation");
			ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "footprintTileMatches");
			ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "syncVar___Rotation");
			ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "syncVar___footprintTileMatches");
			ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted");
			ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted");
			ProceduralGridItem.NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674287);
			ProceduralGridItem.NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674288);
			ProceduralGridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674289);
			ProceduralGridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674290);
			ProceduralGridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674291);
			ProceduralGridItem.NativeMethodInfoPtr_SendProceduralGridItemData_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674292);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674293);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674294);
			ProceduralGridItem.NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674295);
			ProceduralGridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674296);
			ProceduralGridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674297);
			ProceduralGridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674298);
			ProceduralGridItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674299);
			ProceduralGridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674300);
			ProceduralGridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674301);
			ProceduralGridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674302);
			ProceduralGridItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674303);
			ProceduralGridItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674304);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674305);
			ProceduralGridItem.NativeMethodInfoPtr__OnStartClient_b__10_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674306);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674307);
			ProceduralGridItem.NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674308);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674309);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674310);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674311);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Server_SendProceduralGridItemData_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674312);
			ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___SendProceduralGridItemData_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674313);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Server_SendProceduralGridItemData_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674314);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674315);
			ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674316);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674317);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674318);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674319);
			ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674320);
			ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674321);
			ProceduralGridItem.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674322);
			ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674323);
			ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674324);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100674325);
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x0019A4B4 File Offset: 0x001986B4
		public unsafe int FootprintXSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186432, XrefRangeEnd = 186453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06005767 RID: 22375 RVA: 0x0019A4F0 File Offset: 0x001986F0
		public unsafe int FootprintYSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186453, XrefRangeEnd = 186474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06005768 RID: 22376 RVA: 0x0019A52C File Offset: 0x0019872C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186482, RefRangeEnd = 186483, XrefRangeStart = 186474, XrefRangeEnd = 186482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005769 RID: 22377 RVA: 0x0019A568 File Offset: 0x00198768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186483, XrefRangeEnd = 186490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600576A RID: 22378 RVA: 0x0019A5A4 File Offset: 0x001987A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186490, XrefRangeEnd = 186491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x0019A5F4 File Offset: 0x001987F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186491, XrefRangeEnd = 186505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendProceduralGridItemData(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_SendProceduralGridItemData_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x0019A66C File Offset: 0x0019886C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186505, XrefRangeEnd = 186554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeProceduralGridItem(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x0019A700 File Offset: 0x00198900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186571, RefRangeEnd = 186572, XrefRangeStart = 186554, XrefRangeEnd = 186571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x0019A780 File Offset: 0x00198980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186572, XrefRangeEnd = 186604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x0019A7DC File Offset: 0x001989DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186604, XrefRangeEnd = 186627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x0019A810 File Offset: 0x00198A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186627, XrefRangeEnd = 186637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x0019A844 File Offset: 0x00198A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186649, RefRangeEnd = 186650, XrefRangeStart = 186637, XrefRangeEnd = 186649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref callOnServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x0019A890 File Offset: 0x00198A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186650, XrefRangeEnd = 186662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x0019A8EC File Offset: 0x00198AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186662, XrefRangeEnd = 186667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x0019A928 File Offset: 0x00198B28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186673, RefRangeEnd = 186676, XrefRangeStart = 186667, XrefRangeEnd = 186673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x0019A968 File Offset: 0x00198B68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 186683, RefRangeEnd = 186687, XrefRangeStart = 186676, XrefRangeEnd = 186683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x0019A9B8 File Offset: 0x00198BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186687, XrefRangeEnd = 186719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x0019AA04 File Offset: 0x00198C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186734, RefRangeEnd = 186735, XrefRangeStart = 186719, XrefRangeEnd = 186734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x0019AA40 File Offset: 0x00198C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186735, XrefRangeEnd = 186740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x0019AA80 File Offset: 0x00198C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnStartClient_b__10_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__OnStartClient_b__10_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x0019AABC File Offset: 0x00198CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186740, XrefRangeEnd = 186745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x0019AAFC File Offset: 0x00198CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetProceduralGridData_b__15_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x0019AB38 File Offset: 0x00198D38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186791, RefRangeEnd = 186792, XrefRangeStart = 186745, XrefRangeEnd = 186791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x0019AB74 File Offset: 0x00198D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186793, RefRangeEnd = 186794, XrefRangeStart = 186792, XrefRangeEnd = 186793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x0019ABB0 File Offset: 0x00198DB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x0019ABEC File Offset: 0x00198DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Server_SendProceduralGridItemData_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x0019AC64 File Offset: 0x00198E64
		[CallerCount(0)]
		public unsafe void RpcLogic___SendProceduralGridItemData_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___SendProceduralGridItemData_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005781 RID: 22401 RVA: 0x0019ACDC File Offset: 0x00198EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186794, XrefRangeEnd = 186800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendProceduralGridItemData_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Server_SendProceduralGridItemData_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005782 RID: 22402 RVA: 0x0019AD40 File Offset: 0x00198F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186800, XrefRangeEnd = 186814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005783 RID: 22403 RVA: 0x0019ADC8 File Offset: 0x00198FC8
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005784 RID: 22404 RVA: 0x0019AE5C File Offset: 0x0019905C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186814, XrefRangeEnd = 186821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005785 RID: 22405 RVA: 0x0019AEAC File Offset: 0x001990AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186821, XrefRangeEnd = 186835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeProceduralGridItem_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005786 RID: 22406 RVA: 0x0019AF34 File Offset: 0x00199134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186835, XrefRangeEnd = 186842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeProceduralGridItem_3164718044(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06005787 RID: 22407 RVA: 0x0019AF84 File Offset: 0x00199184
		// (set) Token: 0x06005788 RID: 22408 RVA: 0x0019AFC0 File Offset: 0x001991C0
		public unsafe int SyncAccessor_Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 186850, RefRangeEnd = 186852, XrefRangeStart = 186842, XrefRangeEnd = 186850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005789 RID: 22409 RVA: 0x0019B00C File Offset: 0x0019920C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186852, XrefRangeEnd = 186865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x0600578A RID: 22410 RVA: 0x0019B080 File Offset: 0x00199280
		// (set) Token: 0x0600578B RID: 22411 RVA: 0x0019B0C0 File Offset: 0x001992C0
		public unsafe List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 186874, RefRangeEnd = 186875, XrefRangeStart = 186865, XrefRangeEnd = 186874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600578C RID: 22412 RVA: 0x0019B110 File Offset: 0x00199310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186875, XrefRangeEnd = 186882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600578D RID: 22413 RVA: 0x00029A36 File Offset: 0x00027C36
		public ProceduralGridItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x0019B14C File Offset: 0x0019934C
		// (set) Token: 0x0600578F RID: 22415 RVA: 0x00029A3F File Offset: 0x00027C3F
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x06005790 RID: 22416 RVA: 0x0019B17C File Offset: 0x0019937C
		// (set) Token: 0x06005791 RID: 22417 RVA: 0x00029A5E File Offset: 0x00027C5E
		public unsafe ProceduralTile.EProceduralTileType ProceduralTileType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType)) = value;
			}
		}

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x06005792 RID: 22418 RVA: 0x0019B1A4 File Offset: 0x001993A4
		// (set) Token: 0x06005793 RID: 22419 RVA: 0x00029A79 File Offset: 0x00027C79
		public unsafe int Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x0019B1CC File Offset: 0x001993CC
		// (set) Token: 0x06005795 RID: 22421 RVA: 0x00029A94 File Offset: 0x00027C94
		public unsafe List<CoordinateProceduralTilePair> footprintTileMatches
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x0019B1FC File Offset: 0x001993FC
		// (set) Token: 0x06005797 RID: 22423 RVA: 0x00029AB3 File Offset: 0x00027CB3
		public unsafe SyncVar<int> syncVar___Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A48 RID: 6728
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x0019B22C File Offset: 0x0019942C
		// (set) Token: 0x06005799 RID: 22425 RVA: 0x00029AD2 File Offset: 0x00027CD2
		public unsafe SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<List<CoordinateProceduralTilePair>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x0600579A RID: 22426 RVA: 0x0019B25C File Offset: 0x0019945C
		// (set) Token: 0x0600579B RID: 22427 RVA: 0x00029AF1 File Offset: 0x00027CF1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x0600579C RID: 22428 RVA: 0x0019B284 File Offset: 0x00199484
		// (set) Token: 0x0600579D RID: 22429 RVA: 0x00029B0C File Offset: 0x00027D0C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003B37 RID: 15159
		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04003B38 RID: 15160
		private static readonly System.IntPtr NativeFieldInfoPtr_ProceduralTileType;

		// Token: 0x04003B39 RID: 15161
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04003B3A RID: 15162
		private static readonly System.IntPtr NativeFieldInfoPtr_footprintTileMatches;

		// Token: 0x04003B3B RID: 15163
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___Rotation;

		// Token: 0x04003B3C RID: 15164
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___footprintTileMatches;

		// Token: 0x04003B3D RID: 15165
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003B3E RID: 15166
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003B3F RID: 15167
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0;

		// Token: 0x04003B40 RID: 15168
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0;

		// Token: 0x04003B41 RID: 15169
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003B42 RID: 15170
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003B43 RID: 15171
		private static readonly System.IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003B44 RID: 15172
		private static readonly System.IntPtr NativeMethodInfoPtr_SendProceduralGridItemData_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B45 RID: 15173
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B46 RID: 15174
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B47 RID: 15175
		private static readonly System.IntPtr NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0;

		// Token: 0x04003B48 RID: 15176
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04003B49 RID: 15177
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x04003B4A RID: 15178
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003B4B RID: 15179
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0;

		// Token: 0x04003B4C RID: 15180
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0;

		// Token: 0x04003B4D RID: 15181
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04003B4E RID: 15182
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04003B4F RID: 15183
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04003B50 RID: 15184
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B51 RID: 15185
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003B52 RID: 15186
		private static readonly System.IntPtr NativeMethodInfoPtr__OnStartClient_b__10_1_Private_Boolean_0;

		// Token: 0x04003B53 RID: 15187
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04003B54 RID: 15188
		private static readonly System.IntPtr NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0;

		// Token: 0x04003B55 RID: 15189
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B56 RID: 15190
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B57 RID: 15191
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B58 RID: 15192
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendProceduralGridItemData_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B59 RID: 15193
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendProceduralGridItemData_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B5A RID: 15194
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendProceduralGridItemData_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003B5B RID: 15195
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B5C RID: 15196
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B5D RID: 15197
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003B5E RID: 15198
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003B5F RID: 15199
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_3164718044_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003B60 RID: 15200
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0;

		// Token: 0x04003B61 RID: 15201
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04003B62 RID: 15202
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003B63 RID: 15203
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0;

		// Token: 0x04003B64 RID: 15204
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0;

		// Token: 0x04003B65 RID: 15205
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A0C RID: 2572
		public class FootprintTileMatch : Il2CppSystem.Object
		{
			// Token: 0x0600D15E RID: 53598 RVA: 0x00329F4C File Offset: 0x0032814C
			// Note: this type is marked as 'beforefieldinit'.
			static FootprintTileMatch()
			{
				Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "FootprintTileMatch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr);
				ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, "footprint");
				ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, "matchedTile");
				ProceduralGridItem.FootprintTileMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, 100674326);
			}

			// Token: 0x0600D15F RID: 53599 RVA: 0x00329FB4 File Offset: 0x003281B4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FootprintTileMatch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.FootprintTileMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D160 RID: 53600 RVA: 0x00065848 File Offset: 0x00063A48
			public FootprintTileMatch(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E8 RID: 16616
			// (get) Token: 0x0600D161 RID: 53601 RVA: 0x00329FF0 File Offset: 0x003281F0
			// (set) Token: 0x0600D162 RID: 53602 RVA: 0x00065851 File Offset: 0x00063A51
			public unsafe FootprintTile footprint
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E9 RID: 16617
			// (get) Token: 0x0600D163 RID: 53603 RVA: 0x0032A020 File Offset: 0x00328220
			// (set) Token: 0x0600D164 RID: 53604 RVA: 0x00065870 File Offset: 0x00063A70
			public unsafe ProceduralTile matchedTile
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D97 RID: 36247
			private static readonly System.IntPtr NativeFieldInfoPtr_footprint;

			// Token: 0x04008D98 RID: 36248
			private static readonly System.IntPtr NativeFieldInfoPtr_matchedTile;

			// Token: 0x04008D99 RID: 36249
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A0D RID: 2573
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<<OnStartClient>g__WaitForDataSend|10_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D165 RID: 53605 RVA: 0x0032A050 File Offset: 0x00328250
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<<OnStartClient>g__WaitForDataSend|10_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674327);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674328);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674329);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674330);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674331);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr, 100674332);
			}

			// Token: 0x0600D166 RID: 53606 RVA: 0x0032A130 File Offset: 0x00328330
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D167 RID: 53607 RVA: 0x0032A178 File Offset: 0x00328378
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D168 RID: 53608 RVA: 0x0032A1AC File Offset: 0x003283AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186399, XrefRangeEnd = 186410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040ED RID: 16621
			// (get) Token: 0x0600D169 RID: 53609 RVA: 0x0032A1E8 File Offset: 0x003283E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D16A RID: 53610 RVA: 0x0032A228 File Offset: 0x00328428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186410, XrefRangeEnd = 186415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040EE RID: 16622
			// (get) Token: 0x0600D16B RID: 53611 RVA: 0x0032A25C File Offset: 0x0032845C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D16C RID: 53612 RVA: 0x0006588F File Offset: 0x00063A8F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040EA RID: 16618
			// (get) Token: 0x0600D16D RID: 53613 RVA: 0x0032A29C File Offset: 0x0032849C
			// (set) Token: 0x0600D16E RID: 53614 RVA: 0x00065898 File Offset: 0x00063A98
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040EB RID: 16619
			// (get) Token: 0x0600D16F RID: 53615 RVA: 0x0032A2C4 File Offset: 0x003284C4
			// (set) Token: 0x0600D170 RID: 53616 RVA: 0x000658B3 File Offset: 0x00063AB3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040EC RID: 16620
			// (get) Token: 0x0600D171 RID: 53617 RVA: 0x0032A2F4 File Offset: 0x003284F4
			// (set) Token: 0x0600D172 RID: 53618 RVA: 0x000658D2 File Offset: 0x00063AD2
			public unsafe ProceduralGridItem __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D9A RID: 36250
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D9B RID: 36251
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D9C RID: 36252
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D9D RID: 36253
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D9E RID: 36254
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D9F RID: 36255
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DA0 RID: 36256
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DA1 RID: 36257
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DA2 RID: 36258
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A0E RID: 2574
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<<SetProceduralGridData>g__Routine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D173 RID: 53619 RVA: 0x0032A324 File Offset: 0x00328524
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<<SetProceduralGridData>g__Routine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674333);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674334);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674335);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674336);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674337);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr, 100674338);
			}

			// Token: 0x0600D174 RID: 53620 RVA: 0x0032A404 File Offset: 0x00328604
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D175 RID: 53621 RVA: 0x0032A44C File Offset: 0x0032864C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D176 RID: 53622 RVA: 0x0032A480 File Offset: 0x00328680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186415, XrefRangeEnd = 186427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040F2 RID: 16626
			// (get) Token: 0x0600D177 RID: 53623 RVA: 0x0032A4BC File Offset: 0x003286BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D178 RID: 53624 RVA: 0x0032A4FC File Offset: 0x003286FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186427, XrefRangeEnd = 186432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040F3 RID: 16627
			// (get) Token: 0x0600D179 RID: 53625 RVA: 0x0032A530 File Offset: 0x00328730
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D17A RID: 53626 RVA: 0x000658F1 File Offset: 0x00063AF1
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040EF RID: 16623
			// (get) Token: 0x0600D17B RID: 53627 RVA: 0x0032A570 File Offset: 0x00328770
			// (set) Token: 0x0600D17C RID: 53628 RVA: 0x000658FA File Offset: 0x00063AFA
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040F0 RID: 16624
			// (get) Token: 0x0600D17D RID: 53629 RVA: 0x0032A598 File Offset: 0x00328798
			// (set) Token: 0x0600D17E RID: 53630 RVA: 0x00065915 File Offset: 0x00063B15
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F1 RID: 16625
			// (get) Token: 0x0600D17F RID: 53631 RVA: 0x0032A5C8 File Offset: 0x003287C8
			// (set) Token: 0x0600D180 RID: 53632 RVA: 0x00065934 File Offset: 0x00063B34
			public unsafe ProceduralGridItem __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DA3 RID: 36259
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008DA4 RID: 36260
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008DA5 RID: 36261
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008DA6 RID: 36262
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008DA7 RID: 36263
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DA8 RID: 36264
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008DA9 RID: 36265
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008DAA RID: 36266
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008DAB RID: 36267
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A0F RID: 2575
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D181 RID: 53633 RVA: 0x0032A5F8 File Offset: 0x003287F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr);
				ProceduralGridItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9");
				ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9__4_0");
				ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9__6_0");
				ProceduralGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100674340);
				ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100674341);
				ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100674342);
			}

			// Token: 0x0600D182 RID: 53634 RVA: 0x0032A69C File Offset: 0x0032889C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D183 RID: 53635 RVA: 0x0032A6D8 File Offset: 0x003288D8
			[CallerCount(0)]
			public unsafe int _get_FootprintXSize_b__4_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D184 RID: 53636 RVA: 0x0032A72C File Offset: 0x0032892C
			[CallerCount(0)]
			public unsafe int _get_FootprintYSize_b__6_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D185 RID: 53637 RVA: 0x00065953 File Offset: 0x00063B53
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F4 RID: 16628
			// (get) Token: 0x0600D186 RID: 53638 RVA: 0x0032A780 File Offset: 0x00328980
			// (set) Token: 0x0600D187 RID: 53639 RVA: 0x0006595C File Offset: 0x00063B5C
			public unsafe static ProceduralGridItem.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F5 RID: 16629
			// (get) Token: 0x0600D188 RID: 53640 RVA: 0x0032A7A8 File Offset: 0x003289A8
			// (set) Token: 0x0600D189 RID: 53641 RVA: 0x0006596E File Offset: 0x00063B6E
			public unsafe static Il2CppSystem.Func<CoordinateFootprintTilePair, int> __9__4_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F6 RID: 16630
			// (get) Token: 0x0600D18A RID: 53642 RVA: 0x0032A7D0 File Offset: 0x003289D0
			// (set) Token: 0x0600D18B RID: 53643 RVA: 0x00065980 File Offset: 0x00063B80
			public unsafe static Il2CppSystem.Func<CoordinateFootprintTilePair, int> __9__6_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DAC RID: 36268
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DAD RID: 36269
			private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04008DAE RID: 36270
			private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04008DAF RID: 36271
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DB0 RID: 36272
			private static readonly System.IntPtr NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0;

			// Token: 0x04008DB1 RID: 36273
			private static readonly System.IntPtr NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0;
		}
	}
}
