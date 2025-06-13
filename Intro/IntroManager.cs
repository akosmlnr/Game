using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Intro
{
	// Token: 0x0200040F RID: 1039
	public class IntroManager : Singleton<IntroManager>
	{
		// Token: 0x0600549E RID: 21662 RVA: 0x00190DA0 File Offset: 0x0018EFA0
		// Note: this type is marked as 'beforefieldinit'.
		static IntroManager()
		{
			Il2CppClassPointerStore<IntroManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Intro", "IntroManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager>.NativeClassPtr);
			IntroManager.NativeFieldInfoPtr_SKIP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SKIP_TIME");
			IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<IsPlaying>k__BackingField");
			IntroManager.NativeFieldInfoPtr_CurrentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "CurrentStep");
			IntroManager.NativeFieldInfoPtr_TimeOfDayOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "TimeOfDayOverride");
			IntroManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "Container");
			IntroManager.NativeFieldInfoPtr_PlayerInitialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "PlayerInitialPosition");
			IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "PlayerInitialPosition_AfterRVExplosion");
			IntroManager.NativeFieldInfoPtr_CameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "CameraContainer");
			IntroManager.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "Anim");
			IntroManager.NativeFieldInfoPtr_SkipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipContainer");
			IntroManager.NativeFieldInfoPtr_SkipDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "SkipDial");
			IntroManager.NativeFieldInfoPtr_DisableDuringIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "DisableDuringIntro");
			IntroManager.NativeFieldInfoPtr_rv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "rv");
			IntroManager.NativeFieldInfoPtr_onIntroDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "onIntroDone");
			IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "onIntroDoneAsServer");
			IntroManager.NativeFieldInfoPtr_MusicName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "MusicName");
			IntroManager.NativeFieldInfoPtr_currentSkipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "currentSkipTime");
			IntroManager.NativeFieldInfoPtr_depressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "depressed");
			IntroManager.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673957);
			IntroManager.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673958);
			IntroManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673959);
			IntroManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673960);
			IntroManager.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673961);
			IntroManager.NativeMethodInfoPtr_PlayMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673962);
			IntroManager.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673963);
			IntroManager.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673964);
			IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673965);
			IntroManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673966);
			IntroManager.NativeMethodInfoPtr__Play_b__23_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673967);
			IntroManager.NativeMethodInfoPtr__PlayMusic_b__24_0_Private_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, 100673968);
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600549F RID: 21663 RVA: 0x00191028 File Offset: 0x0018F228
		// (set) Token: 0x060054A0 RID: 21664 RVA: 0x00191064 File Offset: 0x0018F264
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x001910A4 File Offset: 0x0018F2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183069, XrefRangeEnd = 183075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntroManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x001910E0 File Offset: 0x0018F2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183075, XrefRangeEnd = 183098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x00191114 File Offset: 0x0018F314
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183162, RefRangeEnd = 183163, XrefRangeStart = 183098, XrefRangeEnd = 183162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x00191148 File Offset: 0x0018F348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183163, XrefRangeEnd = 183181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_PlayMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x0019117C File Offset: 0x0018F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183181, XrefRangeEnd = 183194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothes);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x001911D0 File Offset: 0x0018F3D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183194, RefRangeEnd = 183195, XrefRangeStart = 183194, XrefRangeEnd = 183194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PassedStep(int stepIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stepIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A7 RID: 21671 RVA: 0x00191210 File Offset: 0x0018F410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183195, XrefRangeEnd = 183198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntroManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060054A8 RID: 21672 RVA: 0x0019124C File Offset: 0x0018F44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183198, XrefRangeEnd = 183203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x0019128C File Offset: 0x0018F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183203, XrefRangeEnd = 183204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Play_b__23_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__Play_b__23_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060054AA RID: 21674 RVA: 0x001912C8 File Offset: 0x0018F4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183204, XrefRangeEnd = 183206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayMusic_b__24_0(MusicTrack t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntroManager.NativeMethodInfoPtr__PlayMusic_b__24_0_Private_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x0002821D File Offset: 0x0002641D
		public IntroManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060054AC RID: 21676 RVA: 0x00191318 File Offset: 0x0018F518
		// (set) Token: 0x060054AD RID: 21677 RVA: 0x00028226 File Offset: 0x00026426
		public unsafe static float SKIP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntroManager.NativeFieldInfoPtr_SKIP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntroManager.NativeFieldInfoPtr_SKIP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x00191334 File Offset: 0x0018F534
		// (set) Token: 0x060054AF RID: 21679 RVA: 0x00028234 File Offset: 0x00026434
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060054B0 RID: 21680 RVA: 0x0019135C File Offset: 0x0018F55C
		// (set) Token: 0x060054B1 RID: 21681 RVA: 0x0002824F File Offset: 0x0002644F
		public unsafe int CurrentStep
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CurrentStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CurrentStep)) = value;
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x060054B2 RID: 21682 RVA: 0x00191384 File Offset: 0x0018F584
		// (set) Token: 0x060054B3 RID: 21683 RVA: 0x0002826A File Offset: 0x0002646A
		public unsafe int TimeOfDayOverride
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_TimeOfDayOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_TimeOfDayOverride)) = value;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x060054B4 RID: 21684 RVA: 0x001913AC File Offset: 0x0018F5AC
		// (set) Token: 0x060054B5 RID: 21685 RVA: 0x00028285 File Offset: 0x00026485
		public unsafe GameObject Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x001913DC File Offset: 0x0018F5DC
		// (set) Token: 0x060054B7 RID: 21687 RVA: 0x000282A4 File Offset: 0x000264A4
		public unsafe Transform PlayerInitialPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x060054B8 RID: 21688 RVA: 0x0019140C File Offset: 0x0018F60C
		// (set) Token: 0x060054B9 RID: 21689 RVA: 0x000282C3 File Offset: 0x000264C3
		public unsafe Transform PlayerInitialPosition_AfterRVExplosion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x060054BA RID: 21690 RVA: 0x0019143C File Offset: 0x0018F63C
		// (set) Token: 0x060054BB RID: 21691 RVA: 0x000282E2 File Offset: 0x000264E2
		public unsafe Transform CameraContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CameraContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_CameraContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x060054BC RID: 21692 RVA: 0x0019146C File Offset: 0x0018F66C
		// (set) Token: 0x060054BD RID: 21693 RVA: 0x00028301 File Offset: 0x00026501
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x060054BE RID: 21694 RVA: 0x0019149C File Offset: 0x0018F69C
		// (set) Token: 0x060054BF RID: 21695 RVA: 0x00028320 File Offset: 0x00026520
		public unsafe GameObject SkipContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x060054C0 RID: 21696 RVA: 0x001914CC File Offset: 0x0018F6CC
		// (set) Token: 0x060054C1 RID: 21697 RVA: 0x0002833F File Offset: 0x0002653F
		public unsafe Image SkipDial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipDial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_SkipDial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x060054C2 RID: 21698 RVA: 0x001914FC File Offset: 0x0018F6FC
		// (set) Token: 0x060054C3 RID: 21699 RVA: 0x0002835E File Offset: 0x0002655E
		public unsafe Il2CppReferenceArray<GameObject> DisableDuringIntro
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_DisableDuringIntro);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_DisableDuringIntro), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x0019152C File Offset: 0x0018F72C
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x0002837D File Offset: 0x0002657D
		public unsafe RV rv
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_rv);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RV>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_rv), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x060054C6 RID: 21702 RVA: 0x0019155C File Offset: 0x0018F75C
		// (set) Token: 0x060054C7 RID: 21703 RVA: 0x0002839C File Offset: 0x0002659C
		public unsafe UnityEvent onIntroDone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x0019158C File Offset: 0x0018F78C
		// (set) Token: 0x060054C9 RID: 21705 RVA: 0x000283BB File Offset: 0x000265BB
		public unsafe UnityEvent onIntroDoneAsServer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_onIntroDoneAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x060054CA RID: 21706 RVA: 0x001915BC File Offset: 0x0018F7BC
		// (set) Token: 0x060054CB RID: 21707 RVA: 0x000283DA File Offset: 0x000265DA
		public unsafe string MusicName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_MusicName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_MusicName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x060054CC RID: 21708 RVA: 0x001915E4 File Offset: 0x0018F7E4
		// (set) Token: 0x060054CD RID: 21709 RVA: 0x000283F9 File Offset: 0x000265F9
		public unsafe float currentSkipTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_currentSkipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_currentSkipTime)) = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x060054CE RID: 21710 RVA: 0x0019160C File Offset: 0x0018F80C
		// (set) Token: 0x060054CF RID: 21711 RVA: 0x00028414 File Offset: 0x00026614
		public unsafe bool depressed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_depressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.NativeFieldInfoPtr_depressed)) = value;
			}
		}

		// Token: 0x0400395E RID: 14686
		private static readonly System.IntPtr NativeFieldInfoPtr_SKIP_TIME;

		// Token: 0x0400395F RID: 14687
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04003960 RID: 14688
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentStep;

		// Token: 0x04003961 RID: 14689
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeOfDayOverride;

		// Token: 0x04003962 RID: 14690
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04003963 RID: 14691
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInitialPosition;

		// Token: 0x04003964 RID: 14692
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInitialPosition_AfterRVExplosion;

		// Token: 0x04003965 RID: 14693
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraContainer;

		// Token: 0x04003966 RID: 14694
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04003967 RID: 14695
		private static readonly System.IntPtr NativeFieldInfoPtr_SkipContainer;

		// Token: 0x04003968 RID: 14696
		private static readonly System.IntPtr NativeFieldInfoPtr_SkipDial;

		// Token: 0x04003969 RID: 14697
		private static readonly System.IntPtr NativeFieldInfoPtr_DisableDuringIntro;

		// Token: 0x0400396A RID: 14698
		private static readonly System.IntPtr NativeFieldInfoPtr_rv;

		// Token: 0x0400396B RID: 14699
		private static readonly System.IntPtr NativeFieldInfoPtr_onIntroDone;

		// Token: 0x0400396C RID: 14700
		private static readonly System.IntPtr NativeFieldInfoPtr_onIntroDoneAsServer;

		// Token: 0x0400396D RID: 14701
		private static readonly System.IntPtr NativeFieldInfoPtr_MusicName;

		// Token: 0x0400396E RID: 14702
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSkipTime;

		// Token: 0x0400396F RID: 14703
		private static readonly System.IntPtr NativeFieldInfoPtr_depressed;

		// Token: 0x04003970 RID: 14704
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04003971 RID: 14705
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04003972 RID: 14706
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003973 RID: 14707
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003974 RID: 14708
		private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04003975 RID: 14709
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayMusic_Private_Void_0;

		// Token: 0x04003976 RID: 14710
		private static readonly System.IntPtr NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_List_1_ClothingInstance_0;

		// Token: 0x04003977 RID: 14711
		private static readonly System.IntPtr NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0;

		// Token: 0x04003978 RID: 14712
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003979 RID: 14713
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400397A RID: 14714
		private static readonly System.IntPtr NativeMethodInfoPtr__Play_b__23_2_Private_Boolean_0;

		// Token: 0x0400397B RID: 14715
		private static readonly System.IntPtr NativeMethodInfoPtr__PlayMusic_b__24_0_Private_Boolean_MusicTrack_0;

		// Token: 0x020009FA RID: 2554
		[ObfuscatedName("ScheduleOne.Intro.IntroManager+<<Play>g__Wait|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D0C4 RID: 53444 RVA: 0x00328308 File Offset: 0x00326508
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique()
			{
				Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<<Play>g__Wait|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>1__state");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>2__current");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, "<>4__this");
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673969);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673970);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673971);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673972);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673973);
				IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr, 100673974);
			}

			// Token: 0x0600D0C5 RID: 53445 RVA: 0x003283E8 File Offset: 0x003265E8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0C6 RID: 53446 RVA: 0x00328430 File Offset: 0x00326630
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0C7 RID: 53447 RVA: 0x00328464 File Offset: 0x00326664
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182834, XrefRangeEnd = 182959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040BB RID: 16571
			// (get) Token: 0x0600D0C8 RID: 53448 RVA: 0x003284A0 File Offset: 0x003266A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D0C9 RID: 53449 RVA: 0x003284E0 File Offset: 0x003266E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182959, XrefRangeEnd = 182964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040BC RID: 16572
			// (get) Token: 0x0600D0CA RID: 53450 RVA: 0x00328514 File Offset: 0x00326714
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D0CB RID: 53451 RVA: 0x000653D9 File Offset: 0x000635D9
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040B8 RID: 16568
			// (get) Token: 0x0600D0CC RID: 53452 RVA: 0x00328554 File Offset: 0x00326754
			// (set) Token: 0x0600D0CD RID: 53453 RVA: 0x000653E2 File Offset: 0x000635E2
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040B9 RID: 16569
			// (get) Token: 0x0600D0CE RID: 53454 RVA: 0x0032857C File Offset: 0x0032677C
			// (set) Token: 0x0600D0CF RID: 53455 RVA: 0x000653FD File Offset: 0x000635FD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040BA RID: 16570
			// (get) Token: 0x0600D0D0 RID: 53456 RVA: 0x003285AC File Offset: 0x003267AC
			// (set) Token: 0x0600D0D1 RID: 53457 RVA: 0x0006541C File Offset: 0x0006361C
			public unsafe IntroManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D2F RID: 36143
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D30 RID: 36144
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D31 RID: 36145
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D32 RID: 36146
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D33 RID: 36147
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D34 RID: 36148
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D35 RID: 36149
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D36 RID: 36150
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D37 RID: 36151
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009FB RID: 2555
		[ObfuscatedName("ScheduleOne.Intro.IntroManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0D2 RID: 53458 RVA: 0x003285DC File Offset: 0x003267DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr);
				IntroManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, "<>9");
				IntroManager.__c.NativeFieldInfoPtr___9__23_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, "<>9__23_1");
				IntroManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, 100673976);
				IntroManager.__c.NativeMethodInfoPtr__Play_b__23_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr, 100673977);
			}

			// Token: 0x0600D0D3 RID: 53459 RVA: 0x00328658 File Offset: 0x00326858
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0D4 RID: 53460 RVA: 0x00328694 File Offset: 0x00326894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182964, XrefRangeEnd = 182968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Play_b__23_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c.NativeMethodInfoPtr__Play_b__23_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D0D5 RID: 53461 RVA: 0x0006543B File Offset: 0x0006363B
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BD RID: 16573
			// (get) Token: 0x0600D0D6 RID: 53462 RVA: 0x003286D0 File Offset: 0x003268D0
			// (set) Token: 0x0600D0D7 RID: 53463 RVA: 0x00065444 File Offset: 0x00063644
			public unsafe static IntroManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntroManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntroManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040BE RID: 16574
			// (get) Token: 0x0600D0D8 RID: 53464 RVA: 0x003286F8 File Offset: 0x003268F8
			// (set) Token: 0x0600D0D9 RID: 53465 RVA: 0x00065456 File Offset: 0x00063656
			public unsafe static Il2CppSystem.Func<bool> __9__23_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IntroManager.__c.NativeFieldInfoPtr___9__23_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IntroManager.__c.NativeFieldInfoPtr___9__23_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D38 RID: 36152
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D39 RID: 36153
			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_1;

			// Token: 0x04008D3A RID: 36154
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D3B RID: 36155
			private static readonly System.IntPtr NativeMethodInfoPtr__Play_b__23_1_Internal_Boolean_0;
		}

		// Token: 0x020009FC RID: 2556
		[ObfuscatedName("ScheduleOne.Intro.IntroManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0DA RID: 53466 RVA: 0x00328720 File Offset: 0x00326920
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr);
				IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, "clothes");
				IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, 100673978);
				IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, 100673979);
			}

			// Token: 0x0600D0DB RID: 53467 RVA: 0x0032879C File Offset: 0x0032699C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0DC RID: 53468 RVA: 0x003287D8 File Offset: 0x003269D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183064, XrefRangeEnd = 183069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D0DD RID: 53469 RVA: 0x00065468 File Offset: 0x00063668
			public __c__DisplayClass25_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BF RID: 16575
			// (get) Token: 0x0600D0DE RID: 53470 RVA: 0x00328818 File Offset: 0x00326A18
			// (set) Token: 0x0600D0DF RID: 53471 RVA: 0x00065471 File Offset: 0x00063671
			public unsafe IntroManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C0 RID: 16576
			// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x00328848 File Offset: 0x00326A48
			// (set) Token: 0x0600D0E1 RID: 53473 RVA: 0x00065490 File Offset: 0x00063690
			public unsafe List<ClothingInstance> clothes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr_clothes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingInstance>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.NativeFieldInfoPtr_clothes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D3C RID: 36156
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D3D RID: 36157
			private static readonly System.IntPtr NativeFieldInfoPtr_clothes;

			// Token: 0x04008D3E RID: 36158
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D3F RID: 36159
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CA4 RID: 3236
			[ObfuscatedName("ScheduleOne.Intro.IntroManager+<>c__DisplayClass25_0+<<CharacterCreationDone>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E853 RID: 59475 RVA: 0x0036AC44 File Offset: 0x00368E44
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0>.NativeClassPtr, "<<CharacterCreationDone>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673980);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673981);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673982);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673983);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673984);
					IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673985);
				}

				// Token: 0x0600E854 RID: 59476 RVA: 0x0036AD24 File Offset: 0x00368F24
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E855 RID: 59477 RVA: 0x0036AD6C File Offset: 0x00368F6C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E856 RID: 59478 RVA: 0x0036ADA0 File Offset: 0x00368FA0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182968, XrefRangeEnd = 183059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047C2 RID: 18370
				// (get) Token: 0x0600E857 RID: 59479 RVA: 0x0036ADDC File Offset: 0x00368FDC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E858 RID: 59480 RVA: 0x0036AE1C File Offset: 0x0036901C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183059, XrefRangeEnd = 183064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047C3 RID: 18371
				// (get) Token: 0x0600E859 RID: 59481 RVA: 0x0036AE50 File Offset: 0x00369050
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E85A RID: 59482 RVA: 0x00070F73 File Offset: 0x0006F173
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047BF RID: 18367
				// (get) Token: 0x0600E85B RID: 59483 RVA: 0x0036AE90 File Offset: 0x00369090
				// (set) Token: 0x0600E85C RID: 59484 RVA: 0x00070F7C File Offset: 0x0006F17C
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047C0 RID: 18368
				// (get) Token: 0x0600E85D RID: 59485 RVA: 0x0036AEB8 File Offset: 0x003690B8
				// (set) Token: 0x0600E85E RID: 59486 RVA: 0x00070F97 File Offset: 0x0006F197
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047C1 RID: 18369
				// (get) Token: 0x0600E85F RID: 59487 RVA: 0x0036AEE8 File Offset: 0x003690E8
				// (set) Token: 0x0600E860 RID: 59488 RVA: 0x00070FB6 File Offset: 0x0006F1B6
				public unsafe IntroManager.__c__DisplayClass25_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntroManager.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IntroManager.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009B89 RID: 39817
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B8A RID: 39818
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B8B RID: 39819
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B8C RID: 39820
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B8D RID: 39821
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B8E RID: 39822
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B8F RID: 39823
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B90 RID: 39824
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B91 RID: 39825
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
