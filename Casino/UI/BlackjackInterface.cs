using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004CC RID: 1228
	public class BlackjackInterface : Singleton<BlackjackInterface>
	{
		// Token: 0x06006AD7 RID: 27351 RVA: 0x001E13E8 File Offset: 0x001DF5E8
		// Note: this type is marked as 'beforefieldinit'.
		static BlackjackInterface()
		{
			Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "BlackjackInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr);
			BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			BlackjackInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "Canvas");
			BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerDisplay");
			BlackjackInterface.NativeFieldInfoPtr_BetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetContainer");
			BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetTitleLabel");
			BlackjackInterface.NativeFieldInfoPtr_BetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetSlider");
			BlackjackInterface.NativeFieldInfoPtr_BetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "BetAmount");
			BlackjackInterface.NativeFieldInfoPtr_ReadyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ReadyButton");
			BlackjackInterface.NativeFieldInfoPtr_ReadyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ReadyLabel");
			BlackjackInterface.NativeFieldInfoPtr_WaitingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingContainer");
			BlackjackInterface.NativeFieldInfoPtr_WaitingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "WaitingLabel");
			BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "DealerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PlayerScoreLabel");
			BlackjackInterface.NativeFieldInfoPtr_HitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "HitButton");
			BlackjackInterface.NativeFieldInfoPtr_StandButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "StandButton");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeIn");
			BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "InputContainerFadeOut");
			BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "SelectionIndicator");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerAnimation");
			BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "ScoresContainerCanvasGroup");
			BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PositiveOutcomeLabel");
			BlackjackInterface.NativeFieldInfoPtr_PayoutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "PayoutLabel");
			BlackjackInterface.NativeFieldInfoPtr_onBust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBust");
			BlackjackInterface.NativeFieldInfoPtr_onBlackjack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onBlackjack");
			BlackjackInterface.NativeFieldInfoPtr_onWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onWin");
			BlackjackInterface.NativeFieldInfoPtr_onLose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onLose");
			BlackjackInterface.NativeFieldInfoPtr_onPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, "onPush");
			BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676990);
			BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676991);
			BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676992);
			BlackjackInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676993);
			BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676994);
			BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676995);
			BlackjackInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676996);
			BlackjackInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676997);
			BlackjackInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676998);
			BlackjackInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100676999);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677000);
			BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677001);
			BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677002);
			BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677003);
			BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677004);
			BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677005);
			BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677006);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677007);
			BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677008);
			BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr, 100677009);
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06006AD8 RID: 27352 RVA: 0x001E17EC File Offset: 0x001DF9EC
		// (set) Token: 0x06006AD9 RID: 27353 RVA: 0x001E182C File Offset: 0x001DFA2C
		public unsafe BlackjackGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006ADA RID: 27354 RVA: 0x001E1870 File Offset: 0x001DFA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216275, XrefRangeEnd = 216311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BlackjackInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADB RID: 27355 RVA: 0x001E18AC File Offset: 0x001DFAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216311, XrefRangeEnd = 216356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x001E18E0 File Offset: 0x001DFAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216446, RefRangeEnd = 216447, XrefRangeStart = 216356, XrefRangeEnd = 216446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(BlackjackGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADD RID: 27357 RVA: 0x001E1924 File Offset: 0x001DFB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216536, RefRangeEnd = 216537, XrefRangeStart = 216447, XrefRangeEnd = 216536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADE RID: 27358 RVA: 0x001E1958 File Offset: 0x001DFB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216537, XrefRangeEnd = 216542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006ADF RID: 27359 RVA: 0x001E1998 File Offset: 0x001DFB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216542, XrefRangeEnd = 216544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sliderVal;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006AE0 RID: 27360 RVA: 0x001E19E4 File Offset: 0x001DFBE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216549, RefRangeEnd = 216552, XrefRangeStart = 216544, XrefRangeEnd = 216549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE1 RID: 27361 RVA: 0x001E1A18 File Offset: 0x001DFC18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216570, RefRangeEnd = 216571, XrefRangeStart = 216552, XrefRangeEnd = 216570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE2 RID: 27362 RVA: 0x001E1A4C File Offset: 0x001DFC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216571, XrefRangeEnd = 216577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerReadyForInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x001E1A80 File Offset: 0x001DFC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216577, XrefRangeEnd = 216580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ShowScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x001E1AB4 File Offset: 0x001DFCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216580, XrefRangeEnd = 216583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HideScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x001E1AE8 File Offset: 0x001DFCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216583, XrefRangeEnd = 216599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_HitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE6 RID: 27366 RVA: 0x001E1B1C File Offset: 0x001DFD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216599, XrefRangeEnd = 216615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_StandClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x001E1B50 File Offset: 0x001DFD50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216615, XrefRangeEnd = 216621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x001E1B84 File Offset: 0x001DFD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216621, XrefRangeEnd = 216623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x001E1BB8 File Offset: 0x001DFDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216623, XrefRangeEnd = 216624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerBust()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x001E1BEC File Offset: 0x001DFDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216624, XrefRangeEnd = 216629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLocalPlayerRoundCompleted(BlackjackGameController.EPayoutType payout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payout;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x001E1C2C File Offset: 0x001DFE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216629, XrefRangeEnd = 216632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BlackjackInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlackjackInterface>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BlackjackInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00032213 File Offset: 0x00030413
		public BlackjackInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FE0 RID: 8160
		// (get) Token: 0x06006AED RID: 27373 RVA: 0x001E1C68 File Offset: 0x001DFE68
		// (set) Token: 0x06006AEE RID: 27374 RVA: 0x0003221C File Offset: 0x0003041C
		public unsafe BlackjackGameController _CurrentGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BlackjackGameController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE1 RID: 8161
		// (get) Token: 0x06006AEF RID: 27375 RVA: 0x001E1C98 File Offset: 0x001DFE98
		// (set) Token: 0x06006AF0 RID: 27376 RVA: 0x0003223B File Offset: 0x0003043B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE2 RID: 8162
		// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x001E1CC8 File Offset: 0x001DFEC8
		// (set) Token: 0x06006AF2 RID: 27378 RVA: 0x0003225A File Offset: 0x0003045A
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE3 RID: 8163
		// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x001E1CF8 File Offset: 0x001DFEF8
		// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x00032279 File Offset: 0x00030479
		public unsafe RectTransform BetContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE4 RID: 8164
		// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x001E1D28 File Offset: 0x001DFF28
		// (set) Token: 0x06006AF6 RID: 27382 RVA: 0x00032298 File Offset: 0x00030498
		public unsafe TextMeshProUGUI BetTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE5 RID: 8165
		// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x001E1D58 File Offset: 0x001DFF58
		// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x000322B7 File Offset: 0x000304B7
		public unsafe Slider BetSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE6 RID: 8166
		// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x001E1D88 File Offset: 0x001DFF88
		// (set) Token: 0x06006AFA RID: 27386 RVA: 0x000322D6 File Offset: 0x000304D6
		public unsafe TextMeshProUGUI BetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_BetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE7 RID: 8167
		// (get) Token: 0x06006AFB RID: 27387 RVA: 0x001E1DB8 File Offset: 0x001DFFB8
		// (set) Token: 0x06006AFC RID: 27388 RVA: 0x000322F5 File Offset: 0x000304F5
		public unsafe Button ReadyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE8 RID: 8168
		// (get) Token: 0x06006AFD RID: 27389 RVA: 0x001E1DE8 File Offset: 0x001DFFE8
		// (set) Token: 0x06006AFE RID: 27390 RVA: 0x00032314 File Offset: 0x00030514
		public unsafe TextMeshProUGUI ReadyLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ReadyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FE9 RID: 8169
		// (get) Token: 0x06006AFF RID: 27391 RVA: 0x001E1E18 File Offset: 0x001E0018
		// (set) Token: 0x06006B00 RID: 27392 RVA: 0x00032333 File Offset: 0x00030533
		public unsafe RectTransform WaitingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEA RID: 8170
		// (get) Token: 0x06006B01 RID: 27393 RVA: 0x001E1E48 File Offset: 0x001E0048
		// (set) Token: 0x06006B02 RID: 27394 RVA: 0x00032352 File Offset: 0x00030552
		public unsafe TextMeshProUGUI WaitingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_WaitingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEB RID: 8171
		// (get) Token: 0x06006B03 RID: 27395 RVA: 0x001E1E78 File Offset: 0x001E0078
		// (set) Token: 0x06006B04 RID: 27396 RVA: 0x00032371 File Offset: 0x00030571
		public unsafe TextMeshProUGUI DealerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_DealerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEC RID: 8172
		// (get) Token: 0x06006B05 RID: 27397 RVA: 0x001E1EA8 File Offset: 0x001E00A8
		// (set) Token: 0x06006B06 RID: 27398 RVA: 0x00032390 File Offset: 0x00030590
		public unsafe TextMeshProUGUI PlayerScoreLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PlayerScoreLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06006B07 RID: 27399 RVA: 0x001E1ED8 File Offset: 0x001E00D8
		// (set) Token: 0x06006B08 RID: 27400 RVA: 0x000323AF File Offset: 0x000305AF
		public unsafe Button HitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_HitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x001E1F08 File Offset: 0x001E0108
		// (set) Token: 0x06006B0A RID: 27402 RVA: 0x000323CE File Offset: 0x000305CE
		public unsafe Button StandButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_StandButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x001E1F38 File Offset: 0x001E0138
		// (set) Token: 0x06006B0C RID: 27404 RVA: 0x000323ED File Offset: 0x000305ED
		public unsafe Animation InputContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF0 RID: 8176
		// (get) Token: 0x06006B0D RID: 27405 RVA: 0x001E1F68 File Offset: 0x001E0168
		// (set) Token: 0x06006B0E RID: 27406 RVA: 0x0003240C File Offset: 0x0003060C
		public unsafe CanvasGroup InputContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x06006B0F RID: 27407 RVA: 0x001E1F98 File Offset: 0x001E0198
		// (set) Token: 0x06006B10 RID: 27408 RVA: 0x0003242B File Offset: 0x0003062B
		public unsafe AnimationClip InputContainerFadeIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x06006B11 RID: 27409 RVA: 0x001E1FC8 File Offset: 0x001E01C8
		// (set) Token: 0x06006B12 RID: 27410 RVA: 0x0003244A File Offset: 0x0003064A
		public unsafe AnimationClip InputContainerFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_InputContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x06006B13 RID: 27411 RVA: 0x001E1FF8 File Offset: 0x001E01F8
		// (set) Token: 0x06006B14 RID: 27412 RVA: 0x00032469 File Offset: 0x00030669
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06006B15 RID: 27413 RVA: 0x001E2028 File Offset: 0x001E0228
		// (set) Token: 0x06006B16 RID: 27414 RVA: 0x00032488 File Offset: 0x00030688
		public unsafe Animation ScoresContainerAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06006B17 RID: 27415 RVA: 0x001E2058 File Offset: 0x001E0258
		// (set) Token: 0x06006B18 RID: 27416 RVA: 0x000324A7 File Offset: 0x000306A7
		public unsafe CanvasGroup ScoresContainerCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_ScoresContainerCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06006B19 RID: 27417 RVA: 0x001E2088 File Offset: 0x001E0288
		// (set) Token: 0x06006B1A RID: 27418 RVA: 0x000324C6 File Offset: 0x000306C6
		public unsafe TextMeshProUGUI PositiveOutcomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PositiveOutcomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06006B1B RID: 27419 RVA: 0x001E20B8 File Offset: 0x001E02B8
		// (set) Token: 0x06006B1C RID: 27420 RVA: 0x000324E5 File Offset: 0x000306E5
		public unsafe TextMeshProUGUI PayoutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_PayoutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06006B1D RID: 27421 RVA: 0x001E20E8 File Offset: 0x001E02E8
		// (set) Token: 0x06006B1E RID: 27422 RVA: 0x00032504 File Offset: 0x00030704
		public unsafe UnityEvent onBust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x06006B1F RID: 27423 RVA: 0x001E2118 File Offset: 0x001E0318
		// (set) Token: 0x06006B20 RID: 27424 RVA: 0x00032523 File Offset: 0x00030723
		public unsafe UnityEvent onBlackjack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onBlackjack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x001E2148 File Offset: 0x001E0348
		// (set) Token: 0x06006B22 RID: 27426 RVA: 0x00032542 File Offset: 0x00030742
		public unsafe UnityEvent onWin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onWin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06006B23 RID: 27427 RVA: 0x001E2178 File Offset: 0x001E0378
		// (set) Token: 0x06006B24 RID: 27428 RVA: 0x00032561 File Offset: 0x00030761
		public unsafe UnityEvent onLose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onLose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06006B25 RID: 27429 RVA: 0x001E21A8 File Offset: 0x001E03A8
		// (set) Token: 0x06006B26 RID: 27430 RVA: 0x00032580 File Offset: 0x00030780
		public unsafe UnityEvent onPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BlackjackInterface.NativeFieldInfoPtr_onPush), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400493F RID: 18751
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x04004940 RID: 18752
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04004941 RID: 18753
		private static readonly IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x04004942 RID: 18754
		private static readonly IntPtr NativeFieldInfoPtr_BetContainer;

		// Token: 0x04004943 RID: 18755
		private static readonly IntPtr NativeFieldInfoPtr_BetTitleLabel;

		// Token: 0x04004944 RID: 18756
		private static readonly IntPtr NativeFieldInfoPtr_BetSlider;

		// Token: 0x04004945 RID: 18757
		private static readonly IntPtr NativeFieldInfoPtr_BetAmount;

		// Token: 0x04004946 RID: 18758
		private static readonly IntPtr NativeFieldInfoPtr_ReadyButton;

		// Token: 0x04004947 RID: 18759
		private static readonly IntPtr NativeFieldInfoPtr_ReadyLabel;

		// Token: 0x04004948 RID: 18760
		private static readonly IntPtr NativeFieldInfoPtr_WaitingContainer;

		// Token: 0x04004949 RID: 18761
		private static readonly IntPtr NativeFieldInfoPtr_WaitingLabel;

		// Token: 0x0400494A RID: 18762
		private static readonly IntPtr NativeFieldInfoPtr_DealerScoreLabel;

		// Token: 0x0400494B RID: 18763
		private static readonly IntPtr NativeFieldInfoPtr_PlayerScoreLabel;

		// Token: 0x0400494C RID: 18764
		private static readonly IntPtr NativeFieldInfoPtr_HitButton;

		// Token: 0x0400494D RID: 18765
		private static readonly IntPtr NativeFieldInfoPtr_StandButton;

		// Token: 0x0400494E RID: 18766
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerAnimation;

		// Token: 0x0400494F RID: 18767
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerCanvasGroup;

		// Token: 0x04004950 RID: 18768
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeIn;

		// Token: 0x04004951 RID: 18769
		private static readonly IntPtr NativeFieldInfoPtr_InputContainerFadeOut;

		// Token: 0x04004952 RID: 18770
		private static readonly IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04004953 RID: 18771
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerAnimation;

		// Token: 0x04004954 RID: 18772
		private static readonly IntPtr NativeFieldInfoPtr_ScoresContainerCanvasGroup;

		// Token: 0x04004955 RID: 18773
		private static readonly IntPtr NativeFieldInfoPtr_PositiveOutcomeLabel;

		// Token: 0x04004956 RID: 18774
		private static readonly IntPtr NativeFieldInfoPtr_PayoutLabel;

		// Token: 0x04004957 RID: 18775
		private static readonly IntPtr NativeFieldInfoPtr_onBust;

		// Token: 0x04004958 RID: 18776
		private static readonly IntPtr NativeFieldInfoPtr_onBlackjack;

		// Token: 0x04004959 RID: 18777
		private static readonly IntPtr NativeFieldInfoPtr_onWin;

		// Token: 0x0400495A RID: 18778
		private static readonly IntPtr NativeFieldInfoPtr_onLose;

		// Token: 0x0400495B RID: 18779
		private static readonly IntPtr NativeFieldInfoPtr_onPush;

		// Token: 0x0400495C RID: 18780
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_BlackjackGameController_0;

		// Token: 0x0400495D RID: 18781
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_BlackjackGameController_0;

		// Token: 0x0400495E RID: 18782
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400495F RID: 18783
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004960 RID: 18784
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_BlackjackGameController_0;

		// Token: 0x04004961 RID: 18785
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004962 RID: 18786
		private static readonly IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x04004963 RID: 18787
		private static readonly IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x04004964 RID: 18788
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x04004965 RID: 18789
		private static readonly IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x04004966 RID: 18790
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerReadyForInput_Private_Void_0;

		// Token: 0x04004967 RID: 18791
		private static readonly IntPtr NativeMethodInfoPtr_ShowScores_Private_Void_0;

		// Token: 0x04004968 RID: 18792
		private static readonly IntPtr NativeMethodInfoPtr_HideScores_Private_Void_0;

		// Token: 0x04004969 RID: 18793
		private static readonly IntPtr NativeMethodInfoPtr_HitClicked_Private_Void_0;

		// Token: 0x0400496A RID: 18794
		private static readonly IntPtr NativeMethodInfoPtr_StandClicked_Private_Void_0;

		// Token: 0x0400496B RID: 18795
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x0400496C RID: 18796
		private static readonly IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x0400496D RID: 18797
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerBust_Private_Void_0;

		// Token: 0x0400496E RID: 18798
		private static readonly IntPtr NativeMethodInfoPtr_OnLocalPlayerRoundCompleted_Private_Void_EPayoutType_0;

		// Token: 0x0400496F RID: 18799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
