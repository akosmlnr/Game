using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F9 RID: 1273
	public class MusicTrack : MonoBehaviour
	{
		// Token: 0x06006E52 RID: 28242 RVA: 0x001EBC1C File Offset: 0x001E9E1C
		// Note: this type is marked as 'beforefieldinit'.
		static MusicTrack()
		{
			Il2CppClassPointerStore<MusicTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "MusicTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr);
			MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "<IsPlaying>k__BackingField");
			MusicTrack.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Enabled");
			MusicTrack.NativeFieldInfoPtr_TrackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "TrackName");
			MusicTrack.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Priority");
			MusicTrack.NativeFieldInfoPtr_FadeInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "FadeInTime");
			MusicTrack.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "FadeOutTime");
			MusicTrack.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "Controller");
			MusicTrack.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "VolumeMultiplier");
			MusicTrack.NativeFieldInfoPtr_AutoFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "AutoFadeOut");
			MusicTrack.NativeFieldInfoPtr_volumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, "volumeMultiplier");
			MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677335);
			MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677336);
			MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677337);
			MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677338);
			MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677339);
			MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677340);
			MusicTrack.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677341);
			MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677342);
			MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677343);
			MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr, 100677344);
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x06006E53 RID: 28243 RVA: 0x001EBDDC File Offset: 0x001E9FDC
		// (set) Token: 0x06006E54 RID: 28244 RVA: 0x001EBE18 File Offset: 0x001EA018
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x001EBE58 File Offset: 0x001EA058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221197, XrefRangeEnd = 221206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x001EBE8C File Offset: 0x001EA08C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 221206, RefRangeEnd = 221210, XrefRangeStart = 221206, XrefRangeEnd = 221206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x001EBEC0 File Offset: 0x001EA0C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221210, RefRangeEnd = 221212, XrefRangeStart = 221210, XrefRangeEnd = 221210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x001EBEF4 File Offset: 0x001EA0F4
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x001EBF30 File Offset: 0x001EA130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 221217, RefRangeEnd = 221218, XrefRangeStart = 221212, XrefRangeEnd = 221217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x001EBF6C File Offset: 0x001EA16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221218, XrefRangeEnd = 221219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x001EBFA8 File Offset: 0x001EA1A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88449, RefRangeEnd = 88450, XrefRangeStart = 88449, XrefRangeEnd = 88450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MusicTrack.NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x001EBFE4 File Offset: 0x001EA1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221219, XrefRangeEnd = 221224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicTrack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicTrack>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x00033FBA File Offset: 0x000321BA
		public MusicTrack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x06006E5E RID: 28254 RVA: 0x001EC020 File Offset: 0x001EA220
		// (set) Token: 0x06006E5F RID: 28255 RVA: 0x00033FC3 File Offset: 0x000321C3
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x06006E60 RID: 28256 RVA: 0x001EC048 File Offset: 0x001EA248
		// (set) Token: 0x06006E61 RID: 28257 RVA: 0x00033FDE File Offset: 0x000321DE
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06006E62 RID: 28258 RVA: 0x001EC070 File Offset: 0x001EA270
		// (set) Token: 0x06006E63 RID: 28259 RVA: 0x00033FF9 File Offset: 0x000321F9
		public unsafe string TrackName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_TrackName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_TrackName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x001EC098 File Offset: 0x001EA298
		// (set) Token: 0x06006E65 RID: 28261 RVA: 0x00034018 File Offset: 0x00032218
		public unsafe int Priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x06006E66 RID: 28262 RVA: 0x001EC0C0 File Offset: 0x001EA2C0
		// (set) Token: 0x06006E67 RID: 28263 RVA: 0x00034033 File Offset: 0x00032233
		public unsafe float FadeInTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeInTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeInTime)) = value;
			}
		}

		// Token: 0x170020FD RID: 8445
		// (get) Token: 0x06006E68 RID: 28264 RVA: 0x001EC0E8 File Offset: 0x001EA2E8
		// (set) Token: 0x06006E69 RID: 28265 RVA: 0x0003404E File Offset: 0x0003224E
		public unsafe float FadeOutTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeOutTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_FadeOutTime)) = value;
			}
		}

		// Token: 0x170020FE RID: 8446
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x001EC110 File Offset: 0x001EA310
		// (set) Token: 0x06006E6B RID: 28267 RVA: 0x00034069 File Offset: 0x00032269
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020FF RID: 8447
		// (get) Token: 0x06006E6C RID: 28268 RVA: 0x001EC140 File Offset: 0x001EA340
		// (set) Token: 0x06006E6D RID: 28269 RVA: 0x00034088 File Offset: 0x00032288
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x001EC168 File Offset: 0x001EA368
		// (set) Token: 0x06006E6F RID: 28271 RVA: 0x000340A3 File Offset: 0x000322A3
		public unsafe bool AutoFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_AutoFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_AutoFadeOut)) = value;
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x001EC190 File Offset: 0x001EA390
		// (set) Token: 0x06006E71 RID: 28273 RVA: 0x000340BE File Offset: 0x000322BE
		public unsafe float volumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_volumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicTrack.NativeFieldInfoPtr_volumeMultiplier)) = value;
			}
		}

		// Token: 0x04004B70 RID: 19312
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04004B71 RID: 19313
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04004B72 RID: 19314
		private static readonly IntPtr NativeFieldInfoPtr_TrackName;

		// Token: 0x04004B73 RID: 19315
		private static readonly IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04004B74 RID: 19316
		private static readonly IntPtr NativeFieldInfoPtr_FadeInTime;

		// Token: 0x04004B75 RID: 19317
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutTime;

		// Token: 0x04004B76 RID: 19318
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04004B77 RID: 19319
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004B78 RID: 19320
		private static readonly IntPtr NativeFieldInfoPtr_AutoFadeOut;

		// Token: 0x04004B79 RID: 19321
		private static readonly IntPtr NativeFieldInfoPtr_volumeMultiplier;

		// Token: 0x04004B7A RID: 19322
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004B7B RID: 19323
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04004B7C RID: 19324
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004B7D RID: 19325
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x04004B7E RID: 19326
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x04004B7F RID: 19327
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004B80 RID: 19328
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04004B81 RID: 19329
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x04004B82 RID: 19330
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_New_Void_0;

		// Token: 0x04004B83 RID: 19331
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
