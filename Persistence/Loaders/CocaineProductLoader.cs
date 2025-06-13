using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000234 RID: 564
	public class CocaineProductLoader : Loader
	{
		// Token: 0x06002E86 RID: 11910 RVA: 0x001073F4 File Offset: 0x001055F4
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineProductLoader()
		{
			Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CocaineProductLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr);
			CocaineProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr, 100668667);
			CocaineProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr, 100668668);
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x0010744C File Offset: 0x0010564C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineProductLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00107488 File Offset: 0x00105688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130994, XrefRangeEnd = 131011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00018D6B File Offset: 0x00016F6B
		public CocaineProductLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
