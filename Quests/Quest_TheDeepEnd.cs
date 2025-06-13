using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001CE RID: 462
	public class Quest_TheDeepEnd : Quest
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x000EDF2C File Offset: 0x000EC12C
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_TheDeepEnd()
		{
			Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_TheDeepEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr);
			Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MEETING_REMINDER_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "KIDNAP_TIME");
			Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "kidnapQueued");
			Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "meetingSetup");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Thomas");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Gate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Gate");
			Quest_TheDeepEnd.NativeFieldInfoPtr_Switch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "Switch");
			Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "MeetingTeleportPoint");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingCall");
			Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "PostMeetingTrigger");
			Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667696);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667697);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667698);
			Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667699);
			Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667700);
			Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667701);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667702);
			Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667703);
			Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667704);
			Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, 100667705);
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x000EE0EC File Offset: 0x000EC2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120563, XrefRangeEnd = 120610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x000EE128 File Offset: 0x000EC328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120610, XrefRangeEnd = 120612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x000EE174 File Offset: 0x000EC374
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120625, RefRangeEnd = 120627, XrefRangeStart = 120612, XrefRangeEnd = 120625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupFirstMeeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x000EE1A8 File Offset: 0x000EC3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120627, XrefRangeEnd = 120650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThomasDialogueNodeDisplayed(string nodeLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(nodeLabel);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x000EE1EC File Offset: 0x000EC3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120650, XrefRangeEnd = 120676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x000EE220 File Offset: 0x000EC420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120676, XrefRangeEnd = 120683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeforeSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_BeforeSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x000EE254 File Offset: 0x000EC454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120683, XrefRangeEnd = 120696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepFadeOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_SleepFadeOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x000EE288 File Offset: 0x000EC488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120696, XrefRangeEnd = 120701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetQuestEntryState(int entryIndex, EQuestState state, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref entryIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref state;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_TheDeepEnd.NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000EE2F0 File Offset: 0x000EC4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120701, XrefRangeEnd = 120705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_TheDeepEnd() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x000EE32C File Offset: 0x000EC52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120705, XrefRangeEnd = 120710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000157F9 File Offset: 0x000139F9
		public Quest_TheDeepEnd(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x000EE36C File Offset: 0x000EC56C
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00015802 File Offset: 0x00013A02
		public unsafe static float MEETING_REMINDER_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_MEETING_REMINDER_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x000EE388 File Offset: 0x000EC588
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00015810 File Offset: 0x00013A10
		public unsafe static float KIDNAP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.NativeFieldInfoPtr_KIDNAP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x000EE3A4 File Offset: 0x000EC5A4
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x0001581E File Offset: 0x00013A1E
		public unsafe bool kidnapQueued
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_kidnapQueued)) = value;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000EE3CC File Offset: 0x000EC5CC
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00015839 File Offset: 0x00013A39
		public unsafe bool meetingSetup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_meetingSetup)) = value;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x000EE3F4 File Offset: 0x000EC5F4
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00015854 File Offset: 0x00013A54
		public unsafe Thomas Thomas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thomas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Thomas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x000EE424 File Offset: 0x000EC624
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00015873 File Offset: 0x00013A73
		public unsafe ManorGate Gate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManorGate>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Gate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x000EE454 File Offset: 0x000EC654
		// (set) Token: 0x0600271C RID: 10012 RVA: 0x00015892 File Offset: 0x00013A92
		public unsafe ModularSwitch Switch
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_Switch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600271D RID: 10013 RVA: 0x000EE484 File Offset: 0x000EC684
		// (set) Token: 0x0600271E RID: 10014 RVA: 0x000158B1 File Offset: 0x00013AB1
		public unsafe Transform MeetingTeleportPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_MeetingTeleportPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600271F RID: 10015 RVA: 0x000EE4B4 File Offset: 0x000EC6B4
		// (set) Token: 0x06002720 RID: 10016 RVA: 0x000158D0 File Offset: 0x00013AD0
		public unsafe PhoneCallData PostMeetingCall
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingCall), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002721 RID: 10017 RVA: 0x000EE4E4 File Offset: 0x000EC6E4
		// (set) Token: 0x06002722 RID: 10018 RVA: 0x000158EF File Offset: 0x00013AEF
		public unsafe SystemTriggerObject PostMeetingTrigger
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SystemTriggerObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.NativeFieldInfoPtr_PostMeetingTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019F6 RID: 6646
		private static readonly System.IntPtr NativeFieldInfoPtr_MEETING_REMINDER_TIME;

		// Token: 0x040019F7 RID: 6647
		private static readonly System.IntPtr NativeFieldInfoPtr_KIDNAP_TIME;

		// Token: 0x040019F8 RID: 6648
		private static readonly System.IntPtr NativeFieldInfoPtr_kidnapQueued;

		// Token: 0x040019F9 RID: 6649
		private static readonly System.IntPtr NativeFieldInfoPtr_meetingSetup;

		// Token: 0x040019FA RID: 6650
		private static readonly System.IntPtr NativeFieldInfoPtr_Thomas;

		// Token: 0x040019FB RID: 6651
		private static readonly System.IntPtr NativeFieldInfoPtr_Gate;

		// Token: 0x040019FC RID: 6652
		private static readonly System.IntPtr NativeFieldInfoPtr_Switch;

		// Token: 0x040019FD RID: 6653
		private static readonly System.IntPtr NativeFieldInfoPtr_MeetingTeleportPoint;

		// Token: 0x040019FE RID: 6654
		private static readonly System.IntPtr NativeFieldInfoPtr_PostMeetingCall;

		// Token: 0x040019FF RID: 6655
		private static readonly System.IntPtr NativeFieldInfoPtr_PostMeetingTrigger;

		// Token: 0x04001A00 RID: 6656
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupFirstMeeting_Public_Void_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly System.IntPtr NativeMethodInfoPtr_ThomasDialogueNodeDisplayed_Private_Void_String_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly System.IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly System.IntPtr NativeMethodInfoPtr_BeforeSleep_Private_Void_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepFadeOut_Private_Void_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly System.IntPtr NativeMethodInfoPtr_SetQuestEntryState_Public_Virtual_Void_Int32_EQuestState_Boolean_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000903 RID: 2307
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C874 RID: 51316 RVA: 0x003101B4 File Offset: 0x0030E3B4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<<ThomasDialogueNodeDisplayed>g__Wait|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>1__state");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>2__current");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, "<>4__this");
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667706);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667707);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667708);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667709);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667710);
				Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr, 100667711);
			}

			// Token: 0x0600C875 RID: 51317 RVA: 0x00310294 File Offset: 0x0030E494
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C876 RID: 51318 RVA: 0x003102DC File Offset: 0x0030E4DC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C877 RID: 51319 RVA: 0x00310310 File Offset: 0x0030E510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120528, XrefRangeEnd = 120549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E4A RID: 15946
			// (get) Token: 0x0600C878 RID: 51320 RVA: 0x0031034C File Offset: 0x0030E54C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C879 RID: 51321 RVA: 0x0031038C File Offset: 0x0030E58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120549, XrefRangeEnd = 120554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E4B RID: 15947
			// (get) Token: 0x0600C87A RID: 51322 RVA: 0x003103C0 File Offset: 0x0030E5C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C87B RID: 51323 RVA: 0x00061346 File Offset: 0x0005F546
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E47 RID: 15943
			// (get) Token: 0x0600C87C RID: 51324 RVA: 0x00310400 File Offset: 0x0030E600
			// (set) Token: 0x0600C87D RID: 51325 RVA: 0x0006134F File Offset: 0x0005F54F
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E48 RID: 15944
			// (get) Token: 0x0600C87E RID: 51326 RVA: 0x00310428 File Offset: 0x0030E628
			// (set) Token: 0x0600C87F RID: 51327 RVA: 0x0006136A File Offset: 0x0005F56A
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E49 RID: 15945
			// (get) Token: 0x0600C880 RID: 51328 RVA: 0x00310458 File Offset: 0x0030E658
			// (set) Token: 0x0600C881 RID: 51329 RVA: 0x00061389 File Offset: 0x0005F589
			public unsafe Quest_TheDeepEnd __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_TheDeepEnd.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObQuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087F9 RID: 34809
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087FA RID: 34810
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087FB RID: 34811
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087FC RID: 34812
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087FD RID: 34813
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087FE RID: 34814
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087FF RID: 34815
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008800 RID: 34816
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008801 RID: 34817
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000904 RID: 2308
		[ObfuscatedName("ScheduleOne.Quests.Quest_TheDeepEnd+<>c")]
		[System.Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C882 RID: 51330 RVA: 0x00310488 File Offset: 0x0030E688
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Quest_TheDeepEnd>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr);
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9");
				Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, "<>9__13_1");
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667713);
				Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr, 100667714);
			}

			// Token: 0x0600C883 RID: 51331 RVA: 0x00310504 File Offset: 0x0030E704
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_TheDeepEnd.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C884 RID: 51332 RVA: 0x00310540 File Offset: 0x0030E740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120554, XrefRangeEnd = 120563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ThomasDialogueNodeDisplayed_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest_TheDeepEnd.__c.NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C885 RID: 51333 RVA: 0x000613A8 File Offset: 0x0005F5A8
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E4C RID: 15948
			// (get) Token: 0x0600C886 RID: 51334 RVA: 0x0031057C File Offset: 0x0030E77C
			// (set) Token: 0x0600C887 RID: 51335 RVA: 0x000613B1 File Offset: 0x0005F5B1
			public unsafe static Quest_TheDeepEnd.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_TheDeepEnd.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E4D RID: 15949
			// (get) Token: 0x0600C888 RID: 51336 RVA: 0x003105A4 File Offset: 0x0030E7A4
			// (set) Token: 0x0600C889 RID: 51337 RVA: 0x000613C3 File Offset: 0x0005F5C3
			public unsafe static Il2CppSystem.Func<bool> __9__13_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Quest_TheDeepEnd.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008802 RID: 34818
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008803 RID: 34819
			private static readonly System.IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04008804 RID: 34820
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008805 RID: 34821
			private static readonly System.IntPtr NativeMethodInfoPtr__ThomasDialogueNodeDisplayed_b__13_1_Internal_Boolean_0;
		}
	}
}
