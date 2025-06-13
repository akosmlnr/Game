using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x0200050F RID: 1295
	public class VehicleHumanoidCollider : MonoBehaviour
	{
		// Token: 0x06007140 RID: 28992 RVA: 0x001F5A48 File Offset: 0x001F3C48
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleHumanoidCollider()
		{
			Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleHumanoidCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr);
			VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, "vehicle");
			VehicleHumanoidCollider.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677683);
			VehicleHumanoidCollider.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677684);
			VehicleHumanoidCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr, 100677685);
		}

		// Token: 0x06007141 RID: 28993 RVA: 0x001F5AC8 File Offset: 0x001F3CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224811, XrefRangeEnd = 224816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007142 RID: 28994 RVA: 0x001F5AFC File Offset: 0x001F3CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224816, XrefRangeEnd = 224827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionStay(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007143 RID: 28995 RVA: 0x001F5B40 File Offset: 0x001F3D40
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleHumanoidCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleHumanoidCollider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleHumanoidCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007144 RID: 28996 RVA: 0x0003561C File Offset: 0x0003381C
		public VehicleHumanoidCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x06007145 RID: 28997 RVA: 0x001F5B7C File Offset: 0x001F3D7C
		// (set) Token: 0x06007146 RID: 28998 RVA: 0x00035625 File Offset: 0x00033825
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleHumanoidCollider.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D70 RID: 19824
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D71 RID: 19825
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004D72 RID: 19826
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;

		// Token: 0x04004D73 RID: 19827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
