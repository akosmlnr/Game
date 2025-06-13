using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Materials;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000401 RID: 1025
	public class LocalPlayerFootstepGenerator : MonoBehaviour
	{
		// Token: 0x06004E2F RID: 20015 RVA: 0x00178BBC File Offset: 0x00176DBC
		// Note: this type is marked as 'beforefieldinit'.
		static LocalPlayerFootstepGenerator()
		{
			Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "LocalPlayerFootstepGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr);
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "DistancePerStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "ReferencePoint");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "GroundDetectionMask");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "onStep");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "currentDistance");
			LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, "lastFramePosition");
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100673027);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_TriggerStep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100673028);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100673029);
			LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr, 100673030);
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00178CB4 File Offset: 0x00176EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170461, XrefRangeEnd = 170486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00178CE8 File Offset: 0x00176EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170486, XrefRangeEnd = 170495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TriggerStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_TriggerStep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00178D1C File Offset: 0x00176F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170507, RefRangeEnd = 170509, XrefRangeStart = 170495, XrefRangeEnd = 170507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsGrounded(out EMaterialType surfaceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &surfaceType;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00178D68 File Offset: 0x00176F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170509, XrefRangeEnd = 170519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalPlayerFootstepGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalPlayerFootstepGenerator>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalPlayerFootstepGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x000256B0 File Offset: 0x000238B0
		public LocalPlayerFootstepGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06004E35 RID: 20021 RVA: 0x00178DA4 File Offset: 0x00176FA4
		// (set) Token: 0x06004E36 RID: 20022 RVA: 0x000256B9 File Offset: 0x000238B9
		public unsafe float DistancePerStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_DistancePerStep)) = value;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06004E37 RID: 20023 RVA: 0x00178DCC File Offset: 0x00176FCC
		// (set) Token: 0x06004E38 RID: 20024 RVA: 0x000256D4 File Offset: 0x000238D4
		public unsafe Transform ReferencePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_ReferencePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x00178DFC File Offset: 0x00176FFC
		// (set) Token: 0x06004E3A RID: 20026 RVA: 0x000256F3 File Offset: 0x000238F3
		public unsafe LayerMask GroundDetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_GroundDetectionMask)) = value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004E3B RID: 20027 RVA: 0x00178E24 File Offset: 0x00177024
		// (set) Token: 0x06004E3C RID: 20028 RVA: 0x0002570E File Offset: 0x0002390E
		public unsafe UnityEvent<EMaterialType, float> onStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EMaterialType, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_onStep), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004E3D RID: 20029 RVA: 0x00178E54 File Offset: 0x00177054
		// (set) Token: 0x06004E3E RID: 20030 RVA: 0x0002572D File Offset: 0x0002392D
		public unsafe float currentDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_currentDistance)) = value;
			}
		}

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06004E3F RID: 20031 RVA: 0x00178E7C File Offset: 0x0017707C
		// (set) Token: 0x06004E40 RID: 20032 RVA: 0x00025748 File Offset: 0x00023948
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalPlayerFootstepGenerator.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeFieldInfoPtr_DistancePerStep;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeFieldInfoPtr_ReferencePoint;

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeFieldInfoPtr_GroundDetectionMask;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeFieldInfoPtr_onStep;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeFieldInfoPtr_currentDistance;

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeMethodInfoPtr_TriggerStep_Public_Void_0;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeMethodInfoPtr_IsGrounded_Public_Boolean_byref_EMaterialType_0;

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
