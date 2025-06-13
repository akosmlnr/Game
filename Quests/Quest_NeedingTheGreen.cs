using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C9 RID: 457
	public class Quest_NeedingTheGreen : Quest
	{
		// Token: 0x060026D0 RID: 9936 RVA: 0x000ED588 File Offset: 0x000EB788
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_NeedingTheGreen()
		{
			Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_NeedingTheGreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr);
			Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "PrerequisiteQuests");
			Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "EarnEntry");
			Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, "LifetimeEarningsRequirement");
			Quest_NeedingTheGreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, 100667677);
			Quest_NeedingTheGreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr, 100667678);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000ED61C File Offset: 0x000EB81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120258, XrefRangeEnd = 120288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_NeedingTheGreen.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000ED658 File Offset: 0x000EB858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120288, XrefRangeEnd = 120292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_NeedingTheGreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_NeedingTheGreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_NeedingTheGreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00015690 File Offset: 0x00013890
		public Quest_NeedingTheGreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000ED694 File Offset: 0x000EB894
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x00015699 File Offset: 0x00013899
		public unsafe Il2CppReferenceArray<Quest> PrerequisiteQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_PrerequisiteQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x000ED6C4 File Offset: 0x000EB8C4
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x000156B8 File Offset: 0x000138B8
		public unsafe QuestEntry EarnEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_EarnEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x000ED6F4 File Offset: 0x000EB8F4
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x000156D7 File Offset: 0x000138D7
		public unsafe float LifetimeEarningsRequirement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_NeedingTheGreen.NativeFieldInfoPtr_LifetimeEarningsRequirement)) = value;
			}
		}

		// Token: 0x040019D8 RID: 6616
		private static readonly IntPtr NativeFieldInfoPtr_PrerequisiteQuests;

		// Token: 0x040019D9 RID: 6617
		private static readonly IntPtr NativeFieldInfoPtr_EarnEntry;

		// Token: 0x040019DA RID: 6618
		private static readonly IntPtr NativeFieldInfoPtr_LifetimeEarningsRequirement;

		// Token: 0x040019DB RID: 6619
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019DC RID: 6620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
