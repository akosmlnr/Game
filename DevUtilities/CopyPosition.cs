using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000475 RID: 1141
	public class CopyPosition : MonoBehaviour
	{
		// Token: 0x0600622C RID: 25132 RVA: 0x001C2FDC File Offset: 0x001C11DC
		// Note: this type is marked as 'beforefieldinit'.
		static CopyPosition()
		{
			Il2CppClassPointerStore<CopyPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CopyPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr);
			CopyPosition.NativeFieldInfoPtr_ToCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, "ToCopy");
			CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675887);
			CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675888);
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x001C3048 File Offset: 0x001C1248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203554, XrefRangeEnd = 203557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x001C307C File Offset: 0x001C127C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x0002E2AE File Offset: 0x0002C4AE
		public CopyPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06006230 RID: 25136 RVA: 0x001C30B8 File Offset: 0x001C12B8
		// (set) Token: 0x06006231 RID: 25137 RVA: 0x0002E2B7 File Offset: 0x0002C4B7
		public unsafe Transform ToCopy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004309 RID: 17161
		private static readonly IntPtr NativeFieldInfoPtr_ToCopy;

		// Token: 0x0400430A RID: 17162
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400430B RID: 17163
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
