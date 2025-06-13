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
	// Token: 0x020002B6 RID: 694
	public class LabOvenData : GridItemData
	{
		// Token: 0x06003201 RID: 12801 RVA: 0x00112E78 File Offset: 0x00111078
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenData()
		{
			Il2CppClassPointerStore<LabOvenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr);
			LabOvenData.NativeFieldInfoPtr_InputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "InputContents");
			LabOvenData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "OutputContents");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientID");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientQuantity");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientQuality");
			LabOvenData.NativeFieldInfoPtr_CurrentProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentProductID");
			LabOvenData.NativeFieldInfoPtr_CurrentCookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentCookProgress");
			LabOvenData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, 100669060);
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00112F48 File Offset: 0x00111148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136963, RefRangeEnd = 136964, XrefRangeStart = 136953, XrefRangeEnd = 136963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)13) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContents);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref currentIngredientQuantity;
			ptr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((System.UIntPtr)11) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)12) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref currentCookProgress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x0001A606 File Offset: 0x00018806
		public LabOvenData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x0011305C File Offset: 0x0011125C
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x0001A60F File Offset: 0x0001880F
		public unsafe ItemSet InputContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_InputContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_InputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x0011308C File Offset: 0x0011128C
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x0001A62E File Offset: 0x0001882E
		public unsafe ItemSet OutputContents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_OutputContents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x001130BC File Offset: 0x001112BC
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x0001A64D File Offset: 0x0001884D
		public unsafe string CurrentIngredientID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x001130E4 File Offset: 0x001112E4
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x0001A66C File Offset: 0x0001886C
		public unsafe int CurrentIngredientQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity)) = value;
			}
		}

		// Token: 0x1700102A RID: 4138
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x0011310C File Offset: 0x0011130C
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x0001A687 File Offset: 0x00018887
		public unsafe EQuality CurrentIngredientQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality)) = value;
			}
		}

		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x00113134 File Offset: 0x00111334
		// (set) Token: 0x0600320F RID: 12815 RVA: 0x0001A6A2 File Offset: 0x000188A2
		public unsafe string CurrentProductID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06003210 RID: 12816 RVA: 0x0011315C File Offset: 0x0011135C
		// (set) Token: 0x06003211 RID: 12817 RVA: 0x0001A6C1 File Offset: 0x000188C1
		public unsafe int CurrentCookProgress
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentCookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentCookProgress)) = value;
			}
		}

		// Token: 0x040020AF RID: 8367
		private static readonly System.IntPtr NativeFieldInfoPtr_InputContents;

		// Token: 0x040020B0 RID: 8368
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x040020B1 RID: 8369
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentIngredientID;

		// Token: 0x040020B2 RID: 8370
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentIngredientQuantity;

		// Token: 0x040020B3 RID: 8371
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentIngredientQuality;

		// Token: 0x040020B4 RID: 8372
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentProductID;

		// Token: 0x040020B5 RID: 8373
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCookProgress;

		// Token: 0x040020B6 RID: 8374
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0;
	}
}
