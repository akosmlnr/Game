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
	// Token: 0x020002AE RID: 686
	[System.Serializable]
	public class BrickPressData : GridItemData
	{
		// Token: 0x060031B9 RID: 12729 RVA: 0x00112098 File Offset: 0x00110298
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressData()
		{
			Il2CppClassPointerStore<BrickPressData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BrickPressData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr);
			BrickPressData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr, "Contents");
			BrickPressData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr, 100669052);
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x001120F0 File Offset: 0x001102F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136895, RefRangeEnd = 136901, XrefRangeStart = 136887, XrefRangeEnd = 136895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressData>.NativeClassPtr))
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x0001A2FA File Offset: 0x000184FA
		public BrickPressData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x0011219C File Offset: 0x0011039C
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x0001A303 File Offset: 0x00018503
		public unsafe ItemSet Contents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressData.NativeFieldInfoPtr_Contents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400208F RID: 8335
		private static readonly System.IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x04002090 RID: 8336
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0;
	}
}
