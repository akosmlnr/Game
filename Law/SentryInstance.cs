using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003FC RID: 1020
	[System.Serializable]
	public class SentryInstance : Il2CppSystem.Object
	{
		// Token: 0x06004DE7 RID: 19943 RVA: 0x00177EE4 File Offset: 0x001760E4
		// Note: this type is marked as 'beforefieldinit'.
		static SentryInstance()
		{
			Il2CppClassPointerStore<SentryInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "SentryInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr);
			SentryInstance.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "Location");
			SentryInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "Members");
			SentryInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "StartTime");
			SentryInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "EndTime");
			SentryInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "IntensityRequirement");
			SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			SentryInstance.NativeFieldInfoPtr_officers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, "officers");
			SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672998);
			SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100672999);
			SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100673000);
			SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100673001);
			SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr, 100673002);
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00178004 File Offset: 0x00176204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170125, XrefRangeEnd = 170137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x00178038 File Offset: 0x00176238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 170174, RefRangeEnd = 170176, XrefRangeStart = 170137, XrefRangeEnd = 170174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_StartEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x0017806C File Offset: 0x0017626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170176, XrefRangeEnd = 170182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x001780A0 File Offset: 0x001762A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 170205, RefRangeEnd = 170206, XrefRangeStart = 170182, XrefRangeEnd = 170205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSentry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr_EndSentry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x001780D4 File Offset: 0x001762D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170206, XrefRangeEnd = 170214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SentryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SentryInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SentryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00025443 File Offset: 0x00023643
		public SentryInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06004DEE RID: 19950 RVA: 0x00178110 File Offset: 0x00176310
		// (set) Token: 0x06004DEF RID: 19951 RVA: 0x0002544C File Offset: 0x0002364C
		public unsafe SentryLocation Location
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Location);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SentryLocation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x00178140 File Offset: 0x00176340
		// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x0002546B File Offset: 0x0002366B
		public unsafe int Members
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x00178168 File Offset: 0x00176368
		// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x00025486 File Offset: 0x00023686
		public unsafe int StartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x00178190 File Offset: 0x00176390
		// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x000254A1 File Offset: 0x000236A1
		public unsafe int EndTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x001781B8 File Offset: 0x001763B8
		// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x000254BC File Offset: 0x000236BC
		public unsafe int IntensityRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x001781E0 File Offset: 0x001763E0
		// (set) Token: 0x06004DF9 RID: 19961 RVA: 0x000254D7 File Offset: 0x000236D7
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x00178208 File Offset: 0x00176408
		// (set) Token: 0x06004DFB RID: 19963 RVA: 0x000254F2 File Offset: 0x000236F2
		public unsafe List<PoliceOfficer> officers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_officers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SentryInstance.NativeFieldInfoPtr_officers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003475 RID: 13429
		private static readonly System.IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04003476 RID: 13430
		private static readonly System.IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x04003477 RID: 13431
		private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003478 RID: 13432
		private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003479 RID: 13433
		private static readonly System.IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x0400347A RID: 13434
		private static readonly System.IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x0400347B RID: 13435
		private static readonly System.IntPtr NativeFieldInfoPtr_officers;

		// Token: 0x0400347C RID: 13436
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x0400347D RID: 13437
		private static readonly System.IntPtr NativeMethodInfoPtr_StartEntry_Public_Void_0;

		// Token: 0x0400347E RID: 13438
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400347F RID: 13439
		private static readonly System.IntPtr NativeMethodInfoPtr_EndSentry_Public_Void_0;

		// Token: 0x04003480 RID: 13440
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
