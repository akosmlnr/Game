using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x02000390 RID: 912
	public class TransportInitializer : MonoBehaviour
	{
		// Token: 0x06004636 RID: 17974 RVA: 0x0015BA10 File Offset: 0x00159C10
		// Note: this type is marked as 'beforefieldinit'.
		static TransportInitializer()
		{
			Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "TransportInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr);
			TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100671950);
			TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr, 100671951);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x0015BA68 File Offset: 0x00159C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160372, XrefRangeEnd = 160382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004638 RID: 17976 RVA: 0x0015BA9C File Offset: 0x00159C9C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportInitializer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004639 RID: 17977 RVA: 0x00022177 File Offset: 0x00020377
		public TransportInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002F00 RID: 12032
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04002F01 RID: 12033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
