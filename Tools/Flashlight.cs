using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Equipping;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000549 RID: 1353
	public class Flashlight : Equippable_Viewmodel
	{
		// Token: 0x060077F4 RID: 30708 RVA: 0x000388DB File Offset: 0x00036ADB
		// Note: this type is marked as 'beforefieldinit'.
		static Flashlight()
		{
			Il2CppClassPointerStore<Flashlight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "Flashlight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Flashlight>.NativeClassPtr);
			Flashlight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Flashlight>.NativeClassPtr, 100678508);
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x0020C65C File Offset: 0x0020A85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Flashlight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Flashlight>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Flashlight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x00038914 File Offset: 0x00036B14
		public Flashlight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005200 RID: 20992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
