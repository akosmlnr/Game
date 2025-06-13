using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200063D RID: 1597
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		// Token: 0x06008C4F RID: 35919 RVA: 0x0024EEE0 File Offset: 0x0024D0E0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomizationManager()
		{
			Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "CustomizationManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr);
			CustomizationManager.NativeFieldInfoPtr_ActiveSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "ActiveSettings");
			CustomizationManager.NativeFieldInfoPtr_TemplateAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "TemplateAvatar");
			CustomizationManager.NativeFieldInfoPtr_SaveInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "SaveInputField");
			CustomizationManager.NativeFieldInfoPtr_LoadInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "LoadInputField");
			CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "OnAvatarSettingsChanged");
			CustomizationManager.NativeFieldInfoPtr_DefaultSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "DefaultSettings");
			CustomizationManager.NativeFieldInfoPtr_isEditingOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "isEditingOriginal");
			CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680831);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680832);
			CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680833);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680834);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680835);
			CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680836);
			CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680837);
			CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680838);
			CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680839);
			CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680840);
			CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680841);
			CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680842);
			CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680843);
			CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680844);
			CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680845);
			CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680846);
			CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680847);
			CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680848);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680849);
			CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680850);
			CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680851);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680852);
			CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680853);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680854);
			CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680855);
			CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680856);
			CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680857);
			CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, 100680858);
		}

		// Token: 0x06008C50 RID: 35920 RVA: 0x0024F1CC File Offset: 0x0024D3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257897, XrefRangeEnd = 257907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomizationManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C51 RID: 35921 RVA: 0x0024F208 File Offset: 0x0024D408
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C52 RID: 35922 RVA: 0x0024F24C File Offset: 0x0024D44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257907, XrefRangeEnd = 257912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_CreateSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C53 RID: 35923 RVA: 0x0024F280 File Offset: 0x0024D480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257932, RefRangeEnd = 257935, XrefRangeStart = 257912, XrefRangeEnd = 257932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(AvatarSettings loadedSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedSettings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C54 RID: 35924 RVA: 0x0024F2C4 File Offset: 0x0024D4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257935, XrefRangeEnd = 257951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings(string settingsName, bool editOriginal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(settingsName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref editOriginal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C55 RID: 35925 RVA: 0x0024F314 File Offset: 0x0024D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257951, XrefRangeEnd = 257958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDefaultSettings(AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C56 RID: 35926 RVA: 0x0024F358 File Offset: 0x0024D558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257958, XrefRangeEnd = 257984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LoadSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C57 RID: 35927 RVA: 0x0024F38C File Offset: 0x0024D58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257984, XrefRangeEnd = 257986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenderChanged(float genderScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref genderScale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C58 RID: 35928 RVA: 0x0024F3CC File Offset: 0x0024D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257986, XrefRangeEnd = 257988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeightChanged(float weightScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref weightScale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C59 RID: 35929 RVA: 0x0024F40C File Offset: 0x0024D60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257988, XrefRangeEnd = 257990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HeightChanged(float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref height;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C5A RID: 35930 RVA: 0x0024F44C File Offset: 0x0024D64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257990, XrefRangeEnd = 257994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkinColorChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C5B RID: 35931 RVA: 0x0024F48C File Offset: 0x0024D68C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257994, XrefRangeEnd = 258004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairChanged(Accessory newHair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newHair);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C5C RID: 35932 RVA: 0x0024F4D0 File Offset: 0x0024D6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258004, XrefRangeEnd = 258006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HairColorChanged(Color newCol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newCol;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C5D RID: 35933 RVA: 0x0024F510 File Offset: 0x0024D710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258006, XrefRangeEnd = 258008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyeBallTintChanged(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C5E RID: 35934 RVA: 0x0024F550 File Offset: 0x0024D750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258008, XrefRangeEnd = 258010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpperEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C5F RID: 35935 RVA: 0x0024F590 File Offset: 0x0024D790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258010, XrefRangeEnd = 258012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LowerEyeLidRestingPositionChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C60 RID: 35936 RVA: 0x0024F5D0 File Offset: 0x0024D7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258012, XrefRangeEnd = 258014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowScaleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C61 RID: 35937 RVA: 0x0024F610 File Offset: 0x0024D810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258014, XrefRangeEnd = 258016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowThicknessChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C62 RID: 35938 RVA: 0x0024F650 File Offset: 0x0024D850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258016, XrefRangeEnd = 258018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingHeightChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C63 RID: 35939 RVA: 0x0024F690 File Offset: 0x0024D890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258018, XrefRangeEnd = 258020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EyebrowRestingAngleChanged(float newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newVal;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x0024F6D0 File Offset: 0x0024D8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258020, XrefRangeEnd = 258022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PupilDilationChanged(float dilation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dilation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x0024F710 File Offset: 0x0024D910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258022, XrefRangeEnd = 258037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerChanged(FaceLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C66 RID: 35942 RVA: 0x0024F760 File Offset: 0x0024D960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258037, XrefRangeEnd = 258045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FaceLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x0024F7AC File Offset: 0x0024D9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258045, XrefRangeEnd = 258060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerChanged(AvatarLayer layer, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(layer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x0024F7FC File Offset: 0x0024D9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258060, XrefRangeEnd = 258068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BodyLayerColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x0024F848 File Offset: 0x0024DA48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258068, XrefRangeEnd = 258107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryChanged(Accessory acc, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acc);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x0024F898 File Offset: 0x0024DA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258107, XrefRangeEnd = 258120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AccessoryColorChanged(Color col, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x0024F8E4 File Offset: 0x0024DAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258120, XrefRangeEnd = 258123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomizationManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x00042D6D File Offset: 0x00040F6D
		public CustomizationManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A95 RID: 10901
		// (get) Token: 0x06008C6D RID: 35949 RVA: 0x0024F920 File Offset: 0x0024DB20
		// (set) Token: 0x06008C6E RID: 35950 RVA: 0x00042D76 File Offset: 0x00040F76
		public unsafe AvatarSettings ActiveSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_ActiveSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A96 RID: 10902
		// (get) Token: 0x06008C6F RID: 35951 RVA: 0x0024F950 File Offset: 0x0024DB50
		// (set) Token: 0x06008C70 RID: 35952 RVA: 0x00042D95 File Offset: 0x00040F95
		public unsafe Avatar TemplateAvatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_TemplateAvatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x06008C71 RID: 35953 RVA: 0x0024F980 File Offset: 0x0024DB80
		// (set) Token: 0x06008C72 RID: 35954 RVA: 0x00042DB4 File Offset: 0x00040FB4
		public unsafe TMP_InputField SaveInputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_SaveInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x06008C73 RID: 35955 RVA: 0x0024F9B0 File Offset: 0x0024DBB0
		// (set) Token: 0x06008C74 RID: 35956 RVA: 0x00042DD3 File Offset: 0x00040FD3
		public unsafe TMP_InputField LoadInputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_LoadInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x06008C75 RID: 35957 RVA: 0x0024F9E0 File Offset: 0x0024DBE0
		// (set) Token: 0x06008C76 RID: 35958 RVA: 0x00042DF2 File Offset: 0x00040FF2
		public unsafe CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomizationManager.AvatarSettingsChanged>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_OnAvatarSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x0024FA10 File Offset: 0x0024DC10
		// (set) Token: 0x06008C78 RID: 35960 RVA: 0x00042E11 File Offset: 0x00041011
		public unsafe AvatarSettings DefaultSettings
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_DefaultSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x06008C79 RID: 35961 RVA: 0x0024FA40 File Offset: 0x0024DC40
		// (set) Token: 0x06008C7A RID: 35962 RVA: 0x00042E30 File Offset: 0x00041030
		public unsafe bool isEditingOriginal
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CustomizationManager.NativeFieldInfoPtr_isEditingOriginal)) = value;
			}
		}

		// Token: 0x04005F3E RID: 24382
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveSettings;

		// Token: 0x04005F3F RID: 24383
		private static readonly System.IntPtr NativeFieldInfoPtr_TemplateAvatar;

		// Token: 0x04005F40 RID: 24384
		private static readonly System.IntPtr NativeFieldInfoPtr_SaveInputField;

		// Token: 0x04005F41 RID: 24385
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadInputField;

		// Token: 0x04005F42 RID: 24386
		private static readonly System.IntPtr NativeFieldInfoPtr_OnAvatarSettingsChanged;

		// Token: 0x04005F43 RID: 24387
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSettings;

		// Token: 0x04005F44 RID: 24388
		private static readonly System.IntPtr NativeFieldInfoPtr_isEditingOriginal;

		// Token: 0x04005F45 RID: 24389
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005F46 RID: 24390
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_String_0;

		// Token: 0x04005F47 RID: 24391
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateSettings_Public_Void_0;

		// Token: 0x04005F48 RID: 24392
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_AvatarSettings_0;

		// Token: 0x04005F49 RID: 24393
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_String_Boolean_0;

		// Token: 0x04005F4A RID: 24394
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDefaultSettings_Private_Void_AvatarSettings_0;

		// Token: 0x04005F4B RID: 24395
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadSettings_Public_Void_0;

		// Token: 0x04005F4C RID: 24396
		private static readonly System.IntPtr NativeMethodInfoPtr_GenderChanged_Public_Void_Single_0;

		// Token: 0x04005F4D RID: 24397
		private static readonly System.IntPtr NativeMethodInfoPtr_WeightChanged_Public_Void_Single_0;

		// Token: 0x04005F4E RID: 24398
		private static readonly System.IntPtr NativeMethodInfoPtr_HeightChanged_Public_Void_Single_0;

		// Token: 0x04005F4F RID: 24399
		private static readonly System.IntPtr NativeMethodInfoPtr_SkinColorChanged_Public_Void_Color_0;

		// Token: 0x04005F50 RID: 24400
		private static readonly System.IntPtr NativeMethodInfoPtr_HairChanged_Public_Void_Accessory_0;

		// Token: 0x04005F51 RID: 24401
		private static readonly System.IntPtr NativeMethodInfoPtr_HairColorChanged_Public_Void_Color_0;

		// Token: 0x04005F52 RID: 24402
		private static readonly System.IntPtr NativeMethodInfoPtr_EyeBallTintChanged_Public_Void_Color_0;

		// Token: 0x04005F53 RID: 24403
		private static readonly System.IntPtr NativeMethodInfoPtr_UpperEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04005F54 RID: 24404
		private static readonly System.IntPtr NativeMethodInfoPtr_LowerEyeLidRestingPositionChanged_Public_Void_Single_0;

		// Token: 0x04005F55 RID: 24405
		private static readonly System.IntPtr NativeMethodInfoPtr_EyebrowScaleChanged_Public_Void_Single_0;

		// Token: 0x04005F56 RID: 24406
		private static readonly System.IntPtr NativeMethodInfoPtr_EyebrowThicknessChanged_Public_Void_Single_0;

		// Token: 0x04005F57 RID: 24407
		private static readonly System.IntPtr NativeMethodInfoPtr_EyebrowRestingHeightChanged_Public_Void_Single_0;

		// Token: 0x04005F58 RID: 24408
		private static readonly System.IntPtr NativeMethodInfoPtr_EyebrowRestingAngleChanged_Public_Void_Single_0;

		// Token: 0x04005F59 RID: 24409
		private static readonly System.IntPtr NativeMethodInfoPtr_PupilDilationChanged_Public_Void_Single_0;

		// Token: 0x04005F5A RID: 24410
		private static readonly System.IntPtr NativeMethodInfoPtr_FaceLayerChanged_Public_Void_FaceLayer_Int32_0;

		// Token: 0x04005F5B RID: 24411
		private static readonly System.IntPtr NativeMethodInfoPtr_FaceLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005F5C RID: 24412
		private static readonly System.IntPtr NativeMethodInfoPtr_BodyLayerChanged_Public_Void_AvatarLayer_Int32_0;

		// Token: 0x04005F5D RID: 24413
		private static readonly System.IntPtr NativeMethodInfoPtr_BodyLayerColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005F5E RID: 24414
		private static readonly System.IntPtr NativeMethodInfoPtr_AccessoryChanged_Public_Void_Accessory_Int32_0;

		// Token: 0x04005F5F RID: 24415
		private static readonly System.IntPtr NativeMethodInfoPtr_AccessoryColorChanged_Public_Void_Color_Int32_0;

		// Token: 0x04005F60 RID: 24416
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5E RID: 2910
		public sealed class AvatarSettingsChanged : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600DBBC RID: 56252 RVA: 0x00347008 File Offset: 0x00345208
			// Note: this type is marked as 'beforefieldinit'.
			static AvatarSettingsChanged()
			{
				Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomizationManager>.NativeClassPtr, "AvatarSettingsChanged");
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680859);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680860);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680861);
				CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr, 100680862);
			}

			// Token: 0x0600DBBD RID: 56253 RVA: 0x0034707C File Offset: 0x0034527C
			[CallerCount(500)]
			[CachedScanResults(RefRangeStart = 85002, RefRangeEnd = 85502, XrefRangeStart = 85002, XrefRangeEnd = 85502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AvatarSettingsChanged(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomizationManager.AvatarSettingsChanged>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBBE RID: 56254 RVA: 0x003470D8 File Offset: 0x003452D8
			[CallerCount(0)]
			public unsafe void Invoke(AvatarSettings settings)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBBF RID: 56255 RVA: 0x0034711C File Offset: 0x0034531C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(AvatarSettings settings, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600DBC0 RID: 56256 RVA: 0x00347190 File Offset: 0x00345390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomizationManager.AvatarSettingsChanged.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DBC1 RID: 56257 RVA: 0x0006A9C7 File Offset: 0x00068BC7
			public AvatarSettingsChanged(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DBC2 RID: 56258 RVA: 0x0006A9D0 File Offset: 0x00068BD0
			public static implicit operator CustomizationManager.AvatarSettingsChanged(System.Action<AvatarSettings> A_0)
			{
				return DelegateSupport.ConvertDelegate<CustomizationManager.AvatarSettingsChanged>(A_0);
			}

			// Token: 0x0600DBC3 RID: 56259 RVA: 0x0006A9D8 File Offset: 0x00068BD8
			public static CustomizationManager.AvatarSettingsChanged operator +(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<CustomizationManager.AvatarSettingsChanged>();
			}

			// Token: 0x0600DBC4 RID: 56260 RVA: 0x0006A9E6 File Offset: 0x00068BE6
			public static CustomizationManager.AvatarSettingsChanged operator -(CustomizationManager.AvatarSettingsChanged A_0, CustomizationManager.AvatarSettingsChanged A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<CustomizationManager.AvatarSettingsChanged>();
				}
				return result;
			}

			// Token: 0x040093DD RID: 37853
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040093DE RID: 37854
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AvatarSettings_0;

			// Token: 0x040093DF RID: 37855
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AvatarSettings_AsyncCallback_Object_0;

			// Token: 0x040093E0 RID: 37856
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
