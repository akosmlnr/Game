using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x02000210 RID: 528
	public class RotateRigidbodyToTarget : MonoBehaviour
	{
		// Token: 0x06002B4A RID: 11082 RVA: 0x000FC790 File Offset: 0x000FA990
		// Note: this type is marked as 'beforefieldinit'.
		static RotateRigidbodyToTarget()
		{
			Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "RotateRigidbodyToTarget");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr);
			RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "Rigidbody");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "TargetRotation");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "RotationForce");
			RotateRigidbodyToTarget.NativeFieldInfoPtr_Bitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, "Bitch");
			RotateRigidbodyToTarget.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, 100668199);
			RotateRigidbodyToTarget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr, 100668200);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000FC838 File Offset: 0x000FAA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124248, XrefRangeEnd = 124261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateRigidbodyToTarget.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000FC86C File Offset: 0x000FAA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124261, XrefRangeEnd = 124262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RotateRigidbodyToTarget() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RotateRigidbodyToTarget>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RotateRigidbodyToTarget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000175AE File Offset: 0x000157AE
		public RotateRigidbodyToTarget(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000FC8A8 File Offset: 0x000FAAA8
		// (set) Token: 0x06002B4F RID: 11087 RVA: 0x000175B7 File Offset: 0x000157B7
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000FC8D8 File Offset: 0x000FAAD8
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x000175D6 File Offset: 0x000157D6
		public unsafe Vector3 TargetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_TargetRotation)) = value;
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000FC900 File Offset: 0x000FAB00
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x000175F1 File Offset: 0x000157F1
		public unsafe float RotationForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_RotationForce)) = value;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000FC928 File Offset: 0x000FAB28
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x0001760C File Offset: 0x0001580C
		public unsafe Transform Bitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Bitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RotateRigidbodyToTarget.NativeFieldInfoPtr_Bitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeFieldInfoPtr_TargetRotation;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeFieldInfoPtr_RotationForce;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeFieldInfoPtr_Bitch;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
