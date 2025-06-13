using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200046E RID: 1134
	public class ApplicationQuit : MonoBehaviour
	{
		// Token: 0x060061A1 RID: 24993 RVA: 0x001C192C File Offset: 0x001BFB2C
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationQuit()
		{
			Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ApplicationQuit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr);
			ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100675846);
			ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr, 100675847);
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x001C1984 File Offset: 0x001BFB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203211, XrefRangeEnd = 203215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Quit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr_Quit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x001C19B8 File Offset: 0x001BFBB8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationQuit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApplicationQuit>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationQuit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x0002DD30 File Offset: 0x0002BF30
		public ApplicationQuit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeMethodInfoPtr_Quit_Public_Void_0;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
