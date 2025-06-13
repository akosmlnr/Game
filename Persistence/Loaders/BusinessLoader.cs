using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000233 RID: 563
	public class BusinessLoader : PropertyLoader
	{
		// Token: 0x06002E81 RID: 11905 RVA: 0x001072AC File Offset: 0x001054AC
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessLoader()
		{
			Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BusinessLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr);
			BusinessLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr, 100668664);
			BusinessLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr, 100668665);
			BusinessLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr, 100668666);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00107318 File Offset: 0x00105518
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00107354 File Offset: 0x00105554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130969, XrefRangeEnd = 130993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x001073A4 File Offset: 0x001055A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130993, XrefRangeEnd = 130994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(PropertyData propertyData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00018D62 File Offset: 0x00016F62
		public BusinessLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EDC RID: 7900
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_0;
	}
}
