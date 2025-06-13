using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000723 RID: 1827
	public class TattooShopUI : CharacterCustomizationUI
	{
		// Token: 0x0600A323 RID: 41763 RVA: 0x00293324 File Offset: 0x00291524
		// Note: this type is marked as 'beforefieldinit'.
		static TattooShopUI()
		{
			Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "TattooShopUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr);
			TattooShopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100683347);
			TattooShopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100683348);
			TattooShopUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100683349);
			TattooShopUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr, 100683350);
		}

		// Token: 0x0600A324 RID: 41764 RVA: 0x002933A4 File Offset: 0x002915A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287063, XrefRangeEnd = 287083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TattooShopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A325 RID: 41765 RVA: 0x002933FC File Offset: 0x002915FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287083, XrefRangeEnd = 287098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TattooShopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A326 RID: 41766 RVA: 0x0029344C File Offset: 0x0029164C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287098, XrefRangeEnd = 287112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TattooShopUI.NativeMethodInfoPtr_OptionDeselected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A327 RID: 41767 RVA: 0x0029349C File Offset: 0x0029169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TattooShopUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TattooShopUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TattooShopUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A328 RID: 41768 RVA: 0x00050051 File Offset: 0x0004E251
		public TattooShopUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04006D64 RID: 28004
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04006D65 RID: 28005
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D66 RID: 28006
		private static readonly IntPtr NativeMethodInfoPtr_OptionDeselected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D67 RID: 28007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
