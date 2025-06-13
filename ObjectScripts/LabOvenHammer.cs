using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000775 RID: 1909
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x0600B2C3 RID: 45763 RVA: 0x002CBC84 File Offset: 0x002C9E84
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenHammer()
		{
			Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabOvenHammer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr);
			LabOvenHammer.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Draggable");
			LabOvenHammer.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Constraint");
			LabOvenHammer.NativeFieldInfoPtr_Rotator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "Rotator");
			LabOvenHammer.NativeFieldInfoPtr_CoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "CoM");
			LabOvenHammer.NativeFieldInfoPtr_ImpactPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "ImpactPoint");
			LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "VelocityCalculator");
			LabOvenHammer.NativeFieldInfoPtr_MinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinHeight");
			LabOvenHammer.NativeFieldInfoPtr_MaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxHeight");
			LabOvenHammer.NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MinAngle");
			LabOvenHammer.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "MaxAngle");
			LabOvenHammer.NativeFieldInfoPtr_onCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, "onCollision");
			LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100685415);
			LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100685416);
			LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100685417);
			LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr, 100685418);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x002CBDE0 File Offset: 0x002C9FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308421, XrefRangeEnd = 308423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x002CBE14 File Offset: 0x002CA014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308423, XrefRangeEnd = 308429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x002CBE48 File Offset: 0x002CA048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308429, XrefRangeEnd = 308432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x002CBE8C File Offset: 0x002CA08C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308432, XrefRangeEnd = 308433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenHammer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenHammer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenHammer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x00057853 File Offset: 0x00055A53
		public LabOvenHammer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600B2C9 RID: 45769 RVA: 0x002CBEC8 File Offset: 0x002CA0C8
		// (set) Token: 0x0600B2CA RID: 45770 RVA: 0x0005785C File Offset: 0x00055A5C
		public unsafe Draggable Draggable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600B2CB RID: 45771 RVA: 0x002CBEF8 File Offset: 0x002CA0F8
		// (set) Token: 0x0600B2CC RID: 45772 RVA: 0x0005787B File Offset: 0x00055A7B
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600B2CD RID: 45773 RVA: 0x002CBF28 File Offset: 0x002CA128
		// (set) Token: 0x0600B2CE RID: 45774 RVA: 0x0005789A File Offset: 0x00055A9A
		public unsafe RotateRigidbodyToTarget Rotator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RotateRigidbodyToTarget>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_Rotator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600B2CF RID: 45775 RVA: 0x002CBF58 File Offset: 0x002CA158
		// (set) Token: 0x0600B2D0 RID: 45776 RVA: 0x000578B9 File Offset: 0x00055AB9
		public unsafe Transform CoM
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_CoM), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600B2D1 RID: 45777 RVA: 0x002CBF88 File Offset: 0x002CA188
		// (set) Token: 0x0600B2D2 RID: 45778 RVA: 0x000578D8 File Offset: 0x00055AD8
		public unsafe Transform ImpactPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_ImpactPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600B2D3 RID: 45779 RVA: 0x002CBFB8 File Offset: 0x002CA1B8
		// (set) Token: 0x0600B2D4 RID: 45780 RVA: 0x000578F7 File Offset: 0x00055AF7
		public unsafe SmoothedVelocityCalculator VelocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_VelocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600B2D5 RID: 45781 RVA: 0x002CBFE8 File Offset: 0x002CA1E8
		// (set) Token: 0x0600B2D6 RID: 45782 RVA: 0x00057916 File Offset: 0x00055B16
		public unsafe float MinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinHeight)) = value;
			}
		}

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600B2D7 RID: 45783 RVA: 0x002CC010 File Offset: 0x002CA210
		// (set) Token: 0x0600B2D8 RID: 45784 RVA: 0x00057931 File Offset: 0x00055B31
		public unsafe float MaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxHeight)) = value;
			}
		}

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600B2D9 RID: 45785 RVA: 0x002CC038 File Offset: 0x002CA238
		// (set) Token: 0x0600B2DA RID: 45786 RVA: 0x0005794C File Offset: 0x00055B4C
		public unsafe float MinAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MinAngle)) = value;
			}
		}

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600B2DB RID: 45787 RVA: 0x002CC060 File Offset: 0x002CA260
		// (set) Token: 0x0600B2DC RID: 45788 RVA: 0x00057967 File Offset: 0x00055B67
		public unsafe float MaxAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_MaxAngle)) = value;
			}
		}

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600B2DD RID: 45789 RVA: 0x002CC088 File Offset: 0x002CA288
		// (set) Token: 0x0600B2DE RID: 45790 RVA: 0x00057982 File Offset: 0x00055B82
		public unsafe UnityEvent<Collision> onCollision
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenHammer.NativeFieldInfoPtr_onCollision), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400786F RID: 30831
		private static readonly IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x04007870 RID: 30832
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x04007871 RID: 30833
		private static readonly IntPtr NativeFieldInfoPtr_Rotator;

		// Token: 0x04007872 RID: 30834
		private static readonly IntPtr NativeFieldInfoPtr_CoM;

		// Token: 0x04007873 RID: 30835
		private static readonly IntPtr NativeFieldInfoPtr_ImpactPoint;

		// Token: 0x04007874 RID: 30836
		private static readonly IntPtr NativeFieldInfoPtr_VelocityCalculator;

		// Token: 0x04007875 RID: 30837
		private static readonly IntPtr NativeFieldInfoPtr_MinHeight;

		// Token: 0x04007876 RID: 30838
		private static readonly IntPtr NativeFieldInfoPtr_MaxHeight;

		// Token: 0x04007877 RID: 30839
		private static readonly IntPtr NativeFieldInfoPtr_MinAngle;

		// Token: 0x04007878 RID: 30840
		private static readonly IntPtr NativeFieldInfoPtr_MaxAngle;

		// Token: 0x04007879 RID: 30841
		private static readonly IntPtr NativeFieldInfoPtr_onCollision;

		// Token: 0x0400787A RID: 30842
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400787B RID: 30843
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400787C RID: 30844
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x0400787D RID: 30845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
