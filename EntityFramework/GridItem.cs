using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x0200041E RID: 1054
	public class GridItem : BuildableItem
	{
		// Token: 0x06005705 RID: 22277 RVA: 0x0019851C File Offset: 0x0019671C
		// Note: this type is marked as 'beforefieldinit'.
		static GridItem()
		{
			Il2CppClassPointerStore<GridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "GridItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem>.NativeClassPtr);
			GridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			GridItem.NativeFieldInfoPtr_GridType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "GridType");
			GridItem.NativeFieldInfoPtr__OwnerGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<OwnerGrid>k__BackingField");
			GridItem.NativeFieldInfoPtr_OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "OwnerGridGUID");
			GridItem.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "OriginCoordinate");
			GridItem.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "Rotation");
			GridItem.NativeFieldInfoPtr_CoordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "CoordinatePairs");
			GridItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted");
			GridItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.GridItemAssembly-CSharp.dll_Excuted");
			GridItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674207);
			GridItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674208);
			GridItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674209);
			GridItem.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674210);
			GridItem.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674211);
			GridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674212);
			GridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674213);
			GridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674214);
			GridItem.NativeMethodInfoPtr_SendGridItemData_Public_Void_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674215);
			GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674216);
			GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674217);
			GridItem.NativeMethodInfoPtr_SetGridData_Protected_Void_Guid_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674218);
			GridItem.NativeMethodInfoPtr_ValidateRotation_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674219);
			GridItem.NativeMethodInfoPtr_ProcessGridData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674220);
			GridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674221);
			GridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674222);
			GridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674223);
			GridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674224);
			GridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674225);
			GridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674226);
			GridItem.NativeMethodInfoPtr_GetParentTileAtFootprintCoordinate_Public_Tile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674227);
			GridItem.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_New_Boolean_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674228);
			GridItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674229);
			GridItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674230);
			GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674231);
			GridItem.NativeMethodInfoPtr__OnStartClient_b__18_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674232);
			GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674233);
			GridItem.NativeMethodInfoPtr__ProcessGridData_b__25_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674234);
			GridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674235);
			GridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674236);
			GridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674237);
			GridItem.NativeMethodInfoPtr_RpcWriter___Server_SendGridItemData_2821640832_Private_Void_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674238);
			GridItem.NativeMethodInfoPtr_RpcLogic___SendGridItemData_2821640832_Public_Void_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674239);
			GridItem.NativeMethodInfoPtr_RpcReader___Server_SendGridItemData_2821640832_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674240);
			GridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674241);
			GridItem.NativeMethodInfoPtr_RpcLogic___InitializeGridItem_1883577149_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674242);
			GridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674243);
			GridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674244);
			GridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674245);
			GridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem>.NativeClassPtr, 100674246);
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x00198920 File Offset: 0x00196B20
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 185598, RefRangeEnd = 185602, XrefRangeStart = 185595, XrefRangeEnd = 185598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06005707 RID: 22279 RVA: 0x00198960 File Offset: 0x00196B60
		public unsafe int FootprintX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185602, XrefRangeEnd = 185623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06005708 RID: 22280 RVA: 0x0019899C File Offset: 0x00196B9C
		public unsafe int FootprintY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185623, XrefRangeEnd = 185644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x06005709 RID: 22281 RVA: 0x001989D8 File Offset: 0x00196BD8
		// (set) Token: 0x0600570A RID: 22282 RVA: 0x00198A18 File Offset: 0x00196C18
		public unsafe Grid OwnerGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00198A5C File Offset: 0x00196C5C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 185657, RefRangeEnd = 185679, XrefRangeStart = 185644, XrefRangeEnd = 185657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x00198A98 File Offset: 0x00196C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185679, XrefRangeEnd = 185686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x00198AD4 File Offset: 0x00196CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185686, XrefRangeEnd = 185688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x00198B24 File Offset: 0x00196D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185688, XrefRangeEnd = 185704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendGridItemData(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_SendGridItemData_Public_Void_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00198BA8 File Offset: 0x00196DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185704, XrefRangeEnd = 185758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeGridItem(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x00198C48 File Offset: 0x00196E48
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 185775, RefRangeEnd = 185785, XrefRangeStart = 185758, XrefRangeEnd = 185775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00198CD8 File Offset: 0x00196ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185785, XrefRangeEnd = 185805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGridData(Il2CppSystem.Guid gridGUID, Vector2 originCoordinate, int rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_SetGridData_Protected_Void_Guid_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00198D34 File Offset: 0x00196F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185812, RefRangeEnd = 185814, XrefRangeStart = 185805, XrefRangeEnd = 185812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ValidateRotation(int rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_ValidateRotation_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00198D80 File Offset: 0x00196F80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185904, RefRangeEnd = 185906, XrefRangeStart = 185814, XrefRangeEnd = 185904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessGridData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_ProcessGridData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00198DB4 File Offset: 0x00196FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185906, XrefRangeEnd = 185933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00198DE8 File Offset: 0x00196FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185949, RefRangeEnd = 185950, XrefRangeStart = 185933, XrefRangeEnd = 185949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00198E1C File Offset: 0x0019701C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 185952, RefRangeEnd = 185962, XrefRangeStart = 185950, XrefRangeEnd = 185952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref callOnServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00198E68 File Offset: 0x00197068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185962, XrefRangeEnd = 185967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005718 RID: 22296 RVA: 0x00198EA4 File Offset: 0x001970A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185973, RefRangeEnd = 185976, XrefRangeStart = 185967, XrefRangeEnd = 185973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00198EE4 File Offset: 0x001970E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185983, RefRangeEnd = 185985, XrefRangeStart = 185976, XrefRangeEnd = 185983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
		}

		// Token: 0x0600571A RID: 22298 RVA: 0x00198F34 File Offset: 0x00197134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185985, XrefRangeEnd = 186001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetParentTileAtFootprintCoordinate(Coordinate footprintCoord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprintCoord);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_GetParentTileAtFootprintCoordinate_Public_Tile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}

		// Token: 0x0600571B RID: 22299 RVA: 0x00198F84 File Offset: 0x00197184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186001, XrefRangeEnd = 186008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanShareTileWith(List<GridItem> obstacles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacles);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_New_Boolean_List_1_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600571C RID: 22300 RVA: 0x00198FDC File Offset: 0x001971DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186008, XrefRangeEnd = 186012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x00199028 File Offset: 0x00197228
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 186046, RefRangeEnd = 186065, XrefRangeStart = 186012, XrefRangeEnd = 186046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x00199064 File Offset: 0x00197264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186065, XrefRangeEnd = 186070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x001990A4 File Offset: 0x001972A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186070, XrefRangeEnd = 186072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnStartClient_b__18_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr__OnStartClient_b__18_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x001990E0 File Offset: 0x001972E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186072, XrefRangeEnd = 186077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x00199120 File Offset: 0x00197320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ProcessGridData_b__25_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr__ProcessGridData_b__25_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005722 RID: 22306 RVA: 0x0019915C File Offset: 0x0019735C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 186129, RefRangeEnd = 186148, XrefRangeStart = 186077, XrefRangeEnd = 186129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x00199198 File Offset: 0x00197398
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 186148, RefRangeEnd = 186167, XrefRangeStart = 186148, XrefRangeEnd = 186148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x001991D4 File Offset: 0x001973D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x00199210 File Offset: 0x00197410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186167, XrefRangeEnd = 186183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcWriter___Server_SendGridItemData_2821640832_Private_Void_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00199294 File Offset: 0x00197494
		[CallerCount(0)]
		public unsafe void RpcLogic___SendGridItemData_2821640832(ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcLogic___SendGridItemData_2821640832_Public_Void_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x00199318 File Offset: 0x00197518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186183, XrefRangeEnd = 186191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendGridItemData_2821640832(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcReader___Server_SendGridItemData_2821640832_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x0019937C File Offset: 0x0019757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186191, XrefRangeEnd = 186207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00199414 File Offset: 0x00197614
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186214, RefRangeEnd = 186217, XrefRangeStart = 186207, XrefRangeEnd = 186214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_RpcLogic___InitializeGridItem_1883577149_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x001994B4 File Offset: 0x001976B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186217, XrefRangeEnd = 186227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00199504 File Offset: 0x00197704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186227, XrefRangeEnd = 186243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeGridItem_1883577149(NetworkConnection conn, ItemInstance instance, string gridGUID, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(gridGUID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x0019959C File Offset: 0x0019779C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186243, XrefRangeEnd = 186253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeGridItem_1883577149(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x001995EC File Offset: 0x001977EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186253, XrefRangeEnd = 186265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0002985E File Offset: 0x00027A5E
		public GridItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x0600572F RID: 22319 RVA: 0x00199628 File Offset: 0x00197828
		// (set) Token: 0x06005730 RID: 22320 RVA: 0x00029867 File Offset: 0x00027A67
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06005731 RID: 22321 RVA: 0x00199658 File Offset: 0x00197858
		// (set) Token: 0x06005732 RID: 22322 RVA: 0x00029886 File Offset: 0x00027A86
		public unsafe GridItem.EGridType GridType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_GridType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_GridType)) = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x06005733 RID: 22323 RVA: 0x00199680 File Offset: 0x00197880
		// (set) Token: 0x06005734 RID: 22324 RVA: 0x000298A1 File Offset: 0x00027AA1
		public unsafe Grid _OwnerGrid_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr__OwnerGrid_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr__OwnerGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x06005735 RID: 22325 RVA: 0x001996B0 File Offset: 0x001978B0
		// (set) Token: 0x06005736 RID: 22326 RVA: 0x000298C0 File Offset: 0x00027AC0
		public unsafe Il2CppSystem.Guid OwnerGridGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OwnerGridGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OwnerGridGUID)) = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x06005737 RID: 22327 RVA: 0x001996D8 File Offset: 0x001978D8
		// (set) Token: 0x06005738 RID: 22328 RVA: 0x000298DB File Offset: 0x00027ADB
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x06005739 RID: 22329 RVA: 0x00199700 File Offset: 0x00197900
		// (set) Token: 0x0600573A RID: 22330 RVA: 0x000298F6 File Offset: 0x00027AF6
		public unsafe int Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x0600573B RID: 22331 RVA: 0x00199728 File Offset: 0x00197928
		// (set) Token: 0x0600573C RID: 22332 RVA: 0x00029911 File Offset: 0x00027B11
		public unsafe List<CoordinatePair> CoordinatePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinatePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_CoordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x0600573D RID: 22333 RVA: 0x00199758 File Offset: 0x00197958
		// (set) Token: 0x0600573E RID: 22334 RVA: 0x00029930 File Offset: 0x00027B30
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600573F RID: 22335 RVA: 0x00199780 File Offset: 0x00197980
		// (set) Token: 0x06005740 RID: 22336 RVA: 0x0002994B File Offset: 0x00027B4B
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003AEB RID: 15083
		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04003AEC RID: 15084
		private static readonly System.IntPtr NativeFieldInfoPtr_GridType;

		// Token: 0x04003AED RID: 15085
		private static readonly System.IntPtr NativeFieldInfoPtr__OwnerGrid_k__BackingField;

		// Token: 0x04003AEE RID: 15086
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnerGridGUID;

		// Token: 0x04003AEF RID: 15087
		private static readonly System.IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x04003AF0 RID: 15088
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04003AF1 RID: 15089
		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinatePairs;

		// Token: 0x04003AF2 RID: 15090
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003AF3 RID: 15091
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003AF4 RID: 15092
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x04003AF5 RID: 15093
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x04003AF6 RID: 15094
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x04003AF7 RID: 15095
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0;

		// Token: 0x04003AF8 RID: 15096
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0;

		// Token: 0x04003AF9 RID: 15097
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003AFA RID: 15098
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04003AFB RID: 15099
		private static readonly System.IntPtr NativeMethodInfoPtr_SendInitToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003AFC RID: 15100
		private static readonly System.IntPtr NativeMethodInfoPtr_SendGridItemData_Public_Void_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003AFD RID: 15101
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003AFE RID: 15102
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_New_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04003AFF RID: 15103
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGridData_Protected_Void_Guid_Vector2_Int32_0;

		// Token: 0x04003B00 RID: 15104
		private static readonly System.IntPtr NativeMethodInfoPtr_ValidateRotation_Private_Int32_Int32_0;

		// Token: 0x04003B01 RID: 15105
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessGridData_Private_Void_0;

		// Token: 0x04003B02 RID: 15106
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04003B03 RID: 15107
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x04003B04 RID: 15108
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04003B05 RID: 15109
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0;

		// Token: 0x04003B06 RID: 15110
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04003B07 RID: 15111
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04003B08 RID: 15112
		private static readonly System.IntPtr NativeMethodInfoPtr_GetParentTileAtFootprintCoordinate_Public_Tile_Coordinate_0;

		// Token: 0x04003B09 RID: 15113
		private static readonly System.IntPtr NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_New_Boolean_List_1_GridItem_0;

		// Token: 0x04003B0A RID: 15114
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04003B0B RID: 15115
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003B0C RID: 15116
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003B0D RID: 15117
		private static readonly System.IntPtr NativeMethodInfoPtr__OnStartClient_b__18_1_Private_Boolean_0;

		// Token: 0x04003B0E RID: 15118
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04003B0F RID: 15119
		private static readonly System.IntPtr NativeMethodInfoPtr__ProcessGridData_b__25_1_Private_Boolean_0;

		// Token: 0x04003B10 RID: 15120
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003B11 RID: 15121
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003B12 RID: 15122
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003B13 RID: 15123
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendGridItemData_2821640832_Private_Void_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003B14 RID: 15124
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendGridItemData_2821640832_Public_Void_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003B15 RID: 15125
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendGridItemData_2821640832_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003B16 RID: 15126
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003B17 RID: 15127
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___InitializeGridItem_1883577149_Public_Virtual_New_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003B18 RID: 15128
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003B19 RID: 15129
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeGridItem_1883577149_Private_Void_NetworkConnection_ItemInstance_String_Vector2_Int32_String_0;

		// Token: 0x04003B1A RID: 15130
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeGridItem_1883577149_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003B1B RID: 15131
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A07 RID: 2567
		[OriginalName("Assembly-CSharp.dll", "", "EGridType")]
		public enum EGridType
		{
			// Token: 0x04008D79 RID: 36217
			All,
			// Token: 0x04008D7A RID: 36218
			IndoorOnly,
			// Token: 0x04008D7B RID: 36219
			OutdoorOnly
		}

		// Token: 0x02000A08 RID: 2568
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<<OnStartClient>g__WaitForDataSend|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600D131 RID: 53553 RVA: 0x00329680 File Offset: 0x00327880
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<<OnStartClient>g__WaitForDataSend|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100674247);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100674248);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100674249);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100674250);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100674251);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr, 100674252);
			}

			// Token: 0x0600D132 RID: 53554 RVA: 0x00329760 File Offset: 0x00327960
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D133 RID: 53555 RVA: 0x003297A8 File Offset: 0x003279A8
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D134 RID: 53556 RVA: 0x003297DC File Offset: 0x003279DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185563, XrefRangeEnd = 185574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040DD RID: 16605
			// (get) Token: 0x0600D135 RID: 53557 RVA: 0x00329818 File Offset: 0x00327A18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D136 RID: 53558 RVA: 0x00329858 File Offset: 0x00327A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185574, XrefRangeEnd = 185579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040DE RID: 16606
			// (get) Token: 0x0600D137 RID: 53559 RVA: 0x0032988C File Offset: 0x00327A8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D138 RID: 53560 RVA: 0x0006571D File Offset: 0x0006391D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040DA RID: 16602
			// (get) Token: 0x0600D139 RID: 53561 RVA: 0x003298CC File Offset: 0x00327ACC
			// (set) Token: 0x0600D13A RID: 53562 RVA: 0x00065726 File Offset: 0x00063926
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040DB RID: 16603
			// (get) Token: 0x0600D13B RID: 53563 RVA: 0x003298F4 File Offset: 0x00327AF4
			// (set) Token: 0x0600D13C RID: 53564 RVA: 0x00065741 File Offset: 0x00063941
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040DC RID: 16604
			// (get) Token: 0x0600D13D RID: 53565 RVA: 0x00329924 File Offset: 0x00327B24
			// (set) Token: 0x0600D13E RID: 53566 RVA: 0x00065760 File Offset: 0x00063960
			public unsafe GridItem __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D7C RID: 36220
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D7D RID: 36221
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D7E RID: 36222
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D7F RID: 36223
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D80 RID: 36224
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D81 RID: 36225
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D82 RID: 36226
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D83 RID: 36227
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D84 RID: 36228
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A09 RID: 2569
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<<ProcessGridData>g__Routine|25_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600D13F RID: 53567 RVA: 0x00329954 File Offset: 0x00327B54
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<<ProcessGridData>g__Routine|25_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100674253);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100674254);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100674255);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100674256);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100674257);
				GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr, 100674258);
			}

			// Token: 0x0600D140 RID: 53568 RVA: 0x00329A34 File Offset: 0x00327C34
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D141 RID: 53569 RVA: 0x00329A7C File Offset: 0x00327C7C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D142 RID: 53570 RVA: 0x00329AB0 File Offset: 0x00327CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185579, XrefRangeEnd = 185590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040E2 RID: 16610
			// (get) Token: 0x0600D143 RID: 53571 RVA: 0x00329AEC File Offset: 0x00327CEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D144 RID: 53572 RVA: 0x00329B2C File Offset: 0x00327D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185590, XrefRangeEnd = 185595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040E3 RID: 16611
			// (get) Token: 0x0600D145 RID: 53573 RVA: 0x00329B60 File Offset: 0x00327D60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D146 RID: 53574 RVA: 0x0006577F File Offset: 0x0006397F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040DF RID: 16607
			// (get) Token: 0x0600D147 RID: 53575 RVA: 0x00329BA0 File Offset: 0x00327DA0
			// (set) Token: 0x0600D148 RID: 53576 RVA: 0x00065788 File Offset: 0x00063988
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040E0 RID: 16608
			// (get) Token: 0x0600D149 RID: 53577 RVA: 0x00329BC8 File Offset: 0x00327DC8
			// (set) Token: 0x0600D14A RID: 53578 RVA: 0x000657A3 File Offset: 0x000639A3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E1 RID: 16609
			// (get) Token: 0x0600D14B RID: 53579 RVA: 0x00329BF8 File Offset: 0x00327DF8
			// (set) Token: 0x0600D14C RID: 53580 RVA: 0x000657C2 File Offset: 0x000639C2
			public unsafe GridItem __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGrVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D85 RID: 36229
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D86 RID: 36230
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D87 RID: 36231
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D88 RID: 36232
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D89 RID: 36233
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D8A RID: 36234
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D8B RID: 36235
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D8C RID: 36236
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D8D RID: 36237
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A0A RID: 2570
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D14D RID: 53581 RVA: 0x00329C28 File Offset: 0x00327E28
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr);
				GridItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, "<>9");
				GridItem.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, "<>9__5_0");
				GridItem.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, "<>9__7_0");
				GridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, 100674260);
				GridItem.__c.NativeMethodInfoPtr__get_FootprintX_b__5_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, 100674261);
				GridItem.__c.NativeMethodInfoPtr__get_FootprintY_b__7_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr, 100674262);
			}

			// Token: 0x0600D14E RID: 53582 RVA: 0x00329CCC File Offset: 0x00327ECC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D14F RID: 53583 RVA: 0x00329D08 File Offset: 0x00327F08
			[CallerCount(0)]
			public unsafe int _get_FootprintX_b__5_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.__c.NativeMethodInfoPtr__get_FootprintX_b__5_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D150 RID: 53584 RVA: 0x00329D5C File Offset: 0x00327F5C
			[CallerCount(0)]
			public unsafe int _get_FootprintY_b__7_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.__c.NativeMethodInfoPtr__get_FootprintY_b__7_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D151 RID: 53585 RVA: 0x000657E1 File Offset: 0x000639E1
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E4 RID: 16612
			// (get) Token: 0x0600D152 RID: 53586 RVA: 0x00329DB0 File Offset: 0x00327FB0
			// (set) Token: 0x0600D153 RID: 53587 RVA: 0x000657EA File Offset: 0x000639EA
			public unsafe static GridItem.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GridItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GridItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E5 RID: 16613
			// (get) Token: 0x0600D154 RID: 53588 RVA: 0x00329DD8 File Offset: 0x00327FD8
			// (set) Token: 0x0600D155 RID: 53589 RVA: 0x000657FC File Offset: 0x000639FC
			public unsafe static Il2CppSystem.Func<CoordinateFootprintTilePair, int> __9__5_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GridItem.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GridItem.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E6 RID: 16614
			// (get) Token: 0x0600D156 RID: 53590 RVA: 0x00329E00 File Offset: 0x00328000
			// (set) Token: 0x0600D157 RID: 53591 RVA: 0x0006580E File Offset: 0x00063A0E
			public unsafe static Il2CppSystem.Func<CoordinateFootprintTilePair, int> __9__7_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GridItem.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GridItem.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D8E RID: 36238
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D8F RID: 36239
			private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04008D90 RID: 36240
			private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04008D91 RID: 36241
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D92 RID: 36242
			private static readonly System.IntPtr NativeMethodInfoPtr__get_FootprintX_b__5_0_Internal_Int32_CoordinateFootprintTilePair_0;

			// Token: 0x04008D93 RID: 36243
			private static readonly System.IntPtr NativeMethodInfoPtr__get_FootprintY_b__7_0_Internal_Int32_CoordinateFootprintTilePair_0;
		}

		// Token: 0x02000A0B RID: 2571
		[ObfuscatedName("ScheduleOne.EntityFramework.GridItem+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D158 RID: 53592 RVA: 0x00329E28 File Offset: 0x00328028
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GridItem>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr);
				GridItem.__c__DisplayClass32_0.NativeFieldInfoPtr_footprintCoord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr, "footprintCoord");
				GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr, 100674263);
				GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__GetParentTileAtFootprintCoordinate_b__0_Internal_Boolean_CoordinatePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr, 100674264);
			}

			// Token: 0x0600D159 RID: 53593 RVA: 0x00329E90 File Offset: 0x00328090
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItem.__c__DisplayClass32_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D15A RID: 53594 RVA: 0x00329ECC File Offset: 0x003280CC
			[CallerCount(0)]
			public unsafe bool _GetParentTileAtFootprintCoordinate_b__0(CoordinatePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GridItem.__c__DisplayClass32_0.NativeMethodInfoPtr__GetParentTileAtFootprintCoordinate_b__0_Internal_Boolean_CoordinatePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D15B RID: 53595 RVA: 0x00065820 File Offset: 0x00063A20
			public __c__DisplayClass32_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040E7 RID: 16615
			// (get) Token: 0x0600D15C RID: 53596 RVA: 0x00329F1C File Offset: 0x0032811C
			// (set) Token: 0x0600D15D RID: 53597 RVA: 0x00065829 File Offset: 0x00063A29
			public unsafe Coordinate footprintCoord
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.__c__DisplayClass32_0.NativeFieldInfoPtr_footprintCoord);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItem.__c__DisplayClass32_0.NativeFieldInfoPtr_footprintCoord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D94 RID: 36244
			private static readonly System.IntPtr NativeFieldInfoPtr_footprintCoord;

			// Token: 0x04008D95 RID: 36245
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D96 RID: 36246
			private static readonly System.IntPtr NativeMethodInfoPtr__GetParentTileAtFootprintCoordinate_b__0_Internal_Boolean_CoordinatePair_0;
		}
	}
}
