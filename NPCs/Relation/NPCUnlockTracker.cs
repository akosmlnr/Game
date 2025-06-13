using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Relation
{
	// Token: 0x02000313 RID: 787
	public class NPCUnlockTracker : MonoBehaviour
	{
		// Token: 0x06003A8E RID: 14990 RVA: 0x00132774 File Offset: 0x00130974
		// Note: this type is marked as 'beforefieldinit'.
		static NPCUnlockTracker()
		{
			Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Relation", "NPCUnlockTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr);
			NPCUnlockTracker.NativeFieldInfoPtr_Npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "Npc");
			NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, "onUnlocked");
			NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100670200);
			NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100670201);
			NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr, 100670202);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00132808 File Offset: 0x00130A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147351, XrefRangeEnd = 147368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x0013283C File Offset: 0x00130A3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130895, RefRangeEnd = 130899, XrefRangeStart = 130895, XrefRangeEnd = 130899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(NPCRelationData.EUnlockType type, bool t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x00132888 File Offset: 0x00130A88
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCUnlockTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCUnlockTracker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCUnlockTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x0001DE03 File Offset: 0x0001C003
		public NPCUnlockTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x001328C4 File Offset: 0x00130AC4
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x0001DE0C File Offset: 0x0001C00C
		public unsafe NPC Npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_Npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x001328F4 File Offset: 0x00130AF4
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x0001DE2B File Offset: 0x0001C02B
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCUnlockTracker.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026A6 RID: 9894
		private static readonly IntPtr NativeFieldInfoPtr_Npc;

		// Token: 0x040026A7 RID: 9895
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x040026A8 RID: 9896
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040026A9 RID: 9897
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x040026AA RID: 9898
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
