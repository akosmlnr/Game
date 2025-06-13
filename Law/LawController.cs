using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003F8 RID: 1016
	public class LawController : Singleton<LawController>
	{
		// Token: 0x06004D5F RID: 19807 RVA: 0x00176600 File Offset: 0x00174800
		// Note: this type is marked as 'beforefieldinit'.
		static LawController()
		{
			Il2CppClassPointerStore<LawController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "LawController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawController>.NativeClassPtr);
			LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "DAILY_INTENSITY_DRAIN");
			LawController.NativeFieldInfoPtr_LE_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "LE_Intensity");
			LawController.NativeFieldInfoPtr_internalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "internalLawIntensity");
			LawController.NativeFieldInfoPtr_MondaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "MondaySettings");
			LawController.NativeFieldInfoPtr_TuesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "TuesdaySettings");
			LawController.NativeFieldInfoPtr_WednesdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "WednesdaySettings");
			LawController.NativeFieldInfoPtr_ThursdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "ThursdaySettings");
			LawController.NativeFieldInfoPtr_FridaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "FridaySettings");
			LawController.NativeFieldInfoPtr_SaturdaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SaturdaySettings");
			LawController.NativeFieldInfoPtr_SundaySettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "SundaySettings");
			LawController.NativeFieldInfoPtr_IntensityIncreasePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "IntensityIncreasePerDay");
			LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverrideSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<OverriddenSettings>k__BackingField");
			LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<CurrentSettings>k__BackingField");
			LawController.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "loader");
			LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			LawController.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawController>.NativeClassPtr, "<HasChanged>k__BackingField");
			LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672948);
			LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672949);
			LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672950);
			LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672951);
			LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672952);
			LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672953);
			LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672954);
			LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672955);
			LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672956);
			LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672957);
			LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672958);
			LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672959);
			LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672960);
			LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672961);
			LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672962);
			LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672963);
			LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672964);
			LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672965);
			LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672966);
			LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672967);
			LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672968);
			LawController.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672969);
			LawController.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672970);
			LawController.NativeMethodInfoPtr_DayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672971);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672972);
			LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672973);
			LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672974);
			LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672975);
			LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672976);
			LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672977);
			LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672978);
			LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672979);
			LawController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawController>.NativeClassPtr, 100672980);
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x00176A2C File Offset: 0x00174C2C
		// (set) Token: 0x06004D61 RID: 19809 RVA: 0x00176A68 File Offset: 0x00174C68
		public unsafe bool OverrideSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x00176AA8 File Offset: 0x00174CA8
		// (set) Token: 0x06004D63 RID: 19811 RVA: 0x00176AE8 File Offset: 0x00174CE8
		public unsafe LawActivitySettings OverriddenSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24376, RefRangeEnd = 24377, XrefRangeStart = 24376, XrefRangeEnd = 24377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x00176B2C File Offset: 0x00174D2C
		// (set) Token: 0x06004D65 RID: 19813 RVA: 0x00176B6C File Offset: 0x00174D6C
		public unsafe LawActivitySettings CurrentSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48163, RefRangeEnd = 48164, XrefRangeStart = 48163, XrefRangeEnd = 48164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169640, XrefRangeEnd = 169641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x00176BB0 File Offset: 0x00174DB0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169641, XrefRangeEnd = 169643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06004D67 RID: 19815 RVA: 0x00176BE8 File Offset: 0x00174DE8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169643, XrefRangeEnd = 169645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x00176C20 File Offset: 0x00174E20
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06004D69 RID: 19817 RVA: 0x00176C60 File Offset: 0x00174E60
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x00176C9C File Offset: 0x00174E9C
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x00176CDC File Offset: 0x00174EDC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 48192, RefRangeEnd = 48202, XrefRangeStart = 48192, XrefRangeEnd = 48202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99021, RefRangeEnd = 99022, XrefRangeStart = 99021, XrefRangeEnd = 99022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x00176D20 File Offset: 0x00174F20
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x00176D60 File Offset: 0x00174F60
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 32536, RefRangeEnd = 32547, XrefRangeStart = 32536, XrefRangeEnd = 32547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169645, XrefRangeEnd = 169646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x00176DA4 File Offset: 0x00174FA4
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x00176DE0 File Offset: 0x00174FE0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00176E20 File Offset: 0x00175020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169646, XrefRangeEnd = 169649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00176E5C File Offset: 0x0017505C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169649, XrefRangeEnd = 169655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D72 RID: 19826 RVA: 0x00176E98 File Offset: 0x00175098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169655, XrefRangeEnd = 169717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D73 RID: 19827 RVA: 0x00176ED4 File Offset: 0x001750D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169717, XrefRangeEnd = 169771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D74 RID: 19828 RVA: 0x00176F10 File Offset: 0x00175110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169771, XrefRangeEnd = 169780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D75 RID: 19829 RVA: 0x00176F44 File Offset: 0x00175144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169780, XrefRangeEnd = 169785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00176F78 File Offset: 0x00175178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00176FAC File Offset: 0x001751AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169785, XrefRangeEnd = 169789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_DayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00176FE0 File Offset: 0x001751E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 169790, RefRangeEnd = 169792, XrefRangeStart = 169789, XrefRangeEnd = 169790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawActivitySettings GetSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
		}

		// Token: 0x06004D79 RID: 19833 RVA: 0x00177020 File Offset: 0x00175220
		[CallerCount(0)]
		public unsafe LawActivitySettings GetSettings(EDay day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref day;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
		}

		// Token: 0x06004D7A RID: 19834 RVA: 0x0017706C File Offset: 0x0017526C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169792, XrefRangeEnd = 169793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideSetings(LawActivitySettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D7B RID: 19835 RVA: 0x001770B0 File Offset: 0x001752B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169793, XrefRangeEnd = 169794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_EndOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D7C RID: 19836 RVA: 0x001770E4 File Offset: 0x001752E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169794, XrefRangeEnd = 169797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeInternalIntensity(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D7D RID: 19837 RVA: 0x00177124 File Offset: 0x00175324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169800, RefRangeEnd = 169801, XrefRangeStart = 169797, XrefRangeEnd = 169800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInternalIntensity(float intensity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref intensity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D7E RID: 19838 RVA: 0x00177164 File Offset: 0x00175364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169801, XrefRangeEnd = 169806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LawController.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06004D7F RID: 19839 RVA: 0x001771A8 File Offset: 0x001753A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169809, RefRangeEnd = 169810, XrefRangeStart = 169806, XrefRangeEnd = 169809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(LawData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr_Load_Public_Void_LawData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D80 RID: 19840 RVA: 0x001771EC File Offset: 0x001753EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169810, XrefRangeEnd = 169830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawController>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004D81 RID: 19841 RVA: 0x00025071 File Offset: 0x00023271
		public LawController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06004D82 RID: 19842 RVA: 0x00177228 File Offset: 0x00175428
		// (set) Token: 0x06004D83 RID: 19843 RVA: 0x0002507A File Offset: 0x0002327A
		public unsafe static float DAILY_INTENSITY_DRAIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LawController.NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN, (void*)(&value));
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x00177244 File Offset: 0x00175444
		// (set) Token: 0x06004D85 RID: 19845 RVA: 0x00025088 File Offset: 0x00023288
		public unsafe int LE_Intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_LE_Intensity)) = value;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x0017726C File Offset: 0x0017546C
		// (set) Token: 0x06004D87 RID: 19847 RVA: 0x000250A3 File Offset: 0x000232A3
		public unsafe float internalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_internalLawIntensity)) = value;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x00177294 File Offset: 0x00175494
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x000250BE File Offset: 0x000232BE
		public unsafe LawActivitySettings MondaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_MondaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06004D8A RID: 19850 RVA: 0x001772C4 File Offset: 0x001754C4
		// (set) Token: 0x06004D8B RID: 19851 RVA: 0x000250DD File Offset: 0x000232DD
		public unsafe LawActivitySettings TuesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_TuesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x001772F4 File Offset: 0x001754F4
		// (set) Token: 0x06004D8D RID: 19853 RVA: 0x000250FC File Offset: 0x000232FC
		public unsafe LawActivitySettings WednesdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_WednesdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x00177324 File Offset: 0x00175524
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x0002511B File Offset: 0x0002331B
		public unsafe LawActivitySettings ThursdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_ThursdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x00177354 File Offset: 0x00175554
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0002513A File Offset: 0x0002333A
		public unsafe LawActivitySettings FridaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_FridaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x00177384 File Offset: 0x00175584
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x00025159 File Offset: 0x00023359
		public unsafe LawActivitySettings SaturdaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SaturdaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x001773B4 File Offset: 0x001755B4
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x00025178 File Offset: 0x00023378
		public unsafe LawActivitySettings SundaySettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_SundaySettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x06004D96 RID: 19862 RVA: 0x001773E4 File Offset: 0x001755E4
		// (set) Token: 0x06004D97 RID: 19863 RVA: 0x00025197 File Offset: 0x00023397
		public unsafe float IntensityIncreasePerDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_IntensityIncreasePerDay)) = value;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x06004D98 RID: 19864 RVA: 0x0017740C File Offset: 0x0017560C
		// (set) Token: 0x06004D99 RID: 19865 RVA: 0x000251B2 File Offset: 0x000233B2
		public unsafe bool _OverrideSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverrideSettings_k__BackingField)) = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06004D9A RID: 19866 RVA: 0x00177434 File Offset: 0x00175634
		// (set) Token: 0x06004D9B RID: 19867 RVA: 0x000251CD File Offset: 0x000233CD
		public unsafe LawActivitySettings _OverriddenSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__OverriddenSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06004D9C RID: 19868 RVA: 0x00177464 File Offset: 0x00175664
		// (set) Token: 0x06004D9D RID: 19869 RVA: 0x000251EC File Offset: 0x000233EC
		public unsafe LawActivitySettings _CurrentSettings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawActivitySettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__CurrentSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x06004D9E RID: 19870 RVA: 0x00177494 File Offset: 0x00175694
		// (set) Token: 0x06004D9F RID: 19871 RVA: 0x0002520B File Offset: 0x0002340B
		public unsafe LawLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LawLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06004DA0 RID: 19872 RVA: 0x001774C4 File Offset: 0x001756C4
		// (set) Token: 0x06004DA1 RID: 19873 RVA: 0x0002522A File Offset: 0x0002342A
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06004DA2 RID: 19874 RVA: 0x001774F4 File Offset: 0x001756F4
		// (set) Token: 0x06004DA3 RID: 19875 RVA: 0x00025249 File Offset: 0x00023449
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x06004DA4 RID: 19876 RVA: 0x00177524 File Offset: 0x00175724
		// (set) Token: 0x06004DA5 RID: 19877 RVA: 0x00025268 File Offset: 0x00023468
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawController.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeFieldInfoPtr_DAILY_INTENSITY_DRAIN;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeFieldInfoPtr_LE_Intensity;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeFieldInfoPtr_internalLawIntensity;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeFieldInfoPtr_MondaySettings;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeFieldInfoPtr_TuesdaySettings;

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeFieldInfoPtr_WednesdaySettings;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeFieldInfoPtr_ThursdaySettings;

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeFieldInfoPtr_FridaySettings;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeFieldInfoPtr_SaturdaySettings;

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeFieldInfoPtr_SundaySettings;

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeFieldInfoPtr_IntensityIncreasePerDay;

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeFieldInfoPtr__OverrideSettings_k__BackingField;

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeFieldInfoPtr__OverriddenSettings_k__BackingField;

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSettings_k__BackingField;

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeMethodInfoPtr_get_OverrideSettings_Public_get_Boolean_0;

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeMethodInfoPtr_set_OverrideSettings_Protected_set_Void_Boolean_0;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeMethodInfoPtr_get_OverriddenSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeMethodInfoPtr_set_OverriddenSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSettings_Public_get_LawActivitySettings_0;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSettings_Protected_set_Void_LawActivitySettings_0;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400343A RID: 13370
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400343B RID: 13371
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400343C RID: 13372
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400343D RID: 13373
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400343E RID: 13374
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400343F RID: 13375
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003440 RID: 13376
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003441 RID: 13377
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003442 RID: 13378
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003443 RID: 13379
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04003444 RID: 13380
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04003445 RID: 13381
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04003446 RID: 13382
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04003447 RID: 13383
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Private_Void_0;

		// Token: 0x04003448 RID: 13384
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_0;

		// Token: 0x04003449 RID: 13385
		private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_LawActivitySettings_EDay_0;

		// Token: 0x0400344A RID: 13386
		private static readonly IntPtr NativeMethodInfoPtr_OverrideSetings_Public_Void_LawActivitySettings_0;

		// Token: 0x0400344B RID: 13387
		private static readonly IntPtr NativeMethodInfoPtr_EndOverride_Public_Void_0;

		// Token: 0x0400344C RID: 13388
		private static readonly IntPtr NativeMethodInfoPtr_ChangeInternalIntensity_Public_Void_Single_0;

		// Token: 0x0400344D RID: 13389
		private static readonly IntPtr NativeMethodInfoPtr_SetInternalIntensity_Public_Void_Single_0;

		// Token: 0x0400344E RID: 13390
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400344F RID: 13391
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_LawData_0;

		// Token: 0x04003450 RID: 13392
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
