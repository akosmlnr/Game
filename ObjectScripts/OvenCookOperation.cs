using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000777 RID: 1911
	[System.Serializable]
	public class OvenCookOperation : Il2CppSystem.Object
	{
		// Token: 0x0600B30D RID: 45837 RVA: 0x002CC938 File Offset: 0x002CAB38
		// Note: this type is marked as 'beforefieldinit'.
		static OvenCookOperation()
		{
			Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "OvenCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr);
			OvenCookOperation.NativeFieldInfoPtr__itemDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_itemDefinition");
			OvenCookOperation.NativeFieldInfoPtr__productionDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_productionDefinition");
			OvenCookOperation.NativeFieldInfoPtr__cookable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_cookable");
			OvenCookOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientID");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuality");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuantity");
			OvenCookOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "ProductID");
			OvenCookOperation.NativeFieldInfoPtr_CookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "CookProgress");
			OvenCookOperation.NativeFieldInfoPtr_cookDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "cookDuration");
			OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685435);
			OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685436);
			OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685437);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685438);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685439);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685440);
			OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685441);
			OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685442);
			OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685443);
			OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100685444);
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x002CCAE4 File Offset: 0x002CACE4
		public unsafe StorableItemDefinition Ingredient
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 308491, RefRangeEnd = 308498, XrefRangeStart = 308481, XrefRangeEnd = 308491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600B30F RID: 45839 RVA: 0x002CCB24 File Offset: 0x002CAD24
		public unsafe StorableItemDefinition Product
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 308508, RefRangeEnd = 308511, XrefRangeStart = 308498, XrefRangeEnd = 308508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x002CCB64 File Offset: 0x002CAD64
		public unsafe CookableModule Cookable
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 308520, RefRangeEnd = 308526, XrefRangeStart = 308511, XrefRangeEnd = 308520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr2) : null;
			}
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x002CCBA4 File Offset: 0x002CADA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308529, RefRangeEnd = 308532, XrefRangeStart = 308526, XrefRangeEnd = 308529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x002CCC20 File Offset: 0x002CAE20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308535, RefRangeEnd = 308537, XrefRangeStart = 308532, XrefRangeEnd = 308535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref progress;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x002CCCA8 File Offset: 0x002CAEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308538, RefRangeEnd = 308539, XrefRangeStart = 308537, XrefRangeEnd = 308538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x002CCCE4 File Offset: 0x002CAEE4
		[CallerCount(0)]
		public unsafe void UpdateCookProgress(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x002CCD24 File Offset: 0x002CAF24
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 308543, RefRangeEnd = 308551, XrefRangeStart = 308539, XrefRangeEnd = 308543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCookDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x002CCD60 File Offset: 0x002CAF60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308563, RefRangeEnd = 308566, XrefRangeStart = 308551, XrefRangeEnd = 308563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetProductItem(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x002CCDAC File Offset: 0x002CAFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308570, RefRangeEnd = 308571, XrefRangeStart = 308566, XrefRangeEnd = 308570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x00057B22 File Offset: 0x00055D22
		public OvenCookOperation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600B319 RID: 45849 RVA: 0x002CCDE8 File Offset: 0x002CAFE8
		// (set) Token: 0x0600B31A RID: 45850 RVA: 0x00057B2B File Offset: 0x00055D2B
		public unsafe StorableItemDefinition _itemDefinition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600B31B RID: 45851 RVA: 0x002CCE18 File Offset: 0x002CB018
		// (set) Token: 0x0600B31C RID: 45852 RVA: 0x00057B4A File Offset: 0x00055D4A
		public unsafe StorableItemDefinition _productionDefinition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600B31D RID: 45853 RVA: 0x002CCE48 File Offset: 0x002CB048
		// (set) Token: 0x0600B31E RID: 45854 RVA: 0x00057B69 File Offset: 0x00055D69
		public unsafe CookableModule _cookable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600B31F RID: 45855 RVA: 0x002CCE78 File Offset: 0x002CB078
		// (set) Token: 0x0600B320 RID: 45856 RVA: 0x00057B88 File Offset: 0x00055D88
		public unsafe string IngredientID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600B321 RID: 45857 RVA: 0x002CCEA0 File Offset: 0x002CB0A0
		// (set) Token: 0x0600B322 RID: 45858 RVA: 0x00057BA7 File Offset: 0x00055DA7
		public unsafe EQuality IngredientQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality)) = value;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600B323 RID: 45859 RVA: 0x002CCEC8 File Offset: 0x002CB0C8
		// (set) Token: 0x0600B324 RID: 45860 RVA: 0x00057BC2 File Offset: 0x00055DC2
		public unsafe int IngredientQuantity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity)) = value;
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600B325 RID: 45861 RVA: 0x002CCEF0 File Offset: 0x002CB0F0
		// (set) Token: 0x0600B326 RID: 45862 RVA: 0x00057BDD File Offset: 0x00055DDD
		public unsafe string ProductID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600B327 RID: 45863 RVA: 0x002CCF18 File Offset: 0x002CB118
		// (set) Token: 0x0600B328 RID: 45864 RVA: 0x00057BFC File Offset: 0x00055DFC
		public unsafe int CookProgress
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress)) = value;
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600B329 RID: 45865 RVA: 0x002CCF40 File Offset: 0x002CB140
		// (set) Token: 0x0600B32A RID: 45866 RVA: 0x00057C17 File Offset: 0x00055E17
		public unsafe int cookDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration)) = value;
			}
		}

		// Token: 0x0400789C RID: 30876
		private static readonly System.IntPtr NativeFieldInfoPtr__itemDefinition;

		// Token: 0x0400789D RID: 30877
		private static readonly System.IntPtr NativeFieldInfoPtr__productionDefinition;

		// Token: 0x0400789E RID: 30878
		private static readonly System.IntPtr NativeFieldInfoPtr__cookable;

		// Token: 0x0400789F RID: 30879
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040078A0 RID: 30880
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientQuality;

		// Token: 0x040078A1 RID: 30881
		private static readonly System.IntPtr NativeFieldInfoPtr_IngredientQuantity;

		// Token: 0x040078A2 RID: 30882
		private static readonly System.IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040078A3 RID: 30883
		private static readonly System.IntPtr NativeFieldInfoPtr_CookProgress;

		// Token: 0x040078A4 RID: 30884
		private static readonly System.IntPtr NativeFieldInfoPtr_cookDuration;

		// Token: 0x040078A5 RID: 30885
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0;

		// Token: 0x040078A6 RID: 30886
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0;

		// Token: 0x040078A7 RID: 30887
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0;

		// Token: 0x040078A8 RID: 30888
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0;

		// Token: 0x040078A9 RID: 30889
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0;

		// Token: 0x040078AA RID: 30890
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040078AB RID: 30891
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0;

		// Token: 0x040078AC RID: 30892
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCookDuration_Public_Int32_0;

		// Token: 0x040078AD RID: 30893
		private static readonly System.IntPtr NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0;

		// Token: 0x040078AE RID: 30894
		private static readonly System.IntPtr NativeMethodInfoPtr_IsReady_Public_Boolean_0;
	}
}
