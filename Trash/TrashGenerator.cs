using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000544 RID: 1348
	public class TrashGenerator : MonoBehaviour
	{
		// Token: 0x060076F4 RID: 30452 RVA: 0x00208140 File Offset: 0x00206340
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGenerator()
		{
			Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr);
			TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "TRASH_GENERATION_FRACTION");
			TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "DEFAULT_TRASH_PER_M2");
			TrashGenerator.NativeFieldInfoPtr_AllGenerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "AllGenerators");
			TrashGenerator.NativeFieldInfoPtr_MaxTrashCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "MaxTrashCount");
			TrashGenerator.NativeFieldInfoPtr_generatedTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "generatedTrash");
			TrashGenerator.NativeFieldInfoPtr_GroundCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "GroundCheckMask");
			TrashGenerator.NativeFieldInfoPtr_boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "boxCollider");
			TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<GUID>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "StaticGUID");
			TrashGenerator.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678356);
			TrashGenerator.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678357);
			TrashGenerator.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678358);
			TrashGenerator.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678359);
			TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678360);
			TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678361);
			TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678362);
			TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678363);
			TrashGenerator.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678364);
			TrashGenerator.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678365);
			TrashGenerator.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678366);
			TrashGenerator.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678367);
			TrashGenerator.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678368);
			TrashGenerator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678369);
			TrashGenerator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678370);
			TrashGenerator.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678371);
			TrashGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678372);
			TrashGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678373);
			TrashGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678374);
			TrashGenerator.NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678375);
			TrashGenerator.NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678376);
			TrashGenerator.NativeMethodInfoPtr_RegenerateGUID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678377);
			TrashGenerator.NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678378);
			TrashGenerator.NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678379);
			TrashGenerator.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678380);
			TrashGenerator.NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678381);
			TrashGenerator.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678382);
			TrashGenerator.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_TrashGeneratorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678383);
			TrashGenerator.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678384);
			TrashGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678385);
		}

		// Token: 0x170023DF RID: 9183
		// (get) Token: 0x060076F5 RID: 30453 RVA: 0x002084B8 File Offset: 0x002066B8
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232156, XrefRangeEnd = 232161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170023E0 RID: 9184
		// (get) Token: 0x060076F6 RID: 30454 RVA: 0x002084F0 File Offset: 0x002066F0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232161, XrefRangeEnd = 232166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x060076F7 RID: 30455 RVA: 0x00208528 File Offset: 0x00206728
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x060076F8 RID: 30456 RVA: 0x00208568 File Offset: 0x00206768
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x060076F9 RID: 30457 RVA: 0x002085A4 File Offset: 0x002067A4
		// (set) Token: 0x060076FA RID: 30458 RVA: 0x002085E4 File Offset: 0x002067E4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37506, RefRangeEnd = 37507, XrefRangeStart = 37506, XrefRangeEnd = 37507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023E4 RID: 9188
		// (get) Token: 0x060076FB RID: 30459 RVA: 0x00208628 File Offset: 0x00206828
		// (set) Token: 0x060076FC RID: 30460 RVA: 0x00208668 File Offset: 0x00206868
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023E5 RID: 9189
		// (get) Token: 0x060076FD RID: 30461 RVA: 0x002086AC File Offset: 0x002068AC
		// (set) Token: 0x060076FE RID: 30462 RVA: 0x002086E8 File Offset: 0x002068E8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023E6 RID: 9190
		// (get) Token: 0x060076FF RID: 30463 RVA: 0x00208728 File Offset: 0x00206928
		// (set) Token: 0x06007700 RID: 30464 RVA: 0x00208764 File Offset: 0x00206964
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x002087A4 File Offset: 0x002069A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232166, XrefRangeEnd = 232170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x002087E4 File Offset: 0x002069E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232170, XrefRangeEnd = 232180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x00208818 File Offset: 0x00206A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232180, XrefRangeEnd = 232206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x0020884C File Offset: 0x00206A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232206, XrefRangeEnd = 232212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGenerator.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x00208888 File Offset: 0x00206A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232212, XrefRangeEnd = 232216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x002088BC File Offset: 0x00206ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232216, XrefRangeEnd = 232224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x002088F0 File Offset: 0x00206AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232224, XrefRangeEnd = 232240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00208924 File Offset: 0x00206B24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 232259, RefRangeEnd = 232262, XrefRangeStart = 232240, XrefRangeEnd = 232259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGeneratedTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00208968 File Offset: 0x00206B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232262, XrefRangeEnd = 232278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGeneratedTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x002089AC File Offset: 0x00206BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232278, XrefRangeEnd = 232281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_RegenerateGUID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x002089E0 File Offset: 0x00206BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232281, XrefRangeEnd = 232295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCalculateTrashCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x00208A14 File Offset: 0x00206C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232295, XrefRangeEnd = 232298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMaxTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00208A48 File Offset: 0x00206C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232298, XrefRangeEnd = 232305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00208A7C File Offset: 0x00206C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232374, RefRangeEnd = 232376, XrefRangeStart = 232305, XrefRangeEnd = 232374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTrash(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref count;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x00208ABC File Offset: 0x00206CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232377, RefRangeEnd = 232378, XrefRangeStart = 232376, XrefRangeEnd = 232377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x00208AF8 File Offset: 0x00206CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232378, XrefRangeEnd = 232404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashGeneratorData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGenerator.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_TrashGeneratorData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGeneratorData>(intPtr2) : null;
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00208B44 File Offset: 0x00206D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232404, XrefRangeEnd = 232405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00208B7C File Offset: 0x00206D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232405, XrefRangeEnd = 232428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00038343 File Offset: 0x00036543
		public TrashGenerator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D3 RID: 9171
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00208BB8 File Offset: 0x00206DB8
		// (set) Token: 0x06007715 RID: 30485 RVA: 0x0003834C File Offset: 0x0003654C
		public unsafe static float TRASH_GENERATION_FRACTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION, (void*)(&value));
			}
		}

		// Token: 0x170023D4 RID: 9172
		// (get) Token: 0x06007716 RID: 30486 RVA: 0x00208BD4 File Offset: 0x00206DD4
		// (set) Token: 0x06007717 RID: 30487 RVA: 0x0003835A File Offset: 0x0003655A
		public unsafe static float DEFAULT_TRASH_PER_M2
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2, (void*)(&value));
			}
		}

		// Token: 0x170023D5 RID: 9173
		// (get) Token: 0x06007718 RID: 30488 RVA: 0x00208BF0 File Offset: 0x00206DF0
		// (set) Token: 0x06007719 RID: 30489 RVA: 0x00038368 File Offset: 0x00036568
		public unsafe static List<TrashGenerator> AllGenerators
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_AllGenerators, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashGenerator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_AllGenerators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D6 RID: 9174
		// (get) Token: 0x0600771A RID: 30490 RVA: 0x00208C18 File Offset: 0x00206E18
		// (set) Token: 0x0600771B RID: 30491 RVA: 0x0003837A File Offset: 0x0003657A
		public unsafe int MaxTrashCount
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_MaxTrashCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_MaxTrashCount)) = value;
			}
		}

		// Token: 0x170023D7 RID: 9175
		// (get) Token: 0x0600771C RID: 30492 RVA: 0x00208C40 File Offset: 0x00206E40
		// (set) Token: 0x0600771D RID: 30493 RVA: 0x00038395 File Offset: 0x00036595
		public unsafe List<TrashItem> generatedTrash
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_generatedTrash);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_generatedTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D8 RID: 9176
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x00208C70 File Offset: 0x00206E70
		// (set) Token: 0x0600771F RID: 30495 RVA: 0x000383B4 File Offset: 0x000365B4
		public unsafe LayerMask GroundCheckMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_GroundCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_GroundCheckMask)) = value;
			}
		}

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x00208C98 File Offset: 0x00206E98
		// (set) Token: 0x06007721 RID: 30497 RVA: 0x000383CF File Offset: 0x000365CF
		public unsafe BoxCollider boxCollider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_boxCollider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_boxCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x06007722 RID: 30498 RVA: 0x00208CC8 File Offset: 0x00206EC8
		// (set) Token: 0x06007723 RID: 30499 RVA: 0x000383EE File Offset: 0x000365EE
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x00208CF8 File Offset: 0x00206EF8
		// (set) Token: 0x06007725 RID: 30501 RVA: 0x0003840D File Offset: 0x0003660D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06007726 RID: 30502 RVA: 0x00208D28 File Offset: 0x00206F28
		// (set) Token: 0x06007727 RID: 30503 RVA: 0x0003842C File Offset: 0x0003662C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170023DD RID: 9181
		// (get) Token: 0x06007728 RID: 30504 RVA: 0x00208D50 File Offset: 0x00206F50
		// (set) Token: 0x06007729 RID: 30505 RVA: 0x00038447 File Offset: 0x00036647
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170023DE RID: 9182
		// (get) Token: 0x0600772A RID: 30506 RVA: 0x00208D78 File Offset: 0x00206F78
		// (set) Token: 0x0600772B RID: 30507 RVA: 0x00038462 File Offset: 0x00036662
		public unsafe string StaticGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400513E RID: 20798
		private static readonly System.IntPtr NativeFieldInfoPtr_TRASH_GENERATION_FRACTION;

		// Token: 0x0400513F RID: 20799
		private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2;

		// Token: 0x04005140 RID: 20800
		private static readonly System.IntPtr NativeFieldInfoPtr_AllGenerators;

		// Token: 0x04005141 RID: 20801
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxTrashCount;

		// Token: 0x04005142 RID: 20802
		private static readonly System.IntPtr NativeFieldInfoPtr_generatedTrash;

		// Token: 0x04005143 RID: 20803
		private static readonly System.IntPtr NativeFieldInfoPtr_GroundCheckMask;

		// Token: 0x04005144 RID: 20804
		private static readonly System.IntPtr NativeFieldInfoPtr_boxCollider;

		// Token: 0x04005145 RID: 20805
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04005146 RID: 20806
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04005147 RID: 20807
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04005148 RID: 20808
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04005149 RID: 20809
		private static readonly System.IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x0400514A RID: 20810
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400514B RID: 20811
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400514C RID: 20812
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400514D RID: 20813
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400514E RID: 20814
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400514F RID: 20815
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005150 RID: 20816
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005151 RID: 20817
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005152 RID: 20818
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005153 RID: 20819
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04005154 RID: 20820
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04005155 RID: 20821
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04005156 RID: 20822
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005157 RID: 20823
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005158 RID: 20824
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04005159 RID: 20825
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400515A RID: 20826
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400515B RID: 20827
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400515C RID: 20828
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x0400515D RID: 20829
		private static readonly System.IntPtr NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0;

		// Token: 0x0400515E RID: 20830
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0;

		// Token: 0x0400515F RID: 20831
		private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateGUID_Private_Void_0;

		// Token: 0x04005160 RID: 20832
		private static readonly System.IntPtr NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0;

		// Token: 0x04005161 RID: 20833
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0;

		// Token: 0x04005162 RID: 20834
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04005163 RID: 20835
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0;

		// Token: 0x04005164 RID: 20836
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04005165 RID: 20837
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_TrashGeneratorData_0;

		// Token: 0x04005166 RID: 20838
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04005167 RID: 20839
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADF RID: 2783
		[ObfuscatedName("ScheduleOne.Trash.TrashGenerator+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7B5 RID: 55221 RVA: 0x0033BA04 File Offset: 0x00339C04
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr);
				TrashGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, "<>9");
				TrashGenerator.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, "<>9__47_0");
				TrashGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, 100678388);
				TrashGenerator.__c.NativeMethodInfoPtr__GetSaveData_b__47_0_Internal_String_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, 100678389);
			}

			// Token: 0x0600D7B6 RID: 55222 RVA: 0x0033BA80 File Offset: 0x00339C80
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7B7 RID: 55223 RVA: 0x0033BABC File Offset: 0x00339CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232155, XrefRangeEnd = 232156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetSaveData_b__47_0(TrashItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.__c.NativeMethodInfoPtr__GetSaveData_b__47_0_Internal_String_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}

			// Token: 0x0600D7B8 RID: 55224 RVA: 0x00068AE2 File Offset: 0x00066CE2
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700429D RID: 17053
			// (get) Token: 0x0600D7B9 RID: 55225 RVA: 0x0033BB04 File Offset: 0x00339D04
			// (set) Token: 0x0600D7BA RID: 55226 RVA: 0x00068AEB File Offset: 0x00066CEB
			public unsafe static TrashGenerator.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700429E RID: 17054
			// (get) Token: 0x0600D7BB RID: 55227 RVA: 0x0033BB2C File Offset: 0x00339D2C
			// (set) Token: 0x0600D7BC RID: 55228 RVA: 0x00068AFD File Offset: 0x00066CFD
			public unsafe static Il2CppSystem.Converter<TrashItem, string> __9__47_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashGenerator.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Converter<TrashItem, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashGenerator.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400917F RID: 37247
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009180 RID: 37248
			private static readonly System.IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x04009181 RID: 37249
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009182 RID: 37250
			private static readonly System.IntPtr NativeMethodInfoPtr__GetSaveData_b__47_0_Internal_String_TrashItem_0;
		}
	}
}
