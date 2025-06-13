using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002C6 RID: 710
	[Serializable]
	public class MethProductData : ProductData
	{
		// Token: 0x06003286 RID: 12934 RVA: 0x00114814 File Offset: 0x00112A14
		// Note: this type is marked as 'beforefieldinit'.
		static MethProductData()
		{
			Il2CppClassPointerStore<MethProductData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MethProductData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethProductData>.NativeClassPtr);
			MethProductData.NativeFieldInfoPtr_AppearanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethProductData>.NativeClassPtr, "AppearanceSettings");
			MethProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_MethAppearanceSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethProductData>.NativeClassPtr, 100669077);
		}

		// Token: 0x06003287 RID: 12935 RVA: 0x0011486C File Offset: 0x00112A6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 137034, RefRangeEnd = 137037, XrefRangeStart = 137034, XrefRangeEnd = 137037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethProductData(string name, string id, EDrugType drugType, Il2CppStringArray properties, MethAppearanceSettings appearanceSettings) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethProductData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drugType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearanceSettings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethProductData.NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_MethAppearanceSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003288 RID: 12936 RVA: 0x0001AB60 File Offset: 0x00018D60
		public MethProductData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001050 RID: 4176
		// (get) Token: 0x06003289 RID: 12937 RVA: 0x00114900 File Offset: 0x00112B00
		// (set) Token: 0x0600328A RID: 12938 RVA: 0x0001AB69 File Offset: 0x00018D69
		public unsafe MethAppearanceSettings AppearanceSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethProductData.NativeFieldInfoPtr_AppearanceSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethAppearanceSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethProductData.NativeFieldInfoPtr_AppearanceSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020EA RID: 8426
		private static readonly IntPtr NativeFieldInfoPtr_AppearanceSettings;

		// Token: 0x040020EB RID: 8427
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_EDrugType_Il2CppStringArray_MethAppearanceSettings_0;
	}
}
