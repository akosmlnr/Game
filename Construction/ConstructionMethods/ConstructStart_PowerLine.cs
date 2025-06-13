using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x020004AC RID: 1196
	public class ConstructStart_PowerLine : ConstructStart_Base
	{
		// Token: 0x060066A5 RID: 26277 RVA: 0x000304B9 File Offset: 0x0002E6B9
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_PowerLine()
		{
			Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_PowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr);
			ConstructStart_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr, 100676394);
		}

		// Token: 0x060066A6 RID: 26278 RVA: 0x001D1D38 File Offset: 0x001CFF38
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_PowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_PowerLine>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_PowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060066A7 RID: 26279 RVA: 0x000304F2 File Offset: 0x0002E6F2
		public ConstructStart_PowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400460C RID: 17932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
