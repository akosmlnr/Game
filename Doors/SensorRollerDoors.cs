using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x0200044A RID: 1098
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x06005F8E RID: 24462 RVA: 0x001BA444 File Offset: 0x001B8644
		// Note: this type is marked as 'beforefieldinit'.
		static SensorRollerDoors()
		{
			Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SensorRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr);
			SensorRollerDoors.NativeFieldInfoPtr_Detector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "Detector");
			SensorRollerDoors.NativeFieldInfoPtr_ClipDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "ClipDetector");
			SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "DetectPlayerOccupiedVehiclesOnly");
			SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100675547);
			SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100675548);
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x001BA4D8 File Offset: 0x001B86D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200457, XrefRangeEnd = 200468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x001BA514 File Offset: 0x001B8714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x0002CD5F File Offset: 0x0002AF5F
		public SensorRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06005F92 RID: 24466 RVA: 0x001BA550 File Offset: 0x001B8750
		// (set) Token: 0x06005F93 RID: 24467 RVA: 0x0002CD68 File Offset: 0x0002AF68
		public unsafe VehicleDetector Detector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06005F94 RID: 24468 RVA: 0x001BA580 File Offset: 0x001B8780
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x0002CD87 File Offset: 0x0002AF87
		public unsafe VehicleDetector ClipDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06005F96 RID: 24470 RVA: 0x001BA5B0 File Offset: 0x001B87B0
		// (set) Token: 0x06005F97 RID: 24471 RVA: 0x0002CDA6 File Offset: 0x0002AFA6
		public unsafe bool DetectPlayerOccupiedVehiclesOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly)) = value;
			}
		}

		// Token: 0x04004163 RID: 16739
		private static readonly IntPtr NativeFieldInfoPtr_Detector;

		// Token: 0x04004164 RID: 16740
		private static readonly IntPtr NativeFieldInfoPtr_ClipDetector;

		// Token: 0x04004165 RID: 16741
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly;

		// Token: 0x04004166 RID: 16742
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004167 RID: 16743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
