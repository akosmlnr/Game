using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x02000305 RID: 773
	public class NPCActionList : Il2CppSystem.Object
	{
		// Token: 0x06003903 RID: 14595 RVA: 0x0012C930 File Offset: 0x0012AB30
		// Note: this type is marked as 'beforefieldinit'.
		static NPCActionList()
		{
			Il2CppClassPointerStore<NPCActionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCActionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr);
			NPCActionList.NativeFieldInfoPtr_actionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, "actionList");
			NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr, 100669941);
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0012C988 File Offset: 0x0012AB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146170, XrefRangeEnd = 146178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCActionList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCActionList>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCActionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0001D684 File Offset: 0x0001B884
		public NPCActionList(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06003906 RID: 14598 RVA: 0x0012C9C4 File Offset: 0x0012ABC4
		// (set) Token: 0x06003907 RID: 14599 RVA: 0x0001D68D File Offset: 0x0001B88D
		public unsafe List<NPCAction> actionList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCActionList.NativeFieldInfoPtr_actionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002576 RID: 9590
		private static readonly System.IntPtr NativeFieldInfoPtr_actionList;

		// Token: 0x04002577 RID: 9591
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
