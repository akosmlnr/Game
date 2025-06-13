using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000698 RID: 1688
	public class VersionText : MonoBehaviour
	{
		// Token: 0x060095B6 RID: 38326 RVA: 0x0026ADF0 File Offset: 0x00268FF0
		// Note: this type is marked as 'beforefieldinit'.
		static VersionText()
		{
			Il2CppClassPointerStore<VersionText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VersionText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionText>.NativeClassPtr);
			VersionText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100681957);
			VersionText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100681958);
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x0026AE48 File Offset: 0x00269048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269395, XrefRangeEnd = 269406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x0026AE7C File Offset: 0x0026907C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionText>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00048452 File Offset: 0x00046652
		public VersionText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400651A RID: 25882
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400651B RID: 25883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
