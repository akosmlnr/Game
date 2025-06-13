using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000491 RID: 1169
	public class GUIDUtility : MonoBehaviour
	{
		// Token: 0x06006435 RID: 25653 RVA: 0x001C99F8 File Offset: 0x001C7BF8
		// Note: this type is marked as 'beforefieldinit'.
		static GUIDUtility()
		{
			Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GUIDUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr);
			GUIDUtility.NativeMethodInfoPtr_GenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr, 100676108);
			GUIDUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr, 100676109);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x001C9A50 File Offset: 0x001C7C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206553, XrefRangeEnd = 206559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDUtility.NativeMethodInfoPtr_GenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x001C9A84 File Offset: 0x001C7C84
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIDUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIDUtility>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIDUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x0002F1EA File Offset: 0x0002D3EA
		public GUIDUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004456 RID: 17494
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGUID_Public_Void_0;

		// Token: 0x04004457 RID: 17495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
