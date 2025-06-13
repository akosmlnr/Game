using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Compass;
using Il2CppScheduleOne.Variables;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001BB RID: 443
	[Serializable]
	public class QuestEntry : MonoBehaviour
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x000E8C44 File Offset: 0x000E6E44
		// Note: this type is marked as 'beforefieldinit'.
		static QuestEntry()
		{
			Il2CppClassPointerStore<QuestEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr);
			QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "<ParentQuest>k__BackingField");
			QuestEntry.NativeFieldInfoPtr_EntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "EntryTitle");
			QuestEntry.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "state");
			QuestEntry.NativeFieldInfoPtr_AutoComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoComplete");
			QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoCompleteConditions");
			QuestEntry.NativeFieldInfoPtr_CompleteParentQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "CompleteParentQuest");
			QuestEntry.NativeFieldInfoPtr_EntryAddedIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "EntryAddedIn");
			QuestEntry.NativeFieldInfoPtr_AutoCreatePoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoCreatePoI");
			QuestEntry.NativeFieldInfoPtr_PoILocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoILocation");
			QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "AutoUpdatePoILocation");
			QuestEntry.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "PoI");
			QuestEntry.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onStart");
			QuestEntry.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onEnd");
			QuestEntry.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onComplete");
			QuestEntry.NativeFieldInfoPtr_onInitialComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "onInitialComplete");
			QuestEntry.NativeFieldInfoPtr_compassElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "compassElement");
			QuestEntry.NativeFieldInfoPtr_entryUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, "entryUI");
			QuestEntry.NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667514);
			QuestEntry.NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667515);
			QuestEntry.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667516);
			QuestEntry.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667517);
			QuestEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667518);
			QuestEntry.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667519);
			QuestEntry.NativeMethodInfoPtr_OnValidate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667520);
			QuestEntry.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667521);
			QuestEntry.NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667522);
			QuestEntry.NativeMethodInfoPtr_Begin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667523);
			QuestEntry.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667524);
			QuestEntry.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667525);
			QuestEntry.NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667526);
			QuestEntry.NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667527);
			QuestEntry.NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667528);
			QuestEntry.NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667529);
			QuestEntry.NativeMethodInfoPtr_CreatePoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667530);
			QuestEntry.NativeMethodInfoPtr_DestroyPoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667531);
			QuestEntry.NativeMethodInfoPtr_CreateCompassElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667532);
			QuestEntry.NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667533);
			QuestEntry.NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667534);
			QuestEntry.NativeMethodInfoPtr_UpdateName_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667535);
			QuestEntry.NativeMethodInfoPtr_EvaluateConditions_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667536);
			QuestEntry.NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667537);
			QuestEntry.NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667538);
			QuestEntry.NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667539);
			QuestEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667540);
			QuestEntry.NativeMethodInfoPtr__Awake_b__24_0_Private_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667541);
			QuestEntry.NativeMethodInfoPtr__Awake_b__24_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667542);
			QuestEntry.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr, 100667543);
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x000E9020 File Offset: 0x000E7220
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x000E9060 File Offset: 0x000E7260
		public unsafe Quest ParentQuest
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060025B7 RID: 9655 RVA: 0x000E90A4 File Offset: 0x000E72A4
		public unsafe string Title
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000E90DC File Offset: 0x000E72DC
		public unsafe EQuestState State
		{
			[CallerCount(147)]
			[CachedScanResults(RefRangeStart = 42514, RefRangeEnd = 42661, XrefRangeStart = 42514, XrefRangeEnd = 42661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_get_State_Public_get_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000E9118 File Offset: 0x000E7318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118041, XrefRangeEnd = 118079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000E9154 File Offset: 0x000E7354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118079, XrefRangeEnd = 118139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000E9190 File Offset: 0x000E7390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118139, XrefRangeEnd = 118148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_OnValidate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000E91C4 File Offset: 0x000E73C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118148, XrefRangeEnd = 118155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000E9200 File Offset: 0x000E7400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118155, XrefRangeEnd = 118157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(QuestEntryData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000E9244 File Offset: 0x000E7444
		[CallerCount(0)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Begin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x000E9278 File Offset: 0x000E7478
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 118157, RefRangeEnd = 118173, XrefRangeStart = 118157, XrefRangeEnd = 118157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Complete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Complete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x000E92AC File Offset: 0x000E74AC
		[CallerCount(0)]
		public unsafe void SetActive(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x000E92EC File Offset: 0x000E74EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118173, XrefRangeEnd = 118249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetState(EQuestState newState, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newState;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x000E9344 File Offset: 0x000E7544
		[CallerCount(0)]
		public unsafe virtual bool ShouldShowPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x000E938C File Offset: 0x000E758C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118249, XrefRangeEnd = 118255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x000E93C8 File Offset: 0x000E75C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118262, RefRangeEnd = 118264, XrefRangeStart = 118255, XrefRangeEnd = 118262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPoILocation(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x000E9408 File Offset: 0x000E7608
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118313, RefRangeEnd = 118315, XrefRangeStart = 118264, XrefRangeEnd = 118313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_CreatePoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x000E943C File Offset: 0x000E763C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118315, XrefRangeEnd = 118324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_DestroyPoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x000E9470 File Offset: 0x000E7670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118324, XrefRangeEnd = 118339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateCompassElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_CreateCompassElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x000E94A4 File Offset: 0x000E76A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 118345, RefRangeEnd = 118350, XrefRangeStart = 118339, XrefRangeEnd = 118345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCompassElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x000E94D8 File Offset: 0x000E76D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118354, RefRangeEnd = 118355, XrefRangeStart = 118350, XrefRangeEnd = 118354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntryData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryData>(intPtr2) : null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x000E9518 File Offset: 0x000E7718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 118364, RefRangeEnd = 118366, XrefRangeStart = 118355, XrefRangeEnd = 118364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_UpdateName_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x000E954C File Offset: 0x000E774C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118366, XrefRangeEnd = 118367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateConditions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_EvaluateConditions_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x000E9580 File Offset: 0x000E7780
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 118369, RefRangeEnd = 118378, XrefRangeStart = 118367, XrefRangeEnd = 118369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryTitle(string newTitle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newTitle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x000E95C4 File Offset: 0x000E77C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118378, XrefRangeEnd = 118405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateEntryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x000E9600 File Offset: 0x000E7800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118405, XrefRangeEnd = 118406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateEntryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestEntry.NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x000E963C File Offset: 0x000E783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118406, XrefRangeEnd = 118431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestEntry>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x000E9678 File Offset: 0x000E7878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__24_0(EQuestState <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__Awake_b__24_0_Private_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x000E96B8 File Offset: 0x000E78B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41942, RefRangeEnd = 41943, XrefRangeStart = 41942, XrefRangeEnd = 41943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__24_1(bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref b;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr__Awake_b__24_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x000E96F8 File Offset: 0x000E78F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 118459, RefRangeEnd = 118460, XrefRangeStart = 118431, XrefRangeEnd = 118459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestEntry.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00014FF1 File Offset: 0x000131F1
		public QuestEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060025D4 RID: 9684 RVA: 0x000E972C File Offset: 0x000E792C
		// (set) Token: 0x060025D5 RID: 9685 RVA: 0x00014FFA File Offset: 0x000131FA
		public unsafe Quest _ParentQuest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr__ParentQuest_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060025D6 RID: 9686 RVA: 0x000E975C File Offset: 0x000E795C
		// (set) Token: 0x060025D7 RID: 9687 RVA: 0x00015019 File Offset: 0x00013219
		public unsafe string EntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060025D8 RID: 9688 RVA: 0x000E9784 File Offset: 0x000E7984
		// (set) Token: 0x060025D9 RID: 9689 RVA: 0x00015038 File Offset: 0x00013238
		public unsafe EQuestState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000E97AC File Offset: 0x000E79AC
		// (set) Token: 0x060025DB RID: 9691 RVA: 0x00015053 File Offset: 0x00013253
		public unsafe bool AutoComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoComplete)) = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000E97D4 File Offset: 0x000E79D4
		// (set) Token: 0x060025DD RID: 9693 RVA: 0x0001506E File Offset: 0x0001326E
		public unsafe Conditions AutoCompleteConditions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Conditions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCompleteConditions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000E9804 File Offset: 0x000E7A04
		// (set) Token: 0x060025DF RID: 9695 RVA: 0x0001508D File Offset: 0x0001328D
		public unsafe bool CompleteParentQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_CompleteParentQuest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_CompleteParentQuest)) = value;
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000E982C File Offset: 0x000E7A2C
		// (set) Token: 0x060025E1 RID: 9697 RVA: 0x000150A8 File Offset: 0x000132A8
		public unsafe string EntryAddedIn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryAddedIn);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_EntryAddedIn), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000E9854 File Offset: 0x000E7A54
		// (set) Token: 0x060025E3 RID: 9699 RVA: 0x000150C7 File Offset: 0x000132C7
		public unsafe bool AutoCreatePoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCreatePoI);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoCreatePoI)) = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000E987C File Offset: 0x000E7A7C
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x000150E2 File Offset: 0x000132E2
		public unsafe Transform PoILocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoILocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoILocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000E98AC File Offset: 0x000E7AAC
		// (set) Token: 0x060025E7 RID: 9703 RVA: 0x00015101 File Offset: 0x00013301
		public unsafe bool AutoUpdatePoILocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_AutoUpdatePoILocation)) = value;
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000E98D4 File Offset: 0x000E7AD4
		// (set) Token: 0x060025E9 RID: 9705 RVA: 0x0001511C File Offset: 0x0001331C
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000E9904 File Offset: 0x000E7B04
		// (set) Token: 0x060025EB RID: 9707 RVA: 0x0001513B File Offset: 0x0001333B
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000E9934 File Offset: 0x000E7B34
		// (set) Token: 0x060025ED RID: 9709 RVA: 0x0001515A File Offset: 0x0001335A
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000E9964 File Offset: 0x000E7B64
		// (set) Token: 0x060025EF RID: 9711 RVA: 0x00015179 File Offset: 0x00013379
		public unsafe UnityEvent onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000E9994 File Offset: 0x000E7B94
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x00015198 File Offset: 0x00013398
		public unsafe UnityEvent onInitialComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onInitialComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_onInitialComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000E99C4 File Offset: 0x000E7BC4
		// (set) Token: 0x060025F3 RID: 9715 RVA: 0x000151B7 File Offset: 0x000133B7
		public unsafe CompassManager.Element compassElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_compassElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_compassElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000E99F4 File Offset: 0x000E7BF4
		// (set) Token: 0x060025F5 RID: 9717 RVA: 0x000151D6 File Offset: 0x000133D6
		public unsafe QuestEntryHUDUI entryUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_entryUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntryHUDUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestEntry.NativeFieldInfoPtr_entryUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400190D RID: 6413
		private static readonly IntPtr NativeFieldInfoPtr__ParentQuest_k__BackingField;

		// Token: 0x0400190E RID: 6414
		private static readonly IntPtr NativeFieldInfoPtr_EntryTitle;

		// Token: 0x0400190F RID: 6415
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001910 RID: 6416
		private static readonly IntPtr NativeFieldInfoPtr_AutoComplete;

		// Token: 0x04001911 RID: 6417
		private static readonly IntPtr NativeFieldInfoPtr_AutoCompleteConditions;

		// Token: 0x04001912 RID: 6418
		private static readonly IntPtr NativeFieldInfoPtr_CompleteParentQuest;

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeFieldInfoPtr_EntryAddedIn;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeFieldInfoPtr_AutoCreatePoI;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeFieldInfoPtr_PoILocation;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeFieldInfoPtr_AutoUpdatePoILocation;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04001919 RID: 6425
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x0400191A RID: 6426
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x0400191B RID: 6427
		private static readonly IntPtr NativeFieldInfoPtr_onInitialComplete;

		// Token: 0x0400191C RID: 6428
		private static readonly IntPtr NativeFieldInfoPtr_compassElement;

		// Token: 0x0400191D RID: 6429
		private static readonly IntPtr NativeFieldInfoPtr_entryUI;

		// Token: 0x0400191E RID: 6430
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentQuest_Public_get_Quest_0;

		// Token: 0x0400191F RID: 6431
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentQuest_Private_set_Void_Quest_0;

		// Token: 0x04001920 RID: 6432
		private static readonly IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;

		// Token: 0x04001921 RID: 6433
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EQuestState_0;

		// Token: 0x04001922 RID: 6434
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04001923 RID: 6435
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04001924 RID: 6436
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_1;

		// Token: 0x04001925 RID: 6437
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_0;

		// Token: 0x04001926 RID: 6438
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_QuestEntryData_0;

		// Token: 0x04001927 RID: 6439
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Void_0;

		// Token: 0x04001928 RID: 6440
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;

		// Token: 0x04001929 RID: 6441
		private static readonly IntPtr NativeMethodInfoPtr_SetActive_Public_Void_Boolean_0;

		// Token: 0x0400192A RID: 6442
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Virtual_New_Void_EQuestState_Boolean_0;

		// Token: 0x0400192B RID: 6443
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowPoI_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400192C RID: 6444
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePoI_Protected_Virtual_New_Void_0;

		// Token: 0x0400192D RID: 6445
		private static readonly IntPtr NativeMethodInfoPtr_SetPoILocation_Public_Void_Vector3_0;

		// Token: 0x0400192E RID: 6446
		private static readonly IntPtr NativeMethodInfoPtr_CreatePoI_Public_Void_0;

		// Token: 0x0400192F RID: 6447
		private static readonly IntPtr NativeMethodInfoPtr_DestroyPoI_Public_Void_0;

		// Token: 0x04001930 RID: 6448
		private static readonly IntPtr NativeMethodInfoPtr_CreateCompassElement_Public_Void_0;

		// Token: 0x04001931 RID: 6449
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCompassElement_Public_Void_0;

		// Token: 0x04001932 RID: 6450
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_QuestEntryData_0;

		// Token: 0x04001933 RID: 6451
		private static readonly IntPtr NativeMethodInfoPtr_UpdateName_Private_Void_1;

		// Token: 0x04001934 RID: 6452
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateConditions_Private_Void_1;

		// Token: 0x04001935 RID: 6453
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryTitle_Public_Void_String_0;

		// Token: 0x04001936 RID: 6454
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntryUI_Protected_Virtual_New_Void_0;

		// Token: 0x04001937 RID: 6455
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntryUI_Public_Virtual_New_Void_0;

		// Token: 0x04001938 RID: 6456
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001939 RID: 6457
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__24_0_Private_Void_EQuestState_0;

		// Token: 0x0400193A RID: 6458
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__24_1_Private_Void_Boolean_0;

		// Token: 0x0400193B RID: 6459
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
