using System;
using Il2CppFishNet.Managing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSteamworks;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200038E RID: 910
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x060045F3 RID: 17907 RVA: 0x0015AC94 File Offset: 0x00158E94
		// Note: this type is marked as 'beforefieldinit'.
		static Lobby()
		{
			Il2CppClassPointerStore<Lobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "Lobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby>.NativeClassPtr);
			Lobby.NativeFieldInfoPtr_ENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "ENABLED");
			Lobby.NativeFieldInfoPtr_PLAYER_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "PLAYER_LIMIT");
			Lobby.NativeFieldInfoPtr_JOIN_READY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "JOIN_READY");
			Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LOAD_TUTORIAL");
			Lobby.NativeFieldInfoPtr_HOST_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "HOST_LOADING");
			Lobby.NativeFieldInfoPtr_NetworkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "NetworkManager");
			Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LobbyID>k__BackingField");
			Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LocalPlayerID>k__BackingField");
			Lobby.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Players");
			Lobby.NativeFieldInfoPtr_onLobbyChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "onLobbyChange");
			Lobby.NativeFieldInfoPtr_LobbyCreatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyCreatedCallback");
			Lobby.NativeFieldInfoPtr_LobbyEnteredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyEnteredCallback");
			Lobby.NativeFieldInfoPtr_ChatUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "ChatUpdateCallback");
			Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "GameLobbyJoinRequestedCallback");
			Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyChatMessageCallback");
			Lobby.NativeFieldInfoPtr_DebugSteamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "DebugSteamId64");
			Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671918);
			Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671919);
			Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671920);
			Lobby.NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671921);
			Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671922);
			Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671923);
			Lobby.NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671924);
			Lobby.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671925);
			Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671926);
			Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671927);
			Lobby.NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671928);
			Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671929);
			Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671930);
			Lobby.NativeMethodInfoPtr_CreateLobby_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671931);
			Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671932);
			Lobby.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671933);
			Lobby.NativeMethodInfoPtr_DebugJoin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671934);
			Lobby.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671935);
			Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671936);
			Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671937);
			Lobby.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671938);
			Lobby.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671939);
			Lobby.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671940);
			Lobby.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671941);
			Lobby.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671942);
			Lobby.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671943);
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x0015B00C File Offset: 0x0015920C
		public unsafe bool IsHost
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 159853, RefRangeEnd = 159873, XrefRangeStart = 159852, XrefRangeEnd = 159853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060045F5 RID: 17909 RVA: 0x0015B048 File Offset: 0x00159248
		// (set) Token: 0x060045F6 RID: 17910 RVA: 0x0015B084 File Offset: 0x00159284
		public unsafe ulong LobbyID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060045F7 RID: 17911 RVA: 0x0015B0C4 File Offset: 0x001592C4
		public unsafe CSteamID LobbySteamID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x0015B100 File Offset: 0x00159300
		public unsafe bool IsInLobby
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 159873, RefRangeEnd = 159908, XrefRangeStart = 159873, XrefRangeEnd = 159873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060045F9 RID: 17913 RVA: 0x0015B13C File Offset: 0x0015933C
		public unsafe int PlayerCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 159926, RefRangeEnd = 159929, XrefRangeStart = 159908, XrefRangeEnd = 159926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x0015B178 File Offset: 0x00159378
		// (set) Token: 0x060045FB RID: 17915 RVA: 0x0015B1B4 File Offset: 0x001593B4
		public unsafe CSteamID LocalPlayerID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060045FC RID: 17916 RVA: 0x0015B1F4 File Offset: 0x001593F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159929, XrefRangeEnd = 159946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045FD RID: 17917 RVA: 0x0015B230 File Offset: 0x00159430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159946, XrefRangeEnd = 159988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045FE RID: 17918 RVA: 0x0015B26C File Offset: 0x0015946C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160038, RefRangeEnd = 160039, XrefRangeStart = 159988, XrefRangeEnd = 160038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x0015B2A0 File Offset: 0x001594A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160054, RefRangeEnd = 160055, XrefRangeStart = 160039, XrefRangeEnd = 160054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenInviteInterface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x0015B2D4 File Offset: 0x001594D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 160065, RefRangeEnd = 160070, XrefRangeStart = 160055, XrefRangeEnd = 160065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x0015B308 File Offset: 0x00159508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160070, XrefRangeEnd = 160071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_CreateLobby_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x0015B33C File Offset: 0x0015953C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160071, XrefRangeEnd = 160078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLaunchLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x0015B374 File Offset: 0x00159574
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 160086, RefRangeEnd = 160090, XrefRangeStart = 160078, XrefRangeEnd = 160086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLobbyMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x0015B3A8 File Offset: 0x001595A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160090, XrefRangeEnd = 160091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugJoin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_DebugJoin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x0015B3DC File Offset: 0x001595DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160097, RefRangeEnd = 160099, XrefRangeStart = 160091, XrefRangeEnd = 160097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoinAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x0015B420 File Offset: 0x00159620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 160108, RefRangeEnd = 160111, XrefRangeStart = 160099, XrefRangeEnd = 160108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLobbyMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x0015B464 File Offset: 0x00159664
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 160118, RefRangeEnd = 160122, XrefRangeStart = 160111, XrefRangeEnd = 160118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004608 RID: 17928 RVA: 0x0015B4B8 File Offset: 0x001596B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160122, XrefRangeEnd = 160169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyCreated(LobbyCreated_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004609 RID: 17929 RVA: 0x0015B4F8 File Offset: 0x001596F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160169, XrefRangeEnd = 160255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyEntered(LobbyEnter_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600460A RID: 17930 RVA: 0x0015B538 File Offset: 0x00159738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160255, XrefRangeEnd = 160270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600460B RID: 17931 RVA: 0x0015B578 File Offset: 0x00159778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160270, XrefRangeEnd = 160283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600460C RID: 17932 RVA: 0x0015B5B8 File Offset: 0x001597B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160283, XrefRangeEnd = 160320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref result;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600460D RID: 17933 RVA: 0x0015B5F8 File Offset: 0x001597F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160320, XrefRangeEnd = 160334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lobby() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600460E RID: 17934 RVA: 0x00021FAB File Offset: 0x000201AB
		public Lobby(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600460F RID: 17935 RVA: 0x0015B634 File Offset: 0x00159834
		// (set) Token: 0x06004610 RID: 17936 RVA: 0x00021FB4 File Offset: 0x000201B4
		public unsafe static bool ENABLED
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_ENABLED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_ENABLED, (void*)(&value));
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x06004611 RID: 17937 RVA: 0x0015B650 File Offset: 0x00159850
		// (set) Token: 0x06004612 RID: 17938 RVA: 0x00021FC2 File Offset: 0x000201C2
		public unsafe static int PLAYER_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_PLAYER_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_PLAYER_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x06004613 RID: 17939 RVA: 0x0015B66C File Offset: 0x0015986C
		// (set) Token: 0x06004614 RID: 17940 RVA: 0x00021FD0 File Offset: 0x000201D0
		public unsafe static string JOIN_READY
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_JOIN_READY, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_JOIN_READY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06004615 RID: 17941 RVA: 0x0015B68C File Offset: 0x0015988C
		// (set) Token: 0x06004616 RID: 17942 RVA: 0x00021FE2 File Offset: 0x000201E2
		public unsafe static string LOAD_TUTORIAL
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06004617 RID: 17943 RVA: 0x0015B6AC File Offset: 0x001598AC
		// (set) Token: 0x06004618 RID: 17944 RVA: 0x00021FF4 File Offset: 0x000201F4
		public unsafe static string HOST_LOADING
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_HOST_LOADING, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_HOST_LOADING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06004619 RID: 17945 RVA: 0x0015B6CC File Offset: 0x001598CC
		// (set) Token: 0x0600461A RID: 17946 RVA: 0x00022006 File Offset: 0x00020206
		public unsafe NetworkManager NetworkManager
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_NetworkManager);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_NetworkManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x0015B6FC File Offset: 0x001598FC
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00022025 File Offset: 0x00020225
		public unsafe ulong _LobbyID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x0015B724 File Offset: 0x00159924
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x00022040 File Offset: 0x00020240
		public unsafe CSteamID _LocalPlayerID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x0015B74C File Offset: 0x0015994C
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x0002205B File Offset: 0x0002025B
		public unsafe Il2CppStructArray<CSteamID> Players
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Players);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CSteamID>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x0015B77C File Offset: 0x0015997C
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x0002207A File Offset: 0x0002027A
		public unsafe Il2CppSystem.Action onLobbyChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_onLobbyChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_onLobbyChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06004623 RID: 17955 RVA: 0x0015B7AC File Offset: 0x001599AC
		// (set) Token: 0x06004624 RID: 17956 RVA: 0x00022099 File Offset: 0x00020299
		public unsafe Callback<LobbyCreated_t> LobbyCreatedCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyCreatedCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyCreated_t>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyCreatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06004625 RID: 17957 RVA: 0x0015B7DC File Offset: 0x001599DC
		// (set) Token: 0x06004626 RID: 17958 RVA: 0x000220B8 File Offset: 0x000202B8
		public unsafe Callback<LobbyEnter_t> LobbyEnteredCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyEnteredCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyEnter_t>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyEnteredCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x06004627 RID: 17959 RVA: 0x0015B80C File Offset: 0x00159A0C
		// (set) Token: 0x06004628 RID: 17960 RVA: 0x000220D7 File Offset: 0x000202D7
		public unsafe Callback<LobbyChatUpdate_t> ChatUpdateCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_ChatUpdateCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatUpdate_t>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_ChatUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x06004629 RID: 17961 RVA: 0x0015B83C File Offset: 0x00159A3C
		// (set) Token: 0x0600462A RID: 17962 RVA: 0x000220F6 File Offset: 0x000202F6
		public unsafe Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<GameLobbyJoinRequested_t>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600462B RID: 17963 RVA: 0x0015B86C File Offset: 0x00159A6C
		// (set) Token: 0x0600462C RID: 17964 RVA: 0x00022115 File Offset: 0x00020315
		public unsafe Callback<LobbyChatMsg_t> LobbyChatMessageCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatMsg_t>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600462D RID: 17965 RVA: 0x0015B89C File Offset: 0x00159A9C
		// (set) Token: 0x0600462E RID: 17966 RVA: 0x00022134 File Offset: 0x00020334
		public unsafe string DebugSteamId64
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_DebugSteamId64);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_DebugSteamId64), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002ED2 RID: 11986
		private static readonly System.IntPtr NativeFieldInfoPtr_ENABLED;

		// Token: 0x04002ED3 RID: 11987
		private static readonly System.IntPtr NativeFieldInfoPtr_PLAYER_LIMIT;

		// Token: 0x04002ED4 RID: 11988
		private static readonly System.IntPtr NativeFieldInfoPtr_JOIN_READY;

		// Token: 0x04002ED5 RID: 11989
		private static readonly System.IntPtr NativeFieldInfoPtr_LOAD_TUTORIAL;

		// Token: 0x04002ED6 RID: 11990
		private static readonly System.IntPtr NativeFieldInfoPtr_HOST_LOADING;

		// Token: 0x04002ED7 RID: 11991
		private static readonly System.IntPtr NativeFieldInfoPtr_NetworkManager;

		// Token: 0x04002ED8 RID: 11992
		private static readonly System.IntPtr NativeFieldInfoPtr__LobbyID_k__BackingField;

		// Token: 0x04002ED9 RID: 11993
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerID_k__BackingField;

		// Token: 0x04002EDA RID: 11994
		private static readonly System.IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04002EDB RID: 11995
		private static readonly System.IntPtr NativeFieldInfoPtr_onLobbyChange;

		// Token: 0x04002EDC RID: 11996
		private static readonly System.IntPtr NativeFieldInfoPtr_LobbyCreatedCallback;

		// Token: 0x04002EDD RID: 11997
		private static readonly System.IntPtr NativeFieldInfoPtr_LobbyEnteredCallback;

		// Token: 0x04002EDE RID: 11998
		private static readonly System.IntPtr NativeFieldInfoPtr_ChatUpdateCallback;

		// Token: 0x04002EDF RID: 11999
		private static readonly System.IntPtr NativeFieldInfoPtr_GameLobbyJoinRequestedCallback;

		// Token: 0x04002EE0 RID: 12000
		private static readonly System.IntPtr NativeFieldInfoPtr_LobbyChatMessageCallback;

		// Token: 0x04002EE1 RID: 12001
		private static readonly System.IntPtr NativeFieldInfoPtr_DebugSteamId64;

		// Token: 0x04002EE2 RID: 12002
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0;

		// Token: 0x04002EE3 RID: 12003
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0;

		// Token: 0x04002EE4 RID: 12004
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0;

		// Token: 0x04002EE5 RID: 12005
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0;

		// Token: 0x04002EE6 RID: 12006
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0;

		// Token: 0x04002EE7 RID: 12007
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0;

		// Token: 0x04002EE8 RID: 12008
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0;

		// Token: 0x04002EE9 RID: 12009
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0;

		// Token: 0x04002EEA RID: 12010
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002EEB RID: 12011
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002EEC RID: 12012
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0;

		// Token: 0x04002EED RID: 12013
		private static readonly System.IntPtr NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0;

		// Token: 0x04002EEE RID: 12014
		private static readonly System.IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Void_0;

		// Token: 0x04002EEF RID: 12015
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateLobby_Private_Void_0;

		// Token: 0x04002EF0 RID: 12016
		private static readonly System.IntPtr NativeMethodInfoPtr_GetLaunchLobby_Private_String_0;

		// Token: 0x04002EF1 RID: 12017
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0;

		// Token: 0x04002EF2 RID: 12018
		private static readonly System.IntPtr NativeMethodInfoPtr_DebugJoin_Public_Void_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly System.IntPtr NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly System.IntPtr NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0;

		// Token: 0x04002EF7 RID: 12023
		private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0;

		// Token: 0x04002EF8 RID: 12024
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0;

		// Token: 0x04002EF9 RID: 12025
		private static readonly System.IntPtr NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0;

		// Token: 0x04002EFA RID: 12026
		private static readonly System.IntPtr NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0;

		// Token: 0x04002EFB RID: 12027
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009B3 RID: 2483
		[ObfuscatedName("ScheduleOne.Networking.Lobby+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CE60 RID: 52832 RVA: 0x0032167C File Offset: 0x0031F87C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr);
				Lobby.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, "<>9");
				Lobby.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, "<>9__17_0");
				Lobby.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, 100671945);
				Lobby.__c.NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, 100671946);
			}

			// Token: 0x0600CE61 RID: 52833 RVA: 0x003216F8 File Offset: 0x0031F8F8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CE62 RID: 52834 RVA: 0x00321734 File Offset: 0x0031F934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159847, XrefRangeEnd = 159852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayerCount_b__17_0(CSteamID p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref p;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Lobby.__c.NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CE63 RID: 52835 RVA: 0x000640FE File Offset: 0x000622FE
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700400F RID: 16399
			// (get) Token: 0x0600CE64 RID: 52836 RVA: 0x00321780 File Offset: 0x0031F980
			// (set) Token: 0x0600CE65 RID: 52837 RVA: 0x00064107 File Offset: 0x00062307
			public unsafe static Lobby.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lobby.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lobby.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lobby.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004010 RID: 16400
			// (get) Token: 0x0600CE66 RID: 52838 RVA: 0x003217A8 File Offset: 0x0031F9A8
			// (set) Token: 0x0600CE67 RID: 52839 RVA: 0x00064119 File Offset: 0x00062319
			public unsafe static Il2CppSystem.Func<CSteamID, bool> __9__17_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lobby.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<CSteamID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lobby.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BBA RID: 35770
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008BBB RID: 35771
			private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008BBC RID: 35772
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008BBD RID: 35773
			private static readonly System.IntPtr NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0;
		}
	}
}
