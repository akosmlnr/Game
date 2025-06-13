using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x020001AD RID: 429
	public class TileDetector : MonoBehaviour
	{
		// Token: 0x060022A8 RID: 8872 RVA: 0x000DFD7C File Offset: 0x000DDF7C
		// Note: this type is marked as 'beforefieldinit'.
		static TileDetector()
		{
			Il2CppClassPointerStore<TileDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "TileDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDetector>.NativeClassPtr);
			TileDetector.NativeFieldInfoPtr_detectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "detectionRadius");
			TileDetector.NativeFieldInfoPtr_tileDetectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "tileDetectionMode");
			TileDetector.NativeFieldInfoPtr_intersectedTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedTiles");
			TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedOutdoorTiles");
			TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedIndoorTiles");
			TileDetector.NativeFieldInfoPtr_intersectedStorageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedStorageTiles");
			TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedProceduralTiles");
			TileDetector.NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667246);
			TileDetector.NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667247);
			TileDetector.NativeMethodInfoPtr_GetClosestTile_Public_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667248);
			TileDetector.NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667249);
			TileDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667250);
			TileDetector.NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100667251);
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000DFEB0 File Offset: 0x000DE0B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114730, XrefRangeEnd = 114827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections(bool sort = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sort;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileDetector.NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x000DFEFC File Offset: 0x000DE0FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 114833, RefRangeEnd = 114838, XrefRangeStart = 114827, XrefRangeEnd = 114833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.MethodInfoStoreGeneric_OrderList_Public_List_1_T_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x000DFF4C File Offset: 0x000DE14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114838, XrefRangeEnd = 114861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetClosestTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr_GetClosestTile_Public_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x000DFF8C File Offset: 0x000DE18C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114884, RefRangeEnd = 114886, XrefRangeStart = 114861, XrefRangeEnd = 114884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetClosestProceduralTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x000DFFCC File Offset: 0x000DE1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114886, XrefRangeEnd = 114918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileDetector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x000E0008 File Offset: 0x000DE208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114918, XrefRangeEnd = 114927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _OrderList_b__8_0<T>(T x) where T : MonoBehaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = x;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref x;
			}
			ptr2 = intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TileDetector.MethodInfoStoreGeneric__OrderList_b__8_0_Private_Single_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00013397 File Offset: 0x00011597
		public TileDetector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000E008C File Offset: 0x000DE28C
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x000133A0 File Offset: 0x000115A0
		public unsafe float detectionRadius
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_detectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_detectionRadius)) = value;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000E00B4 File Offset: 0x000DE2B4
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x000133BB File Offset: 0x000115BB
		public unsafe ETileDetectionMode tileDetectionMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_tileDetectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_tileDetectionMode)) = value;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000E00DC File Offset: 0x000DE2DC
		// (set) Token: 0x060022B5 RID: 8885 RVA: 0x000133D6 File Offset: 0x000115D6
		public unsafe List<Tile> intersectedTiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedTiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x000E010C File Offset: 0x000DE30C
		// (set) Token: 0x060022B7 RID: 8887 RVA: 0x000133F5 File Offset: 0x000115F5
		public unsafe List<Tile> intersectedOutdoorTiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000E013C File Offset: 0x000DE33C
		// (set) Token: 0x060022B9 RID: 8889 RVA: 0x00013414 File Offset: 0x00011614
		public unsafe List<Tile> intersectedIndoorTiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x000E016C File Offset: 0x000DE36C
		// (set) Token: 0x060022BB RID: 8891 RVA: 0x00013433 File Offset: 0x00011633
		public unsafe List<StorageTile> intersectedStorageTiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedStorageTiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedStorageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x000E019C File Offset: 0x000DE39C
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x00013452 File Offset: 0x00011652
		public unsafe List<ProceduralTile> intersectedProceduralTiles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001715 RID: 5909
		private static readonly System.IntPtr NativeFieldInfoPtr_detectionRadius;

		// Token: 0x04001716 RID: 5910
		private static readonly System.IntPtr NativeFieldInfoPtr_tileDetectionMode;

		// Token: 0x04001717 RID: 5911
		private static readonly System.IntPtr NativeFieldInfoPtr_intersectedTiles;

		// Token: 0x04001718 RID: 5912
		private static readonly System.IntPtr NativeFieldInfoPtr_intersectedOutdoorTiles;

		// Token: 0x04001719 RID: 5913
		private static readonly System.IntPtr NativeFieldInfoPtr_intersectedIndoorTiles;

		// Token: 0x0400171A RID: 5914
		private static readonly System.IntPtr NativeFieldInfoPtr_intersectedStorageTiles;

		// Token: 0x0400171B RID: 5915
		private static readonly System.IntPtr NativeFieldInfoPtr_intersectedProceduralTiles;

		// Token: 0x0400171C RID: 5916
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400171D RID: 5917
		private static readonly System.IntPtr NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0;

		// Token: 0x0400171E RID: 5918
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestTile_Public_Tile_0;

		// Token: 0x0400171F RID: 5919
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0;

		// Token: 0x04001720 RID: 5920
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001721 RID: 5921
		private static readonly System.IntPtr NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0;

		// Token: 0x020008F3 RID: 2291
		private sealed class MethodInfoStoreGeneric_OrderList_Public_List_1_T_List_1_T_0<T>
		{
			// Token: 0x040087B4 RID: 34740
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDetector.NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0, Il2CppClassPointerStore<TileDetector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020008F4 RID: 2292
		private sealed class MethodInfoStoreGeneric__OrderList_b__8_0_Private_Single_T_0<T>
		{
			// Token: 0x040087B5 RID: 34741
			internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDetector.NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0, Il2CppClassPointerStore<TileDetector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
