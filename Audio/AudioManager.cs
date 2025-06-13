using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004ED RID: 1261
	public class AudioManager : PersistentSingleton<AudioManager>
	{
		// Token: 0x06006D4A RID: 27978 RVA: 0x001E8AB4 File Offset: 0x001E6CB4
		// Note: this type is marked as 'beforefieldinit'.
		static AudioManager()
		{
			Il2CppClassPointerStore<AudioManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioManager>.NativeClassPtr);
			AudioManager.NativeFieldInfoPtr_MIN_WORLD_MUSIC_VOLUME_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MIN_WORLD_MUSIC_VOLUME_MULTIPLIER");
			AudioManager.NativeFieldInfoPtr_MUSIC_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MUSIC_FADE_TIME");
			AudioManager.NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "masterVolume");
			AudioManager.NativeFieldInfoPtr_ambientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "ambientVolume");
			AudioManager.NativeFieldInfoPtr_footstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "footstepsVolume");
			AudioManager.NativeFieldInfoPtr_fxVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "fxVolume");
			AudioManager.NativeFieldInfoPtr_uiVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "uiVolume");
			AudioManager.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "musicVolume");
			AudioManager.NativeFieldInfoPtr_voiceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "voiceVolume");
			AudioManager.NativeFieldInfoPtr_onSettingsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "onSettingsChanged");
			AudioManager.NativeFieldInfoPtr_DoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DoorOpen");
			AudioManager.NativeFieldInfoPtr_DoorClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DoorClose");
			AudioManager.NativeFieldInfoPtr_MainGameMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MainGameMixer");
			AudioManager.NativeFieldInfoPtr_MenuMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MenuMixer");
			AudioManager.NativeFieldInfoPtr_MusicMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "MusicMixer");
			AudioManager.NativeFieldInfoPtr_currentGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "currentGameVolume");
			AudioManager.NativeFieldInfoPtr_minGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "minGameVolume");
			AudioManager.NativeFieldInfoPtr_maxGameVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "maxGameVolume");
			AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "gameVolumeMultiplier");
			AudioManager.NativeFieldInfoPtr__WorldMusicVolumeMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "<WorldMusicVolumeMultiplier>k__BackingField");
			AudioManager.NativeFieldInfoPtr_DefaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DefaultSnapshot");
			AudioManager.NativeFieldInfoPtr_DistortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, "DistortedSnapshot");
			AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677217);
			AudioManager.NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677218);
			AudioManager.NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677219);
			AudioManager.NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677220);
			AudioManager.NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677221);
			AudioManager.NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677222);
			AudioManager.NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677223);
			AudioManager.NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677224);
			AudioManager.NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677225);
			AudioManager.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677226);
			AudioManager.NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677227);
			AudioManager.NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677228);
			AudioManager.NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677229);
			AudioManager.NativeMethodInfoPtr_get_WorldMusicVolumeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677230);
			AudioManager.NativeMethodInfoPtr_set_WorldMusicVolumeMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677231);
			AudioManager.NativeMethodInfoPtr_GetScaledMusicVolumeMultiplier_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677232);
			AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677233);
			AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677234);
			AudioManager.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677235);
			AudioManager.NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677236);
			AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677237);
			AudioManager.NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677238);
			AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677239);
			AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677240);
			AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677241);
			AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677242);
			AudioManager.NativeMethodInfoPtr__Start_b__53_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioManager>.NativeClassPtr, 100677243);
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06006D4B RID: 27979 RVA: 0x001E8EB8 File Offset: 0x001E70B8
		public unsafe float MasterVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62417, RefRangeEnd = 62418, XrefRangeStart = 62417, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x001E8EF4 File Offset: 0x001E70F4
		public unsafe float AmbientVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06006D4D RID: 27981 RVA: 0x001E8F30 File Offset: 0x001E7130
		public unsafe float UnscaledAmbientVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x001E8F6C File Offset: 0x001E716C
		public unsafe float FootstepsVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06006D4F RID: 27983 RVA: 0x001E8FA8 File Offset: 0x001E71A8
		public unsafe float UnscaledFootstepsVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31486, RefRangeEnd = 31487, XrefRangeStart = 31486, XrefRangeEnd = 31487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06006D50 RID: 27984 RVA: 0x001E8FE4 File Offset: 0x001E71E4
		public unsafe float FXVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06006D51 RID: 27985 RVA: 0x001E9020 File Offset: 0x001E7220
		public unsafe float UnscaledFXVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06006D52 RID: 27986 RVA: 0x001E905C File Offset: 0x001E725C
		public unsafe float UIVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x06006D53 RID: 27987 RVA: 0x001E9098 File Offset: 0x001E7298
		public unsafe float UnscaledUIVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x06006D54 RID: 27988 RVA: 0x001E90D4 File Offset: 0x001E72D4
		public unsafe float MusicVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x06006D55 RID: 27989 RVA: 0x001E9110 File Offset: 0x001E7310
		public unsafe float UnscaledMusicVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x06006D56 RID: 27990 RVA: 0x001E914C File Offset: 0x001E734C
		public unsafe float VoiceVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x06006D57 RID: 27991 RVA: 0x001E9188 File Offset: 0x001E7388
		public unsafe float UnscaledVoiceVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31489, RefRangeEnd = 31490, XrefRangeStart = 31489, XrefRangeEnd = 31490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x06006D58 RID: 27992 RVA: 0x001E91C4 File Offset: 0x001E73C4
		// (set) Token: 0x06006D59 RID: 27993 RVA: 0x001E9200 File Offset: 0x001E7400
		public unsafe float WorldMusicVolumeMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_get_WorldMusicVolumeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_set_WorldMusicVolumeMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x001E9240 File Offset: 0x001E7440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220032, RefRangeEnd = 220033, XrefRangeStart = 220032, XrefRangeEnd = 220032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetScaledMusicVolumeMultiplier(float min)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetScaledMusicVolumeMultiplier_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x001E928C File Offset: 0x001E748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220033, XrefRangeEnd = 220051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x001E92C8 File Offset: 0x001E74C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220051, XrefRangeEnd = 220078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001E9304 File Offset: 0x001E7504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220078, XrefRangeEnd = 220105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001E9338 File Offset: 0x001E7538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220105, XrefRangeEnd = 220106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameVolumeMultipler(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x001E9378 File Offset: 0x001E7578
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 220109, RefRangeEnd = 220117, XrefRangeStart = 220106, XrefRangeEnd = 220109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transition;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x001E93C4 File Offset: 0x001E75C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 220123, RefRangeEnd = 220127, XrefRangeStart = 220117, XrefRangeEnd = 220123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameVolume(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x001E9404 File Offset: 0x001E7604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220127, RefRangeEnd = 220128, XrefRangeStart = 220127, XrefRangeEnd = 220127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVolume(EAudioType audioType, bool scaled = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref audioType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scaled;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x001E945C File Offset: 0x001E765C
		[CallerCount(0)]
		public unsafe void SetMasterVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x001E949C File Offset: 0x001E769C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220128, RefRangeEnd = 220134, XrefRangeStart = 220128, XrefRangeEnd = 220128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(EAudioType type, float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x001E94E8 File Offset: 0x001E76E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220134, XrefRangeEnd = 220142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x001E9524 File Offset: 0x001E7724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220142, XrefRangeEnd = 220144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__53_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioManager.NativeMethodInfoPtr__Start_b__53_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x00033793 File Offset: 0x00031993
		public AudioManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06006D67 RID: 28007 RVA: 0x001E9558 File Offset: 0x001E7758
		// (set) Token: 0x06006D68 RID: 28008 RVA: 0x0003379C File Offset: 0x0003199C
		public unsafe static float MIN_WORLD_MUSIC_VOLUME_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_MIN_WORLD_MUSIC_VOLUME_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_MIN_WORLD_MUSIC_VOLUME_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06006D69 RID: 28009 RVA: 0x001E9574 File Offset: 0x001E7774
		// (set) Token: 0x06006D6A RID: 28010 RVA: 0x000337AA File Offset: 0x000319AA
		public unsafe static float MUSIC_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_MUSIC_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_MUSIC_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06006D6B RID: 28011 RVA: 0x001E9590 File Offset: 0x001E7790
		// (set) Token: 0x06006D6C RID: 28012 RVA: 0x000337B8 File Offset: 0x000319B8
		public unsafe float masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_masterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_masterVolume)) = value;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06006D6D RID: 28013 RVA: 0x001E95B8 File Offset: 0x001E77B8
		// (set) Token: 0x06006D6E RID: 28014 RVA: 0x000337D3 File Offset: 0x000319D3
		public unsafe float ambientVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_ambientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_ambientVolume)) = value;
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06006D6F RID: 28015 RVA: 0x001E95E0 File Offset: 0x001E77E0
		// (set) Token: 0x06006D70 RID: 28016 RVA: 0x000337EE File Offset: 0x000319EE
		public unsafe float footstepsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_footstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_footstepsVolume)) = value;
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06006D71 RID: 28017 RVA: 0x001E9608 File Offset: 0x001E7808
		// (set) Token: 0x06006D72 RID: 28018 RVA: 0x00033809 File Offset: 0x00031A09
		public unsafe float fxVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_fxVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_fxVolume)) = value;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x001E9630 File Offset: 0x001E7830
		// (set) Token: 0x06006D74 RID: 28020 RVA: 0x00033824 File Offset: 0x00031A24
		public unsafe float uiVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_uiVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_uiVolume)) = value;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06006D75 RID: 28021 RVA: 0x001E9658 File Offset: 0x001E7858
		// (set) Token: 0x06006D76 RID: 28022 RVA: 0x0003383F File Offset: 0x00031A3F
		public unsafe float musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_musicVolume)) = value;
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06006D77 RID: 28023 RVA: 0x001E9680 File Offset: 0x001E7880
		// (set) Token: 0x06006D78 RID: 28024 RVA: 0x0003385A File Offset: 0x00031A5A
		public unsafe float voiceVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_voiceVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_voiceVolume)) = value;
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06006D79 RID: 28025 RVA: 0x001E96A8 File Offset: 0x001E78A8
		// (set) Token: 0x06006D7A RID: 28026 RVA: 0x00033875 File Offset: 0x00031A75
		public unsafe UnityEvent onSettingsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onSettingsChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_onSettingsChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06006D7B RID: 28027 RVA: 0x001E96D8 File Offset: 0x001E78D8
		// (set) Token: 0x06006D7C RID: 28028 RVA: 0x00033894 File Offset: 0x00031A94
		public unsafe AudioSourceController DoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06006D7D RID: 28029 RVA: 0x001E9708 File Offset: 0x001E7908
		// (set) Token: 0x06006D7E RID: 28030 RVA: 0x000338B3 File Offset: 0x00031AB3
		public unsafe AudioSourceController DoorClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DoorClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06006D7F RID: 28031 RVA: 0x001E9738 File Offset: 0x001E7938
		// (set) Token: 0x06006D80 RID: 28032 RVA: 0x000338D2 File Offset: 0x00031AD2
		public unsafe AudioMixerGroup MainGameMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainGameMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MainGameMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06006D81 RID: 28033 RVA: 0x001E9768 File Offset: 0x001E7968
		// (set) Token: 0x06006D82 RID: 28034 RVA: 0x000338F1 File Offset: 0x00031AF1
		public unsafe AudioMixerGroup MenuMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MenuMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MenuMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06006D83 RID: 28035 RVA: 0x001E9798 File Offset: 0x001E7998
		// (set) Token: 0x06006D84 RID: 28036 RVA: 0x00033910 File Offset: 0x00031B10
		public unsafe AudioMixerGroup MusicMixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicMixer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_MusicMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06006D85 RID: 28037 RVA: 0x001E97C8 File Offset: 0x001E79C8
		// (set) Token: 0x06006D86 RID: 28038 RVA: 0x0003392F File Offset: 0x00031B2F
		public unsafe float currentGameVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGameVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_currentGameVolume)) = value;
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06006D87 RID: 28039 RVA: 0x001E97F0 File Offset: 0x001E79F0
		// (set) Token: 0x06006D88 RID: 28040 RVA: 0x0003394A File Offset: 0x00031B4A
		public unsafe static float minGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_minGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_minGameVolume, (void*)(&value));
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06006D89 RID: 28041 RVA: 0x001E980C File Offset: 0x001E7A0C
		// (set) Token: 0x06006D8A RID: 28042 RVA: 0x00033958 File Offset: 0x00031B58
		public unsafe static float maxGameVolume
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioManager.NativeFieldInfoPtr_maxGameVolume, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioManager.NativeFieldInfoPtr_maxGameVolume, (void*)(&value));
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06006D8B RID: 28043 RVA: 0x001E9828 File Offset: 0x001E7A28
		// (set) Token: 0x06006D8C RID: 28044 RVA: 0x00033966 File Offset: 0x00031B66
		public unsafe float gameVolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_gameVolumeMultiplier)) = value;
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06006D8D RID: 28045 RVA: 0x001E9850 File Offset: 0x001E7A50
		// (set) Token: 0x06006D8E RID: 28046 RVA: 0x00033981 File Offset: 0x00031B81
		public unsafe float _WorldMusicVolumeMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__WorldMusicVolumeMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr__WorldMusicVolumeMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06006D8F RID: 28047 RVA: 0x001E9878 File Offset: 0x001E7A78
		// (set) Token: 0x06006D90 RID: 28048 RVA: 0x0003399C File Offset: 0x00031B9C
		public unsafe AudioMixerSnapshot DefaultSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DefaultSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DefaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06006D91 RID: 28049 RVA: 0x001E98A8 File Offset: 0x001E7AA8
		// (set) Token: 0x06006D92 RID: 28050 RVA: 0x000339BB File Offset: 0x00031BBB
		public unsafe AudioMixerSnapshot DistortedSnapshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DistortedSnapshot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioManager.NativeFieldInfoPtr_DistortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AC1 RID: 19137
		private static readonly IntPtr NativeFieldInfoPtr_MIN_WORLD_MUSIC_VOLUME_MULTIPLIER;

		// Token: 0x04004AC2 RID: 19138
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_TIME;

		// Token: 0x04004AC3 RID: 19139
		private static readonly IntPtr NativeFieldInfoPtr_masterVolume;

		// Token: 0x04004AC4 RID: 19140
		private static readonly IntPtr NativeFieldInfoPtr_ambientVolume;

		// Token: 0x04004AC5 RID: 19141
		private static readonly IntPtr NativeFieldInfoPtr_footstepsVolume;

		// Token: 0x04004AC6 RID: 19142
		private static readonly IntPtr NativeFieldInfoPtr_fxVolume;

		// Token: 0x04004AC7 RID: 19143
		private static readonly IntPtr NativeFieldInfoPtr_uiVolume;

		// Token: 0x04004AC8 RID: 19144
		private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

		// Token: 0x04004AC9 RID: 19145
		private static readonly IntPtr NativeFieldInfoPtr_voiceVolume;

		// Token: 0x04004ACA RID: 19146
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsChanged;

		// Token: 0x04004ACB RID: 19147
		private static readonly IntPtr NativeFieldInfoPtr_DoorOpen;

		// Token: 0x04004ACC RID: 19148
		private static readonly IntPtr NativeFieldInfoPtr_DoorClose;

		// Token: 0x04004ACD RID: 19149
		private static readonly IntPtr NativeFieldInfoPtr_MainGameMixer;

		// Token: 0x04004ACE RID: 19150
		private static readonly IntPtr NativeFieldInfoPtr_MenuMixer;

		// Token: 0x04004ACF RID: 19151
		private static readonly IntPtr NativeFieldInfoPtr_MusicMixer;

		// Token: 0x04004AD0 RID: 19152
		private static readonly IntPtr NativeFieldInfoPtr_currentGameVolume;

		// Token: 0x04004AD1 RID: 19153
		private static readonly IntPtr NativeFieldInfoPtr_minGameVolume;

		// Token: 0x04004AD2 RID: 19154
		private static readonly IntPtr NativeFieldInfoPtr_maxGameVolume;

		// Token: 0x04004AD3 RID: 19155
		private static readonly IntPtr NativeFieldInfoPtr_gameVolumeMultiplier;

		// Token: 0x04004AD4 RID: 19156
		private static readonly IntPtr NativeFieldInfoPtr__WorldMusicVolumeMultiplier_k__BackingField;

		// Token: 0x04004AD5 RID: 19157
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSnapshot;

		// Token: 0x04004AD6 RID: 19158
		private static readonly IntPtr NativeFieldInfoPtr_DistortedSnapshot;

		// Token: 0x04004AD7 RID: 19159
		private static readonly IntPtr NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0;

		// Token: 0x04004AD8 RID: 19160
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbientVolume_Public_get_Single_0;

		// Token: 0x04004AD9 RID: 19161
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledAmbientVolume_Public_get_Single_0;

		// Token: 0x04004ADA RID: 19162
		private static readonly IntPtr NativeMethodInfoPtr_get_FootstepsVolume_Public_get_Single_0;

		// Token: 0x04004ADB RID: 19163
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledFootstepsVolume_Public_get_Single_0;

		// Token: 0x04004ADC RID: 19164
		private static readonly IntPtr NativeMethodInfoPtr_get_FXVolume_Public_get_Single_0;

		// Token: 0x04004ADD RID: 19165
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledFXVolume_Public_get_Single_0;

		// Token: 0x04004ADE RID: 19166
		private static readonly IntPtr NativeMethodInfoPtr_get_UIVolume_Public_get_Single_0;

		// Token: 0x04004ADF RID: 19167
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledUIVolume_Public_get_Single_0;

		// Token: 0x04004AE0 RID: 19168
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0;

		// Token: 0x04004AE1 RID: 19169
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledMusicVolume_Public_get_Single_0;

		// Token: 0x04004AE2 RID: 19170
		private static readonly IntPtr NativeMethodInfoPtr_get_VoiceVolume_Public_get_Single_0;

		// Token: 0x04004AE3 RID: 19171
		private static readonly IntPtr NativeMethodInfoPtr_get_UnscaledVoiceVolume_Public_get_Single_0;

		// Token: 0x04004AE4 RID: 19172
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldMusicVolumeMultiplier_Public_get_Single_0;

		// Token: 0x04004AE5 RID: 19173
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldMusicVolumeMultiplier_Private_set_Void_Single_0;

		// Token: 0x04004AE6 RID: 19174
		private static readonly IntPtr NativeMethodInfoPtr_GetScaledMusicVolumeMultiplier_Public_Single_Single_0;

		// Token: 0x04004AE7 RID: 19175
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004AE8 RID: 19176
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004AE9 RID: 19177
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x04004AEA RID: 19178
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVolumeMultipler_Public_Void_Single_0;

		// Token: 0x04004AEB RID: 19179
		private static readonly IntPtr NativeMethodInfoPtr_SetDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x04004AEC RID: 19180
		private static readonly IntPtr NativeMethodInfoPtr_SetGameVolume_Private_Void_Single_0;

		// Token: 0x04004AED RID: 19181
		private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Public_Single_EAudioType_Boolean_0;

		// Token: 0x04004AEE RID: 19182
		private static readonly IntPtr NativeMethodInfoPtr_SetMasterVolume_Public_Void_Single_0;

		// Token: 0x04004AEF RID: 19183
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_EAudioType_Single_0;

		// Token: 0x04004AF0 RID: 19184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004AF1 RID: 19185
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__53_0_Private_Void_0;
	}
}
