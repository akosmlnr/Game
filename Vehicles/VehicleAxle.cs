using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x0200050B RID: 1291
	public class VehicleAxle : MonoBehaviour
	{
		// Token: 0x060070F5 RID: 28917 RVA: 0x001F4DD8 File Offset: 0x001F2FD8
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleAxle()
		{
			Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleAxle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr);
			VehicleAxle.NativeFieldInfoPtr_wheel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, "wheel");
			VehicleAxle.NativeFieldInfoPtr_model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, "model");
			VehicleAxle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677664);
			VehicleAxle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677665);
			VehicleAxle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr, 100677666);
		}

		// Token: 0x060070F6 RID: 28918 RVA: 0x001F4E6C File Offset: 0x001F306C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224490, XrefRangeEnd = 224496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAxle.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070F7 RID: 28919 RVA: 0x001F4EA8 File Offset: 0x001F30A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224496, XrefRangeEnd = 224514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleAxle.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070F8 RID: 28920 RVA: 0x001F4EE4 File Offset: 0x001F30E4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleAxle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleAxle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleAxle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x000353AB File Offset: 0x000335AB
		public VehicleAxle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021DA RID: 8666
		// (get) Token: 0x060070FA RID: 28922 RVA: 0x001F4F20 File Offset: 0x001F3120
		// (set) Token: 0x060070FB RID: 28923 RVA: 0x000353B4 File Offset: 0x000335B4
		public unsafe Wheel wheel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_wheel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wheel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_wheel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021DB RID: 8667
		// (get) Token: 0x060070FC RID: 28924 RVA: 0x001F4F50 File Offset: 0x001F3150
		// (set) Token: 0x060070FD RID: 28925 RVA: 0x000353D3 File Offset: 0x000335D3
		public unsafe Transform model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleAxle.NativeFieldInfoPtr_model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeFieldInfoPtr_wheel;

		// Token: 0x04004D46 RID: 19782
		private static readonly IntPtr NativeFieldInfoPtr_model;

		// Token: 0x04004D47 RID: 19783
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04004D48 RID: 19784
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004D49 RID: 19785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
