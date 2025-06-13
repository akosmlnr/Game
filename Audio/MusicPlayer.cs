using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Audio;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F7 RID: 1271
	public class MusicPlayer : PersistentSingleton<MusicPlayer>
	{
		// Token: 0x06006E34 RID: 28212 RVA: 0x001EB5D4 File Offset: 0x001E97D4
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPlayer()
		{
			Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr);
			MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "TimeSinceLastAmbientTrack");
			MusicPlayer.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "Tracks");
			MusicPlayer.NativeFieldInfoPtr_MusicMixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "MusicMixer");
			MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "DefaultSnapshot");
			MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "DistortedSnapshot");
			MusicPlayer.NativeFieldInfoPtr__currentTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "_currentTrack");
			MusicPlayer.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677316);
			MusicPlayer.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677317);
			MusicPlayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677318);
			MusicPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677319);
			MusicPlayer.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677320);
			MusicPlayer.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677321);
			MusicPlayer.NativeMethodInfoPtr_StopTrack_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677322);
			MusicPlayer.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677323);
			MusicPlayer.NativeMethodInfoPtr_UpdateTracks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677324);
			MusicPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677325);
			MusicPlayer.NativeMethodInfoPtr__Start_b__9_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, 100677327);
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x001EB758 File Offset: 0x001E9958
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220977, XrefRangeEnd = 220981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x001EB794 File Offset: 0x001E9994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220981, XrefRangeEnd = 221002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x001EB7C8 File Offset: 0x001E99C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221002, XrefRangeEnd = 221033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicPlayer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x001EB804 File Offset: 0x001E9A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221033, XrefRangeEnd = 221039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x001EB838 File Offset: 0x001E9A38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 221042, RefRangeEnd = 221050, XrefRangeStart = 221039, XrefRangeEnd = 221042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMusicDistorted(bool distorted, float transition = 5f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref distorted;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref transition;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x001EB884 File Offset: 0x001E9A84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 221070, RefRangeEnd = 221076, XrefRangeStart = 221050, XrefRangeEnd = 221070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrackEnabled(string trackName, bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x001EB8D4 File Offset: 0x001E9AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221102, RefRangeEnd = 221103, XrefRangeStart = 221076, XrefRangeEnd = 221102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTrack(string trackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trackName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_StopTrack_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x001EB918 File Offset: 0x001E9B18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221117, RefRangeEnd = 221119, XrefRangeStart = 221103, XrefRangeEnd = 221117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAndDisableTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x001EB94C File Offset: 0x001E9B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221119, XrefRangeEnd = 221155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTracks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr_UpdateTracks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x001EB980 File Offset: 0x001E9B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221155, XrefRangeEnd = 221165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPlayer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x001EB9BC File Offset: 0x001E9BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221165, XrefRangeEnd = 221167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__9_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.NativeMethodInfoPtr__Start_b__9_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x00033EFF File Offset: 0x000320FF
		public MusicPlayer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x001EB9F0 File Offset: 0x001E9BF0
		// (set) Token: 0x06006E42 RID: 28226 RVA: 0x00033F08 File Offset: 0x00032108
		public unsafe static float TimeSinceLastAmbientTrack
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicPlayer.NativeFieldInfoPtr_TimeSinceLastAmbientTrack, (void*)(&value));
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x06006E43 RID: 28227 RVA: 0x001EBA0C File Offset: 0x001E9C0C
		// (set) Token: 0x06006E44 RID: 28228 RVA: 0x00033F16 File Offset: 0x00032116
		public unsafe List<MusicTrack> Tracks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_Tracks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x06006E45 RID: 28229 RVA: 0x001EBA3C File Offset: 0x001E9C3C
		// (set) Token: 0x06006E46 RID: 28230 RVA: 0x00033F35 File Offset: 0x00032135
		public unsafe AudioMixerGroup MusicMixer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_MusicMixer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_MusicMixer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06006E47 RID: 28231 RVA: 0x001EBA6C File Offset: 0x001E9C6C
		// (set) Token: 0x06006E48 RID: 28232 RVA: 0x00033F54 File Offset: 0x00032154
		public unsafe AudioMixerSnapshot DefaultSnapshot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DefaultSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06006E49 RID: 28233 RVA: 0x001EBA9C File Offset: 0x001E9C9C
		// (set) Token: 0x06006E4A RID: 28234 RVA: 0x00033F73 File Offset: 0x00032173
		public unsafe AudioMixerSnapshot DistortedSnapshot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioMixerSnapshot>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr_DistortedSnapshot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06006E4B RID: 28235 RVA: 0x001EBACC File Offset: 0x001E9CCC
		// (set) Token: 0x06006E4C RID: 28236 RVA: 0x00033F92 File Offset: 0x00032192
		public unsafe MusicTrack _currentTrack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr__currentTrack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicTrack>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.NativeFieldInfoPtr__currentTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B5C RID: 19292
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeSinceLastAmbientTrack;

		// Token: 0x04004B5D RID: 19293
		private static readonly System.IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x04004B5E RID: 19294
		private static readonly System.IntPtr NativeFieldInfoPtr_MusicMixer;

		// Token: 0x04004B5F RID: 19295
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSnapshot;

		// Token: 0x04004B60 RID: 19296
		private static readonly System.IntPtr NativeFieldInfoPtr_DistortedSnapshot;

		// Token: 0x04004B61 RID: 19297
		private static readonly System.IntPtr NativeFieldInfoPtr__currentTrack;

		// Token: 0x04004B62 RID: 19298
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004B63 RID: 19299
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04004B64 RID: 19300
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004B65 RID: 19301
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004B66 RID: 19302
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMusicDistorted_Public_Void_Boolean_Single_0;

		// Token: 0x04004B67 RID: 19303
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTrackEnabled_Public_Void_String_Boolean_0;

		// Token: 0x04004B68 RID: 19304
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTrack_Public_Void_String_0;

		// Token: 0x04004B69 RID: 19305
		private static readonly System.IntPtr NativeMethodInfoPtr_StopAndDisableTracks_Public_Void_0;

		// Token: 0x04004B6A RID: 19306
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTracks_Private_Void_0;

		// Token: 0x04004B6B RID: 19307
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004B6C RID: 19308
		private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__9_0_Private_Void_0;

		// Token: 0x02000AAC RID: 2732
		[ObfuscatedName("ScheduleOne.Audio.MusicPlayer+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5D6 RID: 54742 RVA: 0x00336448 File Offset: 0x00334648
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr);
				MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, "trackName");
				MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, 100677328);
				MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr, 100677329);
			}

			// Token: 0x0600D5D7 RID: 54743 RVA: 0x003364B0 File Offset: 0x003346B0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5D8 RID: 54744 RVA: 0x003364EC File Offset: 0x003346EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetTrackEnabled_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass12_0.NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D5D9 RID: 54745 RVA: 0x00067CAB File Offset: 0x00065EAB
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700421C RID: 16924
			// (get) Token: 0x0600D5DA RID: 54746 RVA: 0x0033653C File Offset: 0x0033473C
			// (set) Token: 0x0600D5DB RID: 54747 RVA: 0x00067CB4 File Offset: 0x00065EB4
			public unsafe string trackName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass12_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009062 RID: 36962
			private static readonly System.IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04009063 RID: 36963
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009064 RID: 36964
			private static readonly System.IntPtr NativeMethodInfoPtr__SetTrackEnabled_b__0_Internal_Boolean_MusicTrack_0;
		}

		// Token: 0x02000AAD RID: 2733
		[ObfuscatedName("ScheduleOne.Audio.MusicPlayer+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D5DC RID: 54748 RVA: 0x00336564 File Offset: 0x00334764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPlayer>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr);
				MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, "trackName");
				MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, 100677330);
				MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr, 100677331);
			}

			// Token: 0x0600D5DD RID: 54749 RVA: 0x003365CC File Offset: 0x003347CC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPlayer.__c__DisplayClass13_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D5DE RID: 54750 RVA: 0x00336608 File Offset: 0x00334808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StopTrack_b__0(MusicTrack t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MusicPlayer.__c__DisplayClass13_0.NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D5DF RID: 54751 RVA: 0x00067CD3 File Offset: 0x00065ED3
			public __c__DisplayClass13_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700421D RID: 16925
			// (get) Token: 0x0600D5E0 RID: 54752 RVA: 0x00336658 File Offset: 0x00334858
			// (set) Token: 0x0600D5E1 RID: 54753 RVA: 0x00067CDC File Offset: 0x00065EDC
			public unsafe string trackName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPlayer.__c__DisplayClass13_0.NativeFieldInfoPtr_trackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009065 RID: 36965
			private static readonly System.IntPtr NativeFieldInfoPtr_trackName;

			// Token: 0x04009066 RID: 36966
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009067 RID: 36967
			private static readonly System.IntPtr NativeMethodInfoPtr__StopTrack_b__0_Internal_Boolean_MusicTrack_0;
		}
	}
}
