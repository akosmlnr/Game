using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F3 RID: 1267
	public class FootstepSounds : MonoBehaviour
	{
		// Token: 0x06006DFE RID: 28158 RVA: 0x001EAC84 File Offset: 0x001E8E84
		// Note: this type is marked as 'beforefieldinit'.
		static FootstepSounds()
		{
			Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "FootstepSounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr);
			FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "COOLDOWN_TIME");
			FootstepSounds.NativeFieldInfoPtr__VolumeMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<VolumeMultiplier>k__BackingField");
			FootstepSounds.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "sources");
			FootstepSounds.NativeFieldInfoPtr_soundGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "soundGroups");
			FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "materialFootstepSounds");
			FootstepSounds.NativeFieldInfoPtr_lastStepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "lastStepTime");
			FootstepSounds.NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677287);
			FootstepSounds.NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677288);
			FootstepSounds.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677289);
			FootstepSounds.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677290);
			FootstepSounds.NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677291);
			FootstepSounds.NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677292);
			FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, 100677293);
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x06006DFF RID: 28159 RVA: 0x001EADB8 File Offset: 0x001E8FB8
		// (set) Token: 0x06006E00 RID: 28160 RVA: 0x001EADF4 File Offset: 0x001E8FF4
		public unsafe float VolumeMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x001EAE34 File Offset: 0x001E9034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220719, XrefRangeEnd = 220806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x001EAE68 File Offset: 0x001E9068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220806, XrefRangeEnd = 220807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x001EAE9C File Offset: 0x001E909C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220807, XrefRangeEnd = 220856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Step(EMaterialType materialType, float hardness)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref materialType;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref hardness;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x001EAEE8 File Offset: 0x001E90E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220856, XrefRangeEnd = 220874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSourceController GetFreeSource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x001EAF28 File Offset: 0x001E9128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220874, XrefRangeEnd = 220896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootstepSounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x00033D51 File Offset: 0x00031F51
		public FootstepSounds(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06006E07 RID: 28167 RVA: 0x001EAF64 File Offset: 0x001E9164
		// (set) Token: 0x06006E08 RID: 28168 RVA: 0x00033D5A File Offset: 0x00031F5A
		public unsafe static float COOLDOWN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootstepSounds.NativeFieldInfoPtr_COOLDOWN_TIME, (void*)(&value));
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06006E09 RID: 28169 RVA: 0x001EAF80 File Offset: 0x001E9180
		// (set) Token: 0x06006E0A RID: 28170 RVA: 0x00033D68 File Offset: 0x00031F68
		public unsafe float _VolumeMultiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr__VolumeMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr__VolumeMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06006E0B RID: 28171 RVA: 0x001EAFA8 File Offset: 0x001E91A8
		// (set) Token: 0x06006E0C RID: 28172 RVA: 0x00033D83 File Offset: 0x00031F83
		public unsafe List<AudioSourceController> sources
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sources);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioSourceController>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06006E0D RID: 28173 RVA: 0x001EAFD8 File Offset: 0x001E91D8
		// (set) Token: 0x06006E0E RID: 28174 RVA: 0x00033DA2 File Offset: 0x00031FA2
		public unsafe List<FootstepSounds.FootstepSoundGroup> soundGroups
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_soundGroups);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootstepSounds.FootstepSoundGroup>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_soundGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06006E0F RID: 28175 RVA: 0x001EB008 File Offset: 0x001E9208
		// (set) Token: 0x06006E10 RID: 28176 RVA: 0x00033DC1 File Offset: 0x00031FC1
		public unsafe Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup> materialFootstepSounds
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EMaterialType, FootstepSounds.FootstepSoundGroup>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_materialFootstepSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x06006E11 RID: 28177 RVA: 0x001EB038 File Offset: 0x001E9238
		// (set) Token: 0x06006E12 RID: 28178 RVA: 0x00033DE0 File Offset: 0x00031FE0
		public unsafe float lastStepTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_lastStepTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.NativeFieldInfoPtr_lastStepTime)) = value;
			}
		}

		// Token: 0x04004B3D RID: 19261
		private static readonly System.IntPtr NativeFieldInfoPtr_COOLDOWN_TIME;

		// Token: 0x04004B3E RID: 19262
		private static readonly System.IntPtr NativeFieldInfoPtr__VolumeMultiplier_k__BackingField;

		// Token: 0x04004B3F RID: 19263
		private static readonly System.IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x04004B40 RID: 19264
		private static readonly System.IntPtr NativeFieldInfoPtr_soundGroups;

		// Token: 0x04004B41 RID: 19265
		private static readonly System.IntPtr NativeFieldInfoPtr_materialFootstepSounds;

		// Token: 0x04004B42 RID: 19266
		private static readonly System.IntPtr NativeFieldInfoPtr_lastStepTime;

		// Token: 0x04004B43 RID: 19267
		private static readonly System.IntPtr NativeMethodInfoPtr_get_VolumeMultiplier_Public_get_Single_0;

		// Token: 0x04004B44 RID: 19268
		private static readonly System.IntPtr NativeMethodInfoPtr_set_VolumeMultiplier_Public_set_Void_Single_0;

		// Token: 0x04004B45 RID: 19269
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004B46 RID: 19270
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004B47 RID: 19271
		private static readonly System.IntPtr NativeMethodInfoPtr_Step_Public_Void_EMaterialType_Single_0;

		// Token: 0x04004B48 RID: 19272
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeSource_Public_AudioSourceController_0;

		// Token: 0x04004B49 RID: 19273
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA8 RID: 2728
		[System.Serializable]
		public class FootstepSoundGroup : Il2CppSystem.Object
		{
			// Token: 0x0600D5B9 RID: 54713 RVA: 0x00335FE8 File Offset: 0x003341E8
			// Note: this type is marked as 'beforefieldinit'.
			static FootstepSoundGroup()
			{
				Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "FootstepSoundGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr);
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "name");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "clips");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "appliesTo");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "PitchMin");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "PitchMax");
				FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "Volume");
				FootstepSounds.FootstepSoundGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, 100677294);
			}

			// Token: 0x0600D5BA RID: 54714 RVA: 0x003360A0 File Offset: 0x003342A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220686, XrefRangeEnd = 220701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FootstepSoundGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.FootstepSoundGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5BB RID: 54715 RVA: 0x00067B9F File Offset: 0x00065D9F
			public FootstepSoundGroup(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004213 RID: 16915
			// (get) Token: 0x0600D5BC RID: 54716 RVA: 0x003360DC File Offset: 0x003342DC
			// (set) Token: 0x0600D5BD RID: 54717 RVA: 0x00067BA8 File Offset: 0x00065DA8
			public unsafe string name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004214 RID: 16916
			// (get) Token: 0x0600D5BE RID: 54718 RVA: 0x00336104 File Offset: 0x00334304
			// (set) Token: 0x0600D5BF RID: 54719 RVA: 0x00067BC7 File Offset: 0x00065DC7
			public unsafe List<AudioClip> clips
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_clips), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004215 RID: 16917
			// (get) Token: 0x0600D5C0 RID: 54720 RVA: 0x00336134 File Offset: 0x00334334
			// (set) Token: 0x0600D5C1 RID: 54721 RVA: 0x00067BE6 File Offset: 0x00065DE6
			public unsafe List<FootstepSounds.FootstepSoundGroup.MaterialType> appliesTo
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootstepSounds.FootstepSoundGroup.MaterialType>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_appliesTo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004216 RID: 16918
			// (get) Token: 0x0600D5C2 RID: 54722 RVA: 0x00336164 File Offset: 0x00334364
			// (set) Token: 0x0600D5C3 RID: 54723 RVA: 0x00067C05 File Offset: 0x00065E05
			public unsafe float PitchMin
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMin)) = value;
				}
			}

			// Token: 0x17004217 RID: 16919
			// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x0033618C File Offset: 0x0033438C
			// (set) Token: 0x0600D5C5 RID: 54725 RVA: 0x00067C20 File Offset: 0x00065E20
			public unsafe float PitchMax
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_PitchMax)) = value;
				}
			}

			// Token: 0x17004218 RID: 16920
			// (get) Token: 0x0600D5C6 RID: 54726 RVA: 0x003361B4 File Offset: 0x003343B4
			// (set) Token: 0x0600D5C7 RID: 54727 RVA: 0x00067C3B File Offset: 0x00065E3B
			public unsafe float Volume
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.NativeFieldInfoPtr_Volume)) = value;
				}
			}

			// Token: 0x04009049 RID: 36937
			private static readonly System.IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400904A RID: 36938
			private static readonly System.IntPtr NativeFieldInfoPtr_clips;

			// Token: 0x0400904B RID: 36939
			private static readonly System.IntPtr NativeFieldInfoPtr_appliesTo;

			// Token: 0x0400904C RID: 36940
			private static readonly System.IntPtr NativeFieldInfoPtr_PitchMin;

			// Token: 0x0400904D RID: 36941
			private static readonly System.IntPtr NativeFieldInfoPtr_PitchMax;

			// Token: 0x0400904E RID: 36942
			private static readonly System.IntPtr NativeFieldInfoPtr_Volume;

			// Token: 0x0400904F RID: 36943
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000CB9 RID: 3257
			[System.Serializable]
			public class MaterialType : Il2CppSystem.Object
			{
				// Token: 0x0600E988 RID: 59784 RVA: 0x0036E944 File Offset: 0x0036CB44
				// Note: this type is marked as 'beforefieldinit'.
				static MaterialType()
				{
					Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup>.NativeClassPtr, "MaterialType");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr);
					FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr, "type");
					FootstepSounds.FootstepSoundGroup.MaterialType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr, 100677295);
				}

				// Token: 0x0600E989 RID: 59785 RVA: 0x0036E998 File Offset: 0x0036CB98
				[CallerCount(2576)]
				[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe MaterialType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.FootstepSoundGroup.MaterialType>.NativeClassPtr))
				{
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.FootstepSoundGroup.MaterialType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E98A RID: 59786 RVA: 0x00071874 File Offset: 0x0006FA74
				public MaterialType(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700482C RID: 18476
				// (get) Token: 0x0600E98B RID: 59787 RVA: 0x0036E9D4 File Offset: 0x0036CBD4
				// (set) Token: 0x0600E98C RID: 59788 RVA: 0x0007187D File Offset: 0x0006FA7D
				public unsafe EMaterialType type
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.FootstepSoundGroup.MaterialType.NativeFieldInfoPtr_type)) = value;
					}
				}

				// Token: 0x04009C4A RID: 40010
				private static readonly System.IntPtr NativeFieldInfoPtr_type;

				// Token: 0x04009C4B RID: 40011
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000AA9 RID: 2729
		[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D5C8 RID: 54728 RVA: 0x003361DC File Offset: 0x003343DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr);
				FootstepSounds.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, "<>9");
				FootstepSounds.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, "<>9__13_0");
				FootstepSounds.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, 100677297);
				FootstepSounds.__c.NativeMethodInfoPtr__GetFreeSource_b__13_0_Internal_Boolean_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr, 100677298);
			}

			// Token: 0x0600D5C9 RID: 54729 RVA: 0x00336258 File Offset: 0x00334458
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5CA RID: 54730 RVA: 0x00336294 File Offset: 0x00334494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220701, XrefRangeEnd = 220702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFreeSource_b__13_0(AudioSourceController source)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c.NativeMethodInfoPtr__GetFreeSource_b__13_0_Internal_Boolean_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D5CB RID: 54731 RVA: 0x00067C56 File Offset: 0x00065E56
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004219 RID: 16921
			// (get) Token: 0x0600D5CC RID: 54732 RVA: 0x003362E4 File Offset: 0x003344E4
			// (set) Token: 0x0600D5CD RID: 54733 RVA: 0x00067C5F File Offset: 0x00065E5F
			public unsafe static FootstepSounds.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FootstepSounds.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FootstepSounds.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700421A RID: 16922
			// (get) Token: 0x0600D5CE RID: 54734 RVA: 0x0033630C File Offset: 0x0033450C
			// (set) Token: 0x0600D5CF RID: 54735 RVA: 0x00067C71 File Offset: 0x00065E71
			public unsafe static Il2CppSystem.Func<AudioSourceController, bool> __9__13_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FootstepSounds.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<AudioSourceController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FootstepSounds.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009050 RID: 36944
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009051 RID: 36945
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009052 RID: 36946
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009053 RID: 36947
			private static readonly System.IntPtr NativeMethodInfoPtr__GetFreeSource_b__13_0_Internal_Boolean_AudioSourceController_0;
		}

		// Token: 0x02000AAA RID: 2730
		[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5D0 RID: 54736 RVA: 0x00336334 File Offset: 0x00334534
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr);
				FootstepSounds.__c__DisplayClass12_0.NativeFieldInfoPtr_source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr, "source");
				FootstepSounds.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr, 100677299);
				FootstepSounds.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr, 100677300);
			}

			// Token: 0x0600D5D1 RID: 54737 RVA: 0x0033639C File Offset: 0x0033459C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5D2 RID: 54738 RVA: 0x003363D8 File Offset: 0x003345D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220714, XrefRangeEnd = 220719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D5D3 RID: 54739 RVA: 0x00067C83 File Offset: 0x00065E83
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700421B RID: 16923
			// (get) Token: 0x0600D5D4 RID: 54740 RVA: 0x00336418 File Offset: 0x00334618
			// (set) Token: 0x0600D5D5 RID: 54741 RVA: 0x00067C8C File Offset: 0x00065E8C
			public unsafe AudioSourceController source
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.NativeFieldInfoPtr_source);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.NativeFieldInfoPtr_source), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009054 RID: 36948
			private static readonly System.IntPtr NativeFieldInfoPtr_source;

			// Token: 0x04009055 RID: 36949
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009056 RID: 36950
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CBA RID: 3258
			[ObfuscatedName("ScheduleOne.Audio.FootstepSounds+<>c__DisplayClass12_0+<<Step>g__DisableSource|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E98D RID: 59789 RVA: 0x0036E9FC File Offset: 0x0036CBFC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0>.NativeClassPtr, "<<Step>g__DisableSource|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677301);
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677302);
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677303);
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677304);
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677305);
					FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677306);
				}

				// Token: 0x0600E98E RID: 59790 RVA: 0x0036EADC File Offset: 0x0036CCDC
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E98F RID: 59791 RVA: 0x0036EB24 File Offset: 0x0036CD24
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E990 RID: 59792 RVA: 0x0036EB58 File Offset: 0x0036CD58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220702, XrefRangeEnd = 220709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004830 RID: 18480
				// (get) Token: 0x0600E991 RID: 59793 RVA: 0x0036EB94 File Offset: 0x0036CD94
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E992 RID: 59794 RVA: 0x0036EBD4 File Offset: 0x0036CDD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220709, XrefRangeEnd = 220714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004831 RID: 18481
				// (get) Token: 0x0600E993 RID: 59795 RVA: 0x0036EC08 File Offset: 0x0036CE08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E994 RID: 59796 RVA: 0x00071898 File Offset: 0x0006FA98
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700482D RID: 18477
				// (get) Token: 0x0600E995 RID: 59797 RVA: 0x0036EC48 File Offset: 0x0036CE48
				// (set) Token: 0x0600E996 RID: 59798 RVA: 0x000718A1 File Offset: 0x0006FAA1
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700482E RID: 18478
				// (get) Token: 0x0600E997 RID: 59799 RVA: 0x0036EC70 File Offset: 0x0036CE70
				// (set) Token: 0x0600E998 RID: 59800 RVA: 0x000718BC File Offset: 0x0006FABC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700482F RID: 18479
				// (get) Token: 0x0600E999 RID: 59801 RVA: 0x0036ECA0 File Offset: 0x0036CEA0
				// (set) Token: 0x0600E99A RID: 59802 RVA: 0x000718DB File Offset: 0x0006FADB
				public unsafe FootstepSounds.__c__DisplayClass12_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootstepSounds.__c__DisplayClass12_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FootstepSounds.__c__DisplayClass12_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C4C RID: 40012
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C4D RID: 40013
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C4E RID: 40014
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C4F RID: 40015
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C50 RID: 40016
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C51 RID: 40017
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C52 RID: 40018
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C53 RID: 40019
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C54 RID: 40020
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
