using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppSystem;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003FA RID: 1018
	[System.Serializable]
	public class PatrolInstance : Il2CppSystem.Object
	{
		// Token: 0x06004DB1 RID: 19889 RVA: 0x001777BC File Offset: 0x001759BC
		// Note: this type is marked as 'beforefieldinit'.
		static PatrolInstance()
		{
			Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "PatrolInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr);
			PatrolInstance.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Route");
			PatrolInstance.NativeFieldInfoPtr_Members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "Members");
			PatrolInstance.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "StartTime");
			PatrolInstance.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "EndTime");
			PatrolInstance.NativeFieldInfoPtr_IntensityRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "IntensityRequirement");
			PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "OnlyIfCurfewEnabled");
			PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, "<ActiveGroup>k__BackingField");
			PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672990);
			PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672991);
			PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672992);
			PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672993);
			PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672994);
			PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672995);
			PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr, 100672996);
		}

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x00177904 File Offset: 0x00175B04
		// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x00177944 File Offset: 0x00175B44
		public unsafe PatrolGroup ActiveGroup
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00177988 File Offset: 0x00175B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169931, XrefRangeEnd = 169943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Evaluate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_Evaluate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x001779BC File Offset: 0x00175BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169971, RefRangeEnd = 169973, XrefRangeStart = 169943, XrefRangeEnd = 169971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_StartPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DB6 RID: 19894 RVA: 0x001779F0 File Offset: 0x00175BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169973, XrefRangeEnd = 169995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DB7 RID: 19895 RVA: 0x00177A24 File Offset: 0x00175C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169995, XrefRangeEnd = 170012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr_EndPatrol_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DB8 RID: 19896 RVA: 0x00177A58 File Offset: 0x00175C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170012, XrefRangeEnd = 170013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PatrolInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolInstance>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PatrolInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004DB9 RID: 19897 RVA: 0x000252A8 File Offset: 0x000234A8
		public PatrolInstance(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x00177A94 File Offset: 0x00175C94
		// (set) Token: 0x06004DBB RID: 19899 RVA: 0x000252B1 File Offset: 0x000234B1
		public unsafe FootPatrolRoute Route
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootPatrolRoute>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x06004DBC RID: 19900 RVA: 0x00177AC4 File Offset: 0x00175CC4
		// (set) Token: 0x06004DBD RID: 19901 RVA: 0x000252D0 File Offset: 0x000234D0
		public unsafe int Members
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Members);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_Members)) = value;
			}
		}

		// Token: 0x1700172C RID: 5932
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x00177AEC File Offset: 0x00175CEC
		// (set) Token: 0x06004DBF RID: 19903 RVA: 0x000252EB File Offset: 0x000234EB
		public unsafe int StartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_StartTime)) = value;
			}
		}

		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x00177B14 File Offset: 0x00175D14
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x00025306 File Offset: 0x00023506
		public unsafe int EndTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_EndTime)) = value;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x00177B3C File Offset: 0x00175D3C
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x00025321 File Offset: 0x00023521
		public unsafe int IntensityRequirement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_IntensityRequirement)) = value;
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x00177B64 File Offset: 0x00175D64
		// (set) Token: 0x06004DC5 RID: 19909 RVA: 0x0002533C File Offset: 0x0002353C
		public unsafe bool OnlyIfCurfewEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr_OnlyIfCurfewEnabled)) = value;
			}
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x00177B8C File Offset: 0x00175D8C
		// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x00025357 File Offset: 0x00023557
		public unsafe PatrolGroup _ActiveGroup_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PatrolInstance.NativeFieldInfoPtr__ActiveGroup_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003458 RID: 13400
		private static readonly System.IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04003459 RID: 13401
		private static readonly System.IntPtr NativeFieldInfoPtr_Members;

		// Token: 0x0400345A RID: 13402
		private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x0400345B RID: 13403
		private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x0400345C RID: 13404
		private static readonly System.IntPtr NativeFieldInfoPtr_IntensityRequirement;

		// Token: 0x0400345D RID: 13405
		private static readonly System.IntPtr NativeFieldInfoPtr_OnlyIfCurfewEnabled;

		// Token: 0x0400345E RID: 13406
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveGroup_k__BackingField;

		// Token: 0x0400345F RID: 13407
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveGroup_Public_get_PatrolGroup_0;

		// Token: 0x04003460 RID: 13408
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveGroup_Protected_set_Void_PatrolGroup_0;

		// Token: 0x04003461 RID: 13409
		private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_0;

		// Token: 0x04003462 RID: 13410
		private static readonly System.IntPtr NativeMethodInfoPtr_StartPatrol_Public_Void_0;

		// Token: 0x04003463 RID: 13411
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003464 RID: 13412
		private static readonly System.IntPtr NativeMethodInfoPtr_EndPatrol_Public_Void_0;

		// Token: 0x04003465 RID: 13413
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
