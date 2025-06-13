using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x02000519 RID: 1305
	[System.Serializable]
	public class VehicleKeyFrame : Il2CppSystem.Object
	{
		// Token: 0x0600727C RID: 29308 RVA: 0x001F948C File Offset: 0x001F768C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleKeyFrame()
		{
			Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "VehicleKeyFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr);
			VehicleKeyFrame.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "position");
			VehicleKeyFrame.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "rotation");
			VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "brakesApplied");
			VehicleKeyFrame.NativeFieldInfoPtr_reversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "reversing");
			VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "headlightsOn");
			VehicleKeyFrame.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "wheels");
			VehicleKeyFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, 100677780);
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x001F9548 File Offset: 0x001F7748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225551, XrefRangeEnd = 225559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleKeyFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x00036199 File Offset: 0x00034399
		public VehicleKeyFrame(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x0600727F RID: 29311 RVA: 0x001F9584 File Offset: 0x001F7784
		// (set) Token: 0x06007280 RID: 29312 RVA: 0x000361A2 File Offset: 0x000343A2
		public unsafe Vector3 position
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x06007281 RID: 29313 RVA: 0x001F95AC File Offset: 0x001F77AC
		// (set) Token: 0x06007282 RID: 29314 RVA: 0x000361BD File Offset: 0x000343BD
		public unsafe Quaternion rotation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x1700226A RID: 8810
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x001F95D4 File Offset: 0x001F77D4
		// (set) Token: 0x06007284 RID: 29316 RVA: 0x000361D8 File Offset: 0x000343D8
		public unsafe bool brakesApplied
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied)) = value;
			}
		}

		// Token: 0x1700226B RID: 8811
		// (get) Token: 0x06007285 RID: 29317 RVA: 0x001F95FC File Offset: 0x001F77FC
		// (set) Token: 0x06007286 RID: 29318 RVA: 0x000361F3 File Offset: 0x000343F3
		public unsafe bool reversing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_reversing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_reversing)) = value;
			}
		}

		// Token: 0x1700226C RID: 8812
		// (get) Token: 0x06007287 RID: 29319 RVA: 0x001F9624 File Offset: 0x001F7824
		// (set) Token: 0x06007288 RID: 29320 RVA: 0x0003620E File Offset: 0x0003440E
		public unsafe bool headlightsOn
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn)) = value;
			}
		}

		// Token: 0x1700226D RID: 8813
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x001F964C File Offset: 0x001F784C
		// (set) Token: 0x0600728A RID: 29322 RVA: 0x00036229 File Offset: 0x00034429
		public unsafe List<VehicleKeyFrame.WheelTransform> wheels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_wheels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame.WheelTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E33 RID: 20019
		private static readonly System.IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04004E34 RID: 20020
		private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04004E35 RID: 20021
		private static readonly System.IntPtr NativeFieldInfoPtr_brakesApplied;

		// Token: 0x04004E36 RID: 20022
		private static readonly System.IntPtr NativeFieldInfoPtr_reversing;

		// Token: 0x04004E37 RID: 20023
		private static readonly System.IntPtr NativeFieldInfoPtr_headlightsOn;

		// Token: 0x04004E38 RID: 20024
		private static readonly System.IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04004E39 RID: 20025
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AB9 RID: 2745
		[System.Serializable]
		public class WheelTransform : Il2CppSystem.Object
		{
			// Token: 0x0600D652 RID: 54866 RVA: 0x00337A24 File Offset: 0x00335C24
			// Note: this type is marked as 'beforefieldinit'.
			static WheelTransform()
			{
				Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "WheelTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr);
				VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, "yPos");
				VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, "rotation");
				VehicleKeyFrame.WheelTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, 100677781);
			}

			// Token: 0x0600D653 RID: 54867 RVA: 0x00337A8C File Offset: 0x00335C8C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WheelTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleKeyFrame.WheelTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D654 RID: 54868 RVA: 0x00068037 File Offset: 0x00066237
			public WheelTransform(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700423D RID: 16957
			// (get) Token: 0x0600D655 RID: 54869 RVA: 0x00337AC8 File Offset: 0x00335CC8
			// (set) Token: 0x0600D656 RID: 54870 RVA: 0x00068040 File Offset: 0x00066240
			public unsafe float yPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x1700423E RID: 16958
			// (get) Token: 0x0600D657 RID: 54871 RVA: 0x00337AF0 File Offset: 0x00335CF0
			// (set) Token: 0x0600D658 RID: 54872 RVA: 0x0006805B File Offset: 0x0006625B
			public unsafe Quaternion rotation
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x040090A7 RID: 37031
			private static readonly System.IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x040090A8 RID: 37032
			private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x040090A9 RID: 37033
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
