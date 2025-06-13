using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Police;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003FE RID: 1022
	[System.Serializable]
	public class VehiclePatrolInstance : Il2CppSystem.Object
	{
		// Token: 0x06004E03 RID: 19971 RVA: 0x00178340 File Offset: 0x00176540
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolInstance()
		{
			Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "VehiclePatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr);
			VehiclePatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "Route");
			VehiclePatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "StartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "IntensityRequirement");
			VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "activeOfficer");
			VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "latestStartTime");
			VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, "startedThisCycle");
			VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100673004);
			VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100673005);
			VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100673006);
			VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100673007);
			VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr, 100673008);
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x00178460 File Offset: 0x00176660
		public unsafe PoliceStation nearestStation
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 170235, RefRangeEnd = 170238, XrefRangeStart = 170229, XrefRangeEnd = 170235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr2) : null;
			}
		}

		// Token: 0x06004E05 RID: 19973 RVA: 0x001784A0 File Offset: 0x001766A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170268, RefRangeEnd = 170269, XrefRangeStart = 170238, XrefRangeEnd = 170268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x001784D4 File Offset: 0x001766D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170269, XrefRangeEnd = 170274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_CheckEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x00178508 File Offset: 0x00176708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170274, XrefRangeEnd = 170291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x0017853C File Offset: 0x0017673C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170291, XrefRangeEnd = 170292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00025558 File Offset: 0x00023758
		public VehiclePatrolInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004E0A RID: 19978 RVA: 0x00178578 File Offset: 0x00176778
		// (set) Token: 0x06004E0B RID: 19979 RVA: 0x00025561 File Offset: 0x00023761
		public unsafe VehiclePatrolRoute Route
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolRoute>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x001785A8 File Offset: 0x001767A8
		// (set) Token: 0x06004E0D RID: 19981 RVA: 0x00025580 File Offset: 0x00023780
		public unsafe int StartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x001785D0 File Offset: 0x001767D0
		// (set) Token: 0x06004E0F RID: 19983 RVA: 0x0002559B File Offset: 0x0002379B
		public unsafe int IntensityRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x06004E10 RID: 19984 RVA: 0x001785F8 File Offset: 0x001767F8
		// (set) Token: 0x06004E11 RID: 19985 RVA: 0x000255B6 File Offset: 0x000237B6
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x00178620 File Offset: 0x00176820
		// (set) Token: 0x06004E13 RID: 19987 RVA: 0x000255D1 File Offset: 0x000237D1
		public unsafe PoliceOfficer activeOfficer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_activeOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x00178650 File Offset: 0x00176850
		// (set) Token: 0x06004E15 RID: 19989 RVA: 0x000255F0 File Offset: 0x000237F0
		public unsafe int latestStartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_latestStartTime)) = value;
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x00178678 File Offset: 0x00176878
		// (set) Token: 0x06004E17 RID: 19991 RVA: 0x0002560B File Offset: 0x0002380B
		public unsafe bool startedThisCycle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolInstance.NativeFieldInfoPtr_startedThisCycle)) = value;
			}
		}

		// Token: 0x04003484 RID: 13444
		private static readonly System.IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04003485 RID: 13445
		private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003486 RID: 13446
		private static readonly System.IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x04003487 RID: 13447
		private static readonly System.IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x04003488 RID: 13448
		private static readonly System.IntPtr NativeFieldInfoPtr_activeOfficer;

		// Token: 0x04003489 RID: 13449
		private static readonly System.IntPtr NativeFieldInfoPtr_latestStartTime;

		// Token: 0x0400348A RID: 13450
		private static readonly System.IntPtr NativeFieldInfoPtr_startedThisCycle;

		// Token: 0x0400348B RID: 13451
		private static readonly System.IntPtr NativeMethodInfoPtr_get_nearestStation_Private_get_PoliceStation_0;

		// Token: 0x0400348C RID: 13452
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400348D RID: 13453
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckEnd_Private_Void_0;

		// Token: 0x0400348E RID: 13454
		private static readonly System.IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x0400348F RID: 13455
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
