using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Dragging;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000545 RID: 1349
	public class TrashItem : MonoBehaviour
	{
		// Token: 0x0600772C RID: 30508 RVA: 0x00208DA0 File Offset: 0x00206FA0
		// Note: this type is marked as 'beforefieldinit'.
		static TrashItem()
		{
			Il2CppClassPointerStore<TrashItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashItem>.NativeClassPtr);
			TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "POSITION_CHANGE_THRESHOLD");
			TrashItem.NativeFieldInfoPtr_LINEAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "LINEAR_DRAG");
			TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ANGULAR_DRAG");
			TrashItem.NativeFieldInfoPtr_MIN_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "MIN_Y");
			TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "INTERACTION_PRIORITY");
			TrashItem.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Rigidbody");
			TrashItem.NativeFieldInfoPtr_Draggable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Draggable");
			TrashItem.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "ID");
			TrashItem.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "Size");
			TrashItem.NativeFieldInfoPtr_SellValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "SellValue");
			TrashItem.NativeFieldInfoPtr_CanGoInContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "CanGoInContainer");
			TrashItem.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "colliders");
			TrashItem.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<GUID>k__BackingField");
			TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			TrashItem.NativeFieldInfoPtr_lastPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "lastPosition");
			TrashItem.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "onDestroyed");
			TrashItem.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "collidersEnabled");
			TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "timeOnPhysicsEnabled");
			TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678390);
			TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678391);
			TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678392);
			TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678393);
			TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678394);
			TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678395);
			TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678396);
			TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678397);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678398);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678399);
			TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678400);
			TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678401);
			TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678402);
			TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678403);
			TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678404);
			TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678405);
			TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678406);
			TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678407);
			TrashItem.NativeMethodInfoPtr_MinPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678408);
			TrashItem.NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678409);
			TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678410);
			TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678411);
			TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678412);
			TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678413);
			TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678414);
			TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678415);
			TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678416);
			TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678417);
			TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678418);
			TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678419);
			TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678420);
			TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678421);
			TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678422);
			TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678423);
			TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678424);
			TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678425);
			TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678426);
			TrashItem.NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678427);
			TrashItem.NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashItem>.NativeClassPtr, 100678428);
		}

		// Token: 0x170023FC RID: 9212
		// (get) Token: 0x0600772D RID: 30509 RVA: 0x00209280 File Offset: 0x00207480
		// (set) Token: 0x0600772E RID: 30510 RVA: 0x002092BC File Offset: 0x002074BC
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023FD RID: 9213
		// (get) Token: 0x0600772F RID: 30511 RVA: 0x002092FC File Offset: 0x002074FC
		// (set) Token: 0x06007730 RID: 30512 RVA: 0x0020933C File Offset: 0x0020753C
		public unsafe Property CurrentProperty
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 49659, RefRangeEnd = 49699, XrefRangeStart = 49659, XrefRangeEnd = 49699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170023FE RID: 9214
		// (get) Token: 0x06007731 RID: 30513 RVA: 0x00209380 File Offset: 0x00207580
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232428, XrefRangeEnd = 232433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x170023FF RID: 9215
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x002093B8 File Offset: 0x002075B8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232433, XrefRangeEnd = 232438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x17002400 RID: 9216
		// (get) Token: 0x06007733 RID: 30515 RVA: 0x002093F0 File Offset: 0x002075F0
		public unsafe virtual Loader Loader
		{
			[CallerCount(70)]
			[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr2) : null;
			}
		}

		// Token: 0x17002401 RID: 9217
		// (get) Token: 0x06007734 RID: 30516 RVA: 0x00209430 File Offset: 0x00207630
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(176)]
			[CachedScanResults(RefRangeStart = 38110, RefRangeEnd = 38286, XrefRangeStart = 38110, XrefRangeEnd = 38286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17002402 RID: 9218
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x0020946C File Offset: 0x0020766C
		// (set) Token: 0x06007736 RID: 30518 RVA: 0x002094AC File Offset: 0x002076AC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 48192, RefRangeEnd = 48202, XrefRangeStart = 48192, XrefRangeEnd = 48202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99021, RefRangeEnd = 99022, XrefRangeStart = 99021, XrefRangeEnd = 99022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002403 RID: 9219
		// (get) Token: 0x06007737 RID: 30519 RVA: 0x002094F0 File Offset: 0x002076F0
		// (set) Token: 0x06007738 RID: 30520 RVA: 0x00209530 File Offset: 0x00207730
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 32536, RefRangeEnd = 32547, XrefRangeStart = 32536, XrefRangeEnd = 32547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002404 RID: 9220
		// (get) Token: 0x06007739 RID: 30521 RVA: 0x00209574 File Offset: 0x00207774
		// (set) Token: 0x0600773A RID: 30522 RVA: 0x002095B0 File Offset: 0x002077B0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x002095F0 File Offset: 0x002077F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232438, XrefRangeEnd = 232498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Awake_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00209624 File Offset: 0x00207824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232498, XrefRangeEnd = 232549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00209658 File Offset: 0x00207858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232549, XrefRangeEnd = 232555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00209694 File Offset: 0x00207894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232555, XrefRangeEnd = 232584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x002096C8 File Offset: 0x002078C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232584, XrefRangeEnd = 232612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_MinPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x002096FC File Offset: 0x002078FC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mins;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x0020973C File Offset: 0x0020793C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232612, XrefRangeEnd = 232620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Hovered_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00209770 File Offset: 0x00207970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232620, XrefRangeEnd = 232627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_Interacted_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x002097A4 File Offset: 0x002079A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232643, RefRangeEnd = 232645, XrefRangeStart = 232627, XrefRangeEnd = 232643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x002097E4 File Offset: 0x002079E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232646, RefRangeEnd = 232648, XrefRangeStart = 232645, XrefRangeEnd = 232646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVelocity(Vector3 velocity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref velocity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00209824 File Offset: 0x00207A24
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 232654, RefRangeEnd = 232665, XrefRangeStart = 232648, XrefRangeEnd = 232654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_DestroyTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00209858 File Offset: 0x00207A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232665, XrefRangeEnd = 232703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deinitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00209894 File Offset: 0x00207A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232703, XrefRangeEnd = 232739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x002098C8 File Offset: 0x00207AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232739, XrefRangeEnd = 232749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x002098FC File Offset: 0x00207AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232749, XrefRangeEnd = 232758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrashItemData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItemData>(intPtr2) : null;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00209948 File Offset: 0x00207B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232758, XrefRangeEnd = 232760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x0020998C File Offset: 0x00207B8C
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 31612, RefRangeEnd = 31633, XrefRangeStart = 31612, XrefRangeEnd = 31633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashItem.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x002099D4 File Offset: 0x00207BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232803, RefRangeEnd = 232805, XrefRangeStart = 232760, XrefRangeEnd = 232803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecheckProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_RecheckProperty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00209A08 File Offset: 0x00207C08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 232815, RefRangeEnd = 232821, XrefRangeStart = 232805, XrefRangeEnd = 232815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContinuousCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00209A3C File Offset: 0x00207C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232821, XrefRangeEnd = 232828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDiscreteCollisionDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00209A70 File Offset: 0x00207C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232828, XrefRangeEnd = 232831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhysicsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00209AB0 File Offset: 0x00207CB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 232834, RefRangeEnd = 232839, XrefRangeStart = 232831, XrefRangeEnd = 232834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCollidersEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00209AF0 File Offset: 0x00207CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232839, XrefRangeEnd = 232858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashItem>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00209B2C File Offset: 0x00207D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232858, XrefRangeEnd = 232859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__44_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00209B60 File Offset: 0x00207D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232859, XrefRangeEnd = 232860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__44_1(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashItem.NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00038481 File Offset: 0x00036681
		public TrashItem(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x00209BA4 File Offset: 0x00207DA4
		// (set) Token: 0x06007756 RID: 30550 RVA: 0x0003848A File Offset: 0x0003668A
		public unsafe static float POSITION_CHANGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x06007757 RID: 30551 RVA: 0x00209BC0 File Offset: 0x00207DC0
		// (set) Token: 0x06007758 RID: 30552 RVA: 0x00038498 File Offset: 0x00036698
		public unsafe static float LINEAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_LINEAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x06007759 RID: 30553 RVA: 0x00209BDC File Offset: 0x00207DDC
		// (set) Token: 0x0600775A RID: 30554 RVA: 0x000384A6 File Offset: 0x000366A6
		public unsafe static float ANGULAR_DRAG
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_ANGULAR_DRAG, (void*)(&value));
			}
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x00209BF8 File Offset: 0x00207DF8
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x000384B4 File Offset: 0x000366B4
		public unsafe static float MIN_Y
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_MIN_Y, (void*)(&value));
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x0600775D RID: 30557 RVA: 0x00209C14 File Offset: 0x00207E14
		// (set) Token: 0x0600775E RID: 30558 RVA: 0x000384C2 File Offset: 0x000366C2
		public unsafe static int INTERACTION_PRIORITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashItem.NativeFieldInfoPtr_INTERACTION_PRIORITY, (void*)(&value));
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600775F RID: 30559 RVA: 0x00209C30 File Offset: 0x00207E30
		// (set) Token: 0x06007760 RID: 30560 RVA: 0x000384D0 File Offset: 0x000366D0
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06007761 RID: 30561 RVA: 0x00209C60 File Offset: 0x00207E60
		// (set) Token: 0x06007762 RID: 30562 RVA: 0x000384EF File Offset: 0x000366EF
		public unsafe Draggable Draggable
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Draggable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x06007763 RID: 30563 RVA: 0x00209C90 File Offset: 0x00207E90
		// (set) Token: 0x06007764 RID: 30564 RVA: 0x0003850E File Offset: 0x0003670E
		public unsafe string ID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x06007765 RID: 30565 RVA: 0x00209CB8 File Offset: 0x00207EB8
		// (set) Token: 0x06007766 RID: 30566 RVA: 0x0003852D File Offset: 0x0003672D
		public unsafe int Size
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_Size)) = value;
			}
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x00209CE0 File Offset: 0x00207EE0
		// (set) Token: 0x06007768 RID: 30568 RVA: 0x00038548 File Offset: 0x00036748
		public unsafe int SellValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_SellValue)) = value;
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x00209D08 File Offset: 0x00207F08
		// (set) Token: 0x0600776A RID: 30570 RVA: 0x00038563 File Offset: 0x00036763
		public unsafe bool CanGoInContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_CanGoInContainer)) = value;
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600776B RID: 30571 RVA: 0x00209D30 File Offset: 0x00207F30
		// (set) Token: 0x0600776C RID: 30572 RVA: 0x0003857E File Offset: 0x0003677E
		public unsafe Il2CppReferenceArray<Collider> colliders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x00209D60 File Offset: 0x00207F60
		// (set) Token: 0x0600776E RID: 30574 RVA: 0x0003859D File Offset: 0x0003679D
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600776F RID: 30575 RVA: 0x00209D88 File Offset: 0x00207F88
		// (set) Token: 0x06007770 RID: 30576 RVA: 0x000385B8 File Offset: 0x000367B8
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F5 RID: 9205
		// (get) Token: 0x06007771 RID: 30577 RVA: 0x00209DB8 File Offset: 0x00207FB8
		// (set) Token: 0x06007772 RID: 30578 RVA: 0x000385D7 File Offset: 0x000367D7
		public unsafe Vector3 lastPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_lastPosition)) = value;
			}
		}

		// Token: 0x170023F6 RID: 9206
		// (get) Token: 0x06007773 RID: 30579 RVA: 0x00209DE0 File Offset: 0x00207FE0
		// (set) Token: 0x06007774 RID: 30580 RVA: 0x000385F2 File Offset: 0x000367F2
		public unsafe Il2CppSystem.Action<TrashItem> onDestroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<TrashItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023F7 RID: 9207
		// (get) Token: 0x06007775 RID: 30581 RVA: 0x00209E10 File Offset: 0x00208010
		// (set) Token: 0x06007776 RID: 30582 RVA: 0x00038611 File Offset: 0x00036811
		public unsafe bool collidersEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x170023F8 RID: 9208
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x00209E38 File Offset: 0x00208038
		// (set) Token: 0x06007778 RID: 30584 RVA: 0x0003862C File Offset: 0x0003682C
		public unsafe float timeOnPhysicsEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr_timeOnPhysicsEnabled)) = value;
			}
		}

		// Token: 0x170023F9 RID: 9209
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x00209E60 File Offset: 0x00208060
		// (set) Token: 0x0600777A RID: 30586 RVA: 0x00038647 File Offset: 0x00036847
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FA RID: 9210
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x00209E90 File Offset: 0x00208090
		// (set) Token: 0x0600777C RID: 30588 RVA: 0x00038666 File Offset: 0x00036866
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023FB RID: 9211
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x00209EC0 File Offset: 0x002080C0
		// (set) Token: 0x0600777E RID: 30590 RVA: 0x00038685 File Offset: 0x00036885
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashItem.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04005168 RID: 20840
		private static readonly System.IntPtr NativeFieldInfoPtr_POSITION_CHANGE_THRESHOLD;

		// Token: 0x04005169 RID: 20841
		private static readonly System.IntPtr NativeFieldInfoPtr_LINEAR_DRAG;

		// Token: 0x0400516A RID: 20842
		private static readonly System.IntPtr NativeFieldInfoPtr_ANGULAR_DRAG;

		// Token: 0x0400516B RID: 20843
		private static readonly System.IntPtr NativeFieldInfoPtr_MIN_Y;

		// Token: 0x0400516C RID: 20844
		private static readonly System.IntPtr NativeFieldInfoPtr_INTERACTION_PRIORITY;

		// Token: 0x0400516D RID: 20845
		private static readonly System.IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x0400516E RID: 20846
		private static readonly System.IntPtr NativeFieldInfoPtr_Draggable;

		// Token: 0x0400516F RID: 20847
		private static readonly System.IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04005170 RID: 20848
		private static readonly System.IntPtr NativeFieldInfoPtr_Size;

		// Token: 0x04005171 RID: 20849
		private static readonly System.IntPtr NativeFieldInfoPtr_SellValue;

		// Token: 0x04005172 RID: 20850
		private static readonly System.IntPtr NativeFieldInfoPtr_CanGoInContainer;

		// Token: 0x04005173 RID: 20851
		private static readonly System.IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x04005174 RID: 20852
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04005175 RID: 20853
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x04005176 RID: 20854
		private static readonly System.IntPtr NativeFieldInfoPtr_lastPosition;

		// Token: 0x04005177 RID: 20855
		private static readonly System.IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x04005178 RID: 20856
		private static readonly System.IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04005179 RID: 20857
		private static readonly System.IntPtr NativeFieldInfoPtr_timeOnPhysicsEnabled;

		// Token: 0x0400517A RID: 20858
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x0400517B RID: 20859
		private static readonly System.IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x0400517C RID: 20860
		private static readonly System.IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x0400517D RID: 20861
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400517E RID: 20862
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400517F RID: 20863
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x04005180 RID: 20864
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentProperty_Protected_set_Void_Property_0;

		// Token: 0x04005181 RID: 20865
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005182 RID: 20866
		private static readonly System.IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04005183 RID: 20867
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04005184 RID: 20868
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04005185 RID: 20869
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005186 RID: 20870
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005187 RID: 20871
		private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04005188 RID: 20872
		private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04005189 RID: 20873
		private static readonly System.IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400518A RID: 20874
		private static readonly System.IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400518B RID: 20875
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Void_0;

		// Token: 0x0400518C RID: 20876
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x0400518D RID: 20877
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400518E RID: 20878
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x0400518F RID: 20879
		private static readonly System.IntPtr NativeMethodInfoPtr_MinPass_Protected_Void_0;

		// Token: 0x04005190 RID: 20880
		private static readonly System.IntPtr NativeMethodInfoPtr_SleepEnd_Protected_Void_Int32_0;

		// Token: 0x04005191 RID: 20881
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Protected_Void_0;

		// Token: 0x04005192 RID: 20882
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Protected_Void_0;

		// Token: 0x04005193 RID: 20883
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04005194 RID: 20884
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVelocity_Public_Void_Vector3_0;

		// Token: 0x04005195 RID: 20885
		private static readonly System.IntPtr NativeMethodInfoPtr_DestroyTrash_Public_Void_0;

		// Token: 0x04005196 RID: 20886
		private static readonly System.IntPtr NativeMethodInfoPtr_Deinitialize_Public_Virtual_New_Void_0;

		// Token: 0x04005197 RID: 20887
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005198 RID: 20888
		private static readonly System.IntPtr NativeMethodInfoPtr_RecheckPosition_Private_Void_0;

		// Token: 0x04005199 RID: 20889
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_Virtual_New_TrashItemData_0;

		// Token: 0x0400519A RID: 20890
		private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400519B RID: 20891
		private static readonly System.IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x0400519C RID: 20892
		private static readonly System.IntPtr NativeMethodInfoPtr_RecheckProperty_Private_Void_0;

		// Token: 0x0400519D RID: 20893
		private static readonly System.IntPtr NativeMethodInfoPtr_SetContinuousCollisionDetection_Public_Void_0;

		// Token: 0x0400519E RID: 20894
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDiscreteCollisionDetection_Public_Void_0;

		// Token: 0x0400519F RID: 20895
		private static readonly System.IntPtr NativeMethodInfoPtr_SetPhysicsActive_Public_Void_Boolean_0;

		// Token: 0x040051A0 RID: 20896
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCollidersEnabled_Public_Void_Boolean_0;

		// Token: 0x040051A1 RID: 20897
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040051A2 RID: 20898
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__44_0_Private_Void_0;

		// Token: 0x040051A3 RID: 20899
		private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__44_1_Private_Void_Impact_0;
	}
}
