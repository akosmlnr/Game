using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.Presets.Options;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Management.SetterScreens
{
	// Token: 0x020003CB RID: 971
	public class ItemSetterScreen : Singleton<ItemSetterScreen>
	{
		// Token: 0x06004ACF RID: 19151 RVA: 0x0016DF40 File Offset: 0x0016C140
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSetterScreen()
		{
			Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.SetterScreens", "ItemSetterScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr);
			ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<Option>k__BackingField");
			ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "ListEntryPrefab");
			ItemSetterScreen.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "EntryContainer");
			ItemSetterScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "TitleLabel");
			ItemSetterScreen.NativeFieldInfoPtr_allEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "allEntry");
			ItemSetterScreen.NativeFieldInfoPtr_noneEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "noneEntry");
			ItemSetterScreen.NativeFieldInfoPtr_pairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "pairs");
			ItemSetterScreen.NativeMethodInfoPtr_get_Option_Public_get_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672650);
			ItemSetterScreen.NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672651);
			ItemSetterScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672652);
			ItemSetterScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672653);
			ItemSetterScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672654);
			ItemSetterScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672655);
			ItemSetterScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672656);
			ItemSetterScreen.NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672657);
			ItemSetterScreen.NativeMethodInfoPtr_AllClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672658);
			ItemSetterScreen.NativeMethodInfoPtr_NoneClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672659);
			ItemSetterScreen.NativeMethodInfoPtr_EntryClicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672660);
			ItemSetterScreen.NativeMethodInfoPtr_RefreshTicks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672661);
			ItemSetterScreen.NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672662);
			ItemSetterScreen.NativeMethodInfoPtr_CreateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672663);
			ItemSetterScreen.NativeMethodInfoPtr_DestroyEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672664);
			ItemSetterScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, 100672665);
		}

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06004AD0 RID: 19152 RVA: 0x0016E13C File Offset: 0x0016C33C
		// (set) Token: 0x06004AD1 RID: 19153 RVA: 0x0016E17C File Offset: 0x0016C37C
		public unsafe ItemList Option
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_get_Option_Public_get_ItemList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06004AD2 RID: 19154 RVA: 0x0016E1C0 File Offset: 0x0016C3C0
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 167769, RefRangeEnd = 167770, XrefRangeStart = 167769, XrefRangeEnd = 167769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06004AD3 RID: 19155 RVA: 0x0016E1FC File Offset: 0x0016C3FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167770, XrefRangeEnd = 167805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AD4 RID: 19156 RVA: 0x0016E238 File Offset: 0x0016C438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167805, XrefRangeEnd = 167823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(ItemList option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AD5 RID: 19157 RVA: 0x0016E288 File Offset: 0x0016C488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167823, XrefRangeEnd = 167824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x0016E2CC File Offset: 0x0016C4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167824, XrefRangeEnd = 167829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSetterScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x0016E308 File Offset: 0x0016C508
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167888, RefRangeEnd = 167890, XrefRangeStart = 167829, XrefRangeEnd = 167888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateEntry(Sprite icon, string label, Il2CppSystem.Action onClick, string prefabID = "", bool createPair = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onClick);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref createPair;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0016E3A0 File Offset: 0x0016C5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167890, XrefRangeEnd = 167892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_AllClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x0016E3D4 File Offset: 0x0016C5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167892, XrefRangeEnd = 167896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_NoneClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ADA RID: 19162 RVA: 0x0016E408 File Offset: 0x0016C608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167896, XrefRangeEnd = 167913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked(string prefabID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prefabID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_EntryClicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ADB RID: 19163 RVA: 0x0016E44C File Offset: 0x0016C64C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167956, RefRangeEnd = 167960, XrefRangeStart = 167913, XrefRangeEnd = 167956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTicks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_RefreshTicks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ADC RID: 19164 RVA: 0x0016E480 File Offset: 0x0016C680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167966, RefRangeEnd = 167967, XrefRangeStart = 167960, XrefRangeEnd = 167966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryTicked(RectTransform entry, bool ticked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref ticked;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ADD RID: 19165 RVA: 0x0016E4D0 File Offset: 0x0016C6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167967, XrefRangeEnd = 167976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_CreateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ADE RID: 19166 RVA: 0x0016E504 File Offset: 0x0016C704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167997, RefRangeEnd = 167998, XrefRangeStart = 167976, XrefRangeEnd = 167997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr_DestroyEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x0016E538 File Offset: 0x0016C738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167998, XrefRangeEnd = 168008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSetterScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00023DCA File Offset: 0x00021FCA
		public ItemSetterScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x06004AE1 RID: 19169 RVA: 0x0016E574 File Offset: 0x0016C774
		// (set) Token: 0x06004AE2 RID: 19170 RVA: 0x00023DD3 File Offset: 0x00021FD3
		public unsafe ItemList _Option_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr__Option_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06004AE3 RID: 19171 RVA: 0x0016E5A4 File Offset: 0x0016C7A4
		// (set) Token: 0x06004AE4 RID: 19172 RVA: 0x00023DF2 File Offset: 0x00021FF2
		public unsafe GameObject ListEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_ListEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06004AE5 RID: 19173 RVA: 0x0016E5D4 File Offset: 0x0016C7D4
		// (set) Token: 0x06004AE6 RID: 19174 RVA: 0x00023E11 File Offset: 0x00022011
		public unsafe RectTransform EntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_EntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0016E604 File Offset: 0x0016C804
		// (set) Token: 0x06004AE8 RID: 19176 RVA: 0x00023E30 File Offset: 0x00022030
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_TitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06004AE9 RID: 19177 RVA: 0x0016E634 File Offset: 0x0016C834
		// (set) Token: 0x06004AEA RID: 19178 RVA: 0x00023E4F File Offset: 0x0002204F
		public unsafe RectTransform allEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_allEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_allEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06004AEB RID: 19179 RVA: 0x0016E664 File Offset: 0x0016C864
		// (set) Token: 0x06004AEC RID: 19180 RVA: 0x00023E6E File Offset: 0x0002206E
		public unsafe RectTransform noneEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_noneEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_noneEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06004AED RID: 19181 RVA: 0x0016E694 File Offset: 0x0016C894
		// (set) Token: 0x06004AEE RID: 19182 RVA: 0x00023E8D File Offset: 0x0002208D
		public unsafe List<ItemSetterScreen.Pair> pairs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_pairs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSetterScreen.Pair>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.NativeFieldInfoPtr_pairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400326E RID: 12910
		private static readonly System.IntPtr NativeFieldInfoPtr__Option_k__BackingField;

		// Token: 0x0400326F RID: 12911
		private static readonly System.IntPtr NativeFieldInfoPtr_ListEntryPrefab;

		// Token: 0x04003270 RID: 12912
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04003271 RID: 12913
		private static readonly System.IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04003272 RID: 12914
		private static readonly System.IntPtr NativeFieldInfoPtr_allEntry;

		// Token: 0x04003273 RID: 12915
		private static readonly System.IntPtr NativeFieldInfoPtr_noneEntry;

		// Token: 0x04003274 RID: 12916
		private static readonly System.IntPtr NativeFieldInfoPtr_pairs;

		// Token: 0x04003275 RID: 12917
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Option_Public_get_ItemList_0;

		// Token: 0x04003276 RID: 12918
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Option_Private_set_Void_ItemList_0;

		// Token: 0x04003277 RID: 12919
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04003278 RID: 12920
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003279 RID: 12921
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_ItemList_0;

		// Token: 0x0400327A RID: 12922
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400327B RID: 12923
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x0400327C RID: 12924
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntry_Private_RectTransform_Sprite_String_Action_String_Boolean_0;

		// Token: 0x0400327D RID: 12925
		private static readonly System.IntPtr NativeMethodInfoPtr_AllClicked_Private_Void_0;

		// Token: 0x0400327E RID: 12926
		private static readonly System.IntPtr NativeMethodInfoPtr_NoneClicked_Private_Void_0;

		// Token: 0x0400327F RID: 12927
		private static readonly System.IntPtr NativeMethodInfoPtr_EntryClicked_Private_Void_String_0;

		// Token: 0x04003280 RID: 12928
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTicks_Private_Void_0;

		// Token: 0x04003281 RID: 12929
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEntryTicked_Private_Void_RectTransform_Boolean_0;

		// Token: 0x04003282 RID: 12930
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntries_Private_Void_0;

		// Token: 0x04003283 RID: 12931
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyEntries_Private_Void_0;

		// Token: 0x04003284 RID: 12932
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009CB RID: 2507
		public class Pair : Il2CppSystem.Object
		{
			// Token: 0x0600CF0A RID: 53002 RVA: 0x003235EC File Offset: 0x003217EC
			// Note: this type is marked as 'beforefieldinit'.
			static Pair()
			{
				Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "Pair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr);
				ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, "prefabID");
				ItemSetterScreen.Pair.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, "entry");
				ItemSetterScreen.Pair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr, 100672666);
			}

			// Token: 0x0600CF0B RID: 53003 RVA: 0x00323654 File Offset: 0x00321854
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Pair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.Pair>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.Pair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF0C RID: 53004 RVA: 0x000645B2 File Offset: 0x000627B2
			public Pair(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004038 RID: 16440
			// (get) Token: 0x0600CF0D RID: 53005 RVA: 0x00323690 File Offset: 0x00321890
			// (set) Token: 0x0600CF0E RID: 53006 RVA: 0x000645BB File Offset: 0x000627BB
			public unsafe string prefabID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_prefabID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004039 RID: 16441
			// (get) Token: 0x0600CF0F RID: 53007 RVA: 0x003236B8 File Offset: 0x003218B8
			// (set) Token: 0x0600CF10 RID: 53008 RVA: 0x000645DA File Offset: 0x000627DA
			public unsafe RectTransform entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.Pair.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C21 RID: 35873
			private static readonly System.IntPtr NativeFieldInfoPtr_prefabID;

			// Token: 0x04008C22 RID: 35874
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04008C23 RID: 35875
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009CC RID: 2508
		[ObfuscatedName("ScheduleOne.Management.SetterScreens.ItemSetterScreen+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF11 RID: 53009 RVA: 0x003236E8 File Offset: 0x003218E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr);
				ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, "onClick");
				ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, 100672667);
				ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr, 100672668);
			}

			// Token: 0x0600CF12 RID: 53010 RVA: 0x00323750 File Offset: 0x00321950
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF13 RID: 53011 RVA: 0x0032378C File Offset: 0x0032198C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF14 RID: 53012 RVA: 0x000645F9 File Offset: 0x000627F9
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403A RID: 16442
			// (get) Token: 0x0600CF15 RID: 53013 RVA: 0x003237C0 File Offset: 0x003219C0
			// (set) Token: 0x0600CF16 RID: 53014 RVA: 0x00064602 File Offset: 0x00062802
			public unsafe Il2CppSystem.Action onClick
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C24 RID: 35876
			private static readonly System.IntPtr NativeFieldInfoPtr_onClick;

			// Token: 0x04008C25 RID: 35877
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C26 RID: 35878
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0;
		}

		// Token: 0x020009CD RID: 2509
		[ObfuscatedName("ScheduleOne.Management.SetterScreens.ItemSetterScreen+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF17 RID: 53015 RVA: 0x003237F0 File Offset: 0x003219F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemSetterScreen>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr);
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "i");
				ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, "<>9__0");
				ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, 100672669);
				ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr, 100672670);
			}

			// Token: 0x0600CF18 RID: 53016 RVA: 0x00323880 File Offset: 0x00321A80
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSetterScreen.__c__DisplayClass21_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF19 RID: 53017 RVA: 0x003238BC File Offset: 0x00321ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167764, XrefRangeEnd = 167769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshTicks_b__0(ItemSetterScreen.Pair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ItemSetterScreen.__c__DisplayClass21_0.NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CF1A RID: 53018 RVA: 0x00064621 File Offset: 0x00062821
			public __c__DisplayClass21_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700403B RID: 16443
			// (get) Token: 0x0600CF1B RID: 53019 RVA: 0x0032390C File Offset: 0x00321B0C
			// (set) Token: 0x0600CF1C RID: 53020 RVA: 0x0006462A File Offset: 0x0006282A
			public unsafe ItemSetterScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSetterScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700403C RID: 16444
			// (get) Token: 0x0600CF1D RID: 53021 RVA: 0x0032393C File Offset: 0x00321B3C
			// (set) Token: 0x0600CF1E RID: 53022 RVA: 0x00064649 File Offset: 0x00062849
			public unsafe int i
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x1700403D RID: 16445
			// (get) Token: 0x0600CF1F RID: 53023 RVA: 0x00323964 File Offset: 0x00321B64
			// (set) Token: 0x0600CF20 RID: 53024 RVA: 0x00064664 File Offset: 0x00062864
			public unsafe Il2CppSystem.Predicate<ItemSetterScreen.Pair> __9__0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<ItemSetterScreen.Pair>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSetterScreen.__c__DisplayClass21_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C27 RID: 35879
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C28 RID: 35880
			private static readonly System.IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008C29 RID: 35881
			private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008C2A RID: 35882
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C2B RID: 35883
			private static readonly System.IntPtr NativeMethodInfoPtr__RefreshTicks_b__0_Internal_Boolean_Pair_0;
		}
	}
}
