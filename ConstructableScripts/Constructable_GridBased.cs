using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property.Utilities.Power;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005EE RID: 1518
	public class Constructable_GridBased : Constructable
	{
		// Token: 0x060084B1 RID: 33969 RVA: 0x00236F9C File Offset: 0x0023519C
		// Note: this type is marked as 'beforefieldinit'.
		static Constructable_GridBased()
		{
			Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "Constructable_GridBased");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr);
			Constructable_GridBased.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "buildPoint");
			Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "CoordinateFootprintTilePairs");
			Constructable_GridBased.NativeFieldInfoPtr_ContentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "ContentContainer");
			Constructable_GridBased.NativeFieldInfoPtr_Grids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "Grids");
			Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "roofObjectsForVisibility");
			Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "AlwaysPowered");
			Constructable_GridBased.NativeFieldInfoPtr_powerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "powerNode");
			Constructable_GridBased.NativeFieldInfoPtr_isGhost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "isGhost");
			Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "dataChangedThisFrame");
			Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "<OwnerGrid>k__BackingField");
			Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "OwnerGridGUID");
			Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "OriginCoordinate");
			Constructable_GridBased.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "Rotation");
			Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "coordinatePairs");
			Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "originalRoofLayers");
			Constructable_GridBased.NativeFieldInfoPtr_roofVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "roofVisible");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___OwnerGridGUID");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___OriginCoordinate");
			Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "syncVar___Rotation");
			Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted");
			Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.Constructable_GridBasedAssembly-CSharp.dll_Excuted");
			Constructable_GridBased.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679990);
			Constructable_GridBased.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679991);
			Constructable_GridBased.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679992);
			Constructable_GridBased.NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679993);
			Constructable_GridBased.NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679994);
			Constructable_GridBased.NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679995);
			Constructable_GridBased.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679996);
			Constructable_GridBased.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679997);
			Constructable_GridBased.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679998);
			Constructable_GridBased.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100679999);
			Constructable_GridBased.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680000);
			Constructable_GridBased.NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680001);
			Constructable_GridBased.NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680002);
			Constructable_GridBased.NativeMethodInfoPtr_ReceiveData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680003);
			Constructable_GridBased.NativeMethodInfoPtr_SetParent_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680004);
			Constructable_GridBased.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680005);
			Constructable_GridBased.NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680006);
			Constructable_GridBased.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680007);
			Constructable_GridBased.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680008);
			Constructable_GridBased.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680009);
			Constructable_GridBased.NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680010);
			Constructable_GridBased.NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680011);
			Constructable_GridBased.NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680012);
			Constructable_GridBased.NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680013);
			Constructable_GridBased.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680014);
			Constructable_GridBased.NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680015);
			Constructable_GridBased.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680016);
			Constructable_GridBased.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680017);
			Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680018);
			Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680019);
			Constructable_GridBased.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680020);
			Constructable_GridBased.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680021);
			Constructable_GridBased.NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680022);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680023);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680024);
			Constructable_GridBased.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680025);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680026);
			Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680027);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680028);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680029);
			Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680030);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680031);
			Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680032);
			Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680033);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680034);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680035);
			Constructable_GridBased.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680036);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680037);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680038);
			Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680039);
			Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680040);
			Constructable_GridBased.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, 100680041);
		}

		// Token: 0x1700280D RID: 10253
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x00237580 File Offset: 0x00235780
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 250001, RefRangeEnd = 250004, XrefRangeStart = 249998, XrefRangeEnd = 250001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
		}

		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x060084B3 RID: 33971 RVA: 0x002375C0 File Offset: 0x002357C0
		public unsafe int FootprintX
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250004, XrefRangeEnd = 250008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x060084B4 RID: 33972 RVA: 0x002375FC File Offset: 0x002357FC
		public unsafe int FootprintY
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250008, XrefRangeEnd = 250012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x060084B5 RID: 33973 RVA: 0x00237638 File Offset: 0x00235838
		public unsafe bool hasWaterSupply
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x060084B6 RID: 33974 RVA: 0x00237674 File Offset: 0x00235874
		public unsafe PowerNode PowerNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x060084B7 RID: 33975 RVA: 0x002376B4 File Offset: 0x002358B4
		public unsafe bool isPowered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x060084B8 RID: 33976 RVA: 0x002376F0 File Offset: 0x002358F0
		// (set) Token: 0x060084B9 RID: 33977 RVA: 0x00237730 File Offset: 0x00235930
		public unsafe Grid OwnerGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x00237774 File Offset: 0x00235974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250013, RefRangeEnd = 250014, XrefRangeStart = 250012, XrefRangeEnd = 250013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x002377B0 File Offset: 0x002359B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250014, XrefRangeEnd = 250022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x002377EC File Offset: 0x002359EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250022, XrefRangeEnd = 250037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x0023783C File Offset: 0x00235A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250037, XrefRangeEnd = 250045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartNetwork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x00237878 File Offset: 0x00235A78
		[CallerCount(0)]
		public unsafe virtual void InitializeConstructable_GridBased(Grid grid, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x002378E4 File Offset: 0x00235AE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250094, RefRangeEnd = 250095, XrefRangeStart = 250045, XrefRangeEnd = 250094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_ReceiveData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x00237918 File Offset: 0x00235B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250095, XrefRangeEnd = 250099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParent(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetParent_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x0023795C File Offset: 0x00235B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250099, XrefRangeEnd = 250124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetData(Il2CppSystem.Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x002379C4 File Offset: 0x00235BC4
		[CallerCount(0)]
		public unsafe virtual void RepositionConstructable(Il2CppSystem.Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x00237A2C File Offset: 0x00235C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250124, XrefRangeEnd = 250159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x00237A60 File Offset: 0x00235C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250159, XrefRangeEnd = 250171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x00237A94 File Offset: 0x00235C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250213, RefRangeEnd = 250214, XrefRangeStart = 250171, XrefRangeEnd = 250213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref callOnServer;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x00237AE0 File Offset: 0x00235CE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250238, RefRangeEnd = 250239, XrefRangeStart = 250214, XrefRangeEnd = 250238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGridGUIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x00237B14 File Offset: 0x00235D14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250245, RefRangeEnd = 250247, XrefRangeStart = 250239, XrefRangeEnd = 250245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetGridGUIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x00237B54 File Offset: 0x00235D54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250278, RefRangeEnd = 250280, XrefRangeStart = 250247, XrefRangeEnd = 250278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGridGUIDs(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x00237BA8 File Offset: 0x00235DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250280, XrefRangeEnd = 250295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x00237BE4 File Offset: 0x00235DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250295, XrefRangeEnd = 250306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RestoreVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x00237C20 File Offset: 0x00235E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250306, XrefRangeEnd = 250364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRoofVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x00237C6C File Offset: 0x00235E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 250369, RefRangeEnd = 250370, XrefRangeStart = 250364, XrefRangeEnd = 250369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x00237CA0 File Offset: 0x00235EA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250376, RefRangeEnd = 250379, XrefRangeStart = 250370, XrefRangeEnd = 250376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084CE RID: 33998 RVA: 0x00237CE0 File Offset: 0x00235EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250386, RefRangeEnd = 250388, XrefRangeStart = 250379, XrefRangeEnd = 250386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x00237D30 File Offset: 0x00235F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250388, XrefRangeEnd = 250404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FootprintTile> GetFootprintTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x00237D70 File Offset: 0x00235F70
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250467, RefRangeEnd = 250470, XrefRangeStart = 250404, XrefRangeEnd = 250467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable_GridBased() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x00237DAC File Offset: 0x00235FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250470, XrefRangeEnd = 250475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x00237DEC File Offset: 0x00235FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ReceiveData_b__36_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x00237E28 File Offset: 0x00236028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250543, RefRangeEnd = 250546, XrefRangeStart = 250475, XrefRangeEnd = 250543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x00237E64 File Offset: 0x00236064
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250546, RefRangeEnd = 250549, XrefRangeStart = 250546, XrefRangeEnd = 250546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x00237EA0 File Offset: 0x002360A0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x00237EDC File Offset: 0x002360DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250549, XrefRangeEnd = 250563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetData_810381718(Il2CppSystem.Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x00237F38 File Offset: 0x00236138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250607, RefRangeEnd = 250609, XrefRangeStart = 250563, XrefRangeEnd = 250607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetData_810381718(Il2CppSystem.Guid gridGUID, Vector2 originCoordinate, float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref gridGUID;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x00237FA0 File Offset: 0x002361A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250609, XrefRangeEnd = 250616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetData_810381718(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x00238004 File Offset: 0x00236204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250616, XrefRangeEnd = 250626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x00238058 File Offset: 0x00236258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250638, RefRangeEnd = 250640, XrefRangeStart = 250626, XrefRangeEnd = 250638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x002380AC File Offset: 0x002362AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250640, XrefRangeEnd = 250643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x002380FC File Offset: 0x002362FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250643, XrefRangeEnd = 250653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGridGUIDs_2890081366(NetworkConnection target, Il2CppStringArray guids)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guids);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x00238150 File Offset: 0x00236350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250653, XrefRangeEnd = 250657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGridGUIDs_2890081366(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17002814 RID: 10260
		// (get) Token: 0x060084DE RID: 34014 RVA: 0x002381A0 File Offset: 0x002363A0
		// (set) Token: 0x060084DF RID: 34015 RVA: 0x002381DC File Offset: 0x002363DC
		public unsafe Il2CppSystem.Guid SyncAccessor_OwnerGridGUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 250665, RefRangeEnd = 250666, XrefRangeStart = 250657, XrefRangeEnd = 250665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x00238228 File Offset: 0x00236428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250666, XrefRangeEnd = 250686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref UInt321;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref Boolean2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x060084E1 RID: 34017 RVA: 0x0023829C File Offset: 0x0023649C
		// (set) Token: 0x060084E2 RID: 34018 RVA: 0x002382D8 File Offset: 0x002364D8
		public unsafe Vector2 SyncAccessor_OriginCoordinate
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 250694, RefRangeEnd = 250695, XrefRangeStart = 250686, XrefRangeEnd = 250694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002816 RID: 10262
		// (get) Token: 0x060084E3 RID: 34019 RVA: 0x00238324 File Offset: 0x00236524
		// (set) Token: 0x060084E4 RID: 34020 RVA: 0x00238360 File Offset: 0x00236560
		public unsafe float SyncAccessor_Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250695, XrefRangeEnd = 250703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x002383AC File Offset: 0x002365AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 250733, RefRangeEnd = 250736, XrefRangeStart = 250703, XrefRangeEnd = 250733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable_GridBased.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x0003ED84 File Offset: 0x0003CF84
		public Constructable_GridBased(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027F8 RID: 10232
		// (get) Token: 0x060084E7 RID: 34023 RVA: 0x002383E8 File Offset: 0x002365E8
		// (set) Token: 0x060084E8 RID: 34024 RVA: 0x0003ED8D File Offset: 0x0003CF8D
		public unsafe Transform buildPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_buildPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027F9 RID: 10233
		// (get) Token: 0x060084E9 RID: 34025 RVA: 0x00238418 File Offset: 0x00236618
		// (set) Token: 0x060084EA RID: 34026 RVA: 0x0003EDAC File Offset: 0x0003CFAC
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FA RID: 10234
		// (get) Token: 0x060084EB RID: 34027 RVA: 0x00238448 File Offset: 0x00236648
		// (set) Token: 0x060084EC RID: 34028 RVA: 0x0003EDCB File Offset: 0x0003CFCB
		public unsafe Transform ContentContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_ContentContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_ContentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FB RID: 10235
		// (get) Token: 0x060084ED RID: 34029 RVA: 0x00238478 File Offset: 0x00236678
		// (set) Token: 0x060084EE RID: 34030 RVA: 0x0003EDEA File Offset: 0x0003CFEA
		public unsafe Il2CppReferenceArray<Grid> Grids
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Grids);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grid>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Grids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FC RID: 10236
		// (get) Token: 0x060084EF RID: 34031 RVA: 0x002384A8 File Offset: 0x002366A8
		// (set) Token: 0x060084F0 RID: 34032 RVA: 0x0003EE09 File Offset: 0x0003D009
		public unsafe List<GameObject> roofObjectsForVisibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofObjectsForVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FD RID: 10237
		// (get) Token: 0x060084F1 RID: 34033 RVA: 0x002384D8 File Offset: 0x002366D8
		// (set) Token: 0x060084F2 RID: 34034 RVA: 0x0003EE28 File Offset: 0x0003D028
		public unsafe bool AlwaysPowered
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_AlwaysPowered)) = value;
			}
		}

		// Token: 0x170027FE RID: 10238
		// (get) Token: 0x060084F3 RID: 34035 RVA: 0x00238500 File Offset: 0x00236700
		// (set) Token: 0x060084F4 RID: 34036 RVA: 0x0003EE43 File Offset: 0x0003D043
		public unsafe PowerNode powerNode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_powerNode);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_powerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170027FF RID: 10239
		// (get) Token: 0x060084F5 RID: 34037 RVA: 0x00238530 File Offset: 0x00236730
		// (set) Token: 0x060084F6 RID: 34038 RVA: 0x0003EE62 File Offset: 0x0003D062
		public unsafe bool isGhost
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_isGhost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_isGhost)) = value;
			}
		}

		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x060084F7 RID: 34039 RVA: 0x00238558 File Offset: 0x00236758
		// (set) Token: 0x060084F8 RID: 34040 RVA: 0x0003EE7D File Offset: 0x0003D07D
		public unsafe bool dataChangedThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_dataChangedThisFrame)) = value;
			}
		}

		// Token: 0x17002801 RID: 10241
		// (get) Token: 0x060084F9 RID: 34041 RVA: 0x00238580 File Offset: 0x00236780
		// (set) Token: 0x060084FA RID: 34042 RVA: 0x0003EE98 File Offset: 0x0003D098
		public unsafe Grid _OwnerGrid_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr__OwnerGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002802 RID: 10242
		// (get) Token: 0x060084FB RID: 34043 RVA: 0x002385B0 File Offset: 0x002367B0
		// (set) Token: 0x060084FC RID: 34044 RVA: 0x0003EEB7 File Offset: 0x0003D0B7
		public unsafe Il2CppSystem.Guid OwnerGridGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OwnerGridGUID)) = value;
			}
		}

		// Token: 0x17002803 RID: 10243
		// (get) Token: 0x060084FD RID: 34045 RVA: 0x002385D8 File Offset: 0x002367D8
		// (set) Token: 0x060084FE RID: 34046 RVA: 0x0003EED2 File Offset: 0x0003D0D2
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17002804 RID: 10244
		// (get) Token: 0x060084FF RID: 34047 RVA: 0x00238600 File Offset: 0x00236800
		// (set) Token: 0x06008500 RID: 34048 RVA: 0x0003EEED File Offset: 0x0003D0ED
		public unsafe float Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x17002805 RID: 10245
		// (get) Token: 0x06008501 RID: 34049 RVA: 0x00238628 File Offset: 0x00236828
		// (set) Token: 0x06008502 RID: 34050 RVA: 0x0003EF08 File Offset: 0x0003D108
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x06008503 RID: 34051 RVA: 0x00238658 File Offset: 0x00236858
		// (set) Token: 0x06008504 RID: 34052 RVA: 0x0003EF27 File Offset: 0x0003D127
		public unsafe Dictionary<GameObject, LayerMask> originalRoofLayers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameObject, LayerMask>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_originalRoofLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x06008505 RID: 34053 RVA: 0x00238688 File Offset: 0x00236888
		// (set) Token: 0x06008506 RID: 34054 RVA: 0x0003EF46 File Offset: 0x0003D146
		public unsafe bool roofVisible
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_roofVisible)) = value;
			}
		}

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x002386B0 File Offset: 0x002368B0
		// (set) Token: 0x06008508 RID: 34056 RVA: 0x0003EF61 File Offset: 0x0003D161
		public unsafe SyncVar<Il2CppSystem.Guid> syncVar___OwnerGridGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Il2CppSystem.Guid>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OwnerGridGUID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x06008509 RID: 34057 RVA: 0x002386E0 File Offset: 0x002368E0
		// (set) Token: 0x0600850A RID: 34058 RVA: 0x0003EF80 File Offset: 0x0003D180
		public unsafe SyncVar<Vector2> syncVar___OriginCoordinate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector2>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___OriginCoordinate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x00238710 File Offset: 0x00236910
		// (set) Token: 0x0600850C RID: 34060 RVA: 0x0003EF9F File Offset: 0x0003D19F
		public unsafe SyncVar<float> syncVar___Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_syncVar___Rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x00238740 File Offset: 0x00236940
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x0003EFBE File Offset: 0x0003D1BE
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600850F RID: 34063 RVA: 0x00238768 File Offset: 0x00236968
		// (set) Token: 0x06008510 RID: 34064 RVA: 0x0003EFD9 File Offset: 0x0003D1D9
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005A4E RID: 23118
		private static readonly System.IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x04005A4F RID: 23119
		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04005A50 RID: 23120
		private static readonly System.IntPtr NativeFieldInfoPtr_ContentContainer;

		// Token: 0x04005A51 RID: 23121
		private static readonly System.IntPtr NativeFieldInfoPtr_Grids;

		// Token: 0x04005A52 RID: 23122
		private static readonly System.IntPtr NativeFieldInfoPtr_roofObjectsForVisibility;

		// Token: 0x04005A53 RID: 23123
		private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysPowered;

		// Token: 0x04005A54 RID: 23124
		private static readonly System.IntPtr NativeFieldInfoPtr_powerNode;

		// Token: 0x04005A55 RID: 23125
		private static readonly System.IntPtr NativeFieldInfoPtr_isGhost;

		// Token: 0x04005A56 RID: 23126
		private static readonly System.IntPtr NativeFieldInfoPtr_dataChangedThisFrame;

		// Token: 0x04005A57 RID: 23127
		private static readonly System.IntPtr NativeFieldInfoPtr__OwnerGrid_k__BackingField;

		// Token: 0x04005A58 RID: 23128
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnerGridGUID;

		// Token: 0x04005A59 RID: 23129
		private static readonly System.IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x04005A5A RID: 23130
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04005A5B RID: 23131
		private static readonly System.IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x04005A5C RID: 23132
		private static readonly System.IntPtr NativeFieldInfoPtr_originalRoofLayers;

		// Token: 0x04005A5D RID: 23133
		private static readonly System.IntPtr NativeFieldInfoPtr_roofVisible;

		// Token: 0x04005A5E RID: 23134
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___OwnerGridGUID;

		// Token: 0x04005A5F RID: 23135
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___OriginCoordinate;

		// Token: 0x04005A60 RID: 23136
		private static readonly System.IntPtr NativeFieldInfoPtr_syncVar___Rotation;

		// Token: 0x04005A61 RID: 23137
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005A62 RID: 23138
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005A63 RID: 23139
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x04005A64 RID: 23140
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x04005A65 RID: 23141
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x04005A66 RID: 23142
		private static readonly System.IntPtr NativeMethodInfoPtr_get_hasWaterSupply_Public_get_Boolean_0;

		// Token: 0x04005A67 RID: 23143
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PowerNode_Public_get_PowerNode_0;

		// Token: 0x04005A68 RID: 23144
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isPowered_Public_get_Boolean_0;

		// Token: 0x04005A69 RID: 23145
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerGrid_Public_get_Grid_0;

		// Token: 0x04005A6A RID: 23146
		private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerGrid_Protected_set_Void_Grid_0;

		// Token: 0x04005A6B RID: 23147
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04005A6C RID: 23148
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04005A6D RID: 23149
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04005A6E RID: 23150
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartNetwork_Public_Virtual_Void_0;

		// Token: 0x04005A6F RID: 23151
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeConstructable_GridBased_Public_Virtual_New_Void_Grid_Vector2_Single_0;

		// Token: 0x04005A70 RID: 23152
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceiveData_Private_Void_0;

		// Token: 0x04005A71 RID: 23153
		private static readonly System.IntPtr NativeMethodInfoPtr_SetParent_Private_Void_Transform_0;

		// Token: 0x04005A72 RID: 23154
		private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Protected_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x04005A73 RID: 23155
		private static readonly System.IntPtr NativeMethodInfoPtr_RepositionConstructable_Public_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x04005A74 RID: 23156
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x04005A75 RID: 23157
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x04005A76 RID: 23158
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_Void_Boolean_0;

		// Token: 0x04005A77 RID: 23159
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateGridGUIDs_Private_Void_0;

		// Token: 0x04005A78 RID: 23160
		private static readonly System.IntPtr NativeMethodInfoPtr_GetGridGUIDs_Private_Il2CppStringArray_0;

		// Token: 0x04005A79 RID: 23161
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGridGUIDs_Protected_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005A7A RID: 23162
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_Void_0;

		// Token: 0x04005A7B RID: 23163
		private static readonly System.IntPtr NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_Void_0;

		// Token: 0x04005A7C RID: 23164
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRoofVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04005A7D RID: 23165
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0;

		// Token: 0x04005A7E RID: 23166
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04005A7F RID: 23167
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04005A80 RID: 23168
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFootprintTiles_Public_List_1_FootprintTile_0;

		// Token: 0x04005A81 RID: 23169
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005A82 RID: 23170
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04005A83 RID: 23171
		private static readonly System.IntPtr NativeMethodInfoPtr__ReceiveData_b__36_1_Private_Boolean_0;

		// Token: 0x04005A84 RID: 23172
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005A85 RID: 23173
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005A86 RID: 23174
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005A87 RID: 23175
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetData_810381718_Private_Void_Guid_Vector2_Single_0;

		// Token: 0x04005A88 RID: 23176
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetData_810381718_Protected_Virtual_New_Void_Guid_Vector2_Single_0;

		// Token: 0x04005A89 RID: 23177
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetData_810381718_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005A8A RID: 23178
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005A8B RID: 23179
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetGridGUIDs_2890081366_Protected_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005A8C RID: 23180
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005A8D RID: 23181
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGridGUIDs_2890081366_Private_Void_NetworkConnection_Il2CppStringArray_0;

		// Token: 0x04005A8E RID: 23182
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGridGUIDs_2890081366_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005A8F RID: 23183
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_OwnerGridGUID_Public_get_Guid_0;

		// Token: 0x04005A90 RID: 23184
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_OwnerGridGUID_Public_set_Void_Guid_Boolean_0;

		// Token: 0x04005A91 RID: 23185
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ConstructableScripts_Constructable_GridBased_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04005A92 RID: 23186
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_OriginCoordinate_Public_get_Vector2_0;

		// Token: 0x04005A93 RID: 23187
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_OriginCoordinate_Public_set_Void_Vector2_Boolean_0;

		// Token: 0x04005A94 RID: 23188
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Single_0;

		// Token: 0x04005A95 RID: 23189
		private static readonly System.IntPtr NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Single_Boolean_0;

		// Token: 0x04005A96 RID: 23190
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000B31 RID: 2865
		[ObfuscatedName("ScheduleOne.ConstructableScripts.Constructable_GridBased+<<ReceiveData>g__Routine|36_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DA5B RID: 55899 RVA: 0x0034310C File Offset: 0x0034130C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique()
			{
				Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Constructable_GridBased>.NativeClassPtr, "<<ReceiveData>g__Routine|36_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>1__state");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>2__current");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, "<>4__this");
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100680042);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100680043);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100680044);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100680045);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100680046);
				Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr, 100680047);
			}

			// Token: 0x0600DA5C RID: 55900 RVA: 0x003431EC File Offset: 0x003413EC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA5D RID: 55901 RVA: 0x00343234 File Offset: 0x00341434
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DA5E RID: 55902 RVA: 0x00343268 File Offset: 0x00341468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249982, XrefRangeEnd = 249993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x1700435D RID: 17245
			// (get) Token: 0x0600DA5F RID: 55903 RVA: 0x003432A4 File Offset: 0x003414A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA60 RID: 55904 RVA: 0x003432E4 File Offset: 0x003414E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249993, XrefRangeEnd = 249998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700435E RID: 17246
			// (get) Token: 0x0600DA61 RID: 55905 RVA: 0x00343318 File Offset: 0x00341518
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DA62 RID: 55906 RVA: 0x00069EC6 File Offset: 0x000680C6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0600DA63 RID: 55907 RVA: 0x00343358 File Offset: 0x00341558
			// (set) Token: 0x0600DA64 RID: 55908 RVA: 0x00069ECF File Offset: 0x000680CF
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0600DA65 RID: 55909 RVA: 0x00343380 File Offset: 0x00341580
			// (set) Token: 0x0600DA66 RID: 55910 RVA: 0x00069EEA File Offset: 0x000680EA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700435C RID: 17244
			// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x003433B0 File Offset: 0x003415B0
			// (set) Token: 0x0600DA68 RID: 55912 RVA: 0x00069F09 File Offset: 0x00068109
			public unsafe Constructable_GridBased __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable_GridBased.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092F1 RID: 37617
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040092F2 RID: 37618
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040092F3 RID: 37619
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092F4 RID: 37620
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040092F5 RID: 37621
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092F6 RID: 37622
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040092F7 RID: 37623
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040092F8 RID: 37624
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040092F9 RID: 37625
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
