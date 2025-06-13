using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Skating
{
	// Token: 0x020001B2 RID: 434
	public class SkateboardCamera : NetworkBehaviour
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x000E3E40 File Offset: 0x000E2040
		// Note: this type is marked as 'beforefieldinit'.
		static SkateboardCamera()
		{
			Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Skating", "SkateboardCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr);
			SkateboardCamera.NativeFieldInfoPtr_followDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "followDelta");
			SkateboardCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "yMinLimit");
			SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "manualOverrideTime");
			SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "manualOverrideReturnTime");
			SkateboardCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "xSpeed");
			SkateboardCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "ySpeed");
			SkateboardCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "yMaxLimit");
			SkateboardCamera.NativeFieldInfoPtr_cameraOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraOrigin");
			SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "CameraFollowSpeed");
			SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "HorizontalOffset");
			SkateboardCamera.NativeFieldInfoPtr_VerticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "VerticalOffset");
			SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "CameraDownAngle");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplier_MinSpeed");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplier_MaxSpeed");
			SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "FOVMultiplierChangeRate");
			SkateboardCamera.NativeFieldInfoPtr_board = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "board");
			SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "currentFovMultiplier");
			SkateboardCamera.NativeFieldInfoPtr_cameraReversed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraReversed");
			SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraAdjusted");
			SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "timeSinceCameraManuallyAdjusted");
			SkateboardCamera.NativeFieldInfoPtr_orbitDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "orbitDistance");
			SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "lastFrameCameraOffset");
			SkateboardCamera.NativeFieldInfoPtr_lastManualOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "lastManualOffset");
			SkateboardCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "targetTransform");
			SkateboardCamera.NativeFieldInfoPtr_cameraDolly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "cameraDolly");
			SkateboardCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "x");
			SkateboardCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "y");
			SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted");
			SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Skating.SkateboardCameraAssembly-CSharp.dll_Excuted");
			SkateboardCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667360);
			SkateboardCamera.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667361);
			SkateboardCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667362);
			SkateboardCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667363);
			SkateboardCamera.NativeMethodInfoPtr_Update_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667364);
			SkateboardCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667365);
			SkateboardCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667366);
			SkateboardCamera.NativeMethodInfoPtr_UpdateCamera_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667367);
			SkateboardCamera.NativeMethodInfoPtr_UpdateFOV_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667368);
			SkateboardCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667369);
			SkateboardCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667370);
			SkateboardCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667371);
			SkateboardCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667372);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667373);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667374);
			SkateboardCamera.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667375);
			SkateboardCamera.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr, 100667376);
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x000E4208 File Offset: 0x000E2408
		public unsafe Transform cam
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 116073, RefRangeEnd = 116086, XrefRangeStart = 116067, XrefRangeEnd = 116073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x000E4248 File Offset: 0x000E2448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116086, XrefRangeEnd = 116087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x000E4284 File Offset: 0x000E2484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116087, XrefRangeEnd = 116090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x000E42C0 File Offset: 0x000E24C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116090, XrefRangeEnd = 116098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x000E42F4 File Offset: 0x000E24F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116098, XrefRangeEnd = 116104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_Update_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x000E4328 File Offset: 0x000E2528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116104, XrefRangeEnd = 116108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_CheckForClick_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x000E435C File Offset: 0x000E255C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116108, XrefRangeEnd = 116116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_LateUpdate_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x000E4390 File Offset: 0x000E2590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116209, RefRangeEnd = 116210, XrefRangeStart = 116116, XrefRangeEnd = 116209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCamera()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_UpdateCamera_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x000E43C4 File Offset: 0x000E25C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116226, RefRangeEnd = 116227, XrefRangeStart = 116210, XrefRangeEnd = 116226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFOV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_UpdateFOV_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x000E43F8 File Offset: 0x000E25F8
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x000E4454 File Offset: 0x000E2654
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116238, RefRangeEnd = 116239, XrefRangeStart = 116227, XrefRangeEnd = 116238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetTargetCameraPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x000E4490 File Offset: 0x000E2690
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 116266, RefRangeEnd = 116269, XrefRangeStart = 116239, XrefRangeEnd = 116266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 LimitCameraPosition(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetPosition;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x000E44DC File Offset: 0x000E26DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116269, XrefRangeEnd = 116274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkateboardCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkateboardCamera>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x000E4518 File Offset: 0x000E2718
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x000E4554 File Offset: 0x000E2754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116274, RefRangeEnd = 116275, XrefRangeStart = 116274, XrefRangeEnd = 116274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x000E4590 File Offset: 0x000E2790
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SkateboardCamera.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x000E45CC File Offset: 0x000E27CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 116304, RefRangeEnd = 116305, XrefRangeStart = 116275, XrefRangeEnd = 116304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkateboardCamera.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00014392 File Offset: 0x00012592
		public SkateboardCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x0600243F RID: 9279 RVA: 0x000E4600 File Offset: 0x000E2800
		// (set) Token: 0x06002440 RID: 9280 RVA: 0x0001439B File Offset: 0x0001259B
		public unsafe static float followDelta
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_followDelta, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_followDelta, (void*)(&value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002441 RID: 9281 RVA: 0x000E461C File Offset: 0x000E281C
		// (set) Token: 0x06002442 RID: 9282 RVA: 0x000143A9 File Offset: 0x000125A9
		public unsafe static float yMinLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_yMinLimit, (void*)(&value));
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x000E4638 File Offset: 0x000E2838
		// (set) Token: 0x06002444 RID: 9284 RVA: 0x000143B7 File Offset: 0x000125B7
		public unsafe static float manualOverrideTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideTime, (void*)(&value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x000E4654 File Offset: 0x000E2854
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x000143C5 File Offset: 0x000125C5
		public unsafe static float manualOverrideReturnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_manualOverrideReturnTime, (void*)(&value));
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x000E4670 File Offset: 0x000E2870
		// (set) Token: 0x06002448 RID: 9288 RVA: 0x000143D3 File Offset: 0x000125D3
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x000E468C File Offset: 0x000E288C
		// (set) Token: 0x0600244A RID: 9290 RVA: 0x000143E1 File Offset: 0x000125E1
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x0600244B RID: 9291 RVA: 0x000E46A8 File Offset: 0x000E28A8
		// (set) Token: 0x0600244C RID: 9292 RVA: 0x000143EF File Offset: 0x000125EF
		public unsafe static float yMaxLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SkateboardCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SkateboardCamera.NativeFieldInfoPtr_yMaxLimit, (void*)(&value));
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600244D RID: 9293 RVA: 0x000E46C4 File Offset: 0x000E28C4
		// (set) Token: 0x0600244E RID: 9294 RVA: 0x000143FD File Offset: 0x000125FD
		public unsafe Transform cameraOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x0600244F RID: 9295 RVA: 0x000E46F4 File Offset: 0x000E28F4
		// (set) Token: 0x06002450 RID: 9296 RVA: 0x0001441C File Offset: 0x0001261C
		public unsafe float CameraFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraFollowSpeed)) = value;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002451 RID: 9297 RVA: 0x000E471C File Offset: 0x000E291C
		// (set) Token: 0x06002452 RID: 9298 RVA: 0x00014437 File Offset: 0x00012637
		public unsafe float HorizontalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_HorizontalOffset)) = value;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002453 RID: 9299 RVA: 0x000E4744 File Offset: 0x000E2944
		// (set) Token: 0x06002454 RID: 9300 RVA: 0x00014452 File Offset: 0x00012652
		public unsafe float VerticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_VerticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_VerticalOffset)) = value;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06002455 RID: 9301 RVA: 0x000E476C File Offset: 0x000E296C
		// (set) Token: 0x06002456 RID: 9302 RVA: 0x0001446D File Offset: 0x0001266D
		public unsafe float CameraDownAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_CameraDownAngle)) = value;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002457 RID: 9303 RVA: 0x000E4794 File Offset: 0x000E2994
		// (set) Token: 0x06002458 RID: 9304 RVA: 0x00014488 File Offset: 0x00012688
		public unsafe float FOVMultiplier_MinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MinSpeed)) = value;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002459 RID: 9305 RVA: 0x000E47BC File Offset: 0x000E29BC
		// (set) Token: 0x0600245A RID: 9306 RVA: 0x000144A3 File Offset: 0x000126A3
		public unsafe float FOVMultiplier_MaxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplier_MaxSpeed)) = value;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x0600245B RID: 9307 RVA: 0x000E47E4 File Offset: 0x000E29E4
		// (set) Token: 0x0600245C RID: 9308 RVA: 0x000144BE File Offset: 0x000126BE
		public unsafe float FOVMultiplierChangeRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_FOVMultiplierChangeRate)) = value;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x0600245D RID: 9309 RVA: 0x000E480C File Offset: 0x000E2A0C
		// (set) Token: 0x0600245E RID: 9310 RVA: 0x000144D9 File Offset: 0x000126D9
		public unsafe Skateboard board
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_board);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Skateboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_board), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x0600245F RID: 9311 RVA: 0x000E483C File Offset: 0x000E2A3C
		// (set) Token: 0x06002460 RID: 9312 RVA: 0x000144F8 File Offset: 0x000126F8
		public unsafe float currentFovMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_currentFovMultiplier)) = value;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06002461 RID: 9313 RVA: 0x000E4864 File Offset: 0x000E2A64
		// (set) Token: 0x06002462 RID: 9314 RVA: 0x00014513 File Offset: 0x00012713
		public unsafe bool cameraReversed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraReversed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraReversed)) = value;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06002463 RID: 9315 RVA: 0x000E488C File Offset: 0x000E2A8C
		// (set) Token: 0x06002464 RID: 9316 RVA: 0x0001452E File Offset: 0x0001272E
		public unsafe bool cameraAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraAdjusted)) = value;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06002465 RID: 9317 RVA: 0x000E48B4 File Offset: 0x000E2AB4
		// (set) Token: 0x06002466 RID: 9318 RVA: 0x00014549 File Offset: 0x00012749
		public unsafe float timeSinceCameraManuallyAdjusted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted)) = value;
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x000E48DC File Offset: 0x000E2ADC
		// (set) Token: 0x06002468 RID: 9320 RVA: 0x00014564 File Offset: 0x00012764
		public unsafe float orbitDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_orbitDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_orbitDistance)) = value;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x000E4904 File Offset: 0x000E2B04
		// (set) Token: 0x0600246A RID: 9322 RVA: 0x0001457F File Offset: 0x0001277F
		public unsafe Vector3 lastFrameCameraOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastFrameCameraOffset)) = value;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x000E492C File Offset: 0x000E2B2C
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x0001459A File Offset: 0x0001279A
		public unsafe Vector3 lastManualOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastManualOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_lastManualOffset)) = value;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x000E4954 File Offset: 0x000E2B54
		// (set) Token: 0x0600246E RID: 9326 RVA: 0x000145B5 File Offset: 0x000127B5
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x000E4984 File Offset: 0x000E2B84
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x000145D4 File Offset: 0x000127D4
		public unsafe Transform cameraDolly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraDolly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_cameraDolly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x000E49B4 File Offset: 0x000E2BB4
		// (set) Token: 0x06002472 RID: 9330 RVA: 0x000145F3 File Offset: 0x000127F3
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x000E49DC File Offset: 0x000E2BDC
		// (set) Token: 0x06002474 RID: 9332 RVA: 0x0001460E File Offset: 0x0001280E
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002475 RID: 9333 RVA: 0x000E4A04 File Offset: 0x000E2C04
		// (set) Token: 0x06002476 RID: 9334 RVA: 0x00014629 File Offset: 0x00012829
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x000E4A2C File Offset: 0x000E2C2C
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x00014644 File Offset: 0x00012844
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkateboardCamera.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeFieldInfoPtr_followDelta;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideTime;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeFieldInfoPtr_manualOverrideReturnTime;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeFieldInfoPtr_cameraOrigin;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeFieldInfoPtr_CameraFollowSpeed;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeFieldInfoPtr_HorizontalOffset;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeFieldInfoPtr_VerticalOffset;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeFieldInfoPtr_CameraDownAngle;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplier_MinSpeed;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplier_MaxSpeed;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeFieldInfoPtr_FOVMultiplierChangeRate;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeFieldInfoPtr_board;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeFieldInfoPtr_currentFovMultiplier;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeFieldInfoPtr_cameraReversed;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeFieldInfoPtr_cameraAdjusted;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceCameraManuallyAdjusted;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeFieldInfoPtr_orbitDistance;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeFieldInfoPtr_lastFrameCameraOffset;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeFieldInfoPtr_lastManualOffset;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x04001816 RID: 6166
		private static readonly IntPtr NativeFieldInfoPtr_cameraDolly;

		// Token: 0x04001817 RID: 6167
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x04001818 RID: 6168
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x04001819 RID: 6169
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400181A RID: 6170
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400181B RID: 6171
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x0400181C RID: 6172
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400181D RID: 6173
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400181E RID: 6174
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x0400181F RID: 6175
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_1;

		// Token: 0x04001820 RID: 6176
		private static readonly IntPtr NativeMethodInfoPtr_CheckForClick_Private_Void_1;

		// Token: 0x04001821 RID: 6177
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_1;

		// Token: 0x04001822 RID: 6178
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCamera_Private_Void_1;

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFOV_Private_Void_1;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetCameraPosition_Private_Vector3_0;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeMethodInfoPtr_LimitCameraPosition_Private_Vector3_Vector3_0;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
