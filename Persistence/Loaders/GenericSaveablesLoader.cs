using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000238 RID: 568
	public class GenericSaveablesLoader : Loader
	{
		// Token: 0x06002E9A RID: 11930 RVA: 0x0010792C File Offset: 0x00105B2C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveablesLoader()
		{
			Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "GenericSaveablesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr);
			GenericSaveablesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr, 100668679);
			GenericSaveablesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr, 100668680);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00107984 File Offset: 0x00105B84
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveablesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x001079C0 File Offset: 0x00105BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131147, XrefRangeEnd = 131173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSaveablesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00018D8F File Offset: 0x00016F8F
		public GenericSaveablesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EEB RID: 7915
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EEC RID: 7916
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
