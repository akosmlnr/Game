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
	// Token: 0x020002B0 RID: 688
	public class CauldronData : GridItemData
	{
		// Token: 0x060031C7 RID: 12743 RVA: 0x0011232C File Offset: 0x0011052C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronData()
		{
			Il2CppClassPointerStore<CauldronData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronData>.NativeClassPtr);
			CauldronData.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Ingredients");
			CauldronData.NativeFieldInfoPtr_Liquid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Liquid");
			CauldronData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "Output");
			CauldronData.NativeFieldInfoPtr_RemainingCookTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "RemainingCookTime");
			CauldronData.NativeFieldInfoPtr_InputQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, "InputQuality");
			CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronData>.NativeClassPtr, 100669054);
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x001123D4 File Offset: 0x001105D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136915, RefRangeEnd = 136916, XrefRangeStart = 136906, XrefRangeEnd = 136915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet ingredients, ItemSet liquid, ItemSet output, int remainingCookTime, EQuality inputQuality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(liquid);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref remainingCookTime;
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref inputQuality;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x0001A384 File Offset: 0x00018584
		public CauldronData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x001124C4 File Offset: 0x001106C4
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x0001A38D File Offset: 0x0001858D
		public unsafe ItemSet Ingredients
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x001124F4 File Offset: 0x001106F4
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x0001A3AC File Offset: 0x000185AC
		public unsafe ItemSet Liquid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Liquid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x00112524 File Offset: 0x00110724
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x0001A3CB File Offset: 0x000185CB
		public unsafe ItemSet Output
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x00112554 File Offset: 0x00110754
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0001A3EA File Offset: 0x000185EA
		public unsafe int RemainingCookTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_RemainingCookTime)) = value;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x0011257C File Offset: 0x0011077C
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0001A405 File Offset: 0x00018605
		public unsafe EQuality InputQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronData.NativeFieldInfoPtr_InputQuality)) = value;
			}
		}

		// Token: 0x04002095 RID: 8341
		private static readonly System.IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x04002096 RID: 8342
		private static readonly System.IntPtr NativeFieldInfoPtr_Liquid;

		// Token: 0x04002097 RID: 8343
		private static readonly System.IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x04002098 RID: 8344
		private static readonly System.IntPtr NativeFieldInfoPtr_RemainingCookTime;

		// Token: 0x04002099 RID: 8345
		private static readonly System.IntPtr NativeFieldInfoPtr_InputQuality;

		// Token: 0x0400209A RID: 8346
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_Int32_EQuality_0;
	}
}
