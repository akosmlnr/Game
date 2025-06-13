using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppScheduleOne.UI.Tooltips;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006D7 RID: 1751
	public class MessagesApp : App<MessagesApp>
	{
		// Token: 0x06009CA2 RID: 40098 RVA: 0x0027F8C0 File Offset: 0x0027DAC0
		// Note: this type is marked as 'beforefieldinit'.
		static MessagesApp()
		{
			Il2CppClassPointerStore<MessagesApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessagesApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr);
			MessagesApp.NativeFieldInfoPtr_Conversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "Conversations");
			MessagesApp.NativeFieldInfoPtr_ActiveConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ActiveConversations");
			MessagesApp.NativeFieldInfoPtr_categoryInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "categoryInfos");
			MessagesApp.NativeFieldInfoPtr_conversationEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryContainer");
			MessagesApp.NativeFieldInfoPtr_conversationContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainer");
			MessagesApp.NativeFieldInfoPtr_homePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "homePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePage");
			MessagesApp.NativeFieldInfoPtr_dialoguePageNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "dialoguePageNameText");
			MessagesApp.NativeFieldInfoPtr_relationshipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipContainer");
			MessagesApp.NativeFieldInfoPtr_relationshipScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipScrollbar");
			MessagesApp.NativeFieldInfoPtr_relationshipTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "relationshipTooltip");
			MessagesApp.NativeFieldInfoPtr_standardsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsContainer");
			MessagesApp.NativeFieldInfoPtr_standardsStar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsStar");
			MessagesApp.NativeFieldInfoPtr_standardsTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "standardsTooltip");
			MessagesApp.NativeFieldInfoPtr_iconContainerRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconContainerRect");
			MessagesApp.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "iconImage");
			MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "BlankAvatarSprite");
			MessagesApp.NativeFieldInfoPtr_DealWindowSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "DealWindowSelector");
			MessagesApp.NativeFieldInfoPtr_PhoneShopInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "PhoneShopInterface");
			MessagesApp.NativeFieldInfoPtr_CounterofferInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CounterofferInterface");
			MessagesApp.NativeFieldInfoPtr_ClearFilterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "ClearFilterButton");
			MessagesApp.NativeFieldInfoPtr_CategoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryButtons");
			MessagesApp.NativeFieldInfoPtr_MessageReceivedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageReceivedSound");
			MessagesApp.NativeFieldInfoPtr_MessageSentSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "MessageSentSound");
			MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationEntryPrefab");
			MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "conversationContainerPrefab");
			MessagesApp.NativeFieldInfoPtr_messageBubblePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "messageBubblePrefab");
			MessagesApp.NativeFieldInfoPtr_unreadConversations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "unreadConversations");
			MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<currentConversation>k__BackingField");
			MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682680);
			MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682681);
			MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682682);
			MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682683);
			MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682684);
			MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682685);
			MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682686);
			MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682687);
			MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682688);
			MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682689);
			MessagesApp.NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682690);
			MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682691);
			MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682692);
			MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682693);
			MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682694);
			MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, 100682695);
		}

		// Token: 0x17003018 RID: 12312
		// (get) Token: 0x06009CA3 RID: 40099 RVA: 0x0027FC74 File Offset: 0x0027DE74
		// (set) Token: 0x06009CA4 RID: 40100 RVA: 0x0027FCB4 File Offset: 0x0027DEB4
		public unsafe MSGConversation currentConversation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009CA5 RID: 40101 RVA: 0x0027FCF8 File Offset: 0x0027DEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278712, XrefRangeEnd = 278754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CA6 RID: 40102 RVA: 0x0027FD34 File Offset: 0x0027DF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278754, XrefRangeEnd = 278774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CA7 RID: 40103 RVA: 0x0027FD70 File Offset: 0x0027DF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278774, XrefRangeEnd = 278805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CA8 RID: 40104 RVA: 0x0027FDA4 File Offset: 0x0027DFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278805, XrefRangeEnd = 278813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CA9 RID: 40105 RVA: 0x0027FDD8 File Offset: 0x0027DFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278901, RefRangeEnd = 278902, XrefRangeStart = 278813, XrefRangeEnd = 278901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateConversationUI(MSGConversation c, out RectTransform entry, out RectTransform container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			System.IntPtr returnedException;
			System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr4 = intPtr;
			entry = ((intPtr4 == 0) ? null : new RectTransform(intPtr4));
			System.IntPtr intPtr5 = intPtr2;
			container = ((intPtr5 == 0) ? null : new RectTransform(intPtr5));
		}

		// Token: 0x06009CAA RID: 40106 RVA: 0x0027FE60 File Offset: 0x0027E060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 278923, RefRangeEnd = 278926, XrefRangeStart = 278902, XrefRangeEnd = 278923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RepositionEntries_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CAB RID: 40107 RVA: 0x0027FE94 File Offset: 0x0027E094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278926, XrefRangeEnd = 278927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CAC RID: 40108 RVA: 0x0027FEC8 File Offset: 0x0027E0C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278938, RefRangeEnd = 278939, XrefRangeStart = 278927, XrefRangeEnd = 278938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_RefreshNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CAD RID: 40109 RVA: 0x0027FEFC File Offset: 0x0027E0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278939, XrefRangeEnd = 278946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessagesApp.NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CAE RID: 40110 RVA: 0x0027FF4C File Offset: 0x0027E14C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278948, RefRangeEnd = 278949, XrefRangeStart = 278946, XrefRangeEnd = 278948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentConversation(MSGConversation conversation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conversation);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CAF RID: 40111 RVA: 0x0027FF90 File Offset: 0x0027E190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278949, XrefRangeEnd = 278963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp.CategoryInfo GetCategoryInfo(EConversationCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp.CategoryInfo>(intPtr2) : null;
		}

		// Token: 0x06009CB0 RID: 40112 RVA: 0x0027FFDC File Offset: 0x0027E1DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278963, XrefRangeEnd = 278988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterByCategory(int category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref category;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CB1 RID: 40113 RVA: 0x0028001C File Offset: 0x0027E21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278988, XrefRangeEnd = 279007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr_ClearFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CB2 RID: 40114 RVA: 0x00280050 File Offset: 0x0027E250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279007, XrefRangeEnd = 279020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessagesApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009CB3 RID: 40115 RVA: 0x0004C43B File Offset: 0x0004A63B
		public MessagesApp(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FFB RID: 12283
		// (get) Token: 0x06009CB4 RID: 40116 RVA: 0x0028008C File Offset: 0x0027E28C
		// (set) Token: 0x06009CB5 RID: 40117 RVA: 0x0004C444 File Offset: 0x0004A644
		public unsafe static List<MSGConversation> Conversations
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_Conversations, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_Conversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x06009CB6 RID: 40118 RVA: 0x002800B4 File Offset: 0x0027E2B4
		// (set) Token: 0x06009CB7 RID: 40119 RVA: 0x0004C456 File Offset: 0x0004A656
		public unsafe static List<MSGConversation> ActiveConversations
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessagesApp.NativeFieldInfoPtr_ActiveConversations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x06009CB8 RID: 40120 RVA: 0x002800DC File Offset: 0x0027E2DC
		// (set) Token: 0x06009CB9 RID: 40121 RVA: 0x0004C468 File Offset: 0x0004A668
		public unsafe List<MessagesApp.CategoryInfo> categoryInfos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessagesApp.CategoryInfo>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_categoryInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x06009CBA RID: 40122 RVA: 0x0028010C File Offset: 0x0027E30C
		// (set) Token: 0x06009CBB RID: 40123 RVA: 0x0004C487 File Offset: 0x0004A687
		public unsafe RectTransform conversationEntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x06009CBC RID: 40124 RVA: 0x0028013C File Offset: 0x0027E33C
		// (set) Token: 0x06009CBD RID: 40125 RVA: 0x0004C4A6 File Offset: 0x0004A6A6
		public unsafe RectTransform conversationContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003000 RID: 12288
		// (get) Token: 0x06009CBE RID: 40126 RVA: 0x0028016C File Offset: 0x0027E36C
		// (set) Token: 0x06009CBF RID: 40127 RVA: 0x0004C4C5 File Offset: 0x0004A6C5
		public unsafe GameObject homePage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_homePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003001 RID: 12289
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x0028019C File Offset: 0x0027E39C
		// (set) Token: 0x06009CC1 RID: 40129 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		public unsafe GameObject dialoguePage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003002 RID: 12290
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x002801CC File Offset: 0x0027E3CC
		// (set) Token: 0x06009CC3 RID: 40131 RVA: 0x0004C503 File Offset: 0x0004A703
		public unsafe Text dialoguePageNameText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_dialoguePageNameText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003003 RID: 12291
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x002801FC File Offset: 0x0027E3FC
		// (set) Token: 0x06009CC5 RID: 40133 RVA: 0x0004C522 File Offset: 0x0004A722
		public unsafe RectTransform relationshipContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003004 RID: 12292
		// (get) Token: 0x06009CC6 RID: 40134 RVA: 0x0028022C File Offset: 0x0027E42C
		// (set) Token: 0x06009CC7 RID: 40135 RVA: 0x0004C541 File Offset: 0x0004A741
		public unsafe Scrollbar relationshipScrollbar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipScrollbar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x06009CC8 RID: 40136 RVA: 0x0028025C File Offset: 0x0027E45C
		// (set) Token: 0x06009CC9 RID: 40137 RVA: 0x0004C560 File Offset: 0x0004A760
		public unsafe Tooltip relationshipTooltip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_relationshipTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x0028028C File Offset: 0x0027E48C
		// (set) Token: 0x06009CCB RID: 40139 RVA: 0x0004C57F File Offset: 0x0004A77F
		public unsafe RectTransform standardsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x06009CCC RID: 40140 RVA: 0x002802BC File Offset: 0x0027E4BC
		// (set) Token: 0x06009CCD RID: 40141 RVA: 0x0004C59E File Offset: 0x0004A79E
		public unsafe Image standardsStar
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsStar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x06009CCE RID: 40142 RVA: 0x002802EC File Offset: 0x0027E4EC
		// (set) Token: 0x06009CCF RID: 40143 RVA: 0x0004C5BD File Offset: 0x0004A7BD
		public unsafe Tooltip standardsTooltip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tooltip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_standardsTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x06009CD0 RID: 40144 RVA: 0x0028031C File Offset: 0x0027E51C
		// (set) Token: 0x06009CD1 RID: 40145 RVA: 0x0004C5DC File Offset: 0x0004A7DC
		public unsafe RectTransform iconContainerRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconContainerRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x06009CD2 RID: 40146 RVA: 0x0028034C File Offset: 0x0027E54C
		// (set) Token: 0x06009CD3 RID: 40147 RVA: 0x0004C5FB File Offset: 0x0004A7FB
		public unsafe Image iconImage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300B RID: 12299
		// (get) Token: 0x06009CD4 RID: 40148 RVA: 0x0028037C File Offset: 0x0027E57C
		// (set) Token: 0x06009CD5 RID: 40149 RVA: 0x0004C61A File Offset: 0x0004A81A
		public unsafe Sprite BlankAvatarSprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_BlankAvatarSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300C RID: 12300
		// (get) Token: 0x06009CD6 RID: 40150 RVA: 0x002803AC File Offset: 0x0027E5AC
		// (set) Token: 0x06009CD7 RID: 40151 RVA: 0x0004C639 File Offset: 0x0004A839
		public unsafe DealWindowSelector DealWindowSelector
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealWindowSelector>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_DealWindowSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300D RID: 12301
		// (get) Token: 0x06009CD8 RID: 40152 RVA: 0x002803DC File Offset: 0x0027E5DC
		// (set) Token: 0x06009CD9 RID: 40153 RVA: 0x0004C658 File Offset: 0x0004A858
		public unsafe PhoneShopInterface PhoneShopInterface
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_PhoneShopInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300E RID: 12302
		// (get) Token: 0x06009CDA RID: 40154 RVA: 0x0028040C File Offset: 0x0027E60C
		// (set) Token: 0x06009CDB RID: 40155 RVA: 0x0004C677 File Offset: 0x0004A877
		public unsafe CounterofferInterface CounterofferInterface
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterofferInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CounterofferInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700300F RID: 12303
		// (get) Token: 0x06009CDC RID: 40156 RVA: 0x0028043C File Offset: 0x0027E63C
		// (set) Token: 0x06009CDD RID: 40157 RVA: 0x0004C696 File Offset: 0x0004A896
		public unsafe RectTransform ClearFilterButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_ClearFilterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003010 RID: 12304
		// (get) Token: 0x06009CDE RID: 40158 RVA: 0x0028046C File Offset: 0x0027E66C
		// (set) Token: 0x06009CDF RID: 40159 RVA: 0x0004C6B5 File Offset: 0x0004A8B5
		public unsafe Il2CppReferenceArray<Button> CategoryButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_CategoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003011 RID: 12305
		// (get) Token: 0x06009CE0 RID: 40160 RVA: 0x0028049C File Offset: 0x0027E69C
		// (set) Token: 0x06009CE1 RID: 40161 RVA: 0x0004C6D4 File Offset: 0x0004A8D4
		public unsafe AudioSourceController MessageReceivedSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageReceivedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x06009CE2 RID: 40162 RVA: 0x002804CC File Offset: 0x0027E6CC
		// (set) Token: 0x06009CE3 RID: 40163 RVA: 0x0004C6F3 File Offset: 0x0004A8F3
		public unsafe AudioSourceController MessageSentSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_MessageSentSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x06009CE4 RID: 40164 RVA: 0x002804FC File Offset: 0x0027E6FC
		// (set) Token: 0x06009CE5 RID: 40165 RVA: 0x0004C712 File Offset: 0x0004A912
		public unsafe GameObject conversationEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x0028052C File Offset: 0x0027E72C
		// (set) Token: 0x06009CE7 RID: 40167 RVA: 0x0004C731 File Offset: 0x0004A931
		public unsafe GameObject conversationContainerPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_conversationContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x06009CE8 RID: 40168 RVA: 0x0028055C File Offset: 0x0027E75C
		// (set) Token: 0x06009CE9 RID: 40169 RVA: 0x0004C750 File Offset: 0x0004A950
		public unsafe GameObject messageBubblePrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_messageBubblePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003016 RID: 12310
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x0028058C File Offset: 0x0027E78C
		// (set) Token: 0x06009CEB RID: 40171 RVA: 0x0004C76F File Offset: 0x0004A96F
		public unsafe List<MSGConversation> unreadConversations
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MSGConversation>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr_unreadConversations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003017 RID: 12311
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x002805BC File Offset: 0x0027E7BC
		// (set) Token: 0x06009CED RID: 40173 RVA: 0x0004C78E File Offset: 0x0004A98E
		public unsafe MSGConversation _currentConversation_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.NativeFieldInfoPtr__currentConversation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006969 RID: 26985
		private static readonly System.IntPtr NativeFieldInfoPtr_Conversations;

		// Token: 0x0400696A RID: 26986
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveConversations;

		// Token: 0x0400696B RID: 26987
		private static readonly System.IntPtr NativeFieldInfoPtr_categoryInfos;

		// Token: 0x0400696C RID: 26988
		private static readonly System.IntPtr NativeFieldInfoPtr_conversationEntryContainer;

		// Token: 0x0400696D RID: 26989
		private static readonly System.IntPtr NativeFieldInfoPtr_conversationContainer;

		// Token: 0x0400696E RID: 26990
		private static readonly System.IntPtr NativeFieldInfoPtr_homePage;

		// Token: 0x0400696F RID: 26991
		private static readonly System.IntPtr NativeFieldInfoPtr_dialoguePage;

		// Token: 0x04006970 RID: 26992
		private static readonly System.IntPtr NativeFieldInfoPtr_dialoguePageNameText;

		// Token: 0x04006971 RID: 26993
		private static readonly System.IntPtr NativeFieldInfoPtr_relationshipContainer;

		// Token: 0x04006972 RID: 26994
		private static readonly System.IntPtr NativeFieldInfoPtr_relationshipScrollbar;

		// Token: 0x04006973 RID: 26995
		private static readonly System.IntPtr NativeFieldInfoPtr_relationshipTooltip;

		// Token: 0x04006974 RID: 26996
		private static readonly System.IntPtr NativeFieldInfoPtr_standardsContainer;

		// Token: 0x04006975 RID: 26997
		private static readonly System.IntPtr NativeFieldInfoPtr_standardsStar;

		// Token: 0x04006976 RID: 26998
		private static readonly System.IntPtr NativeFieldInfoPtr_standardsTooltip;

		// Token: 0x04006977 RID: 26999
		private static readonly System.IntPtr NativeFieldInfoPtr_iconContainerRect;

		// Token: 0x04006978 RID: 27000
		private static readonly System.IntPtr NativeFieldInfoPtr_iconImage;

		// Token: 0x04006979 RID: 27001
		private static readonly System.IntPtr NativeFieldInfoPtr_BlankAvatarSprite;

		// Token: 0x0400697A RID: 27002
		private static readonly System.IntPtr NativeFieldInfoPtr_DealWindowSelector;

		// Token: 0x0400697B RID: 27003
		private static readonly System.IntPtr NativeFieldInfoPtr_PhoneShopInterface;

		// Token: 0x0400697C RID: 27004
		private static readonly System.IntPtr NativeFieldInfoPtr_CounterofferInterface;

		// Token: 0x0400697D RID: 27005
		private static readonly System.IntPtr NativeFieldInfoPtr_ClearFilterButton;

		// Token: 0x0400697E RID: 27006
		private static readonly System.IntPtr NativeFieldInfoPtr_CategoryButtons;

		// Token: 0x0400697F RID: 27007
		private static readonly System.IntPtr NativeFieldInfoPtr_MessageReceivedSound;

		// Token: 0x04006980 RID: 27008
		private static readonly System.IntPtr NativeFieldInfoPtr_MessageSentSound;

		// Token: 0x04006981 RID: 27009
		private static readonly System.IntPtr NativeFieldInfoPtr_conversationEntryPrefab;

		// Token: 0x04006982 RID: 27010
		private static readonly System.IntPtr NativeFieldInfoPtr_conversationContainerPrefab;

		// Token: 0x04006983 RID: 27011
		private static readonly System.IntPtr NativeFieldInfoPtr_messageBubblePrefab;

		// Token: 0x04006984 RID: 27012
		private static readonly System.IntPtr NativeFieldInfoPtr_unreadConversations;

		// Token: 0x04006985 RID: 27013
		private static readonly System.IntPtr NativeFieldInfoPtr__currentConversation_k__BackingField;

		// Token: 0x04006986 RID: 27014
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentConversation_Public_get_MSGConversation_0;

		// Token: 0x04006987 RID: 27015
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentConversation_Private_set_Void_MSGConversation_0;

		// Token: 0x04006988 RID: 27016
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006989 RID: 27017
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400698A RID: 27018
		private static readonly System.IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x0400698B RID: 27019
		private static readonly System.IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x0400698C RID: 27020
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateConversationUI_Public_Void_MSGConversation_byref_RectTransform_byref_RectTransform_0;

		// Token: 0x0400698D RID: 27021
		private static readonly System.IntPtr NativeMethodInfoPtr_RepositionEntries_Public_Void_0;

		// Token: 0x0400698E RID: 27022
		private static readonly System.IntPtr NativeMethodInfoPtr_ReturnButtonClicked_Public_Void_0;

		// Token: 0x0400698F RID: 27023
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshNotifications_Public_Void_0;

		// Token: 0x04006990 RID: 27024
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_Void_ExitAction_0;

		// Token: 0x04006991 RID: 27025
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCurrentConversation_Public_Void_MSGConversation_0;

		// Token: 0x04006992 RID: 27026
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCategoryInfo_Public_CategoryInfo_EConversationCategory_0;

		// Token: 0x04006993 RID: 27027
		private static readonly System.IntPtr NativeMethodInfoPtr_FilterByCategory_Public_Void_Int32_0;

		// Token: 0x04006994 RID: 27028
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearFilter_Public_Void_0;

		// Token: 0x04006995 RID: 27029
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BCE RID: 3022
		[System.Serializable]
		public class CategoryInfo : Il2CppSystem.Object
		{
			// Token: 0x0600E098 RID: 57496 RVA: 0x00354FB0 File Offset: 0x003531B0
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInfo()
			{
				Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "CategoryInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr);
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Category");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Name");
				MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, "Color");
				MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr, 100682697);
			}

			// Token: 0x0600E099 RID: 57497 RVA: 0x0035502C File Offset: 0x0035322C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.CategoryInfo>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.CategoryInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E09A RID: 57498 RVA: 0x0006D10B File Offset: 0x0006B30B
			public CategoryInfo(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004557 RID: 17751
			// (get) Token: 0x0600E09B RID: 57499 RVA: 0x00355068 File Offset: 0x00353268
			// (set) Token: 0x0600E09C RID: 57500 RVA: 0x0006D114 File Offset: 0x0006B314
			public unsafe EConversationCategory Category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x17004558 RID: 17752
			// (get) Token: 0x0600E09D RID: 57501 RVA: 0x00355090 File Offset: 0x00353290
			// (set) Token: 0x0600E09E RID: 57502 RVA: 0x0006D12F File Offset: 0x0006B32F
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004559 RID: 17753
			// (get) Token: 0x0600E09F RID: 57503 RVA: 0x003550B8 File Offset: 0x003532B8
			// (set) Token: 0x0600E0A0 RID: 57504 RVA: 0x0006D14E File Offset: 0x0006B34E
			public unsafe Color Color
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.CategoryInfo.NativeFieldInfoPtr_Color)) = value;
				}
			}

			// Token: 0x040096BA RID: 38586
			private static readonly System.IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x040096BB RID: 38587
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x040096BC RID: 38588
			private static readonly System.IntPtr NativeFieldInfoPtr_Color;

			// Token: 0x040096BD RID: 38589
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BCF RID: 3023
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E0A1 RID: 57505 RVA: 0x003550E0 File Offset: 0x003532E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr);
				MessagesApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9");
				MessagesApp.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, "<>9__35_0");
				MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100682699);
				MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr, 100682700);
			}

			// Token: 0x0600E0A2 RID: 57506 RVA: 0x0035515C File Offset: 0x0035335C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0A3 RID: 57507 RVA: 0x00355198 File Offset: 0x00353398
			[CallerCount(0)]
			public unsafe int _Loaded_b__35_0(MSGConversation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c.NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E0A4 RID: 57508 RVA: 0x0006D169 File Offset: 0x0006B369
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455A RID: 17754
			// (get) Token: 0x0600E0A5 RID: 57509 RVA: 0x003551E8 File Offset: 0x003533E8
			// (set) Token: 0x0600E0A6 RID: 57510 RVA: 0x0006D172 File Offset: 0x0006B372
			public unsafe static MessagesApp.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessagesApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455B RID: 17755
			// (get) Token: 0x0600E0A7 RID: 57511 RVA: 0x00355210 File Offset: 0x00353410
			// (set) Token: 0x0600E0A8 RID: 57512 RVA: 0x0006D184 File Offset: 0x0006B384
			public unsafe static Il2CppSystem.Func<MSGConversation, int> __9__35_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MessagesApp.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<MSGConversation, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MessagesApp.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096BE RID: 38590
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040096BF RID: 38591
			private static readonly System.IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x040096C0 RID: 38592
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096C1 RID: 38593
			private static readonly System.IntPtr NativeMethodInfoPtr__Loaded_b__35_0_Internal_Int32_MSGConversation_0;
		}

		// Token: 0x02000BD0 RID: 3024
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessagesApp+<>c__DisplayClass43_0")]
		public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0A9 RID: 57513 RVA: 0x00355238 File Offset: 0x00353438
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass43_0()
			{
				Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessagesApp>.NativeClassPtr, "<>c__DisplayClass43_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr);
				MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, "category");
				MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, 100682701);
				MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr, 100682702);
			}

			// Token: 0x0600E0AA RID: 57514 RVA: 0x003552A0 File Offset: 0x003534A0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagesApp.__c__DisplayClass43_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E0AB RID: 57515 RVA: 0x003552DC File Offset: 0x003534DC
			[CallerCount(0)]
			public unsafe bool _GetCategoryInfo_b__0(MessagesApp.CategoryInfo x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MessagesApp.__c__DisplayClass43_0.NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600E0AC RID: 57516 RVA: 0x0006D196 File Offset: 0x0006B396
			public __c__DisplayClass43_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455C RID: 17756
			// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x0035532C File Offset: 0x0035352C
			// (set) Token: 0x0600E0AE RID: 57518 RVA: 0x0006D19F File Offset: 0x0006B39F
			public unsafe EConversationCategory category
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MessagesApp.__c__DisplayClass43_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x040096C2 RID: 38594
			private static readonly System.IntPtr NativeFieldInfoPtr_category;

			// Token: 0x040096C3 RID: 38595
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096C4 RID: 38596
			private static readonly System.IntPtr NativeMethodInfoPtr__GetCategoryInfo_b__0_Internal_Boolean_CategoryInfo_0;
		}
	}
}
