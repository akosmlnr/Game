using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B9 RID: 697
	[System.Serializable]
	public class PlaceableStorageData : GridItemData
	{
		// Token: 0x06003224 RID: 12836 RVA: 0x0011353C File Offset: 0x0011173C
		// Note: this type is marked as 'beforefieldinit'.
		static PlaceableStorageData()
		{
			Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlaceableStorageData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr);
			PlaceableStorageData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr, "Contents");
			PlaceableStorageData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr, 100669063);
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00113594 File Offset: 0x00111794
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136895, RefRangeEnd = 136901, XrefRangeStart = 136895, XrefRangeEnd = 136901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaceableStorageData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceableStorageData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceableStorageData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x0001A7A4 File Offset: 0x000189A4
		public PlaceableStorageData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x06003227 RID: 12839 RVA: 0x00113640 File Offset: 0x00111840
		// (set) Token: 0x06003228 RID: 12840 RVA: 0x0001A7AD File Offset: 0x000189AD
		public unsafe ItemSet Contents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageData.NativeFieldInfoPtr_Contents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceableStorageData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020BF RID: 8383
		private static readonly System.IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x040020C0 RID: 8384
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0;
	}
}
