using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F3 RID: 1011
	[Serializable]
	public class BrandishingWeapon : Crime
	{
		// Token: 0x06004CF9 RID: 19705 RVA: 0x001751D4 File Offset: 0x001733D4
		// Note: this type is marked as 'beforefieldinit'.
		static BrandishingWeapon()
		{
			Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "BrandishingWeapon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr);
			BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, "<CrimeName>k__BackingField");
			BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672908);
			BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672909);
			BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr, 100672910);
		}

		// Token: 0x170016ED RID: 5869
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00175254 File Offset: 0x00173454
		// (set) Token: 0x06004CFB RID: 19707 RVA: 0x00175298 File Offset: 0x00173498
		public unsafe override string CrimeName
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrandishingWeapon.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x001752E8 File Offset: 0x001734E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169374, RefRangeEnd = 169376, XrefRangeStart = 169365, XrefRangeEnd = 169374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrandishingWeapon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrandishingWeapon>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrandishingWeapon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00024D7E File Offset: 0x00022F7E
		public BrandishingWeapon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016EC RID: 5868
		// (get) Token: 0x06004CFE RID: 19710 RVA: 0x00175324 File Offset: 0x00173524
		// (set) Token: 0x06004CFF RID: 19711 RVA: 0x00024D87 File Offset: 0x00022F87
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrandishingWeapon.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040033DC RID: 13276
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040033DD RID: 13277
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040033DE RID: 13278
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040033DF RID: 13279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
