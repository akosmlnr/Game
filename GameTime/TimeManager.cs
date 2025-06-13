using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200019E RID: 414
	public class TimeManager : NetworkSingleton<TimeManager>
	{
		// Token: 0x06002131 RID: 8497 RVA: 0x000DAB90 File Offset: 0x000D8D90
		// Note: this type is marked as 'beforefieldinit'.
		static TimeManager()
		{
			Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TimeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr);
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "CYCLE_DURATION_MINS");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "MINUTE_TIME");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DEFAULT_WAKE_TIME");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "END_OF_DAY");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<SleepInProgress>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<ElapsedDays>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<CurrentTime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeOnCurrentMinute>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultDay");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "TimeProgressionMultiplier");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<DailyMinTotal>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<Playtime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "savedTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeOverridden>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onMinutePass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onHourPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onDayPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onWeekPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFixedUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeSkip");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTick");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFirstNight");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeChanged");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "SelectedWakeTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "sleepStartTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "sleepEndTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HostDailySummaryDone>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "defaultFixedTimeScale");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "loader");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667039);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667040);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667041);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667042);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667043);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667044);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667045);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667046);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667047);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667048);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667049);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667050);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667051);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667052);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667053);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667054);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667055);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667056);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667057);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667058);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667059);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667060);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667061);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667062);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667063);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667064);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667065);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667066);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667067);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667068);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667069);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667070);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667071);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667072);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667073);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667074);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667075);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667076);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667077);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667078);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667079);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667080);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667081);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667082);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667083);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667084);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Tick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667085);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667086);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667087);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667088);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667089);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667090);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667091);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667092);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667093);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667094);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667095);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667096);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667097);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667098);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667099);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667100);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667101);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667102);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667103);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_EndSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667104);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667105);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667106);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667107);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetRandomTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667108);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667109);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667110);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667111);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667112);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667113);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667114);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667115);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667116);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667117);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667118);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667119);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667120);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667121);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667122);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667123);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667124);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667125);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667126);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667127);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667128);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667129);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667130);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667131);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667132);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667133);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667134);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667135);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667136);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667137);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667138);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667139);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667140);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667141);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667142);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667143);
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x000DB714 File Offset: 0x000D9914
		public unsafe bool IsEndOfDay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 112884, RefRangeEnd = 112887, XrefRangeStart = 112884, XrefRangeEnd = 112884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000DB750 File Offset: 0x000D9950
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x000DB78C File Offset: 0x000D998C
		public unsafe bool SleepInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000DB7CC File Offset: 0x000D99CC
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x000DB808 File Offset: 0x000D9A08
		public unsafe int ElapsedDays
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000DB848 File Offset: 0x000D9A48
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x000DB884 File Offset: 0x000D9A84
		public unsafe int CurrentTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000DB8C4 File Offset: 0x000D9AC4
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x000DB900 File Offset: 0x000D9B00
		public unsafe float TimeOnCurrentMinute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 61709, RefRangeEnd = 61710, XrefRangeStart = 61709, XrefRangeEnd = 61710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000DB940 File Offset: 0x000D9B40
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x000DB97C File Offset: 0x000D9B7C
		public unsafe int DailyMinTotal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000DB9BC File Offset: 0x000D9BBC
		public unsafe bool IsNight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 112887, RefRangeEnd = 112889, XrefRangeStart = 112887, XrefRangeEnd = 112887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x000DB9F8 File Offset: 0x000D9BF8
		public unsafe int DayIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 112889, RefRangeEnd = 112895, XrefRangeStart = 112889, XrefRangeEnd = 112889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000DBA34 File Offset: 0x000D9C34
		public unsafe float NormalizedTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112895, RefRangeEnd = 112896, XrefRangeStart = 112895, XrefRangeEnd = 112895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002140 RID: 8512 RVA: 0x000DBA70 File Offset: 0x000D9C70
		// (set) Token: 0x06002141 RID: 8513 RVA: 0x000DBAAC File Offset: 0x000D9CAC
		public unsafe float Playtime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 112896, RefRangeEnd = 112897, XrefRangeStart = 112896, XrefRangeEnd = 112896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002142 RID: 8514 RVA: 0x000DBAEC File Offset: 0x000D9CEC
		public unsafe EDay CurrentDay
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 112889, RefRangeEnd = 112895, XrefRangeStart = 112889, XrefRangeEnd = 112895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000DBB28 File Offset: 0x000D9D28
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x000DBB64 File Offset: 0x000D9D64
		public unsafe bool TimeOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000DBBA4 File Offset: 0x000D9DA4
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x000DBBE0 File Offset: 0x000D9DE0
		public unsafe bool HostDailySummaryDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000DBC20 File Offset: 0x000D9E20
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112897, XrefRangeEnd = 112899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002148 RID: 8520 RVA: 0x000DBC58 File Offset: 0x000D9E58
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112899, XrefRangeEnd = 112901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000DBC90 File Offset: 0x000D9E90
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x000DBCD0 File Offset: 0x000D9ED0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000DBD0C File Offset: 0x000D9F0C
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x000DBD4C File Offset: 0x000D9F4C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112901, XrefRangeEnd = 112902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000DBD90 File Offset: 0x000D9F90
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x000DBDD0 File Offset: 0x000D9FD0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112902, XrefRangeEnd = 112903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000DBE14 File Offset: 0x000DA014
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x000DBE50 File Offset: 0x000DA050
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000DBE90 File Offset: 0x000DA090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112903, XrefRangeEnd = 112904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x000DBECC File Offset: 0x000DA0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112904, XrefRangeEnd = 112910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x000DBF08 File Offset: 0x000DA108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112910, XrefRangeEnd = 112913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x000DBF58 File Offset: 0x000DA158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112913, XrefRangeEnd = 112926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x000DBF94 File Offset: 0x000DA194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112926, XrefRangeEnd = 112943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x000DBFC8 File Offset: 0x000DA1C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112956, RefRangeEnd = 112958, XrefRangeStart = 112943, XrefRangeEnd = 112956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTimeData(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x000DC00C File Offset: 0x000DA20C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113008, RefRangeEnd = 113009, XrefRangeStart = 112958, XrefRangeEnd = 113008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _time;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x000DC078 File Offset: 0x000DA278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113009, XrefRangeEnd = 113081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x000DC0B4 File Offset: 0x000DA2B4
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113102, RefRangeEnd = 113103, XrefRangeStart = 113081, XrefRangeEnd = 113102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHostSleepDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000DC124 File Offset: 0x000DA324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113124, RefRangeEnd = 113125, XrefRangeStart = 113103, XrefRangeEnd = 113124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkHostSleepDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000DC158 File Offset: 0x000DA358
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 113147, RefRangeEnd = 113153, XrefRangeStart = 113125, XrefRangeEnd = 113147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHostSleepDone(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref done;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000DC198 File Offset: 0x000DA398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113153, XrefRangeEnd = 113158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TickLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x000DC1D8 File Offset: 0x000DA3D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113158, XrefRangeEnd = 113163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TimeLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x000DC218 File Offset: 0x000DA418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113163, XrefRangeEnd = 113168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StaggeredMinPass(float staggerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref staggerTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x000DC264 File Offset: 0x000DA464
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113215, RefRangeEnd = 113217, XrefRangeStart = 113168, XrefRangeEnd = 113215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Tick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x000DC298 File Offset: 0x000DA498
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 113231, RefRangeEnd = 113237, XrefRangeStart = 113217, XrefRangeEnd = 113231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(int _time, bool local = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref local;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x000DC2E4 File Offset: 0x000DA4E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113250, RefRangeEnd = 113251, XrefRangeStart = 113237, XrefRangeEnd = 113250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElapsedDays(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref days;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x000DC324 File Offset: 0x000DA524
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 113279, RefRangeEnd = 113299, XrefRangeStart = 113251, XrefRangeEnd = 113279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appendDesignator;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x000DC36C File Offset: 0x000DA56C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113299, RefRangeEnd = 113301, XrefRangeStart = 113299, XrefRangeEnd = 113299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get24HourTimeFromMinSum(int minSum)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref minSum;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x000DC3AC File Offset: 0x000DA5AC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 113301, RefRangeEnd = 113322, XrefRangeStart = 113301, XrefRangeEnd = 113301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinSumFrom24HourTime(int _time)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _time;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000DC3EC File Offset: 0x000DA5EC
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 113322, RefRangeEnd = 113363, XrefRangeStart = 113322, XrefRangeEnd = 113322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentTimeWithinRange(int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref max;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x000DC444 File Offset: 0x000DA644
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 113363, RefRangeEnd = 113374, XrefRangeStart = 113363, XrefRangeEnd = 113363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref givenTime;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref min;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref max;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x000DC4A0 File Offset: 0x000DA6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113380, RefRangeEnd = 113381, XrefRangeStart = 113374, XrefRangeEnd = 113380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid24HourTime(string input)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x000DC4E4 File Offset: 0x000DA6E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113381, RefRangeEnd = 113382, XrefRangeStart = 113381, XrefRangeEnd = 113381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref end;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x000DC53C File Offset: 0x000DA73C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113382, XrefRangeEnd = 113391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDayPassClientSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x000DC570 File Offset: 0x000DA770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113391, XrefRangeEnd = 113400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeWeekPassClientSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000DC5A4 File Offset: 0x000DA7A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113476, RefRangeEnd = 113477, XrefRangeStart = 113400, XrefRangeEnd = 113476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FastForwardToWakeTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000DC5D8 File Offset: 0x000DA7D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 113477, RefRangeEnd = 113483, XrefRangeStart = 113477, XrefRangeEnd = 113477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x000DC614 File Offset: 0x000DA814
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 113483, RefRangeEnd = 113487, XrefRangeStart = 113483, XrefRangeEnd = 113483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalMinSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x000DC650 File Offset: 0x000DA850
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 113487, RefRangeEnd = 113520, XrefRangeStart = 113487, XrefRangeEnd = 113487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref minsToAdd;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x000DC69C File Offset: 0x000DA89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113520, XrefRangeEnd = 113534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllTimeInRange(int min, int max)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref max;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000DC6EC File Offset: 0x000DA8EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113545, RefRangeEnd = 113547, XrefRangeStart = 113534, XrefRangeEnd = 113545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWakeTime(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000DC72C File Offset: 0x000DA92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113547, XrefRangeEnd = 113568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000DC760 File Offset: 0x000DA960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113568, XrefRangeEnd = 113589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_EndSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000DC794 File Offset: 0x000DA994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113589, XrefRangeEnd = 113595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000DC7D8 File Offset: 0x000DA9D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112896, RefRangeEnd = 112897, XrefRangeStart = 112896, XrefRangeEnd = 112897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlaytime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000DC818 File Offset: 0x000DAA18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113603, RefRangeEnd = 113604, XrefRangeStart = 113595, XrefRangeEnd = 113603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeOverridden(bool overridden, int time = 1200)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref overridden;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000DC864 File Offset: 0x000DAA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113604, XrefRangeEnd = 113606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetRandomTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000DC898 File Offset: 0x000DAA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113606, XrefRangeEnd = 113626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000DC8D4 File Offset: 0x000DAAD4
		[CallerCount(0)]
		public unsafe bool _TimeLoop_b__102_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000DC910 File Offset: 0x000DAB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113626, XrefRangeEnd = 113691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000DC94C File Offset: 0x000DAB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113691, XrefRangeEnd = 113694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000DC988 File Offset: 0x000DAB88
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000DC9C4 File Offset: 0x000DABC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113694, XrefRangeEnd = 113708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _time;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000DCA30 File Offset: 0x000DAC30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113715, RefRangeEnd = 113718, XrefRangeStart = 113708, XrefRangeEnd = 113715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _time;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000DCA9C File Offset: 0x000DAC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113718, XrefRangeEnd = 113726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000DCAEC File Offset: 0x000DACEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113726, XrefRangeEnd = 113740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _time;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref sendTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x000DCB58 File Offset: 0x000DAD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113740, XrefRangeEnd = 113748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x000DCBA8 File Offset: 0x000DADA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113748, XrefRangeEnd = 113757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000DCBDC File Offset: 0x000DADDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113757, XrefRangeEnd = 113758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResetHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000DCC10 File Offset: 0x000DAE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113758, XrefRangeEnd = 113761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ResetHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000DCC74 File Offset: 0x000DAE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113761, XrefRangeEnd = 113770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000DCCA8 File Offset: 0x000DAEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113770, XrefRangeEnd = 113771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000DCCDC File Offset: 0x000DAEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113771, XrefRangeEnd = 113774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000DCD40 File Offset: 0x000DAF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113774, XrefRangeEnd = 113784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref done;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000DCD80 File Offset: 0x000DAF80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113795, RefRangeEnd = 113797, XrefRangeStart = 113784, XrefRangeEnd = 113795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref done;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x000DCDC0 File Offset: 0x000DAFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113797, XrefRangeEnd = 113800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x000DCE10 File Offset: 0x000DB010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x000DCE44 File Offset: 0x000DB044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113800, XrefRangeEnd = 113801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x000DCE78 File Offset: 0x000DB078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113801, XrefRangeEnd = 113803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InvokeDayPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x000DCEC8 File Offset: 0x000DB0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x000DCEFC File Offset: 0x000DB0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113803, XrefRangeEnd = 113804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x000DCF30 File Offset: 0x000DB130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113804, XrefRangeEnd = 113806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x000DCF80 File Offset: 0x000DB180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 113545, RefRangeEnd = 113547, XrefRangeStart = 113545, XrefRangeEnd = 113547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x000DCFC0 File Offset: 0x000DB1C0
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetWakeTime_3316948804(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x000DD000 File Offset: 0x000DB200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113806, XrefRangeEnd = 113810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetWakeTime_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x000DD064 File Offset: 0x000DB264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113810, XrefRangeEnd = 113819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x000DD098 File Offset: 0x000DB298
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 113834, RefRangeEnd = 113839, XrefRangeStart = 113819, XrefRangeEnd = 113834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x000DD0CC File Offset: 0x000DB2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113839, XrefRangeEnd = 113842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x000DD11C File Offset: 0x000DB31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113842, XrefRangeEnd = 113851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x000DD150 File Offset: 0x000DB350
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 113876, RefRangeEnd = 113879, XrefRangeStart = 113851, XrefRangeEnd = 113876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x000DD184 File Offset: 0x000DB384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113879, XrefRangeEnd = 113882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x000DD1D4 File Offset: 0x000DB3D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 113930, RefRangeEnd = 113931, XrefRangeStart = 113882, XrefRangeEnd = 113930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x000128FD File Offset: 0x00010AFD
		public TimeManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x000DD210 File Offset: 0x000DB410
		// (set) Token: 0x0600219D RID: 8605 RVA: 0x00012906 File Offset: 0x00010B06
		public unsafe static float CYCLE_DURATION_MINS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600219E RID: 8606 RVA: 0x000DD22C File Offset: 0x000DB42C
		// (set) Token: 0x0600219F RID: 8607 RVA: 0x00012914 File Offset: 0x00010B14
		public unsafe static float MINUTE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x060021A0 RID: 8608 RVA: 0x000DD248 File Offset: 0x000DB448
		// (set) Token: 0x060021A1 RID: 8609 RVA: 0x00012922 File Offset: 0x00010B22
		public unsafe static int DEFAULT_WAKE_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x000DD264 File Offset: 0x000DB464
		// (set) Token: 0x060021A3 RID: 8611 RVA: 0x00012930 File Offset: 0x00010B30
		public unsafe static int END_OF_DAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY, (void*)(&value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x000DD280 File Offset: 0x000DB480
		// (set) Token: 0x060021A5 RID: 8613 RVA: 0x0001293E File Offset: 0x00010B3E
		public unsafe bool _SleepInProgress_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x060021A6 RID: 8614 RVA: 0x000DD2A8 File Offset: 0x000DB4A8
		// (set) Token: 0x060021A7 RID: 8615 RVA: 0x00012959 File Offset: 0x00010B59
		public unsafe int _ElapsedDays_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x000DD2D0 File Offset: 0x000DB4D0
		// (set) Token: 0x060021A9 RID: 8617 RVA: 0x00012974 File Offset: 0x00010B74
		public unsafe int _CurrentTime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x060021AA RID: 8618 RVA: 0x000DD2F8 File Offset: 0x000DB4F8
		// (set) Token: 0x060021AB RID: 8619 RVA: 0x0001298F File Offset: 0x00010B8F
		public unsafe float _TimeOnCurrentMinute_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x000DD320 File Offset: 0x000DB520
		// (set) Token: 0x060021AD RID: 8621 RVA: 0x000129AA File Offset: 0x00010BAA
		public unsafe int DefaultTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime)) = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x060021AE RID: 8622 RVA: 0x000DD348 File Offset: 0x000DB548
		// (set) Token: 0x060021AF RID: 8623 RVA: 0x000129C5 File Offset: 0x00010BC5
		public unsafe EDay DefaultDay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay)) = value;
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x060021B0 RID: 8624 RVA: 0x000DD370 File Offset: 0x000DB570
		// (set) Token: 0x060021B1 RID: 8625 RVA: 0x000129E0 File Offset: 0x00010BE0
		public unsafe float TimeProgressionMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier)) = value;
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060021B2 RID: 8626 RVA: 0x000DD398 File Offset: 0x000DB598
		// (set) Token: 0x060021B3 RID: 8627 RVA: 0x000129FB File Offset: 0x00010BFB
		public unsafe int _DailyMinTotal_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x000DD3C0 File Offset: 0x000DB5C0
		// (set) Token: 0x060021B5 RID: 8629 RVA: 0x00012A16 File Offset: 0x00010C16
		public unsafe float _Playtime_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060021B6 RID: 8630 RVA: 0x000DD3E8 File Offset: 0x000DB5E8
		// (set) Token: 0x060021B7 RID: 8631 RVA: 0x00012A31 File Offset: 0x00010C31
		public unsafe int savedTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime)) = value;
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060021B8 RID: 8632 RVA: 0x000DD410 File Offset: 0x000DB610
		// (set) Token: 0x060021B9 RID: 8633 RVA: 0x00012A4C File Offset: 0x00010C4C
		public unsafe bool _TimeOverridden_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060021BA RID: 8634 RVA: 0x000DD438 File Offset: 0x000DB638
		// (set) Token: 0x060021BB RID: 8635 RVA: 0x00012A67 File Offset: 0x00010C67
		public unsafe Il2CppSystem.Action onMinutePass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x000DD468 File Offset: 0x000DB668
		// (set) Token: 0x060021BD RID: 8637 RVA: 0x00012A86 File Offset: 0x00010C86
		public unsafe Il2CppSystem.Action onHourPass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x000DD498 File Offset: 0x000DB698
		// (set) Token: 0x060021BF RID: 8639 RVA: 0x00012AA5 File Offset: 0x00010CA5
		public unsafe Il2CppSystem.Action onDayPass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060021C0 RID: 8640 RVA: 0x000DD4C8 File Offset: 0x000DB6C8
		// (set) Token: 0x060021C1 RID: 8641 RVA: 0x00012AC4 File Offset: 0x00010CC4
		public unsafe Il2CppSystem.Action onWeekPass
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060021C2 RID: 8642 RVA: 0x000DD4F8 File Offset: 0x000DB6F8
		// (set) Token: 0x060021C3 RID: 8643 RVA: 0x00012AE3 File Offset: 0x00010CE3
		public unsafe Il2CppSystem.Action onUpdate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060021C4 RID: 8644 RVA: 0x000DD528 File Offset: 0x000DB728
		// (set) Token: 0x060021C5 RID: 8645 RVA: 0x00012B02 File Offset: 0x00010D02
		public unsafe Il2CppSystem.Action onFixedUpdate
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060021C6 RID: 8646 RVA: 0x000DD558 File Offset: 0x000DB758
		// (set) Token: 0x060021C7 RID: 8647 RVA: 0x00012B21 File Offset: 0x00010D21
		public unsafe Il2CppSystem.Action<int> onTimeSkip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060021C8 RID: 8648 RVA: 0x000DD588 File Offset: 0x000DB788
		// (set) Token: 0x060021C9 RID: 8649 RVA: 0x00012B40 File Offset: 0x00010D40
		public unsafe Il2CppSystem.Action onTick
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060021CA RID: 8650 RVA: 0x000DD5B8 File Offset: 0x000DB7B8
		// (set) Token: 0x060021CB RID: 8651 RVA: 0x00012B5F File Offset: 0x00010D5F
		public unsafe static Il2CppSystem.Action onSleepStart
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060021CC RID: 8652 RVA: 0x000DD5E0 File Offset: 0x000DB7E0
		// (set) Token: 0x060021CD RID: 8653 RVA: 0x00012B71 File Offset: 0x00010D71
		public unsafe UnityEvent _onSleepStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060021CE RID: 8654 RVA: 0x000DD610 File Offset: 0x000DB810
		// (set) Token: 0x060021CF RID: 8655 RVA: 0x00012B90 File Offset: 0x00010D90
		public unsafe static Il2CppSystem.Action<int> onSleepEnd
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060021D0 RID: 8656 RVA: 0x000DD638 File Offset: 0x000DB838
		// (set) Token: 0x060021D1 RID: 8657 RVA: 0x00012BA2 File Offset: 0x00010DA2
		public unsafe UnityEvent _onSleepEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060021D2 RID: 8658 RVA: 0x000DD668 File Offset: 0x000DB868
		// (set) Token: 0x060021D3 RID: 8659 RVA: 0x00012BC1 File Offset: 0x00010DC1
		public unsafe UnityEvent onFirstNight
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060021D4 RID: 8660 RVA: 0x000DD698 File Offset: 0x000DB898
		// (set) Token: 0x060021D5 RID: 8661 RVA: 0x00012BE0 File Offset: 0x00010DE0
		public unsafe Il2CppSystem.Action onTimeChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060021D6 RID: 8662 RVA: 0x000DD6C8 File Offset: 0x000DB8C8
		// (set) Token: 0x060021D7 RID: 8663 RVA: 0x00012BFF File Offset: 0x00010DFF
		public unsafe static int SelectedWakeTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime, (void*)(&value));
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060021D8 RID: 8664 RVA: 0x000DD6E4 File Offset: 0x000DB8E4
		// (set) Token: 0x060021D9 RID: 8665 RVA: 0x00012C0D File Offset: 0x00010E0D
		public unsafe GameDateTime sleepStartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime)) = value;
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060021DA RID: 8666 RVA: 0x000DD70C File Offset: 0x000DB90C
		// (set) Token: 0x060021DB RID: 8667 RVA: 0x00012C28 File Offset: 0x00010E28
		public unsafe int sleepEndTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime)) = value;
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x000DD734 File Offset: 0x000DB934
		// (set) Token: 0x060021DD RID: 8669 RVA: 0x00012C43 File Offset: 0x00010E43
		public unsafe bool _HostDailySummaryDone_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060021DE RID: 8670 RVA: 0x000DD75C File Offset: 0x000DB95C
		// (set) Token: 0x060021DF RID: 8671 RVA: 0x00012C5E File Offset: 0x00010E5E
		public unsafe float defaultFixedTimeScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale)) = value;
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060021E0 RID: 8672 RVA: 0x000DD784 File Offset: 0x000DB984
		// (set) Token: 0x060021E1 RID: 8673 RVA: 0x00012C79 File Offset: 0x00010E79
		public unsafe TimeLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060021E2 RID: 8674 RVA: 0x000DD7B4 File Offset: 0x000DB9B4
		// (set) Token: 0x060021E3 RID: 8675 RVA: 0x00012C98 File Offset: 0x00010E98
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060021E4 RID: 8676 RVA: 0x000DD7E4 File Offset: 0x000DB9E4
		// (set) Token: 0x060021E5 RID: 8677 RVA: 0x00012CB7 File Offset: 0x00010EB7
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060021E6 RID: 8678 RVA: 0x000DD814 File Offset: 0x000DBA14
		// (set) Token: 0x060021E7 RID: 8679 RVA: 0x00012CD6 File Offset: 0x00010ED6
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000DD83C File Offset: 0x000DBA3C
		// (set) Token: 0x060021E9 RID: 8681 RVA: 0x00012CF1 File Offset: 0x00010EF1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060021EA RID: 8682 RVA: 0x000DD864 File Offset: 0x000DBA64
		// (set) Token: 0x060021EB RID: 8683 RVA: 0x00012D0C File Offset: 0x00010F0C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400160A RID: 5642
		private static readonly System.IntPtr NativeFieldInfoPtr_CYCLE_DURATION_MINS;

		// Token: 0x0400160B RID: 5643
		private static readonly System.IntPtr NativeFieldInfoPtr_MINUTE_TIME;

		// Token: 0x0400160C RID: 5644
		private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_WAKE_TIME;

		// Token: 0x0400160D RID: 5645
		private static readonly System.IntPtr NativeFieldInfoPtr_END_OF_DAY;

		// Token: 0x0400160E RID: 5646
		private static readonly System.IntPtr NativeFieldInfoPtr__SleepInProgress_k__BackingField;

		// Token: 0x0400160F RID: 5647
		private static readonly System.IntPtr NativeFieldInfoPtr__ElapsedDays_k__BackingField;

		// Token: 0x04001610 RID: 5648
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentTime_k__BackingField;

		// Token: 0x04001611 RID: 5649
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField;

		// Token: 0x04001612 RID: 5650
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultTime;

		// Token: 0x04001613 RID: 5651
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultDay;

		// Token: 0x04001614 RID: 5652
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeProgressionMultiplier;

		// Token: 0x04001615 RID: 5653
		private static readonly System.IntPtr NativeFieldInfoPtr__DailyMinTotal_k__BackingField;

		// Token: 0x04001616 RID: 5654
		private static readonly System.IntPtr NativeFieldInfoPtr__Playtime_k__BackingField;

		// Token: 0x04001617 RID: 5655
		private static readonly System.IntPtr NativeFieldInfoPtr_savedTime;

		// Token: 0x04001618 RID: 5656
		private static readonly System.IntPtr NativeFieldInfoPtr__TimeOverridden_k__BackingField;

		// Token: 0x04001619 RID: 5657
		private static readonly System.IntPtr NativeFieldInfoPtr_onMinutePass;

		// Token: 0x0400161A RID: 5658
		private static readonly System.IntPtr NativeFieldInfoPtr_onHourPass;

		// Token: 0x0400161B RID: 5659
		private static readonly System.IntPtr NativeFieldInfoPtr_onDayPass;

		// Token: 0x0400161C RID: 5660
		private static readonly System.IntPtr NativeFieldInfoPtr_onWeekPass;

		// Token: 0x0400161D RID: 5661
		private static readonly System.IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x0400161E RID: 5662
		private static readonly System.IntPtr NativeFieldInfoPtr_onFixedUpdate;

		// Token: 0x0400161F RID: 5663
		private static readonly System.IntPtr NativeFieldInfoPtr_onTimeSkip;

		// Token: 0x04001620 RID: 5664
		private static readonly System.IntPtr NativeFieldInfoPtr_onTick;

		// Token: 0x04001621 RID: 5665
		private static readonly System.IntPtr NativeFieldInfoPtr_onSleepStart;

		// Token: 0x04001622 RID: 5666
		private static readonly System.IntPtr NativeFieldInfoPtr__onSleepStart;

		// Token: 0x04001623 RID: 5667
		private static readonly System.IntPtr NativeFieldInfoPtr_onSleepEnd;

		// Token: 0x04001624 RID: 5668
		private static readonly System.IntPtr NativeFieldInfoPtr__onSleepEnd;

		// Token: 0x04001625 RID: 5669
		private static readonly System.IntPtr NativeFieldInfoPtr_onFirstNight;

		// Token: 0x04001626 RID: 5670
		private static readonly System.IntPtr NativeFieldInfoPtr_onTimeChanged;

		// Token: 0x04001627 RID: 5671
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedWakeTime;

		// Token: 0x04001628 RID: 5672
		private static readonly System.IntPtr NativeFieldInfoPtr_sleepStartTime;

		// Token: 0x04001629 RID: 5673
		private static readonly System.IntPtr NativeFieldInfoPtr_sleepEndTime;

		// Token: 0x0400162A RID: 5674
		private static readonly System.IntPtr NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField;

		// Token: 0x0400162B RID: 5675
		private static readonly System.IntPtr NativeFieldInfoPtr_defaultFixedTimeScale;

		// Token: 0x0400162C RID: 5676
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400162D RID: 5677
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400162E RID: 5678
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400162F RID: 5679
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04001630 RID: 5680
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001631 RID: 5681
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001632 RID: 5682
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0;

		// Token: 0x04001633 RID: 5683
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0;

		// Token: 0x04001634 RID: 5684
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x04001635 RID: 5685
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0;

		// Token: 0x04001636 RID: 5686
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0;

		// Token: 0x04001637 RID: 5687
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0;

		// Token: 0x04001638 RID: 5688
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0;

		// Token: 0x04001639 RID: 5689
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0;

		// Token: 0x0400163A RID: 5690
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0;

		// Token: 0x0400163B RID: 5691
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0;

		// Token: 0x0400163C RID: 5692
		private static readonly System.IntPtr NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0;

		// Token: 0x0400163D RID: 5693
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0;

		// Token: 0x0400163E RID: 5694
		private static readonly System.IntPtr NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0;

		// Token: 0x0400163F RID: 5695
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0;

		// Token: 0x04001640 RID: 5696
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Playtime_Public_get_Single_0;

		// Token: 0x04001641 RID: 5697
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0;

		// Token: 0x04001642 RID: 5698
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0;

		// Token: 0x04001643 RID: 5699
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0;

		// Token: 0x04001644 RID: 5700
		private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0;

		// Token: 0x04001645 RID: 5701
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0;

		// Token: 0x04001646 RID: 5702
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0;

		// Token: 0x04001647 RID: 5703
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001648 RID: 5704
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001649 RID: 5705
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400164A RID: 5706
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400164B RID: 5707
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400164C RID: 5708
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400164D RID: 5709
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400164E RID: 5710
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400164F RID: 5711
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001650 RID: 5712
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001651 RID: 5713
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04001652 RID: 5714
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04001653 RID: 5715
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04001654 RID: 5716
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04001655 RID: 5717
		private static readonly System.IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x04001656 RID: 5718
		private static readonly System.IntPtr NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0;

		// Token: 0x04001657 RID: 5719
		private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001658 RID: 5720
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001659 RID: 5721
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x0400165A RID: 5722
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0;

		// Token: 0x0400165B RID: 5723
		private static readonly System.IntPtr NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0;

		// Token: 0x0400165C RID: 5724
		private static readonly System.IntPtr NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0;

		// Token: 0x0400165D RID: 5725
		private static readonly System.IntPtr NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0;

		// Token: 0x0400165E RID: 5726
		private static readonly System.IntPtr NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0;

		// Token: 0x0400165F RID: 5727
		private static readonly System.IntPtr NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0;

		// Token: 0x04001660 RID: 5728
		private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Private_Void_0;

		// Token: 0x04001661 RID: 5729
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0;

		// Token: 0x04001662 RID: 5730
		private static readonly System.IntPtr NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0;

		// Token: 0x04001663 RID: 5731
		private static readonly System.IntPtr NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0;

		// Token: 0x04001664 RID: 5732
		private static readonly System.IntPtr NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0;

		// Token: 0x04001665 RID: 5733
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0;

		// Token: 0x04001666 RID: 5734
		private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001667 RID: 5735
		private static readonly System.IntPtr NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04001668 RID: 5736
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0;

		// Token: 0x04001669 RID: 5737
		private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x0400166A RID: 5738
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0;

		// Token: 0x0400166B RID: 5739
		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0;

		// Token: 0x0400166C RID: 5740
		private static readonly System.IntPtr NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0;

		// Token: 0x0400166D RID: 5741
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0;

		// Token: 0x0400166E RID: 5742
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0;

		// Token: 0x0400166F RID: 5743
		private static readonly System.IntPtr NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001670 RID: 5744
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0;

		// Token: 0x04001671 RID: 5745
		private static readonly System.IntPtr NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0;

		// Token: 0x04001672 RID: 5746
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSleep_Private_Void_0;

		// Token: 0x04001673 RID: 5747
		private static readonly System.IntPtr NativeMethodInfoPtr_EndSleep_Private_Void_0;

		// Token: 0x04001674 RID: 5748
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04001675 RID: 5749
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0;

		// Token: 0x04001676 RID: 5750
		private static readonly System.IntPtr NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0;

		// Token: 0x04001677 RID: 5751
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomTime_Private_Void_0;

		// Token: 0x04001678 RID: 5752
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001679 RID: 5753
		private static readonly System.IntPtr NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0;

		// Token: 0x0400167A RID: 5754
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400167B RID: 5755
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400167C RID: 5756
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400167D RID: 5757
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x0400167E RID: 5758
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x0400167F RID: 5759
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001680 RID: 5760
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001681 RID: 5761
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001682 RID: 5762
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0;

		// Token: 0x04001683 RID: 5763
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0;

		// Token: 0x04001684 RID: 5764
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001685 RID: 5765
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0;

		// Token: 0x04001686 RID: 5766
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0;

		// Token: 0x04001687 RID: 5767
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001688 RID: 5768
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001689 RID: 5769
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x0400168A RID: 5770
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400168B RID: 5771
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0;

		// Token: 0x0400168C RID: 5772
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0;

		// Token: 0x0400168D RID: 5773
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400168E RID: 5774
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0;

		// Token: 0x0400168F RID: 5775
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001690 RID: 5776
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001691 RID: 5777
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0;

		// Token: 0x04001692 RID: 5778
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0;

		// Token: 0x04001693 RID: 5779
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001694 RID: 5780
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0;

		// Token: 0x04001695 RID: 5781
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0;

		// Token: 0x04001696 RID: 5782
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001697 RID: 5783
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0;

		// Token: 0x04001698 RID: 5784
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0;

		// Token: 0x04001699 RID: 5785
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400169A RID: 5786
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020008EA RID: 2282
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C78D RID: 51085 RVA: 0x0030D964 File Offset: 0x0030BB64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__101_0");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__102_1");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667145);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667146);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667147);
			}

			// Token: 0x0600C78E RID: 51086 RVA: 0x0030DA08 File Offset: 0x0030BC08
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C78F RID: 51087 RVA: 0x0030DA44 File Offset: 0x0030BC44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112762, XrefRangeEnd = 112763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TickLoop_b__101_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C790 RID: 51088 RVA: 0x0030DA80 File Offset: 0x0030BC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TimeLoop_b__102_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C791 RID: 51089 RVA: 0x00060C0D File Offset: 0x0005EE0D
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E03 RID: 15875
			// (get) Token: 0x0600C792 RID: 51090 RVA: 0x0030DABC File Offset: 0x0030BCBC
			// (set) Token: 0x0600C793 RID: 51091 RVA: 0x00060C16 File Offset: 0x0005EE16
			public unsafe static TimeManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E04 RID: 15876
			// (get) Token: 0x0600C794 RID: 51092 RVA: 0x0030DAE4 File Offset: 0x0030BCE4
			// (set) Token: 0x0600C795 RID: 51093 RVA: 0x00060C28 File Offset: 0x0005EE28
			public unsafe static Il2CppSystem.Func<bool> __9__101_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E05 RID: 15877
			// (get) Token: 0x0600C796 RID: 51094 RVA: 0x0030DB0C File Offset: 0x0030BD0C
			// (set) Token: 0x0600C797 RID: 51095 RVA: 0x00060C3A File Offset: 0x0005EE3A
			public unsafe static Il2CppSystem.Func<bool> __9__102_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008774 RID: 34676
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008775 RID: 34677
			private static readonly System.IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x04008776 RID: 34678
			private static readonly System.IntPtr NativeFieldInfoPtr___9__102_1;

			// Token: 0x04008777 RID: 34679
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008778 RID: 34680
			private static readonly System.IntPtr NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0;

			// Token: 0x04008779 RID: 34681
			private static readonly System.IntPtr NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0;
		}

		// Token: 0x020008EB RID: 2283
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C798 RID: 51096 RVA: 0x0030DB34 File Offset: 0x0030BD34
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "connection");
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667148);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667149);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667150);
			}

			// Token: 0x0600C799 RID: 51097 RVA: 0x0030DBC4 File Offset: 0x0030BDC4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C79A RID: 51098 RVA: 0x0030DC00 File Offset: 0x0030BE00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112780, XrefRangeEnd = 112785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C79B RID: 51099 RVA: 0x0030DC40 File Offset: 0x0030BE40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112785, XrefRangeEnd = 112793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SendTimeData_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600C79C RID: 51100 RVA: 0x00060C4C File Offset: 0x0005EE4C
			public __c__DisplayClass94_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E06 RID: 15878
			// (get) Token: 0x0600C79D RID: 51101 RVA: 0x0030DC7C File Offset: 0x0030BE7C
			// (set) Token: 0x0600C79E RID: 51102 RVA: 0x00060C55 File Offset: 0x0005EE55
			public unsafe NetworkConnection connection
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E07 RID: 15879
			// (get) Token: 0x0600C79F RID: 51103 RVA: 0x0030DCAC File Offset: 0x0030BEAC
			// (set) Token: 0x0600C7A0 RID: 51104 RVA: 0x00060C74 File Offset: 0x0005EE74
			public unsafe TimeManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400877A RID: 34682
			private static readonly System.IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x0400877B RID: 34683
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400877C RID: 34684
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400877D RID: 34685
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400877E RID: 34686
			private static readonly System.IntPtr NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0;

			// Token: 0x02000C8C RID: 3212
			[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c__DisplayClass94_0+<<SendTimeData>g__WaitForPlayerReady|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6D9 RID: 59097 RVA: 0x00366340 File Offset: 0x00364540
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "<<SendTimeData>g__WaitForPlayerReady|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667151);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667152);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667153);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667154);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667155);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667156);
				}

				// Token: 0x0600E6DA RID: 59098 RVA: 0x00366420 File Offset: 0x00364620
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6DB RID: 59099 RVA: 0x00366468 File Offset: 0x00364668
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E6DC RID: 59100 RVA: 0x0036649C File Offset: 0x0036469C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112763, XrefRangeEnd = 112775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004735 RID: 18229
				// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x003664D8 File Offset: 0x003646D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E6DE RID: 59102 RVA: 0x00366518 File Offset: 0x00364718
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112775, XrefRangeEnd = 112780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004736 RID: 18230
				// (get) Token: 0x0600E6DF RID: 59103 RVA: 0x0036654C File Offset: 0x0036474C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E6E0 RID: 59104 RVA: 0x000703F0 File Offset: 0x0006E5F0
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004732 RID: 18226
				// (get) Token: 0x0600E6E1 RID: 59105 RVA: 0x0036658C File Offset: 0x0036478C
				// (set) Token: 0x0600E6E2 RID: 59106 RVA: 0x000703F9 File Offset: 0x0006E5F9
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004733 RID: 18227
				// (get) Token: 0x0600E6E3 RID: 59107 RVA: 0x003665B4 File Offset: 0x003647B4
				// (set) Token: 0x0600E6E4 RID: 59108 RVA: 0x00070414 File Offset: 0x0006E614
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004734 RID: 18228
				// (get) Token: 0x0600E6E5 RID: 59109 RVA: 0x003665E4 File Offset: 0x003647E4
				// (set) Token: 0x0600E6E6 RID: 59110 RVA: 0x00070433 File Offset: 0x0006E633
				public unsafe TimeManager.__c__DisplayClass94_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c__DisplayClass94_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A9C RID: 39580
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A9D RID: 39581
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A9E RID: 39582
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A9F RID: 39583
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009AA0 RID: 39584
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AA1 RID: 39585
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009AA2 RID: 39586
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009AA3 RID: 39587
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009AA4 RID: 39588
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008EC RID: 2284
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<StaggeredMinPass>d__103")]
		public sealed class _StaggeredMinPass_d__103 : Il2CppSystem.Object
		{
			// Token: 0x0600C7A1 RID: 51105 RVA: 0x0030DCDC File Offset: 0x0030BEDC
			// Note: this type is marked as 'beforefieldinit'.
			static _StaggeredMinPass_d__103()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<StaggeredMinPass>d__103");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "staggerTime");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<listeners>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<perDelay>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<startTime>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<waitOverflow>5__5");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<timeOnWaitStart>5__6");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<loopsSinceLastWait>5__7");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<i>5__8");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667157);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667158);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667159);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667160);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667161);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667162);
			}

			// Token: 0x0600C7A2 RID: 51106 RVA: 0x0030DE5C File Offset: 0x0030C05C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StaggeredMinPass_d__103(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7A3 RID: 51107 RVA: 0x0030DEA4 File Offset: 0x0030C0A4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7A4 RID: 51108 RVA: 0x0030DED8 File Offset: 0x0030C0D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112793, XrefRangeEnd = 112820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E13 RID: 15891
			// (get) Token: 0x0600C7A5 RID: 51109 RVA: 0x0030DF14 File Offset: 0x0030C114
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C7A6 RID: 51110 RVA: 0x0030DF54 File Offset: 0x0030C154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112820, XrefRangeEnd = 112825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E14 RID: 15892
			// (get) Token: 0x0600C7A7 RID: 51111 RVA: 0x0030DF88 File Offset: 0x0030C188
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C7A8 RID: 51112 RVA: 0x00060C93 File Offset: 0x0005EE93
			public _StaggeredMinPass_d__103(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E08 RID: 15880
			// (get) Token: 0x0600C7A9 RID: 51113 RVA: 0x0030DFC8 File Offset: 0x0030C1C8
			// (set) Token: 0x0600C7AA RID: 51114 RVA: 0x00060C9C File Offset: 0x0005EE9C
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E09 RID: 15881
			// (get) Token: 0x0600C7AB RID: 51115 RVA: 0x0030DFF0 File Offset: 0x0030C1F0
			// (set) Token: 0x0600C7AC RID: 51116 RVA: 0x00060CB7 File Offset: 0x0005EEB7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E0A RID: 15882
			// (get) Token: 0x0600C7AD RID: 51117 RVA: 0x0030E020 File Offset: 0x0030C220
			// (set) Token: 0x0600C7AE RID: 51118 RVA: 0x00060CD6 File Offset: 0x0005EED6
			public unsafe TimeManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E0B RID: 15883
			// (get) Token: 0x0600C7AF RID: 51119 RVA: 0x0030E050 File Offset: 0x0030C250
			// (set) Token: 0x0600C7B0 RID: 51120 RVA: 0x00060CF5 File Offset: 0x0005EEF5
			public unsafe float staggerTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime)) = value;
				}
			}

			// Token: 0x17003E0C RID: 15884
			// (get) Token: 0x0600C7B1 RID: 51121 RVA: 0x0030E078 File Offset: 0x0030C278
			// (set) Token: 0x0600C7B2 RID: 51122 RVA: 0x00060D10 File Offset: 0x0005EF10
			public unsafe Il2CppReferenceArray<Il2CppSystem.Delegate> _listeners_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Delegate>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E0D RID: 15885
			// (get) Token: 0x0600C7B3 RID: 51123 RVA: 0x0030E0A8 File Offset: 0x0030C2A8
			// (set) Token: 0x0600C7B4 RID: 51124 RVA: 0x00060D2F File Offset: 0x0005EF2F
			public unsafe float _perDelay_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3)) = value;
				}
			}

			// Token: 0x17003E0E RID: 15886
			// (get) Token: 0x0600C7B5 RID: 51125 RVA: 0x0030E0D0 File Offset: 0x0030C2D0
			// (set) Token: 0x0600C7B6 RID: 51126 RVA: 0x00060D4A File Offset: 0x0005EF4A
			public unsafe float _startTime_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4)) = value;
				}
			}

			// Token: 0x17003E0F RID: 15887
			// (get) Token: 0x0600C7B7 RID: 51127 RVA: 0x0030E0F8 File Offset: 0x0030C2F8
			// (set) Token: 0x0600C7B8 RID: 51128 RVA: 0x00060D65 File Offset: 0x0005EF65
			public unsafe float _waitOverflow_5__5
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5)) = value;
				}
			}

			// Token: 0x17003E10 RID: 15888
			// (get) Token: 0x0600C7B9 RID: 51129 RVA: 0x0030E120 File Offset: 0x0030C320
			// (set) Token: 0x0600C7BA RID: 51130 RVA: 0x00060D80 File Offset: 0x0005EF80
			public unsafe float _timeOnWaitStart_5__6
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6)) = value;
				}
			}

			// Token: 0x17003E11 RID: 15889
			// (get) Token: 0x0600C7BB RID: 51131 RVA: 0x0030E148 File Offset: 0x0030C348
			// (set) Token: 0x0600C7BC RID: 51132 RVA: 0x00060D9B File Offset: 0x0005EF9B
			public unsafe int _loopsSinceLastWait_5__7
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7)) = value;
				}
			}

			// Token: 0x17003E12 RID: 15890
			// (get) Token: 0x0600C7BD RID: 51133 RVA: 0x0030E170 File Offset: 0x0030C370
			// (set) Token: 0x0600C7BE RID: 51134 RVA: 0x00060DB6 File Offset: 0x0005EFB6
			public unsafe int _i_5__8
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8)) = value;
				}
			}

			// Token: 0x0400877F RID: 34687
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008780 RID: 34688
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008781 RID: 34689
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008782 RID: 34690
			private static readonly System.IntPtr NativeFieldInfoPtr_staggerTime;

			// Token: 0x04008783 RID: 34691
			private static readonly System.IntPtr NativeFieldInfoPtr__listeners_5__2;

			// Token: 0x04008784 RID: 34692
			private static readonly System.IntPtr NativeFieldInfoPtr__perDelay_5__3;

			// Token: 0x04008785 RID: 34693
			private static readonly System.IntPtr NativeFieldInfoPtr__startTime_5__4;

			// Token: 0x04008786 RID: 34694
			private static readonly System.IntPtr NativeFieldInfoPtr__waitOverflow_5__5;

			// Token: 0x04008787 RID: 34695
			private static readonly System.IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__6;

			// Token: 0x04008788 RID: 34696
			private static readonly System.IntPtr NativeFieldInfoPtr__loopsSinceLastWait_5__7;

			// Token: 0x04008789 RID: 34697
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__8;

			// Token: 0x0400878A RID: 34698
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400878B RID: 34699
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400878C RID: 34700
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400878D RID: 34701
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400878E RID: 34702
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400878F RID: 34703
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008ED RID: 2285
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TickLoop>d__101")]
		public sealed class _TickLoop_d__101 : Il2CppSystem.Object
		{
			// Token: 0x0600C7BF RID: 51135 RVA: 0x0030E198 File Offset: 0x0030C398
			// Note: this type is marked as 'beforefieldinit'.
			static _TickLoop_d__101()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TickLoop>d__101");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667163);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667164);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667165);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667166);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667167);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667168);
			}

			// Token: 0x0600C7C0 RID: 51136 RVA: 0x0030E2B4 File Offset: 0x0030C4B4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TickLoop_d__101(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7C1 RID: 51137 RVA: 0x0030E2FC File Offset: 0x0030C4FC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7C2 RID: 51138 RVA: 0x0030E330 File Offset: 0x0030C530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112825, XrefRangeEnd = 112857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E1B RID: 15899
			// (get) Token: 0x0600C7C3 RID: 51139 RVA: 0x0030E36C File Offset: 0x0030C56C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C7C4 RID: 51140 RVA: 0x0030E3AC File Offset: 0x0030C5AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112857, XrefRangeEnd = 112862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E1C RID: 15900
			// (get) Token: 0x0600C7C5 RID: 51141 RVA: 0x0030E3E0 File Offset: 0x0030C5E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C7C6 RID: 51142 RVA: 0x00060DD1 File Offset: 0x0005EFD1
			public _TickLoop_d__101(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E15 RID: 15893
			// (get) Token: 0x0600C7C7 RID: 51143 RVA: 0x0030E420 File Offset: 0x0030C620
			// (set) Token: 0x0600C7C8 RID: 51144 RVA: 0x00060DDA File Offset: 0x0005EFDA
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E16 RID: 15894
			// (get) Token: 0x0600C7C9 RID: 51145 RVA: 0x0030E448 File Offset: 0x0030C648
			// (set) Token: 0x0600C7CA RID: 51146 RVA: 0x00060DF5 File Offset: 0x0005EFF5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E17 RID: 15895
			// (get) Token: 0x0600C7CB RID: 51147 RVA: 0x0030E478 File Offset: 0x0030C678
			// (set) Token: 0x0600C7CC RID: 51148 RVA: 0x00060E14 File Offset: 0x0005F014
			public unsafe TimeManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E18 RID: 15896
			// (get) Token: 0x0600C7CD RID: 51149 RVA: 0x0030E4A8 File Offset: 0x0030C6A8
			// (set) Token: 0x0600C7CE RID: 51150 RVA: 0x00060E33 File Offset: 0x0005F033
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17003E19 RID: 15897
			// (get) Token: 0x0600C7CF RID: 51151 RVA: 0x0030E4D0 File Offset: 0x0030C6D0
			// (set) Token: 0x0600C7D0 RID: 51152 RVA: 0x00060E4E File Offset: 0x0005F04E
			public unsafe float _timeToWait_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17003E1A RID: 15898
			// (get) Token: 0x0600C7D1 RID: 51153 RVA: 0x0030E4F8 File Offset: 0x0030C6F8
			// (set) Token: 0x0600C7D2 RID: 51154 RVA: 0x00060E69 File Offset: 0x0005F069
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x04008790 RID: 34704
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008791 RID: 34705
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008792 RID: 34706
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008793 RID: 34707
			private static readonly System.IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x04008794 RID: 34708
			private static readonly System.IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x04008795 RID: 34709
			private static readonly System.IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x04008796 RID: 34710
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008797 RID: 34711
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008798 RID: 34712
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008799 RID: 34713
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400879A RID: 34714
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400879B RID: 34715
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008EE RID: 2286
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TimeLoop>d__102")]
		public sealed class _TimeLoop_d__102 : Il2CppSystem.Object
		{
			// Token: 0x0600C7D3 RID: 51155 RVA: 0x0030E520 File Offset: 0x0030C720
			// Note: this type is marked as 'beforefieldinit'.
			static _TimeLoop_d__102()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeLoop>d__102");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667169);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667170);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667171);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667172);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667173);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667174);
			}

			// Token: 0x0600C7D4 RID: 51156 RVA: 0x0030E63C File Offset: 0x0030C83C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TimeLoop_d__102(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7D5 RID: 51157 RVA: 0x0030E684 File Offset: 0x0030C884
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C7D6 RID: 51158 RVA: 0x0030E6B8 File Offset: 0x0030C8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112862, XrefRangeEnd = 112879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17003E23 RID: 15907
			// (get) Token: 0x0600C7D7 RID: 51159 RVA: 0x0030E6F4 File Offset: 0x0030C8F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C7D8 RID: 51160 RVA: 0x0030E734 File Offset: 0x0030C934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112879, XrefRangeEnd = 112884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17003E24 RID: 15908
			// (get) Token: 0x0600C7D9 RID: 51161 RVA: 0x0030E768 File Offset: 0x0030C968
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600C7DA RID: 51162 RVA: 0x00060E84 File Offset: 0x0005F084
			public _TimeLoop_d__102(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E1D RID: 15901
			// (get) Token: 0x0600C7DB RID: 51163 RVA: 0x0030E7A8 File Offset: 0x0030C9A8
			// (set) Token: 0x0600C7DC RID: 51164 RVA: 0x00060E8D File Offset: 0x0005F08D
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E1E RID: 15902
			// (get) Token: 0x0600C7DD RID: 51165 RVA: 0x0030E7D0 File Offset: 0x0030C9D0
			// (set) Token: 0x0600C7DE RID: 51166 RVA: 0x00060EA8 File Offset: 0x0005F0A8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E1F RID: 15903
			// (get) Token: 0x0600C7DF RID: 51167 RVA: 0x0030E800 File Offset: 0x0030CA00
			// (set) Token: 0x0600C7E0 RID: 51168 RVA: 0x00060EC7 File Offset: 0x0005F0C7
			public unsafe TimeManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E20 RID: 15904
			// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x0030E830 File Offset: 0x0030CA30
			// (set) Token: 0x0600C7E2 RID: 51170 RVA: 0x00060EE6 File Offset: 0x0005F0E6
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17003E21 RID: 15905
			// (get) Token: 0x0600C7E3 RID: 51171 RVA: 0x0030E858 File Offset: 0x0030CA58
			// (set) Token: 0x0600C7E4 RID: 51172 RVA: 0x00060F01 File Offset: 0x0005F101
			public unsafe float _timeToWait_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17003E22 RID: 15906
			// (get) Token: 0x0600C7E5 RID: 51173 RVA: 0x0030E880 File Offset: 0x0030CA80
			// (set) Token: 0x0600C7E6 RID: 51174 RVA: 0x00060F1C File Offset: 0x0005F11C
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x0400879C RID: 34716
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400879D RID: 34717
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400879E RID: 34718
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400879F RID: 34719
			private static readonly System.IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x040087A0 RID: 34720
			private static readonly System.IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x040087A1 RID: 34721
			private static readonly System.IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x040087A2 RID: 34722
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087A3 RID: 34723
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087A4 RID: 34724
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087A5 RID: 34725
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087A6 RID: 34726
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087A7 RID: 34727
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
