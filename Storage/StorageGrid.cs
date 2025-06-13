using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200059B RID: 1435
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x06007D52 RID: 32082 RVA: 0x0021DCB4 File Offset: 0x0021BEB4
		// Note: this type is marked as 'beforefieldinit'.
		static StorageGrid()
		{
			Il2CppClassPointerStore<StorageGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr);
			StorageGrid.NativeFieldInfoPtr_gridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "gridSize");
			StorageGrid.NativeFieldInfoPtr_storageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "storageTiles");
			StorageGrid.NativeFieldInfoPtr_freeTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "freeTiles");
			StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateStorageTilePairs");
			StorageGrid.NativeFieldInfoPtr_coordinateToTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateToTile");
			StorageGrid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679107);
			StorageGrid.NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679108);
			StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679109);
			StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679110);
			StorageGrid.NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679111);
			StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679112);
			StorageGrid.NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679113);
			StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679114);
			StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679115);
			StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679116);
			StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679117);
			StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679118);
			StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679119);
			StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100679120);
		}

		// Token: 0x06007D53 RID: 32083 RVA: 0x0021DE60 File Offset: 0x0021C060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239802, XrefRangeEnd = 239807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageGrid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D54 RID: 32084 RVA: 0x0021DE9C File Offset: 0x0021C09C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239824, RefRangeEnd = 239825, XrefRangeStart = 239807, XrefRangeEnd = 239824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoordinateTilePairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D55 RID: 32085 RVA: 0x0021DED0 File Offset: 0x0021C0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239825, XrefRangeEnd = 239839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D56 RID: 32086 RVA: 0x0021DF14 File Offset: 0x0021C114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239839, XrefRangeEnd = 239854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D57 RID: 32087 RVA: 0x0021DF58 File Offset: 0x0021C158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239889, RefRangeEnd = 239890, XrefRangeStart = 239854, XrefRangeEnd = 239889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsItemPositionValid(StorageTile primaryTile, FootprintTile primaryFootprintTile, StoredItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primaryTile);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(primaryFootprintTile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D58 RID: 32088 RVA: 0x0021DFCC File Offset: 0x0021C1CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239905, RefRangeEnd = 239906, XrefRangeStart = 239890, XrefRangeEnd = 239905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
		}

		// Token: 0x06007D59 RID: 32089 RVA: 0x0021E01C File Offset: 0x0021C21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 239916, RefRangeEnd = 239917, XrefRangeStart = 239906, XrefRangeEnd = 239916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGridPositionValid(Coordinate gridCoord, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D5A RID: 32090 RVA: 0x0021E07C File Offset: 0x0021C27C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 239924, RefRangeEnd = 239936, XrefRangeStart = 239917, XrefRangeEnd = 239924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
		}

		// Token: 0x06007D5B RID: 32091 RVA: 0x0021E0CC File Offset: 0x0021C2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239936, XrefRangeEnd = 239938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUserEndCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x0021E108 File Offset: 0x0021C308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 239943, RefRangeEnd = 239945, XrefRangeStart = 239938, XrefRangeEnd = 239943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x0021E144 File Offset: 0x0021C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239945, XrefRangeEnd = 239947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D5E RID: 32094 RVA: 0x0021E180 File Offset: 0x0021C380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239947, XrefRangeEnd = 239948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalFootprintSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D5F RID: 32095 RVA: 0x0021E1BC File Offset: 0x0021C3BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239999, RefRangeEnd = 240002, XrefRangeStart = 239948, XrefRangeEnd = 239999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockedCoordinates);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			originCoordinate = ((intPtr2 == 0) ? null : new Coordinate(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007D60 RID: 32096 RVA: 0x0021E258 File Offset: 0x0021C458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240002, XrefRangeEnd = 240029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007D61 RID: 32097 RVA: 0x0003B38C File Offset: 0x0003958C
		public StorageGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06007D62 RID: 32098 RVA: 0x0021E294 File Offset: 0x0021C494
		// (set) Token: 0x06007D63 RID: 32099 RVA: 0x0003B395 File Offset: 0x00039595
		public unsafe static float gridSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&value));
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06007D64 RID: 32100 RVA: 0x0021E2B0 File Offset: 0x0021C4B0
		// (set) Token: 0x06007D65 RID: 32101 RVA: 0x0003B3A3 File Offset: 0x000395A3
		public unsafe List<StorageTile> storageTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06007D66 RID: 32102 RVA: 0x0021E2E0 File Offset: 0x0021C4E0
		// (set) Token: 0x06007D67 RID: 32103 RVA: 0x0003B3C2 File Offset: 0x000395C2
		public unsafe List<StorageTile> freeTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_freeTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_freeTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06007D68 RID: 32104 RVA: 0x0021E310 File Offset: 0x0021C510
		// (set) Token: 0x06007D69 RID: 32105 RVA: 0x0003B3E1 File Offset: 0x000395E1
		public unsafe List<CoordinateStorageTilePair> coordinateStorageTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06007D6A RID: 32106 RVA: 0x0021E340 File Offset: 0x0021C540
		// (set) Token: 0x06007D6B RID: 32107 RVA: 0x0003B400 File Offset: 0x00039600
		public unsafe Dictionary<Coordinate, StorageTile> coordinateToTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateToTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Coordinate, StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateToTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400555C RID: 21852
		private static readonly IntPtr NativeFieldInfoPtr_gridSize;

		// Token: 0x0400555D RID: 21853
		private static readonly IntPtr NativeFieldInfoPtr_storageTiles;

		// Token: 0x0400555E RID: 21854
		private static readonly IntPtr NativeFieldInfoPtr_freeTiles;

		// Token: 0x0400555F RID: 21855
		private static readonly IntPtr NativeFieldInfoPtr_coordinateStorageTilePairs;

		// Token: 0x04005560 RID: 21856
		private static readonly IntPtr NativeFieldInfoPtr_coordinateToTile;

		// Token: 0x04005561 RID: 21857
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005562 RID: 21858
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCoordinateTilePairs_Private_Void_0;

		// Token: 0x04005563 RID: 21859
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0;

		// Token: 0x04005564 RID: 21860
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0;

		// Token: 0x04005565 RID: 21861
		private static readonly IntPtr NativeMethodInfoPtr_IsItemPositionValid_Public_Boolean_StorageTile_FootprintTile_StoredItem_0;

		// Token: 0x04005566 RID: 21862
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x04005567 RID: 21863
		private static readonly IntPtr NativeMethodInfoPtr_IsGridPositionValid_Public_Boolean_Coordinate_FootprintTile_0;

		// Token: 0x04005568 RID: 21864
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0;

		// Token: 0x04005569 RID: 21865
		private static readonly IntPtr NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0;

		// Token: 0x0400556A RID: 21866
		private static readonly IntPtr NativeMethodInfoPtr_GetActualY_Public_Int32_0;

		// Token: 0x0400556B RID: 21867
		private static readonly IntPtr NativeMethodInfoPtr_GetActualX_Public_Int32_0;

		// Token: 0x0400556C RID: 21868
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0;

		// Token: 0x0400556D RID: 21869
		private static readonly IntPtr NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0;

		// Token: 0x0400556E RID: 21870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
