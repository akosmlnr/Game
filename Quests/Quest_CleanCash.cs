using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C0 RID: 448
	public class Quest_CleanCash : Quest
	{
		// Token: 0x06002683 RID: 9859 RVA: 0x000EC704 File Offset: 0x000EA904
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_CleanCash()
		{
			Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_CleanCash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr);
			Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, "BuyBusinessEntry");
			Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, "GoToBusinessEntry");
			Quest_CleanCash.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, 100667647);
			Quest_CleanCash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr, 100667648);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x000EC784 File Offset: 0x000EA984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119981, XrefRangeEnd = 120016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_CleanCash.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x000EC7C0 File Offset: 0x000EA9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120016, XrefRangeEnd = 120020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_CleanCash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_CleanCash>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_CleanCash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x0001545B File Offset: 0x0001365B
		public Quest_CleanCash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x000EC7FC File Offset: 0x000EA9FC
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x00015464 File Offset: 0x00013664
		public unsafe QuestEntry BuyBusinessEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_BuyBusinessEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x000EC82C File Offset: 0x000EAA2C
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x00015483 File Offset: 0x00013683
		public unsafe QuestEntry GoToBusinessEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_CleanCash.NativeFieldInfoPtr_GoToBusinessEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_BuyBusinessEntry;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_GoToBusinessEntry;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
