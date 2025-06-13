using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200065A RID: 1626
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x06008EB3 RID: 36531 RVA: 0x002563D0 File Offset: 0x002545D0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueCanvas()
		{
			Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr);
			DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "TIME_PER_CHAR");
			DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "SkipNextRollout");
			DialogueCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "canvas");
			DialogueCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "Container");
			DialogueCanvas.NativeFieldInfoPtr_dialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueText");
			DialogueCanvas.NativeFieldInfoPtr_continuePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "continuePopup");
			DialogueCanvas.NativeFieldInfoPtr_dialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueChoices");
			DialogueCanvas.NativeFieldInfoPtr_currentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentHandler");
			DialogueCanvas.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentNode");
			DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "spaceDownThisFrame");
			DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "leftClickThisFrame");
			DialogueCanvas.NativeFieldInfoPtr_overrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "overrideText");
			DialogueCanvas.NativeFieldInfoPtr_dialogueRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueRollout");
			DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "choiceSelectionResidualCoroutine");
			DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "hasChoiceBeenSelected");
			DialogueCanvas.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681110);
			DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681111);
			DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681112);
			DialogueCanvas.NativeMethodInfoPtr_OverrideText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681113);
			DialogueCanvas.NativeMethodInfoPtr_StopTextOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681114);
			DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681115);
			DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681116);
			DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681117);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681118);
			DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681119);
			DialogueCanvas.NativeMethodInfoPtr_EndDialogue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681120);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681121);
			DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681122);
			DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681123);
			DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100681124);
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x06008EB4 RID: 36532 RVA: 0x00256658 File Offset: 0x00254858
		public unsafe bool isActive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260560, RefRangeEnd = 260562, XrefRangeStart = 260556, XrefRangeEnd = 260560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x00256694 File Offset: 0x00254894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260562, XrefRangeEnd = 260579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x002566D0 File Offset: 0x002548D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260595, RefRangeEnd = 260596, XrefRangeStart = 260579, XrefRangeEnd = 260595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<string> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(diag);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x0025674C File Offset: 0x0025494C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260602, RefRangeEnd = 260603, XrefRangeStart = 260596, XrefRangeEnd = 260602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_OverrideText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x00256790 File Offset: 0x00254990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260606, RefRangeEnd = 260607, XrefRangeStart = 260603, XrefRangeEnd = 260606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTextOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StopTextOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x002567C4 File Offset: 0x002549C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260607, XrefRangeEnd = 260616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x002567F8 File Offset: 0x002549F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260616, XrefRangeEnd = 260624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0025683C File Offset: 0x00254A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260624, XrefRangeEnd = 260631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RolloutDialogue(string text, List<string> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x002568A0 File Offset: 0x00254AA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260637, RefRangeEnd = 260638, XrefRangeStart = 260631, XrefRangeEnd = 260637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref fadeTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x00256900 File Offset: 0x00254B00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260692, RefRangeEnd = 260693, XrefRangeStart = 260638, XrefRangeEnd = 260692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(DialogueHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x00256944 File Offset: 0x00254B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260724, RefRangeEnd = 260725, XrefRangeStart = 260693, XrefRangeEnd = 260724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_EndDialogue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x00256978 File Offset: 0x00254B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260725, XrefRangeEnd = 260750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref choiceIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EC0 RID: 36544 RVA: 0x002569B8 File Offset: 0x00254BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260750, XrefRangeEnd = 260758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChoiceValid(int choiceIndex, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref choiceIndex;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x00256A1C File Offset: 0x00254C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260758, XrefRangeEnd = 260771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x00256A58 File Offset: 0x00254C58
		[CallerCount(0)]
		public unsafe bool _RolloutDialogue_b__21_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x00044291 File Offset: 0x00042491
		public DialogueCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B52 RID: 11090
		// (get) Token: 0x06008EC4 RID: 36548 RVA: 0x00256A94 File Offset: 0x00254C94
		// (set) Token: 0x06008EC5 RID: 36549 RVA: 0x0004429A File Offset: 0x0004249A
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x06008EC6 RID: 36550 RVA: 0x00256AB0 File Offset: 0x00254CB0
		// (set) Token: 0x06008EC7 RID: 36551 RVA: 0x000442A8 File Offset: 0x000424A8
		public unsafe bool SkipNextRollout
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout)) = value;
			}
		}

		// Token: 0x17002B54 RID: 11092
		// (get) Token: 0x06008EC8 RID: 36552 RVA: 0x00256AD8 File Offset: 0x00254CD8
		// (set) Token: 0x06008EC9 RID: 36553 RVA: 0x000442C3 File Offset: 0x000424C3
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x06008ECA RID: 36554 RVA: 0x00256B08 File Offset: 0x00254D08
		// (set) Token: 0x06008ECB RID: 36555 RVA: 0x000442E2 File Offset: 0x000424E2
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x06008ECC RID: 36556 RVA: 0x00256B38 File Offset: 0x00254D38
		// (set) Token: 0x06008ECD RID: 36557 RVA: 0x00044301 File Offset: 0x00042501
		public unsafe TextMeshProUGUI dialogueText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x06008ECE RID: 36558 RVA: 0x00256B68 File Offset: 0x00254D68
		// (set) Token: 0x06008ECF RID: 36559 RVA: 0x00044320 File Offset: 0x00042520
		public unsafe GameObject continuePopup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continuePopup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continuePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x06008ED0 RID: 36560 RVA: 0x00256B98 File Offset: 0x00254D98
		// (set) Token: 0x06008ED1 RID: 36561 RVA: 0x0004433F File Offset: 0x0004253F
		public unsafe List<DialogueChoiceEntry> dialogueChoices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x06008ED2 RID: 36562 RVA: 0x00256BC8 File Offset: 0x00254DC8
		// (set) Token: 0x06008ED3 RID: 36563 RVA: 0x0004435E File Offset: 0x0004255E
		public unsafe DialogueHandler currentHandler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x06008ED4 RID: 36564 RVA: 0x00256BF8 File Offset: 0x00254DF8
		// (set) Token: 0x06008ED5 RID: 36565 RVA: 0x0004437D File Offset: 0x0004257D
		public unsafe DialogueNodeData currentNode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x00256C28 File Offset: 0x00254E28
		// (set) Token: 0x06008ED7 RID: 36567 RVA: 0x0004439C File Offset: 0x0004259C
		public unsafe bool spaceDownThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame)) = value;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x00256C50 File Offset: 0x00254E50
		// (set) Token: 0x06008ED9 RID: 36569 RVA: 0x000443B7 File Offset: 0x000425B7
		public unsafe bool leftClickThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame)) = value;
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x00256C78 File Offset: 0x00254E78
		// (set) Token: 0x06008EDB RID: 36571 RVA: 0x000443D2 File Offset: 0x000425D2
		public unsafe string overrideText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_overrideText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_overrideText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x06008EDC RID: 36572 RVA: 0x00256CA0 File Offset: 0x00254EA0
		// (set) Token: 0x06008EDD RID: 36573 RVA: 0x000443F1 File Offset: 0x000425F1
		public unsafe Coroutine dialogueRollout
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRollout);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRollout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x06008EDE RID: 36574 RVA: 0x00256CD0 File Offset: 0x00254ED0
		// (set) Token: 0x06008EDF RID: 36575 RVA: 0x00044410 File Offset: 0x00042610
		public unsafe Coroutine choiceSelectionResidualCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x00256D00 File Offset: 0x00254F00
		// (set) Token: 0x06008EE1 RID: 36577 RVA: 0x0004442F File Offset: 0x0004262F
		public unsafe bool hasChoiceBeenSelected
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected)) = value;
			}
		}

		// Token: 0x040060BF RID: 24767
		private static readonly System.IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x040060C0 RID: 24768
		private static readonly System.IntPtr NativeFieldInfoPtr_SkipNextRollout;

		// Token: 0x040060C1 RID: 24769
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040060C2 RID: 24770
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060C3 RID: 24771
		private static readonly System.IntPtr NativeFieldInfoPtr_dialogueText;

		// Token: 0x040060C4 RID: 24772
		private static readonly System.IntPtr NativeFieldInfoPtr_continuePopup;

		// Token: 0x040060C5 RID: 24773
		private static readonly System.IntPtr NativeFieldInfoPtr_dialogueChoices;

		// Token: 0x040060C6 RID: 24774
		private static readonly System.IntPtr NativeFieldInfoPtr_currentHandler;

		// Token: 0x040060C7 RID: 24775
		private static readonly System.IntPtr NativeFieldInfoPtr_currentNode;

		// Token: 0x040060C8 RID: 24776
		private static readonly System.IntPtr NativeFieldInfoPtr_spaceDownThisFrame;

		// Token: 0x040060C9 RID: 24777
		private static readonly System.IntPtr NativeFieldInfoPtr_leftClickThisFrame;

		// Token: 0x040060CA RID: 24778
		private static readonly System.IntPtr NativeFieldInfoPtr_overrideText;

		// Token: 0x040060CB RID: 24779
		private static readonly System.IntPtr NativeFieldInfoPtr_dialogueRollout;

		// Token: 0x040060CC RID: 24780
		private static readonly System.IntPtr NativeFieldInfoPtr_choiceSelectionResidualCoroutine;

		// Token: 0x040060CD RID: 24781
		private static readonly System.IntPtr NativeFieldInfoPtr_hasChoiceBeenSelected;

		// Token: 0x040060CE RID: 24782
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x040060CF RID: 24783
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040060D0 RID: 24784
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0;

		// Token: 0x040060D1 RID: 24785
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideText_Public_Void_String_0;

		// Token: 0x040060D2 RID: 24786
		private static readonly System.IntPtr NativeMethodInfoPtr_StopTextOverride_Public_Void_0;

		// Token: 0x040060D3 RID: 24787
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040060D4 RID: 24788
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040060D5 RID: 24789
		private static readonly System.IntPtr NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0;

		// Token: 0x040060D6 RID: 24790
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0;

		// Token: 0x040060D7 RID: 24791
		private static readonly System.IntPtr NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0;

		// Token: 0x040060D8 RID: 24792
		private static readonly System.IntPtr NativeMethodInfoPtr_EndDialogue_Public_Void_0;

		// Token: 0x040060D9 RID: 24793
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x040060DA RID: 24794
		private static readonly System.IntPtr NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0;

		// Token: 0x040060DB RID: 24795
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040060DC RID: 24796
		private static readonly System.IntPtr NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0;

		// Token: 0x02000B6A RID: 2922
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<ChoiceSelectionResidual>d__23")]
		public sealed class _ChoiceSelectionResidual_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600DC37 RID: 56375 RVA: 0x003485FC File Offset: 0x003467FC
			// Note: this type is marked as 'beforefieldinit'.
			static _ChoiceSelectionResidual_d__23()
			{
				Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<ChoiceSelectionResidual>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>1__state");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>2__current");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "fadeTime");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "choice");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>4__this");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<realFadeTime>5__2");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<i>5__3");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100681125);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100681126);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100681127);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100681128);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100681129);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100681130);
			}

			// Token: 0x0600DC38 RID: 56376 RVA: 0x0034872C File Offset: 0x0034692C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChoiceSelectionResidual_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC39 RID: 56377 RVA: 0x00348774 File Offset: 0x00346974
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC3A RID: 56378 RVA: 0x003487A8 File Offset: 0x003469A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260488, XrefRangeEnd = 260500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170043F1 RID: 17393
			// (get) Token: 0x0600DC3B RID: 56379 RVA: 0x003487E4 File Offset: 0x003469E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC3C RID: 56380 RVA: 0x00348824 File Offset: 0x00346A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260500, XrefRangeEnd = 260505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170043F2 RID: 17394
			// (get) Token: 0x0600DC3D RID: 56381 RVA: 0x00348858 File Offset: 0x00346A58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC3E RID: 56382 RVA: 0x0006ADBF File Offset: 0x00068FBF
			public _ChoiceSelectionResidual_d__23(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043EA RID: 17386
			// (get) Token: 0x0600DC3F RID: 56383 RVA: 0x00348898 File Offset: 0x00346A98
			// (set) Token: 0x0600DC40 RID: 56384 RVA: 0x0006ADC8 File Offset: 0x00068FC8
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043EB RID: 17387
			// (get) Token: 0x0600DC41 RID: 56385 RVA: 0x003488C0 File Offset: 0x00346AC0
			// (set) Token: 0x0600DC42 RID: 56386 RVA: 0x0006ADE3 File Offset: 0x00068FE3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EC RID: 17388
			// (get) Token: 0x0600DC43 RID: 56387 RVA: 0x003488F0 File Offset: 0x00346AF0
			// (set) Token: 0x0600DC44 RID: 56388 RVA: 0x0006AE02 File Offset: 0x00069002
			public unsafe float fadeTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x170043ED RID: 17389
			// (get) Token: 0x0600DC45 RID: 56389 RVA: 0x00348918 File Offset: 0x00346B18
			// (set) Token: 0x0600DC46 RID: 56390 RVA: 0x0006AE1D File Offset: 0x0006901D
			public unsafe DialogueChoiceEntry choice
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChoiceEntry>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EE RID: 17390
			// (get) Token: 0x0600DC47 RID: 56391 RVA: 0x00348948 File Offset: 0x00346B48
			// (set) Token: 0x0600DC48 RID: 56392 RVA: 0x0006AE3C File Offset: 0x0006903C
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EF RID: 17391
			// (get) Token: 0x0600DC49 RID: 56393 RVA: 0x00348978 File Offset: 0x00346B78
			// (set) Token: 0x0600DC4A RID: 56394 RVA: 0x0006AE5B File Offset: 0x0006905B
			public unsafe float _realFadeTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2)) = value;
				}
			}

			// Token: 0x170043F0 RID: 17392
			// (get) Token: 0x0600DC4B RID: 56395 RVA: 0x003489A0 File Offset: 0x00346BA0
			// (set) Token: 0x0600DC4C RID: 56396 RVA: 0x0006AE76 File Offset: 0x00069076
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009424 RID: 37924
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009425 RID: 37925
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009426 RID: 37926
			private static readonly System.IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04009427 RID: 37927
			private static readonly System.IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04009428 RID: 37928
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009429 RID: 37929
			private static readonly System.IntPtr NativeFieldInfoPtr__realFadeTime_5__2;

			// Token: 0x0400942A RID: 37930
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400942B RID: 37931
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400942C RID: 37932
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942D RID: 37933
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400942E RID: 37934
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400942F RID: 37935
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009430 RID: 37936
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6B RID: 2923
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<RolloutDialogue>d__21")]
		public sealed class _RolloutDialogue_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600DC4D RID: 56397 RVA: 0x003489C8 File Offset: 0x00346BC8
			// Note: this type is marked as 'beforefieldinit'.
			static _RolloutDialogue_d__21()
			{
				Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<RolloutDialogue>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr);
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>1__state");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>2__current");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>4__this");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "text");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "choices");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<activeDialogueChoices>5__2");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<rolloutTime>5__3");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<i>5__4");
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100681131);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100681132);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100681133);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100681134);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100681135);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100681136);
			}

			// Token: 0x0600DC4E RID: 56398 RVA: 0x00348B0C File Offset: 0x00346D0C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RolloutDialogue_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC4F RID: 56399 RVA: 0x00348B54 File Offset: 0x00346D54
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC50 RID: 56400 RVA: 0x00348B88 File Offset: 0x00346D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260505, XrefRangeEnd = 260551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170043FB RID: 17403
			// (get) Token: 0x0600DC51 RID: 56401 RVA: 0x00348BC4 File Offset: 0x00346DC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC52 RID: 56402 RVA: 0x00348C04 File Offset: 0x00346E04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260551, XrefRangeEnd = 260556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170043FC RID: 17404
			// (get) Token: 0x0600DC53 RID: 56403 RVA: 0x00348C38 File Offset: 0x00346E38
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DC54 RID: 56404 RVA: 0x0006AE91 File Offset: 0x00069091
			public _RolloutDialogue_d__21(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F3 RID: 17395
			// (get) Token: 0x0600DC55 RID: 56405 RVA: 0x00348C78 File Offset: 0x00346E78
			// (set) Token: 0x0600DC56 RID: 56406 RVA: 0x0006AE9A File Offset: 0x0006909A
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043F4 RID: 17396
			// (get) Token: 0x0600DC57 RID: 56407 RVA: 0x00348CA0 File Offset: 0x00346EA0
			// (set) Token: 0x0600DC58 RID: 56408 RVA: 0x0006AEB5 File Offset: 0x000690B5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F5 RID: 17397
			// (get) Token: 0x0600DC59 RID: 56409 RVA: 0x00348CD0 File Offset: 0x00346ED0
			// (set) Token: 0x0600DC5A RID: 56410 RVA: 0x0006AED4 File Offset: 0x000690D4
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F6 RID: 17398
			// (get) Token: 0x0600DC5B RID: 56411 RVA: 0x00348D00 File Offset: 0x00346F00
			// (set) Token: 0x0600DC5C RID: 56412 RVA: 0x0006AEF3 File Offset: 0x000690F3
			public unsafe string text
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170043F7 RID: 17399
			// (get) Token: 0x0600DC5D RID: 56413 RVA: 0x00348D28 File Offset: 0x00346F28
			// (set) Token: 0x0600DC5E RID: 56414 RVA: 0x0006AF12 File Offset: 0x00069112
			public unsafe List<string> choices
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F8 RID: 17400
			// (get) Token: 0x0600DC5F RID: 56415 RVA: 0x00348D58 File Offset: 0x00346F58
			// (set) Token: 0x0600DC60 RID: 56416 RVA: 0x0006AF31 File Offset: 0x00069131
			public unsafe List<int> _activeDialogueChoices_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F9 RID: 17401
			// (get) Token: 0x0600DC61 RID: 56417 RVA: 0x00348D88 File Offset: 0x00346F88
			// (set) Token: 0x0600DC62 RID: 56418 RVA: 0x0006AF50 File Offset: 0x00069150
			public unsafe float _rolloutTime_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3)) = value;
				}
			}

			// Token: 0x170043FA RID: 17402
			// (get) Token: 0x0600DC63 RID: 56419 RVA: 0x00348DB0 File Offset: 0x00346FB0
			// (set) Token: 0x0600DC64 RID: 56420 RVA: 0x0006AF6B File Offset: 0x0006916B
			public unsafe float _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04009431 RID: 37937
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009432 RID: 37938
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009433 RID: 37939
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009434 RID: 37940
			private static readonly System.IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04009435 RID: 37941
			private static readonly System.IntPtr NativeFieldInfoPtr_choices;

			// Token: 0x04009436 RID: 37942
			private static readonly System.IntPtr NativeFieldInfoPtr__activeDialogueChoices_5__2;

			// Token: 0x04009437 RID: 37943
			private static readonly System.IntPtr NativeFieldInfoPtr__rolloutTime_5__3;

			// Token: 0x04009438 RID: 37944
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04009439 RID: 37945
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400943A RID: 37946
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400943B RID: 37947
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400943C RID: 37948
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400943D RID: 37949
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400943E RID: 37950
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
