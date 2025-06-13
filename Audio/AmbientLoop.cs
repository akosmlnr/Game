using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004E9 RID: 1257
	public class AmbientLoop : MonoBehaviour
	{
		// Token: 0x06006CF8 RID: 27896 RVA: 0x001E7E0C File Offset: 0x001E600C
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientLoop()
		{
			Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientLoop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr);
			AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "MUSIC_FADE_MULTIPLIER");
			AmbientLoop.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "VolumeCurve");
			AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "FadeDuringMusic");
			AmbientLoop.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "audioSourceController");
			AmbientLoop.NativeFieldInfoPtr_musicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, "musicScale");
			AmbientLoop.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100677199);
			AmbientLoop.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100677200);
			AmbientLoop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr, 100677201);
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x001E7EDC File Offset: 0x001E60DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219749, XrefRangeEnd = 219754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x001E7F10 File Offset: 0x001E6110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219754, XrefRangeEnd = 219765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x001E7F44 File Offset: 0x001E6144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219765, XrefRangeEnd = 219766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientLoop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientLoop>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x0003348F File Offset: 0x0003168F
		public AmbientLoop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700207F RID: 8319
		// (get) Token: 0x06006CFD RID: 27901 RVA: 0x001E7F80 File Offset: 0x001E6180
		// (set) Token: 0x06006CFE RID: 27902 RVA: 0x00033498 File Offset: 0x00031698
		public unsafe static float MUSIC_FADE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientLoop.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002080 RID: 8320
		// (get) Token: 0x06006CFF RID: 27903 RVA: 0x001E7F9C File Offset: 0x001E619C
		// (set) Token: 0x06006D00 RID: 27904 RVA: 0x000334A6 File Offset: 0x000316A6
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002081 RID: 8321
		// (get) Token: 0x06006D01 RID: 27905 RVA: 0x001E7FCC File Offset: 0x001E61CC
		// (set) Token: 0x06006D02 RID: 27906 RVA: 0x000334C5 File Offset: 0x000316C5
		public unsafe bool FadeDuringMusic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_FadeDuringMusic)) = value;
			}
		}

		// Token: 0x17002082 RID: 8322
		// (get) Token: 0x06006D03 RID: 27907 RVA: 0x001E7FF4 File Offset: 0x001E61F4
		// (set) Token: 0x06006D04 RID: 27908 RVA: 0x000334E0 File Offset: 0x000316E0
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002083 RID: 8323
		// (get) Token: 0x06006D05 RID: 27909 RVA: 0x001E8024 File Offset: 0x001E6224
		// (set) Token: 0x06006D06 RID: 27910 RVA: 0x000334FF File Offset: 0x000316FF
		public unsafe float musicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_musicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoop.NativeFieldInfoPtr_musicScale)) = value;
			}
		}

		// Token: 0x04004A93 RID: 19091
		private static readonly IntPtr NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER;

		// Token: 0x04004A94 RID: 19092
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04004A95 RID: 19093
		private static readonly IntPtr NativeFieldInfoPtr_FadeDuringMusic;

		// Token: 0x04004A96 RID: 19094
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x04004A97 RID: 19095
		private static readonly IntPtr NativeFieldInfoPtr_musicScale;

		// Token: 0x04004A98 RID: 19096
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004A99 RID: 19097
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004A9A RID: 19098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
