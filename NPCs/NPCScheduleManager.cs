using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002FD RID: 765
	public class NPCScheduleManager : MonoBehaviour
	{
		// Token: 0x06003783 RID: 14211 RVA: 0x00126CC4 File Offset: 0x00124EC4
		// Note: this type is marked as 'beforefieldinit'.
		static NPCScheduleManager()
		{
			Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCScheduleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr);
			NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ScheduleEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<CurfewModeEnabled>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "DEBUG_MODE");
			NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActiveAction>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<PendingActions>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<Npc>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "EnabledDuringNoCurfew");
			NPCScheduleManager.NativeFieldInfoPtr_ActionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "ActionList");
			NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<ActionsAwaitingStart>k__BackingField");
			NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "lastProcessedTime");
			NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669692);
			NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669693);
			NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669694);
			NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669695);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669696);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669697);
			NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669698);
			NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669699);
			NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669700);
			NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669701);
			NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669702);
			NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669703);
			NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669704);
			NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669705);
			NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669706);
			NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669707);
			NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669708);
			NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669709);
			NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669710);
			NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669711);
			NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669712);
			NPCScheduleManager.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669713);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669714);
			NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669715);
			NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669716);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669717);
			NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669718);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669719);
			NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669720);
			NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669721);
			NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, 100669722);
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06003784 RID: 14212 RVA: 0x0012703C File Offset: 0x0012523C
		// (set) Token: 0x06003785 RID: 14213 RVA: 0x00127078 File Offset: 0x00125278
		public unsafe bool ScheduleEnabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06003786 RID: 14214 RVA: 0x001270B8 File Offset: 0x001252B8
		// (set) Token: 0x06003787 RID: 14215 RVA: 0x001270F4 File Offset: 0x001252F4
		public unsafe bool CurfewModeEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06003788 RID: 14216 RVA: 0x00127134 File Offset: 0x00125334
		// (set) Token: 0x06003789 RID: 14217 RVA: 0x00127174 File Offset: 0x00125374
		public unsafe NPCAction ActiveAction
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600378A RID: 14218 RVA: 0x001271B8 File Offset: 0x001253B8
		// (set) Token: 0x0600378B RID: 14219 RVA: 0x001271F8 File Offset: 0x001253F8
		public unsafe List<NPCAction> PendingActions
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600378C RID: 14220 RVA: 0x0012723C File Offset: 0x0012543C
		// (set) Token: 0x0600378D RID: 14221 RVA: 0x0012727C File Offset: 0x0012547C
		public unsafe NPC Npc
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600378E RID: 14222 RVA: 0x001272C0 File Offset: 0x001254C0
		// (set) Token: 0x0600378F RID: 14223 RVA: 0x00127300 File Offset: 0x00125500
		public unsafe List<NPCAction> ActionsAwaitingStart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003790 RID: 14224 RVA: 0x00127344 File Offset: 0x00125544
		public unsafe TimeManager Time
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 143920, RefRangeEnd = 143924, XrefRangeStart = 143917, XrefRangeEnd = 143920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
			}
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x00127384 File Offset: 0x00125584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143924, XrefRangeEnd = 143929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003792 RID: 14226 RVA: 0x001273C0 File Offset: 0x001255C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143929, XrefRangeEnd = 144017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003793 RID: 14227 RVA: 0x001273FC File Offset: 0x001255FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144017, XrefRangeEnd = 144019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003794 RID: 14228 RVA: 0x00127430 File Offset: 0x00125630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144019, XrefRangeEnd = 144023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003795 RID: 14229 RVA: 0x00127464 File Offset: 0x00125664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144023, XrefRangeEnd = 144027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003796 RID: 14230 RVA: 0x001274A0 File Offset: 0x001256A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144027, RefRangeEnd = 144029, XrefRangeStart = 144027, XrefRangeEnd = 144027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003797 RID: 14231 RVA: 0x001274D4 File Offset: 0x001256D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144033, RefRangeEnd = 144035, XrefRangeStart = 144029, XrefRangeEnd = 144033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSchedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_DisableSchedule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00127508 File Offset: 0x00125708
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 144088, RefRangeEnd = 144091, XrefRangeStart = 144035, XrefRangeEnd = 144088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_InitializeActions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003799 RID: 14233 RVA: 0x0012753C File Offset: 0x0012573C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144091, XrefRangeEnd = 144183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600379A RID: 14234 RVA: 0x00127578 File Offset: 0x00125778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144233, RefRangeEnd = 144235, XrefRangeStart = 144183, XrefRangeEnd = 144233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsOccurringAt(int time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x001275C4 File Offset: 0x001257C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144281, RefRangeEnd = 144283, XrefRangeStart = 144235, XrefRangeEnd = 144281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref max;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref checkShouldStart;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
		}

		// Token: 0x0600379C RID: 14236 RVA: 0x0012762C File Offset: 0x0012582C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144304, RefRangeEnd = 144305, XrefRangeStart = 144283, XrefRangeEnd = 144304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction(NPCAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600379D RID: 14237 RVA: 0x00127670 File Offset: 0x00125870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144305, XrefRangeEnd = 144311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600379E RID: 14238 RVA: 0x001276A4 File Offset: 0x001258A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144413, RefRangeEnd = 144415, XrefRangeStart = 144311, XrefRangeEnd = 144413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnforceState(bool initial = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref initial;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600379F RID: 14239 RVA: 0x001276E4 File Offset: 0x001258E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144415, XrefRangeEnd = 144416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00127720 File Offset: 0x00125920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144416, XrefRangeEnd = 144417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurfewDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCScheduleManager.NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037A1 RID: 14241 RVA: 0x0012775C File Offset: 0x0012595C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 144423, RefRangeEnd = 144426, XrefRangeStart = 144417, XrefRangeEnd = 144423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurfewModeEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x0012779C File Offset: 0x0012599C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144426, XrefRangeEnd = 144444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCScheduleManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x0001CE5C File Offset: 0x0001B05C
		public NPCScheduleManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060037A4 RID: 14244 RVA: 0x001277D8 File Offset: 0x001259D8
		// (set) Token: 0x060037A5 RID: 14245 RVA: 0x0001CE65 File Offset: 0x0001B065
		public unsafe bool _ScheduleEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ScheduleEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060037A6 RID: 14246 RVA: 0x00127800 File Offset: 0x00125A00
		// (set) Token: 0x060037A7 RID: 14247 RVA: 0x0001CE80 File Offset: 0x0001B080
		public unsafe bool _CurfewModeEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060037A8 RID: 14248 RVA: 0x00127828 File Offset: 0x00125A28
		// (set) Token: 0x060037A9 RID: 14249 RVA: 0x0001CE9B File Offset: 0x0001B09B
		public unsafe bool DEBUG_MODE
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x060037AA RID: 14250 RVA: 0x00127850 File Offset: 0x00125A50
		// (set) Token: 0x060037AB RID: 14251 RVA: 0x0001CEB6 File Offset: 0x0001B0B6
		public unsafe NPCAction _ActiveAction_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCAction>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActiveAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x060037AC RID: 14252 RVA: 0x00127880 File Offset: 0x00125A80
		// (set) Token: 0x060037AD RID: 14253 RVA: 0x0001CED5 File Offset: 0x0001B0D5
		public unsafe List<NPCAction> _PendingActions_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__PendingActions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x060037AE RID: 14254 RVA: 0x001278B0 File Offset: 0x00125AB0
		// (set) Token: 0x060037AF RID: 14255 RVA: 0x0001CEF4 File Offset: 0x0001B0F4
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x060037B0 RID: 14256 RVA: 0x001278E0 File Offset: 0x00125AE0
		// (set) Token: 0x060037B1 RID: 14257 RVA: 0x0001CF13 File Offset: 0x0001B113
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringCurfew
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x060037B2 RID: 14258 RVA: 0x00127910 File Offset: 0x00125B10
		// (set) Token: 0x060037B3 RID: 14259 RVA: 0x0001CF32 File Offset: 0x0001B132
		public unsafe Il2CppReferenceArray<GameObject> EnabledDuringNoCurfew
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_EnabledDuringNoCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x060037B4 RID: 14260 RVA: 0x00127940 File Offset: 0x00125B40
		// (set) Token: 0x060037B5 RID: 14261 RVA: 0x0001CF51 File Offset: 0x0001B151
		public unsafe List<NPCAction> ActionList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_ActionList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_ActionList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x060037B6 RID: 14262 RVA: 0x00127970 File Offset: 0x00125B70
		// (set) Token: 0x060037B7 RID: 14263 RVA: 0x0001CF70 File Offset: 0x0001B170
		public unsafe List<NPCAction> _ActionsAwaitingStart_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x060037B8 RID: 14264 RVA: 0x001279A0 File Offset: 0x00125BA0
		// (set) Token: 0x060037B9 RID: 14265 RVA: 0x0001CF8F File Offset: 0x0001B18F
		public unsafe int lastProcessedTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.NativeFieldInfoPtr_lastProcessedTime)) = value;
			}
		}

		// Token: 0x0400244E RID: 9294
		private static readonly System.IntPtr NativeFieldInfoPtr__ScheduleEnabled_k__BackingField;

		// Token: 0x0400244F RID: 9295
		private static readonly System.IntPtr NativeFieldInfoPtr__CurfewModeEnabled_k__BackingField;

		// Token: 0x04002450 RID: 9296
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04002451 RID: 9297
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveAction_k__BackingField;

		// Token: 0x04002452 RID: 9298
		private static readonly System.IntPtr NativeFieldInfoPtr__PendingActions_k__BackingField;

		// Token: 0x04002453 RID: 9299
		private static readonly System.IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04002454 RID: 9300
		private static readonly System.IntPtr NativeFieldInfoPtr_EnabledDuringCurfew;

		// Token: 0x04002455 RID: 9301
		private static readonly System.IntPtr NativeFieldInfoPtr_EnabledDuringNoCurfew;

		// Token: 0x04002456 RID: 9302
		private static readonly System.IntPtr NativeFieldInfoPtr_ActionList;

		// Token: 0x04002457 RID: 9303
		private static readonly System.IntPtr NativeFieldInfoPtr__ActionsAwaitingStart_k__BackingField;

		// Token: 0x04002458 RID: 9304
		private static readonly System.IntPtr NativeFieldInfoPtr_lastProcessedTime;

		// Token: 0x04002459 RID: 9305
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ScheduleEnabled_Public_get_Boolean_0;

		// Token: 0x0400245A RID: 9306
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ScheduleEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400245B RID: 9307
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurfewModeEnabled_Public_get_Boolean_0;

		// Token: 0x0400245C RID: 9308
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurfewModeEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x0400245D RID: 9309
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveAction_Public_get_NPCAction_0;

		// Token: 0x0400245E RID: 9310
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveAction_Public_set_Void_NPCAction_0;

		// Token: 0x0400245F RID: 9311
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PendingActions_Public_get_List_1_NPCAction_0;

		// Token: 0x04002460 RID: 9312
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PendingActions_Public_set_Void_List_1_NPCAction_0;

		// Token: 0x04002461 RID: 9313
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04002462 RID: 9314
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Npc_Protected_set_Void_NPC_0;

		// Token: 0x04002463 RID: 9315
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionsAwaitingStart_Protected_get_List_1_NPCAction_0;

		// Token: 0x04002464 RID: 9316
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActionsAwaitingStart_Protected_set_Void_List_1_NPCAction_0;

		// Token: 0x04002465 RID: 9317
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Time_Protected_get_TimeManager_0;

		// Token: 0x04002466 RID: 9318
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04002467 RID: 9319
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002468 RID: 9320
		private static readonly System.IntPtr NativeMethodInfoPtr_LocalPlayerSpawned_Private_Void_0;

		// Token: 0x04002469 RID: 9321
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400246A RID: 9322
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400246B RID: 9323
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableSchedule_Public_Void_0;

		// Token: 0x0400246C RID: 9324
		private static readonly System.IntPtr NativeMethodInfoPtr_DisableSchedule_Public_Void_0;

		// Token: 0x0400246D RID: 9325
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeActions_Public_Void_0;

		// Token: 0x0400246E RID: 9326
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x0400246F RID: 9327
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionsOccurringAt_Private_List_1_NPCAction_Int32_0;

		// Token: 0x04002470 RID: 9328
		private static readonly System.IntPtr NativeMethodInfoPtr_GetActionsTotallyOccurringWithinRange_Private_List_1_NPCAction_Int32_Int32_Boolean_0;

		// Token: 0x04002471 RID: 9329
		private static readonly System.IntPtr NativeMethodInfoPtr_StartAction_Private_Void_NPCAction_0;

		// Token: 0x04002472 RID: 9330
		private static readonly System.IntPtr NativeMethodInfoPtr_EnforceState_Private_Void_0;

		// Token: 0x04002473 RID: 9331
		private static readonly System.IntPtr NativeMethodInfoPtr_EnforceState_Public_Void_Boolean_0;

		// Token: 0x04002474 RID: 9332
		private static readonly System.IntPtr NativeMethodInfoPtr_CurfewEnabled_Protected_Virtual_New_Void_0;

		// Token: 0x04002475 RID: 9333
		private static readonly System.IntPtr NativeMethodInfoPtr_CurfewDisabled_Protected_Virtual_New_Void_0;

		// Token: 0x04002476 RID: 9334
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCurfewModeEnabled_Public_Void_Boolean_0;

		// Token: 0x04002477 RID: 9335
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000976 RID: 2422
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CBB4 RID: 52148 RVA: 0x003192F8 File Offset: 0x003174F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr);
				NPCScheduleManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__38_0");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__40_0");
				NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, "<>9__41_0");
				NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669724);
				NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669725);
				NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669726);
				NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr, 100669727);
			}

			// Token: 0x0600CBB5 RID: 52149 RVA: 0x003193C4 File Offset: 0x003175C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBB6 RID: 52150 RVA: 0x00319400 File Offset: 0x00317600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143909, XrefRangeEnd = 143911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _InitializeActions_b__38_0(NPCAction a, NPCAction b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBB7 RID: 52151 RVA: 0x00319460 File Offset: 0x00317660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143911, XrefRangeEnd = 143912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActionsOccurringAt_b__40_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBB8 RID: 52152 RVA: 0x003194B0 File Offset: 0x003176B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActionsTotallyOccurringWithinRange_b__41_0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c.NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBB9 RID: 52153 RVA: 0x00062D71 File Offset: 0x00060F71
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F25 RID: 16165
			// (get) Token: 0x0600CBBA RID: 52154 RVA: 0x00319500 File Offset: 0x00317700
			// (set) Token: 0x0600CBBB RID: 52155 RVA: 0x00062D7A File Offset: 0x00060F7A
			public unsafe static NPCScheduleManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F26 RID: 16166
			// (get) Token: 0x0600CBBC RID: 52156 RVA: 0x00319528 File Offset: 0x00317728
			// (set) Token: 0x0600CBBD RID: 52157 RVA: 0x00062D8C File Offset: 0x00060F8C
			public unsafe static Il2CppSystem.Comparison<NPCAction> __9__38_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<NPCAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F27 RID: 16167
			// (get) Token: 0x0600CBBE RID: 52158 RVA: 0x00319550 File Offset: 0x00317750
			// (set) Token: 0x0600CBBF RID: 52159 RVA: 0x00062D9E File Offset: 0x00060F9E
			public unsafe static Il2CppSystem.Func<NPCAction, int> __9__40_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPCAction, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__40_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F28 RID: 16168
			// (get) Token: 0x0600CBC0 RID: 52160 RVA: 0x00319578 File Offset: 0x00317778
			// (set) Token: 0x0600CBC1 RID: 52161 RVA: 0x00062DB0 File Offset: 0x00060FB0
			public unsafe static Il2CppSystem.Func<NPCAction, int> __9__41_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<NPCAction, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCScheduleManager.__c.NativeFieldInfoPtr___9__41_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089EC RID: 35308
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040089ED RID: 35309
			private static readonly System.IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x040089EE RID: 35310
			private static readonly System.IntPtr NativeFieldInfoPtr___9__40_0;

			// Token: 0x040089EF RID: 35311
			private static readonly System.IntPtr NativeFieldInfoPtr___9__41_0;

			// Token: 0x040089F0 RID: 35312
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089F1 RID: 35313
			private static readonly System.IntPtr NativeMethodInfoPtr__InitializeActions_b__38_0_Internal_Int32_NPCAction_NPCAction_0;

			// Token: 0x040089F2 RID: 35314
			private static readonly System.IntPtr NativeMethodInfoPtr__GetActionsOccurringAt_b__40_0_Internal_Int32_NPCAction_0;

			// Token: 0x040089F3 RID: 35315
			private static readonly System.IntPtr NativeMethodInfoPtr__GetActionsTotallyOccurringWithinRange_b__41_0_Internal_Int32_NPCAction_0;
		}

		// Token: 0x02000977 RID: 2423
		[ObfuscatedName("ScheduleOne.NPCs.NPCScheduleManager+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CBC2 RID: 52162 RVA: 0x003195A0 File Offset: 0x003177A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCScheduleManager>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr);
				NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, "actionsOccurringThisFrame");
				NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, "skippedActionOrder");
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669728);
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669729);
				NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr, 100669730);
			}

			// Token: 0x0600CBC3 RID: 52163 RVA: 0x00319630 File Offset: 0x00317830
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCScheduleManager.__c__DisplayClass44_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CBC4 RID: 52164 RVA: 0x0031966C File Offset: 0x0031786C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143912, XrefRangeEnd = 143913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EnforceState_b__0(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBC5 RID: 52165 RVA: 0x003196BC File Offset: 0x003178BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143913, XrefRangeEnd = 143917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _EnforceState_b__1(NPCAction x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NPCScheduleManager.__c__DisplayClass44_0.NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CBC6 RID: 52166 RVA: 0x00062DC2 File Offset: 0x00060FC2
			public __c__DisplayClass44_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F29 RID: 16169
			// (get) Token: 0x0600CBC7 RID: 52167 RVA: 0x0031970C File Offset: 0x0031790C
			// (set) Token: 0x0600CBC8 RID: 52168 RVA: 0x00062DCB File Offset: 0x00060FCB
			public unsafe List<NPCAction> actionsOccurringThisFrame
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPCAction>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_actionsOccurringThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F2A RID: 16170
			// (get) Token: 0x0600CBC9 RID: 52169 RVA: 0x0031973C File Offset: 0x0031793C
			// (set) Token: 0x0600CBCA RID: 52170 RVA: 0x00062DEA File Offset: 0x00060FEA
			public unsafe Dictionary<NPCAction, float> skippedActionOrder
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NPCAction, float>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(NPCScheduleManager.__c__DisplayClass44_0.NativeFieldInfoPtr_skippedActionOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089F4 RID: 35316
			private static readonly System.IntPtr NativeFieldInfoPtr_actionsOccurringThisFrame;

			// Token: 0x040089F5 RID: 35317
			private static readonly System.IntPtr NativeFieldInfoPtr_skippedActionOrder;

			// Token: 0x040089F6 RID: 35318
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089F7 RID: 35319
			private static readonly System.IntPtr NativeMethodInfoPtr__EnforceState_b__0_Internal_Boolean_NPCAction_0;

			// Token: 0x040089F8 RID: 35320
			private static readonly System.IntPtr NativeMethodInfoPtr__EnforceState_b__1_Internal_Single_NPCAction_0;
		}
	}
}
