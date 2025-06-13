using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000461 RID: 1121
	public class DialogueHandler_Police : ControlledDialogueHandler
	{
		// Token: 0x06006123 RID: 24867 RVA: 0x001C0104 File Offset: 0x001BE304
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_Police()
		{
			Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr);
			DialogueHandler_Police.NativeFieldInfoPtr_CheckpointRequestDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, "CheckpointRequestDialogue");
			DialogueHandler_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, "officer");
			DialogueHandler_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675785);
			DialogueHandler_Police.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675786);
			DialogueHandler_Police.NativeMethodInfoPtr_Interacted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675787);
			DialogueHandler_Police.NativeMethodInfoPtr_CanTalk_Checkpoint_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675788);
			DialogueHandler_Police.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675789);
			DialogueHandler_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675790);
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x001C01D4 File Offset: 0x001BE3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202799, XrefRangeEnd = 202809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x001C0210 File Offset: 0x001BE410
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x001C024C File Offset: 0x001BE44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202809, XrefRangeEnd = 202841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_Interacted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x001C0288 File Offset: 0x001BE488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202841, XrefRangeEnd = 202847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanTalk_Checkpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Police.NativeMethodInfoPtr_CanTalk_Checkpoint_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x001C02C4 File Offset: 0x001BE4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202847, XrefRangeEnd = 202868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x001C031C File Offset: 0x001BE51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x0002D91B File Offset: 0x0002BB1B
		public DialogueHandler_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x001C0358 File Offset: 0x001BE558
		// (set) Token: 0x0600612C RID: 24876 RVA: 0x0002D924 File Offset: 0x0002BB24
		public unsafe DialogueContainer CheckpointRequestDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_CheckpointRequestDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_CheckpointRequestDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x0600612D RID: 24877 RVA: 0x001C0388 File Offset: 0x001BE588
		// (set) Token: 0x0600612E RID: 24878 RVA: 0x0002D943 File Offset: 0x0002BB43
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeFieldInfoPtr_CheckpointRequestDialogue;

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_Void_0;

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeMethodInfoPtr_CanTalk_Checkpoint_Private_Boolean_0;

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
