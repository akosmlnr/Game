using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200045C RID: 1116
	[System.Serializable]
	public class DialogueEvent : Il2CppSystem.Object
	{
		// Token: 0x060060AC RID: 24748 RVA: 0x001BE5B8 File Offset: 0x001BC7B8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueEvent()
		{
			Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr);
			DialogueEvent.NativeFieldInfoPtr_Dialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "Dialogue");
			DialogueEvent.NativeFieldInfoPtr_onDialogueEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "onDialogueEnded");
			DialogueEvent.NativeFieldInfoPtr_NodeEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, "NodeEvents");
			DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr, 100675709);
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x001BE638 File Offset: 0x001BC838
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueEvent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x0002D58B File Offset: 0x0002B78B
		public DialogueEvent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x060060AF RID: 24751 RVA: 0x001BE674 File Offset: 0x001BC874
		// (set) Token: 0x060060B0 RID: 24752 RVA: 0x0002D594 File Offset: 0x0002B794
		public unsafe DialogueContainer Dialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_Dialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x060060B1 RID: 24753 RVA: 0x001BE6A4 File Offset: 0x001BC8A4
		// (set) Token: 0x060060B2 RID: 24754 RVA: 0x0002D5B3 File Offset: 0x0002B7B3
		public unsafe UnityEvent onDialogueEnded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_onDialogueEnded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x060060B3 RID: 24755 RVA: 0x001BE6D4 File Offset: 0x001BC8D4
		// (set) Token: 0x060060B4 RID: 24756 RVA: 0x0002D5D2 File Offset: 0x0002B7D2
		public unsafe Il2CppReferenceArray<DialogueNodeEvent> NodeEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueNodeEvent>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueEvent.NativeFieldInfoPtr_NodeEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400421B RID: 16923
		private static readonly System.IntPtr NativeFieldInfoPtr_Dialogue;

		// Token: 0x0400421C RID: 16924
		private static readonly System.IntPtr NativeFieldInfoPtr_onDialogueEnded;

		// Token: 0x0400421D RID: 16925
		private static readonly System.IntPtr NativeFieldInfoPtr_NodeEvents;

		// Token: 0x0400421E RID: 16926
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
