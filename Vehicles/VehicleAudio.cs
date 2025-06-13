using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x0200050A RID: 1290
	public class VehicleAudio : MonoBehaviour
	{
		// Token: 0x060070DF RID: 28895 RVA: 0x001F49EC File Offset: 0x001F2BEC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAudio()
		{
			Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr);
			VehicleAudio.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "Vehicle");
			VehicleAudio.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "Lights");
			VehicleAudio.NativeFieldInfoPtr_EngineStartSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "EngineStartSound");
			VehicleAudio.NativeFieldInfoPtr_EngineStopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "EngineStopSound");
			VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HeadlightsOnSound");
			VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HeadlightsOffSound");
			VehicleAudio.NativeFieldInfoPtr_HornSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, "HornSound");
			VehicleAudio.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677658);
			VehicleAudio.NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677659);
			VehicleAudio.NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677660);
			VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677661);
			VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677662);
			VehicleAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr, 100677663);
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x001F4B20 File Offset: 0x001F2D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224466, XrefRangeEnd = 224490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070E1 RID: 28897 RVA: 0x001F4B5C File Offset: 0x001F2D5C
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EngineStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070E2 RID: 28898 RVA: 0x001F4B98 File Offset: 0x001F2D98
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EngineStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x001F4BD4 File Offset: 0x001F2DD4
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HeadlightsToggledOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x001F4C10 File Offset: 0x001F2E10
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HeadlightsToggledOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAudio.NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x001F4C4C File Offset: 0x001F2E4C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAudio() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAudio>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x000352C9 File Offset: 0x000334C9
		public VehicleAudio(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021D3 RID: 8659
		// (get) Token: 0x060070E7 RID: 28903 RVA: 0x001F4C88 File Offset: 0x001F2E88
		// (set) Token: 0x060070E8 RID: 28904 RVA: 0x000352D2 File Offset: 0x000334D2
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D4 RID: 8660
		// (get) Token: 0x060070E9 RID: 28905 RVA: 0x001F4CB8 File Offset: 0x001F2EB8
		// (set) Token: 0x060070EA RID: 28906 RVA: 0x000352F1 File Offset: 0x000334F1
		public unsafe VehicleLights Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleLights>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D5 RID: 8661
		// (get) Token: 0x060070EB RID: 28907 RVA: 0x001F4CE8 File Offset: 0x001F2EE8
		// (set) Token: 0x060070EC RID: 28908 RVA: 0x00035310 File Offset: 0x00033510
		public unsafe AudioSource EngineStartSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStartSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStartSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D6 RID: 8662
		// (get) Token: 0x060070ED RID: 28909 RVA: 0x001F4D18 File Offset: 0x001F2F18
		// (set) Token: 0x060070EE RID: 28910 RVA: 0x0003532F File Offset: 0x0003352F
		public unsafe AudioSource EngineStopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_EngineStopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D7 RID: 8663
		// (get) Token: 0x060070EF RID: 28911 RVA: 0x001F4D48 File Offset: 0x001F2F48
		// (set) Token: 0x060070F0 RID: 28912 RVA: 0x0003534E File Offset: 0x0003354E
		public unsafe AudioSource HeadlightsOnSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOnSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D8 RID: 8664
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x001F4D78 File Offset: 0x001F2F78
		// (set) Token: 0x060070F2 RID: 28914 RVA: 0x0003536D File Offset: 0x0003356D
		public unsafe AudioSource HeadlightsOffSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HeadlightsOffSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021D9 RID: 8665
		// (get) Token: 0x060070F3 RID: 28915 RVA: 0x001F4DA8 File Offset: 0x001F2FA8
		// (set) Token: 0x060070F4 RID: 28916 RVA: 0x0003538C File Offset: 0x0003358C
		public unsafe AudioSource HornSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HornSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAudio.NativeFieldInfoPtr_HornSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeFieldInfoPtr_EngineStartSound;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeFieldInfoPtr_EngineStopSound;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeFieldInfoPtr_HeadlightsOnSound;

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeFieldInfoPtr_HeadlightsOffSound;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeFieldInfoPtr_HornSound;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeMethodInfoPtr_EngineStart_Protected_Virtual_New_Void_0;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeMethodInfoPtr_EngineStop_Protected_Virtual_New_Void_0;

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeMethodInfoPtr_HeadlightsToggledOn_Protected_Virtual_New_Void_0;

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeMethodInfoPtr_HeadlightsToggledOff_Protected_Virtual_New_Void_0;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
