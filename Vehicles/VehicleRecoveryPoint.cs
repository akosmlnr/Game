using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000514 RID: 1300
	public class VehicleRecoveryPoint : MonoBehaviour
	{
		// Token: 0x060071E0 RID: 29152 RVA: 0x001F7B30 File Offset: 0x001F5D30
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecoveryPoint()
		{
			Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleRecoveryPoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr);
			VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, "recoveryPoints");
			VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677743);
			VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677744);
			VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr, 100677745);
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x001F7BB0 File Offset: 0x001F5DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225323, XrefRangeEnd = 225333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecoveryPoint.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x001F7BEC File Offset: 0x001F5DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225360, RefRangeEnd = 225361, XrefRangeStart = 225333, XrefRangeEnd = 225360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VehicleRecoveryPoint GetClosestRecoveryPoint(Vector3 pos)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleRecoveryPoint>(intPtr2) : null;
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x001F7C2C File Offset: 0x001F5E2C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecoveryPoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecoveryPoint>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecoveryPoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00035B93 File Offset: 0x00033D93
		public VehicleRecoveryPoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x060071E5 RID: 29157 RVA: 0x001F7C68 File Offset: 0x001F5E68
		// (set) Token: 0x060071E6 RID: 29158 RVA: 0x00035B9C File Offset: 0x00033D9C
		public unsafe static List<VehicleRecoveryPoint> recoveryPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleRecoveryPoint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecoveryPoint.NativeFieldInfoPtr_recoveryPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DD8 RID: 19928
		private static readonly IntPtr NativeFieldInfoPtr_recoveryPoints;

		// Token: 0x04004DD9 RID: 19929
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004DDA RID: 19930
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestRecoveryPoint_Public_Static_VehicleRecoveryPoint_Vector3_0;

		// Token: 0x04004DDB RID: 19931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
