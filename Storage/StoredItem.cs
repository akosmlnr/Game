using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x020005A1 RID: 1441
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x06007DC8 RID: 32200 RVA: 0x0021F634 File Offset: 0x0021D834
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem()
		{
			Il2CppClassPointerStore<StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem>.NativeClassPtr);
			StoredItem.NativeFieldInfoPtr__item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<item>k__BackingField");
			StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<Destroyed>k__BackingField");
			StoredItem.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "buildPoint");
			StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			StoredItem.NativeFieldInfoPtr_footprintX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintX");
			StoredItem.NativeFieldInfoPtr_footprintY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintY");
			StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentStorageEntity>k__BackingField");
			StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentGrid>k__BackingField");
			StoredItem.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "intObj");
			StoredItem.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "coordinatePairs");
			StoredItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "rotation");
			StoredItem.NativeFieldInfoPtr_xSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "xSize");
			StoredItem.NativeFieldInfoPtr_ySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "ySize");
			StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<canBePickedUp>k__BackingField");
			StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<noPickupReason>k__BackingField");
			StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679159);
			StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679160);
			StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679161);
			StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679162);
			StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679163);
			StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679164);
			StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679165);
			StoredItem.NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679166);
			StoredItem.NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679167);
			StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679168);
			StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679169);
			StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679170);
			StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679171);
			StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679172);
			StoredItem.NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679173);
			StoredItem.NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679174);
			StoredItem.NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679175);
			StoredItem.NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679176);
			StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679177);
			StoredItem.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679178);
			StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679179);
			StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679180);
			StoredItem.NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679181);
			StoredItem.NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679182);
			StoredItem.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679183);
			StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679184);
			StoredItem.NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679185);
			StoredItem.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679186);
			StoredItem.NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679187);
			StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679188);
			StoredItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679189);
			StoredItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679190);
			StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679191);
			StoredItem.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679192);
			StoredItem.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679193);
			StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100679194);
		}

		// Token: 0x170025D4 RID: 9684
		// (get) Token: 0x06007DC9 RID: 32201 RVA: 0x0021FA60 File Offset: 0x0021DC60
		// (set) Token: 0x06007DCA RID: 32202 RVA: 0x0021FAA0 File Offset: 0x0021DCA0
		public unsafe StorableItemInstance item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025D5 RID: 9685
		// (get) Token: 0x06007DCB RID: 32203 RVA: 0x0021FAE4 File Offset: 0x0021DCE4
		// (set) Token: 0x06007DCC RID: 32204 RVA: 0x0021FB20 File Offset: 0x0021DD20
		public unsafe bool Destroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025D6 RID: 9686
		// (get) Token: 0x06007DCD RID: 32205 RVA: 0x0021FB60 File Offset: 0x0021DD60
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 240542, RefRangeEnd = 240545, XrefRangeStart = 240539, XrefRangeEnd = 240542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06007DCE RID: 32206 RVA: 0x0021FBA0 File Offset: 0x0021DDA0
		public unsafe int FootprintX
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 240566, RefRangeEnd = 240570, XrefRangeStart = 240545, XrefRangeEnd = 240566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06007DCF RID: 32207 RVA: 0x0021FBDC File Offset: 0x0021DDDC
		public unsafe int FootprintY
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 240591, RefRangeEnd = 240595, XrefRangeStart = 240570, XrefRangeEnd = 240591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170025D9 RID: 9689
		// (get) Token: 0x06007DD0 RID: 32208 RVA: 0x0021FC18 File Offset: 0x0021DE18
		// (set) Token: 0x06007DD1 RID: 32209 RVA: 0x0021FC58 File Offset: 0x0021DE58
		public unsafe IStorageEntity parentStorageEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025DA RID: 9690
		// (get) Token: 0x06007DD2 RID: 32210 RVA: 0x0021FC9C File Offset: 0x0021DE9C
		// (set) Token: 0x06007DD3 RID: 32211 RVA: 0x0021FCDC File Offset: 0x0021DEDC
		public unsafe StorageGrid parentGrid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17870, RefRangeEnd = 17871, XrefRangeStart = 17870, XrefRangeEnd = 17871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40500, RefRangeEnd = 40502, XrefRangeStart = 40500, XrefRangeEnd = 40502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025DB RID: 9691
		// (get) Token: 0x06007DD4 RID: 32212 RVA: 0x0021FD20 File Offset: 0x0021DF20
		public unsafe List<CoordinatePair> CoordinatePairs
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49699, XrefRangeStart = 49659, XrefRangeEnd = 49699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
		}

		// Token: 0x170025DC RID: 9692
		// (get) Token: 0x06007DD5 RID: 32213 RVA: 0x0021FD60 File Offset: 0x0021DF60
		public unsafe float Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170025DD RID: 9693
		// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x0021FD9C File Offset: 0x0021DF9C
		public unsafe int totalArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240595, XrefRangeEnd = 240596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170025DE RID: 9694
		// (get) Token: 0x06007DD7 RID: 32215 RVA: 0x0021FDD8 File Offset: 0x0021DFD8
		// (set) Token: 0x06007DD8 RID: 32216 RVA: 0x0021FE14 File Offset: 0x0021E014
		public unsafe bool canBePickedUp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025DF RID: 9695
		// (get) Token: 0x06007DD9 RID: 32217 RVA: 0x0021FE54 File Offset: 0x0021E054
		// (set) Token: 0x06007DDA RID: 32218 RVA: 0x0021FE8C File Offset: 0x0021E08C
		public unsafe string noPickupReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48163, RefRangeEnd = 48164, XrefRangeStart = 48163, XrefRangeEnd = 48164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x0021FED0 File Offset: 0x0021E0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240596, XrefRangeEnd = 240604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x0021FF0C File Offset: 0x0021E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240604, XrefRangeEnd = 240625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DDD RID: 32221 RVA: 0x0021FF48 File Offset: 0x0021E148
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 240682, RefRangeEnd = 240689, XrefRangeStart = 240625, XrefRangeEnd = 240682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DDE RID: 32222 RVA: 0x0021FFC4 File Offset: 0x0021E1C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240722, RefRangeEnd = 240723, XrefRangeStart = 240689, XrefRangeEnd = 240722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DDF RID: 32223 RVA: 0x0021FFF8 File Offset: 0x0021E1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240723, XrefRangeEnd = 240746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeIntObj()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE0 RID: 32224 RVA: 0x00220034 File Offset: 0x0021E234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240746, XrefRangeEnd = 240767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy_Internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE1 RID: 32225 RVA: 0x00220070 File Offset: 0x0021E270
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240780, RefRangeEnd = 240783, XrefRangeStart = 240767, XrefRangeEnd = 240780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE2 RID: 32226 RVA: 0x002200A4 File Offset: 0x0021E2A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240800, RefRangeEnd = 240802, XrefRangeStart = 240783, XrefRangeEnd = 240800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFootprintOccupancy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x002200D8 File Offset: 0x0021E2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240802, XrefRangeEnd = 240803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanBePickedUp(bool _canBePickedUp, string _noPickupReason = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _canBePickedUp;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_noPickupReason);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x00220128 File Offset: 0x0021E328
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240814, RefRangeEnd = 240816, XrefRangeStart = 240803, XrefRangeEnd = 240814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLayerRecursively(GameObject go, int layerNumber)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref layerNumber;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x0022016C File Offset: 0x0021E36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240816, XrefRangeEnd = 240834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<StoredItem> RemoveReservedItems(List<StoredItem> itemList, Employee allowedReservant)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemList);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allowedReservant);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr2) : null;
		}

		// Token: 0x06007DE6 RID: 32230 RVA: 0x002201C4 File Offset: 0x0021E3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 240841, RefRangeEnd = 240842, XrefRangeStart = 240834, XrefRangeEnd = 240841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}

		// Token: 0x06007DE7 RID: 32231 RVA: 0x00220234 File Offset: 0x0021E434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 240848, RefRangeEnd = 240851, XrefRangeStart = 240842, XrefRangeEnd = 240848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE8 RID: 32232 RVA: 0x00220274 File Offset: 0x0021E474
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 240856, RefRangeEnd = 240862, XrefRangeStart = 240851, XrefRangeEnd = 240856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DE9 RID: 32233 RVA: 0x002202A8 File Offset: 0x0021E4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240862, XrefRangeEnd = 240869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
		}

		// Token: 0x06007DEA RID: 32234 RVA: 0x002202F8 File Offset: 0x0021E4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240869, XrefRangeEnd = 240878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DEB RID: 32235 RVA: 0x00220334 File Offset: 0x0021E534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240878, XrefRangeEnd = 240884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x00220370 File Offset: 0x0021E570
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 240902, RefRangeEnd = 240910, XrefRangeStart = 240884, XrefRangeEnd = 240902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x0003B71D File Offset: 0x0003991D
		public StoredItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025C5 RID: 9669
		// (get) Token: 0x06007DEE RID: 32238 RVA: 0x002203AC File Offset: 0x0021E5AC
		// (set) Token: 0x06007DEF RID: 32239 RVA: 0x0003B726 File Offset: 0x00039926
		public unsafe StorableItemInstance _item_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C6 RID: 9670
		// (get) Token: 0x06007DF0 RID: 32240 RVA: 0x002203DC File Offset: 0x0021E5DC
		// (set) Token: 0x06007DF1 RID: 32241 RVA: 0x0003B745 File Offset: 0x00039945
		public unsafe bool _Destroyed_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x170025C7 RID: 9671
		// (get) Token: 0x06007DF2 RID: 32242 RVA: 0x00220404 File Offset: 0x0021E604
		// (set) Token: 0x06007DF3 RID: 32243 RVA: 0x0003B760 File Offset: 0x00039960
		public unsafe Transform buildPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C8 RID: 9672
		// (get) Token: 0x06007DF4 RID: 32244 RVA: 0x00220434 File Offset: 0x0021E634
		// (set) Token: 0x06007DF5 RID: 32245 RVA: 0x0003B77F File Offset: 0x0003997F
		public unsafe List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025C9 RID: 9673
		// (get) Token: 0x06007DF6 RID: 32246 RVA: 0x00220464 File Offset: 0x0021E664
		// (set) Token: 0x06007DF7 RID: 32247 RVA: 0x0003B79E File Offset: 0x0003999E
		public unsafe int footprintX
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX)) = value;
			}
		}

		// Token: 0x170025CA RID: 9674
		// (get) Token: 0x06007DF8 RID: 32248 RVA: 0x0022048C File Offset: 0x0021E68C
		// (set) Token: 0x06007DF9 RID: 32249 RVA: 0x0003B7B9 File Offset: 0x000399B9
		public unsafe int footprintY
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY)) = value;
			}
		}

		// Token: 0x170025CB RID: 9675
		// (get) Token: 0x06007DFA RID: 32250 RVA: 0x002204B4 File Offset: 0x0021E6B4
		// (set) Token: 0x06007DFB RID: 32251 RVA: 0x0003B7D4 File Offset: 0x000399D4
		public unsafe IStorageEntity _parentStorageEntity_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStorageEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentStorageEntity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CC RID: 9676
		// (get) Token: 0x06007DFC RID: 32252 RVA: 0x002204E4 File Offset: 0x0021E6E4
		// (set) Token: 0x06007DFD RID: 32253 RVA: 0x0003B7F3 File Offset: 0x000399F3
		public unsafe StorageGrid _parentGrid_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CD RID: 9677
		// (get) Token: 0x06007DFE RID: 32254 RVA: 0x00220514 File Offset: 0x0021E714
		// (set) Token: 0x06007DFF RID: 32255 RVA: 0x0003B812 File Offset: 0x00039A12
		public unsafe InteractableObject intObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_intObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CE RID: 9678
		// (get) Token: 0x06007E00 RID: 32256 RVA: 0x00220544 File Offset: 0x0021E744
		// (set) Token: 0x06007E01 RID: 32257 RVA: 0x0003B831 File Offset: 0x00039A31
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025CF RID: 9679
		// (get) Token: 0x06007E02 RID: 32258 RVA: 0x00220574 File Offset: 0x0021E774
		// (set) Token: 0x06007E03 RID: 32259 RVA: 0x0003B850 File Offset: 0x00039A50
		public unsafe float rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170025D0 RID: 9680
		// (get) Token: 0x06007E04 RID: 32260 RVA: 0x0022059C File Offset: 0x0021E79C
		// (set) Token: 0x06007E05 RID: 32261 RVA: 0x0003B86B File Offset: 0x00039A6B
		public unsafe int xSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize)) = value;
			}
		}

		// Token: 0x170025D1 RID: 9681
		// (get) Token: 0x06007E06 RID: 32262 RVA: 0x002205C4 File Offset: 0x0021E7C4
		// (set) Token: 0x06007E07 RID: 32263 RVA: 0x0003B886 File Offset: 0x00039A86
		public unsafe int ySize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize)) = value;
			}
		}

		// Token: 0x170025D2 RID: 9682
		// (get) Token: 0x06007E08 RID: 32264 RVA: 0x002205EC File Offset: 0x0021E7EC
		// (set) Token: 0x06007E09 RID: 32265 RVA: 0x0003B8A1 File Offset: 0x00039AA1
		public unsafe bool _canBePickedUp_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__canBePickedUp_k__BackingField)) = value;
			}
		}

		// Token: 0x170025D3 RID: 9683
		// (get) Token: 0x06007E0A RID: 32266 RVA: 0x00220614 File Offset: 0x0021E814
		// (set) Token: 0x06007E0B RID: 32267 RVA: 0x0003B8BC File Offset: 0x00039ABC
		public unsafe string _noPickupReason_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__noPickupReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040055AA RID: 21930
		private static readonly System.IntPtr NativeFieldInfoPtr__item_k__BackingField;

		// Token: 0x040055AB RID: 21931
		private static readonly System.IntPtr NativeFieldInfoPtr__Destroyed_k__BackingField;

		// Token: 0x040055AC RID: 21932
		private static readonly System.IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x040055AD RID: 21933
		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x040055AE RID: 21934
		private static readonly System.IntPtr NativeFieldInfoPtr_footprintX;

		// Token: 0x040055AF RID: 21935
		private static readonly System.IntPtr NativeFieldInfoPtr_footprintY;

		// Token: 0x040055B0 RID: 21936
		private static readonly System.IntPtr NativeFieldInfoPtr__parentStorageEntity_k__BackingField;

		// Token: 0x040055B1 RID: 21937
		private static readonly System.IntPtr NativeFieldInfoPtr__parentGrid_k__BackingField;

		// Token: 0x040055B2 RID: 21938
		private static readonly System.IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x040055B3 RID: 21939
		private static readonly System.IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x040055B4 RID: 21940
		private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x040055B5 RID: 21941
		private static readonly System.IntPtr NativeFieldInfoPtr_xSize;

		// Token: 0x040055B6 RID: 21942
		private static readonly System.IntPtr NativeFieldInfoPtr_ySize;

		// Token: 0x040055B7 RID: 21943
		private static readonly System.IntPtr NativeFieldInfoPtr__canBePickedUp_k__BackingField;

		// Token: 0x040055B8 RID: 21944
		private static readonly System.IntPtr NativeFieldInfoPtr__noPickupReason_k__BackingField;

		// Token: 0x040055B9 RID: 21945
		private static readonly System.IntPtr NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0;

		// Token: 0x040055BA RID: 21946
		private static readonly System.IntPtr NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0;

		// Token: 0x040055BB RID: 21947
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0;

		// Token: 0x040055BC RID: 21948
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0;

		// Token: 0x040055BD RID: 21949
		private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x040055BE RID: 21950
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x040055BF RID: 21951
		private static readonly System.IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x040055C0 RID: 21952
		private static readonly System.IntPtr NativeMethodInfoPtr_get_parentStorageEntity_Public_get_IStorageEntity_0;

		// Token: 0x040055C1 RID: 21953
		private static readonly System.IntPtr NativeMethodInfoPtr_set_parentStorageEntity_Protected_set_Void_IStorageEntity_0;

		// Token: 0x040055C2 RID: 21954
		private static readonly System.IntPtr NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0;

		// Token: 0x040055C3 RID: 21955
		private static readonly System.IntPtr NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0;

		// Token: 0x040055C4 RID: 21956
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0;

		// Token: 0x040055C5 RID: 21957
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;

		// Token: 0x040055C6 RID: 21958
		private static readonly System.IntPtr NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0;

		// Token: 0x040055C7 RID: 21959
		private static readonly System.IntPtr NativeMethodInfoPtr_get_canBePickedUp_Public_get_Boolean_0;

		// Token: 0x040055C8 RID: 21960
		private static readonly System.IntPtr NativeMethodInfoPtr_set_canBePickedUp_Protected_set_Void_Boolean_0;

		// Token: 0x040055C9 RID: 21961
		private static readonly System.IntPtr NativeMethodInfoPtr_get_noPickupReason_Public_get_String_0;

		// Token: 0x040055CA RID: 21962
		private static readonly System.IntPtr NativeMethodInfoPtr_set_noPickupReason_Protected_set_Void_String_0;

		// Token: 0x040055CB RID: 21963
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040055CC RID: 21964
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;

		// Token: 0x040055CD RID: 21965
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x040055CE RID: 21966
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x040055CF RID: 21967
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeIntObj_Protected_Virtual_New_Void_0;

		// Token: 0x040055D0 RID: 21968
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Internal_Public_Virtual_New_Void_0;

		// Token: 0x040055D1 RID: 21969
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyStoredItem_Public_Void_0;

		// Token: 0x040055D2 RID: 21970
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0;

		// Token: 0x040055D3 RID: 21971
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCanBePickedUp_Public_Void_Boolean_String_0;

		// Token: 0x040055D4 RID: 21972
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;

		// Token: 0x040055D5 RID: 21973
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveReservedItems_Public_Static_List_1_StoredItem_List_1_StoredItem_Employee_0;

		// Token: 0x040055D6 RID: 21974
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_New_GameObject_ItemInstance_Transform_0;

		// Token: 0x040055D7 RID: 21975
		private static readonly System.IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x040055D8 RID: 21976
		private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Void_0;

		// Token: 0x040055D9 RID: 21977
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x040055DA RID: 21978
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x040055DB RID: 21979
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x040055DC RID: 21980
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B00 RID: 2816
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D8CB RID: 55499 RVA: 0x0033E968 File Offset: 0x0033CB68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr);
				StoredItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9");
				StoredItem.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__14_0");
				StoredItem.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__17_0");
				StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100679196);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100679197);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100679198);
			}

			// Token: 0x0600D8CC RID: 55500 RVA: 0x0033EA0C File Offset: 0x0033CC0C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8CD RID: 55501 RVA: 0x0033EA48 File Offset: 0x0033CC48
			[CallerCount(0)]
			public unsafe int _get_FootprintX_b__14_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8CE RID: 55502 RVA: 0x0033EA9C File Offset: 0x0033CC9C
			[CallerCount(0)]
			public unsafe int _get_FootprintY_b__17_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8CF RID: 55503 RVA: 0x000693A2 File Offset: 0x000675A2
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042ED RID: 17133
			// (get) Token: 0x0600D8D0 RID: 55504 RVA: 0x0033EAF0 File Offset: 0x0033CCF0
			// (set) Token: 0x0600D8D1 RID: 55505 RVA: 0x000693AB File Offset: 0x000675AB
			public unsafe static StoredItem.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EE RID: 17134
			// (get) Token: 0x0600D8D2 RID: 55506 RVA: 0x0033EB18 File Offset: 0x0033CD18
			// (set) Token: 0x0600D8D3 RID: 55507 RVA: 0x000693BD File Offset: 0x000675BD
			public unsafe static Il2CppSystem.Func<CoordinateStorageFootprintTilePair, int> __9__14_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EF RID: 17135
			// (get) Token: 0x0600D8D4 RID: 55508 RVA: 0x0033EB40 File Offset: 0x0033CD40
			// (set) Token: 0x0600D8D5 RID: 55509 RVA: 0x000693CF File Offset: 0x000675CF
			public unsafe static Il2CppSystem.Func<CoordinateStorageFootprintTilePair, int> __9__17_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009216 RID: 37398
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009217 RID: 37399
			private static readonly System.IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009218 RID: 37400
			private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04009219 RID: 37401
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400921A RID: 37402
			private static readonly System.IntPtr NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;

			// Token: 0x0400921B RID: 37403
			private static readonly System.IntPtr NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;
		}

		// Token: 0x02000B01 RID: 2817
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c__DisplayClass55_0")]
		public sealed class __c__DisplayClass55_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D8D6 RID: 55510 RVA: 0x0033EB68 File Offset: 0x0033CD68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c__DisplayClass55_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr);
				StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, "allowedReservant");
				StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, 100679199);
				StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr, 100679200);
			}

			// Token: 0x0600D8D7 RID: 55511 RVA: 0x0033EBD0 File Offset: 0x0033CDD0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c__DisplayClass55_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8D8 RID: 55512 RVA: 0x0033EC0C File Offset: 0x0033CE0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240532, XrefRangeEnd = 240539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveReservedItems_b__0(StoredItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c__DisplayClass55_0.NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D8D9 RID: 55513 RVA: 0x000693E1 File Offset: 0x000675E1
			public __c__DisplayClass55_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F0 RID: 17136
			// (get) Token: 0x0600D8DA RID: 55514 RVA: 0x0033EC5C File Offset: 0x0033CE5C
			// (set) Token: 0x0600D8DB RID: 55515 RVA: 0x000693EA File Offset: 0x000675EA
			public unsafe Employee allowedReservant
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.__c__DisplayClass55_0.NativeFieldInfoPtr_allowedReservant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400921C RID: 37404
			private static readonly System.IntPtr NativeFieldInfoPtr_allowedReservant;

			// Token: 0x0400921D RID: 37405
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400921E RID: 37406
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveReservedItems_b__0_Internal_Boolean_StoredItem_0;
		}
	}
}
