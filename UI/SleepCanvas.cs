using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000681 RID: 1665
	public class SleepCanvas : Singleton<SleepCanvas>
	{
		// Token: 0x0600939A RID: 37786 RVA: 0x0026488C File Offset: 0x00262A8C
		// Note: this type is marked as 'beforefieldinit'.
		static SleepCanvas()
		{
			Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "SleepCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr);
			SleepCanvas.NativeFieldInfoPtr_MaxSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MaxSleepTime");
			SleepCanvas.NativeFieldInfoPtr_MinSleepTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MinSleepTime");
			SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<IsMenuOpen>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<QueuedSleepMessage>k__BackingField");
			SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "QueuedMessageDisplayTime");
			SleepCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Canvas");
			SleepCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "Container");
			SleepCanvas.NativeFieldInfoPtr_MenuContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "MenuContainer");
			SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "CurrentTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_IncreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "IncreaseButton");
			SleepCanvas.NativeFieldInfoPtr_DecreaseButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "DecreaseButton");
			SleepCanvas.NativeFieldInfoPtr_EndTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "EndTimeLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButton");
			SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepButtonLabel");
			SleepCanvas.NativeFieldInfoPtr_BlackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "BlackOverlay");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageLabel");
			SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "SleepMessageGroup");
			SleepCanvas.NativeFieldInfoPtr_TimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "TimeLabel");
			SleepCanvas.NativeFieldInfoPtr_WakeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WakeLabel");
			SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "WaitingForHostLabel");
			SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepFullyFaded");
			SleepCanvas.NativeFieldInfoPtr_onSleepEndFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "onSleepEndFade");
			SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "queuedPostSleepEvents");
			SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681677);
			SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681678);
			SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681679);
			SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681680);
			SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681681);
			SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681682);
			SleepCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681683);
			SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681684);
			SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681685);
			SleepCanvas.NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681686);
			SleepCanvas.NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681687);
			SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681688);
			SleepCanvas.NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681689);
			SleepCanvas.NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681690);
			SleepCanvas.NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681691);
			SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681692);
			SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681693);
			SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681694);
			SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681695);
			SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681696);
			SleepCanvas.NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681697);
			SleepCanvas.NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681698);
			SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, 100681699);
		}

		// Token: 0x17002D1A RID: 11546
		// (get) Token: 0x0600939B RID: 37787 RVA: 0x00264C54 File Offset: 0x00262E54
		// (set) Token: 0x0600939C RID: 37788 RVA: 0x00264C90 File Offset: 0x00262E90
		public unsafe bool IsMenuOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002D1B RID: 11547
		// (get) Token: 0x0600939D RID: 37789 RVA: 0x00264CD0 File Offset: 0x00262ED0
		// (set) Token: 0x0600939E RID: 37790 RVA: 0x00264D08 File Offset: 0x00262F08
		public unsafe string QueuedSleepMessage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600939F RID: 37791 RVA: 0x00264D4C File Offset: 0x00262F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266959, XrefRangeEnd = 267012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SleepCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A0 RID: 37792 RVA: 0x00264D88 File Offset: 0x00262F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267012, XrefRangeEnd = 267014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A1 RID: 37793 RVA: 0x00264DCC File Offset: 0x00262FCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267094, RefRangeEnd = 267097, XrefRangeStart = 267014, XrefRangeEnd = 267094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref open;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A2 RID: 37794 RVA: 0x00264E0C File Offset: 0x0026300C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267116, RefRangeEnd = 267117, XrefRangeStart = 267097, XrefRangeEnd = 267116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A3 RID: 37795 RVA: 0x00264E40 File Offset: 0x00263040
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267131, RefRangeEnd = 267133, XrefRangeStart = 267117, XrefRangeEnd = 267131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPostSleepEvent(IPostSleepEvent postSleepEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(postSleepEvent);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A4 RID: 37796 RVA: 0x00264E84 File Offset: 0x00263084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267133, XrefRangeEnd = 267136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHourSetting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A5 RID: 37797 RVA: 0x00264EB8 File Offset: 0x002630B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267136, XrefRangeEnd = 267138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A6 RID: 37798 RVA: 0x00264EEC File Offset: 0x002630EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267138, XrefRangeEnd = 267148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSleepButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x00264F20 File Offset: 0x00263120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267159, RefRangeEnd = 267161, XrefRangeStart = 267148, XrefRangeEnd = 267159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSleepAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x00264F60 File Offset: 0x00263160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267170, RefRangeEnd = 267172, XrefRangeStart = 267161, XrefRangeEnd = 267170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampWakeTime(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x00264FAC File Offset: 0x002631AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267172, XrefRangeEnd = 267174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ClampTime(int time, int startTime, int endTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endTime;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x00265014 File Offset: 0x00263214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267174, XrefRangeEnd = 267181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x00265048 File Offset: 0x00263248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267181, XrefRangeEnd = 267199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x0026507C File Offset: 0x0026327C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267212, RefRangeEnd = 267214, XrefRangeStart = 267199, XrefRangeEnd = 267212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpBlackOverlay(float transparency, float lerpTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref transparency;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref lerpTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x002650C8 File Offset: 0x002632C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 267235, RefRangeEnd = 267238, XrefRangeStart = 267214, XrefRangeEnd = 267235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSleepMessage(string message, float displayTime = 3f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref displayTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x00265118 File Offset: 0x00263318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267238, XrefRangeEnd = 267251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SleepCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x00265154 File Offset: 0x00263354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267251, XrefRangeEnd = 267252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__29_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x00265188 File Offset: 0x00263388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267252, XrefRangeEnd = 267253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__29_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x002651BC File Offset: 0x002633BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267253, XrefRangeEnd = 267258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x0004713A File Offset: 0x0004533A
		public SleepCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x060093B3 RID: 37811 RVA: 0x002651FC File Offset: 0x002633FC
		// (set) Token: 0x060093B4 RID: 37812 RVA: 0x00047143 File Offset: 0x00045343
		public unsafe static int MaxSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MaxSleepTime, (void*)(&value));
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x060093B5 RID: 37813 RVA: 0x00265218 File Offset: 0x00263418
		// (set) Token: 0x060093B6 RID: 37814 RVA: 0x00047151 File Offset: 0x00045351
		public unsafe static int MinSleepTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SleepCanvas.NativeFieldInfoPtr_MinSleepTime, (void*)(&value));
			}
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x060093B7 RID: 37815 RVA: 0x00265234 File Offset: 0x00263434
		// (set) Token: 0x060093B8 RID: 37816 RVA: 0x0004715F File Offset: 0x0004535F
		public unsafe bool _IsMenuOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__IsMenuOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x060093B9 RID: 37817 RVA: 0x0026525C File Offset: 0x0026345C
		// (set) Token: 0x060093BA RID: 37818 RVA: 0x0004717A File Offset: 0x0004537A
		public unsafe string _QueuedSleepMessage_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x060093BB RID: 37819 RVA: 0x00265284 File Offset: 0x00263484
		// (set) Token: 0x060093BC RID: 37820 RVA: 0x00047199 File Offset: 0x00045399
		public unsafe float QueuedMessageDisplayTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_QueuedMessageDisplayTime)) = value;
			}
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x060093BD RID: 37821 RVA: 0x002652AC File Offset: 0x002634AC
		// (set) Token: 0x060093BE RID: 37822 RVA: 0x000471B4 File Offset: 0x000453B4
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x060093BF RID: 37823 RVA: 0x002652DC File Offset: 0x002634DC
		// (set) Token: 0x060093C0 RID: 37824 RVA: 0x000471D3 File Offset: 0x000453D3
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x060093C1 RID: 37825 RVA: 0x0026530C File Offset: 0x0026350C
		// (set) Token: 0x060093C2 RID: 37826 RVA: 0x000471F2 File Offset: 0x000453F2
		public unsafe RectTransform MenuContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_MenuContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x060093C3 RID: 37827 RVA: 0x0026533C File Offset: 0x0026353C
		// (set) Token: 0x060093C4 RID: 37828 RVA: 0x00047211 File Offset: 0x00045411
		public unsafe TextMeshProUGUI CurrentTimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_CurrentTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x0026536C File Offset: 0x0026356C
		// (set) Token: 0x060093C6 RID: 37830 RVA: 0x00047230 File Offset: 0x00045430
		public unsafe Button IncreaseButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_IncreaseButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_IncreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x060093C7 RID: 37831 RVA: 0x0026539C File Offset: 0x0026359C
		// (set) Token: 0x060093C8 RID: 37832 RVA: 0x0004724F File Offset: 0x0004544F
		public unsafe Button DecreaseButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_DecreaseButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_DecreaseButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x060093C9 RID: 37833 RVA: 0x002653CC File Offset: 0x002635CC
		// (set) Token: 0x060093CA RID: 37834 RVA: 0x0004726E File Offset: 0x0004546E
		public unsafe TextMeshProUGUI EndTimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_EndTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x060093CB RID: 37835 RVA: 0x002653FC File Offset: 0x002635FC
		// (set) Token: 0x060093CC RID: 37836 RVA: 0x0004728D File Offset: 0x0004548D
		public unsafe Button SleepButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x060093CD RID: 37837 RVA: 0x0026542C File Offset: 0x0026362C
		// (set) Token: 0x060093CE RID: 37838 RVA: 0x000472AC File Offset: 0x000454AC
		public unsafe TextMeshProUGUI SleepButtonLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x060093CF RID: 37839 RVA: 0x0026545C File Offset: 0x0026365C
		// (set) Token: 0x060093D0 RID: 37840 RVA: 0x000472CB File Offset: 0x000454CB
		public unsafe Image BlackOverlay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_BlackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x060093D1 RID: 37841 RVA: 0x0026548C File Offset: 0x0026368C
		// (set) Token: 0x060093D2 RID: 37842 RVA: 0x000472EA File Offset: 0x000454EA
		public unsafe TextMeshProUGUI SleepMessageLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x060093D3 RID: 37843 RVA: 0x002654BC File Offset: 0x002636BC
		// (set) Token: 0x060093D4 RID: 37844 RVA: 0x00047309 File Offset: 0x00045509
		public unsafe CanvasGroup SleepMessageGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_SleepMessageGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x060093D5 RID: 37845 RVA: 0x002654EC File Offset: 0x002636EC
		// (set) Token: 0x060093D6 RID: 37846 RVA: 0x00047328 File Offset: 0x00045528
		public unsafe TextMeshProUGUI TimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_TimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x060093D7 RID: 37847 RVA: 0x0026551C File Offset: 0x0026371C
		// (set) Token: 0x060093D8 RID: 37848 RVA: 0x00047347 File Offset: 0x00045547
		public unsafe TextMeshProUGUI WakeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WakeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x060093D9 RID: 37849 RVA: 0x0026554C File Offset: 0x0026374C
		// (set) Token: 0x060093DA RID: 37850 RVA: 0x00047366 File Offset: 0x00045566
		public unsafe TextMeshProUGUI WaitingForHostLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_WaitingForHostLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x0026557C File Offset: 0x0026377C
		// (set) Token: 0x060093DC RID: 37852 RVA: 0x00047385 File Offset: 0x00045585
		public unsafe UnityEvent onSleepFullyFaded
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepFullyFaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x002655AC File Offset: 0x002637AC
		// (set) Token: 0x060093DE RID: 37854 RVA: 0x000473A4 File Offset: 0x000455A4
		public unsafe UnityEvent onSleepEndFade
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_onSleepEndFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D19 RID: 11545
		// (get) Token: 0x060093DF RID: 37855 RVA: 0x002655DC File Offset: 0x002637DC
		// (set) Token: 0x060093E0 RID: 37856 RVA: 0x000473C3 File Offset: 0x000455C3
		public unsafe List<IPostSleepEvent> queuedPostSleepEvents
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IPostSleepEvent>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.NativeFieldInfoPtr_queuedPostSleepEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040063CA RID: 25546
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxSleepTime;

		// Token: 0x040063CB RID: 25547
		private static readonly System.IntPtr NativeFieldInfoPtr_MinSleepTime;

		// Token: 0x040063CC RID: 25548
		private static readonly System.IntPtr NativeFieldInfoPtr__IsMenuOpen_k__BackingField;

		// Token: 0x040063CD RID: 25549
		private static readonly System.IntPtr NativeFieldInfoPtr__QueuedSleepMessage_k__BackingField;

		// Token: 0x040063CE RID: 25550
		private static readonly System.IntPtr NativeFieldInfoPtr_QueuedMessageDisplayTime;

		// Token: 0x040063CF RID: 25551
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040063D0 RID: 25552
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040063D1 RID: 25553
		private static readonly System.IntPtr NativeFieldInfoPtr_MenuContainer;

		// Token: 0x040063D2 RID: 25554
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTimeLabel;

		// Token: 0x040063D3 RID: 25555
		private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseButton;

		// Token: 0x040063D4 RID: 25556
		private static readonly System.IntPtr NativeFieldInfoPtr_DecreaseButton;

		// Token: 0x040063D5 RID: 25557
		private static readonly System.IntPtr NativeFieldInfoPtr_EndTimeLabel;

		// Token: 0x040063D6 RID: 25558
		private static readonly System.IntPtr NativeFieldInfoPtr_SleepButton;

		// Token: 0x040063D7 RID: 25559
		private static readonly System.IntPtr NativeFieldInfoPtr_SleepButtonLabel;

		// Token: 0x040063D8 RID: 25560
		private static readonly System.IntPtr NativeFieldInfoPtr_BlackOverlay;

		// Token: 0x040063D9 RID: 25561
		private static readonly System.IntPtr NativeFieldInfoPtr_SleepMessageLabel;

		// Token: 0x040063DA RID: 25562
		private static readonly System.IntPtr NativeFieldInfoPtr_SleepMessageGroup;

		// Token: 0x040063DB RID: 25563
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeLabel;

		// Token: 0x040063DC RID: 25564
		private static readonly System.IntPtr NativeFieldInfoPtr_WakeLabel;

		// Token: 0x040063DD RID: 25565
		private static readonly System.IntPtr NativeFieldInfoPtr_WaitingForHostLabel;

		// Token: 0x040063DE RID: 25566
		private static readonly System.IntPtr NativeFieldInfoPtr_onSleepFullyFaded;

		// Token: 0x040063DF RID: 25567
		private static readonly System.IntPtr NativeFieldInfoPtr_onSleepEndFade;

		// Token: 0x040063E0 RID: 25568
		private static readonly System.IntPtr NativeFieldInfoPtr_queuedPostSleepEvents;

		// Token: 0x040063E1 RID: 25569
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsMenuOpen_Public_get_Boolean_0;

		// Token: 0x040063E2 RID: 25570
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsMenuOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040063E3 RID: 25571
		private static readonly System.IntPtr NativeMethodInfoPtr_get_QueuedSleepMessage_Public_get_String_0;

		// Token: 0x040063E4 RID: 25572
		private static readonly System.IntPtr NativeMethodInfoPtr_set_QueuedSleepMessage_Protected_set_Void_String_0;

		// Token: 0x040063E5 RID: 25573
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040063E6 RID: 25574
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040063E7 RID: 25575
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x040063E8 RID: 25576
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040063E9 RID: 25577
		private static readonly System.IntPtr NativeMethodInfoPtr_AddPostSleepEvent_Public_Void_IPostSleepEvent_0;

		// Token: 0x040063EA RID: 25578
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHourSetting_Private_Void_0;

		// Token: 0x040063EB RID: 25579
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimeLabels_Private_Void_0;

		// Token: 0x040063EC RID: 25580
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSleepButton_Private_Void_0;

		// Token: 0x040063ED RID: 25581
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeSleepAmount_Private_Void_Int32_0;

		// Token: 0x040063EE RID: 25582
		private static readonly System.IntPtr NativeMethodInfoPtr_ClampWakeTime_Private_Int32_Int32_0;

		// Token: 0x040063EF RID: 25583
		private static readonly System.IntPtr NativeMethodInfoPtr_ClampTime_Private_Int32_Int32_Int32_Int32_0;

		// Token: 0x040063F0 RID: 25584
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepButtonPressed_Private_Void_0;

		// Token: 0x040063F1 RID: 25585
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x040063F2 RID: 25586
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpBlackOverlay_Private_Void_Single_Single_0;

		// Token: 0x040063F3 RID: 25587
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueSleepMessage_Public_Void_String_Single_0;

		// Token: 0x040063F4 RID: 25588
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040063F5 RID: 25589
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__29_0_Private_Void_0;

		// Token: 0x040063F6 RID: 25590
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__29_1_Private_Void_0;

		// Token: 0x040063F7 RID: 25591
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B91 RID: 2961
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<<SleepStart>g__Sleep|41_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DE1B RID: 56859 RVA: 0x0034DBB4 File Offset: 0x0034BDB4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique()
			{
				Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<<SleepStart>g__Sleep|41_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>1__state");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>2__current");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>4__this");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>8__1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<>7__wrap1");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__3");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, "<i>5__4");
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681700);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681701);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681702);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681703);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681704);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681705);
				SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr, 100681706);
			}

			// Token: 0x0600DE1C RID: 56860 RVA: 0x0034DCF8 File Offset: 0x0034BEF8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE1D RID: 56861 RVA: 0x0034DD40 File Offset: 0x0034BF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266676, XrefRangeEnd = 266681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE1E RID: 56862 RVA: 0x0034DD74 File Offset: 0x0034BF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266681, XrefRangeEnd = 266912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DE1F RID: 56863 RVA: 0x0034DDB0 File Offset: 0x0034BFB0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 266915, RefRangeEnd = 266916, XrefRangeStart = 266912, XrefRangeEnd = 266915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170044A0 RID: 17568
			// (get) Token: 0x0600DE20 RID: 56864 RVA: 0x0034DDE4 File Offset: 0x0034BFE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DE21 RID: 56865 RVA: 0x0034DE24 File Offset: 0x0034C024
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266916, XrefRangeEnd = 266921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170044A1 RID: 17569
			// (get) Token: 0x0600DE22 RID: 56866 RVA: 0x0034DE58 File Offset: 0x0034C058
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DE23 RID: 56867 RVA: 0x0006BDEC File Offset: 0x00069FEC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004499 RID: 17561
			// (get) Token: 0x0600DE24 RID: 56868 RVA: 0x0034DE98 File Offset: 0x0034C098
			// (set) Token: 0x0600DE25 RID: 56869 RVA: 0x0006BDF5 File Offset: 0x00069FF5
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700449A RID: 17562
			// (get) Token: 0x0600DE26 RID: 56870 RVA: 0x0034DEC0 File Offset: 0x0034C0C0
			// (set) Token: 0x0600DE27 RID: 56871 RVA: 0x0006BE10 File Offset: 0x0006A010
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449B RID: 17563
			// (get) Token: 0x0600DE28 RID: 56872 RVA: 0x0034DEF0 File Offset: 0x0034C0F0
			// (set) Token: 0x0600DE29 RID: 56873 RVA: 0x0006BE2F File Offset: 0x0006A02F
			public unsafe SleepCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449C RID: 17564
			// (get) Token: 0x0600DE2A RID: 56874 RVA: 0x0034DF20 File Offset: 0x0034C120
			// (set) Token: 0x0600DE2B RID: 56875 RVA: 0x0006BE4E File Offset: 0x0006A04E
			public unsafe SleepCanvas.__c__DisplayClass41_0 __8__1
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass41_0>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449D RID: 17565
			// (get) Token: 0x0600DE2C RID: 56876 RVA: 0x0034DF50 File Offset: 0x0034C150
			// (set) Token: 0x0600DE2D RID: 56877 RVA: 0x0006BE6D File Offset: 0x0006A06D
			public List<IPostSleepEvent>.Enumerator __7__wrap1
			{
				get
				{
					System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1);
					return new List<IPostSleepEvent>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, data));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IPostSleepEvent>.Enumerator>.NativeClassPtr, (System.UIntPtr)0));
				}
			}

			// Token: 0x1700449E RID: 17566
			// (get) Token: 0x0600DE2E RID: 56878 RVA: 0x0034DF80 File Offset: 0x0034C180
			// (set) Token: 0x0600DE2F RID: 56879 RVA: 0x0006BE9B File Offset: 0x0006A09B
			public unsafe float _lerpTime_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x1700449F RID: 17567
			// (get) Token: 0x0600DE30 RID: 56880 RVA: 0x0034DFA8 File Offset: 0x0034C1A8
			// (set) Token: 0x0600DE31 RID: 56881 RVA: 0x0006BEB6 File Offset: 0x0006A0B6
			public unsafe float _i_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSlEn1IPSiSiObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400954F RID: 38223
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009550 RID: 38224
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009551 RID: 38225
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009552 RID: 38226
			private static readonly System.IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009553 RID: 38227
			private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04009554 RID: 38228
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x04009555 RID: 38229
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04009556 RID: 38230
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009557 RID: 38231
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009558 RID: 38232
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009559 RID: 38233
			private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400955A RID: 38234
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400955B RID: 38235
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400955C RID: 38236
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B92 RID: 2962
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE32 RID: 56882 RVA: 0x0034DFD0 File Offset: 0x0034C1D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr);
				SleepCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_1");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_2");
				SleepCanvas.__c.NativeFieldInfoPtr___9__41_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, "<>9__41_3");
				SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681708);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681709);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681710);
				SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr, 100681711);
			}

			// Token: 0x0600DE33 RID: 56883 RVA: 0x0034E09C File Offset: 0x0034C29C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE34 RID: 56884 RVA: 0x0034E0D8 File Offset: 0x0034C2D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266921, XrefRangeEnd = 266925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__41_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DE35 RID: 56885 RVA: 0x0034E114 File Offset: 0x0034C314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266925, XrefRangeEnd = 266929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SleepStart_b__41_2(IPostSleepEvent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DE36 RID: 56886 RVA: 0x0034E164 File Offset: 0x0034C364
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266929, XrefRangeEnd = 266933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__41_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c.NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DE37 RID: 56887 RVA: 0x0006BED1 File Offset: 0x0006A0D1
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A2 RID: 17570
			// (get) Token: 0x0600DE38 RID: 56888 RVA: 0x0034E1A0 File Offset: 0x0034C3A0
			// (set) Token: 0x0600DE39 RID: 56889 RVA: 0x0006BEDA File Offset: 0x0006A0DA
			public unsafe static SleepCanvas.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A3 RID: 17571
			// (get) Token: 0x0600DE3A RID: 56890 RVA: 0x0034E1C8 File Offset: 0x0034C3C8
			// (set) Token: 0x0600DE3B RID: 56891 RVA: 0x0006BEEC File Offset: 0x0006A0EC
			public unsafe static Il2CppSystem.Func<bool> __9__41_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A4 RID: 17572
			// (get) Token: 0x0600DE3C RID: 56892 RVA: 0x0034E1F0 File Offset: 0x0034C3F0
			// (set) Token: 0x0600DE3D RID: 56893 RVA: 0x0006BEFE File Offset: 0x0006A0FE
			public unsafe static Il2CppSystem.Func<IPostSleepEvent, int> __9__41_2
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_2, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<IPostSleepEvent, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A5 RID: 17573
			// (get) Token: 0x0600DE3E RID: 56894 RVA: 0x0034E218 File Offset: 0x0034C418
			// (set) Token: 0x0600DE3F RID: 56895 RVA: 0x0006BF10 File Offset: 0x0006A110
			public unsafe static Il2CppSystem.Func<bool> __9__41_3
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_3, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SleepCanvas.__c.NativeFieldInfoPtr___9__41_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400955D RID: 38237
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400955E RID: 38238
			private static readonly System.IntPtr NativeFieldInfoPtr___9__41_1;

			// Token: 0x0400955F RID: 38239
			private static readonly System.IntPtr NativeFieldInfoPtr___9__41_2;

			// Token: 0x04009560 RID: 38240
			private static readonly System.IntPtr NativeFieldInfoPtr___9__41_3;

			// Token: 0x04009561 RID: 38241
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009562 RID: 38242
			private static readonly System.IntPtr NativeMethodInfoPtr__SleepStart_b__41_1_Internal_Boolean_0;

			// Token: 0x04009563 RID: 38243
			private static readonly System.IntPtr NativeMethodInfoPtr__SleepStart_b__41_2_Internal_Int32_IPostSleepEvent_0;

			// Token: 0x04009564 RID: 38244
			private static readonly System.IntPtr NativeMethodInfoPtr__SleepStart_b__41_3_Internal_Boolean_0;
		}

		// Token: 0x02000B93 RID: 2963
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE40 RID: 56896 RVA: 0x0034E240 File Offset: 0x0034C440
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, "pse");
				SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, 100681712);
				SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr, 100681713);
			}

			// Token: 0x0600DE41 RID: 56897 RVA: 0x0034E2A8 File Offset: 0x0034C4A8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass41_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE42 RID: 56898 RVA: 0x0034E2E4 File Offset: 0x0034C4E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266933, XrefRangeEnd = 266936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SleepStart_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass41_0.NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DE43 RID: 56899 RVA: 0x0006BF22 File Offset: 0x0006A122
			public __c__DisplayClass41_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A6 RID: 17574
			// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x0034E320 File Offset: 0x0034C520
			// (set) Token: 0x0600DE45 RID: 56901 RVA: 0x0006BF2B File Offset: 0x0006A12B
			public unsafe IPostSleepEvent pse
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPostSleepEvent>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass41_0.NativeFieldInfoPtr_pse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009565 RID: 38245
			private static readonly System.IntPtr NativeFieldInfoPtr_pse;

			// Token: 0x04009566 RID: 38246
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009567 RID: 38247
			private static readonly System.IntPtr NativeMethodInfoPtr__SleepStart_b__4_Internal_Boolean_0;
		}

		// Token: 0x02000B94 RID: 2964
		[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass42_0")]
		public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE46 RID: 56902 RVA: 0x0034E350 File Offset: 0x0034C550
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass42_0()
			{
				Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas>.NativeClassPtr, "<>c__DisplayClass42_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr);
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "<>4__this");
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "transparency");
				SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "lerpTime");
				SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, 100681714);
				SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, 100681715);
			}

			// Token: 0x0600DE47 RID: 56903 RVA: 0x0034E3E0 File Offset: 0x0034C5E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE48 RID: 56904 RVA: 0x0034E41C File Offset: 0x0034C61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266954, XrefRangeEnd = 266959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DE49 RID: 56905 RVA: 0x0006BF4A File Offset: 0x0006A14A
			public __c__DisplayClass42_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A7 RID: 17575
			// (get) Token: 0x0600DE4A RID: 56906 RVA: 0x0034E45C File Offset: 0x0034C65C
			// (set) Token: 0x0600DE4B RID: 56907 RVA: 0x0006BF53 File Offset: 0x0006A153
			public unsafe SleepCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A8 RID: 17576
			// (get) Token: 0x0600DE4C RID: 56908 RVA: 0x0034E48C File Offset: 0x0034C68C
			// (set) Token: 0x0600DE4D RID: 56909 RVA: 0x0006BF72 File Offset: 0x0006A172
			public unsafe float transparency
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_transparency)) = value;
				}
			}

			// Token: 0x170044A9 RID: 17577
			// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x0034E4B4 File Offset: 0x0034C6B4
			// (set) Token: 0x0600DE4F RID: 56911 RVA: 0x0006BF8D File Offset: 0x0006A18D
			public unsafe float lerpTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.NativeFieldInfoPtr_lerpTime)) = value;
				}
			}

			// Token: 0x04009568 RID: 38248
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009569 RID: 38249
			private static readonly System.IntPtr NativeFieldInfoPtr_transparency;

			// Token: 0x0400956A RID: 38250
			private static readonly System.IntPtr NativeFieldInfoPtr_lerpTime;

			// Token: 0x0400956B RID: 38251
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400956C RID: 38252
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD3 RID: 3283
			[ObfuscatedName("ScheduleOne.UI.SleepCanvas+<>c__DisplayClass42_0+<<LerpBlackOverlay>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB4D RID: 60237 RVA: 0x00373C6C File Offset: 0x00371E6C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique()
				{
					Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0>.NativeClassPtr, "<<LerpBlackOverlay>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>1__state");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>2__current");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<>4__this");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<startColor>5__2");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<endColor>5__3");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, "<i>5__4");
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681716);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681717);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681718);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681719);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681720);
					SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr, 100681721);
				}

				// Token: 0x0600EB4E RID: 60238 RVA: 0x00373D88 File Offset: 0x00371F88
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB4F RID: 60239 RVA: 0x00373DD0 File Offset: 0x00371FD0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB50 RID: 60240 RVA: 0x00373E04 File Offset: 0x00372004
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266936, XrefRangeEnd = 266949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048E1 RID: 18657
				// (get) Token: 0x0600EB51 RID: 60241 RVA: 0x00373E40 File Offset: 0x00372040
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB52 RID: 60242 RVA: 0x00373E80 File Offset: 0x00372080
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 266949, XrefRangeEnd = 266954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048E2 RID: 18658
				// (get) Token: 0x0600EB53 RID: 60243 RVA: 0x00373EB4 File Offset: 0x003720B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB54 RID: 60244 RVA: 0x00072775 File Offset: 0x00070975
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048DB RID: 18651
				// (get) Token: 0x0600EB55 RID: 60245 RVA: 0x00373EF4 File Offset: 0x003720F4
				// (set) Token: 0x0600EB56 RID: 60246 RVA: 0x0007277E File Offset: 0x0007097E
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048DC RID: 18652
				// (get) Token: 0x0600EB57 RID: 60247 RVA: 0x00373F1C File Offset: 0x0037211C
				// (set) Token: 0x0600EB58 RID: 60248 RVA: 0x00072799 File Offset: 0x00070999
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048DD RID: 18653
				// (get) Token: 0x0600EB59 RID: 60249 RVA: 0x00373F4C File Offset: 0x0037214C
				// (set) Token: 0x0600EB5A RID: 60250 RVA: 0x000727B8 File Offset: 0x000709B8
				public unsafe SleepCanvas.__c__DisplayClass42_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SleepCanvas.__c__DisplayClass42_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048DE RID: 18654
				// (get) Token: 0x0600EB5B RID: 60251 RVA: 0x00373F7C File Offset: 0x0037217C
				// (set) Token: 0x0600EB5C RID: 60252 RVA: 0x000727D7 File Offset: 0x000709D7
				public unsafe Color _startColor_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__startColor_5__2)) = value;
					}
				}

				// Token: 0x170048DF RID: 18655
				// (get) Token: 0x0600EB5D RID: 60253 RVA: 0x00373FA4 File Offset: 0x003721A4
				// (set) Token: 0x0600EB5E RID: 60254 RVA: 0x000727F2 File Offset: 0x000709F2
				public unsafe Color _endColor_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__endColor_5__3)) = value;
					}
				}

				// Token: 0x170048E0 RID: 18656
				// (get) Token: 0x0600EB5F RID: 60255 RVA: 0x00373FCC File Offset: 0x003721CC
				// (set) Token: 0x0600EB60 RID: 60256 RVA: 0x0007280D File Offset: 0x00070A0D
				public unsafe float _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SleepCanvas.__c__DisplayClass42_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObCoSiCoObObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009D5E RID: 40286
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D5F RID: 40287
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D60 RID: 40288
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D61 RID: 40289
				private static readonly System.IntPtr NativeFieldInfoPtr__startColor_5__2;

				// Token: 0x04009D62 RID: 40290
				private static readonly System.IntPtr NativeFieldInfoPtr__endColor_5__3;

				// Token: 0x04009D63 RID: 40291
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009D64 RID: 40292
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D65 RID: 40293
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D66 RID: 40294
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D67 RID: 40295
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D68 RID: 40296
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D69 RID: 40297
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
