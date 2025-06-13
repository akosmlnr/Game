using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CD RID: 461
	public class Quest_SinkOrSwim : Quest
	{
		// Token: 0x060026ED RID: 9965 RVA: 0x000EDAB8 File Offset: 0x000EBCB8
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_SinkOrSwim()
		{
			Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_SinkOrSwim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr);
			Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "DAYS_TO_COMPLETE");
			Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "QuestName");
			Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "NelsonCallTime");
			Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "LoanSharkVehiclePosition");
			Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, "LoanSharkGraves");
			Quest_SinkOrSwim.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667686);
			Quest_SinkOrSwim.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667687);
			Quest_SinkOrSwim.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667688);
			Quest_SinkOrSwim.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667689);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667690);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667691);
			Quest_SinkOrSwim.NativeMethodInfoPtr_CheckArrival_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667692);
			Quest_SinkOrSwim.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667693);
			Quest_SinkOrSwim.NativeMethodInfoPtr_UpdateName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667694);
			Quest_SinkOrSwim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr, 100667695);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000EDC14 File Offset: 0x000EBE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120350, XrefRangeEnd = 120354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x000EDC50 File Offset: 0x000EBE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120354, XrefRangeEnd = 120411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x000EDC8C File Offset: 0x000EBE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000EDCC8 File Offset: 0x000EBEC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120411, XrefRangeEnd = 120415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000EDCFC File Offset: 0x000EBEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120415, XrefRangeEnd = 120438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x000EDD30 File Offset: 0x000EBF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120438, XrefRangeEnd = 120445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnLoanSharkVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x000EDD64 File Offset: 0x000EBF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120445, XrefRangeEnd = 120483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckArrival()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_CheckArrival_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000EDD98 File Offset: 0x000EBF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120483, XrefRangeEnd = 120487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_SinkOrSwim.NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000EDDF0 File Offset: 0x000EBFF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120519, RefRangeEnd = 120520, XrefRangeStart = 120487, XrefRangeEnd = 120519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr_UpdateName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000EDE24 File Offset: 0x000EC024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120520, XrefRangeEnd = 120528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_SinkOrSwim() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_SinkOrSwim>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_SinkOrSwim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0001576A File Offset: 0x0001396A
		public Quest_SinkOrSwim(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000EDE60 File Offset: 0x000EC060
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x00015773 File Offset: 0x00013973
		public unsafe static int DAYS_TO_COMPLETE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_SinkOrSwim.NativeFieldInfoPtr_DAYS_TO_COMPLETE, (void*)(&value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000EDE7C File Offset: 0x000EC07C
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00015781 File Offset: 0x00013981
		public unsafe string QuestName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_QuestName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000EDEA4 File Offset: 0x000EC0A4
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x000157A0 File Offset: 0x000139A0
		public unsafe int NelsonCallTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_NelsonCallTime)) = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000EDECC File Offset: 0x000EC0CC
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x000157BB File Offset: 0x000139BB
		public unsafe Transform LoanSharkVehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkVehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000EDEFC File Offset: 0x000EC0FC
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x000157DA File Offset: 0x000139DA
		public unsafe GameObject LoanSharkGraves
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_SinkOrSwim.NativeFieldInfoPtr_LoanSharkGraves), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeFieldInfoPtr_DAYS_TO_COMPLETE;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeFieldInfoPtr_QuestName;

		// Token: 0x040019E9 RID: 6633
		private static readonly IntPtr NativeFieldInfoPtr_NelsonCallTime;

		// Token: 0x040019EA RID: 6634
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkVehiclePosition;

		// Token: 0x040019EB RID: 6635
		private static readonly IntPtr NativeFieldInfoPtr_LoanSharkGraves;

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040019ED RID: 6637
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040019EE RID: 6638
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019EF RID: 6639
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040019F0 RID: 6640
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x040019F1 RID: 6641
		private static readonly IntPtr NativeMethodInfoPtr_SpawnLoanSharkVehicle_Private_Void_0;

		// Token: 0x040019F2 RID: 6642
		private static readonly IntPtr NativeMethodInfoPtr_CheckArrival_Private_Void_0;

		// Token: 0x040019F3 RID: 6643
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_Void_EQuestState_Boolean_0;

		// Token: 0x040019F4 RID: 6644
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_0;

		// Token: 0x040019F5 RID: 6645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
