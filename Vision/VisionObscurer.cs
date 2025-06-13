using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000183 RID: 387
	public class VisionObscurer : MonoBehaviour
	{
		// Token: 0x06001EE1 RID: 7905 RVA: 0x000D375C File Offset: 0x000D195C
		// Note: this type is marked as 'beforefieldinit'.
		static VisionObscurer()
		{
			Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisionObscurer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr);
			VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr, "ObscuranceAmount");
			VisionObscurer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr, 100666833);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000D37B4 File Offset: 0x000D19B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisionObscurer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisionObscurer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisionObscurer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x000114F5 File Offset: 0x0000F6F5
		public VisionObscurer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x000D37F0 File Offset: 0x000D19F0
		// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x000114FE File Offset: 0x0000F6FE
		public unsafe float ObscuranceAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisionObscurer.NativeFieldInfoPtr_ObscuranceAmount)) = value;
			}
		}

		// Token: 0x04001485 RID: 5253
		private static readonly IntPtr NativeFieldInfoPtr_ObscuranceAmount;

		// Token: 0x04001486 RID: 5254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
