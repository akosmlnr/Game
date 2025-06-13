using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004C2 RID: 1218
	public class BlackjackGameController : CasinoGameController
	{
		// Token: 0x06006852 RID: 26706 RVA: 0x001D7360 File Offset: 0x001D5560
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackGameController()
		{
			Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "BlackjackGameController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr);
			BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BET_MINIMUM");
			BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BET_MAXIMUM");
			BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "PAYOUT_RATIO");
			BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "BLACKJACK_PAYOUT_RATIO");
			BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<CurrentStage>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<PlayerTurn>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerBet>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<DealerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<LocalPlayerScore>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBlackjack>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<IsLocalPlayerBust>k__BackingField");
			BlackjackGameController.NativeFieldInfoPtr_Cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Cards");
			BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DefaultCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FocusedCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "FinalCameraTransforms");
			BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player1CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player2CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player3CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "Player4CardPositions");
			BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "DealerCardPositions");
			BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playersInCurrentRound");
			BlackjackGameController.NativeFieldInfoPtr_playStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "playStack");
			BlackjackGameController.NativeFieldInfoPtr_player1Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player1Hand");
			BlackjackGameController.NativeFieldInfoPtr_player2Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player2Hand");
			BlackjackGameController.NativeFieldInfoPtr_player3Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player3Hand");
			BlackjackGameController.NativeFieldInfoPtr_player4Hand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "player4Hand");
			BlackjackGameController.NativeFieldInfoPtr_dealerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "dealerHand");
			BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "cardValuesInDeck");
			BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "drawnCardsValues");
			BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFocusCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "localFinalCameraTransform");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBetChange");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerExitRound");
			BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onInitialCardsDealt");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerReadyForInput");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerBust");
			BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "onLocalPlayerRoundCompleted");
			BlackjackGameController.NativeFieldInfoPtr_roundEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "roundEnded");
			BlackjackGameController.NativeFieldInfoPtr_gameRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "gameRoutine");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.BlackjackGameControllerAssembly-CSharp.dll_Excuted");
			BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676586);
			BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676587);
			BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676588);
			BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676589);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676590);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676591);
			BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676592);
			BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676593);
			BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676594);
			BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676595);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676596);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676597);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676598);
			BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676599);
			BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676600);
			BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676601);
			BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676602);
			BlackjackGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676603);
			BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676604);
			BlackjackGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676605);
			BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676606);
			BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676607);
			BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676608);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676609);
			BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676610);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676611);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676612);
			BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676613);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676614);
			BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676615);
			BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676616);
			BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676617);
			BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676618);
			BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676619);
			BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676620);
			BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676621);
			BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676622);
			BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676623);
			BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676624);
			BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676625);
			BlackjackGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676626);
			BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676627);
			BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676628);
			BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676629);
			BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676630);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676631);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676632);
			BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676633);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676634);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676635);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676636);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676637);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676638);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676639);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676640);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676641);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676642);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676643);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676644);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676645);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676646);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676647);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676648);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676649);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676650);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676651);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676652);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676653);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676654);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676655);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676656);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676657);
			BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676658);
			BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676659);
			BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676660);
			BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, 100676661);
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06006853 RID: 26707 RVA: 0x001D7CB4 File Offset: 0x001D5EB4
		// (set) Token: 0x06006854 RID: 26708 RVA: 0x001D7CF0 File Offset: 0x001D5EF0
		public unsafe BlackjackGameController.EStage CurrentStage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x06006855 RID: 26709 RVA: 0x001D7D30 File Offset: 0x001D5F30
		// (set) Token: 0x06006856 RID: 26710 RVA: 0x001D7D70 File Offset: 0x001D5F70
		public unsafe Player PlayerTurn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x06006857 RID: 26711 RVA: 0x001D7DB4 File Offset: 0x001D5FB4
		// (set) Token: 0x06006858 RID: 26712 RVA: 0x001D7DF0 File Offset: 0x001D5FF0
		public unsafe float LocalPlayerBet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x06006859 RID: 26713 RVA: 0x001D7E30 File Offset: 0x001D6030
		// (set) Token: 0x0600685A RID: 26714 RVA: 0x001D7E6C File Offset: 0x001D606C
		public unsafe int DealerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x0600685B RID: 26715 RVA: 0x001D7EAC File Offset: 0x001D60AC
		// (set) Token: 0x0600685C RID: 26716 RVA: 0x001D7EE8 File Offset: 0x001D60E8
		public unsafe int LocalPlayerScore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x001D7F28 File Offset: 0x001D6128
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x001D7F64 File Offset: 0x001D6164
		public unsafe bool IsLocalPlayerBlackjack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x0600685F RID: 26719 RVA: 0x001D7FA4 File Offset: 0x001D61A4
		// (set) Token: 0x06006860 RID: 26720 RVA: 0x001D7FE0 File Offset: 0x001D61E0
		public unsafe bool IsLocalPlayerBust
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x06006861 RID: 26721 RVA: 0x001D8020 File Offset: 0x001D6220
		public unsafe bool IsLocalPlayerInCurrentRound
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 211801, RefRangeEnd = 211806, XrefRangeStart = 211793, XrefRangeEnd = 211801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x001D805C File Offset: 0x001D625C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211806, XrefRangeEnd = 211829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x001D8098 File Offset: 0x001D6298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211829, XrefRangeEnd = 211850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Open_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x001D80D4 File Offset: 0x001D62D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211850, XrefRangeEnd = 211859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Close_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x001D8110 File Offset: 0x001D6310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211859, XrefRangeEnd = 211863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x001D8160 File Offset: 0x001D6360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211863, XrefRangeEnd = 211924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x001D819C File Offset: 0x001D639C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211955, RefRangeEnd = 211957, XrefRangeStart = 211924, XrefRangeEnd = 211955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Player> GetClockwisePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x001D81DC File Offset: 0x001D63DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211957, XrefRangeEnd = 211978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_StartGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x001D8210 File Offset: 0x001D6410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212003, RefRangeEnd = 212005, XrefRangeStart = 211978, XrefRangeEnd = 212003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyPlayerScore(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref blackjack;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001D8270 File Offset: 0x001D6470
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212005, RefRangeEnd = 212008, XrefRangeStart = 212005, XrefRangeEnd = 212005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Transform> GetPlayerCardPositions(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref playerIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x001D82BC File Offset: 0x001D64BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212028, RefRangeEnd = 212029, XrefRangeStart = 212008, XrefRangeEnd = 212028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoundEnded(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ended;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x001D82FC File Offset: 0x001D64FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212053, RefRangeEnd = 212056, XrefRangeStart = 212029, XrefRangeEnd = 212053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerIndex, PlayingCard card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref playerIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x001D834C File Offset: 0x001D654C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212056, XrefRangeEnd = 212080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToPlayerHand(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x001D839C File Offset: 0x001D659C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212102, RefRangeEnd = 212104, XrefRangeStart = 212080, XrefRangeEnd = 212102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCardToDealerHand(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x001D83E0 File Offset: 0x001D65E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212104, RefRangeEnd = 212105, XrefRangeStart = 212104, XrefRangeEnd = 212104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<PlayingCard> GetPlayerCards(int playerIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref playerIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x001D842C File Offset: 0x001D662C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212133, RefRangeEnd = 212136, XrefRangeStart = 212105, XrefRangeEnd = 212133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetHandScore(List<PlayingCard> cards, bool countFaceDown = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref countFaceDown;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x001D8488 File Offset: 0x001D6688
		[CallerCount(0)]
		public unsafe int GetCardValue(PlayingCard card, bool aceAsEleven = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref aceAsEleven;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x001D84E4 File Offset: 0x001D66E4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 212155, RefRangeEnd = 212160, XrefRangeStart = 212136, XrefRangeEnd = 212155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayingCard DrawCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayingCard>(intPtr2) : null;
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x001D8524 File Offset: 0x001D6724
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 212193, RefRangeEnd = 212199, XrefRangeStart = 212160, XrefRangeEnd = 212193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ResetCards_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x001D8558 File Offset: 0x001D6758
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212221, RefRangeEnd = 212222, XrefRangeStart = 212199, XrefRangeEnd = 212221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_EndGame_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001D858C File Offset: 0x001D678C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212268, RefRangeEnd = 212271, XrefRangeStart = 212222, XrefRangeEnd = 212268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLocalPlayerFromGame(BlackjackGameController.EPayoutType payout, float cameraDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref payout;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref cameraDelay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001D85D8 File Offset: 0x001D67D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212271, RefRangeEnd = 212272, XrefRangeStart = 212271, XrefRangeEnd = 212271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPayout(float bet, BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref bet;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref payout;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x001D8630 File Offset: 0x001D6830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212272, XrefRangeEnd = 212273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentRoundEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x001D866C File Offset: 0x001D686C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212273, XrefRangeEnd = 212295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerToCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x001D86B0 File Offset: 0x001D68B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212295, XrefRangeEnd = 212317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestRemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x001D86F4 File Offset: 0x001D68F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212339, RefRangeEnd = 212342, XrefRangeStart = 212317, XrefRangeEnd = 212339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayerFromCurrentRound(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001D8738 File Offset: 0x001D6938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212342, RefRangeEnd = 212344, XrefRangeStart = 212342, XrefRangeEnd = 212342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLocalPlayerBet(float bet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref bet;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001D8778 File Offset: 0x001D6978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212344, XrefRangeEnd = 212359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAllPlayersReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x001D87B4 File Offset: 0x001D69B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212359, XrefRangeEnd = 212372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPlayersReadyCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x001D87F0 File Offset: 0x001D69F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212391, RefRangeEnd = 212392, XrefRangeStart = 212372, XrefRangeEnd = 212391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleLocalPlayerReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x001D8824 File Offset: 0x001D6A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212392, XrefRangeEnd = 212444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackGameController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x001D8860 File Offset: 0x001D6A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212444, XrefRangeEnd = 212500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x001D889C File Offset: 0x001D6A9C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x001D88D8 File Offset: 0x001D6AD8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x001D8914 File Offset: 0x001D6B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212500, XrefRangeEnd = 212509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x001D8948 File Offset: 0x001D6B48
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 212566, RefRangeEnd = 212571, XrefRangeStart = 212509, XrefRangeEnd = 212566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x001D897C File Offset: 0x001D6B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212571, XrefRangeEnd = 212574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x001D89CC File Offset: 0x001D6BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212574, XrefRangeEnd = 212587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref blackjack;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x001D8A2C File Offset: 0x001D6C2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212595, RefRangeEnd = 212597, XrefRangeStart = 212587, XrefRangeEnd = 212595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyPlayerScore_2864061566(NetworkObject player, int score, bool blackjack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref score;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref blackjack;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x001D8A8C File Offset: 0x001D6C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212597, XrefRangeEnd = 212603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_NotifyPlayerScore_2864061566(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001D8ADC File Offset: 0x001D6CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212603, XrefRangeEnd = 212613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ended;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x001D8B1C File Offset: 0x001D6D1C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetRoundEnded_1140765316(bool ended)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref ended;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x001D8B5C File Offset: 0x001D6D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212613, XrefRangeEnd = 212615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRoundEnded_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x001D8BAC File Offset: 0x001D6DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212615, XrefRangeEnd = 212627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x001D8BFC File Offset: 0x001D6DFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212651, RefRangeEnd = 212654, XrefRangeStart = 212627, XrefRangeEnd = 212651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToPlayerHand_2801973956(int playerindex, string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref playerindex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cardID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x001D8C4C File Offset: 0x001D6E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212654, XrefRangeEnd = 212660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToPlayerHand_2801973956(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x001D8C9C File Offset: 0x001D6E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212660, XrefRangeEnd = 212670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x001D8CE0 File Offset: 0x001D6EE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212694, RefRangeEnd = 212696, XrefRangeStart = 212670, XrefRangeEnd = 212694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCardToDealerHand_3615296227(string cardID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(cardID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x001D8D24 File Offset: 0x001D6F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212696, XrefRangeEnd = 212700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCardToDealerHand_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x001D8D74 File Offset: 0x001D6F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212700, XrefRangeEnd = 212709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x001D8DA8 File Offset: 0x001D6FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212709, XrefRangeEnd = 212711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndGame_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x001D8DDC File Offset: 0x001D6FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212711, XrefRangeEnd = 212715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndGame_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x001D8E2C File Offset: 0x001D702C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212715, XrefRangeEnd = 212725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x001D8E70 File Offset: 0x001D7070
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212746, RefRangeEnd = 212749, XrefRangeStart = 212725, XrefRangeEnd = 212746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddPlayerToCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x001D8EB4 File Offset: 0x001D70B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212749, XrefRangeEnd = 212753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerToCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x001D8F04 File Offset: 0x001D7104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212753, XrefRangeEnd = 212763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x001D8F48 File Offset: 0x001D7148
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212339, RefRangeEnd = 212342, XrefRangeStart = 212339, XrefRangeEnd = 212342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x001D8F8C File Offset: 0x001D718C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212763, XrefRangeEnd = 212767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x001D8FF0 File Offset: 0x001D71F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212767, XrefRangeEnd = 212777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x001D9034 File Offset: 0x001D7234
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212798, RefRangeEnd = 212801, XrefRangeStart = 212777, XrefRangeEnd = 212798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemovePlayerFromCurrentRound_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x001D9078 File Offset: 0x001D7278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212801, XrefRangeEnd = 212805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x001D90C8 File Offset: 0x001D72C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212805, XrefRangeEnd = 212828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackGameController.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600689F RID: 26783 RVA: 0x0003119A File Offset: 0x0002F39A
		public BlackjackGameController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x060068A0 RID: 26784 RVA: 0x001D9104 File Offset: 0x001D7304
		// (set) Token: 0x060068A1 RID: 26785 RVA: 0x000311A3 File Offset: 0x0002F3A3
		public unsafe static int BET_MINIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BET_MINIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x060068A2 RID: 26786 RVA: 0x001D9120 File Offset: 0x001D7320
		// (set) Token: 0x060068A3 RID: 26787 RVA: 0x000311B1 File Offset: 0x0002F3B1
		public unsafe static int BET_MAXIMUM
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BET_MAXIMUM, (void*)(&value));
			}
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x060068A4 RID: 26788 RVA: 0x001D913C File Offset: 0x001D733C
		// (set) Token: 0x060068A5 RID: 26789 RVA: 0x000311BF File Offset: 0x0002F3BF
		public unsafe static float PAYOUT_RATIO
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_PAYOUT_RATIO, (void*)(&value));
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x060068A6 RID: 26790 RVA: 0x001D9158 File Offset: 0x001D7358
		// (set) Token: 0x060068A7 RID: 26791 RVA: 0x000311CD File Offset: 0x0002F3CD
		public unsafe static float BLACKJACK_PAYOUT_RATIO
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BlackjackGameController.NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO, (void*)(&value));
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x060068A8 RID: 26792 RVA: 0x001D9174 File Offset: 0x001D7374
		// (set) Token: 0x060068A9 RID: 26793 RVA: 0x000311DB File Offset: 0x0002F3DB
		public unsafe BlackjackGameController.EStage _CurrentStage_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__CurrentStage_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x060068AA RID: 26794 RVA: 0x001D919C File Offset: 0x001D739C
		// (set) Token: 0x060068AB RID: 26795 RVA: 0x000311F6 File Offset: 0x0002F3F6
		public unsafe Player _PlayerTurn_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__PlayerTurn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x060068AC RID: 26796 RVA: 0x001D91CC File Offset: 0x001D73CC
		// (set) Token: 0x060068AD RID: 26797 RVA: 0x00031215 File Offset: 0x0002F415
		public unsafe float _LocalPlayerBet_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerBet_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x060068AE RID: 26798 RVA: 0x001D91F4 File Offset: 0x001D73F4
		// (set) Token: 0x060068AF RID: 26799 RVA: 0x00031230 File Offset: 0x0002F430
		public unsafe int _DealerScore_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__DealerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x060068B0 RID: 26800 RVA: 0x001D921C File Offset: 0x001D741C
		// (set) Token: 0x060068B1 RID: 26801 RVA: 0x0003124B File Offset: 0x0002F44B
		public unsafe int _LocalPlayerScore_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__LocalPlayerScore_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x001D9244 File Offset: 0x001D7444
		// (set) Token: 0x060068B3 RID: 26803 RVA: 0x00031266 File Offset: 0x0002F466
		public unsafe bool _IsLocalPlayerBlackjack_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x060068B4 RID: 26804 RVA: 0x001D926C File Offset: 0x001D746C
		// (set) Token: 0x060068B5 RID: 26805 RVA: 0x00031281 File Offset: 0x0002F481
		public unsafe bool _IsLocalPlayerBust_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x060068B6 RID: 26806 RVA: 0x001D9294 File Offset: 0x001D7494
		// (set) Token: 0x060068B7 RID: 26807 RVA: 0x0003129C File Offset: 0x0002F49C
		public unsafe Il2CppReferenceArray<PlayingCard> Cards
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x060068B8 RID: 26808 RVA: 0x001D92C4 File Offset: 0x001D74C4
		// (set) Token: 0x060068B9 RID: 26809 RVA: 0x000312BB File Offset: 0x0002F4BB
		public unsafe Il2CppReferenceArray<Transform> DefaultCardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DefaultCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x060068BA RID: 26810 RVA: 0x001D92F4 File Offset: 0x001D74F4
		// (set) Token: 0x060068BB RID: 26811 RVA: 0x000312DA File Offset: 0x0002F4DA
		public unsafe Il2CppReferenceArray<Transform> FocusedCameraTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FocusedCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x060068BC RID: 26812 RVA: 0x001D9324 File Offset: 0x001D7524
		// (set) Token: 0x060068BD RID: 26813 RVA: 0x000312F9 File Offset: 0x0002F4F9
		public unsafe Il2CppReferenceArray<Transform> FinalCameraTransforms
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_FinalCameraTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x060068BE RID: 26814 RVA: 0x001D9354 File Offset: 0x001D7554
		// (set) Token: 0x060068BF RID: 26815 RVA: 0x00031318 File Offset: 0x0002F518
		public unsafe Il2CppReferenceArray<Transform> Player1CardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player1CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x001D9384 File Offset: 0x001D7584
		// (set) Token: 0x060068C1 RID: 26817 RVA: 0x00031337 File Offset: 0x0002F537
		public unsafe Il2CppReferenceArray<Transform> Player2CardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player2CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x060068C2 RID: 26818 RVA: 0x001D93B4 File Offset: 0x001D75B4
		// (set) Token: 0x060068C3 RID: 26819 RVA: 0x00031356 File Offset: 0x0002F556
		public unsafe Il2CppReferenceArray<Transform> Player3CardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player3CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x001D93E4 File Offset: 0x001D75E4
		// (set) Token: 0x060068C5 RID: 26821 RVA: 0x00031375 File Offset: 0x0002F575
		public unsafe Il2CppReferenceArray<Transform> Player4CardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_Player4CardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x060068C6 RID: 26822 RVA: 0x001D9414 File Offset: 0x001D7614
		// (set) Token: 0x060068C7 RID: 26823 RVA: 0x00031394 File Offset: 0x0002F594
		public unsafe Il2CppReferenceArray<Transform> DealerCardPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_DealerCardPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x001D9444 File Offset: 0x001D7644
		// (set) Token: 0x060068C9 RID: 26825 RVA: 0x000313B3 File Offset: 0x0002F5B3
		public unsafe List<Player> playersInCurrentRound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playersInCurrentRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x001D9474 File Offset: 0x001D7674
		// (set) Token: 0x060068CB RID: 26827 RVA: 0x000313D2 File Offset: 0x0002F5D2
		public unsafe List<PlayingCard> playStack
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_playStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x060068CC RID: 26828 RVA: 0x001D94A4 File Offset: 0x001D76A4
		// (set) Token: 0x060068CD RID: 26829 RVA: 0x000313F1 File Offset: 0x0002F5F1
		public unsafe List<PlayingCard> player1Hand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player1Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x060068CE RID: 26830 RVA: 0x001D94D4 File Offset: 0x001D76D4
		// (set) Token: 0x060068CF RID: 26831 RVA: 0x00031410 File Offset: 0x0002F610
		public unsafe List<PlayingCard> player2Hand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player2Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x060068D0 RID: 26832 RVA: 0x001D9504 File Offset: 0x001D7704
		// (set) Token: 0x060068D1 RID: 26833 RVA: 0x0003142F File Offset: 0x0002F62F
		public unsafe List<PlayingCard> player3Hand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player3Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x060068D2 RID: 26834 RVA: 0x001D9534 File Offset: 0x001D7734
		// (set) Token: 0x060068D3 RID: 26835 RVA: 0x0003144E File Offset: 0x0002F64E
		public unsafe List<PlayingCard> player4Hand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_player4Hand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x060068D4 RID: 26836 RVA: 0x001D9564 File Offset: 0x001D7764
		// (set) Token: 0x060068D5 RID: 26837 RVA: 0x0003146D File Offset: 0x0002F66D
		public unsafe List<PlayingCard> dealerHand
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_dealerHand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x060068D6 RID: 26838 RVA: 0x001D9594 File Offset: 0x001D7794
		// (set) Token: 0x060068D7 RID: 26839 RVA: 0x0003148C File Offset: 0x0002F68C
		public unsafe List<PlayingCard.CardData> cardValuesInDeck
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_cardValuesInDeck), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x060068D8 RID: 26840 RVA: 0x001D95C4 File Offset: 0x001D77C4
		// (set) Token: 0x060068D9 RID: 26841 RVA: 0x000314AB File Offset: 0x0002F6AB
		public unsafe List<PlayingCard.CardData> drawnCardsValues
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayingCard.CardData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_drawnCardsValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x060068DA RID: 26842 RVA: 0x001D95F4 File Offset: 0x001D77F4
		// (set) Token: 0x060068DB RID: 26843 RVA: 0x000314CA File Offset: 0x0002F6CA
		public unsafe Transform localFocusCameraTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFocusCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x060068DC RID: 26844 RVA: 0x001D9624 File Offset: 0x001D7824
		// (set) Token: 0x060068DD RID: 26845 RVA: 0x000314E9 File Offset: 0x0002F6E9
		public unsafe Transform localFinalCameraTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_localFinalCameraTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x060068DE RID: 26846 RVA: 0x001D9654 File Offset: 0x001D7854
		// (set) Token: 0x060068DF RID: 26847 RVA: 0x00031508 File Offset: 0x0002F708
		public unsafe Il2CppSystem.Action onLocalPlayerBetChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBetChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x001D9684 File Offset: 0x001D7884
		// (set) Token: 0x060068E1 RID: 26849 RVA: 0x00031527 File Offset: 0x0002F727
		public unsafe Il2CppSystem.Action onLocalPlayerExitRound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerExitRound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x001D96B4 File Offset: 0x001D78B4
		// (set) Token: 0x060068E3 RID: 26851 RVA: 0x00031546 File Offset: 0x0002F746
		public unsafe Il2CppSystem.Action onInitialCardsDealt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onInitialCardsDealt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x060068E4 RID: 26852 RVA: 0x001D96E4 File Offset: 0x001D78E4
		// (set) Token: 0x060068E5 RID: 26853 RVA: 0x00031565 File Offset: 0x0002F765
		public unsafe Il2CppSystem.Action onLocalPlayerReadyForInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerReadyForInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x001D9714 File Offset: 0x001D7914
		// (set) Token: 0x060068E7 RID: 26855 RVA: 0x00031584 File Offset: 0x0002F784
		public unsafe Il2CppSystem.Action onLocalPlayerBust
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x060068E8 RID: 26856 RVA: 0x001D9744 File Offset: 0x001D7944
		// (set) Token: 0x060068E9 RID: 26857 RVA: 0x000315A3 File Offset: 0x0002F7A3
		public unsafe Il2CppSystem.Action<BlackjackGameController.EPayoutType> onLocalPlayerRoundCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<BlackjackGameController.EPayoutType>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_onLocalPlayerRoundCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x060068EA RID: 26858 RVA: 0x001D9774 File Offset: 0x001D7974
		// (set) Token: 0x060068EB RID: 26859 RVA: 0x000315C2 File Offset: 0x0002F7C2
		public unsafe bool roundEnded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_roundEnded)) = value;
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x060068EC RID: 26860 RVA: 0x001D979C File Offset: 0x001D799C
		// (set) Token: 0x060068ED RID: 26861 RVA: 0x000315DD File Offset: 0x0002F7DD
		public unsafe Coroutine gameRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_gameRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x060068EE RID: 26862 RVA: 0x001D97CC File Offset: 0x001D79CC
		// (set) Token: 0x060068EF RID: 26863 RVA: 0x000315FC File Offset: 0x0002F7FC
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x060068F0 RID: 26864 RVA: 0x001D97F4 File Offset: 0x001D79F4
		// (set) Token: 0x060068F1 RID: 26865 RVA: 0x00031617 File Offset: 0x0002F817
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400475D RID: 18269
		private static readonly System.IntPtr NativeFieldInfoPtr_BET_MINIMUM;

		// Token: 0x0400475E RID: 18270
		private static readonly System.IntPtr NativeFieldInfoPtr_BET_MAXIMUM;

		// Token: 0x0400475F RID: 18271
		private static readonly System.IntPtr NativeFieldInfoPtr_PAYOUT_RATIO;

		// Token: 0x04004760 RID: 18272
		private static readonly System.IntPtr NativeFieldInfoPtr_BLACKJACK_PAYOUT_RATIO;

		// Token: 0x04004761 RID: 18273
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentStage_k__BackingField;

		// Token: 0x04004762 RID: 18274
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayerTurn_k__BackingField;

		// Token: 0x04004763 RID: 18275
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerBet_k__BackingField;

		// Token: 0x04004764 RID: 18276
		private static readonly System.IntPtr NativeFieldInfoPtr__DealerScore_k__BackingField;

		// Token: 0x04004765 RID: 18277
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalPlayerScore_k__BackingField;

		// Token: 0x04004766 RID: 18278
		private static readonly System.IntPtr NativeFieldInfoPtr__IsLocalPlayerBlackjack_k__BackingField;

		// Token: 0x04004767 RID: 18279
		private static readonly System.IntPtr NativeFieldInfoPtr__IsLocalPlayerBust_k__BackingField;

		// Token: 0x04004768 RID: 18280
		private static readonly System.IntPtr NativeFieldInfoPtr_Cards;

		// Token: 0x04004769 RID: 18281
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCardPositions;

		// Token: 0x0400476A RID: 18282
		private static readonly System.IntPtr NativeFieldInfoPtr_FocusedCameraTransforms;

		// Token: 0x0400476B RID: 18283
		private static readonly System.IntPtr NativeFieldInfoPtr_FinalCameraTransforms;

		// Token: 0x0400476C RID: 18284
		private static readonly System.IntPtr NativeFieldInfoPtr_Player1CardPositions;

		// Token: 0x0400476D RID: 18285
		private static readonly System.IntPtr NativeFieldInfoPtr_Player2CardPositions;

		// Token: 0x0400476E RID: 18286
		private static readonly System.IntPtr NativeFieldInfoPtr_Player3CardPositions;

		// Token: 0x0400476F RID: 18287
		private static readonly System.IntPtr NativeFieldInfoPtr_Player4CardPositions;

		// Token: 0x04004770 RID: 18288
		private static readonly System.IntPtr NativeFieldInfoPtr_DealerCardPositions;

		// Token: 0x04004771 RID: 18289
		private static readonly System.IntPtr NativeFieldInfoPtr_playersInCurrentRound;

		// Token: 0x04004772 RID: 18290
		private static readonly System.IntPtr NativeFieldInfoPtr_playStack;

		// Token: 0x04004773 RID: 18291
		private static readonly System.IntPtr NativeFieldInfoPtr_player1Hand;

		// Token: 0x04004774 RID: 18292
		private static readonly System.IntPtr NativeFieldInfoPtr_player2Hand;

		// Token: 0x04004775 RID: 18293
		private static readonly System.IntPtr NativeFieldInfoPtr_player3Hand;

		// Token: 0x04004776 RID: 18294
		private static readonly System.IntPtr NativeFieldInfoPtr_player4Hand;

		// Token: 0x04004777 RID: 18295
		private static readonly System.IntPtr NativeFieldInfoPtr_dealerHand;

		// Token: 0x04004778 RID: 18296
		private static readonly System.IntPtr NativeFieldInfoPtr_cardValuesInDeck;

		// Token: 0x04004779 RID: 18297
		private static readonly System.IntPtr NativeFieldInfoPtr_drawnCardsValues;

		// Token: 0x0400477A RID: 18298
		private static readonly System.IntPtr NativeFieldInfoPtr_localFocusCameraTransform;

		// Token: 0x0400477B RID: 18299
		private static readonly System.IntPtr NativeFieldInfoPtr_localFinalCameraTransform;

		// Token: 0x0400477C RID: 18300
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerBetChange;

		// Token: 0x0400477D RID: 18301
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerExitRound;

		// Token: 0x0400477E RID: 18302
		private static readonly System.IntPtr NativeFieldInfoPtr_onInitialCardsDealt;

		// Token: 0x0400477F RID: 18303
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerReadyForInput;

		// Token: 0x04004780 RID: 18304
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerBust;

		// Token: 0x04004781 RID: 18305
		private static readonly System.IntPtr NativeFieldInfoPtr_onLocalPlayerRoundCompleted;

		// Token: 0x04004782 RID: 18306
		private static readonly System.IntPtr NativeFieldInfoPtr_roundEnded;

		// Token: 0x04004783 RID: 18307
		private static readonly System.IntPtr NativeFieldInfoPtr_gameRoutine;

		// Token: 0x04004784 RID: 18308
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004785 RID: 18309
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004786 RID: 18310
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStage_Public_get_EStage_0;

		// Token: 0x04004787 RID: 18311
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentStage_Private_set_Void_EStage_0;

		// Token: 0x04004788 RID: 18312
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerTurn_Public_get_Player_0;

		// Token: 0x04004789 RID: 18313
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerTurn_Private_set_Void_Player_0;

		// Token: 0x0400478A RID: 18314
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPlayerBet_Public_get_Single_0;

		// Token: 0x0400478B RID: 18315
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalPlayerBet_Private_set_Void_Single_0;

		// Token: 0x0400478C RID: 18316
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DealerScore_Public_get_Int32_0;

		// Token: 0x0400478D RID: 18317
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DealerScore_Private_set_Void_Int32_0;

		// Token: 0x0400478E RID: 18318
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPlayerScore_Public_get_Int32_0;

		// Token: 0x0400478F RID: 18319
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalPlayerScore_Private_set_Void_Int32_0;

		// Token: 0x04004790 RID: 18320
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBlackjack_Public_get_Boolean_0;

		// Token: 0x04004791 RID: 18321
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBlackjack_Private_set_Void_Boolean_0;

		// Token: 0x04004792 RID: 18322
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalPlayerBust_Public_get_Boolean_0;

		// Token: 0x04004793 RID: 18323
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLocalPlayerBust_Private_set_Void_Boolean_0;

		// Token: 0x04004794 RID: 18324
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLocalPlayerInCurrentRound_Public_get_Boolean_0;

		// Token: 0x04004795 RID: 18325
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004796 RID: 18326
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Protected_Virtual_Void_1;

		// Token: 0x04004797 RID: 18327
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Protected_Virtual_Void_1;

		// Token: 0x04004798 RID: 18328
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x04004799 RID: 18329
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_Void_1;

		// Token: 0x0400479A RID: 18330
		private static readonly System.IntPtr NativeMethodInfoPtr_GetClockwisePlayers_Private_List_1_Player_0;

		// Token: 0x0400479B RID: 18331
		private static readonly System.IntPtr NativeMethodInfoPtr_StartGame_Private_Void_0;

		// Token: 0x0400479C RID: 18332
		private static readonly System.IntPtr NativeMethodInfoPtr_NotifyPlayerScore_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x0400479D RID: 18333
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerCardPositions_Private_Il2CppReferenceArray_1_Transform_Int32_0;

		// Token: 0x0400479E RID: 18334
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRoundEnded_Private_Void_Boolean_0;

		// Token: 0x0400479F RID: 18335
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_PlayingCard_0;

		// Token: 0x040047A0 RID: 18336
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCardToPlayerHand_Private_Void_Int32_String_0;

		// Token: 0x040047A1 RID: 18337
		private static readonly System.IntPtr NativeMethodInfoPtr_AddCardToDealerHand_Private_Void_String_0;

		// Token: 0x040047A2 RID: 18338
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerCards_Private_List_1_PlayingCard_Int32_0;

		// Token: 0x040047A3 RID: 18339
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHandScore_Private_Int32_List_1_PlayingCard_Boolean_0;

		// Token: 0x040047A4 RID: 18340
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCardValue_Private_Int32_PlayingCard_Boolean_0;

		// Token: 0x040047A5 RID: 18341
		private static readonly System.IntPtr NativeMethodInfoPtr_DrawCard_Private_PlayingCard_0;

		// Token: 0x040047A6 RID: 18342
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetCards_Private_Void_0;

		// Token: 0x040047A7 RID: 18343
		private static readonly System.IntPtr NativeMethodInfoPtr_EndGame_Private_Void_0;

		// Token: 0x040047A8 RID: 18344
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveLocalPlayerFromGame_Public_Void_EPayoutType_Single_0;

		// Token: 0x040047A9 RID: 18345
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPayout_Public_Single_Single_EPayoutType_0;

		// Token: 0x040047AA RID: 18346
		private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentRoundEmpty_Private_Boolean_0;

		// Token: 0x040047AB RID: 18347
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPlayerToCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040047AC RID: 18348
		private static readonly System.IntPtr NativeMethodInfoPtr_RequestRemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040047AD RID: 18349
		private static readonly System.IntPtr NativeMethodInfoPtr_RemovePlayerFromCurrentRound_Private_Void_NetworkObject_0;

		// Token: 0x040047AE RID: 18350
		private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalPlayerBet_Public_Void_Single_0;

		// Token: 0x040047AF RID: 18351
		private static readonly System.IntPtr NativeMethodInfoPtr_AreAllPlayersReady_Public_Boolean_0;

		// Token: 0x040047B0 RID: 18352
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayersReadyCount_Public_Int32_0;

		// Token: 0x040047B1 RID: 18353
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleLocalPlayerReady_Public_Void_0;

		// Token: 0x040047B2 RID: 18354
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040047B3 RID: 18355
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040047B4 RID: 18356
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040047B5 RID: 18357
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040047B6 RID: 18358
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartGame_2166136261_Private_Void_0;

		// Token: 0x040047B7 RID: 18359
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartGame_2166136261_Private_Void_0;

		// Token: 0x040047B8 RID: 18360
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047B9 RID: 18361
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x040047BA RID: 18362
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___NotifyPlayerScore_2864061566_Private_Void_NetworkObject_Int32_Boolean_0;

		// Token: 0x040047BB RID: 18363
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_NotifyPlayerScore_2864061566_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047BC RID: 18364
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x040047BD RID: 18365
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetRoundEnded_1140765316_Private_Void_Boolean_0;

		// Token: 0x040047BE RID: 18366
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRoundEnded_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047BF RID: 18367
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x040047C0 RID: 18368
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToPlayerHand_2801973956_Private_Void_Int32_String_0;

		// Token: 0x040047C1 RID: 18369
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToPlayerHand_2801973956_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047C2 RID: 18370
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x040047C3 RID: 18371
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddCardToDealerHand_3615296227_Private_Void_String_0;

		// Token: 0x040047C4 RID: 18372
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCardToDealerHand_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047C5 RID: 18373
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndGame_2166136261_Private_Void_0;

		// Token: 0x040047C6 RID: 18374
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___EndGame_2166136261_Private_Void_0;

		// Token: 0x040047C7 RID: 18375
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndGame_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047C8 RID: 18376
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040047C9 RID: 18377
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerToCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040047CA RID: 18378
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerToCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047CB RID: 18379
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040047CC RID: 18380
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040047CD RID: 18381
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_RequestRemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047CE RID: 18382
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040047CF RID: 18383
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___RemovePlayerFromCurrentRound_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040047D0 RID: 18384
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemovePlayerFromCurrentRound_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047D1 RID: 18385
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A85 RID: 2693
		[OriginalName("Assembly-CSharp.dll", "", "EStage")]
		public enum EStage
		{
			// Token: 0x04008F96 RID: 36758
			WaitingForPlayers,
			// Token: 0x04008F97 RID: 36759
			Dealing,
			// Token: 0x04008F98 RID: 36760
			PlayerTurn,
			// Token: 0x04008F99 RID: 36761
			DealerTurn,
			// Token: 0x04008F9A RID: 36762
			Ending
		}

		// Token: 0x02000A86 RID: 2694
		[OriginalName("Assembly-CSharp.dll", "", "EPayoutType")]
		public enum EPayoutType
		{
			// Token: 0x04008F9C RID: 36764
			None,
			// Token: 0x04008F9D RID: 36765
			Blackjack,
			// Token: 0x04008F9E RID: 36766
			Win,
			// Token: 0x04008F9F RID: 36767
			Push
		}

		// Token: 0x02000A87 RID: 2695
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4DE RID: 54494 RVA: 0x00333C4C File Offset: 0x00331E4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "clockwisePlayers");
				BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676662);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676663);
				BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, 100676664);
			}

			// Token: 0x0600D4DF RID: 54495 RVA: 0x00333CDC File Offset: 0x00331EDC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4E0 RID: 54496 RVA: 0x00333D18 File Offset: 0x00331F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211756, XrefRangeEnd = 211761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D4E1 RID: 54497 RVA: 0x00333D58 File Offset: 0x00331F58
			[CallerCount(0)]
			public unsafe bool _StartGame_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4E2 RID: 54498 RVA: 0x000673FA File Offset: 0x000655FA
			public __c__DisplayClass70_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D4 RID: 16852
			// (get) Token: 0x0600D4E3 RID: 54499 RVA: 0x00333D94 File Offset: 0x00331F94
			// (set) Token: 0x0600D4E4 RID: 54500 RVA: 0x00067403 File Offset: 0x00065603
			public unsafe List<Player> clockwisePlayers
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr_clockwisePlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D5 RID: 16853
			// (get) Token: 0x0600D4E5 RID: 54501 RVA: 0x00333DC4 File Offset: 0x00331FC4
			// (set) Token: 0x0600D4E6 RID: 54502 RVA: 0x00067422 File Offset: 0x00065622
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FA0 RID: 36768
			private static readonly System.IntPtr NativeFieldInfoPtr_clockwisePlayers;

			// Token: 0x04008FA1 RID: 36769
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FA2 RID: 36770
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FA3 RID: 36771
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008FA4 RID: 36772
			private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__1_Internal_Boolean_0;

			// Token: 0x02000CB3 RID: 3251
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_0+<<StartGame>g__GameRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E91C RID: 59676 RVA: 0x0036D56C File Offset: 0x0036B76C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0>.NativeClassPtr, "<<StartGame>g__GameRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<>8__1");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<drawSpacing>5__2");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<dealerTurn>5__3");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<i>5__4");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<playerIndex>5__5");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, "<turn>5__6");
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676665);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676666);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676667);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676668);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676669);
					BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr, 100676670);
				}

				// Token: 0x0600E91D RID: 59677 RVA: 0x0036D6C4 File Offset: 0x0036B8C4
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E91E RID: 59678 RVA: 0x0036D70C File Offset: 0x0036B90C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E91F RID: 59679 RVA: 0x0036D740 File Offset: 0x0036B940
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211492, XrefRangeEnd = 211751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700480B RID: 18443
				// (get) Token: 0x0600E920 RID: 59680 RVA: 0x0036D77C File Offset: 0x0036B97C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E921 RID: 59681 RVA: 0x0036D7BC File Offset: 0x0036B9BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211751, XrefRangeEnd = 211756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700480C RID: 18444
				// (get) Token: 0x0600E922 RID: 59682 RVA: 0x0036D7F0 File Offset: 0x0036B9F0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E923 RID: 59683 RVA: 0x000714DC File Offset: 0x0006F6DC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004802 RID: 18434
				// (get) Token: 0x0600E924 RID: 59684 RVA: 0x0036D830 File Offset: 0x0036BA30
				// (set) Token: 0x0600E925 RID: 59685 RVA: 0x000714E5 File Offset: 0x0006F6E5
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004803 RID: 18435
				// (get) Token: 0x0600E926 RID: 59686 RVA: 0x0036D858 File Offset: 0x0036BA58
				// (set) Token: 0x0600E927 RID: 59687 RVA: 0x00071500 File Offset: 0x0006F700
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004804 RID: 18436
				// (get) Token: 0x0600E928 RID: 59688 RVA: 0x0036D888 File Offset: 0x0036BA88
				// (set) Token: 0x0600E929 RID: 59689 RVA: 0x0007151F File Offset: 0x0006F71F
				public unsafe BlackjackGameController.__c__DisplayClass70_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004805 RID: 18437
				// (get) Token: 0x0600E92A RID: 59690 RVA: 0x0036D8B8 File Offset: 0x0036BAB8
				// (set) Token: 0x0600E92B RID: 59691 RVA: 0x0007153E File Offset: 0x0006F73E
				public unsafe BlackjackGameController.__c__DisplayClass70_1 __8__1
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_1>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004806 RID: 18438
				// (get) Token: 0x0600E92C RID: 59692 RVA: 0x0036D8E8 File Offset: 0x0036BAE8
				// (set) Token: 0x0600E92D RID: 59693 RVA: 0x0007155D File Offset: 0x0006F75D
				public unsafe float _drawSpacing_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__drawSpacing_5__2)) = value;
					}
				}

				// Token: 0x17004807 RID: 18439
				// (get) Token: 0x0600E92E RID: 59694 RVA: 0x0036D910 File Offset: 0x0036BB10
				// (set) Token: 0x0600E92F RID: 59695 RVA: 0x00071578 File Offset: 0x0006F778
				public unsafe int _dealerTurn_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__dealerTurn_5__3)) = value;
					}
				}

				// Token: 0x17004808 RID: 18440
				// (get) Token: 0x0600E930 RID: 59696 RVA: 0x0036D938 File Offset: 0x0036BB38
				// (set) Token: 0x0600E931 RID: 59697 RVA: 0x00071593 File Offset: 0x0006F793
				public unsafe int _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x17004809 RID: 18441
				// (get) Token: 0x0600E932 RID: 59698 RVA: 0x0036D960 File Offset: 0x0036BB60
				// (set) Token: 0x0600E933 RID: 59699 RVA: 0x000715AE File Offset: 0x0006F7AE
				public unsafe int _playerIndex_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__playerIndex_5__5)) = value;
					}
				}

				// Token: 0x1700480A RID: 18442
				// (get) Token: 0x0600E934 RID: 59700 RVA: 0x0036D988 File Offset: 0x0036BB88
				// (set) Token: 0x0600E935 RID: 59701 RVA: 0x000715C9 File Offset: 0x0006F7C9
				public unsafe int _turn_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObInObInInUnique.NativeFieldInfoPtr__turn_5__6)) = value;
					}
				}

				// Token: 0x04009C08 RID: 39944
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C09 RID: 39945
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C0A RID: 39946
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C0B RID: 39947
				private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x04009C0C RID: 39948
				private static readonly System.IntPtr NativeFieldInfoPtr__drawSpacing_5__2;

				// Token: 0x04009C0D RID: 39949
				private static readonly System.IntPtr NativeFieldInfoPtr__dealerTurn_5__3;

				// Token: 0x04009C0E RID: 39950
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009C0F RID: 39951
				private static readonly System.IntPtr NativeFieldInfoPtr__playerIndex_5__5;

				// Token: 0x04009C10 RID: 39952
				private static readonly System.IntPtr NativeFieldInfoPtr__turn_5__6;

				// Token: 0x04009C11 RID: 39953
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C12 RID: 39954
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C13 RID: 39955
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C14 RID: 39956
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C15 RID: 39957
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C16 RID: 39958
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A88 RID: 2696
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass70_1")]
		public sealed class __c__DisplayClass70_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D4E7 RID: 54503 RVA: 0x00333DF4 File Offset: 0x00331FF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_1()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass70_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "player");
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "CS$<>8__locals1");
				BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, "<>9__2");
				BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, 100676671);
				BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr, 100676672);
			}

			// Token: 0x0600D4E8 RID: 54504 RVA: 0x00333E84 File Offset: 0x00332084
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass70_1>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4E9 RID: 54505 RVA: 0x00333EC0 File Offset: 0x003320C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211761, XrefRangeEnd = 211768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _StartGame_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass70_1.NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4EA RID: 54506 RVA: 0x00067441 File Offset: 0x00065641
			public __c__DisplayClass70_1(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D6 RID: 16854
			// (get) Token: 0x0600D4EB RID: 54507 RVA: 0x00333EFC File Offset: 0x003320FC
			// (set) Token: 0x0600D4EC RID: 54508 RVA: 0x0006744A File Offset: 0x0006564A
			public unsafe Player player
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D7 RID: 16855
			// (get) Token: 0x0600D4ED RID: 54509 RVA: 0x00333F2C File Offset: 0x0033212C
			// (set) Token: 0x0600D4EE RID: 54510 RVA: 0x00067469 File Offset: 0x00065669
			public unsafe BlackjackGameController.__c__DisplayClass70_0 field_Public___c__DisplayClass70_0_0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass70_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D8 RID: 16856
			// (get) Token: 0x0600D4EF RID: 54511 RVA: 0x00333F5C File Offset: 0x0033215C
			// (set) Token: 0x0600D4F0 RID: 54512 RVA: 0x00067488 File Offset: 0x00065688
			public unsafe Il2CppSystem.Func<bool> __9__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass70_1.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FA5 RID: 36773
			private static readonly System.IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04008FA6 RID: 36774
			private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass70_0_0;

			// Token: 0x04008FA7 RID: 36775
			private static readonly System.IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04008FA8 RID: 36776
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FA9 RID: 36777
			private static readonly System.IntPtr NativeMethodInfoPtr__StartGame_b__2_Internal_Boolean_0;
		}

		// Token: 0x02000A89 RID: 2697
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4F1 RID: 54513 RVA: 0x00333F8C File Offset: 0x0033218C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, 100676673);
				BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr, 100676674);
			}

			// Token: 0x0600D4F2 RID: 54514 RVA: 0x00333FF4 File Offset: 0x003321F4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass75_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4F3 RID: 54515 RVA: 0x00334030 File Offset: 0x00332230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211768, XrefRangeEnd = 211770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToPlayerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass75_0.NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4F4 RID: 54516 RVA: 0x000674A7 File Offset: 0x000656A7
			public __c__DisplayClass75_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D9 RID: 16857
			// (get) Token: 0x0600D4F5 RID: 54517 RVA: 0x00334080 File Offset: 0x00332280
			// (set) Token: 0x0600D4F6 RID: 54518 RVA: 0x000674B0 File Offset: 0x000656B0
			public unsafe string cardID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass75_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008FAA RID: 36778
			private static readonly System.IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04008FAB RID: 36779
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FAC RID: 36780
			private static readonly System.IntPtr NativeMethodInfoPtr__AddCardToPlayerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000A8A RID: 2698
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4F7 RID: 54519 RVA: 0x003340A8 File Offset: 0x003322A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, "cardID");
				BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, 100676675);
				BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr, 100676676);
			}

			// Token: 0x0600D4F8 RID: 54520 RVA: 0x00334110 File Offset: 0x00332310
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass76_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4F9 RID: 54521 RVA: 0x0033414C File Offset: 0x0033234C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCardToDealerHand_b__0(PlayingCard x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass76_0.NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D4FA RID: 54522 RVA: 0x000674CF File Offset: 0x000656CF
			public __c__DisplayClass76_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041DA RID: 16858
			// (get) Token: 0x0600D4FB RID: 54523 RVA: 0x0033419C File Offset: 0x0033239C
			// (set) Token: 0x0600D4FC RID: 54524 RVA: 0x000674D8 File Offset: 0x000656D8
			public unsafe string cardID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass76_0.NativeFieldInfoPtr_cardID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008FAD RID: 36781
			private static readonly System.IntPtr NativeFieldInfoPtr_cardID;

			// Token: 0x04008FAE RID: 36782
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FAF RID: 36783
			private static readonly System.IntPtr NativeMethodInfoPtr__AddCardToDealerHand_b__0_Internal_Boolean_PlayingCard_0;
		}

		// Token: 0x02000A8B RID: 2699
		[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4FD RID: 54525 RVA: 0x003341C4 File Offset: 0x003323C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr);
				BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "cameraDelay");
				BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, 100676677);
				BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, 100676678);
			}

			// Token: 0x0600D4FE RID: 54526 RVA: 0x00334240 File Offset: 0x00332440
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D4FF RID: 54527 RVA: 0x0033427C File Offset: 0x0033247C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211788, XrefRangeEnd = 211793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D500 RID: 54528 RVA: 0x000674F7 File Offset: 0x000656F7
			public __c__DisplayClass83_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041DB RID: 16859
			// (get) Token: 0x0600D501 RID: 54529 RVA: 0x003342BC File Offset: 0x003324BC
			// (set) Token: 0x0600D502 RID: 54530 RVA: 0x00067500 File Offset: 0x00065700
			public unsafe float cameraDelay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr_cameraDelay)) = value;
				}
			}

			// Token: 0x170041DC RID: 16860
			// (get) Token: 0x0600D503 RID: 54531 RVA: 0x003342E4 File Offset: 0x003324E4
			// (set) Token: 0x0600D504 RID: 54532 RVA: 0x0006751B File Offset: 0x0006571B
			public unsafe BlackjackGameController __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FB0 RID: 36784
			private static readonly System.IntPtr NativeFieldInfoPtr_cameraDelay;

			// Token: 0x04008FB1 RID: 36785
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FB2 RID: 36786
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FB3 RID: 36787
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CB4 RID: 3252
			[ObfuscatedName("ScheduleOne.Casino.BlackjackGameController+<>c__DisplayClass83_0+<<RemoveLocalPlayerFromGame>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E936 RID: 59702 RVA: 0x0036D9B0 File Offset: 0x0036BBB0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0>.NativeClassPtr, "<<RemoveLocalPlayerFromGame>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676679);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676680);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676681);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676682);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676683);
					BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676684);
				}

				// Token: 0x0600E937 RID: 59703 RVA: 0x0036DA90 File Offset: 0x0036BC90
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E938 RID: 59704 RVA: 0x0036DAD8 File Offset: 0x0036BCD8
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E939 RID: 59705 RVA: 0x0036DB0C File Offset: 0x0036BD0C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211770, XrefRangeEnd = 211783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004810 RID: 18448
				// (get) Token: 0x0600E93A RID: 59706 RVA: 0x0036DB48 File Offset: 0x0036BD48
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E93B RID: 59707 RVA: 0x0036DB88 File Offset: 0x0036BD88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211783, XrefRangeEnd = 211788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004811 RID: 18449
				// (get) Token: 0x0600E93C RID: 59708 RVA: 0x0036DBBC File Offset: 0x0036BDBC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E93D RID: 59709 RVA: 0x000715E4 File Offset: 0x0006F7E4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700480D RID: 18445
				// (get) Token: 0x0600E93E RID: 59710 RVA: 0x0036DBFC File Offset: 0x0036BDFC
				// (set) Token: 0x0600E93F RID: 59711 RVA: 0x000715ED File Offset: 0x0006F7ED
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700480E RID: 18446
				// (get) Token: 0x0600E940 RID: 59712 RVA: 0x0036DC24 File Offset: 0x0036BE24
				// (set) Token: 0x0600E941 RID: 59713 RVA: 0x00071608 File Offset: 0x0006F808
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700480F RID: 18447
				// (get) Token: 0x0600E942 RID: 59714 RVA: 0x0036DC54 File Offset: 0x0036BE54
				// (set) Token: 0x0600E943 RID: 59715 RVA: 0x00071627 File Offset: 0x0006F827
				public unsafe BlackjackGameController.__c__DisplayClass83_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController.__c__DisplayClass83_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackGameController.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009C17 RID: 39959
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C18 RID: 39960
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C19 RID: 39961
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C1A RID: 39962
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C1B RID: 39963
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C1C RID: 39964
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C1D RID: 39965
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C1E RID: 39966
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C1F RID: 39967
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
