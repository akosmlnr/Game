using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B3 RID: 691
	[System.Serializable]
	public class GridItemData : BuildableItemData
	{
		// Token: 0x060031EE RID: 12782 RVA: 0x00112A88 File Offset: 0x00110C88
		// Note: this type is marked as 'beforefieldinit'.
		static GridItemData()
		{
			Il2CppClassPointerStore<GridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItemData>.NativeClassPtr);
			GridItemData.NativeFieldInfoPtr_GridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "GridGUID");
			GridItemData.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "OriginCoordinate");
			GridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "Rotation");
			GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, 100669057);
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00112B08 File Offset: 0x00110D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136943, RefRangeEnd = 136944, XrefRangeStart = 136937, XrefRangeEnd = 136943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItemData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x0001A558 File Offset: 0x00018758
		public GridItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x060031F1 RID: 12785 RVA: 0x00112BA0 File Offset: 0x00110DA0
		// (set) Token: 0x060031F2 RID: 12786 RVA: 0x0001A561 File Offset: 0x00018761
		public unsafe string GridGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x060031F3 RID: 12787 RVA: 0x00112BC8 File Offset: 0x00110DC8
		// (set) Token: 0x060031F4 RID: 12788 RVA: 0x0001A580 File Offset: 0x00018780
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x060031F5 RID: 12789 RVA: 0x00112BF0 File Offset: 0x00110DF0
		// (set) Token: 0x060031F6 RID: 12790 RVA: 0x0001A59B File Offset: 0x0001879B
		public unsafe int Rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x040020A7 RID: 8359
		private static readonly System.IntPtr NativeFieldInfoPtr_GridGUID;

		// Token: 0x040020A8 RID: 8360
		private static readonly System.IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x040020A9 RID: 8361
		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x040020AA RID: 8362
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0;
	}
}
