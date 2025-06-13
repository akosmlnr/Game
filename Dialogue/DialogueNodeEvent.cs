using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200045D RID: 1117
	[System.Serializable]
	public class DialogueNodeEvent : Il2CppSystem.Object
	{
		// Token: 0x060060B5 RID: 24757 RVA: 0x001BE704 File Offset: 0x001BC904
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueNodeEvent()
		{
			Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueNodeEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr);
			DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "NodeLabel");
			DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, "onNodeDisplayed");
			DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr, 100675710);
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x001BE770 File Offset: 0x001BC970
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueNodeEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueNodeEvent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueNodeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x0002D5F1 File Offset: 0x0002B7F1
		public DialogueNodeEvent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x060060B8 RID: 24760 RVA: 0x001BE7AC File Offset: 0x001BC9AC
		// (set) Token: 0x060060B9 RID: 24761 RVA: 0x0002D5FA File Offset: 0x0002B7FA
		public unsafe string NodeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_NodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x060060BA RID: 24762 RVA: 0x001BE7D4 File Offset: 0x001BC9D4
		// (set) Token: 0x060060BB RID: 24763 RVA: 0x0002D619 File Offset: 0x0002B819
		public unsafe UnityEvent onNodeDisplayed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueNodeEvent.NativeFieldInfoPtr_onNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400421F RID: 16927
		private static readonly System.IntPtr NativeFieldInfoPtr_NodeLabel;

		// Token: 0x04004220 RID: 16928
		private static readonly System.IntPtr NativeFieldInfoPtr_onNodeDisplayed;

		// Token: 0x04004221 RID: 16929
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
