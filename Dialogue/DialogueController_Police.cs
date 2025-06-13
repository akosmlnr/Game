using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000455 RID: 1109
	public class DialogueController_Police : DialogueController
	{
		// Token: 0x0600606A RID: 24682 RVA: 0x001BD778 File Offset: 0x001BB978
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Police()
		{
			Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr);
			DialogueController_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, "officer");
			DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675675);
			DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675676);
			DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr, 100675677);
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x001BD7F8 File Offset: 0x001BB9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201774, XrefRangeEnd = 201780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x001BD834 File Offset: 0x001BBA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201780, XrefRangeEnd = 201781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Police.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x001BD87C File Offset: 0x001BBA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201781, XrefRangeEnd = 201785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Police>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x0002D3C6 File Offset: 0x0002B5C6
		public DialogueController_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x001BD8B8 File Offset: 0x001BBAB8
		// (set) Token: 0x06006070 RID: 24688 RVA: 0x0002D3CF File Offset: 0x0002B5CF
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041F4 RID: 16884
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x040041F5 RID: 16885
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040041F6 RID: 16886
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_Boolean_0;

		// Token: 0x040041F7 RID: 16887
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
