using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000477 RID: 1143
	public class GameManager : NetworkSingleton<GameManager>
	{
		// Token: 0x06006235 RID: 25141 RVA: 0x001C3124 File Offset: 0x001C1324
		// Note: this type is marked as 'beforefieldinit'.
		static GameManager()
		{
			Il2CppClassPointerStore<GameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GameManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameManager>.NativeClassPtr);
			GameManager.NativeFieldInfoPtr_IS_DEMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "IS_DEMO");
			GameManager.NativeFieldInfoPtr_IS_BETA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "IS_BETA");
			GameManager.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "seed");
			GameManager.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "OrganisationName");
			GameManager.NativeFieldInfoPtr__OrganisationLogo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<OrganisationLogo>k__BackingField");
			GameManager.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Settings");
			GameManager.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "SpawnPoint");
			GameManager.NativeFieldInfoPtr_NoHomeRespawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "NoHomeRespawnPoint");
			GameManager.NativeFieldInfoPtr_Temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "Temp");
			GameManager.NativeFieldInfoPtr_onSettingsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "onSettingsLoaded");
			GameManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "loader");
			GameManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			GameManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			GameManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			GameManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted");
			GameManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.DevUtilities.GameManagerAssembly-CSharp.dll_Excuted");
			GameManager.NativeMethodInfoPtr_get_IS_TUTORIAL_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675890);
			GameManager.NativeMethodInfoPtr_get_Seed_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675891);
			GameManager.NativeMethodInfoPtr_get_OrganisationLogo_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675892);
			GameManager.NativeMethodInfoPtr_set_OrganisationLogo_Protected_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675893);
			GameManager.NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675894);
			GameManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675895);
			GameManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675896);
			GameManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675897);
			GameManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675898);
			GameManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675899);
			GameManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675900);
			GameManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675901);
			GameManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675902);
			GameManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675903);
			GameManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675904);
			GameManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675905);
			GameManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675906);
			GameManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675907);
			GameManager.NativeMethodInfoPtr_SetGameData_Public_Void_NetworkConnection_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675908);
			GameManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675909);
			GameManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675910);
			GameManager.NativeMethodInfoPtr_Load_Public_Void_GameData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675911);
			GameManager.NativeMethodInfoPtr_EndTutorial_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675912);
			GameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675913);
			GameManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675914);
			GameManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675915);
			GameManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675916);
			GameManager.NativeMethodInfoPtr_RpcWriter___Target_SetGameData_3076874643_Private_Void_NetworkConnection_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675917);
			GameManager.NativeMethodInfoPtr_RpcLogic___SetGameData_3076874643_Public_Void_NetworkConnection_GameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675918);
			GameManager.NativeMethodInfoPtr_RpcReader___Target_SetGameData_3076874643_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675919);
			GameManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameManager>.NativeClassPtr, 100675920);
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06006236 RID: 25142 RVA: 0x001C3500 File Offset: 0x001C1700
		public unsafe static bool IS_TUTORIAL
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 203568, RefRangeEnd = 203602, XrefRangeStart = 203560, XrefRangeEnd = 203568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_IS_TUTORIAL_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x001C3530 File Offset: 0x001C1730
		public unsafe static int Seed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203602, XrefRangeEnd = 203610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_Seed_Public_Static_get_Int32_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06006238 RID: 25144 RVA: 0x001C3560 File Offset: 0x001C1760
		// (set) Token: 0x06006239 RID: 25145 RVA: 0x001C35A0 File Offset: 0x001C17A0
		public unsafe Sprite OrganisationLogo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_OrganisationLogo_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_OrganisationLogo_Protected_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x0600623A RID: 25146 RVA: 0x001C35E4 File Offset: 0x001C17E4
		public unsafe bool IsTutorial
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 203618, RefRangeEnd = 203639, XrefRangeStart = 203610, XrefRangeEnd = 203618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x001C3620 File Offset: 0x001C1820
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203639, XrefRangeEnd = 203641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600623C RID: 25148 RVA: 0x001C3658 File Offset: 0x001C1858
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203641, XrefRangeEnd = 203643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x001C3690 File Offset: 0x001C1890
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x0600623E RID: 25150 RVA: 0x001C36D0 File Offset: 0x001C18D0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x001C370C File Offset: 0x001C190C
		// (set) Token: 0x06006240 RID: 25152 RVA: 0x001C374C File Offset: 0x001C194C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06006241 RID: 25153 RVA: 0x001C3790 File Offset: 0x001C1990
		// (set) Token: 0x06006242 RID: 25154 RVA: 0x001C37D0 File Offset: 0x001C19D0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 90006, RefRangeEnd = 90007, XrefRangeStart = 90006, XrefRangeEnd = 90007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x001C3814 File Offset: 0x001C1A14
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x001C3850 File Offset: 0x001C1A50
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x001C3890 File Offset: 0x001C1A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203643, XrefRangeEnd = 203647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x001C38CC File Offset: 0x001C1ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203647, XrefRangeEnd = 203650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x001C3908 File Offset: 0x001C1B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203650, XrefRangeEnd = 203666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x001C3958 File Offset: 0x001C1B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203666, XrefRangeEnd = 203676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGameData(NetworkConnection conn, GameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_SetGameData_Public_Void_NetworkConnection_GameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x001C39AC File Offset: 0x001C1BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203676, XrefRangeEnd = 203682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x001C39E8 File Offset: 0x001C1BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203682, XrefRangeEnd = 203687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x001C3A2C File Offset: 0x001C1C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203690, RefRangeEnd = 203691, XrefRangeStart = 203687, XrefRangeEnd = 203690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(GameData data, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_Load_Public_Void_GameData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x001C3A80 File Offset: 0x001C1C80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203736, RefRangeEnd = 203737, XrefRangeStart = 203691, XrefRangeEnd = 203736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndTutorial(bool natural)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref natural;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_EndTutorial_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x001C3AC0 File Offset: 0x001C1CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203737, XrefRangeEnd = 203780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameManager>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x001C3AFC File Offset: 0x001C1CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203780, XrefRangeEnd = 203790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x001C3B38 File Offset: 0x001C1D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203790, XrefRangeEnd = 203793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x001C3B74 File Offset: 0x001C1D74
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x001C3BB0 File Offset: 0x001C1DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_RpcWriter___Target_SetGameData_3076874643_Private_Void_NetworkConnection_GameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x001C3C04 File Offset: 0x001C1E04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203793, XrefRangeEnd = 203796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGameData_3076874643(NetworkConnection conn, GameData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_RpcLogic___SetGameData_3076874643_Public_Void_NetworkConnection_GameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x001C3C58 File Offset: 0x001C1E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203796, XrefRangeEnd = 203802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGameData_3076874643(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameManager.NativeMethodInfoPtr_RpcReader___Target_SetGameData_3076874643_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006254 RID: 25172 RVA: 0x001C3CA8 File Offset: 0x001C1EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203802, XrefRangeEnd = 203806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x0002E318 File Offset: 0x0002C518
		public GameManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06006256 RID: 25174 RVA: 0x001C3CE4 File Offset: 0x001C1EE4
		// (set) Token: 0x06006257 RID: 25175 RVA: 0x0002E321 File Offset: 0x0002C521
		public unsafe static bool IS_DEMO
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_IS_DEMO, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_IS_DEMO, (void*)(&value));
			}
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06006258 RID: 25176 RVA: 0x001C3D00 File Offset: 0x001C1F00
		// (set) Token: 0x06006259 RID: 25177 RVA: 0x0002E32F File Offset: 0x0002C52F
		public unsafe static bool IS_BETA
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameManager.NativeFieldInfoPtr_IS_BETA, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameManager.NativeFieldInfoPtr_IS_BETA, (void*)(&value));
			}
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x0600625A RID: 25178 RVA: 0x001C3D1C File Offset: 0x001C1F1C
		// (set) Token: 0x0600625B RID: 25179 RVA: 0x0002E33D File Offset: 0x0002C53D
		public unsafe int seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_seed)) = value;
			}
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x001C3D44 File Offset: 0x001C1F44
		// (set) Token: 0x0600625D RID: 25181 RVA: 0x0002E358 File Offset: 0x0002C558
		public unsafe string OrganisationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x0600625E RID: 25182 RVA: 0x001C3D6C File Offset: 0x001C1F6C
		// (set) Token: 0x0600625F RID: 25183 RVA: 0x0002E377 File Offset: 0x0002C577
		public unsafe Sprite _OrganisationLogo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__OrganisationLogo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__OrganisationLogo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06006260 RID: 25184 RVA: 0x001C3D9C File Offset: 0x001C1F9C
		// (set) Token: 0x06006261 RID: 25185 RVA: 0x0002E396 File Offset: 0x0002C596
		public unsafe GameSettings Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06006262 RID: 25186 RVA: 0x001C3DCC File Offset: 0x001C1FCC
		// (set) Token: 0x06006263 RID: 25187 RVA: 0x0002E3B5 File Offset: 0x0002C5B5
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06006264 RID: 25188 RVA: 0x001C3DFC File Offset: 0x001C1FFC
		// (set) Token: 0x06006265 RID: 25189 RVA: 0x0002E3D4 File Offset: 0x0002C5D4
		public unsafe Transform NoHomeRespawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_NoHomeRespawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_NoHomeRespawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06006266 RID: 25190 RVA: 0x001C3E2C File Offset: 0x001C202C
		// (set) Token: 0x06006267 RID: 25191 RVA: 0x0002E3F3 File Offset: 0x0002C5F3
		public unsafe Transform Temp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Temp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_Temp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06006268 RID: 25192 RVA: 0x001C3E5C File Offset: 0x001C205C
		// (set) Token: 0x06006269 RID: 25193 RVA: 0x0002E412 File Offset: 0x0002C612
		public unsafe UnityEvent onSettingsLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_onSettingsLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_onSettingsLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x0600626A RID: 25194 RVA: 0x001C3E8C File Offset: 0x001C208C
		// (set) Token: 0x0600626B RID: 25195 RVA: 0x0002E431 File Offset: 0x0002C631
		public unsafe GameDataLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDataLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x0600626C RID: 25196 RVA: 0x001C3EBC File Offset: 0x001C20BC
		// (set) Token: 0x0600626D RID: 25197 RVA: 0x0002E450 File Offset: 0x0002C650
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600626E RID: 25198 RVA: 0x001C3EEC File Offset: 0x001C20EC
		// (set) Token: 0x0600626F RID: 25199 RVA: 0x0002E46F File Offset: 0x0002C66F
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06006270 RID: 25200 RVA: 0x001C3F1C File Offset: 0x001C211C
		// (set) Token: 0x06006271 RID: 25201 RVA: 0x0002E48E File Offset: 0x0002C68E
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06006272 RID: 25202 RVA: 0x001C3F44 File Offset: 0x001C2144
		// (set) Token: 0x06006273 RID: 25203 RVA: 0x0002E4A9 File Offset: 0x0002C6A9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06006274 RID: 25204 RVA: 0x001C3F6C File Offset: 0x001C216C
		// (set) Token: 0x06006275 RID: 25205 RVA: 0x0002E4C4 File Offset: 0x0002C6C4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400430D RID: 17165
		private static readonly IntPtr NativeFieldInfoPtr_IS_DEMO;

		// Token: 0x0400430E RID: 17166
		private static readonly IntPtr NativeFieldInfoPtr_IS_BETA;

		// Token: 0x0400430F RID: 17167
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04004310 RID: 17168
		private static readonly IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04004311 RID: 17169
		private static readonly IntPtr NativeFieldInfoPtr__OrganisationLogo_k__BackingField;

		// Token: 0x04004312 RID: 17170
		private static readonly IntPtr NativeFieldInfoPtr_Settings;

		// Token: 0x04004313 RID: 17171
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04004314 RID: 17172
		private static readonly IntPtr NativeFieldInfoPtr_NoHomeRespawnPoint;

		// Token: 0x04004315 RID: 17173
		private static readonly IntPtr NativeFieldInfoPtr_Temp;

		// Token: 0x04004316 RID: 17174
		private static readonly IntPtr NativeFieldInfoPtr_onSettingsLoaded;

		// Token: 0x04004317 RID: 17175
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004318 RID: 17176
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004319 RID: 17177
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400431A RID: 17178
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400431B RID: 17179
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400431C RID: 17180
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400431D RID: 17181
		private static readonly IntPtr NativeMethodInfoPtr_get_IS_TUTORIAL_Public_Static_get_Boolean_0;

		// Token: 0x0400431E RID: 17182
		private static readonly IntPtr NativeMethodInfoPtr_get_Seed_Public_Static_get_Int32_0;

		// Token: 0x0400431F RID: 17183
		private static readonly IntPtr NativeMethodInfoPtr_get_OrganisationLogo_Public_get_Sprite_0;

		// Token: 0x04004320 RID: 17184
		private static readonly IntPtr NativeMethodInfoPtr_set_OrganisationLogo_Protected_set_Void_Sprite_0;

		// Token: 0x04004321 RID: 17185
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTutorial_Public_get_Boolean_0;

		// Token: 0x04004322 RID: 17186
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004323 RID: 17187
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004324 RID: 17188
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004325 RID: 17189
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004326 RID: 17190
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004327 RID: 17191
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004328 RID: 17192
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004329 RID: 17193
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x0400432A RID: 17194
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400432B RID: 17195
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400432C RID: 17196
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400432D RID: 17197
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x0400432E RID: 17198
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400432F RID: 17199
		private static readonly IntPtr NativeMethodInfoPtr_SetGameData_Public_Void_NetworkConnection_GameData_0;

		// Token: 0x04004330 RID: 17200
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004331 RID: 17201
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004332 RID: 17202
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_GameData_String_0;

		// Token: 0x04004333 RID: 17203
		private static readonly IntPtr NativeMethodInfoPtr_EndTutorial_Public_Void_Boolean_0;

		// Token: 0x04004334 RID: 17204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004335 RID: 17205
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004336 RID: 17206
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004337 RID: 17207
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004338 RID: 17208
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGameData_3076874643_Private_Void_NetworkConnection_GameData_0;

		// Token: 0x04004339 RID: 17209
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGameData_3076874643_Public_Void_NetworkConnection_GameData_0;

		// Token: 0x0400433A RID: 17210
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGameData_3076874643_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400433B RID: 17211
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
