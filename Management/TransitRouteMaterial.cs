using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C8 RID: 968
	public class TransitRouteMaterial : MonoBehaviour
	{
		// Token: 0x06004AC0 RID: 19136 RVA: 0x0016DC24 File Offset: 0x0016BE24
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRouteMaterial()
		{
			Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRouteMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr);
			TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100672643);
			TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr, 100672644);
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x0016DC7C File Offset: 0x0016BE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167747, XrefRangeEnd = 167756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AC2 RID: 19138 RVA: 0x0016DCB0 File Offset: 0x0016BEB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRouteMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRouteMaterial>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRouteMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AC3 RID: 19139 RVA: 0x00023D90 File Offset: 0x00021F90
		public TransitRouteMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003266 RID: 12902
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003267 RID: 12903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
