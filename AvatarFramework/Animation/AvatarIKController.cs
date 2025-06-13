using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppRootMotion.FinalIK;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework.Animation
{
	// Token: 0x02000630 RID: 1584
	public class AvatarIKController : MonoBehaviour
	{
		// Token: 0x06008B18 RID: 35608 RVA: 0x0024B7DC File Offset: 0x002499DC
		// Note: this type is marked as 'beforefieldinit'.
		static AvatarIKController()
		{
			Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Animation", "AvatarIKController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr);
			AvatarIKController.NativeFieldInfoPtr_BodyIK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "BodyIK");
			AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultLeftLegBendTarget");
			AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, "defaultRightLegBendTarget");
			AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680731);
			AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680732);
			AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680733);
			AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680734);
			AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680735);
			AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr, 100680736);
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x0024B8C0 File Offset: 0x00249AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256878, XrefRangeEnd = 256882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x0024B8F4 File Offset: 0x00249AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256882, XrefRangeEnd = 256884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x0024B928 File Offset: 0x00249B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 256886, RefRangeEnd = 256888, XrefRangeStart = 256884, XrefRangeEnd = 256886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIKActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x0024B968 File Offset: 0x00249B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256891, RefRangeEnd = 256892, XrefRangeStart = 256888, XrefRangeEnd = 256891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideLegBendTargets(Transform leftLegTarget, Transform rightLegTarget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftLegTarget);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rightLegTarget);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x0024B9BC File Offset: 0x00249BBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256895, RefRangeEnd = 256896, XrefRangeStart = 256892, XrefRangeEnd = 256895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetLegBendTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x0024B9F0 File Offset: 0x00249BF0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarIKController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AvatarIKController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AvatarIKController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x000421AC File Offset: 0x000403AC
		public AvatarIKController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06008B20 RID: 35616 RVA: 0x0024BA2C File Offset: 0x00249C2C
		// (set) Token: 0x06008B21 RID: 35617 RVA: 0x000421B5 File Offset: 0x000403B5
		public unsafe BipedIK BodyIK
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BipedIK>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_BodyIK), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x0024BA5C File Offset: 0x00249C5C
		// (set) Token: 0x06008B23 RID: 35619 RVA: 0x000421D4 File Offset: 0x000403D4
		public unsafe Transform defaultLeftLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultLeftLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06008B24 RID: 35620 RVA: 0x0024BA8C File Offset: 0x00249C8C
		// (set) Token: 0x06008B25 RID: 35621 RVA: 0x000421F3 File Offset: 0x000403F3
		public unsafe Transform defaultRightLegBendTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AvatarIKController.NativeFieldInfoPtr_defaultRightLegBendTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E87 RID: 24199
		private static readonly IntPtr NativeFieldInfoPtr_BodyIK;

		// Token: 0x04005E88 RID: 24200
		private static readonly IntPtr NativeFieldInfoPtr_defaultLeftLegBendTarget;

		// Token: 0x04005E89 RID: 24201
		private static readonly IntPtr NativeFieldInfoPtr_defaultRightLegBendTarget;

		// Token: 0x04005E8A RID: 24202
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005E8B RID: 24203
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005E8C RID: 24204
		private static readonly IntPtr NativeMethodInfoPtr_SetIKActive_Public_Void_Boolean_0;

		// Token: 0x04005E8D RID: 24205
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLegBendTargets_Public_Void_Transform_Transform_0;

		// Token: 0x04005E8E RID: 24206
		private static readonly IntPtr NativeMethodInfoPtr_ResetLegBendTargets_Public_Void_0;

		// Token: 0x04005E8F RID: 24207
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
