using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000552 RID: 1362
	public class CleanNodeLinks : MonoBehaviour
	{
		// Token: 0x06007871 RID: 30833 RVA: 0x0020DC34 File Offset: 0x0020BE34
		// Note: this type is marked as 'beforefieldinit'.
		static CleanNodeLinks()
		{
			Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "CleanNodeLinks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr);
			CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100678555);
			CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr, 100678556);
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x0020DC8C File Offset: 0x0020BE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234516, XrefRangeEnd = 234535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr_Clean_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x0020DCC0 File Offset: 0x0020BEC0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanNodeLinks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanNodeLinks>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanNodeLinks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x00038D54 File Offset: 0x00036F54
		public CleanNodeLinks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005248 RID: 21064
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Public_Void_0;

		// Token: 0x04005249 RID: 21065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
