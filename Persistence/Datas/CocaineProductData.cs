using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C5 RID: 709
	[Serializable]
	public class CocaineProductData : ProductData
	{
		// Token: 0x06003281 RID: 12929 RVA: 0x001146F8 File Offset: 0x001128F8
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineProductData()
		{
			Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CocaineProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr);
			CocaineProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr, "AppearanceSettings");
			CocaineProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr, 100669076);
		}

		// Token: 0x06003282 RID: 12930 RVA: 0x00114750 File Offset: 0x00112950
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137034, RefRangeEnd = 137037, XrefRangeStart = 137029, XrefRangeEnd = 137034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, CocaineAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003283 RID: 12931 RVA: 0x0001AB38 File Offset: 0x00018D38
		public CocaineProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x06003284 RID: 12932 RVA: 0x001147E4 File Offset: 0x001129E4
		// (set) Token: 0x06003285 RID: 12933 RVA: 0x0001AB41 File Offset: 0x00018D41
		public unsafe CocaineAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CocaineAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020E8 RID: 8424
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x040020E9 RID: 8425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_CocaineAppearanceSettings_0;
	}
}
