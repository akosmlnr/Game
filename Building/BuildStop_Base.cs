using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004DC RID: 1244
	public class BuildStop_Base : MonoBehaviour
	{
		// Token: 0x06006C06 RID: 27654 RVA: 0x001E4F9C File Offset: 0x001E319C
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStop_Base()
		{
			Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStop_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr);
			BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100677109);
			BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr, 100677110);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x001E4FF4 File Offset: 0x001E31F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217962, XrefRangeEnd = 217986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Stop_Building()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStop_Base.NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x001E5030 File Offset: 0x001E3230
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStop_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStop_Base>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStop_Base.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x00032CAE File Offset: 0x00030EAE
		public BuildStop_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040049FB RID: 18939
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Building_Public_Virtual_New_Void_0;

		// Token: 0x040049FC RID: 18940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
