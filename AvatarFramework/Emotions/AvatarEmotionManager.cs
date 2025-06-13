using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x0200062B RID: 1579
	public class AvatarEmotionManager : MonoBehaviour
	{
		// Token: 0x06008A32 RID: 35378 RVA: 0x00248CF0 File Offset: 0x00246EF0
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarEmotionManager()
		{
			Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "AvatarEmotionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr);
			AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "MAX_UPDATE_DISTANCE");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotion>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<CurrentEmotionPreset>k__BackingField");
			AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EmotionPresetList");
			AvatarEmotionManager.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "Avatar");
			AvatarEmotionManager.NativeFieldInfoPtr_EyeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyeController");
			AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "EyebrowController");
			AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "activeEmotionOverride");
			AvatarEmotionManager.NativeFieldInfoPtr_overrideStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "overrideStack");
			AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "neutralPreset");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionLerpRoutine");
			AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "emotionRemovalRoutines");
			AvatarEmotionManager.NativeFieldInfoPtr_tempIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "tempIndex");
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680616);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680617);
			AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680618);
			AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680619);
			AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680620);
			AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680621);
			AvatarEmotionManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680622);
			AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680623);
			AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680624);
			AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680625);
			AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680626);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680627);
			AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680628);
			AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680629);
			AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680630);
			AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680631);
			AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680632);
			AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680633);
			AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, 100680634);
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x06008A33 RID: 35379 RVA: 0x00248FA0 File Offset: 0x002471A0
		// (set) Token: 0x06008A34 RID: 35380 RVA: 0x00248FD8 File Offset: 0x002471D8
		public unsafe string CurrentEmotion
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x06008A35 RID: 35381 RVA: 0x0024901C File Offset: 0x0024721C
		// (set) Token: 0x06008A36 RID: 35382 RVA: 0x0024905C File Offset: 0x0024725C
		public unsafe AvatarEmotionPreset CurrentEmotionPreset
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x06008A37 RID: 35383 RVA: 0x002490A0 File Offset: 0x002472A0
		public unsafe bool IsSwitchingEmotion
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 255826, RefRangeEnd = 255829, XrefRangeStart = 255826, XrefRangeEnd = 255826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06008A38 RID: 35384 RVA: 0x002490DC File Offset: 0x002472DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255829, XrefRangeEnd = 255855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A39 RID: 35385 RVA: 0x00249110 File Offset: 0x00247310
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A3A RID: 35386 RVA: 0x00249144 File Offset: 0x00247344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255855, XrefRangeEnd = 255915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEmotion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_UpdateEmotion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A3B RID: 35387 RVA: 0x00249178 File Offset: 0x00247378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255938, RefRangeEnd = 255940, XrefRangeStart = 255915, XrefRangeEnd = 255938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(faceTex);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref restingBrowHeight;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref restingBrowAngle;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref leftEyelidConfig;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rightEyelidConfig;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A3C RID: 35388 RVA: 0x002491F4 File Offset: 0x002473F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255940, XrefRangeEnd = 255983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotionName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(overrideLabel);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AvatarEmotionManager.NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A3D RID: 35389 RVA: 0x00249270 File Offset: 0x00247470
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 256001, RefRangeEnd = 256024, XrefRangeStart = 255983, XrefRangeEnd = 256001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEmotionOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A3E RID: 35390 RVA: 0x002492B4 File Offset: 0x002474B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256032, RefRangeEnd = 256034, XrefRangeStart = 256024, XrefRangeEnd = 256032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrides()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearOverrides_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A3F RID: 35391 RVA: 0x002492E8 File Offset: 0x002474E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256047, RefRangeEnd = 256049, XrefRangeStart = 256034, XrefRangeEnd = 256047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearRemovalRoutine(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A40 RID: 35392 RVA: 0x0024932C File Offset: 0x0024752C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256049, XrefRangeEnd = 256073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride GetHighestPriorityOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr2) : null;
		}

		// Token: 0x06008A41 RID: 35393 RVA: 0x0024936C File Offset: 0x0024756C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256073, XrefRangeEnd = 256091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref animationTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A42 RID: 35394 RVA: 0x002493BC File Offset: 0x002475BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256115, RefRangeEnd = 256117, XrefRangeStart = 256091, XrefRangeEnd = 256115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEmotion(AvatarEmotionPreset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A43 RID: 35395 RVA: 0x00249400 File Offset: 0x00247600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256118, RefRangeEnd = 256119, XrefRangeStart = 256117, XrefRangeEnd = 256118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008A44 RID: 35396 RVA: 0x00249450 File Offset: 0x00247650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256134, RefRangeEnd = 256136, XrefRangeStart = 256119, XrefRangeEnd = 256134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionPreset GetEmotion(string emotion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
		}

		// Token: 0x06008A45 RID: 35397 RVA: 0x002494A0 File Offset: 0x002476A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256136, XrefRangeEnd = 256162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEmotionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A46 RID: 35398 RVA: 0x00041993 File Offset: 0x0003FB93
		public AvatarEmotionManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x06008A47 RID: 35399 RVA: 0x002494DC File Offset: 0x002476DC
		// (set) Token: 0x06008A48 RID: 35400 RVA: 0x0004199C File Offset: 0x0003FB9C
		public unsafe static float MAX_UPDATE_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.NativeFieldInfoPtr_MAX_UPDATE_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x06008A49 RID: 35401 RVA: 0x002494F8 File Offset: 0x002476F8
		// (set) Token: 0x06008A4A RID: 35402 RVA: 0x000419AA File Offset: 0x0003FBAA
		public unsafe string _CurrentEmotion_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x06008A4B RID: 35403 RVA: 0x00249520 File Offset: 0x00247720
		// (set) Token: 0x06008A4C RID: 35404 RVA: 0x000419C9 File Offset: 0x0003FBC9
		public unsafe AvatarEmotionPreset _CurrentEmotionPreset_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x00249550 File Offset: 0x00247750
		// (set) Token: 0x06008A4E RID: 35406 RVA: 0x000419E8 File Offset: 0x0003FBE8
		public unsafe List<AvatarEmotionPreset> EmotionPresetList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AvatarEmotionPreset>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EmotionPresetList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x00249580 File Offset: 0x00247780
		// (set) Token: 0x06008A50 RID: 35408 RVA: 0x00041A07 File Offset: 0x0003FC07
		public unsafe Avatar Avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x06008A51 RID: 35409 RVA: 0x002495B0 File Offset: 0x002477B0
		// (set) Token: 0x06008A52 RID: 35410 RVA: 0x00041A26 File Offset: 0x0003FC26
		public unsafe EyeController EyeController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x06008A53 RID: 35411 RVA: 0x002495E0 File Offset: 0x002477E0
		// (set) Token: 0x06008A54 RID: 35412 RVA: 0x00041A45 File Offset: 0x0003FC45
		public unsafe EyebrowController EyebrowController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyebrowController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_EyebrowController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06008A55 RID: 35413 RVA: 0x00249610 File Offset: 0x00247810
		// (set) Token: 0x06008A56 RID: 35414 RVA: 0x00041A64 File Offset: 0x0003FC64
		public unsafe EmotionOverride activeEmotionOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmotionOverride>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_activeEmotionOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x06008A57 RID: 35415 RVA: 0x00249640 File Offset: 0x00247840
		// (set) Token: 0x06008A58 RID: 35416 RVA: 0x00041A83 File Offset: 0x0003FC83
		public unsafe List<EmotionOverride> overrideStack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmotionOverride>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_overrideStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x06008A59 RID: 35417 RVA: 0x00249670 File Offset: 0x00247870
		// (set) Token: 0x06008A5A RID: 35418 RVA: 0x00041AA2 File Offset: 0x0003FCA2
		public unsafe AvatarEmotionPreset neutralPreset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_neutralPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x06008A5B RID: 35419 RVA: 0x002496A0 File Offset: 0x002478A0
		// (set) Token: 0x06008A5C RID: 35420 RVA: 0x00041AC1 File Offset: 0x0003FCC1
		public unsafe Coroutine emotionLerpRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionLerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x002496D0 File Offset: 0x002478D0
		// (set) Token: 0x06008A5E RID: 35422 RVA: 0x00041AE0 File Offset: 0x0003FCE0
		public unsafe Dictionary<string, Coroutine> emotionRemovalRoutines
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Coroutine>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_emotionRemovalRoutines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x06008A5F RID: 35423 RVA: 0x00249700 File Offset: 0x00247900
		// (set) Token: 0x06008A60 RID: 35424 RVA: 0x00041AFF File Offset: 0x0003FCFF
		public unsafe int tempIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.NativeFieldInfoPtr_tempIndex)) = value;
			}
		}

		// Token: 0x04005DF5 RID: 24053
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_UPDATE_DISTANCE;

		// Token: 0x04005DF6 RID: 24054
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentEmotion_k__BackingField;

		// Token: 0x04005DF7 RID: 24055
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentEmotionPreset_k__BackingField;

		// Token: 0x04005DF8 RID: 24056
		private static readonly System.IntPtr NativeFieldInfoPtr_EmotionPresetList;

		// Token: 0x04005DF9 RID: 24057
		private static readonly System.IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005DFA RID: 24058
		private static readonly System.IntPtr NativeFieldInfoPtr_EyeController;

		// Token: 0x04005DFB RID: 24059
		private static readonly System.IntPtr NativeFieldInfoPtr_EyebrowController;

		// Token: 0x04005DFC RID: 24060
		private static readonly System.IntPtr NativeFieldInfoPtr_activeEmotionOverride;

		// Token: 0x04005DFD RID: 24061
		private static readonly System.IntPtr NativeFieldInfoPtr_overrideStack;

		// Token: 0x04005DFE RID: 24062
		private static readonly System.IntPtr NativeFieldInfoPtr_neutralPreset;

		// Token: 0x04005DFF RID: 24063
		private static readonly System.IntPtr NativeFieldInfoPtr_emotionLerpRoutine;

		// Token: 0x04005E00 RID: 24064
		private static readonly System.IntPtr NativeFieldInfoPtr_emotionRemovalRoutines;

		// Token: 0x04005E01 RID: 24065
		private static readonly System.IntPtr NativeFieldInfoPtr_tempIndex;

		// Token: 0x04005E02 RID: 24066
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentEmotion_Public_get_String_0;

		// Token: 0x04005E03 RID: 24067
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentEmotion_Protected_set_Void_String_0;

		// Token: 0x04005E04 RID: 24068
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentEmotionPreset_Public_get_AvatarEmotionPreset_0;

		// Token: 0x04005E05 RID: 24069
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentEmotionPreset_Protected_set_Void_AvatarEmotionPreset_0;

		// Token: 0x04005E06 RID: 24070
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSwitchingEmotion_Public_get_Boolean_0;

		// Token: 0x04005E07 RID: 24071
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005E08 RID: 24072
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005E09 RID: 24073
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEmotion_Public_Void_0;

		// Token: 0x04005E0A RID: 24074
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureNeutralFace_Public_Void_Texture2D_Single_Single_EyeLidConfiguration_EyeLidConfiguration_0;

		// Token: 0x04005E0B RID: 24075
		private static readonly System.IntPtr NativeMethodInfoPtr_AddEmotionOverride_Public_Virtual_New_Void_String_String_Single_Int32_0;

		// Token: 0x04005E0C RID: 24076
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEmotionOverride_Public_Void_String_0;

		// Token: 0x04005E0D RID: 24077
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearOverrides_Public_Void_0;

		// Token: 0x04005E0E RID: 24078
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearRemovalRoutine_Private_Void_String_0;

		// Token: 0x04005E0F RID: 24079
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHighestPriorityOverride_Public_EmotionOverride_0;

		// Token: 0x04005E10 RID: 24080
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpEmotion_Private_Void_AvatarEmotionPreset_Single_0;

		// Token: 0x04005E11 RID: 24081
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEmotion_Private_Void_AvatarEmotionPreset_0;

		// Token: 0x04005E12 RID: 24082
		private static readonly System.IntPtr NativeMethodInfoPtr_HasEmotion_Public_Boolean_String_0;

		// Token: 0x04005E13 RID: 24083
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEmotion_Public_AvatarEmotionPreset_String_0;

		// Token: 0x04005E14 RID: 24084
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B4A RID: 2890
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DB3C RID: 56124 RVA: 0x003458F8 File Offset: 0x00343AF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr);
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__21_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__24_0");
				AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, "<>9__29_0");
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680636);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680637);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680638);
				AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr, 100680639);
			}

			// Token: 0x0600DB3D RID: 56125 RVA: 0x003459C4 File Offset: 0x00343BC4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB3E RID: 56126 RVA: 0x00345A00 File Offset: 0x00343C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255784, XrefRangeEnd = 255788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Start_b__21_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB3F RID: 56127 RVA: 0x00345A50 File Offset: 0x00343C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255788, XrefRangeEnd = 255792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ConfigureNeutralFace_b__24_0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB40 RID: 56128 RVA: 0x00345AA0 File Offset: 0x00343CA0
			[CallerCount(0)]
			public unsafe int _GetHighestPriorityOverride_b__29_0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c.NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB41 RID: 56129 RVA: 0x0006A5FA File Offset: 0x000687FA
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A5 RID: 17317
			// (get) Token: 0x0600DB42 RID: 56130 RVA: 0x00345AF0 File Offset: 0x00343CF0
			// (set) Token: 0x0600DB43 RID: 56131 RVA: 0x0006A603 File Offset: 0x00068803
			public unsafe static AvatarEmotionManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A6 RID: 17318
			// (get) Token: 0x0600DB44 RID: 56132 RVA: 0x00345B18 File Offset: 0x00343D18
			// (set) Token: 0x0600DB45 RID: 56133 RVA: 0x0006A615 File Offset: 0x00068815
			public unsafe static Il2CppSystem.Predicate<AvatarEmotionPreset> __9__21_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A7 RID: 17319
			// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x00345B40 File Offset: 0x00343D40
			// (set) Token: 0x0600DB47 RID: 56135 RVA: 0x0006A627 File Offset: 0x00068827
			public unsafe static Il2CppSystem.Predicate<AvatarEmotionPreset> __9__24_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<AvatarEmotionPreset>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043A8 RID: 17320
			// (get) Token: 0x0600DB48 RID: 56136 RVA: 0x00345B68 File Offset: 0x00343D68
			// (set) Token: 0x0600DB49 RID: 56137 RVA: 0x0006A639 File Offset: 0x00068839
			public unsafe static Il2CppSystem.Func<EmotionOverride, int> __9__29_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<EmotionOverride, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AvatarEmotionManager.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009388 RID: 37768
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009389 RID: 37769
			private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x0400938A RID: 37770
			private static readonly System.IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x0400938B RID: 37771
			private static readonly System.IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400938C RID: 37772
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400938D RID: 37773
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__21_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x0400938E RID: 37774
			private static readonly System.IntPtr NativeMethodInfoPtr__ConfigureNeutralFace_b__24_0_Internal_Boolean_AvatarEmotionPreset_0;

			// Token: 0x0400938F RID: 37775
			private static readonly System.IntPtr NativeMethodInfoPtr__GetHighestPriorityOverride_b__29_0_Internal_Int32_EmotionOverride_0;
		}

		// Token: 0x02000B4B RID: 2891
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB4A RID: 56138 RVA: 0x00345B90 File Offset: 0x00343D90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "overrideLabel");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "duration");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680640);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680641);
				AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, 100680642);
			}

			// Token: 0x0600DB4B RID: 56139 RVA: 0x00345C34 File Offset: 0x00343E34
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB4C RID: 56140 RVA: 0x00345C70 File Offset: 0x00343E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB4D RID: 56141 RVA: 0x00345CC0 File Offset: 0x00343EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255802, XrefRangeEnd = 255807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DB4E RID: 56142 RVA: 0x0006A64B File Offset: 0x0006884B
			public __c__DisplayClass25_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043A9 RID: 17321
			// (get) Token: 0x0600DB4F RID: 56143 RVA: 0x00345D00 File Offset: 0x00343F00
			// (set) Token: 0x0600DB50 RID: 56144 RVA: 0x0006A654 File Offset: 0x00068854
			public unsafe string overrideLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_overrideLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170043AA RID: 17322
			// (get) Token: 0x0600DB51 RID: 56145 RVA: 0x00345D28 File Offset: 0x00343F28
			// (set) Token: 0x0600DB52 RID: 56146 RVA: 0x0006A673 File Offset: 0x00068873
			public unsafe float duration
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170043AB RID: 17323
			// (get) Token: 0x0600DB53 RID: 56147 RVA: 0x00345D50 File Offset: 0x00343F50
			// (set) Token: 0x0600DB54 RID: 56148 RVA: 0x0006A68E File Offset: 0x0006888E
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009390 RID: 37776
			private static readonly System.IntPtr NativeFieldInfoPtr_overrideLabel;

			// Token: 0x04009391 RID: 37777
			private static readonly System.IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04009392 RID: 37778
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009393 RID: 37779
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009394 RID: 37780
			private static readonly System.IntPtr NativeMethodInfoPtr__AddEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;

			// Token: 0x04009395 RID: 37781
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CC5 RID: 3269
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass25_0+<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA4B RID: 59979 RVA: 0x00370D80 File Offset: 0x0036EF80
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0>.NativeClassPtr, "<<AddEmotionOverride>g__RemoveEmotionAfterDuration|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680643);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680644);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680645);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680646);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680647);
					AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680648);
				}

				// Token: 0x0600EA4C RID: 59980 RVA: 0x00370E60 File Offset: 0x0036F060
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA4D RID: 59981 RVA: 0x00370EA8 File Offset: 0x0036F0A8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA4E RID: 59982 RVA: 0x00370EDC File Offset: 0x0036F0DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255792, XrefRangeEnd = 255797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004879 RID: 18553
				// (get) Token: 0x0600EA4F RID: 59983 RVA: 0x00370F18 File Offset: 0x0036F118
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA50 RID: 59984 RVA: 0x00370F58 File Offset: 0x0036F158
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255797, XrefRangeEnd = 255802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700487A RID: 18554
				// (get) Token: 0x0600EA51 RID: 59985 RVA: 0x00370F8C File Offset: 0x0036F18C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA52 RID: 59986 RVA: 0x00071ECC File Offset: 0x000700CC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004876 RID: 18550
				// (get) Token: 0x0600EA53 RID: 59987 RVA: 0x00370FCC File Offset: 0x0036F1CC
				// (set) Token: 0x0600EA54 RID: 59988 RVA: 0x00071ED5 File Offset: 0x000700D5
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004877 RID: 18551
				// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x00370FF4 File Offset: 0x0036F1F4
				// (set) Token: 0x0600EA56 RID: 59990 RVA: 0x00071EF0 File Offset: 0x000700F0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004878 RID: 18552
				// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x00371024 File Offset: 0x0036F224
				// (set) Token: 0x0600EA58 RID: 59992 RVA: 0x00071F0F File Offset: 0x0007010F
				public unsafe AvatarEmotionManager.__c__DisplayClass25_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009CC1 RID: 40129
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CC2 RID: 40130
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CC3 RID: 40131
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CC4 RID: 40132
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CC5 RID: 40133
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CC6 RID: 40134
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CC7 RID: 40135
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CC8 RID: 40136
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CC9 RID: 40137
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B4C RID: 2892
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB55 RID: 56149 RVA: 0x00345D80 File Offset: 0x00343F80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, "label");
				AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, 100680649);
				AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr, 100680650);
			}

			// Token: 0x0600DB56 RID: 56150 RVA: 0x00345DE8 File Offset: 0x00343FE8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass26_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB57 RID: 56151 RVA: 0x00345E24 File Offset: 0x00344024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveEmotionOverride_b__0(EmotionOverride x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass26_0.NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB58 RID: 56152 RVA: 0x0006A6AD File Offset: 0x000688AD
			public __c__DisplayClass26_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AC RID: 17324
			// (get) Token: 0x0600DB59 RID: 56153 RVA: 0x00345E74 File Offset: 0x00344074
			// (set) Token: 0x0600DB5A RID: 56154 RVA: 0x0006A6B6 File Offset: 0x000688B6
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass26_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009396 RID: 37782
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009397 RID: 37783
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009398 RID: 37784
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveEmotionOverride_b__0_Internal_Boolean_EmotionOverride_0;
		}

		// Token: 0x02000B4D RID: 2893
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB5B RID: 56155 RVA: 0x00345E9C File Offset: 0x0034409C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "preset");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "animationTime");
				AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, 100680651);
				AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, 100680652);
			}

			// Token: 0x0600DB5C RID: 56156 RVA: 0x00345F2C File Offset: 0x0034412C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB5D RID: 56157 RVA: 0x00345F68 File Offset: 0x00344168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255821, XrefRangeEnd = 255826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DB5E RID: 56158 RVA: 0x0006A6D5 File Offset: 0x000688D5
			public __c__DisplayClass30_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043AD RID: 17325
			// (get) Token: 0x0600DB5F RID: 56159 RVA: 0x00345FA8 File Offset: 0x003441A8
			// (set) Token: 0x0600DB60 RID: 56160 RVA: 0x0006A6DE File Offset: 0x000688DE
			public unsafe AvatarEmotionManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AE RID: 17326
			// (get) Token: 0x0600DB61 RID: 56161 RVA: 0x00345FD8 File Offset: 0x003441D8
			// (set) Token: 0x0600DB62 RID: 56162 RVA: 0x0006A6FD File Offset: 0x000688FD
			public unsafe AvatarEmotionPreset preset
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043AF RID: 17327
			// (get) Token: 0x0600DB63 RID: 56163 RVA: 0x00346008 File Offset: 0x00344208
			// (set) Token: 0x0600DB64 RID: 56164 RVA: 0x0006A71C File Offset: 0x0006891C
			public unsafe float animationTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.NativeFieldInfoPtr_animationTime)) = value;
				}
			}

			// Token: 0x04009399 RID: 37785
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400939A RID: 37786
			private static readonly System.IntPtr NativeFieldInfoPtr_preset;

			// Token: 0x0400939B RID: 37787
			private static readonly System.IntPtr NativeFieldInfoPtr_animationTime;

			// Token: 0x0400939C RID: 37788
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400939D RID: 37789
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CC6 RID: 3270
			[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass30_0+<<LerpEmotion>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EA59 RID: 59993 RVA: 0x00371054 File Offset: 0x0036F254
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique()
				{
					Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0>.NativeClassPtr, "<<LerpEmotion>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>1__state");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>2__current");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<>4__this");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<startPreset>5__2");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<timeStep>5__3");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, "<i>5__4");
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680653);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680654);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680655);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680656);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680657);
					AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr, 100680658);
				}

				// Token: 0x0600EA5A RID: 59994 RVA: 0x00371170 File Offset: 0x0036F370
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA5B RID: 59995 RVA: 0x003711B8 File Offset: 0x0036F3B8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EA5C RID: 59996 RVA: 0x003711EC File Offset: 0x0036F3EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255807, XrefRangeEnd = 255816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004881 RID: 18561
				// (get) Token: 0x0600EA5D RID: 59997 RVA: 0x00371228 File Offset: 0x0036F428
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA5E RID: 59998 RVA: 0x00371268 File Offset: 0x0036F468
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255816, XrefRangeEnd = 255821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004882 RID: 18562
				// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x0037129C File Offset: 0x0036F49C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EA60 RID: 60000 RVA: 0x00071F2E File Offset: 0x0007012E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700487B RID: 18555
				// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x003712DC File Offset: 0x0036F4DC
				// (set) Token: 0x0600EA62 RID: 60002 RVA: 0x00071F37 File Offset: 0x00070137
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700487C RID: 18556
				// (get) Token: 0x0600EA63 RID: 60003 RVA: 0x00371304 File Offset: 0x0036F504
				// (set) Token: 0x0600EA64 RID: 60004 RVA: 0x00071F52 File Offset: 0x00070152
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700487D RID: 18557
				// (get) Token: 0x0600EA65 RID: 60005 RVA: 0x00371334 File Offset: 0x0036F534
				// (set) Token: 0x0600EA66 RID: 60006 RVA: 0x00071F71 File Offset: 0x00070171
				public unsafe AvatarEmotionManager.__c__DisplayClass30_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionManager.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700487E RID: 18558
				// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x00371364 File Offset: 0x0036F564
				// (set) Token: 0x0600EA68 RID: 60008 RVA: 0x00071F90 File Offset: 0x00070190
				public unsafe AvatarEmotionPreset _startPreset_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEmotionPreset>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__startPreset_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700487F RID: 18559
				// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x00371394 File Offset: 0x0036F594
				// (set) Token: 0x0600EA6A RID: 60010 RVA: 0x00071FAF File Offset: 0x000701AF
				public unsafe float _timeStep_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__timeStep_5__3)) = value;
					}
				}

				// Token: 0x17004880 RID: 18560
				// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x003713BC File Offset: 0x0036F5BC
				// (set) Token: 0x0600EA6C RID: 60012 RVA: 0x00071FCA File Offset: 0x000701CA
				public unsafe float _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAvSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009CCA RID: 40138
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009CCB RID: 40139
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009CCC RID: 40140
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009CCD RID: 40141
				private static readonly System.IntPtr NativeFieldInfoPtr__startPreset_5__2;

				// Token: 0x04009CCE RID: 40142
				private static readonly System.IntPtr NativeFieldInfoPtr__timeStep_5__3;

				// Token: 0x04009CCF RID: 40143
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009CD0 RID: 40144
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009CD1 RID: 40145
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CD2 RID: 40146
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009CD3 RID: 40147
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009CD4 RID: 40148
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009CD5 RID: 40149
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B4E RID: 2894
		[ObfuscatedName("ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB65 RID: 56165 RVA: 0x00346030 File Offset: 0x00344230
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AvatarEmotionManager>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr);
				AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, "emotion");
				AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, 100680659);
				AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr, 100680660);
			}

			// Token: 0x0600DB66 RID: 56166 RVA: 0x00346098 File Offset: 0x00344298
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarEmotionManager.__c__DisplayClass33_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB67 RID: 56167 RVA: 0x003460D4 File Offset: 0x003442D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEmotion_b__0(AvatarEmotionPreset x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarEmotionManager.__c__DisplayClass33_0.NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB68 RID: 56168 RVA: 0x0006A737 File Offset: 0x00068937
			public __c__DisplayClass33_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B0 RID: 17328
			// (get) Token: 0x0600DB69 RID: 56169 RVA: 0x00346124 File Offset: 0x00344324
			// (set) Token: 0x0600DB6A RID: 56170 RVA: 0x0006A740 File Offset: 0x00068940
			public unsafe string emotion
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarEmotionManager.__c__DisplayClass33_0.NativeFieldInfoPtr_emotion), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400939E RID: 37790
			private static readonly System.IntPtr NativeFieldInfoPtr_emotion;

			// Token: 0x0400939F RID: 37791
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093A0 RID: 37792
			private static readonly System.IntPtr NativeMethodInfoPtr__GetEmotion_b__0_Internal_Boolean_AvatarEmotionPreset_0;
		}
	}
}
