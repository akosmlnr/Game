using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200055D RID: 1373
	public class ForcePlayerCrouch : MonoBehaviour
	{
		// Token: 0x060078F9 RID: 30969 RVA: 0x0020F64C File Offset: 0x0020D84C
		// Note: this type is marked as 'beforefieldinit'.
		static ForcePlayerCrouch()
		{
			Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ForcePlayerCrouch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr);
			ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678633);
			ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr, 100678634);
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x0020F6A4 File Offset: 0x0020D8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235063, XrefRangeEnd = 235083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x0020F6E8 File Offset: 0x0020D8E8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForcePlayerCrouch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForcePlayerCrouch>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForcePlayerCrouch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060078FC RID: 30972 RVA: 0x00039105 File Offset: 0x00037305
		public ForcePlayerCrouch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400529C RID: 21148
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x0400529D RID: 21149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
