using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200055B RID: 1371
	public class ExitToMenu : MonoBehaviour
	{
		// Token: 0x060078DC RID: 30940 RVA: 0x0020EFE8 File Offset: 0x0020D1E8
		// Note: this type is marked as 'beforefieldinit'.
		static ExitToMenu()
		{
			Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ExitToMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr);
			ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100678609);
			ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr, 100678610);
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x0020F040 File Offset: 0x0020D240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234833, XrefRangeEnd = 234838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x0020F074 File Offset: 0x0020D274
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitToMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitToMenu>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitToMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x00039068 File Offset: 0x00037268
		public ExitToMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005288 RID: 21128
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x04005289 RID: 21129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
