using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F5 RID: 1269
	public class HeartbeatSoundController : MonoBehaviour
	{
		// Token: 0x06006E19 RID: 28185 RVA: 0x001EB164 File Offset: 0x001E9364
		// Note: this type is marked as 'beforefieldinit'.
		static HeartbeatSoundController()
		{
			Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "HeartbeatSoundController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr);
			HeartbeatSoundController.NativeFieldInfoPtr_sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "sound");
			HeartbeatSoundController.NativeFieldInfoPtr_VolumeController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "VolumeController");
			HeartbeatSoundController.NativeFieldInfoPtr_PitchController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, "PitchController");
			HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100677309);
			HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100677310);
			HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr, 100677311);
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x001EB20C File Offset: 0x001E940C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220902, XrefRangeEnd = 220907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x001EB240 File Offset: 0x001E9440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220907, XrefRangeEnd = 220910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x001EB274 File Offset: 0x001E9474
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeartbeatSoundController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartbeatSoundController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeartbeatSoundController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x00033E1F File Offset: 0x0003201F
		public HeartbeatSoundController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x06006E1E RID: 28190 RVA: 0x001EB2B0 File Offset: 0x001E94B0
		// (set) Token: 0x06006E1F RID: 28191 RVA: 0x00033E28 File Offset: 0x00032028
		public unsafe AudioSourceController sound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_sound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_sound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x06006E20 RID: 28192 RVA: 0x001EB2E0 File Offset: 0x001E94E0
		// (set) Token: 0x06006E21 RID: 28193 RVA: 0x00033E47 File Offset: 0x00032047
		public unsafe FloatSmoother VolumeController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_VolumeController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_VolumeController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x06006E22 RID: 28194 RVA: 0x001EB310 File Offset: 0x001E9510
		// (set) Token: 0x06006E23 RID: 28195 RVA: 0x00033E66 File Offset: 0x00032066
		public unsafe FloatSmoother PitchController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_PitchController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatSmoother>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeartbeatSoundController.NativeFieldInfoPtr_PitchController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B4D RID: 19277
		private static readonly IntPtr NativeFieldInfoPtr_sound;

		// Token: 0x04004B4E RID: 19278
		private static readonly IntPtr NativeFieldInfoPtr_VolumeController;

		// Token: 0x04004B4F RID: 19279
		private static readonly IntPtr NativeFieldInfoPtr_PitchController;

		// Token: 0x04004B50 RID: 19280
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004B51 RID: 19281
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004B52 RID: 19282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
