using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x0200050D RID: 1293
	public class VehicleCollisionDetector : MonoBehaviour
	{
		// Token: 0x06007133 RID: 28979 RVA: 0x001F57C8 File Offset: 0x001F39C8
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCollisionDetector()
		{
			Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCollisionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr);
			VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, "onCollisionEnter");
			VehicleCollisionDetector.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, 100677678);
			VehicleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr, 100677679);
		}

		// Token: 0x06007134 RID: 28980 RVA: 0x001F5834 File Offset: 0x001F3A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224804, XrefRangeEnd = 224807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollisionDetector.NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007135 RID: 28981 RVA: 0x001F5878 File Offset: 0x001F3A78
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCollisionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCollisionDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCollisionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007136 RID: 28982 RVA: 0x000355CC File Offset: 0x000337CC
		public VehicleCollisionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x06007137 RID: 28983 RVA: 0x001F58B4 File Offset: 0x001F3AB4
		// (set) Token: 0x06007138 RID: 28984 RVA: 0x000355D5 File Offset: 0x000337D5
		public unsafe UnityEvent<Collision> onCollisionEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Collision>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCollisionDetector.NativeFieldInfoPtr_onCollisionEnter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeFieldInfoPtr_onCollisionEnter;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Public_Void_Collision_0;

		// Token: 0x04004D6B RID: 19819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
