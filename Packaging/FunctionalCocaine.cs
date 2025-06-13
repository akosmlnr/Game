using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000587 RID: 1415
	public class FunctionalCocaine : FunctionalProduct
	{
		// Token: 0x06007B2A RID: 31530 RVA: 0x0003A3A5 File Offset: 0x000385A5
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalCocaine()
		{
			Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalCocaine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr);
			FunctionalCocaine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr, 100678833);
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x00215B74 File Offset: 0x00213D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236576, XrefRangeEnd = 236577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalCocaine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalCocaine>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalCocaine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x0003A3DE File Offset: 0x000385DE
		public FunctionalCocaine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040053E0 RID: 21472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
