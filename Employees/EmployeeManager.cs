using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200042B RID: 1067
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x060059FB RID: 23035 RVA: 0x001A4F20 File Offset: 0x001A3120
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeManager()
		{
			Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "EmployeeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr);
			EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MALE_EMPLOYEE_CHANCE");
			EmployeeManager.NativeFieldInfoPtr_AllEmployees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "AllEmployees");
			EmployeeManager.NativeFieldInfoPtr_EmployeeQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeQuests");
			EmployeeManager.NativeFieldInfoPtr_BotanistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "BotanistPrefab");
			EmployeeManager.NativeFieldInfoPtr_PackagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "PackagerPrefab");
			EmployeeManager.NativeFieldInfoPtr_ChemistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "ChemistPrefab");
			EmployeeManager.NativeFieldInfoPtr_CleanerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "CleanerPrefab");
			EmployeeManager.NativeFieldInfoPtr_MaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_FemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_MaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleVoices");
			EmployeeManager.NativeFieldInfoPtr_FemaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleVoices");
			EmployeeManager.NativeFieldInfoPtr_MaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_LastNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "LastNames");
			EmployeeManager.NativeFieldInfoPtr_takenNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenNames");
			EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenMaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenFemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674729);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674730);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674731);
			EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674732);
			EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674733);
			EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674734);
			EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674735);
			EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674736);
			EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674737);
			EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674738);
			EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674739);
			EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674740);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674741);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674742);
			EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674743);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674744);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674745);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674746);
			EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674747);
			EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674748);
			EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674749);
			EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674750);
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x001A5284 File Offset: 0x001A3484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190304, RefRangeEnd = 190305, XrefRangeStart = 190261, XrefRangeEnd = 190304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewEmployee(Property property, EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x001A52D4 File Offset: 0x001A34D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190305, XrefRangeEnd = 190306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x001A53AC File Offset: 0x001A35AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190365, RefRangeEnd = 190368, XrefRangeStart = 190306, XrefRangeEnd = 190365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x001A5490 File Offset: 0x001A3690
		[CallerCount(0)]
		public unsafe bool IsPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x001A54DC File Offset: 0x001A36DC
		[CallerCount(0)]
		public unsafe bool IsRotationValid(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref rotation;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x001A5528 File Offset: 0x001A3728
		[CallerCount(0)]
		public unsafe bool IsFloatValid(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x001A5574 File Offset: 0x001A3774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190368, XrefRangeEnd = 190374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x001A55B8 File Offset: 0x001A37B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190374, XrefRangeEnd = 190377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A04 RID: 23044 RVA: 0x001A5604 File Offset: 0x001A3804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190388, RefRangeEnd = 190389, XrefRangeStart = 190377, XrefRangeEnd = 190388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref male;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			ref System.IntPtr ptr3 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr il2CppString2 = 0;
			ptr3 = &il2CppString2;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			firstName = IL2CPP.Il2CppStringToManaged(il2CppString);
			lastName = IL2CPP.Il2CppStringToManaged(il2CppString2);
		}

		// Token: 0x06005A05 RID: 23045 RVA: 0x001A5678 File Offset: 0x001A3878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190389, XrefRangeEnd = 190394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmployeeManager.EmployeeAppearance>(intPtr2) : null;
		}

		// Token: 0x06005A06 RID: 23046 RVA: 0x001A56D4 File Offset: 0x001A38D4
		[CallerCount(0)]
		public unsafe VODatabase GetVoice(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr2) : null;
		}

		// Token: 0x06005A07 RID: 23047 RVA: 0x001A5730 File Offset: 0x001A3930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190394, XrefRangeEnd = 190407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &index;
			ref System.IntPtr ptr2 = ref ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)];
			System.IntPtr intPtr = 0;
			ptr2 = &intPtr;
			System.IntPtr returnedException;
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr3 = intPtr;
			settings = ((intPtr3 == 0) ? null : new AvatarSettings(intPtr3));
		}

		// Token: 0x06005A08 RID: 23048 RVA: 0x001A57A0 File Offset: 0x001A39A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 190417, RefRangeEnd = 190420, XrefRangeStart = 190407, XrefRangeEnd = 190417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee GetEmployeePrefab(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
		}

		// Token: 0x06005A09 RID: 23049 RVA: 0x001A57EC File Offset: 0x001A39EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 190443, RefRangeEnd = 190447, XrefRangeStart = 190420, XrefRangeEnd = 190443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x001A5838 File Offset: 0x001A3A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190447, XrefRangeEnd = 190476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A0B RID: 23051 RVA: 0x001A5874 File Offset: 0x001A3A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190476, XrefRangeEnd = 190486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A0C RID: 23052 RVA: 0x001A58B0 File Offset: 0x001A3AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190486, XrefRangeEnd = 190489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x001A58EC File Offset: 0x001A3AEC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x001A5928 File Offset: 0x001A3B28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 190522, RefRangeEnd = 190524, XrefRangeStart = 190489, XrefRangeEnd = 190522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A0F RID: 23055 RVA: 0x001A5A00 File Offset: 0x001A3C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190524, XrefRangeEnd = 190525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)10) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref type;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref male;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref position;
			ptr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref rotation;
			ptr[checked(unchecked((System.UIntPtr)9) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A10 RID: 23056 RVA: 0x001A5AD8 File Offset: 0x001A3CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190525, XrefRangeEnd = 190540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A11 RID: 23057 RVA: 0x001A5B3C File Offset: 0x001A3D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190540, XrefRangeEnd = 190543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x0002A96D File Offset: 0x00028B6D
		public EmployeeManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06005A13 RID: 23059 RVA: 0x001A5B78 File Offset: 0x001A3D78
		// (set) Token: 0x06005A14 RID: 23060 RVA: 0x0002A976 File Offset: 0x00028B76
		public unsafe static float MALE_EMPLOYEE_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06005A15 RID: 23061 RVA: 0x001A5B94 File Offset: 0x001A3D94
		// (set) Token: 0x06005A16 RID: 23062 RVA: 0x0002A984 File Offset: 0x00028B84
		public unsafe List<Employee> AllEmployees
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06005A17 RID: 23063 RVA: 0x001A5BC4 File Offset: 0x001A3DC4
		// (set) Token: 0x06005A18 RID: 23064 RVA: 0x0002A9A3 File Offset: 0x00028BA3
		public unsafe Il2CppReferenceArray<Quest_Employees> EmployeeQuests
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest_Employees>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06005A19 RID: 23065 RVA: 0x001A5BF4 File Offset: 0x001A3DF4
		// (set) Token: 0x06005A1A RID: 23066 RVA: 0x0002A9C2 File Offset: 0x00028BC2
		public unsafe Botanist BotanistPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06005A1B RID: 23067 RVA: 0x001A5C24 File Offset: 0x001A3E24
		// (set) Token: 0x06005A1C RID: 23068 RVA: 0x0002A9E1 File Offset: 0x00028BE1
		public unsafe Packager PackagerPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06005A1D RID: 23069 RVA: 0x001A5C54 File Offset: 0x001A3E54
		// (set) Token: 0x06005A1E RID: 23070 RVA: 0x0002AA00 File Offset: 0x00028C00
		public unsafe Chemist ChemistPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06005A1F RID: 23071 RVA: 0x001A5C84 File Offset: 0x001A3E84
		// (set) Token: 0x06005A20 RID: 23072 RVA: 0x0002AA1F File Offset: 0x00028C1F
		public unsafe Cleaner CleanerPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06005A21 RID: 23073 RVA: 0x001A5CB4 File Offset: 0x001A3EB4
		// (set) Token: 0x06005A22 RID: 23074 RVA: 0x0002AA3E File Offset: 0x00028C3E
		public unsafe List<EmployeeManager.EmployeeAppearance> MaleAppearances
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x001A5CE4 File Offset: 0x001A3EE4
		// (set) Token: 0x06005A24 RID: 23076 RVA: 0x0002AA5D File Offset: 0x00028C5D
		public unsafe List<EmployeeManager.EmployeeAppearance> FemaleAppearances
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x001A5D14 File Offset: 0x001A3F14
		// (set) Token: 0x06005A26 RID: 23078 RVA: 0x0002AA7C File Offset: 0x00028C7C
		public unsafe Il2CppReferenceArray<VODatabase> MaleVoices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06005A27 RID: 23079 RVA: 0x001A5D44 File Offset: 0x001A3F44
		// (set) Token: 0x06005A28 RID: 23080 RVA: 0x0002AA9B File Offset: 0x00028C9B
		public unsafe Il2CppReferenceArray<VODatabase> FemaleVoices
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06005A29 RID: 23081 RVA: 0x001A5D74 File Offset: 0x001A3F74
		// (set) Token: 0x06005A2A RID: 23082 RVA: 0x0002AABA File Offset: 0x00028CBA
		public unsafe Il2CppStringArray MaleFirstNames
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x001A5DA4 File Offset: 0x001A3FA4
		// (set) Token: 0x06005A2C RID: 23084 RVA: 0x0002AAD9 File Offset: 0x00028CD9
		public unsafe Il2CppStringArray FemaleFirstNames
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06005A2D RID: 23085 RVA: 0x001A5DD4 File Offset: 0x001A3FD4
		// (set) Token: 0x06005A2E RID: 23086 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		public unsafe Il2CppStringArray LastNames
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x001A5E04 File Offset: 0x001A4004
		// (set) Token: 0x06005A30 RID: 23088 RVA: 0x0002AB17 File Offset: 0x00028D17
		public unsafe List<string> takenNames
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x001A5E34 File Offset: 0x001A4034
		// (set) Token: 0x06005A32 RID: 23090 RVA: 0x0002AB36 File Offset: 0x00028D36
		public unsafe List<int> takenMaleAppearances
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06005A33 RID: 23091 RVA: 0x001A5E64 File Offset: 0x001A4064
		// (set) Token: 0x06005A34 RID: 23092 RVA: 0x0002AB55 File Offset: 0x00028D55
		public unsafe List<int> takenFemaleAppearances
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06005A35 RID: 23093 RVA: 0x001A5E94 File Offset: 0x001A4094
		// (set) Token: 0x06005A36 RID: 23094 RVA: 0x0002AB74 File Offset: 0x00028D74
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06005A37 RID: 23095 RVA: 0x001A5EBC File Offset: 0x001A40BC
		// (set) Token: 0x06005A38 RID: 23096 RVA: 0x0002AB8F File Offset: 0x00028D8F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003D3D RID: 15677
		private static readonly System.IntPtr NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE;

		// Token: 0x04003D3E RID: 15678
		private static readonly System.IntPtr NativeFieldInfoPtr_AllEmployees;

		// Token: 0x04003D3F RID: 15679
		private static readonly System.IntPtr NativeFieldInfoPtr_EmployeeQuests;

		// Token: 0x04003D40 RID: 15680
		private static readonly System.IntPtr NativeFieldInfoPtr_BotanistPrefab;

		// Token: 0x04003D41 RID: 15681
		private static readonly System.IntPtr NativeFieldInfoPtr_PackagerPrefab;

		// Token: 0x04003D42 RID: 15682
		private static readonly System.IntPtr NativeFieldInfoPtr_ChemistPrefab;

		// Token: 0x04003D43 RID: 15683
		private static readonly System.IntPtr NativeFieldInfoPtr_CleanerPrefab;

		// Token: 0x04003D44 RID: 15684
		private static readonly System.IntPtr NativeFieldInfoPtr_MaleAppearances;

		// Token: 0x04003D45 RID: 15685
		private static readonly System.IntPtr NativeFieldInfoPtr_FemaleAppearances;

		// Token: 0x04003D46 RID: 15686
		private static readonly System.IntPtr NativeFieldInfoPtr_MaleVoices;

		// Token: 0x04003D47 RID: 15687
		private static readonly System.IntPtr NativeFieldInfoPtr_FemaleVoices;

		// Token: 0x04003D48 RID: 15688
		private static readonly System.IntPtr NativeFieldInfoPtr_MaleFirstNames;

		// Token: 0x04003D49 RID: 15689
		private static readonly System.IntPtr NativeFieldInfoPtr_FemaleFirstNames;

		// Token: 0x04003D4A RID: 15690
		private static readonly System.IntPtr NativeFieldInfoPtr_LastNames;

		// Token: 0x04003D4B RID: 15691
		private static readonly System.IntPtr NativeFieldInfoPtr_takenNames;

		// Token: 0x04003D4C RID: 15692
		private static readonly System.IntPtr NativeFieldInfoPtr_takenMaleAppearances;

		// Token: 0x04003D4D RID: 15693
		private static readonly System.IntPtr NativeFieldInfoPtr_takenFemaleAppearances;

		// Token: 0x04003D4E RID: 15694
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003D4F RID: 15695
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003D50 RID: 15696
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0;

		// Token: 0x04003D51 RID: 15697
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003D52 RID: 15698
		private static readonly System.IntPtr NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003D53 RID: 15699
		private static readonly System.IntPtr NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x04003D54 RID: 15700
		private static readonly System.IntPtr NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0;

		// Token: 0x04003D55 RID: 15701
		private static readonly System.IntPtr NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0;

		// Token: 0x04003D56 RID: 15702
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterName_Public_Void_String_0;

		// Token: 0x04003D57 RID: 15703
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0;

		// Token: 0x04003D58 RID: 15704
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0;

		// Token: 0x04003D59 RID: 15705
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0;

		// Token: 0x04003D5A RID: 15706
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0;

		// Token: 0x04003D5B RID: 15707
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0;

		// Token: 0x04003D5C RID: 15708
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0;

		// Token: 0x04003D5D RID: 15709
		private static readonly System.IntPtr NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0;

		// Token: 0x04003D5E RID: 15710
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D5F RID: 15711
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003D60 RID: 15712
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003D61 RID: 15713
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003D62 RID: 15714
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003D63 RID: 15715
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003D64 RID: 15716
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003D65 RID: 15717
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A1C RID: 2588
		[System.Serializable]
		public class EmployeeAppearance : Il2CppSystem.Object
		{
			// Token: 0x0600D1D7 RID: 53719 RVA: 0x0032B64C File Offset: 0x0032984C
			// Note: this type is marked as 'beforefieldinit'.
			static EmployeeAppearance()
			{
				Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeAppearance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr);
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Settings");
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Mugshot");
				EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, 100674751);
			}

			// Token: 0x0600D1D8 RID: 53720 RVA: 0x0032B6B4 File Offset: 0x003298B4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmployeeAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1D9 RID: 53721 RVA: 0x00065BBA File Offset: 0x00063DBA
			public EmployeeAppearance(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700410C RID: 16652
			// (get) Token: 0x0600D1DA RID: 53722 RVA: 0x0032B6F0 File Offset: 0x003298F0
			// (set) Token: 0x0600D1DB RID: 53723 RVA: 0x00065BC3 File Offset: 0x00063DC3
			public unsafe AvatarSettings Settings
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410D RID: 16653
			// (get) Token: 0x0600D1DC RID: 53724 RVA: 0x0032B720 File Offset: 0x00329920
			// (set) Token: 0x0600D1DD RID: 53725 RVA: 0x00065BE2 File Offset: 0x00063DE2
			public unsafe Sprite Mugshot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DE8 RID: 36328
			private static readonly System.IntPtr NativeFieldInfoPtr_Settings;

			// Token: 0x04008DE9 RID: 36329
			private static readonly System.IntPtr NativeFieldInfoPtr_Mugshot;

			// Token: 0x04008DEA RID: 36330
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A1D RID: 2589
		[ObfuscatedName("ScheduleOne.Employees.EmployeeManager+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D1DE RID: 53726 RVA: 0x0032B750 File Offset: 0x00329950
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr);
				EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, "type");
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100674752);
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100674753);
			}

			// Token: 0x0600D1DF RID: 53727 RVA: 0x0032B7B8 File Offset: 0x003299B8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D1E0 RID: 53728 RVA: 0x0032B7F4 File Offset: 0x003299F4
			[CallerCount(0)]
			public unsafe bool _CreateEmployee_Server_b__0(Quest_Employees x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D1E1 RID: 53729 RVA: 0x00065C01 File Offset: 0x00063E01
			public __c__DisplayClass20_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700410E RID: 16654
			// (get) Token: 0x0600D1E2 RID: 53730 RVA: 0x0032B844 File Offset: 0x00329A44
			// (set) Token: 0x0600D1E3 RID: 53731 RVA: 0x00065C0A File Offset: 0x00063E0A
			public unsafe EEmployeeType type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008DEB RID: 36331
			private static readonly System.IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008DEC RID: 36332
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DED RID: 36333
			private static readonly System.IntPtr NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0;
		}
	}
}
