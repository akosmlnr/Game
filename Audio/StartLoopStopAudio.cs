using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004FD RID: 1277
	public class StartLoopStopAudio : MonoBehaviour
	{
		// Token: 0x06006E92 RID: 28306 RVA: 0x001EC7EC File Offset: 0x001EA9EC
		// Note: this type is marked as 'beforefieldinit'.
		static StartLoopStopAudio()
		{
			Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "StartLoopStopAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr);
			StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "<Runnning>k__BackingField");
			StartLoopStopAudio.NativeFieldInfoPtr_StartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "StartSound");
			StartLoopStopAudio.NativeFieldInfoPtr_LoopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "LoopSound");
			StartLoopStopAudio.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "StopSound");
			StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "FadeLoopIn");
			StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "FadeLoopOut");
			StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "timeSinceStart");
			StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, "timeSinceStop");
			StartLoopStopAudio.NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677366);
			StartLoopStopAudio.NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677367);
			StartLoopStopAudio.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677368);
			StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677369);
			StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677370);
			StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr, 100677371);
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06006E93 RID: 28307 RVA: 0x001EC934 File Offset: 0x001EAB34
		// (set) Token: 0x06006E94 RID: 28308 RVA: 0x001EC970 File Offset: 0x001EAB70
		public unsafe bool Runnning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006E95 RID: 28309 RVA: 0x001EC9B0 File Offset: 0x001EABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221400, XrefRangeEnd = 221407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E96 RID: 28310 RVA: 0x001EC9E4 File Offset: 0x001EABE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221408, RefRangeEnd = 221410, XrefRangeStart = 221407, XrefRangeEnd = 221408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StartAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E97 RID: 28311 RVA: 0x001ECA18 File Offset: 0x001EAC18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221411, RefRangeEnd = 221413, XrefRangeStart = 221410, XrefRangeEnd = 221411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr_StopAudio_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E98 RID: 28312 RVA: 0x001ECA4C File Offset: 0x001EAC4C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartLoopStopAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartLoopStopAudio>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartLoopStopAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E99 RID: 28313 RVA: 0x000341AB File Offset: 0x000323AB
		public StartLoopStopAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x001ECA88 File Offset: 0x001EAC88
		// (set) Token: 0x06006E9B RID: 28315 RVA: 0x000341B4 File Offset: 0x000323B4
		public unsafe bool _Runnning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr__Runnning_k__BackingField)) = value;
			}
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06006E9C RID: 28316 RVA: 0x001ECAB0 File Offset: 0x001EACB0
		// (set) Token: 0x06006E9D RID: 28317 RVA: 0x000341CF File Offset: 0x000323CF
		public unsafe AudioSourceController StartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06006E9E RID: 28318 RVA: 0x001ECAE0 File Offset: 0x001EACE0
		// (set) Token: 0x06006E9F RID: 28319 RVA: 0x000341EE File Offset: 0x000323EE
		public unsafe AudioSourceController LoopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_LoopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_LoopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06006EA0 RID: 28320 RVA: 0x001ECB10 File Offset: 0x001EAD10
		// (set) Token: 0x06006EA1 RID: 28321 RVA: 0x0003420D File Offset: 0x0003240D
		public unsafe AudioSourceController StopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x001ECB40 File Offset: 0x001EAD40
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x0003422C File Offset: 0x0003242C
		public unsafe bool FadeLoopIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopIn)) = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x001ECB68 File Offset: 0x001EAD68
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x00034247 File Offset: 0x00032447
		public unsafe bool FadeLoopOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_FadeLoopOut)) = value;
			}
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x001ECB90 File Offset: 0x001EAD90
		// (set) Token: 0x06006EA7 RID: 28327 RVA: 0x00034262 File Offset: 0x00032462
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x001ECBB8 File Offset: 0x001EADB8
		// (set) Token: 0x06006EA9 RID: 28329 RVA: 0x0003427D File Offset: 0x0003247D
		public unsafe float timeSinceStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartLoopStopAudio.NativeFieldInfoPtr_timeSinceStop)) = value;
			}
		}

		// Token: 0x04004B97 RID: 19351
		private static readonly IntPtr NativeFieldInfoPtr__Runnning_k__BackingField;

		// Token: 0x04004B98 RID: 19352
		private static readonly IntPtr NativeFieldInfoPtr_StartSound;

		// Token: 0x04004B99 RID: 19353
		private static readonly IntPtr NativeFieldInfoPtr_LoopSound;

		// Token: 0x04004B9A RID: 19354
		private static readonly IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x04004B9B RID: 19355
		private static readonly IntPtr NativeFieldInfoPtr_FadeLoopIn;

		// Token: 0x04004B9C RID: 19356
		private static readonly IntPtr NativeFieldInfoPtr_FadeLoopOut;

		// Token: 0x04004B9D RID: 19357
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x04004B9E RID: 19358
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStop;

		// Token: 0x04004B9F RID: 19359
		private static readonly IntPtr NativeMethodInfoPtr_get_Runnning_Public_get_Boolean_0;

		// Token: 0x04004BA0 RID: 19360
		private static readonly IntPtr NativeMethodInfoPtr_set_Runnning_Private_set_Void_Boolean_0;

		// Token: 0x04004BA1 RID: 19361
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004BA2 RID: 19362
		private static readonly IntPtr NativeMethodInfoPtr_StartAudio_Public_Void_0;

		// Token: 0x04004BA3 RID: 19363
		private static readonly IntPtr NativeMethodInfoPtr_StopAudio_Public_Void_0;

		// Token: 0x04004BA4 RID: 19364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
