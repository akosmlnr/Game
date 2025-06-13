using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ObjectScripts.Cash;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066C RID: 1644
	public class LaunderingInterface : MonoBehaviour
	{
		// Token: 0x0600907D RID: 36989 RVA: 0x0025B94C File Offset: 0x00259B4C
		// Note: this type is marked as 'beforefieldinit'.
		static LaunderingInterface()
		{
			Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "LaunderingInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr);
			LaunderingInterface.NativeFieldInfoPtr_fovOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "fovOverride");
			LaunderingInterface.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "lerpTime");
			LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "minLaunderAmount");
			LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<business>k__BackingField");
			LaunderingInterface.NativeFieldInfoPtr_cameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "cameraPosition");
			LaunderingInterface.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "intObj");
			LaunderingInterface.NativeFieldInfoPtr_launderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderButton");
			LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSelectorScreen");
			LaunderingInterface.NativeFieldInfoPtr_amountSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountSlider");
			LaunderingInterface.NativeFieldInfoPtr_amountInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "amountInputField");
			LaunderingInterface.NativeFieldInfoPtr_notchContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notchContainer");
			LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "currentTotalAmountLabel");
			LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "launderCapacityLabel");
			LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "insufficientCashLabel");
			LaunderingInterface.NativeFieldInfoPtr_entryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryContainer");
			LaunderingInterface.NativeFieldInfoPtr_noEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "noEntries");
			LaunderingInterface.NativeFieldInfoPtr_CashStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "CashStacks");
			LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "timelineNotchPrefab");
			LaunderingInterface.NativeFieldInfoPtr_entryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "entryPrefab");
			LaunderingInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "canvas");
			LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "selectedAmountToLaunder");
			LaunderingInterface.NativeFieldInfoPtr_operationToNotch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToNotch");
			LaunderingInterface.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "notches");
			LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "ignoreSliderChange");
			LaunderingInterface.NativeFieldInfoPtr_operationToEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "operationToEntry");
			LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681333);
			LaunderingInterface.NativeMethodInfoPtr_get_business_Public_get_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681334);
			LaunderingInterface.NativeMethodInfoPtr_set_business_Private_set_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681335);
			LaunderingInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681336);
			LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681337);
			LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681338);
			LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681339);
			LaunderingInterface.NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681340);
			LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681341);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681342);
			LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681343);
			LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681344);
			LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681345);
			LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681346);
			LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681347);
			LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681348);
			LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681349);
			LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681350);
			LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681351);
			LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681352);
			LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681353);
			LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681354);
			LaunderingInterface.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681355);
			LaunderingInterface.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681356);
			LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681357);
			LaunderingInterface.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681358);
			LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, 100681359);
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0600907E RID: 36990 RVA: 0x0025BD8C File Offset: 0x00259F8C
		public unsafe int maxLaunderAmount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 262614, RefRangeEnd = 262618, XrefRangeStart = 262608, XrefRangeEnd = 262614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600907F RID: 36991 RVA: 0x0025BDC8 File Offset: 0x00259FC8
		// (set) Token: 0x06009080 RID: 36992 RVA: 0x0025BE08 File Offset: 0x0025A008
		public unsafe Business business
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_business_Public_get_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_set_business_Private_set_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06009081 RID: 36993 RVA: 0x0025BE4C File Offset: 0x0025A04C
		public unsafe bool isOpen
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 262622, RefRangeEnd = 262627, XrefRangeStart = 262618, XrefRangeEnd = 262622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x0025BE88 File Offset: 0x0025A088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262773, RefRangeEnd = 262774, XrefRangeStart = 262627, XrefRangeEnd = 262773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Business bus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bus);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Initialize_Public_Void_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x0025BECC File Offset: 0x0025A0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262774, XrefRangeEnd = 262849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x0025BF00 File Offset: 0x0025A100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262849, XrefRangeEnd = 262855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x0025BF3C File Offset: 0x0025A13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262855, XrefRangeEnd = 262859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x0025BF80 File Offset: 0x0025A180
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262963, RefRangeEnd = 262966, XrefRangeStart = 262859, XrefRangeEnd = 262963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009087 RID: 36999 RVA: 0x0025BFB4 File Offset: 0x0025A1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262966, XrefRangeEnd = 262969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x0025BFE8 File Offset: 0x0025A1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263004, RefRangeEnd = 263005, XrefRangeStart = 262969, XrefRangeEnd = 263004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x0025C02C File Offset: 0x0025A22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263005, XrefRangeEnd = 263027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEntry(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x0025C070 File Offset: 0x0025A270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263089, RefRangeEnd = 263091, XrefRangeStart = 263027, XrefRangeEnd = 263089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntryTimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600908B RID: 37003 RVA: 0x0025C0A4 File Offset: 0x0025A2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263091, XrefRangeEnd = 263096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashStacks(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600908C RID: 37004 RVA: 0x0025C0E8 File Offset: 0x0025A2E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 263123, RefRangeEnd = 263126, XrefRangeStart = 263096, XrefRangeEnd = 263123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLaunderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600908D RID: 37005 RVA: 0x0025C11C File Offset: 0x0025A31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263126, XrefRangeEnd = 263134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600908E RID: 37006 RVA: 0x0025C150 File Offset: 0x0025A350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263134, XrefRangeEnd = 263137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAmountSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x0025C184 File Offset: 0x0025A384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263137, XrefRangeEnd = 263166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_ConfirmAmount_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x0025C1B8 File Offset: 0x0025A3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263166, XrefRangeEnd = 263168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SliderValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_SliderValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x0025C1EC File Offset: 0x0025A3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263168, XrefRangeEnd = 263174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InputValueChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_InputValueChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x0025C220 File Offset: 0x0025A420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263174, XrefRangeEnd = 263179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x0025C254 File Offset: 0x0025A454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263179, XrefRangeEnd = 263180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x0025C288 File Offset: 0x0025A488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263180, XrefRangeEnd = 263224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x0025C2C4 File Offset: 0x0025A4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263224, XrefRangeEnd = 263259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunderingInterface.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x0025C300 File Offset: 0x0025A500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263259, XrefRangeEnd = 263279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LaunderingInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x0025C33C File Offset: 0x0025A53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263279, XrefRangeEnd = 263285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__32_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x0025C370 File Offset: 0x0025A570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263285, XrefRangeEnd = 263290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateTimeline_b__36_0(KeyValuePair<LaunderingOperation, RectTransform> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06009099 RID: 37017 RVA: 0x0004534A File Offset: 0x0004354A
		public LaunderingInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x0600909A RID: 37018 RVA: 0x0025C3C4 File Offset: 0x0025A5C4
		// (set) Token: 0x0600909B RID: 37019 RVA: 0x00045353 File Offset: 0x00043553
		public unsafe static float fovOverride
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_fovOverride, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_fovOverride, (void*)(&value));
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x0600909C RID: 37020 RVA: 0x0025C3E0 File Offset: 0x0025A5E0
		// (set) Token: 0x0600909D RID: 37021 RVA: 0x00045361 File Offset: 0x00043561
		public unsafe static float lerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_lerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_lerpTime, (void*)(&value));
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x0600909E RID: 37022 RVA: 0x0025C3FC File Offset: 0x0025A5FC
		// (set) Token: 0x0600909F RID: 37023 RVA: 0x0004536F File Offset: 0x0004356F
		public unsafe static int minLaunderAmount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.NativeFieldInfoPtr_minLaunderAmount, (void*)(&value));
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x060090A0 RID: 37024 RVA: 0x0025C418 File Offset: 0x0025A618
		// (set) Token: 0x060090A1 RID: 37025 RVA: 0x0004537D File Offset: 0x0004357D
		public unsafe Business _business_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr__business_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x060090A2 RID: 37026 RVA: 0x0025C448 File Offset: 0x0025A648
		// (set) Token: 0x060090A3 RID: 37027 RVA: 0x0004539C File Offset: 0x0004359C
		public unsafe Transform cameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_cameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x060090A4 RID: 37028 RVA: 0x0025C478 File Offset: 0x0025A678
		// (set) Token: 0x060090A5 RID: 37029 RVA: 0x000453BB File Offset: 0x000435BB
		public unsafe InteractableObject intObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x060090A6 RID: 37030 RVA: 0x0025C4A8 File Offset: 0x0025A6A8
		// (set) Token: 0x060090A7 RID: 37031 RVA: 0x000453DA File Offset: 0x000435DA
		public unsafe Button launderButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x060090A8 RID: 37032 RVA: 0x0025C4D8 File Offset: 0x0025A6D8
		// (set) Token: 0x060090A9 RID: 37033 RVA: 0x000453F9 File Offset: 0x000435F9
		public unsafe GameObject amountSelectorScreen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x060090AA RID: 37034 RVA: 0x0025C508 File Offset: 0x0025A708
		// (set) Token: 0x060090AB RID: 37035 RVA: 0x00045418 File Offset: 0x00043618
		public unsafe Slider amountSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x060090AC RID: 37036 RVA: 0x0025C538 File Offset: 0x0025A738
		// (set) Token: 0x060090AD RID: 37037 RVA: 0x00045437 File Offset: 0x00043637
		public unsafe TMP_InputField amountInputField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_amountInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x060090AE RID: 37038 RVA: 0x0025C568 File Offset: 0x0025A768
		// (set) Token: 0x060090AF RID: 37039 RVA: 0x00045456 File Offset: 0x00043656
		public unsafe RectTransform notchContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notchContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x060090B0 RID: 37040 RVA: 0x0025C598 File Offset: 0x0025A798
		// (set) Token: 0x060090B1 RID: 37041 RVA: 0x00045475 File Offset: 0x00043675
		public unsafe TextMeshProUGUI currentTotalAmountLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_currentTotalAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x060090B2 RID: 37042 RVA: 0x0025C5C8 File Offset: 0x0025A7C8
		// (set) Token: 0x060090B3 RID: 37043 RVA: 0x00045494 File Offset: 0x00043694
		public unsafe TextMeshProUGUI launderCapacityLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_launderCapacityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x060090B4 RID: 37044 RVA: 0x0025C5F8 File Offset: 0x0025A7F8
		// (set) Token: 0x060090B5 RID: 37045 RVA: 0x000454B3 File Offset: 0x000436B3
		public unsafe TextMeshProUGUI insufficientCashLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_insufficientCashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x060090B6 RID: 37046 RVA: 0x0025C628 File Offset: 0x0025A828
		// (set) Token: 0x060090B7 RID: 37047 RVA: 0x000454D2 File Offset: 0x000436D2
		public unsafe RectTransform entryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x060090B8 RID: 37048 RVA: 0x0025C658 File Offset: 0x0025A858
		// (set) Token: 0x060090B9 RID: 37049 RVA: 0x000454F1 File Offset: 0x000436F1
		public unsafe RectTransform noEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_noEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x060090BA RID: 37050 RVA: 0x0025C688 File Offset: 0x0025A888
		// (set) Token: 0x060090BB RID: 37051 RVA: 0x00045510 File Offset: 0x00043710
		public unsafe Il2CppReferenceArray<CashStackVisuals> CashStacks
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_CashStacks);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CashStackVisuals>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_CashStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x060090BC RID: 37052 RVA: 0x0025C6B8 File Offset: 0x0025A8B8
		// (set) Token: 0x060090BD RID: 37053 RVA: 0x0004552F File Offset: 0x0004372F
		public unsafe GameObject timelineNotchPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_timelineNotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x060090BE RID: 37054 RVA: 0x0025C6E8 File Offset: 0x0025A8E8
		// (set) Token: 0x060090BF RID: 37055 RVA: 0x0004554E File Offset: 0x0004374E
		public unsafe GameObject entryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_entryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x060090C0 RID: 37056 RVA: 0x0025C718 File Offset: 0x0025A918
		// (set) Token: 0x060090C1 RID: 37057 RVA: 0x0004556D File Offset: 0x0004376D
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x060090C2 RID: 37058 RVA: 0x0025C748 File Offset: 0x0025A948
		// (set) Token: 0x060090C3 RID: 37059 RVA: 0x0004558C File Offset: 0x0004378C
		public unsafe int selectedAmountToLaunder
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_selectedAmountToLaunder)) = value;
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x060090C4 RID: 37060 RVA: 0x0025C770 File Offset: 0x0025A970
		// (set) Token: 0x060090C5 RID: 37061 RVA: 0x000455A7 File Offset: 0x000437A7
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToNotch
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToNotch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x060090C6 RID: 37062 RVA: 0x0025C7A0 File Offset: 0x0025A9A0
		// (set) Token: 0x060090C7 RID: 37063 RVA: 0x000455C6 File Offset: 0x000437C6
		public unsafe List<RectTransform> notches
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x060090C8 RID: 37064 RVA: 0x0025C7D0 File Offset: 0x0025A9D0
		// (set) Token: 0x060090C9 RID: 37065 RVA: 0x000455E5 File Offset: 0x000437E5
		public unsafe bool ignoreSliderChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_ignoreSliderChange)) = value;
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x060090CA RID: 37066 RVA: 0x0025C7F8 File Offset: 0x0025A9F8
		// (set) Token: 0x060090CB RID: 37067 RVA: 0x00045600 File Offset: 0x00043800
		public unsafe Dictionary<LaunderingOperation, RectTransform> operationToEntry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LaunderingOperation, RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(LaunderingInterface.NativeFieldInfoPtr_operationToEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040061DC RID: 25052
		private static readonly System.IntPtr NativeFieldInfoPtr_fovOverride;

		// Token: 0x040061DD RID: 25053
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

		// Token: 0x040061DE RID: 25054
		private static readonly System.IntPtr NativeFieldInfoPtr_minLaunderAmount;

		// Token: 0x040061DF RID: 25055
		private static readonly System.IntPtr NativeFieldInfoPtr__business_k__BackingField;

		// Token: 0x040061E0 RID: 25056
		private static readonly System.IntPtr NativeFieldInfoPtr_cameraPosition;

		// Token: 0x040061E1 RID: 25057
		private static readonly System.IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x040061E2 RID: 25058
		private static readonly System.IntPtr NativeFieldInfoPtr_launderButton;

		// Token: 0x040061E3 RID: 25059
		private static readonly System.IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x040061E4 RID: 25060
		private static readonly System.IntPtr NativeFieldInfoPtr_amountSlider;

		// Token: 0x040061E5 RID: 25061
		private static readonly System.IntPtr NativeFieldInfoPtr_amountInputField;

		// Token: 0x040061E6 RID: 25062
		private static readonly System.IntPtr NativeFieldInfoPtr_notchContainer;

		// Token: 0x040061E7 RID: 25063
		private static readonly System.IntPtr NativeFieldInfoPtr_currentTotalAmountLabel;

		// Token: 0x040061E8 RID: 25064
		private static readonly System.IntPtr NativeFieldInfoPtr_launderCapacityLabel;

		// Token: 0x040061E9 RID: 25065
		private static readonly System.IntPtr NativeFieldInfoPtr_insufficientCashLabel;

		// Token: 0x040061EA RID: 25066
		private static readonly System.IntPtr NativeFieldInfoPtr_entryContainer;

		// Token: 0x040061EB RID: 25067
		private static readonly System.IntPtr NativeFieldInfoPtr_noEntries;

		// Token: 0x040061EC RID: 25068
		private static readonly System.IntPtr NativeFieldInfoPtr_CashStacks;

		// Token: 0x040061ED RID: 25069
		private static readonly System.IntPtr NativeFieldInfoPtr_timelineNotchPrefab;

		// Token: 0x040061EE RID: 25070
		private static readonly System.IntPtr NativeFieldInfoPtr_entryPrefab;

		// Token: 0x040061EF RID: 25071
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040061F0 RID: 25072
		private static readonly System.IntPtr NativeFieldInfoPtr_selectedAmountToLaunder;

		// Token: 0x040061F1 RID: 25073
		private static readonly System.IntPtr NativeFieldInfoPtr_operationToNotch;

		// Token: 0x040061F2 RID: 25074
		private static readonly System.IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x040061F3 RID: 25075
		private static readonly System.IntPtr NativeFieldInfoPtr_ignoreSliderChange;

		// Token: 0x040061F4 RID: 25076
		private static readonly System.IntPtr NativeFieldInfoPtr_operationToEntry;

		// Token: 0x040061F5 RID: 25077
		private static readonly System.IntPtr NativeMethodInfoPtr_get_maxLaunderAmount_Protected_get_Int32_0;

		// Token: 0x040061F6 RID: 25078
		private static readonly System.IntPtr NativeMethodInfoPtr_get_business_Public_get_Business_0;

		// Token: 0x040061F7 RID: 25079
		private static readonly System.IntPtr NativeMethodInfoPtr_set_business_Private_set_Void_Business_0;

		// Token: 0x040061F8 RID: 25080
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040061F9 RID: 25081
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Business_0;

		// Token: 0x040061FA RID: 25082
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040061FB RID: 25083
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x040061FC RID: 25084
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Protected_Void_ExitAction_0;

		// Token: 0x040061FD RID: 25085
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeline_Protected_Void_0;

		// Token: 0x040061FE RID: 25086
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCurrentTotal_Protected_Void_0;

		// Token: 0x040061FF RID: 25087
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04006200 RID: 25088
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEntry_Private_Void_LaunderingOperation_0;

		// Token: 0x04006201 RID: 25089
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEntryTimes_Private_Void_0;

		// Token: 0x04006202 RID: 25090
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCashStacks_Private_Void_LaunderingOperation_0;

		// Token: 0x04006203 RID: 25091
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshLaunderButton_Private_Void_0;

		// Token: 0x04006204 RID: 25092
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_0;

		// Token: 0x04006205 RID: 25093
		private static readonly System.IntPtr NativeMethodInfoPtr_CloseAmountSelector_Public_Void_0;

		// Token: 0x04006206 RID: 25094
		private static readonly System.IntPtr NativeMethodInfoPtr_ConfirmAmount_Public_Void_0;

		// Token: 0x04006207 RID: 25095
		private static readonly System.IntPtr NativeMethodInfoPtr_SliderValueChanged_Public_Void_0;

		// Token: 0x04006208 RID: 25096
		private static readonly System.IntPtr NativeMethodInfoPtr_InputValueChanged_Public_Void_0;

		// Token: 0x04006209 RID: 25097
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x0400620A RID: 25098
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400620B RID: 25099
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x0400620C RID: 25100
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x0400620D RID: 25101
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400620E RID: 25102
		private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_0;

		// Token: 0x0400620F RID: 25103
		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTimeline_b__36_0_Private_Boolean_KeyValuePair_2_LaunderingOperation_RectTransform_0;

		// Token: 0x02000B7A RID: 2938
		[ObfuscatedName("ScheduleOne.UI.LaunderingInterface+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DCFF RID: 56575 RVA: 0x0034A87C File Offset: 0x00348A7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaunderingInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr);
				LaunderingInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9");
				LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, "<>9__36_1");
				LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100681361);
				LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr, 100681362);
			}

			// Token: 0x0600DD00 RID: 56576 RVA: 0x0034A8F8 File Offset: 0x00348AF8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunderingInterface.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DD01 RID: 56577 RVA: 0x0034A934 File Offset: 0x00348B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262607, XrefRangeEnd = 262608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RectTransform _UpdateTimeline_b__36_1(KeyValuePair<LaunderingOperation, RectTransform> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunderingInterface.__c.NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}

			// Token: 0x0600DD02 RID: 56578 RVA: 0x0006B49F File Offset: 0x0006969F
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004431 RID: 17457
			// (get) Token: 0x0600DD03 RID: 56579 RVA: 0x0034A98C File Offset: 0x00348B8C
			// (set) Token: 0x0600DD04 RID: 56580 RVA: 0x0006B4A8 File Offset: 0x000696A8
			public unsafe static LaunderingInterface.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunderingInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004432 RID: 17458
			// (get) Token: 0x0600DD05 RID: 56581 RVA: 0x0034A9B4 File Offset: 0x00348BB4
			// (set) Token: 0x0600DD06 RID: 56582 RVA: 0x0006B4BA File Offset: 0x000696BA
			public unsafe static Il2CppSystem.Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform> __9__36_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<LaunderingOperation, RectTransform>, RectTransform>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LaunderingInterface.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009498 RID: 38040
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009499 RID: 38041
			private static readonly System.IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x0400949A RID: 38042
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400949B RID: 38043
			private static readonly System.IntPtr NativeMethodInfoPtr__UpdateTimeline_b__36_1_Internal_RectTransform_KeyValuePair_2_LaunderingOperation_RectTransform_0;
		}
	}
}
