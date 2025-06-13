using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200077B RID: 1915
	[System.Serializable]
	public class MixOperation : Il2CppSystem.Object
	{
		// Token: 0x0600B462 RID: 46178 RVA: 0x002D20A4 File Offset: 0x002D02A4
		// Note: this type is marked as 'beforefieldinit'.
		static MixOperation()
		{
			Il2CppClassPointerStore<MixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixOperation>.NativeClassPtr);
			MixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductID");
			MixOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductQuality");
			MixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "IngredientID");
			MixOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "Quantity");
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685625);
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685626);
			MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685627);
			MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100685628);
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x002D2174 File Offset: 0x002D0374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310336, RefRangeEnd = 310338, XrefRangeStart = 310333, XrefRangeEnd = 310336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref productQuality;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x002D21F0 File Offset: 0x002D03F0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x002D222C File Offset: 0x002D042C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310352, RefRangeEnd = 310354, XrefRangeStart = 310338, XrefRangeEnd = 310352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDrugType GetOutput(out List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			properties = ((intPtr2 == 0) ? null : new List<Property>(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x002D228C File Offset: 0x002D048C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 310377, RefRangeEnd = 310382, XrefRangeStart = 310354, XrefRangeEnd = 310377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			knownProduct = ((intPtr2 == 0) ? null : new ProductDefinition(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x0005842E File Offset: 0x0005662E
		public MixOperation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600B468 RID: 46184 RVA: 0x002D22EC File Offset: 0x002D04EC
		// (set) Token: 0x0600B469 RID: 46185 RVA: 0x00058437 File Offset: 0x00056637
		public unsafe string ProductID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600B46A RID: 46186 RVA: 0x002D2314 File Offset: 0x002D0514
		// (set) Token: 0x0600B46B RID: 46187 RVA: 0x00058456 File Offset: 0x00056656
		public unsafe EQuality ProductQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600B46C RID: 46188 RVA: 0x002D233C File Offset: 0x002D053C
		// (set) Token: 0x0600B46D RID: 46189 RVA: 0x00058471 File Offset: 0x00056671
		public unsafe string IngredientID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600B46E RID: 46190 RVA: 0x002D2364 File Offset: 0x002D0564
		// (set) Token: 0x0600B46F RID: 46191 RVA: 0x00058490 File Offset: 0x00056690
		public unsafe int Quantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x0400799D RID: 31133
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x0400799E RID: 31134
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x0400799F RID: 31135
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040079A0 RID: 31136
		private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040079A1 RID: 31137
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0;

		// Token: 0x040079A2 RID: 31138
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040079A3 RID: 31139
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Property_0;

		// Token: 0x040079A4 RID: 31140
		private static readonly System.IntPtr NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0;
	}
}
