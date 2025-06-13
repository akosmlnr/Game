using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C7 RID: 711
	[Serializable]
	public class ProductData : SaveData
	{
		// Token: 0x0600328B RID: 12939 RVA: 0x00114930 File Offset: 0x00112B30
		// Note: this type is marked as 'beforefieldinit'.
		static ProductData()
		{
			Il2CppClassPointerStore<ProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductData>.NativeClassPtr);
			ProductData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Name");
			ProductData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "ID");
			ProductData.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "DrugType");
			ProductData.NativeFieldInfoPtr_Properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductData>.NativeClassPtr, "Properties");
			ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductData>.NativeClassPtr, 100669078);
		}

		// Token: 0x0600328C RID: 12940 RVA: 0x001149C4 File Offset: 0x00112BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 137041, RefRangeEnd = 137042, XrefRangeStart = 137037, XrefRangeEnd = 137041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600328D RID: 12941 RVA: 0x0001AB88 File Offset: 0x00018D88
		public ProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001051 RID: 4177
		// (get) Token: 0x0600328E RID: 12942 RVA: 0x00114A44 File Offset: 0x00112C44
		// (set) Token: 0x0600328F RID: 12943 RVA: 0x0001AB91 File Offset: 0x00018D91
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001052 RID: 4178
		// (get) Token: 0x06003290 RID: 12944 RVA: 0x00114A6C File Offset: 0x00112C6C
		// (set) Token: 0x06003291 RID: 12945 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001053 RID: 4179
		// (get) Token: 0x06003292 RID: 12946 RVA: 0x00114A94 File Offset: 0x00112C94
		// (set) Token: 0x06003293 RID: 12947 RVA: 0x0001ABCF File Offset: 0x00018DCF
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17001054 RID: 4180
		// (get) Token: 0x06003294 RID: 12948 RVA: 0x00114ABC File Offset: 0x00112CBC
		// (set) Token: 0x06003295 RID: 12949 RVA: 0x0001ABEA File Offset: 0x00018DEA
		public unsafe Il2CppStringArray Properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductData.NativeFieldInfoPtr_Properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020EC RID: 8428
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040020ED RID: 8429
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040020EE RID: 8430
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x040020EF RID: 8431
		private static readonly IntPtr NativeFieldInfoPtr_Properties;

		// Token: 0x040020F0 RID: 8432
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_0;
	}
}
