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
	// Token: 0x020002C1 RID: 705
	public class TrashContainerData : GridItemData
	{
		// Token: 0x0600325C RID: 12892 RVA: 0x001140B0 File Offset: 0x001122B0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerData()
		{
			Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashContainerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr);
			TrashContainerData.NativeFieldInfoPtr_ContentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr, "ContentData");
			TrashContainerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr, 100669071);
		}

		// Token: 0x0600325D RID: 12893 RVA: 0x00114108 File Offset: 0x00112308
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136895, RefRangeEnd = 136901, XrefRangeStart = 136895, XrefRangeEnd = 136901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, TrashContentData contentData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x0001A9BC File Offset: 0x00018BBC
		public TrashContainerData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600325F RID: 12895 RVA: 0x001141B4 File Offset: 0x001123B4
		// (set) Token: 0x06003260 RID: 12896 RVA: 0x0001A9C5 File Offset: 0x00018BC5
		public unsafe TrashContentData ContentData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerData.NativeFieldInfoPtr_ContentData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerData.NativeFieldInfoPtr_ContentData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020D7 RID: 8407
		private static readonly System.IntPtr NativeFieldInfoPtr_ContentData;

		// Token: 0x040020D8 RID: 8408
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_TrashContentData_0;
	}
}
