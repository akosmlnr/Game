using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200056D RID: 1389
	public class RigidbodyEventBroadcaster : MonoBehaviour
	{
		// Token: 0x060079B8 RID: 31160 RVA: 0x002119FC File Offset: 0x0020FBFC
		// Note: this type is marked as 'beforefieldinit'.
		static RigidbodyEventBroadcaster()
		{
			Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "RigidbodyEventBroadcaster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr);
			RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, "onTriggerEnter");
			RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678713);
			RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr, 100678714);
		}

		// Token: 0x060079B9 RID: 31161 RVA: 0x00211A68 File Offset: 0x0020FC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235706, XrefRangeEnd = 235709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079BA RID: 31162 RVA: 0x00211AAC File Offset: 0x0020FCAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RigidbodyEventBroadcaster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RigidbodyEventBroadcaster>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RigidbodyEventBroadcaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060079BB RID: 31163 RVA: 0x0003966A File Offset: 0x0003786A
		public RigidbodyEventBroadcaster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002496 RID: 9366
		// (get) Token: 0x060079BC RID: 31164 RVA: 0x00211AE8 File Offset: 0x0020FCE8
		// (set) Token: 0x060079BD RID: 31165 RVA: 0x00039673 File Offset: 0x00037873
		public unsafe UnityEvent<Collider> onTriggerEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RigidbodyEventBroadcaster.NativeFieldInfoPtr_onTriggerEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400530F RID: 21263
		private static readonly IntPtr NativeFieldInfoPtr_onTriggerEnter;

		// Token: 0x04005310 RID: 21264
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04005311 RID: 21265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
