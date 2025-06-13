using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x020005A4 RID: 1444
	public class WorldStorageEntity : StorageEntity
	{
		// Token: 0x06007E1E RID: 32286 RVA: 0x0022094C File Offset: 0x0021EB4C
		// Note: this type is marked as 'beforefieldinit'.
		static WorldStorageEntity()
		{
			Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "WorldStorageEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr);
			WorldStorageEntity.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "All");
			WorldStorageEntity.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<GUID>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "BakedGUID");
			WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "<HasChanged>k__BackingField");
			WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted");
			WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Storage.WorldStorageEntityAssembly-CSharp.dll_Excuted");
			WorldStorageEntity.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679205);
			WorldStorageEntity.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679206);
			WorldStorageEntity.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679207);
			WorldStorageEntity.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679208);
			WorldStorageEntity.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679209);
			WorldStorageEntity.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679210);
			WorldStorageEntity.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679211);
			WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679212);
			WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679213);
			WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679214);
			WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679215);
			WorldStorageEntity.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679216);
			WorldStorageEntity.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679217);
			WorldStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679218);
			WorldStorageEntity.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679219);
			WorldStorageEntity.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679220);
			WorldStorageEntity.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679221);
			WorldStorageEntity.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679222);
			WorldStorageEntity.NativeMethodInfoPtr_GetSaveData_Public_WorldStorageEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679223);
			WorldStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679224);
			WorldStorageEntity.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_WorldStorageEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679225);
			WorldStorageEntity.NativeMethodInfoPtr_ContentsChanged_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679226);
			WorldStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679227);
			WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679229);
			WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679230);
			WorldStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679231);
			WorldStorageEntity.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr, 100679232);
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x06007E1F RID: 32287 RVA: 0x00220C38 File Offset: 0x0021EE38
		// (set) Token: 0x06007E20 RID: 32288 RVA: 0x00220C74 File Offset: 0x0021EE74
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x00220CB4 File Offset: 0x0021EEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240923, XrefRangeEnd = 240926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x170025EE RID: 9710
		// (get) Token: 0x06007E22 RID: 32290 RVA: 0x00220CE8 File Offset: 0x0021EEE8
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240926, XrefRangeEnd = 240931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x06007E23 RID: 32291 RVA: 0x00220D20 File Offset: 0x0021EF20
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240931, XrefRangeEnd = 240936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x00220D58 File Offset: 0x0021EF58
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x06007E25 RID: 32293 RVA: 0x00220D98 File Offset: 0x0021EF98
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x00220DD4 File Offset: 0x0021EFD4
		// (set) Token: 0x06007E27 RID: 32295 RVA: 0x00220E14 File Offset: 0x0021F014
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240936, XrefRangeEnd = 240937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025F3 RID: 9715
		// (get) Token: 0x06007E28 RID: 32296 RVA: 0x00220E58 File Offset: 0x0021F058
		// (set) Token: 0x06007E29 RID: 32297 RVA: 0x00220E98 File Offset: 0x0021F098
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240937, XrefRangeEnd = 240938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06007E2A RID: 32298 RVA: 0x00220EDC File Offset: 0x0021F0DC
		// (set) Token: 0x06007E2B RID: 32299 RVA: 0x00220F18 File Offset: 0x0021F118
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x00220F58 File Offset: 0x0021F158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240938, XrefRangeEnd = 240939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x00220F94 File Offset: 0x0021F194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240939, XrefRangeEnd = 240948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x00220FD0 File Offset: 0x0021F1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240948, XrefRangeEnd = 240954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x0022100C File Offset: 0x0021F20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240954, XrefRangeEnd = 240958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0022104C File Offset: 0x0021F24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240958, XrefRangeEnd = 240959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x00221094 File Offset: 0x0021F294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 240967, RefRangeEnd = 240969, XrefRangeStart = 240959, XrefRangeEnd = 240967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntityData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr_GetSaveData_Public_WorldStorageEntityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldStorageEntityData>(intPtr2) : null;
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x002210D4 File Offset: 0x0021F2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240969, XrefRangeEnd = 240971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x00221118 File Offset: 0x0021F318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240971, XrefRangeEnd = 240973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(WorldStorageEntityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_WorldStorageEntityData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x00221168 File Offset: 0x0021F368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240973, XrefRangeEnd = 240974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_ContentsChanged_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x002211A4 File Offset: 0x0021F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240974, XrefRangeEnd = 240999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldStorageEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldStorageEntity>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x002211E0 File Offset: 0x0021F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240999, XrefRangeEnd = 241000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0022121C File Offset: 0x0021F41C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x00221258 File Offset: 0x0021F458
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x00221294 File Offset: 0x0021F494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 241039, RefRangeEnd = 241040, XrefRangeStart = 241000, XrefRangeEnd = 241039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldStorageEntity.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x0003B973 File Offset: 0x00039B73
		public WorldStorageEntity(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025E5 RID: 9701
		// (get) Token: 0x06007E3B RID: 32315 RVA: 0x002212D0 File Offset: 0x0021F4D0
		// (set) Token: 0x06007E3C RID: 32316 RVA: 0x0003B97C File Offset: 0x00039B7C
		public unsafe static List<WorldStorageEntity> All
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WorldStorageEntity.NativeFieldInfoPtr_All, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldStorageEntity>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldStorageEntity.NativeFieldInfoPtr_All, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E6 RID: 9702
		// (get) Token: 0x06007E3D RID: 32317 RVA: 0x002212F8 File Offset: 0x0021F4F8
		// (set) Token: 0x06007E3E RID: 32318 RVA: 0x0003B98E File Offset: 0x00039B8E
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170025E7 RID: 9703
		// (get) Token: 0x06007E3F RID: 32319 RVA: 0x00221320 File Offset: 0x0021F520
		// (set) Token: 0x06007E40 RID: 32320 RVA: 0x0003B9A9 File Offset: 0x00039BA9
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170025E8 RID: 9704
		// (get) Token: 0x06007E41 RID: 32321 RVA: 0x00221348 File Offset: 0x0021F548
		// (set) Token: 0x06007E42 RID: 32322 RVA: 0x0003B9C8 File Offset: 0x00039BC8
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025E9 RID: 9705
		// (get) Token: 0x06007E43 RID: 32323 RVA: 0x00221378 File Offset: 0x0021F578
		// (set) Token: 0x06007E44 RID: 32324 RVA: 0x0003B9E7 File Offset: 0x00039BE7
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06007E45 RID: 32325 RVA: 0x002213A8 File Offset: 0x0021F5A8
		// (set) Token: 0x06007E46 RID: 32326 RVA: 0x0003BA06 File Offset: 0x00039C06
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x06007E47 RID: 32327 RVA: 0x002213D0 File Offset: 0x0021F5D0
		// (set) Token: 0x06007E48 RID: 32328 RVA: 0x0003BA21 File Offset: 0x00039C21
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x06007E49 RID: 32329 RVA: 0x002213F8 File Offset: 0x0021F5F8
		// (set) Token: 0x06007E4A RID: 32330 RVA: 0x0003BA3C File Offset: 0x00039C3C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040055E6 RID: 21990
		private static readonly System.IntPtr NativeFieldInfoPtr_All;

		// Token: 0x040055E7 RID: 21991
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x040055E8 RID: 21992
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x040055E9 RID: 21993
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040055EA RID: 21994
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040055EB RID: 21995
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040055EC RID: 21996
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040055ED RID: 21997
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040055EE RID: 21998
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040055EF RID: 21999
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040055F0 RID: 22000
		private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x040055F1 RID: 22001
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040055F2 RID: 22002
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040055F3 RID: 22003
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040055F4 RID: 22004
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040055F5 RID: 22005
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040055F6 RID: 22006
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040055F7 RID: 22007
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040055F8 RID: 22008
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040055F9 RID: 22009
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040055FA RID: 22010
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040055FB RID: 22011
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040055FC RID: 22012
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x040055FD RID: 22013
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040055FE RID: 22014
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040055FF RID: 22015
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04005600 RID: 22016
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_WorldStorageEntityData_0;

		// Token: 0x04005601 RID: 22017
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04005602 RID: 22018
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_WorldStorageEntityData_0;

		// Token: 0x04005603 RID: 22019
		private static readonly System.IntPtr NativeMethodInfoPtr_ContentsChanged_Protected_Virtual_Void_1;

		// Token: 0x04005604 RID: 22020
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005605 RID: 22021
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005606 RID: 22022
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005607 RID: 22023
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005608 RID: 22024
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
