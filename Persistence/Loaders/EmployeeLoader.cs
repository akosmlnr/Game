using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000252 RID: 594
	public class EmployeeLoader : NPCLoader
	{
		// Token: 0x06002F0E RID: 12046 RVA: 0x00109550 File Offset: 0x00107750
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeLoader()
		{
			Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "EmployeeLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr);
			EmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668767);
			EmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668768);
			EmployeeLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668769);
			EmployeeLoader.NativeMethodInfoPtr_CreateAndLoadEmployee_Protected_Virtual_New_Employee_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668770);
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x001095D0 File Offset: 0x001077D0
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132719, XrefRangeEnd = 132726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00109614 File Offset: 0x00107814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132509, RefRangeEnd = 132510, XrefRangeStart = 132509, XrefRangeEnd = 132510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00109650 File Offset: 0x00107850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132726, XrefRangeEnd = 132727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x001096A0 File Offset: 0x001078A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 132747, RefRangeEnd = 132751, XrefRangeStart = 132727, XrefRangeEnd = 132747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Employee CreateAndLoadEmployee(DynamicSaveData saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeLoader.NativeMethodInfoPtr_CreateAndLoadEmployee_Protected_Virtual_New_Employee_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x00018E79 File Offset: 0x00017079
		public EmployeeLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_0;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndLoadEmployee_Protected_Virtual_New_Employee_DynamicSaveData_0;
	}
}
