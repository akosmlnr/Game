using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.AvatarFramework.Customization;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000658 RID: 1624
	public class DemoIntro : Singleton<DemoIntro>
	{
		// Token: 0x06008E74 RID: 36468 RVA: 0x00255990 File Offset: 0x00253B90
		// Note: this type is marked as 'beforefieldinit'.
		static DemoIntro()
		{
			Il2CppClassPointerStore<DemoIntro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DemoIntro");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr);
			DemoIntro.NativeFieldInfoPtr_SKIP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SKIP_TIME");
			DemoIntro.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DemoIntro.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "Anim");
			DemoIntro.NativeFieldInfoPtr_PlayerInitialPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "PlayerInitialPosition");
			DemoIntro.NativeFieldInfoPtr_SkipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SkipContainer");
			DemoIntro.NativeFieldInfoPtr_SkipDial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SkipDial");
			DemoIntro.NativeFieldInfoPtr_SkipEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "SkipEvents");
			DemoIntro.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onStart");
			DemoIntro.NativeFieldInfoPtr_onStartAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onStartAsServer");
			DemoIntro.NativeFieldInfoPtr_onCutsceneDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onCutsceneDone");
			DemoIntro.NativeFieldInfoPtr_onIntroDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onIntroDone");
			DemoIntro.NativeFieldInfoPtr_onIntroDoneAsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "onIntroDoneAsServer");
			DemoIntro.NativeFieldInfoPtr_CurrentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "CurrentStep");
			DemoIntro.NativeFieldInfoPtr_MusicName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "MusicName");
			DemoIntro.NativeFieldInfoPtr_currentSkipTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "currentSkipTime");
			DemoIntro.NativeFieldInfoPtr_depressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "depressed");
			DemoIntro.NativeFieldInfoPtr_waitingForCutsceneEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "waitingForCutsceneEnd");
			DemoIntro.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681091);
			DemoIntro.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681092);
			DemoIntro.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681093);
			DemoIntro.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681094);
			DemoIntro.NativeMethodInfoPtr_PlayMusic_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681095);
			DemoIntro.NativeMethodInfoPtr_ShowAvatar_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681096);
			DemoIntro.NativeMethodInfoPtr_CutsceneDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681097);
			DemoIntro.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681098);
			DemoIntro.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681099);
			DemoIntro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681100);
			DemoIntro.NativeMethodInfoPtr__PlayMusic_b__22_0_Private_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681101);
			DemoIntro.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, 100681102);
		}

		// Token: 0x17002B4B RID: 11083
		// (get) Token: 0x06008E75 RID: 36469 RVA: 0x00255C04 File Offset: 0x00253E04
		// (set) Token: 0x06008E76 RID: 36470 RVA: 0x00255C40 File Offset: 0x00253E40
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008E77 RID: 36471 RVA: 0x00255C80 File Offset: 0x00253E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260350, XrefRangeEnd = 260396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E78 RID: 36472 RVA: 0x00255CB4 File Offset: 0x00253EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260396, XrefRangeEnd = 260427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E79 RID: 36473 RVA: 0x00255CE8 File Offset: 0x00253EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260427, XrefRangeEnd = 260445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayMusic()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_PlayMusic_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E7A RID: 36474 RVA: 0x00255D1C File Offset: 0x00253F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260445, XrefRangeEnd = 260454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_ShowAvatar_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E7B RID: 36475 RVA: 0x00255D50 File Offset: 0x00253F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260454, XrefRangeEnd = 260472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CutsceneDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_CutsceneDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E7C RID: 36476 RVA: 0x00255D84 File Offset: 0x00253F84
		[CallerCount(0)]
		public unsafe void PassedStep(int stepIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stepIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x00255DC4 File Offset: 0x00253FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260472, XrefRangeEnd = 260478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterCreationDone(BasicAvatarSettings avatar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatar);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00255E08 File Offset: 0x00254008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260478, XrefRangeEnd = 260481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DemoIntro() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00255E44 File Offset: 0x00254044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260481, XrefRangeEnd = 260483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayMusic_b__22_0(MusicTrack t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr__PlayMusic_b__22_0_Private_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x00255E94 File Offset: 0x00254094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260483, XrefRangeEnd = 260488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x00043FDF File Offset: 0x000421DF
		public DemoIntro(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B3A RID: 11066
		// (get) Token: 0x06008E82 RID: 36482 RVA: 0x00255ED4 File Offset: 0x002540D4
		// (set) Token: 0x06008E83 RID: 36483 RVA: 0x00043FE8 File Offset: 0x000421E8
		public unsafe static float SKIP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DemoIntro.NativeFieldInfoPtr_SKIP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DemoIntro.NativeFieldInfoPtr_SKIP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002B3B RID: 11067
		// (get) Token: 0x06008E84 RID: 36484 RVA: 0x00255EF0 File Offset: 0x002540F0
		// (set) Token: 0x06008E85 RID: 36485 RVA: 0x00043FF6 File Offset: 0x000421F6
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x06008E86 RID: 36486 RVA: 0x00255F18 File Offset: 0x00254118
		// (set) Token: 0x06008E87 RID: 36487 RVA: 0x00044011 File Offset: 0x00042211
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3D RID: 11069
		// (get) Token: 0x06008E88 RID: 36488 RVA: 0x00255F48 File Offset: 0x00254148
		// (set) Token: 0x06008E89 RID: 36489 RVA: 0x00044030 File Offset: 0x00042230
		public unsafe Transform PlayerInitialPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_PlayerInitialPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_PlayerInitialPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3E RID: 11070
		// (get) Token: 0x06008E8A RID: 36490 RVA: 0x00255F78 File Offset: 0x00254178
		// (set) Token: 0x06008E8B RID: 36491 RVA: 0x0004404F File Offset: 0x0004224F
		public unsafe GameObject SkipContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B3F RID: 11071
		// (get) Token: 0x06008E8C RID: 36492 RVA: 0x00255FA8 File Offset: 0x002541A8
		// (set) Token: 0x06008E8D RID: 36493 RVA: 0x0004406E File Offset: 0x0004226E
		public unsafe Image SkipDial
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipDial);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipDial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B40 RID: 11072
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x00255FD8 File Offset: 0x002541D8
		// (set) Token: 0x06008E8F RID: 36495 RVA: 0x0004408D File Offset: 0x0004228D
		public unsafe int SkipEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_SkipEvents)) = value;
			}
		}

		// Token: 0x17002B41 RID: 11073
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x00256000 File Offset: 0x00254200
		// (set) Token: 0x06008E91 RID: 36497 RVA: 0x000440A8 File Offset: 0x000422A8
		public unsafe UnityEvent onStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B42 RID: 11074
		// (get) Token: 0x06008E92 RID: 36498 RVA: 0x00256030 File Offset: 0x00254230
		// (set) Token: 0x06008E93 RID: 36499 RVA: 0x000440C7 File Offset: 0x000422C7
		public unsafe UnityEvent onStartAsServer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStartAsServer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onStartAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B43 RID: 11075
		// (get) Token: 0x06008E94 RID: 36500 RVA: 0x00256060 File Offset: 0x00254260
		// (set) Token: 0x06008E95 RID: 36501 RVA: 0x000440E6 File Offset: 0x000422E6
		public unsafe UnityEvent onCutsceneDone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onCutsceneDone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onCutsceneDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B44 RID: 11076
		// (get) Token: 0x06008E96 RID: 36502 RVA: 0x00256090 File Offset: 0x00254290
		// (set) Token: 0x06008E97 RID: 36503 RVA: 0x00044105 File Offset: 0x00042305
		public unsafe UnityEvent onIntroDone
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDone);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B45 RID: 11077
		// (get) Token: 0x06008E98 RID: 36504 RVA: 0x002560C0 File Offset: 0x002542C0
		// (set) Token: 0x06008E99 RID: 36505 RVA: 0x00044124 File Offset: 0x00042324
		public unsafe UnityEvent onIntroDoneAsServer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDoneAsServer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_onIntroDoneAsServer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B46 RID: 11078
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x002560F0 File Offset: 0x002542F0
		// (set) Token: 0x06008E9B RID: 36507 RVA: 0x00044143 File Offset: 0x00042343
		public unsafe int CurrentStep
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_CurrentStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_CurrentStep)) = value;
			}
		}

		// Token: 0x17002B47 RID: 11079
		// (get) Token: 0x06008E9C RID: 36508 RVA: 0x00256118 File Offset: 0x00254318
		// (set) Token: 0x06008E9D RID: 36509 RVA: 0x0004415E File Offset: 0x0004235E
		public unsafe string MusicName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_MusicName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_MusicName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B48 RID: 11080
		// (get) Token: 0x06008E9E RID: 36510 RVA: 0x00256140 File Offset: 0x00254340
		// (set) Token: 0x06008E9F RID: 36511 RVA: 0x0004417D File Offset: 0x0004237D
		public unsafe float currentSkipTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_currentSkipTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_currentSkipTime)) = value;
			}
		}

		// Token: 0x17002B49 RID: 11081
		// (get) Token: 0x06008EA0 RID: 36512 RVA: 0x00256168 File Offset: 0x00254368
		// (set) Token: 0x06008EA1 RID: 36513 RVA: 0x00044198 File Offset: 0x00042398
		public unsafe bool depressed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_depressed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_depressed)) = value;
			}
		}

		// Token: 0x17002B4A RID: 11082
		// (get) Token: 0x06008EA2 RID: 36514 RVA: 0x00256190 File Offset: 0x00254390
		// (set) Token: 0x06008EA3 RID: 36515 RVA: 0x000441B3 File Offset: 0x000423B3
		public unsafe bool waitingForCutsceneEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_waitingForCutsceneEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.NativeFieldInfoPtr_waitingForCutsceneEnd)) = value;
			}
		}

		// Token: 0x0400609B RID: 24731
		private static readonly System.IntPtr NativeFieldInfoPtr_SKIP_TIME;

		// Token: 0x0400609C RID: 24732
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x0400609D RID: 24733
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400609E RID: 24734
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInitialPosition;

		// Token: 0x0400609F RID: 24735
		private static readonly System.IntPtr NativeFieldInfoPtr_SkipContainer;

		// Token: 0x040060A0 RID: 24736
		private static readonly System.IntPtr NativeFieldInfoPtr_SkipDial;

		// Token: 0x040060A1 RID: 24737
		private static readonly System.IntPtr NativeFieldInfoPtr_SkipEvents;

		// Token: 0x040060A2 RID: 24738
		private static readonly System.IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x040060A3 RID: 24739
		private static readonly System.IntPtr NativeFieldInfoPtr_onStartAsServer;

		// Token: 0x040060A4 RID: 24740
		private static readonly System.IntPtr NativeFieldInfoPtr_onCutsceneDone;

		// Token: 0x040060A5 RID: 24741
		private static readonly System.IntPtr NativeFieldInfoPtr_onIntroDone;

		// Token: 0x040060A6 RID: 24742
		private static readonly System.IntPtr NativeFieldInfoPtr_onIntroDoneAsServer;

		// Token: 0x040060A7 RID: 24743
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentStep;

		// Token: 0x040060A8 RID: 24744
		private static readonly System.IntPtr NativeFieldInfoPtr_MusicName;

		// Token: 0x040060A9 RID: 24745
		private static readonly System.IntPtr NativeFieldInfoPtr_currentSkipTime;

		// Token: 0x040060AA RID: 24746
		private static readonly System.IntPtr NativeFieldInfoPtr_depressed;

		// Token: 0x040060AB RID: 24747
		private static readonly System.IntPtr NativeFieldInfoPtr_waitingForCutsceneEnd;

		// Token: 0x040060AC RID: 24748
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040060AD RID: 24749
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x040060AE RID: 24750
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040060AF RID: 24751
		private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x040060B0 RID: 24752
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayMusic_Private_Void_0;

		// Token: 0x040060B1 RID: 24753
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowAvatar_Public_Void_0;

		// Token: 0x040060B2 RID: 24754
		private static readonly System.IntPtr NativeMethodInfoPtr_CutsceneDone_Public_Void_0;

		// Token: 0x040060B3 RID: 24755
		private static readonly System.IntPtr NativeMethodInfoPtr_PassedStep_Public_Void_Int32_0;

		// Token: 0x040060B4 RID: 24756
		private static readonly System.IntPtr NativeMethodInfoPtr_CharacterCreationDone_Public_Void_BasicAvatarSettings_0;

		// Token: 0x040060B5 RID: 24757
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040060B6 RID: 24758
		private static readonly System.IntPtr NativeMethodInfoPtr__PlayMusic_b__22_0_Private_Boolean_MusicTrack_0;

		// Token: 0x040060B7 RID: 24759
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B69 RID: 2921
		[ObfuscatedName("ScheduleOne.UI.DemoIntro+<<CharacterCreationDone>g__Wait|26_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DC29 RID: 56361 RVA: 0x00348328 File Offset: 0x00346528
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique()
			{
				Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DemoIntro>.NativeClassPtr, "<<CharacterCreationDone>g__Wait|26_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>1__state");
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>2__current");
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, "<>4__this");
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681103);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681104);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681105);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681106);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681107);
				DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr, 100681108);
			}

			// Token: 0x0600DC2A RID: 56362 RVA: 0x00348408 File Offset: 0x00346608
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC2B RID: 56363 RVA: 0x00348450 File Offset: 0x00346650
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC2C RID: 56364 RVA: 0x00348484 File Offset: 0x00346684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260301, XrefRangeEnd = 260345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170043E8 RID: 17384
			// (get) Token: 0x0600DC2D RID: 56365 RVA: 0x003484C0 File Offset: 0x003466C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC2E RID: 56366 RVA: 0x00348500 File Offset: 0x00346700
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260345, XrefRangeEnd = 260350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170043E9 RID: 17385
			// (get) Token: 0x0600DC2F RID: 56367 RVA: 0x00348534 File Offset: 0x00346734
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC30 RID: 56368 RVA: 0x0006AD5D File Offset: 0x00068F5D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E5 RID: 17381
			// (get) Token: 0x0600DC31 RID: 56369 RVA: 0x00348574 File Offset: 0x00346774
			// (set) Token: 0x0600DC32 RID: 56370 RVA: 0x0006AD66 File Offset: 0x00068F66
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043E6 RID: 17382
			// (get) Token: 0x0600DC33 RID: 56371 RVA: 0x0034859C File Offset: 0x0034679C
			// (set) Token: 0x0600DC34 RID: 56372 RVA: 0x0006AD81 File Offset: 0x00068F81
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E7 RID: 17383
			// (get) Token: 0x0600DC35 RID: 56373 RVA: 0x003485CC File Offset: 0x003467CC
			// (set) Token: 0x0600DC36 RID: 56374 RVA: 0x0006ADA0 File Offset: 0x00068FA0
			public unsafe DemoIntro __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DemoIntro>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DemoIntro.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObDeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400941B RID: 37915
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400941C RID: 37916
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400941D RID: 37917
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400941E RID: 37918
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400941F RID: 37919
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009420 RID: 37920
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009421 RID: 37921
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009422 RID: 37922
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009423 RID: 37923
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
