using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C9 RID: 713
	[Serializable]
	public class ProductManagerData : SaveData
	{
		// Token: 0x0600329B RID: 12955 RVA: 0x00114C08 File Offset: 0x00112E08
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerData()
		{
			Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr);
			ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "DiscoveredProducts");
			ProductManagerData.NativeFieldInfoPtr_ListedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ListedProducts");
			ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ActiveMixOperation");
			ProductManagerData.NativeFieldInfoPtr_IsMixComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "IsMixComplete");
			ProductManagerData.NativeFieldInfoPtr_MixRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "MixRecipes");
			ProductManagerData.NativeFieldInfoPtr_ProductPrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ProductPrices");
			ProductManagerData.NativeFieldInfoPtr_FavouritedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "FavouritedProducts");
			ProductManagerData.NativeFieldInfoPtr_CreatedWeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedWeed");
			ProductManagerData.NativeFieldInfoPtr_CreatedMeth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedMeth");
			ProductManagerData.NativeFieldInfoPtr_CreatedCocaine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedCocaine");
			ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, 100669080);
		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00114D14 File Offset: 0x00112F14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137052, RefRangeEnd = 137053, XrefRangeStart = 137042, XrefRangeEnd = 137052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerData(Il2CppStringArray discoveredProducts, Il2CppStringArray listedProducts, NewMixOperation activeOperation, bool isMixComplete, Il2CppReferenceArray<MixRecipeData> mixRecipes, Il2CppReferenceArray<StringIntPair> productPrices, Il2CppStringArray favouritedProducts, Il2CppReferenceArray<WeedProductData> createdWeed, Il2CppReferenceArray<MethProductData> createdMeth, Il2CppReferenceArray<CocaineProductData> createdCocaine) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(discoveredProducts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeOperation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMixComplete;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixRecipes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productPrices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(favouritedProducts);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdWeed);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdMeth);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdCocaine);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600329D RID: 12957 RVA: 0x0001AC31 File Offset: 0x00018E31
		public ProductManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001056 RID: 4182
		// (get) Token: 0x0600329E RID: 12958 RVA: 0x00114E08 File Offset: 0x00113008
		// (set) Token: 0x0600329F RID: 12959 RVA: 0x0001AC3A File Offset: 0x00018E3A
		public unsafe Il2CppStringArray DiscoveredProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001057 RID: 4183
		// (get) Token: 0x060032A0 RID: 12960 RVA: 0x00114E38 File Offset: 0x00113038
		// (set) Token: 0x060032A1 RID: 12961 RVA: 0x0001AC59 File Offset: 0x00018E59
		public unsafe Il2CppStringArray ListedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x060032A2 RID: 12962 RVA: 0x00114E68 File Offset: 0x00113068
		// (set) Token: 0x060032A3 RID: 12963 RVA: 0x0001AC78 File Offset: 0x00018E78
		public unsafe NewMixOperation ActiveMixOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x060032A4 RID: 12964 RVA: 0x00114E98 File Offset: 0x00113098
		// (set) Token: 0x060032A5 RID: 12965 RVA: 0x0001AC97 File Offset: 0x00018E97
		public unsafe bool IsMixComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete)) = value;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x060032A6 RID: 12966 RVA: 0x00114EC0 File Offset: 0x001130C0
		// (set) Token: 0x060032A7 RID: 12967 RVA: 0x0001ACB2 File Offset: 0x00018EB2
		public unsafe Il2CppReferenceArray<MixRecipeData> MixRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MixRecipeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x060032A8 RID: 12968 RVA: 0x00114EF0 File Offset: 0x001130F0
		// (set) Token: 0x060032A9 RID: 12969 RVA: 0x0001ACD1 File Offset: 0x00018ED1
		public unsafe Il2CppReferenceArray<StringIntPair> ProductPrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x060032AA RID: 12970 RVA: 0x00114F20 File Offset: 0x00113120
		// (set) Token: 0x060032AB RID: 12971 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		public unsafe Il2CppStringArray FavouritedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x060032AC RID: 12972 RVA: 0x00114F50 File Offset: 0x00113150
		// (set) Token: 0x060032AD RID: 12973 RVA: 0x0001AD0F File Offset: 0x00018F0F
		public unsafe Il2CppReferenceArray<WeedProductData> CreatedWeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedWeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WeedProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedWeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x060032AE RID: 12974 RVA: 0x00114F80 File Offset: 0x00113180
		// (set) Token: 0x060032AF RID: 12975 RVA: 0x0001AD2E File Offset: 0x00018F2E
		public unsafe Il2CppReferenceArray<MethProductData> CreatedMeth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedMeth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedMeth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x060032B0 RID: 12976 RVA: 0x00114FB0 File Offset: 0x001131B0
		// (set) Token: 0x060032B1 RID: 12977 RVA: 0x0001AD4D File Offset: 0x00018F4D
		public unsafe Il2CppReferenceArray<CocaineProductData> CreatedCocaine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedCocaine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CocaineProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedCocaine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020F3 RID: 8435
		private static readonly IntPtr NativeFieldInfoPtr_DiscoveredProducts;

		// Token: 0x040020F4 RID: 8436
		private static readonly IntPtr NativeFieldInfoPtr_ListedProducts;

		// Token: 0x040020F5 RID: 8437
		private static readonly IntPtr NativeFieldInfoPtr_ActiveMixOperation;

		// Token: 0x040020F6 RID: 8438
		private static readonly IntPtr NativeFieldInfoPtr_IsMixComplete;

		// Token: 0x040020F7 RID: 8439
		private static readonly IntPtr NativeFieldInfoPtr_MixRecipes;

		// Token: 0x040020F8 RID: 8440
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrices;

		// Token: 0x040020F9 RID: 8441
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedProducts;

		// Token: 0x040020FA RID: 8442
		private static readonly IntPtr NativeFieldInfoPtr_CreatedWeed;

		// Token: 0x040020FB RID: 8443
		private static readonly IntPtr NativeFieldInfoPtr_CreatedMeth;

		// Token: 0x040020FC RID: 8444
		private static readonly IntPtr NativeFieldInfoPtr_CreatedCocaine;

		// Token: 0x040020FD RID: 8445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_0;
	}
}
