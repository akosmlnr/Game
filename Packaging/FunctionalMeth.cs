using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000588 RID: 1416
	public class FunctionalMeth : FunctionalProduct
	{
		// Token: 0x06007B2D RID: 31533 RVA: 0x0003A3E7 File Offset: 0x000385E7
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionalMeth()
		{
			Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FunctionalMeth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr);
			FunctionalMeth.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr, 100678834);
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00215BB0 File Offset: 0x00213DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FunctionalMeth() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionalMeth>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionalMeth.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x0003A420 File Offset: 0x00038620
		public FunctionalMeth(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040053E1 RID: 21473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
