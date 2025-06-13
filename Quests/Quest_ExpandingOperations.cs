using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C5 RID: 453
	public class Quest_ExpandingOperations : Quest
	{
		// Token: 0x060026A9 RID: 9897 RVA: 0x000ECEAC File Offset: 0x000EB0AC
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_ExpandingOperations()
		{
			Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_ExpandingOperations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr);
			Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "SetUpGrowTentsEntry");
			Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, "ReachCustomersEntry");
			Quest_ExpandingOperations.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667663);
			Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr, 100667664);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000ECF2C File Offset: 0x000EB12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120147, XrefRangeEnd = 120180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_ExpandingOperations.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000ECF68 File Offset: 0x000EB168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120180, XrefRangeEnd = 120184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_ExpandingOperations() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_ExpandingOperations>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_ExpandingOperations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x0001553E File Offset: 0x0001373E
		public Quest_ExpandingOperations(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x000ECFA4 File Offset: 0x000EB1A4
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x00015547 File Offset: 0x00013747
		public unsafe QuestEntry SetUpGrowTentsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_SetUpGrowTentsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x000ECFD4 File Offset: 0x000EB1D4
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x00015566 File Offset: 0x00013766
		public unsafe QuestEntry ReachCustomersEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_ExpandingOperations.NativeFieldInfoPtr_ReachCustomersEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_SetUpGrowTentsEntry;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_ReachCustomersEntry;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
