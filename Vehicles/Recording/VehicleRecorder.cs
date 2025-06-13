using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x0200051A RID: 1306
	public class VehicleRecorder : MonoBehaviour
	{
		// Token: 0x0600728B RID: 29323 RVA: 0x001F967C File Offset: 0x001F787C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleRecorder()
		{
			Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "VehicleRecorder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr);
			VehicleRecorder.NativeFieldInfoPtr_frameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "frameRate");
			VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "IS_RECORDING");
			VehicleRecorder.NativeFieldInfoPtr_keyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "keyFrames");
			VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "vehicleToRecord");
			VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, "timeSinceKeyFrame");
			VehicleRecorder.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677782);
			VehicleRecorder.NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677783);
			VehicleRecorder.NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677784);
			VehicleRecorder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr, 100677785);
		}

		// Token: 0x0600728C RID: 29324 RVA: 0x001F9760 File Offset: 0x001F7960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225559, XrefRangeEnd = 225586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleRecorder.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x001F979C File Offset: 0x001F799C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225646, RefRangeEnd = 225647, XrefRangeStart = 225586, XrefRangeEnd = 225646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame Capture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleKeyFrame>(intPtr2) : null;
		}

		// Token: 0x0600728E RID: 29326 RVA: 0x001F97DC File Offset: 0x001F79DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225647, XrefRangeEnd = 225662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame.WheelTransform CaptureWheel(Wheel wheel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(wheel);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleKeyFrame.WheelTransform>(intPtr2) : null;
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x001F982C File Offset: 0x001F7A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225662, XrefRangeEnd = 225670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleRecorder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleRecorder>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleRecorder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00036248 File Offset: 0x00034448
		public VehicleRecorder(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700226E RID: 8814
		// (get) Token: 0x06007291 RID: 29329 RVA: 0x001F9868 File Offset: 0x001F7A68
		// (set) Token: 0x06007292 RID: 29330 RVA: 0x00036251 File Offset: 0x00034451
		public unsafe static int frameRate
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VehicleRecorder.NativeFieldInfoPtr_frameRate, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleRecorder.NativeFieldInfoPtr_frameRate, (void*)(&value));
			}
		}

		// Token: 0x1700226F RID: 8815
		// (get) Token: 0x06007293 RID: 29331 RVA: 0x001F9884 File Offset: 0x001F7A84
		// (set) Token: 0x06007294 RID: 29332 RVA: 0x0003625F File Offset: 0x0003445F
		public unsafe bool IS_RECORDING
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_IS_RECORDING)) = value;
			}
		}

		// Token: 0x17002270 RID: 8816
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x001F98AC File Offset: 0x001F7AAC
		// (set) Token: 0x06007296 RID: 29334 RVA: 0x0003627A File Offset: 0x0003447A
		public unsafe List<VehicleKeyFrame> keyFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_keyFrames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_keyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002271 RID: 8817
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x001F98DC File Offset: 0x001F7ADC
		// (set) Token: 0x06007298 RID: 29336 RVA: 0x00036299 File Offset: 0x00034499
		public unsafe LandVehicle vehicleToRecord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_vehicleToRecord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002272 RID: 8818
		// (get) Token: 0x06007299 RID: 29337 RVA: 0x001F990C File Offset: 0x001F7B0C
		// (set) Token: 0x0600729A RID: 29338 RVA: 0x000362B8 File Offset: 0x000344B8
		public unsafe float timeSinceKeyFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleRecorder.NativeFieldInfoPtr_timeSinceKeyFrame)) = value;
			}
		}

		// Token: 0x04004E3A RID: 20026
		private static readonly IntPtr NativeFieldInfoPtr_frameRate;

		// Token: 0x04004E3B RID: 20027
		private static readonly IntPtr NativeFieldInfoPtr_IS_RECORDING;

		// Token: 0x04004E3C RID: 20028
		private static readonly IntPtr NativeFieldInfoPtr_keyFrames;

		// Token: 0x04004E3D RID: 20029
		private static readonly IntPtr NativeFieldInfoPtr_vehicleToRecord;

		// Token: 0x04004E3E RID: 20030
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceKeyFrame;

		// Token: 0x04004E3F RID: 20031
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004E40 RID: 20032
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Private_VehicleKeyFrame_0;

		// Token: 0x04004E41 RID: 20033
		private static readonly IntPtr NativeMethodInfoPtr_CaptureWheel_Private_WheelTransform_Wheel_0;

		// Token: 0x04004E42 RID: 20034
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
