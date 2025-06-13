using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F0 RID: 1264
	public class AudioZone : Zone
	{
		// Token: 0x06006DC1 RID: 28097 RVA: 0x001EA17C File Offset: 0x001E837C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZone()
		{
			Il2CppClassPointerStore<AudioZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone>.NativeClassPtr);
			AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "VOLUME_CHANGE_RATE");
			AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "ROLLOFF_SCALE");
			AudioZone.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "MaxDistance");
			AudioZone.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Tracks");
			AudioZone.NativeFieldInfoPtr_Modifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Modifiers");
			AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "<VolumeModifier>k__BackingField");
			AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "CurrentVolumeMultiplier");
			AudioZone.NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677262);
			AudioZone.NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677263);
			AudioZone.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677264);
			AudioZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677265);
			AudioZone.NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677266);
			AudioZone.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677267);
			AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677268);
			AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677269);
			AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677270);
			AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, 100677271);
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x06006DC2 RID: 28098 RVA: 0x001EA300 File Offset: 0x001E8500
		// (set) Token: 0x06006DC3 RID: 28099 RVA: 0x001EA33C File Offset: 0x001E853C
		public unsafe float VolumeModifier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x001EA37C File Offset: 0x001E857C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220428, XrefRangeEnd = 220465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x001EA3B0 File Offset: 0x001E85B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220465, XrefRangeEnd = 220490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x001EA3E4 File Offset: 0x001E85E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220505, RefRangeEnd = 220506, XrefRangeStart = 220490, XrefRangeEnd = 220505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalVolumeMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x001EA420 File Offset: 0x001E8620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220506, XrefRangeEnd = 220531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x001EA454 File Offset: 0x001E8654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 220541, RefRangeEnd = 220542, XrefRangeStart = 220531, XrefRangeEnd = 220541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddModifier(AudioZoneModifierVolume modifier, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x001EA4A4 File Offset: 0x001E86A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220542, XrefRangeEnd = 220548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveModifier(AudioZoneModifierVolume modifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(modifier);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x001EA4E8 File Offset: 0x001E86E8
		[CallerCount(0)]
		public unsafe float GetFalloffFactor(float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref distance;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x001EA534 File Offset: 0x001E8734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220548, XrefRangeEnd = 220563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x00033B46 File Offset: 0x00031D46
		public AudioZone(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x06006DCD RID: 28109 RVA: 0x001EA570 File Offset: 0x001E8770
		// (set) Token: 0x06006DCE RID: 28110 RVA: 0x00033B4F File Offset: 0x00031D4F
		public unsafe static float VOLUME_CHANGE_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_VOLUME_CHANGE_RATE, (void*)(&value));
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x06006DCF RID: 28111 RVA: 0x001EA58C File Offset: 0x001E878C
		// (set) Token: 0x06006DD0 RID: 28112 RVA: 0x00033B5D File Offset: 0x00031D5D
		public unsafe static float ROLLOFF_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioZone.NativeFieldInfoPtr_ROLLOFF_SCALE, (void*)(&value));
			}
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x001EA5A8 File Offset: 0x001E87A8
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x00033B6B File Offset: 0x00031D6B
		public unsafe float MaxDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x06006DD3 RID: 28115 RVA: 0x001EA5D0 File Offset: 0x001E87D0
		// (set) Token: 0x06006DD4 RID: 28116 RVA: 0x00033B86 File Offset: 0x00031D86
		public unsafe List<AudioZone.Track> Tracks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Tracks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone.Track>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x06006DD5 RID: 28117 RVA: 0x001EA600 File Offset: 0x001E8800
		// (set) Token: 0x06006DD6 RID: 28118 RVA: 0x00033BA5 File Offset: 0x00031DA5
		public unsafe Dictionary<AudioZoneModifierVolume, float> Modifiers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Modifiers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioZoneModifierVolume, float>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_Modifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x06006DD7 RID: 28119 RVA: 0x001EA630 File Offset: 0x001E8830
		// (set) Token: 0x06006DD8 RID: 28120 RVA: 0x00033BC4 File Offset: 0x00031DC4
		public unsafe float _VolumeModifier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr__VolumeModifier_k__BackingField)) = value;
			}
		}

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x06006DD9 RID: 28121 RVA: 0x001EA658 File Offset: 0x001E8858
		// (set) Token: 0x06006DDA RID: 28122 RVA: 0x00033BDF File Offset: 0x00031DDF
		public unsafe float CurrentVolumeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.NativeFieldInfoPtr_CurrentVolumeMultiplier)) = value;
			}
		}

		// Token: 0x04004B18 RID: 19224
		private static readonly System.IntPtr NativeFieldInfoPtr_VOLUME_CHANGE_RATE;

		// Token: 0x04004B19 RID: 19225
		private static readonly System.IntPtr NativeFieldInfoPtr_ROLLOFF_SCALE;

		// Token: 0x04004B1A RID: 19226
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04004B1B RID: 19227
		private static readonly System.IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x04004B1C RID: 19228
		private static readonly System.IntPtr NativeFieldInfoPtr_Modifiers;

		// Token: 0x04004B1D RID: 19229
		private static readonly System.IntPtr NativeFieldInfoPtr__VolumeModifier_k__BackingField;

		// Token: 0x04004B1E RID: 19230
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentVolumeMultiplier;

		// Token: 0x04004B1F RID: 19231
		private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumeModifier_Public_get_Single_0;

		// Token: 0x04004B20 RID: 19232
		private static readonly System.IntPtr NativeMethodInfoPtr_set_VolumeModifier_Public_set_Void_Single_0;

		// Token: 0x04004B21 RID: 19233
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004B22 RID: 19234
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004B23 RID: 19235
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalVolumeMultiplier_Private_Single_0;

		// Token: 0x04004B24 RID: 19236
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004B25 RID: 19237
		private static readonly System.IntPtr NativeMethodInfoPtr_AddModifier_Public_Void_AudioZoneModifierVolume_Single_0;

		// Token: 0x04004B26 RID: 19238
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveModifier_Public_Void_AudioZoneModifierVolume_0;

		// Token: 0x04004B27 RID: 19239
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFalloffFactor_Private_Single_Single_0;

		// Token: 0x04004B28 RID: 19240
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA6 RID: 2726
		[System.Serializable]
		public class Track : Il2CppSystem.Object
		{
			// Token: 0x0600D591 RID: 54673 RVA: 0x00335A14 File Offset: 0x00333C14
			// Note: this type is marked as 'beforefieldinit'.
			static Track()
			{
				Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioZone>.NativeClassPtr, "Track");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr);
				AudioZone.Track.NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "Source");
				AudioZone.Track.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "Volume");
				AudioZone.Track.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "StartTime");
				AudioZone.Track.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "EndTime");
				AudioZone.Track.NativeFieldInfoPtr_FadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "FadeTime");
				AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "timeVolMultiplier");
				AudioZone.Track.NativeFieldInfoPtr_fadeInStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInStart");
				AudioZone.Track.NativeFieldInfoPtr_fadeInEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInEnd");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutStart");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutEnd");
				AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInStartMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeInEndMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutStartMinSum");
				AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, "fadeOutEndMinSum");
				AudioZone.Track.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100677272);
				AudioZone.Track.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100677273);
				AudioZone.Track.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100677274);
				AudioZone.Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr, 100677275);
			}

			// Token: 0x0600D592 RID: 54674 RVA: 0x00335BA8 File Offset: 0x00333DA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220411, XrefRangeEnd = 220419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D593 RID: 54675 RVA: 0x00335BDC File Offset: 0x00333DDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220419, XrefRangeEnd = 220422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update(float multiplier)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref multiplier;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D594 RID: 54676 RVA: 0x00335C1C File Offset: 0x00333E1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220422, XrefRangeEnd = 220427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTimeMultiplier(int time)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref time;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D595 RID: 54677 RVA: 0x00335C5C File Offset: 0x00333E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220427, XrefRangeEnd = 220428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Track() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZone.Track>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZone.Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D596 RID: 54678 RVA: 0x000679F0 File Offset: 0x00065BF0
			public Track(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004204 RID: 16900
			// (get) Token: 0x0600D597 RID: 54679 RVA: 0x00335C98 File Offset: 0x00333E98
			// (set) Token: 0x0600D598 RID: 54680 RVA: 0x000679F9 File Offset: 0x00065BF9
			public unsafe AudioSourceController Source
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Source);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004205 RID: 16901
			// (get) Token: 0x0600D599 RID: 54681 RVA: 0x00335CC8 File Offset: 0x00333EC8
			// (set) Token: 0x0600D59A RID: 54682 RVA: 0x00067A18 File Offset: 0x00065C18
			public unsafe float Volume
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_Volume)) = value;
				}
			}

			// Token: 0x17004206 RID: 16902
			// (get) Token: 0x0600D59B RID: 54683 RVA: 0x00335CF0 File Offset: 0x00333EF0
			// (set) Token: 0x0600D59C RID: 54684 RVA: 0x00067A33 File Offset: 0x00065C33
			public unsafe int StartTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_StartTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_StartTime)) = value;
				}
			}

			// Token: 0x17004207 RID: 16903
			// (get) Token: 0x0600D59D RID: 54685 RVA: 0x00335D18 File Offset: 0x00333F18
			// (set) Token: 0x0600D59E RID: 54686 RVA: 0x00067A4E File Offset: 0x00065C4E
			public unsafe int EndTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_EndTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_EndTime)) = value;
				}
			}

			// Token: 0x17004208 RID: 16904
			// (get) Token: 0x0600D59F RID: 54687 RVA: 0x00335D40 File Offset: 0x00333F40
			// (set) Token: 0x0600D5A0 RID: 54688 RVA: 0x00067A69 File Offset: 0x00065C69
			public unsafe int FadeTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_FadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_FadeTime)) = value;
				}
			}

			// Token: 0x17004209 RID: 16905
			// (get) Token: 0x0600D5A1 RID: 54689 RVA: 0x00335D68 File Offset: 0x00333F68
			// (set) Token: 0x0600D5A2 RID: 54690 RVA: 0x00067A84 File Offset: 0x00065C84
			public unsafe float timeVolMultiplier
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_timeVolMultiplier)) = value;
				}
			}

			// Token: 0x1700420A RID: 16906
			// (get) Token: 0x0600D5A3 RID: 54691 RVA: 0x00335D90 File Offset: 0x00333F90
			// (set) Token: 0x0600D5A4 RID: 54692 RVA: 0x00067A9F File Offset: 0x00065C9F
			public unsafe int fadeInStart
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStart)) = value;
				}
			}

			// Token: 0x1700420B RID: 16907
			// (get) Token: 0x0600D5A5 RID: 54693 RVA: 0x00335DB8 File Offset: 0x00333FB8
			// (set) Token: 0x0600D5A6 RID: 54694 RVA: 0x00067ABA File Offset: 0x00065CBA
			public unsafe int fadeInEnd
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEnd)) = value;
				}
			}

			// Token: 0x1700420C RID: 16908
			// (get) Token: 0x0600D5A7 RID: 54695 RVA: 0x00335DE0 File Offset: 0x00333FE0
			// (set) Token: 0x0600D5A8 RID: 54696 RVA: 0x00067AD5 File Offset: 0x00065CD5
			public unsafe int fadeOutStart
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStart)) = value;
				}
			}

			// Token: 0x1700420D RID: 16909
			// (get) Token: 0x0600D5A9 RID: 54697 RVA: 0x00335E08 File Offset: 0x00334008
			// (set) Token: 0x0600D5AA RID: 54698 RVA: 0x00067AF0 File Offset: 0x00065CF0
			public unsafe int fadeOutEnd
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEnd)) = value;
				}
			}

			// Token: 0x1700420E RID: 16910
			// (get) Token: 0x0600D5AB RID: 54699 RVA: 0x00335E30 File Offset: 0x00334030
			// (set) Token: 0x0600D5AC RID: 54700 RVA: 0x00067B0B File Offset: 0x00065D0B
			public unsafe int fadeInStartMinSum
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInStartMinSum)) = value;
				}
			}

			// Token: 0x1700420F RID: 16911
			// (get) Token: 0x0600D5AD RID: 54701 RVA: 0x00335E58 File Offset: 0x00334058
			// (set) Token: 0x0600D5AE RID: 54702 RVA: 0x00067B26 File Offset: 0x00065D26
			public unsafe int fadeInEndMinSum
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeInEndMinSum)) = value;
				}
			}

			// Token: 0x17004210 RID: 16912
			// (get) Token: 0x0600D5AF RID: 54703 RVA: 0x00335E80 File Offset: 0x00334080
			// (set) Token: 0x0600D5B0 RID: 54704 RVA: 0x00067B41 File Offset: 0x00065D41
			public unsafe int fadeOutStartMinSum
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutStartMinSum)) = value;
				}
			}

			// Token: 0x17004211 RID: 16913
			// (get) Token: 0x0600D5B1 RID: 54705 RVA: 0x00335EA8 File Offset: 0x003340A8
			// (set) Token: 0x0600D5B2 RID: 54706 RVA: 0x00067B5C File Offset: 0x00065D5C
			public unsafe int fadeOutEndMinSum
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZone.Track.NativeFieldInfoPtr_fadeOutEndMinSum)) = value;
				}
			}

			// Token: 0x04009034 RID: 36916
			private static readonly System.IntPtr NativeFieldInfoPtr_Source;

			// Token: 0x04009035 RID: 36917
			private static readonly System.IntPtr NativeFieldInfoPtr_Volume;

			// Token: 0x04009036 RID: 36918
			private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

			// Token: 0x04009037 RID: 36919
			private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;

			// Token: 0x04009038 RID: 36920
			private static readonly System.IntPtr NativeFieldInfoPtr_FadeTime;

			// Token: 0x04009039 RID: 36921
			private static readonly System.IntPtr NativeFieldInfoPtr_timeVolMultiplier;

			// Token: 0x0400903A RID: 36922
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeInStart;

			// Token: 0x0400903B RID: 36923
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeInEnd;

			// Token: 0x0400903C RID: 36924
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutStart;

			// Token: 0x0400903D RID: 36925
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutEnd;

			// Token: 0x0400903E RID: 36926
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeInStartMinSum;

			// Token: 0x0400903F RID: 36927
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeInEndMinSum;

			// Token: 0x04009040 RID: 36928
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutStartMinSum;

			// Token: 0x04009041 RID: 36929
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeOutEndMinSum;

			// Token: 0x04009042 RID: 36930
			private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

			// Token: 0x04009043 RID: 36931
			private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

			// Token: 0x04009044 RID: 36932
			private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeMultiplier_Public_Void_Int32_0;

			// Token: 0x04009045 RID: 36933
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
