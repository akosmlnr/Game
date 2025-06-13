using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000220 RID: 544
	public class PourIntoPotTask : Task
	{
		// Token: 0x06002CD7 RID: 11479 RVA: 0x00101648 File Offset: 0x000FF848
		// Note: this type is marked as 'beforefieldinit'.
		static PourIntoPotTask()
		{
			Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourIntoPotTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr);
			PourIntoPotTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<TaskName>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "pot");
			PourIntoPotTask.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "item");
			PourIntoPotTask.NativeFieldInfoPtr_pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "pourable");
			PourIntoPotTask.NativeFieldInfoPtr__UseCoverage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<UseCoverage>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<FailOnEmpty>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr__CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<CameraPosition>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr_removeItemAfterInitialPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "removeItemAfterInitialPour");
			PourIntoPotTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668384);
			PourIntoPotTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668385);
			PourIntoPotTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668386);
			PourIntoPotTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668387);
			PourIntoPotTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668388);
			PourIntoPotTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668389);
			PourIntoPotTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668390);
			PourIntoPotTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668391);
			PourIntoPotTask.NativeMethodInfoPtr_OnInitialPour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668392);
			PourIntoPotTask.NativeMethodInfoPtr_RemoveItem_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668393);
			PourIntoPotTask.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668394);
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x001017F4 File Offset: 0x000FF9F4
		// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x00101838 File Offset: 0x000FFA38
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06002CDA RID: 11482 RVA: 0x00101888 File Offset: 0x000FFA88
		public unsafe virtual bool UseCoverage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x001018D0 File Offset: 0x000FFAD0
		public unsafe virtual bool FailOnEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06002CDC RID: 11484 RVA: 0x00101918 File Offset: 0x000FFB18
		public unsafe virtual Pot.ECameraPosition CameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00101960 File Offset: 0x000FFB60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 127053, RefRangeEnd = 127058, XrefRangeStart = 126946, XrefRangeEnd = 127053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourIntoPotTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourIntoPotTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x001019D0 File Offset: 0x000FFBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127058, XrefRangeEnd = 127059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00101A0C File Offset: 0x000FFC0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 127105, RefRangeEnd = 127108, XrefRangeStart = 127059, XrefRangeEnd = 127105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00101A48 File Offset: 0x000FFC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127108, XrefRangeEnd = 127109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInitialPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourIntoPotTask.NativeMethodInfoPtr_OnInitialPour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00101A7C File Offset: 0x000FFC7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127134, RefRangeEnd = 127136, XrefRangeStart = 127109, XrefRangeEnd = 127134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourIntoPotTask.NativeMethodInfoPtr_RemoveItem_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00101AB0 File Offset: 0x000FFCB0
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyCovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00018215 File Offset: 0x00016415
		public PourIntoPotTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x00101AEC File Offset: 0x000FFCEC
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x0001821E File Offset: 0x0001641E
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x00101B14 File Offset: 0x000FFD14
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x0001823D File Offset: 0x0001643D
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x00101B44 File Offset: 0x000FFD44
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x0001825C File Offset: 0x0001645C
		public unsafe ItemInstance item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x00101B74 File Offset: 0x000FFD74
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x0001827B File Offset: 0x0001647B
		public unsafe Pourable pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x00101BA4 File Offset: 0x000FFDA4
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x0001829A File Offset: 0x0001649A
		public unsafe bool _UseCoverage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__UseCoverage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__UseCoverage_k__BackingField)) = value;
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x00101BCC File Offset: 0x000FFDCC
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x000182B5 File Offset: 0x000164B5
		public unsafe bool _FailOnEmpty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x00101BF4 File Offset: 0x000FFDF4
		// (set) Token: 0x06002CF1 RID: 11505 RVA: 0x000182D0 File Offset: 0x000164D0
		public unsafe Pot.ECameraPosition _CameraPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__CameraPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__CameraPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x06002CF2 RID: 11506 RVA: 0x00101C1C File Offset: 0x000FFE1C
		// (set) Token: 0x06002CF3 RID: 11507 RVA: 0x000182EB File Offset: 0x000164EB
		public unsafe bool removeItemAfterInitialPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_removeItemAfterInitialPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_removeItemAfterInitialPour)) = value;
			}
		}

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04001DBD RID: 7613
		private static readonly IntPtr NativeFieldInfoPtr_pourable;

		// Token: 0x04001DBE RID: 7614
		private static readonly IntPtr NativeFieldInfoPtr__UseCoverage_k__BackingField;

		// Token: 0x04001DBF RID: 7615
		private static readonly IntPtr NativeFieldInfoPtr__FailOnEmpty_k__BackingField;

		// Token: 0x04001DC0 RID: 7616
		private static readonly IntPtr NativeFieldInfoPtr__CameraPosition_k__BackingField;

		// Token: 0x04001DC1 RID: 7617
		private static readonly IntPtr NativeFieldInfoPtr_removeItemAfterInitialPour;

		// Token: 0x04001DC2 RID: 7618
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001DC3 RID: 7619
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001DC4 RID: 7620
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001DC5 RID: 7621
		private static readonly IntPtr NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001DC6 RID: 7622
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0;

		// Token: 0x04001DC7 RID: 7623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001DC8 RID: 7624
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DC9 RID: 7625
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001DCA RID: 7626
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialPour_Private_Void_0;

		// Token: 0x04001DCB RID: 7627
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Void_0;

		// Token: 0x04001DCC RID: 7628
		private static readonly IntPtr NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0;
	}
}
