using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200049A RID: 1178
	public class Settings : PersistentSingleton<Settings>
	{
		// Token: 0x060064AD RID: 25773 RVA: 0x001CB0D8 File Offset: 0x001C92D8
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr_MinYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "MinYPos");
			Settings.NativeFieldInfoPtr_BETA_ARG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "BETA_ARG");
			Settings.NativeFieldInfoPtr_DISABLE_COUNTRY_CHECK_ARG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DISABLE_COUNTRY_CHECK_ARG");
			Settings.NativeFieldInfoPtr_COUNTRY_CHECK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "COUNTRY_CHECK");
			Settings.NativeFieldInfoPtr__unitType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "<unitType>k__BackingField");
			Settings.NativeFieldInfoPtr_LaunchArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "LaunchArgs");
			Settings.NativeFieldInfoPtr_DisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DisplaySettings");
			Settings.NativeFieldInfoPtr_UnappliedDisplaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "UnappliedDisplaySettings");
			Settings.NativeFieldInfoPtr_GraphicsSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GraphicsSettings");
			Settings.NativeFieldInfoPtr_AudioSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "AudioSettings");
			Settings.NativeFieldInfoPtr_InputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputSettings");
			Settings.NativeFieldInfoPtr_InputActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InputActions");
			Settings.NativeFieldInfoPtr_GameInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GameInput");
			Settings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SSAO");
			Settings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "GodRays");
			Settings.NativeFieldInfoPtr_LookSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "LookSensitivity");
			Settings.NativeFieldInfoPtr_InvertMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "InvertMouse");
			Settings.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraFOV");
			Settings.NativeFieldInfoPtr_SprintMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "SprintMode");
			Settings.NativeFieldInfoPtr_CameraBobIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "CameraBobIntensity");
			Settings.NativeFieldInfoPtr_playerControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "playerControls");
			Settings.NativeFieldInfoPtr_onDisplayChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onDisplayChanged");
			Settings.NativeFieldInfoPtr_onInputsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "onInputsApplied");
			Settings.NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676158);
			Settings.NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676159);
			Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676160);
			Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676161);
			Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676162);
			Settings.NativeMethodInfoPtr_CheckCountryCode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676163);
			Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676164);
			Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676165);
			Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676166);
			Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676167);
			Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676168);
			Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676169);
			Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676170);
			Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676171);
			Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676172);
			Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676173);
			Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676174);
			Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676175);
			Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676176);
			Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676177);
			Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676178);
			Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676179);
			Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676180);
			Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100676181);
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x060064AE RID: 25774 RVA: 0x001CB4B4 File Offset: 0x001C96B4
		// (set) Token: 0x060064AF RID: 25775 RVA: 0x001CB4F0 File Offset: 0x001C96F0
		public unsafe Settings.UnitType unitType
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 31426, RefRangeEnd = 31454, XrefRangeStart = 31426, XrefRangeEnd = 31454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31454, RefRangeEnd = 31455, XrefRangeStart = 31454, XrefRangeEnd = 31455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x060064B0 RID: 25776 RVA: 0x001CB530 File Offset: 0x001C9730
		public unsafe bool PausingFreezesTime
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 207017, RefRangeEnd = 207021, XrefRangeStart = 207011, XrefRangeEnd = 207017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060064B1 RID: 25777 RVA: 0x001CB56C File Offset: 0x001C976C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207021, XrefRangeEnd = 207122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B2 RID: 25778 RVA: 0x001CB5A8 File Offset: 0x001C97A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207122, XrefRangeEnd = 207136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Settings.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B3 RID: 25779 RVA: 0x001CB5E4 File Offset: 0x001C97E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207136, XrefRangeEnd = 207145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCountryCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_CheckCountryCode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B4 RID: 25780 RVA: 0x001CB618 File Offset: 0x001C9818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207188, RefRangeEnd = 207191, XrefRangeStart = 207145, XrefRangeEnd = 207188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref settings;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B5 RID: 25781 RVA: 0x001CB658 File Offset: 0x001C9858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207191, XrefRangeEnd = 207199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveMainWindowTo(DisplayInfo displayInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(displayInfo));
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x001CB6A0 File Offset: 0x001C98A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207201, RefRangeEnd = 207206, XrefRangeStart = 207199, XrefRangeEnd = 207201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x001CB6D4 File Offset: 0x001C98D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207206, XrefRangeEnd = 207208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x001CB718 File Offset: 0x001C9918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207209, RefRangeEnd = 207210, XrefRangeStart = 207208, XrefRangeEnd = 207209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064B9 RID: 25785 RVA: 0x001CB74C File Offset: 0x001C994C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207239, RefRangeEnd = 207241, XrefRangeStart = 207210, XrefRangeEnd = 207239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064BA RID: 25786 RVA: 0x001CB790 File Offset: 0x001C9990
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207242, RefRangeEnd = 207245, XrefRangeStart = 207241, XrefRangeEnd = 207242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReloadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064BB RID: 25787 RVA: 0x001CB7C4 File Offset: 0x001C99C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207250, RefRangeEnd = 207252, XrefRangeStart = 207245, XrefRangeEnd = 207250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064BC RID: 25788 RVA: 0x001CB808 File Offset: 0x001C9A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207274, RefRangeEnd = 207275, XrefRangeStart = 207252, XrefRangeEnd = 207274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDisplaySettings(DisplaySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref settings;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064BD RID: 25789 RVA: 0x001CB848 File Offset: 0x001C9A48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207297, RefRangeEnd = 207299, XrefRangeStart = 207275, XrefRangeEnd = 207297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisplaySettings ReadDisplaySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060064BE RID: 25790 RVA: 0x001CB884 File Offset: 0x001C9A84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 207316, RefRangeEnd = 207321, XrefRangeStart = 207299, XrefRangeEnd = 207316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteGraphicsSettings(GraphicsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064BF RID: 25791 RVA: 0x001CB8C8 File Offset: 0x001C9AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207321, XrefRangeEnd = 207340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings ReadGraphicsSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr2) : null;
		}

		// Token: 0x060064C0 RID: 25792 RVA: 0x001CB908 File Offset: 0x001C9B08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207363, RefRangeEnd = 207364, XrefRangeStart = 207340, XrefRangeEnd = 207363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteAudioSettings(AudioSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064C1 RID: 25793 RVA: 0x001CB94C File Offset: 0x001C9B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207364, XrefRangeEnd = 207389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings ReadAudioSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr2) : null;
		}

		// Token: 0x060064C2 RID: 25794 RVA: 0x001CB98C File Offset: 0x001C9B8C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 207405, RefRangeEnd = 207408, XrefRangeStart = 207389, XrefRangeEnd = 207405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteInputSettings(InputSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064C3 RID: 25795 RVA: 0x001CB9D0 File Offset: 0x001C9BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207408, XrefRangeEnd = 207427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputSettings ReadInputSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
		}

		// Token: 0x060064C4 RID: 25796 RVA: 0x001CBA10 File Offset: 0x001C9C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207427, XrefRangeEnd = 207437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionControlPath(string actionName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060064C5 RID: 25797 RVA: 0x001CBA58 File Offset: 0x001C9C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207437, XrefRangeEnd = 207462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064C6 RID: 25798 RVA: 0x0002F5C2 File Offset: 0x0002D7C2
		public Settings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x060064C7 RID: 25799 RVA: 0x001CBA94 File Offset: 0x001C9C94
		// (set) Token: 0x060064C8 RID: 25800 RVA: 0x0002F5CB File Offset: 0x0002D7CB
		public unsafe static float MinYPos
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_MinYPos, (void*)(&value));
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x060064C9 RID: 25801 RVA: 0x001CBAB0 File Offset: 0x001C9CB0
		// (set) Token: 0x060064CA RID: 25802 RVA: 0x0002F5D9 File Offset: 0x0002D7D9
		public unsafe static string BETA_ARG
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_BETA_ARG, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_BETA_ARG, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x060064CB RID: 25803 RVA: 0x001CBAD0 File Offset: 0x001C9CD0
		// (set) Token: 0x060064CC RID: 25804 RVA: 0x0002F5EB File Offset: 0x0002D7EB
		public unsafe static string DISABLE_COUNTRY_CHECK_ARG
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_DISABLE_COUNTRY_CHECK_ARG, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_DISABLE_COUNTRY_CHECK_ARG, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x060064CD RID: 25805 RVA: 0x001CBAF0 File Offset: 0x001C9CF0
		// (set) Token: 0x060064CE RID: 25806 RVA: 0x0002F5FD File Offset: 0x0002D7FD
		public unsafe static bool COUNTRY_CHECK
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_COUNTRY_CHECK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_COUNTRY_CHECK, (void*)(&value));
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x060064CF RID: 25807 RVA: 0x001CBB0C File Offset: 0x001C9D0C
		// (set) Token: 0x060064D0 RID: 25808 RVA: 0x0002F60B File Offset: 0x0002D80B
		public unsafe Settings.UnitType _unitType_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__unitType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr__unitType_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x060064D1 RID: 25809 RVA: 0x001CBB34 File Offset: 0x001C9D34
		// (set) Token: 0x060064D2 RID: 25810 RVA: 0x0002F626 File Offset: 0x0002D826
		public unsafe List<string> LaunchArgs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LaunchArgs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LaunchArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x001CBB64 File Offset: 0x001C9D64
		// (set) Token: 0x060064D4 RID: 25812 RVA: 0x0002F645 File Offset: 0x0002D845
		public unsafe DisplaySettings DisplaySettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_DisplaySettings)) = value;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x060064D5 RID: 25813 RVA: 0x001CBB8C File Offset: 0x001C9D8C
		// (set) Token: 0x060064D6 RID: 25814 RVA: 0x0002F660 File Offset: 0x0002D860
		public unsafe DisplaySettings UnappliedDisplaySettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_UnappliedDisplaySettings)) = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x060064D7 RID: 25815 RVA: 0x001CBBB4 File Offset: 0x001C9DB4
		// (set) Token: 0x060064D8 RID: 25816 RVA: 0x0002F67B File Offset: 0x0002D87B
		public unsafe GraphicsSettings GraphicsSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GraphicsSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x060064D9 RID: 25817 RVA: 0x001CBBE4 File Offset: 0x001C9DE4
		// (set) Token: 0x060064DA RID: 25818 RVA: 0x0002F69A File Offset: 0x0002D89A
		public unsafe AudioSettings AudioSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_AudioSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x060064DB RID: 25819 RVA: 0x001CBC14 File Offset: 0x001C9E14
		// (set) Token: 0x060064DC RID: 25820 RVA: 0x0002F6B9 File Offset: 0x0002D8B9
		public unsafe InputSettings InputSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x060064DD RID: 25821 RVA: 0x001CBC44 File Offset: 0x001C9E44
		// (set) Token: 0x060064DE RID: 25822 RVA: 0x0002F6D8 File Offset: 0x0002D8D8
		public unsafe InputActionAsset InputActions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionAsset>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InputActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x060064DF RID: 25823 RVA: 0x001CBC74 File Offset: 0x001C9E74
		// (set) Token: 0x060064E0 RID: 25824 RVA: 0x0002F6F7 File Offset: 0x0002D8F7
		public unsafe GameInput GameInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GameInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x060064E1 RID: 25825 RVA: 0x001CBCA4 File Offset: 0x001C9EA4
		// (set) Token: 0x060064E2 RID: 25826 RVA: 0x0002F716 File Offset: 0x0002D916
		public unsafe ScriptableRendererFeature SSAO
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SSAO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x060064E3 RID: 25827 RVA: 0x001CBCD4 File Offset: 0x001C9ED4
		// (set) Token: 0x060064E4 RID: 25828 RVA: 0x0002F735 File Offset: 0x0002D935
		public unsafe ScriptableRendererFeature GodRays
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableRendererFeature>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_GodRays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x060064E5 RID: 25829 RVA: 0x001CBD04 File Offset: 0x001C9F04
		// (set) Token: 0x060064E6 RID: 25830 RVA: 0x0002F754 File Offset: 0x0002D954
		public unsafe float LookSensitivity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LookSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_LookSensitivity)) = value;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x060064E7 RID: 25831 RVA: 0x001CBD2C File Offset: 0x001C9F2C
		// (set) Token: 0x060064E8 RID: 25832 RVA: 0x0002F76F File Offset: 0x0002D96F
		public unsafe bool InvertMouse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_InvertMouse)) = value;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x060064E9 RID: 25833 RVA: 0x001CBD54 File Offset: 0x001C9F54
		// (set) Token: 0x060064EA RID: 25834 RVA: 0x0002F78A File Offset: 0x0002D98A
		public unsafe float CameraFOV
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x060064EB RID: 25835 RVA: 0x001CBD7C File Offset: 0x001C9F7C
		// (set) Token: 0x060064EC RID: 25836 RVA: 0x0002F7A5 File Offset: 0x0002D9A5
		public unsafe InputSettings.EActionMode SprintMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_SprintMode)) = value;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x060064ED RID: 25837 RVA: 0x001CBDA4 File Offset: 0x001C9FA4
		// (set) Token: 0x060064EE RID: 25838 RVA: 0x0002F7C0 File Offset: 0x0002D9C0
		public unsafe float CameraBobIntensity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_CameraBobIntensity)) = value;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x060064EF RID: 25839 RVA: 0x001CBDCC File Offset: 0x001C9FCC
		// (set) Token: 0x060064F0 RID: 25840 RVA: 0x0002F7DB File Offset: 0x0002D9DB
		public unsafe InputActionMap playerControls
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionMap>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_playerControls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x060064F1 RID: 25841 RVA: 0x001CBDFC File Offset: 0x001C9FFC
		// (set) Token: 0x060064F2 RID: 25842 RVA: 0x0002F7FA File Offset: 0x0002D9FA
		public unsafe Il2CppSystem.Action onDisplayChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplayChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onDisplayChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x060064F3 RID: 25843 RVA: 0x001CBE2C File Offset: 0x001CA02C
		// (set) Token: 0x060064F4 RID: 25844 RVA: 0x0002F819 File Offset: 0x0002DA19
		public unsafe Il2CppSystem.Action onInputsApplied
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_onInputsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044AF RID: 17583
		private static readonly System.IntPtr NativeFieldInfoPtr_MinYPos;

		// Token: 0x040044B0 RID: 17584
		private static readonly System.IntPtr NativeFieldInfoPtr_BETA_ARG;

		// Token: 0x040044B1 RID: 17585
		private static readonly System.IntPtr NativeFieldInfoPtr_DISABLE_COUNTRY_CHECK_ARG;

		// Token: 0x040044B2 RID: 17586
		private static readonly System.IntPtr NativeFieldInfoPtr_COUNTRY_CHECK;

		// Token: 0x040044B3 RID: 17587
		private static readonly System.IntPtr NativeFieldInfoPtr__unitType_k__BackingField;

		// Token: 0x040044B4 RID: 17588
		private static readonly System.IntPtr NativeFieldInfoPtr_LaunchArgs;

		// Token: 0x040044B5 RID: 17589
		private static readonly System.IntPtr NativeFieldInfoPtr_DisplaySettings;

		// Token: 0x040044B6 RID: 17590
		private static readonly System.IntPtr NativeFieldInfoPtr_UnappliedDisplaySettings;

		// Token: 0x040044B7 RID: 17591
		private static readonly System.IntPtr NativeFieldInfoPtr_GraphicsSettings;

		// Token: 0x040044B8 RID: 17592
		private static readonly System.IntPtr NativeFieldInfoPtr_AudioSettings;

		// Token: 0x040044B9 RID: 17593
		private static readonly System.IntPtr NativeFieldInfoPtr_InputSettings;

		// Token: 0x040044BA RID: 17594
		private static readonly System.IntPtr NativeFieldInfoPtr_InputActions;

		// Token: 0x040044BB RID: 17595
		private static readonly System.IntPtr NativeFieldInfoPtr_GameInput;

		// Token: 0x040044BC RID: 17596
		private static readonly System.IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x040044BD RID: 17597
		private static readonly System.IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x040044BE RID: 17598
		private static readonly System.IntPtr NativeFieldInfoPtr_LookSensitivity;

		// Token: 0x040044BF RID: 17599
		private static readonly System.IntPtr NativeFieldInfoPtr_InvertMouse;

		// Token: 0x040044C0 RID: 17600
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x040044C1 RID: 17601
		private static readonly System.IntPtr NativeFieldInfoPtr_SprintMode;

		// Token: 0x040044C2 RID: 17602
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraBobIntensity;

		// Token: 0x040044C3 RID: 17603
		private static readonly System.IntPtr NativeFieldInfoPtr_playerControls;

		// Token: 0x040044C4 RID: 17604
		private static readonly System.IntPtr NativeFieldInfoPtr_onDisplayChanged;

		// Token: 0x040044C5 RID: 17605
		private static readonly System.IntPtr NativeFieldInfoPtr_onInputsApplied;

		// Token: 0x040044C6 RID: 17606
		private static readonly System.IntPtr NativeMethodInfoPtr_get_unitType_Public_get_UnitType_0;

		// Token: 0x040044C7 RID: 17607
		private static readonly System.IntPtr NativeMethodInfoPtr_set_unitType_Protected_set_Void_UnitType_0;

		// Token: 0x040044C8 RID: 17608
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PausingFreezesTime_Public_get_Boolean_0;

		// Token: 0x040044C9 RID: 17609
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040044CA RID: 17610
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040044CB RID: 17611
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckCountryCode_Private_Void_0;

		// Token: 0x040044CC RID: 17612
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x040044CD RID: 17613
		private static readonly System.IntPtr NativeMethodInfoPtr_MoveMainWindowTo_Private_Void_DisplayInfo_0;

		// Token: 0x040044CE RID: 17614
		private static readonly System.IntPtr NativeMethodInfoPtr_ReloadGraphicsSettings_Public_Void_0;

		// Token: 0x040044CF RID: 17615
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x040044D0 RID: 17616
		private static readonly System.IntPtr NativeMethodInfoPtr_ReloadAudioSettings_Public_Void_0;

		// Token: 0x040044D1 RID: 17617
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x040044D2 RID: 17618
		private static readonly System.IntPtr NativeMethodInfoPtr_ReloadInputSettings_Public_Void_0;

		// Token: 0x040044D3 RID: 17619
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyInputSettings_Public_Void_InputSettings_0;

		// Token: 0x040044D4 RID: 17620
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteDisplaySettings_Public_Void_DisplaySettings_0;

		// Token: 0x040044D5 RID: 17621
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadDisplaySettings_Public_DisplaySettings_0;

		// Token: 0x040044D6 RID: 17622
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteGraphicsSettings_Public_Void_GraphicsSettings_0;

		// Token: 0x040044D7 RID: 17623
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadGraphicsSettings_Public_GraphicsSettings_0;

		// Token: 0x040044D8 RID: 17624
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteAudioSettings_Public_Void_AudioSettings_0;

		// Token: 0x040044D9 RID: 17625
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadAudioSettings_Public_AudioSettings_0;

		// Token: 0x040044DA RID: 17626
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteInputSettings_Public_Void_InputSettings_0;

		// Token: 0x040044DB RID: 17627
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadInputSettings_Public_InputSettings_0;

		// Token: 0x040044DC RID: 17628
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionControlPath_Public_String_String_0;

		// Token: 0x040044DD RID: 17629
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A71 RID: 2673
		[OriginalName("Assembly-CSharp.dll", "", "UnitType")]
		public enum UnitType
		{
			// Token: 0x04008F4C RID: 36684
			Metric,
			// Token: 0x04008F4D RID: 36685
			Imperial
		}
	}
}
