using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x0200061C RID: 1564
	public class EyeController : MonoBehaviour
	{
		// Token: 0x060088D1 RID: 35025 RVA: 0x0024509C File Offset: 0x0024329C
		// Note: this type is marked as 'beforefieldinit'.
		static EyeController()
		{
			Il2CppClassPointerStore<EyeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "EyeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController>.NativeClassPtr);
			EyeController.NativeFieldInfoPtr_eyeHeightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeightMultiplier");
			EyeController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "DEBUG");
			EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<EyesOpen>k__BackingField");
			EyeController.NativeFieldInfoPtr_leftEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEye");
			EyeController.NativeFieldInfoPtr_rightEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEye");
			EyeController.NativeFieldInfoPtr_eyeSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSpacing");
			EyeController.NativeFieldInfoPtr_eyeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeHeight");
			EyeController.NativeFieldInfoPtr_eyeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeSize");
			EyeController.NativeFieldInfoPtr_leftEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "leftEyeLidColor");
			EyeController.NativeFieldInfoPtr_rightEyeLidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "rightEyeLidColor");
			EyeController.NativeFieldInfoPtr_LeftRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "LeftRestingEyeState");
			EyeController.NativeFieldInfoPtr_RightRestingEyeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "RightRestingEyeState");
			EyeController.NativeFieldInfoPtr_eyeBallMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallMaterial");
			EyeController.NativeFieldInfoPtr_eyeBallColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallColor");
			EyeController.NativeFieldInfoPtr_PupilDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "PupilDilation");
			EyeController.NativeFieldInfoPtr_BlinkingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "BlinkingEnabled");
			EyeController.NativeFieldInfoPtr_blinkInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkInterval");
			EyeController.NativeFieldInfoPtr_blinkIntervalSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkIntervalSpread");
			EyeController.NativeFieldInfoPtr_blinkDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkDuration");
			EyeController.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "avatar");
			EyeController.NativeFieldInfoPtr_blinkRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "blinkRoutine");
			EyeController.NativeFieldInfoPtr_timeUntilNextBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "timeUntilNextBlink");
			EyeController.NativeFieldInfoPtr_eyeBallTintOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeBallTintOverridden");
			EyeController.NativeFieldInfoPtr_eyeLidOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "eyeLidOverridden");
			EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultLeftEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultRightEyeRestingState");
			EyeController.NativeFieldInfoPtr_defaultDilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "defaultDilation");
			EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680481);
			EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680482);
			EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680483);
			EyeController.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680484);
			EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680485);
			EyeController.NativeMethodInfoPtr_ApplySettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680486);
			EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680487);
			EyeController.NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680488);
			EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680489);
			EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680490);
			EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680491);
			EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680492);
			EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680493);
			EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680494);
			EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680495);
			EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680496);
			EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680497);
			EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680498);
			EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680499);
			EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680500);
			EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680501);
			EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680502);
			EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680503);
			EyeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680504);
			EyeController.NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController>.NativeClassPtr, 100680506);
		}

		// Token: 0x17002977 RID: 10615
		// (get) Token: 0x060088D2 RID: 35026 RVA: 0x002454DC File Offset: 0x002436DC
		// (set) Token: 0x060088D3 RID: 35027 RVA: 0x00245518 File Offset: 0x00243718
		public unsafe bool EyesOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060088D4 RID: 35028 RVA: 0x00245558 File Offset: 0x00243758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254905, XrefRangeEnd = 254922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EyeController.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088D5 RID: 35029 RVA: 0x00245594 File Offset: 0x00243794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254922, XrefRangeEnd = 254937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088D6 RID: 35030 RVA: 0x002455C8 File Offset: 0x002437C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254937, XrefRangeEnd = 254940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088D7 RID: 35031 RVA: 0x002455FC File Offset: 0x002437FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254940, XrefRangeEnd = 254970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplySettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088D8 RID: 35032 RVA: 0x00245630 File Offset: 0x00243830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254970, XrefRangeEnd = 254972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyeballTint(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088D9 RID: 35033 RVA: 0x00245670 File Offset: 0x00243870
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254974, RefRangeEnd = 254980, XrefRangeStart = 254972, XrefRangeEnd = 254974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeballTint(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref col;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x002456B0 File Offset: 0x002438B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 254982, RefRangeEnd = 254988, XrefRangeStart = 254980, XrefRangeEnd = 254982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeballTint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x002456E4 File Offset: 0x002438E4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 254988, RefRangeEnd = 254997, XrefRangeStart = 254988, XrefRangeEnd = 254988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideEyeLids(Eye.EyeLidConfiguration eyeLidConfiguration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref eyeLidConfiguration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x00245724 File Offset: 0x00243924
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 254997, RefRangeEnd = 255009, XrefRangeStart = 254997, XrefRangeEnd = 254997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetEyeLids()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetEyeLids_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088DD RID: 35037 RVA: 0x00245758 File Offset: 0x00243958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255009, XrefRangeEnd = 255012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RagdollChange(bool oldValue, bool newValue, bool playStandUpAnim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldValue;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref newValue;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playStandUpAnim;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088DE RID: 35038 RVA: 0x002457B4 File Offset: 0x002439B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255027, RefRangeEnd = 255029, XrefRangeStart = 255012, XrefRangeEnd = 255027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEyesOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088DF RID: 35039 RVA: 0x002457F4 File Offset: 0x002439F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255029, XrefRangeEnd = 255032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyDilation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E0 RID: 35040 RVA: 0x00245828 File Offset: 0x00243A28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 255034, RefRangeEnd = 255040, XrefRangeStart = 255032, XrefRangeEnd = 255034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPupilDilation(float dilation, bool writeDefault = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dilation;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref writeDefault;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E1 RID: 35041 RVA: 0x00245874 File Offset: 0x00243A74
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 255042, RefRangeEnd = 255048, XrefRangeStart = 255040, XrefRangeEnd = 255042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetPupilDilation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E2 RID: 35042 RVA: 0x002458A8 File Offset: 0x00243AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRestingEyeLidState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E3 RID: 35043 RVA: 0x002458DC File Offset: 0x00243ADC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 255051, RefRangeEnd = 255074, XrefRangeStart = 255048, XrefRangeEnd = 255051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceBlink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ForceBlink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E4 RID: 35044 RVA: 0x00245910 File Offset: 0x00243B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255074, XrefRangeEnd = 255075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLeftEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref config;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E5 RID: 35045 RVA: 0x00245950 File Offset: 0x00243B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255075, XrefRangeEnd = 255076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRightEyeRestingLidState(Eye.EyeLidConfiguration config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref config;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x00245990 File Offset: 0x00243B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255076, XrefRangeEnd = 255081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator BlinkRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x002459D0 File Offset: 0x00243BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255081, XrefRangeEnd = 255082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBlinkCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E8 RID: 35048 RVA: 0x00245A04 File Offset: 0x00243C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255084, RefRangeEnd = 255085, XrefRangeStart = 255082, XrefRangeEnd = 255084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookAt(Vector3 position, bool instant = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref instant;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x00245A50 File Offset: 0x00243C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255085, XrefRangeEnd = 255086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EyeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x00245A8C File Offset: 0x00243C8C
		[CallerCount(0)]
		public unsafe bool _BlinkRoutine_b__48_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeController.NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x00040C80 File Offset: 0x0003EE80
		public EyeController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700295C RID: 10588
		// (get) Token: 0x060088EC RID: 35052 RVA: 0x00245AC8 File Offset: 0x00243CC8
		// (set) Token: 0x060088ED RID: 35053 RVA: 0x00040C89 File Offset: 0x0003EE89
		public unsafe static float eyeHeightMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EyeController.NativeFieldInfoPtr_eyeHeightMultiplier, (void*)(&value));
			}
		}

		// Token: 0x1700295D RID: 10589
		// (get) Token: 0x060088EE RID: 35054 RVA: 0x00245AE4 File Offset: 0x00243CE4
		// (set) Token: 0x060088EF RID: 35055 RVA: 0x00040C97 File Offset: 0x0003EE97
		public unsafe bool DEBUG
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x1700295E RID: 10590
		// (get) Token: 0x060088F0 RID: 35056 RVA: 0x00245B0C File Offset: 0x00243D0C
		// (set) Token: 0x060088F1 RID: 35057 RVA: 0x00040CB2 File Offset: 0x0003EEB2
		public unsafe bool _EyesOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr__EyesOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700295F RID: 10591
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x00245B34 File Offset: 0x00243D34
		// (set) Token: 0x060088F3 RID: 35059 RVA: 0x00040CCD File Offset: 0x0003EECD
		public unsafe Eye leftEye
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002960 RID: 10592
		// (get) Token: 0x060088F4 RID: 35060 RVA: 0x00245B64 File Offset: 0x00243D64
		// (set) Token: 0x060088F5 RID: 35061 RVA: 0x00040CEC File Offset: 0x0003EEEC
		public unsafe Eye rightEye
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Eye>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002961 RID: 10593
		// (get) Token: 0x060088F6 RID: 35062 RVA: 0x00245B94 File Offset: 0x00243D94
		// (set) Token: 0x060088F7 RID: 35063 RVA: 0x00040D0B File Offset: 0x0003EF0B
		public unsafe float eyeSpacing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSpacing)) = value;
			}
		}

		// Token: 0x17002962 RID: 10594
		// (get) Token: 0x060088F8 RID: 35064 RVA: 0x00245BBC File Offset: 0x00243DBC
		// (set) Token: 0x060088F9 RID: 35065 RVA: 0x00040D26 File Offset: 0x0003EF26
		public unsafe float eyeHeight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeHeight)) = value;
			}
		}

		// Token: 0x17002963 RID: 10595
		// (get) Token: 0x060088FA RID: 35066 RVA: 0x00245BE4 File Offset: 0x00243DE4
		// (set) Token: 0x060088FB RID: 35067 RVA: 0x00040D41 File Offset: 0x0003EF41
		public unsafe float eyeSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeSize)) = value;
			}
		}

		// Token: 0x17002964 RID: 10596
		// (get) Token: 0x060088FC RID: 35068 RVA: 0x00245C0C File Offset: 0x00243E0C
		// (set) Token: 0x060088FD RID: 35069 RVA: 0x00040D5C File Offset: 0x0003EF5C
		public unsafe Color leftEyeLidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_leftEyeLidColor)) = value;
			}
		}

		// Token: 0x17002965 RID: 10597
		// (get) Token: 0x060088FE RID: 35070 RVA: 0x00245C34 File Offset: 0x00243E34
		// (set) Token: 0x060088FF RID: 35071 RVA: 0x00040D77 File Offset: 0x0003EF77
		public unsafe Color rightEyeLidColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEyeLidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_rightEyeLidColor)) = value;
			}
		}

		// Token: 0x17002966 RID: 10598
		// (get) Token: 0x06008900 RID: 35072 RVA: 0x00245C5C File Offset: 0x00243E5C
		// (set) Token: 0x06008901 RID: 35073 RVA: 0x00040D92 File Offset: 0x0003EF92
		public unsafe Eye.EyeLidConfiguration LeftRestingEyeState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_LeftRestingEyeState)) = value;
			}
		}

		// Token: 0x17002967 RID: 10599
		// (get) Token: 0x06008902 RID: 35074 RVA: 0x00245C84 File Offset: 0x00243E84
		// (set) Token: 0x06008903 RID: 35075 RVA: 0x00040DAD File Offset: 0x0003EFAD
		public unsafe Eye.EyeLidConfiguration RightRestingEyeState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_RightRestingEyeState)) = value;
			}
		}

		// Token: 0x17002968 RID: 10600
		// (get) Token: 0x06008904 RID: 35076 RVA: 0x00245CAC File Offset: 0x00243EAC
		// (set) Token: 0x06008905 RID: 35077 RVA: 0x00040DC8 File Offset: 0x0003EFC8
		public unsafe Material eyeBallMaterial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002969 RID: 10601
		// (get) Token: 0x06008906 RID: 35078 RVA: 0x00245CDC File Offset: 0x00243EDC
		// (set) Token: 0x06008907 RID: 35079 RVA: 0x00040DE7 File Offset: 0x0003EFE7
		public unsafe Color eyeBallColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallColor)) = value;
			}
		}

		// Token: 0x1700296A RID: 10602
		// (get) Token: 0x06008908 RID: 35080 RVA: 0x00245D04 File Offset: 0x00243F04
		// (set) Token: 0x06008909 RID: 35081 RVA: 0x00040E02 File Offset: 0x0003F002
		public unsafe float PupilDilation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_PupilDilation)) = value;
			}
		}

		// Token: 0x1700296B RID: 10603
		// (get) Token: 0x0600890A RID: 35082 RVA: 0x00245D2C File Offset: 0x00243F2C
		// (set) Token: 0x0600890B RID: 35083 RVA: 0x00040E1D File Offset: 0x0003F01D
		public unsafe bool BlinkingEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_BlinkingEnabled)) = value;
			}
		}

		// Token: 0x1700296C RID: 10604
		// (get) Token: 0x0600890C RID: 35084 RVA: 0x00245D54 File Offset: 0x00243F54
		// (set) Token: 0x0600890D RID: 35085 RVA: 0x00040E38 File Offset: 0x0003F038
		public unsafe float blinkInterval
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkInterval)) = value;
			}
		}

		// Token: 0x1700296D RID: 10605
		// (get) Token: 0x0600890E RID: 35086 RVA: 0x00245D7C File Offset: 0x00243F7C
		// (set) Token: 0x0600890F RID: 35087 RVA: 0x00040E53 File Offset: 0x0003F053
		public unsafe float blinkIntervalSpread
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkIntervalSpread)) = value;
			}
		}

		// Token: 0x1700296E RID: 10606
		// (get) Token: 0x06008910 RID: 35088 RVA: 0x00245DA4 File Offset: 0x00243FA4
		// (set) Token: 0x06008911 RID: 35089 RVA: 0x00040E6E File Offset: 0x0003F06E
		public unsafe float blinkDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkDuration)) = value;
			}
		}

		// Token: 0x1700296F RID: 10607
		// (get) Token: 0x06008912 RID: 35090 RVA: 0x00245DCC File Offset: 0x00243FCC
		// (set) Token: 0x06008913 RID: 35091 RVA: 0x00040E89 File Offset: 0x0003F089
		public unsafe Avatar avatar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002970 RID: 10608
		// (get) Token: 0x06008914 RID: 35092 RVA: 0x00245DFC File Offset: 0x00243FFC
		// (set) Token: 0x06008915 RID: 35093 RVA: 0x00040EA8 File Offset: 0x0003F0A8
		public unsafe Coroutine blinkRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_blinkRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002971 RID: 10609
		// (get) Token: 0x06008916 RID: 35094 RVA: 0x00245E2C File Offset: 0x0024402C
		// (set) Token: 0x06008917 RID: 35095 RVA: 0x00040EC7 File Offset: 0x0003F0C7
		public unsafe float timeUntilNextBlink
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_timeUntilNextBlink)) = value;
			}
		}

		// Token: 0x17002972 RID: 10610
		// (get) Token: 0x06008918 RID: 35096 RVA: 0x00245E54 File Offset: 0x00244054
		// (set) Token: 0x06008919 RID: 35097 RVA: 0x00040EE2 File Offset: 0x0003F0E2
		public unsafe bool eyeBallTintOverridden
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeBallTintOverridden)) = value;
			}
		}

		// Token: 0x17002973 RID: 10611
		// (get) Token: 0x0600891A RID: 35098 RVA: 0x00245E7C File Offset: 0x0024407C
		// (set) Token: 0x0600891B RID: 35099 RVA: 0x00040EFD File Offset: 0x0003F0FD
		public unsafe bool eyeLidOverridden
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_eyeLidOverridden)) = value;
			}
		}

		// Token: 0x17002974 RID: 10612
		// (get) Token: 0x0600891C RID: 35100 RVA: 0x00245EA4 File Offset: 0x002440A4
		// (set) Token: 0x0600891D RID: 35101 RVA: 0x00040F18 File Offset: 0x0003F118
		public unsafe Eye.EyeLidConfiguration defaultLeftEyeRestingState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultLeftEyeRestingState)) = value;
			}
		}

		// Token: 0x17002975 RID: 10613
		// (get) Token: 0x0600891E RID: 35102 RVA: 0x00245ECC File Offset: 0x002440CC
		// (set) Token: 0x0600891F RID: 35103 RVA: 0x00040F33 File Offset: 0x0003F133
		public unsafe Eye.EyeLidConfiguration defaultRightEyeRestingState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultRightEyeRestingState)) = value;
			}
		}

		// Token: 0x17002976 RID: 10614
		// (get) Token: 0x06008920 RID: 35104 RVA: 0x00245EF4 File Offset: 0x002440F4
		// (set) Token: 0x06008921 RID: 35105 RVA: 0x00040F4E File Offset: 0x0003F14E
		public unsafe float defaultDilation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController.NativeFieldInfoPtr_defaultDilation)) = value;
			}
		}

		// Token: 0x04005D26 RID: 23846
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeHeightMultiplier;

		// Token: 0x04005D27 RID: 23847
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04005D28 RID: 23848
		private static readonly System.IntPtr NativeFieldInfoPtr__EyesOpen_k__BackingField;

		// Token: 0x04005D29 RID: 23849
		private static readonly System.IntPtr NativeFieldInfoPtr_leftEye;

		// Token: 0x04005D2A RID: 23850
		private static readonly System.IntPtr NativeFieldInfoPtr_rightEye;

		// Token: 0x04005D2B RID: 23851
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeSpacing;

		// Token: 0x04005D2C RID: 23852
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeHeight;

		// Token: 0x04005D2D RID: 23853
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeSize;

		// Token: 0x04005D2E RID: 23854
		private static readonly System.IntPtr NativeFieldInfoPtr_leftEyeLidColor;

		// Token: 0x04005D2F RID: 23855
		private static readonly System.IntPtr NativeFieldInfoPtr_rightEyeLidColor;

		// Token: 0x04005D30 RID: 23856
		private static readonly System.IntPtr NativeFieldInfoPtr_LeftRestingEyeState;

		// Token: 0x04005D31 RID: 23857
		private static readonly System.IntPtr NativeFieldInfoPtr_RightRestingEyeState;

		// Token: 0x04005D32 RID: 23858
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeBallMaterial;

		// Token: 0x04005D33 RID: 23859
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeBallColor;

		// Token: 0x04005D34 RID: 23860
		private static readonly System.IntPtr NativeFieldInfoPtr_PupilDilation;

		// Token: 0x04005D35 RID: 23861
		private static readonly System.IntPtr NativeFieldInfoPtr_BlinkingEnabled;

		// Token: 0x04005D36 RID: 23862
		private static readonly System.IntPtr NativeFieldInfoPtr_blinkInterval;

		// Token: 0x04005D37 RID: 23863
		private static readonly System.IntPtr NativeFieldInfoPtr_blinkIntervalSpread;

		// Token: 0x04005D38 RID: 23864
		private static readonly System.IntPtr NativeFieldInfoPtr_blinkDuration;

		// Token: 0x04005D39 RID: 23865
		private static readonly System.IntPtr NativeFieldInfoPtr_avatar;

		// Token: 0x04005D3A RID: 23866
		private static readonly System.IntPtr NativeFieldInfoPtr_blinkRoutine;

		// Token: 0x04005D3B RID: 23867
		private static readonly System.IntPtr NativeFieldInfoPtr_timeUntilNextBlink;

		// Token: 0x04005D3C RID: 23868
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeBallTintOverridden;

		// Token: 0x04005D3D RID: 23869
		private static readonly System.IntPtr NativeFieldInfoPtr_eyeLidOverridden;

		// Token: 0x04005D3E RID: 23870
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultLeftEyeRestingState;

		// Token: 0x04005D3F RID: 23871
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultRightEyeRestingState;

		// Token: 0x04005D40 RID: 23872
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultDilation;

		// Token: 0x04005D41 RID: 23873
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EyesOpen_Public_get_Boolean_0;

		// Token: 0x04005D42 RID: 23874
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EyesOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04005D43 RID: 23875
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005D44 RID: 23876
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04005D45 RID: 23877
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04005D46 RID: 23878
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplySettings_Public_Void_0;

		// Token: 0x04005D47 RID: 23879
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyeballTint_Public_Void_Color_0;

		// Token: 0x04005D48 RID: 23880
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideEyeballTint_Public_Void_Color_0;

		// Token: 0x04005D49 RID: 23881
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetEyeballTint_Public_Void_0;

		// Token: 0x04005D4A RID: 23882
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideEyeLids_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005D4B RID: 23883
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetEyeLids_Public_Void_0;

		// Token: 0x04005D4C RID: 23884
		private static readonly System.IntPtr NativeMethodInfoPtr_RagdollChange_Private_Void_Boolean_Boolean_Boolean_0;

		// Token: 0x04005D4D RID: 23885
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEyesOpen_Public_Void_Boolean_0;

		// Token: 0x04005D4E RID: 23886
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDilation_Private_Void_0;

		// Token: 0x04005D4F RID: 23887
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPupilDilation_Public_Void_Single_Boolean_0;

		// Token: 0x04005D50 RID: 23888
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetPupilDilation_Public_Void_0;

		// Token: 0x04005D51 RID: 23889
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyRestingEyeLidState_Private_Void_0;

		// Token: 0x04005D52 RID: 23890
		private static readonly System.IntPtr NativeMethodInfoPtr_ForceBlink_Public_Void_0;

		// Token: 0x04005D53 RID: 23891
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLeftEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005D54 RID: 23892
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRightEyeRestingLidState_Public_Void_EyeLidConfiguration_0;

		// Token: 0x04005D55 RID: 23893
		private static readonly System.IntPtr NativeMethodInfoPtr_BlinkRoutine_Private_IEnumerator_0;

		// Token: 0x04005D56 RID: 23894
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetBlinkCounter_Private_Void_0;

		// Token: 0x04005D57 RID: 23895
		private static readonly System.IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Vector3_Boolean_0;

		// Token: 0x04005D58 RID: 23896
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005D59 RID: 23897
		private static readonly System.IntPtr NativeMethodInfoPtr__BlinkRoutine_b__48_0_Private_Boolean_0;

		// Token: 0x02000B41 RID: 2881
		[ObfuscatedName("ScheduleOne.AvatarFramework.EyeController+<BlinkRoutine>d__48")]
		public sealed class _BlinkRoutine_d__48 : Il2CppSystem.Object
		{
			// Token: 0x0600DAD8 RID: 56024 RVA: 0x0034473C File Offset: 0x0034293C
			// Note: this type is marked as 'beforefieldinit'.
			static _BlinkRoutine_d__48()
			{
				Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EyeController>.NativeClassPtr, "<BlinkRoutine>d__48");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr);
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>1__state");
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>2__current");
				EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, "<>4__this");
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680507);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680508);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680509);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680510);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680511);
				EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr, 100680512);
			}

			// Token: 0x0600DAD9 RID: 56025 RVA: 0x0034481C File Offset: 0x00342A1C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BlinkRoutine_d__48(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EyeController._BlinkRoutine_d__48>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DADA RID: 56026 RVA: 0x00344864 File Offset: 0x00342A64
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DADB RID: 56027 RVA: 0x00344898 File Offset: 0x00342A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254895, XrefRangeEnd = 254900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004384 RID: 17284
			// (get) Token: 0x0600DADC RID: 56028 RVA: 0x003448D4 File Offset: 0x00342AD4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DADD RID: 56029 RVA: 0x00344914 File Offset: 0x00342B14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254900, XrefRangeEnd = 254905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004385 RID: 17285
			// (get) Token: 0x0600DADE RID: 56030 RVA: 0x00344948 File Offset: 0x00342B48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EyeController._BlinkRoutine_d__48.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DADF RID: 56031 RVA: 0x0006A283 File Offset: 0x00068483
			public _BlinkRoutine_d__48(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004381 RID: 17281
			// (get) Token: 0x0600DAE0 RID: 56032 RVA: 0x00344988 File Offset: 0x00342B88
			// (set) Token: 0x0600DAE1 RID: 56033 RVA: 0x0006A28C File Offset: 0x0006848C
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004382 RID: 17282
			// (get) Token: 0x0600DAE2 RID: 56034 RVA: 0x003449B0 File Offset: 0x00342BB0
			// (set) Token: 0x0600DAE3 RID: 56035 RVA: 0x0006A2A7 File Offset: 0x000684A7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004383 RID: 17283
			// (get) Token: 0x0600DAE4 RID: 56036 RVA: 0x003449E0 File Offset: 0x00342BE0
			// (set) Token: 0x0600DAE5 RID: 56037 RVA: 0x0006A2C6 File Offset: 0x000684C6
			public unsafe EyeController __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EyeController._BlinkRoutine_d__48.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009348 RID: 37704
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009349 RID: 37705
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400934A RID: 37706
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400934B RID: 37707
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400934C RID: 37708
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400934D RID: 37709
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400934E RID: 37710
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400934F RID: 37711
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009350 RID: 37712
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
