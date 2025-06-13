using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004FA RID: 1274
	public class RandomizedAudioSourceController : AudioSourceController
	{
		// Token: 0x06006E72 RID: 28274 RVA: 0x001EC1B8 File Offset: 0x001EA3B8
		// Note: this type is marked as 'beforefieldinit'.
		static RandomizedAudioSourceController()
		{
			Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "RandomizedAudioSourceController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr);
			RandomizedAudioSourceController.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, "Clips");
			RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100677345);
			RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100677346);
			RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr, 100677347);
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x001EC238 File Offset: 0x001EA438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221224, XrefRangeEnd = 221237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_Play_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x001EC274 File Offset: 0x001EA474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221237, XrefRangeEnd = 221248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayOneShot(bool duplicateAudioSource = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duplicateAudioSource;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RandomizedAudioSourceController.NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x001EC2C0 File Offset: 0x001EA4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomizedAudioSourceController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedAudioSourceController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomizedAudioSourceController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x000340D9 File Offset: 0x000322D9
		public RandomizedAudioSourceController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x06006E77 RID: 28279 RVA: 0x001EC2FC File Offset: 0x001EA4FC
		// (set) Token: 0x06006E78 RID: 28280 RVA: 0x000340E2 File Offset: 0x000322E2
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RandomizedAudioSourceController.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B84 RID: 19332
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x04004B85 RID: 19333
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_Void_0;

		// Token: 0x04004B86 RID: 19334
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Virtual_Void_Boolean_0;

		// Token: 0x04004B87 RID: 19335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
