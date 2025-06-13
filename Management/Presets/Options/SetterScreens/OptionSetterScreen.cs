using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Presets.Options.SetterScreens
{
	// Token: 0x020003D1 RID: 977
	public class OptionSetterScreen : MonoBehaviour
	{
		// Token: 0x06004B3B RID: 19259 RVA: 0x000240E2 File Offset: 0x000222E2
		// Note: this type is marked as 'beforefieldinit'.
		static OptionSetterScreen()
		{
			Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options.SetterScreens", "OptionSetterScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr);
			OptionSetterScreen.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr, 100672709);
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x0016F674 File Offset: 0x0016D874
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionSetterScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionSetterScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionSetterScreen.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x0002411B File Offset: 0x0002231B
		public OptionSetterScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040032B5 RID: 12981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
