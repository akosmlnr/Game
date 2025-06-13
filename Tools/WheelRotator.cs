using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000577 RID: 1399
	public class WheelRotator : MonoBehaviour
	{
		// Token: 0x06007A2D RID: 31277 RVA: 0x00212CF0 File Offset: 0x00210EF0
		// Note: this type is marked as 'beforefieldinit'.
		static WheelRotator()
		{
			Il2CppClassPointerStore<WheelRotator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "WheelRotator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr);
			WheelRotator.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Radius");
			WheelRotator.NativeFieldInfoPtr_Wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Wheel");
			WheelRotator.NativeFieldInfoPtr_Flip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Flip");
			WheelRotator.NativeFieldInfoPtr_Controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "Controller");
			WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "AudioVolumeDivisor");
			WheelRotator.NativeFieldInfoPtr_RotationAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "RotationAxis");
			WheelRotator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, "lastFramePosition");
			WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678750);
			WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678751);
			WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr, 100678752);
		}

		// Token: 0x06007A2E RID: 31278 RVA: 0x00212DE8 File Offset: 0x00210FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236050, XrefRangeEnd = 236058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x00212E1C File Offset: 0x0021101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236058, XrefRangeEnd = 236072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A30 RID: 31280 RVA: 0x00212E50 File Offset: 0x00211050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236072, XrefRangeEnd = 236086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WheelRotator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WheelRotator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WheelRotator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A31 RID: 31281 RVA: 0x00039A81 File Offset: 0x00037C81
		public WheelRotator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06007A32 RID: 31282 RVA: 0x00212E8C File Offset: 0x0021108C
		// (set) Token: 0x06007A33 RID: 31283 RVA: 0x00039A8A File Offset: 0x00037C8A
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06007A34 RID: 31284 RVA: 0x00212EB4 File Offset: 0x002110B4
		// (set) Token: 0x06007A35 RID: 31285 RVA: 0x00039AA5 File Offset: 0x00037CA5
		public unsafe Transform Wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06007A36 RID: 31286 RVA: 0x00212EE4 File Offset: 0x002110E4
		// (set) Token: 0x06007A37 RID: 31287 RVA: 0x00039AC4 File Offset: 0x00037CC4
		public unsafe bool Flip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Flip)) = value;
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06007A38 RID: 31288 RVA: 0x00212F0C File Offset: 0x0021110C
		// (set) Token: 0x06007A39 RID: 31289 RVA: 0x00039ADF File Offset: 0x00037CDF
		public unsafe AudioSourceController Controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_Controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x06007A3A RID: 31290 RVA: 0x00212F3C File Offset: 0x0021113C
		// (set) Token: 0x06007A3B RID: 31291 RVA: 0x00039AFE File Offset: 0x00037CFE
		public unsafe float AudioVolumeDivisor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_AudioVolumeDivisor)) = value;
			}
		}

		// Token: 0x170024BD RID: 9405
		// (get) Token: 0x06007A3C RID: 31292 RVA: 0x00212F64 File Offset: 0x00211164
		// (set) Token: 0x06007A3D RID: 31293 RVA: 0x00039B19 File Offset: 0x00037D19
		public unsafe Vector3 RotationAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_RotationAxis)) = value;
			}
		}

		// Token: 0x170024BE RID: 9406
		// (get) Token: 0x06007A3E RID: 31294 RVA: 0x00212F8C File Offset: 0x0021118C
		// (set) Token: 0x06007A3F RID: 31295 RVA: 0x00039B34 File Offset: 0x00037D34
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WheelRotator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x0400534E RID: 21326
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x0400534F RID: 21327
		private static readonly IntPtr NativeFieldInfoPtr_Wheel;

		// Token: 0x04005350 RID: 21328
		private static readonly IntPtr NativeFieldInfoPtr_Flip;

		// Token: 0x04005351 RID: 21329
		private static readonly IntPtr NativeFieldInfoPtr_Controller;

		// Token: 0x04005352 RID: 21330
		private static readonly IntPtr NativeFieldInfoPtr_AudioVolumeDivisor;

		// Token: 0x04005353 RID: 21331
		private static readonly IntPtr NativeFieldInfoPtr_RotationAxis;

		// Token: 0x04005354 RID: 21332
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04005355 RID: 21333
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005356 RID: 21334
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005357 RID: 21335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
