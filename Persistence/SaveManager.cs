using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200022F RID: 559
	public class SaveManager : PersistentSingleton<SaveManager>
	{
		// Token: 0x06002E09 RID: 11785 RVA: 0x00105B30 File Offset: 0x00103D30
		// Note: this type is marked as 'beforefieldinit'.
		static SaveManager()
		{
			Il2CppClassPointerStore<SaveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager>.NativeClassPtr);
			SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "MAIN_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "MENU_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "TUTORIAL_SCENE_NAME");
			SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVES_PER_FRAME");
			SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_FILE_EXTENSION");
			SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_SLOT_COUNT");
			SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SAVE_GAME_PREFIX");
			SaveManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "DEBUG");
			SaveManager.NativeFieldInfoPtr_PRETTY_PRINT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "PRETTY_PRINT");
			SaveManager.NativeFieldInfoPtr_SaveError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "SaveError");
			SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<AccessPermissionIssueDetected>k__BackingField");
			SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<IsSaving>k__BackingField");
			SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<SecondsSinceLastSave>k__BackingField");
			SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<PlayersSavePath>k__BackingField");
			SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<IndividualSavesContainerPath>k__BackingField");
			SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<SaveName>k__BackingField");
			SaveManager.NativeFieldInfoPtr_Saveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "Saveables");
			SaveManager.NativeFieldInfoPtr_BaseSaveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "BaseSaveables");
			SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "ApprovedBaseLevelPaths");
			SaveManager.NativeFieldInfoPtr_CompletedSaveables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "CompletedSaveables");
			SaveManager.NativeFieldInfoPtr_QueuedSaveRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "QueuedSaveRequests");
			SaveManager.NativeFieldInfoPtr_WriteIssueDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "WriteIssueDisplay");
			SaveManager.NativeFieldInfoPtr_onSaveStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "onSaveStart");
			SaveManager.NativeFieldInfoPtr_onSaveComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "onSaveComplete");
			SaveManager.NativeFieldInfoPtr_saveFolderInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "saveFolderInitialized");
			SaveManager.NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668608);
			SaveManager.NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668609);
			SaveManager.NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668610);
			SaveManager.NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668611);
			SaveManager.NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668612);
			SaveManager.NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668613);
			SaveManager.NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668614);
			SaveManager.NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668615);
			SaveManager.NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668616);
			SaveManager.NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668617);
			SaveManager.NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668618);
			SaveManager.NativeMethodInfoPtr_get_SaveName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668619);
			SaveManager.NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668620);
			SaveManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668621);
			SaveManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668622);
			SaveManager.NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668623);
			SaveManager.NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668624);
			SaveManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668625);
			SaveManager.NativeMethodInfoPtr_DelayedSave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668626);
			SaveManager.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668627);
			SaveManager.NativeMethodInfoPtr_Save_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668628);
			SaveManager.NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668629);
			SaveManager.NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668630);
			SaveManager.NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668631);
			SaveManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668632);
			SaveManager.NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668633);
			SaveManager.NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668634);
			SaveManager.NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668635);
			SaveManager.NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668636);
			SaveManager.NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668637);
			SaveManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668638);
			SaveManager.NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668639);
			SaveManager.NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668640);
			SaveManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668641);
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00105FFC File Offset: 0x001041FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130352, RefRangeEnd = 130354, XrefRangeStart = 130350, XrefRangeEnd = 130352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportSaveError()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x00106024 File Offset: 0x00104224
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x00106060 File Offset: 0x00104260
		public unsafe bool AccessPermissionIssueDetected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x001060A0 File Offset: 0x001042A0
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x001060DC File Offset: 0x001042DC
		public unsafe bool IsSaving
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x0010611C File Offset: 0x0010431C
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x00106158 File Offset: 0x00104358
		public unsafe float SecondsSinceLastSave
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 109817, RefRangeEnd = 109819, XrefRangeStart = 109817, XrefRangeEnd = 109819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00106198 File Offset: 0x00104398
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x001061D0 File Offset: 0x001043D0
		public unsafe string PlayersSavePath
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x00106214 File Offset: 0x00104414
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x0010624C File Offset: 0x0010444C
		public unsafe string IndividualSavesContainerPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x00106290 File Offset: 0x00104490
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x001062C8 File Offset: 0x001044C8
		public unsafe string SaveName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_get_SaveName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x0010630C File Offset: 0x0010450C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130354, XrefRangeEnd = 130394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00106348 File Offset: 0x00104548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130394, XrefRangeEnd = 130410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00106384 File Offset: 0x00104584
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130451, RefRangeEnd = 130453, XrefRangeStart = 130410, XrefRangeEnd = 130451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSaveFolderInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x001063B8 File Offset: 0x001045B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130465, RefRangeEnd = 130466, XrefRangeStart = 130453, XrefRangeEnd = 130465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasWritePermissionOnDir(string path)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x001063FC File Offset: 0x001045FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130466, XrefRangeEnd = 130489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00106430 File Offset: 0x00104630
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130492, RefRangeEnd = 130493, XrefRangeStart = 130489, XrefRangeEnd = 130492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DelayedSave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00106464 File Offset: 0x00104664
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130499, RefRangeEnd = 130505, XrefRangeStart = 130493, XrefRangeEnd = 130499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00106498 File Offset: 0x00104698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130542, RefRangeEnd = 130543, XrefRangeStart = 130505, XrefRangeEnd = 130542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Save(string saveFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Save_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x001064DC File Offset: 0x001046DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130543, XrefRangeEnd = 130601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearBaseLevelOutdatedSaves(string saveFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(saveFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00106520 File Offset: 0x00104720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130601, XrefRangeEnd = 130614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00106564 File Offset: 0x00104764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130618, RefRangeEnd = 130619, XrefRangeStart = 130614, XrefRangeEnd = 130618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCompletedSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x001065A8 File Offset: 0x001047A8
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 130633, RefRangeEnd = 130665, XrefRangeStart = 130619, XrefRangeEnd = 130633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterSaveable(ISaveable saveable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveable);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x001065EC File Offset: 0x001047EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130665, XrefRangeEnd = 130671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueSaveRequest(SaveRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x00106630 File Offset: 0x00104830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130671, XrefRangeEnd = 130675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DequeueSaveRequest(SaveRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00106674 File Offset: 0x00104874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130675, XrefRangeEnd = 130681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripExtensions(string filePath)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x001066B0 File Offset: 0x001048B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130687, RefRangeEnd = 130691, XrefRangeStart = 130681, XrefRangeEnd = 130687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MakeFileSafe(string fileName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x001066EC File Offset: 0x001048EC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130715, RefRangeEnd = 130720, XrefRangeStart = 130691, XrefRangeEnd = 130715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetVersionNumber(string version)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x00106730 File Offset: 0x00104930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130720, XrefRangeEnd = 130724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x00106764 File Offset: 0x00104964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130753, RefRangeEnd = 130754, XrefRangeStart = 130724, XrefRangeEnd = 130753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisablePlayTutorial(SaveInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x001067A8 File Offset: 0x001049A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130760, RefRangeEnd = 130762, XrefRangeStart = 130754, XrefRangeEnd = 130760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SanitizeFileName(string fileName)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileName);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x001067E4 File Offset: 0x001049E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130762, XrefRangeEnd = 130807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x00018A15 File Offset: 0x00016C15
		public SaveManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00106820 File Offset: 0x00104A20
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x00018A1E File Offset: 0x00016C1E
		public unsafe static string MAIN_SCENE_NAME
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_MAIN_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x00106840 File Offset: 0x00104A40
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x00018A30 File Offset: 0x00016C30
		public unsafe static string MENU_SCENE_NAME
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_MENU_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x00106860 File Offset: 0x00104A60
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x00018A42 File Offset: 0x00016C42
		public unsafe static string TUTORIAL_SCENE_NAME
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_TUTORIAL_SCENE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x00106880 File Offset: 0x00104A80
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x00018A54 File Offset: 0x00016C54
		public unsafe static int SAVES_PER_FRAME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVES_PER_FRAME, (void*)(&value));
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x0010689C File Offset: 0x00104A9C
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x00018A62 File Offset: 0x00016C62
		public unsafe static string SAVE_FILE_EXTENSION
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_FILE_EXTENSION, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x001068BC File Offset: 0x00104ABC
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x00018A74 File Offset: 0x00016C74
		public unsafe static int SAVE_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x001068D8 File Offset: 0x00104AD8
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00018A82 File Offset: 0x00016C82
		public unsafe static string SAVE_GAME_PREFIX
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SAVE_GAME_PREFIX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x001068F8 File Offset: 0x00104AF8
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x00018A94 File Offset: 0x00016C94
		public unsafe static bool DEBUG
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_DEBUG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_DEBUG, (void*)(&value));
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x00106914 File Offset: 0x00104B14
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x00018AA2 File Offset: 0x00016CA2
		public unsafe static bool PRETTY_PRINT
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_PRETTY_PRINT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_PRETTY_PRINT, (void*)(&value));
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x00106930 File Offset: 0x00104B30
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x00018AB0 File Offset: 0x00016CB0
		public unsafe static bool SaveError
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(SaveManager.NativeFieldInfoPtr_SaveError, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SaveManager.NativeFieldInfoPtr_SaveError, (void*)(&value));
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0010694C File Offset: 0x00104B4C
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00018ABE File Offset: 0x00016CBE
		public unsafe bool _AccessPermissionIssueDetected_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00106974 File Offset: 0x00104B74
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00018AD9 File Offset: 0x00016CD9
		public unsafe bool _IsSaving_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IsSaving_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x0010699C File Offset: 0x00104B9C
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x00018AF4 File Offset: 0x00016CF4
		public unsafe float _SecondsSinceLastSave_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField)) = value;
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x001069C4 File Offset: 0x00104BC4
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x00018B0F File Offset: 0x00016D0F
		public unsafe string _PlayersSavePath_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__PlayersSavePath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x001069EC File Offset: 0x00104BEC
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x00018B2E File Offset: 0x00016D2E
		public unsafe string _IndividualSavesContainerPath_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00106A14 File Offset: 0x00104C14
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x00018B4D File Offset: 0x00016D4D
		public unsafe string _SaveName_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr__SaveName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x00106A3C File Offset: 0x00104C3C
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00018B6C File Offset: 0x00016D6C
		public unsafe List<ISaveable> Saveables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_Saveables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISaveable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_Saveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x00106A6C File Offset: 0x00104C6C
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00018B8B File Offset: 0x00016D8B
		public unsafe List<IBaseSaveable> BaseSaveables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_BaseSaveables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IBaseSaveable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_BaseSaveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00106A9C File Offset: 0x00104C9C
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00018BAA File Offset: 0x00016DAA
		public unsafe List<string> ApprovedBaseLevelPaths
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_ApprovedBaseLevelPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00106ACC File Offset: 0x00104CCC
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00018BC9 File Offset: 0x00016DC9
		public unsafe List<ISaveable> CompletedSaveables
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_CompletedSaveables);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ISaveable>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_CompletedSaveables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x00106AFC File Offset: 0x00104CFC
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x00018BE8 File Offset: 0x00016DE8
		public unsafe List<SaveRequest> QueuedSaveRequests
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_QueuedSaveRequests);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SaveRequest>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_QueuedSaveRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00106B2C File Offset: 0x00104D2C
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x00018C07 File Offset: 0x00016E07
		public unsafe RectTransform WriteIssueDisplay
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_WriteIssueDisplay);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_WriteIssueDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x00106B5C File Offset: 0x00104D5C
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x00018C26 File Offset: 0x00016E26
		public unsafe UnityEvent onSaveStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00106B8C File Offset: 0x00104D8C
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x00018C45 File Offset: 0x00016E45
		public unsafe UnityEvent onSaveComplete
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveComplete);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_onSaveComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x00106BBC File Offset: 0x00104DBC
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x00018C64 File Offset: 0x00016E64
		public unsafe bool saveFolderInitialized
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_saveFolderInitialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.NativeFieldInfoPtr_saveFolderInitialized)) = value;
			}
		}

		// Token: 0x04001E8C RID: 7820
		private static readonly System.IntPtr NativeFieldInfoPtr_MAIN_SCENE_NAME;

		// Token: 0x04001E8D RID: 7821
		private static readonly System.IntPtr NativeFieldInfoPtr_MENU_SCENE_NAME;

		// Token: 0x04001E8E RID: 7822
		private static readonly System.IntPtr NativeFieldInfoPtr_TUTORIAL_SCENE_NAME;

		// Token: 0x04001E8F RID: 7823
		private static readonly System.IntPtr NativeFieldInfoPtr_SAVES_PER_FRAME;

		// Token: 0x04001E90 RID: 7824
		private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_FILE_EXTENSION;

		// Token: 0x04001E91 RID: 7825
		private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_SLOT_COUNT;

		// Token: 0x04001E92 RID: 7826
		private static readonly System.IntPtr NativeFieldInfoPtr_SAVE_GAME_PREFIX;

		// Token: 0x04001E93 RID: 7827
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04001E94 RID: 7828
		private static readonly System.IntPtr NativeFieldInfoPtr_PRETTY_PRINT;

		// Token: 0x04001E95 RID: 7829
		private static readonly System.IntPtr NativeFieldInfoPtr_SaveError;

		// Token: 0x04001E96 RID: 7830
		private static readonly System.IntPtr NativeFieldInfoPtr__AccessPermissionIssueDetected_k__BackingField;

		// Token: 0x04001E97 RID: 7831
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSaving_k__BackingField;

		// Token: 0x04001E98 RID: 7832
		private static readonly System.IntPtr NativeFieldInfoPtr__SecondsSinceLastSave_k__BackingField;

		// Token: 0x04001E99 RID: 7833
		private static readonly System.IntPtr NativeFieldInfoPtr__PlayersSavePath_k__BackingField;

		// Token: 0x04001E9A RID: 7834
		private static readonly System.IntPtr NativeFieldInfoPtr__IndividualSavesContainerPath_k__BackingField;

		// Token: 0x04001E9B RID: 7835
		private static readonly System.IntPtr NativeFieldInfoPtr__SaveName_k__BackingField;

		// Token: 0x04001E9C RID: 7836
		private static readonly System.IntPtr NativeFieldInfoPtr_Saveables;

		// Token: 0x04001E9D RID: 7837
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseSaveables;

		// Token: 0x04001E9E RID: 7838
		private static readonly System.IntPtr NativeFieldInfoPtr_ApprovedBaseLevelPaths;

		// Token: 0x04001E9F RID: 7839
		private static readonly System.IntPtr NativeFieldInfoPtr_CompletedSaveables;

		// Token: 0x04001EA0 RID: 7840
		private static readonly System.IntPtr NativeFieldInfoPtr_QueuedSaveRequests;

		// Token: 0x04001EA1 RID: 7841
		private static readonly System.IntPtr NativeFieldInfoPtr_WriteIssueDisplay;

		// Token: 0x04001EA2 RID: 7842
		private static readonly System.IntPtr NativeFieldInfoPtr_onSaveStart;

		// Token: 0x04001EA3 RID: 7843
		private static readonly System.IntPtr NativeFieldInfoPtr_onSaveComplete;

		// Token: 0x04001EA4 RID: 7844
		private static readonly System.IntPtr NativeFieldInfoPtr_saveFolderInitialized;

		// Token: 0x04001EA5 RID: 7845
		private static readonly System.IntPtr NativeMethodInfoPtr_ReportSaveError_Public_Static_Void_0;

		// Token: 0x04001EA6 RID: 7846
		private static readonly System.IntPtr NativeMethodInfoPtr_get_AccessPermissionIssueDetected_Public_get_Boolean_0;

		// Token: 0x04001EA7 RID: 7847
		private static readonly System.IntPtr NativeMethodInfoPtr_set_AccessPermissionIssueDetected_Protected_set_Void_Boolean_0;

		// Token: 0x04001EA8 RID: 7848
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSaving_Public_get_Boolean_0;

		// Token: 0x04001EA9 RID: 7849
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSaving_Protected_set_Void_Boolean_0;

		// Token: 0x04001EAA RID: 7850
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SecondsSinceLastSave_Public_get_Single_0;

		// Token: 0x04001EAB RID: 7851
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SecondsSinceLastSave_Protected_set_Void_Single_0;

		// Token: 0x04001EAC RID: 7852
		private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayersSavePath_Public_get_String_0;

		// Token: 0x04001EAD RID: 7853
		private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayersSavePath_Protected_set_Void_String_0;

		// Token: 0x04001EAE RID: 7854
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IndividualSavesContainerPath_Public_get_String_0;

		// Token: 0x04001EAF RID: 7855
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IndividualSavesContainerPath_Protected_set_Void_String_0;

		// Token: 0x04001EB0 RID: 7856
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveName_Public_get_String_0;

		// Token: 0x04001EB1 RID: 7857
		private static readonly System.IntPtr NativeMethodInfoPtr_set_SaveName_Protected_set_Void_String_0;

		// Token: 0x04001EB2 RID: 7858
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04001EB3 RID: 7859
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckSaveFolderInitialized_Public_Void_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly System.IntPtr NativeMethodInfoPtr_HasWritePermissionOnDir_Public_Static_Boolean_String_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001EB7 RID: 7863
		private static readonly System.IntPtr NativeMethodInfoPtr_DelayedSave_Public_Void_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_String_0;

		// Token: 0x04001EBA RID: 7866
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearBaseLevelOutdatedSaves_Private_Void_String_0;

		// Token: 0x04001EBB RID: 7867
		private static readonly System.IntPtr NativeMethodInfoPtr_CompleteSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001EBC RID: 7868
		private static readonly System.IntPtr NativeMethodInfoPtr_ClearCompletedSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterSaveable_Public_Void_ISaveable_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly System.IntPtr NativeMethodInfoPtr_QueueSaveRequest_Public_Void_SaveRequest_0;

		// Token: 0x04001EBF RID: 7871
		private static readonly System.IntPtr NativeMethodInfoPtr_DequeueSaveRequest_Public_Void_SaveRequest_0;

		// Token: 0x04001EC0 RID: 7872
		private static readonly System.IntPtr NativeMethodInfoPtr_StripExtensions_Public_Static_String_String_0;

		// Token: 0x04001EC1 RID: 7873
		private static readonly System.IntPtr NativeMethodInfoPtr_MakeFileSafe_Public_Static_String_String_0;

		// Token: 0x04001EC2 RID: 7874
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVersionNumber_Public_Static_Single_String_0;

		// Token: 0x04001EC3 RID: 7875
		private static readonly System.IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x04001EC4 RID: 7876
		private static readonly System.IntPtr NativeMethodInfoPtr_DisablePlayTutorial_Public_Void_SaveInfo_0;

		// Token: 0x04001EC5 RID: 7877
		private static readonly System.IntPtr NativeMethodInfoPtr_SanitizeFileName_Public_Static_String_String_0;

		// Token: 0x04001EC6 RID: 7878
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200092D RID: 2349
		[ObfuscatedName("ScheduleOne.Persistence.SaveManager+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C9D0 RID: 51664 RVA: 0x00314140 File Offset: 0x00312340
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr);
				SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, "<>4__this");
				SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr_saveFolderPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, "saveFolderPath");
				SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, 100668642);
				SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, 100668643);
			}

			// Token: 0x0600C9D1 RID: 51665 RVA: 0x003141BC File Offset: 0x003123BC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C9D2 RID: 51666 RVA: 0x003141F8 File Offset: 0x003123F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130345, XrefRangeEnd = 130350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600C9D3 RID: 51667 RVA: 0x00061DD3 File Offset: 0x0005FFD3
			public __c__DisplayClass51_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EB1 RID: 16049
			// (get) Token: 0x0600C9D4 RID: 51668 RVA: 0x00314238 File Offset: 0x00312438
			// (set) Token: 0x0600C9D5 RID: 51669 RVA: 0x00061DDC File Offset: 0x0005FFDC
			public unsafe SaveManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EB2 RID: 16050
			// (get) Token: 0x0600C9D6 RID: 51670 RVA: 0x00314268 File Offset: 0x00312468
			// (set) Token: 0x0600C9D7 RID: 51671 RVA: 0x00061DFB File Offset: 0x0005FFFB
			public unsafe string saveFolderPath
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr_saveFolderPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.NativeFieldInfoPtr_saveFolderPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040088EA RID: 35050
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088EB RID: 35051
			private static readonly System.IntPtr NativeFieldInfoPtr_saveFolderPath;

			// Token: 0x040088EC RID: 35052
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088ED RID: 35053
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C97 RID: 3223
			[ObfuscatedName("ScheduleOne.Persistence.SaveManager+<>c__DisplayClass51_0+<<Save>g__SaveRoutine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E781 RID: 59265 RVA: 0x00368428 File Offset: 0x00366628
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0>.NativeClassPtr, "<<Save>g__SaveRoutine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668644);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668645);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668646);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668647);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668648);
					SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100668649);
				}

				// Token: 0x0600E782 RID: 59266 RVA: 0x00368508 File Offset: 0x00366708
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E783 RID: 59267 RVA: 0x00368550 File Offset: 0x00366750
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E784 RID: 59268 RVA: 0x00368584 File Offset: 0x00366784
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130249, XrefRangeEnd = 130340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004773 RID: 18291
				// (get) Token: 0x0600E785 RID: 59269 RVA: 0x003685C0 File Offset: 0x003667C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E786 RID: 59270 RVA: 0x00368600 File Offset: 0x00366800
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130340, XrefRangeEnd = 130345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004774 RID: 18292
				// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00368634 File Offset: 0x00366834
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E788 RID: 59272 RVA: 0x000708F7 File Offset: 0x0006EAF7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004770 RID: 18288
				// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00368674 File Offset: 0x00366874
				// (set) Token: 0x0600E78A RID: 59274 RVA: 0x00070900 File Offset: 0x0006EB00
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004771 RID: 18289
				// (get) Token: 0x0600E78B RID: 59275 RVA: 0x0036869C File Offset: 0x0036689C
				// (set) Token: 0x0600E78C RID: 59276 RVA: 0x0007091B File Offset: 0x0006EB1B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004772 RID: 18290
				// (get) Token: 0x0600E78D RID: 59277 RVA: 0x003686CC File Offset: 0x003668CC
				// (set) Token: 0x0600E78E RID: 59278 RVA: 0x0007093A File Offset: 0x0006EB3A
				public unsafe SaveManager.__c__DisplayClass51_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveManager.__c__DisplayClass51_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveManager.__c__DisplayClass51_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009B06 RID: 39686
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009B07 RID: 39687
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009B08 RID: 39688
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009B09 RID: 39689
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009B0A RID: 39690
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B0B RID: 39691
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009B0C RID: 39692
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009B0D RID: 39693
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009B0E RID: 39694
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
