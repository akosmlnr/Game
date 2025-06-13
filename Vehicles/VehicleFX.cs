using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x0200050E RID: 1294
	public class VehicleFX : MonoBehaviour
	{
		// Token: 0x06007139 RID: 28985 RVA: 0x001F58E4 File Offset: 0x001F3AE4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleFX()
		{
			Il2CppClassPointerStore<VehicleFX>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleFX");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr);
			VehicleFX.NativeFieldInfoPtr_exhaustFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, "exhaustFX");
			VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677680);
			VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677681);
			VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr, 100677682);
		}

		// Token: 0x0600713A RID: 28986 RVA: 0x001F5964 File Offset: 0x001F3B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224807, XrefRangeEnd = 224809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x001F59A0 File Offset: 0x001F3BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224809, XrefRangeEnd = 224811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnVehicleStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleFX.NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x001F59DC File Offset: 0x001F3BDC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleFX() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleFX>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleFX.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x000355F4 File Offset: 0x000337F4
		public VehicleFX(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600713E RID: 28990 RVA: 0x001F5A18 File Offset: 0x001F3C18
		// (set) Token: 0x0600713F RID: 28991 RVA: 0x000355FD File Offset: 0x000337FD
		public unsafe Il2CppReferenceArray<ParticleSystem> exhaustFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleFX.NativeFieldInfoPtr_exhaustFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D6C RID: 19820
		private static readonly IntPtr NativeFieldInfoPtr_exhaustFX;

		// Token: 0x04004D6D RID: 19821
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStart_Public_Virtual_New_Void_0;

		// Token: 0x04004D6E RID: 19822
		private static readonly IntPtr NativeMethodInfoPtr_OnVehicleStop_Public_Virtual_New_Void_0;

		// Token: 0x04004D6F RID: 19823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
