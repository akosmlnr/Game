using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004EE RID: 1262
	public class AudioSourceController : MonoBehaviour
	{
		// Token: 0x06006D93 RID: 28051 RVA: 0x001E98D8 File Offset: 0x001E7AD8
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSourceController()
		{
			Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr);
			AudioSourceController.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "DEBUG");
			AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "<Volume>k__BackingField");
			AudioSourceController.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "AudioSource");
			AudioSourceController.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "AudioType");
			AudioSourceController.NativeFieldInfoPtr_DefaultVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "DefaultVolume");
			AudioSourceController.NativeFieldInfoPtr_RandomizePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "RandomizePitch");
			AudioSourceController.NativeFieldInfoPtr_MinPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "MinPitch");
			AudioSourceController.NativeFieldInfoPtr_MaxPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "MaxPitch");
			AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "VolumeMultiplier");
			AudioSourceController.NativeFieldInfoPtr_PitchMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "PitchMultiplier");
			AudioSourceController.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "paused");
			AudioSourceController.NativeFieldInfoPtr_isPlayingCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "isPlayingCached");
			AudioSourceController.NativeFieldInfoPtr_basePitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, "basePitch");
			AudioSourceController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677244);
			AudioSourceController.NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677245);
			AudioSourceController.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677246);
			AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677247);
			AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677248);
			AudioSourceController.NativeMethodInfoPtr_DoPauseStuff_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677249);
			AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677250);
			AudioSourceController.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677251);
			AudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677252);
			AudioSourceController.NativeMethodInfoPtr_Pause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677253);
			AudioSourceController.NativeMethodInfoPtr_Unpause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677254);
			AudioSourceController.NativeMethodInfoPtr_SetVolume_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677255);
			AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677256);
			AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677257);
			AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677258);
			AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677259);
			AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677260);
			AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr, 100677261);
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x06006D94 RID: 28052 RVA: 0x001E9B74 File Offset: 0x001E7D74
		// (set) Token: 0x06006D95 RID: 28053 RVA: 0x001E9BB0 File Offset: 0x001E7DB0
		public unsafe float Volume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x06006D96 RID: 28054 RVA: 0x001E9BF0 File Offset: 0x001E7DF0
		public unsafe bool isPlaying
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 220146, RefRangeEnd = 220175, XrefRangeStart = 220144, XrefRangeEnd = 220146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06006D97 RID: 28055 RVA: 0x001E9C2C File Offset: 0x001E7E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220175, XrefRangeEnd = 220179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D98 RID: 28056 RVA: 0x001E9C60 File Offset: 0x001E7E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220179, XrefRangeEnd = 220197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D99 RID: 28057 RVA: 0x001E9C94 File Offset: 0x001E7E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220236, RefRangeEnd = 220237, XrefRangeStart = 220197, XrefRangeEnd = 220236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoPauseStuff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_DoPauseStuff_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x001E9CC8 File Offset: 0x001E7EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220237, XrefRangeEnd = 220255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x001E9CFC File Offset: 0x001E7EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220255, XrefRangeEnd = 220263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x001E9D30 File Offset: 0x001E7F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220263, XrefRangeEnd = 220265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D9D RID: 28061 RVA: 0x001E9D64 File Offset: 0x001E7F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220265, XrefRangeEnd = 220267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Pause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D9E RID: 28062 RVA: 0x001E9D98 File Offset: 0x001E7F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220267, XrefRangeEnd = 220269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unpause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Unpause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x001E9DCC File Offset: 0x001E7FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220269, XrefRangeEnd = 220270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(float volume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref volume;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_SetVolume_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x001E9E0C File Offset: 0x001E800C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 220313, RefRangeEnd = 220326, XrefRangeStart = 220270, XrefRangeEnd = 220313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyVolume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x001E9E40 File Offset: 0x001E8040
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 220330, RefRangeEnd = 220335, XrefRangeStart = 220326, XrefRangeEnd = 220330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPitch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_ApplyPitch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x001E9E74 File Offset: 0x001E8074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220335, XrefRangeEnd = 220339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x001E9EB0 File Offset: 0x001E80B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220373, RefRangeEnd = 220374, XrefRangeStart = 220339, XrefRangeEnd = 220373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayOneShot(bool duplicateAudioSource = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duplicateAudioSource;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x001E9EFC File Offset: 0x001E80FC
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 220376, RefRangeEnd = 220410, XrefRangeStart = 220374, XrefRangeEnd = 220376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x001E9F30 File Offset: 0x001E8130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220410, XrefRangeEnd = 220411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSourceController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DA6 RID: 28070 RVA: 0x000339DA File Offset: 0x00031BDA
		public AudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x06006DA7 RID: 28071 RVA: 0x001E9F6C File Offset: 0x001E816C
		// (set) Token: 0x06006DA8 RID: 28072 RVA: 0x000339E3 File Offset: 0x00031BE3
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06006DA9 RID: 28073 RVA: 0x001E9F94 File Offset: 0x001E8194
		// (set) Token: 0x06006DAA RID: 28074 RVA: 0x000339FE File Offset: 0x00031BFE
		public unsafe float _Volume_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr__Volume_k__BackingField)) = value;
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x06006DAB RID: 28075 RVA: 0x001E9FBC File Offset: 0x001E81BC
		// (set) Token: 0x06006DAC RID: 28076 RVA: 0x00033A19 File Offset: 0x00031C19
		public unsafe AudioSource AudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x06006DAD RID: 28077 RVA: 0x001E9FEC File Offset: 0x001E81EC
		// (set) Token: 0x06006DAE RID: 28078 RVA: 0x00033A38 File Offset: 0x00031C38
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x06006DAF RID: 28079 RVA: 0x001EA014 File Offset: 0x001E8214
		// (set) Token: 0x06006DB0 RID: 28080 RVA: 0x00033A53 File Offset: 0x00031C53
		public unsafe float DefaultVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DefaultVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_DefaultVolume)) = value;
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x06006DB1 RID: 28081 RVA: 0x001EA03C File Offset: 0x001E823C
		// (set) Token: 0x06006DB2 RID: 28082 RVA: 0x00033A6E File Offset: 0x00031C6E
		public unsafe bool RandomizePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_RandomizePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_RandomizePitch)) = value;
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x06006DB3 RID: 28083 RVA: 0x001EA064 File Offset: 0x001E8264
		// (set) Token: 0x06006DB4 RID: 28084 RVA: 0x00033A89 File Offset: 0x00031C89
		public unsafe float MinPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MinPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MinPitch)) = value;
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x06006DB5 RID: 28085 RVA: 0x001EA08C File Offset: 0x001E828C
		// (set) Token: 0x06006DB6 RID: 28086 RVA: 0x00033AA4 File Offset: 0x00031CA4
		public unsafe float MaxPitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MaxPitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_MaxPitch)) = value;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x06006DB7 RID: 28087 RVA: 0x001EA0B4 File Offset: 0x001E82B4
		// (set) Token: 0x06006DB8 RID: 28088 RVA: 0x00033ABF File Offset: 0x00031CBF
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x06006DB9 RID: 28089 RVA: 0x001EA0DC File Offset: 0x001E82DC
		// (set) Token: 0x06006DBA RID: 28090 RVA: 0x00033ADA File Offset: 0x00031CDA
		public unsafe float PitchMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_PitchMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_PitchMultiplier)) = value;
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x06006DBB RID: 28091 RVA: 0x001EA104 File Offset: 0x001E8304
		// (set) Token: 0x06006DBC RID: 28092 RVA: 0x00033AF5 File Offset: 0x00031CF5
		public unsafe bool paused
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_paused);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_paused)) = value;
			}
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x06006DBD RID: 28093 RVA: 0x001EA12C File Offset: 0x001E832C
		// (set) Token: 0x06006DBE RID: 28094 RVA: 0x00033B10 File Offset: 0x00031D10
		public unsafe bool isPlayingCached
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_isPlayingCached);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_isPlayingCached)) = value;
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x06006DBF RID: 28095 RVA: 0x001EA154 File Offset: 0x001E8354
		// (set) Token: 0x06006DC0 RID: 28096 RVA: 0x00033B2B File Offset: 0x00031D2B
		public unsafe float basePitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_basePitch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSourceController.NativeFieldInfoPtr_basePitch)) = value;
			}
		}

		// Token: 0x04004AF2 RID: 19186
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04004AF3 RID: 19187
		private static readonly IntPtr NativeFieldInfoPtr__Volume_k__BackingField;

		// Token: 0x04004AF4 RID: 19188
		private static readonly IntPtr NativeFieldInfoPtr_AudioSource;

		// Token: 0x04004AF5 RID: 19189
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x04004AF6 RID: 19190
		private static readonly IntPtr NativeFieldInfoPtr_DefaultVolume;

		// Token: 0x04004AF7 RID: 19191
		private static readonly IntPtr NativeFieldInfoPtr_RandomizePitch;

		// Token: 0x04004AF8 RID: 19192
		private static readonly IntPtr NativeFieldInfoPtr_MinPitch;

		// Token: 0x04004AF9 RID: 19193
		private static readonly IntPtr NativeFieldInfoPtr_MaxPitch;

		// Token: 0x04004AFA RID: 19194
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004AFB RID: 19195
		private static readonly IntPtr NativeFieldInfoPtr_PitchMultiplier;

		// Token: 0x04004AFC RID: 19196
		private static readonly IntPtr NativeFieldInfoPtr_paused;

		// Token: 0x04004AFD RID: 19197
		private static readonly IntPtr NativeFieldInfoPtr_isPlayingCached;

		// Token: 0x04004AFE RID: 19198
		private static readonly IntPtr NativeFieldInfoPtr_basePitch;

		// Token: 0x04004AFF RID: 19199
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

		// Token: 0x04004B00 RID: 19200
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Protected_set_Void_Single_0;

		// Token: 0x04004B01 RID: 19201
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x04004B02 RID: 19202
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004B03 RID: 19203
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004B04 RID: 19204
		private static readonly IntPtr NativeMethodInfoPtr_DoPauseStuff_Private_Void_0;

		// Token: 0x04004B05 RID: 19205
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004B06 RID: 19206
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004B07 RID: 19207
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004B08 RID: 19208
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Private_Void_0;

		// Token: 0x04004B09 RID: 19209
		private static readonly IntPtr NativeMethodInfoPtr_Unpause_Private_Void_0;

		// Token: 0x04004B0A RID: 19210
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_Single_0;

		// Token: 0x04004B0B RID: 19211
		private static readonly IntPtr NativeMethodInfoPtr_ApplyVolume_Public_Void_0;

		// Token: 0x04004B0C RID: 19212
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPitch_Public_Void_0;

		// Token: 0x04004B0D RID: 19213
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x04004B0E RID: 19214
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004B0F RID: 19215
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04004B10 RID: 19216
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
