using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200045E RID: 1118
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x060060BC RID: 24764 RVA: 0x001BE804 File Offset: 0x001BCA04
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler()
		{
			Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr);
			DialogueHandler.NativeFieldInfoPtr_TimePerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TimePerChar");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMinDuration");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMaxDuration");
			DialogueHandler.NativeFieldInfoPtr_activeDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "activeDialogue");
			DialogueHandler.NativeFieldInfoPtr_activeDialogueNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "activeDialogueNode");
			DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "Database");
			DialogueHandler.NativeFieldInfoPtr_LookPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "LookPosition");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceRend");
			DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<NPC>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_VOEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "VOEmitter");
			DialogueHandler.NativeFieldInfoPtr_CurrentChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "CurrentChoices");
			DialogueHandler.NativeFieldInfoPtr_DialogueEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "DialogueEvents");
			DialogueHandler.NativeFieldInfoPtr_onConversationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onConversationStart");
			DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueNodeDisplayed");
			DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueChoiceChosen");
			DialogueHandler.NativeFieldInfoPtr_overrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "overrideText");
			DialogueHandler.NativeFieldInfoPtr_dialogueContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "dialogueContainers");
			DialogueHandler.NativeFieldInfoPtr_TempLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TempLinks");
			DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "skipNextDialogueBehaviourEnd");
			DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<runtimeModules>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_passChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "passChecked");
			DialogueHandler.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675711);
			DialogueHandler.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675712);
			DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675713);
			DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675714);
			DialogueHandler.NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675715);
			DialogueHandler.NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675716);
			DialogueHandler.NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675717);
			DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675718);
			DialogueHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675719);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675720);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675721);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675722);
			DialogueHandler.NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675723);
			DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675724);
			DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675725);
			DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675726);
			DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675727);
			DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675728);
			DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675729);
			DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675730);
			DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675731);
			DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675732);
			DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675733);
			DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675734);
			DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675735);
			DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675736);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675737);
			DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675738);
			DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675739);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675740);
			DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675741);
			DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675742);
			DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675743);
			DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675744);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675745);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675746);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675747);
			DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675748);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675749);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675750);
			DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675751);
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x060060BD RID: 24765 RVA: 0x001BED20 File Offset: 0x001BCF20
		// (set) Token: 0x060060BE RID: 24766 RVA: 0x001BED5C File Offset: 0x001BCF5C
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x060060BF RID: 24767 RVA: 0x001BED9C File Offset: 0x001BCF9C
		// (set) Token: 0x060060C0 RID: 24768 RVA: 0x001BEDDC File Offset: 0x001BCFDC
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x060060C1 RID: 24769 RVA: 0x001BEE20 File Offset: 0x001BD020
		public unsafe DialogueCanvas canvas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 202175, RefRangeEnd = 202177, XrefRangeStart = 202172, XrefRangeEnd = 202175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x060060C2 RID: 24770 RVA: 0x001BEE60 File Offset: 0x001BD060
		// (set) Token: 0x060060C3 RID: 24771 RVA: 0x001BEEA0 File Offset: 0x001BD0A0
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x001BEEE4 File Offset: 0x001BD0E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202201, RefRangeEnd = 202203, XrefRangeStart = 202177, XrefRangeEnd = 202201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x001BEF20 File Offset: 0x001BD120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202203, XrefRangeEnd = 202238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x001BEF5C File Offset: 0x001BD15C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202241, RefRangeEnd = 202243, XrefRangeStart = 202238, XrefRangeEnd = 202241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x001BEFA0 File Offset: 0x001BD1A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 202273, RefRangeEnd = 202277, XrefRangeStart = 202243, XrefRangeEnd = 202273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogueContainer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x001BF004 File Offset: 0x001BD204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202299, RefRangeEnd = 202300, XrefRangeStart = 202277, XrefRangeEnd = 202299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueContainerName);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x001BF068 File Offset: 0x001BD268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202300, XrefRangeEnd = 202305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeginConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x001BF0B0 File Offset: 0x001BD2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202305, XrefRangeEnd = 202309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideShownDialogue(string _overrideText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_overrideText);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x001BF0F4 File Offset: 0x001BD2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202309, XrefRangeEnd = 202317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x001BF128 File Offset: 0x001BD328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202317, XrefRangeEnd = 202341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x001BF164 File Offset: 0x001BD364
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 202341, RefRangeEnd = 202345, XrefRangeStart = 202341, XrefRangeEnd = 202341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipNextDialogueBehaviourEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x001BF198 File Offset: 0x001BD398
		[CallerCount(0)]
		public unsafe virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x001BF1F4 File Offset: 0x001BD3F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 202400, RefRangeEnd = 202407, XrefRangeStart = 202345, XrefRangeEnd = 202400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowNode(DialogueNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x001BF238 File Offset: 0x001BD438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202429, RefRangeEnd = 202431, XrefRangeStart = 202407, XrefRangeEnd = 202429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateBranch(BranchNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x001BF27C File Offset: 0x001BD47C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202440, RefRangeEnd = 202441, XrefRangeStart = 202431, XrefRangeEnd = 202440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref choiceIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x001BF2BC File Offset: 0x001BD4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202444, RefRangeEnd = 202445, XrefRangeStart = 202441, XrefRangeEnd = 202444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueSubmitted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x001BF2F0 File Offset: 0x001BD4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202445, XrefRangeEnd = 202452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			invalidReason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x001BF364 File Offset: 0x001BD564
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x001BF3BC File Offset: 0x001BD5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202452, XrefRangeEnd = 202470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x001BF414 File Offset: 0x001BD614
		[CallerCount(0)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x001BF47C File Offset: 0x001BD67C
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x001BF4E4 File Offset: 0x001BD6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202470, XrefRangeEnd = 202473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x001BF534 File Offset: 0x001BD734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202486, RefRangeEnd = 202488, XrefRangeStart = 202473, XrefRangeEnd = 202486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DialogueCallback(string dialogueLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x001BF584 File Offset: 0x001BD784
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			existingChoices = ((intPtr3 == 0) ? null : new List<DialogueChoiceData>(intPtr3));
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x001BF5F8 File Offset: 0x001BD7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202488, XrefRangeEnd = 202498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseNodeGUID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseOptionGUID);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNodeGUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x001BF660 File Offset: 0x001BD860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 202528, RefRangeEnd = 202531, XrefRangeStart = 202498, XrefRangeEnd = 202528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr2) : null;
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x001BF6B0 File Offset: 0x001BD8B0
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x001BF6EC File Offset: 0x001BD8EC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x001BF728 File Offset: 0x001BD928
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Local(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x001BF778 File Offset: 0x001BD978
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Networked(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x001BF7C8 File Offset: 0x001BD9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202531, XrefRangeEnd = 202537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayReaction(string key, float duration, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x001BF834 File Offset: 0x001BDA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202537, XrefRangeEnd = 202539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideWorldspaceDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x001BF870 File Offset: 0x001BDA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202539, XrefRangeEnd = 202541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowWorldspaceDialogue(string text, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x001BF8CC File Offset: 0x001BDACC
		[CallerCount(0)]
		public unsafe virtual void ShowWorldspaceDialogue_5s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x001BF91C File Offset: 0x001BDB1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 202573, RefRangeEnd = 202578, XrefRangeStart = 202541, XrefRangeEnd = 202573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x0002D638 File Offset: 0x0002B838
		public DialogueHandler(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x001BF958 File Offset: 0x001BDB58
		// (set) Token: 0x060060E8 RID: 24808 RVA: 0x0002D641 File Offset: 0x0002B841
		public unsafe static float TimePerChar
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&value));
			}
		}

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x001BF974 File Offset: 0x001BDB74
		// (set) Token: 0x060060EA RID: 24810 RVA: 0x0002D64F File Offset: 0x0002B84F
		public unsafe static float WorldspaceDialogueMinDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&value));
			}
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x060060EB RID: 24811 RVA: 0x001BF990 File Offset: 0x001BDB90
		// (set) Token: 0x060060EC RID: 24812 RVA: 0x0002D65D File Offset: 0x0002B85D
		public unsafe static float WorldspaceDialogueMaxDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&value));
			}
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x060060ED RID: 24813 RVA: 0x001BF9AC File Offset: 0x001BDBAC
		// (set) Token: 0x060060EE RID: 24814 RVA: 0x0002D66B File Offset: 0x0002B86B
		public unsafe static DialogueContainer activeDialogue
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_activeDialogue, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_activeDialogue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x001BF9D4 File Offset: 0x001BDBD4
		// (set) Token: 0x060060F0 RID: 24816 RVA: 0x0002D67D File Offset: 0x0002B87D
		public unsafe static DialogueNodeData activeDialogueNode
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_activeDialogueNode, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_activeDialogueNode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x060060F1 RID: 24817 RVA: 0x001BF9FC File Offset: 0x001BDBFC
		// (set) Token: 0x060060F2 RID: 24818 RVA: 0x0002D68F File Offset: 0x0002B88F
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x060060F3 RID: 24819 RVA: 0x001BFA24 File Offset: 0x001BDC24
		// (set) Token: 0x060060F4 RID: 24820 RVA: 0x0002D6AA File Offset: 0x0002B8AA
		public unsafe DialogueDatabase Database
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_Database);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x060060F5 RID: 24821 RVA: 0x001BFA54 File Offset: 0x001BDC54
		// (set) Token: 0x060060F6 RID: 24822 RVA: 0x0002D6C9 File Offset: 0x0002B8C9
		public unsafe Transform LookPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x060060F7 RID: 24823 RVA: 0x001BFA84 File Offset: 0x001BDC84
		// (set) Token: 0x060060F8 RID: 24824 RVA: 0x0002D6E8 File Offset: 0x0002B8E8
		public unsafe WorldspaceDialogueRenderer WorldspaceRend
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x001BFAB4 File Offset: 0x001BDCB4
		// (set) Token: 0x060060FA RID: 24826 RVA: 0x0002D707 File Offset: 0x0002B907
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x060060FB RID: 24827 RVA: 0x001BFAE4 File Offset: 0x001BDCE4
		// (set) Token: 0x060060FC RID: 24828 RVA: 0x0002D726 File Offset: 0x0002B926
		public unsafe VOEmitter VOEmitter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_VOEmitter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VOEmitter>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_VOEmitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x001BFB14 File Offset: 0x001BDD14
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x0002D745 File Offset: 0x0002B945
		public unsafe List<DialogueChoiceData> CurrentChoices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x001BFB44 File Offset: 0x001BDD44
		// (set) Token: 0x06006100 RID: 24832 RVA: 0x0002D764 File Offset: 0x0002B964
		public unsafe Il2CppReferenceArray<DialogueEvent> DialogueEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueEvent>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x001BFB74 File Offset: 0x001BDD74
		// (set) Token: 0x06006102 RID: 24834 RVA: 0x0002D783 File Offset: 0x0002B983
		public unsafe UnityEvent onConversationStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEB RID: 7403
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x001BFBA4 File Offset: 0x001BDDA4
		// (set) Token: 0x06006104 RID: 24836 RVA: 0x0002D7A2 File Offset: 0x0002B9A2
		public unsafe UnityEvent<string> onDialogueNodeDisplayed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x001BFBD4 File Offset: 0x001BDDD4
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x0002D7C1 File Offset: 0x0002B9C1
		public unsafe UnityEvent<string> onDialogueChoiceChosen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x06006107 RID: 24839 RVA: 0x001BFC04 File Offset: 0x001BDE04
		// (set) Token: 0x06006108 RID: 24840 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		public unsafe string overrideText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_overrideText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_overrideText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x06006109 RID: 24841 RVA: 0x001BFC2C File Offset: 0x001BDE2C
		// (set) Token: 0x0600610A RID: 24842 RVA: 0x0002D7FF File Offset: 0x0002B9FF
		public unsafe List<DialogueContainer> dialogueContainers
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueContainer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CEF RID: 7407
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x001BFC5C File Offset: 0x001BDE5C
		// (set) Token: 0x0600610C RID: 24844 RVA: 0x0002D81E File Offset: 0x0002BA1E
		public unsafe List<NodeLinkData> TempLinks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_TempLinks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_TempLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF0 RID: 7408
		// (get) Token: 0x0600610D RID: 24845 RVA: 0x001BFC8C File Offset: 0x001BDE8C
		// (set) Token: 0x0600610E RID: 24846 RVA: 0x0002D83D File Offset: 0x0002BA3D
		public unsafe bool skipNextDialogueBehaviourEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd)) = value;
			}
		}

		// Token: 0x17001CF1 RID: 7409
		// (get) Token: 0x0600610F RID: 24847 RVA: 0x001BFCB4 File Offset: 0x001BDEB4
		// (set) Token: 0x06006110 RID: 24848 RVA: 0x0002D858 File Offset: 0x0002BA58
		public unsafe List<DialogueModule> _runtimeModules_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CF2 RID: 7410
		// (get) Token: 0x06006111 RID: 24849 RVA: 0x001BFCE4 File Offset: 0x001BDEE4
		// (set) Token: 0x06006112 RID: 24850 RVA: 0x0002D877 File Offset: 0x0002BA77
		public unsafe bool passChecked
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked)) = value;
			}
		}

		// Token: 0x04004222 RID: 16930
		private static readonly System.IntPtr NativeFieldInfoPtr_TimePerChar;

		// Token: 0x04004223 RID: 16931
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceDialogueMinDuration;

		// Token: 0x04004224 RID: 16932
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceDialogueMaxDuration;

		// Token: 0x04004225 RID: 16933
		private static readonly System.IntPtr NativeFieldInfoPtr_activeDialogue;

		// Token: 0x04004226 RID: 16934
		private static readonly System.IntPtr NativeFieldInfoPtr_activeDialogueNode;

		// Token: 0x04004227 RID: 16935
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04004228 RID: 16936
		private static readonly System.IntPtr NativeFieldInfoPtr_Database;

		// Token: 0x04004229 RID: 16937
		private static readonly System.IntPtr NativeFieldInfoPtr_LookPosition;

		// Token: 0x0400422A RID: 16938
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldspaceRend;

		// Token: 0x0400422B RID: 16939
		private static readonly System.IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x0400422C RID: 16940
		private static readonly System.IntPtr NativeFieldInfoPtr_VOEmitter;

		// Token: 0x0400422D RID: 16941
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentChoices;

		// Token: 0x0400422E RID: 16942
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueEvents;

		// Token: 0x0400422F RID: 16943
		private static readonly System.IntPtr NativeFieldInfoPtr_onConversationStart;

		// Token: 0x04004230 RID: 16944
		private static readonly System.IntPtr NativeFieldInfoPtr_onDialogueNodeDisplayed;

		// Token: 0x04004231 RID: 16945
		private static readonly System.IntPtr NativeFieldInfoPtr_onDialogueChoiceChosen;

		// Token: 0x04004232 RID: 16946
		private static readonly System.IntPtr NativeFieldInfoPtr_overrideText;

		// Token: 0x04004233 RID: 16947
		private static readonly System.IntPtr NativeFieldInfoPtr_dialogueContainers;

		// Token: 0x04004234 RID: 16948
		private static readonly System.IntPtr NativeFieldInfoPtr_TempLinks;

		// Token: 0x04004235 RID: 16949
		private static readonly System.IntPtr NativeFieldInfoPtr_skipNextDialogueBehaviourEnd;

		// Token: 0x04004236 RID: 16950
		private static readonly System.IntPtr NativeFieldInfoPtr__runtimeModules_k__BackingField;

		// Token: 0x04004237 RID: 16951
		private static readonly System.IntPtr NativeFieldInfoPtr_passChecked;

		// Token: 0x04004238 RID: 16952
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004239 RID: 16953
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x0400423A RID: 16954
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x0400423B RID: 16955
		private static readonly System.IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x0400423C RID: 16956
		private static readonly System.IntPtr NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0;

		// Token: 0x0400423D RID: 16957
		private static readonly System.IntPtr NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0;

		// Token: 0x0400423E RID: 16958
		private static readonly System.IntPtr NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0;

		// Token: 0x0400423F RID: 16959
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004240 RID: 16960
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004241 RID: 16961
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0;

		// Token: 0x04004242 RID: 16962
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0;

		// Token: 0x04004243 RID: 16963
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0;

		// Token: 0x04004244 RID: 16964
		private static readonly System.IntPtr NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0;

		// Token: 0x04004245 RID: 16965
		private static readonly System.IntPtr NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0;

		// Token: 0x04004246 RID: 16966
		private static readonly System.IntPtr NativeMethodInfoPtr_StopOverride_Public_Void_0;

		// Token: 0x04004247 RID: 16967
		private static readonly System.IntPtr NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0;

		// Token: 0x04004248 RID: 16968
		private static readonly System.IntPtr NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0;

		// Token: 0x04004249 RID: 16969
		private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0;

		// Token: 0x0400424A RID: 16970
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0;

		// Token: 0x0400424B RID: 16971
		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0;

		// Token: 0x0400424C RID: 16972
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x0400424D RID: 16973
		private static readonly System.IntPtr NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0;

		// Token: 0x0400424E RID: 16974
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x0400424F RID: 16975
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04004250 RID: 16976
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0;

		// Token: 0x04004251 RID: 16977
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x04004252 RID: 16978
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x04004253 RID: 16979
		private static readonly System.IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x04004254 RID: 16980
		private static readonly System.IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x04004255 RID: 16981
		private static readonly System.IntPtr NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04004256 RID: 16982
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0;

		// Token: 0x04004257 RID: 16983
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0;

		// Token: 0x04004258 RID: 16984
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04004259 RID: 16985
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x0400425A RID: 16986
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0;

		// Token: 0x0400425B RID: 16987
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0;

		// Token: 0x0400425C RID: 16988
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0;

		// Token: 0x0400425D RID: 16989
		private static readonly System.IntPtr NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0;

		// Token: 0x0400425E RID: 16990
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0;

		// Token: 0x0400425F RID: 16991
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0;

		// Token: 0x04004260 RID: 16992
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A4A RID: 2634
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D35F RID: 54111 RVA: 0x0032F9AC File Offset: 0x0032DBAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "npc");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "dialogueContainer");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "entryNodeLabel");
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675752);
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675753);
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675754);
			}

			// Token: 0x0600D360 RID: 54112 RVA: 0x0032FA64 File Offset: 0x0032DC64
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D361 RID: 54113 RVA: 0x0032FAA0 File Offset: 0x0032DCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202132, XrefRangeEnd = 202137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D362 RID: 54114 RVA: 0x0032FAE0 File Offset: 0x0032DCE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 202166, RefRangeEnd = 202167, XrefRangeStart = 202137, XrefRangeEnd = 202166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D363 RID: 54115 RVA: 0x0006680D File Offset: 0x00064A0D
			public __c__DisplayClass35_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004179 RID: 16761
			// (get) Token: 0x0600D364 RID: 54116 RVA: 0x0032FB14 File Offset: 0x0032DD14
			// (set) Token: 0x0600D365 RID: 54117 RVA: 0x00066816 File Offset: 0x00064A16
			public unsafe NPC npc
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700417A RID: 16762
			// (get) Token: 0x0600D366 RID: 54118 RVA: 0x0032FB44 File Offset: 0x0032DD44
			// (set) Token: 0x0600D367 RID: 54119 RVA: 0x00066835 File Offset: 0x00064A35
			public unsafe DialogueHandler __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700417B RID: 16763
			// (get) Token: 0x0600D368 RID: 54120 RVA: 0x0032FB74 File Offset: 0x0032DD74
			// (set) Token: 0x0600D369 RID: 54121 RVA: 0x00066854 File Offset: 0x00064A54
			public unsafe DialogueContainer dialogueContainer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700417C RID: 16764
			// (get) Token: 0x0600D36A RID: 54122 RVA: 0x0032FBA4 File Offset: 0x0032DDA4
			// (set) Token: 0x0600D36B RID: 54123 RVA: 0x00066873 File Offset: 0x00064A73
			public unsafe string entryNodeLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EC1 RID: 36545
			private static readonly System.IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04008EC2 RID: 36546
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EC3 RID: 36547
			private static readonly System.IntPtr NativeFieldInfoPtr_dialogueContainer;

			// Token: 0x04008EC4 RID: 36548
			private static readonly System.IntPtr NativeFieldInfoPtr_entryNodeLabel;

			// Token: 0x04008EC5 RID: 36549
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EC6 RID: 36550
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008EC7 RID: 36551
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000CB0 RID: 3248
			[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass35_0+<<InitializeDialogue>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E8EE RID: 59630 RVA: 0x0036CC78 File Offset: 0x0036AE78
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "<<InitializeDialogue>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675755);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675756);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675757);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675758);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675759);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675760);
				}

				// Token: 0x0600E8EF RID: 59631 RVA: 0x0036CD58 File Offset: 0x0036AF58
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8F0 RID: 59632 RVA: 0x0036CDA0 File Offset: 0x0036AFA0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8F1 RID: 59633 RVA: 0x0036CDD4 File Offset: 0x0036AFD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202122, XrefRangeEnd = 202127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047F4 RID: 18420
				// (get) Token: 0x0600E8F2 RID: 59634 RVA: 0x0036CE10 File Offset: 0x0036B010
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8F3 RID: 59635 RVA: 0x0036CE50 File Offset: 0x0036B050
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202127, XrefRangeEnd = 202132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047F5 RID: 18421
				// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x0036CE84 File Offset: 0x0036B084
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E8F5 RID: 59637 RVA: 0x00071380 File Offset: 0x0006F580
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047F1 RID: 18417
				// (get) Token: 0x0600E8F6 RID: 59638 RVA: 0x0036CEC4 File Offset: 0x0036B0C4
				// (set) Token: 0x0600E8F7 RID: 59639 RVA: 0x00071389 File Offset: 0x0006F589
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047F2 RID: 18418
				// (get) Token: 0x0600E8F8 RID: 59640 RVA: 0x0036CEEC File Offset: 0x0036B0EC
				// (set) Token: 0x0600E8F9 RID: 59641 RVA: 0x000713A4 File Offset: 0x0006F5A4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047F3 RID: 18419
				// (get) Token: 0x0600E8FA RID: 59642 RVA: 0x0036CF1C File Offset: 0x0036B11C
				// (set) Token: 0x0600E8FB RID: 59643 RVA: 0x000713C3 File Offset: 0x0006F5C3
				public unsafe DialogueHandler.__c__DisplayClass35_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009BEB RID: 39915
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BEC RID: 39916
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BED RID: 39917
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BEE RID: 39918
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BEF RID: 39919
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BF0 RID: 39920
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BF1 RID: 39921
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BF2 RID: 39922
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BF3 RID: 39923
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A4B RID: 2635
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D36C RID: 54124 RVA: 0x0032FBCC File Offset: 0x0032DDCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, "dialogueContainerName");
				DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, 100675761);
				DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, 100675762);
			}

			// Token: 0x0600D36D RID: 54125 RVA: 0x0032FC34 File Offset: 0x0032DE34
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D36E RID: 54126 RVA: 0x0032FC70 File Offset: 0x0032DE70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202167, XrefRangeEnd = 202172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeDialogue_b__0(DialogueContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D36F RID: 54127 RVA: 0x00066892 File Offset: 0x00064A92
			public __c__DisplayClass36_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700417D RID: 16765
			// (get) Token: 0x0600D370 RID: 54128 RVA: 0x0032FCC0 File Offset: 0x0032DEC0
			// (set) Token: 0x0600D371 RID: 54129 RVA: 0x0006689B File Offset: 0x00064A9B
			public unsafe string dialogueContainerName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008EC8 RID: 36552
			private static readonly System.IntPtr NativeFieldInfoPtr_dialogueContainerName;

			// Token: 0x04008EC9 RID: 36553
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ECA RID: 36554
			private static readonly System.IntPtr NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0;
		}

		// Token: 0x02000A4C RID: 2636
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D372 RID: 54130 RVA: 0x0032FCE8 File Offset: 0x0032DEE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, 100675763);
				DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, 100675764);
			}

			// Token: 0x0600D373 RID: 54131 RVA: 0x0032FD50 File Offset: 0x0032DF50
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D374 RID: 54132 RVA: 0x0032FD8C File Offset: 0x0032DF8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D375 RID: 54133 RVA: 0x000668BA File Offset: 0x00064ABA
			public __c__DisplayClass57_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700417E RID: 16766
			// (get) Token: 0x0600D376 RID: 54134 RVA: 0x0032FDDC File Offset: 0x0032DFDC
			// (set) Token: 0x0600D377 RID: 54135 RVA: 0x000668C3 File Offset: 0x00064AC3
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008ECB RID: 36555
			private static readonly System.IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04008ECC RID: 36556
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008ECD RID: 36557
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}
	}
}
