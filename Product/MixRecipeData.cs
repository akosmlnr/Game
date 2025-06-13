using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005C5 RID: 1477
	[System.Serializable]
	public class MixRecipeData : Il2CppSystem.Object
	{
		// Token: 0x06008036 RID: 32822 RVA: 0x00227240 File Offset: 0x00225440
		// Note: this type is marked as 'beforefieldinit'.
		static MixRecipeData()
		{
			Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixRecipeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr);
			MixRecipeData.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Product");
			MixRecipeData.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Mixer");
			MixRecipeData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Output");
			MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, 100679432);
		}

		// Token: 0x06008037 RID: 32823 RVA: 0x002272C0 File Offset: 0x002254C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 18724, RefRangeEnd = 18732, XrefRangeStart = 18724, XrefRangeEnd = 18732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixRecipeData(string product, string mixer, string output) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mixer);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(output);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008038 RID: 32824 RVA: 0x0003CA4D File Offset: 0x0003AC4D
		public MixRecipeData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x06008039 RID: 32825 RVA: 0x00227330 File Offset: 0x00225530
		// (set) Token: 0x0600803A RID: 32826 RVA: 0x0003CA56 File Offset: 0x0003AC56
		public unsafe string Product
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x0600803B RID: 32827 RVA: 0x00227358 File Offset: 0x00225558
		// (set) Token: 0x0600803C RID: 32828 RVA: 0x0003CA75 File Offset: 0x0003AC75
		public unsafe string Mixer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x0600803D RID: 32829 RVA: 0x00227380 File Offset: 0x00225580
		// (set) Token: 0x0600803E RID: 32830 RVA: 0x0003CA94 File Offset: 0x0003AC94
		public unsafe string Output
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400574C RID: 22348
		private static readonly System.IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x0400574D RID: 22349
		private static readonly System.IntPtr NativeFieldInfoPtr_Mixer;

		// Token: 0x0400574E RID: 22350
		private static readonly System.IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x0400574F RID: 22351
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}
