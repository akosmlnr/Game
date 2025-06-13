using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001A9 RID: 425
	[System.Serializable]
	public class Tile : MonoBehaviour
	{
		// Token: 0x0600227A RID: 8826 RVA: 0x000DF47C File Offset: 0x000DD67C
		// Note: this type is marked as 'beforefieldinit'.
		static Tile()
		{
			Il2CppClassPointerStore<Tile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Tile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tile>.NativeClassPtr);
			Tile.NativeFieldInfoPtr_TileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "TileSize");
			Tile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "x");
			Tile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "y");
			Tile.NativeFieldInfoPtr_AvailableOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "AvailableOffset");
			Tile.NativeFieldInfoPtr_OwnerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "OwnerGrid");
			Tile.NativeFieldInfoPtr_LightExposureNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "LightExposureNode");
			Tile.NativeFieldInfoPtr_BuildableOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "BuildableOccupants");
			Tile.NativeFieldInfoPtr_ConstructableOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "ConstructableOccupants");
			Tile.NativeFieldInfoPtr_OccupantTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "OccupantTiles");
			Tile.NativeFieldInfoPtr_onTileChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "onTileChanged");
			Tile.NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667227);
			Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667228);
			Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_Constructable_GridBased_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667229);
			Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667230);
			Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_Constructable_GridBased_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667231);
			Tile.NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667232);
			Tile.NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667233);
			Tile.NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667234);
			Tile.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667235);
			Tile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100667236);
		}

		// Token: 0x0600227B RID: 8827 RVA: 0x000DF63C File Offset: 0x000DD83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114597, XrefRangeEnd = 114598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _y;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600227C RID: 8828 RVA: 0x000DF6AC File Offset: 0x000DD8AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114598, XrefRangeEnd = 114614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(GridItem occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600227D RID: 8829 RVA: 0x000DF700 File Offset: 0x000DD900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114614, XrefRangeEnd = 114630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_Constructable_GridBased_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600227E RID: 8830 RVA: 0x000DF754 File Offset: 0x000DD954
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114636, RefRangeEnd = 114638, XrefRangeStart = 114630, XrefRangeEnd = 114636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x000DF7A8 File Offset: 0x000DD9A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114644, RefRangeEnd = 114646, XrefRangeStart = 114638, XrefRangeEnd = 114644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(Constructable_GridBased occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_Constructable_GridBased_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x000DF7FC File Offset: 0x000DD9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114646, XrefRangeEnd = 114655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeBuiltOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x000DF844 File Offset: 0x000DDA44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 114679, RefRangeEnd = 114680, XrefRangeStart = 114655, XrefRangeEnd = 114679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetSurroundingTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000DF884 File Offset: 0x000DDA84
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsIndoorTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x000DF8CC File Offset: 0x000DDACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114680, XrefRangeEnd = 114689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref vis;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002284 RID: 8836 RVA: 0x000DF90C File Offset: 0x000DDB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114689, XrefRangeEnd = 114711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x000131F0 File Offset: 0x000113F0
		public Tile(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x000DF948 File Offset: 0x000DDB48
		// (set) Token: 0x06002287 RID: 8839 RVA: 0x000131F9 File Offset: 0x000113F9
		public unsafe static float TileSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Tile.NativeFieldInfoPtr_TileSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Tile.NativeFieldInfoPtr_TileSize, (void*)(&value));
			}
		}

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x000DF964 File Offset: 0x000DDB64
		// (set) Token: 0x06002289 RID: 8841 RVA: 0x00013207 File Offset: 0x00011407
		public unsafe int x
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x000DF98C File Offset: 0x000DDB8C
		// (set) Token: 0x0600228B RID: 8843 RVA: 0x00013222 File Offset: 0x00011422
		public unsafe int y
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x000DF9B4 File Offset: 0x000DDBB4
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x0001323D File Offset: 0x0001143D
		public unsafe float AvailableOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_AvailableOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_AvailableOffset)) = value;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x000DF9DC File Offset: 0x000DDBDC
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x00013258 File Offset: 0x00011458
		public unsafe Grid OwnerGrid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OwnerGrid);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OwnerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x000DFA0C File Offset: 0x000DDC0C
		// (set) Token: 0x06002291 RID: 8849 RVA: 0x00013277 File Offset: 0x00011477
		public unsafe LightExposureNode LightExposureNode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_LightExposureNode);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightExposureNode>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_LightExposureNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x000DFA3C File Offset: 0x000DDC3C
		// (set) Token: 0x06002293 RID: 8851 RVA: 0x00013296 File Offset: 0x00011496
		public unsafe List<GridItem> BuildableOccupants
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_BuildableOccupants);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GridItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_BuildableOccupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002294 RID: 8852 RVA: 0x000DFA6C File Offset: 0x000DDC6C
		// (set) Token: 0x06002295 RID: 8853 RVA: 0x000132B5 File Offset: 0x000114B5
		public unsafe List<Constructable_GridBased> ConstructableOccupants
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_ConstructableOccupants);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Constructable_GridBased>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_ConstructableOccupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x000DFA9C File Offset: 0x000DDC9C
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x000132D4 File Offset: 0x000114D4
		public unsafe List<FootprintTile> OccupantTiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OccupantTiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OccupantTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x000DFACC File Offset: 0x000DDCCC
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x000132F3 File Offset: 0x000114F3
		public unsafe Tile.TileChange onTileChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile.TileChange>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016EF RID: 5871
		private static readonly System.IntPtr NativeFieldInfoPtr_TileSize;

		// Token: 0x040016F0 RID: 5872
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040016F1 RID: 5873
		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040016F2 RID: 5874
		private static readonly System.IntPtr NativeFieldInfoPtr_AvailableOffset;

		// Token: 0x040016F3 RID: 5875
		private static readonly System.IntPtr NativeFieldInfoPtr_OwnerGrid;

		// Token: 0x040016F4 RID: 5876
		private static readonly System.IntPtr NativeFieldInfoPtr_LightExposureNode;

		// Token: 0x040016F5 RID: 5877
		private static readonly System.IntPtr NativeFieldInfoPtr_BuildableOccupants;

		// Token: 0x040016F6 RID: 5878
		private static readonly System.IntPtr NativeFieldInfoPtr_ConstructableOccupants;

		// Token: 0x040016F7 RID: 5879
		private static readonly System.IntPtr NativeFieldInfoPtr_OccupantTiles;

		// Token: 0x040016F8 RID: 5880
		private static readonly System.IntPtr NativeFieldInfoPtr_onTileChanged;

		// Token: 0x040016F9 RID: 5881
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0;

		// Token: 0x040016FA RID: 5882
		private static readonly System.IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0;

		// Token: 0x040016FB RID: 5883
		private static readonly System.IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_Constructable_GridBased_FootprintTile_0;

		// Token: 0x040016FC RID: 5884
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0;

		// Token: 0x040016FD RID: 5885
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_Constructable_GridBased_FootprintTile_0;

		// Token: 0x040016FE RID: 5886
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0;

		// Token: 0x040016FF RID: 5887
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0;

		// Token: 0x04001700 RID: 5888
		private static readonly System.IntPtr NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0;

		// Token: 0x04001701 RID: 5889
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04001702 RID: 5890
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008F2 RID: 2290
		public sealed class TileChange : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600C7F6 RID: 51190 RVA: 0x0030EAB0 File Offset: 0x0030CCB0
			// Note: this type is marked as 'beforefieldinit'.
			static TileChange()
			{
				Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tile>.NativeClassPtr, "TileChange");
				Tile.TileChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667238);
				Tile.TileChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667239);
				Tile.TileChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667240);
				Tile.TileChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100667241);
			}

			// Token: 0x0600C7F7 RID: 51191 RVA: 0x0030EB24 File Offset: 0x0030CD24
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 110018, RefRangeEnd = 110108, XrefRangeStart = 110018, XrefRangeEnd = 110108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TileChange(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7F8 RID: 51192 RVA: 0x0030EB80 File Offset: 0x0030CD80
			[CallerCount(0)]
			public unsafe void Invoke(Tile thisTile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisTile);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7F9 RID: 51193 RVA: 0x0030EBC4 File Offset: 0x0030CDC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Tile thisTile, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisTile);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600C7FA RID: 51194 RVA: 0x0030EC38 File Offset: 0x0030CE38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7FB RID: 51195 RVA: 0x00060FCF File Offset: 0x0005F1CF
			public TileChange(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C7FC RID: 51196 RVA: 0x00060FD8 File Offset: 0x0005F1D8
			public static implicit operator Tile.TileChange(System.Action<Tile> A_0)
			{
				return DelegateSupport.ConvertDelegate<Tile.TileChange>(A_0);
			}

			// Token: 0x0600C7FD RID: 51197 RVA: 0x00060FE0 File Offset: 0x0005F1E0
			public static Tile.TileChange operator +(Tile.TileChange A_0, Tile.TileChange A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Tile.TileChange>();
			}

			// Token: 0x0600C7FE RID: 51198 RVA: 0x00060FEE File Offset: 0x0005F1EE
			public static Tile.TileChange operator -(Tile.TileChange A_0, Tile.TileChange A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Tile.TileChange>();
				}
				return result;
			}

			// Token: 0x040087B0 RID: 34736
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040087B1 RID: 34737
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0;

			// Token: 0x040087B2 RID: 34738
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0;

			// Token: 0x040087B3 RID: 34739
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
