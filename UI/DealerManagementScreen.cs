using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000656 RID: 1622
	public class DealerManagementScreen : Singleton<DealerManagementScreen>
	{
		// Token: 0x06008E5F RID: 36447 RVA: 0x00043F3B File Offset: 0x0004213B
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementScreen()
		{
			Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealerManagementScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr);
			DealerManagementScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr, 100681080);
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x00255564 File Offset: 0x00253764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260223, XrefRangeEnd = 260226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x00043F74 File Offset: 0x00042174
		public DealerManagementScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400608D RID: 24717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
