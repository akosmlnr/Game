using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004EA RID: 1258
	public class AmbientLoopJukebox : MonoBehaviour
	{
		// Token: 0x06006D07 RID: 27911 RVA: 0x001E804C File Offset: 0x001E624C
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientLoopJukebox()
		{
			Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AmbientLoopJukebox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr);
			AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "VolumeCurve");
			AmbientLoopJukebox.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "Clips");
			AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "audioSourceController");
			AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "currentClipIndex");
			AmbientLoopJukebox.NativeFieldInfoPtr_musicScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, "musicScale");
			AmbientLoopJukebox.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100677202);
			AmbientLoopJukebox.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100677203);
			AmbientLoopJukebox.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100677204);
			AmbientLoopJukebox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr, 100677205);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x001E8130 File Offset: 0x001E6330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219766, XrefRangeEnd = 219794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x001E8164 File Offset: 0x001E6364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219794, XrefRangeEnd = 219799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x001E8198 File Offset: 0x001E6398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219799, XrefRangeEnd = 219810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D0B RID: 27915 RVA: 0x001E81CC File Offset: 0x001E63CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219810, XrefRangeEnd = 219818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientLoopJukebox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientLoopJukebox>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientLoopJukebox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x0003351A File Offset: 0x0003171A
		public AmbientLoopJukebox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002084 RID: 8324
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x001E8208 File Offset: 0x001E6408
		// (set) Token: 0x06006D0E RID: 27918 RVA: 0x00033523 File Offset: 0x00031723
		public unsafe AnimationCurve VolumeCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_VolumeCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x001E8238 File Offset: 0x001E6438
		// (set) Token: 0x06006D10 RID: 27920 RVA: 0x00033542 File Offset: 0x00031742
		public unsafe List<AudioClip> Clips
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_Clips);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioClip>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x001E8268 File Offset: 0x001E6468
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x00033561 File Offset: 0x00031761
		public unsafe AudioSourceController audioSourceController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_audioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x001E8298 File Offset: 0x001E6498
		// (set) Token: 0x06006D14 RID: 27924 RVA: 0x00033580 File Offset: 0x00031780
		public unsafe int currentClipIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_currentClipIndex)) = value;
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x001E82C0 File Offset: 0x001E64C0
		// (set) Token: 0x06006D16 RID: 27926 RVA: 0x0003359B File Offset: 0x0003179B
		public unsafe float musicScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_musicScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientLoopJukebox.NativeFieldInfoPtr_musicScale)) = value;
			}
		}

		// Token: 0x04004A9B RID: 19099
		private static readonly IntPtr NativeFieldInfoPtr_VolumeCurve;

		// Token: 0x04004A9C RID: 19100
		private static readonly IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x04004A9D RID: 19101
		private static readonly IntPtr NativeFieldInfoPtr_audioSourceController;

		// Token: 0x04004A9E RID: 19102
		private static readonly IntPtr NativeFieldInfoPtr_currentClipIndex;

		// Token: 0x04004A9F RID: 19103
		private static readonly IntPtr NativeFieldInfoPtr_musicScale;

		// Token: 0x04004AA0 RID: 19104
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004AA1 RID: 19105
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004AA2 RID: 19106
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04004AA3 RID: 19107
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
