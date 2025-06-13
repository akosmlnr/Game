using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C7 RID: 1223
	public class CasinoGamePlayers : NetworkBehaviour
	{
		// Token: 0x0600695D RID: 26973 RVA: 0x001DB3D8 File Offset: 0x001D95D8
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayers()
		{
			Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr);
			CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "PlayerLimit");
			CasinoGamePlayers.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "Players");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerListChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "onPlayerScoresChanged");
			CasinoGamePlayers.NativeFieldInfoPtr_playerScores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerScores");
			CasinoGamePlayers.NativeFieldInfoPtr_playerDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "playerDatas");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.CasinoGamePlayersAssembly-CSharp.dll_Excuted");
			CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676742);
			CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676743);
			CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676744);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676745);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676746);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676747);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676748);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676749);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676750);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676751);
			CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676752);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676753);
			CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676754);
			CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676755);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676756);
			CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676757);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676758);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676759);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676760);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676761);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676762);
			CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676763);
			CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676764);
			CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676765);
			CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676766);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676767);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676768);
			CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676769);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676770);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676771);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676772);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676773);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676774);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676775);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676776);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676777);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676778);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676779);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676780);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676781);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676782);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676783);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676784);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676785);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676786);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676787);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676788);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676789);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676790);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676791);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676792);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676793);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676794);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676795);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676796);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676797);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676798);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676799);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676800);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676801);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676802);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676803);
			CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676804);
			CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, 100676805);
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x0600695E RID: 26974 RVA: 0x001DB9A8 File Offset: 0x001D9BA8
		public unsafe int CurrentPlayerCount
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 213591, RefRangeEnd = 213613, XrefRangeStart = 213573, XrefRangeEnd = 213591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x001DB9E4 File Offset: 0x001D9BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213613, XrefRangeEnd = 213617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x001DBA20 File Offset: 0x001D9C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213617, XrefRangeEnd = 213632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x001DBA70 File Offset: 0x001D9C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213632, XrefRangeEnd = 213654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x001DBAB4 File Offset: 0x001D9CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213654, XrefRangeEnd = 213673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x001DBAF8 File Offset: 0x001D9CF8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213685, RefRangeEnd = 213690, XrefRangeStart = 213673, XrefRangeEnd = 213685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(Player player, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x001DBB48 File Offset: 0x001D9D48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213700, RefRangeEnd = 213702, XrefRangeStart = 213690, XrefRangeEnd = 213700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerScore(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x001DBB98 File Offset: 0x001D9D98
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 213702, RefRangeEnd = 213711, XrefRangeStart = 213702, XrefRangeEnd = 213702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player GetPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x001DBBE4 File Offset: 0x001D9DE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213714, RefRangeEnd = 213718, XrefRangeStart = 213711, XrefRangeEnd = 213714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayerIndex(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x001DBC34 File Offset: 0x001D9E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213718, XrefRangeEnd = 213740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestAddPlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x001DBC78 File Offset: 0x001D9E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213740, XrefRangeEnd = 213744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x001DBCBC File Offset: 0x001D9EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213744, XrefRangeEnd = 213754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayer(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x001DBD00 File Offset: 0x001D9F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213754, XrefRangeEnd = 213758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromArray(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x001DBD44 File Offset: 0x001D9F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213758, XrefRangeEnd = 213770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestSetScore(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x001DBD94 File Offset: 0x001D9F94
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213816, RefRangeEnd = 213819, XrefRangeStart = 213770, XrefRangeEnd = 213816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerScore(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x001DBDF8 File Offset: 0x001D9FF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213861, RefRangeEnd = 213865, XrefRangeStart = 213819, XrefRangeEnd = 213861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerList(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x001DBE4C File Offset: 0x001DA04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213865, XrefRangeEnd = 213870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr2) : null;
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x001DBE8C File Offset: 0x001DA08C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 213884, RefRangeEnd = 213893, XrefRangeStart = 213870, XrefRangeEnd = 213884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr2) : null;
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x001DBEDC File Offset: 0x001DA0DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 213898, RefRangeEnd = 213904, XrefRangeStart = 213893, XrefRangeEnd = 213898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData GetPlayerData(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerData>(intPtr2) : null;
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x001DBF28 File Offset: 0x001DA128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213904, XrefRangeEnd = 213927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerBool(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x001DBF8C File Offset: 0x001DA18C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 213973, RefRangeEnd = 213976, XrefRangeStart = 213927, XrefRangeEnd = 213973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerBool(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x001DC000 File Offset: 0x001DA200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213999, RefRangeEnd = 214000, XrefRangeStart = 213976, XrefRangeEnd = 213999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerFloat(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x001DC064 File Offset: 0x001DA264
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214046, RefRangeEnd = 214049, XrefRangeStart = 214000, XrefRangeEnd = 214046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceivePlayerFloat(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x001DC0D8 File Offset: 0x001DA2D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214058, RefRangeEnd = 214062, XrefRangeStart = 214049, XrefRangeEnd = 214058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<NetworkObject> GetPlayerObjects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NetworkObject>>(intPtr2) : null;
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x001DC118 File Offset: 0x001DA318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214062, XrefRangeEnd = 214077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayers() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x001DC154 File Offset: 0x001DA354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214077, XrefRangeEnd = 214157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x001DC190 File Offset: 0x001DA390
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x001DC1CC File Offset: 0x001DA3CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CasinoGamePlayers.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x001DC208 File Offset: 0x001DA408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214157, XrefRangeEnd = 214167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x001DC24C File Offset: 0x001DA44C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 214206, RefRangeEnd = 214210, XrefRangeStart = 214167, XrefRangeEnd = 214206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestAddPlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x001DC290 File Offset: 0x001DA490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214210, XrefRangeEnd = 214214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestAddPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x001DC2F4 File Offset: 0x001DA4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x001DC338 File Offset: 0x001DA538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214214, XrefRangeEnd = 214234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayer_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x001DC37C File Offset: 0x001DA57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214234, XrefRangeEnd = 214252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x001DC3E0 File Offset: 0x001DA5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x001DC430 File Offset: 0x001DA630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214252, XrefRangeEnd = 214253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestSetScore_4172557123(NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x001DC480 File Offset: 0x001DA680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214253, XrefRangeEnd = 214258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestSetScore_4172557123(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x001DC4E4 File Offset: 0x001DA6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214258, XrefRangeEnd = 214270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x001DC548 File Offset: 0x001DA748
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214288, RefRangeEnd = 214291, XrefRangeStart = 214270, XrefRangeEnd = 214288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x001DC5AC File Offset: 0x001DA7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214291, XrefRangeEnd = 214297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x001DC5FC File Offset: 0x001DA7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214297, XrefRangeEnd = 214309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerScore_1865307316(NetworkConnection conn, NetworkObject playerObject, int score)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x001DC660 File Offset: 0x001DA860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214309, XrefRangeEnd = 214315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerScore_1865307316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x001DC6B0 File Offset: 0x001DA8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214315, XrefRangeEnd = 214325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x001DC704 File Offset: 0x001DA904
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214360, RefRangeEnd = 214363, XrefRangeStart = 214325, XrefRangeEnd = 214360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x001DC758 File Offset: 0x001DA958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214363, XrefRangeEnd = 214367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x001DC7A8 File Offset: 0x001DA9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214367, XrefRangeEnd = 214377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetPlayerList_204172449(NetworkConnection conn, Il2CppReferenceArray<NetworkObject> playerObjects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObjects);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x001DC7FC File Offset: 0x001DA9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214377, XrefRangeEnd = 214381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetPlayerList_204172449(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x001DC84C File Offset: 0x001DAA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214381, XrefRangeEnd = 214393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x001DC8B0 File Offset: 0x001DAAB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214393, XrefRangeEnd = 214394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerBool_77262511(NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x001DC914 File Offset: 0x001DAB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214394, XrefRangeEnd = 214399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerBool_77262511(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x001DC978 File Offset: 0x001DAB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214399, XrefRangeEnd = 214411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x001DC9EC File Offset: 0x001DABEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214434, RefRangeEnd = 214437, XrefRangeStart = 214411, XrefRangeEnd = 214434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x001DCA60 File Offset: 0x001DAC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214437, XrefRangeEnd = 214442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x001DCAB0 File Offset: 0x001DACB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214442, XrefRangeEnd = 214454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerBool_1748594478(NetworkConnection conn, NetworkObject playerObject, string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x001DCB24 File Offset: 0x001DAD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214454, XrefRangeEnd = 214459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerBool_1748594478(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x001DCB74 File Offset: 0x001DAD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214459, XrefRangeEnd = 214471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x001DCBD8 File Offset: 0x001DADD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214471, XrefRangeEnd = 214472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPlayerFloat_2931762093(NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x001DCC3C File Offset: 0x001DAE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214472, XrefRangeEnd = 214478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPlayerFloat_2931762093(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x001DCCA0 File Offset: 0x001DAEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214478, XrefRangeEnd = 214490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x001DCD14 File Offset: 0x001DAF14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 214513, RefRangeEnd = 214516, XrefRangeStart = 214490, XrefRangeEnd = 214513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x001DCD88 File Offset: 0x001DAF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214516, XrefRangeEnd = 214522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x001DCDD8 File Offset: 0x001DAFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214522, XrefRangeEnd = 214534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceivePlayerFloat_2317689966(NetworkConnection conn, NetworkObject playerObject, string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x001DCE4C File Offset: 0x001DB04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214534, XrefRangeEnd = 214540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceivePlayerFloat_2317689966(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x001DCE9C File Offset: 0x001DB09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214540, XrefRangeEnd = 214544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x000318AB File Offset: 0x0002FAAB
		public CasinoGamePlayers(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x0600699F RID: 27039 RVA: 0x001DCED0 File Offset: 0x001DB0D0
		// (set) Token: 0x060069A0 RID: 27040 RVA: 0x000318B4 File Offset: 0x0002FAB4
		public unsafe int PlayerLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_PlayerLimit)) = value;
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x060069A1 RID: 27041 RVA: 0x001DCEF8 File Offset: 0x001DB0F8
		// (set) Token: 0x060069A2 RID: 27042 RVA: 0x000318CF File Offset: 0x0002FACF
		public unsafe Il2CppReferenceArray<Player> Players
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Player>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x060069A3 RID: 27043 RVA: 0x001DCF28 File Offset: 0x001DB128
		// (set) Token: 0x060069A4 RID: 27044 RVA: 0x000318EE File Offset: 0x0002FAEE
		public unsafe UnityEvent onPlayerListChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x060069A5 RID: 27045 RVA: 0x001DCF58 File Offset: 0x001DB158
		// (set) Token: 0x060069A6 RID: 27046 RVA: 0x0003190D File Offset: 0x0002FB0D
		public unsafe UnityEvent onPlayerScoresChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_onPlayerScoresChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x060069A7 RID: 27047 RVA: 0x001DCF88 File Offset: 0x001DB188
		// (set) Token: 0x060069A8 RID: 27048 RVA: 0x0003192C File Offset: 0x0002FB2C
		public unsafe Dictionary<Player, int> playerScores
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerScores), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x060069A9 RID: 27049 RVA: 0x001DCFB8 File Offset: 0x001DB1B8
		// (set) Token: 0x060069AA RID: 27050 RVA: 0x0003194B File Offset: 0x0002FB4B
		public unsafe Dictionary<Player, CasinoGamePlayerData> playerDatas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Player, CasinoGamePlayerData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_playerDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x060069AB RID: 27051 RVA: 0x001DCFE8 File Offset: 0x001DB1E8
		// (set) Token: 0x060069AC RID: 27052 RVA: 0x0003196A File Offset: 0x0002FB6A
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x060069AD RID: 27053 RVA: 0x001DD010 File Offset: 0x001DB210
		// (set) Token: 0x060069AE RID: 27054 RVA: 0x00031985 File Offset: 0x0002FB85
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayers.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004820 RID: 18464
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLimit;

		// Token: 0x04004821 RID: 18465
		private static readonly System.IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04004822 RID: 18466
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerListChanged;

		// Token: 0x04004823 RID: 18467
		private static readonly System.IntPtr NativeFieldInfoPtr_onPlayerScoresChanged;

		// Token: 0x04004824 RID: 18468
		private static readonly System.IntPtr NativeFieldInfoPtr_playerScores;

		// Token: 0x04004825 RID: 18469
		private static readonly System.IntPtr NativeFieldInfoPtr_playerDatas;

		// Token: 0x04004826 RID: 18470
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004827 RID: 18471
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004828 RID: 18472
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentPlayerCount_Public_get_Int32_0;

		// Token: 0x04004829 RID: 18473
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400482A RID: 18474
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400482B RID: 18475
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayer_Public_Void_Player_0;

		// Token: 0x0400482C RID: 18476
		private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayer_Public_Void_Player_0;

		// Token: 0x0400482D RID: 18477
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerScore_Public_Void_Player_Int32_0;

		// Token: 0x0400482E RID: 18478
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerScore_Public_Int32_Player_0;

		// Token: 0x0400482F RID: 18479
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayer_Public_Player_Int32_0;

		// Token: 0x04004830 RID: 18480
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerIndex_Public_Int32_Player_0;

		// Token: 0x04004831 RID: 18481
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestAddPlayer_Private_Void_NetworkObject_0;

		// Token: 0x04004832 RID: 18482
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerToArray_Private_Void_Player_0;

		// Token: 0x04004833 RID: 18483
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestRemovePlayer_Private_Void_NetworkObject_0;

		// Token: 0x04004834 RID: 18484
		private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayerFromArray_Private_Void_Player_0;

		// Token: 0x04004835 RID: 18485
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestSetScore_Private_Void_NetworkObject_Int32_0;

		// Token: 0x04004836 RID: 18486
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerScore_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x04004837 RID: 18487
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerList_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004838 RID: 18488
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_0;

		// Token: 0x04004839 RID: 18489
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Player_0;

		// Token: 0x0400483A RID: 18490
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerData_Public_CasinoGamePlayerData_Int32_0;

		// Token: 0x0400483B RID: 18491
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerBool_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x0400483C RID: 18492
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePlayerBool_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x0400483D RID: 18493
		private static readonly System.IntPtr NativeMethodInfoPtr_SendPlayerFloat_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x0400483E RID: 18494
		private static readonly System.IntPtr NativeMethodInfoPtr_ReceivePlayerFloat_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x0400483F RID: 18495
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerObjects_Private_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004840 RID: 18496
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004841 RID: 18497
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004842 RID: 18498
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004843 RID: 18499
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004844 RID: 18500
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004845 RID: 18501
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestAddPlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004846 RID: 18502
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestAddPlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004847 RID: 18503
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004848 RID: 18504
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04004849 RID: 18505
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400484A RID: 18506
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x0400484B RID: 18507
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestSetScore_4172557123_Private_Void_NetworkObject_Int32_0;

		// Token: 0x0400484C RID: 18508
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestSetScore_4172557123_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400484D RID: 18509
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x0400484E RID: 18510
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x0400484F RID: 18511
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004850 RID: 18512
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerScore_1865307316_Private_Void_NetworkConnection_NetworkObject_Int32_0;

		// Token: 0x04004851 RID: 18513
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerScore_1865307316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004852 RID: 18514
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004853 RID: 18515
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004854 RID: 18516
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004855 RID: 18517
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetPlayerList_204172449_Private_Void_NetworkConnection_Il2CppReferenceArray_1_NetworkObject_0;

		// Token: 0x04004856 RID: 18518
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetPlayerList_204172449_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004857 RID: 18519
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerBool_77262511_Private_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04004858 RID: 18520
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerBool_77262511_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x04004859 RID: 18521
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerBool_77262511_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400485A RID: 18522
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x0400485B RID: 18523
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x0400485C RID: 18524
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400485D RID: 18525
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerBool_1748594478_Private_Void_NetworkConnection_NetworkObject_String_Boolean_0;

		// Token: 0x0400485E RID: 18526
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerBool_1748594478_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400485F RID: 18527
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPlayerFloat_2931762093_Private_Void_NetworkObject_String_Single_0;

		// Token: 0x04004860 RID: 18528
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendPlayerFloat_2931762093_Public_Void_NetworkObject_String_Single_0;

		// Token: 0x04004861 RID: 18529
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPlayerFloat_2931762093_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004862 RID: 18530
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004863 RID: 18531
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004864 RID: 18532
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004865 RID: 18533
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceivePlayerFloat_2317689966_Private_Void_NetworkConnection_NetworkObject_String_Single_0;

		// Token: 0x04004866 RID: 18534
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceivePlayerFloat_2317689966_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004867 RID: 18535
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000A8E RID: 2702
		[ObfuscatedName("ScheduleOne.Casino.CasinoGamePlayers+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D507 RID: 54535 RVA: 0x003343BC File Offset: 0x003325BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CasinoGamePlayers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr);
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9");
				CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, "<>9__2_0");
				CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100676807);
				CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr, 100676808);
			}

			// Token: 0x0600D508 RID: 54536 RVA: 0x00334438 File Offset: 0x00332638
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayers.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D509 RID: 54537 RVA: 0x00334474 File Offset: 0x00332674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213569, XrefRangeEnd = 213573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CurrentPlayerCount_b__2_0(Player p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayers.__c.NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D50A RID: 54538 RVA: 0x0006753A File Offset: 0x0006573A
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041DD RID: 16861
			// (get) Token: 0x0600D50B RID: 54539 RVA: 0x003344C4 File Offset: 0x003326C4
			// (set) Token: 0x0600D50C RID: 54540 RVA: 0x00067543 File Offset: 0x00065743
			public unsafe static CasinoGamePlayers.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DE RID: 16862
			// (get) Token: 0x0600D50D RID: 54541 RVA: 0x003344EC File Offset: 0x003326EC
			// (set) Token: 0x0600D50E RID: 54542 RVA: 0x00067555 File Offset: 0x00065755
			public unsafe static Il2CppSystem.Func<Player, bool> __9__2_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Player, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CasinoGamePlayers.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FB6 RID: 36790
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008FB7 RID: 36791
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04008FB8 RID: 36792
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FB9 RID: 36793
			private static readonly System.IntPtr NativeMethodInfoPtr__get_CurrentPlayerCount_b__2_0_Internal_Boolean_Player_0;
		}
	}
}
