using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Compass;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BA RID: 442
	[System.Serializable]
	public class Quest : MonoBehaviour
	{
		// Token: 0x0600250F RID: 9487 RVA: 0x000E6910 File Offset: 0x000E4B10
		// Note: this type is marked as 'beforefieldinit'.
		static Quest()
		{
			Il2CppClassPointerStore<Quest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest>.NativeClassPtr);
			Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "MAX_HUD_ENTRY_LABELS");
			Quest.NativeFieldInfoPtr_CriticalExpiryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CriticalExpiryThreshold");
			Quest.NativeFieldInfoPtr_Quests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Quests");
			Quest.NativeFieldInfoPtr_HoveredQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "HoveredQuest");
			Quest.NativeFieldInfoPtr_ActiveQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ActiveQuests");
			Quest.NativeFieldInfoPtr__QuestState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<QuestState>k__BackingField");
			Quest.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<GUID>k__BackingField");
			Quest.NativeFieldInfoPtr__IsTracked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<IsTracked>k__BackingField");
			Quest.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "title");
			Quest.NativeFieldInfoPtr_Subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Subtitle");
			Quest.NativeFieldInfoPtr_onSubtitleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onSubtitleChanged");
			Quest.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Description");
			Quest.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "StaticGUID");
			Quest.NativeFieldInfoPtr_TrackOnBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "TrackOnBegin");
			Quest.NativeFieldInfoPtr_ExpiryVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ExpiryVisibility");
			Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoCompleteOnAllEntriesComplete");
			Quest.NativeFieldInfoPtr_PlayQuestCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PlayQuestCompleteSound");
			Quest.NativeFieldInfoPtr_CompletionXP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "CompletionXP");
			Quest.NativeFieldInfoPtr__Expires_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expires>k__BackingField");
			Quest.NativeFieldInfoPtr__Expiry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<Expiry>k__BackingField");
			Quest.NativeFieldInfoPtr_AutoStartFirstEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "AutoStartFirstEntry");
			Quest.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "Entries");
			Quest.NativeFieldInfoPtr_IconPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "IconPrefab");
			Quest.NativeFieldInfoPtr_PoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "PoIPrefab");
			Quest.NativeFieldInfoPtr_onQuestBegin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestBegin");
			Quest.NativeFieldInfoPtr_onQuestEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onQuestEnd");
			Quest.NativeFieldInfoPtr_onActiveState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onActiveState");
			Quest.NativeFieldInfoPtr_onTrackChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onTrackChange");
			Quest.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onComplete");
			Quest.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onInitialComplete");
			Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiryReminder");
			Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "ShouldSendExpiredNotification");
			Quest.NativeFieldInfoPtr_journalEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "journalEntry");
			Quest.NativeFieldInfoPtr_entryTitleRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTitleRect");
			Quest.NativeFieldInfoPtr_trackedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "trackedRect");
			Quest.NativeFieldInfoPtr_entryTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "entryTimeLabel");
			Quest.NativeFieldInfoPtr_criticalTimeBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "criticalTimeBackground");
			Quest.NativeFieldInfoPtr_detailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "detailPanel");
			Quest.NativeFieldInfoPtr__hudUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<hudUI>k__BackingField");
			Quest.NativeFieldInfoPtr_onHudUICreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "onHudUICreated");
			Quest.NativeFieldInfoPtr_expiryReminderSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "expiryReminderSent");
			Quest.NativeFieldInfoPtr_compassElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "compassElement");
			Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Quest.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<HasChanged>k__BackingField");
			Quest.NativeFieldInfoPtr_autoInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest>.NativeClassPtr, "autoInitialize");
			Quest.NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667437);
			Quest.NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667438);
			Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667439);
			Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667440);
			Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667441);
			Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667442);
			Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667443);
			Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667444);
			Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667445);
			Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667446);
			Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667447);
			Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667448);
			Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667449);
			Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667450);
			Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667451);
			Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667452);
			Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667453);
			Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667454);
			Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667455);
			Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667456);
			Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667457);
			Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667458);
			Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667459);
			Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667460);
			Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667461);
			Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667462);
			Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667463);
			Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667464);
			Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667465);
			Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667466);
			Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667467);
			Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667468);
			Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667469);
			Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667470);
			Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667471);
			Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667472);
			Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667473);
			Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667474);
			Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667475);
			Quest.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667476);
			Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667477);
			Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667478);
			Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667479);
			Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667480);
			Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667481);
			Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667482);
			Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667483);
			Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667484);
			Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667485);
			Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667486);
			Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667487);
			Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667488);
			Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667489);
			Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667490);
			Quest.NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667491);
			Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667492);
			Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667493);
			Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667494);
			Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667495);
			Quest.NativeMethodInfoPtr_DestroyHudUI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667496);
			Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667497);
			Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667498);
			Quest.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667499);
			Quest.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667500);
			Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667501);
			Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667502);
			Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667503);
			Quest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667504);
			Quest.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667506);
			Quest.NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667507);
			Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest>.NativeClassPtr, 100667508);
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000E7264 File Offset: 0x000E5464
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x000E72A0 File Offset: 0x000E54A0
		public unsafe EQuestState QuestState
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21913, RefRangeEnd = 21914, XrefRangeStart = 21913, XrefRangeEnd = 21914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31411, RefRangeEnd = 31412, XrefRangeStart = 31411, XrefRangeEnd = 31412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000E72E0 File Offset: 0x000E54E0
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x000E731C File Offset: 0x000E551C
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000E735C File Offset: 0x000E555C
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x000E7398 File Offset: 0x000E5598
		public unsafe bool IsTracked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000E73D8 File Offset: 0x000E55D8
		public unsafe int ActiveEntryCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117141, RefRangeEnd = 117142, XrefRangeStart = 117123, XrefRangeEnd = 117141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000E7414 File Offset: 0x000E5614
		public unsafe string Title
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117142, RefRangeEnd = 117143, XrefRangeStart = 117142, XrefRangeEnd = 117142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x000E744C File Offset: 0x000E564C
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x000E7488 File Offset: 0x000E5688
		public unsafe bool Expires
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x000E74C8 File Offset: 0x000E56C8
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x000E7504 File Offset: 0x000E5704
		public unsafe GameDateTime Expiry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000E7544 File Offset: 0x000E5744
		public unsafe bool hudUIExists
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117143, XrefRangeEnd = 117147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x0600251D RID: 9501 RVA: 0x000E7580 File Offset: 0x000E5780
		// (set) Token: 0x0600251E RID: 9502 RVA: 0x000E75C0 File Offset: 0x000E57C0
		public unsafe QuestHUDUI hudUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x0600251F RID: 9503 RVA: 0x000E7604 File Offset: 0x000E5804
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117147, XrefRangeEnd = 117152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002520 RID: 9504 RVA: 0x000E763C File Offset: 0x000E583C
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117152, XrefRangeEnd = 117157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002521 RID: 9505 RVA: 0x000E7674 File Offset: 0x000E5874
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000E76B4 File Offset: 0x000E58B4
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x000E76F0 File Offset: 0x000E58F0
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x000E7730 File Offset: 0x000E5930
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117157, XrefRangeEnd = 117158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002525 RID: 9509 RVA: 0x000E7774 File Offset: 0x000E5974
		// (set) Token: 0x06002526 RID: 9510 RVA: 0x000E77B4 File Offset: 0x000E59B4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002527 RID: 9511 RVA: 0x000E77F8 File Offset: 0x000E59F8
		// (set) Token: 0x06002528 RID: 9512 RVA: 0x000E7834 File Offset: 0x000E5A34
		public unsafe virtual bool HasChanged
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 117158, RefRangeEnd = 117159, XrefRangeStart = 117158, XrefRangeEnd = 117158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000E7874 File Offset: 0x000E5A74
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000E78B0 File Offset: 0x000E5AB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 117198, RefRangeEnd = 117204, XrefRangeStart = 117159, XrefRangeEnd = 117198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000E78EC File Offset: 0x000E5AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117265, RefRangeEnd = 117266, XrefRangeStart = 117204, XrefRangeEnd = 117265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeQuest(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000E7970 File Offset: 0x000E5B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117266, XrefRangeEnd = 117272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000E79AC File Offset: 0x000E5BAC
		[CallerCount(0)]
		public unsafe void ConfigureExpiry(bool expires, GameDateTime expiry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref expires;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref expiry;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000E79F8 File Offset: 0x000E5BF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117283, RefRangeEnd = 117287, XrefRangeStart = 117272, XrefRangeEnd = 117283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000E7A44 File Offset: 0x000E5C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117313, RefRangeEnd = 117314, XrefRangeStart = 117287, XrefRangeEnd = 117313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000E7A90 File Offset: 0x000E5C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117314, XrefRangeEnd = 117320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fail(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000E7ADC File Offset: 0x000E5CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117320, XrefRangeEnd = 117325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Expire(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000E7B28 File Offset: 0x000E5D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117325, XrefRangeEnd = 117331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cancel(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000E7B74 File Offset: 0x000E5D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117372, RefRangeEnd = 117374, XrefRangeStart = 117331, XrefRangeEnd = 117372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_End_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000E7BB0 File Offset: 0x000E5DB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 117422, RefRangeEnd = 117426, XrefRangeStart = 117374, XrefRangeEnd = 117422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestState(EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref state;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000E7C08 File Offset: 0x000E5E08
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000E7C50 File Offset: 0x000E5E50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 117437, RefRangeEnd = 117438, XrefRangeStart = 117426, XrefRangeEnd = 117437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000E7CB8 File Offset: 0x000E5EB8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 117449, RefRangeEnd = 117463, XrefRangeStart = 117438, XrefRangeEnd = 117449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000E7CF4 File Offset: 0x000E5EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117463, XrefRangeEnd = 117465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000E7D30 File Offset: 0x000E5F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117465, XrefRangeEnd = 117470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAutoComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000E7D64 File Offset: 0x000E5F64
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000E7DAC File Offset: 0x000E5FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117470, XrefRangeEnd = 117481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000E7DE8 File Offset: 0x000E5FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117481, XrefRangeEnd = 117492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000E7E24 File Offset: 0x000E6024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117492, XrefRangeEnd = 117496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000E7E64 File Offset: 0x000E6064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSubtitle(string subtitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000E7EA8 File Offset: 0x000E60A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117496, XrefRangeEnd = 117520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsTracked(bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref tracked;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000E7EF4 File Offset: 0x000E60F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117520, XrefRangeEnd = 117617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetupJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000E7F30 File Offset: 0x000E6130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117617, XrefRangeEnd = 117626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000E7F64 File Offset: 0x000E6164
		[CallerCount(0)]
		public unsafe void JournalEntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000E7F98 File Offset: 0x000E6198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117626, XrefRangeEnd = 117632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JournalEntryHoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000E7FCC File Offset: 0x000E61CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 117638, RefRangeEnd = 117645, XrefRangeStart = 117632, XrefRangeEnd = 117638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMinsUntilExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000E8008 File Offset: 0x000E6208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 117651, RefRangeEnd = 117654, XrefRangeStart = 117645, XrefRangeEnd = 117651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetExpiryText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetExpiryText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000E8040 File Offset: 0x000E6240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117654, XrefRangeEnd = 117679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual QuestHUDUI SetupHudUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000E808C File Offset: 0x000E628C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117679, XrefRangeEnd = 117680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000E80C0 File Offset: 0x000E62C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117680, XrefRangeEnd = 117685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BopHUDUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_BopHUDUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000E80F4 File Offset: 0x000E62F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetQuestTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000E8138 File Offset: 0x000E6338
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117692, RefRangeEnd = 117694, XrefRangeStart = 117685, XrefRangeEnd = 117692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry GetFirstActiveEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000E8178 File Offset: 0x000E6378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117694, XrefRangeEnd = 117702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHudUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyHudUI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000E81AC File Offset: 0x000E63AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117702, XrefRangeEnd = 117824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform CreateDetailDisplay(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000E8208 File Offset: 0x000E6408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 117834, RefRangeEnd = 117836, XrefRangeStart = 117824, XrefRangeEnd = 117834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDetailDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000E823C File Offset: 0x000E643C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000E8284 File Offset: 0x000E6484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117836, XrefRangeEnd = 117868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000E82D0 File Offset: 0x000E64D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117868, XrefRangeEnd = 117869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000E8308 File Offset: 0x000E6508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117869, XrefRangeEnd = 117891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(QuestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000E8358 File Offset: 0x000E6558
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 117910, RefRangeEnd = 117915, XrefRangeStart = 117891, XrefRangeEnd = 117910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Quest GetQuest(string questName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(questName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000E839C File Offset: 0x000E659C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 117944, RefRangeEnd = 117966, XrefRangeStart = 117915, XrefRangeEnd = 117944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000E83D8 File Offset: 0x000E65D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118005, RefRangeEnd = 118006, XrefRangeStart = 117966, XrefRangeEnd = 118005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000E840C File Offset: 0x000E660C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118006, XrefRangeEnd = 118012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetupJournalEntry_b__110_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000E8450 File Offset: 0x000E6650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118012, XrefRangeEnd = 118041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00014ADF File Offset: 0x00012CDF
		public Quest(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000E8484 File Offset: 0x000E6684
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x00014AE8 File Offset: 0x00012CE8
		public unsafe static int MAX_HUD_ENTRY_LABELS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS, (void*)(&value));
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000E84A0 File Offset: 0x000E66A0
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x00014AF6 File Offset: 0x00012CF6
		public unsafe static int CriticalExpiryThreshold
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_CriticalExpiryThreshold, (void*)(&value));
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000E84BC File Offset: 0x000E66BC
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x00014B04 File Offset: 0x00012D04
		public unsafe static List<Quest> Quests
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_Quests, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_Quests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000E84E4 File Offset: 0x000E66E4
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x00014B16 File Offset: 0x00012D16
		public unsafe static Quest HoveredQuest
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_HoveredQuest, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_HoveredQuest, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000E850C File Offset: 0x000E670C
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x00014B28 File Offset: 0x00012D28
		public unsafe static List<Quest> ActiveQuests
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Quest.NativeFieldInfoPtr_ActiveQuests, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Quest>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest.NativeFieldInfoPtr_ActiveQuests, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000E8534 File Offset: 0x000E6734
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x00014B3A File Offset: 0x00012D3A
		public unsafe EQuestState _QuestState_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__QuestState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__QuestState_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000E855C File Offset: 0x000E675C
		// (set) Token: 0x06002565 RID: 9573 RVA: 0x00014B55 File Offset: 0x00012D55
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000E8584 File Offset: 0x000E6784
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x00014B70 File Offset: 0x00012D70
		public unsafe bool _IsTracked_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__IsTracked_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000E85AC File Offset: 0x000E67AC
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x00014B8B File Offset: 0x00012D8B
		public unsafe string title
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000E85D4 File Offset: 0x000E67D4
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x00014BAA File Offset: 0x00012DAA
		public unsafe string Subtitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Subtitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000E85FC File Offset: 0x000E67FC
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x00014BC9 File Offset: 0x00012DC9
		public unsafe Il2CppSystem.Action onSubtitleChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onSubtitleChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000E862C File Offset: 0x000E682C
		// (set) Token: 0x0600256F RID: 9583 RVA: 0x00014BE8 File Offset: 0x00012DE8
		public unsafe string Description
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000E8654 File Offset: 0x000E6854
		// (set) Token: 0x06002571 RID: 9585 RVA: 0x00014C07 File Offset: 0x00012E07
		public unsafe string StaticGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000E867C File Offset: 0x000E687C
		// (set) Token: 0x06002573 RID: 9587 RVA: 0x00014C26 File Offset: 0x00012E26
		public unsafe bool TrackOnBegin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_TrackOnBegin)) = value;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000E86A4 File Offset: 0x000E68A4
		// (set) Token: 0x06002575 RID: 9589 RVA: 0x00014C41 File Offset: 0x00012E41
		public unsafe EExpiryVisibility ExpiryVisibility
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ExpiryVisibility)) = value;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000E86CC File Offset: 0x000E68CC
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x00014C5C File Offset: 0x00012E5C
		public unsafe bool AutoCompleteOnAllEntriesComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete)) = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000E86F4 File Offset: 0x000E68F4
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x00014C77 File Offset: 0x00012E77
		public unsafe bool PlayQuestCompleteSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PlayQuestCompleteSound)) = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000E871C File Offset: 0x000E691C
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x00014C92 File Offset: 0x00012E92
		public unsafe int CompletionXP
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_CompletionXP)) = value;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000E8744 File Offset: 0x000E6944
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x00014CAD File Offset: 0x00012EAD
		public unsafe bool _Expires_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expires_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000E876C File Offset: 0x000E696C
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x00014CC8 File Offset: 0x00012EC8
		public unsafe GameDateTime _Expiry_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__Expiry_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002580 RID: 9600 RVA: 0x000E8794 File Offset: 0x000E6994
		// (set) Token: 0x06002581 RID: 9601 RVA: 0x00014CE3 File Offset: 0x00012EE3
		public unsafe bool AutoStartFirstEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_AutoStartFirstEntry)) = value;
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x000E87BC File Offset: 0x000E69BC
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x00014CFE File Offset: 0x00012EFE
		public unsafe List<QuestEntry> Entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002584 RID: 9604 RVA: 0x000E87EC File Offset: 0x000E69EC
		// (set) Token: 0x06002585 RID: 9605 RVA: 0x00014D1D File Offset: 0x00012F1D
		public unsafe RectTransform IconPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_IconPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002586 RID: 9606 RVA: 0x000E881C File Offset: 0x000E6A1C
		// (set) Token: 0x06002587 RID: 9607 RVA: 0x00014D3C File Offset: 0x00012F3C
		public unsafe GameObject PoIPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_PoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x000E884C File Offset: 0x000E6A4C
		// (set) Token: 0x06002589 RID: 9609 RVA: 0x00014D5B File Offset: 0x00012F5B
		public unsafe UnityEvent onQuestBegin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestBegin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x0600258A RID: 9610 RVA: 0x000E887C File Offset: 0x000E6A7C
		// (set) Token: 0x0600258B RID: 9611 RVA: 0x00014D7A File Offset: 0x00012F7A
		public unsafe UnityEvent<EQuestState> onQuestEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<EQuestState>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onQuestEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600258C RID: 9612 RVA: 0x000E88AC File Offset: 0x000E6AAC
		// (set) Token: 0x0600258D RID: 9613 RVA: 0x00014D99 File Offset: 0x00012F99
		public unsafe UnityEvent onActiveState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onActiveState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600258E RID: 9614 RVA: 0x000E88DC File Offset: 0x000E6ADC
		// (set) Token: 0x0600258F RID: 9615 RVA: 0x00014DB8 File Offset: 0x00012FB8
		public unsafe UnityEvent<bool> onTrackChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<bool>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onTrackChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002590 RID: 9616 RVA: 0x000E890C File Offset: 0x000E6B0C
		// (set) Token: 0x06002591 RID: 9617 RVA: 0x00014DD7 File Offset: 0x00012FD7
		public unsafe UnityEvent onComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002592 RID: 9618 RVA: 0x000E893C File Offset: 0x000E6B3C
		// (set) Token: 0x06002593 RID: 9619 RVA: 0x00014DF6 File Offset: 0x00012FF6
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x000E896C File Offset: 0x000E6B6C
		// (set) Token: 0x06002595 RID: 9621 RVA: 0x00014E15 File Offset: 0x00013015
		public unsafe bool ShouldSendExpiryReminder
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiryReminder)) = value;
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002596 RID: 9622 RVA: 0x000E8994 File Offset: 0x000E6B94
		// (set) Token: 0x06002597 RID: 9623 RVA: 0x00014E30 File Offset: 0x00013030
		public unsafe bool ShouldSendExpiredNotification
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_ShouldSendExpiredNotification)) = value;
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002598 RID: 9624 RVA: 0x000E89BC File Offset: 0x000E6BBC
		// (set) Token: 0x06002599 RID: 9625 RVA: 0x00014E4B File Offset: 0x0001304B
		public unsafe RectTransform journalEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_journalEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600259A RID: 9626 RVA: 0x000E89EC File Offset: 0x000E6BEC
		// (set) Token: 0x0600259B RID: 9627 RVA: 0x00014E6A File Offset: 0x0001306A
		public unsafe RectTransform entryTitleRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTitleRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x0600259C RID: 9628 RVA: 0x000E8A1C File Offset: 0x000E6C1C
		// (set) Token: 0x0600259D RID: 9629 RVA: 0x00014E89 File Offset: 0x00013089
		public unsafe RectTransform trackedRect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_trackedRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600259E RID: 9630 RVA: 0x000E8A4C File Offset: 0x000E6C4C
		// (set) Token: 0x0600259F RID: 9631 RVA: 0x00014EA8 File Offset: 0x000130A8
		public unsafe Text entryTimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_entryTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060025A0 RID: 9632 RVA: 0x000E8A7C File Offset: 0x000E6C7C
		// (set) Token: 0x060025A1 RID: 9633 RVA: 0x00014EC7 File Offset: 0x000130C7
		public unsafe Image criticalTimeBackground
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_criticalTimeBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x060025A2 RID: 9634 RVA: 0x000E8AAC File Offset: 0x000E6CAC
		// (set) Token: 0x060025A3 RID: 9635 RVA: 0x00014EE6 File Offset: 0x000130E6
		public unsafe RectTransform detailPanel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_detailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x060025A4 RID: 9636 RVA: 0x000E8ADC File Offset: 0x000E6CDC
		// (set) Token: 0x060025A5 RID: 9637 RVA: 0x00014F05 File Offset: 0x00013105
		public unsafe QuestHUDUI _hudUI_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestHUDUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__hudUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000E8B0C File Offset: 0x000E6D0C
		// (set) Token: 0x060025A7 RID: 9639 RVA: 0x00014F24 File Offset: 0x00013124
		public unsafe Il2CppSystem.Action onHudUICreated
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_onHudUICreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x060025A8 RID: 9640 RVA: 0x000E8B3C File Offset: 0x000E6D3C
		// (set) Token: 0x060025A9 RID: 9641 RVA: 0x00014F43 File Offset: 0x00013143
		public unsafe bool expiryReminderSent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_expiryReminderSent)) = value;
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x060025AA RID: 9642 RVA: 0x000E8B64 File Offset: 0x000E6D64
		// (set) Token: 0x060025AB RID: 9643 RVA: 0x00014F5E File Offset: 0x0001315E
		public unsafe CompassManager.Element compassElement
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_compassElement);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_compassElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x060025AC RID: 9644 RVA: 0x000E8B94 File Offset: 0x000E6D94
		// (set) Token: 0x060025AD RID: 9645 RVA: 0x00014F7D File Offset: 0x0001317D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x060025AE RID: 9646 RVA: 0x000E8BC4 File Offset: 0x000E6DC4
		// (set) Token: 0x060025AF RID: 9647 RVA: 0x00014F9C File Offset: 0x0001319C
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CDF RID: 3295
		// (get) Token: 0x060025B0 RID: 9648 RVA: 0x000E8BF4 File Offset: 0x000E6DF4
		// (set) Token: 0x060025B1 RID: 9649 RVA: 0x00014FBB File Offset: 0x000131BB
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x060025B2 RID: 9650 RVA: 0x000E8C1C File Offset: 0x000E6E1C
		// (set) Token: 0x060025B3 RID: 9651 RVA: 0x00014FD6 File Offset: 0x000131D6
		public unsafe bool autoInitialize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.NativeFieldInfoPtr_autoInitialize)) = value;
			}
		}

		// Token: 0x04001898 RID: 6296
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_HUD_ENTRY_LABELS;

		// Token: 0x04001899 RID: 6297
		private static readonly System.IntPtr NativeFieldInfoPtr_CriticalExpiryThreshold;

		// Token: 0x0400189A RID: 6298
		private static readonly System.IntPtr NativeFieldInfoPtr_Quests;

		// Token: 0x0400189B RID: 6299
		private static readonly System.IntPtr NativeFieldInfoPtr_HoveredQuest;

		// Token: 0x0400189C RID: 6300
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveQuests;

		// Token: 0x0400189D RID: 6301
		private static readonly System.IntPtr NativeFieldInfoPtr__QuestState_k__BackingField;

		// Token: 0x0400189E RID: 6302
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400189F RID: 6303
		private static readonly System.IntPtr NativeFieldInfoPtr__IsTracked_k__BackingField;

		// Token: 0x040018A0 RID: 6304
		private static readonly System.IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040018A1 RID: 6305
		private static readonly System.IntPtr NativeFieldInfoPtr_Subtitle;

		// Token: 0x040018A2 RID: 6306
		private static readonly System.IntPtr NativeFieldInfoPtr_onSubtitleChanged;

		// Token: 0x040018A3 RID: 6307
		private static readonly System.IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x040018A4 RID: 6308
		private static readonly System.IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x040018A5 RID: 6309
		private static readonly System.IntPtr NativeFieldInfoPtr_TrackOnBegin;

		// Token: 0x040018A6 RID: 6310
		private static readonly System.IntPtr NativeFieldInfoPtr_ExpiryVisibility;

		// Token: 0x040018A7 RID: 6311
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoCompleteOnAllEntriesComplete;

		// Token: 0x040018A8 RID: 6312
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayQuestCompleteSound;

		// Token: 0x040018A9 RID: 6313
		private static readonly System.IntPtr NativeFieldInfoPtr_CompletionXP;

		// Token: 0x040018AA RID: 6314
		private static readonly System.IntPtr NativeFieldInfoPtr__Expires_k__BackingField;

		// Token: 0x040018AB RID: 6315
		private static readonly System.IntPtr NativeFieldInfoPtr__Expiry_k__BackingField;

		// Token: 0x040018AC RID: 6316
		private static readonly System.IntPtr NativeFieldInfoPtr_AutoStartFirstEntry;

		// Token: 0x040018AD RID: 6317
		private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040018AE RID: 6318
		private static readonly System.IntPtr NativeFieldInfoPtr_IconPrefab;

		// Token: 0x040018AF RID: 6319
		private static readonly System.IntPtr NativeFieldInfoPtr_PoIPrefab;

		// Token: 0x040018B0 RID: 6320
		private static readonly System.IntPtr NativeFieldInfoPtr_onQuestBegin;

		// Token: 0x040018B1 RID: 6321
		private static readonly System.IntPtr NativeFieldInfoPtr_onQuestEnd;

		// Token: 0x040018B2 RID: 6322
		private static readonly System.IntPtr NativeFieldInfoPtr_onActiveState;

		// Token: 0x040018B3 RID: 6323
		private static readonly System.IntPtr NativeFieldInfoPtr_onTrackChange;

		// Token: 0x040018B4 RID: 6324
		private static readonly System.IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x040018B5 RID: 6325
		private static readonly System.IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x040018B6 RID: 6326
		private static readonly System.IntPtr NativeFieldInfoPtr_ShouldSendExpiryReminder;

		// Token: 0x040018B7 RID: 6327
		private static readonly System.IntPtr NativeFieldInfoPtr_ShouldSendExpiredNotification;

		// Token: 0x040018B8 RID: 6328
		private static readonly System.IntPtr NativeFieldInfoPtr_journalEntry;

		// Token: 0x040018B9 RID: 6329
		private static readonly System.IntPtr NativeFieldInfoPtr_entryTitleRect;

		// Token: 0x040018BA RID: 6330
		private static readonly System.IntPtr NativeFieldInfoPtr_trackedRect;

		// Token: 0x040018BB RID: 6331
		private static readonly System.IntPtr NativeFieldInfoPtr_entryTimeLabel;

		// Token: 0x040018BC RID: 6332
		private static readonly System.IntPtr NativeFieldInfoPtr_criticalTimeBackground;

		// Token: 0x040018BD RID: 6333
		private static readonly System.IntPtr NativeFieldInfoPtr_detailPanel;

		// Token: 0x040018BE RID: 6334
		private static readonly System.IntPtr NativeFieldInfoPtr__hudUI_k__BackingField;

		// Token: 0x040018BF RID: 6335
		private static readonly System.IntPtr NativeFieldInfoPtr_onHudUICreated;

		// Token: 0x040018C0 RID: 6336
		private static readonly System.IntPtr NativeFieldInfoPtr_expiryReminderSent;

		// Token: 0x040018C1 RID: 6337
		private static readonly System.IntPtr NativeFieldInfoPtr_compassElement;

		// Token: 0x040018C2 RID: 6338
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040018C3 RID: 6339
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040018C4 RID: 6340
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040018C5 RID: 6341
		private static readonly System.IntPtr NativeFieldInfoPtr_autoInitialize;

		// Token: 0x040018C6 RID: 6342
		private static readonly System.IntPtr NativeMethodInfoPtr_get_QuestState_Public_get_EQuestState_0;

		// Token: 0x040018C7 RID: 6343
		private static readonly System.IntPtr NativeMethodInfoPtr_set_QuestState_Protected_set_Void_EQuestState_0;

		// Token: 0x040018C8 RID: 6344
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040018C9 RID: 6345
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040018CA RID: 6346
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsTracked_Public_get_Boolean_0;

		// Token: 0x040018CB RID: 6347
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsTracked_Protected_set_Void_Boolean_0;

		// Token: 0x040018CC RID: 6348
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveEntryCount_Public_get_Int32_0;

		// Token: 0x040018CD RID: 6349
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x040018CE RID: 6350
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Expires_Public_get_Boolean_0;

		// Token: 0x040018CF RID: 6351
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Expires_Protected_set_Void_Boolean_0;

		// Token: 0x040018D0 RID: 6352
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Expiry_Public_get_GameDateTime_0;

		// Token: 0x040018D1 RID: 6353
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Expiry_Protected_set_Void_GameDateTime_0;

		// Token: 0x040018D2 RID: 6354
		private static readonly System.IntPtr NativeMethodInfoPtr_get_hudUIExists_Public_get_Boolean_0;

		// Token: 0x040018D3 RID: 6355
		private static readonly System.IntPtr NativeMethodInfoPtr_get_hudUI_Public_get_QuestHUDUI_0;

		// Token: 0x040018D4 RID: 6356
		private static readonly System.IntPtr NativeMethodInfoPtr_set_hudUI_Private_set_Void_QuestHUDUI_0;

		// Token: 0x040018D5 RID: 6357
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040018D6 RID: 6358
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040018D7 RID: 6359
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040018D8 RID: 6360
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040018D9 RID: 6361
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040018DA RID: 6362
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040018DB RID: 6363
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040018DC RID: 6364
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040018DD RID: 6365
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040018DE RID: 6366
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040018DF RID: 6367
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040018E0 RID: 6368
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040018E1 RID: 6369
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeQuest_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_0;

		// Token: 0x040018E2 RID: 6370
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040018E3 RID: 6371
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfigureExpiry_Public_Void_Boolean_GameDateTime_0;

		// Token: 0x040018E4 RID: 6372
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018E5 RID: 6373
		private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018E6 RID: 6374
		private static readonly System.IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018E7 RID: 6375
		private static readonly System.IntPtr NativeMethodInfoPtr_Expire_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018E8 RID: 6376
		private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018E9 RID: 6377
		private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Virtual_New_Void_0;

		// Token: 0x040018EA RID: 6378
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuestState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x040018EB RID: 6379
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018EC RID: 6380
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_New_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x040018ED RID: 6381
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040018EE RID: 6382
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckExpiry_Protected_Virtual_New_Void_0;

		// Token: 0x040018EF RID: 6383
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckAutoComplete_Private_Void_1;

		// Token: 0x040018F0 RID: 6384
		private static readonly System.IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_New_Boolean_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly System.IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_New_Void_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly System.IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_New_Void_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSubtitle_Public_Void_String_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsTracked_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupJournalEntry_Public_Virtual_New_Void_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyJournalEntry_Private_Void_1;

		// Token: 0x040018F8 RID: 6392
		private static readonly System.IntPtr NativeMethodInfoPtr_JournalEntryClicked_Private_Void_1;

		// Token: 0x040018F9 RID: 6393
		private static readonly System.IntPtr NativeMethodInfoPtr_JournalEntryHoverStart_Private_Void_1;

		// Token: 0x040018FA RID: 6394
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMinsUntilExpiry_Public_Int32_0;

		// Token: 0x040018FB RID: 6395
		private static readonly System.IntPtr NativeMethodInfoPtr_GetExpiryText_Public_String_0;

		// Token: 0x040018FC RID: 6396
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupHudUI_Public_Virtual_New_QuestHUDUI_0;

		// Token: 0x040018FD RID: 6397
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHUDUI_Public_Void_0;

		// Token: 0x040018FE RID: 6398
		private static readonly System.IntPtr NativeMethodInfoPtr_BopHUDUI_Public_Void_0;

		// Token: 0x040018FF RID: 6399
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQuestTitle_Public_Virtual_New_String_0;

		// Token: 0x04001900 RID: 6400
		private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstActiveEntry_Public_QuestEntry_0;

		// Token: 0x04001901 RID: 6401
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyHudUI_Private_Void_1;

		// Token: 0x04001902 RID: 6402
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateDetailDisplay_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x04001903 RID: 6403
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDetailDisplay_Public_Void_0;

		// Token: 0x04001904 RID: 6404
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04001905 RID: 6405
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_SaveData_0;

		// Token: 0x04001906 RID: 6406
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04001907 RID: 6407
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_QuestData_0;

		// Token: 0x04001908 RID: 6408
		private static readonly System.IntPtr NativeMethodInfoPtr_GetQuest_Public_Static_Quest_String_0;

		// Token: 0x04001909 RID: 6409
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400190A RID: 6410
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x0400190B RID: 6411
		private static readonly System.IntPtr NativeMethodInfoPtr__SetupJournalEntry_b__110_0_Private_Void_BaseEventData_0;

		// Token: 0x0400190C RID: 6412
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x020008FE RID: 2302
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C855 RID: 51285 RVA: 0x0030FC40 File Offset: 0x0030DE40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr);
				Quest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9");
				Quest.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, "<>9__18_0");
				Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667510);
				Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr, 100667511);
			}

			// Token: 0x0600C856 RID: 51286 RVA: 0x0030FCBC File Offset: 0x0030DEBC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C857 RID: 51287 RVA: 0x0030FCF8 File Offset: 0x0030DEF8
			[CallerCount(0)]
			public unsafe bool _get_ActiveEntryCount_b__18_0(QuestEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.__c.NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C858 RID: 51288 RVA: 0x0006127D File Offset: 0x0005F47D
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E40 RID: 15936
			// (get) Token: 0x0600C859 RID: 51289 RVA: 0x0030FD48 File Offset: 0x0030DF48
			// (set) Token: 0x0600C85A RID: 51290 RVA: 0x00061286 File Offset: 0x0005F486
			public unsafe static Quest.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E41 RID: 15937
			// (get) Token: 0x0600C85B RID: 51291 RVA: 0x0030FD70 File Offset: 0x0030DF70
			// (set) Token: 0x0600C85C RID: 51292 RVA: 0x00061298 File Offset: 0x0005F498
			public unsafe static Il2CppSystem.Func<QuestEntry, bool> __9__18_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087E3 RID: 34787
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087E4 RID: 34788
			private static readonly System.IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x040087E5 RID: 34789
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087E6 RID: 34790
			private static readonly System.IntPtr NativeMethodInfoPtr__get_ActiveEntryCount_b__18_0_Internal_Boolean_QuestEntry_0;
		}

		// Token: 0x020008FF RID: 2303
		[ObfuscatedName("ScheduleOne.Quests.Quest+<>c__DisplayClass128_0")]
		public sealed class __c__DisplayClass128_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C85D RID: 51293 RVA: 0x0030FD98 File Offset: 0x0030DF98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass128_0()
			{
				Il2CppClassPointerStore<Quest.__c__DisplayClass128_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest>.NativeClassPtr, "<>c__DisplayClass128_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest.__c__DisplayClass128_0>.NativeClassPtr);
				Quest.__c__DisplayClass128_0.NativeFieldInfoPtr_questName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest.__c__DisplayClass128_0>.NativeClassPtr, "questName");
				Quest.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass128_0>.NativeClassPtr, 100667512);
				Quest.__c__DisplayClass128_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest.__c__DisplayClass128_0>.NativeClassPtr, 100667513);
			}

			// Token: 0x0600C85E RID: 51294 RVA: 0x0030FE00 File Offset: 0x0030E000
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass128_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest.__c__DisplayClass128_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C85F RID: 51295 RVA: 0x0030FE3C File Offset: 0x0030E03C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117119, XrefRangeEnd = 117123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetQuest_b__0(Quest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest.__c__DisplayClass128_0.NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C860 RID: 51296 RVA: 0x000612AA File Offset: 0x0005F4AA
			public __c__DisplayClass128_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E42 RID: 15938
			// (get) Token: 0x0600C861 RID: 51297 RVA: 0x0030FE8C File Offset: 0x0030E08C
			// (set) Token: 0x0600C862 RID: 51298 RVA: 0x000612B3 File Offset: 0x0005F4B3
			public unsafe string questName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass128_0.NativeFieldInfoPtr_questName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest.__c__DisplayClass128_0.NativeFieldInfoPtr_questName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040087E7 RID: 34791
			private static readonly System.IntPtr NativeFieldInfoPtr_questName;

			// Token: 0x040087E8 RID: 34792
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087E9 RID: 34793
			private static readonly System.IntPtr NativeMethodInfoPtr__GetQuest_b__0_Internal_Boolean_Quest_0;
		}
	}
}
