using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.AI.Navigation;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000408 RID: 1032
	public class PlayerManager : Singleton<PlayerManager>
	{
		// Token: 0x060052BF RID: 21183 RVA: 0x0018B2B4 File Offset: 0x001894B4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerManager()
		{
			Il2CppClassPointerStore<PlayerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr);
			PlayerManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loader");
			PlayerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			PlayerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			PlayerManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			PlayerManager.NativeFieldInfoPtr_loadedPlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loadedPlayerData");
			PlayerManager.NativeFieldInfoPtr_loadedPlayerDataPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loadedPlayerDataPaths");
			PlayerManager.NativeFieldInfoPtr_loadedPlayerFileNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "loadedPlayerFileNames");
			PlayerManager.NativeFieldInfoPtr_PlayerRecoverySurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "PlayerRecoverySurface");
			PlayerManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673761);
			PlayerManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673762);
			PlayerManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673763);
			PlayerManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673764);
			PlayerManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673765);
			PlayerManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673766);
			PlayerManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673767);
			PlayerManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673768);
			PlayerManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673769);
			PlayerManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673770);
			PlayerManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673771);
			PlayerManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673772);
			PlayerManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673773);
			PlayerManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673774);
			PlayerManager.NativeMethodInfoPtr_SavePlayer_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673775);
			PlayerManager.NativeMethodInfoPtr_LoadPlayer_Public_Void_PlayerData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673776);
			PlayerManager.NativeMethodInfoPtr_AllPlayerFilesLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673777);
			PlayerManager.NativeMethodInfoPtr_TryGetPlayerData_Public_Boolean_String_byref_PlayerData_byref_String_byref_String_byref_String_byref_Il2CppReferenceArray_1_VariableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673778);
			PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100673779);
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x060052C0 RID: 21184 RVA: 0x0018B500 File Offset: 0x00189700
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180597, XrefRangeEnd = 180599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x060052C1 RID: 21185 RVA: 0x0018B538 File Offset: 0x00189738
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180599, XrefRangeEnd = 180601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x060052C2 RID: 21186 RVA: 0x0018B570 File Offset: 0x00189770
		public unsafe virtual Loader Loader
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x060052C3 RID: 21187 RVA: 0x0018B5B0 File Offset: 0x001897B0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x060052C4 RID: 21188 RVA: 0x0018B5EC File Offset: 0x001897EC
		// (set) Token: 0x060052C5 RID: 21189 RVA: 0x0018B62C File Offset: 0x0018982C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x060052C6 RID: 21190 RVA: 0x0018B670 File Offset: 0x00189870
		// (set) Token: 0x060052C7 RID: 21191 RVA: 0x0018B6B0 File Offset: 0x001898B0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 21004, RefRangeEnd = 21011, XrefRangeStart = 21004, XrefRangeEnd = 21011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x060052C8 RID: 21192 RVA: 0x0018B6F4 File Offset: 0x001898F4
		// (set) Token: 0x060052C9 RID: 21193 RVA: 0x0018B730 File Offset: 0x00189930
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x0018B770 File Offset: 0x00189970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180601, XrefRangeEnd = 180604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x0018B7AC File Offset: 0x001899AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180604, XrefRangeEnd = 180610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x0018B7E8 File Offset: 0x001899E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180610, XrefRangeEnd = 180612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0018B82C File Offset: 0x00189A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180612, XrefRangeEnd = 180702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0018B888 File Offset: 0x00189A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180758, RefRangeEnd = 180759, XrefRangeStart = 180702, XrefRangeEnd = 180758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SavePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_SavePlayer_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x0018B8CC File Offset: 0x00189ACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180815, RefRangeEnd = 180816, XrefRangeStart = 180759, XrefRangeEnd = 180815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPlayer(PlayerData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_LoadPlayer_Public_Void_PlayerData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x0018B920 File Offset: 0x00189B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180816, XrefRangeEnd = 180855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AllPlayerFilesLoaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_AllPlayerFilesLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x0018B954 File Offset: 0x00189B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180964, RefRangeEnd = 180965, XrefRangeStart = 180855, XrefRangeEnd = 180964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetPlayerData(string playerCode, out PlayerData data, out string inventoryString, out string appearanceString, out string clothingString, out Il2CppReferenceArray<VariableData> variables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(playerCode);
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr3 = &il2CppString;
			ref System.IntPtr ptr4 = ref ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString2 = 0;
			ptr4 = &il2CppString2;
			ref System.IntPtr ptr5 = ref ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString3 = 0;
			ptr5 = &il2CppString3;
			ref System.IntPtr ptr6 = ref ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr2 = 0;
			ptr6 = &intPtr2;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_TryGetPlayerData_Public_Boolean_String_byref_PlayerData_byref_String_byref_String_byref_String_byref_Il2CppReferenceArray_1_VariableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			data = ((intPtr3 == 0) ? null : new PlayerData(intPtr3));
			inventoryString = IL2CPP.Il2CppStringToManaged(il2CppString);
			appearanceString = IL2CPP.Il2CppStringToManaged(il2CppString2);
			clothingString = IL2CPP.Il2CppStringToManaged(il2CppString3);
			System.IntPtr intPtr4 = intPtr2;
			variables = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<VariableData>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0018BA3C File Offset: 0x00189C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180965, XrefRangeEnd = 181002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00027239 File Offset: 0x00025439
		public PlayerManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x060052D4 RID: 21204 RVA: 0x0018BA78 File Offset: 0x00189C78
		// (set) Token: 0x060052D5 RID: 21205 RVA: 0x00027242 File Offset: 0x00025442
		public unsafe PlayersLoader loader
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loader);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayersLoader>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x060052D6 RID: 21206 RVA: 0x0018BAA8 File Offset: 0x00189CA8
		// (set) Token: 0x060052D7 RID: 21207 RVA: 0x00027261 File Offset: 0x00025461
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x060052D8 RID: 21208 RVA: 0x0018BAD8 File Offset: 0x00189CD8
		// (set) Token: 0x060052D9 RID: 21209 RVA: 0x00027280 File Offset: 0x00025480
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A7 RID: 6311
		// (get) Token: 0x060052DA RID: 21210 RVA: 0x0018BB08 File Offset: 0x00189D08
		// (set) Token: 0x060052DB RID: 21211 RVA: 0x0002729F File Offset: 0x0002549F
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170018A8 RID: 6312
		// (get) Token: 0x060052DC RID: 21212 RVA: 0x0018BB30 File Offset: 0x00189D30
		// (set) Token: 0x060052DD RID: 21213 RVA: 0x000272BA File Offset: 0x000254BA
		public unsafe List<PlayerData> loadedPlayerData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x060052DE RID: 21214 RVA: 0x0018BB60 File Offset: 0x00189D60
		// (set) Token: 0x060052DF RID: 21215 RVA: 0x000272D9 File Offset: 0x000254D9
		public unsafe List<string> loadedPlayerDataPaths
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerDataPaths);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerDataPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x060052E0 RID: 21216 RVA: 0x0018BB90 File Offset: 0x00189D90
		// (set) Token: 0x060052E1 RID: 21217 RVA: 0x000272F8 File Offset: 0x000254F8
		public unsafe List<string> loadedPlayerFileNames
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerFileNames);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_loadedPlayerFileNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x060052E2 RID: 21218 RVA: 0x0018BBC0 File Offset: 0x00189DC0
		// (set) Token: 0x060052E3 RID: 21219 RVA: 0x00027317 File Offset: 0x00025517
		public unsafe NavMeshSurface PlayerRecoverySurface
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_PlayerRecoverySurface);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavMeshSurface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_PlayerRecoverySurface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003825 RID: 14373
		private static readonly System.IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04003826 RID: 14374
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003827 RID: 14375
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003828 RID: 14376
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003829 RID: 14377
		private static readonly System.IntPtr NativeFieldInfoPtr_loadedPlayerData;

		// Token: 0x0400382A RID: 14378
		private static readonly System.IntPtr NativeFieldInfoPtr_loadedPlayerDataPaths;

		// Token: 0x0400382B RID: 14379
		private static readonly System.IntPtr NativeFieldInfoPtr_loadedPlayerFileNames;

		// Token: 0x0400382C RID: 14380
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRecoverySurface;

		// Token: 0x0400382D RID: 14381
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400382E RID: 14382
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400382F RID: 14383
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003830 RID: 14384
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003831 RID: 14385
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003832 RID: 14386
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003833 RID: 14387
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003834 RID: 14388
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003835 RID: 14389
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003836 RID: 14390
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003837 RID: 14391
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003838 RID: 14392
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003839 RID: 14393
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400383A RID: 14394
		private static readonly System.IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x0400383B RID: 14395
		private static readonly System.IntPtr NativeMethodInfoPtr_SavePlayer_Public_Void_Player_0;

		// Token: 0x0400383C RID: 14396
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadPlayer_Public_Void_PlayerData_String_0;

		// Token: 0x0400383D RID: 14397
		private static readonly System.IntPtr NativeMethodInfoPtr_AllPlayerFilesLoaded_Public_Void_0;

		// Token: 0x0400383E RID: 14398
		private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPlayerData_Public_Boolean_String_byref_PlayerData_byref_String_byref_String_byref_String_byref_Il2CppReferenceArray_1_VariableData_0;

		// Token: 0x0400383F RID: 14399
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009EF RID: 2543
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D062 RID: 53346 RVA: 0x003271F8 File Offset: 0x003253F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr, "i");
				PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr, 100673780);
				PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__WriteData_b__0_Internal_Boolean_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr, 100673781);
			}

			// Token: 0x0600D063 RID: 53347 RVA: 0x00327260 File Offset: 0x00325460
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass28_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D064 RID: 53348 RVA: 0x0032729C File Offset: 0x0032549C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180579, XrefRangeEnd = 180589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _WriteData_b__0(PlayerData PlayerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerData);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass28_0.NativeMethodInfoPtr__WriteData_b__0_Internal_Boolean_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D065 RID: 53349 RVA: 0x000650A4 File Offset: 0x000632A4
			public __c__DisplayClass28_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409B RID: 16539
			// (get) Token: 0x0600D066 RID: 53350 RVA: 0x003272EC File Offset: 0x003254EC
			// (set) Token: 0x0600D067 RID: 53351 RVA: 0x000650AD File Offset: 0x000632AD
			public unsafe int i
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass28_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x04008CEE RID: 36078
			private static readonly System.IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008CEF RID: 36079
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF0 RID: 36080
			private static readonly System.IntPtr NativeMethodInfoPtr__WriteData_b__0_Internal_Boolean_PlayerData_0;
		}

		// Token: 0x020009F0 RID: 2544
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D068 RID: 53352 RVA: 0x00327314 File Offset: 0x00325514
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass29_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr, "player");
				PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr, 100673782);
				PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__SavePlayer_b__0_Internal_Boolean_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr, 100673783);
			}

			// Token: 0x0600D069 RID: 53353 RVA: 0x0032737C File Offset: 0x0032557C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass29_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D06A RID: 53354 RVA: 0x003273B8 File Offset: 0x003255B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180589, XrefRangeEnd = 180592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SavePlayer_b__0(PlayerData PlayerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerData);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass29_0.NativeMethodInfoPtr__SavePlayer_b__0_Internal_Boolean_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D06B RID: 53355 RVA: 0x000650C8 File Offset: 0x000632C8
			public __c__DisplayClass29_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409C RID: 16540
			// (get) Token: 0x0600D06C RID: 53356 RVA: 0x00327408 File Offset: 0x00325608
			// (set) Token: 0x0600D06D RID: 53357 RVA: 0x000650D1 File Offset: 0x000632D1
			public unsafe Player player
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass29_0.NativeFieldInfoPtr_player);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass29_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CF1 RID: 36081
			private static readonly System.IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04008CF2 RID: 36082
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF3 RID: 36083
			private static readonly System.IntPtr NativeMethodInfoPtr__SavePlayer_b__0_Internal_Boolean_PlayerData_0;
		}

		// Token: 0x020009F1 RID: 2545
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D06E RID: 53358 RVA: 0x00327438 File Offset: 0x00325638
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass30_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr, "data");
				PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr, 100673784);
				PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__LoadPlayer_b__0_Internal_Boolean_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr, 100673785);
			}

			// Token: 0x0600D06F RID: 53359 RVA: 0x003274A0 File Offset: 0x003256A0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass30_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D070 RID: 53360 RVA: 0x003274DC File Offset: 0x003256DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180592, XrefRangeEnd = 180595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPlayer_b__0(Player Player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(Player);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass30_0.NativeMethodInfoPtr__LoadPlayer_b__0_Internal_Boolean_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D071 RID: 53361 RVA: 0x000650F0 File Offset: 0x000632F0
			public __c__DisplayClass30_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409D RID: 16541
			// (get) Token: 0x0600D072 RID: 53362 RVA: 0x0032752C File Offset: 0x0032572C
			// (set) Token: 0x0600D073 RID: 53363 RVA: 0x000650F9 File Offset: 0x000632F9
			public unsafe PlayerData data
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass30_0.NativeFieldInfoPtr_data);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass30_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CF4 RID: 36084
			private static readonly System.IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008CF5 RID: 36085
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF6 RID: 36086
			private static readonly System.IntPtr NativeMethodInfoPtr__LoadPlayer_b__0_Internal_Boolean_Player_0;
		}

		// Token: 0x020009F2 RID: 2546
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerManager+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D074 RID: 53364 RVA: 0x0032755C File Offset: 0x0032575C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr);
				PlayerManager.__c__DisplayClass32_0.NativeFieldInfoPtr_playerCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr, "playerCode");
				PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr, 100673786);
				PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__TryGetPlayerData_b__0_Internal_Boolean_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr, 100673787);
			}

			// Token: 0x0600D075 RID: 53365 RVA: 0x003275C4 File Offset: 0x003257C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager.__c__DisplayClass32_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D076 RID: 53366 RVA: 0x00327600 File Offset: 0x00325800
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180595, XrefRangeEnd = 180597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetPlayerData_b__0(PlayerData PlayerData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(PlayerData);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PlayerManager.__c__DisplayClass32_0.NativeMethodInfoPtr__TryGetPlayerData_b__0_Internal_Boolean_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D077 RID: 53367 RVA: 0x00065118 File Offset: 0x00063318
			public __c__DisplayClass32_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700409E RID: 16542
			// (get) Token: 0x0600D078 RID: 53368 RVA: 0x00327650 File Offset: 0x00325850
			// (set) Token: 0x0600D079 RID: 53369 RVA: 0x00065121 File Offset: 0x00063321
			public unsafe string playerCode
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass32_0.NativeFieldInfoPtr_playerCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.__c__DisplayClass32_0.NativeFieldInfoPtr_playerCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008CF7 RID: 36087
			private static readonly System.IntPtr NativeFieldInfoPtr_playerCode;

			// Token: 0x04008CF8 RID: 36088
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF9 RID: 36089
			private static readonly System.IntPtr NativeMethodInfoPtr__TryGetPlayerData_b__0_Internal_Boolean_PlayerData_0;
		}
	}
}
