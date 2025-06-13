using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x0200074C RID: 1868
	public class FI_ColorPicker : FI_Base
	{
		// Token: 0x0600A797 RID: 42903 RVA: 0x002A181C File Offset: 0x0029FA1C
		// Note: this type is marked as 'beforefieldinit'.
		static FI_ColorPicker()
		{
			Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_ColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr);
			FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorButtonContainer");
			FI_ColorPicker.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "buyButton");
			FI_ColorPicker.NativeFieldInfoPtr_buyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "buyButtonText");
			FI_ColorPicker.NativeFieldInfoPtr_colorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorLabel");
			FI_ColorPicker.NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "bar");
			FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "colorButtonPrefab");
			FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "onSelectionChanged");
			FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "onSelectionPurchased");
			FI_ColorPicker.NativeFieldInfoPtr_specificFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "specificFeature");
			FI_ColorPicker.NativeFieldInfoPtr_selectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "selectionIndex");
			FI_ColorPicker.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683879);
			FI_ColorPicker.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683880);
			FI_ColorPicker.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683881);
			FI_ColorPicker.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683882);
			FI_ColorPicker.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683883);
			FI_ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, 100683884);
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x002A198C File Offset: 0x0029FB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292819, XrefRangeEnd = 292868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(Feature _feature)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_ColorPicker.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x002A19DC File Offset: 0x0029FBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292868, XrefRangeEnd = 292876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_ColorPicker.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x002A1A18 File Offset: 0x0029FC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292876, XrefRangeEnd = 292904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x002A1A4C File Offset: 0x0029FC4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 292914, RefRangeEnd = 292916, XrefRangeStart = 292904, XrefRangeEnd = 292914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x002A1A8C File Offset: 0x0029FC8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 292956, RefRangeEnd = 292959, XrefRangeStart = 292916, XrefRangeEnd = 292956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x002A1AC0 File Offset: 0x0029FCC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_ColorPicker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x0005268C File Offset: 0x0005088C
		public FI_ColorPicker(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600A79F RID: 42911 RVA: 0x002A1AFC File Offset: 0x0029FCFC
		// (set) Token: 0x0600A7A0 RID: 42912 RVA: 0x00052695 File Offset: 0x00050895
		public unsafe RectTransform colorButtonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600A7A1 RID: 42913 RVA: 0x002A1B2C File Offset: 0x0029FD2C
		// (set) Token: 0x0600A7A2 RID: 42914 RVA: 0x000526B4 File Offset: 0x000508B4
		public unsafe Button buyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600A7A3 RID: 42915 RVA: 0x002A1B5C File Offset: 0x0029FD5C
		// (set) Token: 0x0600A7A4 RID: 42916 RVA: 0x000526D3 File Offset: 0x000508D3
		public unsafe TextMeshProUGUI buyButtonText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButtonText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_buyButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600A7A5 RID: 42917 RVA: 0x002A1B8C File Offset: 0x0029FD8C
		// (set) Token: 0x0600A7A6 RID: 42918 RVA: 0x000526F2 File Offset: 0x000508F2
		public unsafe TextMeshProUGUI colorLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003386 RID: 13190
		// (get) Token: 0x0600A7A7 RID: 42919 RVA: 0x002A1BBC File Offset: 0x0029FDBC
		// (set) Token: 0x0600A7A8 RID: 42920 RVA: 0x00052711 File Offset: 0x00050911
		public unsafe RectTransform bar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_bar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003387 RID: 13191
		// (get) Token: 0x0600A7A9 RID: 42921 RVA: 0x002A1BEC File Offset: 0x0029FDEC
		// (set) Token: 0x0600A7AA RID: 42922 RVA: 0x00052730 File Offset: 0x00050930
		public unsafe GameObject colorButtonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_colorButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003388 RID: 13192
		// (get) Token: 0x0600A7AB RID: 42923 RVA: 0x002A1C1C File Offset: 0x0029FE1C
		// (set) Token: 0x0600A7AC RID: 42924 RVA: 0x0005274F File Offset: 0x0005094F
		public unsafe UnityEvent<ColorFeature.NamedColor> onSelectionChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003389 RID: 13193
		// (get) Token: 0x0600A7AD RID: 42925 RVA: 0x002A1C4C File Offset: 0x0029FE4C
		// (set) Token: 0x0600A7AE RID: 42926 RVA: 0x0005276E File Offset: 0x0005096E
		public unsafe UnityEvent<ColorFeature.NamedColor> onSelectionPurchased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ColorFeature.NamedColor>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_onSelectionPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338A RID: 13194
		// (get) Token: 0x0600A7AF RID: 42927 RVA: 0x002A1C7C File Offset: 0x0029FE7C
		// (set) Token: 0x0600A7B0 RID: 42928 RVA: 0x0005278D File Offset: 0x0005098D
		public unsafe ColorFeature specificFeature
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_specificFeature);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFeature>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_specificFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338B RID: 13195
		// (get) Token: 0x0600A7B1 RID: 42929 RVA: 0x002A1CAC File Offset: 0x0029FEAC
		// (set) Token: 0x0600A7B2 RID: 42930 RVA: 0x000527AC File Offset: 0x000509AC
		public unsafe int selectionIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_selectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.NativeFieldInfoPtr_selectionIndex)) = value;
			}
		}

		// Token: 0x0400705E RID: 28766
		private static readonly System.IntPtr NativeFieldInfoPtr_colorButtonContainer;

		// Token: 0x0400705F RID: 28767
		private static readonly System.IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04007060 RID: 28768
		private static readonly System.IntPtr NativeFieldInfoPtr_buyButtonText;

		// Token: 0x04007061 RID: 28769
		private static readonly System.IntPtr NativeFieldInfoPtr_colorLabel;

		// Token: 0x04007062 RID: 28770
		private static readonly System.IntPtr NativeFieldInfoPtr_bar;

		// Token: 0x04007063 RID: 28771
		private static readonly System.IntPtr NativeFieldInfoPtr_colorButtonPrefab;

		// Token: 0x04007064 RID: 28772
		private static readonly System.IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04007065 RID: 28773
		private static readonly System.IntPtr NativeFieldInfoPtr_onSelectionPurchased;

		// Token: 0x04007066 RID: 28774
		private static readonly System.IntPtr NativeFieldInfoPtr_specificFeature;

		// Token: 0x04007067 RID: 28775
		private static readonly System.IntPtr NativeFieldInfoPtr_selectionIndex;

		// Token: 0x04007068 RID: 28776
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_Feature_0;

		// Token: 0x04007069 RID: 28777
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400706A RID: 28778
		private static readonly System.IntPtr NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0;

		// Token: 0x0400706B RID: 28779
		private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x0400706C RID: 28780
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x0400706D RID: 28781
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C1D RID: 3101
		[ObfuscatedName("ScheduleOne.UI.Construction.Features.FI_ColorPicker+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E343 RID: 58179 RVA: 0x0035C748 File Offset: 0x0035A948
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_ColorPicker>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr);
				FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "index");
				FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100683885);
				FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr, 100683886);
			}

			// Token: 0x0600E344 RID: 58180 RVA: 0x0035C7C4 File Offset: 0x0035A9C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_ColorPicker.__c__DisplayClass10_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E345 RID: 58181 RVA: 0x0035C800 File Offset: 0x0035AA00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292817, XrefRangeEnd = 292819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_ColorPicker.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E346 RID: 58182 RVA: 0x0006E6F6 File Offset: 0x0006C8F6
			public __c__DisplayClass10_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004616 RID: 17942
			// (get) Token: 0x0600E347 RID: 58183 RVA: 0x0035C834 File Offset: 0x0035AA34
			// (set) Token: 0x0600E348 RID: 58184 RVA: 0x0006E6FF File Offset: 0x0006C8FF
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17004617 RID: 17943
			// (get) Token: 0x0600E349 RID: 58185 RVA: 0x0035C85C File Offset: 0x0035AA5C
			// (set) Token: 0x0600E34A RID: 58186 RVA: 0x0006E71A File Offset: 0x0006C91A
			public unsafe FI_ColorPicker __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_ColorPicker>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_ColorPicker.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009842 RID: 38978
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009843 RID: 38979
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009844 RID: 38980
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009845 RID: 38981
			private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
		}
	}
}
