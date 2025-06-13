using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002B7 RID: 695
	public class MixingStationData : GridItemData
	{
		// Token: 0x06003212 RID: 12818 RVA: 0x00113184 File Offset: 0x00111384
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationData()
		{
			Il2CppClassPointerStore<MixingStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr);
			MixingStationData.NativeFieldInfoPtr_ProductContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "ProductContents");
			MixingStationData.NativeFieldInfoPtr_MixerContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "MixerContents");
			MixingStationData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "OutputContents");
			MixingStationData.NativeFieldInfoPtr_CurrentMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "CurrentMixOperation");
			MixingStationData.NativeFieldInfoPtr_CurrentMixTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "CurrentMixTime");
			MixingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, 100669061);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x0011322C File Offset: 0x0011142C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 136974, RefRangeEnd = 136976, XrefRangeStart = 136964, XrefRangeEnd = 136974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet productContents, ItemSet mixerContents, ItemSet outputContents, MixOperation currentMixOperation, int currentMixTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productContents);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixerContents);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentMixOperation);
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref currentMixTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x0001A6DC File Offset: 0x000188DC
		public MixingStationData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x00113320 File Offset: 0x00111520
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0001A6E5 File Offset: 0x000188E5
		public unsafe ItemSet ProductContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_ProductContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_ProductContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x00113350 File Offset: 0x00111550
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x0001A704 File Offset: 0x00018904
		public unsafe ItemSet MixerContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_MixerContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_MixerContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x06003219 RID: 12825 RVA: 0x00113380 File Offset: 0x00111580
		// (set) Token: 0x0600321A RID: 12826 RVA: 0x0001A723 File Offset: 0x00018923
		public unsafe ItemSet OutputContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_OutputContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x001133B0 File Offset: 0x001115B0
		// (set) Token: 0x0600321C RID: 12828 RVA: 0x0001A742 File Offset: 0x00018942
		public unsafe MixOperation CurrentMixOperation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixOperation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixOperation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600321D RID: 12829 RVA: 0x001133E0 File Offset: 0x001115E0
		// (set) Token: 0x0600321E RID: 12830 RVA: 0x0001A761 File Offset: 0x00018961
		public unsafe int CurrentMixTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixTime)) = value;
			}
		}

		// Token: 0x040020B7 RID: 8375
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductContents;

		// Token: 0x040020B8 RID: 8376
		private static readonly System.IntPtr NativeFieldInfoPtr_MixerContents;

		// Token: 0x040020B9 RID: 8377
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x040020BA RID: 8378
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMixOperation;

		// Token: 0x040020BB RID: 8379
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMixTime;

		// Token: 0x040020BC RID: 8380
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0;
	}
}
