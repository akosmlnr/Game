using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200047C RID: 1148
	public class LookAt : MonoBehaviour
	{
		// Token: 0x060062AB RID: 25259 RVA: 0x001C4934 File Offset: 0x001C2B34
		// Note: this type is marked as 'beforefieldinit'.
		static LookAt()
		{
			Il2CppClassPointerStore<LookAt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LookAt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAt>.NativeClassPtr);
			LookAt.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAt>.NativeClassPtr, "Target");
			LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675942);
			LookAt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAt>.NativeClassPtr, 100675943);
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x001C49A0 File Offset: 0x001C2BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204076, XrefRangeEnd = 204082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x001C49D4 File Offset: 0x001C2BD4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LookAt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAt>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LookAt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x0002E6DE File Offset: 0x0002C8DE
		public LookAt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x060062AF RID: 25263 RVA: 0x001C4A10 File Offset: 0x001C2C10
		// (set) Token: 0x060062B0 RID: 25264 RVA: 0x0002E6E7 File Offset: 0x0002C8E7
		public unsafe Transform Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LookAt.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400435B RID: 17243
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x0400435C RID: 17244
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400435D RID: 17245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
