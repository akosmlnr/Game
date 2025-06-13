using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004E4 RID: 1252
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x06006CB1 RID: 27825 RVA: 0x001E6FB8 File Offset: 0x001E51B8
		// Note: this type is marked as 'beforefieldinit'.
		static CornerObstacle()
		{
			Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "CornerObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr);
			CornerObstacle.NativeFieldInfoPtr_obstacleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "obstacleEnabled");
			CornerObstacle.NativeFieldInfoPtr_parentFootprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "parentFootprint");
			CornerObstacle.NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "coordinates");
			CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100677170);
			CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100677171);
			CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100677172);
		}

		// Token: 0x06006CB2 RID: 27826 RVA: 0x001E7060 File Offset: 0x001E5260
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219518, RefRangeEnd = 219520, XrefRangeStart = 219488, XrefRangeEnd = 219518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairedTile);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
		}

		// Token: 0x06006CB3 RID: 27827 RVA: 0x001E70B0 File Offset: 0x001E52B0
		[CallerCount(0)]
		public unsafe bool ApproxEquals(float a, float b, float precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006CB4 RID: 27828 RVA: 0x001E7118 File Offset: 0x001E5318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219520, XrefRangeEnd = 219523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CornerObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CB5 RID: 27829 RVA: 0x00033266 File Offset: 0x00031466
		public CornerObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700206D RID: 8301
		// (get) Token: 0x06006CB6 RID: 27830 RVA: 0x001E7154 File Offset: 0x001E5354
		// (set) Token: 0x06006CB7 RID: 27831 RVA: 0x0003326F File Offset: 0x0003146F
		public unsafe bool obstacleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled)) = value;
			}
		}

		// Token: 0x1700206E RID: 8302
		// (get) Token: 0x06006CB8 RID: 27832 RVA: 0x001E717C File Offset: 0x001E537C
		// (set) Token: 0x06006CB9 RID: 27833 RVA: 0x0003328A File Offset: 0x0003148A
		public unsafe FootprintTile parentFootprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700206F RID: 8303
		// (get) Token: 0x06006CBA RID: 27834 RVA: 0x001E71AC File Offset: 0x001E53AC
		// (set) Token: 0x06006CBB RID: 27835 RVA: 0x000332A9 File Offset: 0x000314A9
		public unsafe Vector2 coordinates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates)) = value;
			}
		}

		// Token: 0x04004A66 RID: 19046
		private static readonly IntPtr NativeFieldInfoPtr_obstacleEnabled;

		// Token: 0x04004A67 RID: 19047
		private static readonly IntPtr NativeFieldInfoPtr_parentFootprint;

		// Token: 0x04004A68 RID: 19048
		private static readonly IntPtr NativeFieldInfoPtr_coordinates;

		// Token: 0x04004A69 RID: 19049
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0;

		// Token: 0x04004A6A RID: 19050
		private static readonly IntPtr NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0;

		// Token: 0x04004A6B RID: 19051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
