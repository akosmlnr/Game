using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200054F RID: 1359
	public class BetaEnabledGameObject : MonoBehaviour
	{
		// Token: 0x0600785C RID: 30812 RVA: 0x0020D894 File Offset: 0x0020BA94
		// Note: this type is marked as 'beforefieldinit'.
		static BetaEnabledGameObject()
		{
			Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "BetaEnabledGameObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr);
			BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100678548);
			BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr, 100678549);
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x0020D8EC File Offset: 0x0020BAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234478, XrefRangeEnd = 234482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x0020D920 File Offset: 0x0020BB20
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BetaEnabledGameObject() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BetaEnabledGameObject>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BetaEnabledGameObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x00038CD2 File Offset: 0x00036ED2
		public BetaEnabledGameObject(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400523D RID: 21053
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400523E RID: 21054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
