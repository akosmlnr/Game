using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200023B RID: 571
	public class MetadataLoader : Loader
	{
		// Token: 0x06002EAB RID: 11947 RVA: 0x00107E60 File Offset: 0x00106060
		// Note: this type is marked as 'beforefieldinit'.
		static MetadataLoader()
		{
			Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "MetadataLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr);
			MetadataLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr, 100668690);
			MetadataLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr, 100668691);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00107EB8 File Offset: 0x001060B8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00107EF4 File Offset: 0x001060F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131332, XrefRangeEnd = 131341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MetadataLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00018DAA File Offset: 0x00016FAA
		public MetadataLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EF6 RID: 7926
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EF7 RID: 7927
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
