using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000670 RID: 1648
	public class NewMixScreen : Singleton<NewMixScreen>
	{
		// Token: 0x0600913B RID: 37179 RVA: 0x0025DA64 File Offset: 0x0025BC64
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixScreen()
		{
			Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NewMixScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr);
			NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MAX_PROPERTIES_DISPLAYED");
			NewMixScreen.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "canvas");
			NewMixScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "Container");
			NewMixScreen.NativeFieldInfoPtr_nameInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "nameInputField");
			NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "mixAlreadyExistsText");
			NewMixScreen.NativeFieldInfoPtr_editIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "editIcon");
			NewMixScreen.NativeFieldInfoPtr_randomizeNameButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "randomizeNameButton");
			NewMixScreen.NativeFieldInfoPtr_confirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "confirmButton");
			NewMixScreen.NativeFieldInfoPtr_PropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "PropertiesLabel");
			NewMixScreen.NativeFieldInfoPtr_MarketValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "MarketValueLabel");
			NewMixScreen.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "Sound");
			NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "attributeEntryPrefab");
			NewMixScreen.NativeFieldInfoPtr_name1Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name1Library");
			NewMixScreen.NativeFieldInfoPtr_name2Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "name2Library");
			NewMixScreen.NativeFieldInfoPtr_onMixNamed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, "onMixNamed");
			NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681417);
			NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681418);
			NewMixScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681419);
			NewMixScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681420);
			NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681421);
			NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681422);
			NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681423);
			NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681424);
			NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681425);
			NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681426);
			NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681427);
			NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr, 100681428);
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0600913C RID: 37180 RVA: 0x0025DCB0 File Offset: 0x0025BEB0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263602, RefRangeEnd = 263603, XrefRangeStart = 263600, XrefRangeEnd = 263602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x0025DCEC File Offset: 0x0025BEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263603, XrefRangeEnd = 263629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x0025DD28 File Offset: 0x0025BF28
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600913F RID: 37183 RVA: 0x0025DD6C File Offset: 0x0025BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263629, XrefRangeEnd = 263635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewMixScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009140 RID: 37184 RVA: 0x0025DDA8 File Offset: 0x0025BFA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263692, RefRangeEnd = 263694, XrefRangeStart = 263635, XrefRangeEnd = 263692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(List<Property> properties, EDrugType drugType, float productMarketValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref drugType;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref productMarketValue;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x0025DE08 File Offset: 0x0025C008
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263704, RefRangeEnd = 263705, XrefRangeStart = 263694, XrefRangeEnd = 263704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009142 RID: 37186 RVA: 0x0025DE3C File Offset: 0x0025C03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263705, XrefRangeEnd = 263708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x0025DE70 File Offset: 0x0025C070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263720, RefRangeEnd = 263721, XrefRangeStart = 263708, XrefRangeEnd = 263720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009144 RID: 37188 RVA: 0x0025DEA4 File Offset: 0x0025C0A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 263756, RefRangeEnd = 263761, XrefRangeStart = 263721, XrefRangeEnd = 263756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateUniqueName(Il2CppReferenceArray<Property> properties = null, EDrugType drugType = EDrugType.Marijuana)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref drugType;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x0025DEFC File Offset: 0x0025C0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263761, XrefRangeEnd = 263771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNameButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x0025DF30 File Offset: 0x0025C130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263771, XrefRangeEnd = 263801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNameValueChanged(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x0025DF74 File Offset: 0x0025C174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263801, XrefRangeEnd = 263816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x00045AD6 File Offset: 0x00043CD6
		public NewMixScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x06009149 RID: 37193 RVA: 0x0025DFB0 File Offset: 0x0025C1B0
		// (set) Token: 0x0600914A RID: 37194 RVA: 0x00045ADF File Offset: 0x00043CDF
		public unsafe static int MAX_PROPERTIES_DISPLAYED
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NewMixScreen.NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED, (void*)(&value));
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x0600914B RID: 37195 RVA: 0x0025DFCC File Offset: 0x0025C1CC
		// (set) Token: 0x0600914C RID: 37196 RVA: 0x00045AED File Offset: 0x00043CED
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600914D RID: 37197 RVA: 0x0025DFFC File Offset: 0x0025C1FC
		// (set) Token: 0x0600914E RID: 37198 RVA: 0x00045B0C File Offset: 0x00043D0C
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600914F RID: 37199 RVA: 0x0025E02C File Offset: 0x0025C22C
		// (set) Token: 0x06009150 RID: 37200 RVA: 0x00045B2B File Offset: 0x00043D2B
		public unsafe TMP_InputField nameInputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_nameInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x0025E05C File Offset: 0x0025C25C
		// (set) Token: 0x06009152 RID: 37202 RVA: 0x00045B4A File Offset: 0x00043D4A
		public unsafe GameObject mixAlreadyExistsText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_mixAlreadyExistsText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x06009153 RID: 37203 RVA: 0x0025E08C File Offset: 0x0025C28C
		// (set) Token: 0x06009154 RID: 37204 RVA: 0x00045B69 File Offset: 0x00043D69
		public unsafe RectTransform editIcon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_editIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x06009155 RID: 37205 RVA: 0x0025E0BC File Offset: 0x0025C2BC
		// (set) Token: 0x06009156 RID: 37206 RVA: 0x00045B88 File Offset: 0x00043D88
		public unsafe Button randomizeNameButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_randomizeNameButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_randomizeNameButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x06009157 RID: 37207 RVA: 0x0025E0EC File Offset: 0x0025C2EC
		// (set) Token: 0x06009158 RID: 37208 RVA: 0x00045BA7 File Offset: 0x00043DA7
		public unsafe Button confirmButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_confirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x0025E11C File Offset: 0x0025C31C
		// (set) Token: 0x0600915A RID: 37210 RVA: 0x00045BC6 File Offset: 0x00043DC6
		public unsafe TextMeshProUGUI PropertiesLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_PropertiesLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_PropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x0600915B RID: 37211 RVA: 0x0025E14C File Offset: 0x0025C34C
		// (set) Token: 0x0600915C RID: 37212 RVA: 0x00045BE5 File Offset: 0x00043DE5
		public unsafe TextMeshProUGUI MarketValueLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_MarketValueLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_MarketValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x0600915D RID: 37213 RVA: 0x0025E17C File Offset: 0x0025C37C
		// (set) Token: 0x0600915E RID: 37214 RVA: 0x00045C04 File Offset: 0x00043E04
		public unsafe AudioSourceController Sound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Sound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3B RID: 11323
		// (get) Token: 0x0600915F RID: 37215 RVA: 0x0025E1AC File Offset: 0x0025C3AC
		// (set) Token: 0x06009160 RID: 37216 RVA: 0x00045C23 File Offset: 0x00043E23
		public unsafe GameObject attributeEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_attributeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3C RID: 11324
		// (get) Token: 0x06009161 RID: 37217 RVA: 0x0025E1DC File Offset: 0x0025C3DC
		// (set) Token: 0x06009162 RID: 37218 RVA: 0x00045C42 File Offset: 0x00043E42
		public unsafe List<string> name1Library
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name1Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x06009163 RID: 37219 RVA: 0x0025E20C File Offset: 0x0025C40C
		// (set) Token: 0x06009164 RID: 37220 RVA: 0x00045C61 File Offset: 0x00043E61
		public unsafe List<string> name2Library
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_name2Library), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x06009165 RID: 37221 RVA: 0x0025E23C File Offset: 0x0025C43C
		// (set) Token: 0x06009166 RID: 37222 RVA: 0x00045C80 File Offset: 0x00043E80
		public unsafe Il2CppSystem.Action<string> onMixNamed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixScreen.NativeFieldInfoPtr_onMixNamed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006250 RID: 25168
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_PROPERTIES_DISPLAYED;

		// Token: 0x04006251 RID: 25169
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006252 RID: 25170
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006253 RID: 25171
		private static readonly System.IntPtr NativeFieldInfoPtr_nameInputField;

		// Token: 0x04006254 RID: 25172
		private static readonly System.IntPtr NativeFieldInfoPtr_mixAlreadyExistsText;

		// Token: 0x04006255 RID: 25173
		private static readonly System.IntPtr NativeFieldInfoPtr_editIcon;

		// Token: 0x04006256 RID: 25174
		private static readonly System.IntPtr NativeFieldInfoPtr_randomizeNameButton;

		// Token: 0x04006257 RID: 25175
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmButton;

		// Token: 0x04006258 RID: 25176
		private static readonly System.IntPtr NativeFieldInfoPtr_PropertiesLabel;

		// Token: 0x04006259 RID: 25177
		private static readonly System.IntPtr NativeFieldInfoPtr_MarketValueLabel;

		// Token: 0x0400625A RID: 25178
		private static readonly System.IntPtr NativeFieldInfoPtr_Sound;

		// Token: 0x0400625B RID: 25179
		private static readonly System.IntPtr NativeFieldInfoPtr_attributeEntryPrefab;

		// Token: 0x0400625C RID: 25180
		private static readonly System.IntPtr NativeFieldInfoPtr_name1Library;

		// Token: 0x0400625D RID: 25181
		private static readonly System.IntPtr NativeFieldInfoPtr_name2Library;

		// Token: 0x0400625E RID: 25182
		private static readonly System.IntPtr NativeFieldInfoPtr_onMixNamed;

		// Token: 0x0400625F RID: 25183
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006260 RID: 25184
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006261 RID: 25185
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006262 RID: 25186
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006263 RID: 25187
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_List_1_Property_EDrugType_Single_0;

		// Token: 0x04006264 RID: 25188
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006265 RID: 25189
		private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeButtonClicked_Public_Void_0;

		// Token: 0x04006266 RID: 25190
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmButtonClicked_Public_Void_0;

		// Token: 0x04006267 RID: 25191
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateUniqueName_Public_String_Il2CppReferenceArray_1_Property_EDrugType_0;

		// Token: 0x04006268 RID: 25192
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshNameButtons_Protected_Void_0;

		// Token: 0x04006269 RID: 25193
		private static readonly System.IntPtr NativeMethodInfoPtr_OnNameValueChanged_Public_Void_String_0;

		// Token: 0x0400626A RID: 25194
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
