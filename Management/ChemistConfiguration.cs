using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A6 RID: 934
	public class ChemistConfiguration : EntityConfiguration
	{
		// Token: 0x06004823 RID: 18467 RVA: 0x00163B24 File Offset: 0x00161D24
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfiguration()
		{
			Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ChemistConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr);
			ChemistConfiguration.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Home");
			ChemistConfiguration.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Stations");
			ChemistConfiguration.NativeFieldInfoPtr_ChemStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "ChemStations");
			ChemistConfiguration.NativeFieldInfoPtr_LabOvens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "LabOvens");
			ChemistConfiguration.NativeFieldInfoPtr_Cauldrons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Cauldrons");
			ChemistConfiguration.NativeFieldInfoPtr_MixStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "MixStations");
			ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "<chemist>k__BackingField");
			ChemistConfiguration.NativeFieldInfoPtr__assignedHome_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "<assignedHome>k__BackingField");
			ChemistConfiguration.NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672281);
			ChemistConfiguration.NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672282);
			ChemistConfiguration.NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672283);
			ChemistConfiguration.NativeMethodInfoPtr_get_assignedHome_Public_get_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672284);
			ChemistConfiguration.NativeMethodInfoPtr_set_assignedHome_Private_set_Void_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672285);
			ChemistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672286);
			ChemistConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672287);
			ChemistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672288);
			ChemistConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672289);
			ChemistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672290);
			ChemistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672291);
			ChemistConfiguration.NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672292);
			ChemistConfiguration.NativeMethodInfoPtr___ctor_b__16_0_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672293);
		}

		// Token: 0x1700158B RID: 5515
		// (get) Token: 0x06004824 RID: 18468 RVA: 0x00163CF8 File Offset: 0x00161EF8
		public unsafe int TotalStations
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 164200, RefRangeEnd = 164202, XrefRangeStart = 164196, XrefRangeEnd = 164200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700158C RID: 5516
		// (get) Token: 0x06004825 RID: 18469 RVA: 0x00163D34 File Offset: 0x00161F34
		// (set) Token: 0x06004826 RID: 18470 RVA: 0x00163D74 File Offset: 0x00161F74
		public unsafe Chemist chemist
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 24360, RefRangeEnd = 24376, XrefRangeStart = 24360, XrefRangeEnd = 24376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700158D RID: 5517
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x00163DB8 File Offset: 0x00161FB8
		// (set) Token: 0x06004828 RID: 18472 RVA: 0x00163DF8 File Offset: 0x00161FF8
		public unsafe EmployeeHome assignedHome
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24376, RefRangeEnd = 24377, XrefRangeStart = 24376, XrefRangeEnd = 24377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_assignedHome_Public_get_EmployeeHome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_set_assignedHome_Private_set_Void_EmployeeHome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004829 RID: 18473 RVA: 0x00163E3C File Offset: 0x0016203C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164328, RefRangeEnd = 164329, XrefRangeStart = 164202, XrefRangeEnd = 164328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_chemist);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600482A RID: 18474 RVA: 0x00163EAC File Offset: 0x001620AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164329, XrefRangeEnd = 164430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600482B RID: 18475 RVA: 0x00163EE8 File Offset: 0x001620E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164430, XrefRangeEnd = 164456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj2);
		}

		// Token: 0x0600482C RID: 18476 RVA: 0x00163F50 File Offset: 0x00162150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164456, XrefRangeEnd = 164657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedStationsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600482D RID: 18477 RVA: 0x00163F94 File Offset: 0x00162194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164657, XrefRangeEnd = 164664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600482E RID: 18478 RVA: 0x00163FDC File Offset: 0x001621DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164664, XrefRangeEnd = 164671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x0600482F RID: 18479 RVA: 0x00164020 File Offset: 0x00162220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164671, XrefRangeEnd = 164689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HomeChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004830 RID: 18480 RVA: 0x00164064 File Offset: 0x00162264
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130895, RefRangeEnd = 130899, XrefRangeStart = 130895, XrefRangeEnd = 130899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_0(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr___ctor_b__16_0_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004831 RID: 18481 RVA: 0x00022CBE File Offset: 0x00020EBE
		public ChemistConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x001640A8 File Offset: 0x001622A8
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x00022CC7 File Offset: 0x00020EC7
		public unsafe ObjectField Home
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Home);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x001640D8 File Offset: 0x001622D8
		// (set) Token: 0x06004835 RID: 18485 RVA: 0x00022CE6 File Offset: 0x00020EE6
		public unsafe ObjectListField Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x00164108 File Offset: 0x00162308
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x00022D05 File Offset: 0x00020F05
		public unsafe List<ChemistryStation> ChemStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_ChemStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_ChemStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x00164138 File Offset: 0x00162338
		// (set) Token: 0x06004839 RID: 18489 RVA: 0x00022D24 File Offset: 0x00020F24
		public unsafe List<LabOven> LabOvens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_LabOvens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_LabOvens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x00164168 File Offset: 0x00162368
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x00022D43 File Offset: 0x00020F43
		public unsafe List<Cauldron> Cauldrons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Cauldrons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Cauldrons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x00164198 File Offset: 0x00162398
		// (set) Token: 0x0600483D RID: 18493 RVA: 0x00022D62 File Offset: 0x00020F62
		public unsafe List<MixingStation> MixStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_MixStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_MixStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x001641C8 File Offset: 0x001623C8
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x00022D81 File Offset: 0x00020F81
		public unsafe Chemist _chemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x06004840 RID: 18496 RVA: 0x001641F8 File Offset: 0x001623F8
		// (set) Token: 0x06004841 RID: 18497 RVA: 0x00022DA0 File Offset: 0x00020FA0
		public unsafe EmployeeHome _assignedHome_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__assignedHome_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__assignedHome_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeFieldInfoPtr_ChemStations;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeFieldInfoPtr_LabOvens;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeFieldInfoPtr_Cauldrons;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeFieldInfoPtr_MixStations;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeFieldInfoPtr__chemist_k__BackingField;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeFieldInfoPtr__assignedHome_k__BackingField;

		// Token: 0x04003084 RID: 12420
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0;

		// Token: 0x04003085 RID: 12421
		private static readonly IntPtr NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0;

		// Token: 0x04003086 RID: 12422
		private static readonly IntPtr NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0;

		// Token: 0x04003087 RID: 12423
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedHome_Public_get_EmployeeHome_0;

		// Token: 0x04003088 RID: 12424
		private static readonly IntPtr NativeMethodInfoPtr_set_assignedHome_Private_set_Void_EmployeeHome_0;

		// Token: 0x04003089 RID: 12425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0;

		// Token: 0x0400308A RID: 12426
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400308B RID: 12427
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr_HomeChanged_Private_Void_BuildableItem_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_0_Private_Void_List_1_BuildableItem_0;
	}
}
