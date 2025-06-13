using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000501 RID: 1281
	public class ForkliftFork : MonoBehaviour
	{
		// Token: 0x06006F0C RID: 28428 RVA: 0x001EE1D0 File Offset: 0x001EC3D0
		// Note: this type is marked as 'beforefieldinit'.
		static ForkliftFork()
		{
			Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ForkliftFork");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr);
			ForkliftFork.NativeFieldInfoPtr_forklift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr, "forklift");
			ForkliftFork.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr, 100677422);
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x001EE228 File Offset: 0x001EC428
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForkliftFork() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForkliftFork.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x00034552 File Offset: 0x00032752
		public ForkliftFork(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x001EE264 File Offset: 0x001EC464
		// (set) Token: 0x06006F10 RID: 28432 RVA: 0x0003455B File Offset: 0x0003275B
		public unsafe Forklift forklift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftFork.NativeFieldInfoPtr_forklift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Forklift>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftFork.NativeFieldInfoPtr_forklift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004BE9 RID: 19433
		private static readonly IntPtr NativeFieldInfoPtr_forklift;

		// Token: 0x04004BEA RID: 19434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
