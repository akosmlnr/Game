using System;
using Il2CppHSVPicker;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x0200071F RID: 1823
	public class BarbershopUI : CharacterCustomizationUI
	{
		// Token: 0x0600A288 RID: 41608 RVA: 0x002915B0 File Offset: 0x0028F7B0
		// Note: this type is marked as 'beforefieldinit'.
		static BarbershopUI()
		{
			Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "BarbershopUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr);
			BarbershopUI.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ColorPicker");
			BarbershopUI.NativeFieldInfoPtr_ApplyColorButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "ApplyColorButton");
			BarbershopUI.NativeFieldInfoPtr_appliedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, "appliedColor");
			BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683278);
			BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683279);
			BarbershopUI.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683280);
			BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683281);
			BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683282);
			BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683283);
			BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683284);
			BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr, 100683285);
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x002916BC File Offset: 0x0028F8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286527, XrefRangeEnd = 286529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsOptionCurrentlyApplied(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x00291714 File Offset: 0x0028F914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286529, XrefRangeEnd = 286535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x00291764 File Offset: 0x0028F964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286535, XrefRangeEnd = 286543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x002917A0 File Offset: 0x0028F9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286543, XrefRangeEnd = 286547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BarbershopUI.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x002917DC File Offset: 0x0028F9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286547, XrefRangeEnd = 286551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorFieldChanged(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x0029181C File Offset: 0x0028FA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286551, XrefRangeEnd = 286555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_ApplyColorChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x00291850 File Offset: 0x0028FA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286555, XrefRangeEnd = 286560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RevertColorChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr_RevertColorChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x00291884 File Offset: 0x0028FA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286560, XrefRangeEnd = 286565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BarbershopUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BarbershopUI>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BarbershopUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x0004FA81 File Offset: 0x0004DC81
		public BarbershopUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600A292 RID: 41618 RVA: 0x002918C0 File Offset: 0x0028FAC0
		// (set) Token: 0x0600A293 RID: 41619 RVA: 0x0004FA8A File Offset: 0x0004DC8A
		public unsafe ColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600A294 RID: 41620 RVA: 0x002918F0 File Offset: 0x0028FAF0
		// (set) Token: 0x0600A295 RID: 41621 RVA: 0x0004FAA9 File Offset: 0x0004DCA9
		public unsafe Button ApplyColorButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_ApplyColorButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600A296 RID: 41622 RVA: 0x00291920 File Offset: 0x0028FB20
		// (set) Token: 0x0600A297 RID: 41623 RVA: 0x0004FAC8 File Offset: 0x0004DCC8
		public unsafe Color appliedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BarbershopUI.NativeFieldInfoPtr_appliedColor)) = value;
			}
		}

		// Token: 0x04006D01 RID: 27905
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x04006D02 RID: 27906
		private static readonly IntPtr NativeFieldInfoPtr_ApplyColorButton;

		// Token: 0x04006D03 RID: 27907
		private static readonly IntPtr NativeFieldInfoPtr_appliedColor;

		// Token: 0x04006D04 RID: 27908
		private static readonly IntPtr NativeMethodInfoPtr_IsOptionCurrentlyApplied_Public_Virtual_Boolean_CharacterCustomizationOption_0;

		// Token: 0x04006D05 RID: 27909
		private static readonly IntPtr NativeMethodInfoPtr_OptionSelected_Public_Virtual_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D06 RID: 27910
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04006D07 RID: 27911
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x04006D08 RID: 27912
		private static readonly IntPtr NativeMethodInfoPtr_ColorFieldChanged_Public_Void_Color_0;

		// Token: 0x04006D09 RID: 27913
		private static readonly IntPtr NativeMethodInfoPtr_ApplyColorChange_Public_Void_0;

		// Token: 0x04006D0A RID: 27914
		private static readonly IntPtr NativeMethodInfoPtr_RevertColorChange_Public_Void_0;

		// Token: 0x04006D0B RID: 27915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
