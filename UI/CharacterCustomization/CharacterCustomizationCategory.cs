using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCustomization
{
	// Token: 0x02000720 RID: 1824
	public class CharacterCustomizationCategory : MonoBehaviour
	{
		// Token: 0x0600A298 RID: 41624 RVA: 0x00291948 File Offset: 0x0028FB48
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCustomizationCategory()
		{
			Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCustomization", "CharacterCustomizationCategory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr);
			CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "CategoryName");
			CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "TitleText");
			CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "BackButton");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ScrollRect");
			CharacterCustomizationCategory.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "ui");
			CharacterCustomizationCategory.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "options");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onOpen");
			CharacterCustomizationCategory.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "onClose");
			CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683286);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683287);
			CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683288);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683289);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683290);
			CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683291);
			CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, 100683292);
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x00291AA4 File Offset: 0x0028FCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286582, XrefRangeEnd = 286629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x00291AD8 File Offset: 0x0028FCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286642, RefRangeEnd = 286643, XrefRangeStart = 286629, XrefRangeEnd = 286642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x00291B0C File Offset: 0x0028FD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286643, XrefRangeEnd = 286648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x00291B40 File Offset: 0x0028FD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286648, XrefRangeEnd = 286654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionSelected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x00291B84 File Offset: 0x0028FD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286654, XrefRangeEnd = 286655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionDeselected(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x00291BC8 File Offset: 0x0028FDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286655, XrefRangeEnd = 286665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OptionPurchased(CharacterCustomizationOption option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x00291C0C File Offset: 0x0028FE0C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCustomizationCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x0004FAE3 File Offset: 0x0004DCE3
		public CharacterCustomizationCategory(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600A2A1 RID: 41633 RVA: 0x00291C48 File Offset: 0x0028FE48
		// (set) Token: 0x0600A2A2 RID: 41634 RVA: 0x0004FAEC File Offset: 0x0004DCEC
		public unsafe string CategoryName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_CategoryName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170031E6 RID: 12774
		// (get) Token: 0x0600A2A3 RID: 41635 RVA: 0x00291C70 File Offset: 0x0028FE70
		// (set) Token: 0x0600A2A4 RID: 41636 RVA: 0x0004FB0B File Offset: 0x0004DD0B
		public unsafe TextMeshProUGUI TitleText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E7 RID: 12775
		// (get) Token: 0x0600A2A5 RID: 41637 RVA: 0x00291CA0 File Offset: 0x0028FEA0
		// (set) Token: 0x0600A2A6 RID: 41638 RVA: 0x0004FB2A File Offset: 0x0004DD2A
		public unsafe Button BackButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E8 RID: 12776
		// (get) Token: 0x0600A2A7 RID: 41639 RVA: 0x00291CD0 File Offset: 0x0028FED0
		// (set) Token: 0x0600A2A8 RID: 41640 RVA: 0x0004FB49 File Offset: 0x0004DD49
		public unsafe ScrollRect ScrollRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E9 RID: 12777
		// (get) Token: 0x0600A2A9 RID: 41641 RVA: 0x00291D00 File Offset: 0x0028FF00
		// (set) Token: 0x0600A2AA RID: 41642 RVA: 0x0004FB68 File Offset: 0x0004DD68
		public unsafe CharacterCustomizationUI ui
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A2AB RID: 41643 RVA: 0x00291D30 File Offset: 0x0028FF30
		// (set) Token: 0x0600A2AC RID: 41644 RVA: 0x0004FB87 File Offset: 0x0004DD87
		public unsafe Il2CppReferenceArray<CharacterCustomizationOption> options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCustomizationOption>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600A2AD RID: 41645 RVA: 0x00291D60 File Offset: 0x0028FF60
		// (set) Token: 0x0600A2AE RID: 41646 RVA: 0x0004FBA6 File Offset: 0x0004DDA6
		public unsafe UnityEvent onOpen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031EC RID: 12780
		// (get) Token: 0x0600A2AF RID: 41647 RVA: 0x00291D90 File Offset: 0x0028FF90
		// (set) Token: 0x0600A2B0 RID: 41648 RVA: 0x0004FBC5 File Offset: 0x0004DDC5
		public unsafe UnityEvent onClose
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D0C RID: 27916
		private static readonly System.IntPtr NativeFieldInfoPtr_CategoryName;

		// Token: 0x04006D0D RID: 27917
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleText;

		// Token: 0x04006D0E RID: 27918
		private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006D0F RID: 27919
		private static readonly System.IntPtr NativeFieldInfoPtr_ScrollRect;

		// Token: 0x04006D10 RID: 27920
		private static readonly System.IntPtr NativeFieldInfoPtr_ui;

		// Token: 0x04006D11 RID: 27921
		private static readonly System.IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006D12 RID: 27922
		private static readonly System.IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04006D13 RID: 27923
		private static readonly System.IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04006D14 RID: 27924
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006D15 RID: 27925
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006D16 RID: 27926
		private static readonly System.IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04006D17 RID: 27927
		private static readonly System.IntPtr NativeMethodInfoPtr_OptionSelected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D18 RID: 27928
		private static readonly System.IntPtr NativeMethodInfoPtr_OptionDeselected_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D19 RID: 27929
		private static readonly System.IntPtr NativeMethodInfoPtr_OptionPurchased_Private_Void_CharacterCustomizationOption_0;

		// Token: 0x04006D1A RID: 27930
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF8 RID: 3064
		[ObfuscatedName("ScheduleOne.UI.CharacterCustomization.CharacterCustomizationCategory+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E1EE RID: 57838 RVA: 0x00358A70 File Offset: 0x00356C70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCustomizationCategory>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, "option");
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100683293);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100683294);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100683295);
				CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr, 100683296);
			}

			// Token: 0x0600E1EF RID: 57839 RVA: 0x00358B14 File Offset: 0x00356D14
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCustomizationCategory.__c__DisplayClass8_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1F0 RID: 57840 RVA: 0x00358B50 File Offset: 0x00356D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286565, XrefRangeEnd = 286571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1F1 RID: 57841 RVA: 0x00358B84 File Offset: 0x00356D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286571, XrefRangeEnd = 286572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1F2 RID: 57842 RVA: 0x00358BB8 File Offset: 0x00356DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286572, XrefRangeEnd = 286582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeMethodInfoPtr__Awake_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1F3 RID: 57843 RVA: 0x0006DC5D File Offset: 0x0006BE5D
			public __c__DisplayClass8_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B7 RID: 17847
			// (get) Token: 0x0600E1F4 RID: 57844 RVA: 0x00358BEC File Offset: 0x00356DEC
			// (set) Token: 0x0600E1F5 RID: 57845 RVA: 0x0006DC66 File Offset: 0x0006BE66
			public unsafe CharacterCustomizationOption option
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationOption>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr_option), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B8 RID: 17848
			// (get) Token: 0x0600E1F6 RID: 57846 RVA: 0x00358C1C File Offset: 0x00356E1C
			// (set) Token: 0x0600E1F7 RID: 57847 RVA: 0x0006DC85 File Offset: 0x0006BE85
			public unsafe CharacterCustomizationCategory __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCustomizationCategory>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCustomizationCategory.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400977D RID: 38781
			private static readonly System.IntPtr NativeFieldInfoPtr_option;

			// Token: 0x0400977E RID: 38782
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400977F RID: 38783
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009780 RID: 38784
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;

			// Token: 0x04009781 RID: 38785
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__1_Internal_Void_0;

			// Token: 0x04009782 RID: 38786
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__2_Internal_Void_0;
		}
	}
}
