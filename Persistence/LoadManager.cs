using System;
using Il2CppFishNet.Transporting;
using Il2CppFishNet.Transporting.Yak;
using Il2CppFishySteamworks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.ItemLoaders;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.MainMenu;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200022B RID: 555
	public class LoadManager : PersistentSingleton<LoadManager>
	{
		// Token: 0x06002D83 RID: 11651 RVA: 0x00103FC0 File Offset: 0x001021C0
		// Note: this type is marked as 'beforefieldinit'.
		static LoadManager()
		{
			Il2CppClassPointerStore<LoadManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager>.NativeClassPtr);
			LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOADS_PER_FRAME");
			LoadManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "DEBUG");
			LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LOAD_ERROR_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NETWORK_TIMEOUT");
			LoadManager.NativeFieldInfoPtr_LoadHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LoadHistory");
			LoadManager.NativeFieldInfoPtr_SaveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "SaveGames");
			LoadManager.NativeFieldInfoPtr_LastPlayedGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LastPlayedGame");
			LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<IsLoading>k__BackingField");
			LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<TimeSinceGameLoaded>k__BackingField");
			LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<DebugMode>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadStatus>k__BackingField");
			LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<LoadedGameFolderPath>k__BackingField");
			LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<ActiveSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<StoredSaveInfo>k__BackingField");
			LoadManager.NativeFieldInfoPtr_loadRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "loadRequests");
			LoadManager.NativeFieldInfoPtr_ItemLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ItemLoaders");
			LoadManager.NativeFieldInfoPtr_ObjectLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "ObjectLoaders");
			LoadManager.NativeFieldInfoPtr_LegacyNPCLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "LegacyNPCLoaders");
			LoadManager.NativeFieldInfoPtr_NPCLoaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "NPCLoaders");
			LoadManager.NativeFieldInfoPtr_onPreSceneChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreSceneChange");
			LoadManager.NativeFieldInfoPtr_onPreLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onPreLoad");
			LoadManager.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onLoadComplete");
			LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "onSaveInfoLoaded");
			LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668478);
			LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668479);
			LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668480);
			LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668481);
			LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668482);
			LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668483);
			LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668484);
			LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668485);
			LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668486);
			LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668487);
			LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668488);
			LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668489);
			LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668490);
			LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668491);
			LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668492);
			LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668493);
			LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668494);
			LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668495);
			LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668496);
			LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668497);
			LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668498);
			LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668499);
			LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668500);
			LoadManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668501);
			LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668502);
			LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668503);
			LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668504);
			LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668505);
			LoadManager.NativeMethodInfoPtr_GetLegacyNPCLoader_Public_LegacyNPCLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668506);
			LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668507);
			LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668508);
			LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668509);
			LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668510);
			LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668511);
			LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668512);
			LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668513);
			LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668514);
			LoadManager.NativeMethodInfoPtr_CleanUp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668515);
			LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668516);
			LoadManager.NativeMethodInfoPtr_TryLoadSaveInfo_Public_Static_Boolean_String_Int32_byref_SaveInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668517);
			LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668518);
			LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668519);
			LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668521);
			LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, 100668522);
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x00104540 File Offset: 0x00102740
		public unsafe string DefaultTutorialSaveFolder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 129111, RefRangeEnd = 129113, XrefRangeStart = 129101, XrefRangeEnd = 129111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x00104578 File Offset: 0x00102778
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x001045B4 File Offset: 0x001027B4
		public unsafe bool IsGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x001045F4 File Offset: 0x001027F4
		// (set) Token: 0x06002D88 RID: 11656 RVA: 0x00104630 File Offset: 0x00102830
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06002D89 RID: 11657 RVA: 0x00104670 File Offset: 0x00102870
		// (set) Token: 0x06002D8A RID: 11658 RVA: 0x001046AC File Offset: 0x001028AC
		public unsafe float TimeSinceGameLoaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 109817, RefRangeEnd = 109819, XrefRangeStart = 109817, XrefRangeEnd = 109819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x001046EC File Offset: 0x001028EC
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00104728 File Offset: 0x00102928
		public unsafe bool DebugMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00104768 File Offset: 0x00102968
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x001047A4 File Offset: 0x001029A4
		public unsafe LoadManager.ELoadStatus LoadStatus
		{
			[CallerCount(123)]
			[CachedScanResults(RefRangeStart = 47877, RefRangeEnd = 48000, XrefRangeStart = 47877, XrefRangeEnd = 48000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x001047E4 File Offset: 0x001029E4
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x0010481C File Offset: 0x00102A1C
		public unsafe string LoadedGameFolderPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x00104860 File Offset: 0x00102A60
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x001048A0 File Offset: 0x00102AA0
		public unsafe SaveInfo ActiveSaveInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06002D93 RID: 11667 RVA: 0x001048E4 File Offset: 0x00102AE4
		// (set) Token: 0x06002D94 RID: 11668 RVA: 0x00104924 File Offset: 0x00102B24
		public unsafe SaveInfo StoredSaveInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00104968 File Offset: 0x00102B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129113, XrefRangeEnd = 129116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x001049A4 File Offset: 0x00102BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129116, XrefRangeEnd = 129258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x001049E0 File Offset: 0x00102BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129308, RefRangeEnd = 129309, XrefRangeStart = 129258, XrefRangeEnd = 129308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Bananas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Bananas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x00104A14 File Offset: 0x00102C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129309, XrefRangeEnd = 129353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeItemLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x00104A48 File Offset: 0x00102C48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129433, RefRangeEnd = 129434, XrefRangeStart = 129353, XrefRangeEnd = 129433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeObjectLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x00104A7C File Offset: 0x00102C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129434, XrefRangeEnd = 129482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeNPCLoaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x00104AB0 File Offset: 0x00102CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129482, XrefRangeEnd = 129523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x00104AE4 File Offset: 0x00102CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129523, XrefRangeEnd = 129529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00104B28 File Offset: 0x00102D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129529, XrefRangeEnd = 129533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueLoadRequest(LoadRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00104B6C File Offset: 0x00102D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129533, XrefRangeEnd = 129554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemLoader GetItemLoader(string itemType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemType);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemLoader>(intPtr2) : null;
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00104BBC File Offset: 0x00102DBC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129575, RefRangeEnd = 129578, XrefRangeStart = 129554, XrefRangeEnd = 129575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemLoader GetObjectLoader(string objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectType);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemLoader>(intPtr2) : null;
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00104C0C File Offset: 0x00102E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129599, RefRangeEnd = 129600, XrefRangeStart = 129578, XrefRangeEnd = 129599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyNPCLoader GetLegacyNPCLoader(string npcType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcType);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetLegacyNPCLoader_Public_LegacyNPCLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LegacyNPCLoader>(intPtr2) : null;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00104C5C File Offset: 0x00102E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129621, RefRangeEnd = 129623, XrefRangeStart = 129600, XrefRangeEnd = 129621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCLoader GetNPCLoader(string npcType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcType);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCLoader>(intPtr2) : null;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x00104CAC File Offset: 0x00102EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129630, RefRangeEnd = 129631, XrefRangeStart = 129623, XrefRangeEnd = 129630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLoadStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_GetLoadStatusText_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00104CE4 File Offset: 0x00102EE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129650, RefRangeEnd = 129654, XrefRangeStart = 129631, XrefRangeEnd = 129650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame(SaveInfo info, bool allowLoadStacking = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref allowLoadStacking;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00104D34 File Offset: 0x00102F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129673, RefRangeEnd = 129674, XrefRangeStart = 129654, XrefRangeEnd = 129673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTutorialAsClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00104D68 File Offset: 0x00102F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129694, RefRangeEnd = 129695, XrefRangeStart = 129674, XrefRangeEnd = 129694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00104DAC File Offset: 0x00102FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129695, XrefRangeEnd = 129701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLoadErrorAutosubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00104DE0 File Offset: 0x00102FE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 129701, RefRangeEnd = 129703, XrefRangeStart = 129701, XrefRangeEnd = 129701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitingForHostLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00104E14 File Offset: 0x00103014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129703, XrefRangeEnd = 129710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLastSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_LoadLastSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x00104E48 File Offset: 0x00103048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 129785, RefRangeEnd = 129788, XrefRangeStart = 129710, XrefRangeEnd = 129785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanUp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_CleanUp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x00104E7C File Offset: 0x0010307C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 129848, RefRangeEnd = 129855, XrefRangeStart = 129788, XrefRangeEnd = 129848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitToMenu(SaveInfo autoLoadSave = null, MainMenuPopup.Data mainMenuPopup = null, bool preventLeaveLobby = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(autoLoadSave);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainMenuPopup);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref preventLeaveLobby;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x00104EE0 File Offset: 0x001030E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130003, RefRangeEnd = 130005, XrefRangeStart = 129855, XrefRangeEnd = 130003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryLoadSaveInfo(string saveFolderPath, int saveSlotIndex, out SaveInfo saveInfo, bool requireGameFile = false)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref saveSlotIndex;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref requireGameFile;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_TryLoadSaveInfo_Public_Static_Boolean_String_Int32_byref_SaveInfo_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			saveInfo = ((intPtr2 == 0) ? null : new SaveInfo(intPtr2));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00104F60 File Offset: 0x00103160
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 130057, RefRangeEnd = 130060, XrefRangeStart = 130005, XrefRangeEnd = 130057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSaveInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00104F94 File Offset: 0x00103194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130060, XrefRangeEnd = 130101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00104FD0 File Offset: 0x001031D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130101, XrefRangeEnd = 130127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_PDM_0()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00104FF8 File Offset: 0x001031F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130127, XrefRangeEnd = 130132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00018609 File Offset: 0x00016809
		public LoadManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x00105038 File Offset: 0x00103238
		// (set) Token: 0x06002DB2 RID: 11698 RVA: 0x00018612 File Offset: 0x00016812
		public unsafe static int LOADS_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOADS_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x00105054 File Offset: 0x00103254
		// (set) Token: 0x06002DB4 RID: 11700 RVA: 0x00018620 File Offset: 0x00016820
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x00105070 File Offset: 0x00103270
		// (set) Token: 0x06002DB6 RID: 11702 RVA: 0x0001862E File Offset: 0x0001682E
		public unsafe static float LOAD_ERROR_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x0010508C File Offset: 0x0010328C
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x0001863C File Offset: 0x0001683C
		public unsafe static float NETWORK_TIMEOUT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_NETWORK_TIMEOUT, (void*)(&value));
			}
		}

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x001050A8 File Offset: 0x001032A8
		// (set) Token: 0x06002DBA RID: 11706 RVA: 0x0001864A File Offset: 0x0001684A
		public unsafe static List<string> LoadHistory
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LoadHistory, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LoadHistory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06002DBB RID: 11707 RVA: 0x001050D0 File Offset: 0x001032D0
		// (set) Token: 0x06002DBC RID: 11708 RVA: 0x0001865C File Offset: 0x0001685C
		public unsafe static Il2CppReferenceArray<SaveInfo> SaveGames
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_SaveGames, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SaveInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_SaveGames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06002DBD RID: 11709 RVA: 0x001050F8 File Offset: 0x001032F8
		// (set) Token: 0x06002DBE RID: 11710 RVA: 0x0001866E File Offset: 0x0001686E
		public unsafe static SaveInfo LastPlayedGame
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadManager.NativeFieldInfoPtr_LastPlayedGame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06002DBF RID: 11711 RVA: 0x00105120 File Offset: 0x00103320
		// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x00018680 File Offset: 0x00016880
		public unsafe bool _IsGameLoaded_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x00105148 File Offset: 0x00103348
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x0001869B File Offset: 0x0001689B
		public unsafe bool _IsLoading_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__IsLoading_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x00105170 File Offset: 0x00103370
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x000186B6 File Offset: 0x000168B6
		public unsafe float _TimeSinceGameLoaded_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x00105198 File Offset: 0x00103398
		// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x000186D1 File Offset: 0x000168D1
		public unsafe bool _DebugMode_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__DebugMode_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x001051C0 File Offset: 0x001033C0
		// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x000186EC File Offset: 0x000168EC
		public unsafe LoadManager.ELoadStatus _LoadStatus_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadStatus_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x001051E8 File Offset: 0x001033E8
		// (set) Token: 0x06002DCA RID: 11722 RVA: 0x00018707 File Offset: 0x00016907
		public unsafe string _LoadedGameFolderPath_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x00105210 File Offset: 0x00103410
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x00018726 File Offset: 0x00016926
		public unsafe SaveInfo _ActiveSaveInfo_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x00105240 File Offset: 0x00103440
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x00018745 File Offset: 0x00016945
		public unsafe SaveInfo _StoredSaveInfo_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr__StoredSaveInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x00105270 File Offset: 0x00103470
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x00018764 File Offset: 0x00016964
		public unsafe List<LoadRequest> loadRequests
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LoadRequest>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_loadRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x001052A0 File Offset: 0x001034A0
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x00018783 File Offset: 0x00016983
		public unsafe List<ItemLoader> ItemLoaders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemLoader>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ItemLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x001052D0 File Offset: 0x001034D0
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x000187A2 File Offset: 0x000169A2
		public unsafe List<BuildableItemLoader> ObjectLoaders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItemLoader>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_ObjectLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x00105300 File Offset: 0x00103500
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x000187C1 File Offset: 0x000169C1
		public unsafe List<LegacyNPCLoader> LegacyNPCLoaders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_LegacyNPCLoaders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LegacyNPCLoader>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_LegacyNPCLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x00105330 File Offset: 0x00103530
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x000187E0 File Offset: 0x000169E0
		public unsafe List<NPCLoader> NPCLoaders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCLoader>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_NPCLoaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x00105360 File Offset: 0x00103560
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x000187FF File Offset: 0x000169FF
		public unsafe UnityEvent onPreSceneChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreSceneChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x00105390 File Offset: 0x00103590
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x0001881E File Offset: 0x00016A1E
		public unsafe UnityEvent onPreLoad
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onPreLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x001053C0 File Offset: 0x001035C0
		// (set) Token: 0x06002DDE RID: 11742 RVA: 0x0001883D File Offset: 0x00016A3D
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06002DDF RID: 11743 RVA: 0x001053F0 File Offset: 0x001035F0
		// (set) Token: 0x06002DE0 RID: 11744 RVA: 0x0001885C File Offset: 0x00016A5C
		public unsafe UnityEvent onSaveInfoLoaded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.NativeFieldInfoPtr_onSaveInfoLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E33 RID: 7731
		private static readonly System.IntPtr NativeFieldInfoPtr_LOADS_PER_FRAME;

		// Token: 0x04001E34 RID: 7732
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001E35 RID: 7733
		private static readonly System.IntPtr NativeFieldInfoPtr_LOAD_ERROR_TIMEOUT;

		// Token: 0x04001E36 RID: 7734
		private static readonly System.IntPtr NativeFieldInfoPtr_NETWORK_TIMEOUT;

		// Token: 0x04001E37 RID: 7735
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadHistory;

		// Token: 0x04001E38 RID: 7736
		private static readonly System.IntPtr NativeFieldInfoPtr_SaveGames;

		// Token: 0x04001E39 RID: 7737
		private static readonly System.IntPtr NativeFieldInfoPtr_LastPlayedGame;

		// Token: 0x04001E3A RID: 7738
		private static readonly System.IntPtr NativeFieldInfoPtr__IsGameLoaded_k__BackingField;

		// Token: 0x04001E3B RID: 7739
		private static readonly System.IntPtr NativeFieldInfoPtr__IsLoading_k__BackingField;

		// Token: 0x04001E3C RID: 7740
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeSinceGameLoaded_k__BackingField;

		// Token: 0x04001E3D RID: 7741
		private static readonly System.IntPtr NativeFieldInfoPtr__DebugMode_k__BackingField;

		// Token: 0x04001E3E RID: 7742
		private static readonly System.IntPtr NativeFieldInfoPtr__LoadStatus_k__BackingField;

		// Token: 0x04001E3F RID: 7743
		private static readonly System.IntPtr NativeFieldInfoPtr__LoadedGameFolderPath_k__BackingField;

		// Token: 0x04001E40 RID: 7744
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveSaveInfo_k__BackingField;

		// Token: 0x04001E41 RID: 7745
		private static readonly System.IntPtr NativeFieldInfoPtr__StoredSaveInfo_k__BackingField;

		// Token: 0x04001E42 RID: 7746
		private static readonly System.IntPtr NativeFieldInfoPtr_loadRequests;

		// Token: 0x04001E43 RID: 7747
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemLoaders;

		// Token: 0x04001E44 RID: 7748
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectLoaders;

		// Token: 0x04001E45 RID: 7749
		private static readonly System.IntPtr NativeFieldInfoPtr_LegacyNPCLoaders;

		// Token: 0x04001E46 RID: 7750
		private static readonly System.IntPtr NativeFieldInfoPtr_NPCLoaders;

		// Token: 0x04001E47 RID: 7751
		private static readonly System.IntPtr NativeFieldInfoPtr_onPreSceneChange;

		// Token: 0x04001E48 RID: 7752
		private static readonly System.IntPtr NativeFieldInfoPtr_onPreLoad;

		// Token: 0x04001E49 RID: 7753
		private static readonly System.IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001E4A RID: 7754
		private static readonly System.IntPtr NativeFieldInfoPtr_onSaveInfoLoaded;

		// Token: 0x04001E4B RID: 7755
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultTutorialSaveFolder_Public_get_String_0;

		// Token: 0x04001E4C RID: 7756
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsGameLoaded_Public_get_Boolean_0;

		// Token: 0x04001E4D RID: 7757
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsGameLoaded_Protected_set_Void_Boolean_0;

		// Token: 0x04001E4E RID: 7758
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoading_Public_get_Boolean_0;

		// Token: 0x04001E4F RID: 7759
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLoading_Protected_set_Void_Boolean_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeSinceGameLoaded_Public_get_Single_0;

		// Token: 0x04001E51 RID: 7761
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeSinceGameLoaded_Protected_set_Void_Single_0;

		// Token: 0x04001E52 RID: 7762
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DebugMode_Public_get_Boolean_0;

		// Token: 0x04001E53 RID: 7763
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DebugMode_Protected_set_Void_Boolean_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadStatus_Public_get_ELoadStatus_0;

		// Token: 0x04001E55 RID: 7765
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadStatus_Protected_set_Void_ELoadStatus_0;

		// Token: 0x04001E56 RID: 7766
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadedGameFolderPath_Public_get_String_0;

		// Token: 0x04001E57 RID: 7767
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LoadedGameFolderPath_Protected_set_Void_String_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001E59 RID: 7769
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001E5A RID: 7770
		private static readonly System.IntPtr NativeMethodInfoPtr_get_StoredSaveInfo_Public_get_SaveInfo_0;

		// Token: 0x04001E5B RID: 7771
		private static readonly System.IntPtr NativeMethodInfoPtr_set_StoredSaveInfo_Private_set_Void_SaveInfo_0;

		// Token: 0x04001E5C RID: 7772
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001E5D RID: 7773
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001E5E RID: 7774
		private static readonly System.IntPtr NativeMethodInfoPtr_Bananas_Private_Void_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeItemLoaders_Private_Void_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeObjectLoaders_Private_Void_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeNPCLoaders_Private_Void_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly System.IntPtr NativeMethodInfoPtr_DequeueLoadRequest_Public_Void_LoadRequest_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly System.IntPtr NativeMethodInfoPtr_GetItemLoader_Public_ItemLoader_String_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectLoader_Public_BuildableItemLoader_String_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLegacyNPCLoader_Public_LegacyNPCLoader_String_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNPCLoader_Public_NPCLoader_String_0;

		// Token: 0x04001E69 RID: 7785
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLoadStatusText_Public_String_0;

		// Token: 0x04001E6A RID: 7786
		private static readonly System.IntPtr NativeMethodInfoPtr_StartGame_Public_Void_SaveInfo_Boolean_0;

		// Token: 0x04001E6B RID: 7787
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadTutorialAsClient_Public_Void_0;

		// Token: 0x04001E6C RID: 7788
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadAsClient_Public_Void_String_0;

		// Token: 0x04001E6D RID: 7789
		private static readonly System.IntPtr NativeMethodInfoPtr_StartLoadErrorAutosubmit_Private_Void_0;

		// Token: 0x04001E6E RID: 7790
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWaitingForHostLoad_Public_Void_0;

		// Token: 0x04001E6F RID: 7791
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadLastSave_Public_Void_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly System.IntPtr NativeMethodInfoPtr_CleanUp_Private_Void_0;

		// Token: 0x04001E71 RID: 7793
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitToMenu_Public_Void_SaveInfo_Data_Boolean_0;

		// Token: 0x04001E72 RID: 7794
		private static readonly System.IntPtr NativeMethodInfoPtr_TryLoadSaveInfo_Public_Static_Boolean_String_Int32_byref_SaveInfo_Boolean_0;

		// Token: 0x04001E73 RID: 7795
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSaveInfo_Public_Void_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E75 RID: 7797
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_PDM_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000920 RID: 2336
		[OriginalName("Assembly-CSharp.dll", "", "ELoadStatus")]
		public enum ELoadStatus
		{
			// Token: 0x0400889C RID: 34972
			None,
			// Token: 0x0400889D RID: 34973
			LoadingScene,
			// Token: 0x0400889E RID: 34974
			Initializing,
			// Token: 0x0400889F RID: 34975
			LoadingData,
			// Token: 0x040088A0 RID: 34976
			SpawningPlayer,
			// Token: 0x040088A1 RID: 34977
			WaitingForHost
		}

		// Token: 0x02000921 RID: 2337
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<<StartLoadErrorAutosubmit>g__Wait|68_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C950 RID: 51536 RVA: 0x00312A70 File Offset: 0x00310C70
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique()
			{
				Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<<StartLoadErrorAutosubmit>g__Wait|68_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>1__state");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>2__current");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<>4__this");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, "<t>5__2");
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668523);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668524);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668525);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668526);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668527);
				LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr, 100668528);
			}

			// Token: 0x0600C951 RID: 51537 RVA: 0x00312B64 File Offset: 0x00310D64
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C952 RID: 51538 RVA: 0x00312BAC File Offset: 0x00310DAC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C953 RID: 51539 RVA: 0x00312BE0 File Offset: 0x00310DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128233, XrefRangeEnd = 128246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E93 RID: 16019
			// (get) Token: 0x0600C954 RID: 51540 RVA: 0x00312C1C File Offset: 0x00310E1C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C955 RID: 51541 RVA: 0x00312C5C File Offset: 0x00310E5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128246, XrefRangeEnd = 128251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E94 RID: 16020
			// (get) Token: 0x0600C956 RID: 51542 RVA: 0x00312C90 File Offset: 0x00310E90
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C957 RID: 51543 RVA: 0x00061A25 File Offset: 0x0005FC25
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E8F RID: 16015
			// (get) Token: 0x0600C958 RID: 51544 RVA: 0x00312CD0 File Offset: 0x00310ED0
			// (set) Token: 0x0600C959 RID: 51545 RVA: 0x00061A2E File Offset: 0x0005FC2E
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E90 RID: 16016
			// (get) Token: 0x0600C95A RID: 51546 RVA: 0x00312CF8 File Offset: 0x00310EF8
			// (set) Token: 0x0600C95B RID: 51547 RVA: 0x00061A49 File Offset: 0x0005FC49
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E91 RID: 16017
			// (get) Token: 0x0600C95C RID: 51548 RVA: 0x00312D28 File Offset: 0x00310F28
			// (set) Token: 0x0600C95D RID: 51549 RVA: 0x00061A68 File Offset: 0x0005FC68
			public unsafe LoadManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E92 RID: 16018
			// (get) Token: 0x0600C95E RID: 51550 RVA: 0x00312D58 File Offset: 0x00310F58
			// (set) Token: 0x0600C95F RID: 51551 RVA: 0x00061A87 File Offset: 0x0005FC87
			public unsafe float _t_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x040088A2 RID: 34978
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088A3 RID: 34979
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088A4 RID: 34980
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088A5 RID: 34981
			private static readonly System.IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x040088A6 RID: 34982
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088A7 RID: 34983
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088A8 RID: 34984
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088A9 RID: 34985
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088AA RID: 34986
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088AB RID: 34987
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000922 RID: 2338
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C960 RID: 51552 RVA: 0x00312D80 File Offset: 0x00310F80
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr);
				LoadManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9");
				LoadManager.__c.NativeFieldInfoPtr___9__65_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_5");
				LoadManager.__c.NativeFieldInfoPtr___9__65_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_1");
				LoadManager.__c.NativeFieldInfoPtr___9__65_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__65_2");
				LoadManager.__c.NativeFieldInfoPtr___9__66_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__66_2");
				LoadManager.__c.NativeFieldInfoPtr___9__66_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__66_3");
				LoadManager.__c.NativeFieldInfoPtr___9__66_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__66_4");
				LoadManager.__c.NativeFieldInfoPtr___9__67_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__67_2");
				LoadManager.__c.NativeFieldInfoPtr___9__67_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__67_3");
				LoadManager.__c.NativeFieldInfoPtr___9__67_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, "<>9__67_4");
				LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668530);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__65_5_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668531);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__65_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668532);
				LoadManager.__c.NativeMethodInfoPtr__StartGame_b__65_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668533);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__66_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668534);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__66_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668535);
				LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__66_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668536);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__67_2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668537);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__67_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668538);
				LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__67_4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr, 100668539);
			}

			// Token: 0x0600C961 RID: 51553 RVA: 0x00312F3C File Offset: 0x0031113C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C962 RID: 51554 RVA: 0x00312F78 File Offset: 0x00311178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128251, XrefRangeEnd = 128252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__65_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__65_5_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C963 RID: 51555 RVA: 0x00312FB4 File Offset: 0x003111B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128252, XrefRangeEnd = 128255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__65_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__65_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C964 RID: 51556 RVA: 0x00312FF0 File Offset: 0x003111F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128255, XrefRangeEnd = 128263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__65_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__StartGame_b__65_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C965 RID: 51557 RVA: 0x0031302C File Offset: 0x0031122C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__66_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__66_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C966 RID: 51558 RVA: 0x00313068 File Offset: 0x00311268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__66_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__66_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C967 RID: 51559 RVA: 0x003130A4 File Offset: 0x003112A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128263, XrefRangeEnd = 128271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__66_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadTutorialAsClient_b__66_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C968 RID: 51560 RVA: 0x003130E0 File Offset: 0x003112E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128271, XrefRangeEnd = 128279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__67_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__67_2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C969 RID: 51561 RVA: 0x0031311C File Offset: 0x0031131C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128279, XrefRangeEnd = 128287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__67_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__67_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C96A RID: 51562 RVA: 0x00313158 File Offset: 0x00311358
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128287, XrefRangeEnd = 128291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__67_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c.NativeMethodInfoPtr__LoadAsClient_b__67_4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C96B RID: 51563 RVA: 0x00061AA2 File Offset: 0x0005FCA2
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E95 RID: 16021
			// (get) Token: 0x0600C96C RID: 51564 RVA: 0x00313194 File Offset: 0x00311394
			// (set) Token: 0x0600C96D RID: 51565 RVA: 0x00061AAB File Offset: 0x0005FCAB
			public unsafe static LoadManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E96 RID: 16022
			// (get) Token: 0x0600C96E RID: 51566 RVA: 0x003131BC File Offset: 0x003113BC
			// (set) Token: 0x0600C96F RID: 51567 RVA: 0x00061ABD File Offset: 0x0005FCBD
			public unsafe static Il2CppSystem.Func<bool> __9__65_5
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_5, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E97 RID: 16023
			// (get) Token: 0x0600C970 RID: 51568 RVA: 0x003131E4 File Offset: 0x003113E4
			// (set) Token: 0x0600C971 RID: 51569 RVA: 0x00061ACF File Offset: 0x0005FCCF
			public unsafe static Il2CppSystem.Func<bool> __9__65_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E98 RID: 16024
			// (get) Token: 0x0600C972 RID: 51570 RVA: 0x0031320C File Offset: 0x0031140C
			// (set) Token: 0x0600C973 RID: 51571 RVA: 0x00061AE1 File Offset: 0x0005FCE1
			public unsafe static Il2CppSystem.Func<bool> __9__65_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__65_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__65_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E99 RID: 16025
			// (get) Token: 0x0600C974 RID: 51572 RVA: 0x00313234 File Offset: 0x00311434
			// (set) Token: 0x0600C975 RID: 51573 RVA: 0x00061AF3 File Offset: 0x0005FCF3
			public unsafe static Il2CppSystem.Func<bool> __9__66_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__66_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__66_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E9A RID: 16026
			// (get) Token: 0x0600C976 RID: 51574 RVA: 0x0031325C File Offset: 0x0031145C
			// (set) Token: 0x0600C977 RID: 51575 RVA: 0x00061B05 File Offset: 0x0005FD05
			public unsafe static Il2CppSystem.Func<bool> __9__66_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__66_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__66_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E9B RID: 16027
			// (get) Token: 0x0600C978 RID: 51576 RVA: 0x00313284 File Offset: 0x00311484
			// (set) Token: 0x0600C979 RID: 51577 RVA: 0x00061B17 File Offset: 0x0005FD17
			public unsafe static Il2CppSystem.Func<bool> __9__66_4
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__66_4, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__66_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E9C RID: 16028
			// (get) Token: 0x0600C97A RID: 51578 RVA: 0x003132AC File Offset: 0x003114AC
			// (set) Token: 0x0600C97B RID: 51579 RVA: 0x00061B29 File Offset: 0x0005FD29
			public unsafe static Il2CppSystem.Func<bool> __9__67_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__67_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__67_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E9D RID: 16029
			// (get) Token: 0x0600C97C RID: 51580 RVA: 0x003132D4 File Offset: 0x003114D4
			// (set) Token: 0x0600C97D RID: 51581 RVA: 0x00061B3B File Offset: 0x0005FD3B
			public unsafe static Il2CppSystem.Func<bool> __9__67_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__67_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__67_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E9E RID: 16030
			// (get) Token: 0x0600C97E RID: 51582 RVA: 0x003132FC File Offset: 0x003114FC
			// (set) Token: 0x0600C97F RID: 51583 RVA: 0x00061B4D File Offset: 0x0005FD4D
			public unsafe static Il2CppSystem.Func<bool> __9__67_4
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LoadManager.__c.NativeFieldInfoPtr___9__67_4, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LoadManager.__c.NativeFieldInfoPtr___9__67_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088AC RID: 34988
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040088AD RID: 34989
			private static readonly System.IntPtr NativeFieldInfoPtr___9__65_5;

			// Token: 0x040088AE RID: 34990
			private static readonly System.IntPtr NativeFieldInfoPtr___9__65_1;

			// Token: 0x040088AF RID: 34991
			private static readonly System.IntPtr NativeFieldInfoPtr___9__65_2;

			// Token: 0x040088B0 RID: 34992
			private static readonly System.IntPtr NativeFieldInfoPtr___9__66_2;

			// Token: 0x040088B1 RID: 34993
			private static readonly System.IntPtr NativeFieldInfoPtr___9__66_3;

			// Token: 0x040088B2 RID: 34994
			private static readonly System.IntPtr NativeFieldInfoPtr___9__66_4;

			// Token: 0x040088B3 RID: 34995
			private static readonly System.IntPtr NativeFieldInfoPtr___9__67_2;

			// Token: 0x040088B4 RID: 34996
			private static readonly System.IntPtr NativeFieldInfoPtr___9__67_3;

			// Token: 0x040088B5 RID: 34997
			private static readonly System.IntPtr NativeFieldInfoPtr___9__67_4;

			// Token: 0x040088B6 RID: 34998
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088B7 RID: 34999
			private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__65_5_Internal_Boolean_0;

			// Token: 0x040088B8 RID: 35000
			private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__65_1_Internal_Boolean_0;

			// Token: 0x040088B9 RID: 35001
			private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__65_2_Internal_Boolean_0;

			// Token: 0x040088BA RID: 35002
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__66_2_Internal_Boolean_0;

			// Token: 0x040088BB RID: 35003
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__66_3_Internal_Boolean_0;

			// Token: 0x040088BC RID: 35004
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__66_4_Internal_Boolean_0;

			// Token: 0x040088BD RID: 35005
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadAsClient_b__67_2_Internal_Boolean_0;

			// Token: 0x040088BE RID: 35006
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadAsClient_b__67_3_Internal_Boolean_0;

			// Token: 0x040088BF RID: 35007
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadAsClient_b__67_4_Internal_Boolean_0;
		}

		// Token: 0x02000923 RID: 2339
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C980 RID: 51584 RVA: 0x00313324 File Offset: 0x00311524
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_itemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, "itemType");
				LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, 100668540);
				LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr, 100668541);
			}

			// Token: 0x0600C981 RID: 51585 RVA: 0x0031338C File Offset: 0x0031158C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass60_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C982 RID: 51586 RVA: 0x003133C8 File Offset: 0x003115C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128291, XrefRangeEnd = 128293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetItemLoader_b__0(ItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass60_0.NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C983 RID: 51587 RVA: 0x00061B5F File Offset: 0x0005FD5F
			public __c__DisplayClass60_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E9F RID: 16031
			// (get) Token: 0x0600C984 RID: 51588 RVA: 0x00313418 File Offset: 0x00311618
			// (set) Token: 0x0600C985 RID: 51589 RVA: 0x00061B68 File Offset: 0x0005FD68
			public unsafe string itemType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_itemType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass60_0.NativeFieldInfoPtr_itemType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088C0 RID: 35008
			private static readonly System.IntPtr NativeFieldInfoPtr_itemType;

			// Token: 0x040088C1 RID: 35009
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088C2 RID: 35010
			private static readonly System.IntPtr NativeMethodInfoPtr__GetItemLoader_b__0_Internal_Boolean_ItemLoader_0;
		}

		// Token: 0x02000924 RID: 2340
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass61_0")]
		public sealed class __c__DisplayClass61_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C986 RID: 51590 RVA: 0x00313440 File Offset: 0x00311640
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass61_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass61_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, "objectType");
				LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, 100668542);
				LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr, 100668543);
			}

			// Token: 0x0600C987 RID: 51591 RVA: 0x003134A8 File Offset: 0x003116A8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass61_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass61_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C988 RID: 51592 RVA: 0x003134E4 File Offset: 0x003116E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128293, XrefRangeEnd = 128295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetObjectLoader_b__0(BuildableItemLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass61_0.NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C989 RID: 51593 RVA: 0x00061B87 File Offset: 0x0005FD87
			public __c__DisplayClass61_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA0 RID: 16032
			// (get) Token: 0x0600C98A RID: 51594 RVA: 0x00313534 File Offset: 0x00311734
			// (set) Token: 0x0600C98B RID: 51595 RVA: 0x00061B90 File Offset: 0x0005FD90
			public unsafe string objectType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_objectType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass61_0.NativeFieldInfoPtr_objectType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088C3 RID: 35011
			private static readonly System.IntPtr NativeFieldInfoPtr_objectType;

			// Token: 0x040088C4 RID: 35012
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088C5 RID: 35013
			private static readonly System.IntPtr NativeMethodInfoPtr__GetObjectLoader_b__0_Internal_Boolean_BuildableItemLoader_0;
		}

		// Token: 0x02000925 RID: 2341
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass62_0")]
		public sealed class __c__DisplayClass62_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C98C RID: 51596 RVA: 0x0031355C File Offset: 0x0031175C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass62_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass62_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass62_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass62_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass62_0.NativeFieldInfoPtr_npcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass62_0>.NativeClassPtr, "npcType");
				LoadManager.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass62_0>.NativeClassPtr, 100668544);
				LoadManager.__c__DisplayClass62_0.NativeMethodInfoPtr__GetLegacyNPCLoader_b__0_Internal_Boolean_LegacyNPCLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass62_0>.NativeClassPtr, 100668545);
			}

			// Token: 0x0600C98D RID: 51597 RVA: 0x003135C4 File Offset: 0x003117C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass62_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass62_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass62_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C98E RID: 51598 RVA: 0x00313600 File Offset: 0x00311800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLegacyNPCLoader_b__0(LegacyNPCLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass62_0.NativeMethodInfoPtr__GetLegacyNPCLoader_b__0_Internal_Boolean_LegacyNPCLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C98F RID: 51599 RVA: 0x00061BAF File Offset: 0x0005FDAF
			public __c__DisplayClass62_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA1 RID: 16033
			// (get) Token: 0x0600C990 RID: 51600 RVA: 0x00313650 File Offset: 0x00311850
			// (set) Token: 0x0600C991 RID: 51601 RVA: 0x00061BB8 File Offset: 0x0005FDB8
			public unsafe string npcType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass62_0.NativeFieldInfoPtr_npcType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass62_0.NativeFieldInfoPtr_npcType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088C6 RID: 35014
			private static readonly System.IntPtr NativeFieldInfoPtr_npcType;

			// Token: 0x040088C7 RID: 35015
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088C8 RID: 35016
			private static readonly System.IntPtr NativeMethodInfoPtr__GetLegacyNPCLoader_b__0_Internal_Boolean_LegacyNPCLoader_0;
		}

		// Token: 0x02000926 RID: 2342
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass63_0")]
		public sealed class __c__DisplayClass63_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C992 RID: 51602 RVA: 0x00313678 File Offset: 0x00311878
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass63_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass63_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_npcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, "npcType");
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668546);
				LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr, 100668547);
			}

			// Token: 0x0600C993 RID: 51603 RVA: 0x003136E0 File Offset: 0x003118E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass63_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass63_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C994 RID: 51604 RVA: 0x0031371C File Offset: 0x0031191C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetNPCLoader_b__0(NPCLoader loader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loader);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass63_0.NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C995 RID: 51605 RVA: 0x00061BD7 File Offset: 0x0005FDD7
			public __c__DisplayClass63_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA2 RID: 16034
			// (get) Token: 0x0600C996 RID: 51606 RVA: 0x0031376C File Offset: 0x0031196C
			// (set) Token: 0x0600C997 RID: 51607 RVA: 0x00061BE0 File Offset: 0x0005FDE0
			public unsafe string npcType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_npcType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass63_0.NativeFieldInfoPtr_npcType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088C9 RID: 35017
			private static readonly System.IntPtr NativeFieldInfoPtr_npcType;

			// Token: 0x040088CA RID: 35018
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088CB RID: 35019
			private static readonly System.IntPtr NativeMethodInfoPtr__GetNPCLoader_b__0_Internal_Boolean_NPCLoader_0;
		}

		// Token: 0x02000927 RID: 2343
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0")]
		public sealed class __c__DisplayClass65_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C998 RID: 51608 RVA: 0x00313794 File Offset: 0x00311994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass65_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "info");
				LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668548);
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668549);
				LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, 100668550);
			}

			// Token: 0x0600C999 RID: 51609 RVA: 0x00313824 File Offset: 0x00311A24
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C99A RID: 51610 RVA: 0x00313860 File Offset: 0x00311A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128595, XrefRangeEnd = 128600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C99B RID: 51611 RVA: 0x003138A0 File Offset: 0x00311AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128600, XrefRangeEnd = 128605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C99C RID: 51612 RVA: 0x00061BFF File Offset: 0x0005FDFF
			public __c__DisplayClass65_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA3 RID: 16035
			// (get) Token: 0x0600C99D RID: 51613 RVA: 0x003138E0 File Offset: 0x00311AE0
			// (set) Token: 0x0600C99E RID: 51614 RVA: 0x00061C08 File Offset: 0x0005FE08
			public unsafe SaveInfo info
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_info);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EA4 RID: 16036
			// (get) Token: 0x0600C99F RID: 51615 RVA: 0x00313910 File Offset: 0x00311B10
			// (set) Token: 0x0600C9A0 RID: 51616 RVA: 0x00061C27 File Offset: 0x0005FE27
			public unsafe LoadManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088CC RID: 35020
			private static readonly System.IntPtr NativeFieldInfoPtr_info;

			// Token: 0x040088CD RID: 35021
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088CE RID: 35022
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088CF RID: 35023
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040088D0 RID: 35024
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000C91 RID: 3217
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0+<<StartGame>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E721 RID: 59169 RVA: 0x003671A0 File Offset: 0x003653A0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<<StartGame>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<playingTutorial>5__2");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__3");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, "<yak>5__4");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668551);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668552);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668553);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668554);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668555);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr, 100668556);
				}

				// Token: 0x0600E722 RID: 59170 RVA: 0x003672BC File Offset: 0x003654BC
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E723 RID: 59171 RVA: 0x00367304 File Offset: 0x00365504
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E724 RID: 59172 RVA: 0x00367338 File Offset: 0x00365538
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128295, XrefRangeEnd = 128566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004752 RID: 18258
				// (get) Token: 0x0600E725 RID: 59173 RVA: 0x00367374 File Offset: 0x00365574
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E726 RID: 59174 RVA: 0x003673B4 File Offset: 0x003655B4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128566, XrefRangeEnd = 128571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004753 RID: 18259
				// (get) Token: 0x0600E727 RID: 59175 RVA: 0x003673E8 File Offset: 0x003655E8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E728 RID: 59176 RVA: 0x000705F5 File Offset: 0x0006E7F5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700474C RID: 18252
				// (get) Token: 0x0600E729 RID: 59177 RVA: 0x00367428 File Offset: 0x00365628
				// (set) Token: 0x0600E72A RID: 59178 RVA: 0x000705FE File Offset: 0x0006E7FE
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700474D RID: 18253
				// (get) Token: 0x0600E72B RID: 59179 RVA: 0x00367450 File Offset: 0x00365650
				// (set) Token: 0x0600E72C RID: 59180 RVA: 0x00070619 File Offset: 0x0006E819
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700474E RID: 18254
				// (get) Token: 0x0600E72D RID: 59181 RVA: 0x00367480 File Offset: 0x00365680
				// (set) Token: 0x0600E72E RID: 59182 RVA: 0x00070638 File Offset: 0x0006E838
				public unsafe LoadManager.__c__DisplayClass65_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass65_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700474F RID: 18255
				// (get) Token: 0x0600E72F RID: 59183 RVA: 0x003674B0 File Offset: 0x003656B0
				// (set) Token: 0x0600E730 RID: 59184 RVA: 0x00070657 File Offset: 0x0006E857
				public unsafe bool _playingTutorial_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__playingTutorial_5__2)) = value;
					}
				}

				// Token: 0x17004750 RID: 18256
				// (get) Token: 0x0600E731 RID: 59185 RVA: 0x003674D8 File Offset: 0x003656D8
				// (set) Token: 0x0600E732 RID: 59186 RVA: 0x00070672 File Offset: 0x0006E872
				public unsafe AsyncOperation _asyncLoad_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004751 RID: 18257
				// (get) Token: 0x0600E733 RID: 59187 RVA: 0x00367508 File Offset: 0x00365708
				// (set) Token: 0x0600E734 RID: 59188 RVA: 0x00070691 File Offset: 0x0006E891
				public unsafe Yak _yak_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoAsYaObObUnique.NativeFieldInfoPtr__yak_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009ACA RID: 39626
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009ACB RID: 39627
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009ACC RID: 39628
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009ACD RID: 39629
				private static readonly System.IntPtr NativeFieldInfoPtr__playingTutorial_5__2;

				// Token: 0x04009ACE RID: 39630
				private static readonly System.IntPtr NativeFieldInfoPtr__asyncLoad_5__3;

				// Token: 0x04009ACF RID: 39631
				private static readonly System.IntPtr NativeFieldInfoPtr__yak_5__4;

				// Token: 0x04009AD0 RID: 39632
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AD1 RID: 39633
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AD2 RID: 39634
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AD3 RID: 39635
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AD4 RID: 39636
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AD5 RID: 39637
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000C92 RID: 3218
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_0+<<StartGame>g__Load|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E735 RID: 59189 RVA: 0x00367538 File Offset: 0x00365738
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0>.NativeClassPtr, "<<StartGame>g__Load|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668557);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668558);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668559);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668560);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668561);
					LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668562);
				}

				// Token: 0x0600E736 RID: 59190 RVA: 0x00367618 File Offset: 0x00365818
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E737 RID: 59191 RVA: 0x00367660 File Offset: 0x00365860
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E738 RID: 59192 RVA: 0x00367694 File Offset: 0x00365894
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128571, XrefRangeEnd = 128590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004757 RID: 18263
				// (get) Token: 0x0600E739 RID: 59193 RVA: 0x003676D0 File Offset: 0x003658D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E73A RID: 59194 RVA: 0x00367710 File Offset: 0x00365910
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128590, XrefRangeEnd = 128595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004758 RID: 18264
				// (get) Token: 0x0600E73B RID: 59195 RVA: 0x00367744 File Offset: 0x00365944
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E73C RID: 59196 RVA: 0x000706B0 File Offset: 0x0006E8B0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004754 RID: 18260
				// (get) Token: 0x0600E73D RID: 59197 RVA: 0x00367784 File Offset: 0x00365984
				// (set) Token: 0x0600E73E RID: 59198 RVA: 0x000706B9 File Offset: 0x0006E8B9
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004755 RID: 18261
				// (get) Token: 0x0600E73F RID: 59199 RVA: 0x003677AC File Offset: 0x003659AC
				// (set) Token: 0x0600E740 RID: 59200 RVA: 0x000706D4 File Offset: 0x0006E8D4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004756 RID: 18262
				// (get) Token: 0x0600E741 RID: 59201 RVA: 0x003677DC File Offset: 0x003659DC
				// (set) Token: 0x0600E742 RID: 59202 RVA: 0x000706F3 File Offset: 0x0006E8F3
				public unsafe LoadManager.__c__DisplayClass65_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass65_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009AD6 RID: 39638
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AD7 RID: 39639
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AD8 RID: 39640
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AD9 RID: 39641
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009ADA RID: 39642
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009ADB RID: 39643
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009ADC RID: 39644
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009ADD RID: 39645
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009ADE RID: 39646
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000928 RID: 2344
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass65_1")]
		public sealed class __c__DisplayClass65_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C9A1 RID: 51617 RVA: 0x00313940 File Offset: 0x00311B40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass65_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass65_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass65_1.NativeFieldInfoPtr_fishy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr, "fishy");
				LoadManager.__c__DisplayClass65_1.NativeFieldInfoPtr_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr, "port");
				LoadManager.__c__DisplayClass65_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr, 100668563);
				LoadManager.__c__DisplayClass65_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr, 100668564);
			}

			// Token: 0x0600C9A2 RID: 51618 RVA: 0x003139BC File Offset: 0x00311BBC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass65_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass65_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9A3 RID: 51619 RVA: 0x003139F8 File Offset: 0x00311BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128605, XrefRangeEnd = 128645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_ServerConnectionStateArgs_PDM_0(ServerConnectionStateArgs args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref args;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass65_1.NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9A4 RID: 51620 RVA: 0x00061C46 File Offset: 0x0005FE46
			public __c__DisplayClass65_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA5 RID: 16037
			// (get) Token: 0x0600C9A5 RID: 51621 RVA: 0x00313A38 File Offset: 0x00311C38
			// (set) Token: 0x0600C9A6 RID: 51622 RVA: 0x00061C4F File Offset: 0x0005FE4F
			public unsafe FishySteamworks fishy
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_1.NativeFieldInfoPtr_fishy);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FishySteamworks>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_1.NativeFieldInfoPtr_fishy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EA6 RID: 16038
			// (get) Token: 0x0600C9A7 RID: 51623 RVA: 0x00313A68 File Offset: 0x00311C68
			// (set) Token: 0x0600C9A8 RID: 51624 RVA: 0x00061C6E File Offset: 0x0005FE6E
			public unsafe ushort port
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_1.NativeFieldInfoPtr_port);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass65_1.NativeFieldInfoPtr_port)) = value;
				}
			}

			// Token: 0x040088D1 RID: 35025
			private static readonly System.IntPtr NativeFieldInfoPtr_fishy;

			// Token: 0x040088D2 RID: 35026
			private static readonly System.IntPtr NativeFieldInfoPtr_port;

			// Token: 0x040088D3 RID: 35027
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088D4 RID: 35028
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_ServerConnectionStateArgs_PDM_0;
		}

		// Token: 0x02000929 RID: 2345
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass66_0")]
		public sealed class __c__DisplayClass66_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9A9 RID: 51625 RVA: 0x00313A90 File Offset: 0x00311C90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass66_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass66_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass66_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, 100668565);
				LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, 100668566);
				LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, 100668567);
				LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, 100668568);
			}

			// Token: 0x0600C9AA RID: 51626 RVA: 0x00313B34 File Offset: 0x00311D34
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass66_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9AB RID: 51627 RVA: 0x00313B70 File Offset: 0x00311D70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128862, XrefRangeEnd = 128867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C9AC RID: 51628 RVA: 0x00313BB0 File Offset: 0x00311DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128867, XrefRangeEnd = 128869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadTutorialAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C9AD RID: 51629 RVA: 0x00313BEC File Offset: 0x00311DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128869, XrefRangeEnd = 128874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C9AE RID: 51630 RVA: 0x00061C89 File Offset: 0x0005FE89
			public __c__DisplayClass66_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA7 RID: 16039
			// (get) Token: 0x0600C9AF RID: 51631 RVA: 0x00313C2C File Offset: 0x00311E2C
			// (set) Token: 0x0600C9B0 RID: 51632 RVA: 0x00061C92 File Offset: 0x0005FE92
			public unsafe bool waitForExit
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x17003EA8 RID: 16040
			// (get) Token: 0x0600C9B1 RID: 51633 RVA: 0x00313C54 File Offset: 0x00311E54
			// (set) Token: 0x0600C9B2 RID: 51634 RVA: 0x00061CAD File Offset: 0x0005FEAD
			public unsafe LoadManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088D5 RID: 35029
			private static readonly System.IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040088D6 RID: 35030
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088D7 RID: 35031
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088D8 RID: 35032
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040088D9 RID: 35033
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadTutorialAsClient_b__1_Internal_Boolean_0;

			// Token: 0x040088DA RID: 35034
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02000C93 RID: 3219
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass66_0+<<LoadTutorialAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E743 RID: 59203 RVA: 0x0036780C File Offset: 0x00365A0C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, "<yak>5__3");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668569);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668570);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668571);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668572);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668573);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr, 100668574);
				}

				// Token: 0x0600E744 RID: 59204 RVA: 0x00367914 File Offset: 0x00365B14
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E745 RID: 59205 RVA: 0x0036795C File Offset: 0x00365B5C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E746 RID: 59206 RVA: 0x00367990 File Offset: 0x00365B90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128645, XrefRangeEnd = 128833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700475E RID: 18270
				// (get) Token: 0x0600E747 RID: 59207 RVA: 0x003679CC File Offset: 0x00365BCC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E748 RID: 59208 RVA: 0x00367A0C File Offset: 0x00365C0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128833, XrefRangeEnd = 128838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700475F RID: 18271
				// (get) Token: 0x0600E749 RID: 59209 RVA: 0x00367A40 File Offset: 0x00365C40
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E74A RID: 59210 RVA: 0x00070712 File Offset: 0x0006E912
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004759 RID: 18265
				// (get) Token: 0x0600E74B RID: 59211 RVA: 0x00367A80 File Offset: 0x00365C80
				// (set) Token: 0x0600E74C RID: 59212 RVA: 0x0007071B File Offset: 0x0006E91B
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700475A RID: 18266
				// (get) Token: 0x0600E74D RID: 59213 RVA: 0x00367AA8 File Offset: 0x00365CA8
				// (set) Token: 0x0600E74E RID: 59214 RVA: 0x00070736 File Offset: 0x0006E936
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700475B RID: 18267
				// (get) Token: 0x0600E74F RID: 59215 RVA: 0x00367AD8 File Offset: 0x00365CD8
				// (set) Token: 0x0600E750 RID: 59216 RVA: 0x00070755 File Offset: 0x0006E955
				public unsafe LoadManager.__c__DisplayClass66_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700475C RID: 18268
				// (get) Token: 0x0600E751 RID: 59217 RVA: 0x00367B08 File Offset: 0x00365D08
				// (set) Token: 0x0600E752 RID: 59218 RVA: 0x00070774 File Offset: 0x0006E974
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700475D RID: 18269
				// (get) Token: 0x0600E753 RID: 59219 RVA: 0x00367B38 File Offset: 0x00365D38
				// (set) Token: 0x0600E754 RID: 59220 RVA: 0x00070793 File Offset: 0x0006E993
				public unsafe Yak _yak_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Yak>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsYaObObUnique.NativeFieldInfoPtr__yak_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009ADF RID: 39647
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AE0 RID: 39648
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AE1 RID: 39649
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AE2 RID: 39650
				private static readonly System.IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x04009AE3 RID: 39651
				private static readonly System.IntPtr NativeFieldInfoPtr__yak_5__3;

				// Token: 0x04009AE4 RID: 39652
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AE5 RID: 39653
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AE6 RID: 39654
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AE7 RID: 39655
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AE8 RID: 39656
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AE9 RID: 39657
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02000C94 RID: 3220
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass66_0+<<LoadTutorialAsClient>g__Load|5>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E755 RID: 59221 RVA: 0x00367B68 File Offset: 0x00365D68
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0>.NativeClassPtr, "<<LoadTutorialAsClient>g__Load|5>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668575);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668576);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668577);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668578);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668579);
					LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668580);
				}

				// Token: 0x0600E756 RID: 59222 RVA: 0x00367C48 File Offset: 0x00365E48
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E757 RID: 59223 RVA: 0x00367C90 File Offset: 0x00365E90
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E758 RID: 59224 RVA: 0x00367CC4 File Offset: 0x00365EC4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128838, XrefRangeEnd = 128857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004763 RID: 18275
				// (get) Token: 0x0600E759 RID: 59225 RVA: 0x00367D00 File Offset: 0x00365F00
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E75A RID: 59226 RVA: 0x00367D40 File Offset: 0x00365F40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128857, XrefRangeEnd = 128862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004764 RID: 18276
				// (get) Token: 0x0600E75B RID: 59227 RVA: 0x00367D74 File Offset: 0x00365F74
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E75C RID: 59228 RVA: 0x000707B2 File Offset: 0x0006E9B2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004760 RID: 18272
				// (get) Token: 0x0600E75D RID: 59229 RVA: 0x00367DB4 File Offset: 0x00365FB4
				// (set) Token: 0x0600E75E RID: 59230 RVA: 0x000707BB File Offset: 0x0006E9BB
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004761 RID: 18273
				// (get) Token: 0x0600E75F RID: 59231 RVA: 0x00367DDC File Offset: 0x00365FDC
				// (set) Token: 0x0600E760 RID: 59232 RVA: 0x000707D6 File Offset: 0x0006E9D6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004762 RID: 18274
				// (get) Token: 0x0600E761 RID: 59233 RVA: 0x00367E0C File Offset: 0x0036600C
				// (set) Token: 0x0600E762 RID: 59234 RVA: 0x000707F5 File Offset: 0x0006E9F5
				public unsafe LoadManager.__c__DisplayClass66_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass66_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass66_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009AEA RID: 39658
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AEB RID: 39659
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AEC RID: 39660
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AED RID: 39661
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AEE RID: 39662
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AEF RID: 39663
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AF0 RID: 39664
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AF1 RID: 39665
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AF2 RID: 39666
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200092A RID: 2346
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9B3 RID: 51635 RVA: 0x00313C84 File Offset: 0x00311E84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr_waitForExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, "waitForExit");
				LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr_steamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, "steamId64");
				LoadManager.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, 100668581);
				LoadManager.__c__DisplayClass67_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, 100668582);
				LoadManager.__c__DisplayClass67_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, 100668583);
			}

			// Token: 0x0600C9B4 RID: 51636 RVA: 0x00313D28 File Offset: 0x00311F28
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9B5 RID: 51637 RVA: 0x00313D64 File Offset: 0x00311F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129044, XrefRangeEnd = 129049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C9B6 RID: 51638 RVA: 0x00313DA4 File Offset: 0x00311FA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129049, XrefRangeEnd = 129051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadAsClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C9B7 RID: 51639 RVA: 0x00061CCC File Offset: 0x0005FECC
			public __c__DisplayClass67_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EA9 RID: 16041
			// (get) Token: 0x0600C9B8 RID: 51640 RVA: 0x00313DE0 File Offset: 0x00311FE0
			// (set) Token: 0x0600C9B9 RID: 51641 RVA: 0x00061CD5 File Offset: 0x0005FED5
			public unsafe bool waitForExit
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr_waitForExit);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr_waitForExit)) = value;
				}
			}

			// Token: 0x17003EAA RID: 16042
			// (get) Token: 0x0600C9BA RID: 51642 RVA: 0x00313E08 File Offset: 0x00312008
			// (set) Token: 0x0600C9BB RID: 51643 RVA: 0x00061CF0 File Offset: 0x0005FEF0
			public unsafe LoadManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EAB RID: 16043
			// (get) Token: 0x0600C9BC RID: 51644 RVA: 0x00313E38 File Offset: 0x00312038
			// (set) Token: 0x0600C9BD RID: 51645 RVA: 0x00061D0F File Offset: 0x0005FF0F
			public unsafe string steamId64
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr_steamId64);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.NativeFieldInfoPtr_steamId64), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088DB RID: 35035
			private static readonly System.IntPtr NativeFieldInfoPtr_waitForExit;

			// Token: 0x040088DC RID: 35036
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088DD RID: 35037
			private static readonly System.IntPtr NativeFieldInfoPtr_steamId64;

			// Token: 0x040088DE RID: 35038
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088DF RID: 35039
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040088E0 RID: 35040
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadAsClient_b__1_Internal_Boolean_0;

			// Token: 0x02000C95 RID: 3221
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass67_0+<<LoadAsClient>g__LoadRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E763 RID: 59235 RVA: 0x00367E3C File Offset: 0x0036603C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0>.NativeClassPtr, "<<LoadAsClient>g__LoadRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668584);
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668585);
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668586);
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668587);
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668588);
					LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668589);
				}

				// Token: 0x0600E764 RID: 59236 RVA: 0x00367F1C File Offset: 0x0036611C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E765 RID: 59237 RVA: 0x00367F64 File Offset: 0x00366164
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E766 RID: 59238 RVA: 0x00367F98 File Offset: 0x00366198
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128874, XrefRangeEnd = 129039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004768 RID: 18280
				// (get) Token: 0x0600E767 RID: 59239 RVA: 0x00367FD4 File Offset: 0x003661D4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E768 RID: 59240 RVA: 0x00368014 File Offset: 0x00366214
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129039, XrefRangeEnd = 129044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004769 RID: 18281
				// (get) Token: 0x0600E769 RID: 59241 RVA: 0x00368048 File Offset: 0x00366248
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E76A RID: 59242 RVA: 0x00070814 File Offset: 0x0006EA14
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004765 RID: 18277
				// (get) Token: 0x0600E76B RID: 59243 RVA: 0x00368088 File Offset: 0x00366288
				// (set) Token: 0x0600E76C RID: 59244 RVA: 0x0007081D File Offset: 0x0006EA1D
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004766 RID: 18278
				// (get) Token: 0x0600E76D RID: 59245 RVA: 0x003680B0 File Offset: 0x003662B0
				// (set) Token: 0x0600E76E RID: 59246 RVA: 0x00070838 File Offset: 0x0006EA38
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004767 RID: 18279
				// (get) Token: 0x0600E76F RID: 59247 RVA: 0x003680E0 File Offset: 0x003662E0
				// (set) Token: 0x0600E770 RID: 59248 RVA: 0x00070857 File Offset: 0x0006EA57
				public unsafe LoadManager.__c__DisplayClass67_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass67_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass67_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009AF3 RID: 39667
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AF4 RID: 39668
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AF5 RID: 39669
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AF6 RID: 39670
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AF7 RID: 39671
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AF8 RID: 39672
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AF9 RID: 39673
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AFA RID: 39674
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AFB RID: 39675
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200092B RID: 2347
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass72_0")]
		public sealed class __c__DisplayClass72_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9BE RID: 51646 RVA: 0x00313E60 File Offset: 0x00312060
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_0()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass72_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr);
				LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, "<>4__this");
				LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_autoLoadSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, "autoLoadSave");
				LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_mainMenuPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, "mainMenuPopup");
				LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, 100668590);
				LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, 100668591);
			}

			// Token: 0x0600C9BF RID: 51647 RVA: 0x00313EF0 File Offset: 0x003120F0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9C0 RID: 51648 RVA: 0x00313F2C File Offset: 0x0031212C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129092, XrefRangeEnd = 129097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C9C1 RID: 51649 RVA: 0x00061D2E File Offset: 0x0005FF2E
			public __c__DisplayClass72_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EAC RID: 16044
			// (get) Token: 0x0600C9C2 RID: 51650 RVA: 0x00313F6C File Offset: 0x0031216C
			// (set) Token: 0x0600C9C3 RID: 51651 RVA: 0x00061D37 File Offset: 0x0005FF37
			public unsafe LoadManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EAD RID: 16045
			// (get) Token: 0x0600C9C4 RID: 51652 RVA: 0x00313F9C File Offset: 0x0031219C
			// (set) Token: 0x0600C9C5 RID: 51653 RVA: 0x00061D56 File Offset: 0x0005FF56
			public unsafe SaveInfo autoLoadSave
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_autoLoadSave);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveInfo>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_autoLoadSave), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EAE RID: 16046
			// (get) Token: 0x0600C9C6 RID: 51654 RVA: 0x00313FCC File Offset: 0x003121CC
			// (set) Token: 0x0600C9C7 RID: 51655 RVA: 0x00061D75 File Offset: 0x0005FF75
			public unsafe MainMenuPopup.Data mainMenuPopup
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_mainMenuPopup);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuPopup.Data>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.NativeFieldInfoPtr_mainMenuPopup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088E1 RID: 35041
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088E2 RID: 35042
			private static readonly System.IntPtr NativeFieldInfoPtr_autoLoadSave;

			// Token: 0x040088E3 RID: 35043
			private static readonly System.IntPtr NativeFieldInfoPtr_mainMenuPopup;

			// Token: 0x040088E4 RID: 35044
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088E5 RID: 35045
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C96 RID: 3222
			[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass72_0+<<ExitToMenu>g__Load|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E771 RID: 59249 RVA: 0x00368110 File Offset: 0x00366310
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique()
				{
					Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0>.NativeClassPtr, "<<ExitToMenu>g__Load|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr);
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>1__state");
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>2__current");
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<>4__this");
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, "<asyncLoad>5__2");
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668592);
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668593);
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668594);
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668595);
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668596);
					LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr, 100668597);
				}

				// Token: 0x0600E772 RID: 59250 RVA: 0x00368204 File Offset: 0x00366404
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E773 RID: 59251 RVA: 0x0036824C File Offset: 0x0036644C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E774 RID: 59252 RVA: 0x00368280 File Offset: 0x00366480
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129051, XrefRangeEnd = 129087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700476E RID: 18286
				// (get) Token: 0x0600E775 RID: 59253 RVA: 0x003682BC File Offset: 0x003664BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E776 RID: 59254 RVA: 0x003682FC File Offset: 0x003664FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129087, XrefRangeEnd = 129092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700476F RID: 18287
				// (get) Token: 0x0600E777 RID: 59255 RVA: 0x00368330 File Offset: 0x00366530
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E778 RID: 59256 RVA: 0x00070876 File Offset: 0x0006EA76
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700476A RID: 18282
				// (get) Token: 0x0600E779 RID: 59257 RVA: 0x00368370 File Offset: 0x00366570
				// (set) Token: 0x0600E77A RID: 59258 RVA: 0x0007087F File Offset: 0x0006EA7F
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700476B RID: 18283
				// (get) Token: 0x0600E77B RID: 59259 RVA: 0x00368398 File Offset: 0x00366598
				// (set) Token: 0x0600E77C RID: 59260 RVA: 0x0007089A File Offset: 0x0006EA9A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700476C RID: 18284
				// (get) Token: 0x0600E77D RID: 59261 RVA: 0x003683C8 File Offset: 0x003665C8
				// (set) Token: 0x0600E77E RID: 59262 RVA: 0x000708B9 File Offset: 0x0006EAB9
				public unsafe LoadManager.__c__DisplayClass72_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadManager.__c__DisplayClass72_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700476D RID: 18285
				// (get) Token: 0x0600E77F RID: 59263 RVA: 0x003683F8 File Offset: 0x003665F8
				// (set) Token: 0x0600E780 RID: 59264 RVA: 0x000708D8 File Offset: 0x0006EAD8
				public unsafe AsyncOperation _asyncLoad_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAsObObUnique.NativeFieldInfoPtr__asyncLoad_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009AFC RID: 39676
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009AFD RID: 39677
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009AFE RID: 39678
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009AFF RID: 39679
				private static readonly System.IntPtr NativeFieldInfoPtr__asyncLoad_5__2;

				// Token: 0x04009B00 RID: 39680
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B01 RID: 39681
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B02 RID: 39682
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B03 RID: 39683
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B04 RID: 39684
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B05 RID: 39685
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200092C RID: 2348
		[ObfuscatedName("ScheduleOne.Persistence.LoadManager+<>c__DisplayClass72_1")]
		public sealed class __c__DisplayClass72_1 : Il2CppSystem.Object
		{
			// Token: 0x0600C9C8 RID: 51656 RVA: 0x00313FFC File Offset: 0x003121FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass72_1()
			{
				Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadManager>.NativeClassPtr, "<>c__DisplayClass72_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr);
				LoadManager.__c__DisplayClass72_1.NativeFieldInfoPtr_timeOnWaitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr, "timeOnWaitStart");
				LoadManager.__c__DisplayClass72_1.NativeFieldInfoPtr_maxWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr, "maxWait");
				LoadManager.__c__DisplayClass72_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr, 100668598);
				LoadManager.__c__DisplayClass72_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr, 100668599);
			}

			// Token: 0x0600C9C9 RID: 51657 RVA: 0x00314078 File Offset: 0x00312278
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass72_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadManager.__c__DisplayClass72_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9CA RID: 51658 RVA: 0x003140B4 File Offset: 0x003122B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129097, XrefRangeEnd = 129101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExitToMenu_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LoadManager.__c__DisplayClass72_1.NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C9CB RID: 51659 RVA: 0x00061D94 File Offset: 0x0005FF94
			public __c__DisplayClass72_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EAF RID: 16047
			// (get) Token: 0x0600C9CC RID: 51660 RVA: 0x003140F0 File Offset: 0x003122F0
			// (set) Token: 0x0600C9CD RID: 51661 RVA: 0x00061D9D File Offset: 0x0005FF9D
			public unsafe float timeOnWaitStart
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_1.NativeFieldInfoPtr_timeOnWaitStart);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_1.NativeFieldInfoPtr_timeOnWaitStart)) = value;
				}
			}

			// Token: 0x17003EB0 RID: 16048
			// (get) Token: 0x0600C9CE RID: 51662 RVA: 0x00314118 File Offset: 0x00312318
			// (set) Token: 0x0600C9CF RID: 51663 RVA: 0x00061DB8 File Offset: 0x0005FFB8
			public unsafe float maxWait
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_1.NativeFieldInfoPtr_maxWait);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LoadManager.__c__DisplayClass72_1.NativeFieldInfoPtr_maxWait)) = value;
				}
			}

			// Token: 0x040088E6 RID: 35046
			private static readonly System.IntPtr NativeFieldInfoPtr_timeOnWaitStart;

			// Token: 0x040088E7 RID: 35047
			private static readonly System.IntPtr NativeFieldInfoPtr_maxWait;

			// Token: 0x040088E8 RID: 35048
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088E9 RID: 35049
			private static readonly System.IntPtr NativeMethodInfoPtr__ExitToMenu_b__1_Internal_Boolean_0;
		}
	}
}
