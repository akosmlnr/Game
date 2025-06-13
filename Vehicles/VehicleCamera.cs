using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x0200050C RID: 1292
	public class VehicleCamera : MonoBehaviour
	{
		// Token: 0x060070FE RID: 28926 RVA: 0x001F4F80 File Offset: 0x001F3180
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleCamera()
		{
			Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr);
			VehicleCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "followDelta");
			VehicleCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMinLimit");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideTime");
			VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "manualOverrideReturnTime");
			VehicleCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "xSpeed");
			VehicleCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "ySpeed");
			VehicleCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "yMaxLimit");
			VehicleCamera.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "vehicle");
			VehicleCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraOrigin");
			VehicleCamera.NativeFieldInfoPtr_lateralOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lateralOffset");
			VehicleCamera.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "verticalOffset");
			VehicleCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraReversed");
			VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			VehicleCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "orbitDistance");
			VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastFrameCameraOffset");
			VehicleCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "lastManualOffset");
			VehicleCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "targetTransform");
			VehicleCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "cameraDolly");
			VehicleCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "x");
			VehicleCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, "y");
			VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677667);
			VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677668);
			VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677669);
			VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677670);
			VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677671);
			VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677672);
			VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677673);
			VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677674);
			VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677675);
			VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677676);
			VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr, 100677677);
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x060070FF RID: 28927 RVA: 0x001F521C File Offset: 0x001F341C
		public unsafe Transform cam
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 224520, RefRangeEnd = 224535, XrefRangeStart = 224514, XrefRangeEnd = 224520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x001F525C File Offset: 0x001F345C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224535, XrefRangeEnd = 224604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007101 RID: 28929 RVA: 0x001F5298 File Offset: 0x001F3498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224604, XrefRangeEnd = 224622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Subscribe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_Subscribe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x001F52CC File Offset: 0x001F34CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224638, RefRangeEnd = 224639, XrefRangeStart = 224622, XrefRangeEnd = 224638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007103 RID: 28931 RVA: 0x001F5308 File Offset: 0x001F3508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224639, XrefRangeEnd = 224650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnteredVehicle(LandVehicle veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007104 RID: 28932 RVA: 0x001F534C File Offset: 0x001F354C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224650, XrefRangeEnd = 224665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007105 RID: 28933 RVA: 0x001F5380 File Offset: 0x001F3580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224759, RefRangeEnd = 224760, XrefRangeStart = 224665, XrefRangeEnd = 224759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007106 RID: 28934 RVA: 0x001F53BC File Offset: 0x001F35BC
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007107 RID: 28935 RVA: 0x001F5418 File Offset: 0x001F3618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224767, RefRangeEnd = 224768, XrefRangeStart = 224760, XrefRangeEnd = 224767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007108 RID: 28936 RVA: 0x001F5454 File Offset: 0x001F3654
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224795, RefRangeEnd = 224798, XrefRangeStart = 224768, XrefRangeEnd = 224795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007109 RID: 28937 RVA: 0x001F54A0 File Offset: 0x001F36A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224803, RefRangeEnd = 224804, XrefRangeStart = 224798, XrefRangeEnd = 224803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleCamera>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600710A RID: 28938 RVA: 0x000353F2 File Offset: 0x000335F2
		public VehicleCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021DC RID: 8668
		// (get) Token: 0x0600710B RID: 28939 RVA: 0x001F54DC File Offset: 0x001F36DC
		// (set) Token: 0x0600710C RID: 28940 RVA: 0x000353FB File Offset: 0x000335FB
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x170021DD RID: 8669
		// (get) Token: 0x0600710D RID: 28941 RVA: 0x001F54F8 File Offset: 0x001F36F8
		// (set) Token: 0x0600710E RID: 28942 RVA: 0x00035409 File Offset: 0x00033609
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x170021DE RID: 8670
		// (get) Token: 0x0600710F RID: 28943 RVA: 0x001F5514 File Offset: 0x001F3714
		// (set) Token: 0x06007110 RID: 28944 RVA: 0x00035417 File Offset: 0x00033617
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x170021DF RID: 8671
		// (get) Token: 0x06007111 RID: 28945 RVA: 0x001F5530 File Offset: 0x001F3730
		// (set) Token: 0x06007112 RID: 28946 RVA: 0x00035425 File Offset: 0x00033625
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x170021E0 RID: 8672
		// (get) Token: 0x06007113 RID: 28947 RVA: 0x001F554C File Offset: 0x001F374C
		// (set) Token: 0x06007114 RID: 28948 RVA: 0x00035433 File Offset: 0x00033633
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x170021E1 RID: 8673
		// (get) Token: 0x06007115 RID: 28949 RVA: 0x001F5568 File Offset: 0x001F3768
		// (set) Token: 0x06007116 RID: 28950 RVA: 0x00035441 File Offset: 0x00033641
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x170021E2 RID: 8674
		// (get) Token: 0x06007117 RID: 28951 RVA: 0x001F5584 File Offset: 0x001F3784
		// (set) Token: 0x06007118 RID: 28952 RVA: 0x0003544F File Offset: 0x0003364F
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x170021E3 RID: 8675
		// (get) Token: 0x06007119 RID: 28953 RVA: 0x001F55A0 File Offset: 0x001F37A0
		// (set) Token: 0x0600711A RID: 28954 RVA: 0x0003545D File Offset: 0x0003365D
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E4 RID: 8676
		// (get) Token: 0x0600711B RID: 28955 RVA: 0x001F55D0 File Offset: 0x001F37D0
		// (set) Token: 0x0600711C RID: 28956 RVA: 0x0003547C File Offset: 0x0003367C
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600711D RID: 28957 RVA: 0x001F5600 File Offset: 0x001F3800
		// (set) Token: 0x0600711E RID: 28958 RVA: 0x0003549B File Offset: 0x0003369B
		public unsafe float lateralOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lateralOffset)) = value;
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x0600711F RID: 28959 RVA: 0x001F5628 File Offset: 0x001F3828
		// (set) Token: 0x06007120 RID: 28960 RVA: 0x000354B6 File Offset: 0x000336B6
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06007121 RID: 28961 RVA: 0x001F5650 File Offset: 0x001F3850
		// (set) Token: 0x06007122 RID: 28962 RVA: 0x000354D1 File Offset: 0x000336D1
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06007123 RID: 28963 RVA: 0x001F5678 File Offset: 0x001F3878
		// (set) Token: 0x06007124 RID: 28964 RVA: 0x000354EC File Offset: 0x000336EC
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x06007125 RID: 28965 RVA: 0x001F56A0 File Offset: 0x001F38A0
		// (set) Token: 0x06007126 RID: 28966 RVA: 0x00035507 File Offset: 0x00033707
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x06007127 RID: 28967 RVA: 0x001F56C8 File Offset: 0x001F38C8
		// (set) Token: 0x06007128 RID: 28968 RVA: 0x00035522 File Offset: 0x00033722
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x06007129 RID: 28969 RVA: 0x001F56F0 File Offset: 0x001F38F0
		// (set) Token: 0x0600712A RID: 28970 RVA: 0x0003553D File Offset: 0x0003373D
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x0600712B RID: 28971 RVA: 0x001F5718 File Offset: 0x001F3918
		// (set) Token: 0x0600712C RID: 28972 RVA: 0x00035558 File Offset: 0x00033758
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600712D RID: 28973 RVA: 0x001F5748 File Offset: 0x001F3948
		// (set) Token: 0x0600712E RID: 28974 RVA: 0x00035577 File Offset: 0x00033777
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600712F RID: 28975 RVA: 0x001F5778 File Offset: 0x001F3978
		// (set) Token: 0x06007130 RID: 28976 RVA: 0x00035596 File Offset: 0x00033796
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x06007131 RID: 28977 RVA: 0x001F57A0 File Offset: 0x001F39A0
		// (set) Token: 0x06007132 RID: 28978 RVA: 0x000355B1 File Offset: 0x000337B1
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x04004D4A RID: 19786
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x04004D4B RID: 19787
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04004D51 RID: 19793
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004D52 RID: 19794
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04004D53 RID: 19795
		private static readonly IntPtr NativeFieldInfoPtr_lateralOffset;

		// Token: 0x04004D54 RID: 19796
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x04004D55 RID: 19797
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x04004D56 RID: 19798
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x04004D57 RID: 19799
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeMethodInfoPtr_Subscribe_Private_Void_0;

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnteredVehicle_Private_Void_LandVehicle_0;

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_0;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
