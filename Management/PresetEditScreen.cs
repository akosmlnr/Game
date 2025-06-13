using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management.Presets;
using Il2CppScheduleOne.Management.Presets.Options.SetterScreens;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C2 RID: 962
	public class PresetEditScreen : MonoBehaviour
	{
		// Token: 0x06004A3E RID: 19006 RVA: 0x0016C100 File Offset: 0x0016A300
		// Note: this type is marked as 'beforefieldinit'.
		static PresetEditScreen()
		{
			Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PresetEditScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr);
			PresetEditScreen.NativeFieldInfoPtr_EditedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "EditedPreset");
			PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "IconBackgroundRect");
			PresetEditScreen.NativeFieldInfoPtr_IconBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "IconBackground");
			PresetEditScreen.NativeFieldInfoPtr_InputFieldRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "InputFieldRect");
			PresetEditScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "InputField");
			PresetEditScreen.NativeFieldInfoPtr_EditButtonRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "EditButtonRect");
			PresetEditScreen.NativeFieldInfoPtr_ReturnButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "ReturnButton");
			PresetEditScreen.NativeFieldInfoPtr_DeleteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "DeleteButton");
			PresetEditScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672576);
			PresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672577);
			PresetEditScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672578);
			PresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672579);
			PresetEditScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672580);
			PresetEditScreen.NativeMethodInfoPtr_RefreshIcon_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672581);
			PresetEditScreen.NativeMethodInfoPtr_RefreshTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672582);
			PresetEditScreen.NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672583);
			PresetEditScreen.NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672584);
			PresetEditScreen.NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672585);
			PresetEditScreen.NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672586);
			PresetEditScreen.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672587);
			PresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672588);
			PresetEditScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, 100672589);
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x06004A3F RID: 19007 RVA: 0x0016C2E8 File Offset: 0x0016A4E8
		public unsafe bool isOpen
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 167243, RefRangeEnd = 167251, XrefRangeStart = 167243, XrefRangeEnd = 167243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x0016C324 File Offset: 0x0016A524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167291, RefRangeEnd = 167292, XrefRangeStart = 167251, XrefRangeEnd = 167291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x0016C360 File Offset: 0x0016A560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167292, XrefRangeEnd = 167296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x0016C3A4 File Offset: 0x0016A5A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167309, RefRangeEnd = 167310, XrefRangeStart = 167296, XrefRangeEnd = 167309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x0016C3F4 File Offset: 0x0016A5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167310, XrefRangeEnd = 167314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x0016C428 File Offset: 0x0016A628
		[CallerCount(0)]
		public unsafe void RefreshIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_RefreshIcon_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x0016C45C File Offset: 0x0016A65C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167332, RefRangeEnd = 167334, XrefRangeStart = 167314, XrefRangeEnd = 167332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransforms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_RefreshTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A46 RID: 19014 RVA: 0x0016C490 File Offset: 0x0016A690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167334, XrefRangeEnd = 167335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFieldChange(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A47 RID: 19015 RVA: 0x0016C4D4 File Offset: 0x0016A6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167335, XrefRangeEnd = 167344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NameFieldDone(string piss)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(piss);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A48 RID: 19016 RVA: 0x0016C518 File Offset: 0x0016A718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167344, XrefRangeEnd = 167351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameAppropriate(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004A49 RID: 19017 RVA: 0x0016C568 File Offset: 0x0016A768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167351, XrefRangeEnd = 167363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A4A RID: 19018 RVA: 0x0016C59C File Offset: 0x0016A79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A4B RID: 19019 RVA: 0x0016C5D0 File Offset: 0x0016A7D0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PresetEditScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A4C RID: 19020 RVA: 0x0016C60C File Offset: 0x0016A80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167363, XrefRangeEnd = 167368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004A4D RID: 19021 RVA: 0x00023997 File Offset: 0x00021B97
		public PresetEditScreen(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x0016C64C File Offset: 0x0016A84C
		// (set) Token: 0x06004A4F RID: 19023 RVA: 0x000239A0 File Offset: 0x00021BA0
		public unsafe Preset EditedPreset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditedPreset);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditedPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06004A50 RID: 19024 RVA: 0x0016C67C File Offset: 0x0016A87C
		// (set) Token: 0x06004A51 RID: 19025 RVA: 0x000239BF File Offset: 0x00021BBF
		public unsafe RectTransform IconBackgroundRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackgroundRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x06004A52 RID: 19026 RVA: 0x0016C6AC File Offset: 0x0016A8AC
		// (set) Token: 0x06004A53 RID: 19027 RVA: 0x000239DE File Offset: 0x00021BDE
		public unsafe Image IconBackground
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackground);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_IconBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x06004A54 RID: 19028 RVA: 0x0016C6DC File Offset: 0x0016A8DC
		// (set) Token: 0x06004A55 RID: 19029 RVA: 0x000239FD File Offset: 0x00021BFD
		public unsafe RectTransform InputFieldRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputFieldRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputFieldRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x06004A56 RID: 19030 RVA: 0x0016C70C File Offset: 0x0016A90C
		// (set) Token: 0x06004A57 RID: 19031 RVA: 0x00023A1C File Offset: 0x00021C1C
		public unsafe TMP_InputField InputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06004A58 RID: 19032 RVA: 0x0016C73C File Offset: 0x0016A93C
		// (set) Token: 0x06004A59 RID: 19033 RVA: 0x00023A3B File Offset: 0x00021C3B
		public unsafe RectTransform EditButtonRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditButtonRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_EditButtonRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06004A5A RID: 19034 RVA: 0x0016C76C File Offset: 0x0016A96C
		// (set) Token: 0x06004A5B RID: 19035 RVA: 0x00023A5A File Offset: 0x00021C5A
		public unsafe Button ReturnButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_ReturnButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_ReturnButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x06004A5C RID: 19036 RVA: 0x0016C79C File Offset: 0x0016A99C
		// (set) Token: 0x06004A5D RID: 19037 RVA: 0x00023A79 File Offset: 0x00021C79
		public unsafe Button DeleteButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_DeleteButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.NativeFieldInfoPtr_DeleteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003210 RID: 12816
		private static readonly System.IntPtr NativeFieldInfoPtr_EditedPreset;

		// Token: 0x04003211 RID: 12817
		private static readonly System.IntPtr NativeFieldInfoPtr_IconBackgroundRect;

		// Token: 0x04003212 RID: 12818
		private static readonly System.IntPtr NativeFieldInfoPtr_IconBackground;

		// Token: 0x04003213 RID: 12819
		private static readonly System.IntPtr NativeFieldInfoPtr_InputFieldRect;

		// Token: 0x04003214 RID: 12820
		private static readonly System.IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x04003215 RID: 12821
		private static readonly System.IntPtr NativeFieldInfoPtr_EditButtonRect;

		// Token: 0x04003216 RID: 12822
		private static readonly System.IntPtr NativeFieldInfoPtr_ReturnButton;

		// Token: 0x04003217 RID: 12823
		private static readonly System.IntPtr NativeFieldInfoPtr_DeleteButton;

		// Token: 0x04003218 RID: 12824
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04003219 RID: 12825
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400321A RID: 12826
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400321B RID: 12827
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Preset_0;

		// Token: 0x0400321C RID: 12828
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400321D RID: 12829
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshIcon_Private_Void_0;

		// Token: 0x0400321E RID: 12830
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshTransforms_Private_Void_0;

		// Token: 0x0400321F RID: 12831
		private static readonly System.IntPtr NativeMethodInfoPtr_NameFieldChange_Private_Void_String_0;

		// Token: 0x04003220 RID: 12832
		private static readonly System.IntPtr NativeMethodInfoPtr_NameFieldDone_Private_Void_String_0;

		// Token: 0x04003221 RID: 12833
		private static readonly System.IntPtr NativeMethodInfoPtr_IsNameAppropriate_Private_Boolean_String_0;

		// Token: 0x04003222 RID: 12834
		private static readonly System.IntPtr NativeMethodInfoPtr_DeleteButtonClicked_Public_Void_0;

		// Token: 0x04003223 RID: 12835
		private static readonly System.IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x04003224 RID: 12836
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003225 RID: 12837
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009C5 RID: 2501
		[System.Serializable]
		public class OptionData : Il2CppSystem.Object
		{
			// Token: 0x0600CEE0 RID: 52960 RVA: 0x00322EA4 File Offset: 0x003210A4
			// Note: this type is marked as 'beforefieldinit'.
			static OptionData()
			{
				Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "OptionData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr);
				PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, "OptionEntryPrefab");
				PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, "OptionSetterScreen");
				PresetEditScreen.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr, 100672590);
			}

			// Token: 0x0600CEE1 RID: 52961 RVA: 0x00322F0C File Offset: 0x0032110C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OptionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen.OptionData>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.OptionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEE2 RID: 52962 RVA: 0x00064475 File Offset: 0x00062675
			public OptionData(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402C RID: 16428
			// (get) Token: 0x0600CEE3 RID: 52963 RVA: 0x00322F48 File Offset: 0x00321148
			// (set) Token: 0x0600CEE4 RID: 52964 RVA: 0x0006447E File Offset: 0x0006267E
			public unsafe GameObject OptionEntryPrefab
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402D RID: 16429
			// (get) Token: 0x0600CEE5 RID: 52965 RVA: 0x00322F78 File Offset: 0x00321178
			// (set) Token: 0x0600CEE6 RID: 52966 RVA: 0x0006449D File Offset: 0x0006269D
			public unsafe OptionSetterScreen OptionSetterScreen
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionSetterScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.OptionData.NativeFieldInfoPtr_OptionSetterScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C08 RID: 35848
			private static readonly System.IntPtr NativeFieldInfoPtr_OptionEntryPrefab;

			// Token: 0x04008C09 RID: 35849
			private static readonly System.IntPtr NativeFieldInfoPtr_OptionSetterScreen;

			// Token: 0x04008C0A RID: 35850
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009C6 RID: 2502
		[ObfuscatedName("ScheduleOne.Management.PresetEditScreen+<<Open>g__Delay|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CEE7 RID: 52967 RVA: 0x00322FA8 File Offset: 0x003211A8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresetEditScreen>.NativeClassPtr, "<<Open>g__Delay|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672591);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672592);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672593);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672594);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672595);
				PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100672596);
			}

			// Token: 0x0600CEE8 RID: 52968 RVA: 0x00323088 File Offset: 0x00321288
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEE9 RID: 52969 RVA: 0x003230D0 File Offset: 0x003212D0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEEA RID: 52970 RVA: 0x00323104 File Offset: 0x00321304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167233, XrefRangeEnd = 167238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004031 RID: 16433
			// (get) Token: 0x0600CEEB RID: 52971 RVA: 0x00323140 File Offset: 0x00321340
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CEEC RID: 52972 RVA: 0x00323180 File Offset: 0x00321380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167238, XrefRangeEnd = 167243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004032 RID: 16434
			// (get) Token: 0x0600CEED RID: 52973 RVA: 0x003231B4 File Offset: 0x003213B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CEEE RID: 52974 RVA: 0x000644BC File Offset: 0x000626BC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402E RID: 16430
			// (get) Token: 0x0600CEEF RID: 52975 RVA: 0x003231F4 File Offset: 0x003213F4
			// (set) Token: 0x0600CEF0 RID: 52976 RVA: 0x000644C5 File Offset: 0x000626C5
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700402F RID: 16431
			// (get) Token: 0x0600CEF1 RID: 52977 RVA: 0x0032321C File Offset: 0x0032141C
			// (set) Token: 0x0600CEF2 RID: 52978 RVA: 0x000644E0 File Offset: 0x000626E0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004030 RID: 16432
			// (get) Token: 0x0600CEF3 RID: 52979 RVA: 0x0032324C File Offset: 0x0032144C
			// (set) Token: 0x0600CEF4 RID: 52980 RVA: 0x000644FF File Offset: 0x000626FF
			public unsafe PresetEditScreen __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PresetEditScreen>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PresetEditScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C0B RID: 35851
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C0C RID: 35852
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C0D RID: 35853
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C0E RID: 35854
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C0F RID: 35855
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C10 RID: 35856
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C11 RID: 35857
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C12 RID: 35858
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C13 RID: 35859
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
