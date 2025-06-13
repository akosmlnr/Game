using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000396 RID: 918
	[System.Serializable]
	public class MSGConversation : Il2CppSystem.Object
	{
		// Token: 0x0600469C RID: 18076 RVA: 0x0015DBE0 File Offset: 0x0015BDE0
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversation()
		{
			Il2CppClassPointerStore<MSGConversation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "MSGConversation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr);
			MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "MAX_MESSAGE_HISTORY");
			MSGConversation.NativeFieldInfoPtr_contactName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "contactName");
			MSGConversation.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sender");
			MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<IsSenderKnown>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_messageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageHistory");
			MSGConversation.NativeFieldInfoPtr_messageChainHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageChainHistory");
			MSGConversation.NativeFieldInfoPtr_bubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbles");
			MSGConversation.NativeFieldInfoPtr_Sendables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Sendables");
			MSGConversation.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "read");
			MSGConversation.NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<index>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<isOpen>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<rollingOut>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<EntryVisible>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Categories");
			MSGConversation.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entry");
			MSGConversation.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "container");
			MSGConversation.NativeFieldInfoPtr_bubbleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbleContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRectContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRectContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRect");
			MSGConversation.NativeFieldInfoPtr_entryPreviewText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entryPreviewText");
			MSGConversation.NativeFieldInfoPtr_unreadDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "unreadDot");
			MSGConversation.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "slider");
			MSGConversation.NativeFieldInfoPtr_sliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sliderFill");
			MSGConversation.NativeFieldInfoPtr_responseContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseContainer");
			MSGConversation.NativeFieldInfoPtr_senderInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "senderInterface");
			MSGConversation.NativeFieldInfoPtr_uiCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "uiCreated");
			MSGConversation.NativeFieldInfoPtr_onMessageRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onMessageRendered");
			MSGConversation.NativeFieldInfoPtr_onLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onLoaded");
			MSGConversation.NativeFieldInfoPtr_onResponsesShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onResponsesShown");
			MSGConversation.NativeFieldInfoPtr_currentResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "currentResponses");
			MSGConversation.NativeFieldInfoPtr_responseRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseRects");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<HasChanged>k__BackingField");
			MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672034);
			MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672035);
			MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672036);
			MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672037);
			MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672038);
			MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672039);
			MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672040);
			MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672041);
			MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672042);
			MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672043);
			MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672044);
			MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672045);
			MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672046);
			MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672047);
			MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672048);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672049);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672050);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672051);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672052);
			MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672053);
			MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672054);
			MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672055);
			MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672056);
			MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672057);
			MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672058);
			MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672059);
			MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672060);
			MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672061);
			MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672062);
			MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672063);
			MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672064);
			MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672065);
			MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672066);
			MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672067);
			MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672068);
			MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672069);
			MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672070);
			MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672071);
			MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672072);
			MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672073);
			MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672074);
			MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672075);
			MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672076);
			MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672077);
			MSGConversation.NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672078);
			MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672079);
			MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672080);
			MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672081);
			MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672082);
			MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672083);
			MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672084);
			MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672085);
			MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672086);
			MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672087);
			MSGConversation.NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672088);
			MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100672089);
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600469D RID: 18077 RVA: 0x0015E318 File Offset: 0x0015C518
		// (set) Token: 0x0600469E RID: 18078 RVA: 0x0015E354 File Offset: 0x0015C554
		public unsafe bool IsSenderKnown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600469F RID: 18079 RVA: 0x0015E394 File Offset: 0x0015C594
		// (set) Token: 0x060046A0 RID: 18080 RVA: 0x0015E3D0 File Offset: 0x0015C5D0
		public unsafe int index
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 51072, RefRangeEnd = 51083, XrefRangeStart = 51072, XrefRangeEnd = 51083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 51083, RefRangeEnd = 51092, XrefRangeStart = 51083, XrefRangeEnd = 51092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060046A1 RID: 18081 RVA: 0x0015E410 File Offset: 0x0015C610
		// (set) Token: 0x060046A2 RID: 18082 RVA: 0x0015E44C File Offset: 0x0015C64C
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x0015E48C File Offset: 0x0015C68C
		// (set) Token: 0x060046A4 RID: 18084 RVA: 0x0015E4C8 File Offset: 0x0015C6C8
		public unsafe bool rollingOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x0015E508 File Offset: 0x0015C708
		// (set) Token: 0x060046A6 RID: 18086 RVA: 0x0015E544 File Offset: 0x0015C744
		public unsafe bool EntryVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x0015E584 File Offset: 0x0015C784
		public unsafe bool AreResponsesActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161455, XrefRangeEnd = 161456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x0015E5C0 File Offset: 0x0015C7C0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161456, XrefRangeEnd = 161458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x0015E5F8 File Offset: 0x0015C7F8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161458, XrefRangeEnd = 161460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x0015E630 File Offset: 0x0015C830
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x0015E670 File Offset: 0x0015C870
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x0015E6AC File Offset: 0x0015C8AC
		// (set) Token: 0x060046AD RID: 18093 RVA: 0x0015E6EC File Offset: 0x0015C8EC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x0015E730 File Offset: 0x0015C930
		// (set) Token: 0x060046AF RID: 18095 RVA: 0x0015E770 File Offset: 0x0015C970
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161460, XrefRangeEnd = 161461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x0015E7B4 File Offset: 0x0015C9B4
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x0015E7F0 File Offset: 0x0015C9F0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x0015E830 File Offset: 0x0015CA30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161541, RefRangeEnd = 161542, XrefRangeStart = 161461, XrefRangeEnd = 161541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversation(NPC _npc, string _contactName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_contactName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x0015E890 File Offset: 0x0015CA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161542, XrefRangeEnd = 161548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x0015E8CC File Offset: 0x0015CACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategories(List<EConversationCategory> cat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cat);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x0015E910 File Offset: 0x0015CB10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161565, RefRangeEnd = 161568, XrefRangeStart = 161548, XrefRangeEnd = 161565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToTop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x0015E944 File Offset: 0x0015CB44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 161693, RefRangeEnd = 161699, XrefRangeStart = 161568, XrefRangeEnd = 161693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x0015E978 File Offset: 0x0015CB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161699, XrefRangeEnd = 161700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureUIExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x0015E9AC File Offset: 0x0015CBAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161707, RefRangeEnd = 161710, XrefRangeStart = 161700, XrefRangeEnd = 161707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPreviewText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x0015E9E0 File Offset: 0x0015CBE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161722, RefRangeEnd = 161724, XrefRangeStart = 161710, XrefRangeEnd = 161722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x0015EA14 File Offset: 0x0015CC14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161748, RefRangeEnd = 161751, XrefRangeStart = 161724, XrefRangeEnd = 161748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsKnown(bool known)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref known;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x0015EA54 File Offset: 0x0015CC54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161751, XrefRangeEnd = 161752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x0015EA88 File Offset: 0x0015CC88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 161782, RefRangeEnd = 161787, XrefRangeStart = 161752, XrefRangeEnd = 161782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x0015EAC8 File Offset: 0x0015CCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161787, XrefRangeEnd = 161868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RenderMessage(Message m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x0015EB18 File Offset: 0x0015CD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161868, XrefRangeEnd = 161871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryVisibility(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref v;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x0015EB58 File Offset: 0x0015CD58
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 161902, RefRangeEnd = 161909, XrefRangeStart = 161871, XrefRangeEnd = 161902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRead(bool r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref r;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C0 RID: 18112 RVA: 0x0015EB98 File Offset: 0x0015CD98
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 161954, RefRangeEnd = 161963, XrefRangeStart = 161909, XrefRangeEnd = 161954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(Message message, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x0015EBF8 File Offset: 0x0015CDF8
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 161996, RefRangeEnd = 162017, XrefRangeStart = 161963, XrefRangeEnd = 161996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref notify;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x0015EC64 File Offset: 0x0015CE64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162073, RefRangeEnd = 162076, XrefRangeStart = 162017, XrefRangeEnd = 162073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversationData>(intPtr2) : null;
		}

		// Token: 0x060046C3 RID: 18115 RVA: 0x0015ECA4 File Offset: 0x0015CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162076, XrefRangeEnd = 162078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060046C4 RID: 18116 RVA: 0x0015ECE8 File Offset: 0x0015CEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162078, XrefRangeEnd = 162131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0015ED38 File Offset: 0x0015CF38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162137, RefRangeEnd = 162139, XrefRangeStart = 162131, XrefRangeEnd = 162137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValue(float value, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref color;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x0015ED84 File Offset: 0x0015CF84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162154, RefRangeEnd = 162155, XrefRangeStart = 162139, XrefRangeEnd = 162154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response GetResponse(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Response>(intPtr2) : null;
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0015EDD4 File Offset: 0x0015CFD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162182, RefRangeEnd = 162186, XrefRangeStart = 162155, XrefRangeEnd = 162182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_responses);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref showResponseDelay;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x0015EE34 File Offset: 0x0015D034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162237, RefRangeEnd = 162238, XrefRangeStart = 162186, XrefRangeEnd = 162237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateResponseUI(Response r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0015EE78 File Offset: 0x0015D078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162238, XrefRangeEnd = 162258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshResponseContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x0015EEAC File Offset: 0x0015D0AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162270, RefRangeEnd = 162273, XrefRangeStart = 162258, XrefRangeEnd = 162270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponseUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x0015EEE0 File Offset: 0x0015D0E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 162282, RefRangeEnd = 162287, XrefRangeStart = 162273, XrefRangeEnd = 162282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResponseContainerVisible(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref v;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x0015EF20 File Offset: 0x0015D120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162300, RefRangeEnd = 162302, XrefRangeStart = 162287, XrefRangeEnd = 162300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResponseChosen(Response r, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x0015EF70 File Offset: 0x0015D170
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 162311, RefRangeEnd = 162317, XrefRangeStart = 162302, XrefRangeEnd = 162311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponses(bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x0015EFB0 File Offset: 0x0015D1B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162336, RefRangeEnd = 162339, XrefRangeStart = 162317, XrefRangeEnd = 162336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage CreateSendableMessage(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr2) : null;
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x0015F000 File Offset: 0x0015D200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162343, RefRangeEnd = 162344, XrefRangeStart = 162339, XrefRangeEnd = 162343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x0015F05C File Offset: 0x0015D25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162344, XrefRangeEnd = 162349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderPlayerMessage(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x0015F0A0 File Offset: 0x0015D2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162349, XrefRangeEnd = 162361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSendLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x0015F0D4 File Offset: 0x0015D2D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162380, RefRangeEnd = 162382, XrefRangeStart = 162361, XrefRangeEnd = 162380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSendNewMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x0015F110 File Offset: 0x0015D310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162382, XrefRangeEnd = 162385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateUI_b__72_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x0015F144 File Offset: 0x0015D344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162385, XrefRangeEnd = 162390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x00022290 File Offset: 0x00020490
		public MSGConversation(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x0015F184 File Offset: 0x0015D384
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x00022299 File Offset: 0x00020499
		public unsafe static int MAX_MESSAGE_HISTORY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&value));
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x0015F1A0 File Offset: 0x0015D3A0
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x000222A7 File Offset: 0x000204A7
		public unsafe string contactName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x0015F1C8 File Offset: 0x0015D3C8
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x000222C6 File Offset: 0x000204C6
		public unsafe NPC sender
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x0015F1F8 File Offset: 0x0015D3F8
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x000222E5 File Offset: 0x000204E5
		public unsafe bool _IsSenderKnown_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField)) = value;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x0015F220 File Offset: 0x0015D420
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x00022300 File Offset: 0x00020500
		public unsafe List<Message> messageHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x0015F250 File Offset: 0x0015D450
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x0002231F File Offset: 0x0002051F
		public unsafe List<MessageChain> messageChainHistory
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageChain>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x0015F280 File Offset: 0x0015D480
		// (set) Token: 0x060046E3 RID: 18147 RVA: 0x0002233E File Offset: 0x0002053E
		public unsafe List<MessageBubble> bubbles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x0015F2B0 File Offset: 0x0015D4B0
		// (set) Token: 0x060046E5 RID: 18149 RVA: 0x0002235D File Offset: 0x0002055D
		public unsafe List<SendableMessage> Sendables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SendableMessage>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x0015F2E0 File Offset: 0x0015D4E0
		// (set) Token: 0x060046E7 RID: 18151 RVA: 0x0002237C File Offset: 0x0002057C
		public unsafe bool read
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_read)) = value;
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060046E8 RID: 18152 RVA: 0x0015F308 File Offset: 0x0015D508
		// (set) Token: 0x060046E9 RID: 18153 RVA: 0x00022397 File Offset: 0x00020597
		public unsafe int _index_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField)) = value;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x0015F330 File Offset: 0x0015D530
		// (set) Token: 0x060046EB RID: 18155 RVA: 0x000223B2 File Offset: 0x000205B2
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x0015F358 File Offset: 0x0015D558
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x000223CD File Offset: 0x000205CD
		public unsafe bool _rollingOut_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField)) = value;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x0015F380 File Offset: 0x0015D580
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x000223E8 File Offset: 0x000205E8
		public unsafe bool _EntryVisible_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x0015F3A8 File Offset: 0x0015D5A8
		// (set) Token: 0x060046F1 RID: 18161 RVA: 0x00022403 File Offset: 0x00020603
		public unsafe List<EConversationCategory> Categories
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EConversationCategory>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x0015F3D8 File Offset: 0x0015D5D8
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x00022422 File Offset: 0x00020622
		public unsafe RectTransform entry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x0015F408 File Offset: 0x0015D608
		// (set) Token: 0x060046F5 RID: 18165 RVA: 0x00022441 File Offset: 0x00020641
		public unsafe RectTransform container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x0015F438 File Offset: 0x0015D638
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x00022460 File Offset: 0x00020660
		public unsafe RectTransform bubbleContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x0015F468 File Offset: 0x0015D668
		// (set) Token: 0x060046F9 RID: 18169 RVA: 0x0002247F File Offset: 0x0002067F
		public unsafe RectTransform scrollRectContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x0015F498 File Offset: 0x0015D698
		// (set) Token: 0x060046FB RID: 18171 RVA: 0x0002249E File Offset: 0x0002069E
		public unsafe ScrollRect scrollRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x0015F4C8 File Offset: 0x0015D6C8
		// (set) Token: 0x060046FD RID: 18173 RVA: 0x000224BD File Offset: 0x000206BD
		public unsafe Text entryPreviewText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x0015F4F8 File Offset: 0x0015D6F8
		// (set) Token: 0x060046FF RID: 18175 RVA: 0x000224DC File Offset: 0x000206DC
		public unsafe RectTransform unreadDot
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x0015F528 File Offset: 0x0015D728
		// (set) Token: 0x06004701 RID: 18177 RVA: 0x000224FB File Offset: 0x000206FB
		public unsafe Slider slider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x0015F558 File Offset: 0x0015D758
		// (set) Token: 0x06004703 RID: 18179 RVA: 0x0002251A File Offset: 0x0002071A
		public unsafe Image sliderFill
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x0015F588 File Offset: 0x0015D788
		// (set) Token: 0x06004705 RID: 18181 RVA: 0x00022539 File Offset: 0x00020739
		public unsafe RectTransform responseContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x0015F5B8 File Offset: 0x0015D7B8
		// (set) Token: 0x06004707 RID: 18183 RVA: 0x00022558 File Offset: 0x00020758
		public unsafe MessageSenderInterface senderInterface
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x0015F5E8 File Offset: 0x0015D7E8
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x00022577 File Offset: 0x00020777
		public unsafe bool uiCreated
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated)) = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600470A RID: 18186 RVA: 0x0015F610 File Offset: 0x0015D810
		// (set) Token: 0x0600470B RID: 18187 RVA: 0x00022592 File Offset: 0x00020792
		public unsafe Il2CppSystem.Action onMessageRendered
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x0015F640 File Offset: 0x0015D840
		// (set) Token: 0x0600470D RID: 18189 RVA: 0x000225B1 File Offset: 0x000207B1
		public unsafe Il2CppSystem.Action onLoaded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x0015F670 File Offset: 0x0015D870
		// (set) Token: 0x0600470F RID: 18191 RVA: 0x000225D0 File Offset: 0x000207D0
		public unsafe Il2CppSystem.Action onResponsesShown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06004710 RID: 18192 RVA: 0x0015F6A0 File Offset: 0x0015D8A0
		// (set) Token: 0x06004711 RID: 18193 RVA: 0x000225EF File Offset: 0x000207EF
		public unsafe List<Response> currentResponses
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Response>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06004712 RID: 18194 RVA: 0x0015F6D0 File Offset: 0x0015D8D0
		// (set) Token: 0x06004713 RID: 18195 RVA: 0x0002260E File Offset: 0x0002080E
		public unsafe List<RectTransform> responseRects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06004714 RID: 18196 RVA: 0x0015F700 File Offset: 0x0015D900
		// (set) Token: 0x06004715 RID: 18197 RVA: 0x0002262D File Offset: 0x0002082D
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06004716 RID: 18198 RVA: 0x0015F730 File Offset: 0x0015D930
		// (set) Token: 0x06004717 RID: 18199 RVA: 0x0002264C File Offset: 0x0002084C
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06004718 RID: 18200 RVA: 0x0015F760 File Offset: 0x0015D960
		// (set) Token: 0x06004719 RID: 18201 RVA: 0x0002266B File Offset: 0x0002086B
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04002F56 RID: 12118
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_MESSAGE_HISTORY;

		// Token: 0x04002F57 RID: 12119
		private static readonly System.IntPtr NativeFieldInfoPtr_contactName;

		// Token: 0x04002F58 RID: 12120
		private static readonly System.IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002F59 RID: 12121
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSenderKnown_k__BackingField;

		// Token: 0x04002F5A RID: 12122
		private static readonly System.IntPtr NativeFieldInfoPtr_messageHistory;

		// Token: 0x04002F5B RID: 12123
		private static readonly System.IntPtr NativeFieldInfoPtr_messageChainHistory;

		// Token: 0x04002F5C RID: 12124
		private static readonly System.IntPtr NativeFieldInfoPtr_bubbles;

		// Token: 0x04002F5D RID: 12125
		private static readonly System.IntPtr NativeFieldInfoPtr_Sendables;

		// Token: 0x04002F5E RID: 12126
		private static readonly System.IntPtr NativeFieldInfoPtr_read;

		// Token: 0x04002F5F RID: 12127
		private static readonly System.IntPtr NativeFieldInfoPtr__index_k__BackingField;

		// Token: 0x04002F60 RID: 12128
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04002F61 RID: 12129
		private static readonly System.IntPtr NativeFieldInfoPtr__rollingOut_k__BackingField;

		// Token: 0x04002F62 RID: 12130
		private static readonly System.IntPtr NativeFieldInfoPtr__EntryVisible_k__BackingField;

		// Token: 0x04002F63 RID: 12131
		private static readonly System.IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04002F64 RID: 12132
		private static readonly System.IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x04002F65 RID: 12133
		private static readonly System.IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04002F66 RID: 12134
		private static readonly System.IntPtr NativeFieldInfoPtr_bubbleContainer;

		// Token: 0x04002F67 RID: 12135
		private static readonly System.IntPtr NativeFieldInfoPtr_scrollRectContainer;

		// Token: 0x04002F68 RID: 12136
		private static readonly System.IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04002F69 RID: 12137
		private static readonly System.IntPtr NativeFieldInfoPtr_entryPreviewText;

		// Token: 0x04002F6A RID: 12138
		private static readonly System.IntPtr NativeFieldInfoPtr_unreadDot;

		// Token: 0x04002F6B RID: 12139
		private static readonly System.IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04002F6C RID: 12140
		private static readonly System.IntPtr NativeFieldInfoPtr_sliderFill;

		// Token: 0x04002F6D RID: 12141
		private static readonly System.IntPtr NativeFieldInfoPtr_responseContainer;

		// Token: 0x04002F6E RID: 12142
		private static readonly System.IntPtr NativeFieldInfoPtr_senderInterface;

		// Token: 0x04002F6F RID: 12143
		private static readonly System.IntPtr NativeFieldInfoPtr_uiCreated;

		// Token: 0x04002F70 RID: 12144
		private static readonly System.IntPtr NativeFieldInfoPtr_onMessageRendered;

		// Token: 0x04002F71 RID: 12145
		private static readonly System.IntPtr NativeFieldInfoPtr_onLoaded;

		// Token: 0x04002F72 RID: 12146
		private static readonly System.IntPtr NativeFieldInfoPtr_onResponsesShown;

		// Token: 0x04002F73 RID: 12147
		private static readonly System.IntPtr NativeFieldInfoPtr_currentResponses;

		// Token: 0x04002F74 RID: 12148
		private static readonly System.IntPtr NativeFieldInfoPtr_responseRects;

		// Token: 0x04002F75 RID: 12149
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002F76 RID: 12150
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002F77 RID: 12151
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002F78 RID: 12152
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0;

		// Token: 0x04002F79 RID: 12153
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0;

		// Token: 0x04002F7A RID: 12154
		private static readonly System.IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x04002F7B RID: 12155
		private static readonly System.IntPtr NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0;

		// Token: 0x04002F7C RID: 12156
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04002F7D RID: 12157
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04002F7E RID: 12158
		private static readonly System.IntPtr NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0;

		// Token: 0x04002F7F RID: 12159
		private static readonly System.IntPtr NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0;

		// Token: 0x04002F80 RID: 12160
		private static readonly System.IntPtr NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0;

		// Token: 0x04002F81 RID: 12161
		private static readonly System.IntPtr NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04002F82 RID: 12162
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0;

		// Token: 0x04002F83 RID: 12163
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002F84 RID: 12164
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002F85 RID: 12165
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002F86 RID: 12166
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002F87 RID: 12167
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002F88 RID: 12168
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002F89 RID: 12169
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002F8A RID: 12170
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002F8B RID: 12171
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002F8C RID: 12172
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly System.IntPtr NativeMethodInfoPtr_MoveToTop_Public_Void_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateUI_Protected_Void_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly System.IntPtr NativeMethodInfoPtr_EnsureUIExists_Public_Void_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly System.IntPtr NativeMethodInfoPtr_RepositionEntry_Public_Void_0;

		// Token: 0x04002F95 RID: 12181
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0;

		// Token: 0x04002F96 RID: 12182
		private static readonly System.IntPtr NativeMethodInfoPtr_EntryClicked_Public_Void_0;

		// Token: 0x04002F97 RID: 12183
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04002F98 RID: 12184
		private static readonly System.IntPtr NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0;

		// Token: 0x04002F99 RID: 12185
		private static readonly System.IntPtr NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0;

		// Token: 0x04002F9A RID: 12186
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly System.IntPtr NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0;

		// Token: 0x04002FA0 RID: 12192
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0;

		// Token: 0x04002FA1 RID: 12193
		private static readonly System.IntPtr NativeMethodInfoPtr_GetResponse_Public_Response_String_0;

		// Token: 0x04002FA2 RID: 12194
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0;

		// Token: 0x04002FA3 RID: 12195
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0;

		// Token: 0x04002FA4 RID: 12196
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0;

		// Token: 0x04002FA5 RID: 12197
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0;

		// Token: 0x04002FA6 RID: 12198
		private static readonly System.IntPtr NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0;

		// Token: 0x04002FA7 RID: 12199
		private static readonly System.IntPtr NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0;

		// Token: 0x04002FA8 RID: 12200
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0;

		// Token: 0x04002FA9 RID: 12201
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0;

		// Token: 0x04002FAA RID: 12202
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04002FAB RID: 12203
		private static readonly System.IntPtr NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0;

		// Token: 0x04002FAC RID: 12204
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckSendLoop_Private_Void_0;

		// Token: 0x04002FAD RID: 12205
		private static readonly System.IntPtr NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0;

		// Token: 0x04002FAE RID: 12206
		private static readonly System.IntPtr NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0;

		// Token: 0x04002FAF RID: 12207
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x020009B7 RID: 2487
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<<CheckSendLoop>g__Loop|99_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600CE71 RID: 52849 RVA: 0x00321978 File Offset: 0x0031FB78
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique()
			{
				Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<<CheckSendLoop>g__Loop|99_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>1__state");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>2__current");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>4__this");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100672090);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100672091);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100672092);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100672093);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100672094);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100672095);
			}

			// Token: 0x0600CE72 RID: 52850 RVA: 0x00321A58 File Offset: 0x0031FC58
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE73 RID: 52851 RVA: 0x00321AA0 File Offset: 0x0031FCA0
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE74 RID: 52852 RVA: 0x00321AD4 File Offset: 0x0031FCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161347, XrefRangeEnd = 161360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004016 RID: 16406
			// (get) Token: 0x0600CE75 RID: 52853 RVA: 0x00321B10 File Offset: 0x0031FD10
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE76 RID: 52854 RVA: 0x00321B50 File Offset: 0x0031FD50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161360, XrefRangeEnd = 161365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004017 RID: 16407
			// (get) Token: 0x0600CE77 RID: 52855 RVA: 0x00321B84 File Offset: 0x0031FD84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CE78 RID: 52856 RVA: 0x00064172 File Offset: 0x00062372
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004013 RID: 16403
			// (get) Token: 0x0600CE79 RID: 52857 RVA: 0x00321BC4 File Offset: 0x0031FDC4
			// (set) Token: 0x0600CE7A RID: 52858 RVA: 0x0006417B File Offset: 0x0006237B
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004014 RID: 16404
			// (get) Token: 0x0600CE7B RID: 52859 RVA: 0x00321BEC File Offset: 0x0031FDEC
			// (set) Token: 0x0600CE7C RID: 52860 RVA: 0x00064196 File Offset: 0x00062396
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004015 RID: 16405
			// (get) Token: 0x0600CE7D RID: 52861 RVA: 0x00321C1C File Offset: 0x0031FE1C
			// (set) Token: 0x0600CE7E RID: 52862 RVA: 0x000641B5 File Offset: 0x000623B5
			public unsafe MSGConversation __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BC9 RID: 35785
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BCA RID: 35786
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BCB RID: 35787
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BCC RID: 35788
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BCD RID: 35789
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BCE RID: 35790
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BCF RID: 35791
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BD0 RID: 35792
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BD1 RID: 35793
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020009B8 RID: 2488
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE7F RID: 52863 RVA: 0x00321C4C File Offset: 0x0031FE4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr);
				MSGConversation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9");
				MSGConversation.__c.NativeFieldInfoPtr___9__100_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9__100_0");
				MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100672097);
				MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100672098);
			}

			// Token: 0x0600CE80 RID: 52864 RVA: 0x00321CC8 File Offset: 0x0031FEC8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE81 RID: 52865 RVA: 0x00321D04 File Offset: 0x0031FF04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161365, XrefRangeEnd = 161366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanSendNewMessage_b__100_0(SendableMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE82 RID: 52866 RVA: 0x000641D4 File Offset: 0x000623D4
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004018 RID: 16408
			// (get) Token: 0x0600CE83 RID: 52867 RVA: 0x00321D54 File Offset: 0x0031FF54
			// (set) Token: 0x0600CE84 RID: 52868 RVA: 0x000641DD File Offset: 0x000623DD
			public unsafe static MSGConversation.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004019 RID: 16409
			// (get) Token: 0x0600CE85 RID: 52869 RVA: 0x00321D7C File Offset: 0x0031FF7C
			// (set) Token: 0x0600CE86 RID: 52870 RVA: 0x000641EF File Offset: 0x000623EF
			public unsafe static Il2CppSystem.Func<SendableMessage, bool> __9__100_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9__100_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<SendableMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9__100_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BD2 RID: 35794
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BD3 RID: 35795
			private static readonly System.IntPtr NativeFieldInfoPtr___9__100_0;

			// Token: 0x04008BD4 RID: 35796
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BD5 RID: 35797
			private static readonly System.IntPtr NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0;
		}

		// Token: 0x020009B9 RID: 2489
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE87 RID: 52871 RVA: 0x00321DA4 File Offset: 0x0031FFA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, "message");
				MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, 100672099);
				MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, 100672100);
			}

			// Token: 0x0600CE88 RID: 52872 RVA: 0x00321E0C File Offset: 0x0032000C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE89 RID: 52873 RVA: 0x00321E48 File Offset: 0x00320048
			[CallerCount(0)]
			public unsafe bool _SendMessage_b__0(Message x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE8A RID: 52874 RVA: 0x00064201 File Offset: 0x00062401
			public __c__DisplayClass82_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700401A RID: 16410
			// (get) Token: 0x0600CE8B RID: 52875 RVA: 0x00321E98 File Offset: 0x00320098
			// (set) Token: 0x0600CE8C RID: 52876 RVA: 0x0006420A File Offset: 0x0006240A
			public unsafe Message message
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Message>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BD6 RID: 35798
			private static readonly System.IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04008BD7 RID: 35799
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BD8 RID: 35800
			private static readonly System.IntPtr NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0;
		}

		// Token: 0x020009BA RID: 2490
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE8D RID: 52877 RVA: 0x00321EC8 File Offset: 0x003200C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "messages");
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "notify");
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100672101);
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100672102);
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100672103);
			}

			// Token: 0x0600CE8E RID: 52878 RVA: 0x00321F6C File Offset: 0x0032016C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE8F RID: 52879 RVA: 0x00321FA8 File Offset: 0x003201A8
			[CallerCount(0)]
			public unsafe bool _SendMessageChain_b__0(MessageChain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE90 RID: 52880 RVA: 0x00321FF8 File Offset: 0x003201F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161416, XrefRangeEnd = 161422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_MessageChain_Single_PDM_0(MessageChain messageChain, float initialDelay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initialDelay;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CE91 RID: 52881 RVA: 0x00064229 File Offset: 0x00062429
			public __c__DisplayClass83_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700401B RID: 16411
			// (get) Token: 0x0600CE92 RID: 52882 RVA: 0x00322058 File Offset: 0x00320258
			// (set) Token: 0x0600CE93 RID: 52883 RVA: 0x00064232 File Offset: 0x00062432
			public unsafe MessageChain messages
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401C RID: 16412
			// (get) Token: 0x0600CE94 RID: 52884 RVA: 0x00322088 File Offset: 0x00320288
			// (set) Token: 0x0600CE95 RID: 52885 RVA: 0x00064251 File Offset: 0x00062451
			public unsafe MSGConversation __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401D RID: 16413
			// (get) Token: 0x0600CE96 RID: 52886 RVA: 0x003220B8 File Offset: 0x003202B8
			// (set) Token: 0x0600CE97 RID: 52887 RVA: 0x00064270 File Offset: 0x00062470
			public unsafe bool notify
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify)) = value;
				}
			}

			// Token: 0x04008BD9 RID: 35801
			private static readonly System.IntPtr NativeFieldInfoPtr_messages;

			// Token: 0x04008BDA RID: 35802
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BDB RID: 35803
			private static readonly System.IntPtr NativeFieldInfoPtr_notify;

			// Token: 0x04008BDC RID: 35804
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BDD RID: 35805
			private static readonly System.IntPtr NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0;

			// Token: 0x04008BDE RID: 35806
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0;

			// Token: 0x02000C9D RID: 3229
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass83_0+<<SendMessageChain>g__Routine|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E7D9 RID: 59353 RVA: 0x00369598 File Offset: 0x00367798
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "<<SendMessageChain>g__Routine|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "messageChain");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "initialDelay");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<messageClasses>5__2");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<i>5__3");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100672104);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100672105);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100672106);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100672107);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100672108);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100672109);
				}

				// Token: 0x0600E7DA RID: 59354 RVA: 0x003696C8 File Offset: 0x003678C8
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7DB RID: 59355 RVA: 0x00369710 File Offset: 0x00367910
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7DC RID: 59356 RVA: 0x00369744 File Offset: 0x00367944
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161366, XrefRangeEnd = 161411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004797 RID: 18327
				// (get) Token: 0x0600E7DD RID: 59357 RVA: 0x00369780 File Offset: 0x00367980
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E7DE RID: 59358 RVA: 0x003697C0 File Offset: 0x003679C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161411, XrefRangeEnd = 161416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004798 RID: 18328
				// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x003697F4 File Offset: 0x003679F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E7E0 RID: 59360 RVA: 0x00070B79 File Offset: 0x0006ED79
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004790 RID: 18320
				// (get) Token: 0x0600E7E1 RID: 59361 RVA: 0x00369834 File Offset: 0x00367A34
				// (set) Token: 0x0600E7E2 RID: 59362 RVA: 0x00070B82 File Offset: 0x0006ED82
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004791 RID: 18321
				// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x0036985C File Offset: 0x00367A5C
				// (set) Token: 0x0600E7E4 RID: 59364 RVA: 0x00070B9D File Offset: 0x0006ED9D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004792 RID: 18322
				// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x0036988C File Offset: 0x00367A8C
				// (set) Token: 0x0600E7E6 RID: 59366 RVA: 0x00070BBC File Offset: 0x0006EDBC
				public unsafe MSGConversation.__c__DisplayClass83_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass83_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004793 RID: 18323
				// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x003698BC File Offset: 0x00367ABC
				// (set) Token: 0x0600E7E8 RID: 59368 RVA: 0x00070BDB File Offset: 0x0006EDDB
				public unsafe MessageChain messageChain
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004794 RID: 18324
				// (get) Token: 0x0600E7E9 RID: 59369 RVA: 0x003698EC File Offset: 0x00367AEC
				// (set) Token: 0x0600E7EA RID: 59370 RVA: 0x00070BFA File Offset: 0x0006EDFA
				public unsafe float initialDelay
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay)) = value;
					}
				}

				// Token: 0x17004795 RID: 18325
				// (get) Token: 0x0600E7EB RID: 59371 RVA: 0x00369914 File Offset: 0x00367B14
				// (set) Token: 0x0600E7EC RID: 59372 RVA: 0x00070C15 File Offset: 0x0006EE15
				public unsafe List<Message> _messageClasses_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004796 RID: 18326
				// (get) Token: 0x0600E7ED RID: 59373 RVA: 0x00369944 File Offset: 0x00367B44
				// (set) Token: 0x0600E7EE RID: 59374 RVA: 0x00070C34 File Offset: 0x0006EE34
				public unsafe int _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009B3E RID: 39742
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B3F RID: 39743
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B40 RID: 39744
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B41 RID: 39745
				private static readonly System.IntPtr NativeFieldInfoPtr_messageChain;

				// Token: 0x04009B42 RID: 39746
				private static readonly System.IntPtr NativeFieldInfoPtr_initialDelay;

				// Token: 0x04009B43 RID: 39747
				private static readonly System.IntPtr NativeFieldInfoPtr__messageClasses_5__2;

				// Token: 0x04009B44 RID: 39748
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009B45 RID: 39749
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B46 RID: 39750
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B47 RID: 39751
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B48 RID: 39752
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B49 RID: 39753
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B4A RID: 39754
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009BB RID: 2491
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE98 RID: 52888 RVA: 0x003220E0 File Offset: 0x003202E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, "label");
				MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, 100672110);
				MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, 100672111);
			}

			// Token: 0x0600CE99 RID: 52889 RVA: 0x00322148 File Offset: 0x00320348
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE9A RID: 52890 RVA: 0x00322184 File Offset: 0x00320384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161422, XrefRangeEnd = 161424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResponse_b__0(Response x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE9B RID: 52891 RVA: 0x0006428B File Offset: 0x0006248B
			public __c__DisplayClass88_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700401E RID: 16414
			// (get) Token: 0x0600CE9C RID: 52892 RVA: 0x003221D4 File Offset: 0x003203D4
			// (set) Token: 0x0600CE9D RID: 52893 RVA: 0x00064294 File Offset: 0x00062494
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008BDF RID: 35807
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04008BE0 RID: 35808
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BE1 RID: 35809
			private static readonly System.IntPtr NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0;
		}

		// Token: 0x020009BC RID: 2492
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass89_0")]
		public sealed class __c__DisplayClass89_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE9E RID: 52894 RVA: 0x003221FC File Offset: 0x003203FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass89_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass89_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "showResponseDelay");
				MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, 100672112);
				MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, 100672113);
			}

			// Token: 0x0600CE9F RID: 52895 RVA: 0x00322278 File Offset: 0x00320478
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass89_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEA0 RID: 52896 RVA: 0x003222B4 File Offset: 0x003204B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161434, XrefRangeEnd = 161439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600CEA1 RID: 52897 RVA: 0x000642B3 File Offset: 0x000624B3
			public __c__DisplayClass89_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700401F RID: 16415
			// (get) Token: 0x0600CEA2 RID: 52898 RVA: 0x003222F4 File Offset: 0x003204F4
			// (set) Token: 0x0600CEA3 RID: 52899 RVA: 0x000642BC File Offset: 0x000624BC
			public unsafe float showResponseDelay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay)) = value;
				}
			}

			// Token: 0x17004020 RID: 16416
			// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x0032231C File Offset: 0x0032051C
			// (set) Token: 0x0600CEA5 RID: 52901 RVA: 0x000642D7 File Offset: 0x000624D7
			public unsafe MSGConversation __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BE2 RID: 35810
			private static readonly System.IntPtr NativeFieldInfoPtr_showResponseDelay;

			// Token: 0x04008BE3 RID: 35811
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BE4 RID: 35812
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BE5 RID: 35813
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C9E RID: 3230
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass89_0+<<ShowResponses>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E7EF RID: 59375 RVA: 0x0036996C File Offset: 0x00367B6C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "<<ShowResponses>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672114);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672115);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672116);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672117);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672118);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100672119);
				}

				// Token: 0x0600E7F0 RID: 59376 RVA: 0x00369A4C File Offset: 0x00367C4C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7F1 RID: 59377 RVA: 0x00369A94 File Offset: 0x00367C94
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E7F2 RID: 59378 RVA: 0x00369AC8 File Offset: 0x00367CC8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161424, XrefRangeEnd = 161429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700479C RID: 18332
				// (get) Token: 0x0600E7F3 RID: 59379 RVA: 0x00369B04 File Offset: 0x00367D04
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E7F4 RID: 59380 RVA: 0x00369B44 File Offset: 0x00367D44
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161429, XrefRangeEnd = 161434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700479D RID: 18333
				// (get) Token: 0x0600E7F5 RID: 59381 RVA: 0x00369B78 File Offset: 0x00367D78
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E7F6 RID: 59382 RVA: 0x00070C4F File Offset: 0x0006EE4F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004799 RID: 18329
				// (get) Token: 0x0600E7F7 RID: 59383 RVA: 0x00369BB8 File Offset: 0x00367DB8
				// (set) Token: 0x0600E7F8 RID: 59384 RVA: 0x00070C58 File Offset: 0x0006EE58
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700479A RID: 18330
				// (get) Token: 0x0600E7F9 RID: 59385 RVA: 0x00369BE0 File Offset: 0x00367DE0
				// (set) Token: 0x0600E7FA RID: 59386 RVA: 0x00070C73 File Offset: 0x0006EE73
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700479B RID: 18331
				// (get) Token: 0x0600E7FB RID: 59387 RVA: 0x00369C10 File Offset: 0x00367E10
				// (set) Token: 0x0600E7FC RID: 59388 RVA: 0x00070C92 File Offset: 0x0006EE92
				public unsafe MSGConversation.__c__DisplayClass89_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass89_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009B4B RID: 39755
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B4C RID: 39756
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B4D RID: 39757
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B4E RID: 39758
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B4F RID: 39759
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B50 RID: 39760
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B51 RID: 39761
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B52 RID: 39762
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B53 RID: 39763
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009BD RID: 2493
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEA6 RID: 52902 RVA: 0x0032234C File Offset: 0x0032054C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "r");
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "network");
				MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, 100672120);
				MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, 100672121);
			}

			// Token: 0x0600CEA7 RID: 52903 RVA: 0x003223DC File Offset: 0x003205DC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEA8 RID: 52904 RVA: 0x00322418 File Offset: 0x00320618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161439, XrefRangeEnd = 161455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateResponseUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CEA9 RID: 52905 RVA: 0x000642F6 File Offset: 0x000624F6
			public __c__DisplayClass90_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004021 RID: 16417
			// (get) Token: 0x0600CEAA RID: 52906 RVA: 0x0032244C File Offset: 0x0032064C
			// (set) Token: 0x0600CEAB RID: 52907 RVA: 0x000642FF File Offset: 0x000624FF
			public unsafe MSGConversation __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004022 RID: 16418
			// (get) Token: 0x0600CEAC RID: 52908 RVA: 0x0032247C File Offset: 0x0032067C
			// (set) Token: 0x0600CEAD RID: 52909 RVA: 0x0006431E File Offset: 0x0006251E
			public unsafe Response r
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Response>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004023 RID: 16419
			// (get) Token: 0x0600CEAE RID: 52910 RVA: 0x003224AC File Offset: 0x003206AC
			// (set) Token: 0x0600CEAF RID: 52911 RVA: 0x0006433D File Offset: 0x0006253D
			public unsafe bool network
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network)) = value;
				}
			}

			// Token: 0x04008BE6 RID: 35814
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BE7 RID: 35815
			private static readonly System.IntPtr NativeFieldInfoPtr_r;

			// Token: 0x04008BE8 RID: 35816
			private static readonly System.IntPtr NativeFieldInfoPtr_network;

			// Token: 0x04008BE9 RID: 35817
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BEA RID: 35818
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0;
		}
	}
}
