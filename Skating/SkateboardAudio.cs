using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001B1 RID: 433
	public class SkateboardAudio : MonoBehaviour
	{
		// Token: 0x0600241A RID: 9242 RVA: 0x000E3AF8 File Offset: 0x000E1CF8
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardAudio()
		{
			Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr);
			SkateboardAudio.NativeFieldInfoPtr_Board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "Board");
			SkateboardAudio.NativeFieldInfoPtr_JumpAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "JumpAudio");
			SkateboardAudio.NativeFieldInfoPtr_LandAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "LandAudio");
			SkateboardAudio.NativeFieldInfoPtr_RollingAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "RollingAudio");
			SkateboardAudio.NativeFieldInfoPtr_WindAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, "WindAudio");
			SkateboardAudio.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667354);
			SkateboardAudio.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667355);
			SkateboardAudio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667356);
			SkateboardAudio.NativeMethodInfoPtr_PlayJump_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667357);
			SkateboardAudio.NativeMethodInfoPtr_PlayLand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667358);
			SkateboardAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr, 100667359);
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x000E3C04 File Offset: 0x000E1E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116035, XrefRangeEnd = 116052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x000E3C38 File Offset: 0x000E1E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116052, XrefRangeEnd = 116054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x000E3C6C File Offset: 0x000E1E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116054, XrefRangeEnd = 116060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x000E3CA0 File Offset: 0x000E1EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116060, XrefRangeEnd = 116062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayJump(float force)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref force;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_PlayJump_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x000E3CE0 File Offset: 0x000E1EE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 116063, RefRangeEnd = 116067, XrefRangeStart = 116062, XrefRangeEnd = 116063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayLand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr_PlayLand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x000E3D14 File Offset: 0x000E1F14
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardAudio>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x000142EE File Offset: 0x000124EE
		public SkateboardAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x000E3D50 File Offset: 0x000E1F50
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x000142F7 File Offset: 0x000124F7
		public unsafe Skateboard Board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_Board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_Board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x000E3D80 File Offset: 0x000E1F80
		// (set) Token: 0x06002425 RID: 9253 RVA: 0x00014316 File Offset: 0x00012516
		public unsafe AudioSourceController JumpAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_JumpAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_JumpAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06002426 RID: 9254 RVA: 0x000E3DB0 File Offset: 0x000E1FB0
		// (set) Token: 0x06002427 RID: 9255 RVA: 0x00014335 File Offset: 0x00012535
		public unsafe AudioSourceController LandAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_LandAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_LandAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002428 RID: 9256 RVA: 0x000E3DE0 File Offset: 0x000E1FE0
		// (set) Token: 0x06002429 RID: 9257 RVA: 0x00014354 File Offset: 0x00012554
		public unsafe AudioSourceController RollingAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_RollingAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_RollingAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x0600242A RID: 9258 RVA: 0x000E3E10 File Offset: 0x000E2010
		// (set) Token: 0x0600242B RID: 9259 RVA: 0x00014373 File Offset: 0x00012573
		public unsafe AudioSourceController WindAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_WindAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardAudio.NativeFieldInfoPtr_WindAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeFieldInfoPtr_Board;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr_JumpAudio;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeFieldInfoPtr_LandAudio;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeFieldInfoPtr_RollingAudio;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeFieldInfoPtr_WindAudio;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_PlayJump_Public_Void_Single_0;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_PlayLand_Public_Void_0;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
