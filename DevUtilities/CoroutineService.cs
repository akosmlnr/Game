using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000476 RID: 1142
	public class CoroutineService : Singleton<CoroutineService>
	{
		// Token: 0x06006232 RID: 25138 RVA: 0x0002E2D6 File Offset: 0x0002C4D6
		// Note: this type is marked as 'beforefieldinit'.
		static CoroutineService()
		{
			Il2CppClassPointerStore<CoroutineService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CoroutineService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr);
			CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr, 100675889);
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x001C30E8 File Offset: 0x001C12E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203557, XrefRangeEnd = 203560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoroutineService() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoroutineService>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoroutineService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x0002E30F File Offset: 0x0002C50F
		public CoroutineService(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400430C RID: 17164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
