using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Casino.UI
{
	// Token: 0x020004CE RID: 1230
	public class RTBInterface : Singleton<RTBInterface>
	{
		// Token: 0x06006B34 RID: 27444 RVA: 0x001E2454 File Offset: 0x001E0654
		// Note: this type is marked as 'beforefieldinit'.
		static RTBInterface()
		{
			Il2CppClassPointerStore<RTBInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino.UI", "RTBInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr);
			RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<CurrentGame>k__BackingField");
			RTBInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "Canvas");
			RTBInterface.NativeFieldInfoPtr_PlayerDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "PlayerDisplay");
			RTBInterface.NativeFieldInfoPtr_StatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "StatusLabel");
			RTBInterface.NativeFieldInfoPtr_BetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetContainer");
			RTBInterface.NativeFieldInfoPtr_BetTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetTitleLabel");
			RTBInterface.NativeFieldInfoPtr_BetSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetSlider");
			RTBInterface.NativeFieldInfoPtr_BetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "BetAmount");
			RTBInterface.NativeFieldInfoPtr_ReadyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ReadyButton");
			RTBInterface.NativeFieldInfoPtr_ReadyLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ReadyLabel");
			RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "WinningsMultiplierLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainer");
			RTBInterface.NativeFieldInfoPtr_QuestionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionLabel");
			RTBInterface.NativeFieldInfoPtr_TimerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "TimerSlider");
			RTBInterface.NativeFieldInfoPtr_AnswerButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerButtons");
			RTBInterface.NativeFieldInfoPtr_AnswerLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "AnswerLabels");
			RTBInterface.NativeFieldInfoPtr_ForfeitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitButton");
			RTBInterface.NativeFieldInfoPtr_ForfeitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "ForfeitLabel");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerAnimation");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeIn");
			RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionContainerFadeOut");
			RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "QuestionCanvasGroup");
			RTBInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "SelectionIndicator");
			RTBInterface.NativeFieldInfoPtr_onCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onCorrect");
			RTBInterface.NativeFieldInfoPtr_onFinalCorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onFinalCorrect");
			RTBInterface.NativeFieldInfoPtr_onIncorrect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "onIncorrect");
			RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677015);
			RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677016);
			RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677017);
			RTBInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677018);
			RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677019);
			RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677020);
			RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677021);
			RTBInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677022);
			RTBInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677023);
			RTBInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677024);
			RTBInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677025);
			RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677026);
			RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677027);
			RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677028);
			RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677029);
			RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677030);
			RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677031);
			RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677032);
			RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677033);
			RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677034);
			RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, 100677035);
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x001E2830 File Offset: 0x001E0A30
		// (set) Token: 0x06006B36 RID: 27446 RVA: 0x001E2870 File Offset: 0x001E0A70
		public unsafe RTBGameController CurrentGame
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x001E28B4 File Offset: 0x001E0AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216756, XrefRangeEnd = 216798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RTBInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x001E28F0 File Offset: 0x001E0AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216798, XrefRangeEnd = 216817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x001E2924 File Offset: 0x001E0B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216827, RefRangeEnd = 216828, XrefRangeStart = 216817, XrefRangeEnd = 216827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetStatusText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetStatusText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x001E295C File Offset: 0x001E0B5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216917, RefRangeEnd = 216918, XrefRangeStart = 216828, XrefRangeEnd = 216917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(RTBGameController game)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x001E29A0 File Offset: 0x001E0BA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217007, RefRangeEnd = 217008, XrefRangeStart = 216918, XrefRangeEnd = 217007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x001E29D4 File Offset: 0x001E0BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217008, XrefRangeEnd = 217012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BetSliderChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref newValue;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B3D RID: 27453 RVA: 0x001E2A14 File Offset: 0x001E0C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217012, XrefRangeEnd = 217014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBetFromSliderValue(float sliderVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref sliderVal;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x001E2A60 File Offset: 0x001E0C60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217019, RefRangeEnd = 217022, XrefRangeStart = 217014, XrefRangeEnd = 217019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayedBet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x001E2A94 File Offset: 0x001E0C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217022, XrefRangeEnd = 217040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshReadyButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x001E2AC8 File Offset: 0x001E0CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217040, XrefRangeEnd = 217062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionReady(string question, Il2CppStringArray answers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(question);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(answers);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B41 RID: 27457 RVA: 0x001E2B1C File Offset: 0x001E0D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217062, XrefRangeEnd = 217071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnswerButtonClicked(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B42 RID: 27458 RVA: 0x001E2B5C File Offset: 0x001E0D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217071, XrefRangeEnd = 217082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForfeitClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ForfeitClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x001E2B90 File Offset: 0x001E0D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217082, XrefRangeEnd = 217086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuestionDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_QuestionDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B44 RID: 27460 RVA: 0x001E2BC4 File Offset: 0x001E0DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217086, XrefRangeEnd = 217090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerExitRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B45 RID: 27461 RVA: 0x001E2BF8 File Offset: 0x001E0DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217090, XrefRangeEnd = 217096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Correct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Correct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B46 RID: 27462 RVA: 0x001E2C2C File Offset: 0x001E0E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217096, XrefRangeEnd = 217097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incorrect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Incorrect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x001E2C60 File Offset: 0x001E0E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217097, XrefRangeEnd = 217108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadyButtonClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x001E2C94 File Offset: 0x001E0E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217108, XrefRangeEnd = 217111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RTBInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x001E2CD0 File Offset: 0x001E0ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217111, XrefRangeEnd = 217116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00032605 File Offset: 0x00030805
		public RTBInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x001E2D10 File Offset: 0x001E0F10
		// (set) Token: 0x06006B4C RID: 27468 RVA: 0x0003260E File Offset: 0x0003080E
		public unsafe RTBGameController _CurrentGame_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBGameController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr__CurrentGame_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x001E2D40 File Offset: 0x001E0F40
		// (set) Token: 0x06006B4E RID: 27470 RVA: 0x0003262D File Offset: 0x0003082D
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06006B4F RID: 27471 RVA: 0x001E2D70 File Offset: 0x001E0F70
		// (set) Token: 0x06006B50 RID: 27472 RVA: 0x0003264C File Offset: 0x0003084C
		public unsafe CasinoGamePlayerDisplay PlayerDisplay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayerDisplay>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_PlayerDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06006B51 RID: 27473 RVA: 0x001E2DA0 File Offset: 0x001E0FA0
		// (set) Token: 0x06006B52 RID: 27474 RVA: 0x0003266B File Offset: 0x0003086B
		public unsafe TextMeshProUGUI StatusLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_StatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06006B53 RID: 27475 RVA: 0x001E2DD0 File Offset: 0x001E0FD0
		// (set) Token: 0x06006B54 RID: 27476 RVA: 0x0003268A File Offset: 0x0003088A
		public unsafe RectTransform BetContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06006B55 RID: 27477 RVA: 0x001E2E00 File Offset: 0x001E1000
		// (set) Token: 0x06006B56 RID: 27478 RVA: 0x000326A9 File Offset: 0x000308A9
		public unsafe TextMeshProUGUI BetTitleLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetTitleLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06006B57 RID: 27479 RVA: 0x001E2E30 File Offset: 0x001E1030
		// (set) Token: 0x06006B58 RID: 27480 RVA: 0x000326C8 File Offset: 0x000308C8
		public unsafe Slider BetSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06006B59 RID: 27481 RVA: 0x001E2E60 File Offset: 0x001E1060
		// (set) Token: 0x06006B5A RID: 27482 RVA: 0x000326E7 File Offset: 0x000308E7
		public unsafe TextMeshProUGUI BetAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetAmount);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_BetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x001E2E90 File Offset: 0x001E1090
		// (set) Token: 0x06006B5C RID: 27484 RVA: 0x00032706 File Offset: 0x00030906
		public unsafe Button ReadyButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06006B5D RID: 27485 RVA: 0x001E2EC0 File Offset: 0x001E10C0
		// (set) Token: 0x06006B5E RID: 27486 RVA: 0x00032725 File Offset: 0x00030925
		public unsafe TextMeshProUGUI ReadyLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ReadyLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06006B5F RID: 27487 RVA: 0x001E2EF0 File Offset: 0x001E10F0
		// (set) Token: 0x06006B60 RID: 27488 RVA: 0x00032744 File Offset: 0x00030944
		public unsafe TextMeshProUGUI WinningsMultiplierLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_WinningsMultiplierLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x001E2F20 File Offset: 0x001E1120
		// (set) Token: 0x06006B62 RID: 27490 RVA: 0x00032763 File Offset: 0x00030963
		public unsafe RectTransform QuestionContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x06006B63 RID: 27491 RVA: 0x001E2F50 File Offset: 0x001E1150
		// (set) Token: 0x06006B64 RID: 27492 RVA: 0x00032782 File Offset: 0x00030982
		public unsafe TextMeshProUGUI QuestionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x001E2F80 File Offset: 0x001E1180
		// (set) Token: 0x06006B66 RID: 27494 RVA: 0x000327A1 File Offset: 0x000309A1
		public unsafe Slider TimerSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_TimerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x06006B67 RID: 27495 RVA: 0x001E2FB0 File Offset: 0x001E11B0
		// (set) Token: 0x06006B68 RID: 27496 RVA: 0x000327C0 File Offset: 0x000309C0
		public unsafe Il2CppReferenceArray<Button> AnswerButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x001E2FE0 File Offset: 0x001E11E0
		// (set) Token: 0x06006B6A RID: 27498 RVA: 0x000327DF File Offset: 0x000309DF
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> AnswerLabels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_AnswerLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x001E3010 File Offset: 0x001E1210
		// (set) Token: 0x06006B6C RID: 27500 RVA: 0x000327FE File Offset: 0x000309FE
		public unsafe Button ForfeitButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x001E3040 File Offset: 0x001E1240
		// (set) Token: 0x06006B6E RID: 27502 RVA: 0x0003281D File Offset: 0x00030A1D
		public unsafe TextMeshProUGUI ForfeitLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_ForfeitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x001E3070 File Offset: 0x001E1270
		// (set) Token: 0x06006B70 RID: 27504 RVA: 0x0003283C File Offset: 0x00030A3C
		public unsafe Animation QuestionContainerAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x001E30A0 File Offset: 0x001E12A0
		// (set) Token: 0x06006B72 RID: 27506 RVA: 0x0003285B File Offset: 0x00030A5B
		public unsafe AnimationClip QuestionContainerFadeIn
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeIn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x06006B73 RID: 27507 RVA: 0x001E30D0 File Offset: 0x001E12D0
		// (set) Token: 0x06006B74 RID: 27508 RVA: 0x0003287A File Offset: 0x00030A7A
		public unsafe AnimationClip QuestionContainerFadeOut
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionContainerFadeOut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x06006B75 RID: 27509 RVA: 0x001E3100 File Offset: 0x001E1300
		// (set) Token: 0x06006B76 RID: 27510 RVA: 0x00032899 File Offset: 0x00030A99
		public unsafe CanvasGroup QuestionCanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_QuestionCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x06006B77 RID: 27511 RVA: 0x001E3130 File Offset: 0x001E1330
		// (set) Token: 0x06006B78 RID: 27512 RVA: 0x000328B8 File Offset: 0x00030AB8
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06006B79 RID: 27513 RVA: 0x001E3160 File Offset: 0x001E1360
		// (set) Token: 0x06006B7A RID: 27514 RVA: 0x000328D7 File Offset: 0x00030AD7
		public unsafe UnityEvent onCorrect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06006B7B RID: 27515 RVA: 0x001E3190 File Offset: 0x001E1390
		// (set) Token: 0x06006B7C RID: 27516 RVA: 0x000328F6 File Offset: 0x00030AF6
		public unsafe UnityEvent onFinalCorrect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onFinalCorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06006B7D RID: 27517 RVA: 0x001E31C0 File Offset: 0x001E13C0
		// (set) Token: 0x06006B7E RID: 27518 RVA: 0x00032915 File Offset: 0x00030B15
		public unsafe UnityEvent onIncorrect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.NativeFieldInfoPtr_onIncorrect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004978 RID: 18808
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentGame_k__BackingField;

		// Token: 0x04004979 RID: 18809
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400497A RID: 18810
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDisplay;

		// Token: 0x0400497B RID: 18811
		private static readonly System.IntPtr NativeFieldInfoPtr_StatusLabel;

		// Token: 0x0400497C RID: 18812
		private static readonly System.IntPtr NativeFieldInfoPtr_BetContainer;

		// Token: 0x0400497D RID: 18813
		private static readonly System.IntPtr NativeFieldInfoPtr_BetTitleLabel;

		// Token: 0x0400497E RID: 18814
		private static readonly System.IntPtr NativeFieldInfoPtr_BetSlider;

		// Token: 0x0400497F RID: 18815
		private static readonly System.IntPtr NativeFieldInfoPtr_BetAmount;

		// Token: 0x04004980 RID: 18816
		private static readonly System.IntPtr NativeFieldInfoPtr_ReadyButton;

		// Token: 0x04004981 RID: 18817
		private static readonly System.IntPtr NativeFieldInfoPtr_ReadyLabel;

		// Token: 0x04004982 RID: 18818
		private static readonly System.IntPtr NativeFieldInfoPtr_WinningsMultiplierLabel;

		// Token: 0x04004983 RID: 18819
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionContainer;

		// Token: 0x04004984 RID: 18820
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionLabel;

		// Token: 0x04004985 RID: 18821
		private static readonly System.IntPtr NativeFieldInfoPtr_TimerSlider;

		// Token: 0x04004986 RID: 18822
		private static readonly System.IntPtr NativeFieldInfoPtr_AnswerButtons;

		// Token: 0x04004987 RID: 18823
		private static readonly System.IntPtr NativeFieldInfoPtr_AnswerLabels;

		// Token: 0x04004988 RID: 18824
		private static readonly System.IntPtr NativeFieldInfoPtr_ForfeitButton;

		// Token: 0x04004989 RID: 18825
		private static readonly System.IntPtr NativeFieldInfoPtr_ForfeitLabel;

		// Token: 0x0400498A RID: 18826
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionContainerAnimation;

		// Token: 0x0400498B RID: 18827
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionContainerFadeIn;

		// Token: 0x0400498C RID: 18828
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionContainerFadeOut;

		// Token: 0x0400498D RID: 18829
		private static readonly System.IntPtr NativeFieldInfoPtr_QuestionCanvasGroup;

		// Token: 0x0400498E RID: 18830
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x0400498F RID: 18831
		private static readonly System.IntPtr NativeFieldInfoPtr_onCorrect;

		// Token: 0x04004990 RID: 18832
		private static readonly System.IntPtr NativeFieldInfoPtr_onFinalCorrect;

		// Token: 0x04004991 RID: 18833
		private static readonly System.IntPtr NativeFieldInfoPtr_onIncorrect;

		// Token: 0x04004992 RID: 18834
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentGame_Public_get_RTBGameController_0;

		// Token: 0x04004993 RID: 18835
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentGame_Private_set_Void_RTBGameController_0;

		// Token: 0x04004994 RID: 18836
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004995 RID: 18837
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004996 RID: 18838
		private static readonly System.IntPtr NativeMethodInfoPtr_GetStatusText_Private_String_0;

		// Token: 0x04004997 RID: 18839
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_RTBGameController_0;

		// Token: 0x04004998 RID: 18840
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004999 RID: 18841
		private static readonly System.IntPtr NativeMethodInfoPtr_BetSliderChanged_Private_Void_Single_0;

		// Token: 0x0400499A RID: 18842
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBetFromSliderValue_Private_Single_Single_0;

		// Token: 0x0400499B RID: 18843
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshDisplayedBet_Private_Void_0;

		// Token: 0x0400499C RID: 18844
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshReadyButton_Private_Void_0;

		// Token: 0x0400499D RID: 18845
		private static readonly System.IntPtr NativeMethodInfoPtr_QuestionReady_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x0400499E RID: 18846
		private static readonly System.IntPtr NativeMethodInfoPtr_AnswerButtonClicked_Private_Void_Int32_0;

		// Token: 0x0400499F RID: 18847
		private static readonly System.IntPtr NativeMethodInfoPtr_ForfeitClicked_Private_Void_0;

		// Token: 0x040049A0 RID: 18848
		private static readonly System.IntPtr NativeMethodInfoPtr_QuestionDone_Private_Void_0;

		// Token: 0x040049A1 RID: 18849
		private static readonly System.IntPtr NativeMethodInfoPtr_LocalPlayerExitRound_Private_Void_0;

		// Token: 0x040049A2 RID: 18850
		private static readonly System.IntPtr NativeMethodInfoPtr_Correct_Private_Void_0;

		// Token: 0x040049A3 RID: 18851
		private static readonly System.IntPtr NativeMethodInfoPtr_Incorrect_Private_Void_0;

		// Token: 0x040049A4 RID: 18852
		private static readonly System.IntPtr NativeMethodInfoPtr_ReadyButtonClicked_Private_Void_0;

		// Token: 0x040049A5 RID: 18853
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040049A6 RID: 18854
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000A9C RID: 2716
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<<QuestionReady>g__Routine|38_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D555 RID: 54613 RVA: 0x0033500C File Offset: 0x0033320C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique()
			{
				Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<<QuestionReady>g__Routine|38_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>1__state");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>2__current");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, "<>4__this");
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100677036);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100677037);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100677038);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100677039);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100677040);
				RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr, 100677041);
			}

			// Token: 0x0600D556 RID: 54614 RVA: 0x003350EC File Offset: 0x003332EC
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D557 RID: 54615 RVA: 0x00335134 File Offset: 0x00333334
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D558 RID: 54616 RVA: 0x00335168 File Offset: 0x00333368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216733, XrefRangeEnd = 216742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170041F6 RID: 16886
			// (get) Token: 0x0600D559 RID: 54617 RVA: 0x003351A4 File Offset: 0x003333A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D55A RID: 54618 RVA: 0x003351E4 File Offset: 0x003333E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216742, XrefRangeEnd = 216747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170041F7 RID: 16887
			// (get) Token: 0x0600D55B RID: 54619 RVA: 0x00335218 File Offset: 0x00333418
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D55C RID: 54620 RVA: 0x000677F0 File Offset: 0x000659F0
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F3 RID: 16883
			// (get) Token: 0x0600D55D RID: 54621 RVA: 0x00335258 File Offset: 0x00333458
			// (set) Token: 0x0600D55E RID: 54622 RVA: 0x000677F9 File Offset: 0x000659F9
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041F4 RID: 16884
			// (get) Token: 0x0600D55F RID: 54623 RVA: 0x00335280 File Offset: 0x00333480
			// (set) Token: 0x0600D560 RID: 54624 RVA: 0x00067814 File Offset: 0x00065A14
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041F5 RID: 16885
			// (get) Token: 0x0600D561 RID: 54625 RVA: 0x003352B0 File Offset: 0x003334B0
			// (set) Token: 0x0600D562 RID: 54626 RVA: 0x00067833 File Offset: 0x00065A33
			public unsafe RTBInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObRTObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009007 RID: 36871
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009008 RID: 36872
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009009 RID: 36873
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400900A RID: 36874
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400900B RID: 36875
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400900C RID: 36876
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400900D RID: 36877
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400900E RID: 36878
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400900F RID: 36879
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A9D RID: 2717
		[ObfuscatedName("ScheduleOne.Casino.UI.RTBInterface+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D563 RID: 54627 RVA: 0x003352E0 File Offset: 0x003334E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RTBInterface>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr);
				RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, "index");
				RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, "<>4__this");
				RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, 100677042);
				RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr, 100677043);
			}

			// Token: 0x0600D564 RID: 54628 RVA: 0x0033535C File Offset: 0x0033355C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTBInterface.__c__DisplayClass29_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D565 RID: 54629 RVA: 0x00335398 File Offset: 0x00333598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216747, XrefRangeEnd = 216756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Awake_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTBInterface.__c__DisplayClass29_0.NativeMethodInfoPtr__Awake_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D566 RID: 54630 RVA: 0x00067852 File Offset: 0x00065A52
			public __c__DisplayClass29_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F8 RID: 16888
			// (get) Token: 0x0600D567 RID: 54631 RVA: 0x003353CC File Offset: 0x003335CC
			// (set) Token: 0x0600D568 RID: 54632 RVA: 0x0006785B File Offset: 0x00065A5B
			public unsafe int index
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170041F9 RID: 16889
			// (get) Token: 0x0600D569 RID: 54633 RVA: 0x003353F4 File Offset: 0x003335F4
			// (set) Token: 0x0600D56A RID: 54634 RVA: 0x00067876 File Offset: 0x00065A76
			public unsafe RTBInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTBInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RTBInterface.__c__DisplayClass29_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009010 RID: 36880
			private static readonly System.IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04009011 RID: 36881
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009012 RID: 36882
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009013 RID: 36883
			private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__0_Internal_Void_0;
		}
	}
}
