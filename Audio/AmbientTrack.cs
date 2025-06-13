using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004EC RID: 1260
	public class AmbientTrack : MonoBehaviour
	{
		// Token: 0x06006D2E RID: 27950 RVA: 0x001E8670 File Offset: 0x001E6870
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientTrack()
		{
			Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr);
			AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MIN_TIME_BETWEEN_AMBIENT_TRACKS");
			AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "LastPlayedTrack");
			AmbientTrack.NativeFieldInfoPtr_TrackQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "TrackQueued");
			AmbientTrack.NativeFieldInfoPtr_Tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "Tracks");
			AmbientTrack.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MinTime");
			AmbientTrack.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "MaxTime");
			AmbientTrack.NativeFieldInfoPtr_Chance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "Chance");
			AmbientTrack.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "startTime");
			AmbientTrack.NativeFieldInfoPtr_playTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "playTrack");
			AmbientTrack.NativeFieldInfoPtr_trackRandomized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, "trackRandomized");
			AmbientTrack.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100677211);
			AmbientTrack.NativeMethodInfoPtr_ForcePlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100677212);
			AmbientTrack.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100677213);
			AmbientTrack.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100677214);
			AmbientTrack.NativeMethodInfoPtr_CanStartAmbientTrack_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100677215);
			AmbientTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr, 100677216);
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x001E87E0 File Offset: 0x001E69E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219871, XrefRangeEnd = 219884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x001E8814 File Offset: 0x001E6A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219908, RefRangeEnd = 219909, XrefRangeStart = 219884, XrefRangeEnd = 219908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForcePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_ForcePlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x001E8848 File Offset: 0x001E6A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219909, XrefRangeEnd = 219915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x001E887C File Offset: 0x001E6A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219915, XrefRangeEnd = 219998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x001E88B0 File Offset: 0x001E6AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219998, XrefRangeEnd = 220024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStartAmbientTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AmbientTrack.NativeMethodInfoPtr_CanStartAmbientTrack_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x001E88F8 File Offset: 0x001E6AF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220024, XrefRangeEnd = 220032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientTrack>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x0003369B File Offset: 0x0003189B
		public AmbientTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002091 RID: 8337
		// (get) Token: 0x06006D36 RID: 27958 RVA: 0x001E8934 File Offset: 0x001E6B34
		// (set) Token: 0x06006D37 RID: 27959 RVA: 0x000336A4 File Offset: 0x000318A4
		public unsafe static float MIN_TIME_BETWEEN_AMBIENT_TRACKS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS, (void*)(&value));
			}
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06006D38 RID: 27960 RVA: 0x001E8950 File Offset: 0x001E6B50
		// (set) Token: 0x06006D39 RID: 27961 RVA: 0x000336B2 File Offset: 0x000318B2
		public unsafe static AmbientTrack LastPlayedTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientTrack>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_LastPlayedTrack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06006D3A RID: 27962 RVA: 0x001E8978 File Offset: 0x001E6B78
		// (set) Token: 0x06006D3B RID: 27963 RVA: 0x000336C4 File Offset: 0x000318C4
		public unsafe static bool TrackQueued
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(AmbientTrack.NativeFieldInfoPtr_TrackQueued, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientTrack.NativeFieldInfoPtr_TrackQueued, (void*)(&value));
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06006D3C RID: 27964 RVA: 0x001E8994 File Offset: 0x001E6B94
		// (set) Token: 0x06006D3D RID: 27965 RVA: 0x000336D2 File Offset: 0x000318D2
		public unsafe List<MusicTrack> Tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MusicTrack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06006D3E RID: 27966 RVA: 0x001E89C4 File Offset: 0x001E6BC4
		// (set) Token: 0x06006D3F RID: 27967 RVA: 0x000336F1 File Offset: 0x000318F1
		public unsafe int MinTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MinTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MinTime)) = value;
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06006D40 RID: 27968 RVA: 0x001E89EC File Offset: 0x001E6BEC
		// (set) Token: 0x06006D41 RID: 27969 RVA: 0x0003370C File Offset: 0x0003190C
		public unsafe int MaxTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MaxTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_MaxTime)) = value;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06006D42 RID: 27970 RVA: 0x001E8A14 File Offset: 0x001E6C14
		// (set) Token: 0x06006D43 RID: 27971 RVA: 0x00033727 File Offset: 0x00031927
		public unsafe float Chance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Chance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_Chance)) = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06006D44 RID: 27972 RVA: 0x001E8A3C File Offset: 0x001E6C3C
		// (set) Token: 0x06006D45 RID: 27973 RVA: 0x00033742 File Offset: 0x00031942
		public unsafe int startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06006D46 RID: 27974 RVA: 0x001E8A64 File Offset: 0x001E6C64
		// (set) Token: 0x06006D47 RID: 27975 RVA: 0x0003375D File Offset: 0x0003195D
		public unsafe bool playTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_playTrack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_playTrack)) = value;
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06006D48 RID: 27976 RVA: 0x001E8A8C File Offset: 0x001E6C8C
		// (set) Token: 0x06006D49 RID: 27977 RVA: 0x00033778 File Offset: 0x00031978
		public unsafe bool trackRandomized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_trackRandomized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientTrack.NativeFieldInfoPtr_trackRandomized)) = value;
			}
		}

		// Token: 0x04004AB1 RID: 19121
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TIME_BETWEEN_AMBIENT_TRACKS;

		// Token: 0x04004AB2 RID: 19122
		private static readonly IntPtr NativeFieldInfoPtr_LastPlayedTrack;

		// Token: 0x04004AB3 RID: 19123
		private static readonly IntPtr NativeFieldInfoPtr_TrackQueued;

		// Token: 0x04004AB4 RID: 19124
		private static readonly IntPtr NativeFieldInfoPtr_Tracks;

		// Token: 0x04004AB5 RID: 19125
		private static readonly IntPtr NativeFieldInfoPtr_MinTime;

		// Token: 0x04004AB6 RID: 19126
		private static readonly IntPtr NativeFieldInfoPtr_MaxTime;

		// Token: 0x04004AB7 RID: 19127
		private static readonly IntPtr NativeFieldInfoPtr_Chance;

		// Token: 0x04004AB8 RID: 19128
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x04004AB9 RID: 19129
		private static readonly IntPtr NativeFieldInfoPtr_playTrack;

		// Token: 0x04004ABA RID: 19130
		private static readonly IntPtr NativeFieldInfoPtr_trackRandomized;

		// Token: 0x04004ABB RID: 19131
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004ABC RID: 19132
		private static readonly IntPtr NativeMethodInfoPtr_ForcePlay_Public_Void_0;

		// Token: 0x04004ABD RID: 19133
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04004ABE RID: 19134
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004ABF RID: 19135
		private static readonly IntPtr NativeMethodInfoPtr_CanStartAmbientTrack_Protected_Virtual_New_Boolean_0;

		// Token: 0x04004AC0 RID: 19136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
