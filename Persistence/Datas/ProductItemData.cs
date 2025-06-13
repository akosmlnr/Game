using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000283 RID: 643
	[Serializable]
	public class ProductItemData : QualityItemData
	{
		// Token: 0x06003078 RID: 12408 RVA: 0x0010E9BC File Offset: 0x0010CBBC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemData()
		{
			Il2CppClassPointerStore<ProductItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr);
			ProductItemData.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr, "PackagingID");
			ProductItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr, 100669007);
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0010EA14 File Offset: 0x0010CC14
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136642, RefRangeEnd = 136646, XrefRangeStart = 136642, XrefRangeEnd = 136646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00019649 File Offset: 0x00017849
		public ProductItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x0600307B RID: 12411 RVA: 0x0010EA94 File Offset: 0x0010CC94
		// (set) Token: 0x0600307C RID: 12412 RVA: 0x00019652 File Offset: 0x00017852
		public unsafe string PackagingID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemData.NativeFieldInfoPtr_PackagingID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemData.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
