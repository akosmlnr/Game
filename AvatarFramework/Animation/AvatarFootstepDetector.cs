using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200062F RID: 1583
	public class AvatarFootstepDetector : MonoBehaviour
	{
		// Token: 0x06008AFC RID: 35580 RVA: 0x0024B3C8 File Offset: 0x002495C8
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarFootstepDetector()
		{
			Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarFootstepDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr);
			AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "MAX_DETECTION_RANGE");
			AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "GROUND_DETECTION_RANGE");
			AvatarFootstepDetector.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "Avatar");
			AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "ReferencePoint");
			AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "LeftBone");
			AvatarFootstepDetector.NativeFieldInfoPtr_RightBone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "RightBone");
			AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "StepThreshold");
			AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "GroundDetectionMask");
			AvatarFootstepDetector.NativeFieldInfoPtr_leftDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "leftDown");
			AvatarFootstepDetector.NativeFieldInfoPtr_rightDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "rightDown");
			AvatarFootstepDetector.NativeFieldInfoPtr_onStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, "onStep");
			AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680727);
			AvatarFootstepDetector.NativeMethodInfoPtr_TriggerStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680728);
			AvatarFootstepDetector.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680729);
			AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr, 100680730);
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x0024B524 File Offset: 0x00249724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256829, XrefRangeEnd = 256852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x0024B558 File Offset: 0x00249758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256856, RefRangeEnd = 256857, XrefRangeStart = 256852, XrefRangeEnd = 256856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_TriggerStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x0024B58C File Offset: 0x0024978C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256869, RefRangeEnd = 256870, XrefRangeStart = 256857, XrefRangeEnd = 256869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x0024B5D8 File Offset: 0x002497D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256870, XrefRangeEnd = 256878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarFootstepDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarFootstepDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarFootstepDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x00042080 File Offset: 0x00040280
		public AvatarFootstepDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x06008B02 RID: 35586 RVA: 0x0024B614 File Offset: 0x00249814
		// (set) Token: 0x06008B03 RID: 35587 RVA: 0x00042089 File Offset: 0x00040289
		public unsafe static float MAX_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_MAX_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x06008B04 RID: 35588 RVA: 0x0024B630 File Offset: 0x00249830
		// (set) Token: 0x06008B05 RID: 35589 RVA: 0x00042097 File Offset: 0x00040297
		public unsafe static float GROUND_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AvatarFootstepDetector.NativeFieldInfoPtr_GROUND_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06008B06 RID: 35590 RVA: 0x0024B64C File Offset: 0x0024984C
		// (set) Token: 0x06008B07 RID: 35591 RVA: 0x000420A5 File Offset: 0x000402A5
		public unsafe Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06008B08 RID: 35592 RVA: 0x0024B67C File Offset: 0x0024987C
		// (set) Token: 0x06008B09 RID: 35593 RVA: 0x000420C4 File Offset: 0x000402C4
		public unsafe Transform ReferencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_ReferencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06008B0A RID: 35594 RVA: 0x0024B6AC File Offset: 0x002498AC
		// (set) Token: 0x06008B0B RID: 35595 RVA: 0x000420E3 File Offset: 0x000402E3
		public unsafe Transform LeftBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_LeftBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06008B0C RID: 35596 RVA: 0x0024B6DC File Offset: 0x002498DC
		// (set) Token: 0x06008B0D RID: 35597 RVA: 0x00042102 File Offset: 0x00040302
		public unsafe Transform RightBone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_RightBone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_RightBone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06008B0E RID: 35598 RVA: 0x0024B70C File Offset: 0x0024990C
		// (set) Token: 0x06008B0F RID: 35599 RVA: 0x00042121 File Offset: 0x00040321
		public unsafe float StepThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_StepThreshold)) = value;
			}
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x06008B10 RID: 35600 RVA: 0x0024B734 File Offset: 0x00249934
		// (set) Token: 0x06008B11 RID: 35601 RVA: 0x0004213C File Offset: 0x0004033C
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x06008B12 RID: 35602 RVA: 0x0024B75C File Offset: 0x0024995C
		// (set) Token: 0x06008B13 RID: 35603 RVA: 0x00042157 File Offset: 0x00040357
		public unsafe bool leftDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_leftDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_leftDown)) = value;
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x06008B14 RID: 35604 RVA: 0x0024B784 File Offset: 0x00249984
		// (set) Token: 0x06008B15 RID: 35605 RVA: 0x00042172 File Offset: 0x00040372
		public unsafe bool rightDown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_rightDown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_rightDown)) = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x06008B16 RID: 35606 RVA: 0x0024B7AC File Offset: 0x002499AC
		// (set) Token: 0x06008B17 RID: 35607 RVA: 0x0004218D File Offset: 0x0004038D
		public unsafe UnityEvent<EMaterialType, float> onStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_onStep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EMaterialType, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarFootstepDetector.NativeFieldInfoPtr_onStep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E78 RID: 24184
		private static readonly IntPtr NativeFieldInfoPtr_MAX_DETECTION_RANGE;

		// Token: 0x04005E79 RID: 24185
		private static readonly IntPtr NativeFieldInfoPtr_GROUND_DETECTION_RANGE;

		// Token: 0x04005E7A RID: 24186
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x04005E7B RID: 24187
		private static readonly IntPtr NativeFieldInfoPtr_ReferencePoint;

		// Token: 0x04005E7C RID: 24188
		private static readonly IntPtr NativeFieldInfoPtr_LeftBone;

		// Token: 0x04005E7D RID: 24189
		private static readonly IntPtr NativeFieldInfoPtr_RightBone;

		// Token: 0x04005E7E RID: 24190
		private static readonly IntPtr NativeFieldInfoPtr_StepThreshold;

		// Token: 0x04005E7F RID: 24191
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x04005E80 RID: 24192
		private static readonly IntPtr NativeFieldInfoPtr_leftDown;

		// Token: 0x04005E81 RID: 24193
		private static readonly IntPtr NativeFieldInfoPtr_rightDown;

		// Token: 0x04005E82 RID: 24194
		private static readonly IntPtr NativeFieldInfoPtr_onStep;

		// Token: 0x04005E83 RID: 24195
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04005E84 RID: 24196
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Public_Void_0;

		// Token: 0x04005E85 RID: 24197
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0;

		// Token: 0x04005E86 RID: 24198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
