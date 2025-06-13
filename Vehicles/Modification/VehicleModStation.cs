using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Modification
{
	// Token: 0x0200051D RID: 1309
	public class VehicleModStation : MonoBehaviour
	{
		// Token: 0x060072A2 RID: 29346 RVA: 0x001F9AB0 File Offset: 0x001F7CB0
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleModStation()
		{
			Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Modification", "VehicleModStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr);
			VehicleModStation.NativeFieldInfoPtr_vehiclePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, "vehiclePosition");
			VehicleModStation.NativeFieldInfoPtr_orbitCam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, "orbitCam");
			VehicleModStation.NativeFieldInfoPtr__currentVehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, "<currentVehicle>k__BackingField");
			VehicleModStation.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677795);
			VehicleModStation.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677796);
			VehicleModStation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677797);
			VehicleModStation.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677798);
			VehicleModStation.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677799);
			VehicleModStation.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677800);
			VehicleModStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr, 100677801);
		}

		// Token: 0x17002277 RID: 8823
		// (get) Token: 0x060072A3 RID: 29347 RVA: 0x001F9BA8 File Offset: 0x001F7DA8
		// (set) Token: 0x060072A4 RID: 29348 RVA: 0x001F9BE8 File Offset: 0x001F7DE8
		public unsafe LandVehicle currentVehicle
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 20988, RefRangeEnd = 21002, XrefRangeStart = 20988, XrefRangeEnd = 21002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 21003, RefRangeEnd = 21004, XrefRangeStart = 21003, XrefRangeEnd = 21004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002278 RID: 8824
		// (get) Token: 0x060072A5 RID: 29349 RVA: 0x001F9C2C File Offset: 0x001F7E2C
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225708, XrefRangeEnd = 225712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x060072A6 RID: 29350 RVA: 0x001F9C68 File Offset: 0x001F7E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225712, XrefRangeEnd = 225768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072A7 RID: 29351 RVA: 0x001F9CAC File Offset: 0x001F7EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225768, XrefRangeEnd = 225789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleModStation.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072A8 RID: 29352 RVA: 0x001F9CE8 File Offset: 0x001F7EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225789, XrefRangeEnd = 225803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072A9 RID: 29353 RVA: 0x001F9D1C File Offset: 0x001F7F1C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleModStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleModStation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleModStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060072AA RID: 29354 RVA: 0x000362FB File Offset: 0x000344FB
		public VehicleModStation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002274 RID: 8820
		// (get) Token: 0x060072AB RID: 29355 RVA: 0x001F9D58 File Offset: 0x001F7F58
		// (set) Token: 0x060072AC RID: 29356 RVA: 0x00036304 File Offset: 0x00034504
		public unsafe Transform vehiclePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_vehiclePosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_vehiclePosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002275 RID: 8821
		// (get) Token: 0x060072AD RID: 29357 RVA: 0x001F9D88 File Offset: 0x001F7F88
		// (set) Token: 0x060072AE RID: 29358 RVA: 0x00036323 File Offset: 0x00034523
		public unsafe OrbitCamera orbitCam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_orbitCam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OrbitCamera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr_orbitCam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002276 RID: 8822
		// (get) Token: 0x060072AF RID: 29359 RVA: 0x001F9DB8 File Offset: 0x001F7FB8
		// (set) Token: 0x060072B0 RID: 29360 RVA: 0x00036342 File Offset: 0x00034542
		public unsafe LandVehicle _currentVehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr__currentVehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleModStation.NativeFieldInfoPtr__currentVehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E59 RID: 20057
		private static readonly IntPtr NativeFieldInfoPtr_vehiclePosition;

		// Token: 0x04004E5A RID: 20058
		private static readonly IntPtr NativeFieldInfoPtr_orbitCam;

		// Token: 0x04004E5B RID: 20059
		private static readonly IntPtr NativeFieldInfoPtr__currentVehicle_k__BackingField;

		// Token: 0x04004E5C RID: 20060
		private static readonly IntPtr NativeMethodInfoPtr_get_currentVehicle_Public_get_LandVehicle_0;

		// Token: 0x04004E5D RID: 20061
		private static readonly IntPtr NativeMethodInfoPtr_set_currentVehicle_Protected_set_Void_LandVehicle_0;

		// Token: 0x04004E5E RID: 20062
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04004E5F RID: 20063
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_LandVehicle_0;

		// Token: 0x04004E60 RID: 20064
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004E61 RID: 20065
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04004E62 RID: 20066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
