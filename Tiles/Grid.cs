using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A6 RID: 422
	public class Grid : MonoBehaviour
	{
		// Token: 0x06002246 RID: 8774 RVA: 0x000DE9E8 File Offset: 0x000DCBE8
		// Note: this type is marked as 'beforefieldinit'.
		static Grid()
		{
			Il2CppClassPointerStore<Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grid>.NativeClassPtr);
			Grid.NativeFieldInfoPtr_GridSideLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "GridSideLength");
			Grid.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "Tiles");
			Grid.NativeFieldInfoPtr_CoordinateTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "CoordinateTilePairs");
			Grid.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "Container");
			Grid.NativeFieldInfoPtr_IsStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "IsStatic");
			Grid.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "StaticGUID");
			Grid.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<GUID>k__BackingField");
			Grid.NativeFieldInfoPtr__coordinateToTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_coordinateToTile");
			Grid.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667204);
			Grid.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667205);
			Grid.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667206);
			Grid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667207);
			Grid.NativeMethodInfoPtr_DestroyGrid_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667208);
			Grid.NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667209);
			Grid.NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667210);
			Grid.NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667211);
			Grid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667212);
			Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667213);
			Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667214);
			Grid.NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667215);
			Grid.NativeMethodInfoPtr_SetVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667216);
			Grid.NativeMethodInfoPtr_SetInvisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667217);
			Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100667218);
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x000DEBE4 File Offset: 0x000DCDE4
		// (set) Token: 0x06002248 RID: 8776 RVA: 0x000DEC20 File Offset: 0x000DCE20
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x000DEC60 File Offset: 0x000DCE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114282, XrefRangeEnd = 114286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x000DECA0 File Offset: 0x000DCEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114286, XrefRangeEnd = 114326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Grid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x000DECDC File Offset: 0x000DCEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114326, XrefRangeEnd = 114330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Grid.NativeMethodInfoPtr_DestroyGrid_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x000DED18 File Offset: 0x000DCF18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114347, RefRangeEnd = 114348, XrefRangeStart = 114330, XrefRangeEnd = 114347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoordinateDataPairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x000DED4C File Offset: 0x000DCF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114348, XrefRangeEnd = 114362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(Tile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x000DED90 File Offset: 0x000DCF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114362, XrefRangeEnd = 114388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(Tile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x000DEDD4 File Offset: 0x000DCFD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 114403, RefRangeEnd = 114406, XrefRangeStart = 114388, XrefRangeEnd = 114403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x000DEE24 File Offset: 0x000DD024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114418, RefRangeEnd = 114419, XrefRangeStart = 114406, XrefRangeEnd = 114418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, GridItem tileOwner = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileOwner);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x000DEE98 File Offset: 0x000DD098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114435, RefRangeEnd = 114436, XrefRangeStart = 114419, XrefRangeEnd = 114435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, Constructable_GridBased ignoreConstructable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreConstructable);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_Constructable_GridBased_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x000DEF0C File Offset: 0x000DD10C
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 114450, RefRangeEnd = 114481, XrefRangeStart = 114436, XrefRangeEnd = 114450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x000DEF5C File Offset: 0x000DD15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114481, XrefRangeEnd = 114492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x000DEF90 File Offset: 0x000DD190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114492, XrefRangeEnd = 114503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetInvisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x000DEFC4 File Offset: 0x000DD1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114503, XrefRangeEnd = 114528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grid>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00013026 File Offset: 0x00011226
		public Grid(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002257 RID: 8791 RVA: 0x000DF000 File Offset: 0x000DD200
		// (set) Token: 0x06002258 RID: 8792 RVA: 0x0001302F File Offset: 0x0001122F
		public unsafe static float GridSideLength
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Grid.NativeFieldInfoPtr_GridSideLength, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Grid.NativeFieldInfoPtr_GridSideLength, (void*)(&value));
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x000DF01C File Offset: 0x000DD21C
		// (set) Token: 0x0600225A RID: 8794 RVA: 0x0001303D File Offset: 0x0001123D
		public unsafe List<Tile> Tiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Tiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600225B RID: 8795 RVA: 0x000DF04C File Offset: 0x000DD24C
		// (set) Token: 0x0600225C RID: 8796 RVA: 0x0001305C File Offset: 0x0001125C
		public unsafe List<CoordinateTilePair> CoordinateTilePairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_CoordinateTilePairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateTilePair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_CoordinateTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600225D RID: 8797 RVA: 0x000DF07C File Offset: 0x000DD27C
		// (set) Token: 0x0600225E RID: 8798 RVA: 0x0001307B File Offset: 0x0001127B
		public unsafe Transform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600225F RID: 8799 RVA: 0x000DF0AC File Offset: 0x000DD2AC
		// (set) Token: 0x06002260 RID: 8800 RVA: 0x0001309A File Offset: 0x0001129A
		public unsafe bool IsStatic
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_IsStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_IsStatic)) = value;
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x06002261 RID: 8801 RVA: 0x000DF0D4 File Offset: 0x000DD2D4
		// (set) Token: 0x06002262 RID: 8802 RVA: 0x000130B5 File Offset: 0x000112B5
		public unsafe string StaticGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x06002263 RID: 8803 RVA: 0x000DF0FC File Offset: 0x000DD2FC
		// (set) Token: 0x06002264 RID: 8804 RVA: 0x000130D4 File Offset: 0x000112D4
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x000DF124 File Offset: 0x000DD324
		// (set) Token: 0x06002266 RID: 8806 RVA: 0x000130EF File Offset: 0x000112EF
		public unsafe Dictionary<Coordinate, Tile> _coordinateToTile
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__coordinateToTile);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Coordinate, Tile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__coordinateToTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016CE RID: 5838
		private static readonly System.IntPtr NativeFieldInfoPtr_GridSideLength;

		// Token: 0x040016CF RID: 5839
		private static readonly System.IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x040016D0 RID: 5840
		private static readonly System.IntPtr NativeFieldInfoPtr_CoordinateTilePairs;

		// Token: 0x040016D1 RID: 5841
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040016D2 RID: 5842
		private static readonly System.IntPtr NativeFieldInfoPtr_IsStatic;

		// Token: 0x040016D3 RID: 5843
		private static readonly System.IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x040016D4 RID: 5844
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x040016D5 RID: 5845
		private static readonly System.IntPtr NativeFieldInfoPtr__coordinateToTile;

		// Token: 0x040016D6 RID: 5846
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040016DA RID: 5850
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyGrid_Public_Virtual_New_Void_0;

		// Token: 0x040016DB RID: 5851
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0;

		// Token: 0x040016DC RID: 5852
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0;

		// Token: 0x040016DD RID: 5853
		private static readonly System.IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0;

		// Token: 0x040016DE RID: 5854
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x040016DF RID: 5855
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly System.IntPtr NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_Constructable_GridBased_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly System.IntPtr NativeMethodInfoPtr_SetInvisible_Public_Void_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008F0 RID: 2288
		[ObfuscatedName("ScheduleOne.Tiles.Grid+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C7F0 RID: 51184 RVA: 0x0030E988 File Offset: 0x0030CB88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr);
				Grid.__c__DisplayClass20_0.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr, "coord");
				Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr, 100667220);
				Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__GetTile_b__0_Internal_Boolean_CoordinateTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr, 100667221);
			}

			// Token: 0x0600C7F1 RID: 51185 RVA: 0x0030E9F0 File Offset: 0x0030CBF0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grid.__c__DisplayClass20_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7F2 RID: 51186 RVA: 0x0030EA2C File Offset: 0x0030CC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114281, XrefRangeEnd = 114282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTile_b__0(CoordinateTilePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Grid.__c__DisplayClass20_0.NativeMethodInfoPtr__GetTile_b__0_Internal_Boolean_CoordinateTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C7F3 RID: 51187 RVA: 0x00060FA7 File Offset: 0x0005F1A7
			public __c__DisplayClass20_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E28 RID: 15912
			// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x0030EA80 File Offset: 0x0030CC80
			// (set) Token: 0x0600C7F5 RID: 51189 RVA: 0x00060FB0 File Offset: 0x0005F1B0
			public unsafe Coordinate coord
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.__c__DisplayClass20_0.NativeFieldInfoPtr_coord);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.__c__DisplayClass20_0.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087AB RID: 34731
			private static readonly System.IntPtr NativeFieldInfoPtr_coord;

			// Token: 0x040087AC RID: 34732
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087AD RID: 34733
			private static readonly System.IntPtr NativeMethodInfoPtr__GetTile_b__0_Internal_Boolean_CoordinateTilePair_0;
		}
	}
}
