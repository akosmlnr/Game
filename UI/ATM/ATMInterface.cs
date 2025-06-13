using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Money;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.ATM
{
	// Token: 0x0200072B RID: 1835
	public class ATMInterface : MonoBehaviour
	{
		// Token: 0x0600A38E RID: 41870 RVA: 0x002948A0 File Offset: 0x00292AA0
		// Note: this type is marked as 'beforefieldinit'.
		static ATMInterface()
		{
			Il2CppClassPointerStore<ATMInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.ATM", "ATMInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr);
			ATMInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "canvas");
			ATMInterface.NativeFieldInfoPtr_atm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "atm");
			ATMInterface.NativeFieldInfoPtr_CompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "CompleteSound");
			ATMInterface.NativeFieldInfoPtr_menuScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menuScreen");
			ATMInterface.NativeFieldInfoPtr_menu_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_TitleText");
			ATMInterface.NativeFieldInfoPtr_menu_DepositButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_DepositButton");
			ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_WithdrawButton");
			ATMInterface.NativeFieldInfoPtr_depositLimitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitText");
			ATMInterface.NativeFieldInfoPtr_onlineBalanceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "onlineBalanceText");
			ATMInterface.NativeFieldInfoPtr_cleanCashText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "cleanCashText");
			ATMInterface.NativeFieldInfoPtr_depositLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitContainer");
			ATMInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorScreen");
			ATMInterface.NativeFieldInfoPtr_amountSelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorTitle");
			ATMInterface.NativeFieldInfoPtr_amountButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountButtons");
			ATMInterface.NativeFieldInfoPtr_amountLabelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountLabelText");
			ATMInterface.NativeFieldInfoPtr_amountBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountBackground");
			ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedButtonIndicator");
			ATMInterface.NativeFieldInfoPtr_confirmAmountButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmAmountButton");
			ATMInterface.NativeFieldInfoPtr_confirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmButtonText");
			ATMInterface.NativeFieldInfoPtr_processingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreen");
			ATMInterface.NativeFieldInfoPtr_processingScreenIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreenIndicator");
			ATMInterface.NativeFieldInfoPtr_successScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreen");
			ATMInterface.NativeFieldInfoPtr_successScreenSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreenSubtitle");
			ATMInterface.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "doneButton");
			ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<isOpen>k__BackingField");
			ATMInterface.NativeFieldInfoPtr_activeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "activeScreen");
			ATMInterface.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amounts");
			ATMInterface.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositing");
			ATMInterface.NativeFieldInfoPtr_selectedAmountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmountIndex");
			ATMInterface.NativeFieldInfoPtr_selectedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmount");
			ATMInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683395);
			ATMInterface.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683396);
			ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683397);
			ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683398);
			ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683399);
			ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683400);
			ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683401);
			ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683402);
			ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683403);
			ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683404);
			ATMInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683405);
			ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683406);
			ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683407);
			ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683408);
			ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683409);
			ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683410);
			ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683411);
			ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683412);
			ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683413);
			ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683414);
			ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683415);
			ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683416);
			ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683417);
			ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683418);
			ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683419);
			ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683420);
			ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100683421);
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600A38F RID: 41871 RVA: 0x00294D44 File Offset: 0x00292F44
		// (set) Token: 0x0600A390 RID: 41872 RVA: 0x00294D80 File Offset: 0x00292F80
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600A391 RID: 41873 RVA: 0x00294DC0 File Offset: 0x00292FC0
		public unsafe float relevantBalance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 287466, RefRangeEnd = 287472, XrefRangeStart = 287459, XrefRangeEnd = 287466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17003252 RID: 12882
		// (get) Token: 0x0600A392 RID: 41874 RVA: 0x00294DFC File Offset: 0x00292FFC
		public unsafe static float remainingAllowedDeposit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287476, RefRangeEnd = 287479, XrefRangeStart = 287472, XrefRangeEnd = 287476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600A393 RID: 41875 RVA: 0x00294E2C File Offset: 0x0029302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287479, XrefRangeEnd = 287514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A394 RID: 41876 RVA: 0x00294E60 File Offset: 0x00293060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287514, XrefRangeEnd = 287534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A395 RID: 41877 RVA: 0x00294E94 File Offset: 0x00293094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287534, XrefRangeEnd = 287588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A396 RID: 41878 RVA: 0x00294ED0 File Offset: 0x002930D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287588, XrefRangeEnd = 287594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A397 RID: 41879 RVA: 0x00294F04 File Offset: 0x00293104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287594, XrefRangeEnd = 287678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x00294F40 File Offset: 0x00293140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287678, XrefRangeEnd = 287692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x00294F7C File Offset: 0x0029317C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287692, XrefRangeEnd = 287711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A39A RID: 41882 RVA: 0x00294FC8 File Offset: 0x002931C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287711, XrefRangeEnd = 287723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A39B RID: 41883 RVA: 0x00295018 File Offset: 0x00293218
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 287746, RefRangeEnd = 287752, XrefRangeStart = 287723, XrefRangeEnd = 287746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveScreen(RectTransform screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A39C RID: 41884 RVA: 0x0029505C File Offset: 0x0029325C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287762, RefRangeEnd = 287763, XrefRangeStart = 287752, XrefRangeEnd = 287762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A39D RID: 41885 RVA: 0x00295090 File Offset: 0x00293290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287763, XrefRangeEnd = 287767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepositButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A39E RID: 41886 RVA: 0x002950C4 File Offset: 0x002932C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287767, XrefRangeEnd = 287798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithdrawButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A39F RID: 41887 RVA: 0x002950F8 File Offset: 0x002932F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287798, XrefRangeEnd = 287799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A0 RID: 41888 RVA: 0x0029512C File Offset: 0x0029332C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287804, RefRangeEnd = 287806, XrefRangeStart = 287799, XrefRangeEnd = 287804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountSelected(int amountIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amountIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x0029516C File Offset: 0x0029336C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287824, RefRangeEnd = 287826, XrefRangeStart = 287806, XrefRangeEnd = 287824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x002951AC File Offset: 0x002933AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 287839, RefRangeEnd = 287841, XrefRangeStart = 287826, XrefRangeEnd = 287839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAmountFromIndex(int index, bool depositing)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref depositing;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x002951F8 File Offset: 0x002933F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 287878, RefRangeEnd = 287879, XrefRangeStart = 287841, XrefRangeEnd = 287878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvailableAmounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x0029522C File Offset: 0x0029342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287879, XrefRangeEnd = 287885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountConfirmed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A5 RID: 41893 RVA: 0x00295260 File Offset: 0x00293460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287885, XrefRangeEnd = 287886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A6 RID: 41894 RVA: 0x002952A0 File Offset: 0x002934A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287886, XrefRangeEnd = 287891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref depositing;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x002952FC File Offset: 0x002934FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 252561, RefRangeEnd = 252564, XrefRangeStart = 252561, XrefRangeEnd = 252564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x00295330 File Offset: 0x00293530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToMenuButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x00295364 File Offset: 0x00293564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287891, XrefRangeEnd = 287899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ATMInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x000503A2 File Offset: 0x0004E5A2
		public ATMInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003232 RID: 12850
		// (get) Token: 0x0600A3AB RID: 41899 RVA: 0x002953A0 File Offset: 0x002935A0
		// (set) Token: 0x0600A3AC RID: 41900 RVA: 0x000503AB File Offset: 0x0004E5AB
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A3AD RID: 41901 RVA: 0x002953D0 File Offset: 0x002935D0
		// (set) Token: 0x0600A3AE RID: 41902 RVA: 0x000503CA File Offset: 0x0004E5CA
		public unsafe ATM atm
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATM>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003234 RID: 12852
		// (get) Token: 0x0600A3AF RID: 41903 RVA: 0x00295400 File Offset: 0x00293600
		// (set) Token: 0x0600A3B0 RID: 41904 RVA: 0x000503E9 File Offset: 0x0004E5E9
		public unsafe AudioSourceController CompleteSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_CompleteSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_CompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003235 RID: 12853
		// (get) Token: 0x0600A3B1 RID: 41905 RVA: 0x00295430 File Offset: 0x00293630
		// (set) Token: 0x0600A3B2 RID: 41906 RVA: 0x00050408 File Offset: 0x0004E608
		public unsafe RectTransform menuScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003236 RID: 12854
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x00295460 File Offset: 0x00293660
		// (set) Token: 0x0600A3B4 RID: 41908 RVA: 0x00050427 File Offset: 0x0004E627
		public unsafe Text menu_TitleText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003237 RID: 12855
		// (get) Token: 0x0600A3B5 RID: 41909 RVA: 0x00295490 File Offset: 0x00293690
		// (set) Token: 0x0600A3B6 RID: 41910 RVA: 0x00050446 File Offset: 0x0004E646
		public unsafe Button menu_DepositButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003238 RID: 12856
		// (get) Token: 0x0600A3B7 RID: 41911 RVA: 0x002954C0 File Offset: 0x002936C0
		// (set) Token: 0x0600A3B8 RID: 41912 RVA: 0x00050465 File Offset: 0x0004E665
		public unsafe Button menu_WithdrawButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003239 RID: 12857
		// (get) Token: 0x0600A3B9 RID: 41913 RVA: 0x002954F0 File Offset: 0x002936F0
		// (set) Token: 0x0600A3BA RID: 41914 RVA: 0x00050484 File Offset: 0x0004E684
		public unsafe Text depositLimitText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323A RID: 12858
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x00295520 File Offset: 0x00293720
		// (set) Token: 0x0600A3BC RID: 41916 RVA: 0x000504A3 File Offset: 0x0004E6A3
		public unsafe Text onlineBalanceText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323B RID: 12859
		// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x00295550 File Offset: 0x00293750
		// (set) Token: 0x0600A3BE RID: 41918 RVA: 0x000504C2 File Offset: 0x0004E6C2
		public unsafe Text cleanCashText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323C RID: 12860
		// (get) Token: 0x0600A3BF RID: 41919 RVA: 0x00295580 File Offset: 0x00293780
		// (set) Token: 0x0600A3C0 RID: 41920 RVA: 0x000504E1 File Offset: 0x0004E6E1
		public unsafe RectTransform depositLimitContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323D RID: 12861
		// (get) Token: 0x0600A3C1 RID: 41921 RVA: 0x002955B0 File Offset: 0x002937B0
		// (set) Token: 0x0600A3C2 RID: 41922 RVA: 0x00050500 File Offset: 0x0004E700
		public unsafe RectTransform amountSelectorScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323E RID: 12862
		// (get) Token: 0x0600A3C3 RID: 41923 RVA: 0x002955E0 File Offset: 0x002937E0
		// (set) Token: 0x0600A3C4 RID: 41924 RVA: 0x0005051F File Offset: 0x0004E71F
		public unsafe Text amountSelectorTitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700323F RID: 12863
		// (get) Token: 0x0600A3C5 RID: 41925 RVA: 0x00295610 File Offset: 0x00293810
		// (set) Token: 0x0600A3C6 RID: 41926 RVA: 0x0005053E File Offset: 0x0004E73E
		public unsafe List<Button> amountButtons
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003240 RID: 12864
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x00295640 File Offset: 0x00293840
		// (set) Token: 0x0600A3C8 RID: 41928 RVA: 0x0005055D File Offset: 0x0004E75D
		public unsafe Text amountLabelText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003241 RID: 12865
		// (get) Token: 0x0600A3C9 RID: 41929 RVA: 0x00295670 File Offset: 0x00293870
		// (set) Token: 0x0600A3CA RID: 41930 RVA: 0x0005057C File Offset: 0x0004E77C
		public unsafe RectTransform amountBackground
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x002956A0 File Offset: 0x002938A0
		// (set) Token: 0x0600A3CC RID: 41932 RVA: 0x0005059B File Offset: 0x0004E79B
		public unsafe RectTransform selectedButtonIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x002956D0 File Offset: 0x002938D0
		// (set) Token: 0x0600A3CE RID: 41934 RVA: 0x000505BA File Offset: 0x0004E7BA
		public unsafe Button confirmAmountButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600A3CF RID: 41935 RVA: 0x00295700 File Offset: 0x00293900
		// (set) Token: 0x0600A3D0 RID: 41936 RVA: 0x000505D9 File Offset: 0x0004E7D9
		public unsafe Text confirmButtonText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600A3D1 RID: 41937 RVA: 0x00295730 File Offset: 0x00293930
		// (set) Token: 0x0600A3D2 RID: 41938 RVA: 0x000505F8 File Offset: 0x0004E7F8
		public unsafe RectTransform processingScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600A3D3 RID: 41939 RVA: 0x00295760 File Offset: 0x00293960
		// (set) Token: 0x0600A3D4 RID: 41940 RVA: 0x00050617 File Offset: 0x0004E817
		public unsafe RectTransform processingScreenIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x00295790 File Offset: 0x00293990
		// (set) Token: 0x0600A3D6 RID: 41942 RVA: 0x00050636 File Offset: 0x0004E836
		public unsafe RectTransform successScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A3D7 RID: 41943 RVA: 0x002957C0 File Offset: 0x002939C0
		// (set) Token: 0x0600A3D8 RID: 41944 RVA: 0x00050655 File Offset: 0x0004E855
		public unsafe Text successScreenSubtitle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A3D9 RID: 41945 RVA: 0x002957F0 File Offset: 0x002939F0
		// (set) Token: 0x0600A3DA RID: 41946 RVA: 0x00050674 File Offset: 0x0004E874
		public unsafe Button doneButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A3DB RID: 41947 RVA: 0x00295820 File Offset: 0x00293A20
		// (set) Token: 0x0600A3DC RID: 41948 RVA: 0x00050693 File Offset: 0x0004E893
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A3DD RID: 41949 RVA: 0x00295848 File Offset: 0x00293A48
		// (set) Token: 0x0600A3DE RID: 41950 RVA: 0x000506AE File Offset: 0x0004E8AE
		public unsafe RectTransform activeScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600A3DF RID: 41951 RVA: 0x00295878 File Offset: 0x00293A78
		// (set) Token: 0x0600A3E0 RID: 41952 RVA: 0x000506CD File Offset: 0x0004E8CD
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ATMInterface.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATMInterface.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x002958A0 File Offset: 0x00293AA0
		// (set) Token: 0x0600A3E2 RID: 41954 RVA: 0x000506DF File Offset: 0x0004E8DF
		public unsafe bool depositing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing)) = value;
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600A3E3 RID: 41955 RVA: 0x002958C8 File Offset: 0x00293AC8
		// (set) Token: 0x0600A3E4 RID: 41956 RVA: 0x000506FA File Offset: 0x0004E8FA
		public unsafe int selectedAmountIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex)) = value;
			}
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x002958F0 File Offset: 0x00293AF0
		// (set) Token: 0x0600A3E6 RID: 41958 RVA: 0x00050715 File Offset: 0x0004E915
		public unsafe float selectedAmount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount)) = value;
			}
		}

		// Token: 0x04006DA4 RID: 28068
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04006DA5 RID: 28069
		private static readonly System.IntPtr NativeFieldInfoPtr_atm;

		// Token: 0x04006DA6 RID: 28070
		private static readonly System.IntPtr NativeFieldInfoPtr_CompleteSound;

		// Token: 0x04006DA7 RID: 28071
		private static readonly System.IntPtr NativeFieldInfoPtr_menuScreen;

		// Token: 0x04006DA8 RID: 28072
		private static readonly System.IntPtr NativeFieldInfoPtr_menu_TitleText;

		// Token: 0x04006DA9 RID: 28073
		private static readonly System.IntPtr NativeFieldInfoPtr_menu_DepositButton;

		// Token: 0x04006DAA RID: 28074
		private static readonly System.IntPtr NativeFieldInfoPtr_menu_WithdrawButton;

		// Token: 0x04006DAB RID: 28075
		private static readonly System.IntPtr NativeFieldInfoPtr_depositLimitText;

		// Token: 0x04006DAC RID: 28076
		private static readonly System.IntPtr NativeFieldInfoPtr_onlineBalanceText;

		// Token: 0x04006DAD RID: 28077
		private static readonly System.IntPtr NativeFieldInfoPtr_cleanCashText;

		// Token: 0x04006DAE RID: 28078
		private static readonly System.IntPtr NativeFieldInfoPtr_depositLimitContainer;

		// Token: 0x04006DAF RID: 28079
		private static readonly System.IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x04006DB0 RID: 28080
		private static readonly System.IntPtr NativeFieldInfoPtr_amountSelectorTitle;

		// Token: 0x04006DB1 RID: 28081
		private static readonly System.IntPtr NativeFieldInfoPtr_amountButtons;

		// Token: 0x04006DB2 RID: 28082
		private static readonly System.IntPtr NativeFieldInfoPtr_amountLabelText;

		// Token: 0x04006DB3 RID: 28083
		private static readonly System.IntPtr NativeFieldInfoPtr_amountBackground;

		// Token: 0x04006DB4 RID: 28084
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedButtonIndicator;

		// Token: 0x04006DB5 RID: 28085
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmAmountButton;

		// Token: 0x04006DB6 RID: 28086
		private static readonly System.IntPtr NativeFieldInfoPtr_confirmButtonText;

		// Token: 0x04006DB7 RID: 28087
		private static readonly System.IntPtr NativeFieldInfoPtr_processingScreen;

		// Token: 0x04006DB8 RID: 28088
		private static readonly System.IntPtr NativeFieldInfoPtr_processingScreenIndicator;

		// Token: 0x04006DB9 RID: 28089
		private static readonly System.IntPtr NativeFieldInfoPtr_successScreen;

		// Token: 0x04006DBA RID: 28090
		private static readonly System.IntPtr NativeFieldInfoPtr_successScreenSubtitle;

		// Token: 0x04006DBB RID: 28091
		private static readonly System.IntPtr NativeFieldInfoPtr_doneButton;

		// Token: 0x04006DBC RID: 28092
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04006DBD RID: 28093
		private static readonly System.IntPtr NativeFieldInfoPtr_activeScreen;

		// Token: 0x04006DBE RID: 28094
		private static readonly System.IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x04006DBF RID: 28095
		private static readonly System.IntPtr NativeFieldInfoPtr_depositing;

		// Token: 0x04006DC0 RID: 28096
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedAmountIndex;

		// Token: 0x04006DC1 RID: 28097
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedAmount;

		// Token: 0x04006DC2 RID: 28098
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006DC3 RID: 28099
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006DC4 RID: 28100
		private static readonly System.IntPtr NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0;

		// Token: 0x04006DC5 RID: 28101
		private static readonly System.IntPtr NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0;

		// Token: 0x04006DC6 RID: 28102
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006DC7 RID: 28103
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006DC8 RID: 28104
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006DC9 RID: 28105
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x04006DCA RID: 28106
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04006DCB RID: 28107
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006DCC RID: 28108
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006DCD RID: 28109
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006DCE RID: 28110
		private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0;

		// Token: 0x04006DCF RID: 28111
		private static readonly System.IntPtr NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0;

		// Token: 0x04006DD0 RID: 28112
		private static readonly System.IntPtr NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0;

		// Token: 0x04006DD1 RID: 28113
		private static readonly System.IntPtr NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0;

		// Token: 0x04006DD2 RID: 28114
		private static readonly System.IntPtr NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0;

		// Token: 0x04006DD3 RID: 28115
		private static readonly System.IntPtr NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0;

		// Token: 0x04006DD4 RID: 28116
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0;

		// Token: 0x04006DD5 RID: 28117
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0;

		// Token: 0x04006DD6 RID: 28118
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0;

		// Token: 0x04006DD7 RID: 28119
		private static readonly System.IntPtr NativeMethodInfoPtr_AmountConfirmed_Public_Void_0;

		// Token: 0x04006DD8 RID: 28120
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x04006DD9 RID: 28121
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0;

		// Token: 0x04006DDA RID: 28122
		private static readonly System.IntPtr NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0;

		// Token: 0x04006DDB RID: 28123
		private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0;

		// Token: 0x04006DDC RID: 28124
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C01 RID: 3073
		[ObfuscatedName("ScheduleOne.UI.ATM.ATMInterface+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E244 RID: 57924 RVA: 0x003599A8 File Offset: 0x00357BA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr);
				ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, "fuckYou");
				ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, 100683423);
				ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr, 100683424);
			}

			// Token: 0x0600E245 RID: 57925 RVA: 0x00359A24 File Offset: 0x00357C24
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass39_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E246 RID: 57926 RVA: 0x00359A60 File Offset: 0x00357C60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287439, XrefRangeEnd = 287441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass39_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E247 RID: 57927 RVA: 0x0006DF0E File Offset: 0x0006C10E
			public __c__DisplayClass39_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045CF RID: 17871
			// (get) Token: 0x0600E248 RID: 57928 RVA: 0x00359A94 File Offset: 0x00357C94
			// (set) Token: 0x0600E249 RID: 57929 RVA: 0x0006DF17 File Offset: 0x0006C117
			public unsafe int fuckYou
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr_fuckYou)) = value;
				}
			}

			// Token: 0x170045D0 RID: 17872
			// (get) Token: 0x0600E24A RID: 57930 RVA: 0x00359ABC File Offset: 0x00357CBC
			// (set) Token: 0x0600E24B RID: 57931 RVA: 0x0006DF32 File Offset: 0x0006C132
			public unsafe ATMInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097AD RID: 38829
			private static readonly System.IntPtr NativeFieldInfoPtr_fuckYou;

			// Token: 0x040097AE RID: 38830
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097AF RID: 38831
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097B0 RID: 38832
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000C02 RID: 3074
		[ObfuscatedName("ScheduleOne.UI.ATM.ATMInterface+<ProcessTransaction>d__56")]
		public sealed class _ProcessTransaction_d__56 : Il2CppSystem.Object
		{
			// Token: 0x0600E24C RID: 57932 RVA: 0x00359AEC File Offset: 0x00357CEC
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessTransaction_d__56()
			{
				Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<ProcessTransaction>d__56");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr);
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>1__state");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>2__current");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "<>4__this");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "depositing");
				ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, "amount");
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683425);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683426);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683427);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683428);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683429);
				ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr, 100683430);
			}

			// Token: 0x0600E24D RID: 57933 RVA: 0x00359BF4 File Offset: 0x00357DF4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessTransaction_d__56(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__56>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E24E RID: 57934 RVA: 0x00359C3C File Offset: 0x00357E3C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E24F RID: 57935 RVA: 0x00359C70 File Offset: 0x00357E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287441, XrefRangeEnd = 287454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170045D6 RID: 17878
			// (get) Token: 0x0600E250 RID: 57936 RVA: 0x00359CAC File Offset: 0x00357EAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E251 RID: 57937 RVA: 0x00359CEC File Offset: 0x00357EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287454, XrefRangeEnd = 287459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170045D7 RID: 17879
			// (get) Token: 0x0600E252 RID: 57938 RVA: 0x00359D20 File Offset: 0x00357F20
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__56.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E253 RID: 57939 RVA: 0x0006DF51 File Offset: 0x0006C151
			public _ProcessTransaction_d__56(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D1 RID: 17873
			// (get) Token: 0x0600E254 RID: 57940 RVA: 0x00359D60 File Offset: 0x00357F60
			// (set) Token: 0x0600E255 RID: 57941 RVA: 0x0006DF5A File Offset: 0x0006C15A
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045D2 RID: 17874
			// (get) Token: 0x0600E256 RID: 57942 RVA: 0x00359D88 File Offset: 0x00357F88
			// (set) Token: 0x0600E257 RID: 57943 RVA: 0x0006DF75 File Offset: 0x0006C175
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D3 RID: 17875
			// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00359DB8 File Offset: 0x00357FB8
			// (set) Token: 0x0600E259 RID: 57945 RVA: 0x0006DF94 File Offset: 0x0006C194
			public unsafe ATMInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D4 RID: 17876
			// (get) Token: 0x0600E25A RID: 57946 RVA: 0x00359DE8 File Offset: 0x00357FE8
			// (set) Token: 0x0600E25B RID: 57947 RVA: 0x0006DFB3 File Offset: 0x0006C1B3
			public unsafe bool depositing
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_depositing)) = value;
				}
			}

			// Token: 0x170045D5 RID: 17877
			// (get) Token: 0x0600E25C RID: 57948 RVA: 0x00359E10 File Offset: 0x00358010
			// (set) Token: 0x0600E25D RID: 57949 RVA: 0x0006DFCE File Offset: 0x0006C1CE
			public unsafe float amount
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__56.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x040097B1 RID: 38833
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040097B2 RID: 38834
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040097B3 RID: 38835
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097B4 RID: 38836
			private static readonly System.IntPtr NativeFieldInfoPtr_depositing;

			// Token: 0x040097B5 RID: 38837
			private static readonly System.IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x040097B6 RID: 38838
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040097B7 RID: 38839
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097B8 RID: 38840
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040097B9 RID: 38841
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040097BA RID: 38842
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097BB RID: 38843
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
