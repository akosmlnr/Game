using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200044E RID: 1102
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x06005FDA RID: 24538 RVA: 0x001BB410 File Offset: 0x001B9610
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController()
		{
			Il2CppClassPointerStore<DialogueController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController>.NativeClassPtr);
			DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GREETING_COOLDOWN");
			DialogueController.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "IntObj");
			DialogueController.NativeFieldInfoPtr_GenericDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GenericDialogue");
			DialogueController.NativeFieldInfoPtr_DialogueEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueEnabled");
			DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "UseDialogueBehaviour");
			DialogueController.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "Choices");
			DialogueController.NativeFieldInfoPtr_GreetingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverrides");
			DialogueController.NativeFieldInfoPtr_OverrideContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "OverrideContainer");
			DialogueController.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "npc");
			DialogueController.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "handler");
			DialogueController.NativeFieldInfoPtr_lastGreetingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "lastGreetingTime");
			DialogueController.NativeFieldInfoPtr_shownChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "shownChoices");
			DialogueController.NativeFieldInfoPtr_dialogueQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "dialogueQueued");
			DialogueController.NativeFieldInfoPtr_cachedGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "cachedGreeting");
			DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675587);
			DialogueController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675588);
			DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675589);
			DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675590);
			DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675591);
			DialogueController.NativeMethodInfoPtr_Unqueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675592);
			DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675593);
			DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675594);
			DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675595);
			DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675596);
			DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675597);
			DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675598);
			DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675599);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675600);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675601);
			DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675602);
			DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675603);
			DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675604);
			DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675605);
			DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675606);
			DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675607);
			DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675608);
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x001BB710 File Offset: 0x001B9910
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 200748, RefRangeEnd = 200753, XrefRangeStart = 200729, XrefRangeEnd = 200748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x001BB74C File Offset: 0x001B994C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200753, XrefRangeEnd = 200754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x001BB780 File Offset: 0x001B9980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200754, XrefRangeEnd = 200768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x001BB7B4 File Offset: 0x001B99B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200769, RefRangeEnd = 200771, XrefRangeStart = 200768, XrefRangeEnd = 200769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGenericDialogue(bool allowExit = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref allowExit;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x001BB7F4 File Offset: 0x001B99F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200783, RefRangeEnd = 200784, XrefRangeStart = 200771, XrefRangeEnd = 200783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x001BB828 File Offset: 0x001B9A28
		[CallerCount(0)]
		public unsafe void Unqueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Unqueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x001BB85C File Offset: 0x001B9A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200797, RefRangeEnd = 200798, XrefRangeStart = 200784, XrefRangeEnd = 200797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = &playVO;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &voLineType;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x001BB8B0 File Offset: 0x001B9AB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200840, RefRangeEnd = 200842, XrefRangeStart = 200798, XrefRangeEnd = 200840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x001BB8F0 File Offset: 0x001B9AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200842, XrefRangeEnd = 200857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			ref System.IntPtr ptr2 = ref *ptr;
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &playVO;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &voLineType;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			greeting = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x001BB970 File Offset: 0x001B9B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200857, XrefRangeEnd = 200863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x001BB9D8 File Offset: 0x001B9BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200863, XrefRangeEnd = 200869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x001BBA30 File Offset: 0x001B9C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200882, RefRangeEnd = 200883, XrefRangeStart = 200869, XrefRangeEnd = 200882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x001BBA78 File Offset: 0x001B9C78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 200893, RefRangeEnd = 200900, XrefRangeStart = 200883, XrefRangeEnd = 200893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x001BBAE0 File Offset: 0x001B9CE0
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x001BBB48 File Offset: 0x001B9D48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 200929, RefRangeEnd = 200933, XrefRangeStart = 200900, XrefRangeEnd = 200929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			existingChoices = ((intPtr3 == 0) ? null : new List<DialogueChoiceData>(intPtr3));
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x001BBBBC File Offset: 0x001B9DBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 200956, RefRangeEnd = 200962, XrefRangeStart = 200933, XrefRangeEnd = 200956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x001BBC0C File Offset: 0x001B9E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 200983, RefRangeEnd = 200984, XrefRangeStart = 200962, XrefRangeEnd = 200983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x001BBC80 File Offset: 0x001B9E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideContainer(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x001BBCC4 File Offset: 0x001B9EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200984, XrefRangeEnd = 200985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrideContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x001BBCF8 File Offset: 0x001B9EF8
		[CallerCount(0)]
		public unsafe virtual bool DecideBranch(string branchLabel, out int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &index;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x001BBD60 File Offset: 0x001B9F60
		[CallerCount(0)]
		public unsafe void SetDialogueEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x001BBDA0 File Offset: 0x001B9FA0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 201008, RefRangeEnd = 201017, XrefRangeStart = 200985, XrefRangeEnd = 201008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x0002CFB5 File Offset: 0x0002B1B5
		public DialogueController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x001BBDDC File Offset: 0x001B9FDC
		// (set) Token: 0x06005FF3 RID: 24563 RVA: 0x0002CFBE File Offset: 0x0002B1BE
		public unsafe static float GREETING_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06005FF4 RID: 24564 RVA: 0x001BBDF8 File Offset: 0x001B9FF8
		// (set) Token: 0x06005FF5 RID: 24565 RVA: 0x0002CFCC File Offset: 0x0002B1CC
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06005FF6 RID: 24566 RVA: 0x001BBE28 File Offset: 0x001BA028
		// (set) Token: 0x06005FF7 RID: 24567 RVA: 0x0002CFEB File Offset: 0x0002B1EB
		public unsafe DialogueContainer GenericDialogue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06005FF8 RID: 24568 RVA: 0x001BBE58 File Offset: 0x001BA058
		// (set) Token: 0x06005FF9 RID: 24569 RVA: 0x0002D00A File Offset: 0x0002B20A
		public unsafe bool DialogueEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled)) = value;
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06005FFA RID: 24570 RVA: 0x001BBE80 File Offset: 0x001BA080
		// (set) Token: 0x06005FFB RID: 24571 RVA: 0x0002D025 File Offset: 0x0002B225
		public unsafe bool UseDialogueBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour)) = value;
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06005FFC RID: 24572 RVA: 0x001BBEA8 File Offset: 0x001BA0A8
		// (set) Token: 0x06005FFD RID: 24573 RVA: 0x0002D040 File Offset: 0x0002B240
		public unsafe List<DialogueController.DialogueChoice> Choices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06005FFE RID: 24574 RVA: 0x001BBED8 File Offset: 0x001BA0D8
		// (set) Token: 0x06005FFF RID: 24575 RVA: 0x0002D05F File Offset: 0x0002B25F
		public unsafe List<DialogueController.GreetingOverride> GreetingOverrides
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.GreetingOverride>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06006000 RID: 24576 RVA: 0x001BBF08 File Offset: 0x001BA108
		// (set) Token: 0x06006001 RID: 24577 RVA: 0x0002D07E File Offset: 0x0002B27E
		public unsafe DialogueContainer OverrideContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x001BBF38 File Offset: 0x001BA138
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x0002D09D File Offset: 0x0002B29D
		public unsafe NPC npc
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06006004 RID: 24580 RVA: 0x001BBF68 File Offset: 0x001BA168
		// (set) Token: 0x06006005 RID: 24581 RVA: 0x0002D0BC File Offset: 0x0002B2BC
		public unsafe DialogueHandler handler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06006006 RID: 24582 RVA: 0x001BBF98 File Offset: 0x001BA198
		// (set) Token: 0x06006007 RID: 24583 RVA: 0x0002D0DB File Offset: 0x0002B2DB
		public unsafe float lastGreetingTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime)) = value;
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06006008 RID: 24584 RVA: 0x001BBFC0 File Offset: 0x001BA1C0
		// (set) Token: 0x06006009 RID: 24585 RVA: 0x0002D0F6 File Offset: 0x0002B2F6
		public unsafe List<DialogueController.DialogueChoice> shownChoices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x0600600A RID: 24586 RVA: 0x001BBFF0 File Offset: 0x001BA1F0
		// (set) Token: 0x0600600B RID: 24587 RVA: 0x0002D115 File Offset: 0x0002B315
		public unsafe bool dialogueQueued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_dialogueQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_dialogueQueued)) = value;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x0600600C RID: 24588 RVA: 0x001BC018 File Offset: 0x001BA218
		// (set) Token: 0x0600600D RID: 24589 RVA: 0x0002D130 File Offset: 0x0002B330
		public unsafe string cachedGreeting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004193 RID: 16787
		private static readonly System.IntPtr NativeFieldInfoPtr_GREETING_COOLDOWN;

		// Token: 0x04004194 RID: 16788
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004195 RID: 16789
		private static readonly System.IntPtr NativeFieldInfoPtr_GenericDialogue;

		// Token: 0x04004196 RID: 16790
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueEnabled;

		// Token: 0x04004197 RID: 16791
		private static readonly System.IntPtr NativeFieldInfoPtr_UseDialogueBehaviour;

		// Token: 0x04004198 RID: 16792
		private static readonly System.IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x04004199 RID: 16793
		private static readonly System.IntPtr NativeFieldInfoPtr_GreetingOverrides;

		// Token: 0x0400419A RID: 16794
		private static readonly System.IntPtr NativeFieldInfoPtr_OverrideContainer;

		// Token: 0x0400419B RID: 16795
		private static readonly System.IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x0400419C RID: 16796
		private static readonly System.IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x0400419D RID: 16797
		private static readonly System.IntPtr NativeFieldInfoPtr_lastGreetingTime;

		// Token: 0x0400419E RID: 16798
		private static readonly System.IntPtr NativeFieldInfoPtr_shownChoices;

		// Token: 0x0400419F RID: 16799
		private static readonly System.IntPtr NativeFieldInfoPtr_dialogueQueued;

		// Token: 0x040041A0 RID: 16800
		private static readonly System.IntPtr NativeFieldInfoPtr_cachedGreeting;

		// Token: 0x040041A1 RID: 16801
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040041A2 RID: 16802
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040041A3 RID: 16803
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x040041A4 RID: 16804
		private static readonly System.IntPtr NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0;

		// Token: 0x040041A5 RID: 16805
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040041A6 RID: 16806
		private static readonly System.IntPtr NativeMethodInfoPtr_Unqueue_Private_Void_0;

		// Token: 0x040041A7 RID: 16807
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x040041A8 RID: 16808
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0;

		// Token: 0x040041A9 RID: 16809
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x040041AA RID: 16810
		private static readonly System.IntPtr NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0;

		// Token: 0x040041AB RID: 16811
		private static readonly System.IntPtr NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0;

		// Token: 0x040041AC RID: 16812
		private static readonly System.IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0;

		// Token: 0x040041AD RID: 16813
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0;

		// Token: 0x040041AE RID: 16814
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0;

		// Token: 0x040041AF RID: 16815
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x040041B0 RID: 16816
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0;

		// Token: 0x040041B1 RID: 16817
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x040041B2 RID: 16818
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0;

		// Token: 0x040041B3 RID: 16819
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0;

		// Token: 0x040041B4 RID: 16820
		private static readonly System.IntPtr NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0;

		// Token: 0x040041B5 RID: 16821
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0;

		// Token: 0x040041B6 RID: 16822
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A3F RID: 2623
		[System.Serializable]
		public class DialogueChoice : Il2CppSystem.Object
		{
			// Token: 0x0600D2F9 RID: 54009 RVA: 0x0032E998 File Offset: 0x0032CB98
			// Note: this type is marked as 'beforefieldinit'.
			static DialogueChoice()
			{
				Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueChoice");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr);
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Enabled");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ChoiceText");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Conversation");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "onChoosen");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "shouldShowCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "isValidCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Priority");
				DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675610);
				DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675611);
				DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675612);
			}

			// Token: 0x0600D2FA RID: 54010 RVA: 0x0032EA8C File Offset: 0x0032CC8C
			[CallerCount(0)]
			public unsafe bool ShouldShow()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D2FB RID: 54011 RVA: 0x0032EAC8 File Offset: 0x0032CCC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200700, XrefRangeEnd = 200703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid(out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				ref System.IntPtr ptr2 = ref *ptr;
				System.IntPtr il2CppString = 0;
				ptr2 = &il2CppString;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D2FC RID: 54012 RVA: 0x0032EB20 File Offset: 0x0032CD20
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 200709, RefRangeEnd = 200727, XrefRangeStart = 200703, XrefRangeEnd = 200709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DialogueChoice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D2FD RID: 54013 RVA: 0x00066464 File Offset: 0x00064664
			public DialogueChoice(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700415B RID: 16731
			// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x0032EB5C File Offset: 0x0032CD5C
			// (set) Token: 0x0600D2FF RID: 54015 RVA: 0x0006646D File Offset: 0x0006466D
			public unsafe bool Enabled
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x1700415C RID: 16732
			// (get) Token: 0x0600D300 RID: 54016 RVA: 0x0032EB84 File Offset: 0x0032CD84
			// (set) Token: 0x0600D301 RID: 54017 RVA: 0x00066488 File Offset: 0x00064688
			public unsafe string ChoiceText
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700415D RID: 16733
			// (get) Token: 0x0600D302 RID: 54018 RVA: 0x0032EBAC File Offset: 0x0032CDAC
			// (set) Token: 0x0600D303 RID: 54019 RVA: 0x000664A7 File Offset: 0x000646A7
			public unsafe DialogueContainer Conversation
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700415E RID: 16734
			// (get) Token: 0x0600D304 RID: 54020 RVA: 0x0032EBDC File Offset: 0x0032CDDC
			// (set) Token: 0x0600D305 RID: 54021 RVA: 0x000664C6 File Offset: 0x000646C6
			public unsafe UnityEvent onChoosen
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700415F RID: 16735
			// (get) Token: 0x0600D306 RID: 54022 RVA: 0x0032EC0C File Offset: 0x0032CE0C
			// (set) Token: 0x0600D307 RID: 54023 RVA: 0x000664E5 File Offset: 0x000646E5
			public unsafe DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.ShouldShowCheck>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004160 RID: 16736
			// (get) Token: 0x0600D308 RID: 54024 RVA: 0x0032EC3C File Offset: 0x0032CE3C
			// (set) Token: 0x0600D309 RID: 54025 RVA: 0x00066504 File Offset: 0x00064704
			public unsafe DialogueController.DialogueChoice.IsChoiceValid isValidCheck
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.IsChoiceValid>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004161 RID: 16737
			// (get) Token: 0x0600D30A RID: 54026 RVA: 0x0032EC6C File Offset: 0x0032CE6C
			// (set) Token: 0x0600D30B RID: 54027 RVA: 0x00066523 File Offset: 0x00064723
			public unsafe int Priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04008E8F RID: 36495
			private static readonly System.IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04008E90 RID: 36496
			private static readonly System.IntPtr NativeFieldInfoPtr_ChoiceText;

			// Token: 0x04008E91 RID: 36497
			private static readonly System.IntPtr NativeFieldInfoPtr_Conversation;

			// Token: 0x04008E92 RID: 36498
			private static readonly System.IntPtr NativeFieldInfoPtr_onChoosen;

			// Token: 0x04008E93 RID: 36499
			private static readonly System.IntPtr NativeFieldInfoPtr_shouldShowCheck;

			// Token: 0x04008E94 RID: 36500
			private static readonly System.IntPtr NativeFieldInfoPtr_isValidCheck;

			// Token: 0x04008E95 RID: 36501
			private static readonly System.IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008E96 RID: 36502
			private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShow_Public_Boolean_0;

			// Token: 0x04008E97 RID: 36503
			private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0;

			// Token: 0x04008E98 RID: 36504
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000CAE RID: 3246
			public sealed class ShouldShowCheck : Il2CppSystem.MulticastDelegate
			{
				// Token: 0x0600E8DF RID: 59615 RVA: 0x0036C88C File Offset: 0x0036AA8C
				// Note: this type is marked as 'beforefieldinit'.
				static ShouldShowCheck()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ShouldShowCheck");
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675613);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675614);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675615);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675616);
				}

				// Token: 0x0600E8E0 RID: 59616 RVA: 0x0036C900 File Offset: 0x0036AB00
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 200655, RefRangeEnd = 200671, XrefRangeStart = 200652, XrefRangeEnd = 200655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ShouldShowCheck(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8E1 RID: 59617 RVA: 0x0036C95C File Offset: 0x0036AB5C
				[CallerCount(0)]
				public unsafe bool Invoke(bool enabled)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref enabled;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E8E2 RID: 59618 RVA: 0x0036C9A8 File Offset: 0x0036ABA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200671, XrefRangeEnd = 200675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppSystem.IAsyncResult BeginInvoke(bool enabled, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref enabled;
					ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
				}

				// Token: 0x0600E8E3 RID: 59619 RVA: 0x0036CA18 File Offset: 0x0036AC18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(Il2CppSystem.IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E8E4 RID: 59620 RVA: 0x00071347 File Offset: 0x0006F547
				public ShouldShowCheck(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600E8E5 RID: 59621 RVA: 0x00071350 File Offset: 0x0006F550
				public static implicit operator DialogueController.DialogueChoice.ShouldShowCheck(System.Func<bool, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<DialogueController.DialogueChoice.ShouldShowCheck>(A_0);
				}

				// Token: 0x0600E8E6 RID: 59622 RVA: 0x00071358 File Offset: 0x0006F558
				public static DialogueController.DialogueChoice.ShouldShowCheck operator +(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
				}

				// Token: 0x0600E8E7 RID: 59623 RVA: 0x00071366 File Offset: 0x0006F566
				public static DialogueController.DialogueChoice.ShouldShowCheck operator -(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					Il2CppSystem.Delegate result;
					Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
					if (@delegate != null)
					{
						result = @delegate.Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
					}
					return result;
				}

				// Token: 0x04009BE3 RID: 39907
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04009BE4 RID: 39908
				private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0;

				// Token: 0x04009BE5 RID: 39909
				private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

				// Token: 0x04009BE6 RID: 39910
				private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000CAF RID: 3247
			public sealed class IsChoiceValid : Il2CppSystem.MulticastDelegate
			{
				// Token: 0x0600E8E8 RID: 59624 RVA: 0x0036CA68 File Offset: 0x0036AC68
				// Note: this type is marked as 'beforefieldinit'.
				static IsChoiceValid()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "IsChoiceValid");
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675617);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675618);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675619);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675620);
				}

				// Token: 0x0600E8E9 RID: 59625 RVA: 0x0036CADC File Offset: 0x0036ACDC
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 200679, RefRangeEnd = 200699, XrefRangeStart = 200675, XrefRangeEnd = 200679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsChoiceValid(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8EA RID: 59626 RVA: 0x0036CB38 File Offset: 0x0036AD38
				[CallerCount(0)]
				public unsafe bool Invoke(out string invalidReason)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					ref System.IntPtr ptr2 = ref *ptr;
					System.IntPtr il2CppString = 0;
					ptr2 = &il2CppString;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E8EB RID: 59627 RVA: 0x0036CB90 File Offset: 0x0036AD90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200699, XrefRangeEnd = 200700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Il2CppSystem.IAsyncResult BeginInvoke(out string invalidReason, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
					ref System.IntPtr ptr2 = ref *ptr;
					System.IntPtr il2CppString = 0;
					ptr2 = &il2CppString;
					ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
				}

				// Token: 0x0600E8EC RID: 59628 RVA: 0x0036CC10 File Offset: 0x0036AE10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(out string invalidReason, Il2CppSystem.IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
					ref System.IntPtr ptr2 = ref *ptr;
					System.IntPtr il2CppString = 0;
					ptr2 = &il2CppString;
					ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600E8ED RID: 59629 RVA: 0x00071377 File Offset: 0x0006F577
				public IsChoiceValid(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x04009BE7 RID: 39911
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04009BE8 RID: 39912
				private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0;

				// Token: 0x04009BE9 RID: 39913
				private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0;

				// Token: 0x04009BEA RID: 39914
				private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
			}
		}

		// Token: 0x02000A40 RID: 2624
		[System.Serializable]
		public class GreetingOverride : Il2CppSystem.Object
		{
			// Token: 0x0600D30C RID: 54028 RVA: 0x0032EC94 File Offset: 0x0032CE94
			// Note: this type is marked as 'beforefieldinit'.
			static GreetingOverride()
			{
				Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverride");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr);
				DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "Greeting");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "ShouldShow");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "PlayVO");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "VOType");
				DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, 100675621);
			}

			// Token: 0x0600D30D RID: 54029 RVA: 0x0032ED24 File Offset: 0x0032CF24
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreetingOverride() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D30E RID: 54030 RVA: 0x0006653E File Offset: 0x0006473E
			public GreetingOverride(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004162 RID: 16738
			// (get) Token: 0x0600D30F RID: 54031 RVA: 0x0032ED60 File Offset: 0x0032CF60
			// (set) Token: 0x0600D310 RID: 54032 RVA: 0x00066547 File Offset: 0x00064747
			public unsafe string Greeting
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004163 RID: 16739
			// (get) Token: 0x0600D311 RID: 54033 RVA: 0x0032ED88 File Offset: 0x0032CF88
			// (set) Token: 0x0600D312 RID: 54034 RVA: 0x00066566 File Offset: 0x00064766
			public unsafe bool ShouldShow
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow)) = value;
				}
			}

			// Token: 0x17004164 RID: 16740
			// (get) Token: 0x0600D313 RID: 54035 RVA: 0x0032EDB0 File Offset: 0x0032CFB0
			// (set) Token: 0x0600D314 RID: 54036 RVA: 0x00066581 File Offset: 0x00064781
			public unsafe bool PlayVO
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO)) = value;
				}
			}

			// Token: 0x17004165 RID: 16741
			// (get) Token: 0x0600D315 RID: 54037 RVA: 0x0032EDD8 File Offset: 0x0032CFD8
			// (set) Token: 0x0600D316 RID: 54038 RVA: 0x0006659C File Offset: 0x0006479C
			public unsafe EVOLineType VOType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType)) = value;
				}
			}

			// Token: 0x04008E99 RID: 36505
			private static readonly System.IntPtr NativeFieldInfoPtr_Greeting;

			// Token: 0x04008E9A RID: 36506
			private static readonly System.IntPtr NativeFieldInfoPtr_ShouldShow;

			// Token: 0x04008E9B RID: 36507
			private static readonly System.IntPtr NativeFieldInfoPtr_PlayVO;

			// Token: 0x04008E9C RID: 36508
			private static readonly System.IntPtr NativeFieldInfoPtr_VOType;

			// Token: 0x04008E9D RID: 36509
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A41 RID: 2625
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D317 RID: 54039 RVA: 0x0032EE00 File Offset: 0x0032D000
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr);
				DialogueController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9");
				DialogueController.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9__23_0");
				DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100675623);
				DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100675624);
			}

			// Token: 0x0600D318 RID: 54040 RVA: 0x0032EE7C File Offset: 0x0032D07C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D319 RID: 54041 RVA: 0x0032EEB8 File Offset: 0x0032D0B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200727, XrefRangeEnd = 200729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActiveChoices_b__23_0(DialogueController.DialogueChoice a, DialogueController.DialogueChoice b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D31A RID: 54042 RVA: 0x000665B7 File Offset: 0x000647B7
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004166 RID: 16742
			// (get) Token: 0x0600D31B RID: 54043 RVA: 0x0032EF18 File Offset: 0x0032D118
			// (set) Token: 0x0600D31C RID: 54044 RVA: 0x000665C0 File Offset: 0x000647C0
			public unsafe static DialogueController.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004167 RID: 16743
			// (get) Token: 0x0600D31D RID: 54045 RVA: 0x0032EF40 File Offset: 0x0032D140
			// (set) Token: 0x0600D31E RID: 54046 RVA: 0x000665D2 File Offset: 0x000647D2
			public unsafe static Il2CppSystem.Comparison<DialogueController.DialogueChoice> __9__23_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<DialogueController.DialogueChoice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E9E RID: 36510
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E9F RID: 36511
			private static readonly System.IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04008EA0 RID: 36512
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EA1 RID: 36513
			private static readonly System.IntPtr NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0;
		}
	}
}
