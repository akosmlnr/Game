using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001C4 RID: 452
	public class Quest_Employees : Quest
	{
		// Token: 0x0600269C RID: 9884 RVA: 0x000ECC18 File Offset: 0x000EAE18
		// Note: this type is marked as 'beforefieldinit'.
		static Quest_Employees()
		{
			Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Quest_Employees");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr);
			Quest_Employees.NativeFieldInfoPtr_EmployeeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "EmployeeType");
			Quest_Employees.NativeFieldInfoPtr_AssignBedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "AssignBedEntry");
			Quest_Employees.NativeFieldInfoPtr_PayEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, "PayEntry");
			Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667658);
			Quest_Employees.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667659);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667660);
			Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667661);
			Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr, 100667662);
		}

		// Token: 0x0600269D RID: 9885 RVA: 0x000ECCE8 File Offset: 0x000EAEE8
		[CallerCount(0)]
		public unsafe virtual List<Employee> GetEmployees()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x000ECD34 File Offset: 0x000EAF34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 120116, RefRangeEnd = 120120, XrefRangeStart = 120110, XrefRangeEnd = 120116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Quest_Employees.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000ECD70 File Offset: 0x000EAF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120134, RefRangeEnd = 120135, XrefRangeStart = 120120, XrefRangeEnd = 120134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesAssignedBeds()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x000ECDAC File Offset: 0x000EAFAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120146, RefRangeEnd = 120147, XrefRangeStart = 120135, XrefRangeEnd = 120146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyEmployeesPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000ECDE8 File Offset: 0x000EAFE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Quest_Employees() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Quest_Employees>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Quest_Employees.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x000154DC File Offset: 0x000136DC
		public Quest_Employees(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000ECE24 File Offset: 0x000EB024
		// (set) Token: 0x060026A4 RID: 9892 RVA: 0x000154E5 File Offset: 0x000136E5
		public unsafe EEmployeeType EmployeeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_EmployeeType)) = value;
			}
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000ECE4C File Offset: 0x000EB04C
		// (set) Token: 0x060026A6 RID: 9894 RVA: 0x00015500 File Offset: 0x00013700
		public unsafe QuestEntry AssignBedEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_AssignBedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x060026A7 RID: 9895 RVA: 0x000ECE7C File Offset: 0x000EB07C
		// (set) Token: 0x060026A8 RID: 9896 RVA: 0x0001551F File Offset: 0x0001371F
		public unsafe QuestEntry PayEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Quest_Employees.NativeFieldInfoPtr_PayEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeType;

		// Token: 0x040019BC RID: 6588
		private static readonly IntPtr NativeFieldInfoPtr_AssignBedEntry;

		// Token: 0x040019BD RID: 6589
		private static readonly IntPtr NativeFieldInfoPtr_PayEntry;

		// Token: 0x040019BE RID: 6590
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployees_Public_Abstract_Virtual_New_List_1_Employee_0;

		// Token: 0x040019BF RID: 6591
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040019C0 RID: 6592
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesAssignedBeds_Protected_Boolean_0;

		// Token: 0x040019C1 RID: 6593
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyEmployeesPaid_Protected_Boolean_0;

		// Token: 0x040019C2 RID: 6594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
