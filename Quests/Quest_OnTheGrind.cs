using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CA RID: 458
	public class Quest_OnTheGrind : Quest
	{
		// Token: 0x060026DA RID: 9946 RVA: 0x000ED71C File Offset: 0x000EB91C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_OnTheGrind()
		{
			Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_OnTheGrind");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr);
			Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, "CompleteDealsEntry");
			Quest_OnTheGrind.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667679);
			Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr, 100667680);
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x000ED788 File Offset: 0x000EB988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120292, XrefRangeEnd = 120310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_OnTheGrind.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026DC RID: 9948 RVA: 0x000ED7C4 File Offset: 0x000EB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120310, XrefRangeEnd = 120314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_OnTheGrind() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_OnTheGrind>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_OnTheGrind.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x000156F2 File Offset: 0x000138F2
		public Quest_OnTheGrind(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x000ED800 File Offset: 0x000EBA00
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x000156FB File Offset: 0x000138FB
		public unsafe QuestEntry CompleteDealsEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_OnTheGrind.NativeFieldInfoPtr_CompleteDealsEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr_CompleteDealsEntry;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
