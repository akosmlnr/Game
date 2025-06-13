using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000256 RID: 598
	public class LegacyEmployeeLoader : LegacyNPCLoader
	{
		// Token: 0x06002F23 RID: 12067 RVA: 0x00109AB0 File Offset: 0x00107CB0
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyEmployeeLoader()
		{
			Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LegacyEmployeeLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr);
			LegacyEmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr, 100668795);
			LegacyEmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr, 100668796);
			LegacyEmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr, 100668797);
		}

		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x00109B1C File Offset: 0x00107D1C
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133104, XrefRangeEnd = 133111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LegacyEmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06002F25 RID: 12069 RVA: 0x00109B60 File Offset: 0x00107D60
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 133122, RefRangeEnd = 133137, XrefRangeStart = 133111, XrefRangeEnd = 133122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyEmployeeLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyEmployeeLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyEmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002F26 RID: 12070 RVA: 0x00109B9C File Offset: 0x00107D9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 133202, RefRangeEnd = 133206, XrefRangeStart = 133137, XrefRangeEnd = 133202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee LoadAndCreateEmployee(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyEmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr2) : null;
		}

		// Token: 0x06002F27 RID: 12071 RVA: 0x00018E9D File Offset: 0x0001709D
		public LegacyEmployeeLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001F38 RID: 7992
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001F39 RID: 7993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F3A RID: 7994
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0;
	}
}
