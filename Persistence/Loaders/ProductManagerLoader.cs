using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000241 RID: 577
	public class ProductManagerLoader : Loader
	{
		// Token: 0x06002EC4 RID: 11972 RVA: 0x00108410 File Offset: 0x00106610
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerLoader()
		{
			Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ProductManagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr);
			ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668712);
			ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668713);
			ProductManagerLoader.NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668714);
			ProductManagerLoader.NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668715);
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00108490 File Offset: 0x00106690
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x001084CC File Offset: 0x001066CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131485, XrefRangeEnd = 131594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x0010851C File Offset: 0x0010671C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 131622, RefRangeEnd = 131625, XrefRangeStart = 131594, XrefRangeEnd = 131622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SanitizeProductData(ProductData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00108560 File Offset: 0x00106760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131625, XrefRangeEnd = 131648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProducts(ProductManagerData productData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00018DE0 File Offset: 0x00016FE0
		public ProductManagerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F03 RID: 7939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F04 RID: 7940
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001F05 RID: 7941
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0;

		// Token: 0x04001F06 RID: 7942
		private static readonly IntPtr NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0;
	}
}
