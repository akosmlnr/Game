using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005B2 RID: 1458
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06007F40 RID: 32576 RVA: 0x002240DC File Offset: 0x002222DC
		// Note: this type is marked as 'beforefieldinit'.
		static PourableAngleLimit()
		{
			Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "PourableAngleLimit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr);
			PourableAngleLimit.NativeFieldInfoPtr_Pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Pourable");
			PourableAngleLimit.NativeFieldInfoPtr_Constraint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "Constraint");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "AngleAtMinFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMaxFill");
			PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, "PourAngleMinFill");
			PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100679327);
			PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100679328);
			PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr, 100679329);
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x002241C0 File Offset: 0x002223C0
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x002241F4 File Offset: 0x002223F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241555, XrefRangeEnd = 241557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x00224228 File Offset: 0x00222428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241557, XrefRangeEnd = 241558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableAngleLimit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableAngleLimit>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableAngleLimit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x0003C2C2 File Offset: 0x0003A4C2
		public PourableAngleLimit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06007F45 RID: 32581 RVA: 0x00224264 File Offset: 0x00222464
		// (set) Token: 0x06007F46 RID: 32582 RVA: 0x0003C2CB File Offset: 0x0003A4CB
		public unsafe PourableModule Pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06007F47 RID: 32583 RVA: 0x00224294 File Offset: 0x00222494
		// (set) Token: 0x06007F48 RID: 32584 RVA: 0x0003C2EA File Offset: 0x0003A4EA
		public unsafe DraggableConstraint Constraint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DraggableConstraint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_Constraint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x06007F49 RID: 32585 RVA: 0x002242C4 File Offset: 0x002224C4
		// (set) Token: 0x06007F4A RID: 32586 RVA: 0x0003C309 File Offset: 0x0003A509
		public unsafe float AngleAtMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMaxFill)) = value;
			}
		}

		// Token: 0x1700264B RID: 9803
		// (get) Token: 0x06007F4B RID: 32587 RVA: 0x002242EC File Offset: 0x002224EC
		// (set) Token: 0x06007F4C RID: 32588 RVA: 0x0003C324 File Offset: 0x0003A524
		public unsafe float AngleAtMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_AngleAtMinFill)) = value;
			}
		}

		// Token: 0x1700264C RID: 9804
		// (get) Token: 0x06007F4D RID: 32589 RVA: 0x00224314 File Offset: 0x00222514
		// (set) Token: 0x06007F4E RID: 32590 RVA: 0x0003C33F File Offset: 0x0003A53F
		public unsafe float PourAngleMaxFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMaxFill)) = value;
			}
		}

		// Token: 0x1700264D RID: 9805
		// (get) Token: 0x06007F4F RID: 32591 RVA: 0x0022433C File Offset: 0x0022253C
		// (set) Token: 0x06007F50 RID: 32592 RVA: 0x0003C35A File Offset: 0x0003A55A
		public unsafe float PourAngleMinFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableAngleLimit.NativeFieldInfoPtr_PourAngleMinFill)) = value;
			}
		}

		// Token: 0x0400569D RID: 22173
		private static readonly IntPtr NativeFieldInfoPtr_Pourable;

		// Token: 0x0400569E RID: 22174
		private static readonly IntPtr NativeFieldInfoPtr_Constraint;

		// Token: 0x0400569F RID: 22175
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMaxFill;

		// Token: 0x040056A0 RID: 22176
		private static readonly IntPtr NativeFieldInfoPtr_AngleAtMinFill;

		// Token: 0x040056A1 RID: 22177
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMaxFill;

		// Token: 0x040056A2 RID: 22178
		private static readonly IntPtr NativeFieldInfoPtr_PourAngleMinFill;

		// Token: 0x040056A3 RID: 22179
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040056A4 RID: 22180
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x040056A5 RID: 22181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
