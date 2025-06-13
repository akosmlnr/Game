using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Construction.Features
{
	// Token: 0x0200074E RID: 1870
	public class FI_OptionList : FI_Base
	{
		// Token: 0x0600A7BC RID: 42940 RVA: 0x002A1E90 File Offset: 0x002A0090
		// Note: this type is marked as 'beforefieldinit'.
		static FI_OptionList()
		{
			Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Construction.Features", "FI_OptionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr);
			FI_OptionList.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buttonContainer");
			FI_OptionList.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buyButton");
			FI_OptionList.NativeFieldInfoPtr_buyButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buyButtonText");
			FI_OptionList.NativeFieldInfoPtr_bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "bar");
			FI_OptionList.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "buttonPrefab");
			FI_OptionList.NativeFieldInfoPtr_onSelectionChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "onSelectionChanged");
			FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "onSelectionPurchased");
			FI_OptionList.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "options");
			FI_OptionList.NativeFieldInfoPtr_specificFeature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "specificFeature");
			FI_OptionList.NativeFieldInfoPtr_selectionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "selectionIndex");
			FI_OptionList.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683890);
			FI_OptionList.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683891);
			FI_OptionList.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683892);
			FI_OptionList.NativeMethodInfoPtr_Select_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683893);
			FI_OptionList.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683894);
			FI_OptionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, 100683895);
		}

		// Token: 0x0600A7BD RID: 42941 RVA: 0x002A2000 File Offset: 0x002A0200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292971, XrefRangeEnd = 293028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(OptionListFeature _feature, List<FI_OptionList.Option> _options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_feature);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_OptionList.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7BE RID: 42942 RVA: 0x002A2060 File Offset: 0x002A0260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293028, XrefRangeEnd = 293036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FI_OptionList.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7BF RID: 42943 RVA: 0x002A209C File Offset: 0x002A029C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293036, XrefRangeEnd = 293062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7C0 RID: 42944 RVA: 0x002A20D0 File Offset: 0x002A02D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293069, RefRangeEnd = 293071, XrefRangeStart = 293062, XrefRangeEnd = 293069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_Select_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7C1 RID: 42945 RVA: 0x002A2110 File Offset: 0x002A0310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 293109, RefRangeEnd = 293112, XrefRangeStart = 293071, XrefRangeEnd = 293109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x002A2144 File Offset: 0x002A0344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293112, XrefRangeEnd = 293120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FI_OptionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x0005280E File Offset: 0x00050A0E
		public FI_OptionList(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700338E RID: 13198
		// (get) Token: 0x0600A7C4 RID: 42948 RVA: 0x002A2180 File Offset: 0x002A0380
		// (set) Token: 0x0600A7C5 RID: 42949 RVA: 0x00052817 File Offset: 0x00050A17
		public unsafe RectTransform buttonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700338F RID: 13199
		// (get) Token: 0x0600A7C6 RID: 42950 RVA: 0x002A21B0 File Offset: 0x002A03B0
		// (set) Token: 0x0600A7C7 RID: 42951 RVA: 0x00052836 File Offset: 0x00050A36
		public unsafe Button buyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003390 RID: 13200
		// (get) Token: 0x0600A7C8 RID: 42952 RVA: 0x002A21E0 File Offset: 0x002A03E0
		// (set) Token: 0x0600A7C9 RID: 42953 RVA: 0x00052855 File Offset: 0x00050A55
		public unsafe TextMeshProUGUI buyButtonText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButtonText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buyButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003391 RID: 13201
		// (get) Token: 0x0600A7CA RID: 42954 RVA: 0x002A2210 File Offset: 0x002A0410
		// (set) Token: 0x0600A7CB RID: 42955 RVA: 0x00052874 File Offset: 0x00050A74
		public unsafe RectTransform bar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_bar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003392 RID: 13202
		// (get) Token: 0x0600A7CC RID: 42956 RVA: 0x002A2240 File Offset: 0x002A0440
		// (set) Token: 0x0600A7CD RID: 42957 RVA: 0x00052893 File Offset: 0x00050A93
		public unsafe GameObject buttonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003393 RID: 13203
		// (get) Token: 0x0600A7CE RID: 42958 RVA: 0x002A2270 File Offset: 0x002A0470
		// (set) Token: 0x0600A7CF RID: 42959 RVA: 0x000528B2 File Offset: 0x00050AB2
		public unsafe UnityEvent<int> onSelectionChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003394 RID: 13204
		// (get) Token: 0x0600A7D0 RID: 42960 RVA: 0x002A22A0 File Offset: 0x002A04A0
		// (set) Token: 0x0600A7D1 RID: 42961 RVA: 0x000528D1 File Offset: 0x00050AD1
		public unsafe UnityEvent<int> onSelectionPurchased
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_onSelectionPurchased), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003395 RID: 13205
		// (get) Token: 0x0600A7D2 RID: 42962 RVA: 0x002A22D0 File Offset: 0x002A04D0
		// (set) Token: 0x0600A7D3 RID: 42963 RVA: 0x000528F0 File Offset: 0x00050AF0
		public unsafe List<FI_OptionList.Option> options
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_options);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003396 RID: 13206
		// (get) Token: 0x0600A7D4 RID: 42964 RVA: 0x002A2300 File Offset: 0x002A0500
		// (set) Token: 0x0600A7D5 RID: 42965 RVA: 0x0005290F File Offset: 0x00050B0F
		public unsafe OptionListFeature specificFeature
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_specificFeature);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionListFeature>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_specificFeature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x0600A7D6 RID: 42966 RVA: 0x002A2330 File Offset: 0x002A0530
		// (set) Token: 0x0600A7D7 RID: 42967 RVA: 0x0005292E File Offset: 0x00050B2E
		public unsafe int selectionIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_selectionIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.NativeFieldInfoPtr_selectionIndex)) = value;
			}
		}

		// Token: 0x04007073 RID: 28787
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x04007074 RID: 28788
		private static readonly System.IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04007075 RID: 28789
		private static readonly System.IntPtr NativeFieldInfoPtr_buyButtonText;

		// Token: 0x04007076 RID: 28790
		private static readonly System.IntPtr NativeFieldInfoPtr_bar;

		// Token: 0x04007077 RID: 28791
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04007078 RID: 28792
		private static readonly System.IntPtr NativeFieldInfoPtr_onSelectionChanged;

		// Token: 0x04007079 RID: 28793
		private static readonly System.IntPtr NativeFieldInfoPtr_onSelectionPurchased;

		// Token: 0x0400707A RID: 28794
		private static readonly System.IntPtr NativeFieldInfoPtr_options;

		// Token: 0x0400707B RID: 28795
		private static readonly System.IntPtr NativeFieldInfoPtr_specificFeature;

		// Token: 0x0400707C RID: 28796
		private static readonly System.IntPtr NativeFieldInfoPtr_selectionIndex;

		// Token: 0x0400707D RID: 28797
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_OptionListFeature_List_1_Option_0;

		// Token: 0x0400707E RID: 28798
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400707F RID: 28799
		private static readonly System.IntPtr NativeMethodInfoPtr_BuyButtonClicked_Public_Void_0;

		// Token: 0x04007080 RID: 28800
		private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Void_Int32_0;

		// Token: 0x04007081 RID: 28801
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04007082 RID: 28802
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C1E RID: 3102
		public class Option : Il2CppSystem.Object
		{
			// Token: 0x0600E34B RID: 58187 RVA: 0x0035C88C File Offset: 0x0035AA8C
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr);
				FI_OptionList.Option.NativeFieldInfoPtr_optionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionLabel");
				FI_OptionList.Option.NativeFieldInfoPtr_optionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionColor");
				FI_OptionList.Option.NativeFieldInfoPtr_optionPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, "optionPrice");
				FI_OptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr, 100683896);
			}

			// Token: 0x0600E34C RID: 58188 RVA: 0x0035C908 File Offset: 0x0035AB08
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 292967, RefRangeEnd = 292969, XrefRangeStart = 292965, XrefRangeEnd = 292967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option(string _optionLabel, Color _optionColor, float _optionPrice) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList.Option>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(_optionLabel);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _optionColor;
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _optionPrice;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.Option.NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E34D RID: 58189 RVA: 0x0006E739 File Offset: 0x0006C939
			public Option(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004618 RID: 17944
			// (get) Token: 0x0600E34E RID: 58190 RVA: 0x0035C970 File Offset: 0x0035AB70
			// (set) Token: 0x0600E34F RID: 58191 RVA: 0x0006E742 File Offset: 0x0006C942
			public unsafe string optionLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004619 RID: 17945
			// (get) Token: 0x0600E350 RID: 58192 RVA: 0x0035C998 File Offset: 0x0035AB98
			// (set) Token: 0x0600E351 RID: 58193 RVA: 0x0006E761 File Offset: 0x0006C961
			public unsafe Color optionColor
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionColor)) = value;
				}
			}

			// Token: 0x1700461A RID: 17946
			// (get) Token: 0x0600E352 RID: 58194 RVA: 0x0035C9C0 File Offset: 0x0035ABC0
			// (set) Token: 0x0600E353 RID: 58195 RVA: 0x0006E77C File Offset: 0x0006C97C
			public unsafe float optionPrice
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionPrice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.Option.NativeFieldInfoPtr_optionPrice)) = value;
				}
			}

			// Token: 0x04009846 RID: 38982
			private static readonly System.IntPtr NativeFieldInfoPtr_optionLabel;

			// Token: 0x04009847 RID: 38983
			private static readonly System.IntPtr NativeFieldInfoPtr_optionColor;

			// Token: 0x04009848 RID: 38984
			private static readonly System.IntPtr NativeFieldInfoPtr_optionPrice;

			// Token: 0x04009849 RID: 38985
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Color_Single_0;
		}

		// Token: 0x02000C1F RID: 3103
		[ObfuscatedName("ScheduleOne.UI.Construction.Features.FI_OptionList+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E354 RID: 58196 RVA: 0x0035C9E8 File Offset: 0x0035ABE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FI_OptionList>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr);
				FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, "index");
				FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, 100683897);
				FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr, 100683898);
			}

			// Token: 0x0600E355 RID: 58197 RVA: 0x0035CA64 File Offset: 0x0035AC64
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FI_OptionList.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E356 RID: 58198 RVA: 0x0035CAA0 File Offset: 0x0035ACA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292969, XrefRangeEnd = 292971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FI_OptionList.__c__DisplayClass11_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E357 RID: 58199 RVA: 0x0006E797 File Offset: 0x0006C997
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700461B RID: 17947
			// (get) Token: 0x0600E358 RID: 58200 RVA: 0x0035CAD4 File Offset: 0x0035ACD4
			// (set) Token: 0x0600E359 RID: 58201 RVA: 0x0006E7A0 File Offset: 0x0006C9A0
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700461C RID: 17948
			// (get) Token: 0x0600E35A RID: 58202 RVA: 0x0035CAFC File Offset: 0x0035ACFC
			// (set) Token: 0x0600E35B RID: 58203 RVA: 0x0006E7BB File Offset: 0x0006C9BB
			public unsafe FI_OptionList __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FI_OptionList>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FI_OptionList.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400984A RID: 38986
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x0400984B RID: 38987
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400984C RID: 38988
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400984D RID: 38989
			private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;
		}
	}
}
